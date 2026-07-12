
Imports System.ComponentModel
Imports Skye.UI
Imports SkyeShow.My

Partial Friend Class MainForm

#Region "Pics"

    ' Control Events
    Private Sub BtnlvPicFoldersMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnlvPicFolders.MouseUp
        If e.Button = MouseButtons.Left Then ToggleFolderList(My.App.GetFilesType.Pics)
    End Sub
    Private Sub BtnPicTimerEnabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnPicTimerEnabled.Click
        If App.FrmPicsVisible Then
            App.frmPics.ToggleTimer()
        Else
            App.PicTimerEnabled = Not App.PicTimerEnabled
        End If
        ShowSettings()
        App.SetSave()
    End Sub
    Private Sub RadbtnPicPlayModeLinearClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicPlayModeLinear.Click
        My.App.PicPlayMode = My.App.PlayMode.Linear
        App.SetSave()
    End Sub
    Private Sub RadbtnPicPlayModeLinearWithRandomStartClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicPlayModeLinearWithRandomStart.Click
        My.App.PicPlayMode = My.App.PlayMode.LinearWithRandomStart
        App.SetSave()
    End Sub
    Private Sub RadbtnPicPlayModeRandomClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicPlayModeRandom.Click
        My.App.PicPlayMode = My.App.PlayMode.Random
        App.SetSave()
    End Sub
    Private Sub RadbtnPicJustifyClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicJustifyRight.Click, radbtnPicJustifyLeft.Click, radbtnPicJustifyCenter.Click
        Select Case CType(sender, RadioButton).Name
            Case Me.radbtnPicJustifyLeft.Name : My.App.PicJustify = My.App.LocationJustify.Left
            Case Me.radbtnPicJustifyCenter.Name : My.App.PicJustify = My.App.LocationJustify.Center
            Case Me.radbtnPicJustifyRight.Name : My.App.PicJustify = My.App.LocationJustify.Right
        End Select
        App.SetSave()
    End Sub
    Private Sub RadbtnPicLocationModeClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicLocationModeTopRightInside.Click, radbtnPicLocationModeTopRight.Click, radbtnPicLocationModeTopLeftInside.Click, radbtnPicLocationModeTopLeft.Click, radbtnPicLocationModeTopCenterRightInside.Click, radbtnPicLocationModeTopCenterRight.Click, radbtnPicLocationModeTopCenterLeftInside.Click, radbtnPicLocationModeTopCenterLeft.Click, radbtnPicLocationModeTopCenterInside.Click, radbtnPicLocationModeTopCenter.Click, radbtnPicLocationModeRightCenterTopInside.Click, radbtnPicLocationModeRightCenterTop.Click, radbtnPicLocationModeRightCenterInside.Click, radbtnPicLocationModeRightCenterBottomInside.Click, radbtnPicLocationModeRightCenterBottom.Click, radbtnPicLocationModeRightCenter.Click, radbtnPicLocationModeManual.Click, radbtnPicLocationModeLeftCenterTopInside.Click, radbtnPicLocationModeLeftCenterTop.Click, radbtnPicLocationModeLeftCenterInside.Click, radbtnPicLocationModeLeftCenterBottomInside.Click, radbtnPicLocationModeLeftCenterBottom.Click, radbtnPicLocationModeLeftCenter.Click, radbtnPicLocationModeBottomRightInside.Click, radbtnPicLocationModeBottomRight.Click, radbtnPicLocationModeBottomLeftInside.Click, radbtnPicLocationModeBottomLeft.Click, radbtnPicLocationModeBottomCenterRightInside.Click, radbtnPicLocationModeBottomCenterRight.Click, radbtnPicLocationModeBottomCenterLeftInside.Click, radbtnPicLocationModeBottomCenterLeft.Click, radbtnPicLocationModeBottomCenterInside.Click, radbtnPicLocationModeBottomCenter.Click
        For Each c As Control In Me.gpbxPicLocationMode.Controls
            If sender Is c Then
                Select Case c.Name
                    Case "radbtnPicLocationModeManual" : My.App.PicLocationMode = My.App.LocationMode.Manual
                    Case "radbtnPicLocationModeTopLeft" : My.App.PicLocationMode = My.App.LocationMode.TopLeft
                    Case "radbtnPicLocationModeTopCenterLeft" : My.App.PicLocationMode = My.App.LocationMode.TopCenterLeft
                    Case "radbtnPicLocationModeTopCenter" : My.App.PicLocationMode = My.App.LocationMode.TopCenter
                    Case "radbtnPicLocationModeTopCenterRight" : My.App.PicLocationMode = My.App.LocationMode.TopCenterRight
                    Case "radbtnPicLocationModeTopRight" : My.App.PicLocationMode = My.App.LocationMode.TopRight
                    Case "radbtnPicLocationModeRightCenterTop" : My.App.PicLocationMode = My.App.LocationMode.RightCenterTop
                    Case "radbtnPicLocationModeRightCenter" : My.App.PicLocationMode = My.App.LocationMode.RightCenter
                    Case "radbtnPicLocationModeRightCenterBottom" : My.App.PicLocationMode = My.App.LocationMode.RightCenterBottom
                    Case "radbtnPicLocationModeBottomRight" : My.App.PicLocationMode = My.App.LocationMode.BottomRight
                    Case "radbtnPicLocationModeBottomCenterRight" : My.App.PicLocationMode = My.App.LocationMode.BottomCenterRight
                    Case "radbtnPicLocationModeBottomCenter" : My.App.PicLocationMode = My.App.LocationMode.BottomCenter
                    Case "radbtnPicLocationModeBottomCenterLeft" : My.App.PicLocationMode = My.App.LocationMode.BottomCenterLeft
                    Case "radbtnPicLocationModeBottomLeft" : My.App.PicLocationMode = My.App.LocationMode.BottomLeft
                    Case "radbtnPicLocationModeLeftCenterBottom" : My.App.PicLocationMode = My.App.LocationMode.LeftCenterBottom
                    Case "radbtnPicLocationModeLeftCenter" : My.App.PicLocationMode = My.App.LocationMode.LeftCenter
                    Case "radbtnPicLocationModeLeftCenterTop" : My.App.PicLocationMode = My.App.LocationMode.LeftCenterTop
                    Case "radbtnPicLocationModeTopLeftInside" : My.App.PicLocationMode = My.App.LocationMode.TopLeftInside
                    Case "radbtnPicLocationModeTopCenterLeftInside" : My.App.PicLocationMode = My.App.LocationMode.TopCenterLeftInside
                    Case "radbtnPicLocationModeTopCenterInside" : My.App.PicLocationMode = My.App.LocationMode.TopCenterInside
                    Case "radbtnPicLocationModeTopCenterRightInside" : My.App.PicLocationMode = My.App.LocationMode.TopCenterRightInside
                    Case "radbtnPicLocationModeTopRightInside" : My.App.PicLocationMode = My.App.LocationMode.TopRightInside
                    Case "radbtnPicLocationModeRightCenterTopInside" : My.App.PicLocationMode = My.App.LocationMode.RightCenterTopInside
                    Case "radbtnPicLocationModeRightCenterInside" : My.App.PicLocationMode = My.App.LocationMode.RightCenterInside
                    Case "radbtnPicLocationModeRightCenterBottomInside" : My.App.PicLocationMode = My.App.LocationMode.RightCenterBottomInside
                    Case "radbtnPicLocationModeBottomRightInside" : My.App.PicLocationMode = My.App.LocationMode.BottomRightInside
                    Case "radbtnPicLocationModeBottomCenterRightInside" : My.App.PicLocationMode = My.App.LocationMode.BottomCenterRightInside
                    Case "radbtnPicLocationModeBottomCenterInside" : My.App.PicLocationMode = My.App.LocationMode.BottomCenterInside
                    Case "radbtnPicLocationModeBottomCenterLeftInside" : My.App.PicLocationMode = My.App.LocationMode.BottomCenterLeftInside
                    Case "radbtnPicLocationModeBottomLeftInside" : My.App.PicLocationMode = My.App.LocationMode.BottomLeftInside
                    Case "radbtnPicLocationModeLeftCenterBottomInside" : My.App.PicLocationMode = My.App.LocationMode.LeftCenterBottomInside
                    Case "radbtnPicLocationModeLeftCenterInside" : My.App.PicLocationMode = My.App.LocationMode.LeftCenterInside
                    Case "radbtnPicLocationModeLeftCenterTopInside" : My.App.PicLocationMode = My.App.LocationMode.LeftCenterTopInside
                End Select
                If My.App.FrmPicsVisible Then My.App.frmPics.DrawImage()
                App.SetSave()
            End If
        Next
    End Sub
    Private Sub RadBtnPicTimerCountdownLocationModeClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnPicTimerCountdownLocationModeTopRight.Click, radbtnPicTimerCountdownLocationModeTopLeft.Click, radbtnPicTimerCountdownLocationModeTopCenterRight.Click, radbtnPicTimerCountdownLocationModeTopCenterLeft.Click, radbtnPicTimerCountdownLocationModeTopCenter.Click, radbtnPicTimerCountdownLocationModeRightCenterTop.Click, radbtnPicTimerCountdownLocationModeRightCenterBottom.Click, radbtnPicTimerCountdownLocationModeRightCenter.Click, radbtnPicTimerCountdownLocationModeLeftCenterTop.Click, radbtnPicTimerCountdownLocationModeLeftCenterBottom.Click, radbtnPicTimerCountdownLocationModeLeftCenter.Click, radbtnPicTimerCountdownLocationModeBottomRight.Click, radbtnPicTimerCountdownLocationModeBottomLeft.Click, radbtnPicTimerCountdownLocationModeBottomCenterRight.Click, radbtnPicTimerCountdownLocationModeBottomCenterLeft.Click, radbtnPicTimerCountdownLocationModeBottomCenter.Click
        For Each c As Control In Me.gpbxPicTimerCountdownLocationMode.Controls
            If sender Is c Then
                Select Case c.Name
                    Case "radbtnPicTimerCountdownLocationModeTopLeft" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.TopLeft
                    Case "radbtnPicTimerCountdownLocationModeTopCenterLeft" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.TopCenterLeft
                    Case "radbtnPicTimerCountdownLocationModeTopCenter" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.TopCenter
                    Case "radbtnPicTimerCountdownLocationModeTopCenterRight" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.TopCenterRight
                    Case "radbtnPicTimerCountdownLocationModeTopRight" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.TopRight
                    Case "radbtnPicTimerCountdownLocationModeRightCenterTop" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.RightCenterTop
                    Case "radbtnPicTimerCountdownLocationModeRightCenter" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.RightCenter
                    Case "radbtnPicTimerCountdownLocationModeRightCenterBottom" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.RightCenterBottom
                    Case "radbtnPicTimerCountdownLocationModeBottomRight" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.BottomRight
                    Case "radbtnPicTimerCountdownLocationModeBottomCenterRight" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.BottomCenterRight
                    Case "radbtnPicTimerCountdownLocationModeBottomCenter" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.BottomCenter
                    Case "radbtnPicTimerCountdownLocationModeBottomCenterLeft" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.BottomCenterLeft
                    Case "radbtnPicTimerCountdownLocationModeBottomLeft" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.BottomLeft
                    Case "radbtnPicTimerCountdownLocationModeLeftCenterBottom" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.LeftCenterBottom
                    Case "radbtnPicTimerCountdownLocationModeLeftCenter" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.LeftCenter
                    Case "radbtnPicTimerCountdownLocationModeLeftCenterTop" : My.App.PicTimerCountdownLocationMode = My.App.LocationMode.LeftCenterTop
                End Select
                If My.App.FrmPicsVisible Then My.App.frmPics.ShowImageTimerCountdown()
                App.SetSave()
            End If
        Next
    End Sub
    Private Sub ChBxPicTimerCountdownClick(sender As Object, e As EventArgs) Handles chbxPicTimerCountdown.Click
        My.App.PicTimerCountdown = Not My.App.PicTimerCountdown
        ShowSettingsImages()
        If My.App.FrmPicsVisible Then My.App.frmPics.SetImageTimerCountdown()
        App.SetSave()
    End Sub
    Private Sub ChbxPicAutoViewClick(ByVal sender As Object, ByVal e As EventArgs) Handles chbxPicAutoView.Click
        My.App.PicAutoView = Not My.App.PicAutoView
        App.SetSave()
    End Sub
    Private Sub ChbxPicLockFullScreenClick(ByVal sender As Object, ByVal e As EventArgs) Handles chbxPicLockFullScreen.Click
        My.App.PicLockFullScreen = Not My.App.PicLockFullScreen
        App.SetSave()
    End Sub
    Private Sub ChbxPicTimerAutoStartClick(ByVal sender As Object, ByVal e As EventArgs) Handles chbxPicTimerAutoStart.Click
        My.App.PicTimerAutoStart = Not My.App.PicTimerAutoStart
        App.SetSave()
    End Sub
    Private Sub TxbxPicTimerIntervalValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txbxPicTimerInterval.Validating
        If Int(Val(Me.txbxPicTimerInterval.Text)) < 1 Then Me.txbxPicTimerInterval.Text = "1"
        If Int(Val(Me.txbxPicTimerInterval.Text)) > 86400 Then Me.txbxPicTimerInterval.Text = "86400"
    End Sub
    Private Sub TxbxPicTimerIntervalValidated(ByVal sender As Object, ByVal e As EventArgs) Handles txbxPicTimerInterval.Validated
        My.App.PicTimerInterval = CType(Int(Val(Me.txbxPicTimerInterval.Text)), Integer)
        If My.App.FrmPicsVisible Then My.App.frmPics.SetTimer()
        Me.txbxPicTimerInterval.SelectAll()
        App.SetSave()
    End Sub

