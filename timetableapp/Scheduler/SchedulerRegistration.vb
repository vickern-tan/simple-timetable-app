Public Class SchedulerRegistration
    Dim con As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Dim newsql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim totalrecords As Integer
    Dim a As Control

    'To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRowSche As DataRow

        'EMAIL VALIDATION
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, par) Then
            If txtPassword.Text = txtconfirmpass.Text Then
                dsNewRowSche = ds.Tables("SchedulerAccount").NewRow()
                If txtFullname.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" And txtEmail.Text <> "" And txtSchedulerID.Text <> "" Then
                    dsNewRowSche.Item(0) = txtSchedulerID.Text
                    dsNewRowSche.Item(1) = txtFullname.Text
                    dsNewRowSche.Item(2) = txtUsername.Text
                    dsNewRowSche.Item(3) = txtPassword.Text
                    dsNewRowSche.Item(4) = txtEmail.Text

                    ds.Tables("SchedulerAccount").Rows.Add(dsNewRowSche)
                    da.Update(ds, "SchedulerAccount")

                    totalrecords = totalrecords + 1
                    For Each txt In {txtFullname, txtUsername, txtPassword, txtconfirmpass, txtEmail, txtSchedulerID}
                        txt.Text = ""
                    Next

                    ' SHOW SUCCESFULLY REGISTERED
                    MsgBox("Scheduler Account has been successfully created.", MessageBoxIcon.Information)
                    Me.Hide()
                    SchedulerLogin.Show()
                Else
                    MsgBox("Please fill in all the details above!", MessageBoxIcon.Error, "ERROR")
                End If
            Else
                MsgBox("Password does not match!", MessageBoxIcon.Error, "ERROR")
                ' CLEAR CONPASS TEXTBOX
                txtconfirmpass.Text = ""
                txtconfirmpass.Focus()
            End If
        Else
            MsgBox("The email address you have submitted is not in a valid format.", MessageBoxIcon.Information, "InvalidEmail")
            txtEmail.Text = ""
            txtEmail.Focus()
        End If
    End Sub
    Private Sub iconShowPass_Click(sender As Object, e As EventArgs) Handles iconShowPass.Click
        iconShowPass.Visible = False
        iconHidePass.Visible = True
        txtPassword.isPassword = False
        txtconfirmpass.isPassword = False
    End Sub

    Private Sub iconHidePass_Click(sender As Object, e As EventArgs) Handles iconHidePass.Click
        iconShowPass.Visible = True
        iconHidePass.Visible = False
        txtPassword.isPassword = True
        txtconfirmpass.isPassword = True
    End Sub
    Private Sub PnlTopBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlTopBorder.MouseDown
        xpos = Control.MousePosition.X - Me.Location.X
        ypos = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub PnlTopBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlTopBorder.MouseMove
        'TOP BAR SET NEW POSITION
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos)
            newpoint.Y -= (ypos)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        'MINIMIZE FORM
        Me.WindowState = 1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'CLOSE FORM
        If MsgBox("Do you want to Exit the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit|TimetableApp") = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub txtconfirmpass_OnValueChanged(sender As Object, e As EventArgs) Handles txtconfirmpass.OnValueChanged
        txtPassword.isPassword = True
    End Sub
    Private Sub SchedulerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput

        con.Open()
        newsql = "Select * from SchedulerAccount"
        da = New OleDb.OleDbDataAdapter(newsql, con)
        da.Fill(ds, "SchedulerAccount")
        con.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        For Each txt In {txtFullname, txtUsername, txtPassword, txtconfirmpass, txtEmail, txtSchedulerID}
            txt.Text = ""
        Next
        Me.Hide()
        SchedulerLogin.Show()
    End Sub
End Class