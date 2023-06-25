<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulerLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulerLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.UserIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.PassIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.logoLogin = New System.Windows.Forms.PictureBox()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PnlTopBorder = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblForgetpass = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRegister = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtUserPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblschedulertlogin = New System.Windows.Forms.Label()
        Me.txtUserLogin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTopBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'UserIcon
        '
        Me.UserIcon.BackColor = System.Drawing.Color.Transparent
        Me.UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UserIcon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.UserIcon.IconColor = System.Drawing.SystemColors.ControlText
        Me.UserIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UserIcon.IconSize = 22
        Me.UserIcon.Location = New System.Drawing.Point(29, 287)
        Me.UserIcon.Name = "UserIcon"
        Me.UserIcon.Size = New System.Drawing.Size(22, 22)
        Me.UserIcon.TabIndex = 44
        Me.UserIcon.TabStop = False
        '
        'PassIcon
        '
        Me.PassIcon.BackColor = System.Drawing.Color.Transparent
        Me.PassIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PassIcon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PassIcon.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.PassIcon.IconColor = System.Drawing.SystemColors.ControlText
        Me.PassIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PassIcon.IconSize = 23
        Me.PassIcon.Location = New System.Drawing.Point(29, 329)
        Me.PassIcon.Name = "PassIcon"
        Me.PassIcon.Size = New System.Drawing.Size(25, 23)
        Me.PassIcon.TabIndex = 43
        Me.PassIcon.TabStop = False
        '
        'logoLogin
        '
        Me.logoLogin.BackColor = System.Drawing.Color.Transparent
        Me.logoLogin.BackgroundImage = CType(resources.GetObject("logoLogin.BackgroundImage"), System.Drawing.Image)
        Me.logoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoLogin.Location = New System.Drawing.Point(29, 112)
        Me.logoLogin.Name = "logoLogin"
        Me.logoLogin.Size = New System.Drawing.Size(266, 164)
        Me.logoLogin.TabIndex = 42
        Me.logoLogin.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 20
        Me.btnBack.ActiveFillColor = System.Drawing.Color.Red
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.Red
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 20
        Me.btnBack.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnBack.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnBack.Location = New System.Drawing.Point(29, 438)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 47)
        Me.btnBack.TabIndex = 39
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.BackColor = System.Drawing.Color.White
        Me.PnlTopBorder.BackgroundImage = CType(resources.GetObject("PnlTopBorder.BackgroundImage"), System.Drawing.Image)
        Me.PnlTopBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTopBorder.Controls.Add(Me.btnExit)
        Me.PnlTopBorder.Controls.Add(Me.btnMinimize)
        Me.PnlTopBorder.Controls.Add(Me.btnClose)
        Me.PnlTopBorder.Controls.Add(Me.IconButton1)
        Me.PnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTopBorder.GradientBottomLeft = System.Drawing.Color.White
        Me.PnlTopBorder.GradientBottomRight = System.Drawing.Color.White
        Me.PnlTopBorder.GradientTopLeft = System.Drawing.Color.White
        Me.PnlTopBorder.GradientTopRight = System.Drawing.Color.White
        Me.PnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.PnlTopBorder.Name = "PnlTopBorder"
        Me.PnlTopBorder.Quality = 10
        Me.PnlTopBorder.Size = New System.Drawing.Size(328, 34)
        Me.PnlTopBorder.TabIndex = 38
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.Location = New System.Drawing.Point(287, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 33)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(271, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(17, 33)
        Me.btnMinimize.TabIndex = 13
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(587, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(571, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(17, 33)
        Me.IconButton1.TabIndex = 11
        Me.IconButton1.Text = "-"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lblForgetpass
        '
        Me.lblForgetpass.AutoSize = True
        Me.lblForgetpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgetpass.Location = New System.Drawing.Point(26, 362)
        Me.lblForgetpass.Name = "lblForgetpass"
        Me.lblForgetpass.Size = New System.Drawing.Size(86, 13)
        Me.lblForgetpass.TabIndex = 37
        Me.lblForgetpass.Text = "Forget Password"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Location = New System.Drawing.Point(249, 362)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(46, 13)
        Me.lblRegister.TabIndex = 36
        Me.lblRegister.Text = "Register"
        '
        'btnlogin
        '
        Me.btnlogin.ActiveBorderThickness = 1
        Me.btnlogin.ActiveCornerRadius = 20
        Me.btnlogin.ActiveFillColor = System.Drawing.Color.Red
        Me.btnlogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnlogin.ActiveLineColor = System.Drawing.Color.Red
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleCornerRadius = 20
        Me.btnlogin.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnlogin.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnlogin.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnlogin.Location = New System.Drawing.Point(29, 395)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(266, 47)
        Me.btnlogin.TabIndex = 35
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.Color.White
        Me.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserPassword.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserPassword.HintText = "Password"
        Me.txtUserPassword.isPassword = True
        Me.txtUserPassword.LineFocusedColor = System.Drawing.Color.Red
        Me.txtUserPassword.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtUserPassword.LineMouseHoverColor = System.Drawing.Color.Red
        Me.txtUserPassword.LineThickness = 4
        Me.txtUserPassword.Location = New System.Drawing.Point(29, 323)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(266, 35)
        Me.txtUserPassword.TabIndex = 34
        Me.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblschedulertlogin
        '
        Me.lblschedulertlogin.Font = New System.Drawing.Font("Perpetua", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblschedulertlogin.Location = New System.Drawing.Point(10, 48)
        Me.lblschedulertlogin.Name = "lblschedulertlogin"
        Me.lblschedulertlogin.Size = New System.Drawing.Size(305, 61)
        Me.lblschedulertlogin.TabIndex = 32
        Me.lblschedulertlogin.Text = "Scheduler Login"
        Me.lblschedulertlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserLogin
        '
        Me.txtUserLogin.BackColor = System.Drawing.Color.White
        Me.txtUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserLogin.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserLogin.HintText = "ID(SCHE)*"
        Me.txtUserLogin.isPassword = False
        Me.txtUserLogin.LineFocusedColor = System.Drawing.Color.Red
        Me.txtUserLogin.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtUserLogin.LineMouseHoverColor = System.Drawing.Color.Red
        Me.txtUserLogin.LineThickness = 4
        Me.txtUserLogin.Location = New System.Drawing.Point(29, 283)
        Me.txtUserLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(266, 32)
        Me.txtUserLogin.TabIndex = 33
        Me.txtUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SchedulerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 505)
        Me.Controls.Add(Me.UserIcon)
        Me.Controls.Add(Me.PassIcon)
        Me.Controls.Add(Me.logoLogin)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PnlTopBorder)
        Me.Controls.Add(Me.lblForgetpass)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.lblschedulertlogin)
        Me.Controls.Add(Me.txtUserLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SchedulerLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SchedulerLogin"
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTopBorder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents UserIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PassIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents logoLogin As PictureBox
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PnlTopBorder As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblForgetpass As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRegister As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtUserPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblschedulertlogin As Label
    Friend WithEvents txtUserLogin As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