#End Region

#Region "Vids"

    ' Control Events
    Private Sub BtnlvVidFoldersMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnlvVidFolders.MouseUp
        If e.Button = MouseButtons.Left Then ToggleFolderList(My.App.GetFilesType.Vids)
    End Sub
    Private Sub BtnVidMuteClick(ByVal sender As Object, ByVal e As EventArgs)
        My.App.VidVolumeMute = Not My.App.VidVolumeMute
        ShowSettings()
        App.SetSave()
    End Sub
    Private Sub RadbtnVidPlayModeLinearClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnVidPlayModeLinear.Click
        My.App.VidPlayMode = My.App.PlayMode.Linear
        App.SetSave()
    End Sub
    Private Sub RadbtnVidPlayModeLinearWithRandomStartClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnVidPlayModeLinearWithRandomStart.Click
        My.App.VidPlayMode = My.App.PlayMode.LinearWithRandomStart
        App.SetSave()
    End Sub
    Private Sub RadbtnVidPlayModeRandomClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnVidPlayModeRandom.Click
        My.App.VidPlayMode = My.App.PlayMode.Random
        App.SetSave()
    End Sub
    Private Sub RadbtnVidScaleClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnVideoScaleFit.Click, radbtnVideoScale75.Click, radbtnVideoScale66.Click, radbtnVideoScale50.Click, radbtnVideoScale33.Click, radbtnVideoScale25.Click, radbtnVideoScale100.Click, radbtnVideoScale10.Click
        If Me.radbtnVideoScale10.Checked Then : My.App.VidScale = 0.1
        ElseIf Me.radbtnVideoScale25.Checked Then : My.App.VidScale = 0.25
        ElseIf Me.radbtnVideoScale33.Checked Then : My.App.VidScale = 0.3333
        ElseIf Me.radbtnVideoScale50.Checked Then : My.App.VidScale = 0.5
        ElseIf Me.radbtnVideoScale66.Checked Then : My.App.VidScale = 0.6666
        ElseIf Me.radbtnVideoScale75.Checked Then : My.App.VidScale = 0.75
        ElseIf Me.radbtnVideoScale100.Checked Then : My.App.VidScale = 1
        ElseIf Me.radbtnVideoScaleFit.Checked Then : My.App.VidScale = 0
        End If
        If My.App.FrmVidsVisible Then My.App.FrmVids.SetSize()
        App.SetSave()
    End Sub
    Private Sub RadbtnVidLocationModeClick(ByVal sender As Object, ByVal e As EventArgs) Handles radbtnVidLocationModeTopRightInside.Click, radbtnVidLocationModeTopRight.Click, radbtnVidLocationModeTopLeftInside.Click, radbtnVidLocationModeTopLeft.Click, radbtnVidLocationModeTopCenterRightInside.Click, radbtnVidLocationModeTopCenterRight.Click, radbtnVidLocationModeTopCenterLeftInside.Click, radbtnVidLocationModeTopCenterLeft.Click, radbtnVidLocationModeTopCenterInside.Click, radbtnVidLocationModeTopCenter.Click, radbtnVidLocationModeRightCenterTopInside.Click, radbtnVidLocationModeRightCenterTop.Click, radbtnVidLocationModeRightCenterInside.Click, radbtnVidLocationModeRightCenterBottomInside.Click, radbtnVidLocationModeRightCenterBottom.Click, radbtnVidLocationModeRightCenter.Click, radbtnVidLocationModeManual.Click, radbtnVidLocationModeLeftCenterTopInside.Click, radbtnVidLocationModeLeftCenterTop.Click, radbtnVidLocationModeLeftCenterInside.Click, radbtnVidLocationModeLeftCenterBottomInside.Click, radbtnVidLocationModeLeftCenterBottom.Click, radbtnVidLocationModeLeftCenter.Click, radbtnVidLocationModeBottomRightInside.Click, radbtnVidLocationModeBottomRight.Click, radbtnVidLocationModeBottomLeftInside.Click, radbtnVidLocationModeBottomLeft.Click, radbtnVidLocationModeBottomCenterRightInside.Click, radbtnVidLocationModeBottomCenterRight.Click, radbtnVidLocationModeBottomCenterLeftInside.Click, radbtnVidLocationModeBottomCenterLeft.Click, radbtnVidLocationModeBottomCenterInside.Click, radbtnVidLocationModeBottomCenter.Click
        For Each c As Control In Me.gpbxVidLocationMode.Controls
            If sender Is c Then
                Select Case c.Name
                    Case "radbtnVidLocationModeManual" : My.App.VidLocationMode = My.App.LocationMode.Manual
                    Case "radbtnVidLocationModeTopLeft" : My.App.VidLocationMode = My.App.LocationMode.TopLeft
                    Case "radbtnVidLocationModeTopCenterLeft" : My.App.VidLocationMode = My.App.LocationMode.TopCenterLeft
                    Case "radbtnVidLocationModeTopCenter" : My.App.VidLocationMode = My.App.LocationMode.TopCenter
                    Case "radbtnVidLocationModeTopCenterRight" : My.App.VidLocationMode = My.App.LocationMode.TopCenterRight
                    Case "radbtnVidLocationModeTopRight" : My.App.VidLocationMode = My.App.LocationMode.TopRight
                    Case "radbtnVidLocationModeRightCenterTop" : My.App.VidLocationMode = My.App.LocationMode.RightCenterTop
                    Case "radbtnVidLocationModeRightCenter" : My.App.VidLocationMode = My.App.LocationMode.RightCenter
                    Case "radbtnVidLocationModeRightCenterBottom" : My.App.VidLocationMode = My.App.LocationMode.RightCenterBottom
                    Case "radbtnVidLocationModeBottomRight" : My.App.VidLocationMode = My.App.LocationMode.BottomRight
                    Case "radbtnVidLocationModeBottomCenterRight" : My.App.VidLocationMode = My.App.LocationMode.BottomCenterRight
                    Case "radbtnVidLocationModeBottomCenter" : My.App.VidLocationMode = My.App.LocationMode.BottomCenter
                    Case "radbtnVidLocationModeBottomCenterLeft" : My.App.VidLocationMode = My.App.LocationMode.BottomCenterLeft
                    Case "radbtnVidLocationModeBottomLeft" : My.App.VidLocationMode = My.App.LocationMode.BottomLeft
                    Case "radbtnVidLocationModeLeftCenterBottom" : My.App.VidLocationMode = My.App.LocationMode.LeftCenterBottom
                    Case "radbtnVidLocationModeLeftCenter" : My.App.VidLocationMode = My.App.LocationMode.LeftCenter
                    Case "radbtnVidLocationModeLeftCenterTop" : My.App.VidLocationMode = My.App.LocationMode.LeftCenterTop
                    Case "radbtnVidLocationModeTopLeftInside" : My.App.VidLocationMode = My.App.LocationMode.TopLeftInside
                    Case "radbtnVidLocationModeTopCenterLeftInside" : My.App.VidLocationMode = My.App.LocationMode.TopCenterLeftInside
                    Case "radbtnVidLocationModeTopCenterInside" : My.App.VidLocationMode = My.App.LocationMode.TopCenterInside
                    Case "radbtnVidLocationModeTopCenterRightInside" : My.App.VidLocationMode = My.App.LocationMode.TopCenterRightInside
                    Case "radbtnVidLocationModeTopRightInside" : My.App.VidLocationMode = My.App.LocationMode.TopRightInside
                    Case "radbtnVidLocationModeRightCenterTopInside" : My.App.VidLocationMode = My.App.LocationMode.RightCenterTopInside
                    Case "radbtnVidLocationModeRightCenterInside" : My.App.VidLocationMode = My.App.LocationMode.RightCenterInside
                    Case "radbtnVidLocationModeRightCenterBottomInside" : My.App.VidLocationMode = My.App.LocationMode.RightCenterBottomInside
                    Case "radbtnVidLocationModeBottomRightInside" : My.App.VidLocationMode = My.App.LocationMode.BottomRightInside
                    Case "radbtnVidLocationModeBottomCenterRightInside" : My.App.VidLocationMode = My.App.LocationMode.BottomCenterRightInside
                    Case "radbtnVidLocationModeBottomCenterInside" : My.App.VidLocationMode = My.App.LocationMode.BottomCenterInside
                    Case "radbtnVidLocationModeBottomCenterLeftInside" : My.App.VidLocationMode = My.App.LocationMode.BottomCenterLeftInside
                    Case "radbtnVidLocationModeBottomLeftInside" : My.App.VidLocationMode = My.App.LocationMode.BottomLeftInside
                    Case "radbtnVidLocationModeLeftCenterBottomInside" : My.App.VidLocationMode = My.App.LocationMode.LeftCenterBottomInside
                    Case "radbtnVidLocationModeLeftCenterInside" : My.App.VidLocationMode = My.App.LocationMode.LeftCenterInside
                    Case "radbtnVidLocationModeLeftCenterTopInside" : My.App.VidLocationMode = My.App.LocationMode.LeftCenterTopInside
                End Select
                If My.App.FrmVidsVisible Then My.App.FrmVids.SetSize()
                App.SetSave()
            End If
        Next
    End Sub
    Private Sub RadbtnVidTimeLocationModeClick(sender As Object, e As EventArgs) Handles radbtnVidTimeLocationModeTopRight.Click, radbtnVidTimeLocationModeTopLeft.Click, radbtnVidTimeLocationModeTopCenterRight.Click, radbtnVidTimeLocationModeTopCenterLeft.Click, radbtnVidTimeLocationModeTopCenter.Click, radbtnVidTimeLocationModeRightCenterTop.Click, radbtnVidTimeLocationModeRightCenterBottom.Click, radbtnVidTimeLocationModeRightCenter.Click, radbtnVidTimeLocationModeLeftCenterTop.Click, radbtnVidTimeLocationModeLeftCenterBottom.Click, radbtnVidTimeLocationModeLeftCenter.Click, radbtnVidTimeLocationModeBottomRight.Click, radbtnVidTimeLocationModeBottomLeft.Click, radbtnVidTimeLocationModeBottomCenterRight.Click, radbtnVidTimeLocationModeBottomCenterLeft.Click, radbtnVidTimeLocationModeBottomCenter.Click
        For Each c As Control In Me.grbxVidTimeLocationMode.Controls
            If sender Is c Then
                Select Case c.Name
                    Case "radbtnVidTimeLocationModeTopLeft" : My.App.VidTimeLocationMode = My.App.LocationMode.TopLeft
                    Case "radbtnVidTimeLocationModeTopCenterLeft" : My.App.VidTimeLocationMode = My.App.LocationMode.TopCenterLeft
                    Case "radbtnVidTimeLocationModeTopCenter" : My.App.VidTimeLocationMode = My.App.LocationMode.TopCenter
                    Case "radbtnVidTimeLocationModeTopCenterRight" : My.App.VidTimeLocationMode = My.App.LocationMode.TopCenterRight
                    Case "radbtnVidTimeLocationModeTopRight" : My.App.VidTimeLocationMode = My.App.LocationMode.TopRight
                    Case "radbtnVidTimeLocationModeRightCenterTop" : My.App.VidTimeLocationMode = My.App.LocationMode.RightCenterTop
                    Case "radbtnVidTimeLocationModeRightCenter" : My.App.VidTimeLocationMode = My.App.LocationMode.RightCenter
                    Case "radbtnVidTimeLocationModeRightCenterBottom" : My.App.VidTimeLocationMode = My.App.LocationMode.RightCenterBottom
                    Case "radbtnVidTimeLocationModeBottomRight" : My.App.VidTimeLocationMode = My.App.LocationMode.BottomRight
                    Case "radbtnVidTimeLocationModeBottomCenterRight" : My.App.VidTimeLocationMode = My.App.LocationMode.BottomCenterRight
                    Case "radbtnVidTimeLocationModeBottomCenter" : My.App.VidTimeLocationMode = My.App.LocationMode.BottomCenter
                    Case "radbtnVidTimeLocationModeBottomCenterLeft" : My.App.VidTimeLocationMode = My.App.LocationMode.BottomCenterLeft
                    Case "radbtnVidTimeLocationModeBottomLeft" : My.App.VidTimeLocationMode = My.App.LocationMode.BottomLeft
                    Case "radbtnVidTimeLocationModeLeftCenterBottom" : My.App.VidTimeLocationMode = My.App.LocationMode.LeftCenterBottom
                    Case "radbtnVidTimeLocationModeLeftCenter" : My.App.VidTimeLocationMode = My.App.LocationMode.LeftCenter
                    Case "radbtnVidTimeLocationModeLeftCenterTop" : My.App.VidTimeLocationMode = My.App.LocationMode.LeftCenterTop
                End Select
                If My.App.FrmVidsVisible Then My.App.FrmVids.ShowVideoTime()
                App.SetSave()
            End If
        Next
    End Sub
    Private Sub ChbxVidAutoViewClick(ByVal sender As Object, ByVal e As EventArgs) Handles chbxVidAutoView.Click
        My.App.VidAutoView = Not My.App.VidAutoView
        App.SetSave()
    End Sub
    Private Sub ChbxVidLockFullScreenClick(ByVal sender As Object, ByVal e As EventArgs) Handles chbxVidLockFullScreen.Click
        My.App.VidLockFullScreen = Not My.App.VidLockFullScreen
        App.SetSave()
    End Sub
    Private Sub ChbkVidMuteClick(sender As Object, e As EventArgs) Handles chbkVidMute.Click
        App.VidVolumeMute = chbkVidMute.Checked
        UpdateSettingsVids()
        If App.FrmVids IsNot Nothing Then App.FrmVids.SetVolume()
        App.SetSave()
    End Sub
    Private Sub ChbxVidTimeClick(sender As Object, e As EventArgs) Handles chbxVidTime.Click
        My.App.VidTime = Me.chbxVidTime.Checked
        ShowSettingsVideos()
        If My.App.FrmVidsVisible Then My.App.FrmVids.SetVideoTime()
        App.SetSave()
    End Sub
    Private Sub CobxVidTimeDisplayModeSelectionChangeCommitted(sender As Object, e As EventArgs) Handles cobxVidTimeDisplayMode.SelectionChangeCommitted
        My.App.VidTimeDisplayMode = CType(Me.cobxVidTimeDisplayMode.SelectedIndex, My.App.VideoPositionMode)
        If My.App.FrmVidsVisible Then My.App.FrmVids.ShowVideoTime()
        App.SetSave()
    End Sub

