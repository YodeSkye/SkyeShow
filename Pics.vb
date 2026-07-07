
Imports System.Diagnostics
Imports SkyeShow.My

Partial Friend Class Pics

	'Declarations
	Private WithEvents TimerImageAdvance As New Timer
	Private WithEvents TimerHideMouse As New Timer
	Private WithEvents TimerQuickHide As New Timer
	Private WithEvents TimerDeleteImage As New Timer
	Private mMove As Boolean = False
	Private mMoveMode As Byte = 0 '0=Select, 1=Move, 2=ReSize
	Private mResize As Boolean = False
	Private mStartSize As Int16
	Private mHide As Boolean = False
	Private mOffset, mPosition, mHidePosition, mStartLocation, mLastLocation, mHoverLocation As Point
	Private timerImageAdvanceCount As Integer
	Private DeleteImageConfirm As Boolean = False
	Private FullScreen As Boolean = False
	Private imageRaw As Image
	Private imageDrawn As Bitmap
	Private imageProcessor As Graphics

	'Form Events
	Friend Sub New()
		'Initialize Globals
		'Initialize Locals
		TimerImageAdvance.Interval = 1000
		TimerHideMouse.Interval = 5000
		TimerDeleteImage.Interval = 5000
		'Initialize Form
		InitializeComponent()
		AddHandler Me.Disposed, AddressOf frmDisposed
		AddHandler Me.LostFocus, AddressOf frmLostFocus
		Me.Text = My.Application.Info.Title + " Image"
		UpdateDeleteImageConfirm()
	End Sub
	Friend Sub FrmPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
		My.App.HideBalloon()
		If e.Alt Then
		ElseIf e.Control Then
		ElseIf e.Shift Then
			Select Case e.KeyCode
				Case Keys.Delete : QuickHide(False)
			End Select
		Else
			Select Case e.KeyCode
				Case Keys.Escape : ToggleFullScreen()
				Case Keys.End : Me.Close()
				Case Keys.Up : ToggleTimer()
				Case Keys.Left : NextImage(My.App.PlayOption.Backward)
				Case Keys.Right : NextImage(My.App.PlayOption.Forward)
				Case Keys.Down : NextImage(My.App.PlayOption.Random)
				Case Keys.Space : NextImage(My.App.PlayOption.Forward)
				Case Keys.OemQuestion : ShowFileInfo()
				Case Keys.PageUp
					If Not FullScreen Then
						My.App.picLocationMode = CType(My.App.picLocationMode - 1, My.App.LocationMode)
						If My.App.picLocationMode < 0 Then My.App.picLocationMode = CType(My.App.LocationModeCount, App.LocationMode) 'My.App.LocationMode.Manual
						If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
						DrawImage()
					End If
				Case Keys.PageDown
					If Not FullScreen Then
						My.App.picLocationMode = CType(My.App.picLocationMode + 1, My.App.LocationMode)
						If My.App.picLocationMode > My.App.LocationModeCount Then My.App.picLocationMode = 0
						If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
						DrawImage()
					End If
				Case Keys.Home : QuickRestore()
				Case Keys.Delete : QuickHide()
				Case Keys.Insert : QuickShift()
			End Select
		End If
	End Sub
	Private Sub FrmLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		SetTimerAutoStart()
		If My.App.picPlayMode = My.App.PlayMode.LinearWithRandomStart Then My.App.ImageIndex = Skye.Common.GetRandom(0, My.App.ImageFiles.Count - 1, My.App.ImageIndex)
		NextImage(My.App.PlayOption.ByPlayMode)
	End Sub
	Private Sub FrmClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
		My.App.HideBalloon()
		ShowCursor()
		RemoveHandler Me.LostFocus, AddressOf frmLostFocus
		TimerImageAdvance.Stop()
		TimerHideMouse.Stop()
		TimerQuickHide.Stop()
		DisposeGraphics()
		My.App.ImageIsOnTop = True
		If My.App.FrmMain.BackgroundworkerGetFiles.IsBusy Then My.App.FrmMain.cmiViewPics.Enabled = False
		If My.App.FrmMain.Visible Then My.App.FrmMain.Focus()
	End Sub
	Private Sub FrmDisposed(ByVal sender As Object, ByVal e As EventArgs)
		My.App.FrmMain.ToggleContextMenu()
		'		My.SkyeShow.SetScreenSaverWatcher
		My.App.frmPics = Nothing
	End Sub
	Private Sub FrmLostFocus(ByVal sender As Object, ByVal e As EventArgs)
		If FullScreen And Not My.App.picLockFullScreen And Not My.App.BalloonLoading And Not My.App.IgnoreFocusChange Then ToggleFullScreen()
	End Sub
	Private Sub FrmKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
		If e.Control Then : mMoveMode = 1
		ElseIf e.Shift Then : mMoveMode = 2
		Else : mMoveMode = 0
		End If
	End Sub
	Private Sub FrmKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
		If Not e.Control Or e.Shift Then
			mMoveMode = 0
			mMove = False
			mResize = False
		End If
	End Sub
	Private Sub FrmMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picbx.MouseDown, lblCountdown.MouseDown
		If e.Button = MouseButtons.Left Then
			If Not My.ImageIsOnTop Then QuickShow()

			If e.Clicks = 2 Then : ToggleFullScreen()
			ElseIf Not FullScreen Then
				If mMoveMode = 1 Then
					Cursor = Cursors.UpArrow
					mStartLocation = Location
					mLastLocation = Location
					If sender Is lblCountdown Then
						mOffset = New Point(-(lblCountdown.Left + e.X), -(lblCountdown.Top + e.Y))
						mLastLocation.Offset(lblCountdown.Left + e.X, lblCountdown.Top + e.Y)
					Else
						mOffset = New Point(-e.X, -e.Y)
						mLastLocation.Offset(e.Location)
					End If
					mMove = True
				ElseIf mMoveMode = 2 Then
					Cursor = Cursors.SizeAll
					mResize = False
					mStartSize = My.picMaxSize
					mLastLocation = Location
					If sender Is lblCountdown Then : mLastLocation.Offset(lblCountdown.Left + e.X, lblCountdown.Top + e.Y)
					Else : mLastLocation.Offset(e.Location)
					End If
					mMove = True
				End If
			End If
		End If
	End Sub
	Private Sub FrmMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picbx.MouseMove, lblCountdown.MouseMove
		Debug.Print("frmMouseMove")
		If mMove Then
			If mMoveMode = 1 Then
				mPosition = Control.MousePosition
				mPosition.Offset(mOffset.X, mOffset.Y)
				CheckMove(mPosition)
				Location = mPosition
				SetImageTimerCountdown()
			ElseIf mMoveMode = 2 Then
				If sender Is Me.lblCountdown Then : My.App.picMaxSize += CType(Me.Left + (Me.lblCountdown.Left + e.X) - mLastLocation.X, Short)
				Else : My.App.picMaxSize += CType(Me.Left + e.X - mLastLocation.X, Short)
				End If
				If mStartSize <> My.App.picMaxSize Then mResize = True
				If My.App.picMaxSize > Int(My.Computer.Screen.Bounds.Width / 2) Then : My.App.picMaxSize = CType(Int(My.Computer.Screen.Bounds.Width / 2), Short)
				ElseIf My.App.picMaxSize < Int(My.Computer.Screen.Bounds.Width / 50) Then : My.App.picMaxSize = CType(Int(My.Computer.Screen.Bounds.Width / 50), Short)
				End If
				mLastLocation = Me.Location
				If sender Is Me.lblCountdown Then : mLastLocation.Offset(Me.lblCountdown.Left + e.X, Me.lblCountdown.Top + e.Y)
				Else : mLastLocation.Offset(e.Location)
				End If
				DrawImage()
				Me.Refresh()
			End If
		Else
			If mHide Then : If Not mHidePosition = Control.MousePosition Then ShowCursor()
			Else
				If FullScreen AndAlso My.App.appHideCursorWhenFullscreen AndAlso mHoverLocation = e.Location Then
					If Not TimerHideMouse.Enabled Then
						TimerHideMouse.Start()
						Debug.Print("frmMouseMove--> Hide Timer Started")
					End If
				Else
					If TimerHideMouse.Enabled Then
						TimerHideMouse.Stop()
						Debug.Print("frmMouseMove--> Hide Timer STOPPED")
					End If
					mHoverLocation = e.Location
				End If
			End If
		End If
	End Sub
	Private Sub FrmMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picbx.MouseUp, lblCountdown.MouseUp
		Debug.Print("frmMouseUp")
		My.App.HideBalloon()
		If mMove Then
			mMove = False
			If mMoveMode = 1 Then
				If mStartLocation <> Me.Location Then
					If Me.Location.X > My.Computer.Screen.WorkingArea.Left + (My.Computer.Screen.WorkingArea.Width * (My.App.LocationModeManualAnchorThreshold / 100)) Then : My.App.picLocation.X = Me.Location.X + Me.Width
					Else : My.App.picLocation.X = Me.Location.X
					End If
					If Me.Location.Y > My.Computer.Screen.WorkingArea.Top + (My.Computer.Screen.WorkingArea.Height * (My.App.LocationModeManualAnchorThreshold / 100)) Then : My.App.picLocation.Y = Me.Location.Y + Me.Height
					Else : My.App.picLocation.Y = Me.Location.Y
					End If
					My.App.picLocationMode = My.App.LocationMode.Manual
					My.App.FrmMain.UpdateSettings()
				End If
			ElseIf mMoveMode = 2 Then : If mResize Then Me.cmPics.Close()
			End If
			Me.ResetCursor()
		ElseIf mHide Then : ShowCursor()
		ElseIf e.Button = MouseButtons.Left AndAlso sender Is Me.lblCountdown AndAlso My.App.MouseInBounds(DirectCast(Me.lblCountdown, Control), New Point(e.X, e.Y)) Then : ToggleTimer()
		End If
	End Sub

	'Control Events
	Private Sub CMPicsClosing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles cmPics.Closing
		If cmPics.Items(cmPics.Items.IndexOfKey(cmiDeleteImage.Name)).Selected Then : If Not DeleteImageConfirm Then e.Cancel = True
		Else : SetDeleteImageConfirm(True)
		End If
	End Sub
	Private Sub CMIFullScreenMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiFullScreen.MouseUp
		If e.Button = MouseButtons.Left Then ToggleFullScreen()
	End Sub
	Private Sub CMIQuickHideMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiQuickHide.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				If Me.cmiQuickHide.Checked Then : QuickShow()
				Else : QuickHide()
				End If
			Case MouseButtons.Right
				If Me.cmiQuickHide.Checked And Not Me.TimerQuickHide.Enabled Then : QuickShow()
				Else : QuickHide(False)
				End If
		End Select
	End Sub
	Private Sub CMIQuickShiftMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiQuickShift.MouseUp
		If e.Button = MouseButtons.Left Then QuickShift()
	End Sub
	Private Sub CMIQuickRestoreMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiQuickRestore.MouseUp
		If e.Button = MouseButtons.Left Then QuickRestore()
	End Sub
	Private Sub CMIQuickTimerMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiTimer.MouseUp
		If e.Button = MouseButtons.Left Then ToggleTimer()
	End Sub
	Private Sub CMIAdvanceMouseUp(sender As Object, e As MouseEventArgs) Handles cmiAdvance.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				If My.Computer.Keyboard.CtrlKeyDown Then : NextImage(My.App.PlayOption.Random)
				Else : NextImage(My.App.PlayOption.Forward)
				End If
			Case MouseButtons.Right
				If My.Computer.Keyboard.CtrlKeyDown Then : NextImage(My.App.PlayOption.Previous)
				Else : NextImage(My.App.PlayOption.Backward)
				End If
		End Select
	End Sub
	Private Sub CMIShowFileInfoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiShowFileInfo.MouseUp
		If e.Button = MouseButtons.Left Then ShowFileInfo()
	End Sub
	Private Sub CMIViewImageMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiViewImage.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				If App.ViewFile(App.ImageFiles(App.ImageIndex)) And FullScreen Then ToggleFullScreen()
				NextImage(App.PlayOption.ByPlayMode)
			Case MouseButtons.Right
				If App.OpenFileLocation(App.ImageFiles(App.ImageIndex)) And FullScreen Then ToggleFullScreen()
		End Select
	End Sub
	Private Sub CMIDeleteImageMouseUp(sender As Object, e As MouseEventArgs) Handles cmiDeleteImage.MouseUp
		If e.Button = MouseButtons.Left Then
			If DeleteImageConfirm Then
				Dim file As String = My.App.ImageFiles.Item(My.App.ImageIndex)
				My.App.ImageFiles.RemoveAt(My.App.ImageIndex)
				My.App.ImageRepeatList.Remove(file)
				NextImage(My.App.PlayOption.BySelection)
				My.App.ImageIndexPrevious = -1
				My.App.DeleteFile(file)
				My.App.FrmMain.UpdateSettings()
			End If
			SetDeleteImageConfirm()
		Else
			SetDeleteImageConfirm(True)
		End If
	End Sub
	Private Sub CMICloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiClose.MouseUp
		If e.Button = MouseButtons.Left Then Me.Close()
	End Sub

	'Handlers
	Private Sub TimerImageAdvanceTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerImageAdvance.Tick
		Me.timerImageAdvanceCount += 1
		If Me.timerImageAdvanceCount = My.App.picTimerInterval Then
			Me.timerImageAdvanceCount = 0
			SetDeleteImageConfirm(True)
			If Not Me.cmPics.Visible AndAlso Not My.App.BalloonVisible Then NextImage(My.App.PlayOption.ByPlayMode)
		End If
		ShowImageTimerCountdown()
	End Sub
	Private Sub TimerHideMouseTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerHideMouse.Tick
		Debug.Print("timerHideMouseTick")
		Me.TimerHideMouse.Stop()

		If Not (Cursor.Position.X < Me.Left Or Cursor.Position.Y < Me.Top Or Cursor.Position.X >= Me.Left + Me.Width Or Cursor.Position.Y >= Me.Top + Me.Height Or Me.cmPics.Visible) Then
			HideCursor()
		End If
	End Sub
	Private Sub TimerQuickHideTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerQuickHide.Tick
		NextImage(My.App.PlayOption.ByPlayMode)
		QuickShow()
	End Sub
	Private Sub TimerDeleteImageTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerDeleteImage.Tick
		SetDeleteImageConfirm()
	End Sub

	'Procedures
	Friend Sub DrawImage()
		My.App.IgnoreFocusChange = True
		Me.Hide()

		If FullScreen Then
			If imageRaw.Width <= My.Computer.Screen.Bounds.Width And imageRaw.Height <= My.Computer.Screen.Bounds.Height Then
				'Smaller than or equal to Screen Size
				Me.Size = imageRaw.Size
				Select Case My.App.picJustify
					Case My.App.LocationJustify.Left : Me.Left = 0
					Case My.App.LocationJustify.Center : Me.Left = CType(My.Computer.Screen.Bounds.Width / 2 - Me.Width / 2, Integer)
					Case My.App.LocationJustify.Right : Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
				End Select
				Me.Top = CType(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2, Integer)
			ElseIf (imageRaw.Width - My.Computer.Screen.Bounds.Width) / My.Computer.Screen.Bounds.Width >= (imageRaw.Height - My.Computer.Screen.Bounds.Height) / My.Computer.Screen.Bounds.Height Then
				'Adjusted Width larger than or equal to Adjusted Height
				Me.Width = My.Computer.Screen.Bounds.Width
				Me.Height = CType(imageRaw.Height * (My.Computer.Screen.Bounds.Width / imageRaw.Width), Integer)
				Me.Left = 0
				Me.Top = CType(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2, Integer)
			Else
				'Adjusted Height larger than Adjusted Width
				Me.Width = CType(imageRaw.Width * (My.Computer.Screen.Bounds.Height / imageRaw.Height), Integer)
				Me.Height = My.Computer.Screen.Bounds.Height
				Select Case My.App.picJustify
					Case My.App.LocationJustify.Left : Me.Left = 0
					Case My.App.LocationJustify.Center : Me.Left = CType(My.Computer.Screen.Bounds.Width / 2 - Me.Width / 2, Integer)
					Case My.App.LocationJustify.Right : Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
				End Select
				Me.Top = 0
			End If
		Else
			If imageRaw.Width <= My.App.picMaxSize And imageRaw.Height <= My.App.picMaxSize Then
				'Smaller than or equal to MaxSize
				Me.Size = New Size(imageRaw.Width, imageRaw.Height)
			ElseIf imageRaw.Width >= imageRaw.Height Then
				'Landscape or Square, but larger than MaxSize
				Me.Size = New Size(My.App.picMaxSize, CType(imageRaw.Height * (My.App.picMaxSize / imageRaw.Width), Integer))
			Else
				'Portrait, but larger than MaxSize
				Me.Size = New Size(CType(imageRaw.Width * (My.App.picMaxSize / imageRaw.Height), Integer), My.App.picMaxSize)
			End If
			Select Case My.App.picLocationMode
				Case My.App.LocationMode.Manual
					Static locM As New Point
					If My.App.picLocation.X > My.Computer.Screen.WorkingArea.Left + (My.Computer.Screen.WorkingArea.Width * (My.App.LocationModeManualAnchorThreshold / 100)) Then
						locM.X = My.App.picLocation.X - Me.Width
					Else : locM.X = My.App.picLocation.X
					End If
					If My.App.picLocation.Y > My.Computer.Screen.WorkingArea.Top + (My.Computer.Screen.WorkingArea.Height * (My.App.LocationModeManualAnchorThreshold / 100)) Then
						locM.Y = My.App.picLocation.Y - Me.Height
					Else : locM.Y = My.App.picLocation.Y
					End If
					Me.Location = locM
					locM = Nothing
				Case My.App.LocationMode.TopLeft : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Top)
				Case My.App.LocationMode.TopCenterLeft : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top)
				Case My.App.LocationMode.TopCenter : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top)
				Case My.App.LocationMode.TopCenterRight : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top)
				Case My.App.LocationMode.TopRight : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width, My.Computer.Screen.WorkingArea.Top)
				Case My.App.LocationMode.RightCenterTop : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
				Case My.App.LocationMode.RightCenter : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
				Case My.App.LocationMode.RightCenterBottom : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
				Case My.App.LocationMode.BottomRight : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width, My.Computer.Screen.WorkingArea.Bottom - Me.Height)
				Case My.App.LocationMode.BottomCenterRight : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height)
				Case My.App.LocationMode.BottomCenter : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height)
				Case My.App.LocationMode.BottomCenterLeft : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height)
				Case My.App.LocationMode.BottomLeft : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Bottom - Me.Height)
				Case My.App.LocationMode.LeftCenterBottom : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
				Case My.App.LocationMode.LeftCenter : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
				Case My.App.LocationMode.LeftCenterTop : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
				Case My.App.LocationMode.TopLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + My.App.appInsideLocationOffset)
				Case My.App.LocationMode.TopCenterLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.appInsideLocationOffset)
				Case My.App.LocationMode.TopCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.appInsideLocationOffset)
				Case My.App.LocationMode.TopCenterRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.appInsideLocationOffset)
				Case My.App.LocationMode.TopRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + My.App.appInsideLocationOffset)
				Case My.App.LocationMode.RightCenterTopInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
				Case My.App.LocationMode.RightCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
				Case My.App.LocationMode.RightCenterBottomInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
				Case My.App.LocationMode.BottomRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.appInsideLocationOffset)
				Case My.App.LocationMode.BottomCenterRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.appInsideLocationOffset)
				Case My.App.LocationMode.BottomCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.appInsideLocationOffset)
				Case My.App.LocationMode.BottomCenterLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.appInsideLocationOffset)
				Case My.App.LocationMode.BottomLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.appInsideLocationOffset)
				Case My.App.LocationMode.LeftCenterBottomInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
				Case My.App.LocationMode.LeftCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
				Case My.App.LocationMode.LeftCenterTopInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.appInsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
			End Select
			CheckMove(Me.Location)
		End If
		If My.App.ImageFiles(My.App.ImageIndex).EndsWith(".gif", True, Globalization.CultureInfo.CurrentCulture) Then
			'GIF Images
			Me.picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picbx.Image = imageRaw
		Else
			'All Other Image Types
			Me.picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
			imageDrawn = New Bitmap(imageRaw, Me.Size)
			imageProcessor = Graphics.FromImage(imageDrawn)
			imageProcessor.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighQuality
			imageProcessor.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			imageProcessor.DrawImage(imageRaw, 0, 0, Me.Width, Me.Height)
			Me.picbx.Image = imageDrawn
		End If
		SetImageTimerCountdown()
		If Me.cmiQuickHide.Checked Then
			Me.cmiQuickHide.Checked = False
			Me.cmiQuickHide.ResetForeColor()
			SetTimerAutoStart()
		End If
		Me.Show()
		OnTop(True)
		My.App.IgnoreFocusChange = False
	End Sub
	Friend Sub SetTimer()
		Me.TimerImageAdvance.Stop()
		If Me.timerImageAdvanceCount > 0 Then Me.timerImageAdvanceCount = 0
		ShowImageTimerCountdown()

		If My.App.picTimerEnabled Then
			Me.TimerImageAdvance.Start()
			Me.cmiTimer.Checked = True
			Me.cmiTimer.ForeColor = Color.Teal
		Else
			Me.cmiTimer.Checked = False
			Me.cmiTimer.ForeColor = Color.Maroon
		End If
	End Sub
	Friend Sub ToggleTimer()
		My.App.picTimerEnabled = Not My.App.picTimerEnabled
		If My.App.picTimerEnabled Then SetImageTimerCountdown()

		If Me.cmiQuickHide.Checked Then : QuickShow()
		Else : SetTimer()
		End If
		If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
	End Sub
	Friend Sub ToggleFullScreen()
		FullScreen = Not FullScreen
		Me.cmiFullScreen.Checked = Not Me.cmiFullScreen.Checked
		If Not FullScreen Then ShowCursor()
		DrawImage()
	End Sub
	Friend Sub QuickShow()
		DrawImage()
		SetTimerAutoStart()
		SetTimer()
		Me.cmiQuickHide.ResetForeColor()
		Me.cmiQuickHide.Checked = False
	End Sub
	Friend Sub SetImageTimerCountdown()
		If My.App.picTimerCountdown Then
			Me.timerImageAdvanceCount = 0
			Me.lblCountdown.Visible = True
			ShowImageTimerCountdown()
		Else : Me.lblCountdown.Visible = False
		End If
	End Sub
	Friend Sub ShowImageTimerCountdown()
		Me.lblCountdown.SuspendLayout()

		If My.App.picTimerEnabled Then : Me.lblCountdown.Text = (My.App.picTimerInterval - Me.timerImageAdvanceCount).ToString
		Else : Me.lblCountdown.Text = " - "
		End If
		Select Case My.App.picTimerCountdownLocationMode
			Case My.App.LocationMode.TopLeft : Me.lblCountdown.Location = New Point(My.App.ImageTimerCountdownBorderPadding, My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.TopCenterLeft : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.25) - CInt(Me.lblCountdown.Width / 2), My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.TopCenter : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.5) - CInt(Me.lblCountdown.Width / 2), My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.TopCenterRight : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.75) - CInt(Me.lblCountdown.Width / 2), My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.TopRight : Me.lblCountdown.Location = New Point(Me.Width - Me.lblCountdown.Width - My.App.ImageTimerCountdownBorderPadding, My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.RightCenterTop : Me.lblCountdown.Location = New Point(Me.Width - Me.lblCountdown.Width - My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.25) - CInt(Me.lblCountdown.Height / 2))
			Case My.App.LocationMode.RightCenter : Me.lblCountdown.Location = New Point(Me.Width - Me.lblCountdown.Width - My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.5) - CInt(Me.lblCountdown.Height / 2))
			Case My.App.LocationMode.RightCenterBottom : Me.lblCountdown.Location = New Point(Me.Width - Me.lblCountdown.Width - My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.75) - CInt(Me.lblCountdown.Height / 2))
			Case My.App.LocationMode.BottomRight : Me.lblCountdown.Location = New Point(Me.Width - Me.lblCountdown.Width - My.App.ImageTimerCountdownBorderPadding, Me.Height - Me.lblCountdown.Height - My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.BottomCenterRight : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.75) - CInt(Me.lblCountdown.Width / 2), Me.Height - Me.lblCountdown.Height - My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.BottomCenter : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.5) - CInt(Me.lblCountdown.Width / 2), Me.Height - Me.lblCountdown.Height - My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.BottomCenterLeft : Me.lblCountdown.Location = New Point(CInt(Me.Width * 0.25) - CInt(Me.lblCountdown.Width / 2), Me.Height - Me.lblCountdown.Height - My.App.ImageTimerCountdownBorderPadding)
			Case My.App.LocationMode.LeftCenterBottom : Me.lblCountdown.Location = New Point(My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.75) - CInt(Me.lblCountdown.Height / 2))
			Case My.App.LocationMode.LeftCenter : Me.lblCountdown.Location = New Point(My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.5) - CInt(Me.lblCountdown.Height / 2))
			Case My.App.LocationMode.LeftCenterTop : Me.lblCountdown.Location = New Point(My.App.ImageTimerCountdownBorderPadding, CInt(Me.Height * 0.25) - CInt(Me.lblCountdown.Height / 2))
			Case Else : Me.lblCountdown.Location = New Point(My.App.ImageTimerCountdownBorderPadding, Me.Height - Me.lblCountdown.Height - My.App.ImageTimerCountdownBorderPadding)
		End Select
		Me.lblCountdown.ResumeLayout()
	End Sub
	Friend Sub ShowFileInfo()
		On Error Resume Next
		Dim s As String = String.Empty
		Dim i As IO.FileInfo
		i = Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo(My.App.ImageFiles.Item(My.App.ImageIndex))
		s += Skye.Common.FormatFileSize(i.Length, Skye.Common.FormatFileSizeUnits.Auto, 1)
		s += vbCr
		s += Me.imageRaw.Size.Width.ToString + "x" + Me.imageRaw.Size.Height.ToString
		s += " ("
		s += My.App.FormatImageAspectRatio(Me.imageRaw.Size)
		s += ") "
		s += Math.Round(Me.imageRaw.Size.Width * Me.imageRaw.Size.Height / 1000000, 2).ToString + "MP"
		s += vbCr
		s += i.DirectoryName
		My.App.ShowBalloon(Me, My.Resources.Resources.imageImage32, i.Name, s)
	End Sub
	Friend Function IsFullScreen() As Boolean '
		Return FullScreen
	End Function
	Friend Function IsImageAdvanceActive() As Boolean '
		Return TimerImageAdvance.Enabled
	End Function
	Private Sub NextImage(opt As My.App.PlayOption)
		If Not (opt = My.App.PlayOption.Previous AndAlso My.App.ImageIndexPrevious = -1) Then
			DisposeGraphics()
			If My.App.ImageFiles.Count > 0 Then
				Try
					Me.TimerImageAdvance.Stop()

					If opt = My.App.PlayOption.ByPlayMode Then
						Select Case My.App.picPlayMode
							Case My.App.PlayMode.Linear, My.App.PlayMode.LinearWithRandomStart : opt = My.App.PlayOption.Forward
							Case My.App.PlayMode.Random : opt = My.App.PlayOption.Random
						End Select
					End If
					If My.App.ImageRepeatList.Count >= My.App.ImageFiles.Count Then My.App.ImageRepeatList.Clear()
					Do
						Select Case opt
							Case My.App.PlayOption.Forward
								My.App.ImageIndexPrevious = My.App.ImageIndex
								My.App.ImageIndex += 1
								If My.App.ImageIndex > My.App.ImageFiles.Count - 1 Then My.App.ImageIndex = 0
							Case My.App.PlayOption.Backward
								My.App.ImageIndexPrevious = My.App.ImageIndex
								My.App.ImageIndex -= 1
								If My.App.ImageIndex < 0 Then My.App.ImageIndex = My.App.ImageFiles.Count - 1
							Case My.App.PlayOption.Random
								My.App.ImageIndexPrevious = My.App.ImageIndex
								Do : My.App.ImageIndex = Skye.Common.GetRandom(0, My.App.ImageFiles.Count - 1, My.App.ImageIndex)
								Loop Until Not My.App.ImageRepeatList.Contains(My.App.ImageFiles(My.App.ImageIndex))
							Case My.App.PlayOption.BySelection
								My.App.ImageIndexPrevious = My.App.ImageIndex
								If My.App.ImageIndex < 0 Then : My.App.ImageIndex = 0
								ElseIf My.App.ImageIndex > My.App.ImageFiles.Count - 1 Then : My.App.ImageIndex = My.App.ImageFiles.Count - 1
								End If
							Case My.App.PlayOption.Previous : If Not (My.App.ImageIndexPrevious < 0 OrElse My.App.ImageIndexPrevious > My.App.ImageFiles.Count - 1) Then My.App.SwapValues(My.App.ImageIndex, My.App.ImageIndexPrevious)
						End Select
						If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(My.App.ImageFiles.Item(My.App.ImageIndex)) Then : Exit Do
						Else
							My.App.ImageFiles.RemoveAt(My.App.ImageIndex)
							If opt = My.App.PlayOption.Forward Then My.App.ImageIndex -= 1
							If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
						End If
					Loop
					App.WriteToLog(App.ImageIndexLogText)
					imageRaw = Image.FromFile(My.App.ImageFiles.Item(My.App.ImageIndex))
					DrawImage()
					SetTimer()
					If Not My.App.ImageRepeatList.Contains(My.App.ImageFiles(My.App.ImageIndex)) Then
						My.App.ImageRepeatList.Add(My.App.ImageFiles(My.App.ImageIndex))
						My.App.FrmMain.UpdateSettings()
					End If
					'My.Debug.ShowMessage(My.SkyeShow.Tools.Images, "NextImage", "Repeat Count : " + My.SkyeShow.ImageRepeatList.Count.ToString)
				Catch ex As Exception
					My.App.WriteToLog("Image Load Error" + Chr(13) + ex.ToString)
					My.App.SetErrorAlert()
					My.App.ImageFiles.RemoveAt(My.App.ImageIndex)
					My.App.FrmMain.UpdateSettings()
					If My.App.ImageFiles.Count = 0 Then : Me.Close()
					Else : NextImage(My.App.PlayOption.ByPlayMode)
					End If
				End Try
			Else : Me.Close()
			End If
		End If
	End Sub
	Private Sub QuickHide(Optional autorestore As Boolean = True)
		ShowCursor()
		If My.App.picTimerEnabled Then ToggleTimer()
		Me.TimerQuickHide.Stop()
		Me.cmiQuickHide.Checked = True
		If FullScreen Then ToggleFullScreen()
		OnTop(False)
		If autorestore Then
			Me.cmiQuickHide.ForeColor = Color.Goldenrod
			Me.TimerQuickHide.Interval = My.App.picTimerInterval * 1000
			Me.TimerQuickHide.Start()
		Else : Me.cmiQuickHide.ForeColor = Color.Maroon
		End If
	End Sub
	Private Sub QuickShift()
		If Not FullScreen Then
			My.App.picLocationMode = CType(My.App.picLocationMode + 6, My.App.LocationMode)
			'If My.SkyeShow.picLocationMode > My.SkyeShow.LocationMode.Manual Then My.SkyeShow.picLocationMode = CType(My.SkyeShow.picLocationMode - My.SkyeShow.LocationMode.Manual, My.SkyeShow.LocationMode)
			If My.App.picLocationMode > My.App.LocationModeCount Then My.App.picLocationMode = CType(My.App.picLocationMode - My.App.LocationModeCount, My.App.LocationMode)
			If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
			DrawImage()
		End If
	End Sub
	Private Sub QuickRestore()
		ShowCursor()
		If FullScreen Then ToggleFullScreen()
		Me.Hide()
		My.App.FrmMain.RestoreSettings()
		DrawImage()
	End Sub
	Private Sub OnTop(mode As Boolean)
		On Error Resume Next
		If mode Then
			Me.TimerQuickHide.Stop()
			Me.TopMost = True
			My.App.ImageIsOnTop = True
			My.App.FrmMain.AppNotify()
		Else
			Me.SendToBack()
			Me.SendToBack()
			My.App.ImageIsOnTop = False
			My.App.FrmMain.AppNotify()
		End If
	End Sub
	Private Sub SetTimerAutoStart()
		If My.App.picTimerAutoStart And Not My.App.picTimerEnabled Then
			My.App.picTimerEnabled = True
			My.App.FrmMain.UpdateSettings()
		End If
	End Sub
	Private Sub DisposeGraphics()
		On Error Resume Next
		imageProcessor.Dispose()
		imageProcessor = Nothing
		imageDrawn.Dispose()
		imageDrawn = Nothing
		imageRaw.Dispose()
		imageRaw = Nothing
	End Sub
	Private Sub HideCursor()
		If Not mHide AndAlso My.App.appHideCursorWhenFullscreen Then
			mHide = True
			mHidePosition = Control.MousePosition
			Cursor.Hide()
			Debug.Print("HideCursor")
		End If
	End Sub
	Private Sub ShowCursor()
		If mHide Then
			mHide = False
			Cursor.Show()
			Debug.Print("ShowCursor")
		End If
	End Sub
	Private Sub SetDeleteImageConfirm(Optional forcereset As Boolean = False)
		If DeleteImageConfirm Or forcereset Then
			TimerDeleteImage.Stop()
			DeleteImageConfirm = False
		Else
			DeleteImageConfirm = True
			TimerDeleteImage.Start()
		End If
		UpdateDeleteImageConfirm
	End Sub
	Private Sub UpdateDeleteImageConfirm()
		If DeleteImageConfirm Then
			Me.cmiDeleteImage.Text = "Are You Sure?"
			Me.cmiDeleteImage.ForeColor = Color.Maroon
			Me.cmiDeleteImage.Font = New Font(Me.cmiDeleteImage.Font, FontStyle.Bold)
		Else
			Me.cmiDeleteImage.ResetForeColor
			Me.cmiDeleteImage.Text = "Delete Image"
			Me.cmiDeleteImage.Font = New Font(Me.cmiDeleteImage.Font, FontStyle.Regular)
		End If
	End Sub
	Private Sub CheckMove(ByRef location As Point)
		If location.X + Me.Width > My.Computer.Screen.WorkingArea.Right Then location.X = My.Computer.Screen.WorkingArea.Right - Me.Width
		If location.Y + Me.Height > My.Computer.Screen.WorkingArea.Bottom Then location.Y = My.Computer.Screen.WorkingArea.Bottom - Me.Height
		If location.X < My.Computer.Screen.WorkingArea.Left Then location.X = My.Computer.Screen.WorkingArea.Left
		If location.Y < My.Computer.Screen.WorkingArea.Top Then location.Y = My.Computer.Screen.WorkingArea.Top
	End Sub

End Class
