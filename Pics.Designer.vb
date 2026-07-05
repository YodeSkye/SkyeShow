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
        cmPics = New ContextMenuStrip(components)
        cmiFullScreen = New ToolStripMenuItem()
        cmiSeparator1 = New ToolStripSeparator()
        cmiQuickHide = New ToolStripMenuItem()
        cmiQuickShift = New ToolStripMenuItem()
        cmiQuickRestore = New ToolStripMenuItem()
        cmiSeparator2 = New ToolStripSeparator()
        cmiTimer = New ToolStripMenuItem()
        cmiAdvance = New ToolStripMenuItem()
        cmiShowFileInfo = New ToolStripMenuItem()
        cmiViewImage = New ToolStripMenuItem()
        cmiSeparator3 = New ToolStripSeparator()
        cmiDeleteImage = New ToolStripMenuItem()
        cmiSeparator4 = New ToolStripSeparator()
        cmiClose = New ToolStripMenuItem()
        lblCountdown = New Label()
        CType(picbx, ComponentModel.ISupportInitialize).BeginInit()
        cmPics.SuspendLayout()
        SuspendLayout()
        ' 
        ' picbx
        ' 
        picbx.BackColor = Color.Black
        picbx.ContextMenuStrip = cmPics
        picbx.Dock = DockStyle.Fill
        picbx.Location = New Point(0, 0)
        picbx.Margin = New Padding(3, 4, 3, 4)
        picbx.Name = "picbx"
        picbx.Size = New Size(300, 300)
        picbx.TabIndex = 0
        picbx.TabStop = False
        ' 
        ' cmPics
        ' 
        cmPics.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmPics.Items.AddRange(New ToolStripItem() {cmiFullScreen, cmiSeparator1, cmiQuickHide, cmiQuickShift, cmiQuickRestore, cmiSeparator2, cmiTimer, cmiAdvance, cmiShowFileInfo, cmiViewImage, cmiSeparator3, cmiDeleteImage, cmiSeparator4, cmiClose})
        cmPics.Name = "contextmenuImageForm"
        cmPics.RenderMode = ToolStripRenderMode.Professional
        cmPics.Size = New Size(204, 270)
        ' 
        ' cmiFullScreen
        ' 
        cmiFullScreen.Image = My.Resources.Resources.imageFullScreen
        cmiFullScreen.Name = "cmiFullScreen"
        cmiFullScreen.ShortcutKeyDisplayString = "ESC"
        cmiFullScreen.Size = New Size(203, 22)
        cmiFullScreen.Text = "Full Screen"
        ' 
        ' cmiSeparator1
        ' 
        cmiSeparator1.Name = "cmiSeparator1"
        cmiSeparator1.Size = New Size(200, 6)
        ' 
        ' cmiQuickHide
        ' 
        cmiQuickHide.Image = My.Resources.Resources.imageHide
        cmiQuickHide.Name = "cmiQuickHide"
        cmiQuickHide.ShortcutKeyDisplayString = "DELETE"
        cmiQuickHide.Size = New Size(203, 22)
        cmiQuickHide.Text = "Quick Hide"
        cmiQuickHide.ToolTipText = "RightClick = Perma Hide (Shift+Delete)"
        ' 
        ' cmiQuickShift
        ' 
        cmiQuickShift.Image = My.Resources.Resources.imageQuickShift
        cmiQuickShift.Name = "cmiQuickShift"
        cmiQuickShift.ShortcutKeyDisplayString = "INSERT"
        cmiQuickShift.Size = New Size(203, 22)
        cmiQuickShift.Text = "Quick Shift"
        ' 
        ' cmiQuickRestore
        ' 
        cmiQuickRestore.Image = My.Resources.Resources.imageRestore
        cmiQuickRestore.Name = "cmiQuickRestore"
        cmiQuickRestore.ShortcutKeyDisplayString = "HOME"
        cmiQuickRestore.Size = New Size(203, 22)
        cmiQuickRestore.Text = "Quick Restore"
        ' 
        ' cmiSeparator2
        ' 
        cmiSeparator2.Name = "cmiSeparator2"
        cmiSeparator2.Size = New Size(200, 6)
        ' 
        ' cmiTimer
        ' 
        cmiTimer.Image = My.Resources.Resources.imageTimer
        cmiTimer.Name = "cmiTimer"
        cmiTimer.ShortcutKeyDisplayString = "UPARROW"
        cmiTimer.Size = New Size(203, 22)
        cmiTimer.Text = "Timer"
        ' 
        ' cmiAdvance
        ' 
        cmiAdvance.Image = My.Resources.Resources.imageAdvance
        cmiAdvance.Name = "cmiAdvance"
        cmiAdvance.ShortcutKeyDisplayString = "-->, -V-, <--"
        cmiAdvance.Size = New Size(203, 22)
        cmiAdvance.Text = "Advance"
        cmiAdvance.ToolTipText = "LeftClick |RightArrow| = Forward" & vbCrLf & "CtrlLeftClick |DownArrow| = Random" & vbCrLf & "RightClick |LeftArrow| = Backward" & vbCrLf & "CtrlRightClick = Previous Image"
        ' 
        ' cmiShowFileInfo
        ' 
        cmiShowFileInfo.Image = My.Resources.Resources.ImageImage
        cmiShowFileInfo.Name = "cmiShowFileInfo"
        cmiShowFileInfo.ShortcutKeyDisplayString = "?"
        cmiShowFileInfo.Size = New Size(203, 22)
        cmiShowFileInfo.Text = "Show Image Info"
        ' 
        ' cmiViewImage
        ' 
        cmiViewImage.Image = My.Resources.Resources.imageGo
        cmiViewImage.Name = "cmiViewImage"
        cmiViewImage.Size = New Size(203, 22)
        cmiViewImage.Text = "View Image"
        cmiViewImage.ToolTipText = "RightClick = Open File Location"
        ' 
        ' cmiSeparator3
        ' 
        cmiSeparator3.Name = "cmiSeparator3"
        cmiSeparator3.Size = New Size(200, 6)
        ' 
        ' cmiDeleteImage
        ' 
        cmiDeleteImage.Image = My.Resources.Resources.imageRemove
        cmiDeleteImage.Name = "cmiDeleteImage"
        cmiDeleteImage.Size = New Size(203, 22)
        ' 
        ' cmiSeparator4
        ' 
        cmiSeparator4.Name = "cmiSeparator4"
        cmiSeparator4.Size = New Size(200, 6)
        ' 
        ' cmiClose
        ' 
        cmiClose.Image = My.Resources.Resources.imageClose
        cmiClose.Name = "cmiClose"
        cmiClose.ShortcutKeyDisplayString = "END"
        cmiClose.Size = New Size(203, 22)
        cmiClose.Text = "Close"
        ' 
        ' lblCountdown
        ' 
        lblCountdown.Anchor = AnchorStyles.None
        lblCountdown.AutoSize = True
        lblCountdown.BackColor = SystemColors.Control
        lblCountdown.CausesValidation = False
        lblCountdown.ContextMenuStrip = cmPics
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
        cmPics.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents cmPics As System.Windows.Forms.ContextMenuStrip
    Private cmiSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private cmiSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents lblCountdown As System.Windows.Forms.Label
	Private WithEvents picbx As System.Windows.Forms.PictureBox
	Private WithEvents cmiAdvance As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiDeleteImage As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickHide As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickRestore As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiQuickShift As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiViewImage As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiTimer As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiShowFileInfo As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiFullScreen As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiClose As System.Windows.Forms.ToolStripMenuItem
End Class