#End Region

    ' Declarations
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend BackgroundworkerGetFiles As New System.ComponentModel.BackgroundWorker
    Private mMove As Boolean = False
    Private mOffset, mPosition As Point
    Private nonNumberEntered As Boolean
    Private suppressPageSelection As Boolean = False
    Private cmListCurrentSourceControl As String
    Private cmiSettingListEnableItemLastIndex As Integer
    Private folderbrowser As New FolderBrowserDialog
    Private uiWPFileBrowser As New OpenFileDialog
    Private GenerateImageListType As My.App.GetFilesMode
    Private GenerateImageListStartTime As TimeSpan
    Private GenerateImageListEndTime As TimeSpan
    Private GenerateVideoListType As My.App.GetFilesMode
    Private GenerateVideoListStartTime As TimeSpan
    Private GenerateVideoListEndTime As TimeSpan
    Private ImageActiveOnRefresh, VideoActiveOnRefresh As Boolean

    ' Form Events
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            Select Case m.Msg
                Case Skye.WinAPI.WM_SYSCOMMAND
                    Select Case CInt(m.WParam)
                        Case Skye.WinAPI.SC_CLOSE
#If DEBUG Then
                            My.App.CloseApp()
#Else
							HideForm
#End If
                        Case Else : MyBase.WndProc(m)
                    End Select
                Case Skye.WinAPI.WM_HOTKEY
                    My.App.PerformHotKeyAction(m.WParam.ToInt32)
                    MyBase.WndProc(m)
                Case Else : MyBase.WndProc(m)
            End Select
        Catch ex As Exception : My.App.WriteToLog("MainForm WndProc Handler Error" + Chr(13) + ex.ToString)
        End Try
    End Sub
    Friend Sub New()

        ' Initialize Locals
        InitializeComponent()
        folderbrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        folderbrowser.ShowNewFolderButton = False
        uiWPFileBrowser.Title = "Select An Image..."
        uiWPFileBrowser.DefaultExt = "jpg"
        uiWPFileBrowser.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png;*.tif;*.tiff"

        ' Initialize Form
        Text = "Settings For " + My.Application.Info.Title + "  v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        ILPageSelector.Images.Add(My.Resources.Resources.ImageApp48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageImage48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageVideo48)
        LVPageSelector.Items.Add(New ListViewItem("App", 0))
        LVPageSelector.Items.Add(New ListViewItem("Pics", 1))
        LVPageSelector.Items.Add(New ListViewItem("Vids", 2))
        LVPageSelector.Items(0).Selected = True
        lvPicFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        lvPicFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        lvPicFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        lvVidFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        lvVidFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        lvVidFolders.Columns.Add(Nothing, 0, HorizontalAlignment.Center)
        For Each thm As Skye.UI.SkyeTheme In SkyeThemes.AllThemes
            CoBoxTheme.Items.Add(thm.Name)
        Next
        For Each mode As App.VideoPositionMode In [Enum].GetValues(Of App.VideoPositionMode)()
            cobxVidTimeDisplayMode.Items.Add(App.VideoPositionModeToString(mode))
        Next
        AddHandler BackgroundworkerGetFiles.DoWork, AddressOf BackgroundworkerGetFilesDoWork
        AddHandler BackgroundworkerGetFiles.RunWorkerCompleted, AddressOf BackgroundworkerGetFilesRunWorkerCompleted

    End Sub
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowSettings()
        ToggleFolderList(My.App.GetFilesType.All, True)
        If App.FrmSplash IsNot Nothing Then
            App.FrmSplash.Close()
            App.FrmSplash = Nothing
        End If
    End Sub
    Private Sub MainForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        HideForm()
        Opacity = 1
#If DEBUG Then
        Left = 0
        btnErrorTest.Visible = True
        ShowForm()
        btnClose.Focus()
