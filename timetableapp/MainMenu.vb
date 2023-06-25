Public Class menuform
    'https://forums.asp.net/t/1924289.aspx?Converting+amp+to+in+vb+net.Archived
    'July 23, 2013.
    Public UserName As String
    Dim conn As New OleDb.OleDbConnection
    Dim dbInput As String
    Dim dbOutput As String
    Dim dr As OleDb.OleDbDataReader

    ''''To Move Borderless Windows
    Private newpoint As System.Drawing.Point
    Private xpos As Integer
    Private ypos As Integer

    Private Sub iconStudent_Click(sender As Object, e As EventArgs) Handles iconStudent.Click
        Me.Hide()
        studentlogin.Show()
    End Sub

    Private Sub iconLecturer_Click(sender As Object, e As EventArgs) Handles iconLecturer.Click
        Me.Hide()
        Lecturerlogin.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbInput = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbOutput = "Data Source=TimetableappDB.accdb"
        conn.ConnectionString = dbInput & dbOutput
    End Sub

    Private Sub PnlTopBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlTopBorder.MouseDown
        xpos = Control.MousePosition.X - Me.Location.X
        ypos = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PnlTopBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos)
            newpoint.Y -= (ypos)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'CLOSE FORM
        Me.Close()
        Application.Exit()
        End
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'MINIMIZE FORM
        Me.WindowState = 1
    End Sub

    Private Sub PnlTopBorder_Paint(sender As Object, e As PaintEventArgs) Handles PnlTopBorder.Paint

    End Sub

    Private Sub iconScheduler_Click(sender As Object, e As EventArgs) Handles iconScheduler.Click
        Me.Hide()
        SchedulerLogin.Show()
    End Sub
End Class