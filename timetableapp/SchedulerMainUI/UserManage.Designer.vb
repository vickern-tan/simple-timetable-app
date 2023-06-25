<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusIcon = New FontAwesome.Sharp.IconButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblLecNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStuEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLecEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblStuNo = New System.Windows.Forms.Label()
        Me.LecturerStatus = New FontAwesome.Sharp.IconButton()
        Me.StudentStatus = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.StatusIcon)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 55)
        Me.Panel1.TabIndex = 2
        '
        'StatusIcon
        '
        Me.StatusIcon.BackColor = System.Drawing.Color.Transparent
        Me.StatusIcon.FlatAppearance.BorderSize = 0
        Me.StatusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatusIcon.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusIcon.IconChar = FontAwesome.Sharp.IconChar.ShareAlt
        Me.StatusIcon.IconColor = System.Drawing.Color.BlueViolet
        Me.StatusIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.StatusIcon.IconSize = 30
        Me.StatusIcon.Location = New System.Drawing.Point(23, 12)
        Me.StatusIcon.Name = "StatusIcon"
        Me.StatusIcon.Size = New System.Drawing.Size(54, 54)
        Me.StatusIcon.TabIndex = 4
        Me.StatusIcon.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 20.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(70, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(164, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "User Status :"
        '
        'lblLecNo
        '
        Me.lblLecNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLecNo.AutoSize = True
        Me.lblLecNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblLecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLecNo.Location = New System.Drawing.Point(179, 57)
        Me.lblLecNo.Name = "lblLecNo"
        Me.lblLecNo.Size = New System.Drawing.Size(44, 31)
        Me.lblLecNo.TabIndex = 3
        Me.lblLecNo.Text = "00"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnStuEdit)
        Me.Panel2.Controls.Add(Me.btnLecEdit)
        Me.Panel2.Controls.Add(Me.lblLecNo)
        Me.Panel2.Controls.Add(Me.lblStuNo)
        Me.Panel2.Controls.Add(Me.LecturerStatus)
        Me.Panel2.Controls.Add(Me.StudentStatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 395)
        Me.Panel2.TabIndex = 3
        '
        'btnStuEdit
        '
        Me.btnStuEdit.ActiveBorderThickness = 1
        Me.btnStuEdit.ActiveCornerRadius = 1
        Me.btnStuEdit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnStuEdit.ActiveForecolor = System.Drawing.Color.Black
        Me.btnStuEdit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnStuEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStuEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnStuEdit.BackgroundImage = CType(resources.GetObject("btnStuEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnStuEdit.ButtonText = "Manage Students"
        Me.btnStuEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStuEdit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStuEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnStuEdit.IdleBorderThickness = 1
        Me.btnStuEdit.IdleCornerRadius = 1
        Me.btnStuEdit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnStuEdit.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnStuEdit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnStuEdit.Location = New System.Drawing.Point(475, 255)
        Me.btnStuEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStuEdit.Name = "btnStuEdit"
        Me.btnStuEdit.Size = New System.Drawing.Size(250, 105)
        Me.btnStuEdit.TabIndex = 7
        Me.btnStuEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLecEdit
        '
        Me.btnLecEdit.ActiveBorderThickness = 1
        Me.btnLecEdit.ActiveCornerRadius = 1
        Me.btnLecEdit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnLecEdit.ActiveForecolor = System.Drawing.Color.Black
        Me.btnLecEdit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLecEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLecEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLecEdit.BackgroundImage = CType(resources.GetObject("btnLecEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnLecEdit.ButtonText = "Manage Lecturers"
        Me.btnLecEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLecEdit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLecEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnLecEdit.IdleBorderThickness = 1
        Me.btnLecEdit.IdleCornerRadius = 1
        Me.btnLecEdit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLecEdit.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnLecEdit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnLecEdit.Location = New System.Drawing.Point(76, 255)
        Me.btnLecEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLecEdit.Name = "btnLecEdit"
        Me.btnLecEdit.Size = New System.Drawing.Size(250, 105)
        Me.btnLecEdit.TabIndex = 6
        Me.btnLecEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStuNo
        '
        Me.lblStuNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStuNo.AutoSize = True
        Me.lblStuNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblStuNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblStuNo.Location = New System.Drawing.Point(578, 57)
        Me.lblStuNo.Name = "lblStuNo"
        Me.lblStuNo.Size = New System.Drawing.Size(44, 31)
        Me.lblStuNo.TabIndex = 2
        Me.lblStuNo.Text = "00"
        '
        'LecturerStatus
        '
        Me.LecturerStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LecturerStatus.FlatAppearance.BorderSize = 0
        Me.LecturerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LecturerStatus.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerStatus.ForeColor = System.Drawing.Color.White
        Me.LecturerStatus.IconChar = FontAwesome.Sharp.IconChar.None
        Me.LecturerStatus.IconColor = System.Drawing.Color.White
        Me.LecturerStatus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LecturerStatus.Location = New System.Drawing.Point(2, 0)
        Me.LecturerStatus.Name = "LecturerStatus"
        Me.LecturerStatus.Size = New System.Drawing.Size(399, 248)
        Me.LecturerStatus.TabIndex = 0
        Me.LecturerStatus.Text = "Lecturers"
        Me.LecturerStatus.UseVisualStyleBackColor = False
        '
        'StudentStatus
        '
        Me.StudentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.StudentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StudentStatus.FlatAppearance.BorderSize = 0
        Me.StudentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentStatus.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentStatus.ForeColor = System.Drawing.Color.White
        Me.StudentStatus.IconChar = FontAwesome.Sharp.IconChar.None
        Me.StudentStatus.IconColor = System.Drawing.Color.White
        Me.StudentStatus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.StudentStatus.Location = New System.Drawing.Point(401, 0)
        Me.StudentStatus.Name = "StudentStatus"
        Me.StudentStatus.Size = New System.Drawing.Size(399, 248)
        Me.StudentStatus.TabIndex = 1
        Me.StudentStatus.Text = "Students"
        Me.StudentStatus.UseVisualStyleBackColor = False
        '
        'UserManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "UserManage"
        Me.Text = "UserManage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LecturerStatus As FontAwesome.Sharp.IconButton
    Friend WithEvents StudentStatus As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLecNo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblStuNo As Label
    Friend WithEvents StatusIcon As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLecEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnStuEdit As Bunifu.Framework.UI.BunifuThinButton2
End Class
