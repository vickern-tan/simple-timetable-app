Imports System.Runtime.InteropServices

Public Class ResetPassScheduler
    Public Shared SavedPassword As String = Nothing
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SavedPassword = SchedulerLogin.txtUserPassword.Text
        Try
            Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TimetableappDB.accdb")
            Dim ds1 As New DataSet
            Dim da1 As New OleDb.OleDbDataAdapter("SELECT * FROM SchedulerAccount WHERE SchedulerEmail ='" & Trim(txtUserMail.Text) & "' AND SchedulerID ='" & Trim(txtScheID.Text) & "'", con)
            ' CHECK IF PASSWORD LENGTH IS MORE THAN 5 CHARACTER
            If txtNewPass.Text.Length < 5 Then
                MsgBox("The New Password Should be of Atleast 5 Characters")
                txtNewPass.Text = ""
                txtConPass.Text = ""
                ' CHECK IF THE OLD PASSWORD = NEW PASSWORD
            ElseIf txtNewPass.Text = SavedPassword Then
                MsgBox("The New Password is Same As Old Password")
                txtNewPass.Text = ""
                txtNewPass.Focus()
            Else
                ' CHECK IF THERE IS ANY EMPTY SPACE
                If txtUserMail.Text.Trim.Length > 0 AndAlso txtScheID.Text.Trim.Length > 0 AndAlso txtNewPass.Text.Trim.Length > 0 AndAlso txtConPass.Text.Trim.Length > 0 Then
                    If (txtNewPass.Text = txtConPass.Text) Then
                        If da1.Fill(ds1) Then

                            Dim ra As Integer
                            Dim cb As OleDb.OleDbCommand

                            ' UPDATE DATABASE RECORDS
                            con.Open()
                            cb = New OleDb.OleDbCommand("UPDATE SchedulerAccount SET SchedulerPassword ='" & txtNewPass.Text & "' WHERE SchedulerEmail ='" & txtUserMail.Text &
                                "' AND SchedulerID = '" & txtScheID.Text & "'", con)
                            ra = cb.ExecuteNonQuery()
                            MessageBox.Show("Password has been reset.")
                            con.Close()
                            SchedulerLogin.Show()
                            Me.Hide()
                        Else
                            MsgBox("Invalid Username or Email.", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Password does not match!", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Please fill in all the details!", MsgBoxStyle.Critical)
                End If
            End If
            ' REPORT ERRORS
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Reset Failure")
        End Try
    End Sub
    Private Sub txtConPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtConPass.OnValueChanged
        txtConPass.isPassword = True
        If (txtNewPass.Text <> txtConPass.Text) Then
            lblcheckpass.Visible = True
            lblcheckpass.Text = "NOTE: PASSWORD DOES NOT MATCH!"
        Else
            lblcheckpass.Visible = False
        End If
    End Sub

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' EXIT APPLICATION BUTTON
        If MsgBox("Exit Application?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "TimeTableAPP.info") = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub iconShowPass_Click(sender As Object, e As EventArgs) Handles iconShowPass.Click
        If iconShowPass.Visible = True Then
            iconHidePass.Visible = True
            iconShowPass.Visible = False
            txtNewPass.isPassword = False
            txtConPass.isPassword = False
        End If
    End Sub

    Private Sub ResetUserPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iconShowPass.Visible = True
        iconHidePass.Visible = False
    End Sub

    Private Sub iconHidePass_Click(sender As Object, e As EventArgs) Handles iconHidePass.Click
        iconHidePass.Visible = False
        iconShowPass.Visible = True
        txtNewPass.isPassword = True
        txtConPass.isPassword = True
    End Sub

    Private Sub txtNewPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtNewPass.OnValueChanged
        txtNewPass.isPassword = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Quit Resetting Password?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Back|Scheduler Login") = MsgBoxResult.Ok Then
            Me.Hide()
            SchedulerLogin.Show()
        End If
    End Sub
End Class