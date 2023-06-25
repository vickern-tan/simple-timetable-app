Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports System.Data.OleDb
Imports System.Data

Public Class StudentMainPage
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim nds As New DataSet
    Private Access As New DBControl
    Dim dbInput As String
    Dim dbOutput As String
    Dim strID As String
    Dim strPass As String
    Dim newsql As String

    'Private Sub ProfileDetails()
    '
    'End Sub

    Private currentChildForm As Form

    ''''Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 75)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'LeftBorder
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Current Form Icon
            btnHome.IconChar = currentBtn.IconChar
            btnHome.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(26, 25, 65)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'End
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        DesktopPanel.Controls.Add(childForm)
        DesktopPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblHomeTitle.Text = childForm.Text
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColor.color2)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        ActivateButton(sender, RGBColor.color3)
        OpenChildForm(New FormTimetable)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        ActivateButton(sender, RGBColor.color4)
        OpenChildForm(New FormAccount)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ActivateButton(sender, RGBColor.color8)
        OpenChildForm(New FormSearch)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ActivateButton(sender, RGBColor.ColorRed)
        If MsgBox("Do you want to Logout?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "TimeTableAPP.info") = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        btnHome.IconChar = IconChar.Home
        btnHome.IconColor = Color.SlateBlue
        lblHomeTitle.Text = "Home"
    End Sub

    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByValParam As Integer)
    End Sub

    Private Sub panelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub StudentMainPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.FixedSingle
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MsgBox("Exit Application?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "TimeTableAPP.info") = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub logoLogin_Click_1(sender As Object, e As EventArgs) Handles UserProfileImage.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub StudentMainPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDigitalClock.Font = myfont.GetInstance(40, FontStyle.Regular)
        lblDigitalClock.ForeColor = RGBColor.ColorRed
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDigitalClock.Text = Date.Now.ToString("dd MMMM yyyy" & vbNewLine & "hh:mm:ss:tt")
    End Sub

    Private Sub DesktopPanel_Paint(sender As Object, e As PaintEventArgs) Handles DesktopPanel.Paint

    End Sub
End Class