Friend Partial Class Balloon
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
		Me.picbxIcon = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblText = New System.Windows.Forms.Label()
		CType(Me.picbxIcon,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'picbxIcon
		'
		Me.picbxIcon.Location = New System.Drawing.Point(7, 8)
		Me.picbxIcon.Name = "picbxIcon"
		Me.picbxIcon.Size = New System.Drawing.Size(32, 32)
		Me.picbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.picbxIcon.TabIndex = 0
		Me.picbxIcon.TabStop = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = true
		Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitle.Location = New System.Drawing.Point(44, 14)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(36, 17)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.Text = "Title"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblTitle.UseMnemonic = False
		'
		'lblText
		'
		Me.lblText.AutoSize = true
		Me.lblText.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblText.Location = New System.Drawing.Point(7, 48)
		Me.lblText.Name = "lblText"
		Me.lblText.Size = New System.Drawing.Size(31, 17)
		Me.lblText.TabIndex = 2
		Me.lblText.Text = "Text"
		Me.lblText.UseMnemonic = False
		'
		'Balloon
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.AutoSize = true
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
		Me.ClientSize = New System.Drawing.Size(135, 58)
		Me.ControlBox = false
		Me.Controls.Add(Me.lblText)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.picbxIcon)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "Balloon"
		Me.Padding = New System.Windows.Forms.Padding(0, 0, 2, 10)
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.TopMost = True
		CType(Me.picbxIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Friend WithEvents lblText As System.Windows.Forms.Label
	Friend WithEvents lblTitle As System.Windows.Forms.Label
	Friend WithEvents picbxIcon As System.Windows.Forms.PictureBox
End Class