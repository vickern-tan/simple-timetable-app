Public Class TestINNERJOIN
    Dim dbInput, dbOutput As String
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim newsql As String
    Dim strID As String = studentlogin.txtUserLogin.Text
    Private Sub TestINNERJOIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        JoinFunction()
    End Sub

    Sub JoinFunction()
        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
            newsql = "SELECT * FROM StudentAccount INNER JOIN StudentTimetable ON CourseCode WHERE StudentID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            Me.Hide()
            StudentProfile.Show()
            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            txt1.Text = dr("StudentFullName")
            txt2.Text = dr("StudentUsername")
            txt3.Text = dr("StudentID")
            txt4.Text = dr("CourseCode")
            con.Close()
            ' DISPLAY USER PROFILE IMAGE
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class