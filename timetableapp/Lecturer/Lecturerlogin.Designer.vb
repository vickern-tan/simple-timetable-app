<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lecturerlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lecturerlogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblForgetpass = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRegister = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtUserPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtUserLogin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PnlTopBorder = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.iconUser = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPass = New FontAwesome.Sharp.IconPictureBox()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iconShowPass = New FontAwesome.Sharp.IconButton()
        Me.iconHidePass = New FontAwesome.Sharp.IconButton()
        Me.PnlTopBorder.SuspendLayout()
        CType(Me.iconUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblForgetpass
        '
        Me.lblForgetpass.AutoSize = True
        Me.lblForgetpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgetpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetpass.Location = New System.Drawing.Point(33, 353)
        Me.lblForgetpass.Name = "lblForgetpass"
        Me.lblForgetpass.Size = New System.Drawing.Size(110, 16)
        Me.lblForgetpass.TabIndex = 27
        Me.lblForgetpass.Text = "Forget Password"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(239, 353)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(59, 16)
        Me.lblRegister.TabIndex = 26
        Me.lblRegister.Text = "Register"
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassword.ForeColor = System.Drawing.Color.Black
        Me.txtUserPassword.HintForeColor = System.Drawing.Color.Black
        Me.txtUserPassword.HintText = "Password"
        Me.txtUserPassword.isPassword = False
        Me.txtUserPassword.LineFocusedColor = System.Drawing.Color.Cyan
        Me.txtUserPassword.LineIdleColor = System.Drawing.Color.Silver
        Me.txtUserPassword.LineMouseHoverColor = System.Drawing.Color.Cyan
        Me.txtUserPassword.LineThickness = 3
        Me.txtUserPassword.Location = New System.Drawing.Point(31, 306)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(266, 41)
        Me.txtUserPassword.TabIndex = 24
        Me.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Perpetua", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(3, 51)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(325, 96)
        Me.lbltitle.TabIndex = 21
        Me.lbltitle.Text = "LECTURER LOGIN"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserLogin
        '
        Me.txtUserLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.ForeColor = System.Drawing.Color.Black
        Me.txtUserLogin.HintForeColor = System.Drawing.Color.Black
        Me.txtUserLogin.HintText = "ID"
        Me.txtUserLogin.isPassword = False
        Me.txtUserLogin.LineFocusedColor = System.Drawing.Color.Cyan
        Me.txtUserLogin.LineIdleColor = System.Drawing.Color.Silver
        Me.txtUserLogin.LineMouseHoverColor = System.Drawing.Color.Cyan
        Me.txtUserLogin.LineThickness = 3
        Me.txtUserLogin.Location = New System.Drawing.Point(31, 263)
        Me.txtUserLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(266, 41)
        Me.txtUserLogin.TabIndex = 23
        Me.txtUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnlTopBorder.BackgroundImage = CType(resources.GetObject("PnlTopBorder.BackgroundImage"), System.Drawing.Image)
        Me.PnlTopBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTopBorder.Controls.Add(Me.btnExit)
        Me.PnlTopBorder.Controls.Add(Me.btnMinimize)
        Me.PnlTopBorder.Controls.Add(Me.btnClose)
        Me.PnlTopBorder.Controls.Add(Me.IconButton1)
        Me.PnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTopBorder.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnlTopBorder.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnlTopBorder.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnlTopBorder.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.PnlTopBorder.Name = "PnlTopBorder"
        Me.PnlTopBorder.Quality = 10
        Me.PnlTopBorder.Size = New System.Drawing.Size(328, 34)
        Me.PnlTopBorder.TabIndex = 31
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
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 20
        Me.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.ActiveForecolor = System.Drawing.Color.Black
        Me.btnBack.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 20
        Me.btnBack.IdleFillColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.IdleForecolor = System.Drawing.Color.Black
        Me.btnBack.IdleLineColor = System.Drawing.Color.MediumTurquoise
        Me.btnBack.Location = New System.Drawing.Point(31, 422)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 47)
        Me.btnBack.TabIndex = 30
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconUser
        '
        Me.iconUser.BackColor = System.Drawing.Color.Transparent
        Me.iconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.iconUser.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconUser.IconSize = 22
        Me.iconUser.Location = New System.Drawing.Point(36, 276)
        Me.iconUser.Name = "iconUser"
        Me.iconUser.Size = New System.Drawing.Size(22, 22)
        Me.iconUser.TabIndex = 29
        Me.iconUser.TabStop = False
        '
        'iconPass
        '
        Me.iconPass.BackColor = System.Drawing.Color.Transparent
        Me.iconPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iconPass.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.iconPass.IconColor = System.Drawing.SystemColors.ControlText
        Me.iconPass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconPass.IconSize = 23
        Me.iconPass.Location = New System.Drawing.Point(36, 319)
        Me.iconPass.Name = "iconPass"
        Me.iconPass.Size = New System.Drawing.Size(25, 23)
        Me.iconPass.TabIndex = 28
        Me.iconPass.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.ActiveBorderThickness = 1
        Me.btnlogin.ActiveCornerRadius = 20
        Me.btnlogin.ActiveFillColor = System.Drawing.Color.Turquoise
        Me.btnlogin.ActiveForecolor = System.Drawing.Color.Black
        Me.btnlogin.ActiveLineColor = System.Drawing.Color.Turquoise
        Me.btnlogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleCornerRadius = 20
        Me.btnlogin.IdleFillColor = System.Drawing.Color.MediumTurquoise
        Me.btnlogin.IdleForecolor = System.Drawing.Color.Black
        Me.btnlogin.IdleLineColor = System.Drawing.Color.MediumTurquoise
        Me.btnlogin.Location = New System.Drawing.Point(32, 380)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(266, 47)
        Me.btnlogin.TabIndex = 25
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(40, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 138)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
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
        Me.iconShowPass.Location = New System.Drawing.Point(263, 320)
        Me.iconShowPass.Name = "iconShowPass"
        Me.iconShowPass.Size = New System.Drawing.Size(35, 22)
        Me.iconShowPass.TabIndex = 42
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
        Me.iconHidePass.Location = New System.Drawing.Point(263, 320)
        Me.iconHidePass.Name = "iconHidePass"
        Me.iconHidePass.Size = New System.Drawing.Size(35, 22)
        Me.iconHidePass.TabIndex = 43
        Me.iconHidePass.UseVisualStyleBackColor = True
        Me.iconHidePass.Visible = False
        '
        'Lecturerlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(328, 494)
        Me.Controls.Add(Me.iconShowPass)
        Me.Controls.Add(Me.iconHidePass)
        Me.Controls.Add(Me.PnlTopBorder)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.iconUser)
        Me.Controls.Add(Me.iconPass)
        Me.Controls.Add(Me.lblForgetpass)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUserLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturerlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturerlogin"
        Me.PnlTopBorder.ResumeLayout(False)
        CType(Me.iconUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents iconUser As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPass As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblForgetpass As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRegister As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtUserPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbltitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUserLogin As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PnlTopBorder As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents iconShowPass As FontAwesome.Sharp.IconButton
    Friend WithEvents iconHidePass As FontAwesome.Sharp.IconButton
End Class
