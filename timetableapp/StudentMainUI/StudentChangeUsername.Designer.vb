<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentChangeUsername
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentChangeUsername))
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.txtStudentMail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btncancel2 = New FontAwesome.Sharp.IconButton()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.Savebtn2 = New FontAwesome.Sharp.IconButton()
        Me.Savebtn1 = New FontAwesome.Sharp.IconButton()
        Me.btnEdit2 = New FontAwesome.Sharp.IconButton()
        Me.btnEdit1 = New FontAwesome.Sharp.IconButton()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Fax", 36.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Azure
        Me.lblTitle.Location = New System.Drawing.Point(0, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(926, 135)
        Me.lblTitle.TabIndex = 40
        Me.lblTitle.Text = "CUSTOMIZE USER DETAILS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.SlateGray
        Me.PanelTitle.Controls.Add(Me.btnClose)
        Me.PanelTitle.Controls.Add(Me.btnMinimize)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(926, 37)
        Me.PanelTitle.TabIndex = 39
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(884, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Black
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(864, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 32)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'txtStudentMail
        '
        Me.txtStudentMail.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtStudentMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentMail.ForeColor = System.Drawing.Color.Black
        Me.txtStudentMail.HintForeColor = System.Drawing.Color.Empty
        Me.txtStudentMail.HintText = "Email Address"
        Me.txtStudentMail.isPassword = False
        Me.txtStudentMail.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtStudentMail.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtStudentMail.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtStudentMail.LineThickness = 2
        Me.txtStudentMail.Location = New System.Drawing.Point(175, 274)
        Me.txtStudentMail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentMail.Name = "txtStudentMail"
        Me.txtStudentMail.Size = New System.Drawing.Size(574, 41)
        Me.txtStudentMail.TabIndex = 36
        Me.txtStudentMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = "Student Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtUsername.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtUsername.LineThickness = 2
        Me.txtUsername.Location = New System.Drawing.Point(175, 202)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(574, 41)
        Me.txtUsername.TabIndex = 35
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'btncancel2
        '
        Me.btncancel2.BackColor = System.Drawing.Color.Transparent
        Me.btncancel2.FlatAppearance.BorderSize = 0
        Me.btncancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel2.ForeColor = System.Drawing.Color.Red
        Me.btncancel2.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.btncancel2.IconColor = System.Drawing.Color.Red
        Me.btncancel2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btncancel2.IconSize = 30
        Me.btncancel2.Location = New System.Drawing.Point(756, 280)
        Me.btncancel2.Name = "btncancel2"
        Me.btncancel2.Size = New System.Drawing.Size(101, 36)
        Me.btncancel2.TabIndex = 46
        Me.btncancel2.Text = "Cancel"
        Me.btncancel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel2.UseVisualStyleBackColor = False
        Me.btncancel2.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.btnCancel.IconColor = System.Drawing.Color.Red
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnCancel.IconSize = 30
        Me.btnCancel.Location = New System.Drawing.Point(756, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 36)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'Savebtn2
        '
        Me.Savebtn2.BackColor = System.Drawing.Color.Transparent
        Me.Savebtn2.FlatAppearance.BorderSize = 0
        Me.Savebtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.Savebtn2.IconColor = System.Drawing.Color.Black
        Me.Savebtn2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.Savebtn2.IconSize = 30
        Me.Savebtn2.Location = New System.Drawing.Point(714, 276)
        Me.Savebtn2.Name = "Savebtn2"
        Me.Savebtn2.Size = New System.Drawing.Size(35, 36)
        Me.Savebtn2.TabIndex = 44
        Me.Savebtn2.UseVisualStyleBackColor = False
        Me.Savebtn2.Visible = False
        '
        'Savebtn1
        '
        Me.Savebtn1.BackColor = System.Drawing.Color.Transparent
        Me.Savebtn1.FlatAppearance.BorderSize = 0
        Me.Savebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.Savebtn1.IconColor = System.Drawing.Color.Black
        Me.Savebtn1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.Savebtn1.IconSize = 30
        Me.Savebtn1.Location = New System.Drawing.Point(713, 202)
        Me.Savebtn1.Name = "Savebtn1"
        Me.Savebtn1.Size = New System.Drawing.Size(35, 36)
        Me.Savebtn1.TabIndex = 43
        Me.Savebtn1.UseVisualStyleBackColor = False
        Me.Savebtn1.Visible = False
        '
        'btnEdit2
        '
        Me.btnEdit2.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit2.FlatAppearance.BorderSize = 0
        Me.btnEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit2.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit2.IconColor = System.Drawing.Color.Black
        Me.btnEdit2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit2.IconSize = 30
        Me.btnEdit2.Location = New System.Drawing.Point(713, 286)
        Me.btnEdit2.Name = "btnEdit2"
        Me.btnEdit2.Size = New System.Drawing.Size(36, 24)
        Me.btnEdit2.TabIndex = 42
        Me.btnEdit2.UseVisualStyleBackColor = False
        '
        'btnEdit1
        '
        Me.btnEdit1.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit1.FlatAppearance.BorderSize = 0
        Me.btnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit1.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit1.IconColor = System.Drawing.Color.Black
        Me.btnEdit1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit1.IconSize = 30
        Me.btnEdit1.Location = New System.Drawing.Point(713, 214)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(36, 24)
        Me.btnEdit1.TabIndex = 41
        Me.btnEdit1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 42
        Me.btnBack.ActiveFillColor = System.Drawing.Color.Red
        Me.btnBack.ActiveForecolor = System.Drawing.Color.Black
        Me.btnBack.ActiveLineColor = System.Drawing.Color.White
        Me.btnBack.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 40
        Me.btnBack.IdleFillColor = System.Drawing.Color.White
        Me.btnBack.IdleForecolor = System.Drawing.Color.Black
        Me.btnBack.IdleLineColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(318, 362)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(289, 73)
        Me.btnBack.TabIndex = 38
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentChangeUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(926, 523)
        Me.Controls.Add(Me.btncancel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Savebtn2)
        Me.Controls.Add(Me.Savebtn1)
        Me.Controls.Add(Me.btnEdit2)
        Me.Controls.Add(Me.btnEdit1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtStudentMail)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentChangeUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentChangeUsername"
        Me.PanelTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtStudentMail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnEdit1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEdit2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Savebtn1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Savebtn2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btncancel2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
End Class
