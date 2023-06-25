Public Class LecturerAccount
    Dim dbInput, dbOutput As String
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim newsql As String
    Dim strID As String = Lecturerlogin.txtUserLogin.Text
    Private Sub btnUserProfile_Click(sender As Object, e As EventArgs) Handles btnUserProfile.Click
        Try
            ' GRAB LECTURER'S DATA FROM DB
            con.Open()
            newsql = "SELECT LecturerID, LecturerFullName, LecturerUsername, LecturerEmail FROM LecturerAccount WHERE LecturerID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            Me.Hide()
            LecturerProfile.Show()
            ' DISPLAY USERNAME, FULLNAME IN LECTURER PROFILE PAGE
            LecturerProfile.txtFullName.Text = dr("LecturerFullName")
            LecturerProfile.txtUsername.Text = dr("LecturerUsername")
            LecturerMainPage.lblUsername.Text = dr("LecturerUsername")
            LecturerProfile.lblProfileTitle.Text = dr("LecturerFullName") & "'s Profile".ToUpper
            LecturerProfile.txtEmail.Text = dr("LecturerEmail")
            LecturerProfile.txtLecID.Text = dr("LecturerID")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ' CHECK IF FORM IS ACTIVE/OPEN
        If Application.OpenForms().OfType(Of LecturerProfile).Any Then
            btnUserProfile.Enabled = False
        Else
            btnUserProfile.Enabled = True
        End If
    End Sub

    Private Sub btnChgPass_Click(sender As Object, e As EventArgs) Handles btnChgPass.Click
        Me.Hide()
        LecturerChangePass.Show()

        ' CHECK IF FORM IS ACTIVE/OPEN
        If Application.OpenForms().OfType(Of LecturerChangePass).Any Then
            btnChgPass.Enabled = False
        Else
            btnChgPass.Enabled = True
        End If
    End Sub

    Private Sub btnChgUsername_Click(sender As Object, e As EventArgs) Handles btnChgUsername.Click
        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
            newsql = "SELECT LecturerID, LecturerUsername, LecturerEmail FROM LecturerAccount WHERE LecturerID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            Me.Hide()
            LecturerChangeUsername.Show()
            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            LecturerChangeUsername.txtStudentMail.Text = dr("LecturerEmail")
            LecturerChangeUsername.txtUsername.Text = dr("LecturerUsername")
            LecturerChangeUsername.txtStudentMail.Enabled = False
            LecturerChangeUsername.txtUsername.Enabled = False
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        ' CHECK IF FORM IS ACTIVE/OPEN
        If Application.OpenForms().OfType(Of LecturerChangeUsername).Any Then
            btnChgUsername.Enabled = False
        Else
            btnChgUsername.Enabled = True
        End If
    End Sub

    Private Sub LecturerFormProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub
End Class