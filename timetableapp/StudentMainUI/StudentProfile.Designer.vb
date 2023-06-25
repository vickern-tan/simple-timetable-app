<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfile
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
        Me.lblintakecode = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblProfileTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(78, 347)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(114, 33)
        Me.lblEmail.TabIndex = 44
        Me.lblEmail.Text = "Email :"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(78, 229)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(177, 33)
        Me.lblUsername.TabIndex = 43
        Me.lblUsername.Text = "Username :"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(78, 170)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(179, 33)
        Me.lblFullName.TabIndex = 42
        Me.lblFullName.Text = "Full Name :"
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblintakecode
        '
        Me.lblintakecode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblintakecode.AutoSize = True
        Me.lblintakecode.BackColor = System.Drawing.Color.Transparent
        Me.lblintakecode.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintakecode.ForeColor = System.Drawing.Color.Black
        Me.lblintakecode.Location = New System.Drawing.Point(78, 288)
        Me.lblintakecode.Name = "lblintakecode"
        Me.lblintakecode.Size = New System.Drawing.Size(207, 33)
        Me.lblintakecode.TabIndex = 41
        Me.lblintakecode.Text = "Intake Code :"
        Me.lblintakecode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtEmail.Location = New System.Drawing.Point(196, 347)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(523, 33)
        Me.txtEmail.TabIndex = 40
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIntakeCode.BackColor = System.Drawing.Color.White
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtIntakeCode.Location = New System.Drawing.Point(289, 288)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.ReadOnly = True
        Me.txtIntakeCode.Size = New System.Drawing.Size(430, 33)
        Me.txtIntakeCode.TabIndex = 39
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtUsername.Location = New System.Drawing.Point(261, 229)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(458, 33)
        Me.txtUsername.TabIndex = 38
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.SlateBlue
        Me.txtFullName.Location = New System.Drawing.Point(261, 170)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(458, 33)
        Me.txtFullName.TabIndex = 37
        Me.txtFullName.Text = "Test"
        '
        'lblProfileTitle
        '
        Me.lblProfileTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProfileTitle.Font = New System.Drawing.Font("Lucida Fax", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileTitle.ForeColor = System.Drawing.Color.Black
        Me.lblProfileTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblProfileTitle.Name = "lblProfileTitle"
        Me.lblProfileTitle.Size = New System.Drawing.Size(800, 154)
        Me.lblProfileTitle.TabIndex = 45
        Me.lblProfileTitle.Text = "'s Profile Name here"
        Me.lblProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblintakecode)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtIntakeCode)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblProfileTitle)
        Me.Name = "StudentProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblUsername As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFullName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblintakecode As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblProfileTitle As Bunifu.Framework.UI.BunifuCustomLabel
End Class
