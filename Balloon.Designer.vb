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
        picbxIcon = New PictureBox()
        lblTitle = New Label()
        lblText = New Label()
        CType(picbxIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picbxIcon
        ' 
        picbxIcon.Location = New Point(7, 8)
        picbxIcon.Name = "picbxIcon"
        picbxIcon.Size = New Size(32, 32)
        picbxIcon.SizeMode = PictureBoxSizeMode.CenterImage
        picbxIcon.TabIndex = 0
        picbxIcon.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(44, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(36, 17)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Title"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.UseMnemonic = False
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.ImageAlign = ContentAlignment.TopLeft
        lblText.Location = New Point(7, 48)
        lblText.Name = "lblText"
        lblText.Size = New Size(31, 17)
        lblText.TabIndex = 2
        lblText.Text = "Text"
        lblText.UseMnemonic = False
        ' 
        ' Balloon
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(135, 58)
        ControlBox = False
        Controls.Add(lblText)
        Controls.Add(lblTitle)
        Controls.Add(picbxIcon)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Balloon"
        Padding = New Padding(0, 0, 2, 10)
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        TopMost = True
        CType(picbxIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
	Friend WithEvents lblTitle As System.Windows.Forms.Label
	Friend WithEvents picbxIcon As System.Windows.Forms.PictureBox
End Class