
Imports System.Diagnostics
Imports System.Reflection
Imports LibVLCSharp.[Shared]

Namespace My

	Public Module App

#Region "Pics"

		'Declarations Saved In Registry
		Friend picFolders As New Collections.Generic.List(Of String)
		Friend picLocation As System.Drawing.Point
		Friend picLocationMode As LocationMode
		Friend picJustify As LocationJustify
		Friend picMaxSize As Int16
		Friend picPlayMode As PlayMode
		Friend picAutoView As Boolean
		Friend picLockFullScreen As Boolean
		Friend picTimerEnabled As Boolean
		Friend picTimerAutoStart As Boolean
		Friend picTimerCountdown As Boolean
		Friend picTimerCountdownLocationMode As LocationMode
		Friend picTimerInterval As Integer

		'Declarations
		Friend Const ImageTimerCountdownBorderPadding As Integer = 5
		Friend ImageFiles As New Collections.Generic.List(Of String)
		Friend ImageExtensions As New Collections.Generic.List(Of String)
		Friend ImageIndex As Integer = -1
		Friend ImageIndexPrevious As Integer = -1
		Friend ImageRepeatList As New Collections.Generic.List(Of String)
		Friend ImageIsOnTop As Boolean = True
		Friend frmPics As Pics

		'Procedures
		Friend Sub ShowImages()
			frmPics = New Pics
			frmPics.Show()
		End Sub
		Friend Sub SaveImageFileList()
			Try
				If My.App.appSaveFileLists Then
					If My.App.ImageFiles.Count = 0 Then
						If My.Computer.FileSystem.FileExists(My.App.ImageFilesPath) Then My.Computer.FileSystem.DeleteFile(My.App.ImageFilesPath)
					Else
						Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
						Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
						Dim file As New System.IO.StreamWriter(My.App.ImageFilesPath)
						writer.Serialize(file, My.App.ImageFiles)
						file.Close()
						file.Dispose()
						writer = Nothing
						My.App.WriteToLog(My.App.AppMode.Pictures, "Image List Saved (" + My.App.ImageFiles.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Save Image List: " + ex.Message, True)
			End Try
		End Sub
		Friend Sub LoadImageFileList()
			Try
				If My.App.appSaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.ImageFilesPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
					Dim file As New System.IO.FileStream(My.App.ImageFilesPath, IO.FileMode.Open)
					My.App.ImageFiles = CType(reader.Deserialize(file), Collections.Generic.List(Of String))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog(My.App.AppMode.Pictures, "Image List Loaded (" + My.App.ImageFiles.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
					starttime = TimeSpan.Zero
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Load Image List: " + ex.Message, True)
			End Try
		End Sub
		Friend Sub SaveImageRepeatList()
			Try
				If My.App.appSaveFileLists Then
					If My.App.ImageFiles.Count = 0 Then
						If My.Computer.FileSystem.FileExists(My.App.ImageRepeatListPath) Then My.Computer.FileSystem.DeleteFile(My.App.ImageRepeatListPath)
					Else
						Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
						Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
						Dim file As New System.IO.StreamWriter(My.App.ImageRepeatListPath)
						writer.Serialize(file, My.App.ImageRepeatList)
						file.Close()
						file.Dispose()
						writer = Nothing
						My.App.WriteToLog(My.App.AppMode.Pictures, "Viewed Image List Saved (" + My.App.ImageRepeatList.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Save Viewed Image List: " + ex.Message, True)
			End Try
		End Sub
		Friend Sub LoadImageRepeatList()
			Try
				If My.App.appSaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.ImageRepeatListPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
					Dim file As New System.IO.FileStream(My.App.ImageRepeatListPath, IO.FileMode.Open)
					My.App.ImageRepeatList = CType(reader.Deserialize(file), Collections.Generic.List(Of String))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog(My.App.AppMode.Pictures, "Viewed Image List Loaded (" + My.App.ImageRepeatList.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
					starttime = TimeSpan.Zero
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Load Viewed Image List: " + ex.Message, True)
			End Try
		End Sub
		Friend Function FrmPicsVisible() As Boolean
			If frmPics IsNot Nothing AndAlso frmPics.Visible Then Return True
			Return False
		End Function
		Friend Function ImageIndexLogText() As String
			ImageIndexLogText = "Image Index " + ImageIndex.ToString
			If ImageIndex >= 0 Then ImageIndexLogText += " (" + ImageFiles(ImageIndex) + ")"
		End Function

#End Region

#Region "Vids"

		'Declarations Saved In Registry
		Friend vidFolders As New Collections.Generic.List(Of VideoFolderType)
		Friend vidExtensions As New Collections.Generic.List(Of String)
		Friend vidLocation As System.Drawing.Point
		Friend vidLocationMode As LocationMode
		Friend vidScale As Single
		Friend vidMaxSize As Int16
		Friend vidPlayMode As PlayMode
		Friend vidAutoView As Boolean
		Friend vidLockFullScreen As Boolean
		Friend vidVolume As Int16
		Friend vidVolumeMute As Boolean
		Friend vidTime As Boolean
		Friend vidTimeDisplayMode As VideoPositionMode
		Friend vidTimeLocationMode As LocationMode

		'Declarations
		Friend Enum VideoPositionMode
			CurrentPosition
			TimeRemaining
		End Enum
		Friend Function VideoPositionModeToString(mode As VideoPositionMode) As String
			Select Case mode
				Case VideoPositionMode.CurrentPosition : VideoPositionModeToString = "Current Position"
				Case VideoPositionMode.TimeRemaining : VideoPositionModeToString = "Time Remaining"
				Case Else : VideoPositionModeToString = "UnKnown Mode"
			End Select
		End Function
		Public Enum VideoFileState
			Valid
			Deleted
			PathNotFound
			DisplayError
		End Enum
		Friend Enum VideoFilesCountMode
			Viewed
			UnViewed
			Enabled
			Disabled
			Valid
			InValid
			Total
		End Enum
		Public Structure VideoFileType
			Public Path As String
			Public Viewed As Boolean
			Public Enabled As Boolean
			Public State As VideoFileState
			Public ReadOnly Property SearchName As String
				Get
					Dim split As String()
					split = Me.Path.Split(CChar("\"))
					Return split.GetValue(split.Length - 1).ToString
					Array.Clear(split, 0, split.Length)
					split = Nothing
				End Get
			End Property '
			Public Sub New(path As String)
				Me.Path = path
				Me.Viewed = False
				Me.Enabled = True
				Me.State = VideoFileState.Valid
			End Sub
			Public Sub New(path As String, enabled As Boolean)
				Me.Path = path
				Me.Viewed = False
				Me.Enabled = enabled
				Me.State = VideoFileState.Valid
			End Sub
			Public Function ViewedText() As String
				Select Case Me.Viewed
					Case True : Return "Yes"
					Case False : Return "No"
					Case Else : Return "Error"
				End Select
			End Function
			Public Function EnabledText() As String
				Select Case Me.Enabled
					Case True : Return "Yes"
					Case False : Return "No"
					Case Else : Return "Error"
				End Select
			End Function
			Public Overrides Function ToString() As String
				Return Me.Path
			End Function
			Public Class Comparer
				Implements Collections.Generic.IComparer(Of VideoFileType)
				Public Function Compare(ByVal x As VideoFileType, ByVal y As VideoFileType) As Integer Implements Collections.Generic.IComparer(Of VideoFileType).Compare
					If x.Path Is Nothing Then
						If y.Path Is Nothing Then : Return 0
						Else : Return -1
						End If
					Else
						If y.Path Is Nothing Then : Return 1
						Else : Return x.Path.CompareTo(y.Path)
						End If
					End If
				End Function
			End Class
		End Structure
		Friend Structure VideoFolderType
			Public Path As String
			Public Enabled As Boolean
			Public ReadOnly Property SearchPath As String
				Get
					Return Me.Path + "\"
				End Get
			End Property '
			Public Sub New(path As String)
				Me.Path = path
				Me.Enabled = True
			End Sub
			Public Sub New(path As String, enabled As Boolean)
				Me.Path = path
				Me.Enabled = enabled
			End Sub
			Public Overrides Function ToString() As String
				Return Me.Path
			End Function
			Public Class Comparer
				Implements Collections.Generic.IComparer(Of VideoFolderType)
				Public Function Compare(ByVal x As VideoFolderType, ByVal y As VideoFolderType) As Integer Implements Collections.Generic.IComparer(Of VideoFolderType).Compare
					If x.Path Is Nothing Then
						If y.Path Is Nothing Then : Return 0
						Else : Return -1
						End If
					Else
						If y.Path Is Nothing Then : Return 1
						Else : Return x.Path.CompareTo(y.Path)
						End If
					End If
				End Function
			End Class
		End Structure
		Friend Const VideoTimeBorderPadding As Integer = 5
		Friend VideoFiles As New Collections.Generic.List(Of VideoFileType)
		Friend VideoIndex As Integer = -1
		Friend VideoIndexPrevious As Integer = -1
		Friend VideoIsOnTop As Boolean = True
		Friend frmVids As Vids
		Friend frmVidList As VidList

		'Procedures
		Friend Sub ShowVideos(Optional showBySelection As Boolean = False)
			If FrmVidsVisible() Then frmVids.Close()
			frmVids = New Vids(showBySelection)
			Try : frmVids.Show() : Catch : End Try
		End Sub
		Friend Sub ShowVideoFromCommandLine()
			Debug.Print(AppMode.SkyeShow.ToString + " --> ShowVideoFromCommandLine " + CommandLinePath.ToUpper)
			Dim video As New VideoFileType(CommandLinePath)
			CommandLinePath = String.Empty
			VideoFiles.Add(video)
			frmMain.UpdateSettings()
			VideoIndex = VideoFiles.Count - 1
			ShowVideos(True)
			frmMain.ToggleContextMenu()
		End Sub
		Friend Sub ShowVideoList()
			frmVidList = New VidList
			frmVidList.Show()
		End Sub
		Friend Sub SaveVideoFileList()
			Try
				If My.App.appSaveFileLists Then
					If My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total) = 0 Then : If My.Computer.FileSystem.FileExists(My.App.VideoFilesPath) Then My.Computer.FileSystem.DeleteFile(My.App.VideoFilesPath)
					Else
						Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
						Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of VideoFileType)))
						Dim file As New System.IO.StreamWriter(My.App.VideoFilesPath)
						writer.Serialize(file, My.App.VideoFiles)
						file.Close()
						file.Dispose()
						writer = Nothing
						My.App.WriteToLog(My.App.AppMode.Videos, "Video List Saved (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Save Video List: " + ex.Message, True)
			End Try
		End Sub
		Friend Sub LoadVideoFileList()
			Try
				If My.App.appSaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.VideoFilesPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of VideoFileType)))
					Dim file As New System.IO.FileStream(My.App.VideoFilesPath, IO.FileMode.Open)
					My.App.VideoFiles = CType(reader.Deserialize(file), Collections.Generic.List(Of VideoFileType))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog(My.App.AppMode.Videos, "Video List Loaded (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")", True)
					starttime = TimeSpan.Zero
					VideoFilesResetEnabled()
				End If
			Catch ex As Exception : WriteToLog(AppMode.Pictures, "Cannot Load Video List: " + ex.Message, True)
			End Try
		End Sub
		Friend Sub VideoFilesSetViewed(index As Integer)
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesSetViewed", "Index = " + index.ToString)
			Dim file As VideoFileType = VideoFiles(index)
			file.Viewed = True
			VideoFiles.RemoveAt(index)
			VideoFiles.Insert(index, file)
			If VideoFilesCount() = 0 Then VideoFilesResetViewed()
			frmMain.UpdateSettings()
		End Sub
		Friend Sub VideoFilesResetViewed()
			For index As Integer = 0 To VideoFiles.Count - 1
				If VideoFiles(index).Enabled Then
					Dim file As VideoFileType = VideoFiles(index)
					file.Viewed = False
					VideoFiles.RemoveAt(index)
					VideoFiles.Insert(index, file)
				End If
			Next
		End Sub
		Friend Sub VideoFilesSetEnabled(folderindex As Integer, enabled As Boolean)
			For index As Integer = 0 To VideoFiles.Count - 1
				If VideoFiles(index).Path.StartsWith(vidFolders(folderindex).SearchPath) AndAlso VideoFiles(index).State = VideoFileState.Valid Then
					Dim file As VideoFileType = VideoFiles(index)
					file.Enabled = enabled
					VideoFiles.RemoveAt(index)
					VideoFiles.Insert(index, file)
				End If
			Next
			If VideoFilesCount() = 0 Then VideoFilesResetViewed()
		End Sub
		Friend Sub VideoFilesResetEnabled()
			Dim file As VideoFileType
			For fileindex As Integer = 0 To VideoFiles.Count - 1
				For folderindex As Integer = 0 To vidFolders.Count - 1
					If VideoFiles(fileindex).Path.StartsWith(vidFolders(folderindex).SearchPath) AndAlso VideoFiles(fileindex).State = VideoFileState.Valid Then
						file = VideoFiles(fileindex)
						file.Enabled = vidFolders(folderindex).Enabled
						VideoFiles.RemoveAt(fileindex)
						VideoFiles.Insert(fileindex, file)
					End If
				Next
			Next
		End Sub
		Friend Sub VideoFilesSetState(index As Integer, state As VideoFileState)
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesSetState", "Index = " + index.ToString)
			Dim file As VideoFileType = VideoFiles(index)
			Select Case state
				Case VideoFileState.Valid
					file.Viewed = False
					For Each folder As VideoFolderType In vidFolders : If file.Path.StartsWith(folder.SearchPath) AndAlso folder.Enabled Then file.Enabled = True
					Next
					file.State = state
				Case Else
					file.Viewed = True
					file.Enabled = False
					file.State = state
			End Select
			VideoFiles.RemoveAt(index)
			VideoFiles.Insert(index, file)
			If Not state = VideoFileState.Valid AndAlso VideoFilesCount() = 0 Then VideoFilesResetViewed()
			frmMain.UpdateSettings()
		End Sub
		Friend Function FrmVidsVisible() As Boolean
			If frmVids IsNot Nothing AndAlso frmVids.Visible Then Return True
			Return False
		End Function
		Friend Function FrmVidListVisible() As Boolean
			If frmVidList IsNot Nothing AndAlso frmVidList.Visible Then : Return True
			Else : Return False
			End If
		End Function
		Friend Function VideoFileReEnable(index As Integer) As VideoFileType
			Dim file As VideoFileType = VideoFiles(index)
			file.State = VideoFileState.Valid
			file.Viewed = False
			file.Enabled = True
			Return file
		End Function
		Friend Function VideoFilesCount(Optional countmode As VideoFilesCountMode = VideoFilesCountMode.UnViewed) As Integer
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesCount", "StartTime " + My.Computer.Clock.LocalTiMe.TimeOfDay.ToString)
			VideoFilesCount = 0
			For Each file As VideoFileType In VideoFiles
				Select Case countmode
					Case VideoFilesCountMode.Viewed : If file.Enabled And file.Viewed Then VideoFilesCount += 1
					Case VideoFilesCountMode.UnViewed : If file.Enabled And Not file.Viewed Then VideoFilesCount += 1
					Case VideoFilesCountMode.Enabled : If file.Enabled Then VideoFilesCount += 1
					Case VideoFilesCountMode.Disabled : If Not file.Enabled And file.State = VideoFileState.Valid Then VideoFilesCount += 1
					Case VideoFilesCountMode.Valid : If file.State = VideoFileState.Valid Then VideoFilesCount += 1
					Case VideoFilesCountMode.InValid : If Not file.State = VideoFileState.Valid Then VideoFilesCount += 1
					Case VideoFilesCountMode.Total : VideoFilesCount += 1
				End Select
			Next
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesCount", VideoFilesCount.ToString)
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesCount", "EndTime " + My.Computer.Clock.LocalTiMe.TimeOfDay.ToString)
		End Function
		'''<returns>Returns zero-based index of first Enabled item in My.SkyeShow.VideoFiles. Returns -1 if no Enabled items are found.</returns>
		Friend Function VideoFilesFindFirstEnabled() As Integer
			For index As Integer = 0 To VideoFiles.Count - 1 : If VideoFiles(index).Enabled Then Return index
			Next
			Return -1
		End Function
		Friend Function VideoFilesContains(path As String) As Boolean
			For Each file As VideoFileType In VideoFiles : If file.Path.Equals(path, StringComparison.CurrentCultureIgnoreCase) Then Return True
			Next
			Return False
		End Function
		Friend Function VideoFoldersContains(path As String) As Boolean
			For Each folder As VideoFolderType In vidFolders : If folder.Path.Equals(path, StringComparison.CurrentCultureIgnoreCase) Then Return True
			Next
			Return False
		End Function
		Friend Function VideoIndexLogText() As String
			VideoIndexLogText = "Video Index " + VideoIndex.ToString
			If VideoIndex >= 0 Then VideoIndexLogText += " (" + VideoFiles(VideoIndex).Path + ")"
		End Function

#End Region

#Region "App"

		'Declarations Saved In Registry
		Friend appSaveFileLists As Boolean 'Default = False
		Friend appLoadFileListsInBackground As Boolean 'Default = True
		Friend appRefreshFileListsOnStartUp As Boolean 'Default = True
		Friend appHideCursorWhenFullscreen As Boolean 'Default = True
		Friend appActionOnScreenSave As ScreenSaveActions 'Default = Close
		Friend appInsideLocationOffset As UInt16 'Default = 40 'Inside Offset for Pic & Vid Location Mode
		Friend hkEnabled As Boolean
		Friend hkPicToggle As New HotKey
		Friend hkPicToggleFullScreen As New HotKey
		Friend hkPicShowFileInfo As New HotKey
		Friend hkVidToggle As New HotKey
		Friend hkVidToggleFullScreen As New HotKey
		Friend hkVidShowFileInfo As New HotKey

		'Declarations
		Friend Const LocationModeManualAnchorThreshold As Byte = 50 'Percent of screen width/height that determines when the manual mode anchor should be right/bottom of form.
		Friend Const GeneratingFileListAlertText As String = "Generating File List ... Please Wait"
		Friend ReadOnly UserPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Skye\" 'UserPath is the base path for user-specific files.
		Public ReadOnly Property AppTitle As String
			Get
				Dim asm As Assembly = Assembly.GetExecutingAssembly()
				Dim titleAttr As AssemblyTitleAttribute = asm.GetCustomAttribute(Of AssemblyTitleAttribute)()
				Return titleAttr.Title 'If(titleAttr IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(titleAttr.Title), titleAttr.Title, My.Application.Info.Title)
			End Get
		End Property

#If DEBUG Then
		Private ReadOnly LogPath As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Application.Info.ProductName + "LogDEV.txt" 'LogPath is the path to the log file.
		Private ReadOnly RegPath As String = "Software\\" + My.Application.Info.ProductName + "DEV" 'RegPath is the path to the registry key where application settings are stored.
		Friend ReadOnly ImageFilesPath As String = UserPath + My.Application.Info.ProductName + "ImagesDEV.xml"
		Friend ReadOnly ImageRepeatListPath As String = UserPath + My.Application.Info.ProductName + "ImagesViewedDEV.xml"
		Friend ReadOnly VideoFilesPath As String = UserPath + My.Application.Info.ProductName + "VideosDEV.xml"
#Else
		Private ReadOnly LogPath As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + My.Application.Info.ProductName + "Log.txt" 'LogPath is the path to the log file.
		Private ReadOnly RegPath As String = "Software\\" + My.Application.Info.ProductName 'RegPath is the path to the registry key where application settings are stored.
		Friend ReadOnly ImageFilesPath As String = UserPath + My.Application.Info.ProductName + "Images.xml"
		Friend ReadOnly ImageRepeatListPath As String = UserPath + My.Application.Info.ProductName + "ImagesViewed.xml"
		Friend ReadOnly VideoFilesPath As String = UserPath + My.Application.Info.ProductName + "Videos.xml"
#End If
		Friend Enum AppMode
			Pictures
			Videos
			WallPaper
			SkyeShow
		End Enum
		Friend Enum GetFilesMode
			Generated
			Refreshed
		End Enum
		Friend Enum GetFilesType
			Pics
			Vids
			All
		End Enum
		Friend Enum FileType
			Pic
			Vid
		End Enum
		Friend Enum PlayMode
			Linear
			LinearWithRandomStart
			Random
		End Enum
		Friend Enum PlayOption
			ByPlayMode
			BySelection
			Forward
			Backward
			Random
			Previous
		End Enum
		Friend Enum LocationMode
			Manual
			TopLeft
			TopCenterLeft
			TopCenter
			TopCenterRight
			TopRight
			RightCenterTop
			RightCenter
			RightCenterBottom
			BottomRight
			BottomCenterRight
			BottomCenter
			BottomCenterLeft
			BottomLeft
			LeftCenterBottom
			LeftCenter
			LeftCenterTop
			TopLeftInside
			TopCenterLeftInside
			TopCenterInside
			TopCenterRightInside
			TopRightInside
			RightCenterTopInside
			RightCenterInside
			RightCenterBottomInside
			BottomRightInside
			BottomCenterRightInside
			BottomCenterInside
			BottomCenterLeftInside
			BottomLeftInside
			LeftCenterBottomInside
			LeftCenterInside
			LeftCenterTopInside
		End Enum
		Friend LocationModeCount As Integer = 32
		Friend Enum LocationJustify
			Left
			Center
			Right
		End Enum
		Friend Enum FormatFileSizeUnits
			Auto
			Bytes
			KiloBytes
			MegaBytes
			GigaBytes
		End Enum
		Friend Enum WindowSize
			Small '400x240
			Medium '640x480
			Large '800x600
		End Enum
		Friend Enum ScreenSaveActions
			NoAction
			Suspend
			Close
		End Enum
		Friend Structure HotKey
			Dim WinID As Integer
			Dim Description As String
			Dim Key As Keys
			Dim KeyCode As Byte
			Dim KeyMod As Byte
			ReadOnly Property KeyText As String
				Get
					Dim kc As New System.Windows.Forms.KeysConverter
					KeyText = kc.ConvertToString(Key)
				End Get
			End Property
			Sub New(id As Integer, description As String, key As Keys, keycode As Byte, keymod As Byte)
				Me.WinID = id
				Me.Description = description
				Me.Key = key
				Me.KeyCode = keycode
				Me.KeyMod = keymod
			End Sub
		End Structure
		Friend ErrorAlert As Boolean = False
		Friend IsGeneratingFileList As Boolean
		Friend CommandLinePath As String = String.Empty
		Friend BalloonLoading As Boolean = False
		Friend IgnoreFocusChange As Boolean = False
		Friend HotKeys As New Collections.Generic.List(Of HotKey)
		Friend frmMain As MainForm
		Friend Function FormSize(windowsize As WindowSize) As Size
			Select Case windowsize
				Case WindowSize.Small : Return New Size(400, 240)
				Case WindowSize.Medium : Return New Size(640, 480)
				Case WindowSize.Large : Return New Size(800, 600)
			End Select
		End Function
		Private WithEvents FrmBalloonTimer As New Timer
		Private WithEvents ScreenSaverWatcher As New Timer
		Private SettingsRegKey As Microsoft.Win32.RegistryKey
		Private SettingsRegSubKey As Microsoft.Win32.RegistryKey
		Private ScreenSaverRunning As Boolean = False
		Private WorkStationLocked As Boolean = False
		Private ReadOnly RandomFileIndex As New Random
		Private frmInfo As InfoForm
		Private ReadOnly frmBalloon As New Balloon
		Private frmBalloonParent As String = String.Empty

		'Handlers
		Private Sub FrmBalloonTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles FrmBalloonTimer.Tick
			HideBalloon()
		End Sub
		Private Sub ScreenSaverWatcherTick(ByVal sender As Object, ByVal e As EventArgs) Handles ScreenSaverWatcher.Tick
			Static ssStatus As Boolean
			Skye.WinAPI.SystemParametersInfo(Skye.WinAPI.SPI_GETSCREENSAVERRUNNING, 0, ssStatus, 0)
			Select Case ssStatus
				Case True
					If Not ScreenSaverRunning Then
						ScreenSaverRunning = True
						Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> ScreenSaverWatcherTick --> SS Activated @ " & Now)
						WriteToLog(My.App.AppMode.SkyeShow, "ScreenSaver Activated", True)
						WorkSpaceSuspendedActions()
					End If
				Case False
					If ScreenSaverRunning Then
						ScreenSaverRunning = False
						Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> ScreenSaverWatcherTick --> SS DeActivated @ " & Now)
						WriteToLog(My.App.AppMode.SkyeShow, "ScreenSaver DeActivated", True)
					End If
			End Select
		End Sub
		Private Sub WorkStationLockedHandler(sender As Object, e As Microsoft.Win32.SessionSwitchEventArgs)
			If e.Reason = Microsoft.Win32.SessionSwitchReason.SessionLock Then
				WorkStationLocked = True
				Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> SessionSwitch --> Workstation Locked @ " & Now)
				WriteToLog(My.App.AppMode.SkyeShow, "WorkStation Locked", True)
				WorkSpaceSuspendedActions()
			ElseIf e.Reason = Microsoft.Win32.SessionSwitchReason.SessionUnlock Then
				WorkStationLocked = False
				Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> SessionSwitch --> Workstation UNLocked @ " & Now)
				WriteToLog(My.App.AppMode.SkyeShow, "WorkStation UnLocked", True)
			End If
		End Sub

		'Procedures
		Friend Sub Initialize()
			WriteToLog(My.App.AppMode.SkyeShow, My.Application.Info.ProductName + " Started", True)
			Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> OnStartup --> Alternate Start = " + My.Application.AlternateStart.ToString)
			FrmBalloonTimer.Interval = 6000
			ScreenSaverWatcher.Interval = 1000
			GetSettings()
#If DEBUG Then
			GetDebugSettings()
#End If
			LoadImageFileList()
			LoadImageRepeatList()
			LoadVideoFileList()
			ScreenSaverWatcher.Start()
			AddHandler Microsoft.Win32.SystemEvents.SessionSwitch, AddressOf WorkStationLockedHandler
			UpdateLog()
			If hkEnabled Then RegisterHotKeys(True)
		End Sub
		Friend Sub Finalize()
			If hkEnabled Then RegisterHotKeys(False)
			My.App.SaveImageFileList()
			My.App.SaveImageRepeatList()
			My.App.SaveVideoFileList()
			My.App.WriteToLog(My.App.AppMode.SkyeShow, My.Application.Info.ProductName + " Closed", True)
		End Sub
		Friend Sub CloseApp(Optional restart As Boolean = False)
			On Error Resume Next
			If FrmVidsVisible() Then frmVids.Close()
			If FrmPicsVisible() Then frmPics.Close()
			If FrmVidListVisible() Then frmVidList.Close()

			If restart Then
				frmMain.Close()
				System.Windows.Forms.Application.Restart()
			Else : frmMain.Close()
			End If
		End Sub
		Friend Sub GetSettings()
			'Initialize
			SettingsRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegPath)
			'App Settings
			Select Case SettingsRegKey.GetValue("AppSaveFileLists", "False").ToString
				Case "True", "1" : appSaveFileLists = True
				Case Else : appSaveFileLists = False
			End Select
			Select Case SettingsRegKey.GetValue("AppLoadFileListsInBackground", "True").ToString
				Case "False", "0" : appLoadFileListsInBackground = False
				Case Else : appLoadFileListsInBackground = True
			End Select
			Select Case SettingsRegKey.GetValue("AppRefreshFileListsOnStartUp", "True").ToString
				Case "False", "0" : appRefreshFileListsOnStartUp = False
				Case Else : appRefreshFileListsOnStartUp = True
			End Select
			Select Case SettingsRegKey.GetValue("AppHideCursorWhenFullscreen", "True").ToString
				Case "False", "0" : appHideCursorWhenFullscreen = False
				Case Else : appHideCursorWhenFullscreen = True
			End Select
			appActionOnScreenSave = CType(Val(SettingsRegKey.GetValue("AppActionOnScreenSave", "2")), My.App.ScreenSaveActions)
			appInsideLocationOffset = CType(Val(SettingsRegKey.GetValue("AppInsideLocationOffset", "40")), UInt16)
			'HotKeys
			Select Case SettingsRegKey.GetValue("HKEnabled", "True").ToString
				Case "False", "0" : hkEnabled = False
				Case Else : hkEnabled = True
			End Select
			hkPicToggle.Description = "Toggle Pictures"
			hkPicToggle.WinID = 1
			Try
				hkPicToggle.Key = CType(Val(SettingsRegKey.GetValue("HKPicToggleKey", "0")), Keys)
				If hkPicToggle.Key < 0 Or hkPicToggle.Key > Integer.MaxValue Then hkPicToggle.Key = 0
			Catch : hkPicToggle.Key = 0
			End Try
			Try
				hkPicToggle.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKPicToggleKeyCode", "0")))
				If hkPicToggle.KeyCode < Byte.MinValue Or hkPicToggle.KeyCode > Byte.MaxValue Then hkPicToggle.KeyCode = 0
			Catch : hkPicToggle.KeyCode = 0
			End Try
			Try
				hkPicToggle.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKPicToggleKeyMod", "0")))
				If hkPicToggle.KeyMod < Byte.MinValue Or hkPicToggle.KeyMod > Byte.MaxValue Then hkPicToggle.KeyMod = 0
			Catch : hkPicToggle.KeyMod = 0
			End Try
			hkPicToggleFullScreen.Description = "Toggle Pictures FullScreen"
			hkPicToggleFullScreen.WinID = 2
			Try
				hkPicToggleFullScreen.Key = CType(Val(SettingsRegKey.GetValue("HKPicToggleFullScreenKey", "0")), Keys)
				If hkPicToggleFullScreen.Key < 0 Or hkPicToggleFullScreen.Key > Integer.MaxValue Then hkPicToggleFullScreen.Key = 0
			Catch : hkPicToggleFullScreen.Key = 0
			End Try
			Try
				hkPicToggleFullScreen.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKPicToggleFullScreenKeyCode", "0")))
				If hkPicToggleFullScreen.KeyCode < Byte.MinValue Or hkPicToggleFullScreen.KeyCode > Byte.MaxValue Then hkPicToggleFullScreen.KeyCode = 0
			Catch : hkPicToggleFullScreen.KeyCode = 0
			End Try
			Try
				hkPicToggleFullScreen.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKPicToggleFullScreenKeyMod", "0")))
				If hkPicToggleFullScreen.KeyMod < Byte.MinValue Or hkPicToggleFullScreen.KeyMod > Byte.MaxValue Then hkPicToggleFullScreen.KeyMod = 0
			Catch : hkPicToggleFullScreen.KeyMod = 0
			End Try
			hkPicShowFileInfo.Description = "Show Picture Info"
			hkPicShowFileInfo.WinID = 3
			Try
				hkPicShowFileInfo.Key = CType(Val(SettingsRegKey.GetValue("HKPicShowFileInfoKey", "0")), Keys)
				If hkPicShowFileInfo.Key < 0 Or hkPicShowFileInfo.Key > Integer.MaxValue Then hkPicShowFileInfo.Key = 0
			Catch : hkPicShowFileInfo.Key = 0
			End Try
			Try
				hkPicShowFileInfo.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKPicShowFileInfoKeyCode", "0")))
				If hkPicShowFileInfo.KeyCode < Byte.MinValue Or hkPicShowFileInfo.KeyCode > Byte.MaxValue Then hkPicShowFileInfo.KeyCode = 0
			Catch : hkPicShowFileInfo.KeyCode = 0
			End Try
			Try
				hkPicShowFileInfo.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKPicShowFileInfoKeyMod", "0")))
				If hkPicShowFileInfo.KeyMod < Byte.MinValue Or hkPicShowFileInfo.KeyMod > Byte.MaxValue Then hkPicShowFileInfo.KeyMod = 0
			Catch : hkPicShowFileInfo.KeyMod = 0
			End Try
			hkVidToggle.Description = "Toggle Videos"
			hkVidToggle.WinID = 4
			Try
				hkVidToggle.Key = CType(Val(SettingsRegKey.GetValue("HKVidToggleKey", "0")), Keys)
				If hkVidToggle.Key < 0 Or hkVidToggle.Key > Integer.MaxValue Then hkVidToggle.Key = 0
			Catch : hkVidToggle.Key = 0
			End Try
			Try
				hkVidToggle.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKVidToggleKeyCode", "0")))
				If hkVidToggle.KeyCode < Byte.MinValue Or hkVidToggle.KeyCode > Byte.MaxValue Then hkVidToggle.KeyCode = 0
			Catch : hkVidToggle.KeyCode = 0
			End Try
			Try
				hkVidToggle.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKVidToggleKeyMod", "0")))
				If hkVidToggle.KeyMod < Byte.MinValue Or hkVidToggle.KeyMod > Byte.MaxValue Then hkVidToggle.KeyMod = 0
			Catch : hkVidToggle.KeyMod = 0
			End Try
			hkVidToggleFullScreen.Description = "Toggle Videos FullScreen"
			hkVidToggleFullScreen.WinID = 5
			Try
				hkVidToggleFullScreen.Key = CType(Val(SettingsRegKey.GetValue("HKVidToggleFullScreenKey", "0")), Keys)
				If hkVidToggleFullScreen.Key < 0 Or hkVidToggleFullScreen.Key > Integer.MaxValue Then hkVidToggleFullScreen.Key = 0
			Catch : hkVidToggleFullScreen.Key = 0
			End Try
			Try
				hkVidToggleFullScreen.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKVidToggleFullScreenKeyCode", "0")))
				If hkVidToggleFullScreen.KeyCode < Byte.MinValue Or hkVidToggleFullScreen.KeyCode > Byte.MaxValue Then hkVidToggleFullScreen.KeyCode = 0
			Catch : hkVidToggleFullScreen.KeyCode = 0
			End Try
			Try
				hkVidToggleFullScreen.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKVidToggleFullScreenKeyMod", "0")))
				If hkVidToggleFullScreen.KeyMod < Byte.MinValue Or hkVidToggleFullScreen.KeyMod > Byte.MaxValue Then hkVidToggleFullScreen.KeyMod = 0
			Catch : hkVidToggleFullScreen.KeyMod = 0
			End Try
			hkVidShowFileInfo.Description = "Show Video Info"
			hkVidShowFileInfo.WinID = 6
			Try
				hkVidShowFileInfo.Key = CType(Val(SettingsRegKey.GetValue("HKVidShowFileInfoKey", "0")), Keys)
				If hkVidShowFileInfo.Key < 0 Or hkVidShowFileInfo.Key > Integer.MaxValue Then hkVidShowFileInfo.Key = 0
			Catch : hkVidShowFileInfo.Key = 0
			End Try
			Try
				hkVidShowFileInfo.KeyCode = CByte(Val(SettingsRegKey.GetValue("HKVidShowFileInfoKeyCode", "0")))
				If hkVidShowFileInfo.KeyCode < Byte.MinValue Or hkVidShowFileInfo.KeyCode > Byte.MaxValue Then hkVidShowFileInfo.KeyCode = 0
			Catch : hkVidShowFileInfo.KeyCode = 0
			End Try
			Try
				hkVidShowFileInfo.KeyMod = CByte(Val(SettingsRegKey.GetValue("HKVidShowFileInfoKeyMod", "0")))
				If hkVidShowFileInfo.KeyMod < Byte.MinValue Or hkVidShowFileInfo.KeyMod > Byte.MaxValue Then hkVidShowFileInfo.KeyMod = 0
			Catch : hkVidShowFileInfo.KeyMod = 0
			End Try
			GenerateHotKeyList()
			'Image Settings
			picLocation.X = CInt(Val(SettingsRegKey.GetValue("ImageLocationX", "0")))
			picLocation.Y = CInt(Val(SettingsRegKey.GetValue("ImageLocationY", "0")))
			picLocationMode = CType(Val(SettingsRegKey.GetValue("ImageLocationMode", "0")), My.App.LocationMode)
			picJustify = CType(Val(SettingsRegKey.GetValue("ImageJustify", "1")), My.App.LocationJustify)
			picMaxSize = CShort(Val(SettingsRegKey.GetValue("ImageMaxSize", "200")))
			If picMaxSize > My.Computer.Screen.Bounds.Width / 2 Then picMaxSize = CShort(My.Computer.Screen.Bounds.Width / 2)
			If picMaxSize < My.Computer.Screen.Bounds.Width / 50 Then picMaxSize = CShort(My.Computer.Screen.Bounds.Width / 50)
			Select Case SettingsRegKey.GetValue("ImagePlayMode", "Random").ToString
				Case "Linear" : picPlayMode = PlayMode.Linear
				Case "LinearWithRandomStart" : picPlayMode = PlayMode.LinearWithRandomStart
				Case "Random" : picPlayMode = PlayMode.Random
				Case Else : picPlayMode = PlayMode.Random
			End Select
			Select Case SettingsRegKey.GetValue("ImageAutoView", "False").ToString
				Case "True", "1" : picAutoView = True
				Case Else : picAutoView = False
			End Select
			Select Case SettingsRegKey.GetValue("ImageLockFullScreen", "False").ToString
				Case "True", "1" : picLockFullScreen = True
				Case Else : picLockFullScreen = False
			End Select
			Select Case SettingsRegKey.GetValue("ImageTimerCountdown", "False").ToString
				Case "True", "1" : picTimerCountdown = True
				Case Else : picTimerCountdown = False
			End Select
			picTimerCountdownLocationMode = CType(Val(SettingsRegKey.GetValue("ImageTimerCountdownLocationMode", "1")), My.App.LocationMode)
			Select Case SettingsRegKey.GetValue("ImageTimerEnabled", "True").ToString
				Case "False", "0" : picTimerEnabled = False
				Case Else : picTimerEnabled = True
			End Select
			Select Case SettingsRegKey.GetValue("ImageTimerAutoStart", "False").ToString
				Case "True", "1" : picTimerAutoStart = True
				Case Else : picTimerAutoStart = False
			End Select
			If picTimerAutoStart And Not picTimerEnabled Then picTimerEnabled = True
			picTimerInterval = CInt(Val(SettingsRegKey.GetValue("ImageTimerInterval", "30")))
			If picTimerInterval < 1 Or picTimerInterval > 86400 Then picTimerInterval = 30
			picFolders.Clear()
			SettingsRegSubKey = SettingsRegKey.CreateSubKey("ImageFolders")
			For Each s As String In SettingsRegSubKey.GetValueNames : picFolders.Add(SettingsRegSubKey.GetValue(s).ToString) : Next
			SettingsRegSubKey.Close()
			picFolders.Sort()
			ImageExtensions.Clear()
			ImageExtensions.Add(".jpg")
			ImageExtensions.Add(".jpeg")
			ImageExtensions.Add(".bmp")
			ImageExtensions.Add(".gif") 'These are what the .NET Image Class can handle.
			ImageExtensions.Add(".png")
			ImageExtensions.Add(".tif")
			ImageExtensions.Add(".tiff")
			ImageExtensions.Add(".exif")
			'Video Settings
			vidLocation.X = CInt(Val(SettingsRegKey.GetValue("VideoLocationX", "0")))
			vidLocation.Y = CInt(Val(SettingsRegKey.GetValue("VideoLocationY", "0")))
			vidLocationMode = CType(Val(SettingsRegKey.GetValue("VideoLocationMode", "0")), My.App.LocationMode)
			vidMaxSize = CShort(Val(SettingsRegKey.GetValue("VideoMaxSize", "300")))
			If vidMaxSize > My.Computer.Screen.WorkingArea.Width Then vidMaxSize = CShort(My.Computer.Screen.WorkingArea.Width)
			If vidMaxSize < My.Computer.Screen.WorkingArea.Width / 30 Then vidMaxSize = CShort(My.Computer.Screen.WorkingArea.Width / 30)
			Select Case Val(SettingsRegKey.GetValue("VideoScale", ".5"))
				Case 0 : vidScale = 0
				Case 0.1 : vidScale = 0.1
				Case 0.25 : vidScale = 0.25
				Case 0.3333 : vidScale = 0.3333
				Case 0.6666 : vidScale = 0.6666
				Case 0.75 : vidScale = 0.75
				Case 1 : vidScale = 1
				Case Else : vidScale = 0.5
			End Select
			Select Case SettingsRegKey.GetValue("VideoPlayMode", "Random").ToString
				Case "Linear" : vidPlayMode = PlayMode.Linear
				Case "LinearWithRandomStart" : vidPlayMode = PlayMode.LinearWithRandomStart
				Case "Random" : vidPlayMode = PlayMode.Random
				Case Else : vidPlayMode = PlayMode.Random
			End Select
			Select Case SettingsRegKey.GetValue("VideoAutoView", "False").ToString
				Case "True", "1" : vidAutoView = True
				Case Else : vidAutoView = False
			End Select
			Select Case SettingsRegKey.GetValue("VideoLockFullScreen", "False").ToString
				Case "True", "1" : vidLockFullScreen = True
				Case Else : vidLockFullScreen = False
			End Select
			vidVolume = CShort(Val(SettingsRegKey.GetValue("VideoVolume", "-2000")))
			If vidVolume < -7000 Or vidVolume > 0 Then vidVolume = -2000
			Select Case SettingsRegKey.GetValue("VideoVolumeMute", "True").ToString
				Case "False", "0" : vidVolumeMute = False
				Case Else : vidVolumeMute = True
			End Select
			Select Case SettingsRegKey.GetValue("VideoTime", "False").ToString
				Case "True", "1" : vidTime = True
				Case Else : vidTime = False
			End Select
			vidTimeDisplayMode = CType(Val(SettingsRegKey.GetValue("VideoTimeDisplayMode", "0")), My.App.VideoPositionMode)
			vidTimeLocationMode = CType(Val(SettingsRegKey.GetValue("VideoTimeLocationMode", "0")), My.App.LocationMode)
			vidFolders.Clear()
			SettingsRegSubKey = SettingsRegKey.CreateSubKey("VideoFolders")
			For Each name As String In SettingsRegSubKey.GetValueNames
				Dim value As String = SettingsRegSubKey.GetValue(name).ToString
				If value.StartsWith("-"c) Then : vidFolders.Add(New VideoFolderType(value.Remove(0, 1), False))
				Else : vidFolders.Add(New VideoFolderType(value, True))
				End If
				value = Nothing
			Next
			vidFolders.Sort(New My.App.VideoFolderType.Comparer)
			SettingsRegSubKey.Close()
			vidExtensions.Clear()
			SettingsRegSubKey = SettingsRegKey.CreateSubKey("VideoExtensions")
			For Each s As String In SettingsRegSubKey.GetValueNames : vidExtensions.Add(SettingsRegSubKey.GetValue(s).ToString) : Next
			SettingsRegSubKey.Close()
			vidExtensions.Sort()
			'Finalize
			SettingsRegKey.Close()
		End Sub
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetDebugSettings()
			'Initialize
			'App Settings
			appRefreshFileListsOnStartUp = False
			'HotKeys
			hkEnabled = True
			hkPicToggle = New HotKey(1, "DEBUG Toggle Pictures", CType(393296, Keys), 80, 3) 'CtrlAltP
			hkPicToggleFullScreen = New HotKey(2, "DEBUG Toggle Pictures FullScreen", CType(196688, Keys), 80, 6) 'CtrlShiftP
			hkPicShowFileInfo = New HotKey(3, "DEBUG Show Picture Info", CType(327760, Keys), 80, 5) 'AltShiftP
			hkVidToggle = New HotKey(4, "DEBUG Toggle Videos", CType(393302, Keys), 86, 3) 'CtrlAltV
			hkVidToggleFullScreen = New HotKey(5, "DEBUG Toggle Videos FullScreen", CType(196694, Keys), 86, 6) 'CtrlShiftV
			hkVidShowFileInfo = New HotKey(6, "DEBUG Show Video Info", CType(327766, Keys), 86, 5) 'AltShiftV
			'hkPicToggle = New HotKey(1, "DEBUG Toggle Pictures", CType(393281, Keys), 65, 3) 'CtrlAltA
			'hkPicToggleFullScreen = New HotKey(2, "DEBUG Toggle Pictures FullScreen", CType(196673, Keys), 65, 6) 'CtrlShiftA
			'hkPicShowFileInfo = New HotKey(3, "DEBUG Show Picture Info", CType(327745, Keys), 65, 5) 'AltShiftA
			'hkVidToggle = New HotKey(4, "DEBUG Toggle Videos", CType(393299, Keys), 83, 3) 'CtrlAltS
			'hkVidToggleFullScreen = New HotKey(5, "DEBUG Toggle Videos FullScreen", CType(196691, Keys), 83, 6) 'CtrlShiftS
			'hkVidShowFileInfo = New HotKey(6, "DEBUG Show Video Info", CType(327763, Keys), 83, 5) 'AltShiftS
			GenerateHotKeyList()
			'Image Settings
			picAutoView = False
			picTimerInterval = 10
			picTimerEnabled = False
			picTimerAutoStart = False
			picTimerCountdown = True
			picLocation = New Point(800, 200)
			'picLocation = New Point(2800, 2200)
			picLocationMode = LocationMode.Manual
			picTimerCountdown = False
			'ImageTimerCountdownLocationMode = LocationMode.TopRight
			'ImagePlayMode = PlayMode.LinearWithRandomStart
			picFolders.Clear()
			picFolders.Add("C:\Users\YodeS\Dev\TESTDATA")
			'picFolders.Add("C:\Users\CT\Pictures")
			'picFolders.Add("D:\Beauty\Celebrities")
			'picFolders.Add("D:\Beauty\EAC")
			'picFolders.Add("D:\Beauty\Fantasy")
			'picFolders.Add("D:\Erotica")
			picFolders.Sort()
			'Video Settings
			vidAutoView = False
			'VideoPlayMode = PlayMode.LinearWithRandomStart
			vidScale = 0
			vidLocation = New Point(1200, 200)
			'vidLocation = New Point(2200, 2200)
			vidLocationMode = LocationMode.TopCenterRightInside
			vidTime = True
			vidTimeDisplayMode = VideoPositionMode.TimeRemaining
			vidFolders.Clear()
			vidFolders.Add(New VideoFolderType("C:\Users\YodeS\Dev\TESTDATA"))
			'vidFolders.Add(New VideoFolderType("C:\Users\Music\Videos"))
			'vidFolders.Add(New VideoFolderType("D:\Beauty\Videos"))
			'vidFolders.Add(New VideoFolderType("D:\Beauty\Fantasy"))
			'vidFolders.Add(New VideoFolderType("D:\Erotica"))
			vidFolders.Sort(New My.App.VideoFolderType.Comparer)
			vidExtensions.Clear()
			vidExtensions.Add(".avi")
			vidExtensions.Add(".flv")
			vidExtensions.Add(".mpeg")
			vidExtensions.Add(".wmv")
			'vidExtensions.Add(".mp4")
			'vidExtensions.Add(".wmv")
			'Finalize
		End Sub
		Friend Sub SaveSettings()
			'Initialize
			SettingsRegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegPath, True)
			'App Settings
			SettingsRegKey.SetValue("AppSaveFileLists", appSaveFileLists.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("AppLoadFileListsInBackground", appLoadFileListsInBackground.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("AppRefreshFileListsOnStartUp", appRefreshFileListsOnStartUp.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("AppHideCursorWhenFullscreen", appHideCursorWhenFullscreen.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("AppActionOnScreenSave", Str(appActionOnScreenSave).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("AppInsideLocationOffset", appInsideLocationOffset.ToString, Microsoft.Win32.RegistryValueKind.String)
			'HotKeys
			SettingsRegKey.SetValue("HKEnabled", hkEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleKey", Val(hkPicToggle.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleKeyCode", hkPicToggle.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleKeyMod", hkPicToggle.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleFullScreenKey", Val(hkPicToggleFullScreen.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleFullScreenKeyCode", hkPicToggleFullScreen.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicToggleFullScreenKeyMod", hkPicToggleFullScreen.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicShowFileInfoKey", Val(hkPicShowFileInfo.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicShowFileInfoKeyCode", hkPicShowFileInfo.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKPicShowFileInfoKeyMod", hkPicShowFileInfo.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleKey", Val(hkVidToggle.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleKeyCode", hkVidToggle.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleKeyMod", hkVidToggle.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleFullScreenKey", Val(hkVidToggleFullScreen.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleFullScreenKeyCode", hkVidToggleFullScreen.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidToggleFullScreenKeyMod", hkVidToggleFullScreen.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidShowFileInfoKey", Val(hkVidShowFileInfo.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidShowFileInfoKeyCode", hkVidShowFileInfo.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("HKVidShowFileInfoKeyMod", hkVidShowFileInfo.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			'Pic Settings
			SettingsRegKey.SetValue("ImageLocationX", picLocation.X.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageLocationY", picLocation.Y.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageLocationMode", Str(picLocationMode).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageJustify", Str(picJustify).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageMaxSize", picMaxSize.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImagePlayMode", picPlayMode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageAutoView", picAutoView.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageLockFullScreen", picLockFullScreen.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageTimerCountdown", picTimerCountdown.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageTimerCountdownLocationMode", Str(picTimerCountdownLocationMode).Trim, Microsoft.Win32.RegistryValueKind.String)
			If picTimerAutoStart And Not picTimerEnabled Then picTimerEnabled = True
			SettingsRegKey.SetValue("ImageTimerEnabled", picTimerEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageTimerAutoStart", picTimerAutoStart.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("ImageTimerInterval", picTimerInterval.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegSubKey = SettingsRegKey.OpenSubKey("ImageFolders", True)
			For Each s As String In SettingsRegSubKey.GetValueNames : SettingsRegSubKey.DeleteValue(s) : Next
			For Each s As String In picFolders : SettingsRegSubKey.SetValue("Folder" + Str(picFolders.IndexOf(s) + 1).Trim, s, Microsoft.Win32.RegistryValueKind.String) : Next
			SettingsRegSubKey.Close()
			'Vid Settings
			SettingsRegKey.SetValue("VideoLocationX", vidLocation.X.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoLocationY", vidLocation.Y.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoLocationMode", Str(vidLocationMode).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoMaxSize", vidMaxSize.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoPlayMode", vidPlayMode.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoAutoView", vidAutoView.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoLockFullScreen", vidLockFullScreen.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoScale", vidScale.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoVolume", vidVolume.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoVolumeMute", vidVolumeMute.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoTime", vidTime.ToString, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoTimeDisplayMode", Str(vidTimeDisplayMode).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegKey.SetValue("VideoTimeLocationMode", Str(vidTimeLocationMode).Trim, Microsoft.Win32.RegistryValueKind.String)
			SettingsRegSubKey = SettingsRegKey.OpenSubKey("VideoFolders", True)
			For Each s As String In SettingsRegSubKey.GetValueNames : SettingsRegSubKey.DeleteValue(s) : Next
			For index As Integer = 0 To vidFolders.Count - 1 : SettingsRegSubKey.SetValue("Folder" + (index + 1).ToString, IIf(vidFolders(index).Enabled, vidFolders(index).Path, "-" + vidFolders(index).Path), Microsoft.Win32.RegistryValueKind.String) : Next
			SettingsRegSubKey.Close()
			SettingsRegSubKey = SettingsRegKey.OpenSubKey("VideoExtensions", True)
			For Each s As String In SettingsRegSubKey.GetValueNames : SettingsRegSubKey.DeleteValue(s) : Next
			For Each s As String In vidExtensions : SettingsRegSubKey.SetValue("Extension" + Str(vidExtensions.IndexOf(s) + 1).Trim, s, Microsoft.Win32.RegistryValueKind.String) : Next
			SettingsRegSubKey.Close()
			'Finalize
			SettingsRegKey.Flush()
			SettingsRegKey.Close()
		End Sub
		''' <summary>
		''' Register / UNRegister HotKeys with Windows.
		''' </summary>
		''' <param name="mode">True = Register, False = UNRegister, Default = True</param>
		Friend Sub RegisterHotKeys(Optional mode As Boolean = True)
			If hkEnabled Then
				Dim status As Boolean
				Select Case mode
					Case True 'Register All HotKeys Where Key Is Not 'NONE'
						For Each key As HotKey In HotKeys
							If Not key.Key = Keys.None Then
								status = Skye.WinAPI.RegisterHotKey(frmMain.Handle, key.WinID, key.KeyMod, key.KeyCode)
								WriteToLog(AppMode.SkyeShow, "HotKey '" + key.Description + " (" + key.WinID.ToString + ") (" + key.Key.ToString + ") (" + key.KeyCode.ToString + " mod " + key.KeyMod.ToString + ")' " + IIf(status, "Successfully Registered", "Failed To Register").ToString, True)
							End If
						Next
					Case False 'UnRegister HotKeys
						For Each key As HotKey In HotKeys
							If Not key.Key = Keys.None Then
								status = Skye.WinAPI.UnregisterHotKey(frmMain.Handle, key.WinID)
								WriteToLog(AppMode.SkyeShow, "HotKey '" + key.Description + " (" + key.WinID.ToString + ")' " + IIf(status, "Successfully UNRegistered", "Failed To UNRegister").ToString, True)
							End If
						Next
				End Select
			End If
		End Sub
		Friend Sub PerformHotKeyAction(hotkey As Integer)
			If Not IsGeneratingFileList Then
				Select Case hotkey
					Case hkPicToggle.WinID
						If FrmPicsVisible() Then : frmPics.Close()
						Else : ShowImages()
						End If
						frmMain.ToggleContextMenu()
					Case hkPicToggleFullScreen.WinID
						If FrmPicsVisible() Then : frmPics.ToggleFullScreen()
						Else
							ShowImages()
							frmPics.ToggleFullScreen()
							frmMain.ToggleContextMenu()
						End If
					Case hkPicShowFileInfo.WinID
						If FrmPicsVisible() Then
							frmPics.BringToFront()
							frmPics.ShowFileInfo()
						End If
					Case hkVidToggle.WinID
						If FrmVidsVisible() Then : frmVids.Close()
						Else : ShowVideos()
						End If
						frmMain.ToggleContextMenu()
					Case hkVidToggleFullScreen.WinID
						If FrmVidsVisible() Then : frmVids.ToggleFullScreen()
						Else
							ShowVideos()
							frmVids.ToggleFullScreen()
							frmMain.ToggleContextMenu()
						End If
					Case hkVidShowFileInfo.WinID
						If FrmVidsVisible() Then
							frmVids.BringToFront()
							frmVids.ShowFileInfo()
						End If
				End Select
			End If
		End Sub
		Friend Sub GenerateHotKeyList()
			HotKeys.Clear()
			HotKeys.Add(hkPicToggle)
			HotKeys.Add(hkPicToggleFullScreen)
			HotKeys.Add(hkPicShowFileInfo)
			HotKeys.Add(hkVidToggle)
			HotKeys.Add(hkVidToggleFullScreen)
			HotKeys.Add(hkVidShowFileInfo)
		End Sub
		Friend Sub ShowBalloon(ByRef sender As Form, image As Image, title As String, text As String)
			If frmBalloon.Visible And frmBalloonParent = sender.Name Then : HideBalloon() 'This allows for toggle of balloon
			Else
				HideBalloon()
				frmBalloonParent = sender.Name
				If image Is Nothing Then : frmBalloon.picbxIcon.Image = My.Resources.Resources.imageInfo32
				Else : frmBalloon.picbxIcon.Image = image
				End If
				frmBalloon.lblTitle.Text = title
				frmBalloon.lblText.Text = text
				frmBalloon.Location = sender.Location
				If frmBalloon.Right > My.Computer.Screen.WorkingArea.Right Then frmBalloon.Left -= frmBalloon.Right - My.Computer.Screen.WorkingArea.Right
				If frmBalloon.Bottom > My.Computer.Screen.WorkingArea.Bottom Then frmBalloon.Top -= frmBalloon.Bottom - My.Computer.Screen.WorkingArea.Bottom
				BalloonLoading = True
				frmBalloon.Show()
				BalloonLoading = False
				FrmBalloonTimer.Start()
			End If
		End Sub
		Friend Sub HideBalloon()
			If frmBalloon.Visible Then
				FrmBalloonTimer.Stop()

				If frmPics IsNot Nothing AndAlso frmPics.Name = frmBalloonParent Then : frmPics.BringToFront()
				ElseIf frmVids IsNot Nothing AndAlso frmVids.Name = frmBalloonParent Then : frmVids.BringToFront()
				End If
				frmBalloonParent = String.Empty
				frmBalloon.Hide()
			End If
		End Sub
		Friend Sub BalloonPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
			If frmPics IsNot Nothing AndAlso frmPics.Name = frmBalloonParent Then : frmPics.FrmPreviewKeyDown(sender, e)
			ElseIf frmVids IsNot Nothing AndAlso frmVids.Name = frmBalloonParent Then : frmVids.FrmPreviewKeyDown(sender, e)
			End If
			HideBalloon()
		End Sub
		Friend Sub ShowInfo(title As String, message As String, postmessage As String, Optional icon As Icon = Nothing, Optional wordwrap As Boolean = False, Optional scrolltotop As Boolean = True, Optional showmaximized As Boolean = False)
			Try
				If frmInfo IsNot Nothing Then frmInfo.Close()
				frmInfo = New InfoForm
				If icon Is Nothing Then : frmInfo.Icon = My.Resources.Resources.iconApp 'DirectCast(AppResources.GetObject("iconApp"), Icon)
				Else : frmInfo.Icon = icon
				End If
				frmInfo.Text = My.Application.Info.Title + " " + title
				frmInfo.rtbMessage.ResetText()
				frmInfo.rtbMessage.AppendText(message)
				If scrolltotop Then frmInfo.rtbMessage.Select(0, 0)
				If wordwrap Then frmInfo.rtbMessage.WordWrap = True
				frmInfo.tbPostMessage.Text = postmessage
				If title.Contains("Log") Then
					Dim lines As Integer = 0
					If frmInfo.rtbMessage.Lines(0).Length > 0 Then lines = frmInfo.rtbMessage.GetLineFromCharIndex(frmInfo.rtbMessage.Text.Length)
					If lines > 0 Then
						frmInfo.tbPostMessage.Text += "  (" + lines.ToString + IIf(lines > 1, " Lines", " Line").ToString + ")"
						frmInfo.btnClearLog.Visible = True
					End If
					frmInfo.btnRefreshLog.Visible = True
				End If
				frmInfo.btnClose.Select()
				frmInfo.Show()
				If showmaximized Then frmInfo.ChangeWindowState()
				frmInfo.rtbMessage.Focus()
			Catch ex As Exception : WriteToLog(My.App.AppMode.SkyeShow, "ShowInfo Managed Error" + Chr(13) + ex.ToString)
			End Try
		End Sub
		Friend Sub ShowHelp(Optional showmaximized As Boolean = False)
			Dim logtext As String = String.Empty
			'logtext += Chr(13) + Chr(13) + "App -- "
			'logtext += Chr(13) + Chr(13) + "HotKeys -- "
			'logtext += Chr(13) + Chr(13) + "Settings -- "
			'logtext += Chr(13) + Chr(13) + "Pictures -- "
			'logtext += Chr(13) + Chr(13) + "Videos -- "
			'logtext += Chr(13) + Chr(13) + "Pictures & Videos -- "
			'logtext += Chr(13) + Chr(13) + "WallPaper -- "
			logtext += "Pictures -- When using QuickHide, the next picture will be displayed after the interval has expired. If the user intervenes during the interval, the current picture will remain."
			logtext += Chr(13) + Chr(13) + "Pictures -- When using QuickHide, manually starting the Timer will restore the window."
			logtext += Chr(13) + Chr(13) + "Pictures -- The Picture List is a simple list of file names stored in memory. When an error occurs trying to open a picture, that file name is simply removed from the Picture List and another is selected. A picture can only be viewed once until all pictures have been viewed, or the Picture List is manually refreshed."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- Quick Hide will hide the window by sending it to the Desktop. The window will remain hidden for the Picture Interval setting(unless Perma Hide is selected) or until the user LeftClicks either the Tray Icon, the Quick Hide menu item, or the window itself."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- All Settings are restored on Quick Restore"
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- Refresh File List means the file system will be scanned and new files will be added to the list, preserving your view history. Reset File List means all files and their history will be cleared from the list and the file system scanned for files."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- When moving a Picture or Video around the screen, the upper left corner is used as the anchor in Manual Mode, until the anchor moves past " + LocationModeManualAnchorThreshold.ToString + "% of the screen. The anchor will then become the right and/or bottom of the window."
			logtext += Chr(13) + Chr(13) + "Videos -- The Video List is a list of file names and status information stored in memory. When an error occurs trying to play a Video, the Video is marked as Viewed and put into an InValid State, but otherwise kept in the Video List. Videos will be marked as Viewed when they are played, and the Video List will be reset to UnViewed for all Enabled and Valid Videos once all videos have been played. Videos can be Enabled or Disabled by Folder. All Manual Additions will be removed when you Refresh or Reset the Video List."
			logtext += Chr(13) + Chr(13) + "Videos -- Video File Counts -- Viewed/UnViewed count is only from Enabled and Valid Videos, Enabled/Disabled count is only from Valid Videos."
			logtext += Chr(13) + Chr(13) + "Video List -- DoubleLeftClick on any Enabled Video will Play the Video."
			logtext += Chr(13) + Chr(13) + "Video List -- KeyBoard ShortCuts -- Pressing Enter on any Enabled Video will Play the Video. Pressing any Letter Key searches for the next Video starting with that letter, holding Shift reverses the search. PageUp/PageDown scrolls by page, holding Shift scrolls by Folder. F3 searches for the next Video containing the text you specify, holding Shift reverses the search. F5 refreshes the Video List. Escape closes the Video List."
			logtext += Chr(13) + Chr(13) + "App -- If Save File Lists is checked, all lists and view history will be saved on exit and loaded on startup."
			logtext += Chr(13) + Chr(13) + "App -- Action On ScreenSave means that when the screen saver is activated or the workstation is locked, Pictures & Videos will either be suspended or closed. For Pictures, the suspend option will hold the countdown timer. For Videos, the suspend option will pause playback."
			logtext += Chr(13) + Chr(13) + "App -- Holding the ShiftKey down while the app is starting will put the app into 'Alternate Start Mode'. This means that the Picture & Video Lists will not AutoRefresh on StartUp and Pictures & Videos will not AutoView, regardless of Settings."
			logtext += Chr(13) + Chr(13) + "Settings Window -- DoubleLeftClick on Pictures Tab will open and close Pictures. DoubleLeftClick on Videos Tab will open and close Videos."
			logtext += Chr(13) + Chr(13) + "CommandLine -- The CommandLine Structure is '" + My.Application.Info.ProductName + " path', where 'path' is a fully qualified Video File Path. If the Path has any spaces, it MUST be encased in Double Quotation Marks. The CommandLine Structure can be used Manually from the Windows Command Prompt or Automatically through the Windows Explorer Shell. Use OpenWith from the file context menu, or use ContextEdit v1.2 or similar program or hack the Windows Registry manually(Not Recommended) to add context menu items(Shell Commands) to the various Video file types. Using " + My.Application.Info.ProductName + " as an Picture Viewer is NOT supported."
			If showmaximized Then : ShowInfo("Help & About", logtext, "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString, My.Resources.Resources.iconInfo, True, True, True)
			Else : ShowInfo("Help & About", logtext, "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString, My.Resources.Resources.iconInfo, True, True, False)
			End If
		End Sub
		Friend Sub ShowLog(Optional showmaximized As Boolean = False)
			Dim logtext As String = String.Empty
			Try : logtext = IO.File.ReadAllText(LogPath)
			Catch
			Finally
				If String.IsNullOrEmpty(logtext) Then logtext = "Log Empty"
				If showmaximized Then : ShowInfo("Log", logtext, LogPath, My.Resources.Resources.iconLog, False, False, True)
				Else : ShowInfo("Log", logtext, LogPath, My.Resources.Resources.iconLog, False, False, False)
				End If
			End Try
		End Sub
		Friend Sub WriteToLog(tool As AppMode, logentry As String, Optional minimal As Boolean = False)
			Dim logtext As String = My.Computer.Clock.LocalTime.ToString("yyyy/MM/dd") + " @ " + My.Computer.Clock.LocalTime.ToString("HH:mm:ss") + " @ " + tool.ToString
			If minimal Then : logtext += " --> " + logentry + vbCr
			Else
				logtext += vbCr + logentry
				logtext += vbCr + ImageIndexLogText()
				logtext += vbCr + VideoIndexLogText()
				logtext += vbCr
			End If
			Dim fi As New IO.FileInfo(LogPath)
			If fi.Exists Then If fi.Length >= 1000000 Then IO.File.Move(LogPath, LogPath.Insert(LogPath.Length - 4, "Backup@" + My.Computer.Clock.LocalTime.ToString("yyyyMMdd") + "@" + My.Computer.Clock.LocalTime.ToString("HHmmss")))
			IO.File.AppendAllText(LogPath, logtext)
			Debug.Print(AppMode.SkyeShow.ToString + " --> WriteToLog --> " + IIf(String.IsNullOrEmpty(logtext), String.Empty, logtext.TrimEnd).ToString)
			fi = Nothing
		End Sub
		Friend Sub UpdateLog()
			Static logtext As String
			Static fInfo As IO.FileInfo
			Static fList As Collections.Generic.List(Of String)
			If fList Is Nothing Then fList = New Collections.Generic.List(Of String)
			logtext = "--> Status @ " + My.Computer.Clock.LocalTime.ToString("yyyy/MM/dd") + " @ " + My.Computer.Clock.LocalTime.ToString("HH:mm:ss")
			logtext += vbCr + ImageIndexLogText()
			logtext += vbCr + VideoIndexLogText()
			logtext += vbCr + "--"
			fInfo = New IO.FileInfo(LogPath)
			If Not fInfo.Exists Then : IO.File.AppendAllText(LogPath, logtext + vbCr)
			Else
				fList.AddRange(IO.File.ReadAllLines(LogPath))
				If fList(0).StartsWith("--> Status @ ") Then
					Do : fList.RemoveAt(0)
					Loop Until fList(0).StartsWith("--")
					fList.RemoveAt(0)
				End If
				fList.Insert(0, logtext)
				IO.File.WriteAllLines(LogPath, fList.ToArray)
				fList.Clear()
			End If
			Debug.Print("Update Log " & logtext)
			fInfo = Nothing
			logtext = String.Empty
		End Sub
		Friend Sub ClearLog()
			Try : My.Computer.FileSystem.DeleteFile(LogPath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
			Catch
			Finally : frmInfo.Close()
			End Try
		End Sub
		Friend Sub DeleteFile(AppMode As AppMode, file As String)
			Try
				If My.Computer.FileSystem.FileExists(file) Then My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
			Catch ex As Exception : WriteToLog(AppMode, "Error Deleting File '" + file + "'; " + Microsoft.VisualBasic.vbCr + ex.Message, True)
			End Try
		End Sub
		Friend Sub SetErrorAlert()
			ErrorAlert = True
			frmMain.AppNotify()
		End Sub
		Friend Sub ClearErrorAlert()
			ErrorAlert = False
			frmMain.AppNotify()
		End Sub
		Private Sub WorkSpaceSuspendedActions()
			If FrmVidsVisible() Then
				Select Case appActionOnScreenSave
					Case ScreenSaveActions.Suspend
						frmVids.TogglePlayState(True)
						If frmVids.IsFullScreen Then frmVids.ToggleFullScreen()
					Case ScreenSaveActions.Close : frmVids.Close()
				End Select
			End If
			If FrmPicsVisible() Then
				Select Case appActionOnScreenSave
					Case ScreenSaveActions.Suspend
						picTimerEnabled = False
						frmPics.SetTimer()
						If frmPics.IsFullScreen Then frmPics.ToggleFullScreen()
					Case ScreenSaveActions.Close : frmPics.Close()
				End Select
			End If
			If FrmVidListVisible() AndAlso appActionOnScreenSave = ScreenSaveActions.Close Then frmVidList.Close()
			Debug.Print(My.App.AppMode.SkyeShow.ToString + " --> SSActive @ " & Now)
		End Sub
		Friend Sub SwapValues(ByRef x As Integer, ByRef y As Integer)
			x = x Xor y
			y = y Xor x
			x = x Xor y
		End Sub
		Friend Function GenerateUsedKeyList() As Collections.Generic.List(Of Keys)
			GenerateUsedKeyList = New Collections.Generic.List(Of Keys) From {
				CType(131137, Keys), ' A, Control ' Select All
				CType(131139, Keys), ' C, Control ' Copy
				CType(131160, Keys), ' X, Control ' Cut / Clear
				CType(131158, Keys), ' V, Control ' Paste
				CType(131155, Keys)} ' S, Control ' Save As
			For Each hk As HotKey In HotKeys
				GenerateUsedKeyList.Add(hk.Key)
			Next
		End Function
		Friend Function BalloonVisible() As Boolean
			Return frmBalloon.Visible
		End Function
		Friend Function CheckFileType(file As String, type As FileType) As Boolean
			Select Case type
				Case FileType.Pic
					For Each s As String In ImageExtensions : If file.EndsWith(s, StringComparison.CurrentCultureIgnoreCase) Then Return True
					Next
				Case FileType.Vid
					For Each s As String In vidExtensions : If file.EndsWith(s, StringComparison.CurrentCultureIgnoreCase) Then Return True
					Next
				Case Else : Return False
			End Select
			Return False
		End Function
		Friend Function ViewFile(tool As AppMode) As Boolean '
			Dim psi As New Diagnostics.ProcessStartInfo
			Select Case tool
				Case AppMode.Pictures : psi.FileName = ImageFiles(ImageIndex)
				Case AppMode.Videos : psi.FileName = VideoFiles(VideoIndex).Path
				Case Else : Return False
			End Select
			psi.UseShellExecute = True
			psi.WindowStyle = Diagnostics.ProcessWindowStyle.Normal
			Try : Diagnostics.Process.Start(psi)
			Catch ex As Exception
				'MessageBox.Show(ex.Message, "Error Opening File", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
				WriteToLog(tool, "Error Opening File '" + psi.FileName + "'", True)
				SetErrorAlert()
				Return False
			End Try
			Return True
		End Function
		Friend Function OpenFileLocation(tool As AppMode) As Boolean
			Dim filepath As String
			Select Case tool
				Case AppMode.Pictures : filepath = ImageFiles(ImageIndex)
				Case AppMode.Videos : filepath = VideoFiles(VideoIndex).Path
				Case Else : Return False
			End Select

			Dim psi As New Diagnostics.ProcessStartInfo("EXPLORER.EXE") With {
				.Arguments = "/SELECT," + filepath,
				.UseShellExecute = True,
				.WindowStyle = Diagnostics.ProcessWindowStyle.Normal}
			Try : Diagnostics.Process.Start(psi)
			Catch ex As Exception
				WriteToLog(tool, "Error Opening File Location '" + filepath + "'", True)
				SetErrorAlert()
				Return False
			End Try
			Return True
		End Function
		Friend Function FormatAspectRatio(tool As AppMode, size As Size) As String
			Static aspect As Single
			Static aspecttext As String
			aspect = CSng(Math.Round(size.Width / size.Height, 2))
			aspecttext = String.Empty
			Select Case tool
				Case AppMode.Pictures
					If size.Width = size.Height Then Return "1x1 Square"
					Select Case aspect
						Case 1.25 : aspecttext = "8x10"
						Case 1.27 : aspecttext = "11x14"
						Case 1.33 : aspecttext = "4x3 Standard"
						Case 1.4 : aspecttext = "5x7"
						Case 1.5 : aspecttext = "3x2,4x6"
						Case 1.77 To 1.81 : aspecttext = "16x9 WideScreen"
						Case Else : aspecttext = aspect.ToString + "x1"
					End Select
				Case AppMode.Videos
					If size.Width = size.Height Then Return "1:1"
					Select Case aspect
						Case 1.32 To 1.34 : aspecttext = "4:3 Standard"
						Case 1.77 To 1.81 : aspecttext = "16:9 WideScreen"
						Case Else : aspecttext = aspect.ToString + ":1"
					End Select
				Case Else : aspecttext = aspect.ToString + ":1"
			End Select
			Return aspecttext
		End Function
		Friend Function MouseInBounds(ByRef control As Control, ByRef mouseposition As Point) As Boolean
			If mouseposition.X >= 0 AndAlso mouseposition.X <= control.Width AndAlso mouseposition.Y >= 0 AndAlso mouseposition.Y <= control.Height Then Return True
			Return False
		End Function
		''' <summary>
		''' Determines if WorkSpace is in a suspended state.
		''' </summary>
		''' <returns>True if ScreenSaver is running or WorkStation is locked, otherwise false.</returns>
		Friend Function WorkSpaceSuspended() As Boolean
			If ScreenSaverRunning OrElse WorkStationLocked Then : Return True
			Else : Return False
			End If
		End Function

#End Region

		Public Class VLCViewerHook
			Inherits NativeWindow

			Public Event RightClick(clientPoint As Point)

			Protected Overrides Sub WndProc(ByRef m As Message)
				MyBase.WndProc(m)
				Select Case m.Msg
					Case Skye.WinAPI.WM_RBUTTONUP, Skye.WinAPI.WM_CONTEXTMENU
						Dim screenPt As Point = Cursor.Position
						Dim clientPt As Point = Control.FromHandle(m.HWnd).PointToClient(screenPt)
						RaiseEvent RightClick(clientPt)
				End Select
			End Sub
		End Class

	End Module

End Namespace
