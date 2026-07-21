Friend Partial Class Vids
Inherits System.Windows.Forms.Form
	Private components As System.ComponentModel.IContainer
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
    Private Sub InitializeComponent
        components = New ComponentModel.Container()
        CMVids = New ContextMenuStrip(components)
        cmiFullScreen = New ToolStripMenuItem()
        cmiSeparator1 = New ToolStripSeparator()
        cmiQuickHide = New ToolStripMenuItem()
        cmiQuickShift = New ToolStripMenuItem()
        cmiQuickRestore = New ToolStripMenuItem()
        cmiSeparator2 = New ToolStripSeparator()
        cmiPlay = New ToolStripMenuItem()
        CMINavigation = New ToolStripMenuItem()
        CMNavigation = New ContextMenuStrip(components)
        CMIForward = New ToolStripMenuItem()
        CMIRandom = New ToolStripMenuItem()
        CMIBackward = New ToolStripMenuItem()
        CMIPrevious = New ToolStripMenuItem()
        cmiShowFileInfo = New ToolStripMenuItem()
        cmiViewVideo = New ToolStripMenuItem()
        cmiMuteVideo = New ToolStripMenuItem()
        cmiSeparator3 = New ToolStripSeparator()
        cmiDeleteVideo = New ToolStripMenuItem()
        cmiSeparator4 = New ToolStripSeparator()
        cmiClose = New ToolStripMenuItem()
        lblTime = New Label()
        VLCViewer = New LibVLCSharp.WinForms.VideoView()
        CMVids.SuspendLayout()
        CMNavigation.SuspendLayout()
        CType(VLCViewer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CMVids
        ' 
        CMVids.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CMVids.Items.AddRange(New ToolStripItem() {cmiFullScreen, cmiSeparator1, cmiQuickHide, cmiQuickShift, cmiQuickRestore, cmiSeparator2, cmiPlay, CMINavigation, cmiShowFileInfo, cmiViewVideo, cmiMuteVideo, cmiSeparator3, cmiDeleteVideo, cmiSeparator4, cmiClose})
        CMVids.Name = "contextmenuVideo"
        CMVids.RenderMode = ToolStripRenderMode.Professional
        CMVids.ShowItemToolTips = False
        CMVids.Size = New Size(233, 314)
        ' 
        ' cmiFullScreen
        ' 
        cmiFullScreen.Image = My.Resources.Resources.ImageFullscreen
        cmiFullScreen.Name = "cmiFullScreen"
        cmiFullScreen.ShortcutKeyDisplayString = "ESC"
        cmiFullScreen.Size = New Size(232, 26)
        cmiFullScreen.Text = "Fullscreen"
        ' 
        ' cmiSeparator1
        ' 
        cmiSeparator1.Name = "cmiSeparator1"
        cmiSeparator1.Size = New Size(229, 6)
        ' 
        ' cmiQuickHide
        ' 
        cmiQuickHide.Image = My.Resources.Resources.imageHide
        cmiQuickHide.Name = "cmiQuickHide"
        cmiQuickHide.ShortcutKeyDisplayString = "DELETE"
        cmiQuickHide.Size = New Size(232, 26)
        cmiQuickHide.Text = "Quick Hide"
        cmiQuickHide.ToolTipText = "RightClick = Perma Hide (Shift+Delete)"
        ' 
        ' cmiQuickShift
        ' 
        cmiQuickShift.Image = My.Resources.Resources.imageQuickShift
        cmiQuickShift.Name = "cmiQuickShift"
        cmiQuickShift.ShortcutKeyDisplayString = "INSERT"
        cmiQuickShift.Size = New Size(232, 26)
        cmiQuickShift.Text = "Quick Shift"
        ' 
        ' cmiQuickRestore
        ' 
        cmiQuickRestore.Image = My.Resources.Resources.imageRestore
        cmiQuickRestore.Name = "cmiQuickRestore"
        cmiQuickRestore.ShortcutKeyDisplayString = "HOME"
        cmiQuickRestore.Size = New Size(232, 26)
        cmiQuickRestore.Text = "Quick Restore"
        ' 
        ' cmiSeparator2
        ' 
        cmiSeparator2.Name = "cmiSeparator2"
        cmiSeparator2.Size = New Size(229, 6)
        ' 
        ' cmiPlay
        ' 
        cmiPlay.Name = "cmiPlay"
        cmiPlay.ShortcutKeyDisplayString = "↑"
        cmiPlay.Size = New Size(232, 26)
        cmiPlay.Text = "Play"
        ' 
        ' CMINavigation
        ' 
        CMINavigation.DropDown = CMNavigation
        CMINavigation.Image = My.Resources.Resources.ImageForward16
        CMINavigation.Name = "CMINavigation"
        CMINavigation.ShortcutKeyDisplayString = ""
        CMINavigation.Size = New Size(232, 26)
        CMINavigation.Text = "Navigation"
        ' 
        ' CMNavigation
        ' 
        CMNavigation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CMNavigation.Items.AddRange(New ToolStripItem() {CMIForward, CMIRandom, CMIBackward, CMIPrevious})
        CMNavigation.Name = "CMNavigation"
        CMNavigation.OwnerItem = CMINavigation
        CMNavigation.ShowItemToolTips = False
        CMNavigation.Size = New Size(172, 108)
        ' 
        ' CMIForward
        ' 
        CMIForward.Image = My.Resources.Resources.ImageForward16
        CMIForward.Name = "CMIForward"
        CMIForward.ShortcutKeyDisplayString = "→"
        CMIForward.Size = New Size(171, 26)
        CMIForward.Text = "Forward"
        CMIForward.ToolTipText = "Go Forward One Vid"
        ' 
        ' CMIRandom
        ' 
        CMIRandom.Image = My.Resources.Resources.ImageRandom16
        CMIRandom.Name = "CMIRandom"
        CMIRandom.ShortcutKeyDisplayString = "↓"
        CMIRandom.Size = New Size(171, 26)
        CMIRandom.Text = "Random"
        CMIRandom.ToolTipText = "Go To A Random Vid"
        ' 
        ' CMIBackward
        ' 
        CMIBackward.Image = My.Resources.Resources.ImageBack16
        CMIBackward.Name = "CMIBackward"
        CMIBackward.ShortcutKeyDisplayString = "←"
        CMIBackward.Size = New Size(171, 26)
        CMIBackward.Text = "Backward"
        CMIBackward.ToolTipText = "Go Back One Vid"
        ' 
        ' CMIPrevious
        ' 
        CMIPrevious.Image = My.Resources.Resources.ImagePrevious16
        CMIPrevious.Name = "CMIPrevious"
        CMIPrevious.Size = New Size(171, 26)
        CMIPrevious.Text = "Previous"
        CMIPrevious.ToolTipText = "Go To The Last Vid Viewed"
        ' 
        ' cmiShowFileInfo
        ' 
        cmiShowFileInfo.Image = My.Resources.Resources.ImageVideo
        cmiShowFileInfo.Name = "cmiShowFileInfo"
        cmiShowFileInfo.ShortcutKeyDisplayString = "?"
        cmiShowFileInfo.Size = New Size(232, 26)
        cmiShowFileInfo.Text = "Show Video Info"
        ' 
        ' cmiViewVideo
        ' 
        cmiViewVideo.Image = My.Resources.Resources.imageGo
        cmiViewVideo.Name = "cmiViewVideo"
        cmiViewVideo.Size = New Size(232, 26)
        cmiViewVideo.Text = "View Video"
        cmiViewVideo.ToolTipText = "RightClick = Open File Location"
        ' 
        ' cmiMuteVideo
        ' 
        cmiMuteVideo.Image = My.Resources.Resources.imageSoundMute
        cmiMuteVideo.Name = "cmiMuteVideo"
        cmiMuteVideo.Size = New Size(232, 26)
        cmiMuteVideo.Text = "Mute Audio"
        ' 
        ' cmiSeparator3
        ' 
        cmiSeparator3.Name = "cmiSeparator3"
        cmiSeparator3.Size = New Size(229, 6)
        ' 
        ' cmiDeleteVideo
        ' 
        cmiDeleteVideo.Image = My.Resources.Resources.imageRemove
        cmiDeleteVideo.Name = "cmiDeleteVideo"
        cmiDeleteVideo.Size = New Size(232, 26)
        ' 
        ' cmiSeparator4
        ' 
        cmiSeparator4.Name = "cmiSeparator4"
        cmiSeparator4.Size = New Size(229, 6)
        ' 
        ' cmiClose
        ' 
        cmiClose.Image = My.Resources.Resources.imageClose
        cmiClose.Name = "cmiClose"
        cmiClose.ShortcutKeyDisplayString = "END"
        cmiClose.Size = New Size(232, 26)
        cmiClose.Text = "Close"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.None
        lblTime.AutoSize = True
        lblTime.BackColor = SystemColors.Control
        lblTime.CausesValidation = False
        lblTime.ContextMenuStrip = CMVids
        lblTime.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(135, 142)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(33, 19)
        lblTime.TabIndex = 0
        lblTime.Text = "888"
        lblTime.TextAlign = ContentAlignment.MiddleCenter
        lblTime.UseMnemonic = False
        lblTime.Visible = False
        ' 
        ' VLCViewer
        ' 
        VLCViewer.BackColor = Color.Black
        VLCViewer.ContextMenuStrip = CMVids
        VLCViewer.Dock = DockStyle.Fill
        VLCViewer.Enabled = False
        VLCViewer.Location = New Point(0, 0)
        VLCViewer.MediaPlayer = Nothing
        VLCViewer.Name = "VLCViewer"
        VLCViewer.Size = New Size(300, 300)
        VLCViewer.TabIndex = 0
        VLCViewer.TabStop = False
        ' 
        ' Vids
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.Desktop
        CausesValidation = False
        ClientSize = New Size(300, 300)
        ContextMenuStrip = CMVids
        ControlBox = False
        Controls.Add(VLCViewer)
        Controls.Add(lblTime)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.IconVideo
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Vids"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        CMVids.ResumeLayout(False)
        CMNavigation.ResumeLayout(False)
        CType(VLCViewer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents CMVids As System.Windows.Forms.ContextMenuStrip
    Private cmiSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private cmiSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents CMINavigation As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiDeleteVideo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiQuickHide As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiQuickRestore As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiQuickShift As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiViewVideo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiShowFileInfo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiPlay As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiFullScreen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmiMuteVideo As ToolStripMenuItem
    Friend WithEvents VLCViewer As LibVLCSharp.WinForms.VideoView
    Friend WithEvents CMNavigation As ContextMenuStrip
    Friend WithEvents CMIForward As ToolStripMenuItem
    Friend WithEvents CMIRandom As ToolStripMenuItem
    Friend WithEvents CMIBackward As ToolStripMenuItem
    Friend WithEvents CMIPrevious As ToolStripMenuItem
End Class