Friend Partial Class Balloon
'Declarations
'Form Events
	Friend Sub New
		Me.InitializeComponent
		AddHandler Me.LostFocus, AddressOf BalloonLostFocus
		AddHandler Me.PreviewKeyDown, AddressOf My.App.BalloonPreviewKeyDown
	End Sub
	'Procedures
	Private Sub BalloonLostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LostFocus, lblText.LostFocus, lblTitle.LostFocus, picbxIcon.LostFocus
		My.App.HideBalloon()
	End Sub
End Class