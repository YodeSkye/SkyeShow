<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Skye.UI.Label()
        Label2 = New Skye.UI.Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Image = My.Resources.Resources.imageApp
        Label1.ImageAlign = ContentAlignment.BottomRight
        Label1.Location = New Point(38, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 28)
        Label1.TabIndex = 0
        Label1.Text = "Skye"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ImageAlign = ContentAlignment.BottomRight
        Label2.Location = New Point(107, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 28)
        Label2.TabIndex = 1
        Label2.Text = "Show"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(200, 100)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Skye.UI.Label
    Friend WithEvents Label2 As Skye.UI.Label
End Class
