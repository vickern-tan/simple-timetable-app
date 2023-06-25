Imports Bunifu.Framework
Public Class StudentRegister
    Dim con As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim totalrecords As Integer
    Dim a As Control

    ''''To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer
    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If txtFullname.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" And txtEmail.Text <> "" Then
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput

        con.Open()
        sql = "Select * from StudentAccount"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "StudentAccount")
        con.Close()

        ' lblcheck.Text = "NOTE*: Please Fill in the Required Information!"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''''CLEAR ALL THE TEXTBOX IN REGISTER PAGE
        For Each txt In {txtFullname, txtUsername, txtPassword, txtconfirmpass, txtEmail, txtStudentID}
            txt.Text = ""
        Next
        Me.Hide()
        studentlogin.Show()
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'MINIMIZE FORM
        Me.WindowState = 1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'CLOSE FORM
        Me.Close()
        Application.Exit()
        End
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

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub txtconfirmpass_OnValueChanged(sender As Object, e As EventArgs) Handles txtconfirmpass.OnValueChanged
        txtconfirmpass.isPassword = True
        If (txtPassword.Text <> txtconfirmpass.Text) Then
            lblcheck.Visible = True
            lblcheck.Text = "NOTE: PASSWORD DOES NOT MATCH!"
        Else
            lblcheck.Visible = False
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles iconShowPass.Click
        iconShowPass.Visible = False
        iconHidePass.Visible = True
        txtPassword.isPassword = False
        txtconfirmpass.isPassword = False
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles iconHidePass.Click
        iconShowPass.Visible = True
        iconHidePass.Visible = False
        txtPassword.isPassword = True
        txtconfirmpass.isPassword = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        'EMAIL VALIDATION
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, par) Then

            'PASSWORD VALIDATION
            If txtPassword.Text = txtconfirmpass.Text Then
                dsNewRow = ds.Tables("StudentAccount").NewRow()
                If txtFullname.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" And txtEmail.Text <> "" And txtIntakeCode.Text <> "" And txtStudentID.Text <> "" Then
                    dsNewRow.Item(0) = txtStudentID.Text
                    dsNewRow.Item(1) = txtFullname.Text
                    dsNewRow.Item(2) = txtUsername.Text
                    dsNewRow.Item(3) = txtPassword.Text
                    dsNewRow.Item(4) = txtEmail.Text
                    dsNewRow.Item(6) = txtIntakeCode.Text

                    ds.Tables("StudentAccount").Rows.Add(dsNewRow)
                    da.Update(ds, "StudentAccount")

                    totalrecords = totalrecords + 1
                    For Each txt In {txtFullname, txtUsername, txtPassword, txtconfirmpass, txtEmail, txtIntakeCode, txtStudentID}
                        txt.Text = ""
                    Next

                    'SHOW MESSAGE BOX SUCCESFULLY REGISTERED
                    MsgBox("Student account has been successfully created.", MessageBoxIcon.Information)
                    Me.Hide()
                    studentlogin.Show()
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
            txtPassword.Text = ""
            txtEmail.Focus()
        End If

    End Sub

End Class