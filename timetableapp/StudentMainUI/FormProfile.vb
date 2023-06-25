Imports System.IO
Imports System.Data.OleDb
Public Class FormProfile
    Private abyt As Byte()
    Dim con As New OleDbConnection
    Dim constr As String
    Dim cmd As New OleDbCommand
    Dim filedia As New OpenFileDialog
    Dim imgpath As String
    ' Dim controllsfilled As Boolean
    Public Sub CallConnection()
        constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TimetableappDB.accdb"
        With con
            .ConnectionString = constr
            .Open()
        End With
    End Sub

    Public Sub BrowseImage()
        ' If studentlogin.txtUserLogin.Text = "" Then
        ' controllsfilled = False
        ' End If
        Try
            filedia.Filter = "Image File(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            filedia.Title = "Select Image..."
            If filedia.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fs As New FileStream(filedia.FileName, FileMode.Open)
                Dim br As New BinaryReader(fs)
                abyt = br.ReadBytes(CInt(fs.Length))
                br.Close()
                Dim ms As New MemoryStream(abyt)
                UserProfilePict.Image = Image.FromStream(ms)
                btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub SaveImage()
        Try
            CallConnection()
            With cmd
                .Connection = con
                .CommandText = "INSERT INTO StudentAccount([StudentID],[UserImage]) Values(@SID,@pic)"
            End With
            cmd.Parameters.AddWithValue("@SID", StudentMainPage.lblUsername.Text)
            cmd.Parameters.AddWithValue("@pic", abyt)
            cmd.ExecuteNonQuery()
            MsgBox("Image Upload Successful.", MsgBoxStyle.Information, "Upload|UserImage")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Error|SaveImage")
        End Try

    End Sub
    Private Sub UserProfilePict_Click(sender As Object, e As EventArgs) Handles UserProfilePict.Click
        BrowseImage()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveImage()
    End Sub

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnSave.Enabled = False
    End Sub
End Class