#Else
#End If
        If App.RefreshFileListsOnStartUp Then
            App.IsGeneratingFileList = True
            GetFiles(App.GetFilesType.All)
        Else
            App.IsGeneratingFileList = False
            If Not App.WorkSpaceSuspended Then
                If App.PicAutoView AndAlso App.ImageFiles.Count > 0 Then App.ShowImages()
                If App.VidAutoView AndAlso App.VideoFilesCount > 0 Then App.ShowVideos()
            End If
            ToggleContextMenu()
        End If
        LVPageSelector.Focus()
        Skye.UI.ThemeManager.RegisterComponent(TipInfoEX)
        Skye.UI.ThemeManager.ApplyTheme(Me)
        cmApp.Renderer = New Skye.UI.SkyeMenuRenderer
    End Sub
    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PanelApp.MouseDown, PanelPics.MouseDown, PanelVids.MouseDown, PanelActions.MouseDown
        If e.Button = MouseButtons.Left AndAlso WindowState = FormWindowState.Normal Then
            mMove = True
            Dim ctrl As Control = DirectCast(sender, Control)
            If TypeOf ctrl Is Panel Then
                mOffset = New Point(-e.X - 4 - ctrl.Left - SystemInformation.FrameBorderSize.Width, -e.Y - 4 - ctrl.Top - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            Else
                mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            End If
        End If
    End Sub
    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelApp.MouseMove, PanelPics.MouseMove, PanelVids.MouseMove, PanelActions.MouseMove
        If mMove Then
            mPosition = MousePosition
            mPosition.Offset(mOffset.X, mOffset.Y)
            CheckMove(mPosition)
            Location = mPosition
        End If
    End Sub
    Private Sub MainForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PanelApp.MouseUp, PanelPics.MouseUp, PanelVids.MouseUp, PanelActions.MouseUp
        mMove = False
    End Sub
    Private Sub MainForm_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
        If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
    End Sub

    ' Control Events
    Private Sub NotifyiconSkyeShowMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles notifyiconSkyeShow.MouseClick
        Select Case e.Button
            Case MouseButtons.Left
                If My.App.ErrorAlert Then
                    My.App.ClearErrorAlert()
                ElseIf (My.App.FrmPicsVisible And Not My.App.ImageIsOnTop) Or (My.App.FrmVidsVisible And Not My.App.VideoIsOnTop) Then
                    If My.App.FrmPicsVisible And Not My.App.ImageIsOnTop Then My.App.frmPics.QuickShow()
                    If My.App.FrmVidsVisible And Not My.App.VideoIsOnTop Then My.App.FrmVids.QuickShow()
                    AppNotify()
                Else : ShowForm()
                End If
            Case MouseButtons.Right
                If My.App.ErrorAlert Then
                    My.App.ClearErrorAlert()
                    My.App.ShowLog()
                End If
        End Select
    End Sub
    Private Sub PagePanel_Paint(sender As Object, e As PaintEventArgs) Handles PanelApp.Paint, PanelPics.Paint, PanelVids.Paint
        Dim pagePanel As Panel = DirectCast(sender, Panel)
        Using p As New Pen(Color.FromArgb(100, 100, 100))
            e.Graphics.DrawLine(p, 0, 0, 0, pagePanel.Height)
        End Using
    End Sub
    Private Sub PanelActions_Paint(sender As Object, e As PaintEventArgs) Handles PanelActions.Paint
        Using p As New Pen(Color.FromArgb(60, 60, 60))
            e.Graphics.DrawLine(p, 0, 0, PanelActions.Width, 0)
        End Using
    End Sub
    Private Sub LVPageSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles LVPageSelector.MouseDown
        ' Find the item under the mouse
        suppressPageSelection = True
        Dim info As ListViewHitTestInfo = LVPageSelector.HitTest(e.Location)
        Dim item As ListViewItem = info.Item
        If item Is Nothing Then Return

        ' Ensure it becomes selected (for visual feedback)
        item.Selected = True
        Dim selectedSource As String = item.Text

        Select Case e.Clicks
            Case 1
                SetPage(selectedSource)
            Case 2
                Select Case selectedSource
                    Case "Pics"
                        If cmiViewPics.Enabled Then
                            If App.FrmPicsVisible Then
                                App.frmPics.Close()
                            Else
                                App.ShowImages()
                            End If
                            ToggleContextMenu()
                        End If
                    Case "Vids"
                        If cmiPlayVids.Enabled Then
                            If App.FrmVidsVisible Then
                                App.FrmVids.Close()
                            Else
                                App.ShowVideos()
                            End If
                            ToggleContextMenu()
                        End If
                End Select
        End Select
        suppressPageSelection = False
    End Sub
    Private Sub LVPageSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVPageSelector.SelectedIndexChanged
        If suppressPageSelection OrElse LVPageSelector.SelectedItems.Count = 0 Then Return
        Dim selectedSource As String = LVPageSelector.SelectedItems(0).Text
        SetPage(LVPageSelector.SelectedItems(0).Text)
    End Sub
    Private Sub CMSkyeShowOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmApp.Opening
        If My.App.ErrorAlert Then e.Cancel = True
    End Sub
    Private Sub CMListOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmList.Opening
        cmListCurrentSourceControl = Me.cmList.SourceControl.Name
        Select Case cmListCurrentSourceControl
            Case Me.lvPicFolders.Name
                Me.cmiSettingListEnableItem.Visible = False
                Me.tsSeparatorEnabled.Visible = False
                Me.cmList.RightToLeft = Me.lvPicFolders.RightToLeft
                Me.cmList.Items(2).Text = "Add Folder"
                Me.cmList.Items(4).Text = "Remove Folder"
                If Me.lvPicFolders.SelectedItems.Count = 0 Then : Me.cmiSettingListRemoveItem.Enabled = False
                Else : Me.cmiSettingListRemoveItem.Enabled = True
                End If
                If Me.lvPicFolders.Items.Count = 0 Then : Me.cmiSettingListRemoveAll.Enabled = False
                Else : Me.cmiSettingListRemoveAll.Enabled = True
                End If
            Case Me.lvVidFolders.Name
                Me.cmiSettingListEnableItem.Visible = False
                Me.tsSeparatorEnabled.Visible = False
                Me.cmList.RightToLeft = Me.lvVidFolders.RightToLeft
                Me.cmList.Items(2).Text = "Add Folder"
                Me.cmList.Items(4).Text = "Remove Folder"
                If Me.lvVidFolders.SelectedItems.Count = 0 Then : Me.cmiSettingListRemoveItem.Enabled = False
                Else
                    If My.App.VidFolders(Me.lvVidFolders.SelectedIndices(0)).Enabled Then
                        Me.cmiSettingListEnableItem.Text = "Enabled"
                        Me.cmiSettingListEnableItem.Checked = True
                        Me.cmiSettingListEnableItem.ForeColor = Color.Teal
                        Me.cmiSettingListEnableItem.Image = My.Resources.Resources.imagePlay
                    Else
                        Me.cmiSettingListEnableItem.Text = "Disabled"
                        Me.cmiSettingListEnableItem.Checked = False
                        Me.cmiSettingListEnableItem.ForeColor = Color.Maroon
                        Me.cmiSettingListEnableItem.Image = My.Resources.Resources.imagePause
                    End If
                    Me.cmiSettingListEnableItem.Visible = True
                    Me.tsSeparatorEnabled.Visible = True
                    Me.cmiSettingListRemoveItem.Enabled = True
                End If
                If Me.lvVidFolders.Items.Count = 0 Then
                    Me.cmiSettingListRemoveAll.Enabled = False
                Else
                    Me.cmiSettingListRemoveAll.Enabled = True
                End If
        End Select
    End Sub
    Private Sub CMISettingListEnableItemMouseUp(sender As Object, e As MouseEventArgs) Handles cmiSettingListEnableItem.MouseUp
        If e.Button = MouseButtons.Left Then
            'Initialize
            Dim index As Integer = Me.lvVidFolders.SelectedIndices(0)
            Dim itemY As Integer = Me.lvVidFolders.SelectedItems(0).Bounds.Y
            Dim itemH As Integer = Me.lvVidFolders.Items(0).Bounds.Height 'Will be 14 for Tahoma 8pt Font, changing the font in designer will alter this var the number of If...ElseIf statements below.
            'Enable/Disable Item
            Dim folder As My.App.VideoFolderType = My.App.VidFolders(index)
            folder.Enabled = Not folder.Enabled
            My.App.VidFolders.RemoveAt(index)
            My.App.VidFolders.Insert(index, folder)
            My.App.VideoFilesSetEnabled(index, folder.Enabled)
            ShowSettings()
            'Make it easier to bulk Enable/Disable items by minimizing scrolls and mouse moves.
            'Make better by using count of # of visible rows from WinAPI(find how on internet search), save index of last visible item(adjusting for scroll bars if necessary), then ensurevisible on last visible item index(-1 if original selected index on top row, +1 if original selected index on bottom) after ShowSettings(must keep showsettings to update counts and to show item as disabled)
            If Me.lvVidFolders.Items.Count > 4 And Not Me.lvVidFolders.RightToLeftLayout Then
                'My.Debug.ShowMessage(My.SkyeShow.Mode.Videos, "cmiSettingListEnableItemMouseUp", "Item Y = " + iteMy.ToString)
                'My.Debug.ShowMessage(My.SkyeShow.Mode.Videos, "cmiSettingListEnableItemMouseUp", "Item Height = " + itemH.ToString)
                'Y=42
                If itemY = 0 * itemH Then
                    'On First Visible Row
                    index += 2
                ElseIf itemY = 1 * itemH Then
                    'On Second Visible Row
                    index += 2
                ElseIf itemY = 2 * itemH Then
                    'On Third Visible Row
                    index += 1
                ElseIf itemY = 3 * itemH Then
                    'On Last Visible Row
                    If Not index = Me.lvVidFolders.Items.Count - 1 Then index += 1
                End If
                Me.lvVidFolders.EnsureVisible(index)
                'Original Code
                'If Not index = Me.listviewVideoFolders.Items.Count - 1 Then index += 1
                'Me.listviewVideoFolders.EnsureVisible(index)
            End If
            'Finalize
            App.SetSave()
        End If
    End Sub
    Private Sub CMISettingListAddItemMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiSettingListAddItem.MouseUp
        If e.Button = MouseButtons.Left Then
            Try
                Select Case cmListCurrentSourceControl
                    Case Me.lvPicFolders.Name
                        Dim addSelectedPath As Boolean = True
                        Dim removelist As New Collections.Generic.List(Of String)
                        folderbrowser.Description = "Select a Folder where Images are stored." + Microsoft.VisualBasic.Chr(13) + "All files and sub-directories will be searched starting with your selection:"
                        Dim r As DialogResult = folderbrowser.ShowDialog(Me)
                        If r = System.Windows.Forms.DialogResult.OK And Not My.App.PicFolders.Contains(folderbrowser.SelectedPath) And Not folderbrowser.SelectedPath.Length <= 3 Then
                            For Each s As String In My.App.PicFolders
                                If folderbrowser.SelectedPath.StartsWith(s + "\") Then addSelectedPath = False 'Checks if SelectedPath already included in another folder
                                If s.StartsWith(folderbrowser.SelectedPath) Then removelist.Add(s) 'Checks if any other folder is included in SelectedPath
                            Next
                            For Each s As String In removelist : My.App.PicFolders.Remove(s) : Next
                            If addSelectedPath Then
                                My.App.PicFolders.Add(folderbrowser.SelectedPath)
                                My.App.PicFolders.Sort()
                            End If
                        End If
                        removelist.Clear()
                        removelist = Nothing
                    Case Me.lvVidFolders.Name
                        Dim addSelectedPath As Boolean = True
                        Dim removelist As New Collections.Generic.List(Of Integer)
                        folderbrowser.Description = "Select a Folder where Videos are stored." + Microsoft.VisualBasic.Chr(13) + "All files and sub-directories will be searched starting with your selection:"
                        Dim r As DialogResult = folderbrowser.ShowDialog(Me)
                        If r = System.Windows.Forms.DialogResult.OK And Not My.App.VideoFoldersContains(folderbrowser.SelectedPath) And Not folderbrowser.SelectedPath.Length <= 3 Then
                            For index As Integer = My.App.VidFolders.Count - 1 To 0 Step -1
                                Dim folder As My.App.VideoFolderType = My.App.VidFolders(index)
                                If folderbrowser.SelectedPath.StartsWith(folder.SearchPath) Then addSelectedPath = False 'Checks if SelectedPath already included in another folder
                                If folder.Path.StartsWith(folderbrowser.SelectedPath) Then removelist.Add(index) 'Checks if any other folder is included in SelectedPath
                            Next
                            For Each index As Integer In removelist : My.App.VidFolders.RemoveAt(index) : Next
                            If addSelectedPath Then
                                My.App.VidFolders.Add(New My.App.VideoFolderType(folderbrowser.SelectedPath))
                                My.App.VidFolders.Sort(New My.App.VideoFolderType.Comparer)
                            End If
                        End If
                        removelist.Clear()
                        removelist = Nothing
                End Select
            Catch
            Finally
                ShowSettings()
                App.SetSave()
            End Try
        End If
    End Sub
    Private Sub CMISettingListRemoveItemMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiSettingListRemoveItem.MouseUp
        If e.Button = MouseButtons.Left Then
            Select Case cmListCurrentSourceControl
                Case Me.lvPicFolders.Name : My.App.PicFolders.Remove(Me.lvPicFolders.SelectedItems(0).Tag.ToString)
                Case Me.lvVidFolders.Name
                    My.App.VidFolders.RemoveAt(Me.lvVidFolders.SelectedIndices(0))
            End Select
            ShowSettings()
            App.SetSave()
        End If
    End Sub
    Private Sub CMISettingListRemoveAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiSettingListRemoveAll.MouseUp
        If e.Button = MouseButtons.Left Then
            Select Case cmListCurrentSourceControl
                Case Me.lvPicFolders.Name : My.App.PicFolders.Clear()
                Case Me.lvVidFolders.Name
                    My.App.VidFolders.Clear()
            End Select
            ShowSettings()
            App.SetSave()
        End If
    End Sub
    Private Sub CMIViewImagesMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiViewPics.MouseUp
        On Error Resume Next
        If My.App.FrmPicsVisible Then
            Select Case e.Button
                Case MouseButtons.Left : My.App.frmPics.Close()
                Case MouseButtons.Right : If Not My.App.frmPics.IsFullScreen Then My.App.frmPics.ToggleFullScreen()
            End Select
        Else
            My.App.ShowImages()
            If e.Button = MouseButtons.Right Then My.App.frmPics.ToggleFullScreen()
        End If
        ToggleContextMenu()
    End Sub
    Private Sub CMIPlayVideosMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiPlayVids.MouseUp
        On Error Resume Next
        If My.App.FrmVidsVisible Then
            Select Case e.Button
                Case MouseButtons.Left : My.App.FrmVids.Close()
                Case MouseButtons.Right : If Not My.App.FrmVids.IsFullScreen Then My.App.FrmVids.ToggleFullScreen()
            End Select
        Else
            My.App.ShowVideos()
            If e.Button = MouseButtons.Right Then My.App.FrmVids.ToggleFullScreen()
        End If
        ToggleContextMenu()
    End Sub
    Private Sub CMIHelpMouseUp(sender As Object, e As MouseEventArgs) Handles cmiHelp.MouseUp
        Select Case e.Button
            Case MouseButtons.Left : My.App.ShowHelp(False)
            Case MouseButtons.Right : My.App.ShowHelp(True)
        End Select
    End Sub
    Private Sub CMILogMouseUp(sender As Object, e As MouseEventArgs) Handles cmiLog.MouseUp
        Select Case e.Button
            Case MouseButtons.Left : App.ShowLog(False)
            Case MouseButtons.Right : App.ShowLog(True)
        End Select
    End Sub
    Private Sub CMISettingsMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiSettings.MouseUp
        If e.Button = MouseButtons.Left Then ShowForm()
    End Sub
    Private Sub CMIExitMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiExit.MouseUp
        If e.Button = MouseButtons.Right Then : App.CloseApp(True)
        Else : App.CloseApp()
        End If
    End Sub
    Private Sub TxbxNumbersOnlyKeyDown(sender As Object, e As KeyEventArgs) Handles txbxPicTimerInterval.KeyDown, txbxInsideLocationOffset.KeyDown
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9 Then
            If e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9 Then
                If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
                ElseIf e.KeyCode = Keys.Enter Then : Me.Validate()
                End If
            End If
        End If
    End Sub
    Private Sub TxbxNumbersOnlyKeyPress(sender As Object, e As KeyPressEventArgs) Handles txbxPicTimerInterval.KeyPress, txbxInsideLocationOffset.KeyPress
        If nonNumberEntered Then e.Handled = True
    End Sub
    Private Sub TxbxHotKeyKeyPress(sender As Object, e As KeyPressEventArgs) Handles txbxHotKeyVidToggleFullScreen.KeyPress, txbxHotKeyVidToggle.KeyPress, txbxHotKeyVidShowFileInfo.KeyPress, txbxHotKeyPicToggleFullScreen.KeyPress, txbxHotKeyPicToggle.KeyPress, txbxHotKeyPicShowFileInfo.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxbxHotKeyPreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txbxHotKeyVidToggleFullScreen.PreviewKeyDown, txbxHotKeyVidToggle.PreviewKeyDown, txbxHotKeyVidShowFileInfo.PreviewKeyDown, txbxHotKeyPicToggleFullScreen.PreviewKeyDown, txbxHotKeyPicToggle.PreviewKeyDown, txbxHotKeyPicShowFileInfo.PreviewKeyDown
        Static senderTextBox As TextBox
        Static senderTag As My.App.HotKey
        senderTextBox = CType(sender, TextBox)
        senderTag = CType(senderTextBox.Tag, My.App.HotKey)
        If Not e.KeyData = senderTag.Key Then
            'Setup New HotKey
            Dim newhotkey As New My.App.HotKey
            Dim keysinuse As Collections.Generic.List(Of Keys) = My.App.GenerateUsedKeyList
            Dim modifiers As Integer = 0
            Dim match As Boolean = False
            If e.Shift Then modifiers += Skye.WinAPI.MOD_SHIFT
            If e.Control Then modifiers += Skye.WinAPI.MOD_CONTROL
            If e.Alt Then modifiers += Skye.WinAPI.MOD_ALT
            newhotkey.Description = senderTag.Description
            newhotkey.WinID = senderTag.WinID
            newhotkey.Key = e.KeyData
            newhotkey.KeyCode = CByte(e.KeyValue)
            newhotkey.KeyMod = CByte(modifiers)
            'Check If Already In-Use
            If Not CType(Me.txbxHotKeyPicToggle.Tag, My.App.HotKey).Key = My.App.HKPicToggle.Key Then keysinuse.Add(CType(Me.txbxHotKeyPicToggle.Tag, My.App.HotKey).Key)
            If Not CType(Me.txbxHotKeyPicToggleFullScreen.Tag, My.App.HotKey).Key = My.App.HKPicToggleFullScreen.Key Then keysinuse.Add(CType(Me.txbxHotKeyPicToggleFullScreen.Tag, My.App.HotKey).Key)
            If Not CType(Me.txbxHotKeyPicShowFileInfo.Tag, My.App.HotKey).Key = My.App.HKPicShowFileInfo.Key Then keysinuse.Add(CType(Me.txbxHotKeyPicShowFileInfo.Tag, My.App.HotKey).Key)
            If Not CType(Me.txbxHotKeyVidToggle.Tag, My.App.HotKey).Key = My.App.HKVidToggle.Key Then keysinuse.Add(CType(Me.txbxHotKeyVidToggle.Tag, My.App.HotKey).Key)
            If Not CType(Me.txbxHotKeyVidToggleFullScreen.Tag, My.App.HotKey).Key = My.App.HKVidToggleFullScreen.Key Then keysinuse.Add(CType(Me.txbxHotKeyVidToggleFullScreen.Tag, My.App.HotKey).Key)
            If Not CType(Me.txbxHotKeyVidShowFileInfo.Tag, My.App.HotKey).Key = My.App.HKVidShowFileInfo.Key Then keysinuse.Add(CType(Me.txbxHotKeyVidShowFileInfo.Tag, My.App.HotKey).Key)
            For Each usedkey As Keys In keysinuse : If usedkey = newhotkey.Key Then match = True
            Next
            'Display New HotKey If Not Already In-Use
            If Not match Then
                senderTextBox.Font = New Font(senderTextBox.Font, FontStyle.Regular)
                senderTextBox.ForeColor = Color.Maroon
                senderTextBox.Text = e.KeyData.ToString
                senderTextBox.Tag = newhotkey
                If senderTextBox Is Me.txbxHotKeyPicToggle OrElse senderTextBox Is Me.txbxHotKeyPicToggleFullScreen OrElse senderTextBox Is Me.txbxHotKeyPicShowFileInfo Then
                    Me.btnHotKeysPicsUndo.Enabled = True
                    Me.btnHotKeysPicsSet.Enabled = True
                ElseIf senderTextBox Is Me.txbxHotKeyVidToggle OrElse senderTextBox Is Me.txbxHotKeyVidToggleFullScreen OrElse senderTextBox Is Me.txbxHotKeyVidShowFileInfo Then
                    Me.btnHotKeysVidsUndo.Enabled = True
                    Me.btnHotKeysVidsSet.Enabled = True
                End If
            End If
        End If
        senderTag = Nothing
        senderTextBox = Nothing
    End Sub
    Private Sub TxbxInsideLocationOffsetValidated(sender As Object, e As EventArgs) Handles txbxInsideLocationOffset.Validated
        If Not My.App.InsideLocationOffset = CType(Int(Val(Me.txbxInsideLocationOffset.Text)), UInt16) Then
            My.App.InsideLocationOffset = CType(Int(Val(Me.txbxInsideLocationOffset.Text)), UInt16)
            If My.App.FrmPicsVisible Then My.App.frmPics.DrawImage()
            Me.txbxInsideLocationOffset.Focus()
            Me.txbxInsideLocationOffset.SelectAll()
            App.SetSave()
        End If
    End Sub
    Private Sub CoBxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxTheme.SelectedIndexChanged
        Dim selectedName As String = CoBoxTheme.SelectedItem.ToString()
        Dim selected As Skye.UI.SkyeTheme = Skye.UI.SkyeThemes.GetTheme(selectedName)
        App.Theme = selected
        If Not App.ThemeAuto Then
            Skye.UI.ThemeManager.SetTheme(selected)
            ShowSettings()
        End If
        App.SetSave()
    End Sub
    Private Sub ChkBoxThemeAuto_Click(sender As Object, e As EventArgs) Handles ChkBoxThemeAuto.Click
        App.ThemeAuto = ChkBoxThemeAuto.Checked
        SetThemesList()
        If App.ThemeAuto Then
            Skye.UI.ThemeManager.SetTheme(Skye.UI.ThemeManager.DetectWindowsTheme())
        Else
            Skye.UI.ThemeManager.SetTheme(App.Theme)
        End If
        App.SetSave()
    End Sub
    Private Sub ChbxSaveFileListsClick(sender As Object, e As EventArgs) Handles chbxSaveFileLists.Click
        My.App.SaveFileLists = Me.chbxSaveFileLists.Checked
        App.SetSave()
    End Sub
    Private Sub ChbxLoadFileListsInBackgroundClick(sender As Object, e As EventArgs) Handles chbxLoadFileListsInBackground.Click
        My.App.LoadFileListsInBackground = Me.chbxLoadFileListsInBackground.Checked
        App.SetSave()
    End Sub
    Private Sub ChbxRefreshFileListsOnStartUpClick(sender As Object, e As EventArgs) Handles chbxRefreshFileListsOnStartUp.Click
        My.App.RefreshFileListsOnStartUp = Me.chbxRefreshFileListsOnStartUp.Checked
        App.SetSave()
    End Sub
    Private Sub ChbxHideCursorWhenFullscreenClick(sender As Object, e As EventArgs) Handles chbxHideCursorWhenFullscreen.Click
        My.App.HideCursorWhenFullscreen = Me.chbxHideCursorWhenFullscreen.Checked
        App.SetSave()
    End Sub
    Private Sub ChbxHotKeysClick(sender As Object, e As EventArgs) Handles chbxHotKeys.Click
        If My.App.HKEnabled Then
            My.App.RegisterHotKeys(False)
            My.App.HKEnabled = False
        Else
            My.App.HKEnabled = True
            My.App.RegisterHotKeys(True)
        End If
        ShowSettings()
        App.SetSave()
    End Sub
    Private Sub RadbtnActionOnScreenSaveNoActionClick(sender As Object, e As EventArgs) Handles radbtnActionOnScreenSaveNoAction.Click
        My.App.ActionOnScreenSave = My.App.ScreenSaveActions.NoAction
        App.SetSave()
    End Sub
    Private Sub RadbtnActionOnScreenSaveSuspendClick(sender As Object, e As EventArgs) Handles radbtnActionOnScreenSaveSuspend.Click
        My.App.ActionOnScreenSave = My.App.ScreenSaveActions.Suspend
        App.SetSave()
    End Sub
    Private Sub RadbtnActionOnScreenSaveCloseClick(sender As Object, e As EventArgs) Handles radbtnActionOnScreenSaveClose.Click
        My.App.ActionOnScreenSave = My.App.ScreenSaveActions.Close
        App.SetSave()
    End Sub
    Private Sub BtnEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveSettings.Enter, btnRestoreSettings.Enter, btnRefreshVidList.Enter, btnRefreshPicList.Enter, btnPicTimerEnabled.Enter, btnlvVidFolders.Enter, btnlvPicFolders.Enter, btnHotKeyVidToggleFullScreenDisable.Enter, btnHotKeyVidToggleDisable.Enter, btnHotKeyVidShowFileInfoDisable.Enter, btnHotKeysVidsUndo.Enter, btnHotKeysVidsSet.Enter, btnHotKeysPicsUndo.Enter, btnHotKeysPicsSet.Enter, btnHotKeyPicToggleFullScreenDisable.Enter, btnHotKeyPicToggleDisable.Enter, btnHotKeyPicShowFileInfoDisable.Enter, btnErrorTest.Enter
        btnClose.Focus()
    End Sub
    Private Sub BtnHotKeyDisableClick(sender As Object, e As EventArgs) Handles btnHotKeyVidToggleFullScreenDisable.Click, btnHotKeyVidToggleDisable.Click, btnHotKeyVidShowFileInfoDisable.Click, btnHotKeyPicToggleFullScreenDisable.Click, btnHotKeyPicToggleDisable.Click, btnHotKeyPicShowFileInfoDisable.Click
        Static senderTextBox As TextBox
        Static senderTag As My.App.HotKey
        senderTextBox = New TextBox
        senderTag = New My.App.HotKey
        If sender Is Me.btnHotKeyPicToggleDisable Then
            senderTextBox = Me.txbxHotKeyPicToggle
            senderTag = CType(Me.txbxHotKeyPicToggle.Tag, My.App.HotKey)
        ElseIf sender Is Me.btnHotKeyPicToggleFullScreenDisable Then
            senderTextBox = Me.txbxHotKeyPicToggleFullScreen
            senderTag = CType(Me.txbxHotKeyPicToggleFullScreen.Tag, My.App.HotKey)
        ElseIf sender Is Me.btnHotKeyPicShowFileInfoDisable Then
            senderTextBox = Me.txbxHotKeyPicShowFileInfo
            senderTag = CType(Me.txbxHotKeyPicShowFileInfo.Tag, My.App.HotKey)
        ElseIf sender Is Me.btnHotKeyVidToggleDisable Then
            senderTextBox = Me.txbxHotKeyVidToggle
            senderTag = CType(Me.txbxHotKeyVidToggle.Tag, My.App.HotKey)
        ElseIf sender Is Me.btnHotKeyVidToggleFullScreenDisable Then
            senderTextBox = Me.txbxHotKeyVidToggleFullScreen
            senderTag = CType(Me.txbxHotKeyVidToggleFullScreen.Tag, My.App.HotKey)
        ElseIf sender Is Me.btnHotKeyVidShowFileInfoDisable Then
            senderTextBox = Me.txbxHotKeyVidShowFileInfo
            senderTag = CType(Me.txbxHotKeyVidShowFileInfo.Tag, My.App.HotKey)
        End If
        If Not CType(senderTag.Key, Keys) = Keys.None Then
            Dim newhotkey As New My.App.HotKey With {
                .Description = senderTag.Description,
                .WinID = senderTag.WinID,
                .Key = Keys.None,
                .KeyCode = 0,
                .KeyMod = 0}
            senderTextBox.Font = New Font(senderTextBox.Font, FontStyle.Regular)
            senderTextBox.ForeColor = Color.Maroon
            senderTextBox.Text = newhotkey.Key.ToString
            senderTextBox.Tag = newhotkey
            If sender Is Me.btnHotKeyPicToggleDisable OrElse sender Is Me.btnHotKeyPicToggleFullScreenDisable OrElse sender Is Me.btnHotKeyPicShowFileInfoDisable Then
                Me.btnHotKeysPicsUndo.Enabled = True
                Me.btnHotKeysPicsSet.Enabled = True
            ElseIf sender Is Me.btnHotKeyVidToggleDisable OrElse sender Is Me.btnHotKeyVidToggleFullScreenDisable OrElse sender Is Me.btnHotKeyVidShowFileInfoDisable Then
                Me.btnHotKeysVidsUndo.Enabled = True
                Me.btnHotKeysVidsSet.Enabled = True
            End If
        End If
        senderTag = Nothing
        senderTextBox = Nothing
    End Sub
    Private Sub BtnHotKeysUndoClick(sender As Object, e As EventArgs) Handles btnHotKeysVidsUndo.Click, btnHotKeysPicsUndo.Click
        If sender Is Me.btnHotKeysPicsUndo Then : ShowSettingsImages()
        ElseIf sender Is Me.btnHotKeysVidsUndo Then : ShowSettingsVideos()
        End If
    End Sub
    Private Sub BtnHotKeysSetClick(sender As Object, e As EventArgs) Handles btnHotKeysVidsSet.Click, btnHotKeysPicsSet.Click
        Static NeedsReRegistered As Boolean
        NeedsReRegistered = False
        If Not CType(Me.txbxHotKeyPicToggle.Tag, My.App.HotKey).Key = My.App.HKPicToggle.Key Then
            My.App.HKPicToggle = CType(Me.txbxHotKeyPicToggle.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If Not CType(Me.txbxHotKeyPicToggleFullScreen.Tag, My.App.HotKey).Key = My.App.HKPicToggleFullScreen.Key Then
            My.App.HKPicToggleFullScreen = CType(Me.txbxHotKeyPicToggleFullScreen.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If Not CType(Me.txbxHotKeyPicShowFileInfo.Tag, My.App.HotKey).Key = My.App.HKPicShowFileInfo.Key Then
            My.App.HKPicShowFileInfo = CType(Me.txbxHotKeyPicShowFileInfo.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If Not CType(Me.txbxHotKeyVidToggle.Tag, My.App.HotKey).Key = My.App.HKVidToggle.Key Then
            My.App.HKVidToggle = CType(Me.txbxHotKeyVidToggle.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If Not CType(Me.txbxHotKeyVidToggleFullScreen.Tag, My.App.HotKey).Key = My.App.HKVidToggleFullScreen.Key Then
            My.App.HKVidToggleFullScreen = CType(Me.txbxHotKeyVidToggleFullScreen.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If Not CType(Me.txbxHotKeyVidShowFileInfo.Tag, My.App.HotKey).Key = My.App.HKVidShowFileInfo.Key Then
            My.App.HKVidShowFileInfo = CType(Me.txbxHotKeyVidShowFileInfo.Tag, My.App.HotKey)
            NeedsReRegistered = True
        End If
        If NeedsReRegistered Then
            My.App.RegisterHotKeys(False)
            My.App.GenerateHotKeyList()
            My.App.RegisterHotKeys(True)
            If sender Is Me.btnHotKeysPicsSet Then : ShowSettingsImages()
            ElseIf sender Is Me.btnHotKeysVidsSet Then : ShowSettingsVideos()
            End If
        End If
        App.SetSave()
    End Sub
    Private Sub BtnInfoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnInfo.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : My.App.ShowHelp(False)
                Case MouseButtons.Right : My.App.ShowHelp(True)
            End Select
        End If
    End Sub
    Private Sub BtnLogMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnLog.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : App.ShowLog(False)
                Case MouseButtons.Right : App.ShowLog(True)
            End Select
            If My.App.ErrorAlert Then App.ClearErrorAlert()
        End If
    End Sub
    Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        HideForm()
    End Sub
    Private Sub BtnErrorTestMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnErrorTest.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left
                    My.App.SetErrorAlert()
                    Debug.Print("btnErrorTestMouseUp --> TEST ERROR - DO NOT PANIC!!")
                    MsgBox("Just Checking, DO NOT PANIC!!", MsgBoxStyle.Critical, "Test Error")
                    My.App.WriteToLog("Test Error - DO NOT PANIC!!")
                Case MouseButtons.Right
                    My.App.SetErrorAlert()
                    My.App.WriteToLog("Test Exception - DO NOT PANIC!!")
                    Throw New Exception("Test Exception - DO NOT PANIC!!")
            End Select
        End If
    End Sub
    Private Sub BtnRefreshListMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnRefreshVidList.MouseUp, btnRefreshPicList.MouseUp
        If My.App.FrmPicsVisible Then : ImageActiveOnRefresh = True : Else : ImageActiveOnRefresh = False : End If
        If My.App.FrmVidsVisible Then : VideoActiveOnRefresh = True : Else : VideoActiveOnRefresh = False : End If
        Select Case e.Button
            Case MouseButtons.Left
                If sender Is Me.btnRefreshPicList Then
                    If My.Computer.Keyboard.CtrlKeyDown Then My.App.ImageRepeatList.Clear()
                    GetFiles(My.App.GetFilesType.Pics)
                ElseIf sender Is Me.btnRefreshVidList Then
                    If My.Computer.Keyboard.CtrlKeyDown Then My.App.VideoFiles.Clear()

                    If My.App.VideoFiles.Count > 0 Then
                        'Remove Manual Entries, including Entries without a Folder(because Folder was Deleted)
                        Dim found As Boolean
                        For index As Integer = My.App.VideoFiles.Count - 1 To 0 Step -1
                            found = False
                            For Each folder As My.App.VideoFolderType In My.App.VidFolders
                                If My.App.VideoFiles(index).Path.StartsWith(folder.Path) Then found = True : Exit For
                            Next
                            If Not found Then My.App.VideoFiles.RemoveAt(index)
                        Next
                    End If
                    GetFiles(My.App.GetFilesType.Vids)
                End If
            Case MouseButtons.Right
                If My.Computer.Keyboard.CtrlKeyDown Then
                    My.App.ImageRepeatList.Clear()
                    My.App.VideoFiles.Clear()
                End If
                GetFiles(My.App.GetFilesType.All)
        End Select
    End Sub
    Private Sub BtnSaveSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveSettings.Click
        My.App.SaveSettings()
        App.NeedsSaved = False
        ShowSave()
        HideForm()
    End Sub
    Private Sub BtnRestoreSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreSettings.Click
        RestoreSettings()
    End Sub

    ' Methods
    Friend Sub AppNotify()
        notifyiconSkyeShow.Text = Application.Info.Title
        TipInfoEX.SetText(btnLog, "Show Log")
        If App.IsGeneratingFileList Then
            notifyiconSkyeShow.Icon = My.Resources.Resources.IconAppLoading
            notifyiconSkyeShow.Text += Chr(13) + App.GeneratingFileListAlertText
        ElseIf App.ErrorAlert Then
            notifyiconSkyeShow.Icon = My.Resources.Resources.IconAppError
            notifyiconSkyeShow.Text += Chr(13) + "** ERROR **" + Chr(13) + "LeftClick = Clear" + Chr(13) + "RightClick = View Log"
            btnLog.BackColor = Color.Red
            TipInfoEX.SetText(btnLog, TipInfoEX.GetText(btnLog) + vbCr + "An Error Has Occurred")
        Else
            If App.ImageIsOnTop And App.VideoIsOnTop Then : notifyiconSkyeShow.Icon = My.Resources.Resources.IconApp
            Else
                notifyiconSkyeShow.Icon = My.Resources.Resources.IconAppHidden
                notifyiconSkyeShow.Text += Chr(13) + "One Or More Windows Are Hidden. Click To Restore."
            End If
            btnLog.BackColor = Skye.UI.ThemeManager.CurrentTheme.ButtonBack
        End If
    End Sub
    Friend Sub ShowSave()
        If App.NeedsSaved Then
            btnSaveSettings.BackColor = Color.Red
            TipInfoEX.SetText(btnSaveSettings, "Settings Need Saved")
        Else
            btnSaveSettings.BackColor = Skye.UI.ThemeManager.CurrentTheme.ButtonBack
            TipInfoEX.SetText(btnSaveSettings, "Save All Settings")
        End If
    End Sub
    Private Sub SetPage(page As String)
        PanelApp.Enabled = False
        PanelPics.Enabled = False
        PanelVids.Enabled = False
        Select Case page
            Case "App"
                PanelApp.Enabled = True
                PanelApp.BringToFront()
            Case "Pics"
                PanelPics.Enabled = True
                PanelPics.BringToFront()
            Case "Vids"
                PanelVids.Enabled = True
                PanelVids.BringToFront()
        End Select
    End Sub
    Friend Sub ShowSettings()
        ShowSettingsApp()
        ShowSettingsImages()
        ShowSettingsVideos()
        UpdateSettings()
    End Sub
    Friend Sub UpdateSettings() 'Settings that can change on other forms
        UpdateSettingsApp()
        UpdateSettingsPics()
        UpdateSettingsVids()
    End Sub
    Friend Sub UpdateSettingsApp() 'Settings that can change on other forms

    End Sub
    Friend Sub UpdateSettingsPics() 'Settings that can change on other forms
        If Not Me.BackgroundworkerGetFiles.IsBusy Then
            Me.lblPicFileCount.Text = (My.App.ImageFiles.Count - My.App.ImageRepeatList.Count).ToString
            Me.lblPicFileCount.Text += " / " + My.App.ImageRepeatList.Count.ToString
            Me.lblPicFileCount.Text += " / " + My.App.ImageFiles.Count.ToString
            Dim s As String
            s = "Image Counts" + Chr(13)
            s += (My.App.ImageFiles.Count - My.App.ImageRepeatList.Count).ToString + " " + My.App.VideoFilesCountMode.UnViewed.ToString
            s += ", " + My.App.ImageRepeatList.Count.ToString + " " + My.App.VideoFilesCountMode.Viewed.ToString
            s += ", " + My.App.ImageFiles.Count.ToString + " " + My.App.VideoFilesCountMode.Total.ToString
            TipInfoEX.SetText(lblPicFileCount, s)
            If My.App.ImageFiles.Count = 0 Then : cmiViewPics.Enabled = False
            Else : cmiViewPics.Enabled = True
            End If
        End If
        Select Case App.PicLocationMode
            Case App.LocationMode.Manual : radbtnPicLocationModeManual.Checked = True
            Case App.LocationMode.TopLeft : radbtnPicLocationModeTopLeft.Checked = True
            Case App.LocationMode.TopCenterLeft : radbtnPicLocationModeTopCenterLeft.Checked = True
            Case App.LocationMode.TopCenter : radbtnPicLocationModeTopCenter.Checked = True
            Case App.LocationMode.TopCenterRight : radbtnPicLocationModeTopCenterRight.Checked = True
            Case App.LocationMode.TopRight : radbtnPicLocationModeTopRight.Checked = True
            Case App.LocationMode.RightCenterTop : radbtnPicLocationModeRightCenterTop.Checked = True
            Case App.LocationMode.RightCenter : radbtnPicLocationModeRightCenter.Checked = True
            Case App.LocationMode.RightCenterBottom : radbtnPicLocationModeRightCenterBottom.Checked = True
            Case App.LocationMode.BottomRight : radbtnPicLocationModeBottomRight.Checked = True
            Case App.LocationMode.BottomCenterRight : radbtnPicLocationModeBottomCenterRight.Checked = True
            Case App.LocationMode.BottomCenter : radbtnPicLocationModeBottomCenter.Checked = True
            Case App.LocationMode.BottomCenterLeft : radbtnPicLocationModeBottomCenterLeft.Checked = True
            Case App.LocationMode.BottomLeft : radbtnPicLocationModeBottomLeft.Checked = True
            Case App.LocationMode.LeftCenterBottom : radbtnPicLocationModeLeftCenterBottom.Checked = True
            Case App.LocationMode.LeftCenter : radbtnPicLocationModeLeftCenter.Checked = True
            Case App.LocationMode.LeftCenterTop : radbtnPicLocationModeLeftCenterTop.Checked = True
            Case App.LocationMode.TopLeftInside : radbtnPicLocationModeTopLeftInside.Checked = True
            Case App.LocationMode.TopCenterLeftInside : radbtnPicLocationModeTopCenterLeftInside.Checked = True
            Case App.LocationMode.TopCenterInside : radbtnPicLocationModeTopCenterInside.Checked = True
            Case App.LocationMode.TopCenterRightInside : radbtnPicLocationModeTopCenterRightInside.Checked = True
            Case App.LocationMode.TopRightInside : radbtnPicLocationModeTopRightInside.Checked = True
            Case App.LocationMode.RightCenterTopInside : radbtnPicLocationModeRightCenterTopInside.Checked = True
            Case App.LocationMode.RightCenterInside : radbtnPicLocationModeRightCenterInside.Checked = True
            Case App.LocationMode.RightCenterBottomInside : radbtnPicLocationModeRightCenterBottomInside.Checked = True
            Case App.LocationMode.BottomRightInside : radbtnPicLocationModeBottomRightInside.Checked = True
            Case App.LocationMode.BottomCenterRightInside : radbtnPicLocationModeBottomCenterRightInside.Checked = True
            Case App.LocationMode.BottomCenterInside : radbtnPicLocationModeBottomCenterInside.Checked = True
            Case App.LocationMode.BottomCenterLeftInside : radbtnPicLocationModeBottomCenterLeftInside.Checked = True
            Case App.LocationMode.BottomLeftInside : radbtnPicLocationModeBottomLeftInside.Checked = True
            Case App.LocationMode.LeftCenterBottomInside : radbtnPicLocationModeLeftCenterBottomInside.Checked = True
            Case App.LocationMode.LeftCenterInside : radbtnPicLocationModeLeftCenterInside.Checked = True
            Case App.LocationMode.LeftCenterTopInside : radbtnPicLocationModeLeftCenterTopInside.Checked = True
        End Select
        If My.App.PicTimerEnabled Then
            Me.btnPicTimerEnabled.FlatAppearance.BorderColor = Color.Teal
            Me.btnPicTimerEnabled.FlatAppearance.MouseOverBackColor = Color.Maroon
            Me.btnPicTimerEnabled.ForeColor = Color.Teal
        Else
            Me.btnPicTimerEnabled.FlatAppearance.BorderColor = Color.Maroon
            Me.btnPicTimerEnabled.FlatAppearance.MouseOverBackColor = Color.Teal
            Me.btnPicTimerEnabled.ForeColor = Color.Maroon
        End If
    End Sub
    Friend Sub UpdateSettingsVids() 'Settings that can change on other forms
        If Not Me.BackgroundworkerGetFiles.IsBusy Then
            Me.lblVidFileCount.Text = My.App.VideoFilesCount(My.App.VideoFilesCountMode.UnViewed).ToString
            Me.lblVidFileCount.Text += " / " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Enabled).ToString
            Me.lblVidFileCount.Text += " / " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Valid).ToString
            Dim s As String
            s = "Video Counts (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + " " + My.App.VideoFilesCountMode.Total.ToString + ")"
            s += Chr(13) + My.App.VideoFilesCount(My.App.VideoFilesCountMode.UnViewed).ToString + " " + My.App.VideoFilesCountMode.UnViewed.ToString
            s += ", " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Enabled).ToString + " " + My.App.VideoFilesCountMode.Enabled.ToString
            s += ", " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Valid).ToString + " " + My.App.VideoFilesCountMode.Valid.ToString
            s += Chr(13) + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Viewed).ToString + " " + My.App.VideoFilesCountMode.Viewed.ToString
            s += ", " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Disabled).ToString + " " + My.App.VideoFilesCountMode.Disabled.ToString
            s += ", " + My.App.VideoFilesCount(My.App.VideoFilesCountMode.InValid).ToString + " " + My.App.VideoFilesCountMode.InValid.ToString
            Me.TipInfoEX.SetText(Me.lblVidFileCount, s)
            If My.App.VideoFilesCount = 0 Then
                Me.cmiPlayVids.Enabled = False
            Else
                Me.cmiPlayVids.Enabled = True
            End If
        End If
        Select Case My.App.VidLocationMode
            Case My.App.LocationMode.Manual : Me.radbtnVidLocationModeManual.Checked = True
            Case My.App.LocationMode.TopLeft : Me.radbtnVidLocationModeTopLeft.Checked = True
            Case My.App.LocationMode.TopCenterLeft : Me.radbtnVidLocationModeTopCenterLeft.Checked = True
            Case My.App.LocationMode.TopCenter : Me.radbtnVidLocationModeTopCenter.Checked = True
            Case My.App.LocationMode.TopCenterRight : Me.radbtnVidLocationModeTopCenterRight.Checked = True
            Case My.App.LocationMode.TopRight : Me.radbtnVidLocationModeTopRight.Checked = True
            Case My.App.LocationMode.RightCenterTop : Me.radbtnVidLocationModeRightCenterTop.Checked = True
            Case My.App.LocationMode.RightCenter : Me.radbtnVidLocationModeRightCenter.Checked = True
            Case My.App.LocationMode.RightCenterBottom : Me.radbtnVidLocationModeRightCenterBottom.Checked = True
            Case My.App.LocationMode.BottomRight : Me.radbtnVidLocationModeBottomRight.Checked = True
            Case My.App.LocationMode.BottomCenterRight : Me.radbtnVidLocationModeBottomCenterRight.Checked = True
            Case My.App.LocationMode.BottomCenter : Me.radbtnVidLocationModeBottomCenter.Checked = True
            Case My.App.LocationMode.BottomCenterLeft : Me.radbtnVidLocationModeBottomCenterLeft.Checked = True
            Case My.App.LocationMode.BottomLeft : Me.radbtnVidLocationModeBottomLeft.Checked = True
            Case My.App.LocationMode.LeftCenterBottom : Me.radbtnVidLocationModeLeftCenterBottom.Checked = True
            Case My.App.LocationMode.LeftCenter : Me.radbtnVidLocationModeLeftCenter.Checked = True
            Case My.App.LocationMode.LeftCenterTop : Me.radbtnVidLocationModeLeftCenterTop.Checked = True
            Case My.App.LocationMode.TopLeftInside : Me.radbtnVidLocationModeTopLeftInside.Checked = True
            Case My.App.LocationMode.TopCenterLeftInside : Me.radbtnVidLocationModeTopCenterLeftInside.Checked = True
            Case My.App.LocationMode.TopCenterInside : Me.radbtnVidLocationModeTopCenterInside.Checked = True
            Case My.App.LocationMode.TopCenterRightInside : Me.radbtnVidLocationModeTopCenterRightInside.Checked = True
            Case My.App.LocationMode.TopRightInside : Me.radbtnVidLocationModeTopRightInside.Checked = True
            Case My.App.LocationMode.RightCenterTopInside : Me.radbtnVidLocationModeRightCenterTopInside.Checked = True
            Case My.App.LocationMode.RightCenterInside : Me.radbtnVidLocationModeRightCenterInside.Checked = True
            Case My.App.LocationMode.RightCenterBottomInside : Me.radbtnVidLocationModeRightCenterBottomInside.Checked = True
            Case My.App.LocationMode.BottomRightInside : Me.radbtnVidLocationModeBottomRightInside.Checked = True
            Case My.App.LocationMode.BottomCenterRightInside : Me.radbtnVidLocationModeBottomCenterRightInside.Checked = True
            Case My.App.LocationMode.BottomCenterInside : Me.radbtnVidLocationModeBottomCenterInside.Checked = True
            Case My.App.LocationMode.BottomCenterLeftInside : Me.radbtnVidLocationModeBottomCenterLeftInside.Checked = True
            Case My.App.LocationMode.BottomLeftInside : Me.radbtnVidLocationModeBottomLeftInside.Checked = True
            Case My.App.LocationMode.LeftCenterBottomInside : Me.radbtnVidLocationModeLeftCenterBottomInside.Checked = True
            Case My.App.LocationMode.LeftCenterInside : Me.radbtnVidLocationModeLeftCenterInside.Checked = True
            Case My.App.LocationMode.LeftCenterTopInside : Me.radbtnVidLocationModeLeftCenterTopInside.Checked = True
        End Select
        Me.cobxVidTimeDisplayMode.SelectedIndex = My.App.VidTimeDisplayMode
        chbkVidMute.Checked = App.VidVolumeMute
        Select Case App.VidVolumeMute
            Case True
                chbkVidMute.Image = My.Resources.Resources.imageSoundMute
            Case False
                chbkVidMute.Image = My.Resources.Resources.ImageSound
        End Select
    End Sub
    Friend Sub RestoreSettings()
        My.App.GetSettings()
        My.App.VideoFilesResetEnabled()
        ShowSettings()
        If App.ThemeAuto Then
            Skye.UI.ThemeManager.SetTheme(Skye.UI.ThemeManager.DetectWindowsTheme())
        Else
            Skye.UI.ThemeManager.SetTheme(App.Theme)
        End If
        If App.FrmPicsVisible Then App.frmPics.DrawImage()
        If App.FrmVidsVisible Then
            App.FrmVids.SetSize()
            App.FrmVids.SetVolume()
        End If
        App.NeedsSaved = False
        ShowSave()
    End Sub
    Friend Sub ToggleContextMenu()
        If My.App.FrmPicsVisible Then : Me.cmiViewPics.Checked = True
        Else : Me.cmiViewPics.Checked = False
        End If
        If My.App.FrmVidsVisible Then : Me.cmiPlayVids.Checked = True
        Else : Me.cmiPlayVids.Checked = False
        End If
        AppNotify()
    End Sub
    Private Sub ShowSettingsApp()
        Me.chbxSaveFileLists.Checked = My.App.SaveFileLists
        Me.chbxLoadFileListsInBackground.Checked = My.App.LoadFileListsInBackground
        Me.chbxRefreshFileListsOnStartUp.Checked = My.App.RefreshFileListsOnStartUp
        Me.chbxHideCursorWhenFullscreen.Checked = My.App.HideCursorWhenFullscreen
        Me.chbxHotKeys.Checked = My.App.HKEnabled
        Me.txbxInsideLocationOffset.Text = My.App.InsideLocationOffset.ToString
        CoBoxTheme.SelectedItem = App.Theme.Name
        ChkBoxThemeAuto.Checked = App.ThemeAuto
        SetThemesList()
        Select Case My.App.ActionOnScreenSave
            Case My.App.ScreenSaveActions.NoAction : Me.radbtnActionOnScreenSaveNoAction.Checked = True
            Case My.App.ScreenSaveActions.Suspend : Me.radbtnActionOnScreenSaveSuspend.Checked = True
            Case My.App.ScreenSaveActions.Close : Me.radbtnActionOnScreenSaveClose.Checked = True
        End Select
        UpdateSettingsApp()
        Me.btnClose.Focus()
    End Sub
    Private Sub ShowSettingsImages()
        Static lvi As ListViewItem
        Static split As String()
        Me.lvPicFolders.Items.Clear()

        For Each s As String In My.App.PicFolders
            split = s.Split(CChar("\"))
            lvi = New ListViewItem
            lvi.SubItems.Add(s)
            lvi.SubItems.Add(split.GetValue(split.Length - 1).ToString)
            lvi.Tag = s
            Me.lvPicFolders.Items.Add(lvi)
        Next
        lvi = Nothing
        split = Nothing
        If My.App.PicAutoView Then : Me.chbxPicAutoView.Checked = True
        Else : Me.chbxPicAutoView.Checked = False
        End If
        If My.App.PicLockFullScreen Then : Me.chbxPicLockFullScreen.Checked = True
        Else : Me.chbxPicLockFullScreen.Checked = False
        End If
        Select Case My.App.PicPlayMode
            Case My.App.PlayMode.Linear
                Me.radbtnPicPlayModeLinear.Checked = True
            Case My.App.PlayMode.LinearWithRandomStart
                Me.radbtnPicPlayModeLinearWithRandomStart.Checked = True
            Case My.App.PlayMode.Random
                Me.radbtnPicPlayModeRandom.Checked = True
        End Select
        Select Case My.App.PicJustify
            Case My.App.LocationJustify.Left : Me.radbtnPicJustifyLeft.Checked = True
            Case My.App.LocationJustify.Center : Me.radbtnPicJustifyCenter.Checked = True
            Case My.App.LocationJustify.Right : Me.radbtnPicJustifyRight.Checked = True
        End Select
        If My.App.PicTimerCountdown Then
            Me.chbxPicTimerCountdown.Checked = True
            Me.gpbxPicTimerCountdownLocationMode.Enabled = True
        Else
            Me.chbxPicTimerCountdown.Checked = False
            Me.gpbxPicTimerCountdownLocationMode.Enabled = False
        End If
        Select Case My.App.PicTimerCountdownLocationMode
            Case My.App.LocationMode.TopLeft : Me.radbtnPicTimerCountdownLocationModeTopLeft.Checked = True
            Case My.App.LocationMode.TopCenterLeft : Me.radbtnPicTimerCountdownLocationModeTopCenterLeft.Checked = True
            Case My.App.LocationMode.TopCenter : Me.radbtnPicTimerCountdownLocationModeTopCenter.Checked = True
            Case My.App.LocationMode.TopCenterRight : Me.radbtnPicTimerCountdownLocationModeTopCenterRight.Checked = True
            Case My.App.LocationMode.TopRight : Me.radbtnPicTimerCountdownLocationModeTopRight.Checked = True
            Case My.App.LocationMode.RightCenterTop : Me.radbtnPicTimerCountdownLocationModeRightCenterTop.Checked = True
            Case My.App.LocationMode.RightCenter : Me.radbtnPicTimerCountdownLocationModeRightCenter.Checked = True
            Case My.App.LocationMode.RightCenterBottom : Me.radbtnPicTimerCountdownLocationModeRightCenterBottom.Checked = True
            Case My.App.LocationMode.BottomRight : Me.radbtnPicTimerCountdownLocationModeBottomRight.Checked = True
            Case My.App.LocationMode.BottomCenterRight : Me.radbtnPicTimerCountdownLocationModeBottomCenterRight.Checked = True
            Case My.App.LocationMode.BottomCenter : Me.radbtnPicTimerCountdownLocationModeBottomCenter.Checked = True
            Case My.App.LocationMode.BottomCenterLeft : Me.radbtnPicTimerCountdownLocationModeBottomCenterLeft.Checked = True
            Case My.App.LocationMode.BottomLeft : Me.radbtnPicTimerCountdownLocationModeBottomLeft.Checked = True
            Case My.App.LocationMode.LeftCenterBottom : Me.radbtnPicTimerCountdownLocationModeLeftCenterBottom.Checked = True
            Case My.App.LocationMode.LeftCenter : Me.radbtnPicTimerCountdownLocationModeLeftCenter.Checked = True
            Case My.App.LocationMode.LeftCenterTop : Me.radbtnPicTimerCountdownLocationModeLeftCenterTop.Checked = True
        End Select
        Me.txbxPicTimerInterval.Text = My.App.PicTimerInterval.ToString
        Me.chbxPicTimerAutoStart.Checked = My.App.PicTimerAutoStart
        If My.App.HKEnabled Then : Me.grbxHotKeysPics.Enabled = True
        Else : Me.grbxHotKeysPics.Enabled = False
        End If
        Me.lblHotKeyPicToggle.Text = My.App.HKPicToggle.Description
        Me.txbxHotKeyPicToggle.Text = My.App.HKPicToggle.Key.ToString
        Me.txbxHotKeyPicToggle.Tag = My.App.HKPicToggle
        Me.txbxHotKeyPicToggle.Font = New Font(Me.txbxHotKeyPicToggle.Font, FontStyle.Bold)
        Me.txbxHotKeyPicToggle.ForeColor = Color.Teal
        Me.lblHotKeyPicToggleFullScreen.Text = My.App.HKPicToggleFullScreen.Description
        Me.txbxHotKeyPicToggleFullScreen.Text = My.App.HKPicToggleFullScreen.Key.ToString
        Me.txbxHotKeyPicToggleFullScreen.Tag = My.App.HKPicToggleFullScreen
        Me.txbxHotKeyPicToggleFullScreen.Font = New Font(Me.txbxHotKeyPicToggleFullScreen.Font, FontStyle.Bold)
        Me.txbxHotKeyPicToggleFullScreen.ForeColor = Color.Teal
        Me.lblHotKeyPicShowFileInfo.Text = My.App.HKPicShowFileInfo.Description
        Me.txbxHotKeyPicShowFileInfo.Text = My.App.HKPicShowFileInfo.Key.ToString
        Me.txbxHotKeyPicShowFileInfo.Tag = My.App.HKPicShowFileInfo
        Me.txbxHotKeyPicShowFileInfo.Font = New Font(Me.txbxHotKeyPicShowFileInfo.Font, FontStyle.Bold)
        Me.txbxHotKeyPicShowFileInfo.ForeColor = Color.Teal
        Me.btnHotKeysPicsUndo.Enabled = False
        Me.btnHotKeysPicsSet.Enabled = False
        UpdateSettingsPics()
        Me.btnClose.Focus()
    End Sub
    Private Sub ShowSettingsVideos()
        Static lvi As ListViewItem
        Static split As String()
        Me.lvVidFolders.Items.Clear()
        For Each folder As My.App.VideoFolderType In My.App.VidFolders
            split = folder.Path.TrimStart(CChar("-")).Split(CChar("\"))
            lvi = New ListViewItem
            lvi.SubItems.Add(folder.Path.TrimStart(CChar("-")))
            lvi.SubItems.Add(split.GetValue(split.Length - 1).ToString)
            lvi.Tag = folder.Path
            If Not folder.Enabled Then
                lvi.Font = New Font(Me.lvVidFolders.Font, FontStyle.Strikeout)
                lvi.ForeColor = Color.Gray
            End If
            Me.lvVidFolders.Items.Add(lvi)
        Next
        lvi = Nothing
        split = Nothing
        If My.App.VidAutoView Then : Me.chbxVidAutoView.Checked = True
        Else : Me.chbxVidAutoView.Checked = False
        End If
        If My.App.VidVolumeMute Then : Me.chbkVidMute.Checked = True
        Else : Me.chbkVidMute.Checked = False
        End If
        If My.App.VidLockFullScreen Then : Me.chbxVidLockFullScreen.Checked = True
        Else : Me.chbxVidLockFullScreen.Checked = False
        End If
        Select Case My.App.VidPlayMode
            Case My.App.PlayMode.Linear
                Me.radbtnVidPlayModeLinear.Checked = True
            Case My.App.PlayMode.LinearWithRandomStart
                Me.radbtnVidPlayModeLinearWithRandomStart.Checked = True
            Case My.App.PlayMode.Random
                Me.radbtnVidPlayModeRandom.Checked = True
        End Select
        Select Case My.App.VidScale
            Case 0 : Me.radbtnVideoScaleFit.Checked = True
            Case 0.1 : Me.radbtnVideoScale10.Checked = True
            Case 0.25 : Me.radbtnVideoScale25.Checked = True
            Case 0.3333 : Me.radbtnVideoScale33.Checked = True
            Case 0.5 : Me.radbtnVideoScale50.Checked = True
            Case 0.6666 : Me.radbtnVideoScale66.Checked = True
            Case 0.75 : Me.radbtnVideoScale75.Checked = True
            Case 1 : Me.radbtnVideoScale100.Checked = True
            Case Else
                My.App.VidScale = 0.5
                Me.radbtnVideoScale50.Checked = True
        End Select
        If My.App.VidTime Then
            Me.chbxVidTime.Checked = True
            Me.cobxVidTimeDisplayMode.Enabled = True
            Me.grbxVidTimeLocationMode.Enabled = True
        Else
            Me.chbxVidTime.Checked = False
            Me.cobxVidTimeDisplayMode.Enabled = False
            Me.grbxVidTimeLocationMode.Enabled = False
        End If
        Select Case My.App.VidTimeLocationMode
            Case My.App.LocationMode.TopLeft : Me.radbtnVidTimeLocationModeTopLeft.Checked = True
            Case My.App.LocationMode.TopCenterLeft : Me.radbtnVidTimeLocationModeTopCenterLeft.Checked = True
            Case My.App.LocationMode.TopCenter : Me.radbtnVidTimeLocationModeTopCenter.Checked = True
            Case My.App.LocationMode.TopCenterRight : Me.radbtnVidTimeLocationModeTopCenterRight.Checked = True
            Case My.App.LocationMode.TopRight : Me.radbtnVidTimeLocationModeTopRight.Checked = True
            Case My.App.LocationMode.RightCenterTop : Me.radbtnVidTimeLocationModeRightCenterTop.Checked = True
            Case My.App.LocationMode.RightCenter : Me.radbtnVidTimeLocationModeRightCenter.Checked = True
            Case My.App.LocationMode.RightCenterBottom : Me.radbtnVidTimeLocationModeRightCenterBottom.Checked = True
            Case My.App.LocationMode.BottomRight : Me.radbtnVidTimeLocationModeBottomRight.Checked = True
            Case My.App.LocationMode.BottomCenterRight : Me.radbtnVidTimeLocationModeBottomCenterRight.Checked = True
            Case My.App.LocationMode.BottomCenter : Me.radbtnVidTimeLocationModeBottomCenter.Checked = True
            Case My.App.LocationMode.BottomCenterLeft : Me.radbtnVidTimeLocationModeBottomCenterLeft.Checked = True
            Case My.App.LocationMode.BottomLeft : Me.radbtnVidTimeLocationModeBottomLeft.Checked = True
            Case My.App.LocationMode.LeftCenterBottom : Me.radbtnVidTimeLocationModeLeftCenterBottom.Checked = True
            Case My.App.LocationMode.LeftCenter : Me.radbtnVidTimeLocationModeLeftCenter.Checked = True
            Case My.App.LocationMode.LeftCenterTop : Me.radbtnVidTimeLocationModeLeftCenterTop.Checked = True
        End Select
        If My.App.HKEnabled Then : Me.grbxHotKeysVids.Enabled = True
        Else : Me.grbxHotKeysVids.Enabled = False
        End If
        Me.lblHotKeyVidToggle.Text = My.App.HKVidToggle.Description
        Me.txbxHotKeyVidToggle.Text = My.App.HKVidToggle.Key.ToString
        Me.txbxHotKeyVidToggle.Tag = My.App.HKVidToggle
        Me.txbxHotKeyVidToggle.Font = New Font(Me.txbxHotKeyVidToggle.Font, FontStyle.Bold)
        Me.txbxHotKeyVidToggle.ForeColor = Color.Teal
        Me.lblHotKeyVidToggleFullScreen.Text = My.App.HKVidToggleFullScreen.Description
        Me.txbxHotKeyVidToggleFullScreen.Text = My.App.HKVidToggleFullScreen.Key.ToString
        Me.txbxHotKeyVidToggleFullScreen.Tag = My.App.HKVidToggleFullScreen
        Me.txbxHotKeyVidToggleFullScreen.Font = New Font(Me.txbxHotKeyVidToggleFullScreen.Font, FontStyle.Bold)
        Me.txbxHotKeyVidToggleFullScreen.ForeColor = Color.Teal
        Me.lblHotKeyVidShowFileInfo.Text = My.App.HKVidShowFileInfo.Description
        Me.txbxHotKeyVidShowFileInfo.Text = My.App.HKVidShowFileInfo.Key.ToString
        Me.txbxHotKeyVidShowFileInfo.Tag = My.App.HKVidShowFileInfo
        Me.txbxHotKeyVidShowFileInfo.Font = New Font(Me.txbxHotKeyVidShowFileInfo.Font, FontStyle.Bold)
        Me.txbxHotKeyVidShowFileInfo.ForeColor = Color.Teal
        Me.btnHotKeysVidsUndo.Enabled = False
        Me.btnHotKeysVidsSet.Enabled = False
        UpdateSettingsVids()
        Me.btnClose.Focus()
    End Sub
    Private Sub GetFiles(mode As My.App.GetFilesType)
        If Not Me.BackgroundworkerGetFiles.IsBusy Then
            My.App.IsGeneratingFileList = True
            AppNotify()
            Me.cmiViewPics.Enabled = False
            Me.cmiViewPics.ToolTipText = Nothing
            Me.cmiPlayVids.Enabled = False
            Me.cmiPlayVids.ToolTipText = Nothing
            Me.lvPicFolders.Enabled = False
            Me.btnRefreshPicList.Enabled = False
            Me.lvVidFolders.Enabled = False
            Me.btnRefreshVidList.Enabled = False
            Me.btnRestoreSettings.Enabled = False
            Me.lblPicFileCount.Text = My.App.GeneratingFileListAlertText
            Me.lblVidFileCount.Text = My.App.GeneratingFileListAlertText
            Me.TipInfoEX.SetText(Me.lblVidFileCount, My.App.GeneratingFileListAlertText)
            If My.App.FrmVidsVisible Then My.App.FrmVids.Close()
            If (mode = My.App.GetFilesType.Pics Or mode = My.App.GetFilesType.All) And My.App.FrmPicsVisible Then My.App.frmPics.Close()

            If My.App.LoadFileListsInBackground Then : My.Application.CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.BelowNormal
            Else : My.Application.CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.Normal
            End If
            Me.BackgroundworkerGetFiles.RunWorkerAsync(mode)
        End If
    End Sub
    Private Sub BackgroundworkerGetFilesDoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim mode As My.App.GetFilesType = CType(e.Argument, My.App.GetFilesType)
        Dim filelist As New Collections.Generic.List(Of String)
        If mode = My.App.GetFilesType.Pics Or mode = My.App.GetFilesType.All Then
            If My.App.ImageFiles.Count = 0 Then : GenerateImageListType = My.App.GetFilesMode.Generated
            Else : GenerateImageListType = My.App.GetFilesMode.Refreshed
            End If
            Dim removelist As New Collections.Generic.List(Of String)
            GenerateImageListStartTime = My.Computer.Clock.LocalTime.TimeOfDay
            My.App.ImageFiles.Clear()

            For Each folder As String In My.App.PicFolders
                Try
                    filelist.AddRange(IO.Directory.GetFiles(folder, "*", IO.SearchOption.AllDirectories))
                    For Each s As String In filelist : If My.App.CheckFileType(s, My.App.FileType.Pic) Then My.App.ImageFiles.Add(s)
                    Next
                Catch : removelist.Add(folder)
                Finally : filelist.Clear()
                End Try
            Next
            For Each folder As String In removelist : My.App.PicFolders.Remove(folder) : Next
            If GenerateImageListType = My.App.GetFilesMode.Refreshed Then
                For index As Integer = My.App.ImageRepeatList.Count - 1 To 0 Step -1
                    If Not My.App.ImageFiles.Contains(My.App.ImageRepeatList(index)) Then My.App.ImageRepeatList.RemoveAt(index)
                Next
            End If
            If My.App.ImageFiles.Count > 0 Then My.App.ImageFiles.Sort()
            GenerateImageListEndTime = My.Computer.Clock.LocalTime.TimeOfDay
            removelist.Clear()
            removelist = Nothing
        End If
        If mode = My.App.GetFilesType.Vids Or mode = My.App.GetFilesType.All Then
            If My.App.VideoFiles.Count = 0 Then : GenerateVideoListType = My.App.GetFilesMode.Generated
            Else : GenerateVideoListType = My.App.GetFilesMode.Refreshed
            End If
            Dim removelist As New Collections.Generic.List(Of Integer)
            GenerateVideoListStartTime = My.Computer.Clock.LocalTime.TimeOfDay
            'Remove Dead Or Missing Files
            If GenerateVideoListType = My.App.GetFilesMode.Refreshed Then
                For index As Integer = My.App.VideoFiles.Count - 1 To 0 Step -1
                    If Not My.App.VideoFiles(index).State = My.App.VideoFileState.Valid Then : My.App.VideoFiles.RemoveAt(index)
                    ElseIf Not My.Computer.FileSystem.FileExists(My.App.VideoFiles(index).Path) Then : My.App.VideoFiles.RemoveAt(index)
                    End If
                Next
            End If
            'Get Files
            For index As Integer = 0 To My.App.VidFolders.Count - 1
                Dim folder As My.App.VideoFolderType = My.App.VidFolders(index)
                Try
                    filelist.AddRange(IO.Directory.GetFiles(folder.Path, "*", IO.SearchOption.AllDirectories))
                    For Each s As String In filelist : If My.App.CheckFileType(s, My.App.FileType.Vid) Then If GenerateVideoListType = My.App.GetFilesMode.Generated OrElse (GenerateVideoListType = My.App.GetFilesMode.Refreshed And Not My.App.VideoFilesContains(s)) Then My.App.VideoFiles.Add(New My.App.VideoFileType(s, folder.Enabled))
                    Next
                Catch : removelist.Add(index)
                Finally : filelist.Clear()
                End Try
            Next
            removelist.Reverse()
            For Each index As Integer In removelist : My.App.VidFolders.RemoveAt(index) : Next
            If My.App.VideoFiles.Count > 0 Then My.App.VideoFiles.Sort(New My.App.VideoFileType.Comparer)
            GenerateVideoListEndTime = My.Computer.Clock.LocalTime.TimeOfDay
            removelist.Clear()
            removelist = Nothing
        End If
        filelist = Nothing
        e.Result = e.Argument
    End Sub
    Private Sub BackgroundworkerGetFilesRunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        My.Application.CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.AboveNormal
        Me.lvPicFolders.Enabled = True
        Me.btnRefreshPicList.Enabled = True
        Me.lvVidFolders.Enabled = True
        Me.btnRefreshVidList.Enabled = True
        Me.btnRestoreSettings.Enabled = True
        Me.cmiViewPics.ToolTipText = "RightClick = Show Maximized"
        Me.cmiViewPics.Enabled = True
        Me.cmiPlayVids.ToolTipText = "RightClick = Show Maximized"
        Me.cmiPlayVids.Enabled = True
        Dim mode As My.App.GetFilesType = CType(e.Result, My.App.GetFilesType)
        If (mode = My.App.GetFilesType.Pics Or mode = My.App.GetFilesType.All) Then
            My.App.WriteToLog("Image List " + Me.GenerateImageListType.ToString + " (" + My.App.ImageFiles.Count.ToString + ") (" + Skye.Common.GenerateLogTime(GenerateImageListStartTime, GenerateImageListEndTime) + ")")
            GenerateImageListStartTime = TimeSpan.Zero
            GenerateImageListEndTime = TimeSpan.Zero
        End If
        If (mode = My.App.GetFilesType.Vids Or mode = My.App.GetFilesType.All) Then
            My.App.WriteToLog("Video List " + Me.GenerateVideoListType.ToString + " (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + ") (" + Skye.Common.GenerateLogTime(GenerateVideoListStartTime, GenerateVideoListEndTime) + ")")
            GenerateVideoListStartTime = TimeSpan.Zero
            GenerateVideoListEndTime = TimeSpan.Zero
        End If
        ShowSettings()
        My.App.IsGeneratingFileList = False
        If Not My.App.WorkSpaceSuspended Then
            If ((My.App.PicAutoView And (mode = My.App.GetFilesType.Pics Or mode = My.App.GetFilesType.All)) Or ImageActiveOnRefresh) And Not My.App.FrmPicsVisible And My.App.ImageFiles.Count > 0 Then My.App.ShowImages()

            If Not String.IsNullOrEmpty(My.App.CommandLinePath) Then : My.App.ShowVideoFromCommandLine()
            Else : If ((My.App.VidAutoView And (mode = My.App.GetFilesType.Vids Or mode = My.App.GetFilesType.All)) Or VideoActiveOnRefresh) And My.App.VideoFilesCount > 0 Then My.App.ShowVideos()
            End If
        End If
        ToggleContextMenu()
    End Sub
    Private Sub ShowForm()
        Select Case Me.Visible
            Case True
                If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
                HideForm()
            Case False
                Me.Show()
                Me.Activate()
                Me.cmiSettings.Checked = True
        End Select
    End Sub
    Private Sub HideForm()
        If Me.Visible Then
            Me.Hide()
            Me.cmiSettings.Checked = False
        End If
    End Sub
    Private Sub SetThemesList()
        If App.ThemeAuto Then
            CoBoxTheme.Enabled = False
        Else
            CoBoxTheme.Enabled = True
        End If
    End Sub
    Private Sub ToggleFolderList(mode As My.App.GetFilesType, Optional reset As Boolean = False)
        Me.TipInfoEX.HideTooltip()
        If mode = My.App.GetFilesType.Pics Or mode = My.App.GetFilesType.All Then
            If Me.lvPicFolders.Columns(1).Width = 0 And Not reset Then
                If Me.lvPicFolders.Items.Count < 5 Then : Me.lvPicFolders.Columns(1).Width = Me.lvPicFolders.Width
                Else : Me.lvPicFolders.Columns(1).Width = Me.lvPicFolders.Width - 18
                End If
                Me.lvPicFolders.Columns(2).Width = 0
                Me.btnlvPicFolders.Text = "View By Folder Name"
            Else
                Me.lvPicFolders.Columns(1).Width = 0
                If Me.lvPicFolders.Items.Count < 5 Then : Me.lvPicFolders.Columns(2).Width = Me.lvPicFolders.Width
                Else : Me.lvPicFolders.Columns(2).Width = Me.lvPicFolders.Width - 18
                End If
                Me.btnlvPicFolders.Text = "View By Full Path"
            End If
        End If
        If mode = My.App.GetFilesType.Vids Or mode = My.App.GetFilesType.All Then
            If Me.lvVidFolders.Columns(1).Width = 0 And Not reset Then
                If Me.lvVidFolders.Items.Count < 5 Then : Me.lvVidFolders.Columns(1).Width = Me.lvVidFolders.Width
                Else : Me.lvVidFolders.Columns(1).Width = Me.lvVidFolders.Width - 18
                End If
                Me.lvVidFolders.Columns(2).Width = 0
                Me.btnlvVidFolders.Text = "View By Folder Name"
            Else
                Me.lvVidFolders.Columns(1).Width = 0
                If Me.lvVidFolders.Items.Count < 5 Then : Me.lvVidFolders.Columns(2).Width = Me.lvVidFolders.Width
                Else : Me.lvVidFolders.Columns(2).Width = Me.lvVidFolders.Width - 18
                End If
                Me.btnlvVidFolders.Text = "View By Full Path"
            End If
        End If
    End Sub
    Private Sub CheckMove(ByRef location As Point)
        Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
        If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
        If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
        If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
        If location.Y < screen.Top Then location.Y = screen.Top
    End Sub

End Class
