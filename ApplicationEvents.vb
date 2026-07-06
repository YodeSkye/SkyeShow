
Imports System.Collections.ObjectModel
Imports LibVLCSharp.[Shared]

Namespace My
	Partial Friend Class MyApplication

		'App Declarations
		Friend CurrentProcess As Diagnostics.Process = Diagnostics.Process.GetCurrentProcess
		Friend AlternateStart As Boolean = False
		Private _pendingArgs As ReadOnlyCollection(Of String)

		'App Events
		Public Sub New()
			MyBase.New(ApplicationServices.AuthenticationMode.Windows)
			If My.Computer.Keyboard.ShiftKeyDown Then AlternateStart = True
			Me.EnableVisualStyles = True
			Me.IsSingleInstance = True
			Me.SaveMySettingsOnExit = False
			Me.ShutdownStyle = ApplicationServices.ShutdownMode.AfterMainFormCloses
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

			_pendingArgs = e.CommandLine
			Return True
		End Function
		Protected Overrides Sub OnStartupNextInstance(e As ApplicationServices.StartupNextInstanceEventArgs)
			e.BringToForeground = False
			ProcessCommandLine(e.CommandLine)
		End Sub
		Protected Overrides Sub OnCreateMainForm()
			App.FrmMain = New MainForm
			Me.MainForm = App.FrmMain
			My.App.Initialize()
			If _pendingArgs IsNot Nothing Then ProcessCommandLine(_pendingArgs)
		End Sub

		'App Procedures
		Private Sub ProcessCommandLine(ByRef commandline As Collections.ObjectModel.ReadOnlyCollection(Of String))
			If commandline.Count > 0 Then
				Try
					If commandline.Count = 1 Then
						If String.IsNullOrEmpty(commandline(0)) Then : Throw New Exception
						Else
							My.App.CommandLinePath = commandline(0)
							If Not My.App.IsGeneratingFileList Then My.App.ShowVideoFromCommandLine()
						End If
					Else : Throw New Exception
					End If
				Catch
					Dim commandlineparameters As String = String.Empty
					For Each s As String In commandline : commandlineparameters += IIf(String.IsNullOrEmpty(s), "<NULL>", s).ToString + " " : Next
					commandlineparameters = commandlineparameters.Trim(CType(" ", Char))
					My.App.WriteToLog("Invalid CommandLine Parameters (" + commandline.Count.ToString + ") : " + commandlineparameters)
					My.App.SetErrorAlert()
				End Try
			End If
		End Sub

	End Class

End Namespace
