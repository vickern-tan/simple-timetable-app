<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecturerFormBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecturerFormBooking))
        Me.btnCheckApp = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'btnCheckApp
        '
        Me.btnCheckApp.ActiveBorderThickness = 1
        Me.btnCheckApp.ActiveCornerRadius = 20
        Me.btnCheckApp.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnCheckApp.ActiveForecolor = System.Drawing.Color.White
        Me.btnCheckApp.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnCheckApp.BackColor = System.Drawing.SystemColors.Control
        Me.btnCheckApp.BackgroundImage = CType(resources.GetObject("btnCheckApp.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckApp.ButtonText = "Check My Appointment"
        Me.btnCheckApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckApp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckApp.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCheckApp.IdleBorderThickness = 1
        Me.btnCheckApp.IdleCornerRadius = 20
        Me.btnCheckApp.IdleFillColor = System.Drawing.Color.White
        Me.btnCheckApp.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnCheckApp.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnCheckApp.Location = New System.Drawing.Point(24, 36)
        Me.btnCheckApp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheckApp.Name = "btnCheckApp"
        Me.btnCheckApp.Size = New System.Drawing.Size(257, 72)
        Me.btnCheckApp.TabIndex = 0
        Me.btnCheckApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LecturerFormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheckApp)
        Me.Name = "LecturerFormBooking"
        Me.Text = "LecturerFormBooking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheckApp As Bunifu.Framework.UI.BunifuThinButton2
End Class
