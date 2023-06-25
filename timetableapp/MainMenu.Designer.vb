<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuform))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.iconScheduler = New FontAwesome.Sharp.IconButton()
        Me.iconLecturer = New FontAwesome.Sharp.IconButton()
        Me.iconStudent = New FontAwesome.Sharp.IconButton()
        Me.PnlTopBorder = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.logoMain = New System.Windows.Forms.PictureBox()
        Me.PnlTopBorder.SuspendLayout()
        CType(Me.logoMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'lbltitle
        '
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Perpetua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lbltitle.Location = New System.Drawing.Point(234, 29)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(497, 55)
        Me.lbltitle.TabIndex = 6
        Me.lbltitle.Text = "Timetable System"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconScheduler
        '
        Me.iconScheduler.BackColor = System.Drawing.Color.Transparent
        Me.iconScheduler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconScheduler.FlatAppearance.BorderSize = 5
        Me.iconScheduler.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconScheduler.ForeColor = System.Drawing.Color.Maroon
        Me.iconScheduler.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        Me.iconScheduler.IconColor = System.Drawing.Color.Black
        Me.iconScheduler.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconScheduler.IconSize = 82
        Me.iconScheduler.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.iconScheduler.Location = New System.Drawing.Point(510, 306)
        Me.iconScheduler.Name = "iconScheduler"
        Me.iconScheduler.Size = New System.Drawing.Size(150, 135)
        Me.iconScheduler.TabIndex = 9
        Me.iconScheduler.Text = "Login as Scheduler"
        Me.iconScheduler.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.iconScheduler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.iconScheduler.UseVisualStyleBackColor = False
        '
        'iconLecturer
        '
        Me.iconLecturer.BackColor = System.Drawing.Color.Transparent
        Me.iconLecturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconLecturer.FlatAppearance.BorderSize = 5
        Me.iconLecturer.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconLecturer.ForeColor = System.Drawing.Color.Maroon
        Me.iconLecturer.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.iconLecturer.IconColor = System.Drawing.Color.Black
        Me.iconLecturer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconLecturer.IconSize = 75
        Me.iconLecturer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.iconLecturer.Location = New System.Drawing.Point(738, 127)
        Me.iconLecturer.Name = "iconLecturer"
        Me.iconLecturer.Size = New System.Drawing.Size(150, 135)
        Me.iconLecturer.TabIndex = 8
        Me.iconLecturer.Text = "Login as Lecturer"
        Me.iconLecturer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.iconLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.iconLecturer.UseVisualStyleBackColor = False
        '
        'iconStudent
        '
        Me.iconStudent.BackColor = System.Drawing.Color.Transparent
        Me.iconStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconStudent.FlatAppearance.BorderSize = 5
        Me.iconStudent.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconStudent.ForeColor = System.Drawing.Color.Maroon
        Me.iconStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.iconStudent.IconColor = System.Drawing.Color.Black
        Me.iconStudent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconStudent.IconSize = 75
        Me.iconStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.iconStudent.Location = New System.Drawing.Point(510, 127)
        Me.iconStudent.Name = "iconStudent"
        Me.iconStudent.Size = New System.Drawing.Size(150, 135)
        Me.iconStudent.TabIndex = 7
        Me.iconStudent.Text = "Login as Student"
        Me.iconStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.iconStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.iconStudent.UseVisualStyleBackColor = False
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.BackColor = System.Drawing.Color.White
        Me.PnlTopBorder.BackgroundImage = CType(resources.GetObject("PnlTopBorder.BackgroundImage"), System.Drawing.Image)
        Me.PnlTopBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.PnlTopBorder.Size = New System.Drawing.Size(969, 37)
        Me.PnlTopBorder.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(928, 4)
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
        Me.IconButton1.Location = New System.Drawing.Point(912, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(17, 33)
        Me.IconButton1.TabIndex = 11
        Me.IconButton1.Text = "-"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'logoMain
        '
        Me.logoMain.BackColor = System.Drawing.Color.Transparent
        Me.logoMain.BackgroundImage = CType(resources.GetObject("logoMain.BackgroundImage"), System.Drawing.Image)
        Me.logoMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoMain.Location = New System.Drawing.Point(31, 116)
        Me.logoMain.Name = "logoMain"
        Me.logoMain.Size = New System.Drawing.Size(388, 325)
        Me.logoMain.TabIndex = 26
        Me.logoMain.TabStop = False
        '
        'menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 499)
        Me.Controls.Add(Me.logoMain)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PnlTopBorder)
        Me.Controls.Add(Me.iconScheduler)
        Me.Controls.Add(Me.iconLecturer)
        Me.Controls.Add(Me.iconStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(7, 7)
        Me.MaximizeBox = False
        Me.Name = "menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.PnlTopBorder.ResumeLayout(False)
        CType(Me.logoMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents iconScheduler As FontAwesome.Sharp.IconButton
    Friend WithEvents iconLecturer As FontAwesome.Sharp.IconButton
    Friend WithEvents iconStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents lbltitle As Label
    Friend WithEvents PnlTopBorder As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents logoMain As PictureBox
End Class
