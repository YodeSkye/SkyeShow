
Imports System.Reflection
Imports Skye.UI

Namespace My

	Public Module App

#Region "Pics"

		' DECLARATIONS
		Friend Const ImageTimerCountdownBorderPadding As Integer = 5
		Friend ImageFiles As New Collections.Generic.List(Of String)
		Friend ImageExtensions As Collections.Generic.List(Of String)
		Friend ImageIndex As Integer = -1
		Friend ImageIndexPrevious As Integer = -1
		Friend ImageRepeatList As New Collections.Generic.List(Of String)
		Friend ImageIsOnTop As Boolean = True
		Friend frmPics As Pics

		' Saved Settings
		Friend PicFolders As New Collections.Generic.List(Of String)
		Friend PicLocation As System.Drawing.Point
		Friend PicLocationMode As LocationMode
		Friend PicJustify As LocationJustify
		Friend PicMaxSize As Int16
		Friend PicPlayMode As PlayMode
		Friend PicAutoView As Boolean
		Friend PicLockFullScreen As Boolean
		Friend PicTimerEnabled As Boolean
		Friend PicTimerAutoStart As Boolean
		Friend PicTimerCountdown As Boolean
		Friend PicTimerCountdownLocationMode As LocationMode
		Friend PicTimerInterval As Integer

		' METHODS
		Friend Sub ShowImages()
			frmPics = New Pics
			frmPics.Show()
		End Sub
		Friend Sub SaveImageFileList()
			Try
				If My.App.SaveFileLists Then
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
						My.App.WriteToLog("Image List Saved (" + My.App.ImageFiles.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog("Cannot Save Image List: " + ex.Message)
			End Try
		End Sub
		Friend Sub LoadImageFileList()
			Try
				If My.App.SaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.ImageFilesPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
					Dim file As New System.IO.FileStream(My.App.ImageFilesPath, IO.FileMode.Open)
					My.App.ImageFiles = CType(reader.Deserialize(file), Collections.Generic.List(Of String))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog("Image List Loaded (" + My.App.ImageFiles.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
					starttime = TimeSpan.Zero
				End If
			Catch ex As Exception : WriteToLog("Cannot Load Image List: " + ex.Message)
			End Try
		End Sub
		Friend Sub SaveImageRepeatList()
			Try
				If My.App.SaveFileLists Then
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
						My.App.WriteToLog("Viewed Image List Saved (" + My.App.ImageRepeatList.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog("Cannot Save Viewed Image List: " + ex.Message)
			End Try
		End Sub
		Friend Sub LoadImageRepeatList()
			Try
				If My.App.SaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.ImageRepeatListPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of String)))
					Dim file As New System.IO.FileStream(My.App.ImageRepeatListPath, IO.FileMode.Open)
					My.App.ImageRepeatList = CType(reader.Deserialize(file), Collections.Generic.List(Of String))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog("Viewed Image List Loaded (" + My.App.ImageRepeatList.Count.ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
					starttime = TimeSpan.Zero
				End If
			Catch ex As Exception : WriteToLog("Cannot Load Viewed Image List: " + ex.Message)
			End Try
		End Sub
		Friend Function FrmPicsVisible() As Boolean
			If frmPics IsNot Nothing AndAlso frmPics.Visible Then Return True
			Return False
		End Function
		Friend Function ImageIndexLogText() As String
			ImageIndexLogText = "Showing Image Index " + ImageIndex.ToString
			If ImageIndex >= 0 Then ImageIndexLogText += " (" + ImageFiles(ImageIndex) + ")"
		End Function

#End Region

#Region "Vids"

		' DECLARATIONS
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
		Friend VideoExtensionDictionary As New Dictionary(Of String, String) 'VideoExtensionDictionary is a dictionary that maps file extensions to their respective media types.
		Friend VideoIndex As Integer = -1
		Friend VideoIndexPrevious As Integer = -1
		Friend VideoIsOnTop As Boolean = True
		Friend FrmVids As Vids

		' Saved Settings
		Friend VidFolders As New Collections.Generic.List(Of VideoFolderType)
		Friend VidLocation As System.Drawing.Point
		Friend VidLocationMode As LocationMode
		Friend VidScale As Single
		Friend VidMaxSize As Int16
		Friend VidPlayMode As PlayMode
		Friend VidAutoView As Boolean
		Friend VidLockFullScreen As Boolean
		Friend VidVolume As Int16
		Friend VidVolumeMute As Boolean
		Friend VidTime As Boolean
		Friend VidTimeDisplayMode As VideoPositionMode
		Friend VidTimeLocationMode As LocationMode

		' METHODS
		Friend Sub ShowVideos(Optional showBySelection As Boolean = False)
			If FrmVidsVisible() Then FrmVids.Close()
			FrmVids = New Vids(showBySelection)
			Try : FrmVids.Show() : Catch : End Try
		End Sub
		Friend Sub ShowVideoFromCommandLine()
			Debug.Print("ShowVideoFromCommandLine " + CommandLinePath.ToUpper)
			Dim video As New VideoFileType(CommandLinePath)
			CommandLinePath = String.Empty
			VideoFiles.Add(video)
			FrmMain.UpdateSettings()
			VideoIndex = VideoFiles.Count - 1
			ShowVideos(True)
			FrmMain.ToggleContextMenu()
		End Sub
		Friend Sub SaveVideoFileList()
			Try
				If My.App.SaveFileLists Then
					If My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total) = 0 Then : If My.Computer.FileSystem.FileExists(My.App.VideoFilesPath) Then My.Computer.FileSystem.DeleteFile(My.App.VideoFilesPath)
					Else
						Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
						Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of VideoFileType)))
						Dim file As New System.IO.StreamWriter(My.App.VideoFilesPath)
						writer.Serialize(file, My.App.VideoFiles)
						file.Close()
						file.Dispose()
						writer = Nothing
						My.App.WriteToLog("Video List Saved (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
						starttime = TimeSpan.Zero
					End If
				End If
			Catch ex As Exception : WriteToLog("Cannot Save Video List: " + ex.Message)
			End Try
		End Sub
		Friend Sub LoadVideoFileList()
			Try
				If My.App.SaveFileLists AndAlso My.Computer.FileSystem.FileExists(My.App.VideoFilesPath) Then
					Dim starttime As TimeSpan = My.Computer.Clock.LocalTime.TimeOfDay
					Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Collections.Generic.List(Of VideoFileType)))
					Dim file As New System.IO.FileStream(My.App.VideoFilesPath, IO.FileMode.Open)
					My.App.VideoFiles = CType(reader.Deserialize(file), Collections.Generic.List(Of VideoFileType))
					file.Close()
					file.Dispose()
					reader = Nothing
					My.App.WriteToLog("Video List Loaded (" + My.App.VideoFilesCount(My.App.VideoFilesCountMode.Total).ToString + ") (" + Skye.Common.GenerateLogTime(starttime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
					starttime = TimeSpan.Zero
					VideoFilesResetEnabled()
				End If
			Catch ex As Exception : WriteToLog("Cannot Load Video List: " + ex.Message)
			End Try
		End Sub
		Friend Sub VideoFilesSetViewed(index As Integer)
			'My.Debug.ShowMessage(Mode.Videos, "VideoFilesSetViewed", "Index = " + index.ToString)
			Dim file As VideoFileType = VideoFiles(index)
			file.Viewed = True
			VideoFiles.RemoveAt(index)
			VideoFiles.Insert(index, file)
			If VideoFilesCount() = 0 Then VideoFilesResetViewed()
			FrmMain.UpdateSettings()
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
				If VideoFiles(index).Path.StartsWith(VidFolders(folderindex).SearchPath) AndAlso VideoFiles(index).State = VideoFileState.Valid Then
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
				For folderindex As Integer = 0 To VidFolders.Count - 1
					If VideoFiles(fileindex).Path.StartsWith(VidFolders(folderindex).SearchPath) AndAlso VideoFiles(fileindex).State = VideoFileState.Valid Then
						file = VideoFiles(fileindex)
						file.Enabled = VidFolders(folderindex).Enabled
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
					For Each folder As VideoFolderType In VidFolders : If file.Path.StartsWith(folder.SearchPath) AndAlso folder.Enabled Then file.Enabled = True
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
			FrmMain.UpdateSettings()
		End Sub
		Friend Function FrmVidsVisible() As Boolean
			If FrmVids IsNot Nothing AndAlso FrmVids.Visible Then Return True
			Return False
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
			For Each folder As VideoFolderType In VidFolders : If folder.Path.Equals(path, StringComparison.CurrentCultureIgnoreCase) Then Return True
			Next
			Return False
		End Function
		Friend Function VideoIndexLogText() As String
			VideoIndexLogText = "Showing Video Index " + VideoIndex.ToString
			If VideoIndex >= 0 Then VideoIndexLogText += " (" + VideoFiles(VideoIndex).Path + ")"
		End Function

#End Region

#Region "App"

		' DECLARATIONS
		Friend Const LocationModeManualAnchorThreshold As Byte = 50 'Percent of screen width/height that determines when the manual mode anchor should be right/bottom of form.
		Friend Const GeneratingFileListAlertText As String = "Generating File List ... Please Wait"
		Friend ReadOnly UserPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Skye\" 'UserPath is the base path for user-specific files.
		Public ReadOnly Property AppTitle As String
			Get
				Dim asm As Assembly = Assembly.GetExecutingAssembly()
				Dim titleAttr As AssemblyTitleAttribute = asm.GetCustomAttribute(Of AssemblyTitleAttribute)()
				Return titleAttr.Title
			End Get
		End Property
#If DEBUG Then
		Friend ReadOnly ImageFilesPath As String = UserPath + My.Application.Info.ProductName + "ImagesDEV.xml"
		Friend ReadOnly ImageRepeatListPath As String = UserPath + My.Application.Info.ProductName + "ImagesViewedDEV.xml"
		Friend ReadOnly VideoFilesPath As String = UserPath + My.Application.Info.ProductName + "VideosDEV.xml"
#Else
		Friend ReadOnly ImageFilesPath As String = UserPath + My.Application.Info.ProductName + "Images.xml"
		Friend ReadOnly ImageRepeatListPath As String = UserPath + My.Application.Info.ProductName + "ImagesViewed.xml"
		Friend ReadOnly VideoFilesPath As String = UserPath + My.Application.Info.ProductName + "Videos.xml"
#End If
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
		Friend ReadOnly AdjustScreenBoundsNormalWindow As Byte = 8 'AdjustScreenBoundsNormalWindow is the number of pixels to adjust the screen bounds for normal windows.
		Friend ReadOnly AdjustScreenBoundsDialogWindow As Byte = 10 'AdjustScreenBoundsDialogWindow is the number of pixels to adjust the screen bounds for dialog windows.
		Friend ReadOnly MenuFont As New Font("Segoe UI", 12, FontStyle.Regular) ' MenuFont is the font used for context menus.
		Friend NeedsSaved As Boolean = False
		Friend ErrorAlert As Boolean = False
		Friend IsGeneratingFileList As Boolean
		Friend CommandLinePath As String = String.Empty
		Friend BalloonLoading As Boolean = False
		Friend IgnoreFocusChange As Boolean = False
		Friend HotKeys As New Collections.Generic.List(Of HotKey)
		Friend FrmMain As MainForm
		Friend FrmHelp As Help
		Friend FrmLog As Log
		Private ReadOnly FrmBalloon As New Balloon
		Private WithEvents FrmBalloonTimer As New Timer
		Private WithEvents ScreenSaverWatcher As New Timer
		Private ScreenSaverRunning As Boolean = False
		Private WorkStationLocked As Boolean = False
		Private ReadOnly RandomFileIndex As New Random
        Private frmBalloonParent As String = String.Empty

		' Saved Settings
		Friend SaveFileLists As Boolean 'Default = False
		Friend LoadFileListsInBackground As Boolean 'Default = True
		Friend RefreshFileListsOnStartUp As Boolean 'Default = True
		Friend HideCursorWhenFullscreen As Boolean 'Default = True
		Friend ActionOnScreenSave As ScreenSaveActions 'Default = Close
		Friend InsideLocationOffset As UInt16 'Default = 40 'Inside Offset for Pic & Vid Location Mode
		Friend Theme As Skye.UI.SkyeTheme
		Friend ThemeAuto As Boolean
		Friend HKEnabled As Boolean
		Friend HKPicToggle As New HotKey
		Friend HKPicToggleFullScreen As New HotKey
		Friend HKPicShowFileInfo As New HotKey
		Friend HKVidToggle As New HotKey
		Friend HKVidToggleFullScreen As New HotKey
		Friend HKVidShowFileInfo As New HotKey

		' HANDLERS
		Private Sub OnThemeChanged(sender As Object, e As EventArgs)
			For Each f As Form In Application.OpenForms
				ThemeManager.ApplyTheme(f)
			Next
		End Sub
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
						Debug.Print("ScreenSaverWatcherTick --> SS Activated @ " & Now)
						WriteToLog("ScreenSaver Activated")
						WorkSpaceSuspendedActions()
					End If
				Case False
					If ScreenSaverRunning Then
						ScreenSaverRunning = False
						Debug.Print("ScreenSaverWatcherTick --> SS DeActivated @ " & Now)
						WriteToLog("ScreenSaver DeActivated")
					End If
			End Select
		End Sub
		Private Sub WorkStationLockedHandler(sender As Object, e As Microsoft.Win32.SessionSwitchEventArgs)
			If e.Reason = Microsoft.Win32.SessionSwitchReason.SessionLock Then
				WorkStationLocked = True
				Debug.Print("SessionSwitch --> Workstation Locked @ " & Now)
				WriteToLog("WorkStation Locked")
				WorkSpaceSuspendedActions()
			ElseIf e.Reason = Microsoft.Win32.SessionSwitchReason.SessionUnlock Then
				WorkStationLocked = False
				Debug.Print("SessionSwitch --> Workstation UNLocked @ " & Now)
				WriteToLog("WorkStation UnLocked")
			End If
		End Sub

		' METHODS
		Friend Sub Initialize()
#If DEBUG Then
			Skye.Common.Log.Initialize(My.Application.Info.ProductName + "DEV") ' Use separate log file for debug builds to prevent debug logs from being mixed with release logs
			Skye.Common.RegistryHelper.BaseKey = "Software\" + My.Application.Info.ProductName + "DEV" ' Use separate registry key for debug builds
#Else
            Skye.Common.Log.Initialize(My.Application.Info.ProductName) ' Use standard log file for release builds
            Skye.Common.RegistryHelper.BaseKey = "Software\" + My.Application.Info.ProductName ' Use standard registry key for release builds
#End If
			WriteToLog(My.Application.Info.ProductName + " Started")
			FrmBalloonTimer.Interval = 6000
			ScreenSaverWatcher.Interval = 1000
			ImageExtensions = New List(Of String) From {".jpg", ".jpeg", ".bmp", ".gif", ".png", ".tif", ".tiff", ".exif"}
			VideoExtensionDictionary.Add(".mkv", "Matroska")
			VideoExtensionDictionary.Add(".ogv", "OGG Video")
			VideoExtensionDictionary.Add(".avi", "AVI Video")
			VideoExtensionDictionary.Add(".wmv", "Windows Media")
			VideoExtensionDictionary.Add(".asf", "ASF")
			VideoExtensionDictionary.Add(".mp4", "MP4")
			VideoExtensionDictionary.Add(".m4p", "MP4")
			VideoExtensionDictionary.Add(".m4v", "MP4")
			VideoExtensionDictionary.Add(".mpeg", "MPEG")
			VideoExtensionDictionary.Add(".mpg", "MPEG")
			VideoExtensionDictionary.Add(".mpe", "MPEG")
			VideoExtensionDictionary.Add(".mpv", "MPEG")
			VideoExtensionDictionary.Add(".m2v", "MPEG")
			VideoExtensionDictionary.Add(".flv", "Flash Video")
			GetSettings()
#If DEBUG Then
			'GetDebugSettings()
#End If
			If ThemeAuto Then
				Skye.UI.ThemeManager.SetTheme(Skye.UI.ThemeManager.DetectWindowsTheme())
			Else
				Skye.UI.ThemeManager.CurrentTheme = Theme
			End If
			AddHandler Skye.UI.ThemeManager.ThemeChanged, AddressOf OnThemeChanged
			LoadImageFileList()
			LoadImageRepeatList()
			LoadVideoFileList()
			ScreenSaverWatcher.Start()
			AddHandler Microsoft.Win32.SystemEvents.SessionSwitch, AddressOf WorkStationLockedHandler
			If HKEnabled Then RegisterHotKeys(True)
		End Sub
		Friend Sub Finalize()
			If HKEnabled Then RegisterHotKeys(False)
			My.App.SaveImageFileList()
			My.App.SaveImageRepeatList()
			My.App.SaveVideoFileList()
			My.App.WriteToLog(My.Application.Info.ProductName + " Closed")
		End Sub
		Friend Sub CloseApp(Optional restart As Boolean = False)
			If FrmVidsVisible() Then FrmVids.Close()
			If FrmPicsVisible() Then frmPics.Close()
			If FrmHelp?.Visible Then FrmHelp.Close()
			If FrmLog?.Visible Then FrmLog.Close()
			FrmMain.Close()
			If restart Then System.Windows.Forms.Application.Restart()
		End Sub
		Friend Sub WriteToLog(logentry As String)
			If String.IsNullOrWhiteSpace(logentry) Then Exit Sub
			Skye.Common.Log.Write(logentry)
			Debug.Print("WriteToLog --> " + logentry)
		End Sub
		Friend Sub GetSettings()

			' App
			SaveFileLists = Skye.Common.RegistryHelper.GetBool("AppSaveFileLists", False)
			LoadFileListsInBackground = Skye.Common.RegistryHelper.GetBool("AppLoadFileListsInBackground", True)
			RefreshFileListsOnStartUp = Skye.Common.RegistryHelper.GetBool("AppRefreshFileListsOnStartUp", True)
			HideCursorWhenFullscreen = Skye.Common.RegistryHelper.GetBool("AppHideCursorWhenFullscreen", True)
			ActionOnScreenSave = CType(Skye.Common.RegistryHelper.GetInt("AppActionOnScreenSave", CInt(ScreenSaveActions.Close)), ScreenSaveActions)
			InsideLocationOffset = CUShort(Skye.Common.RegistryHelper.GetInt("AppInsideLocationOffset", 40))

			' Theme
			Dim themeName As String = Skye.Common.RegistryHelper.GetString("Theme", "Light")
			Theme = Skye.UI.SkyeThemes.GetTheme(themeName)
			ThemeAuto = Skye.Common.RegistryHelper.GetBool("ThemeAuto", True)

			' HotKeys
			HKEnabled = Skye.Common.RegistryHelper.GetBool("HKEnabled", True)
			HKPicToggle = New HotKey(
				id:=1,
				description:="Toggle Pictures",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKPicToggleKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicToggleKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicToggleKeyMod", 0))
			)
			HKPicToggleFullScreen = New HotKey(
				id:=2,
				description:="Toggle Pictures FullScreen",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKPicToggleFullScreenKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicToggleFullScreenKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicToggleFullScreenKeyMod", 0))
			)
			HKPicShowFileInfo = New HotKey(
				id:=3,
				description:="Show Picture Info",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKPicShowFileInfoKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicShowFileInfoKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKPicShowFileInfoKeyMod", 0))
			)
			HKVidToggle = New HotKey(
				id:=4,
				description:="Toggle Videos",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKVidToggleKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidToggleKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidToggleKeyMod", 0))
			)
			HKVidToggleFullScreen = New HotKey(
				id:=5,
				description:="Toggle Videos FullScreen",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKVidToggleFullScreenKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidToggleFullScreenKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidToggleFullScreenKeyMod", 0))
			)
			HKVidShowFileInfo = New HotKey(
				id:=6,
				description:="Show Video Info",
				key:=CType(Skye.Common.RegistryHelper.GetInt("HKVidShowFileInfoKey", 0), Keys),
				keycode:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidShowFileInfoKeyCode", 0)),
				keymod:=CByte(Skye.Common.RegistryHelper.GetInt("HKVidShowFileInfoKeyMod", 0))
			)
			GenerateHotKeyList()

			' Pics
			PicLocation = New Point(Skye.Common.RegistryHelper.GetInt("ImageLocationX", 0), Skye.Common.RegistryHelper.GetInt("ImageLocationY", 0))
			PicLocationMode = CType(Skye.Common.RegistryHelper.GetInt("ImageLocationMode", CInt(LocationMode.Manual)), LocationMode)
			PicJustify = CType(Skye.Common.RegistryHelper.GetInt("ImageJustify", CInt(LocationJustify.Center)), LocationJustify)
			PicMaxSize = CShort(Skye.Common.RegistryHelper.GetInt("ImageMaxSize", 200))
			If PicMaxSize > My.Computer.Screen.Bounds.Width / 2 Then PicMaxSize = CShort(My.Computer.Screen.Bounds.Width / 2)
			If PicMaxSize < My.Computer.Screen.Bounds.Width / 50 Then PicMaxSize = CShort(My.Computer.Screen.Bounds.Width / 50)
			PicPlayMode = CType(Skye.Common.RegistryHelper.GetInt("ImagePlayMode", CInt(PlayMode.Random)), PlayMode)
			PicAutoView = Skye.Common.RegistryHelper.GetBool("ImageAutoView", False)
			PicLockFullScreen = Skye.Common.RegistryHelper.GetBool("ImageLockFullScreen", False)
			PicTimerCountdown = Skye.Common.RegistryHelper.GetBool("ImageTimerCountdown", False)
			PicTimerCountdownLocationMode = CType(Skye.Common.RegistryHelper.GetInt("ImageTimerCountdownLocationMode", CInt(LocationMode.Manual)), LocationMode)
			PicTimerEnabled = Skye.Common.RegistryHelper.GetBool("ImageTimerEnabled", True)
			PicTimerAutoStart = Skye.Common.RegistryHelper.GetBool("ImageTimerAutoStart", False)
			If PicTimerAutoStart AndAlso Not PicTimerEnabled Then PicTimerEnabled = True
			PicTimerInterval = Skye.Common.RegistryHelper.GetInt("ImageTimerInterval", 30)
			If PicTimerInterval < 1 Or PicTimerInterval > 86400 Then PicTimerInterval = 30
			PicFolders = Skye.Common.RegistryHelper.GetStringArray("ImageFolders", Array.Empty(Of String)).ToList()
			PicFolders.Sort()

			' Vids
			VidLocation = New Point(Skye.Common.RegistryHelper.GetInt("VideoLocationX", 0), Skye.Common.RegistryHelper.GetInt("VideoLocationY", 0))
			VidLocationMode = CType(Skye.Common.RegistryHelper.GetInt("VideoLocationMode", CInt(LocationMode.Manual)), LocationMode)
			VidMaxSize = CShort(Skye.Common.RegistryHelper.GetInt("VideoMaxSize", 300))
			If VidMaxSize > My.Computer.Screen.WorkingArea.Width Then VidMaxSize = CShort(My.Computer.Screen.WorkingArea.Width)
			If VidMaxSize < My.Computer.Screen.WorkingArea.Width / 30 Then VidMaxSize = CShort(My.Computer.Screen.WorkingArea.Width / 30)
			Dim scaleStr As String = Skye.Common.RegistryHelper.GetString("VideoScale", "0.5")
			Dim parsedScale As Single
			If Single.TryParse(scaleStr, parsedScale) Then
				VidScale = parsedScale
			Else
				VidScale = 0.5F
			End If
			VidPlayMode = CType(Skye.Common.RegistryHelper.GetInt("VideoPlayMode", CInt(PlayMode.Random)), PlayMode)
			VidAutoView = Skye.Common.RegistryHelper.GetBool("VideoAutoView", False)
			VidLockFullScreen = Skye.Common.RegistryHelper.GetBool("VideoLockFullScreen", False)
			VidVolume = CShort(Skye.Common.RegistryHelper.GetInt("VideoVolume", -2000))
			If VidVolume < -7000 Or VidVolume > 0 Then VidVolume = -2000
			VidVolumeMute = Skye.Common.RegistryHelper.GetBool("VideoVolumeMute", True)
			VidTime = Skye.Common.RegistryHelper.GetBool("VideoTime", False)
			VidTimeDisplayMode = CType(Skye.Common.RegistryHelper.GetInt("VideoTimeDisplayMode", CInt(VideoPositionMode.CurrentPosition)), VideoPositionMode)
			VidTimeLocationMode = CType(Skye.Common.RegistryHelper.GetInt("VideoTimeLocationMode", CInt(LocationMode.Manual)), LocationMode)
			VidFolders.Clear()
			Dim rawVidFolders As String() = Skye.Common.RegistryHelper.GetStringArray("VideoFolders", Array.Empty(Of String))
			For Each entry As String In rawVidFolders
				If entry.StartsWith("-"c) Then
					VidFolders.Add(New VideoFolderType(entry.Substring(1), False))
				Else
					VidFolders.Add(New VideoFolderType(entry, True))
				End If
			Next
			VidFolders.Sort(New VideoFolderType.Comparer)

		End Sub
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetDebugSettings()
			'Initialize
			'App Settings
			RefreshFileListsOnStartUp = False
			'HotKeys
			HKEnabled = True
			HKPicToggle = New HotKey(1, "DEBUG Toggle Pictures", CType(393296, Keys), 80, 3) 'CtrlAltP
			HKPicToggleFullScreen = New HotKey(2, "DEBUG Toggle Pictures FullScreen", CType(196688, Keys), 80, 6) 'CtrlShiftP
			HKPicShowFileInfo = New HotKey(3, "DEBUG Show Picture Info", CType(327760, Keys), 80, 5) 'AltShiftP
			HKVidToggle = New HotKey(4, "DEBUG Toggle Videos", CType(393302, Keys), 86, 3) 'CtrlAltV
			HKVidToggleFullScreen = New HotKey(5, "DEBUG Toggle Videos FullScreen", CType(196694, Keys), 86, 6) 'CtrlShiftV
			HKVidShowFileInfo = New HotKey(6, "DEBUG Show Video Info", CType(327766, Keys), 86, 5) 'AltShiftV
			GenerateHotKeyList()
			'Image Settings
			PicAutoView = False
			PicTimerInterval = 10
			PicTimerEnabled = False
			PicTimerAutoStart = False
			PicTimerCountdown = True
			PicLocation = New Point(800, 200)
			PicLocationMode = LocationMode.Manual
			PicTimerCountdown = False
			'ImageTimerCountdownLocationMode = LocationMode.TopRight
			'ImagePlayMode = PlayMode.LinearWithRandomStart
			PicFolders.Clear()
			PicFolders.Add("C:\Users\YodeS\Dev\TESTDATA")
			PicFolders.Sort()
			'Video Settings
			VidAutoView = False
			'VideoPlayMode = PlayMode.LinearWithRandomStart
			VidScale = 0
			VidLocation = New Point(1200, 200)
			VidLocationMode = LocationMode.TopCenterRightInside
			VidTime = True
			VidTimeDisplayMode = VideoPositionMode.TimeRemaining
			VidFolders.Clear()
			VidFolders.Add(New VideoFolderType("C:\Users\YodeS\Dev\TESTDATA"))
			VidFolders.Sort(New My.App.VideoFolderType.Comparer)
			'Finalize
		End Sub
		Friend Sub SaveSettings()

			' App
			Skye.Common.RegistryHelper.SetBool("AppSaveFileLists", SaveFileLists)
			Skye.Common.RegistryHelper.SetBool("AppLoadFileListsInBackground", LoadFileListsInBackground)
			Skye.Common.RegistryHelper.SetBool("AppRefreshFileListsOnStartUp", RefreshFileListsOnStartUp)
			Skye.Common.RegistryHelper.SetBool("AppHideCursorWhenFullscreen", HideCursorWhenFullscreen)
			Skye.Common.RegistryHelper.SetInt("AppActionOnScreenSave", CInt(ActionOnScreenSave))
			Skye.Common.RegistryHelper.SetInt("AppInsideLocationOffset", InsideLocationOffset)

			' Theme
			Skye.Common.RegistryHelper.SetString("Theme", Theme.Name)
			Skye.Common.RegistryHelper.SetBool("ThemeAuto", ThemeAuto)

			' HotKeys
			Skye.Common.RegistryHelper.SetBool("HKEnabled", HKEnabled)
			Skye.Common.RegistryHelper.SetInt("HKPicToggleKey", CInt(HKPicToggle.Key))
			Skye.Common.RegistryHelper.SetInt("HKPicToggleKeyCode", HKPicToggle.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKPicToggleKeyMod", HKPicToggle.KeyMod)
			Skye.Common.RegistryHelper.SetInt("HKPicToggleFullScreenKey", CInt(HKPicToggleFullScreen.Key))
			Skye.Common.RegistryHelper.SetInt("HKPicToggleFullScreenKeyCode", HKPicToggleFullScreen.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKPicToggleFullScreenKeyMod", HKPicToggleFullScreen.KeyMod)
			Skye.Common.RegistryHelper.SetInt("HKPicShowFileInfoKey", CInt(HKPicShowFileInfo.Key))
			Skye.Common.RegistryHelper.SetInt("HKPicShowFileInfoKeyCode", HKPicShowFileInfo.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKPicShowFileInfoKeyMod", HKPicShowFileInfo.KeyMod)
			Skye.Common.RegistryHelper.SetInt("HKVidToggleKey", CInt(HKVidToggle.Key))
			Skye.Common.RegistryHelper.SetInt("HKVidToggleKeyCode", HKVidToggle.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKVidToggleKeyMod", HKVidToggle.KeyMod)
			Skye.Common.RegistryHelper.SetInt("HKVidToggleFullScreenKey", CInt(HKVidToggleFullScreen.Key))
			Skye.Common.RegistryHelper.SetInt("HKVidToggleFullScreenKeyCode", HKVidToggleFullScreen.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKVidToggleFullScreenKeyMod", HKVidToggleFullScreen.KeyMod)
			Skye.Common.RegistryHelper.SetInt("HKVidShowFileInfoKey", CInt(HKVidShowFileInfo.Key))
			Skye.Common.RegistryHelper.SetInt("HKVidShowFileInfoKeyCode", HKVidShowFileInfo.KeyCode)
			Skye.Common.RegistryHelper.SetInt("HKVidShowFileInfoKeyMod", HKVidShowFileInfo.KeyMod)

			' Pics
			Skye.Common.RegistryHelper.SetInt("ImageLocationX", PicLocation.X)
			Skye.Common.RegistryHelper.SetInt("ImageLocationY", PicLocation.Y)
			Skye.Common.RegistryHelper.SetInt("ImageLocationMode", CInt(PicLocationMode))
			Skye.Common.RegistryHelper.SetInt("ImageJustify", CInt(PicJustify))
			Skye.Common.RegistryHelper.SetInt("ImageMaxSize", PicMaxSize)
			Skye.Common.RegistryHelper.SetInt("ImagePlayMode", CInt(PicPlayMode))
			Skye.Common.RegistryHelper.SetBool("ImageAutoView", PicAutoView)
			Skye.Common.RegistryHelper.SetBool("ImageLockFullScreen", PicLockFullScreen)
			Skye.Common.RegistryHelper.SetBool("ImageTimerCountdown", PicTimerCountdown)
			Skye.Common.RegistryHelper.SetInt("ImageTimerCountdownLocationMode", CInt(PicTimerCountdownLocationMode))
			If PicTimerAutoStart AndAlso Not PicTimerEnabled Then PicTimerEnabled = True
			Skye.Common.RegistryHelper.SetBool("ImageTimerEnabled", PicTimerEnabled)
			Skye.Common.RegistryHelper.SetBool("ImageTimerAutoStart", PicTimerAutoStart)
			Skye.Common.RegistryHelper.SetInt("ImageTimerInterval", PicTimerInterval)
			Skye.Common.RegistryHelper.SetStringArray("ImageFolders", PicFolders.ToArray())

			' Vids
			Skye.Common.RegistryHelper.SetInt("VideoLocationX", VidLocation.X)
			Skye.Common.RegistryHelper.SetInt("VideoLocationY", VidLocation.Y)
			Skye.Common.RegistryHelper.SetInt("VideoLocationMode", CInt(VidLocationMode))
			Skye.Common.RegistryHelper.SetInt("VideoMaxSize", VidMaxSize)
			Skye.Common.RegistryHelper.SetInt("VideoPlayMode", CInt(VidPlayMode))
			Skye.Common.RegistryHelper.SetBool("VideoAutoView", VidAutoView)
			Skye.Common.RegistryHelper.SetBool("VideoLockFullScreen", VidLockFullScreen)
			Skye.Common.RegistryHelper.SetString("VideoScale", VidScale.ToString())
			Skye.Common.RegistryHelper.SetInt("VideoVolume", VidVolume)
			Skye.Common.RegistryHelper.SetBool("VideoVolumeMute", VidVolumeMute)
			Skye.Common.RegistryHelper.SetBool("VideoTime", VidTime)
			Skye.Common.RegistryHelper.SetInt("VideoTimeDisplayMode", CInt(VidTimeDisplayMode))
			Skye.Common.RegistryHelper.SetInt("VideoTimeLocationMode", CInt(VidTimeLocationMode))
			Dim vidFolderStrings As New List(Of String)
			For Each vf As App.VideoFolderType In VidFolders
				If vf.Enabled Then
					vidFolderStrings.Add(vf.Path)
				Else
					vidFolderStrings.Add("-" & vf.Path)
				End If
			Next
			Skye.Common.RegistryHelper.SetStringArray("VideoFolders", vidFolderStrings.ToArray())

		End Sub
		Friend Sub SetSave()
			NeedsSaved = True
			FrmMain?.ShowSave()
		End Sub
		Friend Sub RegisterHotKeys(Optional mode As Boolean = True)
			If HKEnabled Then
				Dim status As Boolean
				Select Case mode
					Case True 'Register All HotKeys Where Key Is Not 'NONE'
						For Each key As HotKey In HotKeys
							If Not key.Key = Keys.None Then
								status = Skye.WinAPI.RegisterHotKey(FrmMain.Handle, key.WinID, key.KeyMod, key.KeyCode)
								WriteToLog("HotKey '" + key.Description + " (" + key.WinID.ToString + ") (" + key.Key.ToString + ") (" + key.KeyCode.ToString + " mod " + key.KeyMod.ToString + ")' " + IIf(status, "Successfully Registered", "Failed To Register").ToString)
							End If
						Next
					Case False 'UnRegister HotKeys
						For Each key As HotKey In HotKeys
							If Not key.Key = Keys.None Then
								status = Skye.WinAPI.UnregisterHotKey(FrmMain.Handle, key.WinID)
								WriteToLog("HotKey '" + key.Description + " (" + key.WinID.ToString + ")' " + IIf(status, "Successfully UNRegistered", "Failed To UNRegister").ToString)
							End If
						Next
				End Select
			End If
		End Sub
		Friend Sub PerformHotKeyAction(hotkey As Integer)
			If Not IsGeneratingFileList Then
				Select Case hotkey
					Case HKPicToggle.WinID
						If FrmPicsVisible() Then : frmPics.Close()
						Else : ShowImages()
						End If
						FrmMain.ToggleContextMenu()
					Case HKPicToggleFullScreen.WinID
						If FrmPicsVisible() Then : frmPics.ToggleFullScreen()
						Else
							ShowImages()
							frmPics.ToggleFullScreen()
							FrmMain.ToggleContextMenu()
						End If
					Case HKPicShowFileInfo.WinID
						If FrmPicsVisible() Then
							frmPics.BringToFront()
							frmPics.ShowFileInfo()
						End If
					Case HKVidToggle.WinID
						If FrmVidsVisible() Then : FrmVids.Close()
						Else : ShowVideos()
						End If
						FrmMain.ToggleContextMenu()
					Case HKVidToggleFullScreen.WinID
						If FrmVidsVisible() Then : FrmVids.ToggleFullScreen()
						Else
							ShowVideos()
							FrmVids.ToggleFullScreen()
							FrmMain.ToggleContextMenu()
						End If
					Case HKVidShowFileInfo.WinID
						If FrmVidsVisible() Then
							FrmVids.BringToFront()
							FrmVids.ShowFileInfo()
						End If
				End Select
			End If
		End Sub
		Friend Sub GenerateHotKeyList()
			HotKeys.Clear()
			HotKeys.Add(HKPicToggle)
			HotKeys.Add(HKPicToggleFullScreen)
			HotKeys.Add(HKPicShowFileInfo)
			HotKeys.Add(HKVidToggle)
			HotKeys.Add(HKVidToggleFullScreen)
			HotKeys.Add(HKVidShowFileInfo)
		End Sub
		Friend Sub ShowBalloon(ByRef sender As Form, image As Image, title As String, text As String)
			If FrmBalloon.Visible And frmBalloonParent = sender.Name Then : HideBalloon() 'This allows for toggle of balloon
			Else
				HideBalloon()
				frmBalloonParent = sender.Name
				If image Is Nothing Then : FrmBalloon.picbxIcon.Image = My.Resources.Resources.ImageInfo32
				Else : FrmBalloon.picbxIcon.Image = image
				End If
				FrmBalloon.lblTitle.Text = title
				FrmBalloon.lblText.Text = text
				FrmBalloon.Location = sender.Location
				If FrmBalloon.Right > My.Computer.Screen.WorkingArea.Right Then FrmBalloon.Left -= FrmBalloon.Right - My.Computer.Screen.WorkingArea.Right
				If FrmBalloon.Bottom > My.Computer.Screen.WorkingArea.Bottom Then FrmBalloon.Top -= FrmBalloon.Bottom - My.Computer.Screen.WorkingArea.Bottom
				BalloonLoading = True
				FrmBalloon.Show()
				BalloonLoading = False
				FrmBalloonTimer.Start()
			End If
		End Sub
		Friend Sub HideBalloon()
			If FrmBalloon.Visible Then
				FrmBalloonTimer.Stop()
				If frmPics IsNot Nothing AndAlso frmPics.Name = frmBalloonParent Then
					frmPics.BringToFront()
				ElseIf FrmVids IsNot Nothing AndAlso FrmVids.Name = frmBalloonParent Then
					FrmVids.BringToFront()
				End If
				frmBalloonParent = String.Empty
				FrmBalloon.Hide()
			End If
		End Sub
		Friend Sub BalloonPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
			If frmPics IsNot Nothing AndAlso frmPics.Name = frmBalloonParent Then
				frmPics.FrmPreviewKeyDown(sender, e)
			ElseIf FrmVids IsNot Nothing AndAlso FrmVids.Name = frmBalloonParent Then
				FrmVids.FrmPreviewKeyDown(sender, e)
			End If
			HideBalloon()
		End Sub
		Friend Sub ShowHelp(Optional showmaximized As Boolean = False)
			Dim logtext As String = String.Empty
			logtext += "Pictures -- When using QuickHide, the next picture will be displayed after the interval has expired. If the user intervenes during the interval, the current picture will remain."
			logtext += Chr(13) + Chr(13) + "Pictures -- When using QuickHide, manually starting the Timer will restore the window."
			logtext += Chr(13) + Chr(13) + "Pictures -- The Picture List is a simple list of file names stored in memory. When an error occurs trying to open a picture, that file name is simply removed from the Picture List and another is selected. A picture can only be viewed once until all pictures have been viewed, or the Picture List is manually refreshed."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- Quick Hide will hide the window by sending it to the Desktop. The window will remain hidden for the Picture Interval setting(unless Perma Hide is selected) or until the user LeftClicks either the Tray Icon, the Quick Hide menu item, or the window itself."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- Refresh File List means the file system will be scanned and new files will be added to the list, preserving your view history. Reset File List means all files and their history will be cleared from the list and the file system scanned for files."
			logtext += Chr(13) + Chr(13) + "Pictures & Videos -- When moving a Picture or Video around the screen, the upper left corner is used as the anchor in Manual Mode, until the anchor moves past " + LocationModeManualAnchorThreshold.ToString + "% of the screen. The anchor will then become the right and/or bottom of the window."
			logtext += Chr(13) + Chr(13) + "Videos -- Video File Counts -- Viewed/UnViewed count is only from Enabled and Valid Videos, Enabled/Disabled count is only from Valid Videos."
			logtext += Chr(13) + Chr(13) + "App -- If Save File Lists is checked, all lists and view history will be saved on exit and loaded on startup."
			logtext += Chr(13) + Chr(13) + "App -- Action On ScreenSave means that when the screen saver is activated or the workstation is locked, Pictures & Videos will either be suspended or closed. For Pictures, the suspend option will hold the countdown timer. For Videos, the suspend option will pause playback."
			logtext += Chr(13) + Chr(13) + "Settings Window -- DoubleLeftClick on Pictures Tab will open and close Pictures. DoubleLeftClick on Videos Tab will open and close Videos."
			If FrmHelp Is Nothing Then
				FrmHelp = New Help With {
					.Text = My.Application.Info.Title + " Help & About",
					.Icon = My.Resources.Resources.iconInfo
				}
				FrmHelp.RTxtBoxMessage.Clear()
				FrmHelp.RTxtBoxMessage.AppendText(logtext)
				FrmHelp.RTxtBoxMessage.Select(0, 0)
				FrmHelp.TxtBoxPostMessage.Text = "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
				FrmHelp.Show()
			Else
				FrmHelp.BringToFront()
				FrmHelp.Focus()
			End If
			If showmaximized Then FrmHelp.WindowState = FormWindowState.Maximized
			FrmHelp.BtnOK.Select()
		End Sub
		Friend Sub ShowLog(Optional showmaximized As Boolean = False)
			If FrmLog Is Nothing Then
				FrmLog = New Log
				FrmLog.LogViewer.Tip.Font = MenuFont
				FrmLog.Show()
			Else
				FrmLog.BringToFront()
				FrmLog.Focus()
			End If
			If showmaximized Then FrmLog.WindowState = FormWindowState.Maximized
			FrmLog.BTNOK.Select()
		End Sub
		Friend Sub HideLog()
			If FrmLog IsNot Nothing AndAlso Not FrmLog.IsDisposed Then
				FrmLog.Close()
			End If
		End Sub
		Friend Sub DeleteFile(file As String)
			Try
				If My.Computer.FileSystem.FileExists(file) Then My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
			Catch ex As Exception : WriteToLog("Error Deleting File '" + file + "'; " + Microsoft.VisualBasic.vbCr + ex.Message)
			End Try
		End Sub
		Friend Sub SetErrorAlert()
			ErrorAlert = True
			FrmMain.AppNotify()
		End Sub
		Friend Sub ClearErrorAlert()
			ErrorAlert = False
			FrmMain.AppNotify()
		End Sub
		Private Sub WorkSpaceSuspendedActions()
			If FrmVidsVisible() Then
				Select Case ActionOnScreenSave
					Case ScreenSaveActions.Suspend
						FrmVids.TogglePlayState(True)
						If FrmVids.IsFullScreen Then FrmVids.ToggleFullScreen()
					Case ScreenSaveActions.Close : FrmVids.Close()
				End Select
			End If
			If FrmPicsVisible() Then
				Select Case ActionOnScreenSave
					Case ScreenSaveActions.Suspend
						PicTimerEnabled = False
						frmPics.SetTimer()
						If frmPics.IsFullScreen Then frmPics.ToggleFullScreen()
					Case ScreenSaveActions.Close : frmPics.Close()
				End Select
			End If
			Debug.Print("SSActive @ " & Now)
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
			Return FrmBalloon.Visible
		End Function
		Friend Function CheckFileType(file As String, type As FileType) As Boolean
			Select Case type
				Case FileType.Pic
					Return ImageExtensions.Any(Function(ext) file.EndsWith(ext, StringComparison.CurrentCultureIgnoreCase))
				Case FileType.Vid
					Return VideoExtensionDictionary.Keys.Any(Function(ext) file.EndsWith(ext, StringComparison.CurrentCultureIgnoreCase))
				Case Else
					Return False
			End Select
			Return False
		End Function
		Friend Function ViewFile(path As String) As Boolean
			Try
				Dim psi As New Diagnostics.ProcessStartInfo With {
					.FileName = path,
					.UseShellExecute = True,
					.WindowStyle = Diagnostics.ProcessWindowStyle.Normal
				}
				Diagnostics.Process.Start(psi)
				Return True
			Catch ex As Exception
				WriteToLog("Error Opening File '" & path & "'")
				SetErrorAlert()
				Return False
			End Try
		End Function
		Friend Function OpenFileLocation(path As String) As Boolean
			Dim psi As New Diagnostics.ProcessStartInfo("EXPLORER.EXE") With {
				.Arguments = "/SELECT," & path,
				.UseShellExecute = True,
				.WindowStyle = Diagnostics.ProcessWindowStyle.Normal
			}
			Try
				Diagnostics.Process.Start(psi)
				Return True
			Catch ex As Exception
				WriteToLog("Error Opening File Location '" & path & "'")
				SetErrorAlert()
				Return False
			End Try
		End Function
		Friend Function FormatImageAspectRatio(size As Size) As String
			Dim aspect As Single = CSng(Math.Round(size.Width / size.Height, 2))
			If size.Width = size.Height Then Return "1x1 Square"
			Select Case aspect
				Case 1.25 : Return "8x10"
				Case 1.27 : Return "11x14"
				Case 1.33 : Return "4x3 Standard"
				Case 1.4 : Return "5x7"
				Case 1.5 : Return "3x2,4x6"
				Case 1.77 To 1.81 : Return "16x9 WideScreen"
				Case Else : Return aspect.ToString & "x1"
			End Select
		End Function
		Friend Function FormatVideoAspectRatio(size As Size) As String
			Dim aspect As Single = CSng(Math.Round(size.Width / size.Height, 2))
			If size.Width = size.Height Then Return "1:1"
			Select Case aspect
				Case 1.32 To 1.34 : Return "4:3 Standard"
				Case 1.77 To 1.81 : Return "16:9 WideScreen"
				Case Else : Return aspect.ToString & ":1"
			End Select
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
