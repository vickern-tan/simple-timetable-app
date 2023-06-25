<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedulerRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulerRegistration))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtconfirmpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblSchedulerTitle = New System.Windows.Forms.Label()
        Me.iconShowPass = New FontAwesome.Sharp.IconButton()
        Me.iconHidePass = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.PnlTopBorder = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtSchedulerID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PnlTopBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 20
        Me.btnBack.ActiveFillColor = System.Drawing.Color.Red
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.Red
        Me.btnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back To Login"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 20
        Me.btnBack.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnBack.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnBack.Location = New System.Drawing.Point(112, 397)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(556, 59)
        Me.btnBack.TabIndex = 38
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.ActiveBorderThickness = 1
        Me.btnRegister.ActiveCornerRadius = 20
        Me.btnRegister.ActiveFillColor = System.Drawing.Color.Red
        Me.btnRegister.ActiveForecolor = System.Drawing.Color.White
        Me.btnRegister.ActiveLineColor = System.Drawing.Color.Red
        Me.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegister.BackgroundImage = CType(resources.GetObject("btnRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnRegister.ButtonText = "Register"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRegister.IdleBorderThickness = 1
        Me.btnRegister.IdleCornerRadius = 20
        Me.btnRegister.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnRegister.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnRegister.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRegister.Location = New System.Drawing.Point(112, 344)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(556, 59)
        Me.btnRegister.TabIndex = 36
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.HintText = "Password*"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtPassword.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(413, 201)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(255, 36)
        Me.txtPassword.TabIndex = 35
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFullname.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtFullname.HintText = "Full Name*"
        Me.txtFullname.isPassword = False
        Me.txtFullname.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtFullname.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtFullname.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtFullname.LineThickness = 3
        Me.txtFullname.Location = New System.Drawing.Point(413, 136)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(255, 36)
        Me.txtFullname.TabIndex = 34
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEmail.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtEmail.HintText = "Email*"
        Me.txtEmail.isPassword = False
        Me.txtEmail.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtEmail.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtEmail.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtEmail.LineThickness = 3
        Me.txtEmail.Location = New System.Drawing.Point(112, 266)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(255, 36)
        Me.txtEmail.TabIndex = 33
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsername.HintText = "Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtUsername.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtUsername.LineThickness = 3
        Me.txtUsername.Location = New System.Drawing.Point(112, 201)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(255, 36)
        Me.txtUsername.TabIndex = 32
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtconfirmpass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtconfirmpass.HintText = "Confirm Password"
        Me.txtconfirmpass.isPassword = False
        Me.txtconfirmpass.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtconfirmpass.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtconfirmpass.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtconfirmpass.LineThickness = 3
        Me.txtconfirmpass.Location = New System.Drawing.Point(413, 266)
        Me.txtconfirmpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.Size = New System.Drawing.Size(255, 36)
        Me.txtconfirmpass.TabIndex = 31
        Me.txtconfirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSchedulerTitle
        '
        Me.lblSchedulerTitle.Font = New System.Drawing.Font("Perpetua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedulerTitle.Location = New System.Drawing.Point(178, 41)
        Me.lblSchedulerTitle.Name = "lblSchedulerTitle"
        Me.lblSchedulerTitle.Size = New System.Drawing.Size(424, 66)
        Me.lblSchedulerTitle.TabIndex = 30
        Me.lblSchedulerTitle.Text = "Scheduler Register"
        Me.lblSchedulerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.iconShowPass.Location = New System.Drawing.Point(675, 217)
        Me.iconShowPass.Name = "iconShowPass"
        Me.iconShowPass.Size = New System.Drawing.Size(35, 22)
        Me.iconShowPass.TabIndex = 39
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
        Me.iconHidePass.Location = New System.Drawing.Point(675, 217)
        Me.iconHidePass.Name = "iconHidePass"
        Me.iconHidePass.Size = New System.Drawing.Size(35, 22)
        Me.iconHidePass.TabIndex = 40
        Me.iconHidePass.UseVisualStyleBackColor = True
        Me.iconHidePass.Visible = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(738, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(722, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(17, 33)
        Me.btnMinimize.TabIndex = 11
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlTopBorder.BackgroundImage = CType(resources.GetObject("PnlTopBorder.BackgroundImage"), System.Drawing.Image)
        Me.PnlTopBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTopBorder.Controls.Add(Me.btnClose)
        Me.PnlTopBorder.Controls.Add(Me.btnMinimize)
        Me.PnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTopBorder.GradientBottomLeft = System.Drawing.Color.WhiteSmoke
        Me.PnlTopBorder.GradientBottomRight = System.Drawing.Color.WhiteSmoke
        Me.PnlTopBorder.GradientTopLeft = System.Drawing.Color.WhiteSmoke
        Me.PnlTopBorder.GradientTopRight = System.Drawing.Color.WhiteSmoke
        Me.PnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.PnlTopBorder.Name = "PnlTopBorder"
        Me.PnlTopBorder.Quality = 10
        Me.PnlTopBorder.Size = New System.Drawing.Size(780, 38)
        Me.PnlTopBorder.TabIndex = 41
        '
        'txtSchedulerID
        '
        Me.txtSchedulerID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSchedulerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchedulerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedulerID.ForeColor = System.Drawing.Color.Black
        Me.txtSchedulerID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtSchedulerID.HintText = "Scheduler ID*(SCHE)"
        Me.txtSchedulerID.isPassword = False
        Me.txtSchedulerID.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.txtSchedulerID.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtSchedulerID.LineMouseHoverColor = System.Drawing.Color.DarkOrange
        Me.txtSchedulerID.LineThickness = 3
        Me.txtSchedulerID.Location = New System.Drawing.Point(112, 136)
        Me.txtSchedulerID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSchedulerID.Name = "txtSchedulerID"
        Me.txtSchedulerID.Size = New System.Drawing.Size(255, 36)
        Me.txtSchedulerID.TabIndex = 44
        Me.txtSchedulerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SchedulerRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(780, 469)
        Me.Controls.Add(Me.txtSchedulerID)
        Me.Controls.Add(Me.PnlTopBorder)
        Me.Controls.Add(Me.iconShowPass)
        Me.Controls.Add(Me.iconHidePass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.lblSchedulerTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SchedulerRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SchedulerRegistration"
        Me.PnlTopBorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtconfirmpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblSchedulerTitle As Label
    Friend WithEvents iconShowPass As FontAwesome.Sharp.IconButton
    Friend WithEvents iconHidePass As FontAwesome.Sharp.IconButton
    Friend WithEvents PnlTopBorder As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSchedulerID As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
