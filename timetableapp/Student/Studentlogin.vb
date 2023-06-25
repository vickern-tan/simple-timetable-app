Imports System.IO
Public Class studentlogin
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim nds As New DataSet
    Private Access As New DBControl
    Dim dbInput As String
    Dim dbOutput As String
    Dim strID As String
    Dim strPass As String
    Dim newsql As String

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS HERE
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub GetUsers()
        ' QUERY USERS TO FILL DATA TABLE
        Access.ExecQuery("SELECT * FROM StudentAccount")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
    End Sub

    ''''To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblstudentlogin.Click

    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        StudentRegister.Show()
    End Sub

    Private Sub lblRegister_MouseHover(sender As Object, e As EventArgs) Handles lblRegister.MouseHover

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If MsgBox("Exit Application?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "TimeTableAPP.info") = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
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

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        strID = txtUserLogin.Text
        strPass = txtUserPassword.Text
        Try
            ' GRAB STUDENT'S USERNAME AND PASSWORD FOR AUTHORIZATION
            con.Open()
            Dim sql As String = "SELECT * FROM StudentAccount WHERE StudentID = '" & txtUserLogin.Text & "'And StudentPassword ='" & txtUserPassword.Text & "'"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "StudentAccount")
            con.Close()
            If ds.Tables("StudentAccount").Rows.Count <> 0 Then
                Try
                    con.Open()
                    newsql = "SELECT StudentID,StudentUsername FROM StudentAccount WHERE StudentID = '" & strID & "'"
                    Dim cmd As New OleDb.OleDbCommand(newsql, con)
                    Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
                    dr.Read()

                    ' DISPLAY USERNAME IN STUDENT MAIN PAGE
                    StudentMainPage.lblUsername.Text = dr("StudentUsername")
                    con.Close()
                    MsgBox("Welcome back :) ", MsgBoxStyle.Information, "Student|Login Successfull")
                    Me.Hide()
                    StudentMainPage.Show()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            Else
                MsgBox("ID or PASSWORD is INVALID." + vbNewLine + "PLEASE TRY AGAIN.", MsgBoxStyle.Exclamation, "Login | Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Login | Error")
        End Try

        ' GRAB STUDENT'S DATA FROM DB

    End Sub

    Private Sub PnlTopBorder_Paint(sender As Object, e As PaintEventArgs) Handles PnlTopBorder.Paint

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        menuform.Show()
    End Sub

    Private Sub lblForgetpass_Click(sender As Object, e As EventArgs) Handles lblForgetpass.Click
        Me.Hide()
        ForgetPassword.Show()
    End Sub

    Private Sub iconShowPass_Click(sender As Object, e As EventArgs) Handles iconShowPass.Click
        If iconShowPass.Visible = True Then
            iconHidePass.Visible = True
            iconShowPass.Visible = False
            txtUserPassword.isPassword = False
        End If
    End Sub

    Private Sub ResetUserPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iconShowPass.Visible = True
        iconHidePass.Visible = False
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
