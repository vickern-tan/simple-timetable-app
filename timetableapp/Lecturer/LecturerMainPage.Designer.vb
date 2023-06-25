<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecturerMainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecturerMainPage))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.btnTimetable = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.btnUserProfile = New FontAwesome.Sharp.IconButton()
        Me.topleftpanel = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.logoUser = New System.Windows.Forms.PictureBox()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconPictureBox()
        Me.lblHomeTitle = New System.Windows.Forms.Label()
        Me.contentpanel = New System.Windows.Forms.Panel()
        Me.DesktopPanel = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.topleftpanel.SuspendLayout()
        CType(Me.logoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitle.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnSearch)
        Me.PanelMenu.Controls.Add(Me.btnTimetable)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.btnUserProfile)
        Me.PanelMenu.Controls.Add(Me.topleftpanel)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(160, 597)
        Me.PanelMenu.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Constantia", 11.25!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 32
        Me.btnLogout.Location = New System.Drawing.Point(0, 429)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(160, 75)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Constantia", 11.25!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.White
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 32
        Me.btnSearch.Location = New System.Drawing.Point(0, 354)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSearch.Size = New System.Drawing.Size(160, 75)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnTimetable
        '
        Me.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTimetable.FlatAppearance.BorderSize = 0
        Me.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimetable.Font = New System.Drawing.Font("Constantia", 11.25!)
        Me.btnTimetable.ForeColor = System.Drawing.Color.White
        Me.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnTimetable.IconColor = System.Drawing.Color.White
        Me.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTimetable.IconSize = 32
        Me.btnTimetable.Location = New System.Drawing.Point(0, 279)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTimetable.Size = New System.Drawing.Size(160, 75)
        Me.btnTimetable.TabIndex = 3
        Me.btnTimetable.Text = "Timetable"
        Me.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimetable.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Constantia", 11.25!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.Location = New System.Drawing.Point(0, 204)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(160, 75)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnUserProfile
        '
        Me.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserProfile.FlatAppearance.BorderSize = 0
        Me.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserProfile.Font = New System.Drawing.Font("Constantia", 11.25!)
        Me.btnUserProfile.ForeColor = System.Drawing.Color.White
        Me.btnUserProfile.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.btnUserProfile.IconColor = System.Drawing.Color.White
        Me.btnUserProfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUserProfile.IconSize = 32
        Me.btnUserProfile.Location = New System.Drawing.Point(0, 129)
        Me.btnUserProfile.Name = "btnUserProfile"
        Me.btnUserProfile.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUserProfile.Size = New System.Drawing.Size(160, 75)
        Me.btnUserProfile.TabIndex = 1
        Me.btnUserProfile.Text = "Profile"
        Me.btnUserProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserProfile.UseVisualStyleBackColor = True
        '
        'topleftpanel
        '
        Me.topleftpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.topleftpanel.Controls.Add(Me.lblUsername)
        Me.topleftpanel.Controls.Add(Me.logoUser)
        Me.topleftpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topleftpanel.Location = New System.Drawing.Point(0, 0)
        Me.topleftpanel.Name = "topleftpanel"
        Me.topleftpanel.Size = New System.Drawing.Size(160, 129)
        Me.topleftpanel.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblUsername.Location = New System.Drawing.Point(0, 105)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(160, 24)
        Me.lblUsername.TabIndex = 28
        Me.lblUsername.Text = "UserID"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logoUser
        '
        Me.logoUser.BackColor = System.Drawing.Color.White
        Me.logoUser.BackgroundImage = CType(resources.GetObject("logoUser.BackgroundImage"), System.Drawing.Image)
        Me.logoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoUser.Location = New System.Drawing.Point(12, 13)
        Me.logoUser.Name = "logoUser"
        Me.logoUser.Size = New System.Drawing.Size(137, 89)
        Me.logoUser.TabIndex = 27
        Me.logoUser.TabStop = False
        '
        'panelTitle
        '
        Me.panelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.panelTitle.Controls.Add(Me.btnMaximize)
        Me.panelTitle.Controls.Add(Me.btnClose)
        Me.panelTitle.Controls.Add(Me.btnMinimize)
        Me.panelTitle.Controls.Add(Me.btnHome)
        Me.panelTitle.Controls.Add(Me.lblHomeTitle)
        Me.panelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitle.Location = New System.Drawing.Point(160, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(930, 107)
        Me.panelTitle.TabIndex = 2
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.Gray
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt
        Me.btnMaximize.IconColor = System.Drawing.Color.Gray
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 19
        Me.btnMaximize.Location = New System.Drawing.Point(862, 11)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(27, 22)
        Me.btnMaximize.TabIndex = 17
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gray
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(888, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Gray
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(835, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 32)
        Me.btnMinimize.TabIndex = 16
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.ForeColor = System.Drawing.Color.Lavender
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnHome.IconColor = System.Drawing.Color.Lavender
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 26
        Me.btnHome.Location = New System.Drawing.Point(29, 69)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(28, 26)
        Me.btnHome.TabIndex = 2
        Me.btnHome.TabStop = False
        '
        'lblHomeTitle
        '
        Me.lblHomeTitle.AutoSize = True
        Me.lblHomeTitle.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHomeTitle.Location = New System.Drawing.Point(60, 74)
        Me.lblHomeTitle.Name = "lblHomeTitle"
        Me.lblHomeTitle.Size = New System.Drawing.Size(51, 18)
        Me.lblHomeTitle.TabIndex = 3
        Me.lblHomeTitle.Text = "Home"
        '
        'contentpanel
        '
        Me.contentpanel.Controls.Add(Me.DesktopPanel)
        Me.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentpanel.Location = New System.Drawing.Point(160, 107)
        Me.contentpanel.Name = "contentpanel"
        Me.contentpanel.Size = New System.Drawing.Size(930, 490)
        Me.contentpanel.TabIndex = 3
        '
        'DesktopPanel
        '
        Me.DesktopPanel.BackColor = System.Drawing.Color.Transparent
        Me.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopPanel.Location = New System.Drawing.Point(0, 0)
        Me.DesktopPanel.Name = "DesktopPanel"
        Me.DesktopPanel.Size = New System.Drawing.Size(930, 490)
        Me.DesktopPanel.TabIndex = 0
        '
        'LecturerMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 597)
        Me.Controls.Add(Me.contentpanel)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "LecturerMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LecturerMainPage"
        Me.PanelMenu.ResumeLayout(False)
        Me.topleftpanel.ResumeLayout(False)
        CType(Me.logoUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contentpanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents topleftpanel As Panel
    Friend WithEvents btnUserProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTimetable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents logoUser As PictureBox
    Friend WithEvents panelTitle As Panel
    Friend WithEvents contentpanel As Panel
    Friend WithEvents btnHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblHomeTitle As Label
    Friend WithEvents DesktopPanel As Panel
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents lblUsername As Label
End Class
