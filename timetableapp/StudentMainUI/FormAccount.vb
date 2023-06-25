Public Class FormAccount
    Dim dbInput, dbOutput As String
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim newsql As String
    Dim strID As String = studentlogin.txtUserLogin.Text

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles btnChgPass.Click
        Me.Hide()
        StudentChangePassword.Show()
        ' CHECK IF CHANGE PASSWORD FORM IS ACTIVE/OPENED
        If Application.OpenForms().OfType(Of StudentChangePassword).Any Then
            btnChgPass.Enabled = False
        Else
            btnChgPass.Enabled = True
        End If
    End Sub

    Private Sub btnUserProfile_Click(sender As Object, e As EventArgs) Handles btnUserProfile.Click

        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
                newsql = "SELECT StudentID, StudentFullName, StudentUsername, StudentEmail, IntakeCode FROM StudentAccount WHERE StudentID = '" & strID & "'"
                Dim cmd As New OleDb.OleDbCommand(newsql, con)
                Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
                dr.Read()
            Me.Hide()
            StudentProfile.Show()
            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            StudentProfile.txtFullName.Text = dr("StudentFullName")
            StudentProfile.txtUsername.Text = dr("StudentUsername")
            StudentMainPage.lblUsername.Text = dr("StudentID")
            StudentProfile.lblProfileTitle.Text = dr("StudentUsername") & "'s Profile"
            StudentProfile.txtEmail.Text = dr("StudentEmail")
            StudentProfile.txtIntakeCode.Text = dr("IntakeCode")
            con.Close()
            ' DISPLAY USER PROFILE IMAGE
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        If Application.OpenForms().OfType(Of StudentProfile).Any Then
            btnUserProfile.Enabled = False
        Else
            btnUserProfile.Enabled = True
        End If
    End Sub

    Private Sub btnChgUsername_Click(sender As Object, e As EventArgs) Handles btnChgUsername.Click
        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
            newsql = "SELECT StudentID, StudentUsername, StudentEmail FROM StudentAccount WHERE StudentID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            Me.Hide()
            StudentChangeUsername.Show()
            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            StudentChangeUsername.txtStudentMail.Text = dr("StudentEmail")
            StudentChangeUsername.txtUsername.Text = dr("StudentUsername")
            StudentChangeUsername.txtStudentMail.Enabled = False
            StudentChangeUsername.txtUsername.Enabled = False
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        If Application.OpenForms().OfType(Of StudentChangeUsername).Any Then
            btnChgUsername.Enabled = False
        Else
            btnChgUsername.Enabled = True
        End If
    End Sub

    Private Sub FormAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub
End Class