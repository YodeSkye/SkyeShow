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
        radbtnPicPlayModeLinear = New RadioButton()
        radbtnPicPlayModeRandom = New RadioButton()
        label4 = New Label()
        chbxPicTimerAutoStart = New CheckBox()
        PanelVids = New Panel()
        PanelActions = New Panel()
        PanelPageSelector = New Panel()
        LVPageSelector = New Skye.UI.ListViewEX()
        ILPageSelector = New ImageList(components)
        TipInfoEX = New Skye.UI.ToolTipEX(components)
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
        btnClose.Image = My.Resources.Resources.ImageOK
        TipInfoEX.SetImage(btnClose, My.Resources.Resources.ImageOK16)
        btnClose.Location = New Point(426, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(64, 64)
        btnClose.TabIndex = 0
        TipInfoEX.SetText(btnClose, "Close Window")
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
        cmSkyeShow.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(cmSkyeShow, Nothing)
        cmSkyeShow.Items.AddRange(New ToolStripItem() {cmiViewPics, cmiPlayVids, toolStripSeparator1, cmiHelp, cmiLog, cmiSettings, toolStripSeparator2, cmiExit})
        cmSkyeShow.Name = "cmenuYMShow"
        cmSkyeShow.RenderMode = ToolStripRenderMode.Professional
        cmSkyeShow.Size = New Size(185, 172)
        TipInfoEX.SetText(cmSkyeShow, Nothing)
        ' 
        ' cmiViewPics
        ' 
        cmiViewPics.Enabled = False
        cmiViewPics.Image = My.Resources.Resources.ImageImage
        cmiViewPics.Name = "cmiViewPics"
        cmiViewPics.Size = New Size(184, 26)
        cmiViewPics.Text = "Pictures"
        ' 
        ' cmiPlayVids
        ' 
        cmiPlayVids.Enabled = False
        cmiPlayVids.Image = My.Resources.Resources.ImageVideo
        cmiPlayVids.Name = "cmiPlayVids"
        cmiPlayVids.Size = New Size(184, 26)
        cmiPlayVids.Text = "Videos"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(181, 6)
        ' 
        ' cmiHelp
        ' 
        cmiHelp.Image = My.Resources.Resources.ImageInfo
        cmiHelp.Name = "cmiHelp"
        cmiHelp.Size = New Size(184, 26)
        cmiHelp.Text = "Help"
        cmiHelp.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiLog
        ' 
        cmiLog.Image = My.Resources.Resources.imageLog
        cmiLog.Name = "cmiLog"
        cmiLog.Size = New Size(184, 26)
        cmiLog.Text = "Log"
        cmiLog.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiSettings
        ' 
        cmiSettings.Image = CType(resources.GetObject("cmiSettings.Image"), Image)
        cmiSettings.Name = "cmiSettings"
        cmiSettings.Size = New Size(184, 26)
        cmiSettings.Text = "Settings"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(181, 6)
        ' 
        ' cmiExit
        ' 
        cmiExit.Image = My.Resources.Resources.imageClose
        cmiExit.Name = "cmiExit"
        cmiExit.Size = New Size(184, 26)
        cmiExit.Text = "Exit Skye Show"
        cmiExit.ToolTipText = "RightClick = ReStart YMShow"
        ' 
        ' lvVidFolders
        ' 
        lvVidFolders.BorderStyle = BorderStyle.FixedSingle
        lvVidFolders.ContextMenuStrip = cmList
        lvVidFolders.FullRowSelect = True
        lvVidFolders.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(lvVidFolders, Nothing)
        lvVidFolders.Location = New Point(7, 11)
        lvVidFolders.MultiSelect = False
        lvVidFolders.Name = "lvVidFolders"
        lvVidFolders.Size = New Size(742, 86)
        lvVidFolders.TabIndex = 10
        lvVidFolders.TabStop = False
        TipInfoEX.SetText(lvVidFolders, Nothing)
        lvVidFolders.UseCompatibleStateImageBehavior = False
        lvVidFolders.View = View.Details
        ' 
        ' cmList
        ' 
        cmList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(cmList, Nothing)
        cmList.Items.AddRange(New ToolStripItem() {cmiSettingListEnableItem, tsSeparatorEnabled, cmiSettingListAddItem, toolStripSeparator4, cmiSettingListRemoveItem, cmiSettingListRemoveAll})
        cmList.Name = "contextmenuSettingList"
        cmList.RenderMode = ToolStripRenderMode.Professional
        cmList.Size = New Size(173, 120)
        TipInfoEX.SetText(cmList, Nothing)
        ' 
        ' cmiSettingListEnableItem
        ' 
        cmiSettingListEnableItem.Name = "cmiSettingListEnableItem"
        cmiSettingListEnableItem.Size = New Size(172, 26)
        ' 
        ' tsSeparatorEnabled
        ' 
        tsSeparatorEnabled.Name = "tsSeparatorEnabled"
        tsSeparatorEnabled.Size = New Size(169, 6)
        ' 
        ' cmiSettingListAddItem
        ' 
        cmiSettingListAddItem.Image = My.Resources.Resources.imageAdd
        cmiSettingListAddItem.Name = "cmiSettingListAddItem"
        cmiSettingListAddItem.Size = New Size(172, 26)
        cmiSettingListAddItem.Text = "Add Item"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(169, 6)
        ' 
        ' cmiSettingListRemoveItem
        ' 
        cmiSettingListRemoveItem.Name = "cmiSettingListRemoveItem"
        cmiSettingListRemoveItem.Size = New Size(172, 26)
        cmiSettingListRemoveItem.Text = "Remove Item"
        ' 
        ' cmiSettingListRemoveAll
        ' 
        cmiSettingListRemoveAll.Name = "cmiSettingListRemoveAll"
        cmiSettingListRemoveAll.Size = New Size(172, 26)
        cmiSettingListRemoveAll.Text = "Remove All"
        ' 
        ' chbxHotKeys
        ' 
        TipInfoEX.SetImage(chbxHotKeys, Nothing)
        chbxHotKeys.Location = New Point(112, 205)
        chbxHotKeys.Name = "chbxHotKeys"
        chbxHotKeys.Size = New Size(140, 26)
        chbxHotKeys.TabIndex = 60
        TipInfoEX.SetText(chbxHotKeys, Nothing)
        chbxHotKeys.Text = "HotKeys"
        chbxHotKeys.UseVisualStyleBackColor = True
        ' 
        ' txbxInsideLocationOffset
        ' 
        TipInfoEX.SetImage(txbxInsideLocationOffset, Nothing)
        txbxInsideLocationOffset.Location = New Point(112, 308)
        txbxInsideLocationOffset.MaxLength = 4
        txbxInsideLocationOffset.Name = "txbxInsideLocationOffset"
        txbxInsideLocationOffset.Size = New Size(80, 29)
        txbxInsideLocationOffset.TabIndex = 70
        TipInfoEX.SetText(txbxInsideLocationOffset, Nothing)
        txbxInsideLocationOffset.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblInsideLocationOffset
        ' 
        TipInfoEX.SetImage(lblInsideLocationOffset, Nothing)
        lblInsideLocationOffset.Location = New Point(110, 288)
        lblInsideLocationOffset.Name = "lblInsideLocationOffset"
        lblInsideLocationOffset.Size = New Size(179, 22)
        lblInsideLocationOffset.TabIndex = 71
        lblInsideLocationOffset.Text = "Inside Location Offset"
        TipInfoEX.SetText(lblInsideLocationOffset, Nothing)
        lblInsideLocationOffset.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' grbxActionOnScreenSave
        ' 
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveClose)
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveSuspend)
        grbxActionOnScreenSave.Controls.Add(radbtnActionOnScreenSaveNoAction)
        TipInfoEX.SetImage(grbxActionOnScreenSave, Nothing)
        grbxActionOnScreenSave.Location = New Point(486, 25)
        grbxActionOnScreenSave.Name = "grbxActionOnScreenSave"
        grbxActionOnScreenSave.Size = New Size(318, 89)
        grbxActionOnScreenSave.TabIndex = 100
        grbxActionOnScreenSave.TabStop = False
        grbxActionOnScreenSave.Text = "Action on Lock Screen or Screen Saver"
        TipInfoEX.SetText(grbxActionOnScreenSave, Nothing)
        ' 
        ' radbtnActionOnScreenSaveClose
        ' 
        radbtnActionOnScreenSaveClose.CheckAlign = ContentAlignment.BottomCenter
        TipInfoEX.SetImage(radbtnActionOnScreenSaveClose, Nothing)
        radbtnActionOnScreenSaveClose.Location = New Point(214, 26)
        radbtnActionOnScreenSaveClose.Name = "radbtnActionOnScreenSaveClose"
        radbtnActionOnScreenSaveClose.Size = New Size(98, 43)
        radbtnActionOnScreenSaveClose.TabIndex = 2
        radbtnActionOnScreenSaveClose.TabStop = True
        TipInfoEX.SetText(radbtnActionOnScreenSaveClose, Nothing)
        radbtnActionOnScreenSaveClose.Text = "Close"
        radbtnActionOnScreenSaveClose.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveClose.UseVisualStyleBackColor = True
        ' 
        ' radbtnActionOnScreenSaveSuspend
        ' 
        radbtnActionOnScreenSaveSuspend.CheckAlign = ContentAlignment.BottomCenter
        TipInfoEX.SetImage(radbtnActionOnScreenSaveSuspend, Nothing)
        radbtnActionOnScreenSaveSuspend.Location = New Point(110, 26)
        radbtnActionOnScreenSaveSuspend.Name = "radbtnActionOnScreenSaveSuspend"
        radbtnActionOnScreenSaveSuspend.Size = New Size(98, 43)
        radbtnActionOnScreenSaveSuspend.TabIndex = 1
        radbtnActionOnScreenSaveSuspend.TabStop = True
        TipInfoEX.SetText(radbtnActionOnScreenSaveSuspend, Nothing)
        radbtnActionOnScreenSaveSuspend.Text = "Suspend"
        radbtnActionOnScreenSaveSuspend.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveSuspend.UseVisualStyleBackColor = True
        ' 
        ' radbtnActionOnScreenSaveNoAction
        ' 
        radbtnActionOnScreenSaveNoAction.CheckAlign = ContentAlignment.BottomCenter
        TipInfoEX.SetImage(radbtnActionOnScreenSaveNoAction, Nothing)
        radbtnActionOnScreenSaveNoAction.Location = New Point(6, 26)
        radbtnActionOnScreenSaveNoAction.Name = "radbtnActionOnScreenSaveNoAction"
        radbtnActionOnScreenSaveNoAction.Size = New Size(98, 43)
        radbtnActionOnScreenSaveNoAction.TabIndex = 0
        radbtnActionOnScreenSaveNoAction.TabStop = True
        TipInfoEX.SetText(radbtnActionOnScreenSaveNoAction, Nothing)
        radbtnActionOnScreenSaveNoAction.Text = "No Action"
        radbtnActionOnScreenSaveNoAction.TextAlign = ContentAlignment.TopCenter
        radbtnActionOnScreenSaveNoAction.UseVisualStyleBackColor = True
        ' 
        ' chbxHideCursorWhenFullscreen
        ' 
        TipInfoEX.SetImage(chbxHideCursorWhenFullscreen, Nothing)
        chbxHideCursorWhenFullscreen.Location = New Point(112, 166)
        chbxHideCursorWhenFullscreen.Name = "chbxHideCursorWhenFullscreen"
        chbxHideCursorWhenFullscreen.Size = New Size(241, 26)
        chbxHideCursorWhenFullscreen.TabIndex = 40
        TipInfoEX.SetText(chbxHideCursorWhenFullscreen, Nothing)
        chbxHideCursorWhenFullscreen.Text = "Hide Cursor When Fullscreen"
        chbxHideCursorWhenFullscreen.UseVisualStyleBackColor = True
        ' 
        ' chbxRefreshFileListsOnStartUp
        ' 
        TipInfoEX.SetImage(chbxRefreshFileListsOnStartUp, Nothing)
        chbxRefreshFileListsOnStartUp.Location = New Point(112, 127)
        chbxRefreshFileListsOnStartUp.Name = "chbxRefreshFileListsOnStartUp"
        chbxRefreshFileListsOnStartUp.Size = New Size(241, 26)
        chbxRefreshFileListsOnStartUp.TabIndex = 30
        TipInfoEX.SetText(chbxRefreshFileListsOnStartUp, Nothing)
        chbxRefreshFileListsOnStartUp.Text = "Refresh File Lists On StartUp?"
        chbxRefreshFileListsOnStartUp.UseVisualStyleBackColor = True
        ' 
        ' chbxLoadFileListsInBackground
        ' 
        TipInfoEX.SetImage(chbxLoadFileListsInBackground, Nothing)
        chbxLoadFileListsInBackground.Location = New Point(112, 88)
        chbxLoadFileListsInBackground.Name = "chbxLoadFileListsInBackground"
        chbxLoadFileListsInBackground.Size = New Size(241, 26)
        chbxLoadFileListsInBackground.TabIndex = 20
        TipInfoEX.SetText(chbxLoadFileListsInBackground, Nothing)
        chbxLoadFileListsInBackground.Text = "Load File Lists In Background?"
        chbxLoadFileListsInBackground.UseVisualStyleBackColor = True
        ' 
        ' chbxSaveFileLists
        ' 
        TipInfoEX.SetImage(chbxSaveFileLists, Nothing)
        chbxSaveFileLists.Location = New Point(112, 49)
        chbxSaveFileLists.Name = "chbxSaveFileLists"
        chbxSaveFileLists.Size = New Size(151, 26)
        chbxSaveFileLists.TabIndex = 10
        TipInfoEX.SetText(chbxSaveFileLists, Nothing)
        chbxSaveFileLists.Text = "Save File Lists?"
        chbxSaveFileLists.UseVisualStyleBackColor = True
        ' 
        ' chbkVidMute
        ' 
        chbkVidMute.BackColor = Color.Transparent
        chbkVidMute.Image = CType(resources.GetObject("chbkVidMute.Image"), Image)
        TipInfoEX.SetImage(chbkVidMute, Nothing)
        chbkVidMute.ImageAlign = ContentAlignment.MiddleLeft
        chbkVidMute.Location = New Point(261, 208)
        chbkVidMute.Name = "chbkVidMute"
        chbkVidMute.Size = New Size(129, 52)
        chbkVidMute.TabIndex = 131
        TipInfoEX.SetText(chbkVidMute, Nothing)
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
        TipInfoEX.SetImage(grbxHotKeysVids, Nothing)
        grbxHotKeysVids.Location = New Point(567, 253)
        grbxHotKeysVids.Name = "grbxHotKeysVids"
        grbxHotKeysVids.Size = New Size(181, 196)
        grbxHotKeysVids.TabIndex = 130
        grbxHotKeysVids.TabStop = False
        grbxHotKeysVids.Text = "HotKeys"
        TipInfoEX.SetText(grbxHotKeysVids, Nothing)
        ' 
        ' txbxHotKeyVidToggle
        ' 
        txbxHotKeyVidToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipInfoEX.SetImage(txbxHotKeyVidToggle, Nothing)
        txbxHotKeyVidToggle.Location = New Point(8, 39)
        txbxHotKeyVidToggle.Name = "txbxHotKeyVidToggle"
        txbxHotKeyVidToggle.ShortcutsEnabled = False
        txbxHotKeyVidToggle.Size = New Size(151, 29)
        txbxHotKeyVidToggle.TabIndex = 45
        txbxHotKeyVidToggle.TabStop = False
        TipInfoEX.SetText(txbxHotKeyVidToggle, Nothing)
        txbxHotKeyVidToggle.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidToggle.WordWrap = False
        ' 
        ' btnHotKeyVidToggleDisable
        ' 
        btnHotKeyVidToggleDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidToggleDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidToggleDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidToggleDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyVidToggleDisable, Nothing)
        btnHotKeyVidToggleDisable.Location = New Point(156, 43)
        btnHotKeyVidToggleDisable.Name = "btnHotKeyVidToggleDisable"
        btnHotKeyVidToggleDisable.Size = New Size(20, 17)
        btnHotKeyVidToggleDisable.TabIndex = 46
        btnHotKeyVidToggleDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyVidToggleDisable, Nothing)
        btnHotKeyVidToggleDisable.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyVidToggleFullScreen
        ' 
        txbxHotKeyVidToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipInfoEX.SetImage(txbxHotKeyVidToggleFullScreen, Nothing)
        txbxHotKeyVidToggleFullScreen.Location = New Point(8, 82)
        txbxHotKeyVidToggleFullScreen.Name = "txbxHotKeyVidToggleFullScreen"
        txbxHotKeyVidToggleFullScreen.ShortcutsEnabled = False
        txbxHotKeyVidToggleFullScreen.Size = New Size(151, 29)
        txbxHotKeyVidToggleFullScreen.TabIndex = 42
        txbxHotKeyVidToggleFullScreen.TabStop = False
        TipInfoEX.SetText(txbxHotKeyVidToggleFullScreen, Nothing)
        txbxHotKeyVidToggleFullScreen.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidToggleFullScreen.WordWrap = False
        ' 
        ' btnHotKeyVidToggleFullScreenDisable
        ' 
        btnHotKeyVidToggleFullScreenDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidToggleFullScreenDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidToggleFullScreenDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidToggleFullScreenDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyVidToggleFullScreenDisable, Nothing)
        btnHotKeyVidToggleFullScreenDisable.Location = New Point(156, 86)
        btnHotKeyVidToggleFullScreenDisable.Name = "btnHotKeyVidToggleFullScreenDisable"
        btnHotKeyVidToggleFullScreenDisable.Size = New Size(20, 17)
        btnHotKeyVidToggleFullScreenDisable.TabIndex = 43
        btnHotKeyVidToggleFullScreenDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyVidToggleFullScreenDisable, Nothing)
        btnHotKeyVidToggleFullScreenDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysVidsUndo
        ' 
        btnHotKeysVidsUndo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipInfoEX.SetImage(btnHotKeysVidsUndo, Nothing)
        btnHotKeysVidsUndo.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysVidsUndo.Location = New Point(7, 156)
        btnHotKeysVidsUndo.Name = "btnHotKeysVidsUndo"
        btnHotKeysVidsUndo.Size = New Size(83, 32)
        btnHotKeysVidsUndo.TabIndex = 30
        btnHotKeysVidsUndo.TabStop = False
        TipInfoEX.SetText(btnHotKeysVidsUndo, Nothing)
        btnHotKeysVidsUndo.Text = "Undo"
        btnHotKeysVidsUndo.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysVidsUndo.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysVidsSet
        ' 
        btnHotKeysVidsSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeysVidsSet.Image = My.Resources.Resources.imageGo
        TipInfoEX.SetImage(btnHotKeysVidsSet, Nothing)
        btnHotKeysVidsSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysVidsSet.Location = New Point(96, 156)
        btnHotKeysVidsSet.Name = "btnHotKeysVidsSet"
        btnHotKeysVidsSet.Size = New Size(63, 32)
        btnHotKeysVidsSet.TabIndex = 40
        btnHotKeysVidsSet.TabStop = False
        TipInfoEX.SetText(btnHotKeysVidsSet, Nothing)
        btnHotKeysVidsSet.Text = "Set"
        btnHotKeysVidsSet.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysVidsSet.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyVidShowFileInfo
        ' 
        txbxHotKeyVidShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipInfoEX.SetImage(txbxHotKeyVidShowFileInfo, Nothing)
        txbxHotKeyVidShowFileInfo.Location = New Point(8, 125)
        txbxHotKeyVidShowFileInfo.Name = "txbxHotKeyVidShowFileInfo"
        txbxHotKeyVidShowFileInfo.ShortcutsEnabled = False
        txbxHotKeyVidShowFileInfo.Size = New Size(151, 29)
        txbxHotKeyVidShowFileInfo.TabIndex = 10
        txbxHotKeyVidShowFileInfo.TabStop = False
        TipInfoEX.SetText(txbxHotKeyVidShowFileInfo, Nothing)
        txbxHotKeyVidShowFileInfo.TextAlign = HorizontalAlignment.Center
        txbxHotKeyVidShowFileInfo.WordWrap = False
        ' 
        ' btnHotKeyVidShowFileInfoDisable
        ' 
        btnHotKeyVidShowFileInfoDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHotKeyVidShowFileInfoDisable.FlatAppearance.BorderSize = 0
        btnHotKeyVidShowFileInfoDisable.FlatStyle = FlatStyle.Flat
        btnHotKeyVidShowFileInfoDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyVidShowFileInfoDisable, Nothing)
        btnHotKeyVidShowFileInfoDisable.Location = New Point(156, 129)
        btnHotKeyVidShowFileInfoDisable.Name = "btnHotKeyVidShowFileInfoDisable"
        btnHotKeyVidShowFileInfoDisable.Size = New Size(20, 17)
        btnHotKeyVidShowFileInfoDisable.TabIndex = 20
        btnHotKeyVidShowFileInfoDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyVidShowFileInfoDisable, Nothing)
        btnHotKeyVidShowFileInfoDisable.UseVisualStyleBackColor = True
        ' 
        ' lblHotKeyVidToggle
        ' 
        lblHotKeyVidToggle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidToggle.BackColor = Color.Transparent
        lblHotKeyVidToggle.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyVidToggle, Nothing)
        lblHotKeyVidToggle.Location = New Point(-21, 17)
        lblHotKeyVidToggle.Name = "lblHotKeyVidToggle"
        lblHotKeyVidToggle.Size = New Size(211, 23)
        lblHotKeyVidToggle.TabIndex = 44
        lblHotKeyVidToggle.Text = "VidToggle"
        TipInfoEX.SetText(lblHotKeyVidToggle, Nothing)
        lblHotKeyVidToggle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyVidToggleFullScreen
        ' 
        lblHotKeyVidToggleFullScreen.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidToggleFullScreen.BackColor = Color.Transparent
        lblHotKeyVidToggleFullScreen.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyVidToggleFullScreen, Nothing)
        lblHotKeyVidToggleFullScreen.Location = New Point(-21, 60)
        lblHotKeyVidToggleFullScreen.Name = "lblHotKeyVidToggleFullScreen"
        lblHotKeyVidToggleFullScreen.Size = New Size(211, 23)
        lblHotKeyVidToggleFullScreen.TabIndex = 41
        lblHotKeyVidToggleFullScreen.Text = "VidToggleFullScreen"
        TipInfoEX.SetText(lblHotKeyVidToggleFullScreen, Nothing)
        lblHotKeyVidToggleFullScreen.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHotKeyVidShowFileInfo
        ' 
        lblHotKeyVidShowFileInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHotKeyVidShowFileInfo.BackColor = Color.Transparent
        lblHotKeyVidShowFileInfo.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyVidShowFileInfo, Nothing)
        lblHotKeyVidShowFileInfo.Location = New Point(-21, 103)
        lblHotKeyVidShowFileInfo.Name = "lblHotKeyVidShowFileInfo"
        lblHotKeyVidShowFileInfo.Size = New Size(211, 23)
        lblHotKeyVidShowFileInfo.TabIndex = 0
        lblHotKeyVidShowFileInfo.Text = "VidShowFileInfo"
        TipInfoEX.SetText(lblHotKeyVidShowFileInfo, Nothing)
        lblHotKeyVidShowFileInfo.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cobxVidTimeDisplayMode
        ' 
        cobxVidTimeDisplayMode.DropDownStyle = ComboBoxStyle.DropDownList
        cobxVidTimeDisplayMode.FormattingEnabled = True
        TipInfoEX.SetImage(cobxVidTimeDisplayMode, Nothing)
        cobxVidTimeDisplayMode.Location = New Point(261, 281)
        cobxVidTimeDisplayMode.Name = "cobxVidTimeDisplayMode"
        cobxVidTimeDisplayMode.Size = New Size(156, 29)
        cobxVidTimeDisplayMode.TabIndex = 105
        TipInfoEX.SetText(cobxVidTimeDisplayMode, Nothing)
        ' 
        ' chbxVidLockFullScreen
        ' 
        chbxVidLockFullScreen.BackColor = Color.Transparent
        chbxVidLockFullScreen.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(chbxVidLockFullScreen, Nothing)
        chbxVidLockFullScreen.Location = New Point(554, 151)
        chbxVidLockFullScreen.Name = "chbxVidLockFullScreen"
        chbxVidLockFullScreen.Size = New Size(120, 22)
        chbxVidLockFullScreen.TabIndex = 75
        TipInfoEX.SetText(chbxVidLockFullScreen, Nothing)
        chbxVidLockFullScreen.Text = "Lock Full Screen"
        chbxVidLockFullScreen.TextAlign = ContentAlignment.MiddleRight
        chbxVidLockFullScreen.UseVisualStyleBackColor = False
        ' 
        ' chbxVidAutoView
        ' 
        chbxVidAutoView.BackColor = Color.Transparent
        chbxVidAutoView.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(chbxVidAutoView, Nothing)
        chbxVidAutoView.Location = New Point(590, 133)
        chbxVidAutoView.Name = "chbxVidAutoView"
        chbxVidAutoView.Size = New Size(84, 22)
        chbxVidAutoView.TabIndex = 70
        TipInfoEX.SetText(chbxVidAutoView, Nothing)
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
        TipInfoEX.SetImage(gpbxVidScale, Nothing)
        gpbxVidScale.Location = New Point(261, 137)
        gpbxVidScale.Name = "gpbxVidScale"
        gpbxVidScale.Size = New Size(270, 65)
        gpbxVidScale.TabIndex = 60
        gpbxVidScale.TabStop = False
        gpbxVidScale.Text = "Video Scale"
        TipInfoEX.SetText(gpbxVidScale, Nothing)
        ' 
        ' radbtnVideoScale100
        ' 
        TipInfoEX.SetImage(radbtnVideoScale100, Nothing)
        radbtnVideoScale100.Location = New Point(211, 19)
        radbtnVideoScale100.Name = "radbtnVideoScale100"
        radbtnVideoScale100.Size = New Size(58, 24)
        radbtnVideoScale100.TabIndex = 7
        TipInfoEX.SetText(radbtnVideoScale100, Nothing)
        radbtnVideoScale100.Text = "100%"
        radbtnVideoScale100.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScaleFit
        ' 
        TipInfoEX.SetImage(radbtnVideoScaleFit, Nothing)
        radbtnVideoScaleFit.Location = New Point(109, 19)
        radbtnVideoScaleFit.Name = "radbtnVideoScaleFit"
        radbtnVideoScaleFit.Size = New Size(42, 24)
        radbtnVideoScaleFit.TabIndex = 0
        TipInfoEX.SetText(radbtnVideoScaleFit, Nothing)
        radbtnVideoScaleFit.Text = "FIT"
        radbtnVideoScaleFit.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale10
        ' 
        TipInfoEX.SetImage(radbtnVideoScale10, Nothing)
        radbtnVideoScale10.Location = New Point(7, 19)
        radbtnVideoScale10.Name = "radbtnVideoScale10"
        radbtnVideoScale10.Size = New Size(51, 24)
        radbtnVideoScale10.TabIndex = 1
        TipInfoEX.SetText(radbtnVideoScale10, Nothing)
        radbtnVideoScale10.Text = "10%"
        radbtnVideoScale10.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale25
        ' 
        TipInfoEX.SetImage(radbtnVideoScale25, Nothing)
        radbtnVideoScale25.Location = New Point(7, 37)
        radbtnVideoScale25.Name = "radbtnVideoScale25"
        radbtnVideoScale25.Size = New Size(51, 24)
        radbtnVideoScale25.TabIndex = 2
        TipInfoEX.SetText(radbtnVideoScale25, Nothing)
        radbtnVideoScale25.Text = "25%"
        radbtnVideoScale25.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale33
        ' 
        TipInfoEX.SetImage(radbtnVideoScale33, Nothing)
        radbtnVideoScale33.Location = New Point(58, 37)
        radbtnVideoScale33.Name = "radbtnVideoScale33"
        radbtnVideoScale33.Size = New Size(51, 24)
        radbtnVideoScale33.TabIndex = 3
        TipInfoEX.SetText(radbtnVideoScale33, Nothing)
        radbtnVideoScale33.Text = "33%"
        radbtnVideoScale33.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale50
        ' 
        TipInfoEX.SetImage(radbtnVideoScale50, Nothing)
        radbtnVideoScale50.Location = New Point(109, 37)
        radbtnVideoScale50.Name = "radbtnVideoScale50"
        radbtnVideoScale50.Size = New Size(51, 24)
        radbtnVideoScale50.TabIndex = 4
        TipInfoEX.SetText(radbtnVideoScale50, Nothing)
        radbtnVideoScale50.Text = "50%"
        radbtnVideoScale50.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale66
        ' 
        TipInfoEX.SetImage(radbtnVideoScale66, Nothing)
        radbtnVideoScale66.Location = New Point(160, 37)
        radbtnVideoScale66.Name = "radbtnVideoScale66"
        radbtnVideoScale66.Size = New Size(51, 24)
        radbtnVideoScale66.TabIndex = 5
        TipInfoEX.SetText(radbtnVideoScale66, Nothing)
        radbtnVideoScale66.Text = "66%"
        radbtnVideoScale66.UseVisualStyleBackColor = True
        ' 
        ' radbtnVideoScale75
        ' 
        TipInfoEX.SetImage(radbtnVideoScale75, Nothing)
        radbtnVideoScale75.Location = New Point(211, 37)
        radbtnVideoScale75.Name = "radbtnVideoScale75"
        radbtnVideoScale75.Size = New Size(51, 24)
        radbtnVideoScale75.TabIndex = 6
        TipInfoEX.SetText(radbtnVideoScale75, Nothing)
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
        TipInfoEX.SetImage(gpbxVidLocationMode, Nothing)
        gpbxVidLocationMode.Location = New Point(7, 239)
        gpbxVidLocationMode.Name = "gpbxVidLocationMode"
        gpbxVidLocationMode.Size = New Size(195, 210)
        gpbxVidLocationMode.TabIndex = 90
        gpbxVidLocationMode.TabStop = False
        gpbxVidLocationMode.Text = "Video Location"
        TipInfoEX.SetText(gpbxVidLocationMode, Nothing)
        ' 
        ' radbtnVidLocationModeTopLeftInside
        ' 
        radbtnVidLocationModeTopLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopLeftInside, Nothing)
        radbtnVidLocationModeTopLeftInside.Location = New Point(34, 48)
        radbtnVidLocationModeTopLeftInside.Name = "radbtnVidLocationModeTopLeftInside"
        radbtnVidLocationModeTopLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopLeftInside.TabIndex = 107
        TipInfoEX.SetText(radbtnVidLocationModeTopLeftInside, Nothing)
        radbtnVidLocationModeTopLeftInside.Text = "  "
        radbtnVidLocationModeTopLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomLeftInside
        ' 
        radbtnVidLocationModeBottomLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomLeftInside, Nothing)
        radbtnVidLocationModeBottomLeftInside.Location = New Point(34, 160)
        radbtnVidLocationModeBottomLeftInside.Name = "radbtnVidLocationModeBottomLeftInside"
        radbtnVidLocationModeBottomLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomLeftInside.TabIndex = 108
        TipInfoEX.SetText(radbtnVidLocationModeBottomLeftInside, Nothing)
        radbtnVidLocationModeBottomLeftInside.Text = "  "
        radbtnVidLocationModeBottomLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomRightInside
        ' 
        radbtnVidLocationModeBottomRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomRightInside, Nothing)
        radbtnVidLocationModeBottomRightInside.Location = New Point(146, 160)
        radbtnVidLocationModeBottomRightInside.Name = "radbtnVidLocationModeBottomRightInside"
        radbtnVidLocationModeBottomRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomRightInside.TabIndex = 109
        TipInfoEX.SetText(radbtnVidLocationModeBottomRightInside, Nothing)
        radbtnVidLocationModeBottomRightInside.Text = "  "
        radbtnVidLocationModeBottomRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopRightInside
        ' 
        radbtnVidLocationModeTopRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopRightInside, Nothing)
        radbtnVidLocationModeTopRightInside.Location = New Point(146, 48)
        radbtnVidLocationModeTopRightInside.Name = "radbtnVidLocationModeTopRightInside"
        radbtnVidLocationModeTopRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopRightInside.TabIndex = 112
        TipInfoEX.SetText(radbtnVidLocationModeTopRightInside, Nothing)
        radbtnVidLocationModeTopRightInside.Text = "  "
        radbtnVidLocationModeTopRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterBottomInside
        ' 
        radbtnVidLocationModeLeftCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenterBottomInside, Nothing)
        radbtnVidLocationModeLeftCenterBottomInside.Location = New Point(34, 132)
        radbtnVidLocationModeLeftCenterBottomInside.Name = "radbtnVidLocationModeLeftCenterBottomInside"
        radbtnVidLocationModeLeftCenterBottomInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterBottomInside.TabIndex = 106
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenterBottomInside, Nothing)
        radbtnVidLocationModeLeftCenterBottomInside.Text = "  "
        radbtnVidLocationModeLeftCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterInside
        ' 
        radbtnVidLocationModeLeftCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenterInside, Nothing)
        radbtnVidLocationModeLeftCenterInside.Location = New Point(34, 104)
        radbtnVidLocationModeLeftCenterInside.Name = "radbtnVidLocationModeLeftCenterInside"
        radbtnVidLocationModeLeftCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterInside.TabIndex = 110
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenterInside, Nothing)
        radbtnVidLocationModeLeftCenterInside.Text = "  "
        radbtnVidLocationModeLeftCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterTopInside
        ' 
        radbtnVidLocationModeLeftCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenterTopInside, Nothing)
        radbtnVidLocationModeLeftCenterTopInside.Location = New Point(34, 76)
        radbtnVidLocationModeLeftCenterTopInside.Name = "radbtnVidLocationModeLeftCenterTopInside"
        radbtnVidLocationModeLeftCenterTopInside.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterTopInside.TabIndex = 111
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenterTopInside, Nothing)
        radbtnVidLocationModeLeftCenterTopInside.Text = "  "
        radbtnVidLocationModeLeftCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterInside
        ' 
        radbtnVidLocationModeBottomCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenterInside, Nothing)
        radbtnVidLocationModeBottomCenterInside.Location = New Point(90, 160)
        radbtnVidLocationModeBottomCenterInside.Name = "radbtnVidLocationModeBottomCenterInside"
        radbtnVidLocationModeBottomCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterInside.TabIndex = 104
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenterInside, Nothing)
        radbtnVidLocationModeBottomCenterInside.Text = "  "
        radbtnVidLocationModeBottomCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterInside
        ' 
        radbtnVidLocationModeRightCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenterInside, Nothing)
        radbtnVidLocationModeRightCenterInside.Location = New Point(146, 104)
        radbtnVidLocationModeRightCenterInside.Name = "radbtnVidLocationModeRightCenterInside"
        radbtnVidLocationModeRightCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterInside.TabIndex = 102
        TipInfoEX.SetText(radbtnVidLocationModeRightCenterInside, Nothing)
        radbtnVidLocationModeRightCenterInside.Text = "  "
        radbtnVidLocationModeRightCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterLeftInside
        ' 
        radbtnVidLocationModeBottomCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenterLeftInside, Nothing)
        radbtnVidLocationModeBottomCenterLeftInside.Location = New Point(62, 160)
        radbtnVidLocationModeBottomCenterLeftInside.Name = "radbtnVidLocationModeBottomCenterLeftInside"
        radbtnVidLocationModeBottomCenterLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterLeftInside.TabIndex = 105
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenterLeftInside, Nothing)
        radbtnVidLocationModeBottomCenterLeftInside.Text = "  "
        radbtnVidLocationModeBottomCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterRightInside
        ' 
        radbtnVidLocationModeBottomCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenterRightInside, Nothing)
        radbtnVidLocationModeBottomCenterRightInside.Location = New Point(118, 160)
        radbtnVidLocationModeBottomCenterRightInside.Name = "radbtnVidLocationModeBottomCenterRightInside"
        radbtnVidLocationModeBottomCenterRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterRightInside.TabIndex = 101
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenterRightInside, Nothing)
        radbtnVidLocationModeBottomCenterRightInside.Text = "  "
        radbtnVidLocationModeBottomCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterBottomInside
        ' 
        radbtnVidLocationModeRightCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenterBottomInside, Nothing)
        radbtnVidLocationModeRightCenterBottomInside.Location = New Point(146, 132)
        radbtnVidLocationModeRightCenterBottomInside.Name = "radbtnVidLocationModeRightCenterBottomInside"
        radbtnVidLocationModeRightCenterBottomInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterBottomInside.TabIndex = 103
        TipInfoEX.SetText(radbtnVidLocationModeRightCenterBottomInside, Nothing)
        radbtnVidLocationModeRightCenterBottomInside.Text = "  "
        radbtnVidLocationModeRightCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterRightInside
        ' 
        radbtnVidLocationModeTopCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenterRightInside, Nothing)
        radbtnVidLocationModeTopCenterRightInside.Location = New Point(118, 48)
        radbtnVidLocationModeTopCenterRightInside.Name = "radbtnVidLocationModeTopCenterRightInside"
        radbtnVidLocationModeTopCenterRightInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterRightInside.TabIndex = 99
        TipInfoEX.SetText(radbtnVidLocationModeTopCenterRightInside, Nothing)
        radbtnVidLocationModeTopCenterRightInside.Text = "  "
        radbtnVidLocationModeTopCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterTopInside
        ' 
        radbtnVidLocationModeRightCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenterTopInside, Nothing)
        radbtnVidLocationModeRightCenterTopInside.Location = New Point(146, 76)
        radbtnVidLocationModeRightCenterTopInside.Name = "radbtnVidLocationModeRightCenterTopInside"
        radbtnVidLocationModeRightCenterTopInside.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterTopInside.TabIndex = 100
        TipInfoEX.SetText(radbtnVidLocationModeRightCenterTopInside, Nothing)
        radbtnVidLocationModeRightCenterTopInside.Text = "  "
        radbtnVidLocationModeRightCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterInside
        ' 
        radbtnVidLocationModeTopCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenterInside, Nothing)
        radbtnVidLocationModeTopCenterInside.Location = New Point(90, 48)
        radbtnVidLocationModeTopCenterInside.Name = "radbtnVidLocationModeTopCenterInside"
        radbtnVidLocationModeTopCenterInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterInside.TabIndex = 98
        TipInfoEX.SetText(radbtnVidLocationModeTopCenterInside, Nothing)
        radbtnVidLocationModeTopCenterInside.Text = "  "
        radbtnVidLocationModeTopCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterLeftInside
        ' 
        radbtnVidLocationModeTopCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenterLeftInside, Nothing)
        radbtnVidLocationModeTopCenterLeftInside.Location = New Point(62, 48)
        radbtnVidLocationModeTopCenterLeftInside.Name = "radbtnVidLocationModeTopCenterLeftInside"
        radbtnVidLocationModeTopCenterLeftInside.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterLeftInside.TabIndex = 97
        TipInfoEX.SetText(radbtnVidLocationModeTopCenterLeftInside, Nothing)
        radbtnVidLocationModeTopCenterLeftInside.Text = "  "
        radbtnVidLocationModeTopCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterTop
        ' 
        radbtnVidLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenterTop, Nothing)
        radbtnVidLocationModeLeftCenterTop.Location = New Point(6, 62)
        radbtnVidLocationModeLeftCenterTop.Name = "radbtnVidLocationModeLeftCenterTop"
        radbtnVidLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterTop.TabIndex = 33
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenterTop, Nothing)
        radbtnVidLocationModeLeftCenterTop.Text = "  "
        radbtnVidLocationModeLeftCenterTop.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomLeft
        ' 
        radbtnVidLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomLeft, Nothing)
        radbtnVidLocationModeBottomLeft.Location = New Point(6, 188)
        radbtnVidLocationModeBottomLeft.Name = "radbtnVidLocationModeBottomLeft"
        radbtnVidLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnVidLocationModeBottomLeft.TabIndex = 30
        TipInfoEX.SetText(radbtnVidLocationModeBottomLeft, Nothing)
        radbtnVidLocationModeBottomLeft.Text = "  "
        radbtnVidLocationModeBottomLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterTop
        ' 
        radbtnVidLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenterTop, Nothing)
        radbtnVidLocationModeRightCenterTop.Location = New Point(174, 62)
        radbtnVidLocationModeRightCenterTop.Name = "radbtnVidLocationModeRightCenterTop"
        radbtnVidLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterTop.TabIndex = 23
        TipInfoEX.SetText(radbtnVidLocationModeRightCenterTop, Nothing)
        radbtnVidLocationModeRightCenterTop.Text = "  "
        radbtnVidLocationModeRightCenterTop.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenterBottom
        ' 
        radbtnVidLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenterBottom, Nothing)
        radbtnVidLocationModeRightCenterBottom.Location = New Point(174, 146)
        radbtnVidLocationModeRightCenterBottom.Name = "radbtnVidLocationModeRightCenterBottom"
        radbtnVidLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenterBottom.TabIndex = 25
        TipInfoEX.SetText(radbtnVidLocationModeRightCenterBottom, Nothing)
        radbtnVidLocationModeRightCenterBottom.Text = "  "
        radbtnVidLocationModeRightCenterBottom.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterRight
        ' 
        radbtnVidLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenterRight, Nothing)
        radbtnVidLocationModeBottomCenterRight.Location = New Point(132, 188)
        radbtnVidLocationModeBottomCenterRight.Name = "radbtnVidLocationModeBottomCenterRight"
        radbtnVidLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterRight.TabIndex = 27
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenterRight, Nothing)
        radbtnVidLocationModeBottomCenterRight.Text = "  "
        radbtnVidLocationModeBottomCenterRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenterLeft
        ' 
        radbtnVidLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenterLeft, Nothing)
        radbtnVidLocationModeBottomCenterLeft.Location = New Point(48, 188)
        radbtnVidLocationModeBottomCenterLeft.Name = "radbtnVidLocationModeBottomCenterLeft"
        radbtnVidLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenterLeft.TabIndex = 29
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenterLeft, Nothing)
        radbtnVidLocationModeBottomCenterLeft.Text = "  "
        radbtnVidLocationModeBottomCenterLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomRight
        ' 
        radbtnVidLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomRight, Nothing)
        radbtnVidLocationModeBottomRight.Location = New Point(174, 188)
        radbtnVidLocationModeBottomRight.Name = "radbtnVidLocationModeBottomRight"
        radbtnVidLocationModeBottomRight.Size = New Size(16, 16)
        radbtnVidLocationModeBottomRight.TabIndex = 26
        TipInfoEX.SetText(radbtnVidLocationModeBottomRight, Nothing)
        radbtnVidLocationModeBottomRight.Text = "  "
        radbtnVidLocationModeBottomRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenterBottom
        ' 
        radbtnVidLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenterBottom, Nothing)
        radbtnVidLocationModeLeftCenterBottom.Location = New Point(6, 146)
        radbtnVidLocationModeLeftCenterBottom.Name = "radbtnVidLocationModeLeftCenterBottom"
        radbtnVidLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenterBottom.TabIndex = 31
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenterBottom, Nothing)
        radbtnVidLocationModeLeftCenterBottom.Text = "  "
        radbtnVidLocationModeLeftCenterBottom.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeBottomCenter
        ' 
        radbtnVidLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeBottomCenter, Nothing)
        radbtnVidLocationModeBottomCenter.Location = New Point(90, 188)
        radbtnVidLocationModeBottomCenter.Name = "radbtnVidLocationModeBottomCenter"
        radbtnVidLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnVidLocationModeBottomCenter.TabIndex = 28
        TipInfoEX.SetText(radbtnVidLocationModeBottomCenter, Nothing)
        radbtnVidLocationModeBottomCenter.Text = "  "
        radbtnVidLocationModeBottomCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeLeftCenter
        ' 
        radbtnVidLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeLeftCenter, Nothing)
        radbtnVidLocationModeLeftCenter.Location = New Point(6, 104)
        radbtnVidLocationModeLeftCenter.Name = "radbtnVidLocationModeLeftCenter"
        radbtnVidLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnVidLocationModeLeftCenter.TabIndex = 32
        TipInfoEX.SetText(radbtnVidLocationModeLeftCenter, Nothing)
        radbtnVidLocationModeLeftCenter.Text = "  "
        radbtnVidLocationModeLeftCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterLeft
        ' 
        radbtnVidLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenterLeft, Nothing)
        radbtnVidLocationModeTopCenterLeft.Location = New Point(48, 20)
        radbtnVidLocationModeTopCenterLeft.Name = "radbtnVidLocationModeTopCenterLeft"
        radbtnVidLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterLeft.TabIndex = 19
        TipInfoEX.SetText(radbtnVidLocationModeTopCenterLeft, Nothing)
        radbtnVidLocationModeTopCenterLeft.Text = "  "
        radbtnVidLocationModeTopCenterLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenter
        ' 
        radbtnVidLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenter, Nothing)
        radbtnVidLocationModeTopCenter.Location = New Point(90, 20)
        radbtnVidLocationModeTopCenter.Name = "radbtnVidLocationModeTopCenter"
        radbtnVidLocationModeTopCenter.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenter.TabIndex = 20
        TipInfoEX.SetText(radbtnVidLocationModeTopCenter, Nothing)
        radbtnVidLocationModeTopCenter.Text = "  "
        radbtnVidLocationModeTopCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopRight
        ' 
        radbtnVidLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopRight, Nothing)
        radbtnVidLocationModeTopRight.Location = New Point(174, 20)
        radbtnVidLocationModeTopRight.Name = "radbtnVidLocationModeTopRight"
        radbtnVidLocationModeTopRight.Size = New Size(16, 16)
        radbtnVidLocationModeTopRight.TabIndex = 22
        TipInfoEX.SetText(radbtnVidLocationModeTopRight, Nothing)
        radbtnVidLocationModeTopRight.Text = "  "
        radbtnVidLocationModeTopRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopCenterRight
        ' 
        radbtnVidLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopCenterRight, Nothing)
        radbtnVidLocationModeTopCenterRight.Location = New Point(132, 20)
        radbtnVidLocationModeTopCenterRight.Name = "radbtnVidLocationModeTopCenterRight"
        radbtnVidLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnVidLocationModeTopCenterRight.TabIndex = 21
        TipInfoEX.SetText(radbtnVidLocationModeTopCenterRight, Nothing)
        radbtnVidLocationModeTopCenterRight.Text = "  "
        radbtnVidLocationModeTopCenterRight.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeRightCenter
        ' 
        radbtnVidLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeRightCenter, Nothing)
        radbtnVidLocationModeRightCenter.Location = New Point(174, 104)
        radbtnVidLocationModeRightCenter.Name = "radbtnVidLocationModeRightCenter"
        radbtnVidLocationModeRightCenter.Size = New Size(16, 16)
        radbtnVidLocationModeRightCenter.TabIndex = 24
        TipInfoEX.SetText(radbtnVidLocationModeRightCenter, Nothing)
        radbtnVidLocationModeRightCenter.Text = "  "
        radbtnVidLocationModeRightCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeTopLeft
        ' 
        radbtnVidLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidLocationModeTopLeft, Nothing)
        radbtnVidLocationModeTopLeft.Location = New Point(6, 20)
        radbtnVidLocationModeTopLeft.Name = "radbtnVidLocationModeTopLeft"
        radbtnVidLocationModeTopLeft.Size = New Size(16, 16)
        radbtnVidLocationModeTopLeft.TabIndex = 18
        TipInfoEX.SetText(radbtnVidLocationModeTopLeft, Nothing)
        radbtnVidLocationModeTopLeft.Text = "  "
        radbtnVidLocationModeTopLeft.TextAlign = ContentAlignment.MiddleCenter
        radbtnVidLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidLocationModeManual
        ' 
        radbtnVidLocationModeManual.CheckAlign = ContentAlignment.BottomCenter
        TipInfoEX.SetImage(radbtnVidLocationModeManual, Nothing)
        radbtnVidLocationModeManual.Location = New Point(69, 78)
        radbtnVidLocationModeManual.Name = "radbtnVidLocationModeManual"
        radbtnVidLocationModeManual.Size = New Size(57, 40)
        radbtnVidLocationModeManual.TabIndex = 17
        TipInfoEX.SetText(radbtnVidLocationModeManual, Nothing)
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
        TipInfoEX.SetImage(gpbxVidPlayMode, Nothing)
        gpbxVidPlayMode.Location = New Point(7, 137)
        gpbxVidPlayMode.Name = "gpbxVidPlayMode"
        gpbxVidPlayMode.Size = New Size(248, 47)
        gpbxVidPlayMode.TabIndex = 50
        gpbxVidPlayMode.TabStop = False
        gpbxVidPlayMode.Text = "Video Play Mode"
        TipInfoEX.SetText(gpbxVidPlayMode, Nothing)
        ' 
        ' radbtnVidPlayModeLinearWithRandomStart
        ' 
        TipInfoEX.SetImage(radbtnVidPlayModeLinearWithRandomStart, Nothing)
        radbtnVidPlayModeLinearWithRandomStart.Location = New Point(84, 19)
        radbtnVidPlayModeLinearWithRandomStart.Name = "radbtnVidPlayModeLinearWithRandomStart"
        radbtnVidPlayModeLinearWithRandomStart.Size = New Size(74, 24)
        radbtnVidPlayModeLinearWithRandomStart.TabIndex = 2
        TipInfoEX.SetText(radbtnVidPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnVidPlayModeLinearWithRandomStart.Text = "Linear +"
        tipInfo.SetToolTip(radbtnVidPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnVidPlayModeLinearWithRandomStart.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidPlayModeRandom
        ' 
        TipInfoEX.SetImage(radbtnVidPlayModeRandom, Nothing)
        radbtnVidPlayModeRandom.Location = New Point(172, 19)
        radbtnVidPlayModeRandom.Name = "radbtnVidPlayModeRandom"
        radbtnVidPlayModeRandom.Size = New Size(75, 24)
        radbtnVidPlayModeRandom.TabIndex = 1
        TipInfoEX.SetText(radbtnVidPlayModeRandom, Nothing)
        radbtnVidPlayModeRandom.Text = "Random"
        radbtnVidPlayModeRandom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidPlayModeLinear
        ' 
        TipInfoEX.SetImage(radbtnVidPlayModeLinear, Nothing)
        radbtnVidPlayModeLinear.Location = New Point(7, 19)
        radbtnVidPlayModeLinear.Name = "radbtnVidPlayModeLinear"
        radbtnVidPlayModeLinear.Size = New Size(61, 24)
        radbtnVidPlayModeLinear.TabIndex = 0
        TipInfoEX.SetText(radbtnVidPlayModeLinear, Nothing)
        radbtnVidPlayModeLinear.Text = "Linear"
        radbtnVidPlayModeLinear.UseVisualStyleBackColor = True
        ' 
        ' chbxVidTime
        ' 
        chbxVidTime.BackColor = Color.Transparent
        TipInfoEX.SetImage(chbxVidTime, Nothing)
        chbxVidTime.Location = New Point(261, 261)
        chbxVidTime.Name = "chbxVidTime"
        chbxVidTime.Size = New Size(133, 22)
        chbxVidTime.TabIndex = 100
        TipInfoEX.SetText(chbxVidTime, Nothing)
        chbxVidTime.Text = "Show Video Time"
        chbxVidTime.UseVisualStyleBackColor = False
        ' 
        ' lblVidFileCount
        ' 
        lblVidFileCount.BackColor = Color.Transparent
        TipInfoEX.SetImage(lblVidFileCount, Nothing)
        lblVidFileCount.Location = New Point(8, 97)
        lblVidFileCount.Name = "lblVidFileCount"
        lblVidFileCount.Size = New Size(254, 22)
        lblVidFileCount.TabIndex = 0
        TipInfoEX.SetText(lblVidFileCount, Nothing)
        ' 
        ' btnlvVidFolders
        ' 
        btnlvVidFolders.BackColor = Color.Transparent
        btnlvVidFolders.FlatAppearance.BorderSize = 0
        btnlvVidFolders.Image = My.Resources.Resources.imageFolder
        TipInfoEX.SetImage(btnlvVidFolders, My.Resources.Resources.imageFolder)
        btnlvVidFolders.ImageAlign = ContentAlignment.MiddleLeft
        btnlvVidFolders.Location = New Point(469, 95)
        btnlvVidFolders.Name = "btnlvVidFolders"
        btnlvVidFolders.Size = New Size(175, 32)
        btnlvVidFolders.TabIndex = 22
        btnlvVidFolders.TabStop = False
        TipInfoEX.SetText(btnlvVidFolders, "Folder List View Mode")
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
        TipInfoEX.SetImage(btnRefreshVidList, My.Resources.Resources.imageRefresh)
        btnRefreshVidList.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshVidList.Location = New Point(650, 95)
        btnRefreshVidList.Name = "btnRefreshVidList"
        btnRefreshVidList.Size = New Size(100, 32)
        btnRefreshVidList.TabIndex = 24
        btnRefreshVidList.TabStop = False
        TipInfoEX.SetText(btnRefreshVidList, "LeftClick = Refresh Video List (Ctrl = Reset)" & vbCrLf & "RightClick = Refresh All File Lists (Ctrl = Reset)")
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
        TipInfoEX.SetImage(grbxVidTimeLocationMode, Nothing)
        grbxVidTimeLocationMode.Location = New Point(261, 305)
        grbxVidTimeLocationMode.Name = "grbxVidTimeLocationMode"
        grbxVidTimeLocationMode.Size = New Size(133, 144)
        grbxVidTimeLocationMode.TabIndex = 110
        grbxVidTimeLocationMode.TabStop = False
        grbxVidTimeLocationMode.Text = "Time Location"
        TipInfoEX.SetText(grbxVidTimeLocationMode, Nothing)
        ' 
        ' radbtnVidTimeLocationModeLeftCenterTop
        ' 
        radbtnVidTimeLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeLeftCenterTop, Nothing)
        radbtnVidTimeLocationModeLeftCenterTop.Location = New Point(5, 45)
        radbtnVidTimeLocationModeLeftCenterTop.Name = "radbtnVidTimeLocationModeLeftCenterTop"
        radbtnVidTimeLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenterTop.TabIndex = 16
        TipInfoEX.SetText(radbtnVidTimeLocationModeLeftCenterTop, Nothing)
        radbtnVidTimeLocationModeLeftCenterTop.Text = "  "
        radbtnVidTimeLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomLeft
        ' 
        radbtnVidTimeLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeBottomLeft, Nothing)
        radbtnVidTimeLocationModeBottomLeft.Location = New Point(5, 123)
        radbtnVidTimeLocationModeBottomLeft.Name = "radbtnVidTimeLocationModeBottomLeft"
        radbtnVidTimeLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomLeft.TabIndex = 13
        TipInfoEX.SetText(radbtnVidTimeLocationModeBottomLeft, Nothing)
        radbtnVidTimeLocationModeBottomLeft.Text = "  "
        radbtnVidTimeLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenterTop
        ' 
        radbtnVidTimeLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeRightCenterTop, Nothing)
        radbtnVidTimeLocationModeRightCenterTop.Location = New Point(113, 45)
        radbtnVidTimeLocationModeRightCenterTop.Name = "radbtnVidTimeLocationModeRightCenterTop"
        radbtnVidTimeLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenterTop.TabIndex = 6
        TipInfoEX.SetText(radbtnVidTimeLocationModeRightCenterTop, Nothing)
        radbtnVidTimeLocationModeRightCenterTop.Text = "  "
        radbtnVidTimeLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenterBottom
        ' 
        radbtnVidTimeLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeRightCenterBottom, Nothing)
        radbtnVidTimeLocationModeRightCenterBottom.Location = New Point(113, 97)
        radbtnVidTimeLocationModeRightCenterBottom.Name = "radbtnVidTimeLocationModeRightCenterBottom"
        radbtnVidTimeLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenterBottom.TabIndex = 8
        TipInfoEX.SetText(radbtnVidTimeLocationModeRightCenterBottom, Nothing)
        radbtnVidTimeLocationModeRightCenterBottom.Text = "  "
        radbtnVidTimeLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenterRight
        ' 
        radbtnVidTimeLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeBottomCenterRight, Nothing)
        radbtnVidTimeLocationModeBottomCenterRight.Location = New Point(86, 123)
        radbtnVidTimeLocationModeBottomCenterRight.Name = "radbtnVidTimeLocationModeBottomCenterRight"
        radbtnVidTimeLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenterRight.TabIndex = 10
        TipInfoEX.SetText(radbtnVidTimeLocationModeBottomCenterRight, Nothing)
        radbtnVidTimeLocationModeBottomCenterRight.Text = "  "
        radbtnVidTimeLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenterLeft
        ' 
        radbtnVidTimeLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeBottomCenterLeft, Nothing)
        radbtnVidTimeLocationModeBottomCenterLeft.Location = New Point(32, 123)
        radbtnVidTimeLocationModeBottomCenterLeft.Name = "radbtnVidTimeLocationModeBottomCenterLeft"
        radbtnVidTimeLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenterLeft.TabIndex = 12
        TipInfoEX.SetText(radbtnVidTimeLocationModeBottomCenterLeft, Nothing)
        radbtnVidTimeLocationModeBottomCenterLeft.Text = "  "
        radbtnVidTimeLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomRight
        ' 
        radbtnVidTimeLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeBottomRight, Nothing)
        radbtnVidTimeLocationModeBottomRight.Location = New Point(113, 123)
        radbtnVidTimeLocationModeBottomRight.Name = "radbtnVidTimeLocationModeBottomRight"
        radbtnVidTimeLocationModeBottomRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomRight.TabIndex = 9
        TipInfoEX.SetText(radbtnVidTimeLocationModeBottomRight, Nothing)
        radbtnVidTimeLocationModeBottomRight.Text = "  "
        radbtnVidTimeLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeLeftCenterBottom
        ' 
        radbtnVidTimeLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeLeftCenterBottom, Nothing)
        radbtnVidTimeLocationModeLeftCenterBottom.Location = New Point(5, 97)
        radbtnVidTimeLocationModeLeftCenterBottom.Name = "radbtnVidTimeLocationModeLeftCenterBottom"
        radbtnVidTimeLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenterBottom.TabIndex = 14
        TipInfoEX.SetText(radbtnVidTimeLocationModeLeftCenterBottom, Nothing)
        radbtnVidTimeLocationModeLeftCenterBottom.Text = "  "
        radbtnVidTimeLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeBottomCenter
        ' 
        radbtnVidTimeLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeBottomCenter, Nothing)
        radbtnVidTimeLocationModeBottomCenter.Location = New Point(59, 123)
        radbtnVidTimeLocationModeBottomCenter.Name = "radbtnVidTimeLocationModeBottomCenter"
        radbtnVidTimeLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeBottomCenter.TabIndex = 11
        TipInfoEX.SetText(radbtnVidTimeLocationModeBottomCenter, Nothing)
        radbtnVidTimeLocationModeBottomCenter.Text = "  "
        radbtnVidTimeLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeLeftCenter
        ' 
        radbtnVidTimeLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeLeftCenter, Nothing)
        radbtnVidTimeLocationModeLeftCenter.Location = New Point(5, 71)
        radbtnVidTimeLocationModeLeftCenter.Name = "radbtnVidTimeLocationModeLeftCenter"
        radbtnVidTimeLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeLeftCenter.TabIndex = 15
        TipInfoEX.SetText(radbtnVidTimeLocationModeLeftCenter, Nothing)
        radbtnVidTimeLocationModeLeftCenter.Text = "  "
        radbtnVidTimeLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenterLeft
        ' 
        radbtnVidTimeLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeTopCenterLeft, Nothing)
        radbtnVidTimeLocationModeTopCenterLeft.Location = New Point(32, 19)
        radbtnVidTimeLocationModeTopCenterLeft.Name = "radbtnVidTimeLocationModeTopCenterLeft"
        radbtnVidTimeLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenterLeft.TabIndex = 2
        TipInfoEX.SetText(radbtnVidTimeLocationModeTopCenterLeft, Nothing)
        radbtnVidTimeLocationModeTopCenterLeft.Text = "  "
        radbtnVidTimeLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenter
        ' 
        radbtnVidTimeLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeTopCenter, Nothing)
        radbtnVidTimeLocationModeTopCenter.Location = New Point(59, 19)
        radbtnVidTimeLocationModeTopCenter.Name = "radbtnVidTimeLocationModeTopCenter"
        radbtnVidTimeLocationModeTopCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenter.TabIndex = 3
        TipInfoEX.SetText(radbtnVidTimeLocationModeTopCenter, Nothing)
        radbtnVidTimeLocationModeTopCenter.Text = "  "
        radbtnVidTimeLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopRight
        ' 
        radbtnVidTimeLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeTopRight, Nothing)
        radbtnVidTimeLocationModeTopRight.Location = New Point(113, 19)
        radbtnVidTimeLocationModeTopRight.Name = "radbtnVidTimeLocationModeTopRight"
        radbtnVidTimeLocationModeTopRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopRight.TabIndex = 5
        TipInfoEX.SetText(radbtnVidTimeLocationModeTopRight, Nothing)
        radbtnVidTimeLocationModeTopRight.Text = "  "
        radbtnVidTimeLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopCenterRight
        ' 
        radbtnVidTimeLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeTopCenterRight, Nothing)
        radbtnVidTimeLocationModeTopCenterRight.Location = New Point(86, 19)
        radbtnVidTimeLocationModeTopCenterRight.Name = "radbtnVidTimeLocationModeTopCenterRight"
        radbtnVidTimeLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopCenterRight.TabIndex = 4
        TipInfoEX.SetText(radbtnVidTimeLocationModeTopCenterRight, Nothing)
        radbtnVidTimeLocationModeTopCenterRight.Text = "  "
        radbtnVidTimeLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeRightCenter
        ' 
        radbtnVidTimeLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeRightCenter, Nothing)
        radbtnVidTimeLocationModeRightCenter.Location = New Point(113, 71)
        radbtnVidTimeLocationModeRightCenter.Name = "radbtnVidTimeLocationModeRightCenter"
        radbtnVidTimeLocationModeRightCenter.Size = New Size(16, 16)
        radbtnVidTimeLocationModeRightCenter.TabIndex = 7
        TipInfoEX.SetText(radbtnVidTimeLocationModeRightCenter, Nothing)
        radbtnVidTimeLocationModeRightCenter.Text = "  "
        radbtnVidTimeLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnVidTimeLocationModeTopLeft
        ' 
        radbtnVidTimeLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnVidTimeLocationModeTopLeft, Nothing)
        radbtnVidTimeLocationModeTopLeft.Location = New Point(5, 19)
        radbtnVidTimeLocationModeTopLeft.Name = "radbtnVidTimeLocationModeTopLeft"
        radbtnVidTimeLocationModeTopLeft.Size = New Size(16, 16)
        radbtnVidTimeLocationModeTopLeft.TabIndex = 1
        TipInfoEX.SetText(radbtnVidTimeLocationModeTopLeft, Nothing)
        radbtnVidTimeLocationModeTopLeft.Text = "  "
        radbtnVidTimeLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSaveSettings.Image = My.Resources.Resources.ImageSave32
        TipInfoEX.SetImage(btnSaveSettings, My.Resources.Resources.ImageSave16)
        btnSaveSettings.Location = New Point(12, 24)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(48, 48)
        btnSaveSettings.TabIndex = 100
        TipInfoEX.SetText(btnSaveSettings, "Save All Settings")
        btnSaveSettings.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnSaveSettings, "Save All Settings")
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnRestoreSettings
        ' 
        btnRestoreSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRestoreSettings.Image = My.Resources.Resources.ImageUndo32
        TipInfoEX.SetImage(btnRestoreSettings, My.Resources.Resources.ImageUndo16)
        btnRestoreSettings.Location = New Point(73, 24)
        btnRestoreSettings.Name = "btnRestoreSettings"
        btnRestoreSettings.Size = New Size(48, 48)
        btnRestoreSettings.TabIndex = 101
        TipInfoEX.SetText(btnRestoreSettings, "Restore All Settings")
        btnRestoreSettings.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnRestoreSettings, "Restore All Settings")
        btnRestoreSettings.UseVisualStyleBackColor = True
        ' 
        ' radioButton16
        ' 
        radioButton16.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton16, Nothing)
        radioButton16.Location = New Point(0, 42)
        radioButton16.Name = "radioButton16"
        radioButton16.Size = New Size(21, 24)
        radioButton16.TabIndex = 16
        TipInfoEX.SetText(radioButton16, Nothing)
        radioButton16.UseVisualStyleBackColor = True
        ' 
        ' radioButton17
        ' 
        radioButton17.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton17, Nothing)
        radioButton17.Location = New Point(0, 135)
        radioButton17.Name = "radioButton17"
        radioButton17.Size = New Size(21, 24)
        radioButton17.TabIndex = 13
        TipInfoEX.SetText(radioButton17, Nothing)
        radioButton17.UseVisualStyleBackColor = True
        ' 
        ' radioButton18
        ' 
        radioButton18.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton18, Nothing)
        radioButton18.Location = New Point(140, 42)
        radioButton18.Name = "radioButton18"
        radioButton18.Size = New Size(21, 24)
        radioButton18.TabIndex = 6
        TipInfoEX.SetText(radioButton18, Nothing)
        radioButton18.UseVisualStyleBackColor = True
        ' 
        ' radioButton19
        ' 
        radioButton19.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton19, Nothing)
        radioButton19.Location = New Point(140, 104)
        radioButton19.Name = "radioButton19"
        radioButton19.Size = New Size(21, 24)
        radioButton19.TabIndex = 8
        TipInfoEX.SetText(radioButton19, Nothing)
        radioButton19.UseVisualStyleBackColor = True
        ' 
        ' radioButton20
        ' 
        radioButton20.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton20, Nothing)
        radioButton20.Location = New Point(105, 135)
        radioButton20.Name = "radioButton20"
        radioButton20.Size = New Size(21, 24)
        radioButton20.TabIndex = 10
        TipInfoEX.SetText(radioButton20, Nothing)
        radioButton20.UseVisualStyleBackColor = True
        ' 
        ' radioButton21
        ' 
        radioButton21.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton21, Nothing)
        radioButton21.Location = New Point(35, 135)
        radioButton21.Name = "radioButton21"
        radioButton21.Size = New Size(21, 24)
        radioButton21.TabIndex = 12
        TipInfoEX.SetText(radioButton21, Nothing)
        radioButton21.UseVisualStyleBackColor = True
        ' 
        ' radioButton22
        ' 
        radioButton22.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton22, Nothing)
        radioButton22.Location = New Point(140, 135)
        radioButton22.Name = "radioButton22"
        radioButton22.Size = New Size(21, 24)
        radioButton22.TabIndex = 8
        TipInfoEX.SetText(radioButton22, Nothing)
        radioButton22.UseVisualStyleBackColor = True
        ' 
        ' radioButton23
        ' 
        radioButton23.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton23, Nothing)
        radioButton23.Location = New Point(0, 104)
        radioButton23.Name = "radioButton23"
        radioButton23.Size = New Size(21, 24)
        radioButton23.TabIndex = 14
        TipInfoEX.SetText(radioButton23, Nothing)
        radioButton23.UseVisualStyleBackColor = True
        ' 
        ' radioButton24
        ' 
        radioButton24.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton24, Nothing)
        radioButton24.Location = New Point(70, 135)
        radioButton24.Name = "radioButton24"
        radioButton24.Size = New Size(21, 24)
        radioButton24.TabIndex = 11
        TipInfoEX.SetText(radioButton24, Nothing)
        radioButton24.UseVisualStyleBackColor = True
        ' 
        ' radioButton25
        ' 
        radioButton25.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton25, Nothing)
        radioButton25.Location = New Point(0, 73)
        radioButton25.Name = "radioButton25"
        radioButton25.Size = New Size(21, 24)
        radioButton25.TabIndex = 15
        TipInfoEX.SetText(radioButton25, Nothing)
        radioButton25.UseVisualStyleBackColor = True
        ' 
        ' radioButton26
        ' 
        radioButton26.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton26, Nothing)
        radioButton26.Location = New Point(35, 11)
        radioButton26.Name = "radioButton26"
        radioButton26.Size = New Size(21, 24)
        radioButton26.TabIndex = 2
        TipInfoEX.SetText(radioButton26, Nothing)
        radioButton26.UseVisualStyleBackColor = True
        ' 
        ' radioButton27
        ' 
        radioButton27.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton27, Nothing)
        radioButton27.Location = New Point(70, 11)
        radioButton27.Name = "radioButton27"
        radioButton27.Size = New Size(21, 24)
        radioButton27.TabIndex = 3
        TipInfoEX.SetText(radioButton27, Nothing)
        radioButton27.UseVisualStyleBackColor = True
        ' 
        ' radioButton28
        ' 
        radioButton28.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton28, Nothing)
        radioButton28.Location = New Point(140, 11)
        radioButton28.Name = "radioButton28"
        radioButton28.Size = New Size(21, 24)
        radioButton28.TabIndex = 5
        TipInfoEX.SetText(radioButton28, Nothing)
        radioButton28.UseVisualStyleBackColor = True
        ' 
        ' radioButton29
        ' 
        radioButton29.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton29, Nothing)
        radioButton29.Location = New Point(105, 11)
        radioButton29.Name = "radioButton29"
        radioButton29.Size = New Size(21, 24)
        radioButton29.TabIndex = 4
        TipInfoEX.SetText(radioButton29, Nothing)
        radioButton29.UseVisualStyleBackColor = True
        ' 
        ' radioButton30
        ' 
        radioButton30.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton30, Nothing)
        radioButton30.Location = New Point(140, 73)
        radioButton30.Name = "radioButton30"
        radioButton30.Size = New Size(21, 24)
        radioButton30.TabIndex = 7
        TipInfoEX.SetText(radioButton30, Nothing)
        radioButton30.UseVisualStyleBackColor = True
        ' 
        ' radioButton31
        ' 
        radioButton31.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton31, Nothing)
        radioButton31.Location = New Point(0, 11)
        radioButton31.Name = "radioButton31"
        radioButton31.Size = New Size(21, 24)
        radioButton31.TabIndex = 1
        TipInfoEX.SetText(radioButton31, Nothing)
        radioButton31.UseVisualStyleBackColor = True
        ' 
        ' radioButton32
        ' 
        radioButton32.CheckAlign = ContentAlignment.MiddleCenter
        radioButton32.Cursor = Cursors.Hand
        TipInfoEX.SetImage(radioButton32, Nothing)
        radioButton32.Location = New Point(57, 59)
        radioButton32.Name = "radioButton32"
        radioButton32.Size = New Size(48, 51)
        radioButton32.TabIndex = 0
        TipInfoEX.SetText(radioButton32, Nothing)
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
        btnErrorTest.Image = My.Resources.Resources.ImageError32
        TipInfoEX.SetImage(btnErrorTest, My.Resources.Resources.ImageError16)
        btnErrorTest.Location = New Point(153, 24)
        btnErrorTest.Name = "btnErrorTest"
        btnErrorTest.Size = New Size(48, 48)
        btnErrorTest.TabIndex = 0
        btnErrorTest.TabStop = False
        TipInfoEX.SetText(btnErrorTest, "LeftClick = Test Error" & vbCrLf & "RightClick = Cause Exception")
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
        btnInfo.Image = My.Resources.Resources.ImageInfo32
        TipInfoEX.SetImage(btnInfo, My.Resources.Resources.ImageInfo)
        btnInfo.Location = New Point(796, 24)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(48, 48)
        btnInfo.TabIndex = 105
        TipInfoEX.SetText(btnInfo, "Show Help & About")
        btnInfo.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnInfo, "Help & About")
        btnInfo.UseVisualStyleBackColor = True
        ' 
        ' btnlvPicFolders
        ' 
        btnlvPicFolders.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnlvPicFolders.FlatAppearance.BorderSize = 0
        btnlvPicFolders.Image = My.Resources.Resources.imageFolder
        TipInfoEX.SetImage(btnlvPicFolders, My.Resources.Resources.imageFolder)
        btnlvPicFolders.ImageAlign = ContentAlignment.MiddleLeft
        btnlvPicFolders.Location = New Point(507, 98)
        btnlvPicFolders.Name = "btnlvPicFolders"
        btnlvPicFolders.Size = New Size(202, 32)
        btnlvPicFolders.TabIndex = 5
        btnlvPicFolders.TabStop = False
        TipInfoEX.SetText(btnlvPicFolders, "Folder List View Mode")
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
        TipInfoEX.SetImage(btnRefreshPicList, My.Resources.Resources.imageRefresh)
        btnRefreshPicList.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshPicList.Location = New Point(715, 98)
        btnRefreshPicList.Name = "btnRefreshPicList"
        btnRefreshPicList.Size = New Size(100, 32)
        btnRefreshPicList.TabIndex = 6
        btnRefreshPicList.TabStop = False
        TipInfoEX.SetText(btnRefreshPicList, "LeftClick = Refresh Picture List (Ctrl = Reset)" & vbCrLf & "RightClick = Refresh All File Lists (Ctrl = Reset)")
        btnRefreshPicList.Text = "Refresh"
        btnRefreshPicList.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnRefreshPicList, "LeftClick = Refresh Picture List (Ctrl = Reset)" & vbCrLf & "RightClick = Refresh All File Lists (Ctrl = Reset)")
        btnRefreshPicList.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicPlayModeLinearWithRandomStart
        ' 
        TipInfoEX.SetImage(radbtnPicPlayModeLinearWithRandomStart, Nothing)
        radbtnPicPlayModeLinearWithRandomStart.Location = New Point(91, 22)
        radbtnPicPlayModeLinearWithRandomStart.Name = "radbtnPicPlayModeLinearWithRandomStart"
        radbtnPicPlayModeLinearWithRandomStart.Size = New Size(91, 33)
        radbtnPicPlayModeLinearWithRandomStart.TabIndex = 1
        TipInfoEX.SetText(radbtnPicPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnPicPlayModeLinearWithRandomStart.Text = "Linear +"
        tipInfo.SetToolTip(radbtnPicPlayModeLinearWithRandomStart, "Linear With Random Start")
        radbtnPicPlayModeLinearWithRandomStart.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLog.Image = My.Resources.Resources.ImageLog32
        TipInfoEX.SetImage(btnLog, Nothing)
        btnLog.Location = New Point(857, 24)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(48, 48)
        btnLog.TabIndex = 106
        TipInfoEX.SetText(btnLog, Nothing)
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
        TipInfoEX.SetImage(PanelApp, Nothing)
        PanelApp.Location = New Point(91, 0)
        PanelApp.Name = "PanelApp"
        PanelApp.Size = New Size(826, 534)
        PanelApp.TabIndex = 107
        TipInfoEX.SetText(PanelApp, Nothing)
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
        TipInfoEX.SetImage(PanelPics, Nothing)
        PanelPics.Location = New Point(91, 0)
        PanelPics.Name = "PanelPics"
        PanelPics.Size = New Size(826, 534)
        PanelPics.TabIndex = 108
        TipInfoEX.SetText(PanelPics, Nothing)
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
        TipInfoEX.SetImage(grbxHotKeysPics, Nothing)
        grbxHotKeysPics.Location = New Point(564, 307)
        grbxHotKeysPics.Name = "grbxHotKeysPics"
        grbxHotKeysPics.Size = New Size(250, 215)
        grbxHotKeysPics.TabIndex = 50
        grbxHotKeysPics.TabStop = False
        grbxHotKeysPics.Text = "HotKeys"
        TipInfoEX.SetText(grbxHotKeysPics, Nothing)
        ' 
        ' txbxHotKeyPicToggle
        ' 
        TipInfoEX.SetImage(txbxHotKeyPicToggle, Nothing)
        txbxHotKeyPicToggle.Location = New Point(8, 41)
        txbxHotKeyPicToggle.Name = "txbxHotKeyPicToggle"
        txbxHotKeyPicToggle.ShortcutsEnabled = False
        txbxHotKeyPicToggle.Size = New Size(203, 29)
        txbxHotKeyPicToggle.TabIndex = 45
        txbxHotKeyPicToggle.TabStop = False
        TipInfoEX.SetText(txbxHotKeyPicToggle, Nothing)
        txbxHotKeyPicToggle.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicToggle.WordWrap = False
        ' 
        ' btnHotKeyPicToggleDisable
        ' 
        btnHotKeyPicToggleDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicToggleDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyPicToggleDisable, Nothing)
        btnHotKeyPicToggleDisable.Location = New Point(211, 40)
        btnHotKeyPicToggleDisable.Name = "btnHotKeyPicToggleDisable"
        btnHotKeyPicToggleDisable.Size = New Size(31, 31)
        btnHotKeyPicToggleDisable.TabIndex = 46
        btnHotKeyPicToggleDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyPicToggleDisable, Nothing)
        btnHotKeyPicToggleDisable.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyPicToggleFullScreen
        ' 
        TipInfoEX.SetImage(txbxHotKeyPicToggleFullScreen, Nothing)
        txbxHotKeyPicToggleFullScreen.Location = New Point(8, 92)
        txbxHotKeyPicToggleFullScreen.Name = "txbxHotKeyPicToggleFullScreen"
        txbxHotKeyPicToggleFullScreen.ShortcutsEnabled = False
        txbxHotKeyPicToggleFullScreen.Size = New Size(203, 29)
        txbxHotKeyPicToggleFullScreen.TabIndex = 42
        txbxHotKeyPicToggleFullScreen.TabStop = False
        TipInfoEX.SetText(txbxHotKeyPicToggleFullScreen, Nothing)
        txbxHotKeyPicToggleFullScreen.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicToggleFullScreen.WordWrap = False
        ' 
        ' btnHotKeyPicToggleFullScreenDisable
        ' 
        btnHotKeyPicToggleFullScreenDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicToggleFullScreenDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyPicToggleFullScreenDisable, Nothing)
        btnHotKeyPicToggleFullScreenDisable.Location = New Point(211, 91)
        btnHotKeyPicToggleFullScreenDisable.Name = "btnHotKeyPicToggleFullScreenDisable"
        btnHotKeyPicToggleFullScreenDisable.Size = New Size(31, 31)
        btnHotKeyPicToggleFullScreenDisable.TabIndex = 43
        btnHotKeyPicToggleFullScreenDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyPicToggleFullScreenDisable, Nothing)
        btnHotKeyPicToggleFullScreenDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysPicsUndo
        ' 
        btnHotKeysPicsUndo.Image = My.Resources.Resources.ImageUndo16
        TipInfoEX.SetImage(btnHotKeysPicsUndo, Nothing)
        btnHotKeysPicsUndo.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysPicsUndo.Location = New Point(7, 175)
        btnHotKeysPicsUndo.Name = "btnHotKeysPicsUndo"
        btnHotKeysPicsUndo.Size = New Size(96, 32)
        btnHotKeysPicsUndo.TabIndex = 30
        btnHotKeysPicsUndo.TabStop = False
        TipInfoEX.SetText(btnHotKeysPicsUndo, Nothing)
        btnHotKeysPicsUndo.Text = "Undo"
        btnHotKeysPicsUndo.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysPicsUndo.UseVisualStyleBackColor = True
        ' 
        ' btnHotKeysPicsSet
        ' 
        btnHotKeysPicsSet.Image = My.Resources.Resources.imageGo
        TipInfoEX.SetImage(btnHotKeysPicsSet, Nothing)
        btnHotKeysPicsSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHotKeysPicsSet.Location = New Point(137, 175)
        btnHotKeysPicsSet.Name = "btnHotKeysPicsSet"
        btnHotKeysPicsSet.Size = New Size(96, 32)
        btnHotKeysPicsSet.TabIndex = 40
        btnHotKeysPicsSet.TabStop = False
        TipInfoEX.SetText(btnHotKeysPicsSet, Nothing)
        btnHotKeysPicsSet.Text = "Set"
        btnHotKeysPicsSet.TextAlign = ContentAlignment.MiddleRight
        btnHotKeysPicsSet.UseVisualStyleBackColor = True
        ' 
        ' txbxHotKeyPicShowFileInfo
        ' 
        TipInfoEX.SetImage(txbxHotKeyPicShowFileInfo, Nothing)
        txbxHotKeyPicShowFileInfo.Location = New Point(8, 142)
        txbxHotKeyPicShowFileInfo.Name = "txbxHotKeyPicShowFileInfo"
        txbxHotKeyPicShowFileInfo.ShortcutsEnabled = False
        txbxHotKeyPicShowFileInfo.Size = New Size(203, 29)
        txbxHotKeyPicShowFileInfo.TabIndex = 10
        txbxHotKeyPicShowFileInfo.TabStop = False
        TipInfoEX.SetText(txbxHotKeyPicShowFileInfo, Nothing)
        txbxHotKeyPicShowFileInfo.TextAlign = HorizontalAlignment.Center
        txbxHotKeyPicShowFileInfo.WordWrap = False
        ' 
        ' btnHotKeyPicShowFileInfoDisable
        ' 
        btnHotKeyPicShowFileInfoDisable.FlatAppearance.BorderSize = 0
        btnHotKeyPicShowFileInfoDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHotKeyPicShowFileInfoDisable, Nothing)
        btnHotKeyPicShowFileInfoDisable.Location = New Point(211, 141)
        btnHotKeyPicShowFileInfoDisable.Name = "btnHotKeyPicShowFileInfoDisable"
        btnHotKeyPicShowFileInfoDisable.Size = New Size(31, 31)
        btnHotKeyPicShowFileInfoDisable.TabIndex = 20
        btnHotKeyPicShowFileInfoDisable.TabStop = False
        TipInfoEX.SetText(btnHotKeyPicShowFileInfoDisable, Nothing)
        btnHotKeyPicShowFileInfoDisable.UseVisualStyleBackColor = True
        ' 
        ' lblHotKeyPicToggle
        ' 
        lblHotKeyPicToggle.BackColor = Color.Transparent
        lblHotKeyPicToggle.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyPicToggle, Nothing)
        lblHotKeyPicToggle.Location = New Point(8, 18)
        lblHotKeyPicToggle.Name = "lblHotKeyPicToggle"
        lblHotKeyPicToggle.Size = New Size(203, 23)
        lblHotKeyPicToggle.TabIndex = 44
        lblHotKeyPicToggle.Text = "PicToggle"
        TipInfoEX.SetText(lblHotKeyPicToggle, Nothing)
        lblHotKeyPicToggle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHotKeyPicToggleFullScreen
        ' 
        lblHotKeyPicToggleFullScreen.BackColor = Color.Transparent
        lblHotKeyPicToggleFullScreen.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyPicToggleFullScreen, Nothing)
        lblHotKeyPicToggleFullScreen.Location = New Point(8, 69)
        lblHotKeyPicToggleFullScreen.Name = "lblHotKeyPicToggleFullScreen"
        lblHotKeyPicToggleFullScreen.Size = New Size(203, 23)
        lblHotKeyPicToggleFullScreen.TabIndex = 41
        lblHotKeyPicToggleFullScreen.Text = "PicToggleFullScreen"
        TipInfoEX.SetText(lblHotKeyPicToggleFullScreen, Nothing)
        lblHotKeyPicToggleFullScreen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHotKeyPicShowFileInfo
        ' 
        lblHotKeyPicShowFileInfo.BackColor = Color.Transparent
        lblHotKeyPicShowFileInfo.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblHotKeyPicShowFileInfo, Nothing)
        lblHotKeyPicShowFileInfo.Location = New Point(8, 119)
        lblHotKeyPicShowFileInfo.Name = "lblHotKeyPicShowFileInfo"
        lblHotKeyPicShowFileInfo.Size = New Size(203, 23)
        lblHotKeyPicShowFileInfo.TabIndex = 0
        lblHotKeyPicShowFileInfo.Text = "PicShowFileInfo"
        TipInfoEX.SetText(lblHotKeyPicShowFileInfo, Nothing)
        lblHotKeyPicShowFileInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lvPicFolders
        ' 
        lvPicFolders.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lvPicFolders.BorderStyle = BorderStyle.FixedSingle
        lvPicFolders.ContextMenuStrip = cmList
        lvPicFolders.FullRowSelect = True
        lvPicFolders.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(lvPicFolders, Nothing)
        lvPicFolders.LabelWrap = False
        lvPicFolders.Location = New Point(12, 12)
        lvPicFolders.MultiSelect = False
        lvPicFolders.Name = "lvPicFolders"
        lvPicFolders.ShowGroups = False
        lvPicFolders.Size = New Size(802, 86)
        lvPicFolders.TabIndex = 1
        lvPicFolders.TabStop = False
        TipInfoEX.SetText(lvPicFolders, Nothing)
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
        TipInfoEX.SetImage(gpbxPicTimerCountdownLocationMode, Nothing)
        gpbxPicTimerCountdownLocationMode.Location = New Point(293, 371)
        gpbxPicTimerCountdownLocationMode.Name = "gpbxPicTimerCountdownLocationMode"
        gpbxPicTimerCountdownLocationMode.Size = New Size(133, 150)
        gpbxPicTimerCountdownLocationMode.TabIndex = 80
        gpbxPicTimerCountdownLocationMode.TabStop = False
        gpbxPicTimerCountdownLocationMode.Text = "Timer Location"
        TipInfoEX.SetText(gpbxPicTimerCountdownLocationMode, Nothing)
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenterTop
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeLeftCenterTop, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Location = New Point(5, 50)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Name = "radbtnPicTimerCountdownLocationModeLeftCenterTop"
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.TabIndex = 16
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeLeftCenterTop, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenterTop.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomLeft
        ' 
        radbtnPicTimerCountdownLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeBottomLeft, Nothing)
        radbtnPicTimerCountdownLocationModeBottomLeft.Location = New Point(5, 128)
        radbtnPicTimerCountdownLocationModeBottomLeft.Name = "radbtnPicTimerCountdownLocationModeBottomLeft"
        radbtnPicTimerCountdownLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomLeft.TabIndex = 13
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeBottomLeft, Nothing)
        radbtnPicTimerCountdownLocationModeBottomLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenterTop
        ' 
        radbtnPicTimerCountdownLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeRightCenterTop, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenterTop.Location = New Point(113, 50)
        radbtnPicTimerCountdownLocationModeRightCenterTop.Name = "radbtnPicTimerCountdownLocationModeRightCenterTop"
        radbtnPicTimerCountdownLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenterTop.TabIndex = 6
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeRightCenterTop, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenterTop.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenterBottom
        ' 
        radbtnPicTimerCountdownLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeRightCenterBottom, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Location = New Point(113, 102)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Name = "radbtnPicTimerCountdownLocationModeRightCenterBottom"
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.TabIndex = 8
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeRightCenterBottom, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenterBottom.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenterRight
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeBottomCenterRight, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Location = New Point(86, 128)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Name = "radbtnPicTimerCountdownLocationModeBottomCenterRight"
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.TabIndex = 10
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeBottomCenterRight, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenterRight.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenterLeft
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeBottomCenterLeft, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Location = New Point(32, 128)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Name = "radbtnPicTimerCountdownLocationModeBottomCenterLeft"
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.TabIndex = 12
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeBottomCenterLeft, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomRight
        ' 
        radbtnPicTimerCountdownLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeBottomRight, Nothing)
        radbtnPicTimerCountdownLocationModeBottomRight.Location = New Point(113, 128)
        radbtnPicTimerCountdownLocationModeBottomRight.Name = "radbtnPicTimerCountdownLocationModeBottomRight"
        radbtnPicTimerCountdownLocationModeBottomRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomRight.TabIndex = 8
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeBottomRight, Nothing)
        radbtnPicTimerCountdownLocationModeBottomRight.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenterBottom
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeLeftCenterBottom, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Location = New Point(5, 102)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Name = "radbtnPicTimerCountdownLocationModeLeftCenterBottom"
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.TabIndex = 14
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeLeftCenterBottom, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeBottomCenter
        ' 
        radbtnPicTimerCountdownLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeBottomCenter, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenter.Location = New Point(59, 128)
        radbtnPicTimerCountdownLocationModeBottomCenter.Name = "radbtnPicTimerCountdownLocationModeBottomCenter"
        radbtnPicTimerCountdownLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeBottomCenter.TabIndex = 11
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeBottomCenter, Nothing)
        radbtnPicTimerCountdownLocationModeBottomCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeLeftCenter
        ' 
        radbtnPicTimerCountdownLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeLeftCenter, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenter.Location = New Point(5, 76)
        radbtnPicTimerCountdownLocationModeLeftCenter.Name = "radbtnPicTimerCountdownLocationModeLeftCenter"
        radbtnPicTimerCountdownLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeLeftCenter.TabIndex = 15
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeLeftCenter, Nothing)
        radbtnPicTimerCountdownLocationModeLeftCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenterLeft
        ' 
        radbtnPicTimerCountdownLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeTopCenterLeft, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Location = New Point(32, 24)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Name = "radbtnPicTimerCountdownLocationModeTopCenterLeft"
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.TabIndex = 2
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeTopCenterLeft, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenterLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenter
        ' 
        radbtnPicTimerCountdownLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeTopCenter, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenter.Location = New Point(59, 24)
        radbtnPicTimerCountdownLocationModeTopCenter.Name = "radbtnPicTimerCountdownLocationModeTopCenter"
        radbtnPicTimerCountdownLocationModeTopCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenter.TabIndex = 3
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeTopCenter, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopRight
        ' 
        radbtnPicTimerCountdownLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeTopRight, Nothing)
        radbtnPicTimerCountdownLocationModeTopRight.Location = New Point(113, 24)
        radbtnPicTimerCountdownLocationModeTopRight.Name = "radbtnPicTimerCountdownLocationModeTopRight"
        radbtnPicTimerCountdownLocationModeTopRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopRight.TabIndex = 5
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeTopRight, Nothing)
        radbtnPicTimerCountdownLocationModeTopRight.Text = "  "
        radbtnPicTimerCountdownLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopCenterRight
        ' 
        radbtnPicTimerCountdownLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeTopCenterRight, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenterRight.Location = New Point(86, 24)
        radbtnPicTimerCountdownLocationModeTopCenterRight.Name = "radbtnPicTimerCountdownLocationModeTopCenterRight"
        radbtnPicTimerCountdownLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopCenterRight.TabIndex = 4
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeTopCenterRight, Nothing)
        radbtnPicTimerCountdownLocationModeTopCenterRight.Text = "  "
        radbtnPicTimerCountdownLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeRightCenter
        ' 
        radbtnPicTimerCountdownLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeRightCenter, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenter.Location = New Point(113, 76)
        radbtnPicTimerCountdownLocationModeRightCenter.Name = "radbtnPicTimerCountdownLocationModeRightCenter"
        radbtnPicTimerCountdownLocationModeRightCenter.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeRightCenter.TabIndex = 7
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeRightCenter, Nothing)
        radbtnPicTimerCountdownLocationModeRightCenter.Text = "  "
        radbtnPicTimerCountdownLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicTimerCountdownLocationModeTopLeft
        ' 
        radbtnPicTimerCountdownLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicTimerCountdownLocationModeTopLeft, Nothing)
        radbtnPicTimerCountdownLocationModeTopLeft.Location = New Point(5, 24)
        radbtnPicTimerCountdownLocationModeTopLeft.Name = "radbtnPicTimerCountdownLocationModeTopLeft"
        radbtnPicTimerCountdownLocationModeTopLeft.Size = New Size(16, 16)
        radbtnPicTimerCountdownLocationModeTopLeft.TabIndex = 1
        TipInfoEX.SetText(radbtnPicTimerCountdownLocationModeTopLeft, Nothing)
        radbtnPicTimerCountdownLocationModeTopLeft.Text = "  "
        radbtnPicTimerCountdownLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' chbxPicTimerCountdown
        ' 
        TipInfoEX.SetImage(chbxPicTimerCountdown, Nothing)
        chbxPicTimerCountdown.Location = New Point(295, 341)
        chbxPicTimerCountdown.Name = "chbxPicTimerCountdown"
        chbxPicTimerCountdown.Size = New Size(204, 30)
        chbxPicTimerCountdown.TabIndex = 75
        TipInfoEX.SetText(chbxPicTimerCountdown, Nothing)
        chbxPicTimerCountdown.Text = "Show Timer Countdown"
        chbxPicTimerCountdown.UseVisualStyleBackColor = True
        ' 
        ' txbxPicTimerInterval
        ' 
        TipInfoEX.SetImage(txbxPicTimerInterval, Nothing)
        txbxPicTimerInterval.Location = New Point(295, 314)
        txbxPicTimerInterval.MaxLength = 5
        txbxPicTimerInterval.Name = "txbxPicTimerInterval"
        txbxPicTimerInterval.Size = New Size(80, 29)
        txbxPicTimerInterval.TabIndex = 70
        TipInfoEX.SetText(txbxPicTimerInterval, Nothing)
        txbxPicTimerInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' chbxPicAutoView
        ' 
        chbxPicAutoView.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(chbxPicAutoView, Nothing)
        chbxPicAutoView.Location = New Point(666, 140)
        chbxPicAutoView.Name = "chbxPicAutoView"
        chbxPicAutoView.Size = New Size(99, 37)
        chbxPicAutoView.TabIndex = 30
        TipInfoEX.SetText(chbxPicAutoView, Nothing)
        chbxPicAutoView.Text = "AutoView"
        chbxPicAutoView.UseVisualStyleBackColor = True
        ' 
        ' gpbxPicJustify
        ' 
        gpbxPicJustify.Controls.Add(radbtnPicJustifyCenter)
        gpbxPicJustify.Controls.Add(radbtnPicJustifyLeft)
        gpbxPicJustify.Controls.Add(radbtnPicJustifyRight)
        TipInfoEX.SetImage(gpbxPicJustify, Nothing)
        gpbxPicJustify.Location = New Point(285, 140)
        gpbxPicJustify.Name = "gpbxPicJustify"
        gpbxPicJustify.Size = New Size(242, 65)
        gpbxPicJustify.TabIndex = 20
        gpbxPicJustify.TabStop = False
        gpbxPicJustify.Text = "Fullscreen Justify"
        TipInfoEX.SetText(gpbxPicJustify, Nothing)
        ' 
        ' radbtnPicJustifyCenter
        ' 
        radbtnPicJustifyCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicJustifyCenter, Nothing)
        radbtnPicJustifyCenter.Location = New Point(99, 22)
        radbtnPicJustifyCenter.Name = "radbtnPicJustifyCenter"
        radbtnPicJustifyCenter.Size = New Size(33, 33)
        radbtnPicJustifyCenter.TabIndex = 3
        TipInfoEX.SetText(radbtnPicJustifyCenter, Nothing)
        radbtnPicJustifyCenter.Text = "  "
        radbtnPicJustifyCenter.TextAlign = ContentAlignment.MiddleCenter
        radbtnPicJustifyCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicJustifyLeft
        ' 
        TipInfoEX.SetImage(radbtnPicJustifyLeft, Nothing)
        radbtnPicJustifyLeft.Location = New Point(17, 22)
        radbtnPicJustifyLeft.Name = "radbtnPicJustifyLeft"
        radbtnPicJustifyLeft.Size = New Size(55, 33)
        radbtnPicJustifyLeft.TabIndex = 1
        TipInfoEX.SetText(radbtnPicJustifyLeft, Nothing)
        radbtnPicJustifyLeft.Text = "Left"
        radbtnPicJustifyLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicJustifyRight
        ' 
        radbtnPicJustifyRight.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(radbtnPicJustifyRight, Nothing)
        radbtnPicJustifyRight.Location = New Point(149, 22)
        radbtnPicJustifyRight.Name = "radbtnPicJustifyRight"
        radbtnPicJustifyRight.Size = New Size(77, 33)
        radbtnPicJustifyRight.TabIndex = 5
        TipInfoEX.SetText(radbtnPicJustifyRight, Nothing)
        radbtnPicJustifyRight.Text = "Right"
        radbtnPicJustifyRight.TextAlign = ContentAlignment.MiddleRight
        radbtnPicJustifyRight.UseVisualStyleBackColor = True
        ' 
        ' chbxPicLockFullScreen
        ' 
        chbxPicLockFullScreen.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(chbxPicLockFullScreen, Nothing)
        chbxPicLockFullScreen.Location = New Point(327, 205)
        chbxPicLockFullScreen.Name = "chbxPicLockFullScreen"
        chbxPicLockFullScreen.Size = New Size(145, 26)
        chbxPicLockFullScreen.TabIndex = 25
        TipInfoEX.SetText(chbxPicLockFullScreen, Nothing)
        chbxPicLockFullScreen.Text = "Lock Fullscreen"
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
        TipInfoEX.SetImage(gpbxPicLocationMode, Nothing)
        gpbxPicLocationMode.Location = New Point(12, 299)
        gpbxPicLocationMode.Name = "gpbxPicLocationMode"
        gpbxPicLocationMode.Size = New Size(214, 224)
        gpbxPicLocationMode.TabIndex = 40
        gpbxPicLocationMode.TabStop = False
        gpbxPicLocationMode.Text = "Image Location"
        TipInfoEX.SetText(gpbxPicLocationMode, Nothing)
        ' 
        ' radbtnPicLocationModeTopLeftInside
        ' 
        radbtnPicLocationModeTopLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopLeftInside, Nothing)
        radbtnPicLocationModeTopLeftInside.Location = New Point(43, 56)
        radbtnPicLocationModeTopLeftInside.Name = "radbtnPicLocationModeTopLeftInside"
        radbtnPicLocationModeTopLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopLeftInside.TabIndex = 91
        TipInfoEX.SetText(radbtnPicLocationModeTopLeftInside, Nothing)
        radbtnPicLocationModeTopLeftInside.Text = "  "
        radbtnPicLocationModeTopLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomLeftInside
        ' 
        radbtnPicLocationModeBottomLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomLeftInside, Nothing)
        radbtnPicLocationModeBottomLeftInside.Location = New Point(43, 168)
        radbtnPicLocationModeBottomLeftInside.Name = "radbtnPicLocationModeBottomLeftInside"
        radbtnPicLocationModeBottomLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomLeftInside.TabIndex = 92
        TipInfoEX.SetText(radbtnPicLocationModeBottomLeftInside, Nothing)
        radbtnPicLocationModeBottomLeftInside.Text = "  "
        radbtnPicLocationModeBottomLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomRightInside
        ' 
        radbtnPicLocationModeBottomRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomRightInside, Nothing)
        radbtnPicLocationModeBottomRightInside.Location = New Point(155, 168)
        radbtnPicLocationModeBottomRightInside.Name = "radbtnPicLocationModeBottomRightInside"
        radbtnPicLocationModeBottomRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomRightInside.TabIndex = 93
        TipInfoEX.SetText(radbtnPicLocationModeBottomRightInside, Nothing)
        radbtnPicLocationModeBottomRightInside.Text = "  "
        radbtnPicLocationModeBottomRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopRightInside
        ' 
        radbtnPicLocationModeTopRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopRightInside, Nothing)
        radbtnPicLocationModeTopRightInside.Location = New Point(155, 56)
        radbtnPicLocationModeTopRightInside.Name = "radbtnPicLocationModeTopRightInside"
        radbtnPicLocationModeTopRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopRightInside.TabIndex = 96
        TipInfoEX.SetText(radbtnPicLocationModeTopRightInside, Nothing)
        radbtnPicLocationModeTopRightInside.Text = "  "
        radbtnPicLocationModeTopRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterTop
        ' 
        radbtnPicLocationModeLeftCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenterTop, Nothing)
        radbtnPicLocationModeLeftCenterTop.Location = New Point(15, 70)
        radbtnPicLocationModeLeftCenterTop.Name = "radbtnPicLocationModeLeftCenterTop"
        radbtnPicLocationModeLeftCenterTop.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterTop.TabIndex = 16
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenterTop, Nothing)
        radbtnPicLocationModeLeftCenterTop.Text = "  "
        radbtnPicLocationModeLeftCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomLeft
        ' 
        radbtnPicLocationModeBottomLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomLeft, Nothing)
        radbtnPicLocationModeBottomLeft.Location = New Point(15, 196)
        radbtnPicLocationModeBottomLeft.Name = "radbtnPicLocationModeBottomLeft"
        radbtnPicLocationModeBottomLeft.Size = New Size(16, 16)
        radbtnPicLocationModeBottomLeft.TabIndex = 13
        TipInfoEX.SetText(radbtnPicLocationModeBottomLeft, Nothing)
        radbtnPicLocationModeBottomLeft.Text = "  "
        radbtnPicLocationModeBottomLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterBottomInside
        ' 
        radbtnPicLocationModeLeftCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenterBottomInside, Nothing)
        radbtnPicLocationModeLeftCenterBottomInside.Location = New Point(43, 140)
        radbtnPicLocationModeLeftCenterBottomInside.Name = "radbtnPicLocationModeLeftCenterBottomInside"
        radbtnPicLocationModeLeftCenterBottomInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterBottomInside.TabIndex = 90
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenterBottomInside, Nothing)
        radbtnPicLocationModeLeftCenterBottomInside.Text = "  "
        radbtnPicLocationModeLeftCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterInside
        ' 
        radbtnPicLocationModeLeftCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenterInside, Nothing)
        radbtnPicLocationModeLeftCenterInside.Location = New Point(43, 112)
        radbtnPicLocationModeLeftCenterInside.Name = "radbtnPicLocationModeLeftCenterInside"
        radbtnPicLocationModeLeftCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterInside.TabIndex = 94
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenterInside, Nothing)
        radbtnPicLocationModeLeftCenterInside.Text = "  "
        radbtnPicLocationModeLeftCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterTopInside
        ' 
        radbtnPicLocationModeLeftCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenterTopInside, Nothing)
        radbtnPicLocationModeLeftCenterTopInside.Location = New Point(43, 84)
        radbtnPicLocationModeLeftCenterTopInside.Name = "radbtnPicLocationModeLeftCenterTopInside"
        radbtnPicLocationModeLeftCenterTopInside.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterTopInside.TabIndex = 95
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenterTopInside, Nothing)
        radbtnPicLocationModeLeftCenterTopInside.Text = "  "
        radbtnPicLocationModeLeftCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterInside
        ' 
        radbtnPicLocationModeBottomCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenterInside, Nothing)
        radbtnPicLocationModeBottomCenterInside.Location = New Point(99, 168)
        radbtnPicLocationModeBottomCenterInside.Name = "radbtnPicLocationModeBottomCenterInside"
        radbtnPicLocationModeBottomCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterInside.TabIndex = 88
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenterInside, Nothing)
        radbtnPicLocationModeBottomCenterInside.Text = "  "
        radbtnPicLocationModeBottomCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterInside
        ' 
        radbtnPicLocationModeRightCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenterInside, Nothing)
        radbtnPicLocationModeRightCenterInside.Location = New Point(155, 112)
        radbtnPicLocationModeRightCenterInside.Name = "radbtnPicLocationModeRightCenterInside"
        radbtnPicLocationModeRightCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterInside.TabIndex = 86
        TipInfoEX.SetText(radbtnPicLocationModeRightCenterInside, Nothing)
        radbtnPicLocationModeRightCenterInside.Text = "  "
        radbtnPicLocationModeRightCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterLeftInside
        ' 
        radbtnPicLocationModeBottomCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenterLeftInside, Nothing)
        radbtnPicLocationModeBottomCenterLeftInside.Location = New Point(71, 168)
        radbtnPicLocationModeBottomCenterLeftInside.Name = "radbtnPicLocationModeBottomCenterLeftInside"
        radbtnPicLocationModeBottomCenterLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterLeftInside.TabIndex = 89
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenterLeftInside, Nothing)
        radbtnPicLocationModeBottomCenterLeftInside.Text = "  "
        radbtnPicLocationModeBottomCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterTop
        ' 
        radbtnPicLocationModeRightCenterTop.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenterTop, Nothing)
        radbtnPicLocationModeRightCenterTop.Location = New Point(183, 70)
        radbtnPicLocationModeRightCenterTop.Name = "radbtnPicLocationModeRightCenterTop"
        radbtnPicLocationModeRightCenterTop.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterTop.TabIndex = 6
        TipInfoEX.SetText(radbtnPicLocationModeRightCenterTop, Nothing)
        radbtnPicLocationModeRightCenterTop.Text = "  "
        radbtnPicLocationModeRightCenterTop.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterBottom
        ' 
        radbtnPicLocationModeRightCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenterBottom, Nothing)
        radbtnPicLocationModeRightCenterBottom.Location = New Point(183, 154)
        radbtnPicLocationModeRightCenterBottom.Name = "radbtnPicLocationModeRightCenterBottom"
        radbtnPicLocationModeRightCenterBottom.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterBottom.TabIndex = 8
        TipInfoEX.SetText(radbtnPicLocationModeRightCenterBottom, Nothing)
        radbtnPicLocationModeRightCenterBottom.Text = "  "
        radbtnPicLocationModeRightCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterRight
        ' 
        radbtnPicLocationModeBottomCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenterRight, Nothing)
        radbtnPicLocationModeBottomCenterRight.Location = New Point(141, 196)
        radbtnPicLocationModeBottomCenterRight.Name = "radbtnPicLocationModeBottomCenterRight"
        radbtnPicLocationModeBottomCenterRight.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterRight.TabIndex = 10
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenterRight, Nothing)
        radbtnPicLocationModeBottomCenterRight.Text = "  "
        radbtnPicLocationModeBottomCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeManual
        ' 
        radbtnPicLocationModeManual.CheckAlign = ContentAlignment.BottomCenter
        TipInfoEX.SetImage(radbtnPicLocationModeManual, Nothing)
        radbtnPicLocationModeManual.Location = New Point(70, 86)
        radbtnPicLocationModeManual.Name = "radbtnPicLocationModeManual"
        radbtnPicLocationModeManual.Size = New Size(71, 40)
        radbtnPicLocationModeManual.TabIndex = 0
        TipInfoEX.SetText(radbtnPicLocationModeManual, Nothing)
        radbtnPicLocationModeManual.Text = "Manual"
        radbtnPicLocationModeManual.TextAlign = ContentAlignment.TopCenter
        radbtnPicLocationModeManual.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterLeft
        ' 
        radbtnPicLocationModeBottomCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenterLeft, Nothing)
        radbtnPicLocationModeBottomCenterLeft.Location = New Point(57, 196)
        radbtnPicLocationModeBottomCenterLeft.Name = "radbtnPicLocationModeBottomCenterLeft"
        radbtnPicLocationModeBottomCenterLeft.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterLeft.TabIndex = 12
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenterLeft, Nothing)
        radbtnPicLocationModeBottomCenterLeft.Text = "  "
        radbtnPicLocationModeBottomCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomRight
        ' 
        radbtnPicLocationModeBottomRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomRight, Nothing)
        radbtnPicLocationModeBottomRight.Location = New Point(183, 196)
        radbtnPicLocationModeBottomRight.Name = "radbtnPicLocationModeBottomRight"
        radbtnPicLocationModeBottomRight.Size = New Size(16, 16)
        radbtnPicLocationModeBottomRight.TabIndex = 8
        TipInfoEX.SetText(radbtnPicLocationModeBottomRight, Nothing)
        radbtnPicLocationModeBottomRight.Text = "  "
        radbtnPicLocationModeBottomRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenterBottom
        ' 
        radbtnPicLocationModeLeftCenterBottom.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenterBottom, Nothing)
        radbtnPicLocationModeLeftCenterBottom.Location = New Point(15, 154)
        radbtnPicLocationModeLeftCenterBottom.Name = "radbtnPicLocationModeLeftCenterBottom"
        radbtnPicLocationModeLeftCenterBottom.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenterBottom.TabIndex = 14
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenterBottom, Nothing)
        radbtnPicLocationModeLeftCenterBottom.Text = "  "
        radbtnPicLocationModeLeftCenterBottom.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenterRightInside
        ' 
        radbtnPicLocationModeBottomCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenterRightInside, Nothing)
        radbtnPicLocationModeBottomCenterRightInside.Location = New Point(127, 168)
        radbtnPicLocationModeBottomCenterRightInside.Name = "radbtnPicLocationModeBottomCenterRightInside"
        radbtnPicLocationModeBottomCenterRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenterRightInside.TabIndex = 85
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenterRightInside, Nothing)
        radbtnPicLocationModeBottomCenterRightInside.Text = "  "
        radbtnPicLocationModeBottomCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeBottomCenter
        ' 
        radbtnPicLocationModeBottomCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeBottomCenter, Nothing)
        radbtnPicLocationModeBottomCenter.Location = New Point(99, 196)
        radbtnPicLocationModeBottomCenter.Name = "radbtnPicLocationModeBottomCenter"
        radbtnPicLocationModeBottomCenter.Size = New Size(16, 16)
        radbtnPicLocationModeBottomCenter.TabIndex = 11
        TipInfoEX.SetText(radbtnPicLocationModeBottomCenter, Nothing)
        radbtnPicLocationModeBottomCenter.Text = "  "
        radbtnPicLocationModeBottomCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterBottomInside
        ' 
        radbtnPicLocationModeRightCenterBottomInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenterBottomInside, Nothing)
        radbtnPicLocationModeRightCenterBottomInside.Location = New Point(155, 140)
        radbtnPicLocationModeRightCenterBottomInside.Name = "radbtnPicLocationModeRightCenterBottomInside"
        radbtnPicLocationModeRightCenterBottomInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterBottomInside.TabIndex = 87
        TipInfoEX.SetText(radbtnPicLocationModeRightCenterBottomInside, Nothing)
        radbtnPicLocationModeRightCenterBottomInside.Text = "  "
        radbtnPicLocationModeRightCenterBottomInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeLeftCenter
        ' 
        radbtnPicLocationModeLeftCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeLeftCenter, Nothing)
        radbtnPicLocationModeLeftCenter.Location = New Point(15, 112)
        radbtnPicLocationModeLeftCenter.Name = "radbtnPicLocationModeLeftCenter"
        radbtnPicLocationModeLeftCenter.Size = New Size(16, 16)
        radbtnPicLocationModeLeftCenter.TabIndex = 15
        TipInfoEX.SetText(radbtnPicLocationModeLeftCenter, Nothing)
        radbtnPicLocationModeLeftCenter.Text = "  "
        radbtnPicLocationModeLeftCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterRightInside
        ' 
        radbtnPicLocationModeTopCenterRightInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenterRightInside, Nothing)
        radbtnPicLocationModeTopCenterRightInside.Location = New Point(127, 56)
        radbtnPicLocationModeTopCenterRightInside.Name = "radbtnPicLocationModeTopCenterRightInside"
        radbtnPicLocationModeTopCenterRightInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterRightInside.TabIndex = 83
        TipInfoEX.SetText(radbtnPicLocationModeTopCenterRightInside, Nothing)
        radbtnPicLocationModeTopCenterRightInside.Text = "  "
        radbtnPicLocationModeTopCenterRightInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenterTopInside
        ' 
        radbtnPicLocationModeRightCenterTopInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenterTopInside, Nothing)
        radbtnPicLocationModeRightCenterTopInside.Location = New Point(155, 84)
        radbtnPicLocationModeRightCenterTopInside.Name = "radbtnPicLocationModeRightCenterTopInside"
        radbtnPicLocationModeRightCenterTopInside.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenterTopInside.TabIndex = 84
        TipInfoEX.SetText(radbtnPicLocationModeRightCenterTopInside, Nothing)
        radbtnPicLocationModeRightCenterTopInside.Text = "  "
        radbtnPicLocationModeRightCenterTopInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterInside
        ' 
        radbtnPicLocationModeTopCenterInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenterInside, Nothing)
        radbtnPicLocationModeTopCenterInside.Location = New Point(99, 56)
        radbtnPicLocationModeTopCenterInside.Name = "radbtnPicLocationModeTopCenterInside"
        radbtnPicLocationModeTopCenterInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterInside.TabIndex = 82
        TipInfoEX.SetText(radbtnPicLocationModeTopCenterInside, Nothing)
        radbtnPicLocationModeTopCenterInside.Text = "  "
        radbtnPicLocationModeTopCenterInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterLeft
        ' 
        radbtnPicLocationModeTopCenterLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenterLeft, Nothing)
        radbtnPicLocationModeTopCenterLeft.Location = New Point(57, 28)
        radbtnPicLocationModeTopCenterLeft.Name = "radbtnPicLocationModeTopCenterLeft"
        radbtnPicLocationModeTopCenterLeft.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterLeft.TabIndex = 2
        TipInfoEX.SetText(radbtnPicLocationModeTopCenterLeft, Nothing)
        radbtnPicLocationModeTopCenterLeft.Text = "  "
        radbtnPicLocationModeTopCenterLeft.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenter
        ' 
        radbtnPicLocationModeTopCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenter, Nothing)
        radbtnPicLocationModeTopCenter.Location = New Point(99, 28)
        radbtnPicLocationModeTopCenter.Name = "radbtnPicLocationModeTopCenter"
        radbtnPicLocationModeTopCenter.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenter.TabIndex = 3
        TipInfoEX.SetText(radbtnPicLocationModeTopCenter, Nothing)
        radbtnPicLocationModeTopCenter.Text = "  "
        radbtnPicLocationModeTopCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopRight
        ' 
        radbtnPicLocationModeTopRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopRight, Nothing)
        radbtnPicLocationModeTopRight.Location = New Point(183, 28)
        radbtnPicLocationModeTopRight.Name = "radbtnPicLocationModeTopRight"
        radbtnPicLocationModeTopRight.Size = New Size(16, 16)
        radbtnPicLocationModeTopRight.TabIndex = 5
        TipInfoEX.SetText(radbtnPicLocationModeTopRight, Nothing)
        radbtnPicLocationModeTopRight.Text = "  "
        radbtnPicLocationModeTopRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterRight
        ' 
        radbtnPicLocationModeTopCenterRight.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenterRight, Nothing)
        radbtnPicLocationModeTopCenterRight.Location = New Point(141, 28)
        radbtnPicLocationModeTopCenterRight.Name = "radbtnPicLocationModeTopCenterRight"
        radbtnPicLocationModeTopCenterRight.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterRight.TabIndex = 4
        TipInfoEX.SetText(radbtnPicLocationModeTopCenterRight, Nothing)
        radbtnPicLocationModeTopCenterRight.Text = "  "
        radbtnPicLocationModeTopCenterRight.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeRightCenter
        ' 
        radbtnPicLocationModeRightCenter.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeRightCenter, Nothing)
        radbtnPicLocationModeRightCenter.Location = New Point(183, 112)
        radbtnPicLocationModeRightCenter.Name = "radbtnPicLocationModeRightCenter"
        radbtnPicLocationModeRightCenter.Size = New Size(16, 16)
        radbtnPicLocationModeRightCenter.TabIndex = 7
        TipInfoEX.SetText(radbtnPicLocationModeRightCenter, Nothing)
        radbtnPicLocationModeRightCenter.Text = "  "
        radbtnPicLocationModeRightCenter.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopCenterLeftInside
        ' 
        radbtnPicLocationModeTopCenterLeftInside.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopCenterLeftInside, Nothing)
        radbtnPicLocationModeTopCenterLeftInside.Location = New Point(71, 56)
        radbtnPicLocationModeTopCenterLeftInside.Name = "radbtnPicLocationModeTopCenterLeftInside"
        radbtnPicLocationModeTopCenterLeftInside.Size = New Size(16, 16)
        radbtnPicLocationModeTopCenterLeftInside.TabIndex = 81
        TipInfoEX.SetText(radbtnPicLocationModeTopCenterLeftInside, Nothing)
        radbtnPicLocationModeTopCenterLeftInside.Text = "  "
        radbtnPicLocationModeTopCenterLeftInside.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicLocationModeTopLeft
        ' 
        radbtnPicLocationModeTopLeft.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radbtnPicLocationModeTopLeft, Nothing)
        radbtnPicLocationModeTopLeft.Location = New Point(15, 28)
        radbtnPicLocationModeTopLeft.Name = "radbtnPicLocationModeTopLeft"
        radbtnPicLocationModeTopLeft.Size = New Size(16, 16)
        radbtnPicLocationModeTopLeft.TabIndex = 1
        TipInfoEX.SetText(radbtnPicLocationModeTopLeft, Nothing)
        radbtnPicLocationModeTopLeft.Text = "  "
        radbtnPicLocationModeTopLeft.UseVisualStyleBackColor = True
        ' 
        ' lblPicFileCount
        ' 
        TipInfoEX.SetImage(lblPicFileCount, Nothing)
        lblPicFileCount.Location = New Point(12, 98)
        lblPicFileCount.Name = "lblPicFileCount"
        lblPicFileCount.Size = New Size(254, 22)
        lblPicFileCount.TabIndex = 0
        TipInfoEX.SetText(lblPicFileCount, Nothing)
        ' 
        ' btnPicTimerEnabled
        ' 
        btnPicTimerEnabled.FlatStyle = FlatStyle.Flat
        TipInfoEX.SetImage(btnPicTimerEnabled, Nothing)
        btnPicTimerEnabled.Location = New Point(295, 263)
        btnPicTimerEnabled.Margin = New Padding(3, 4, 3, 4)
        btnPicTimerEnabled.Name = "btnPicTimerEnabled"
        btnPicTimerEnabled.Size = New Size(80, 31)
        btnPicTimerEnabled.TabIndex = 60
        btnPicTimerEnabled.TabStop = False
        TipInfoEX.SetText(btnPicTimerEnabled, Nothing)
        btnPicTimerEnabled.Text = "Timer"
        btnPicTimerEnabled.UseVisualStyleBackColor = True
        ' 
        ' gpbxPicPlayMode
        ' 
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeLinearWithRandomStart)
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeLinear)
        gpbxPicPlayMode.Controls.Add(radbtnPicPlayModeRandom)
        TipInfoEX.SetImage(gpbxPicPlayMode, Nothing)
        gpbxPicPlayMode.Location = New Point(7, 140)
        gpbxPicPlayMode.Name = "gpbxPicPlayMode"
        gpbxPicPlayMode.Size = New Size(275, 65)
        gpbxPicPlayMode.TabIndex = 10
        gpbxPicPlayMode.TabStop = False
        gpbxPicPlayMode.Text = "Picture Advance Mode"
        TipInfoEX.SetText(gpbxPicPlayMode, Nothing)
        ' 
        ' radbtnPicPlayModeLinear
        ' 
        TipInfoEX.SetImage(radbtnPicPlayModeLinear, Nothing)
        radbtnPicPlayModeLinear.Location = New Point(11, 22)
        radbtnPicPlayModeLinear.Name = "radbtnPicPlayModeLinear"
        radbtnPicPlayModeLinear.Size = New Size(71, 33)
        radbtnPicPlayModeLinear.TabIndex = 0
        TipInfoEX.SetText(radbtnPicPlayModeLinear, Nothing)
        radbtnPicPlayModeLinear.Text = "Linear"
        radbtnPicPlayModeLinear.UseVisualStyleBackColor = True
        ' 
        ' radbtnPicPlayModeRandom
        ' 
        TipInfoEX.SetImage(radbtnPicPlayModeRandom, Nothing)
        radbtnPicPlayModeRandom.Location = New Point(185, 22)
        radbtnPicPlayModeRandom.Name = "radbtnPicPlayModeRandom"
        radbtnPicPlayModeRandom.Size = New Size(87, 33)
        radbtnPicPlayModeRandom.TabIndex = 2
        TipInfoEX.SetText(radbtnPicPlayModeRandom, Nothing)
        radbtnPicPlayModeRandom.Text = "Random"
        radbtnPicPlayModeRandom.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        TipInfoEX.SetImage(label4, Nothing)
        label4.Location = New Point(296, 295)
        label4.Name = "label4"
        label4.Size = New Size(80, 22)
        label4.TabIndex = 21
        label4.Text = "Interval (s)"
        TipInfoEX.SetText(label4, Nothing)
        label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' chbxPicTimerAutoStart
        ' 
        TipInfoEX.SetImage(chbxPicTimerAutoStart, Nothing)
        chbxPicTimerAutoStart.Location = New Point(382, 260)
        chbxPicTimerAutoStart.Margin = New Padding(3, 4, 3, 4)
        chbxPicTimerAutoStart.Name = "chbxPicTimerAutoStart"
        chbxPicTimerAutoStart.Size = New Size(140, 38)
        chbxPicTimerAutoStart.TabIndex = 65
        TipInfoEX.SetText(chbxPicTimerAutoStart, Nothing)
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
        TipInfoEX.SetImage(PanelVids, Nothing)
        PanelVids.Location = New Point(91, 0)
        PanelVids.Name = "PanelVids"
        PanelVids.Size = New Size(826, 534)
        PanelVids.TabIndex = 109
        TipInfoEX.SetText(PanelVids, Nothing)
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
        TipInfoEX.SetImage(PanelActions, My.Resources.Resources.imageLog)
        PanelActions.Location = New Point(0, 534)
        PanelActions.Name = "PanelActions"
        PanelActions.Size = New Size(917, 96)
        PanelActions.TabIndex = 110
        TipInfoEX.SetText(PanelActions, "Show Log")
        ' 
        ' PanelPageSelector
        ' 
        PanelPageSelector.Controls.Add(LVPageSelector)
        PanelPageSelector.Dock = DockStyle.Left
        TipInfoEX.SetImage(PanelPageSelector, Nothing)
        PanelPageSelector.Location = New Point(0, 0)
        PanelPageSelector.Name = "PanelPageSelector"
        PanelPageSelector.Size = New Size(91, 534)
        PanelPageSelector.TabIndex = 111
        TipInfoEX.SetText(PanelPageSelector, Nothing)
        ' 
        ' LVPageSelector
        ' 
        LVPageSelector.AutoArrange = False
        LVPageSelector.BackColor = SystemColors.Control
        LVPageSelector.BorderStyle = BorderStyle.None
        LVPageSelector.Dock = DockStyle.Fill
        LVPageSelector.EditableColumns = CType(resources.GetObject("LVPageSelector.EditableColumns"), List(Of Boolean))
        LVPageSelector.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(LVPageSelector, Nothing)
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
        TipInfoEX.SetText(LVPageSelector, Nothing)
        LVPageSelector.UseCompatibleStateImageBehavior = False
        ' 
        ' ILPageSelector
        ' 
        ILPageSelector.ColorDepth = ColorDepth.Depth32Bit
        ILPageSelector.ImageSize = New Size(48, 48)
        ILPageSelector.TransparentColor = Color.Transparent
        ' 
        ' TipInfoEX
        ' 
        TipInfoEX.Font = New Font("Segoe UI", 10F)
        ' 
        ' MainForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(917, 630)
        Controls.Add(PanelVids)
        Controls.Add(PanelPics)
        Controls.Add(PanelApp)
        Controls.Add(PanelPageSelector)
        Controls.Add(PanelActions)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.IconApp
        TipInfoEX.SetImage(Me, Nothing)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "MainForm"
        Opacity = 0R
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        TipInfoEX.SetText(Me, Nothing)
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
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
End Class