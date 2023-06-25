<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestINNERJOIN
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(206, 49)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(388, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(206, 107)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(388, 20)
        Me.txt2.TabIndex = 1
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(206, 165)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(388, 20)
        Me.txt3.TabIndex = 2
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(206, 223)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(388, 20)
        Me.txt4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 86)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestINNERJOIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "TestINNERJOIN"
        Me.Text = "TestINNERJOIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents Button1 As Button
End Class
