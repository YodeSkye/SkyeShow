
Imports System.Diagnostics

Partial Friend Class VidList

	'Declarations
	Private mMove As Boolean = False
	Private mOffset, mPosition As Point
	Private IsGettingData As Boolean = False
	Private ItemIndex As Integer = 0
	Private GroupIndex As Integer = 0

	'Form Events
	Friend Sub New()
		InitializeComponent()
		AddHandler Me.Disposed, AddressOf frmDisposed
		Me.Text = My.Application.Info.Title + " Video File List"
	End Sub
	Private Sub FrmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
		GetData()
	End Sub
	Private Sub FrmSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
		Me.lvVideoList.Columns(0).Width = Me.lvVideoList.Width - 4
	End Sub
	Private Sub FrmDisposed(ByVal sender As Object, ByVal e As EventArgs)
		My.App.FrmMain.ToggleContextMenu()
		My.App.frmVidList = Nothing
	End Sub
	Private Sub FrmMouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown 'Only needed on forms with no title bar, or when you want to move by dragging form contents
		Me.lvVideoList.Focus()

		If e.Button = MouseButtons.Left Then
			mMove = True
			mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
		End If
	End Sub
	Private Sub FrmMouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove 'Only needed on forms with no title bar, or when you want to move by dragging form contents
		If mMove Then
			mPosition = Control.MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			CheckMove(mPosition)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp 'Only needed on forms with no title bar, or when you want to move by dragging form contents
		mMove = False
	End Sub
	Private Sub FrmMove(sender As Object, e As EventArgs) Handles MyBase.Move 'Only needed on a form with a title bar
		If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location) 'Need WindowState check if allowing Maximize/Restore functions(built-in or manual)
	End Sub

	'Control Events
	Private Sub LVVideoListKeyDown(sender As Object, e As KeyEventArgs) Handles lvVideoList.KeyDown
		'My.Debug.ShowMessage(My.SkyeShow.Mode.Videos, "VideoListPreviewKeyDown", Me.lvVideoList.Groups(1).Items(0).Index.ToString)
		Select Case e.KeyCode
			Case Keys.Escape : Close()
			Case Keys.F5 : GetData()
			Case Keys.Enter
				If e.SuppressKeyPress Then
					If e.Shift Then : SearchFromTextBox(True)
					Else : SearchFromTextBox()
					End If
				Else : PlayVideo()
				End If
			Case Keys.PageUp
				If e.Shift Then
					GroupIndex -= 1
					SetGroupIndex()
					e.SuppressKeyPress = True
				End If
			Case Keys.PageDown
				If e.Shift Then
					GroupIndex += 1
					SetGroupIndex()
					e.SuppressKeyPress = True
				End If
			Case Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z
				If lvVideoList.SelectedIndices.Count = 1 Then
					Dim index As Integer = -1
					If e.Shift Then
						If Not lvVideoList.SelectedIndices(0) = 0 Then index = SearchByKey(lvVideoList.SelectedIndices(0), e.KeyCode, True)
						If index = -1 Then index = SearchByKey(My.VideoFiles.Count, e.KeyCode, True)
					Else
						If Not lvVideoList.SelectedIndices(0) = My.VideoFiles.Count - 1 Then index = SearchByKey(lvVideoList.SelectedIndices(0), e.KeyCode)
						If index = -1 Then index = SearchByKey(-1, e.KeyCode)
					End If
					If Not index = -1 Then
						ItemIndex = index
						SetSelectedItem()
					End If
				End If
				e.SuppressKeyPress = True
			Case Keys.F3
				If e.Shift Then : SearchFromTextBox(True)
				Else : SearchFromTextBox()
				End If
				e.SuppressKeyPress = True
		End Select
	End Sub
	Private Sub LVVideoListDoubleClick(sender As Object, e As EventArgs) Handles lvVideoList.DoubleClick
		PlayVideo()
	End Sub
	Private Sub LVVideoListSelectedIndexChanged(sender As Object, e As EventArgs) Handles lvVideoList.SelectedIndexChanged
		If lvVideoList.SelectedItems.Count = 1 Then
			For index As Integer = 0 To My.vidFolders.Count - 1
				If My.VideoFiles(lvVideoList.SelectedIndices(0)).Path.StartsWith(My.vidFolders(index).SearchPath) Then
					GroupIndex = index + 1 'To adjust for manual group at index 0
					Exit For
				End If
				GroupIndex = 0
			Next
			btnGroup.Text = lvVideoList.Groups(GroupIndex).Header
		End If
	End Sub
	Private Sub LVVideoListItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvVideoList.ItemCheck
		If Not IsGettingData Then e.NewValue = e.CurrentValue
	End Sub
	Private Sub TxBxSearchForTextKeyDown(sender As Object, e As KeyEventArgs) Handles txbxSearchForText.KeyDown
		Select Case e.KeyCode
			Case Keys.F3, Keys.Enter
				If e.KeyCode = Keys.Enter Then e.SuppressKeyPress = True
				LVVideoListKeyDown(sender, e)
				Me.lvVideoList.Focus()
			Case Keys.A : If e.Control Then Me.txbxSearchForText.SelectAll()
		End Select
	End Sub
	Private Sub BtnEnter(sender As Object, e As EventArgs) Handles btnRefresh.Enter, btnGroup.Enter
		lvVideoList.Focus()
	End Sub
	Private Sub BtnRefreshClick(sender As Object, e As EventArgs) Handles btnRefresh.Click
		GetData()
	End Sub
	Private Sub BtnGroupClick(sender As Object, e As EventArgs) Handles btnGroup.Click
		Select Case My.Computer.Keyboard.ShiftKeyDown
			Case True : GroupIndex -= 1
			Case False : GroupIndex += 1
		End Select
		SetGroupIndex()
	End Sub
	Private Sub BtnSearchForTextClick(sender As Object, e As EventArgs) Handles btnSearchForText.Click
		SearchFromTextBox()
	End Sub

	'Procedures
	Public Sub GetData(Optional err As Boolean = False)
		IsGettingData = True
		Me.btnRefresh.Enabled = False
		If Not err AndAlso My.App.FrmVidsVisible Then My.App.FrmVids.TogglePlayState(True)
		Dim StartTime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
		If Me.lvVideoList.SelectedIndices.Count = 1 Then ItemIndex = Me.lvVideoList.SelectedIndices(0)
		'Begin Update ListView
		Me.lvVideoList.BeginUpdate()
		Me.lvVideoList.Items.Clear()
		Me.lvVideoList.Groups.Clear()
		Dim lvi As ListViewItem
		Dim group As Integer
		Dim groups As New Collections.Generic.List(Of String) From {"Manual"}
		Me.lvVideoList.Groups.Add("Manual", "Manually Added")
		For Each folder As My.App.VideoFolderType In My.App.vidFolders
			groups.Add(folder.Path)
			Me.lvVideoList.Groups.Add(folder.Path, folder.Path)
		Next
		For Each file As My.App.VideoFileType In My.App.VideoFiles
			group = 0
			For Each folder As My.App.VideoFolderType In My.App.vidFolders
				If file.Path.StartsWith(folder.Path) Then group = groups.IndexOf(folder.Path)
			Next
			If group = 0 Then : lvi = New ListViewItem(file.Path, Me.lvVideoList.Groups(group))
			Else : lvi = New ListViewItem(file.Path.Remove(0, groups(group).Length + 1), Me.lvVideoList.Groups(group))
			End If
			If file.Viewed Then lvi.Checked = True
			If Not file.Enabled Then
				lvi.Font = New Font(Me.lvVideoList.Font, FontStyle.Italic)
				lvi.ForeColor = Color.Gray
			End If
			If Not file.Enabled Then
				lvi.ToolTipText = "Disabled"
				If Not file.State = My.App.VideoFileState.Valid Then lvi.ToolTipText += " (" + file.State.ToString + ")"
			End If
			lvi.SubItems.Add(file.State.ToString)
			Me.lvVideoList.Items.Add(lvi)
		Next
		lvi = Nothing
		groups.Clear()
		groups = Nothing
		If ItemIndex > Me.lvVideoList.Items.Count - 1 Then ItemIndex = Me.lvVideoList.Items.Count - 1
		If Not My.App.VideoFiles(ItemIndex).Enabled Then ItemIndex = My.App.VideoFilesFindFirstEnabled
		If ItemIndex < 0 Then ItemIndex = 0
		SetSelectedItem()
		Me.lvVideoList.EndUpdate()
		'End Update ListView
		Me.lvVideoList.EnsureVisible(ItemIndex)
		My.App.WriteToLog("Video List View Generated In " + Skye.Common.GenerateLogTime(StartTime, My.Computer.Clock.LocalTime.TimeOfDay))
		If Not err AndAlso My.App.FrmVidsVisible Then My.App.FrmVids.TogglePlayState()
		Me.btnRefresh.Enabled = True
		IsGettingData = False
	End Sub
	Private Sub PlayVideo()
		If Me.lvVideoList.SelectedIndices.Count = 1 Then
			If My.App.VideoFiles(Me.lvVideoList.SelectedIndices(0)).State = My.App.VideoFileState.DisplayError Then
				My.App.VideoFiles(Me.lvVideoList.SelectedIndices(0)) = My.App.VideoFileReEnable(Me.lvVideoList.SelectedIndices(0))
				My.App.FrmMain.UpdateSettings()
			End If
			If My.App.VideoFiles(Me.lvVideoList.SelectedIndices(0)).Enabled Then
				Debug.Print("PlayVideo --> " + Me.lvVideoList.SelectedIndices(0).ToString)
				My.App.VideoIndex = Me.lvVideoList.SelectedIndices(0)
				If My.App.FrmVidsVisible Then
					My.App.FrmVids.NextVideo(My.App.PlayOption.BySelection)
				Else
					My.App.ShowVideos(True)
					My.App.FrmMain.ToggleContextMenu()
				End If
			End If
		End If
	End Sub
	Private Sub SearchFromTextBox(Optional reverse As Boolean = False)
		If Me.lvVideoList.SelectedIndices.Count = 1 AndAlso Not String.IsNullOrEmpty(Me.txbxSearchForText.Text) Then
			Dim index As Integer = -1
			If reverse Then
				If Not Me.lvVideoList.SelectedIndices(0) = 0 Then index = SearchForText(Me.lvVideoList.SelectedIndices(0), Me.txbxSearchForText.Text, True)
				If index = -1 Then index = SearchForText(My.App.VideoFiles.Count, Me.txbxSearchForText.Text, True)
			Else
				If Not Me.lvVideoList.SelectedIndices(0) = My.App.VideoFiles.Count - 1 Then index = SearchForText(Me.lvVideoList.SelectedIndices(0), Me.txbxSearchForText.Text)
				If index = -1 Then index = SearchForText(-1, Me.txbxSearchForText.Text)
			End If
			If Not index = -1 Then
				ItemIndex = index
				SetSelectedItem
			End If
		End If
	End Sub
	Private Sub SetGroupIndex()
		If Me.lvVideoList.Groups(0).Items.Count = 0 Then 'Adjusts for 'Manual' Group
			If GroupIndex < 1 Then GroupIndex = Me.lvVideoList.Groups.Count - 1
			If GroupIndex > Me.lvVideoList.Groups.Count - 1 Then GroupIndex = 1
		Else
			If GroupIndex < 0 Then GroupIndex = Me.lvVideoList.Groups.Count - 1
			If GroupIndex > Me.lvVideoList.Groups.Count - 1 Then GroupIndex = 0
		End If
		Try
			ItemIndex = Me.lvVideoList.Groups(GroupIndex).Items(0).Index
			SetSelectedItem
		Catch : End Try
	End Sub
	Private Sub SetSelectedItem()
		Me.lvVideoList.SelectedIndices.Add(ItemIndex)
		Me.lvVideoList.Items(ItemIndex).Focused = True
		Me.lvVideoList.EnsureVisible(ItemIndex)
	End Sub
	Private Sub CheckMove(ByRef location As Point)
		If location.X + Me.Width > My.Computer.Screen.WorkingArea.Right Then location.X = My.Computer.Screen.WorkingArea.Right - Me.Width
		If location.Y + Me.Height > My.Computer.Screen.WorkingArea.Bottom Then location.Y = My.Computer.Screen.WorkingArea.Bottom - Me.Height
		If location.X < My.Computer.Screen.WorkingArea.Left Then location.X = My.Computer.Screen.WorkingArea.Left
		If location.Y < My.Computer.Screen.WorkingArea.Top Then location.Y = My.Computer.Screen.WorkingArea.Top
	End Sub
	Private Function SearchByKey(startindex As Integer, key As Keys, Optional reverse As Boolean = False) As Integer
		For index As Integer = CType(IIf(reverse, startindex - 1, startindex + 1), Integer) To CType(IIf(reverse, 0, My.App.VideoFiles.Count - 1), Integer) Step CType(IIf(reverse, -1, 1), Integer)
			If My.App.VideoFiles(index).Enabled AndAlso My.App.VideoFiles(index).SearchName.StartsWith(key.ToString, StringComparison.CurrentCultureIgnoreCase) Then
				Return index
			End If
		Next
		Return -1
	End Function
	Private Function SearchForText(startindex As Integer, text As String, Optional reverse As Boolean = False) As Integer
		For index As Integer = CType(IIf(reverse, startindex - 1, startindex + 1), Integer) To CType(IIf(reverse, 0, My.App.VideoFiles.Count - 1), Integer) Step CType(IIf(reverse, -1, 1), Integer)
			If My.App.VideoFiles(index).Enabled AndAlso My.App.VideoFiles(index).Path.Contains(text, StringComparison.OrdinalIgnoreCase) Then
				Return index
			End If
		Next
		Return -1
	End Function

End Class
