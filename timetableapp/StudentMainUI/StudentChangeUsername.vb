Imports System.Runtime.InteropServices

Public Class StudentChangeUsername
    Dim dbInput, dbOutput As String
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim newsql As String
    Dim strID As String = studentlogin.txtUserLogin.Text

    'EMAIL VALIDATION
    Dim par As String


    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByValParam As Integer)
    End Sub

    Private Sub panelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Stop Editing Profile?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "TimeTableAPP.info") = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Stop Editing Profile?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "TimeTableAPP.info") = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnEdit1_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
        txtUsername.Enabled = True
        txtUsername.Focus()
        btnCancel.Visible = True
        btnEdit1.Visible = False
        Savebtn1.Visible = True

    End Sub

    Private Sub btnEdit2_Click(sender As Object, e As EventArgs) Handles btnEdit2.Click
        txtStudentMail.Enabled = True
        btncancel2.Visible = True
        txtStudentMail.Focus()
        btnEdit2.Visible = False
        Savebtn2.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RefreshUsername()
        txtUsername.Enabled = False
        btnCancel.Visible = False
        btnEdit1.Visible = True
        Savebtn1.Visible = False
    End Sub

    Private Sub StudentChangeUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub btncancel2_Click(sender As Object, e As EventArgs) Handles btncancel2.Click
        RefreshEmail()
        txtStudentMail.Enabled = False
        btncancel2.Visible = False
        btnEdit2.Visible = True
        Savebtn2.Visible = False
    End Sub
    Sub RefreshUsername()
        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
            newsql = "SELECT StudentID, StudentUsername, StudentEmail FROM StudentAccount WHERE StudentID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()

            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            txtUsername.Text = dr("StudentUsername")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub UpdateUsername()
        Try
            Dim ds1 As New DataSet
            Dim da1 As New OleDb.OleDbDataAdapter("SELECT * FROM StudentAccount WHERE StudentUsername ='" & Trim(txtUsername.Text) & "'", con)
            ' CHECK IF PASSWORD LENGTH IS MORE THAN 5 CHARACTER
            ' CHECK IF THERE IS ANY EMPTY SPACE
            If txtUsername.Text.Length < 5 Then
                MsgBox("Username must be atleast 5 characters!", MsgBoxStyle.Exclamation, "Username|Update-fail")
                txtUsername.Text = ""
                txtUsername.Focus()
            Else
                da1.Fill(ds1)
                Dim ra As Integer
                Dim cb As OleDb.OleDbCommand
                ' UPDATE DATABASE RECORDS
                con.Open()
                cb = New OleDb.OleDbCommand("UPDATE StudentAccount SET StudentUsername ='" & txtUsername.Text & "' WHERE StudentID ='" & strID & "' ", con)
                ra = cb.ExecuteNonQuery()
                MessageBox.Show("Username has been updated.")
                con.Close()
                RefreshUsername()
                txtUsername.Enabled = False
                btnEdit1.Visible = True
                btnCancel.Visible = False
                Savebtn1.Visible = False
            End If

            ' REPORT ERRORS
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Username|Update-fail")
        End Try
    End Sub
    Sub RefreshEmail()
        Try
            ' GRAB STUDENT'S DATA FROM DB
            con.Open()
            newsql = "SELECT StudentEmail FROM StudentAccount WHERE StudentID = '" & strID & "'"
            Dim cmd As New OleDb.OleDbCommand(newsql, con)
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            dr.Read()

            ' DISPLAY USERNAME, FULLNAME IN STUDENT PROFILE PAGE
            txtStudentMail.Text = dr("StudentEmail")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub UpdateUsermail()
        Try
            Dim ds1 As New DataSet
            Dim da1 As New OleDb.OleDbDataAdapter("SELECT * FROM StudentAccount WHERE StudentEmail ='" & Trim(txtStudentMail.Text) & "'", con)
            par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            ' CHECK IF PASSWORD LENGTH IS MORE THAN 5 CHARACTER
            ' CHECK IF THERE IS ANY EMPTY SPACE
            If System.Text.RegularExpressions.Regex.IsMatch(txtStudentMail.Text, par) Then
                da1.Fill(ds1)
                Dim ra As Integer
                Dim cb As OleDb.OleDbCommand
                ' UPDATE DATABASE RECORDS
                con.Open()
                cb = New OleDb.OleDbCommand("UPDATE StudentAccount SET StudentEmail ='" & txtStudentMail.Text & "' WHERE StudentID ='" & strID & "' ", con)
                ra = cb.ExecuteNonQuery()
                MessageBox.Show("Email has been updated.")
                con.Close()
                RefreshEmail()
                txtStudentMail.Enabled = False
                btnEdit2.Visible = True
                btncancel2.Visible = False
                Savebtn2.Visible = False
            Else
                MsgBox("Please Enter a valid email format.", MsgBoxStyle.Exclamation, "Email|Update-fail")
                txtStudentMail.Text = ""
                txtStudentMail.Focus()
                btnEdit2.Visible = False
                Savebtn2.Visible = True
            End If

            ' REPORT ERRORS
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Username|Update-fail")
        End Try
    End Sub

    Private Sub Savebtn1_Click(sender As Object, e As EventArgs) Handles Savebtn1.Click
        UpdateUsername()

    End Sub

    Private Sub Savebtn2_Click(sender As Object, e As EventArgs) Handles Savebtn2.Click
        UpdateUsermail()
    End Sub
End Class