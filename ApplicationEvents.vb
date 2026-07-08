
Imports System.Collections.ObjectModel
Imports LibVLCSharp.[Shared]

Namespace My
	Partial Friend Class MyApplication

		' Declarations
		Friend CurrentProcess As Diagnostics.Process = Diagnostics.Process.GetCurrentProcess

		' Events
		Public Sub New()
			MyBase.New(ApplicationServices.AuthenticationMode.Windows)
			EnableVisualStyles = True
			IsSingleInstance = True
			SaveMySettingsOnExit = False
			ShutdownStyle = ApplicationServices.ShutdownMode.AfterMainFormCloses
			CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.AboveNormal
		End Sub
		Protected Overrides Function OnStartup(e As ApplicationServices.StartupEventArgs) As Boolean
			If e.Cancel Then Return False

			' Show splash
			Dim splash As New Splash()
			splash.Show()
			splash.Refresh()

			LibVLCSharp.Shared.Core.Initialize()
			Try
				Using vlcwarmup As New LibVLC()
					'Do Nothing - Just Warm Up LibVLC
				End Using
			Catch
			End Try

			splash.Close()
			splash.Dispose()

			Return True
		End Function
		Protected Overrides Sub OnCreateMainForm()
			App.FrmMain = New MainForm
			MainForm = App.FrmMain
			App.Initialize()
		End Sub

	End Class

End Namespace
