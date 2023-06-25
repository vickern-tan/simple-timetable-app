<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentlogin))
        Me.lblstudentlogin = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtUserLogin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUserPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblRegister = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblForgetpass = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PnlTopBorder = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.logoLogin = New System.Windows.Forms.PictureBox()
        Me.PassIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.UserIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.iconShowPass = New FontAwesome.Sharp.IconButton()
        Me.iconHidePass = New FontAwesome.Sharp.IconButton()
        Me.PnlTopBorder.SuspendLayout()
        CType(Me.logoLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblstudentlogin
        '
        Me.lblstudentlogin.BackColor = System.Drawing.Color.Transparent
        Me.lblstudentlogin.Font = New System.Drawing.Font("Perpetua", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblstudentlogin.Location = New System.Drawing.Point(23, 39)
        Me.lblstudentlogin.Name = "lblstudentlogin"
        Me.lblstudentlogin.Size = New System.Drawing.Size(282, 113)
        Me.lblstudentlogin.TabIndex = 3
        Me.lblstudentlogin.Text = "Student Login"
        Me.lblstudentlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtUserLogin
        '
        Me.txtUserLogin.BackColor = System.Drawing.Color.White
        Me.txtUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.ForeColor = System.Drawing.Color.Black
        Me.txtUserLogin.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserLogin.HintText = "Student ID"
        Me.txtUserLogin.isPassword = False
        Me.txtUserLogin.LineFocusedColor = System.Drawing.Color.SlateBlue
        Me.txtUserLogin.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtUserLogin.LineMouseHoverColor = System.Drawing.Color.SlateBlue
        Me.txtUserLogin.LineThickness = 3
        Me.txtUserLogin.Location = New System.Drawing.Point(31, 277)
        Me.txtUserLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(266, 32)
        Me.txtUserLogin.TabIndex = 10
        Me.txtUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.Color.White
        Me.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassword.ForeColor = System.Drawing.Color.Black
        Me.txtUserPassword.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUserPassword.HintText = "Password"
        Me.txtUserPassword.isPassword = True
        Me.txtUserPassword.LineFocusedColor = System.Drawing.Color.SlateBlue
        Me.txtUserPassword.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtUserPassword.LineMouseHoverColor = System.Drawing.Color.SlateBlue
        Me.txtUserPassword.LineThickness = 3
        Me.txtUserPassword.Location = New System.Drawing.Point(31, 317)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(266, 35)
        Me.txtUserPassword.TabIndex = 11
        Me.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblRegister.ForeColor = System.Drawing.Color.Black
        Me.lblRegister.Location = New System.Drawing.Point(233, 356)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(59, 16)
        Me.lblRegister.TabIndex = 13
        Me.lblRegister.Text = "Register"
        '
        'lblForgetpass
        '
        Me.lblForgetpass.AutoSize = True
        Me.lblForgetpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgetpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblForgetpass.ForeColor = System.Drawing.Color.Black
        Me.lblForgetpass.Location = New System.Drawing.Point(28, 356)
        Me.lblForgetpass.Name = "lblForgetpass"
        Me.lblForgetpass.Size = New System.Drawing.Size(110, 16)
        Me.lblForgetpass.TabIndex = 14
        Me.lblForgetpass.Text = "Forget Password"
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PnlTopBorder.BackgroundImage = CType(resources.GetObject("PnlTopBorder.BackgroundImage"), System.Drawing.Image)
        Me.PnlTopBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTopBorder.Controls.Add(Me.IconButton2)
        Me.PnlTopBorder.Controls.Add(Me.IconButton3)
        Me.PnlTopBorder.Controls.Add(Me.btnClose)
        Me.PnlTopBorder.Controls.Add(Me.IconButton1)
        Me.PnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTopBorder.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlTopBorder.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlTopBorder.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlTopBorder.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.PnlTopBorder.Name = "PnlTopBorder"
        Me.PnlTopBorder.Quality = 10
        Me.PnlTopBorder.Size = New System.Drawing.Size(328, 34)
        Me.PnlTopBorder.TabIndex = 21
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(287, 1)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(30, 33)
        Me.IconButton2.TabIndex = 12
        Me.IconButton2.Text = "X"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(271, 1)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(17, 33)
        Me.IconButton3.TabIndex = 13
        Me.IconButton3.Text = "-"
        Me.IconButton3.UseVisualStyleBackColor = False
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
        Me.btnlogin.IdleForecolor = System.Drawing.Color.Transparent
        Me.btnlogin.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnlogin.Location = New System.Drawing.Point(31, 388)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(266, 47)
        Me.btnlogin.TabIndex = 12
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnBack.IdleForecolor = System.Drawing.Color.Transparent
        Me.btnBack.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnBack.Location = New System.Drawing.Point(31, 431)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 47)
        Me.btnBack.TabIndex = 22
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logoLogin
        '
        Me.logoLogin.BackColor = System.Drawing.Color.Transparent
        Me.logoLogin.BackgroundImage = CType(resources.GetObject("logoLogin.BackgroundImage"), System.Drawing.Image)
        Me.logoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoLogin.Location = New System.Drawing.Point(48, 141)
        Me.logoLogin.Name = "logoLogin"
        Me.logoLogin.Size = New System.Drawing.Size(232, 115)
        Me.logoLogin.TabIndex = 25
        Me.logoLogin.TabStop = False
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
        Me.PassIcon.Location = New System.Drawing.Point(32, 323)
        Me.PassIcon.Name = "PassIcon"
        Me.PassIcon.Size = New System.Drawing.Size(25, 23)
        Me.PassIcon.TabIndex = 30
        Me.PassIcon.TabStop = False
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
        Me.UserIcon.Location = New System.Drawing.Point(32, 281)
        Me.UserIcon.Name = "UserIcon"
        Me.UserIcon.Size = New System.Drawing.Size(22, 22)
        Me.UserIcon.TabIndex = 31
        Me.UserIcon.TabStop = False
        '
        'iconShowPass
        '
        Me.iconShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconShowPass.FlatAppearance.BorderSize = 0
        Me.iconShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.iconShowPass.IconColor = System.Drawing.Color.Black
        Me.iconShowPass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconShowPass.IconSize = 30
        Me.iconShowPass.Location = New System.Drawing.Point(262, 324)
        Me.iconShowPass.Name = "iconShowPass"
        Me.iconShowPass.Size = New System.Drawing.Size(35, 22)
        Me.iconShowPass.TabIndex = 43
        Me.iconShowPass.UseVisualStyleBackColor = True
        '
        'iconHidePass
        '
        Me.iconHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconHidePass.FlatAppearance.BorderSize = 0
        Me.iconHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconHidePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.iconHidePass.IconColor = System.Drawing.Color.Black
        Me.iconHidePass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconHidePass.IconSize = 30
        Me.iconHidePass.Location = New System.Drawing.Point(262, 324)
        Me.iconHidePass.Name = "iconHidePass"
        Me.iconHidePass.Size = New System.Drawing.Size(35, 22)
        Me.iconHidePass.TabIndex = 44
        Me.iconHidePass.UseVisualStyleBackColor = True
        Me.iconHidePass.Visible = False
        '
        'studentlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 505)
        Me.Controls.Add(Me.logoLogin)
        Me.Controls.Add(Me.lblstudentlogin)
        Me.Controls.Add(Me.iconShowPass)
        Me.Controls.Add(Me.iconHidePass)
        Me.Controls.Add(Me.UserIcon)
        Me.Controls.Add(Me.PassIcon)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PnlTopBorder)
        Me.Controls.Add(Me.lblForgetpass)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.txtUserLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeTableSystem-V1.0"
        Me.PnlTopBorder.ResumeLayout(False)
        CType(Me.logoLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstudentlogin As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtUserLogin As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUserPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblForgetpass As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRegister As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PnlTopBorder As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents logoLogin As PictureBox
    Friend WithEvents UserIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PassIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconShowPass As FontAwesome.Sharp.IconButton
    Friend WithEvents iconHidePass As FontAwesome.Sharp.IconButton
End Class
