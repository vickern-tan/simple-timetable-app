<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccount))
        Me.lblMyAccount = New System.Windows.Forms.Label()
        Me.btnUserProfile = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnChgUsername = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnChgPass = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'lblMyAccount
        '
        Me.lblMyAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMyAccount.Font = New System.Drawing.Font("Perpetua", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMyAccount.Location = New System.Drawing.Point(0, 0)
        Me.lblMyAccount.Name = "lblMyAccount"
        Me.lblMyAccount.Size = New System.Drawing.Size(927, 101)
        Me.lblMyAccount.TabIndex = 2
        Me.lblMyAccount.Text = "My Account"
        Me.lblMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUserProfile
        '
        Me.btnUserProfile.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btnUserProfile.Location = New System.Drawing.Point(26, 171)
        Me.btnUserProfile.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnUserProfile.Name = "btnUserProfile"
        Me.btnUserProfile.Size = New System.Drawing.Size(238, 209)
        Me.btnUserProfile.TabIndex = 14
        '
        'btnChgUsername
        '
        Me.btnChgUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChgUsername.BackColor = System.Drawing.Color.SlateBlue
        Me.btnChgUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnChgUsername.color = System.Drawing.Color.SlateBlue
        Me.btnChgUsername.colorActive = System.Drawing.Color.DarkSlateBlue
        Me.btnChgUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChgUsername.Font = New System.Drawing.Font("Copperplate Gothic Bold", 15.75!)
        Me.btnChgUsername.ForeColor = System.Drawing.Color.Black
        Me.btnChgUsername.Image = CType(resources.GetObject("btnChgUsername.Image"), System.Drawing.Image)
        Me.btnChgUsername.ImagePosition = 17
        Me.btnChgUsername.ImageZoom = 60
        Me.btnChgUsername.LabelPosition = 41
        Me.btnChgUsername.LabelText = "Change Username"
        Me.btnChgUsername.Location = New System.Drawing.Point(673, 171)
        Me.btnChgUsername.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnChgUsername.Name = "btnChgUsername"
        Me.btnChgUsername.Size = New System.Drawing.Size(238, 209)
        Me.btnChgUsername.TabIndex = 5
        '
        'btnChgPass
        '
        Me.btnChgPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChgPass.BackColor = System.Drawing.Color.SlateBlue
        Me.btnChgPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnChgPass.color = System.Drawing.Color.SlateBlue
        Me.btnChgPass.colorActive = System.Drawing.Color.DarkSlateBlue
        Me.btnChgPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChgPass.Font = New System.Drawing.Font("Copperplate Gothic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPass.ForeColor = System.Drawing.Color.Black
        Me.btnChgPass.Image = CType(resources.GetObject("btnChgPass.Image"), System.Drawing.Image)
        Me.btnChgPass.ImagePosition = 10
        Me.btnChgPass.ImageZoom = 70
        Me.btnChgPass.LabelPosition = 42
        Me.btnChgPass.LabelText = "Change Password"
        Me.btnChgPass.Location = New System.Drawing.Point(344, 171)
        Me.btnChgPass.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnChgPass.Name = "btnChgPass"
        Me.btnChgPass.Size = New System.Drawing.Size(238, 209)
        Me.btnChgPass.TabIndex = 4
        '
        'FormAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(927, 488)
        Me.Controls.Add(Me.btnUserProfile)
        Me.Controls.Add(Me.btnChgUsername)
        Me.Controls.Add(Me.btnChgPass)
        Me.Controls.Add(Me.lblMyAccount)
        Me.Name = "FormAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBooking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMyAccount As Label
    Friend WithEvents btnChgPass As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnChgUsername As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUserProfile As Bunifu.Framework.UI.BunifuTileButton
End Class
