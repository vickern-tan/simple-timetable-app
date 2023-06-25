<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfile))
        Me.lblProfileTitle = New System.Windows.Forms.Label()
        Me.UserProfilePict = New System.Windows.Forms.PictureBox()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblintakecode = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFullName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblUsername = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblEmail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnUserProfile = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.UserProfilePict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProfileTitle
        '
        Me.lblProfileTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProfileTitle.AutoSize = True
        Me.lblProfileTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblProfileTitle.Font = New System.Drawing.Font("Lucida Fax", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileTitle.ForeColor = System.Drawing.Color.SlateGray
        Me.lblProfileTitle.Location = New System.Drawing.Point(354, 9)
        Me.lblProfileTitle.Name = "lblProfileTitle"
        Me.lblProfileTitle.Size = New System.Drawing.Size(409, 72)
        Me.lblProfileTitle.TabIndex = 1
        Me.lblProfileTitle.Text = "User Profile"
        Me.lblProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserProfilePict
        '
        Me.UserProfilePict.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserProfilePict.BackColor = System.Drawing.Color.SlateGray
        Me.UserProfilePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UserProfilePict.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserProfilePict.Location = New System.Drawing.Point(200, 222)
        Me.UserProfilePict.Name = "UserProfilePict"
        Me.UserProfilePict.Size = New System.Drawing.Size(257, 215)
        Me.UserProfilePict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserProfilePict.TabIndex = 2
        Me.UserProfilePict.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.Location = New System.Drawing.Point(278, 443)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 46)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProfileTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 113)
        Me.Panel1.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblintakecode
        '
        Me.lblintakecode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblintakecode.AutoSize = True
        Me.lblintakecode.BackColor = System.Drawing.Color.Transparent
        Me.lblintakecode.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintakecode.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblintakecode.Location = New System.Drawing.Point(507, 336)
        Me.lblintakecode.Name = "lblintakecode"
        Me.lblintakecode.Size = New System.Drawing.Size(207, 33)
        Me.lblintakecode.TabIndex = 5
        Me.lblintakecode.Text = "Intake Code :"
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblFullName.Location = New System.Drawing.Point(507, 222)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(179, 33)
        Me.lblFullName.TabIndex = 6
        Me.lblFullName.Text = "Full Name :"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblUsername.Location = New System.Drawing.Point(507, 279)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(177, 33)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username :"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblEmail.Location = New System.Drawing.Point(507, 393)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(114, 33)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email :"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtFullName.Location = New System.Drawing.Point(692, 223)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(178, 32)
        Me.txtFullName.TabIndex = 9
        Me.txtFullName.Text = "Test"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtUsername.Location = New System.Drawing.Point(690, 280)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(178, 32)
        Me.txtUsername.TabIndex = 10
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtIntakeCode.Location = New System.Drawing.Point(720, 337)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.ReadOnly = True
        Me.txtIntakeCode.Size = New System.Drawing.Size(178, 32)
        Me.txtIntakeCode.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtEmail.Location = New System.Drawing.Point(627, 393)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(178, 32)
        Me.txtEmail.TabIndex = 12
        '
        'btnUserProfile
        '
        Me.btnUserProfile.BackColor = System.Drawing.Color.SlateBlue
        Me.btnUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnUserProfile.color = System.Drawing.Color.SlateBlue
        Me.btnUserProfile.colorActive = System.Drawing.Color.DarkSlateBlue
        Me.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserProfile.Font = New System.Drawing.Font("Copperplate Gothic Bold", 15.75!)
        Me.btnUserProfile.ForeColor = System.Drawing.Color.Black
        Me.btnUserProfile.Image = CType(resources.GetObject("btnUserProfile.Image"), System.Drawing.Image)
        Me.btnUserProfile.ImagePosition = 17
        Me.btnUserProfile.ImageZoom = 60
        Me.btnUserProfile.LabelPosition = 41
        Me.btnUserProfile.LabelText = "My Profile"
        Me.btnUserProfile.Location = New System.Drawing.Point(815, 223)
        Me.btnUserProfile.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnUserProfile.Name = "btnUserProfile"
        Me.btnUserProfile.Size = New System.Drawing.Size(238, 209)
        Me.btnUserProfile.TabIndex = 13
        '
        'FormProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1088, 703)
        Me.Controls.Add(Me.btnUserProfile)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtIntakeCode)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblintakecode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.UserProfilePict)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "FormProfile"
        Me.Text = "FormProfile"
        CType(Me.UserProfilePict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProfileTitle As Label
    Friend WithEvents UserProfilePict As PictureBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblintakecode As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFullName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblUsername As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblEmail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnUserProfile As Bunifu.Framework.UI.BunifuTileButton
End Class
