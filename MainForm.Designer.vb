Friend Partial Class MainForm
Inherits System.Windows.Forms.Form
	Private components As System.ComponentModel.IContainer
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
                components.Dispose()
            End If
		End If
		MyBase.Dispose(disposing)
	End Sub
    Private Sub InitializeComponent
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        btnClose = New Button()
        notifyiconSkyeShow = New NotifyIcon(components)
        cmSkyeShow = New ContextMenuStrip(components)
        cmiViewPics = New ToolStripMenuItem()
        cmiPlayVids = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        cmiHelp = New ToolStripMenuItem()
        cmiLog = New ToolStripMenuItem()
        cmiSettings = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        cmiExit = New ToolStripMenuItem()
        lvVidFolders = New ListView()
        cmList = New ContextMenuStrip(components)
        cmiSettingListEnableItem = New ToolStripMenuItem()
        tsSeparatorEnabled = New ToolStripSeparator()
        cmiSettingListAddItem = New ToolStripMenuItem()
        toolStripSeparator4 = New ToolStripSeparator()
        cmiSettingListRemoveItem = New ToolStripMenuItem()
        cmiSettingListRemoveAll = New ToolStripMenuItem()
        chbxHotKeys = New CheckBox()
        txbxInsideLocationOffset = New TextBox()
        lblInsideLocationOffset = New Label()
        grbxActionOnScreenSave = New GroupBox()
        radbtnActionOnScreenSaveClose = New RadioButton()
        radbtnActionOnScreenSaveSuspend = New RadioButton()
        radbtnActionOnScreenSaveNoAction = New RadioButton()
        chbxHideCursorWhenFullscreen = New CheckBox()
        chbxRefreshFileListsOnStartUp = New CheckBox()
        chbxLoadFileListsInBackground = New CheckBox()
        chbxSaveFileLists = New CheckBox()
        chbkVidMute = New CheckBox()
        grbxHotKeysVids = New GroupBox()
        txbxHotKeyVidToggle = New TextBox()
        btnHotKeyVidToggleDisable = New Button()
        txbxHotKeyVidToggleFullScreen = New TextBox()
        btnHotKeyVidToggleFullScreenDisable = New Button()
        btnHotKeysVidsUndo = New Button()
        btnHotKeysVidsSet = New Button()
        txbxHotKeyVidShowFileInfo = New TextBox()
        btnHotKeyVidShowFileInfoDisable = New Button()
        lblHotKeyVidToggle = New Label()
        lblHotKeyVidToggleFullScreen = New Label()
        lblHotKeyVidShowFileInfo = New Label()
        cobxVidTimeDisplayMode = New ComboBox()
        chbxVidLockFullScreen = New CheckBox()
        chbxVidAutoView = New CheckBox()
        gpbxVidScale = New GroupBox()
        radbtnVideoScale100 = New RadioButton()
        radbtnVideoScaleFit = New RadioButton()
        radbtnVideoScale10 = New RadioButton()
        radbtnVideoScale25 = New RadioButton()
        radbtnVideoScale33 = New RadioButton()
        radbtnVideoScale50 = New RadioButton()
        radbtnVideoScale66 = New RadioButton()
        radbtnVideoScale75 = New RadioButton()
        gpbxVidLocationMode = New GroupBox()
        radbtnVidLocationModeTopLeftInside = New RadioButton()
        radbtnVidLocationModeBottomLeftInside = New RadioButton()
        radbtnVidLocationModeBottomRightInside = New RadioButton()
        radbtnVidLocationModeTopRightInside = New RadioButton()
        radbtnVidLocationModeLeftCenterBottomInside = New RadioButton()
        radbtnVidLocationModeLeftCenterInside = New RadioButton()
        radbtnVidLocationModeLeftCenterTopInside = New RadioButton()
        radbtnVidLocationModeBottomCenterInside = New RadioButton()
        radbtnVidLocationModeRightCenterInside = New RadioButton()
        radbtnVidLocationModeBottomCenterLeftInside = New RadioButton()
        radbtnVidLocationModeBottomCenterRightInside = New RadioButton()
        radbtnVidLocationModeRightCenterBottomInside = New RadioButton()
        radbtnVidLocationModeTopCenterRightInside = New RadioButton()
        radbtnVidLocationModeRightCenterTopInside = New RadioButton()
        radbtnVidLocationModeTopCenterInside = New RadioButton()
        radbtnVidLocationModeTopCenterLeftInside = New RadioButton()
        radbtnVidLocationModeLeftCenterTop = New RadioButton()
        radbtnVidLocationModeBottomLeft = New RadioButton()
        radbtnVidLocationModeRightCenterTop = New RadioButton()
        radbtnVidLocationModeRightCenterBottom = New RadioButton()
        radbtnVidLocationModeBottomCenterRight = New RadioButton()
        radbtnVidLocationModeBottomCenterLeft = New RadioButton()
        radbtnVidLocationModeBottomRight = New RadioButton()
        radbtnVidLocationModeLeftCenterBottom = New RadioButton()
        radbtnVidLocationModeBottomCenter = New RadioButton()
        radbtnVidLocationModeLeftCenter = New RadioButton()
        radbtnVidLocationModeTopCenterLeft = New RadioButton()
        radbtnVidLocationModeTopCenter = New RadioButton()
        radbtnVidLocationModeTopRight = New RadioButton()
        radbtnVidLocationModeTopCenterRight = New RadioButton()
        radbtnVidLocationModeRightCenter = New RadioButton()
        radbtnVidLocationModeTopLeft = New RadioButton()
        radbtnVidLocationModeManual = New RadioButton()
        gpbxVidPlayMode = New GroupBox()
        radbtnVidPlayModeLinearWithRandomStart = New RadioButton()
        radbtnVidPlayModeRandom = New RadioButton()
        radbtnVidPlayModeLinear = New RadioButton()
        chbxVidTime = New CheckBox()
        lblVidFileCount = New Label()
        btnlvVidFolders = New Button()
        btnRefreshVidList = New Button()
        grbxVidTimeLocationMode = New GroupBox()
        radbtnVidTimeLocationModeLeftCenterTop = New RadioButton()
        radbtnVidTimeLocationModeBottomLeft = New RadioButton()
        radbtnVidTimeLocationModeRightCenterTop = New RadioButton()
        radbtnVidTimeLocationModeRightCenterBottom = New RadioButton()
        radbtnVidTimeLocationModeBottomCenterRight = New RadioButton()
        radbtnVidTimeLocationModeBottomCenterLeft = New RadioButton()
        radbtnVidTimeLocationModeBottomRight = New RadioButton()
        radbtnVidTimeLocationModeLeftCenterBottom = New RadioButton()
        radbtnVidTimeLocationModeBottomCenter = New RadioButton()
        radbtnVidTimeLocationModeLeftCenter = New RadioButton()
        radbtnVidTimeLocationModeTopCenterLeft = New RadioButton()
        radbtnVidTimeLocationModeTopCenter = New RadioButton()
        radbtnVidTimeLocationModeTopRight = New RadioButton()
        radbtnVidTimeLocationModeTopCenterRight = New RadioButton()
        radbtnVidTimeLocationModeRightCenter = New RadioButton()
        radbtnVidTimeLocationModeTopLeft = New RadioButton()
        btnSaveSettings = New Button()
        btnRestoreSettings = New Button()
        radioButton16 = New RadioButton()
        radioButton17 = New RadioButton()
        radioButton18 = New RadioButton()
        radioButton19 = New RadioButton()
        radioButton20 = New RadioButton()
        radioButton21 = New RadioButton()
        radioButton22 = New RadioButton()
        radioButton23 = New RadioButton()
        radioButton24 = New RadioButton()
        radioButton25 = New RadioButton()
        radioButton26 = New RadioButton()
        radioButton27 = New RadioButton()
        radioButton28 = New RadioButton()
        radioButton29 = New RadioButton()
        radioButton30 = New RadioButton()
        radioButton31 = New RadioButton()
        radioButton32 = New RadioButton()
        btnErrorTest = New Button()
        tipInfo = New ToolTip(components)
        btnInfo = New Button()
        btnlvPicFolders = New Button()
        btnRefreshPicList = New Button()
        radbtnPicPlayModeLinearWithRandomStart = New RadioButton()
        btnLog = New Button()
        PanelApp = New Panel()
        PanelPics = New Panel()
        grbxHotKeysPics = New GroupBox()
        txbxHotKeyPicToggle = New TextBox()
        btnHotKeyPicToggleDisable = New Button()
        txbxHotKeyPicToggleFullScreen = New TextBox()
        btnHotKeyPicToggleFullScreenDisable = New Button()
        btnHotKeysPicsUndo = New Button()
        btnHotKeysPicsSet = New Button()
        txbxHotKeyPicShowFileInfo = New TextBox()
        btnHotKeyPicShowFileInfoDisable = New Button()
        lblHotKeyPicToggle = New Label()
        lblHotKeyPicToggleFullScreen = New Label()
        lblHotKeyPicShowFileInfo = New Label()
        lvPicFolders = New ListView()
        gpbxPicTimerCountdownLocationMode = New GroupBox()
        radbtnPicTimerCountdownLocationModeLeftCenterTop = New RadioButton()
        radbtnPicTimerCountdownLocationModeBottomLeft = New RadioButton()
        radbtnPicTimerCountdownLocationModeRightCenterTop = New RadioButton()
        radbtnPicTimerCountdownLocationModeRightCenterBottom = New RadioButton()
        radbtnPicTimerCountdownLocationModeBottomCenterRight = New RadioButton()
        radbtnPicTimerCountdownLocationModeBottomCenterLeft = New RadioButton()
        radbtnPicTimerCountdownLocationModeBottomRight = New RadioButton()
        radbtnPicTimerCountdownLocationModeLeftCenterBottom = New RadioButton()
        radbtnPicTimerCountdownLocationModeBottomCenter = New RadioButton()
        radbtnPicTimerCountdownLocationModeLeftCenter = New RadioButton()
        radbtnPicTimerCountdownLocationModeTopCenterLeft = New RadioButton()
        radbtnPicTimerCountdownLocationModeTopCenter = New RadioButton()
        radbtnPicTimerCountdownLocationModeTopRight = New RadioButton()
        radbtnPicTimerCountdownLocationModeTopCenterRight = New RadioButton()
        radbtnPicTimerCountdownLocationModeRightCenter = New RadioButton()
        radbtnPicTimerCountdownLocationModeTopLeft = New RadioButton()
        chbxPicTimerCountdown = New CheckBox()
        txbxPicTimerInterval = New TextBox()
        chbxPicAutoView = New CheckBox()
        gpbxPicJustify = New GroupBox()
        radbtnPicJustifyCenter = New RadioButton()
        radbtnPicJustifyLeft = New RadioButton()
        radbtnPicJustifyRight = New RadioButton()
        chbxPicLockFullScreen = New CheckBox()
        gpbxPicLocationMode = New GroupBox()
        radbtnPicLocationModeTopLeftInside = New RadioButton()
        radbtnPicLocationModeBottomLeftInside = New RadioButton()
        radbtnPicLocationModeBottomRightInside = New RadioButton()
        radbtnPicLocationModeTopRightInside = New RadioButton()
        radbtnPicLocationModeLeftCenterTop = New RadioButton()
        radbtnPicLocationModeBottomLeft = New RadioButton()
        radbtnPicLocationModeLeftCenterBottomInside = New RadioButton()
        radbtnPicLocationModeLeftCenterInside = New RadioButton()
        radbtnPicLocationModeLeftCenterTopInside = New RadioButton()
        radbtnPicLocationModeBottomCenterInside = New RadioButton()
        radbtnPicLocationModeRightCenterInside = New RadioButton()
        radbtnPicLocationModeBottomCenterLeftInside = New RadioButton()
        radbtnPicLocationModeRightCenterTop = New RadioButton()
        radbtnPicLocationModeRightCenterBottom = New RadioButton()
        radbtnPicLocationModeBottomCenterRight = New RadioButton()
        radbtnPicLocationModeManual = New RadioButton()
        radbtnPicLocationModeBottomCenterLeft = New RadioButton()
        radbtnPicLocationModeBottomRight = New RadioButton()
        radbtnPicLocationModeLeftCenterBottom = New RadioButton()
        radbtnPicLocationModeBottomCenterRightInside = New RadioButton()
        radbtnPicLocationModeBottomCenter = New RadioButton()
        radbtnPicLocationModeRightCenterBottomInside = New RadioButton()
        radbtnPicLocationModeLeftCenter = New RadioButton()
        radbtnPicLocationModeTopCenterRightInside = New RadioButton()
        radbtnPicLocationModeRightCenterTopInside = New RadioButton()
        radbtnPicLocationModeTopCenterInside = New RadioButton()
        radbtnPicLocationModeTopCenterLeft = New RadioButton()
        radbtnPicLocationModeTopCenter = New RadioButton()
        radbtnPicLocationModeTopRight = New RadioButton()
        radbtnPicLocationModeTopCenterRight = New RadioButton()
        radbtnPicLocationModeRightCenter = New RadioButton()
        radbtnPicLocationModeTopCenterLeftInside = New RadioButton()
        radbtnPicLocationModeTopLeft = New RadioButton()
        lblPicFileCount = New Label()
        btnPicTimerEnabled = New Button()
        gpbxPicPlayMode = New GroupBox()
        radbtnPicPlayModeRandom = New RadioButton()
        radbtnPicPlayModeLinear = New RadioButton()
        label4 = New Label()
        chbxPicTimerAutoStart = New CheckBox()
        PanelVids = New Panel()
        PanelActions = New Panel()
        PanelPageSelector = New Panel()
        LVPageSelector = New Skye.UI.ListViewEX()
        ILPageSelector = New ImageList(components)
        cmSkyeShow.SuspendLayout()
        cmList.SuspendLayout()
        grbxActionOnScreenSave.SuspendLayout()
        grbxHotKeysVids.SuspendLayout()
        gpbxVidScale.SuspendLayout()
        gpbxVidLocationMode.SuspendLayout()
        gpbxVidPlayMode.SuspendLayout()
        grbxVidTimeLocationMode.SuspendLayout()
        PanelApp.SuspendLayout()
        PanelPics.SuspendLayout()
        grbxHotKeysPics.SuspendLayout()
        gpbxPicTimerCountdownLocationMode.SuspendLayout()
        gpbxPicJustify.SuspendLayout()
        gpbxPicLocationMode.SuspendLayout()
        gpbxPicPlayMode.SuspendLayout()
        PanelVids.SuspendLayout()
        PanelActions.SuspendLayout()
        PanelPageSelector.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Image = My.Resources.Resources.imageClose
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(577, 28)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(198, 46)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnClose, "Close Window")
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' notifyiconSkyeShow
        ' 
        notifyiconSkyeShow.ContextMenuStrip = cmSkyeShow
        notifyiconSkyeShow.Visible = True
        ' 
        ' cmSkyeShow
        ' 
        cmSkyeShow.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmSkyeShow.Items.AddRange(New ToolStripItem() {cmiViewPics, cmiPlayVids, toolStripSeparator1, cmiHelp, cmiLog, cmiSettings, toolStripSeparator2, cmiExit})
        cmSkyeShow.Name = "cmenuYMShow"
        cmSkyeShow.RenderMode = ToolStripRenderMode.Professional
        cmSkyeShow.Size = New Size(162, 148)
        ' 
        ' cmiViewPics
        ' 
        cmiViewPics.Enabled = False
        cmiViewPics.Image = My.Resources.Resources.ImageImage
        cmiViewPics.Name = "cmiViewPics"
        cmiViewPics.Size = New Size(161, 22)
        cmiViewPics.Text = "Pictures"
        ' 
        ' cmiPlayVids
        ' 
        cmiPlayVids.Enabled = False
        cmiPlayVids.Image = My.Resources.Resources.ImageVideo
        cmiPlayVids.Name = "cmiPlayVids"
        cmiPlayVids.Size = New Size(161, 22)
        cmiPlayVids.Text = "Videos"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(158, 6)
        ' 
        ' cmiHelp
        ' 
        cmiHelp.Image = My.Resources.Resources.ImageInfo
        cmiHelp.Name = "cmiHelp"
        cmiHelp.Size = New Size(161, 22)
        cmiHelp.Text = "Help"
        cmiHelp.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiLog
        ' 
        cmiLog.Image = My.Resources.Resources.imageLog
        cmiLog.Name = "cmiLog"
        cmiLog.Size = New Size(161, 22)
        cmiLog.Text = "Log"
        cmiLog.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiSettings
        ' 
        cmiSettings.Image = CType(resources.GetObject("cmiSettings.Image"), Image)
        cmiSettings.Name = "cmiSettings"
        cmiSettings.Size = New Size(161, 22)
        cmiSettings.Text = "Settings"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(158, 6)
        ' 
        ' cmiExit
        ' 
        cmiExit.Image = My.Resources.Resources.imageClose
        cmiExit.Name = "cmiExit"
        cmiExit.Size = New Size(161, 22)
        cmiExit.Text = "Exit Skye Show"
        cmiExit.ToolTipText = "RightClick = ReStart YMShow"
        ' 
        ' lvVidFolders
        ' 
        lvVidFolders.BorderStyle = BorderStyle.FixedSingle
        lvVidFolders.ContextMenuStrip = cmList
        lvVidFolders.FullRowSelect = True
        lvVidFolders.HeaderStyle = ColumnHeaderStyle.None
        lvVidFolders.Location = New Point(7, 11)
        lvVidFolders.MultiSelect = False
        lvVidFolders.Name = "lvVidFolders"
        lvVidFolders.Size = New Size(742, 86)
        lvVidFolders.TabIndex = 10
        lvVidFolders.TabStop = False
        lvVidFolders.UseCompatibleStateImageBehavior = False
        lvVidFolders.View = View.Details
        ' 
        ' cmList
        ' 
        cmList.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmList.Items.AddRange(New ToolStripItem() {cmiSettingListEnableItem, tsSeparatorEnabled, cmiSettingListAddItem, toolStripSeparator4, cmiSettingListRemoveItem, cmiSettingListRemoveAll})
        cmList.Name = "contextmenuSettingList"
        cmList.RenderMode = ToolStripRenderMode.Professional
        cmList.Size = New Size(153, 104)
        ' 
        ' cmiSettingListEnableItem
        ' 
        cmiSettingListEnableItem.Name = "cmiSettingListEnableItem"
        cmiSettingListEnableItem.Size = New Size(152, 22)
        ' 
        ' tsSeparatorEnabled
        ' 
        tsSeparatorEnabled.Name = "tsSeparatorEnabled"
        tsSeparatorEnabled.Size = New Size(149, 6)
        ' 
        ' cmiSettingListAddItem
        ' 
        cmiSettingListAddItem.Image = My.Resources.Resources.imageAdd
        cmiSettingListAddItem.Name = "cmiSettingListAddItem"
        cmiSettingListAddItem.Size = New Size(152, 22)
        cmiSettingListAddItem.Text = "Add Item"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(149, 6)
        ' 
        ' cmiSettingListRemoveItem
        ' 
        cmiSettingListRemoveItem.Name = "cmiSettingListRemoveItem"
        cmiSettingListRemoveItem.Size = New Size(152, 22)
        cmiSettingListRemoveItem.Text = "Remove Item"
        ' 
        ' cmiSettingListRemoveAll
        ' 
        cmiSettingListRemoveAll.Name = "cmiSettingListRemoveAll"
        cmiSettingListRemoveAll.Size = New Size(152, 22)
        cmiSettingListRemoveAll.Text = "Remove All"
        ' 
        ' chbxHotKeys
        ' 
        chbxHotKeys.Location = New Point(112, 205)
        chbxHotKeys.Name = "chbxHotKeys"
        chbxHotKeys.Size = New Size(140, 26)
        chbxHotKeys.TabIndex = 60
        chbxHotKeys.Text = "HotKeys"
        chbxHotKeys.UseVisualStyleBackColor = True
        ' 
        ' txbxInsideLocationOffset
        ' 
        txbxInsideLocationOffset.Location = New Point(112, 308)
        txbxInsideLocationOffset.MaxLength = 4
        txbxInsideLocationOffset.Name = "txbxInsideLocationOffset"
        txbxInsideLocationOffset.Size = New Size(80, 29)
        txbxInsideLocationOffset.TabIndex = 70
        txbxInsideLocationOffset.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblInsideLocationOffset
        ' 
        lblInsideLocationOffset.Location = New Point(110, 288)
        lblInsideLocationOffset.Name = "lblInsideLocationOffset"
        lblInsideLocationOffset.Size = New Size(179, 22)
        lblInsideLocationOffset.TabIndex = 71
        lblInsideLocationOffset.Text = "Inside Location Offset"
        lblInsideLocationOffset.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' grbxActionOnScreenSave
        ' 
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveClose)
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveSuspend)
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveNoAction)
        grbxActionOnScreenSave.Location = New Point(486, 25)
        grbxActionOnScreenSave.Name = "grbxActionOnScreenSave"
        grbxActionOnScreenSave.Size = New Size(318, 89)
        grbxActionOnScreenSave.TabIndex = 100
        grbxActionOnScreenSave.TabStop = False
        grbxActionOnScreenSave.Text = "Action On ScreenSave"
        ' 
        ' radbtnActionOnScreenSaveClose
        ' 
        radbtnActionOnScreenSaveClose.CheckAlign = ContentAlignment.BottomCenter
        radbtnActionOnScreenSaveClose.Location = New Point(214, 26)
        radbtnActionOnScreenSaveClose.Name = "radbtnActionOnScreenSaveClose"
        radbtnActionOnScreenSaveClose.Size = New Size(98, 43)
        radbtnActionOnScreenSaveClose.TabIndex = 2
        radbtnActionOnScreenSaveClose.TabStop = True
        radbtnActionOnScreenSaveClose.Text = "Close"
        radbtnActionOnScreenSaveClose.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveClose.UseVisualStyleBackColor = True
        ' 
        ' radbtnActionOnScreenSaveSuspend
        ' 
        radbtnActionOnScreenSaveSuspend.CheckAlign = ContentAlignment.BottomCenter
        radbtnActionOnScreenSaveSuspend.Location = New Point(110, 26)
        radbtnActionOnScreenSaveSuspend.Name = "radbtnActionOnScreenSaveSuspend"
        radbtnActionOnScreenSaveSuspend.Size = New Size(98, 43)
        radbtnActionOnScreenSaveSuspend.TabIndex = 1
        radbtnActionOnScreenSaveSuspend.TabStop = True
        radbtnActionOnScreenSaveSuspend.Text = "Suspend"
        radbtnActionOnScreenSaveSuspend.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveSuspend.UseVisualStyleBackColor = True
        ' 
        ' radbtnActionOnScreenSaveNoAction
        ' 
        radbtnActionOnScreenSaveNoAction.CheckAlign = ContentAlignment.BottomCenter
        radbtnActionOnScreenSaveNoAction.Location = New Point(6, 26)
        radbtnActionOnScreenSaveNoAction.Name = "radbtnActionOnScreenSaveNoAction"
        radbtnActionOnScreenSaveNoAction.Size = New Size(98, 43)
        radbtnActionOnScreenSaveNoAction.TabIndex = 0
        radbtnActionOnScreenSaveNoAction.TabStop = True
        radbtnActionOnScreenSaveNoAction.Text = "No Action"
        radbtnActionOnScreenSaveNoAction.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveNoAction.UseVisualStyleBackColor = True
        ' 
        ' chbxHideCursorWhenFullscreen
        ' 
        chbxHideCursorWhenFullscreen.Location = New Point(112, 166)
        chbxHideCursorWhenFullscreen.Name = "chbxHideCursorWhenFullscreen"
        chbxHideCursorWhenFullscreen.Size = New Size(241, 26)
        chbxHideCursorWhenFullscreen.TabIndex = 40
        chbxHideCursorWhenFullscreen.Text = "Hide Cursor When Fullscreen"
        chbxHideCursorWhenFullscreen.UseVisualStyleBackColor = True
        ' 
        ' chbxRefreshFileListsOnStartUp
        ' 
        chbxRefreshFileListsOnStartUp.Location = New Point(112, 127)
        chbxRefreshFileListsOnStartUp.Name = "chbxRefreshFileListsOnStartUp"
        chbxRefreshFileListsOnStartUp.Size = New Size(241, 26)
        chbxRefreshFileListsOnStartUp.TabIndex = 30
        chbxRefreshFileListsOnStartUp.Text = "Refresh File Lists On StartUp?"
        chbxRefreshFileListsOnStartUp.UseVisualStyleBackColor = True
        ' 
        ' chbxLoadFileListsInBackground
        ' 
        chbxLoadFileListsInBackground.Location = New Point(112, 88)
        chbxLoadFileListsInBackground.Name = "chbxLoadFileListsInBackground"
        chbxLoadFileListsInBackground.Size = New Size(241, 26)
        chbxLoadFileListsInBackground.TabIndex = 20
        chbxLoadFileListsInBackground.Text = "Load File Lists In Background?"
        chbxLoadFileListsInBackground.UseVisualStyleBackColor = True
        ' 
        ' chbxSaveFileLists
        ' 
        chbxSaveFileLists.Location = New Point(112, 49)
        chbxSaveFileLists.Name = "chbxSaveFileLists"
        chbxSaveFileLists.Size = New Size(151, 26)
        chbxSaveFileLists.TabIndex = 10
        chbxSaveFileLists.Text = "Save File Lists?"
        chbxSaveFileLists.UseVisualStyleBackColor = True
        ' 
        ' chbkVidMute
        ' 
        chbkVidMute.BackColor = Color.Transparent
        chbkVidMute.Image = CType(resources.GetObject("chbkVidMute.Image"), Image)
        chbkVidMute.ImageAlign = ContentAlignment.MiddleLeft
        chbkVidMute.Location = New Point(261, 208)
        chbkVidMute.Name = "chbkVidMute"
        chbkVidMute.Size = New Size(129, 52)
        chbkVidMute.TabIndex = 131
        chbkVidMute.Text = "Mute Audio"
        chbkVidMute.TextAlign = ContentAlignment.MiddleRight
        chbkVidMute.UseVisualStyleBackColor = False
        ' 
        ' grbxHotKeysVids
        ' 
        grbxHotKeysVids.BackColor = Color.Transparent
        grbxHotKeysVids.Controls.Add(txbxHotKeyVidToggle)
        grbxHotKeysVids.Controls.Add(btnHotKeyVidToggleDisable)
        grbxHotKeysVids.Controls.Add(txbxHotKeyVidToggleFullScreen)
        grbxHotKeysVids.Controls.Add(btnHotKeyVidToggleFullScreenDisable)
        grbxHotKeysVids.Controls.Add(btnHotKeysVidsUndo)
        grbxHotKeysVids.Controls.Add(btnHotKeysVidsSet)
        grbxHotKeysVids.Controls.Add(txbxHotKeyVidShowFileInfo)
        grbxHotKeysVids.Controls.Add(btnHotKeyVidShowFileInfoDisable)
        grbxHotKeysVids.Controls.Add(lblHotKeyVidToggle)
        grbxHotKeysVids.Controls.Add(lblHotKeyVidToggleFullScreen)
        grbxHotKeysVids.Controls.Add(lblHotKeyVidShowFileInfo)
        grbxHotKeysVids.ForeColor = SystemColors.ControlText
        grbxHotKeysVids.Location = New Point(567, 253)
        grbxHotKeysVids.Name = "grbxHotKeysVids"
        grbxHotKeysVids.Size = New Size(181, 196)
        grbxHotKeysVids.TabIndex = 130
        grbxHotKeysVids.TabStop = False
        grbxHotKeysVids.Text = "HotKeys"
        ' 
        ' txbxHotKeyVidToggle
        ' 
        txbxHotKeyVidToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyVidToggle.Location = New Point(8, 39)
        txbxHotKeyVidToggle.Name = "txbxHotKeyVidToggle"
        txbxHotKeyVidToggle.ShortcutsEnabled = False
        txbxHotKeyVidToggle.Size = New Size(151, 29)
        txbxHotKeyVidToggle.TabIndex = 45
        txbxHotKeyVidToggle.TabStop = False
        txbxHotKeyVidToggle.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidToggle.WordWrap = False
        ' 
        ' btnHotKeyVidToggleDisable
        ' 
        btnHotKeyVidToggleDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidToggleDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidToggleDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidToggleDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyVidToggleDisable.Location = New Point(156, 43)
        btnHotKeyVidToggleDisable.Name = "btnHotKeyVidToggleDisable"
        btnHotKeyVidToggleDisable.Size = New Size(20, 17)
        btnHotKeyVidToggleDisable.TabIndex = 46
        btnHotKeyVidToggleDisable.TabStop = False
        btnHotKeyVidToggleDisable.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyVidToggleFullScreen
        ' 
        txbxHotKeyVidToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyVidToggleFullScreen.Location = New Point(8, 82)
        txbxHotKeyVidToggleFullScreen.Name = "txbxHotKeyVidToggleFullScreen"
        txbxHotKeyVidToggleFullScreen.ShortcutsEnabled = False
        txbxHotKeyVidToggleFullScreen.Size = New Size(151, 29)
        txbxHotKeyVidToggleFullScreen.TabIndex = 42
        txbxHotKeyVidToggleFullScreen.TabStop = False
        txbxHotKeyVidToggleFullScreen.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidToggleFullScreen.WordWrap = False
        ' 
        ' btnHotKeyVidToggleFullScreenDisable
        ' 
        btnHotKeyVidToggleFullScreenDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidToggleFullScreenDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidToggleFullScreenDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidToggleFullScreenDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyVidToggleFullScreenDisable.Location = New Point(156, 86)
        btnHotKeyVidToggleFullScreenDisable.Name = "btnHotKeyVidToggleFullScreenDisable"
        btnHotKeyVidToggleFullScreenDisable.Size = New Size(20, 17)
        btnHotKeyVidToggleFullScreenDisable.TabIndex = 43
        btnHotKeyVidToggleFullScreenDisable.TabStop = False
        btnHotKeyVidToggleFullScreenDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysVidsUndo
        ' 
        btnHotKeysVidsUndo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeysVidsUndo.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysVidsUndo.Location = New Point(7, 156)
        btnHotKeysVidsUndo.Name = "btnHotKeysVidsUndo"
        btnHotKeysVidsUndo.Size = New Size(83, 32)
        btnHotKeysVidsUndo.TabIndex = 30
        btnHotKeysVidsUndo.TabStop = False
        btnHotKeysVidsUndo.Text = "Undo"
        btnHotKeysVidsUndo.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysVidsUndo.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysVidsSet
        ' 
        btnHotKeysVidsSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeysVidsSet.Image = My.Resources.Resources.imageGo
        btnHotKeysVidsSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysVidsSet.Location = New Point(96, 156)
        btnHotKeysVidsSet.Name = "btnHotKeysVidsSet"
        btnHotKeysVidsSet.Size = New Size(63, 32)
        btnHotKeysVidsSet.TabIndex = 40
        btnHotKeysVidsSet.TabStop = False
        btnHotKeysVidsSet.Text = "Set"
        btnHotKeysVidsSet.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysVidsSet.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyVidShowFileInfo
        ' 
        txbxHotKeyVidShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyVidShowFileInfo.Location = New Point(8, 125)
        txbxHotKeyVidShowFileInfo.Name = "txbxHotKeyVidShowFileInfo"
        txbxHotKeyVidShowFileInfo.ShortcutsEnabled = False
        txbxHotKeyVidShowFileInfo.Size = New Size(151, 29)
        txbxHotKeyVidShowFileInfo.TabIndex = 10
        txbxHotKeyVidShowFileInfo.TabStop = False
        txbxHotKeyVidShowFileInfo.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidShowFileInfo.WordWrap = False
        ' 
        ' btnHotKeyVidShowFileInfoDisable
        ' 
        btnHotKeyVidShowFileInfoDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidShowFileInfoDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidShowFileInfoDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidShowFileInfoDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyVidShowFileInfoDisable.Location = New Point(156, 129)
        btnHotKeyVidShowFileInfoDisable.Name = "btnHotKeyVidShowFileInfoDisable"
        btnHotKeyVidShowFileInfoDisable.Size = New Size(20, 17)
        btnHotKeyVidShowFileInfoDisable.TabIndex = 20
        btnHotKeyVidShowFileInfoDisable.TabStop = False
        btnHotKeyVidShowFileInfoDisable.UseVisualStyleBackColor = True
        ' 
        ' lblHotKeyVidToggle
        ' 
        lblHotKeyVidToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidToggle.BackColor = Color.Transparent
        lblHotKeyVidToggle.ForeColor = SystemColors.ControlText
        lblHotKeyVidToggle.Location = New Point(-21, 17)
        lblHotKeyVidToggle.Name = "lblHotKeyVidToggle"
        lblHotKeyVidToggle.Size = New Size(211, 23)
        lblHotKeyVidToggle.TabIndex = 44
        lblHotKeyVidToggle.Text = "VidToggle"
        lblHotKeyVidToggle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyVidToggleFullScreen
        ' 
        lblHotKeyVidToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidToggleFullScreen.BackColor = Color.Transparent
        lblHotKeyVidToggleFullScreen.ForeColor = SystemColors.ControlText
        lblHotKeyVidToggleFullScreen.Location = New Point(-21, 60)
        lblHotKeyVidToggleFullScreen.Name = "lblHotKeyVidToggleFullScreen"
        lblHotKeyVidToggleFullScreen.Size = New Size(211, 23)
        lblHotKeyVidToggleFullScreen.TabIndex = 41
        lblHotKeyVidToggleFullScreen.Text = "VidToggleFullScreen"
        lblHotKeyVidToggleFullScreen.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyVidShowFileInfo
        ' 
        lblHotKeyVidShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidShowFileInfo.BackColor = Color.Transparent
        lblHotKeyVidShowFileInfo.ForeColor = SystemColors.ControlText
        lblHotKeyVidShowFileInfo.Location = New Point(-21, 103)
        lblHotKeyVidShowFileInfo.Name = "lblHotKeyVidShowFileInfo"
        lblHotKeyVidShowFileInfo.Size = New Size(211, 23)
        lblHotKeyVidShowFileInfo.TabIndex = 0
        lblHotKeyVidShowFileInfo.Text = "VidShowFileInfo"
        lblHotKeyVidShowFileInfo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cobxVidTimeDisplayMode
        ' 
        cobxVidTimeDisplayMode.DropDownStyle = ComboBoxStyle.DropDownList
        cobxVidTimeDisplayMode.FormattingEnabled = True
        cobxVidTimeDisplayMode.Location = New Point(261, 281)
        cobxVidTimeDisplayMode.Name = "cobxVidTimeDisplayMode"
        cobxVidTimeDisplayMode.Size = New Size(156, 29)
        cobxVidTimeDisplayMode.TabIndex = 105
        ' 
        ' chbxVidLockFullScreen
        ' 
        chbxVidLockFullScreen.BackColor = Color.Transparent
        chbxVidLockFullScreen.CheckAlign = ContentAlignment.MiddleRight
        chbxVidLockFullScreen.Location = New Point(554, 151)
        chbxVidLockFullScreen.Name = "chbxVidLockFullScreen"
        chbxVidLockFullScreen.Size = New Size(120, 22)
        chbxVidLockFullScreen.TabIndex = 75
        chbxVidLockFullScreen.Text = "Lock Full Screen"
        chbxVidLockFullScreen.TextAlign = ContentAlignment.MiddleRight
        chbxVidLockFullScreen.UseVisualStyleBackColor = False
        ' 
        ' chbxVidAutoView
        ' 
        chbxVidAutoView.BackColor = Color.Transparent
        chbxVidAutoView.CheckAlign = ContentAlignment.MiddleRight
        chbxVidAutoView.Location = New Point(590, 133)
        chbxVidAutoView.Name = "chbxVidAutoView"
        chbxVidAutoView.Size = New Size(84, 22)
        chbxVidAutoView.TabIndex = 70
        chbxVidAutoView.Text = "AutoView"
        chbxVidAutoView.TextAlign = ContentAlignment.MiddleRight
        chbxVidAutoView.UseVisualStyleBackColor = False
        ' 
        ' gpbxVidScale
        ' 
        gpbxVidScale.BackColor = Color.Transparent
        gpbxVidScale.Controls.Add(radbtnVideoScale100)
        gpbxVidScale.Controls.Add(radbtnVideoScaleFit)
        gpbxVidScale.Controls.Add(radbtnVideoScale10)
        gpbxVidScale.Controls.Add(radbtnVideoScale25)
        gpbxVidScale.Controls.Add(radbtnVideoScale33)
        gpbxVidScale.Controls.Add(radbtnVideoScale50)
        gpbxVidScale.Controls.Add(radbtnVideoScale66)
        gpbxVidScale.Controls.Add(radbtnVideoScale75)
        gpbxVidScale.Location = New Point(261, 137)
        gpbxVidScale.Name = "gpbxVidScale"
        gpbxVidScale.Size = New Size(270, 65)
        gpbxVidScale.TabIndex = 60
        gpbxVidScale.TabStop = False
        gpbxVidScale.Text = "Video Scale"
        ' 
        ' radbtnVideoScale100
        ' 
        radbtnVideoScale100.Location = New Point(211, 19)
        radbtnVideoScale100.Name = "radbtnVideoScale100"
        radbtnVideoScale100.Size = New Size(58, 24)
        radbtnVideoScale100.TabIndex = 7
        radbtnVideoScale100.Text = "100%"
        radbtnVideoScale100.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScaleFit
        ' 
        radbtnVideoScaleFit.Location = New Point(109, 19)
        radbtnVideoScaleFit.Name = "radbtnVideoScaleFit"
        radbtnVideoScaleFit.Size = New Size(42, 24)
        radbtnVideoScaleFit.TabIndex = 0
        radbtnVideoScaleFit.Text = "FIT"
        radbtnVideoScaleFit.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale10
        ' 
        radbtnVideoScale10.Location = New Point(7, 19)
        radbtnVideoScale10.Name = "radbtnVideoScale10"
        radbtnVideoScale10.Size = New Size(51, 24)
        radbtnVideoScale10.TabIndex = 1
        radbtnVideoScale10.Text = "10%"
        radbtnVideoScale10.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale25
        ' 
        radbtnVideoScale25.Location = New Point(7, 37)
        radbtnVideoScale25.Name = "radbtnVideoScale25"
        radbtnVideoScale25.Size = New Size(51, 24)
        radbtnVideoScale25.TabIndex = 2
        radbtnVideoScale25.Text = "25%"
        radbtnVideoScale25.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale33
        ' 
        radbtnVideoScale33.Location = New Point(58, 37)
        radbtnVideoScale33.Name = "radbtnVideoScale33"
        radbtnVideoScale33.Size = New Size(51, 24)
        radbtnVideoScale33.TabIndex = 3
        radbtnVideoScale33.Text = "33%"
        radbtnVideoScale33.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale50
        ' 
        radbtnVideoScale50.Location = New Point(109, 37)
        radbtnVideoScale50.Name = "radbtnVideoScale50"
        radbtnVideoScale50.Size = New Size(51, 24)
        radbtnVideoScale50.TabIndex = 4
        radbtnVideoScale50.Text = "50%"
        radbtnVideoScale50.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale66
        ' 
        radbtnVideoScale66.Location = New Point(160, 37)
        radbtnVideoScale66.Name = "radbtnVideoScale66"
        radbtnVideoScale66.Size = New Size(51, 24)
        radbtnVideoScale66.TabIndex = 5
        radbtnVideoScale66.Text = "66%"
        radbtnVideoScale66.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale75
        ' 
        radbtnVideoScale75.Location = New Point(211, 37)
        radbtnVideoScale75.Name = "radbtnVideoScale75"
        radbtnVideoScale75.Size = New Size(51, 24)
        radbtnVideoScale75.TabIndex = 6
        radbtnVideoScale75.Text = "75%"
        radbtnVideoScale75.UseVisualStyleBackColor = True
        ' 
        ' gpbxVidLocationMode
        ' 
        gpbxVidLocationMode.BackColor = Color.Transparent
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopLeftInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomLeftInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomRightInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopRightInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenterBottomInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenterInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenterTopInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenterInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenterInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenterLeftInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenterRightInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenterBottomInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenterRightInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenterTopInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenterInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenterLeftInside)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenterTop)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomLeft)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenterTop)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenterBottom)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenterRight)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenterLeft)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomRight)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenterBottom)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeBottomCenter)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeLeftCenter)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenterLeft)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenter)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopRight)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopCenterRight)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeRightCenter)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeTopLeft)
        gpbxVidLocationMode.Controls.Add(radbtnVidLocationModeManual)
        gpbxVidLocationMode.Location = New Point(7, 239)
        gpbxVidLocationMode.Name = "gpbxVidLocationMode"
        gpbxVidLocationMode.Size = New Size(195, 210)
        gpbxVidLocationMode.TabIndex = 90
        gpbxVidLocationMode.TabStop = False
        gpbxVidLocationMode.Text = "Video Location"
        ' 
        ' radbtnVidLocationModeTopLeftInside
        ' 
        radbtnVidLocationModeTopLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopLeftInside.Location = New Point(34, 48)
        radbtnVidLocationModeTopLeftInside.Name = "radbtnVidLocationModeTopLeftInside"
        radbtnVidLocationModeTopLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopLeftInside.TabIndex = 107
        radbtnVidLocationModeTopLeftInside.Text = "  "
        radbtnVidLocationModeTopLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomLeftInside
        ' 
        radbtnVidLocationModeBottomLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomLeftInside.Location = New Point(34, 160)
        radbtnVidLocationModeBottomLeftInside.Name = "radbtnVidLocationModeBottomLeftInside"
        radbtnVidLocationModeBottomLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomLeftInside.TabIndex = 108
        radbtnVidLocationModeBottomLeftInside.Text = "  "
        radbtnVidLocationModeBottomLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomRightInside
        ' 
        radbtnVidLocationModeBottomRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomRightInside.Location = New Point(146, 160)
        radbtnVidLocationModeBottomRightInside.Name = "radbtnVidLocationModeBottomRightInside"
        radbtnVidLocationModeBottomRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomRightInside.TabIndex = 109
        radbtnVidLocationModeBottomRightInside.Text = "  "
        radbtnVidLocationModeBottomRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopRightInside
        ' 
        radbtnVidLocationModeTopRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopRightInside.Location = New Point(146, 48)
        radbtnVidLocationModeTopRightInside.Name = "radbtnVidLocationModeTopRightInside"
        radbtnVidLocationModeTopRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopRightInside.TabIndex = 112
        radbtnVidLocationModeTopRightInside.Text = "  "
        radbtnVidLocationModeTopRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterBottomInside
        ' 
        radbtnVidLocationModeLeftCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterBottomInside.Location = New Point(34, 132)
        radbtnVidLocationModeLeftCenterBottomInside.Name = "radbtnVidLocationModeLeftCenterBottomInside"
        radbtnVidLocationModeLeftCenterBottomInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterBottomInside.TabIndex = 106
        radbtnVidLocationModeLeftCenterBottomInside.Text = "  "
        radbtnVidLocationModeLeftCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterInside
        ' 
        radbtnVidLocationModeLeftCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterInside.Location = New Point(34, 104)
        radbtnVidLocationModeLeftCenterInside.Name = "radbtnVidLocationModeLeftCenterInside"
        radbtnVidLocationModeLeftCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterInside.TabIndex = 110
        radbtnVidLocationModeLeftCenterInside.Text = "  "
        radbtnVidLocationModeLeftCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterTopInside
        ' 
        radbtnVidLocationModeLeftCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterTopInside.Location = New Point(34, 76)
        radbtnVidLocationModeLeftCenterTopInside.Name = "radbtnVidLocationModeLeftCenterTopInside"
        radbtnVidLocationModeLeftCenterTopInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterTopInside.TabIndex = 111
        radbtnVidLocationModeLeftCenterTopInside.Text = "  "
        radbtnVidLocationModeLeftCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterInside
        ' 
        radbtnVidLocationModeBottomCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterInside.Location = New Point(90, 160)
        radbtnVidLocationModeBottomCenterInside.Name = "radbtnVidLocationModeBottomCenterInside"
        radbtnVidLocationModeBottomCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterInside.TabIndex = 104
        radbtnVidLocationModeBottomCenterInside.Text = "  "
        radbtnVidLocationModeBottomCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterInside
        ' 
        radbtnVidLocationModeRightCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterInside.Location = New Point(146, 104)
        radbtnVidLocationModeRightCenterInside.Name = "radbtnVidLocationModeRightCenterInside"
        radbtnVidLocationModeRightCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterInside.TabIndex = 102
        radbtnVidLocationModeRightCenterInside.Text = "  "
        radbtnVidLocationModeRightCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterLeftInside
        ' 
        radbtnVidLocationModeBottomCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterLeftInside.Location = New Point(62, 160)
        radbtnVidLocationModeBottomCenterLeftInside.Name = "radbtnVidLocationModeBottomCenterLeftInside"
        radbtnVidLocationModeBottomCenterLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterLeftInside.TabIndex = 105
        radbtnVidLocationModeBottomCenterLeftInside.Text = "  "
        radbtnVidLocationModeBottomCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterRightInside
        ' 
        radbtnVidLocationModeBottomCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterRightInside.Location = New Point(118, 160)
        radbtnVidLocationModeBottomCenterRightInside.Name = "radbtnVidLocationModeBottomCenterRightInside"
        radbtnVidLocationModeBottomCenterRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterRightInside.TabIndex = 101
        radbtnVidLocationModeBottomCenterRightInside.Text = "  "
        radbtnVidLocationModeBottomCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterBottomInside
        ' 
        radbtnVidLocationModeRightCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterBottomInside.Location = New Point(146, 132)
        radbtnVidLocationModeRightCenterBottomInside.Name = "radbtnVidLocationModeRightCenterBottomInside"
        radbtnVidLocationModeRightCenterBottomInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterBottomInside.TabIndex = 103
        radbtnVidLocationModeRightCenterBottomInside.Text = "  "
        radbtnVidLocationModeRightCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterRightInside
        ' 
        radbtnVidLocationModeTopCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterRightInside.Location = New Point(118, 48)
        radbtnVidLocationModeTopCenterRightInside.Name = "radbtnVidLocationModeTopCenterRightInside"
        radbtnVidLocationModeTopCenterRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterRightInside.TabIndex = 99
        radbtnVidLocationModeTopCenterRightInside.Text = "  "
        radbtnVidLocationModeTopCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterTopInside
        ' 
        radbtnVidLocationModeRightCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterTopInside.Location = New Point(146, 76)
        radbtnVidLocationModeRightCenterTopInside.Name = "radbtnVidLocationModeRightCenterTopInside"
        radbtnVidLocationModeRightCenterTopInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterTopInside.TabIndex = 100
        radbtnVidLocationModeRightCenterTopInside.Text = "  "
        radbtnVidLocationModeRightCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterInside
        ' 
        radbtnVidLocationModeTopCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterInside.Location = New Point(90, 48)
        radbtnVidLocationModeTopCenterInside.Name = "radbtnVidLocationModeTopCenterInside"
        radbtnVidLocationModeTopCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterInside.TabIndex = 98
        radbtnVidLocationModeTopCenterInside.Text = "  "
        radbtnVidLocationModeTopCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterLeftInside
        ' 
        radbtnVidLocationModeTopCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterLeftInside.Location = New Point(62, 48)
        radbtnVidLocationModeTopCenterLeftInside.Name = "radbtnVidLocationModeTopCenterLeftInside"
        radbtnVidLocationModeTopCenterLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterLeftInside.TabIndex = 97
        radbtnVidLocationModeTopCenterLeftInside.Text = "  "
        radbtnVidLocationModeTopCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterTop
        ' 
        radbtnVidLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterTop.Location = New Point(6, 62)
        radbtnVidLocationModeLeftCenterTop.Name = "radbtnVidLocationModeLeftCenterTop"
        radbtnVidLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterTop.TabIndex = 33
        radbtnVidLocationModeLeftCenterTop.Text = "  "
        radbtnVidLocationModeLeftCenterTop.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomLeft
        ' 
        radbtnVidLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomLeft.Location = New Point(6, 188)
        radbtnVidLocationModeBottomLeft.Name = "radbtnVidLocationModeBottomLeft"
        radbtnVidLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnVidLocationModeBottomLeft.TabIndex = 30
        radbtnVidLocationModeBottomLeft.Text = "  "
        radbtnVidLocationModeBottomLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterTop
        ' 
        radbtnVidLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterTop.Location = New Point(174, 62)
        radbtnVidLocationModeRightCenterTop.Name = "radbtnVidLocationModeRightCenterTop"
        radbtnVidLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterTop.TabIndex = 23
        radbtnVidLocationModeRightCenterTop.Text = "  "
        radbtnVidLocationModeRightCenterTop.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterBottom
        ' 
        radbtnVidLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterBottom.Location = New Point(174, 146)
        radbtnVidLocationModeRightCenterBottom.Name = "radbtnVidLocationModeRightCenterBottom"
        radbtnVidLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterBottom.TabIndex = 25
        radbtnVidLocationModeRightCenterBottom.Text = "  "
        radbtnVidLocationModeRightCenterBottom.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterRight
        ' 
        radbtnVidLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterRight.Location = New Point(132, 188)
        radbtnVidLocationModeBottomCenterRight.Name = "radbtnVidLocationModeBottomCenterRight"
        radbtnVidLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterRight.TabIndex = 27
        radbtnVidLocationModeBottomCenterRight.Text = "  "
        radbtnVidLocationModeBottomCenterRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterLeft
        ' 
        radbtnVidLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterLeft.Location = New Point(48, 188)
        radbtnVidLocationModeBottomCenterLeft.Name = "radbtnVidLocationModeBottomCenterLeft"
        radbtnVidLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterLeft.TabIndex = 29
        radbtnVidLocationModeBottomCenterLeft.Text = "  "
        radbtnVidLocationModeBottomCenterLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomRight
        ' 
        radbtnVidLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomRight.Location = New Point(174, 188)
        radbtnVidLocationModeBottomRight.Name = "radbtnVidLocationModeBottomRight"
        radbtnVidLocationModeBottomRight.Size = New Size(16, 16)
        radbtnVidLocationModeBottomRight.TabIndex = 26
        radbtnVidLocationModeBottomRight.Text = "  "
        radbtnVidLocationModeBottomRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterBottom
        ' 
        radbtnVidLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterBottom.Location = New Point(6, 146)
        radbtnVidLocationModeLeftCenterBottom.Name = "radbtnVidLocationModeLeftCenterBottom"
        radbtnVidLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterBottom.TabIndex = 31
        radbtnVidLocationModeLeftCenterBottom.Text = "  "
        radbtnVidLocationModeLeftCenterBottom.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenter
        ' 
        radbtnVidLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenter.Location = New Point(90, 188)
        radbtnVidLocationModeBottomCenter.Name = "radbtnVidLocationModeBottomCenter"
        radbtnVidLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenter.TabIndex = 28
        radbtnVidLocationModeBottomCenter.Text = "  "
        radbtnVidLocationModeBottomCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenter
        ' 
        radbtnVidLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenter.Location = New Point(6, 104)
        radbtnVidLocationModeLeftCenter.Name = "radbtnVidLocationModeLeftCenter"
        radbtnVidLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenter.TabIndex = 32
        radbtnVidLocationModeLeftCenter.Text = "  "
        radbtnVidLocationModeLeftCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterLeft
        ' 
        radbtnVidLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterLeft.Location = New Point(48, 20)
        radbtnVidLocationModeTopCenterLeft.Name = "radbtnVidLocationModeTopCenterLeft"
        radbtnVidLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterLeft.TabIndex = 19
        radbtnVidLocationModeTopCenterLeft.Text = "  "
        radbtnVidLocationModeTopCenterLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenter
        ' 
        radbtnVidLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenter.Location = New Point(90, 20)
        radbtnVidLocationModeTopCenter.Name = "radbtnVidLocationModeTopCenter"
        radbtnVidLocationModeTopCenter.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenter.TabIndex = 20
        radbtnVidLocationModeTopCenter.Text = "  "
        radbtnVidLocationModeTopCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopRight
        ' 
        radbtnVidLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopRight.Location = New Point(174, 20)
        radbtnVidLocationModeTopRight.Name = "radbtnVidLocationModeTopRight"
        radbtnVidLocationModeTopRight.Size = New Size(16, 16)
        radbtnVidLocationModeTopRight.TabIndex = 22
        radbtnVidLocationModeTopRight.Text = "  "
        radbtnVidLocationModeTopRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterRight
        ' 
        radbtnVidLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterRight.Location = New Point(132, 20)
        radbtnVidLocationModeTopCenterRight.Name = "radbtnVidLocationModeTopCenterRight"
        radbtnVidLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterRight.TabIndex = 21
        radbtnVidLocationModeTopCenterRight.Text = "  "
        radbtnVidLocationModeTopCenterRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenter
        ' 
        radbtnVidLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenter.Location = New Point(174, 104)
        radbtnVidLocationModeRightCenter.Name = "radbtnVidLocationModeRightCenter"
        radbtnVidLocationModeRightCenter.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenter.TabIndex = 24
        radbtnVidLocationModeRightCenter.Text = "  "
        radbtnVidLocationModeRightCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopLeft
        ' 
        radbtnVidLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopLeft.Location = New Point(6, 20)
        radbtnVidLocationModeTopLeft.Name = "radbtnVidLocationModeTopLeft"
        radbtnVidLocationModeTopLeft.Size = New Size(16, 16)
        radbtnVidLocationModeTopLeft.TabIndex = 18
        radbtnVidLocationModeTopLeft.Text = "  "
        radbtnVidLocationModeTopLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeManual
        ' 
        radbtnVidLocationModeManual.CheckAlign = ContentAlignment.BottomCenter
        radbtnVidLocationModeManual.Location = New Point(69, 78)
        radbtnVidLocationModeManual.Name = "radbtnVidLocationModeManual"
        radbtnVidLocationModeManual.Size = New Size(57, 40)
        radbtnVidLocationModeManual.TabIndex = 17
        radbtnVidLocationModeManual.Text = "Manual"
        radbtnVidLocationModeManual.TextAlign = ContentAlignment.TopCenter
        radbtnVidLocationModeManual.UseVisualStyleBackColor = True
        ' 
        ' gpbxVidPlayMode
        ' 
        gpbxVidPlayMode.BackColor = Color.Transparent
        gpbxVidPlayMode.Controls.Add(radbtnVidPlayModeLinearWithRandomStart)
        gpbxVidPlayMode.Controls.Add(radbtnVidPlayModeRandom)
        gpbxVidPlayMode.Controls.Add(radbtnVidPlayModeLinear)
        gpbxVidPlayMode.Location = New Point(7, 137)
        gpbxVidPlayMode.Name = "gpbxVidPlayMode"
        gpbxVidPlayMode.Size = New Size(248, 47)
        gpbxVidPlayMode.TabIndex = 50
        gpbxVidPlayMode.TabStop = False
        gpbxVidPlayMode.Text = "Video Play Mode"
        ' 
        ' radbtnVidPlayModeLinearWithRandomStart
        ' 
        radbtnVidPlayModeLinearWithRandomStart.Location = New Point(84, 19)
        radbtnVidPlayModeLinearWithRandomStart.Name = "radbtnVidPlayModeLinearWithRandomStart"
        radbtnVidPlayModeLinearWithRandomStart.Size = New Size(74, 24)
        radbtnVidPlayModeLinearWithRandomStart.TabIndex = 2
        radbtnVidPlayModeLinearWithRandomStart.Text = "Linear +"
        tipInfo.SetToolTip(radbtnVidPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnVidPlayModeLinearWithRandomStart.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidPlayModeRandom
        ' 
        radbtnVidPlayModeRandom.Location = New Point(172, 19)
        radbtnVidPlayModeRandom.Name = "radbtnVidPlayModeRandom"
        radbtnVidPlayModeRandom.Size = New Size(75, 24)
        radbtnVidPlayModeRandom.TabIndex = 1
        radbtnVidPlayModeRandom.Text = "Random"
        radbtnVidPlayModeRandom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidPlayModeLinear
        ' 
        radbtnVidPlayModeLinear.Location = New Point(7, 19)
        radbtnVidPlayModeLinear.Name = "radbtnVidPlayModeLinear"
        radbtnVidPlayModeLinear.Size = New Size(61, 24)
        radbtnVidPlayModeLinear.TabIndex = 0
        radbtnVidPlayModeLinear.Text = "Linear"
        radbtnVidPlayModeLinear.UseVisualStyleBackColor = True
        ' 
        ' chbxVidTime
        ' 
        chbxVidTime.BackColor = Color.Transparent
        chbxVidTime.Location = New Point(261, 261)
        chbxVidTime.Name = "chbxVidTime"
        chbxVidTime.Size = New Size(133, 22)
        chbxVidTime.TabIndex = 100
        chbxVidTime.Text = "Show Video Time"
        chbxVidTime.UseVisualStyleBackColor = False
        ' 
        ' lblVidFileCount
        ' 
        lblVidFileCount.BackColor = Color.Transparent
        lblVidFileCount.Location = New Point(8, 97)
        lblVidFileCount.Name = "lblVidFileCount"
        lblVidFileCount.Size = New Size(254, 22)
        lblVidFileCount.TabIndex = 0
        ' 
        ' btnlvVidFolders
        ' 
        btnlvVidFolders.BackColor = Color.Transparent
        btnlvVidFolders.FlatAppearance.BorderSize = 0
        btnlvVidFolders.Image = My.Resources.Resources.imageFolder
        btnlvVidFolders.ImageAlign = ContentAlignment.MiddleLeft
        btnlvVidFolders.Location = New Point(469, 95)
        btnlvVidFolders.Name = "btnlvVidFolders"
        btnlvVidFolders.Size = New Size(175, 32)
        btnlvVidFolders.TabIndex = 22
        btnlvVidFolders.TabStop = False
        btnlvVidFolders.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnlvVidFolders, "Folder List View Mode")
        btnlvVidFolders.UseMnemonic = False
        btnlvVidFolders.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshVidList
        ' 
        btnRefreshVidList.BackColor = Color.Transparent
        btnRefreshVidList.FlatAppearance.BorderColor = SystemColors.Highlight
        btnRefreshVidList.FlatAppearance.BorderSize = 0
        btnRefreshVidList.Image = My.Resources.Resources.imageRefresh
        btnRefreshVidList.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshVidList.Location = New Point(650, 95)
        btnRefreshVidList.Name = "btnRefreshVidList"
        btnRefreshVidList.Size = New Size(100, 32)
        btnRefreshVidList.TabIndex = 24
        btnRefreshVidList.TabStop = False
        btnRefreshVidList.Text = "Refresh"
        btnRefreshVidList.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnRefreshVidList, "LeftClick = Refresh Video List (Ctrl = Reset)" & vbCrLf & "RightClick = Refresh All File Lists (Ctrl = Reset)")
        btnRefreshVidList.UseVisualStyleBackColor = False
        ' 
        ' grbxVidTimeLocationMode
        ' 
        grbxVidTimeLocationMode.BackColor = Color.Transparent
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeLeftCenterTop)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeBottomLeft)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeRightCenterTop)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeRightCenterBottom)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeBottomCenterRight)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeBottomCenterLeft)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeBottomRight)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeLeftCenterBottom)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeBottomCenter)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeLeftCenter)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeTopCenterLeft)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeTopCenter)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeTopRight)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeTopCenterRight)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeRightCenter)
        grbxVidTimeLocationMode.Controls.Add(radbtnVidTimeLocationModeTopLeft)
        grbxVidTimeLocationMode.Location = New Point(261, 305)
        grbxVidTimeLocationMode.Name = "grbxVidTimeLocationMode"
        grbxVidTimeLocationMode.Size = New Size(133, 144)
        grbxVidTimeLocationMode.TabIndex = 110
        grbxVidTimeLocationMode.TabStop = False
        grbxVidTimeLocationMode.Text = "Time Location"
        ' 
        ' radbtnVidTimeLocationModeLeftCenterTop
        ' 
        radbtnVidTimeLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeLeftCenterTop.Location = New Point(5, 45)
        radbtnVidTimeLocationModeLeftCenterTop.Name = "radbtnVidTimeLocationModeLeftCenterTop"
        radbtnVidTimeLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenterTop.TabIndex = 16
        radbtnVidTimeLocationModeLeftCenterTop.Text = "  "
        radbtnVidTimeLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomLeft
        ' 
        radbtnVidTimeLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeBottomLeft.Location = New Point(5, 123)
        radbtnVidTimeLocationModeBottomLeft.Name = "radbtnVidTimeLocationModeBottomLeft"
        radbtnVidTimeLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomLeft.TabIndex = 13
        radbtnVidTimeLocationModeBottomLeft.Text = "  "
        radbtnVidTimeLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenterTop
        ' 
        radbtnVidTimeLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeRightCenterTop.Location = New Point(113, 45)
        radbtnVidTimeLocationModeRightCenterTop.Name = "radbtnVidTimeLocationModeRightCenterTop"
        radbtnVidTimeLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenterTop.TabIndex = 6
        radbtnVidTimeLocationModeRightCenterTop.Text = "  "
        radbtnVidTimeLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenterBottom
        ' 
        radbtnVidTimeLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeRightCenterBottom.Location = New Point(113, 97)
        radbtnVidTimeLocationModeRightCenterBottom.Name = "radbtnVidTimeLocationModeRightCenterBottom"
        radbtnVidTimeLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenterBottom.TabIndex = 8
        radbtnVidTimeLocationModeRightCenterBottom.Text = "  "
        radbtnVidTimeLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenterRight
        ' 
        radbtnVidTimeLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeBottomCenterRight.Location = New Point(86, 123)
        radbtnVidTimeLocationModeBottomCenterRight.Name = "radbtnVidTimeLocationModeBottomCenterRight"
        radbtnVidTimeLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenterRight.TabIndex = 10
        radbtnVidTimeLocationModeBottomCenterRight.Text = "  "
        radbtnVidTimeLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenterLeft
        ' 
        radbtnVidTimeLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeBottomCenterLeft.Location = New Point(32, 123)
        radbtnVidTimeLocationModeBottomCenterLeft.Name = "radbtnVidTimeLocationModeBottomCenterLeft"
        radbtnVidTimeLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenterLeft.TabIndex = 12
        radbtnVidTimeLocationModeBottomCenterLeft.Text = "  "
        radbtnVidTimeLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomRight
        ' 
        radbtnVidTimeLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeBottomRight.Location = New Point(113, 123)
        radbtnVidTimeLocationModeBottomRight.Name = "radbtnVidTimeLocationModeBottomRight"
        radbtnVidTimeLocationModeBottomRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomRight.TabIndex = 9
        radbtnVidTimeLocationModeBottomRight.Text = "  "
        radbtnVidTimeLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeLeftCenterBottom
        ' 
        radbtnVidTimeLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeLeftCenterBottom.Location = New Point(5, 97)
        radbtnVidTimeLocationModeLeftCenterBottom.Name = "radbtnVidTimeLocationModeLeftCenterBottom"
        radbtnVidTimeLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenterBottom.TabIndex = 14
        radbtnVidTimeLocationModeLeftCenterBottom.Text = "  "
        radbtnVidTimeLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenter
        ' 
        radbtnVidTimeLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeBottomCenter.Location = New Point(59, 123)
        radbtnVidTimeLocationModeBottomCenter.Name = "radbtnVidTimeLocationModeBottomCenter"
        radbtnVidTimeLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenter.TabIndex = 11
        radbtnVidTimeLocationModeBottomCenter.Text = "  "
        radbtnVidTimeLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeLeftCenter
        ' 
        radbtnVidTimeLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeLeftCenter.Location = New Point(5, 71)
        radbtnVidTimeLocationModeLeftCenter.Name = "radbtnVidTimeLocationModeLeftCenter"
        radbtnVidTimeLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenter.TabIndex = 15
        radbtnVidTimeLocationModeLeftCenter.Text = "  "
        radbtnVidTimeLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenterLeft
        ' 
        radbtnVidTimeLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeTopCenterLeft.Location = New Point(32, 19)
        radbtnVidTimeLocationModeTopCenterLeft.Name = "radbtnVidTimeLocationModeTopCenterLeft"
        radbtnVidTimeLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenterLeft.TabIndex = 2
        radbtnVidTimeLocationModeTopCenterLeft.Text = "  "
        radbtnVidTimeLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenter
        ' 
        radbtnVidTimeLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeTopCenter.Location = New Point(59, 19)
        radbtnVidTimeLocationModeTopCenter.Name = "radbtnVidTimeLocationModeTopCenter"
        radbtnVidTimeLocationModeTopCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenter.TabIndex = 3
        radbtnVidTimeLocationModeTopCenter.Text = "  "
        radbtnVidTimeLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopRight
        ' 
        radbtnVidTimeLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeTopRight.Location = New Point(113, 19)
        radbtnVidTimeLocationModeTopRight.Name = "radbtnVidTimeLocationModeTopRight"
        radbtnVidTimeLocationModeTopRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopRight.TabIndex = 5
        radbtnVidTimeLocationModeTopRight.Text = "  "
        radbtnVidTimeLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenterRight
        ' 
        radbtnVidTimeLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeTopCenterRight.Location = New Point(86, 19)
        radbtnVidTimeLocationModeTopCenterRight.Name = "radbtnVidTimeLocationModeTopCenterRight"
        radbtnVidTimeLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenterRight.TabIndex = 4
        radbtnVidTimeLocationModeTopCenterRight.Text = "  "
        radbtnVidTimeLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenter
        ' 
        radbtnVidTimeLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeRightCenter.Location = New Point(113, 71)
        radbtnVidTimeLocationModeRightCenter.Name = "radbtnVidTimeLocationModeRightCenter"
        radbtnVidTimeLocationModeRightCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenter.TabIndex = 7
        radbtnVidTimeLocationModeRightCenter.Text = "  "
        radbtnVidTimeLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopLeft
        ' 
        radbtnVidTimeLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnVidTimeLocationModeTopLeft.Location = New Point(5, 19)
        radbtnVidTimeLocationModeTopLeft.Name = "radbtnVidTimeLocationModeTopLeft"
        radbtnVidTimeLocationModeTopLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopLeft.TabIndex = 1
        radbtnVidTimeLocationModeTopLeft.Text = "  "
        radbtnVidTimeLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSaveSettings.Image = My.Resources.Resources.imageSave
        btnSaveSettings.ImageAlign = ContentAlignment.TopLeft
        btnSaveSettings.Location = New Point(15, 28)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(62, 46)
        btnSaveSettings.TabIndex = 100
        btnSaveSettings.Text = "Save"
        btnSaveSettings.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnSaveSettings, "Save All Settings")
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnRestoreSettings
        ' 
        btnRestoreSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRestoreSettings.Image = My.Resources.Resources.imageRestore
        btnRestoreSettings.ImageAlign = ContentAlignment.TopLeft
        btnRestoreSettings.Location = New Point(76, 28)
        btnRestoreSettings.Name = "btnRestoreSettings"
        btnRestoreSettings.Size = New Size(62, 46)
        btnRestoreSettings.TabIndex = 101
        btnRestoreSettings.Text = "Restore"
        btnRestoreSettings.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnRestoreSettings, "Restore All Settings")
        btnRestoreSettings.UseVisualStyleBackColor = True
        ' 
        ' radioButton16
        ' 
        radioButton16.CheckAlign = ContentAlignment.MiddleCenter
        radioButton16.Location = New Point(0, 42)
        radioButton16.Name = "radioButton16"
        radioButton16.Size = New Size(21, 24)
        radioButton16.TabIndex = 16
        radioButton16.UseVisualStyleBackColor = True
        ' 
        ' radioButton17
        ' 
        radioButton17.CheckAlign = ContentAlignment.MiddleCenter
        radioButton17.Location = New Point(0, 135)
        radioButton17.Name = "radioButton17"
        radioButton17.Size = New Size(21, 24)
        radioButton17.TabIndex = 13
        radioButton17.UseVisualStyleBackColor = True
        ' 
        ' radioButton18
        ' 
        radioButton18.CheckAlign = ContentAlignment.MiddleCenter
        radioButton18.Location = New Point(140, 42)
        radioButton18.Name = "radioButton18"
        radioButton18.Size = New Size(21, 24)
        radioButton18.TabIndex = 6
        radioButton18.UseVisualStyleBackColor = True
        ' 
        ' radioButton19
        ' 
        radioButton19.CheckAlign = ContentAlignment.MiddleCenter
        radioButton19.Location = New Point(140, 104)
        radioButton19.Name = "radioButton19"
        radioButton19.Size = New Size(21, 24)
        radioButton19.TabIndex = 8
        radioButton19.UseVisualStyleBackColor = True
        ' 
        ' radioButton20
        ' 
        radioButton20.CheckAlign = ContentAlignment.MiddleCenter
        radioButton20.Location = New Point(105, 135)
        radioButton20.Name = "radioButton20"
        radioButton20.Size = New Size(21, 24)
        radioButton20.TabIndex = 10
        radioButton20.UseVisualStyleBackColor = True
        ' 
        ' radioButton21
        ' 
        radioButton21.CheckAlign = ContentAlignment.MiddleCenter
        radioButton21.Location = New Point(35, 135)
        radioButton21.Name = "radioButton21"
        radioButton21.Size = New Size(21, 24)
        radioButton21.TabIndex = 12
        radioButton21.UseVisualStyleBackColor = True
        ' 
        ' radioButton22
        ' 
        radioButton22.CheckAlign = ContentAlignment.MiddleCenter
        radioButton22.Location = New Point(140, 135)
        radioButton22.Name = "radioButton22"
        radioButton22.Size = New Size(21, 24)
        radioButton22.TabIndex = 8
        radioButton22.UseVisualStyleBackColor = True
        ' 
        ' radioButton23
        ' 
        radioButton23.CheckAlign = ContentAlignment.MiddleCenter
        radioButton23.Location = New Point(0, 104)
        radioButton23.Name = "radioButton23"
        radioButton23.Size = New Size(21, 24)
        radioButton23.TabIndex = 14
        radioButton23.UseVisualStyleBackColor = True
        ' 
        ' radioButton24
        ' 
        radioButton24.CheckAlign = ContentAlignment.MiddleCenter
        radioButton24.Location = New Point(70, 135)
        radioButton24.Name = "radioButton24"
        radioButton24.Size = New Size(21, 24)
        radioButton24.TabIndex = 11
        radioButton24.UseVisualStyleBackColor = True
        ' 
        ' radioButton25
        ' 
        radioButton25.CheckAlign = ContentAlignment.MiddleCenter
        radioButton25.Location = New Point(0, 73)
        radioButton25.Name = "radioButton25"
        radioButton25.Size = New Size(21, 24)
        radioButton25.TabIndex = 15
        radioButton25.UseVisualStyleBackColor = True
        ' 
        ' radioButton26
        ' 
        radioButton26.CheckAlign = ContentAlignment.MiddleCenter
        radioButton26.Location = New Point(35, 11)
        radioButton26.Name = "radioButton26"
        radioButton26.Size = New Size(21, 24)
        radioButton26.TabIndex = 2
        radioButton26.UseVisualStyleBackColor = True
        ' 
        ' radioButton27
        ' 
        radioButton27.CheckAlign = ContentAlignment.MiddleCenter
        radioButton27.Location = New Point(70, 11)
        radioButton27.Name = "radioButton27"
        radioButton27.Size = New Size(21, 24)
        radioButton27.TabIndex = 3
        radioButton27.UseVisualStyleBackColor = True
        ' 
        ' radioButton28
        ' 
        radioButton28.CheckAlign = ContentAlignment.MiddleCenter
        radioButton28.Location = New Point(140, 11)
        radioButton28.Name = "radioButton28"
        radioButton28.Size = New Size(21, 24)
        radioButton28.TabIndex = 5
        radioButton28.UseVisualStyleBackColor = True
        ' 
        ' radioButton29
        ' 
        radioButton29.CheckAlign = ContentAlignment.MiddleCenter
        radioButton29.Location = New Point(105, 11)
        radioButton29.Name = "radioButton29"
        radioButton29.Size = New Size(21, 24)
        radioButton29.TabIndex = 4
        radioButton29.UseVisualStyleBackColor = True
        ' 
        ' radioButton30
        ' 
        radioButton30.CheckAlign = ContentAlignment.MiddleCenter
        radioButton30.Location = New Point(140, 73)
        radioButton30.Name = "radioButton30"
        radioButton30.Size = New Size(21, 24)
        radioButton30.TabIndex = 7
        radioButton30.UseVisualStyleBackColor = True
        ' 
        ' radioButton31
        ' 
        radioButton31.CheckAlign = ContentAlignment.MiddleCenter
        radioButton31.Location = New Point(0, 11)
        radioButton31.Name = "radioButton31"
        radioButton31.Size = New Size(21, 24)
        radioButton31.TabIndex = 1
        radioButton31.UseVisualStyleBackColor = True
        ' 
        ' radioButton32
        ' 
        radioButton32.CheckAlign = ContentAlignment.MiddleCenter
        radioButton32.Cursor = Cursors.Hand
        radioButton32.Location = New Point(57, 59)
        radioButton32.Name = "radioButton32"
        radioButton32.Size = New Size(48, 51)
        radioButton32.TabIndex = 0
        radioButton32.Text = "Manual"
        radioButton32.TextAlign = ContentAlignment.TopCenter
        radioButton32.UseVisualStyleBackColor = True
        ' 
        ' btnErrorTest
        ' 
        btnErrorTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnErrorTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnErrorTest.FlatAppearance.BorderSize = 0
        btnErrorTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnErrorTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnErrorTest.Image = My.Resources.Resources.imageError
        btnErrorTest.Location = New Point(547, 39)
        btnErrorTest.Name = "btnErrorTest"
        btnErrorTest.Size = New Size(24, 24)
        btnErrorTest.TabIndex = 0
        btnErrorTest.TabStop = False
        tipInfo.SetToolTip(btnErrorTest, "LeftClick = Test Error" & vbCrLf & "RightClick = Cause Exception")
        btnErrorTest.Visible = False
        ' 
        ' tipInfo
        ' 
        tipInfo.AutomaticDelay = 250
        tipInfo.AutoPopDelay = 10000
        tipInfo.InitialDelay = 250
        tipInfo.ReshowDelay = 50
        tipInfo.UseAnimation = False
        tipInfo.UseFading = False
        ' 
        ' btnInfo
        ' 
        btnInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInfo.Image = My.Resources.Resources.ImageInfo
        btnInfo.ImageAlign = ContentAlignment.TopLeft
        btnInfo.Location = New Point(144, 28)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(62, 46)
        btnInfo.TabIndex = 105
        btnInfo.Text = "Help"
        btnInfo.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnInfo, "Help & About")
        btnInfo.UseVisualStyleBackColor = True
        ' 
        ' btnlvPicFolders
        ' 
        btnlvPicFolders.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnlvPicFolders.FlatAppearance.BorderSize = 0
        btnlvPicFolders.Image = My.Resources.Resources.imageFolder
        btnlvPicFolders.ImageAlign = ContentAlignment.MiddleLeft
        btnlvPicFolders.Location = New Point(535, 98)
        btnlvPicFolders.Name = "btnlvPicFolders"
        btnlvPicFolders.Size = New Size(175, 32)
        btnlvPicFolders.TabIndex = 5
        btnlvPicFolders.TabStop = False
        btnlvPicFolders.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnlvPicFolders, "Folder List View Mode")
        btnlvPicFolders.UseMnemonic = False
        btnlvPicFolders.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshPicList
        ' 
        btnRefreshPicList.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefreshPicList.FlatAppearance.BorderColor = SystemColors.Highlight
        btnRefreshPicList.FlatAppearance.BorderSize = 0
        btnRefreshPicList.Image = My.Resources.Resources.imageRefresh
        btnRefreshPicList.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshPicList.Location = New Point(716, 98)
        btnRefreshPicList.Name = "btnRefreshPicList"
        btnRefreshPicList.Size = New Size(100, 32)
        btnRefreshPicList.TabIndex = 6
        btnRefreshPicList.TabStop = False
        btnRefreshPicList.Text = "Refresh"
        btnRefreshPicList.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnRefreshPicList, "LeftClick = Refresh Picture List (Ctrl = Reset)" & vbCrLf & "RightClick = Refresh All File Lists (Ctrl = Reset)")
        btnRefreshPicList.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicPlayModeLinearWithRandomStart
        ' 
        radbtnPicPlayModeLinearWithRandomStart.Location = New Point(84, 19)
        radbtnPicPlayModeLinearWithRandomStart.Name = "radbtnPicPlayModeLinearWithRandomStart"
        radbtnPicPlayModeLinearWithRandomStart.Size = New Size(74, 24)
        radbtnPicPlayModeLinearWithRandomStart.TabIndex = 1
        radbtnPicPlayModeLinearWithRandomStart.Text = "Linear +"
        tipInfo.SetToolTip(radbtnPicPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnPicPlayModeLinearWithRandomStart.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLog.Image = My.Resources.Resources.imageLog
        btnLog.ImageAlign = ContentAlignment.TopLeft
        btnLog.Location = New Point(205, 28)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(62, 46)
        btnLog.TabIndex = 106
        btnLog.Text = "Log"
        btnLog.TextAlign = ContentAlignment.BottomRight
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' PanelApp
        ' 
        PanelApp.Controls.Add(chbxHotKeys)
        PanelApp.Controls.Add(chbxSaveFileLists)
        PanelApp.Controls.Add(txbxInsideLocationOffset)
        PanelApp.Controls.Add(chbxLoadFileListsInBackground)
        PanelApp.Controls.Add(lblInsideLocationOffset)
        PanelApp.Controls.Add(chbxRefreshFileListsOnStartUp)
        PanelApp.Controls.Add(grbxActionOnScreenSave)
        PanelApp.Controls.Add(chbxHideCursorWhenFullscreen)
        PanelApp.Dock = DockStyle.Fill
        PanelApp.Location = New Point(91, 0)
        PanelApp.Name = "PanelApp"
        PanelApp.Size = New Size(826, 534)
        PanelApp.TabIndex = 107
        ' 
        ' PanelPics
        ' 
        PanelPics.Controls.Add(grbxHotKeysPics)
        PanelPics.Controls.Add(lvPicFolders)
        PanelPics.Controls.Add(gpbxPicTimerCountdownLocationMode)
        PanelPics.Controls.Add(chbxPicTimerCountdown)
        PanelPics.Controls.Add(txbxPicTimerInterval)
        PanelPics.Controls.Add(chbxPicAutoView)
        PanelPics.Controls.Add(gpbxPicJustify)
        PanelPics.Controls.Add(chbxPicLockFullScreen)
        PanelPics.Controls.Add(gpbxPicLocationMode)
        PanelPics.Controls.Add(lblPicFileCount)
        PanelPics.Controls.Add(btnPicTimerEnabled)
        PanelPics.Controls.Add(btnlvPicFolders)
        PanelPics.Controls.Add(gpbxPicPlayMode)
        PanelPics.Controls.Add(btnRefreshPicList)
        PanelPics.Controls.Add(label4)
        PanelPics.Controls.Add(chbxPicTimerAutoStart)
        PanelPics.Dock = DockStyle.Fill
        PanelPics.Location = New Point(91, 0)
        PanelPics.Name = "PanelPics"
        PanelPics.Size = New Size(826, 534)
        PanelPics.TabIndex = 108
        ' 
        ' grbxHotKeysPics
        ' 
        grbxHotKeysPics.Controls.Add(txbxHotKeyPicToggle)
        grbxHotKeysPics.Controls.Add(btnHotKeyPicToggleDisable)
        grbxHotKeysPics.Controls.Add(txbxHotKeyPicToggleFullScreen)
        grbxHotKeysPics.Controls.Add(btnHotKeyPicToggleFullScreenDisable)
        grbxHotKeysPics.Controls.Add(btnHotKeysPicsUndo)
        grbxHotKeysPics.Controls.Add(btnHotKeysPicsSet)
        grbxHotKeysPics.Controls.Add(txbxHotKeyPicShowFileInfo)
        grbxHotKeysPics.Controls.Add(btnHotKeyPicShowFileInfoDisable)
        grbxHotKeysPics.Controls.Add(lblHotKeyPicToggle)
        grbxHotKeysPics.Controls.Add(lblHotKeyPicToggleFullScreen)
        grbxHotKeysPics.Controls.Add(lblHotKeyPicShowFileInfo)
        grbxHotKeysPics.ForeColor = SystemColors.ControlText
        grbxHotKeysPics.Location = New Point(287, 256)
        grbxHotKeysPics.Name = "grbxHotKeysPics"
        grbxHotKeysPics.Size = New Size(181, 196)
        grbxHotKeysPics.TabIndex = 50
        grbxHotKeysPics.TabStop = False
        grbxHotKeysPics.Text = "HotKeys"
        ' 
        ' txbxHotKeyPicToggle
        ' 
        txbxHotKeyPicToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyPicToggle.Location = New Point(8, 39)
        txbxHotKeyPicToggle.Name = "txbxHotKeyPicToggle"
        txbxHotKeyPicToggle.ShortcutsEnabled = False
        txbxHotKeyPicToggle.Size = New Size(151, 29)
        txbxHotKeyPicToggle.TabIndex = 45
        txbxHotKeyPicToggle.TabStop = False
        txbxHotKeyPicToggle.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicToggle.WordWrap = False
        ' 
        ' btnHotKeyPicToggleDisable
        ' 
        btnHotKeyPicToggleDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyPicToggleDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicToggleDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyPicToggleDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyPicToggleDisable.Location = New Point(156, 43)
        btnHotKeyPicToggleDisable.Name = "btnHotKeyPicToggleDisable"
        btnHotKeyPicToggleDisable.Size = New Size(20, 17)
        btnHotKeyPicToggleDisable.TabIndex = 46
        btnHotKeyPicToggleDisable.TabStop = False
        btnHotKeyPicToggleDisable.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyPicToggleFullScreen
        ' 
        txbxHotKeyPicToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyPicToggleFullScreen.Location = New Point(8, 82)
        txbxHotKeyPicToggleFullScreen.Name = "txbxHotKeyPicToggleFullScreen"
        txbxHotKeyPicToggleFullScreen.ShortcutsEnabled = False
        txbxHotKeyPicToggleFullScreen.Size = New Size(151, 29)
        txbxHotKeyPicToggleFullScreen.TabIndex = 42
        txbxHotKeyPicToggleFullScreen.TabStop = False
        txbxHotKeyPicToggleFullScreen.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicToggleFullScreen.WordWrap = False
        ' 
        ' btnHotKeyPicToggleFullScreenDisable
        ' 
        btnHotKeyPicToggleFullScreenDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyPicToggleFullScreenDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicToggleFullScreenDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyPicToggleFullScreenDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyPicToggleFullScreenDisable.Location = New Point(156, 86)
        btnHotKeyPicToggleFullScreenDisable.Name = "btnHotKeyPicToggleFullScreenDisable"
        btnHotKeyPicToggleFullScreenDisable.Size = New Size(20, 17)
        btnHotKeyPicToggleFullScreenDisable.TabIndex = 43
        btnHotKeyPicToggleFullScreenDisable.TabStop = False
        btnHotKeyPicToggleFullScreenDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysPicsUndo
        ' 
        btnHotKeysPicsUndo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeysPicsUndo.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysPicsUndo.Location = New Point(7, 156)
        btnHotKeysPicsUndo.Name = "btnHotKeysPicsUndo"
        btnHotKeysPicsUndo.Size = New Size(83, 32)
        btnHotKeysPicsUndo.TabIndex = 30
        btnHotKeysPicsUndo.TabStop = False
        btnHotKeysPicsUndo.Text = "Undo"
        btnHotKeysPicsUndo.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysPicsUndo.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysPicsSet
        ' 
        btnHotKeysPicsSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeysPicsSet.Image = My.Resources.Resources.imageGo
        btnHotKeysPicsSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysPicsSet.Location = New Point(96, 156)
        btnHotKeysPicsSet.Name = "btnHotKeysPicsSet"
        btnHotKeysPicsSet.Size = New Size(63, 32)
        btnHotKeysPicsSet.TabIndex = 40
        btnHotKeysPicsSet.TabStop = False
        btnHotKeysPicsSet.Text = "Set"
        btnHotKeysPicsSet.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysPicsSet.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyPicShowFileInfo
        ' 
        txbxHotKeyPicShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txbxHotKeyPicShowFileInfo.Location = New Point(8, 125)
        txbxHotKeyPicShowFileInfo.Name = "txbxHotKeyPicShowFileInfo"
        txbxHotKeyPicShowFileInfo.ShortcutsEnabled = False
        txbxHotKeyPicShowFileInfo.Size = New Size(151, 29)
        txbxHotKeyPicShowFileInfo.TabIndex = 10
        txbxHotKeyPicShowFileInfo.TabStop = False
        txbxHotKeyPicShowFileInfo.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicShowFileInfo.WordWrap = False
        ' 
        ' btnHotKeyPicShowFileInfoDisable
        ' 
        btnHotKeyPicShowFileInfoDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyPicShowFileInfoDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicShowFileInfoDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyPicShowFileInfoDisable.Image = My.Resources.Resources.imageRemove
        btnHotKeyPicShowFileInfoDisable.Location = New Point(156, 129)
        btnHotKeyPicShowFileInfoDisable.Name = "btnHotKeyPicShowFileInfoDisable"
        btnHotKeyPicShowFileInfoDisable.Size = New Size(20, 17)
        btnHotKeyPicShowFileInfoDisable.TabIndex = 20
        btnHotKeyPicShowFileInfoDisable.TabStop = False
        btnHotKeyPicShowFileInfoDisable.UseVisualStyleBackColor = True
        ' 
        ' lblHotKeyPicToggle
        ' 
        lblHotKeyPicToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyPicToggle.BackColor = Color.Transparent
        lblHotKeyPicToggle.ForeColor = SystemColors.ControlText
        lblHotKeyPicToggle.Location = New Point(-20, 17)
        lblHotKeyPicToggle.Name = "lblHotKeyPicToggle"
        lblHotKeyPicToggle.Size = New Size(211, 23)
        lblHotKeyPicToggle.TabIndex = 44
        lblHotKeyPicToggle.Text = "PicToggle"
        lblHotKeyPicToggle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyPicToggleFullScreen
        ' 
        lblHotKeyPicToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyPicToggleFullScreen.BackColor = Color.Transparent
        lblHotKeyPicToggleFullScreen.ForeColor = SystemColors.ControlText
        lblHotKeyPicToggleFullScreen.Location = New Point(-20, 60)
        lblHotKeyPicToggleFullScreen.Name = "lblHotKeyPicToggleFullScreen"
        lblHotKeyPicToggleFullScreen.Size = New Size(211, 23)
        lblHotKeyPicToggleFullScreen.TabIndex = 41
        lblHotKeyPicToggleFullScreen.Text = "PicToggleFullScreen"
        lblHotKeyPicToggleFullScreen.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyPicShowFileInfo
        ' 
        lblHotKeyPicShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyPicShowFileInfo.BackColor = Color.Transparent
        lblHotKeyPicShowFileInfo.ForeColor = SystemColors.ControlText
        lblHotKeyPicShowFileInfo.Location = New Point(-20, 103)
        lblHotKeyPicShowFileInfo.Name = "lblHotKeyPicShowFileInfo"
        lblHotKeyPicShowFileInfo.Size = New Size(211, 23)
        lblHotKeyPicShowFileInfo.TabIndex = 0
        lblHotKeyPicShowFileInfo.Text = "PicShowFileInfo"
        lblHotKeyPicShowFileInfo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lvPicFolders
        ' 
        lvPicFolders.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lvPicFolders.BorderStyle = BorderStyle.FixedSingle
        lvPicFolders.ContextMenuStrip = cmList
        lvPicFolders.FullRowSelect = True
        lvPicFolders.HeaderStyle = ColumnHeaderStyle.None
        lvPicFolders.LabelWrap = False
        lvPicFolders.Location = New Point(7, 14)
        lvPicFolders.MultiSelect = False
        lvPicFolders.Name = "lvPicFolders"
        lvPicFolders.ShowGroups = False
        lvPicFolders.Size = New Size(808, 86)
        lvPicFolders.TabIndex = 1
        lvPicFolders.TabStop = False
        lvPicFolders.UseCompatibleStateImageBehavior = False
        lvPicFolders.View = View.Details
        ' 
        ' gpbxPicTimerCountdownLocationMode
        ' 
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeLeftCenterTop)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeBottomLeft)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeRightCenterTop)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeRightCenterBottom)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeBottomCenterRight)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeBottomCenterLeft)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeBottomRight)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeLeftCenterBottom)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeBottomCenter)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeLeftCenter)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeTopCenterLeft)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeTopCenter)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeTopRight)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeTopCenterRight)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeRightCenter)
        gpbxPicTimerCountdownLocationMode.Controls.Add(radbtnPicTimerCountdownLocationModeTopLeft)
        gpbxPicTimerCountdownLocationMode.Location = New Point(553, 308)
        gpbxPicTimerCountdownLocationMode.Name = "gpbxPicTimerCountdownLocationMode"
        gpbxPicTimerCountdownLocationMode.Size = New Size(133, 144)
        gpbxPicTimerCountdownLocationMode.TabIndex = 80
        gpbxPicTimerCountdownLocationMode.TabStop = False
        gpbxPicTimerCountdownLocationMode.Text = "Timer Location"
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenterTop
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Location = New Point(5, 45)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Name = "radbtnPicTimerCountdownLocationModeLeftCenterTop"
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.TabIndex = 16
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomLeft
        ' 
        radbtnPicTimerCountdownLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeBottomLeft.Location = New Point(5, 123)
        radbtnPicTimerCountdownLocationModeBottomLeft.Name = "radbtnPicTimerCountdownLocationModeBottomLeft"
        radbtnPicTimerCountdownLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomLeft.TabIndex = 13
        radbtnPicTimerCountdownLocationModeBottomLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenterTop
        ' 
        radbtnPicTimerCountdownLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeRightCenterTop.Location = New Point(113, 45)
        radbtnPicTimerCountdownLocationModeRightCenterTop.Name = "radbtnPicTimerCountdownLocationModeRightCenterTop"
        radbtnPicTimerCountdownLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenterTop.TabIndex = 6
        radbtnPicTimerCountdownLocationModeRightCenterTop.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenterBottom
        ' 
        radbtnPicTimerCountdownLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Location = New Point(113, 97)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Name = "radbtnPicTimerCountdownLocationModeRightCenterBottom"
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.TabIndex = 8
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenterRight
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Location = New Point(86, 123)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Name = "radbtnPicTimerCountdownLocationModeBottomCenterRight"
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.TabIndex = 10
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenterLeft
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Location = New Point(32, 123)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Name = "radbtnPicTimerCountdownLocationModeBottomCenterLeft"
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.TabIndex = 12
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomRight
        ' 
        radbtnPicTimerCountdownLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeBottomRight.Location = New Point(113, 123)
        radbtnPicTimerCountdownLocationModeBottomRight.Name = "radbtnPicTimerCountdownLocationModeBottomRight"
        radbtnPicTimerCountdownLocationModeBottomRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomRight.TabIndex = 8
        radbtnPicTimerCountdownLocationModeBottomRight.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenterBottom
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Location = New Point(5, 97)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Name = "radbtnPicTimerCountdownLocationModeLeftCenterBottom"
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.TabIndex = 14
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenter
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeBottomCenter.Location = New Point(59, 123)
        radbtnPicTimerCountdownLocationModeBottomCenter.Name = "radbtnPicTimerCountdownLocationModeBottomCenter"
        radbtnPicTimerCountdownLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenter.TabIndex = 11
        radbtnPicTimerCountdownLocationModeBottomCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenter
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeLeftCenter.Location = New Point(5, 71)
        radbtnPicTimerCountdownLocationModeLeftCenter.Name = "radbtnPicTimerCountdownLocationModeLeftCenter"
        radbtnPicTimerCountdownLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenter.TabIndex = 15
        radbtnPicTimerCountdownLocationModeLeftCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenterLeft
        ' 
        radbtnPicTimerCountdownLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Location = New Point(32, 19)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Name = "radbtnPicTimerCountdownLocationModeTopCenterLeft"
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.TabIndex = 2
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenter
        ' 
        radbtnPicTimerCountdownLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeTopCenter.Location = New Point(59, 19)
        radbtnPicTimerCountdownLocationModeTopCenter.Name = "radbtnPicTimerCountdownLocationModeTopCenter"
        radbtnPicTimerCountdownLocationModeTopCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenter.TabIndex = 3
        radbtnPicTimerCountdownLocationModeTopCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopRight
        ' 
        radbtnPicTimerCountdownLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeTopRight.Location = New Point(113, 19)
        radbtnPicTimerCountdownLocationModeTopRight.Name = "radbtnPicTimerCountdownLocationModeTopRight"
        radbtnPicTimerCountdownLocationModeTopRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopRight.TabIndex = 5
        radbtnPicTimerCountdownLocationModeTopRight.Text = "  "
        radbtnPicTimerCountdownLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenterRight
        ' 
        radbtnPicTimerCountdownLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeTopCenterRight.Location = New Point(86, 19)
        radbtnPicTimerCountdownLocationModeTopCenterRight.Name = "radbtnPicTimerCountdownLocationModeTopCenterRight"
        radbtnPicTimerCountdownLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenterRight.TabIndex = 4
        radbtnPicTimerCountdownLocationModeTopCenterRight.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenter
        ' 
        radbtnPicTimerCountdownLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeRightCenter.Location = New Point(113, 71)
        radbtnPicTimerCountdownLocationModeRightCenter.Name = "radbtnPicTimerCountdownLocationModeRightCenter"
        radbtnPicTimerCountdownLocationModeRightCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenter.TabIndex = 7
        radbtnPicTimerCountdownLocationModeRightCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopLeft
        ' 
        radbtnPicTimerCountdownLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicTimerCountdownLocationModeTopLeft.Location = New Point(5, 19)
        radbtnPicTimerCountdownLocationModeTopLeft.Name = "radbtnPicTimerCountdownLocationModeTopLeft"
        radbtnPicTimerCountdownLocationModeTopLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopLeft.TabIndex = 1
        radbtnPicTimerCountdownLocationModeTopLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' chbxPicTimerCountdown
        ' 
        chbxPicTimerCountdown.Location = New Point(553, 291)
        chbxPicTimerCountdown.Name = "chbxPicTimerCountdown"
        chbxPicTimerCountdown.Size = New Size(165, 21)
        chbxPicTimerCountdown.TabIndex = 75
        chbxPicTimerCountdown.Text = "Show Timer Countdown"
        chbxPicTimerCountdown.UseVisualStyleBackColor = True
        ' 
        ' txbxPicTimerInterval
        ' 
        txbxPicTimerInterval.Location = New Point(553, 264)
        txbxPicTimerInterval.MaxLength = 5
        txbxPicTimerInterval.Name = "txbxPicTimerInterval"
        txbxPicTimerInterval.Size = New Size(80, 29)
        txbxPicTimerInterval.TabIndex = 70
        txbxPicTimerInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' chbxPicAutoView
        ' 
        chbxPicAutoView.CheckAlign = ContentAlignment.MiddleRight
        chbxPicAutoView.Location = New Point(668, 136)
        chbxPicAutoView.Name = "chbxPicAutoView"
        chbxPicAutoView.Size = New Size(81, 22)
        chbxPicAutoView.TabIndex = 30
        chbxPicAutoView.Text = "AutoView"
        chbxPicAutoView.UseVisualStyleBackColor = True
        ' 
        ' gpbxPicJustify
        ' 
        gpbxPicJustify.Controls.Add(radbtnPicJustifyCenter)
        gpbxPicJustify.Controls.Add(radbtnPicJustifyLeft)
        gpbxPicJustify.Controls.Add(radbtnPicJustifyRight)
        gpbxPicJustify.Location = New Point(261, 140)
        gpbxPicJustify.Name = "gpbxPicJustify"
        gpbxPicJustify.Size = New Size(150, 47)
        gpbxPicJustify.TabIndex = 20
        gpbxPicJustify.TabStop = False
        gpbxPicJustify.Text = "FullScreen Justify"
        ' 
        ' radbtnPicJustifyCenter
        ' 
        radbtnPicJustifyCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicJustifyCenter.Location = New Point(59, 19)
        radbtnPicJustifyCenter.Name = "radbtnPicJustifyCenter"
        radbtnPicJustifyCenter.Size = New Size(24, 24)
        radbtnPicJustifyCenter.TabIndex = 3
        radbtnPicJustifyCenter.Text = "  "
        radbtnPicJustifyCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnPicJustifyCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicJustifyLeft
        ' 
        radbtnPicJustifyLeft.Location = New Point(7, 19)
        radbtnPicJustifyLeft.Name = "radbtnPicJustifyLeft"
        radbtnPicJustifyLeft.Size = New Size(47, 24)
        radbtnPicJustifyLeft.TabIndex = 1
        radbtnPicJustifyLeft.Text = "Left"
        radbtnPicJustifyLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicJustifyRight
        ' 
        radbtnPicJustifyRight.CheckAlign = ContentAlignment.MiddleRight
        radbtnPicJustifyRight.Location = New Point(87, 19)
        radbtnPicJustifyRight.Name = "radbtnPicJustifyRight"
        radbtnPicJustifyRight.Size = New Size(56, 24)
        radbtnPicJustifyRight.TabIndex = 5
        radbtnPicJustifyRight.Text = "Right"
        radbtnPicJustifyRight.TextAlign = ContentAlignment.MiddleRight
        radbtnPicJustifyRight.UseVisualStyleBackColor = True
        ' 
        ' chbxPicLockFullScreen
        ' 
        chbxPicLockFullScreen.CheckAlign = ContentAlignment.MiddleRight
        chbxPicLockFullScreen.Location = New Point(266, 183)
        chbxPicLockFullScreen.Name = "chbxPicLockFullScreen"
        chbxPicLockFullScreen.Size = New Size(119, 22)
        chbxPicLockFullScreen.TabIndex = 25
        chbxPicLockFullScreen.Text = "Lock Full Screen"
        chbxPicLockFullScreen.UseVisualStyleBackColor = True
        ' 
        ' gpbxPicLocationMode
        ' 
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopLeftInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomLeftInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomRightInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopRightInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenterTop)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomLeft)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenterBottomInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenterInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenterTopInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenterInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenterInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenterLeftInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenterTop)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenterBottom)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenterRight)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeManual)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenterLeft)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomRight)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenterBottom)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenterRightInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeBottomCenter)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenterBottomInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeLeftCenter)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenterRightInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenterTopInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenterInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenterLeft)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenter)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopRight)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenterRight)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeRightCenter)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopCenterLeftInside)
        gpbxPicLocationMode.Controls.Add(radbtnPicLocationModeTopLeft)
        gpbxPicLocationMode.Location = New Point(7, 242)
        gpbxPicLocationMode.Name = "gpbxPicLocationMode"
        gpbxPicLocationMode.Size = New Size(195, 210)
        gpbxPicLocationMode.TabIndex = 40
        gpbxPicLocationMode.TabStop = False
        gpbxPicLocationMode.Text = "Image Location"
        ' 
        ' radbtnPicLocationModeTopLeftInside
        ' 
        radbtnPicLocationModeTopLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopLeftInside.Location = New Point(34, 48)
        radbtnPicLocationModeTopLeftInside.Name = "radbtnPicLocationModeTopLeftInside"
        radbtnPicLocationModeTopLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopLeftInside.TabIndex = 91
        radbtnPicLocationModeTopLeftInside.Text = "  "
        radbtnPicLocationModeTopLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomLeftInside
        ' 
        radbtnPicLocationModeBottomLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomLeftInside.Location = New Point(34, 160)
        radbtnPicLocationModeBottomLeftInside.Name = "radbtnPicLocationModeBottomLeftInside"
        radbtnPicLocationModeBottomLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomLeftInside.TabIndex = 92
        radbtnPicLocationModeBottomLeftInside.Text = "  "
        radbtnPicLocationModeBottomLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomRightInside
        ' 
        radbtnPicLocationModeBottomRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomRightInside.Location = New Point(146, 160)
        radbtnPicLocationModeBottomRightInside.Name = "radbtnPicLocationModeBottomRightInside"
        radbtnPicLocationModeBottomRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomRightInside.TabIndex = 93
        radbtnPicLocationModeBottomRightInside.Text = "  "
        radbtnPicLocationModeBottomRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopRightInside
        ' 
        radbtnPicLocationModeTopRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopRightInside.Location = New Point(146, 48)
        radbtnPicLocationModeTopRightInside.Name = "radbtnPicLocationModeTopRightInside"
        radbtnPicLocationModeTopRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopRightInside.TabIndex = 96
        radbtnPicLocationModeTopRightInside.Text = "  "
        radbtnPicLocationModeTopRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterTop
        ' 
        radbtnPicLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenterTop.Location = New Point(6, 62)
        radbtnPicLocationModeLeftCenterTop.Name = "radbtnPicLocationModeLeftCenterTop"
        radbtnPicLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterTop.TabIndex = 16
        radbtnPicLocationModeLeftCenterTop.Text = "  "
        radbtnPicLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomLeft
        ' 
        radbtnPicLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomLeft.Location = New Point(6, 188)
        radbtnPicLocationModeBottomLeft.Name = "radbtnPicLocationModeBottomLeft"
        radbtnPicLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnPicLocationModeBottomLeft.TabIndex = 13
        radbtnPicLocationModeBottomLeft.Text = "  "
        radbtnPicLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterBottomInside
        ' 
        radbtnPicLocationModeLeftCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenterBottomInside.Location = New Point(34, 132)
        radbtnPicLocationModeLeftCenterBottomInside.Name = "radbtnPicLocationModeLeftCenterBottomInside"
        radbtnPicLocationModeLeftCenterBottomInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterBottomInside.TabIndex = 90
        radbtnPicLocationModeLeftCenterBottomInside.Text = "  "
        radbtnPicLocationModeLeftCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterInside
        ' 
        radbtnPicLocationModeLeftCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenterInside.Location = New Point(34, 104)
        radbtnPicLocationModeLeftCenterInside.Name = "radbtnPicLocationModeLeftCenterInside"
        radbtnPicLocationModeLeftCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterInside.TabIndex = 94
        radbtnPicLocationModeLeftCenterInside.Text = "  "
        radbtnPicLocationModeLeftCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterTopInside
        ' 
        radbtnPicLocationModeLeftCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenterTopInside.Location = New Point(34, 76)
        radbtnPicLocationModeLeftCenterTopInside.Name = "radbtnPicLocationModeLeftCenterTopInside"
        radbtnPicLocationModeLeftCenterTopInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterTopInside.TabIndex = 95
        radbtnPicLocationModeLeftCenterTopInside.Text = "  "
        radbtnPicLocationModeLeftCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterInside
        ' 
        radbtnPicLocationModeBottomCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenterInside.Location = New Point(90, 160)
        radbtnPicLocationModeBottomCenterInside.Name = "radbtnPicLocationModeBottomCenterInside"
        radbtnPicLocationModeBottomCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterInside.TabIndex = 88
        radbtnPicLocationModeBottomCenterInside.Text = "  "
        radbtnPicLocationModeBottomCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterInside
        ' 
        radbtnPicLocationModeRightCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenterInside.Location = New Point(146, 104)
        radbtnPicLocationModeRightCenterInside.Name = "radbtnPicLocationModeRightCenterInside"
        radbtnPicLocationModeRightCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterInside.TabIndex = 86
        radbtnPicLocationModeRightCenterInside.Text = "  "
        radbtnPicLocationModeRightCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterLeftInside
        ' 
        radbtnPicLocationModeBottomCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenterLeftInside.Location = New Point(62, 160)
        radbtnPicLocationModeBottomCenterLeftInside.Name = "radbtnPicLocationModeBottomCenterLeftInside"
        radbtnPicLocationModeBottomCenterLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterLeftInside.TabIndex = 89
        radbtnPicLocationModeBottomCenterLeftInside.Text = "  "
        radbtnPicLocationModeBottomCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterTop
        ' 
        radbtnPicLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenterTop.Location = New Point(174, 62)
        radbtnPicLocationModeRightCenterTop.Name = "radbtnPicLocationModeRightCenterTop"
        radbtnPicLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterTop.TabIndex = 6
        radbtnPicLocationModeRightCenterTop.Text = "  "
        radbtnPicLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterBottom
        ' 
        radbtnPicLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenterBottom.Location = New Point(174, 146)
        radbtnPicLocationModeRightCenterBottom.Name = "radbtnPicLocationModeRightCenterBottom"
        radbtnPicLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterBottom.TabIndex = 8
        radbtnPicLocationModeRightCenterBottom.Text = "  "
        radbtnPicLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterRight
        ' 
        radbtnPicLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenterRight.Location = New Point(132, 188)
        radbtnPicLocationModeBottomCenterRight.Name = "radbtnPicLocationModeBottomCenterRight"
        radbtnPicLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterRight.TabIndex = 10
        radbtnPicLocationModeBottomCenterRight.Text = "  "
        radbtnPicLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeManual
        ' 
        radbtnPicLocationModeManual.CheckAlign = ContentAlignment.BottomCenter
        radbtnPicLocationModeManual.Location = New Point(69, 78)
        radbtnPicLocationModeManual.Name = "radbtnPicLocationModeManual"
        radbtnPicLocationModeManual.Size = New Size(57, 40)
        radbtnPicLocationModeManual.TabIndex = 0
        radbtnPicLocationModeManual.Text = "Manual"
        radbtnPicLocationModeManual.TextAlign = ContentAlignment.TopCenter
        radbtnPicLocationModeManual.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterLeft
        ' 
        radbtnPicLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenterLeft.Location = New Point(48, 188)
        radbtnPicLocationModeBottomCenterLeft.Name = "radbtnPicLocationModeBottomCenterLeft"
        radbtnPicLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterLeft.TabIndex = 12
        radbtnPicLocationModeBottomCenterLeft.Text = "  "
        radbtnPicLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomRight
        ' 
        radbtnPicLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomRight.Location = New Point(174, 188)
        radbtnPicLocationModeBottomRight.Name = "radbtnPicLocationModeBottomRight"
        radbtnPicLocationModeBottomRight.Size = New Size(16, 16)
        radbtnPicLocationModeBottomRight.TabIndex = 8
        radbtnPicLocationModeBottomRight.Text = "  "
        radbtnPicLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterBottom
        ' 
        radbtnPicLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenterBottom.Location = New Point(6, 146)
        radbtnPicLocationModeLeftCenterBottom.Name = "radbtnPicLocationModeLeftCenterBottom"
        radbtnPicLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterBottom.TabIndex = 14
        radbtnPicLocationModeLeftCenterBottom.Text = "  "
        radbtnPicLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterRightInside
        ' 
        radbtnPicLocationModeBottomCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenterRightInside.Location = New Point(118, 160)
        radbtnPicLocationModeBottomCenterRightInside.Name = "radbtnPicLocationModeBottomCenterRightInside"
        radbtnPicLocationModeBottomCenterRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterRightInside.TabIndex = 85
        radbtnPicLocationModeBottomCenterRightInside.Text = "  "
        radbtnPicLocationModeBottomCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenter
        ' 
        radbtnPicLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeBottomCenter.Location = New Point(90, 188)
        radbtnPicLocationModeBottomCenter.Name = "radbtnPicLocationModeBottomCenter"
        radbtnPicLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenter.TabIndex = 11
        radbtnPicLocationModeBottomCenter.Text = "  "
        radbtnPicLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterBottomInside
        ' 
        radbtnPicLocationModeRightCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenterBottomInside.Location = New Point(146, 132)
        radbtnPicLocationModeRightCenterBottomInside.Name = "radbtnPicLocationModeRightCenterBottomInside"
        radbtnPicLocationModeRightCenterBottomInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterBottomInside.TabIndex = 87
        radbtnPicLocationModeRightCenterBottomInside.Text = "  "
        radbtnPicLocationModeRightCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenter
        ' 
        radbtnPicLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeLeftCenter.Location = New Point(6, 104)
        radbtnPicLocationModeLeftCenter.Name = "radbtnPicLocationModeLeftCenter"
        radbtnPicLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenter.TabIndex = 15
        radbtnPicLocationModeLeftCenter.Text = "  "
        radbtnPicLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterRightInside
        ' 
        radbtnPicLocationModeTopCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenterRightInside.Location = New Point(118, 48)
        radbtnPicLocationModeTopCenterRightInside.Name = "radbtnPicLocationModeTopCenterRightInside"
        radbtnPicLocationModeTopCenterRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterRightInside.TabIndex = 83
        radbtnPicLocationModeTopCenterRightInside.Text = "  "
        radbtnPicLocationModeTopCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterTopInside
        ' 
        radbtnPicLocationModeRightCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenterTopInside.Location = New Point(146, 76)
        radbtnPicLocationModeRightCenterTopInside.Name = "radbtnPicLocationModeRightCenterTopInside"
        radbtnPicLocationModeRightCenterTopInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterTopInside.TabIndex = 84
        radbtnPicLocationModeRightCenterTopInside.Text = "  "
        radbtnPicLocationModeRightCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterInside
        ' 
        radbtnPicLocationModeTopCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenterInside.Location = New Point(90, 48)
        radbtnPicLocationModeTopCenterInside.Name = "radbtnPicLocationModeTopCenterInside"
        radbtnPicLocationModeTopCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterInside.TabIndex = 82
        radbtnPicLocationModeTopCenterInside.Text = "  "
        radbtnPicLocationModeTopCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterLeft
        ' 
        radbtnPicLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenterLeft.Location = New Point(48, 20)
        radbtnPicLocationModeTopCenterLeft.Name = "radbtnPicLocationModeTopCenterLeft"
        radbtnPicLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterLeft.TabIndex = 2
        radbtnPicLocationModeTopCenterLeft.Text = "  "
        radbtnPicLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenter
        ' 
        radbtnPicLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenter.Location = New Point(90, 20)
        radbtnPicLocationModeTopCenter.Name = "radbtnPicLocationModeTopCenter"
        radbtnPicLocationModeTopCenter.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenter.TabIndex = 3
        radbtnPicLocationModeTopCenter.Text = "  "
        radbtnPicLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopRight
        ' 
        radbtnPicLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopRight.Location = New Point(174, 20)
        radbtnPicLocationModeTopRight.Name = "radbtnPicLocationModeTopRight"
        radbtnPicLocationModeTopRight.Size = New Size(16, 16)
        radbtnPicLocationModeTopRight.TabIndex = 5
        radbtnPicLocationModeTopRight.Text = "  "
        radbtnPicLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterRight
        ' 
        radbtnPicLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenterRight.Location = New Point(132, 20)
        radbtnPicLocationModeTopCenterRight.Name = "radbtnPicLocationModeTopCenterRight"
        radbtnPicLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterRight.TabIndex = 4
        radbtnPicLocationModeTopCenterRight.Text = "  "
        radbtnPicLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenter
        ' 
        radbtnPicLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeRightCenter.Location = New Point(174, 104)
        radbtnPicLocationModeRightCenter.Name = "radbtnPicLocationModeRightCenter"
        radbtnPicLocationModeRightCenter.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenter.TabIndex = 7
        radbtnPicLocationModeRightCenter.Text = "  "
        radbtnPicLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterLeftInside
        ' 
        radbtnPicLocationModeTopCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopCenterLeftInside.Location = New Point(62, 48)
        radbtnPicLocationModeTopCenterLeftInside.Name = "radbtnPicLocationModeTopCenterLeftInside"
        radbtnPicLocationModeTopCenterLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterLeftInside.TabIndex = 81
        radbtnPicLocationModeTopCenterLeftInside.Text = "  "
        radbtnPicLocationModeTopCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopLeft
        ' 
        radbtnPicLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        radbtnPicLocationModeTopLeft.Location = New Point(6, 20)
        radbtnPicLocationModeTopLeft.Name = "radbtnPicLocationModeTopLeft"
        radbtnPicLocationModeTopLeft.Size = New Size(16, 16)
        radbtnPicLocationModeTopLeft.TabIndex = 1
        radbtnPicLocationModeTopLeft.Text = "  "
        radbtnPicLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' lblPicFileCount
        ' 
        lblPicFileCount.Location = New Point(8, 100)
        lblPicFileCount.Name = "lblPicFileCount"
        lblPicFileCount.Size = New Size(254, 22)
        lblPicFileCount.TabIndex = 0
        ' 
        ' btnPicTimerEnabled
        ' 
        btnPicTimerEnabled.FlatStyle = FlatStyle.Flat
        btnPicTimerEnabled.Location = New Point(553, 213)
        btnPicTimerEnabled.Margin = New Padding(3, 4, 3, 4)
        btnPicTimerEnabled.Name = "btnPicTimerEnabled"
        btnPicTimerEnabled.Size = New Size(80, 31)
        btnPicTimerEnabled.TabIndex = 60
        btnPicTimerEnabled.TabStop = False
        btnPicTimerEnabled.Text = "Timer"
        btnPicTimerEnabled.UseVisualStyleBackColor = True
        ' 
        ' gpbxPicPlayMode
        ' 
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeLinearWithRandomStart)
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeRandom)
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeLinear)
        gpbxPicPlayMode.Location = New Point(7, 140)
        gpbxPicPlayMode.Name = "gpbxPicPlayMode"
        gpbxPicPlayMode.Size = New Size(248, 47)
        gpbxPicPlayMode.TabIndex = 10
        gpbxPicPlayMode.TabStop = False
        gpbxPicPlayMode.Text = "Picture Advance Mode"
        ' 
        ' radbtnPicPlayModeRandom
        ' 
        radbtnPicPlayModeRandom.Location = New Point(172, 19)
        radbtnPicPlayModeRandom.Name = "radbtnPicPlayModeRandom"
        radbtnPicPlayModeRandom.Size = New Size(75, 24)
        radbtnPicPlayModeRandom.TabIndex = 2
        radbtnPicPlayModeRandom.Text = "Random"
        radbtnPicPlayModeRandom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicPlayModeLinear
        ' 
        radbtnPicPlayModeLinear.Location = New Point(7, 19)
        radbtnPicPlayModeLinear.Name = "radbtnPicPlayModeLinear"
        radbtnPicPlayModeLinear.Size = New Size(61, 24)
        radbtnPicPlayModeLinear.TabIndex = 0
        radbtnPicPlayModeLinear.Text = "Linear"
        radbtnPicPlayModeLinear.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.Location = New Point(554, 245)
        label4.Name = "label4"
        label4.Size = New Size(80, 22)
        label4.TabIndex = 21
        label4.Text = "Interval (s)"
        label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' chbxPicTimerAutoStart
        ' 
        chbxPicTimerAutoStart.Location = New Point(639, 218)
        chbxPicTimerAutoStart.Margin = New Padding(3, 4, 3, 4)
        chbxPicTimerAutoStart.Name = "chbxPicTimerAutoStart"
        chbxPicTimerAutoStart.Size = New Size(118, 22)
        chbxPicTimerAutoStart.TabIndex = 65
        chbxPicTimerAutoStart.Text = "AutoStart Timer"
        chbxPicTimerAutoStart.TextAlign = ContentAlignment.MiddleCenter
        chbxPicTimerAutoStart.UseVisualStyleBackColor = True
        ' 
        ' PanelVids
        ' 
        PanelVids.Controls.Add(chbkVidMute)
        PanelVids.Controls.Add(lvVidFolders)
        PanelVids.Controls.Add(grbxHotKeysVids)
        PanelVids.Controls.Add(grbxVidTimeLocationMode)
        PanelVids.Controls.Add(cobxVidTimeDisplayMode)
        PanelVids.Controls.Add(btnRefreshVidList)
        PanelVids.Controls.Add(btnlvVidFolders)
        PanelVids.Controls.Add(chbxVidLockFullScreen)
        PanelVids.Controls.Add(lblVidFileCount)
        PanelVids.Controls.Add(chbxVidAutoView)
        PanelVids.Controls.Add(chbxVidTime)
        PanelVids.Controls.Add(gpbxVidScale)
        PanelVids.Controls.Add(gpbxVidPlayMode)
        PanelVids.Controls.Add(gpbxVidLocationMode)
        PanelVids.Dock = DockStyle.Fill
        PanelVids.Location = New Point(91, 0)
        PanelVids.Name = "PanelVids"
        PanelVids.Size = New Size(826, 534)
        PanelVids.TabIndex = 109
        ' 
        ' PanelActions
        ' 
        PanelActions.Controls.Add(btnClose)
        PanelActions.Controls.Add(btnRestoreSettings)
        PanelActions.Controls.Add(btnSaveSettings)
        PanelActions.Controls.Add(btnErrorTest)
        PanelActions.Controls.Add(btnInfo)
        PanelActions.Controls.Add(btnLog)
        PanelActions.Dock = DockStyle.Bottom
        PanelActions.Location = New Point(0, 534)
        PanelActions.Name = "PanelActions"
        PanelActions.Size = New Size(917, 96)
        PanelActions.TabIndex = 110
        ' 
        ' PanelPageSelector
        ' 
        PanelPageSelector.Controls.Add(LVPageSelector)
        PanelPageSelector.Dock = DockStyle.Left
        PanelPageSelector.Location = New Point(0, 0)
        PanelPageSelector.Name = "PanelPageSelector"
        PanelPageSelector.Size = New Size(91, 534)
        PanelPageSelector.TabIndex = 111
        ' 
        ' LVPageSelector
        ' 
        LVPageSelector.AutoArrange = False
        LVPageSelector.BackColor = SystemColors.Control
        LVPageSelector.BorderStyle = BorderStyle.None
        LVPageSelector.Dock = DockStyle.Fill
        LVPageSelector.EditableColumns = CType(resources.GetObject("LVPageSelector.EditableColumns"), List(Of Boolean))
        LVPageSelector.HeaderStyle = ColumnHeaderStyle.None
        LVPageSelector.InsertionLineColor = Color.Teal
        LVPageSelector.LargeImageList = ILPageSelector
        LVPageSelector.Location = New Point(0, 0)
        LVPageSelector.MultiSelect = False
        LVPageSelector.Name = "LVPageSelector"
        LVPageSelector.Scrollable = False
        LVPageSelector.ShowGroups = False
        LVPageSelector.Size = New Size(91, 534)
        LVPageSelector.TabIndex = 0
        LVPageSelector.TabStop = False
        LVPageSelector.UseCompatibleStateImageBehavior = False
        ' 
        ' ILPageSelector
        ' 
        ILPageSelector.ColorDepth = ColorDepth.Depth32Bit
        ILPageSelector.ImageSize = New Size(48, 48)
        ILPageSelector.TransparentColor = Color.Transparent
        ' 
        ' MainForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(917, 630)
        Controls.Add(PanelApp)
        Controls.Add(PanelPics)
        Controls.Add(PanelVids)
        Controls.Add(PanelPageSelector)
        Controls.Add(PanelActions)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.IconApp
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "MainForm"
        Opacity = 0R
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        cmSkyeShow.ResumeLayout(False)
        cmList.ResumeLayout(False)
        grbxActionOnScreenSave.ResumeLayout(False)
        grbxHotKeysVids.ResumeLayout(False)
        grbxHotKeysVids.PerformLayout()
        gpbxVidScale.ResumeLayout(False)
        gpbxVidLocationMode.ResumeLayout(False)
        gpbxVidPlayMode.ResumeLayout(False)
        grbxVidTimeLocationMode.ResumeLayout(False)
        PanelApp.ResumeLayout(False)
        PanelApp.PerformLayout()
        PanelPics.ResumeLayout(False)
        PanelPics.PerformLayout()
        grbxHotKeysPics.ResumeLayout(False)
        grbxHotKeysPics.PerformLayout()
        gpbxPicTimerCountdownLocationMode.ResumeLayout(False)
        gpbxPicJustify.ResumeLayout(False)
        gpbxPicLocationMode.ResumeLayout(False)
        gpbxPicPlayMode.ResumeLayout(False)
        PanelVids.ResumeLayout(False)
        PanelActions.ResumeLayout(False)
        PanelPageSelector.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private WithEvents btnHotKeysVidsUndo As System.Windows.Forms.Button
    Private WithEvents btnHotKeysVidsSet As System.Windows.Forms.Button
    Private WithEvents btnHotKeyVidToggleDisable As System.Windows.Forms.Button
    Private WithEvents btnHotKeyVidToggleFullScreenDisable As System.Windows.Forms.Button
    Private WithEvents btnHotKeyVidShowFileInfoDisable As System.Windows.Forms.Button
    Private WithEvents txbxHotKeyVidToggle As System.Windows.Forms.TextBox
    Private WithEvents txbxHotKeyVidToggleFullScreen As System.Windows.Forms.TextBox
    Private WithEvents txbxHotKeyVidShowFileInfo As System.Windows.Forms.TextBox
	Private lblHotKeyVidToggle As System.Windows.Forms.Label
	Private lblHotKeyVidToggleFullScreen As System.Windows.Forms.Label
	Private lblHotKeyVidShowFileInfo As System.Windows.Forms.Label
	Private grbxHotKeysVids As System.Windows.Forms.GroupBox
    Private WithEvents chbxHotKeys As System.Windows.Forms.CheckBox
    Private WithEvents cobxVidTimeDisplayMode As System.Windows.Forms.ComboBox
    Private grbxVidTimeLocationMode As System.Windows.Forms.GroupBox
    Private WithEvents radbtnVidTimeLocationModeRightCenterTop As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeRightCenterBottom As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeBottomCenterRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeBottomRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeTopCenterLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeTopCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeTopRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeTopCenterRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeRightCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeTopLeft As System.Windows.Forms.RadioButton
    Private WithEvents chbxVidTime As System.Windows.Forms.CheckBox
    Private WithEvents radbtnVidTimeLocationModeLeftCenterTop As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeBottomLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeBottomCenterLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeLeftCenterBottom As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeBottomCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidTimeLocationModeLeftCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenterTopInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenterInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenterLeftInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenterInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenterTopInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenterRightInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenterBottomInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenterRightInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenterLeftInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenterInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenterInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenterBottomInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopRightInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomRightInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomLeftInside As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopLeftInside As System.Windows.Forms.RadioButton
    Private gpbxVidLocationMode As System.Windows.Forms.GroupBox
    Private WithEvents radbtnVidLocationModeManual As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenterRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeTopCenterLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenter As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenterBottom As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenterLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomCenterRight As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenterBottom As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeRightCenterTop As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeBottomLeft As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidLocationModeLeftCenterTop As System.Windows.Forms.RadioButton
    Private gpbxVidScale As System.Windows.Forms.GroupBox
    Private WithEvents chbxVidAutoView As System.Windows.Forms.CheckBox
    Private WithEvents chbxVidLockFullScreen As System.Windows.Forms.CheckBox
    Private gpbxVidPlayMode As System.Windows.Forms.GroupBox
    Private WithEvents radbtnVidPlayModeRandom As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidPlayModeLinear As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVidPlayModeLinearWithRandomStart As System.Windows.Forms.RadioButton
    Private WithEvents btnRefreshVidList As System.Windows.Forms.Button
    Private WithEvents btnlvVidFolders As System.Windows.Forms.Button
    Private lvVidFolders As System.Windows.Forms.ListView
    Private lblVidFileCount As System.Windows.Forms.Label
    Private lblInsideLocationOffset As System.Windows.Forms.Label
    Private WithEvents txbxInsideLocationOffset As System.Windows.Forms.TextBox
    Private WithEvents radbtnActionOnScreenSaveNoAction As System.Windows.Forms.RadioButton
    Private WithEvents radbtnActionOnScreenSaveSuspend As System.Windows.Forms.RadioButton
    Private WithEvents radbtnActionOnScreenSaveClose As System.Windows.Forms.RadioButton
    Private grbxActionOnScreenSave As System.Windows.Forms.GroupBox
    Private WithEvents chbxHideCursorWhenFullscreen As System.Windows.Forms.CheckBox
    Friend WithEvents cmiViewPics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmiPlayVids As System.Windows.Forms.ToolStripMenuItem
    Private tsSeparatorEnabled As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmList As System.Windows.Forms.ContextMenuStrip
    Private WithEvents cmSkyeShow As System.Windows.Forms.ContextMenuStrip
    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents chbxRefreshFileListsOnStartUp As System.Windows.Forms.CheckBox
    Private WithEvents chbxLoadFileListsInBackground As System.Windows.Forms.CheckBox
    Private WithEvents chbxSaveFileLists As System.Windows.Forms.CheckBox
    Private WithEvents cmiSettingListEnableItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyiconSkyeShow As System.Windows.Forms.NotifyIcon
    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmiLog As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnLog As System.Windows.Forms.Button
    Private WithEvents btnInfo As System.Windows.Forms.Button
    Private tipInfo As System.Windows.Forms.ToolTip
    Private WithEvents btnErrorTest As System.Windows.Forms.Button
    Private WithEvents radbtnVideoScale33 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScale66 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScale100 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScaleFit As System.Windows.Forms.RadioButton
    Private radioButton32 As System.Windows.Forms.RadioButton
    Private radioButton31 As System.Windows.Forms.RadioButton
	Private radioButton30 As System.Windows.Forms.RadioButton
	Private radioButton29 As System.Windows.Forms.RadioButton
	Private radioButton28 As System.Windows.Forms.RadioButton
	Private radioButton27 As System.Windows.Forms.RadioButton
	Private radioButton26 As System.Windows.Forms.RadioButton
	Private radioButton25 As System.Windows.Forms.RadioButton
	Private radioButton24 As System.Windows.Forms.RadioButton
	Private radioButton23 As System.Windows.Forms.RadioButton
	Private radioButton22 As System.Windows.Forms.RadioButton
	Private radioButton21 As System.Windows.Forms.RadioButton
	Private radioButton20 As System.Windows.Forms.RadioButton
	Private radioButton19 As System.Windows.Forms.RadioButton
	Private radioButton18 As System.Windows.Forms.RadioButton
	Private radioButton17 As System.Windows.Forms.RadioButton
	Private radioButton16 As System.Windows.Forms.RadioButton
    Private WithEvents cmiSettingListRemoveAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiSettingListRemoveItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiSettingListAddItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents radbtnVideoScale75 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScale10 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScale25 As System.Windows.Forms.RadioButton
    Private WithEvents radbtnVideoScale50 As System.Windows.Forms.RadioButton
    Private WithEvents btnRestoreSettings As System.Windows.Forms.Button
    Private WithEvents btnSaveSettings As System.Windows.Forms.Button
    Private WithEvents cmiSettings As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiExit As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chbkVidMute As CheckBox
    Friend WithEvents PanelApp As Panel
    Friend WithEvents PanelPics As Panel
    Friend WithEvents PanelVids As Panel
    Private WithEvents grbxHotKeysPics As GroupBox
    Private WithEvents txbxHotKeyPicToggle As TextBox
    Private WithEvents btnHotKeyPicToggleDisable As Button
    Private WithEvents txbxHotKeyPicToggleFullScreen As TextBox
    Private WithEvents btnHotKeyPicToggleFullScreenDisable As Button
    Private WithEvents btnHotKeysPicsUndo As Button
    Private WithEvents btnHotKeysPicsSet As Button
    Private WithEvents txbxHotKeyPicShowFileInfo As TextBox
    Private WithEvents btnHotKeyPicShowFileInfoDisable As Button
    Private WithEvents lblHotKeyPicToggle As Label
    Private WithEvents lblHotKeyPicToggleFullScreen As Label
    Private WithEvents lblHotKeyPicShowFileInfo As Label
    Private WithEvents lvPicFolders As ListView
    Private WithEvents gpbxPicTimerCountdownLocationMode As GroupBox
    Private WithEvents radbtnPicTimerCountdownLocationModeLeftCenterTop As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeBottomLeft As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeRightCenterTop As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeRightCenterBottom As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeBottomCenterRight As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeBottomCenterLeft As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeBottomRight As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeLeftCenterBottom As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeBottomCenter As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeLeftCenter As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeTopCenterLeft As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeTopCenter As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeTopRight As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeTopCenterRight As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeRightCenter As RadioButton
    Private WithEvents radbtnPicTimerCountdownLocationModeTopLeft As RadioButton
    Private WithEvents chbxPicTimerCountdown As CheckBox
    Private WithEvents txbxPicTimerInterval As TextBox
    Private WithEvents chbxPicAutoView As CheckBox
    Private WithEvents gpbxPicJustify As GroupBox
    Private WithEvents radbtnPicJustifyCenter As RadioButton
    Private WithEvents radbtnPicJustifyLeft As RadioButton
    Private WithEvents radbtnPicJustifyRight As RadioButton
    Private WithEvents chbxPicLockFullScreen As CheckBox
    Private WithEvents gpbxPicLocationMode As GroupBox
    Private WithEvents radbtnPicLocationModeTopLeftInside As RadioButton
    Private WithEvents radbtnPicLocationModeBottomLeftInside As RadioButton
    Private WithEvents radbtnPicLocationModeBottomRightInside As RadioButton
    Private WithEvents radbtnPicLocationModeTopRightInside As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenterTop As RadioButton
    Private WithEvents radbtnPicLocationModeBottomLeft As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenterBottomInside As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenterInside As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenterTopInside As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenterInside As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenterInside As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenterLeftInside As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenterTop As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenterBottom As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenterRight As RadioButton
    Private WithEvents radbtnPicLocationModeManual As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenterLeft As RadioButton
    Private WithEvents radbtnPicLocationModeBottomRight As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenterBottom As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenterRightInside As RadioButton
    Private WithEvents radbtnPicLocationModeBottomCenter As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenterBottomInside As RadioButton
    Private WithEvents radbtnPicLocationModeLeftCenter As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenterRightInside As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenterTopInside As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenterInside As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenterLeft As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenter As RadioButton
    Private WithEvents radbtnPicLocationModeTopRight As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenterRight As RadioButton
    Private WithEvents radbtnPicLocationModeRightCenter As RadioButton
    Private WithEvents radbtnPicLocationModeTopCenterLeftInside As RadioButton
    Private WithEvents radbtnPicLocationModeTopLeft As RadioButton
    Private WithEvents lblPicFileCount As Label
    Private WithEvents btnPicTimerEnabled As Button
    Private WithEvents btnlvPicFolders As Button
    Private WithEvents gpbxPicPlayMode As GroupBox
    Private WithEvents radbtnPicPlayModeLinearWithRandomStart As RadioButton
    Private WithEvents radbtnPicPlayModeRandom As RadioButton
    Private WithEvents radbtnPicPlayModeLinear As RadioButton
    Private WithEvents btnRefreshPicList As Button
    Private WithEvents label4 As Label
    Private WithEvents chbxPicTimerAutoStart As CheckBox
    Friend WithEvents PanelActions As Panel
    Friend WithEvents PanelPageSelector As Panel
    Friend WithEvents LVPageSelector As Skye.UI.ListViewEX
    Friend WithEvents ILPageSelector As ImageList
End Class