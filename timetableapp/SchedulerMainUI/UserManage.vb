Imports System.Data.OleDb
Public Class UserManage
    Dim con As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Private Sub UserManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=|DataDirectory|\TimetableappDB.accdb"
        con.ConnectionString = dbInput & dbOutput
        StatusIcon.ForeColor = Color.White
        countL()
        countS()
    End Sub
    Sub countL()
        Try
            con.Open()
            Dim dr As OleDbDataReader
            Dim sql As String = "SELECT COUNT (*) FROM LecturerAccount"
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                lblLecNo.Text = (dr(0).ToString())
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub countS()
        Try
            con.Open()
            Dim dr As OleDbDataReader
            Dim sql As String = "SELECT COUNT (*) FROM StudentAccount"
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                lblStuNo.Text = (dr(0).ToString())
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnLecEdit_Click(sender As Object, e As EventArgs) Handles btnLecEdit.Click
        ManageLecturerDB.Show()
        If Application.OpenForms().OfType(Of ManageLecturerDB).Any Then
            btnLecEdit.Enabled = False
        Else
            btnLecEdit.Enabled = True
        End If
    End Sub

    Private Sub btnStuEdit_Click(sender As Object, e As EventArgs) Handles btnStuEdit.Click
        ManageStudentDB.Show()
        If Application.OpenForms().OfType(Of ManageStudentDB).Any Then
            btnStuEdit.Enabled = False
        Else
            btnStuEdit.Enabled = True
        End If
    End Sub
End Class