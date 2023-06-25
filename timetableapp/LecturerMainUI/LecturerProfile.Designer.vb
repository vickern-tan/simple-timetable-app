<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecturerProfile
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
        Me.lblEmail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblUsername = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFullName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblLID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtLecID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblProfileTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(54, 266)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(241, 33)
        Me.lblEmail.TabIndex = 53
        Me.lblEmail.Text = "Email Address :"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(54, 162)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(177, 33)
        Me.lblUsername.TabIndex = 52
        Me.lblUsername.Text = "Username :"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(54, 214)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(179, 33)
        Me.lblFullName.TabIndex = 51
        Me.lblFullName.Text = "Full Name :"
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLID
        '
        Me.lblLID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLID.AutoSize = True
        Me.lblLID.BackColor = System.Drawing.Color.Transparent
        Me.lblLID.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLID.ForeColor = System.Drawing.Color.White
        Me.lblLID.Location = New System.Drawing.Point(54, 318)
        Me.lblLID.Name = "lblLID"
        Me.lblLID.Size = New System.Drawing.Size(188, 33)
        Me.lblLID.TabIndex = 50
        Me.lblLID.Text = "LecturerID :"
        Me.lblLID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.Aqua
        Me.txtFullName.Location = New System.Drawing.Point(237, 215)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(439, 32)
        Me.txtFullName.TabIndex = 46
        Me.txtFullName.Text = "Test"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Aqua
        Me.txtUsername.Location = New System.Drawing.Point(237, 163)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(439, 32)
        Me.txtUsername.TabIndex = 47
        '
        'txtLecID
        '
        Me.txtLecID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLecID.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtLecID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLecID.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecID.ForeColor = System.Drawing.Color.Aqua
        Me.txtLecID.Location = New System.Drawing.Point(248, 319)
        Me.txtLecID.Name = "txtLecID"
        Me.txtLecID.ReadOnly = True
        Me.txtLecID.Size = New System.Drawing.Size(439, 32)
        Me.txtLecID.TabIndex = 48
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Aqua
        Me.txtEmail.Location = New System.Drawing.Point(301, 267)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(439, 32)
        Me.txtEmail.TabIndex = 49
        '
        'lblProfileTitle
        '
        Me.lblProfileTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProfileTitle.Font = New System.Drawing.Font("Lucida Fax", 36.0!)
        Me.lblProfileTitle.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblProfileTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblProfileTitle.Name = "lblProfileTitle"
        Me.lblProfileTitle.Size = New System.Drawing.Size(800, 134)
        Me.lblProfileTitle.TabIndex = 54
        Me.lblProfileTitle.Text = "NAME HERE"
        Me.lblProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LecturerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblLID)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLecID)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblProfileTitle)
        Me.Name = "LecturerProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LecturerProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblUsername As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFullName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblLID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLecID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblProfileTitle As Bunifu.Framework.UI.BunifuCustomLabel
End Class
