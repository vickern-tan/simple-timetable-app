Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class LecturerMainPage
    Private currentChildForm As Form
    'FIELDS
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    'CONSTRUCTOR
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'FORM
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
            currentBtn.BackColor = Color.FromArgb(5, 8, 9)
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
            currentBtn.BackColor = Color.FromArgb(5, 8, 9)
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnUserProfile.Click
        ActivateButton(sender, RGBColor.color6)
        OpenChildForm(New LecturerAccount)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColor.color2)
        OpenChildForm(New LecturerFormDashboard)
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        ActivateButton(sender, RGBColor.color3)
        OpenChildForm(New LecturerFormTimetable)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ActivateButton(sender, RGBColor.color8)
        OpenChildForm(New LecturerFormSearch)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ActivateButton(sender, RGBColor.ColorRed)
        If MsgBox("Logout?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "TimeTableAPP.info") = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub logoUser_Click(sender As Object, e As EventArgs) Handles logoUser.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
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

    Private Sub LecturerMainPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    Private Sub DesktopPanel_Paint(sender As Object, e As PaintEventArgs) Handles DesktopPanel.Paint

    End Sub
End Class