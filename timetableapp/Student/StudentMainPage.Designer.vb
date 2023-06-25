<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentMainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentMainPage))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnAccount = New FontAwesome.Sharp.IconButton()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.btnTimetable = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.btnleftborder = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.UserProfileImage = New System.Windows.Forms.PictureBox()
        Me.DesktopPanel = New System.Windows.Forms.Panel()
        Me.lblDigitalClock = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MainPagePicture = New System.Windows.Forms.PictureBox()
        Me.lblHomeTitle = New System.Windows.Forms.Label()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.btnleftborder.SuspendLayout()
        CType(Me.UserProfileImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DesktopPanel.SuspendLayout()
        CType(Me.MainPagePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitle.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnSearch)
        Me.PanelMenu.Controls.Add(Me.btnTimetable)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.btnAccount)
        Me.PanelMenu.Controls.Add(Me.btnleftborder)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(164, 597)
        Me.PanelMenu.TabIndex = 12
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Constantia", 11.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 32
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 429)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(164, 75)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Constantia", 11.0!)
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnAccount.IconColor = System.Drawing.Color.White
        Me.btnAccount.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAccount.IconSize = 32
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(0, 129)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAccount.Size = New System.Drawing.Size(164, 75)
        Me.btnAccount.TabIndex = 4
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Constantia", 11.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.White
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 32
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(0, 354)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSearch.Size = New System.Drawing.Size(164, 75)
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
        Me.btnTimetable.Font = New System.Drawing.Font("Constantia", 11.0!)
        Me.btnTimetable.ForeColor = System.Drawing.Color.White
        Me.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnTimetable.IconColor = System.Drawing.Color.White
        Me.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTimetable.IconSize = 32
        Me.btnTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimetable.Location = New System.Drawing.Point(0, 279)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTimetable.Size = New System.Drawing.Size(164, 75)
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
        Me.btnDashboard.Font = New System.Drawing.Font("Constantia", 11.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 204)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(164, 75)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnleftborder
        '
        Me.btnleftborder.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnleftborder.Controls.Add(Me.lblUsername)
        Me.btnleftborder.Controls.Add(Me.UserProfileImage)
        Me.btnleftborder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnleftborder.Location = New System.Drawing.Point(0, 0)
        Me.btnleftborder.Name = "btnleftborder"
        Me.btnleftborder.Size = New System.Drawing.Size(164, 129)
        Me.btnleftborder.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblUsername.Location = New System.Drawing.Point(0, 105)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(164, 24)
        Me.lblUsername.TabIndex = 27
        Me.lblUsername.Text = "UserID"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserProfileImage
        '
        Me.UserProfileImage.BackColor = System.Drawing.Color.Transparent
        Me.UserProfileImage.BackgroundImage = CType(resources.GetObject("UserProfileImage.BackgroundImage"), System.Drawing.Image)
        Me.UserProfileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UserProfileImage.Location = New System.Drawing.Point(20, 10)
        Me.UserProfileImage.Name = "UserProfileImage"
        Me.UserProfileImage.Size = New System.Drawing.Size(115, 88)
        Me.UserProfileImage.TabIndex = 26
        Me.UserProfileImage.TabStop = False
        '
        'DesktopPanel
        '
        Me.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DesktopPanel.Controls.Add(Me.lblDigitalClock)
        Me.DesktopPanel.Controls.Add(Me.MainPagePicture)
        Me.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopPanel.Location = New System.Drawing.Point(164, 98)
        Me.DesktopPanel.Name = "DesktopPanel"
        Me.DesktopPanel.Size = New System.Drawing.Size(926, 499)
        Me.DesktopPanel.TabIndex = 14
        '
        'lblDigitalClock
        '
        Me.lblDigitalClock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDigitalClock.BackColor = System.Drawing.Color.Transparent
        Me.lblDigitalClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalClock.ForeColor = System.Drawing.Color.White
        Me.lblDigitalClock.Location = New System.Drawing.Point(3, 0)
        Me.lblDigitalClock.Name = "lblDigitalClock"
        Me.lblDigitalClock.Size = New System.Drawing.Size(920, 127)
        Me.lblDigitalClock.TabIndex = 2
        Me.lblDigitalClock.Text = "BunifuCustomLabel1"
        Me.lblDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPagePicture
        '
        Me.MainPagePicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MainPagePicture.BackColor = System.Drawing.Color.Transparent
        Me.MainPagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainPagePicture.Image = CType(resources.GetObject("MainPagePicture.Image"), System.Drawing.Image)
        Me.MainPagePicture.Location = New System.Drawing.Point(3, 130)
        Me.MainPagePicture.Name = "MainPagePicture"
        Me.MainPagePicture.Size = New System.Drawing.Size(920, 366)
        Me.MainPagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainPagePicture.TabIndex = 28
        Me.MainPagePicture.TabStop = False
        '
        'lblHomeTitle
        '
        Me.lblHomeTitle.AutoSize = True
        Me.lblHomeTitle.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblHomeTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHomeTitle.Location = New System.Drawing.Point(52, 58)
        Me.lblHomeTitle.Name = "lblHomeTitle"
        Me.lblHomeTitle.Size = New System.Drawing.Size(65, 23)
        Me.lblHomeTitle.TabIndex = 1
        Me.lblHomeTitle.Text = "Home"
        '
        'panelTitle
        '
        Me.panelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.panelTitle.Controls.Add(Me.btnMaximize)
        Me.panelTitle.Controls.Add(Me.btnClose)
        Me.panelTitle.Controls.Add(Me.btnMinimize)
        Me.panelTitle.Controls.Add(Me.btnHome)
        Me.panelTitle.Controls.Add(Me.lblHomeTitle)
        Me.panelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitle.Location = New System.Drawing.Point(164, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(926, 98)
        Me.panelTitle.TabIndex = 15
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
        Me.btnMaximize.Location = New System.Drawing.Point(856, 10)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(27, 22)
        Me.btnMaximize.TabIndex = 14
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
        Me.btnClose.Location = New System.Drawing.Point(882, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 12
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
        Me.btnMinimize.Location = New System.Drawing.Point(829, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 32)
        Me.btnMinimize.TabIndex = 13
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnHome.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnHome.IconColor = System.Drawing.Color.SlateBlue
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 26
        Me.btnHome.Location = New System.Drawing.Point(21, 55)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(28, 26)
        Me.btnHome.TabIndex = 0
        Me.btnHome.TabStop = False
        '
        'Timer1
        '
        '
        'StudentMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1090, 597)
        Me.Controls.Add(Me.DesktopPanel)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "StudentMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentMainPage"
        Me.PanelMenu.ResumeLayout(False)
        Me.btnleftborder.ResumeLayout(False)
        CType(Me.UserProfileImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DesktopPanel.ResumeLayout(False)
        CType(Me.MainPagePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTimetable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents DesktopPanel As Panel
    Friend WithEvents btnleftborder As Panel
    Friend WithEvents lblHomeTitle As Label
    Friend WithEvents btnHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panelTitle As Panel
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents UserProfileImage As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDigitalClock As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MainPagePicture As PictureBox
End Class
