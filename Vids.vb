
Imports LibVLCSharp.Shared
Imports Skye.Contracts
Imports SkyeShow.My

Partial Friend Class Vids

    'Declarations
    Private WithEvents TimerCheckPlayState As New System.Windows.Forms.Timer
    Private WithEvents TimerHideMouse As New Timer
    Private WithEvents TimerQuickHide As New Timer
    Private WithEvents TimerDeleteVideo As New Timer
    Private _VLCHook As App.VLCViewerHook
    Private mMove As Boolean = False
    Private mMoveMode As Byte = 0 '0=Select, 1=Move, 2=ReSize
    Private mResize As Boolean = False
    Private mStartSize As Int16
    Private mHide As Boolean = False
    Private mOffset, mPosition, mHidePosition, mStartLocation, mLastLocation, mHoverLocation As Point
    Private StartUpPlayOption As My.App.PlayOption = My.App.PlayOption.ByPlayMode
    Private DeleteVideoConfirm As Boolean = False
    Private FullScreen As Boolean = False
    Private PlayState As Boolean = False
    Private TipCM As Skye.UI.ToolTipEX

    'Interface
    Private _player As Skye.Contracts.IMediaPlayer
    Public Class VLCPlayer
        Implements IMediaPlayer, IDisposable

        Private ReadOnly _libVLC As LibVLC
        Private ReadOnly _mediaPlayer As MediaPlayer
        Private _currentMedia As Media
        Private _currentPath As String
        Private _transitionGate As Integer = 0 'simple reentrancy guard

        Public Sub New(_invoker As Form)
            _libVLC = New LibVLC(Array.Empty(Of String))
            _mediaPlayer = New MediaPlayer(_libVLC)
            AddHandler _mediaPlayer.Playing,
                Sub(sender, e)
                    _invoker.BeginInvoke(Sub()
                                             RaiseEvent PlaybackStarted()
                                         End Sub)
                End Sub
            AddHandler _mediaPlayer.EndReached,
                 Sub(sender, e)
                     _invoker.BeginInvoke(Sub()
                                              RaiseEvent PlaybackEnded()
                                          End Sub)
                 End Sub
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Dispose managed resources
            _mediaPlayer?.Stop()
            _mediaPlayer?.Dispose()
            _currentMedia?.Dispose()
            _libVLC?.Dispose()

            ' Tell GC no finalizer is needed
            GC.SuppressFinalize(Me)
        End Sub


        Public Sub Play(path As String) Implements IMediaPlayer.Play
            If Threading.Interlocked.Exchange(_transitionGate, 1) = 1 Then Exit Sub 'Already transitioning; ignore duplicate calls
            Try

                ' Stop current playback first
                _mediaPlayer.Stop()

                ' Dispose old media safely
                If _currentMedia IsNot Nothing Then
                    _currentMedia.Dispose()
                    _currentMedia = Nothing
                End If

                ' Create and keep the new media alive
                _currentPath = path
                _currentMedia = New Media(_libVLC, path, FromType.FromPath, Array.Empty(Of String))

                ' Attach and play
                _mediaPlayer.Media = _currentMedia
                _mediaPlayer.Play()

            Finally
                Threading.Interlocked.Exchange(_transitionGate, 0)
            End Try
        End Sub
        Public Sub Play(uri As Uri) Implements IMediaPlayer.Play
            If Threading.Interlocked.Exchange(_transitionGate, 1) = 1 Then Exit Sub 'Already transitioning; ignore duplicate calls
            Try

                ' Stop current playback first
                _mediaPlayer.Stop()

                ' Dispose old media safely
                If _currentMedia IsNot Nothing Then
                    _currentMedia.Dispose()
                    _currentMedia = Nothing
                End If

                ' Create and keep the new media alive
                _currentPath = uri.ToString
                _currentMedia = New Media(_libVLC, uri, Array.Empty(Of String))

                ' Attach and play
                _mediaPlayer.Media = _currentMedia
                _mediaPlayer.Play()

            Finally
                Threading.Interlocked.Exchange(_transitionGate, 0)
            End Try
        End Sub
        Public Sub Play() Implements IMediaPlayer.Play
            If _currentMedia Is Nothing Then Exit Sub
            _mediaPlayer.Play()
        End Sub
        Public Sub Pause() Implements IMediaPlayer.Pause
            _mediaPlayer.Pause()
        End Sub
        Public Sub [Stop]() Implements IMediaPlayer.Stop
            _mediaPlayer.Stop()
        End Sub

        Public ReadOnly Property MediaPlayer As MediaPlayer
            Get
                Return _mediaPlayer
            End Get
        End Property
        Public ReadOnly Property HasMedia As Boolean Implements IMediaPlayer.HasMedia
            Get
                Return (_mediaPlayer IsNot Nothing) AndAlso (_mediaPlayer.Media IsNot Nothing)
            End Get
        End Property
        Public ReadOnly Property Path As String Implements IMediaPlayer.Path
            Get
                Return _currentPath
            End Get
        End Property
        Public Property Volume As Integer Implements IMediaPlayer.Volume
            Get
                Return _mediaPlayer.Volume
            End Get
            Set(value As Integer)
                _mediaPlayer.Volume = value
            End Set
        End Property
        Public Property Position As Double Implements IMediaPlayer.Position
            Get
                Return _mediaPlayer.Time / 1000.0
            End Get
            Set(value As Double)
                _mediaPlayer.Time = CInt(value * 1000)
            End Set
        End Property
        Public ReadOnly Property Duration As Double Implements IMediaPlayer.Duration
            Get
                Return _mediaPlayer.Length / 1000.0
            End Get
        End Property
        Public ReadOnly Property VideoWidth As Integer Implements IMediaPlayer.VideoWidth
            Get
                Dim w As UInteger, h As UInteger
                If _mediaPlayer.Size(0, w, h) Then
                    Return CInt(w)
                Else
                    Return 0
                End If
            End Get
        End Property
        Public ReadOnly Property VideoHeight As Integer Implements IMediaPlayer.VideoHeight
            Get
                Dim w As UInteger, h As UInteger
                If _mediaPlayer.Size(0, w, h) Then
                    Return CInt(h)
                Else
                    Return 0
                End If
            End Get
        End Property
        Public ReadOnly Property AspectRatio As Double Implements IMediaPlayer.AspectRatio
            Get
                Return If(VideoHeight > 0, CDbl(VideoWidth) / VideoHeight, 0)
            End Get
        End Property

        Public Event PlaybackStarted() Implements IMediaPlayer.PlaybackStarted
        Public Event PlaybackEnded() Implements IMediaPlayer.PlaybackEnded

    End Class

    'Form Events
    Friend Sub New(showBySelection As Boolean)

        'Initialize Locals
        TimerCheckPlayState.Interval = 1000
        TimerHideMouse.Interval = 5000
        TimerDeleteVideo.Interval = 5000
        If showBySelection Then StartUpPlayOption = My.App.PlayOption.BySelection

        'Initialize Form
        InitializeComponent()
        Me.DoubleBuffered = True
        AddHandler Me.Disposed, AddressOf frmDisposed
        AddHandler Me.LostFocus, AddressOf frmLostFocus
        Me.Text = My.Application.Info.Title + " Video"
        UpdateDeleteVideoConfirm()
        cmVids.Renderer = New Skye.UI.SkyeMenuRenderer
        TipCM = New Skye.UI.ToolTipEX() With {
            .Font = App.MenuFont,
            .ShadowAlpha = 0,
            .ShadowThickness = 0,
            .FadeInRate = 25,
            .FadeOutRate = 25,
            .HideDelay = 5000,
            .ShowDelay = 250
        }
        App.HookTSItemsForCMTooltip(cmVids, TipCM)
        Skye.UI.ThemeManager.RegisterComponent(TipCM)
        Skye.UI.ThemeManager.ApplyTheme(Me)
        lblTime.BackColor = Skye.UI.ThemeManager.CurrentTheme.TextBack
        AddHandler Skye.UI.ThemeManager.ThemeChanged, AddressOf OnThemeChanged

        _player = New VLCPlayer(Me)
        VLCViewer.MediaPlayer = CType(_player, VLCPlayer).MediaPlayer
        AddHandler _player.PlaybackStarted, AddressOf OnPlaybackStarted
        AddHandler _player.PlaybackEnded, AddressOf OnPlaybackEnded

    End Sub
    Private Sub FrmLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AddHandler VLCViewer.HandleCreated, AddressOf VLCViewer_HandleCreated
        AddHandler VLCViewer.HandleDestroyed, AddressOf VLCViewer_HandleDestroyed
        Me.cmiMuteVideo.Checked = My.App.VidVolumeMute
        Me.Width = 0
        Me.Height = 0
        If My.App.VidPlayMode = My.App.PlayMode.LinearWithRandomStart Then My.App.VideoIndex = Skye.Common.GetRandom(0, My.App.VideoFiles.Count - 1, My.App.VideoIndex)
        NextVideo(StartUpPlayOption)
    End Sub
    Private Sub FrmClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.App.HideBalloon()
        ShowCursor()
        RemoveHandler Me.LostFocus, AddressOf frmLostFocus
        TimerCheckPlayState.Stop()
        TimerHideMouse.Stop()
        TimerQuickHide.Stop()
        My.App.VideoIsOnTop = True
        If My.App.FrmMain.BackgroundworkerGetFiles.IsBusy Then My.App.FrmMain.cmiPlayVids.Enabled = False
        If My.App.FrmMain.Visible Then My.App.FrmMain.Focus()
        _player?.Stop()
        TryCast(_player, VLCPlayer)?.Dispose()
    End Sub
    Private Sub FrmDisposed(ByVal sender As Object, ByVal e As EventArgs)
        My.App.FrmMain.ToggleContextMenu()
        My.App.FrmVids = Nothing
    End Sub
    Private Sub FrmLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        If FullScreen And Not My.App.VidLockFullScreen And Not My.App.BalloonLoading And Not My.App.IgnoreFocusChange Then ToggleFullScreen()
    End Sub
    Friend Sub FrmPreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        My.App.HideBalloon()
        If e.Alt Then
        ElseIf e.Control Then
            Select Case e.KeyCode
                Case Keys.Left : NextVideo(My.App.PlayOption.Backward)
                Case Keys.Right : NextVideo(My.App.PlayOption.Forward)
                Case Keys.Down : NextVideo(My.App.PlayOption.Random)
            End Select
        ElseIf e.Shift Then
            Select Case e.KeyCode
                Case Keys.Delete : QuickHide(False)
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.Escape : ToggleFullScreen()
                Case Keys.End : My.App.FrmVids.Close()
                Case Keys.Up : TogglePlayState()
                Case Keys.Left : UpdatePosition(False)
                Case Keys.Right : UpdatePosition(True)
                Case Keys.Space : TogglePlayState()
                Case Keys.OemQuestion : ShowFileInfo()
                Case Keys.PageUp
                    If Not FullScreen Then
                        My.App.VidLocationMode = CType(My.App.VidLocationMode - 1, My.App.LocationMode)
                        If My.App.VidLocationMode < 0 Then My.App.VidLocationMode = CType(My.App.LocationModeCount, App.LocationMode)
                        If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
                        SetSize()
                    End If
                Case Keys.PageDown
                    If Not FullScreen Then
                        My.App.VidLocationMode = CType(My.App.VidLocationMode + 1, My.App.LocationMode)
                        If My.App.VidLocationMode > My.App.LocationModeCount Then My.App.VidLocationMode = 0
                        If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
                        SetSize()
                    End If
                Case Keys.Home : QuickRestore()
                Case Keys.Delete : QuickHide()
                Case Keys.Insert : QuickShift()
            End Select
        End If
    End Sub
    Private Sub FrmKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then : mMoveMode = 1
        ElseIf e.Shift And My.App.VidScale = 0 Then : mMoveMode = 2
        Else : mMoveMode = 0
        End If
    End Sub
    Private Sub FrmKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
        If Not e.Control And Not e.Shift Then
            mMoveMode = 0
            mMove = False
            mResize = False
        End If
    End Sub
    Private Sub FrmMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, lblTime.MouseDown
        If e.Button = MouseButtons.Left Then
            If Not My.App.VideoIsOnTop Then
                OnTop(True)
                TogglePlayState()
            End If
            If e.Clicks = 2 Then : ToggleFullScreen()
            ElseIf Not FullScreen Then
                If mMoveMode = 1 Then
                    Me.Cursor = Cursors.UpArrow
                    mStartLocation = Me.Location
                    mLastLocation = Me.Location
                    If sender Is Me.lblTime Then
                        mOffset = New Point(-(Me.lblTime.Left + e.X), -(Me.lblTime.Top + e.Y))
                        mLastLocation.Offset(Me.lblTime.Left + e.X, Me.lblTime.Top + e.Y)
                    Else
                        mOffset = New Point(-e.X, -e.Y)
                        mLastLocation.Offset(e.Location)
                    End If
                    mMove = True
                ElseIf mMoveMode = 2 Then
                    Me.Cursor = Cursors.SizeAll
                    mResize = False
                    mStartSize = My.App.VidMaxSize
                    mLastLocation = Me.Location
                    If sender Is Me.lblTime Then : mLastLocation.Offset(Me.lblTime.Left + e.X, Me.lblTime.Top + e.Y)
                    Else : mLastLocation.Offset(e.Location)
                    End If
                    mMove = True
                End If
            End If
        End If
    End Sub
    Private Sub FrmMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, lblTime.MouseMove
        If mMove Then
            If mMoveMode = 1 Then
                mPosition = Control.MousePosition
                mPosition.Offset(mOffset.X, mOffset.Y)
                CheckMove(mPosition)
                Location = mPosition
            ElseIf mMoveMode = 2 Then
                If sender Is Me.lblTime Then : My.App.VidMaxSize += CType(Me.Left + (Me.lblTime.Left + e.X) - mLastLocation.X, Short)
                Else : My.App.VidMaxSize += CShort(Int(Me.Left + e.X - mLastLocation.X))
                End If
                If mStartSize <> My.App.VidMaxSize Then mResize = True
                mLastLocation = Me.Location
                If sender Is Me.lblTime Then : mLastLocation.Offset(Me.lblTime.Left + e.X, Me.lblTime.Top + e.Y)
                Else : mLastLocation.Offset(e.Location)
                End If
                SetSize()
                If Me.PlayState = False Then ShowVideoTime()
            End If
        Else
            If mHide Then : If Not mHidePosition = Control.MousePosition Then ShowCursor()
            Else
                If FullScreen AndAlso My.App.HideCursorWhenFullscreen AndAlso mHoverLocation = e.Location Then
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
    Private Sub FrmMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, lblTime.MouseUp
        If mMove Then
            mMove = False
            If mMoveMode = 1 Then
                If mStartLocation <> Me.Location Then
                    If Me.Location.X > My.Computer.Screen.WorkingArea.Left + (My.Computer.Screen.WorkingArea.Width * (My.App.LocationModeManualAnchorThreshold / 100)) Then : My.App.VidLocation.X = Me.Location.X + Me.Width
                    Else : My.App.VidLocation.X = Me.Location.X
                    End If
                    If Me.Location.Y > My.Computer.Screen.WorkingArea.Top + (My.Computer.Screen.WorkingArea.Height * (My.App.LocationModeManualAnchorThreshold / 100)) Then : My.App.VidLocation.Y = Me.Location.Y + Me.Height
                    Else : My.App.VidLocation.Y = Me.Location.Y
                    End If
                    My.App.VidLocationMode = My.App.LocationMode.Manual
                    My.App.FrmMain.UpdateSettings()
                End If
            ElseIf mMoveMode = 2 Then : If mResize Then Me.cmVids.Close()
            End If
            Me.ResetCursor()
        ElseIf mHide Then : ShowCursor()
        ElseIf e.Button = MouseButtons.Left AndAlso sender Is Me.lblTime AndAlso My.App.MouseInBounds(DirectCast(Me.lblTime, Control), New Point(e.X, e.Y)) Then
            Select Case My.App.VidTimeDisplayMode
                Case My.App.VideoPositionMode.CurrentPosition : My.App.VidTimeDisplayMode = My.App.VideoPositionMode.TimeRemaining
                Case My.App.VideoPositionMode.TimeRemaining : My.App.VidTimeDisplayMode = My.App.VideoPositionMode.CurrentPosition
            End Select
            SetVideoTime()
            ShowVideoTime()
            If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
        End If
    End Sub

    'Control Events
    Private Sub VLCViewer_HandleCreated(sender As Object, e As EventArgs)
        If _VLCHook Is Nothing Then
            _VLCHook = New App.VLCViewerHook()
            _VLCHook.AssignHandle(VLCViewer.Handle)
            AddHandler _VLCHook.RightClick, AddressOf VLCViewer_RightClick
        End If
    End Sub
    Private Sub VLCViewer_HandleDestroyed(sender As Object, e As EventArgs)
        If _VLCHook IsNot Nothing Then
            RemoveHandler _VLCHook.RightClick, AddressOf VLCViewer_RightClick
            _VLCHook.ReleaseHandle()
            _VLCHook = Nothing
        End If
    End Sub
    Private Sub VLCViewer_RightClick(clientPoint As Point)
        cmVids.Show(VLCViewer, clientPoint)
    End Sub
    Private Sub CMVidsClosing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles cmVids.Closing
        If Me.cmVids.Items(Me.cmVids.Items.IndexOfKey(Me.cmiDeleteVideo.Name)).Selected Then : If Not Me.DeleteVideoConfirm Then e.Cancel = True
        Else : SetDeleteVideoConfirm(True)
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
    Private Sub CMIPlayMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiPlay.MouseUp
        If e.Button = MouseButtons.Left Then
            If Me.cmiQuickHide.Checked Then : QuickShow()
            Else : TogglePlayState()
            End If
        End If
    End Sub
    Private Sub CMIAdvanceMouseUp(sender As Object, e As MouseEventArgs) Handles cmiAdvance.MouseUp
        Select Case e.Button
            Case MouseButtons.Left
                If My.Computer.Keyboard.CtrlKeyDown Then : NextVideo(My.App.PlayOption.Random)
                Else : NextVideo(My.App.PlayOption.Forward)
                End If
            Case MouseButtons.Right
                If My.Computer.Keyboard.CtrlKeyDown Then : NextVideo(My.App.PlayOption.Previous)
                Else : NextVideo(My.App.PlayOption.Backward)
                End If
        End Select
    End Sub
    Private Sub CMIShowFileInfoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiShowFileInfo.MouseUp
        If e.Button = MouseButtons.Left Then ShowFileInfo()
    End Sub
    Private Sub CMIViewVideoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiViewVideo.MouseUp
        Select Case e.Button
            Case MouseButtons.Left
                If App.ViewFile(App.VideoFiles(App.VideoIndex).Path) Then
                    If FullScreen Then ToggleFullScreen()
                    TogglePlayState(True)
                End If
            Case MouseButtons.Right
                If App.OpenFileLocation(App.VideoFiles(App.VideoIndex).Path) And FullScreen Then ToggleFullScreen()
        End Select
    End Sub
    Private Sub CMIMuteVideoMouseUp(sender As Object, e As MouseEventArgs) Handles cmiMuteVideo.MouseUp
        My.App.VidVolumeMute = Not My.App.VidVolumeMute
        SetVolume()
        My.FrmMain.UpdateSettingsVids()
        App.SetSave()
    End Sub
    Private Sub CMIDeleteVideoMouseUp(sender As Object, e As MouseEventArgs) Handles cmiDeleteVideo.MouseUp
        If e.Button = MouseButtons.Left Then
            If DeleteVideoConfirm Then
                Dim file As String = My.App.VideoFiles.Item(My.App.VideoIndex).Path
                My.App.VideoFilesSetState(My.App.VideoIndex, My.App.VideoFileState.Deleted)
                NextVideo(My.App.PlayOption.Forward)
                '				NextVideo(My.SkyeShow.PlayOption.ByPlayMode)
                My.App.VideoIndexPrevious = -1
                My.App.DeleteFile(file)
                My.App.FrmMain.UpdateSettings()
            End If
            SetDeleteVideoConfirm()
        Else : SetDeleteVideoConfirm(True)
        End If
    End Sub
    Private Sub CMICloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiClose.MouseUp
        If e.Button = MouseButtons.Left Then My.App.FrmVids.Close()
    End Sub

    'Handlers
    Private Sub OnThemeChanged(sender As Object, e As EventArgs)
        lblTime.BackColor = Skye.UI.ThemeManager.CurrentTheme.TextBack
    End Sub
    Private Async Sub OnPlaybackStarted()
        Debug.Print("PlaybackStarted")
        SetVolume()
        Await Task.Delay(200)
        SetSize()
        ShowVideoTime()
    End Sub
    Private Sub OnPlaybackEnded()
        Debug.Print("PlaybackEnded")
        SetDeleteVideoConfirm(True)
        My.App.HideBalloon()
        NextVideo(My.App.PlayOption.ByPlayMode)
    End Sub
    Private Sub TimerCheckPlayStateTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerCheckPlayState.Tick
        If _player.HasMedia Then
            ShowVideoTime()
        End If
    End Sub
    Private Sub TimerHideMouseTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerHideMouse.Tick
        Debug.Print("timerHideMouseTick")
        Me.TimerHideMouse.Stop()

        If Not (Cursor.Position.X < Me.Left Or Cursor.Position.Y < Me.Top Or Cursor.Position.X >= Me.Left + Me.Width Or Cursor.Position.Y >= Me.Top + Me.Height Or Me.cmVids.Visible) Then
            HideCursor()
        End If
    End Sub
    Private Sub TimerQuickHideTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerQuickHide.Tick
        QuickShow()
    End Sub
    Private Sub TimerDeleteVideoTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerDeleteVideo.Tick
        SetDeleteVideoConfirm()
    End Sub

    'Procedures
    Friend Sub NextVideo(opt As My.App.PlayOption)
        If Not (opt = My.App.PlayOption.Previous AndAlso My.App.VideoIndexPrevious = -1) Then
            If My.App.VideoFilesCount > 0 Then
                Me.TimerCheckPlayState.Stop()
                If opt = My.App.PlayOption.ByPlayMode Then
                    Select Case My.App.VidPlayMode
                        Case My.App.PlayMode.Linear, My.App.PlayMode.LinearWithRandomStart : opt = My.App.PlayOption.Forward
                        Case My.App.PlayMode.Random : opt = My.App.PlayOption.Random
                    End Select
                End If
                Do
                    If Not opt = My.App.PlayOption.Previous Then My.App.VideoIndexPrevious = My.App.VideoIndex
                    Do
                        Select Case opt
                            Case My.App.PlayOption.Forward
                                My.App.VideoIndex += 1
                                If My.App.VideoIndex > My.App.VideoFiles.Count - 1 Then My.App.VideoIndex = 0
                            Case My.App.PlayOption.Backward
                                My.App.VideoIndex -= 1
                                If My.App.VideoIndex < 0 Then My.App.VideoIndex = My.App.VideoFiles.Count - 1
                            Case My.App.PlayOption.Random : My.App.VideoIndex = Skye.Common.GetRandom(0, My.App.VideoFiles.Count - 1, My.App.VideoIndex)
                            Case My.App.PlayOption.BySelection
                                If My.App.VideoIndex < 0 Then : My.App.VideoIndex = 0
                                ElseIf My.App.VideoIndex > My.App.VideoFiles.Count - 1 Then : My.App.VideoIndex = My.App.VideoFiles.Count - 1
                                End If
                            Case My.App.PlayOption.Previous
                                If Not (My.App.VideoIndexPrevious < 0 OrElse My.App.VideoIndexPrevious > My.App.VideoFiles.Count - 1 OrElse Not My.App.VideoFiles(My.App.VideoIndexPrevious).Enabled) Then
                                    Dim temp As Integer = App.VideoIndex
                                    App.VideoIndex = App.VideoIndexPrevious
                                    App.VideoIndexPrevious = temp
                                End If
                        End Select
                    Loop Until (My.App.VideoFiles(My.App.VideoIndex).Enabled OrElse opt = My.App.PlayOption.BySelection) AndAlso (Not My.App.VideoFiles(My.App.VideoIndex).Viewed OrElse opt = My.App.PlayOption.Backward OrElse opt = My.App.PlayOption.Forward OrElse opt = My.App.PlayOption.BySelection OrElse opt = My.App.PlayOption.Previous)
                    If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(My.App.VideoFiles(My.App.VideoIndex).Path) Then : Exit Do
                    Else
                        My.App.VideoFilesSetState(My.App.VideoIndex, My.App.VideoFileState.PathNotFound)
                        If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
                        If My.App.VideoFilesCount = 0 Or opt = My.App.PlayOption.BySelection Then
                            Me.Close()
                            Exit Sub
                        End If
                    End If
                Loop
                App.WriteToLog(VideoIndexLogText)
                Try
                    _player.Stop()
                    _player.Play(My.App.VideoFiles(My.App.VideoIndex).Path)
                    Debug.Print("NextVideo--> " + Location.ToString)
                    PlayState = False
                    TogglePlayState()
                    My.App.VideoFilesSetViewed(My.App.VideoIndex)
                Catch ex As Exception
                    My.App.WriteToLog("Video Load Error" + Environment.NewLine + ex.ToString)
                    My.App.SetErrorAlert()
                    My.App.VideoFilesSetState(My.App.VideoIndex, My.App.VideoFileState.DisplayError)
                    If My.App.VideoFilesCount = 0 Then : My.App.FrmVids.Close()
                    Else : NextVideo(My.App.PlayOption.ByPlayMode)
                    End If
                End Try
            Else : My.App.FrmVids.Close()
            End If
        End If
    End Sub
    Friend Sub SetSize()
        If _player.VideoWidth <= 0 OrElse _player.VideoHeight <= 0 Then Exit Sub 'VLC hasn't reported size yet — avoid overflow
        My.App.IgnoreFocusChange = True
        Me.SuspendLayout()
        Try
            If FullScreen Then
                If (_player.VideoWidth - My.Computer.Screen.Bounds.Width) / My.Computer.Screen.Bounds.Width >= (_player.VideoHeight - My.Computer.Screen.Bounds.Height) / My.Computer.Screen.Bounds.Height Then
                    'Adjusted Width larger than or equal to Adjusted Height
                    Me.Width = My.Computer.Screen.Bounds.Width
                    Me.Height = CType(Int(_player.VideoHeight * (My.Computer.Screen.Bounds.Width / _player.VideoWidth)), Integer)
                    Me.Left = 0
                    Me.Top = CType(Int(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2), Integer)
                Else
                    'Adjusted Height larger than Adjusted Width
                    Me.Width = CType(Int(_player.VideoWidth * (My.Computer.Screen.Bounds.Height / _player.VideoHeight)), Integer)
                    Me.Height = My.Computer.Screen.Bounds.Height
                    Me.Left = CType(Int(My.Computer.Screen.Bounds.Width / 2 - Me.Width / 2), Integer)
                    Me.Top = 0
                End If
            Else
                If My.App.VidScale = 0 Then
                    If My.App.VidMaxSize < Int(My.Computer.Screen.WorkingArea.Width / 30) Then : My.App.VidMaxSize = CShort(Int(My.Computer.Screen.WorkingArea.Width / 30))
                    Else
                        If Me.Left + My.App.VidMaxSize > My.Computer.Screen.WorkingArea.Width Then My.App.VidMaxSize = CShort(My.Computer.Screen.WorkingArea.Width - Me.Left)
                        Do Until GetHeight(My.App.VidMaxSize) <= My.Computer.Screen.WorkingArea.Height : My.App.VidMaxSize -= CShort(1)
                        Loop
                    End If
                    Me.Width = My.App.VidMaxSize
                    Me.Height = GetHeight(My.App.VidMaxSize)
                Else
                    Me.Size = New System.Drawing.Size(CType(Int(_player.VideoWidth * My.App.VidScale), Integer), CType(Int(_player.VideoHeight * My.App.VidScale), Integer))
                End If
                Select Case My.App.VidLocationMode
                    Case My.App.LocationMode.Manual
                        Static locM As New Point
                        If My.App.VidLocation.X > My.Computer.Screen.WorkingArea.Left + (My.Computer.Screen.WorkingArea.Width * (My.App.LocationModeManualAnchorThreshold / 100)) Then
                            locM.X = My.App.VidLocation.X - Me.Width
                        Else : locM.X = My.App.VidLocation.X
                        End If
                        If My.App.VidLocation.Y > My.Computer.Screen.WorkingArea.Top + (My.Computer.Screen.WorkingArea.Height * (My.App.LocationModeManualAnchorThreshold / 100)) Then
                            locM.Y = My.App.VidLocation.Y - Me.Height
                        Else : locM.Y = My.App.VidLocation.Y
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
                    Case My.App.LocationMode.TopLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + My.App.InsideLocationOffset)
                    Case My.App.LocationMode.TopCenterLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.InsideLocationOffset)
                    Case My.App.LocationMode.TopCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.InsideLocationOffset)
                    Case My.App.LocationMode.TopCenterRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Top + My.App.InsideLocationOffset)
                    Case My.App.LocationMode.TopRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + My.App.InsideLocationOffset)
                    Case My.App.LocationMode.RightCenterTopInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
                    Case My.App.LocationMode.RightCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
                    Case My.App.LocationMode.RightCenterBottomInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
                    Case My.App.LocationMode.BottomRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Right - Me.Width - My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.InsideLocationOffset)
                    Case My.App.LocationMode.BottomCenterRightInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.75 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.InsideLocationOffset)
                    Case My.App.LocationMode.BottomCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.5 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.InsideLocationOffset)
                    Case My.App.LocationMode.BottomCenterLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + CType(My.Computer.Screen.WorkingArea.Width * 0.25 - Me.Width / 2, Integer), My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.InsideLocationOffset)
                    Case My.App.LocationMode.BottomLeftInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Bottom - Me.Height - My.App.InsideLocationOffset)
                    Case My.App.LocationMode.LeftCenterBottomInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.75 - Me.Height / 2, Integer))
                    Case My.App.LocationMode.LeftCenterInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.5 - Me.Height / 2, Integer))
                    Case My.App.LocationMode.LeftCenterTopInside : Me.Location = New Point(My.Computer.Screen.WorkingArea.Left + My.App.InsideLocationOffset, My.Computer.Screen.WorkingArea.Top + CType(My.Computer.Screen.WorkingArea.Height * 0.25 - Me.Height / 2, Integer))
                End Select
                CheckMove(Me.Location)
                Debug.Print("SetSize")
            End If
        Catch
        Finally
            Me.ResumeLayout()
            OnTop(True)
            My.App.IgnoreFocusChange = False
        End Try
    End Sub
    Friend Sub TogglePlayState(Optional ForcePause As Boolean = False)
        If Me.PlayState Or Not _player.HasMedia Or ForcePause Then
            TimerCheckPlayState.Stop()
            _player.Pause()
            Me.PlayState = False
            Me.cmiPlay.Checked = False
            Me.cmiPlay.Image = My.Resources.Resources.imagePause
            Me.cmiPlay.ForeColor = Color.Maroon
            Me.cmiPlay.Text = "Play"
        Else
            _player.Play()
            Me.PlayState = True
            Me.cmiPlay.Checked = True
            Me.cmiPlay.Image = My.Resources.Resources.imagePlay
            Me.cmiPlay.ForeColor = Color.Teal
            Me.cmiPlay.Text = "Pause"
            SetVideoTime()
            TimerCheckPlayState.Start()
            If Me.cmiQuickHide.Checked Then
                Me.cmiQuickHide.Checked = False
                Me.cmiQuickHide.ResetForeColor()
            End If
        End If
    End Sub
    Friend Sub ToggleFullScreen()
        FullScreen = Not FullScreen
        Me.cmiFullScreen.Checked = Not Me.cmiFullScreen.Checked
        If Not FullScreen Then ShowCursor()
        SetSize()
    End Sub
    Friend Sub QuickShow()
        SetSize()
        TogglePlayState()
    End Sub
    Friend Sub SetVideoTime()
        If My.App.VidTime Then
            ShowVideoTime()
            Me.lblTime.BringToFront()
            Me.lblTime.Visible = True
        Else : Me.lblTime.Visible = False
        End If
    End Sub
    Friend Sub ShowVideoTime()
        Static vTime As Double
        Static vTimeText As String
        Dim vlc As VLCPlayer = TryCast(_player, VLCPlayer)
        If vlc Is Nothing OrElse Not vlc.HasMedia Then Exit Sub
        Select Case My.App.VidTimeLocationMode
            Case My.App.LocationMode.TopLeft : Me.lblTime.Location = New Point(My.App.VideoTimeBorderPadding, My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.TopCenterLeft : Me.lblTime.Location = New Point(CInt(Me.Width * 0.25) - CInt(Me.lblTime.Width / 2), My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.TopCenter : Me.lblTime.Location = New Point(CInt(Me.Width * 0.5) - CInt(Me.lblTime.Width / 2), My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.TopCenterRight : Me.lblTime.Location = New Point(CInt(Me.Width * 0.75) - CInt(Me.lblTime.Width / 2), My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.TopRight : Me.lblTime.Location = New Point(Me.Width - Me.lblTime.Width - My.App.VideoTimeBorderPadding, My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.RightCenterTop : Me.lblTime.Location = New Point(Me.Width - Me.lblTime.Width - My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.25) - CInt(Me.lblTime.Height / 2))
            Case My.App.LocationMode.RightCenter : Me.lblTime.Location = New Point(Me.Width - Me.lblTime.Width - My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.5) - CInt(Me.lblTime.Height / 2))
            Case My.App.LocationMode.RightCenterBottom : Me.lblTime.Location = New Point(Me.Width - Me.lblTime.Width - My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.75) - CInt(Me.lblTime.Height / 2))
            Case My.App.LocationMode.BottomRight : Me.lblTime.Location = New Point(Me.Width - Me.lblTime.Width - My.App.VideoTimeBorderPadding, Me.Height - Me.lblTime.Height - My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.BottomCenterRight : Me.lblTime.Location = New Point(CInt(Me.Width * 0.75) - CInt(Me.lblTime.Width / 2), Me.Height - Me.lblTime.Height - My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.BottomCenter : Me.lblTime.Location = New Point(CInt(Me.Width * 0.5) - CInt(Me.lblTime.Width / 2), Me.Height - Me.lblTime.Height - My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.BottomCenterLeft : Me.lblTime.Location = New Point(CInt(Me.Width * 0.25) - CInt(Me.lblTime.Width / 2), Me.Height - Me.lblTime.Height - My.App.VideoTimeBorderPadding)
            Case My.App.LocationMode.LeftCenterBottom : Me.lblTime.Location = New Point(My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.75) - CInt(Me.lblTime.Height / 2))
            Case My.App.LocationMode.LeftCenter : Me.lblTime.Location = New Point(My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.5) - CInt(Me.lblTime.Height / 2))
            Case My.App.LocationMode.LeftCenterTop : Me.lblTime.Location = New Point(My.App.VideoTimeBorderPadding, CInt(Me.Height * 0.25) - CInt(Me.lblTime.Height / 2))
            Case Else : Me.lblTime.Location = New Point(My.App.VideoTimeBorderPadding, Me.Height - Me.lblTime.Height - My.App.VideoTimeBorderPadding)
        End Select
        Select Case My.App.VidTimeDisplayMode
            Case My.App.VideoPositionMode.CurrentPosition
                vTime = vlc.Position
                vTimeText = String.Empty
            Case My.App.VideoPositionMode.TimeRemaining
                vTime = _player.Duration - vlc.Position
                If vTime < 0 Then vTime = 0
                vTimeText = "-"
        End Select
        Dim ts As TimeSpan = TimeSpan.FromSeconds(vTime)
        If ts.Hours > 0 Then
            vTimeText &= ts.ToString("hh\:mm\:ss")
        Else
            vTimeText &= ts.ToString("mm\:ss")
        End If
        Me.lblTime.Text = vTimeText
    End Sub
    Friend Sub ShowFileInfo()
        On Error Resume Next
        Dim s As String = String.Empty
        Dim i As IO.FileInfo
        Dim t As TimeSpan = TimeSpan.FromSeconds(_player.Duration)
        i = Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo(My.App.VideoFiles(My.App.VideoIndex).Path)
        s += IIf(t.Hours > 0, t.Hours.ToString.PadLeft(2, "0"c) + ":", "").ToString + t.Minutes.ToString.PadLeft(2, "0"c) + ":" + t.Seconds.ToString.PadLeft(2, "0"c)
        s += vbCr
        s += Skye.Common.FormatFileSize(i.Length, Skye.Common.FormatFileSizeUnits.Auto, 1)
        s += vbCr
        s += _player.VideoWidth.ToString + "x" + _player.VideoHeight.ToString
        s += " ("
        s += My.App.FormatVideoAspectRatio(New Size(_player.VideoWidth, _player.VideoHeight))
        s += ") "
        s += vbCr
        s += i.DirectoryName
        My.App.ShowBalloon(Me, My.Resources.Resources.imageVideo32, i.Name, s)
    End Sub
    Friend Sub SetVolume()
        If _player.HasMedia Then
            Select Case My.App.VidVolumeMute
                Case True
                    _player.Volume = 0
                    Me.cmiMuteVideo.Checked = True
                Case False
                    _player.Volume = 100
                    Me.cmiMuteVideo.Checked = False
            End Select
        End If
    End Sub
    Friend Function IsFullScreen() As Boolean
        Return FullScreen
    End Function
    Private Sub UpdatePosition(ByVal forward As Boolean, Optional ByVal seconds As Byte = 20)
        If forward Then
            If _player.Position + seconds > _player.Duration Then
                _player.Position = _player.Duration
            Else
                _player.Position += seconds
            End If
        Else
            If _player.Position <= seconds Then
                _player.Position = 0
            Else
                _player.Position -= seconds
            End If
        End If
    End Sub
    Private Sub QuickHide(Optional autorestore As Boolean = True)
        ShowCursor()
        Me.TimerQuickHide.Stop()
        If FullScreen Then ToggleFullScreen()
        Me.cmiQuickHide.Checked = True
        OnTop(False)
        If autorestore Then
            Me.cmiQuickHide.ForeColor = Color.Goldenrod
            Me.TimerQuickHide.Interval = My.App.PicTimerInterval * 1000
            Me.TimerQuickHide.Start()
        Else : Me.cmiQuickHide.ForeColor = Color.Maroon
        End If
    End Sub
    Private Sub QuickShift()
        If Not FullScreen Then
            My.App.VidLocationMode = CType(My.App.VidLocationMode + 6, My.App.LocationMode)
            If My.App.VidLocationMode > My.App.LocationModeCount Then My.App.VidLocationMode = CType(My.App.VidLocationMode - My.App.LocationModeCount, My.App.LocationMode)
            If My.App.FrmMain.Visible Then My.App.FrmMain.UpdateSettings()
            SetSize()
        End If
    End Sub
    Private Sub QuickRestore()
        ShowCursor()
        If FullScreen Then ToggleFullScreen()
        TogglePlayState(True)
        My.App.FrmMain.RestoreSettings()
        SetSize()
        TogglePlayState()
    End Sub
    Private Sub OnTop(mode As Boolean)
        On Error Resume Next
        If mode Then
            Me.TimerQuickHide.Stop()
            Me.cmiQuickHide.ResetForeColor()
            Me.cmiQuickHide.Checked = False
            Me.TopMost = True
            My.App.VideoIsOnTop = True
            My.App.FrmMain.AppNotify()
        Else
            TogglePlayState(True)
            Me.SendToBack()
            Me.SendToBack()
            My.App.VideoIsOnTop = False
            My.App.FrmMain.AppNotify()
        End If
    End Sub
    'Private Sub DisposeVideo()
    '	On Error Resume Next
    '	Me.AxWMP.Ctlcontrols.pause()
    '	Me.URL = Nothing
    'End Sub
    Private Sub HideCursor()
        If Not mHide AndAlso My.App.HideCursorWhenFullscreen Then
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
    Private Sub SetDeleteVideoConfirm(Optional forcereset As Boolean = False)
        If DeleteVideoConfirm Or forcereset Then
            TimerDeleteVideo.Stop()
            DeleteVideoConfirm = False
        Else
            DeleteVideoConfirm = True
            TimerDeleteVideo.Start()
        End If
        UpdateDeleteVideoConfirm()
    End Sub
    Private Sub UpdateDeleteVideoConfirm()
        If DeleteVideoConfirm Then
            Me.cmiDeleteVideo.Text = "Are You Sure?"
            Me.cmiDeleteVideo.ForeColor = Color.Maroon
            Me.cmiDeleteVideo.Font = New Font(Me.cmiDeleteVideo.Font, FontStyle.Bold)
        Else
            Me.cmiDeleteVideo.ResetForeColor()
            Me.cmiDeleteVideo.Text = "Delete Video"
            Me.cmiDeleteVideo.Font = New Font(Me.cmiDeleteVideo.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub CheckMove(ByRef location As Point)
        If location.X + Me.Width > My.Computer.Screen.WorkingArea.Right Then location.X = My.Computer.Screen.WorkingArea.Right - Me.Width
        If location.Y + Me.Height > My.Computer.Screen.WorkingArea.Bottom Then location.Y = My.Computer.Screen.WorkingArea.Bottom - Me.Height
        If location.X < My.Computer.Screen.WorkingArea.Left Then location.X = My.Computer.Screen.WorkingArea.Left
        If location.Y < My.Computer.Screen.WorkingArea.Top Then location.Y = My.Computer.Screen.WorkingArea.Top
    End Sub
    Private Function GetHeight(width As Integer) As Integer
        If _player.HasMedia Then
            If _player.VideoWidth = 0 Then Return 0
            Return CInt(Int(_player.VideoHeight * (width / _player.VideoWidth)))
        Else
            Return 0
        End If
    End Function

End Class
