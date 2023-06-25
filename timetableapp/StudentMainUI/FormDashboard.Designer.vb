<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Me.lblDashboardTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDigitalClock = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'lblDashboardTitle
        '
        Me.lblDashboardTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDashboardTitle.AutoSize = True
        Me.lblDashboardTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDashboardTitle.Location = New System.Drawing.Point(304, 71)
        Me.lblDashboardTitle.Name = "lblDashboardTitle"
        Me.lblDashboardTitle.Size = New System.Drawing.Size(345, 42)
        Me.lblDashboardTitle.TabIndex = 0
        Me.lblDashboardTitle.Text = "Student DashBoard"
        '
        'Timer1
        '
        '
        'lblDigitalClock
        '
        Me.lblDigitalClock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDigitalClock.AutoSize = True
        Me.lblDigitalClock.ForeColor = System.Drawing.Color.White
        Me.lblDigitalClock.Location = New System.Drawing.Point(424, 237)
        Me.lblDigitalClock.Name = "lblDigitalClock"
        Me.lblDigitalClock.Size = New System.Drawing.Size(104, 13)
        Me.lblDigitalClock.TabIndex = 1
        Me.lblDigitalClock.Text = "BunifuCustomLabel1"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(943, 527)
        Me.Controls.Add(Me.lblDigitalClock)
        Me.Controls.Add(Me.lblDashboardTitle)
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDigitalClock As Bunifu.Framework.UI.BunifuCustomLabel
End Class
