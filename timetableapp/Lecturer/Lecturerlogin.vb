Public Class Lecturerlogin
    Dim con As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Dim sql As String
    Dim strID As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim strPass As String
    Dim newsql As String
    Public UserName As String
    Dim ncb As New OleDb.OleDbCommandBuilder
    Dim nds As New DataSet

    ''''To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        LecturerRegister.Show()

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'CLOSE FORM
        If MsgBox("Do you want to Exit the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit|TimetableApp") = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
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
    Private Sub Lecturerlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iconShowPass.Visible = True
        iconHidePass.Visible = False
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub lbltitle_Click(sender As Object, e As EventArgs) Handles lbltitle.Click

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        strID = txtUserLogin.Text
        strPass = txtUserPassword.Text

        con.Open()
        sql = "SELECT * FROM LecturerAccount WHERE LecturerID = '" & txtUserLogin.Text & "' And LecturerPassword = '" & txtUserPassword.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "LecturerAccount")
        con.Close()

        If ds.Tables("LecturerAccount").Rows.Count <> 0 Then
            Try
                con.Open()
                newsql = "SELECT LecturerID,LecturerUsername FROM LecturerAccount WHERE LecturerID = '" & strID & "'"
                Dim cmd As New OleDb.OleDbCommand(newsql, con)
                Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
                dr.Read()

                ' DISPLAY USERNAME IN LECTURER MAIN PAGE
                LecturerMainPage.lblUsername.Text = dr("LecturerUsername")
                con.Close()
                MsgBox("Welcome back :) ", MsgBoxStyle.Information, "Lecturer|Login Successfull")
                Me.Hide()
                LecturerMainPage.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Login | Failed")
            End Try
        Else
            MsgBox("ID or PASSWORD is INVALID." + vbNewLine + "PLEASE TRY AGAIN.", MsgBoxStyle.Exclamation, "Login Details | Error")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        menuform.Show()
    End Sub

    Private Sub lblForgetpass_Click(sender As Object, e As EventArgs) Handles lblForgetpass.Click
        Me.Hide()
        ResetLecturerPassword.Show()
    End Sub

    Private Sub iconShowPass_Click(sender As Object, e As EventArgs) Handles iconShowPass.Click
        If iconShowPass.Visible = True Then
            iconHidePass.Visible = True
            iconShowPass.Visible = False
            txtUserPassword.isPassword = False
        End If
    End Sub

    Private Sub iconHidePass_Click(sender As Object, e As EventArgs) Handles iconHidePass.Click
        iconHidePass.Visible = False
        iconShowPass.Visible = True
        txtUserPassword.isPassword = True
    End Sub

    Private Sub txtUserPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtUserPassword.OnValueChanged
        txtUserPassword.isPassword = True
    End Sub
End Class