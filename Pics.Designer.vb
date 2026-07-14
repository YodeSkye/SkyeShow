Friend Partial Class Pics
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
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        picbx = New PictureBox()
        CMPics = New ContextMenuStrip(components)
        cmiFullScreen = New ToolStripMenuItem()
        cmiSeparator1 = New ToolStripSeparator()
        cmiQuickHide = New ToolStripMenuItem()
        cmiQuickShift = New ToolStripMenuItem()
        cmiQuickRestore = New ToolStripMenuItem()
        cmiSeparator2 = New ToolStripSeparator()
        cmiTimer = New ToolStripMenuItem()
        cmiNavigation = New ToolStripMenuItem()
        CMNavigation = New ContextMenuStrip(components)
        CMIForward = New ToolStripMenuItem()
        CMIRandom = New ToolStripMenuItem()
        CMIBackward = New ToolStripMenuItem()
        CMIPrevious = New ToolStripMenuItem()
        cmiShowFileInfo = New ToolStripMenuItem()
        cmiViewImage = New ToolStripMenuItem()
        cmiSeparator3 = New ToolStripSeparator()
        cmiDeleteImage = New ToolStripMenuItem()
        cmiSeparator4 = New ToolStripSeparator()
        cmiClose = New ToolStripMenuItem()
        lblCountdown = New Label()
        CType(picbx, ComponentModel.ISupportInitialize).BeginInit()
        CMPics.SuspendLayout()
        CMNavigation.SuspendLayout()
        SuspendLayout()
        ' 
        ' picbx
        ' 
        picbx.BackColor = Color.Black
        picbx.ContextMenuStrip = CMPics
        picbx.Dock = DockStyle.Fill
        picbx.Location = New Point(0, 0)
        picbx.Margin = New Padding(3, 4, 3, 4)
        picbx.Name = "picbx"
        picbx.Size = New Size(300, 300)
        picbx.TabIndex = 0
        picbx.TabStop = False
        ' 
        ' CMPics
        ' 
        CMPics.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CMPics.Items.AddRange(New ToolStripItem() {cmiFullScreen, cmiSeparator1, cmiQuickHide, cmiQuickShift, cmiQuickRestore, cmiSeparator2, cmiTimer, cmiNavigation, cmiShowFileInfo, cmiViewImage, cmiSeparator3, cmiDeleteImage, cmiSeparator4, cmiClose})
        CMPics.Name = "contextmenuImageForm"
        CMPics.RenderMode = ToolStripRenderMode.Professional
        CMPics.ShowItemToolTips = False
        CMPics.Size = New Size(233, 310)
        ' 
        ' cmiFullScreen
        ' 
        cmiFullScreen.Image = My.Resources.Resources.ImageFullscreen
        cmiFullScreen.Name = "cmiFullScreen"
        cmiFullScreen.ShortcutKeyDisplayString = "ESC"
        cmiFullScreen.Size = New Size(232, 26)
        cmiFullScreen.Text = "Full Screen"
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
        ' cmiTimer
        ' 
        cmiTimer.Image = My.Resources.Resources.ImageTimer
        cmiTimer.Name = "cmiTimer"
        cmiTimer.ShortcutKeyDisplayString = "↑"
        cmiTimer.Size = New Size(232, 26)
        cmiTimer.Text = "Timer"
        ' 
        ' cmiNavigation
        ' 
        cmiNavigation.DropDown = CMNavigation
        cmiNavigation.Image = My.Resources.Resources.ImageForward16
        cmiNavigation.Name = "cmiNavigation"
        cmiNavigation.ShortcutKeyDisplayString = ""
        cmiNavigation.Size = New Size(232, 26)
        cmiNavigation.Text = "Navigation"
        ' 
        ' CMNavigation
        ' 
        CMNavigation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CMNavigation.Items.AddRange(New ToolStripItem() {CMIForward, CMIRandom, CMIBackward, CMIPrevious})
        CMNavigation.Name = "CMNavigation"
        CMNavigation.OwnerItem = cmiNavigation
        CMNavigation.ShowItemToolTips = False
        CMNavigation.Size = New Size(181, 130)
        ' 
        ' CMIForward
        ' 
        CMIForward.Image = My.Resources.Resources.ImageForward16
        CMIForward.Name = "CMIForward"
        CMIForward.ShortcutKeyDisplayString = "→"
        CMIForward.Size = New Size(180, 26)
        CMIForward.Text = "Forward"
        CMIForward.ToolTipText = "Go Forward One Pic"
        ' 
        ' CMIRandom
        ' 
        CMIRandom.Image = My.Resources.Resources.ImageRandom16
        CMIRandom.Name = "CMIRandom"
        CMIRandom.ShortcutKeyDisplayString = "↓"
        CMIRandom.Size = New Size(180, 26)
        CMIRandom.Text = "Random"
        CMIRandom.ToolTipText = "Go To A Random Pic"
        ' 
        ' CMIBackward
        ' 
        CMIBackward.Image = My.Resources.Resources.ImageBack16
        CMIBackward.Name = "CMIBackward"
        CMIBackward.ShortcutKeyDisplayString = "←"
        CMIBackward.Size = New Size(180, 26)
        CMIBackward.Text = "Backward"
        CMIBackward.ToolTipText = "Go Back One Pic"
        ' 
        ' CMIPrevious
        ' 
        CMIPrevious.Image = My.Resources.Resources.ImagePrevious16
        CMIPrevious.Name = "CMIPrevious"
        CMIPrevious.Size = New Size(180, 26)
        CMIPrevious.Text = "Previous"
        CMIPrevious.ToolTipText = "Go To The Last Pic Viewed"
        ' 
        ' cmiShowFileInfo
        ' 
        cmiShowFileInfo.Image = My.Resources.Resources.ImageImage
        cmiShowFileInfo.Name = "cmiShowFileInfo"
        cmiShowFileInfo.ShortcutKeyDisplayString = "?"
        cmiShowFileInfo.Size = New Size(232, 26)
        cmiShowFileInfo.Text = "Show Image Info"
        ' 
        ' cmiViewImage
        ' 
        cmiViewImage.Image = My.Resources.Resources.imageGo
        cmiViewImage.Name = "cmiViewImage"
        cmiViewImage.Size = New Size(232, 26)
        cmiViewImage.Text = "View Image"
        cmiViewImage.ToolTipText = "RightClick = Open File Location"
        ' 
        ' cmiSeparator3
        ' 
        cmiSeparator3.Name = "cmiSeparator3"
        cmiSeparator3.Size = New Size(229, 6)
        ' 
        ' cmiDeleteImage
        ' 
        cmiDeleteImage.Image = My.Resources.Resources.imageRemove
        cmiDeleteImage.Name = "cmiDeleteImage"
        cmiDeleteImage.Size = New Size(232, 26)
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
        ' lblCountdown
        ' 
        lblCountdown.Anchor = AnchorStyles.None
        lblCountdown.AutoSize = True
        lblCountdown.BackColor = SystemColors.Control
        lblCountdown.CausesValidation = False
        lblCountdown.ContextMenuStrip = CMPics
        lblCountdown.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCountdown.Location = New Point(86, 206)
        lblCountdown.Name = "lblCountdown"
        lblCountdown.Size = New Size(33, 19)
        lblCountdown.TabIndex = 0
        lblCountdown.Text = "888"
        lblCountdown.TextAlign = ContentAlignment.MiddleCenter
        lblCountdown.UseMnemonic = False
        ' 
        ' Pics
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Black
        CausesValidation = False
        ClientSize = New Size(300, 300)
        ControlBox = False
        Controls.Add(lblCountdown)
        Controls.Add(picbx)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = My.Resources.Resources.IconImage
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Pics"
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        TopMost = True
        CType(picbx, ComponentModel.ISupportInitialize).EndInit()
        CMPics.ResumeLayout(False)
        CMNavigation.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents CMPics As System.Windows.Forms.ContextMenuStrip
    Private cmiSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents lblCountdown As System.Windows.Forms.Label
	Private WithEvents picbx As System.Windows.Forms.PictureBox
	Private WithEvents cmiNavigation As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiDeleteImage As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickHide As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickRestore As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickShift As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiViewImage As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiTimer As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiShowFileInfo As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiFullScreen As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMNavigation As ContextMenuStrip
    Friend WithEvents CMIBackward As ToolStripMenuItem
    Friend WithEvents CMIForward As ToolStripMenuItem
    Friend WithEvents CMIRandom As ToolStripMenuItem
    Friend WithEvents CMIPrevious As ToolStripMenuItem
End Class