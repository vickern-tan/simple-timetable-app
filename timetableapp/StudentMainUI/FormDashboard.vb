Public Class FormDashboard
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDigitalClock.Font = myfont.GetInstance(48, FontStyle.Regular)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDigitalClock.Text = TimeOfDay.ToString("hh:mm:ss:tt")
    End Sub

    Private Sub lblDigitalClock_Click(sender As Object, e As EventArgs) Handles lblDigitalClock.Click

    End Sub
End Class