
Imports SkyeShow.My

Partial Friend Class Balloon

	' Form Events
	Friend Sub New()
		InitializeComponent()
		AddHandler LostFocus, AddressOf Balloon_LostFocus
		AddHandler PreviewKeyDown, AddressOf App.BalloonPreviewKeyDown
	End Sub
	Private Sub Balloon_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus, lblText.LostFocus, lblTitle.LostFocus, picbxIcon.LostFocus
		App.HideBalloon()
	End Sub

End Class