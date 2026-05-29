Friend Partial Class InfoForm
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
		Me.components = New System.ComponentModel.Container()
		Me.rtbMessage = New System.Windows.Forms.RichTextBox()
		Me.contextmenuRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.cmiCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.cmiSelectAll = New System.Windows.Forms.ToolStripMenuItem()
		Me.cmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnRefreshLog = New System.Windows.Forms.Button()
		Me.btnClearLog = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.tipInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.tbPostMessage = New System.Windows.Forms.TextBox()
		Me.contextmenuRTB.SuspendLayout
		Me.SuspendLayout
		'
		'rtbMessage
		'
		Me.rtbMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.rtbMessage.AutoWordSelection = true
		Me.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtbMessage.ContextMenuStrip = Me.contextmenuRTB
		Me.rtbMessage.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rtbMessage.HideSelection = false
		Me.rtbMessage.Location = New System.Drawing.Point(0, 0)
		Me.rtbMessage.Margin = New System.Windows.Forms.Padding(0)
		Me.rtbMessage.Name = "rtbMessage"
		Me.rtbMessage.ReadOnly = true
		Me.rtbMessage.ShortcutsEnabled = false
		Me.rtbMessage.ShowSelectionMargin = true
		Me.rtbMessage.Size = New System.Drawing.Size(584, 288)
		Me.rtbMessage.TabIndex = 0
		Me.rtbMessage.Text = "MESSAGE"
		Me.rtbMessage.WordWrap = False
		'
		'contextmenuRTB
		'
		Me.contextmenuRTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.contextmenuRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmiCopy, Me.cmiSelectAll, Me.cmiSaveAs})
		Me.contextmenuRTB.Name = "contextmenuRTB"
		Me.contextmenuRTB.Size = New System.Drawing.Size(174, 96)
		'
		'cmiCopy
		'
		Me.cmiCopy.Image = My.Resources.Resources.imageCopy
		Me.cmiCopy.Name = "cmiCopy"
		Me.cmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
		Me.cmiCopy.Size = New System.Drawing.Size(173, 22)
		Me.cmiCopy.Text = "Copy"
		'
		'cmiSelectAll
		'
		Me.cmiSelectAll.Image = My.Resources.Resources.imageSelectAll
		Me.cmiSelectAll.Name = "cmiSelectAll"
		Me.cmiSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
		Me.cmiSelectAll.Size = New System.Drawing.Size(173, 22)
		Me.cmiSelectAll.Text = "Select All"
		'
		'cmiSaveAs
		'
		Me.cmiSaveAs.Image = My.Resources.Resources.imageSave
		Me.cmiSaveAs.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.cmiSaveAs.Name = "cmiSaveAs"
		Me.cmiSaveAs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
		Me.cmiSaveAs.Size = New System.Drawing.Size(173, 22)
		Me.cmiSaveAs.Text = "Save As"
		'
		'btnRefreshLog
		'
		Me.btnRefreshLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnRefreshLog.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRefreshLog.ForeColor = System.Drawing.Color.Navy
		Me.btnRefreshLog.Image = My.Resources.Resources.imageQuickShift
		Me.btnRefreshLog.Location = New System.Drawing.Point(538, 321)
		Me.btnRefreshLog.Name = "btnRefreshLog"
		Me.btnRefreshLog.Size = New System.Drawing.Size(34, 24)
		Me.btnRefreshLog.TabIndex = 1
		Me.btnRefreshLog.TabStop = false
		Me.btnRefreshLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.tipInfo.SetToolTip(Me.btnRefreshLog, "Refresh")
		Me.btnRefreshLog.UseVisualStyleBackColor = true
		Me.btnRefreshLog.Visible = False
		'
		'btnClearLog
		'
		Me.btnClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnClearLog.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClearLog.ForeColor = System.Drawing.Color.Navy
		Me.btnClearLog.Image = My.Resources.Resources.imageRemove
		Me.btnClearLog.Location = New System.Drawing.Point(12, 321)
		Me.btnClearLog.Name = "btnClearLog"
		Me.btnClearLog.Size = New System.Drawing.Size(34, 24)
		Me.btnClearLog.TabIndex = 1
		Me.btnClearLog.TabStop = false
		Me.btnClearLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.tipInfo.SetToolTip(Me.btnClearLog, "Clear Log")
		Me.btnClearLog.UseVisualStyleBackColor = true
		Me.btnClearLog.Visible = False
		'
		'btnClose
		'
		Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.Navy
		Me.btnClose.Image = My.Resources.Resources.imageClose
		Me.btnClose.Location = New System.Drawing.Point(164, 316)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(256, 34)
		Me.btnClose.TabIndex = 1
		Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.tipInfo.SetToolTip(Me.btnClose, "Close Window")
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'tipInfo
		'
		Me.tipInfo.AutomaticDelay = 250
		Me.tipInfo.AutoPopDelay = 10000
		Me.tipInfo.InitialDelay = 250
		Me.tipInfo.ReshowDelay = 50
		'
		'tbPostMessage
		'
		Me.tbPostMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.tbPostMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbPostMessage.ContextMenuStrip = Me.contextmenuRTB
		Me.tbPostMessage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tbPostMessage.HideSelection = false
		Me.tbPostMessage.Location = New System.Drawing.Point(13, 294)
		Me.tbPostMessage.Name = "tbPostMessage"
		Me.tbPostMessage.ReadOnly = true
		Me.tbPostMessage.ShortcutsEnabled = false
		Me.tbPostMessage.Size = New System.Drawing.Size(560, 18)
		Me.tbPostMessage.TabIndex = 0
		Me.tbPostMessage.TabStop = false
		Me.tbPostMessage.Text = "POSTMESSAGE"
		Me.tbPostMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'InfoForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
		Me.ClientSize = New System.Drawing.Size(584, 362)
		Me.Controls.Add(Me.rtbMessage)
		Me.Controls.Add(Me.btnRefreshLog)
		Me.Controls.Add(Me.btnClearLog)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.tbPostMessage)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.KeyPreview = true
		Me.MinimumSize = New System.Drawing.Size(450, 300)
		Me.Name = "InfoForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "TITLE"
		Me.contextmenuRTB.ResumeLayout(False)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Public WithEvents btnClearLog As System.Windows.Forms.Button
	Public WithEvents btnRefreshLog As System.Windows.Forms.Button
	Private tipInfo As System.Windows.Forms.ToolTip
	Private WithEvents cmiSaveAs As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiSelectAll As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents cmiCopy As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents contextmenuRTB As System.Windows.Forms.ContextMenuStrip
	Public WithEvents tbPostMessage As System.Windows.Forms.TextBox
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents rtbMessage As System.Windows.Forms.RichTextBox
End Class