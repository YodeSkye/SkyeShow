Friend Partial Class VidList
Inherits System.Windows.Forms.Form
	Private components As System.ComponentModel.IContainer
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lvVideoList = New ListView()
        colPath = New ColumnHeader()
        btnRefresh = New Button()
        btnGroup = New Button()
        txbxSearchForText = New TextBox()
        btnSearchForText = New Button()
        tipInfo = New ToolTip(components)
        SuspendLayout()
        ' 
        ' lvVideoList
        ' 
        lvVideoList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvVideoList.CheckBoxes = True
        lvVideoList.Columns.AddRange(New ColumnHeader() {colPath})
        lvVideoList.FullRowSelect = True
        lvVideoList.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvVideoList.LabelWrap = False
        lvVideoList.Location = New Point(13, 94)
        lvVideoList.Margin = New Padding(3, 4, 3, 4)
        lvVideoList.MultiSelect = False
        lvVideoList.Name = "lvVideoList"
        lvVideoList.ShowItemToolTips = True
        lvVideoList.Size = New Size(508, 346)
        lvVideoList.TabIndex = 0
        lvVideoList.UseCompatibleStateImageBehavior = False
        lvVideoList.View = View.Details
        ' 
        ' colPath
        ' 
        colPath.Text = "Viewed | Path"
        colPath.Width = 447
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Image = My.Resources.Resources.imageQuickShift
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(12, 13)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(87, 32)
        btnRefresh.TabIndex = 10
        btnRefresh.TabStop = False
        btnRefresh.Text = "Refresh"
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnRefresh, "Refresh List (F5)")
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnGroup
        ' 
        btnGroup.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGroup.Image = My.Resources.Resources.imageFolder
        btnGroup.ImageAlign = ContentAlignment.MiddleLeft
        btnGroup.Location = New Point(105, 13)
        btnGroup.MaximumSize = New Size(618, 32)
        btnGroup.Name = "btnGroup"
        btnGroup.Size = New Size(418, 32)
        btnGroup.TabIndex = 11
        btnGroup.TabStop = False
        btnGroup.TextImageRelation = TextImageRelation.ImageBeforeText
        tipInfo.SetToolTip(btnGroup, "Go To Next Folder (SHIFT PGUP/PGDN)")
        btnGroup.UseVisualStyleBackColor = True
        ' 
        ' txbxSearchForText
        ' 
        txbxSearchForText.Location = New Point(13, 58)
        txbxSearchForText.Margin = New Padding(3, 4, 3, 4)
        txbxSearchForText.Name = "txbxSearchForText"
        txbxSearchForText.Size = New Size(202, 25)
        txbxSearchForText.TabIndex = 1
        ' 
        ' btnSearchForText
        ' 
        btnSearchForText.Image = My.Resources.Resources.imageSearch
        btnSearchForText.ImageAlign = ContentAlignment.MiddleLeft
        btnSearchForText.Location = New Point(221, 53)
        btnSearchForText.Name = "btnSearchForText"
        btnSearchForText.Size = New Size(87, 33)
        btnSearchForText.TabIndex = 13
        btnSearchForText.TabStop = False
        btnSearchForText.Text = "Search"
        btnSearchForText.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnSearchForText, "Search For Text (F3)")
        btnSearchForText.UseVisualStyleBackColor = True
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
        ' VidList
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(534, 454)
        Controls.Add(btnSearchForText)
        Controls.Add(txbxSearchForText)
        Controls.Add(btnGroup)
        Controls.Add(btnRefresh)
        Controls.Add(lvVideoList)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.iconVideoList
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(336, 320)
        Name = "VidList"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents colPath As System.Windows.Forms.ColumnHeader
    Private WithEvents txbxSearchForText As System.Windows.Forms.TextBox
    Private WithEvents btnSearchForText As System.Windows.Forms.Button
    Private tipInfo As System.Windows.Forms.ToolTip
    Private WithEvents btnGroup As System.Windows.Forms.Button
    Private WithEvents lvVideoList As System.Windows.Forms.ListView
    Private WithEvents btnRefresh As System.Windows.Forms.Button
End Class