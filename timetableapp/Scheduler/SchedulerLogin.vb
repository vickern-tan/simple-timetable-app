Public Class SchedulerLogin
    Dim con As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Public UserName As String


    ''''To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'CLOSE FORM
        If MsgBox("Do you want to Exit the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit|TimetableApp") = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        'MINIMIZE
        WindowState = 1
    End Sub
    Private Sub PnlTopBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlTopBorder.MouseDown
        xpos = Control.MousePosition.X - Me.Location.X
        ypos = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PnlTopBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos)
            newpoint.Y -= (ypos)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub SchedulerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        con.Open()
        sql = "SELECT * FROM  SchedulerAccount WHERE SchedulerID = '" & txtUserLogin.Text & "' And SchedulerPassword = '" & txtUserPassword.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "SchedulerAccount")
        con.Close()

        If ds.Tables("SchedulerAccount").Rows.Count <> 0 Then
            MsgBox("Welcome back :) ", MsgBoxStyle.Information, "Student|Login Successfull")
            Me.Hide()
            SchedulerMainPage.Show()

        Else
            MsgBox("The USERNAME or PASSWORD you have entered is INVALID." + vbNewLine + "PLEASE TRY AGAIN.", MsgBoxStyle.Exclamation, "Invalid.")
        End If
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        SchedulerRegistration.Show()
    End Sub

    Private Sub lblForgetpass_Click(sender As Object, e As EventArgs) Handles lblForgetpass.Click
        Me.Hide()
        ResetPassScheduler.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        menuform.Show()
    End Sub
End Class