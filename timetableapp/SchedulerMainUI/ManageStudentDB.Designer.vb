<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudentDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim StudentFullNameLabel As System.Windows.Forms.Label
        Dim StudentUsernameLabel As System.Windows.Forms.Label
        Dim StudentPasswordLabel As System.Windows.Forms.Label
        Dim StudentEmailLabel As System.Windows.Forms.Label
        Dim UserImageLabel As System.Windows.Forms.Label
        Dim IntakeCodeLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudentDB))
        Me.StudentAccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.StudentAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentAccountDB = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.StudentEmailTextBox = New System.Windows.Forms.TextBox()
        Me.IntakeCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAccountTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.StudentAccountTableAdapter()
        Me.TableAdapterManager = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        Me.lblSearchHint = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuTextbox()
        Me.UserImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentAccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconToolStripButton()
        StudentIDLabel = New System.Windows.Forms.Label()
        StudentFullNameLabel = New System.Windows.Forms.Label()
        StudentUsernameLabel = New System.Windows.Forms.Label()
        StudentPasswordLabel = New System.Windows.Forms.Label()
        StudentEmailLabel = New System.Windows.Forms.Label()
        UserImageLabel = New System.Windows.Forms.Label()
        IntakeCodeLabel = New System.Windows.Forms.Label()
        CType(Me.StudentAccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentAccountBindingNavigator.SuspendLayout()
        CType(Me.StudentAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentAccountDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Enabled = False
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StudentIDLabel.Location = New System.Drawing.Point(24, 60)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(72, 16)
        StudentIDLabel.TabIndex = 2
        StudentIDLabel.Text = "Student ID:"
        '
        'StudentFullNameLabel
        '
        StudentFullNameLabel.AutoSize = True
        StudentFullNameLabel.Enabled = False
        StudentFullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StudentFullNameLabel.Location = New System.Drawing.Point(24, 91)
        StudentFullNameLabel.Name = "StudentFullNameLabel"
        StudentFullNameLabel.Size = New System.Drawing.Size(120, 16)
        StudentFullNameLabel.TabIndex = 4
        StudentFullNameLabel.Text = "Student Full Name:"
        '
        'StudentUsernameLabel
        '
        StudentUsernameLabel.AutoSize = True
        StudentUsernameLabel.Enabled = False
        StudentUsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StudentUsernameLabel.Location = New System.Drawing.Point(24, 122)
        StudentUsernameLabel.Name = "StudentUsernameLabel"
        StudentUsernameLabel.Size = New System.Drawing.Size(122, 16)
        StudentUsernameLabel.TabIndex = 6
        StudentUsernameLabel.Text = "Student Username:"
        '
        'StudentPasswordLabel
        '
        StudentPasswordLabel.AutoSize = True
        StudentPasswordLabel.Enabled = False
        StudentPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StudentPasswordLabel.Location = New System.Drawing.Point(24, 153)
        StudentPasswordLabel.Name = "StudentPasswordLabel"
        StudentPasswordLabel.Size = New System.Drawing.Size(119, 16)
        StudentPasswordLabel.TabIndex = 8
        StudentPasswordLabel.Text = "Student Password:"
        '
        'StudentEmailLabel
        '
        StudentEmailLabel.AutoSize = True
        StudentEmailLabel.Enabled = False
        StudentEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StudentEmailLabel.Location = New System.Drawing.Point(24, 184)
        StudentEmailLabel.Name = "StudentEmailLabel"
        StudentEmailLabel.Size = New System.Drawing.Size(93, 16)
        StudentEmailLabel.TabIndex = 10
        StudentEmailLabel.Text = "Student Email:"
        '
        'UserImageLabel
        '
        UserImageLabel.AutoSize = True
        UserImageLabel.Enabled = False
        UserImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        UserImageLabel.Location = New System.Drawing.Point(277, 60)
        UserImageLabel.Name = "UserImageLabel"
        UserImageLabel.Size = New System.Drawing.Size(81, 16)
        UserImageLabel.TabIndex = 12
        UserImageLabel.Text = "User Image:"
        '
        'IntakeCodeLabel
        '
        IntakeCodeLabel.AutoSize = True
        IntakeCodeLabel.Enabled = False
        IntakeCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        IntakeCodeLabel.Location = New System.Drawing.Point(275, 181)
        IntakeCodeLabel.Name = "IntakeCodeLabel"
        IntakeCodeLabel.Size = New System.Drawing.Size(83, 16)
        IntakeCodeLabel.TabIndex = 14
        IntakeCodeLabel.Text = "Intake Code:"
        '
        'StudentAccountBindingNavigator
        '
        Me.StudentAccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentAccountBindingNavigator.BindingSource = Me.StudentAccountBindingSource
        Me.StudentAccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentAccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentAccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentAccountBindingNavigatorSaveItem, Me.btnRefresh})
        Me.StudentAccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentAccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentAccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentAccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentAccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentAccountBindingNavigator.Name = "StudentAccountBindingNavigator"
        Me.StudentAccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentAccountBindingNavigator.Size = New System.Drawing.Size(1116, 25)
        Me.StudentAccountBindingNavigator.TabIndex = 0
        Me.StudentAccountBindingNavigator.Text = "BindingNavigator1"
        '
        'StudentAccountBindingSource
        '
        Me.StudentAccountBindingSource.DataMember = "StudentAccount"
        Me.StudentAccountBindingSource.DataSource = Me.TimetableappDBDataSet
        '
        'TimetableappDBDataSet
        '
        Me.TimetableappDBDataSet.DataSetName = "TimetableappDBDataSet"
        Me.TimetableappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentAccountDB
        '
        Me.StudentAccountDB.AllowUserToResizeColumns = False
        Me.StudentAccountDB.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StudentAccountDB.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentAccountDB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentAccountDB.AutoGenerateColumns = False
        Me.StudentAccountDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.StudentAccountDB.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.StudentAccountDB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentAccountDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentAccountDB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentAccountDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentAccountDB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn6})
        Me.StudentAccountDB.DataSource = Me.StudentAccountBindingSource
        Me.StudentAccountDB.DoubleBuffered = True
        Me.StudentAccountDB.EnableHeadersVisualStyles = False
        Me.StudentAccountDB.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.StudentAccountDB.HeaderForeColor = System.Drawing.Color.Black
        Me.StudentAccountDB.Location = New System.Drawing.Point(27, 172)
        Me.StudentAccountDB.Name = "StudentAccountDB"
        Me.StudentAccountDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentAccountDB.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.StudentAccountDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.StudentAccountDB.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentAccountDB.Size = New System.Drawing.Size(1058, 340)
        Me.StudentAccountDB.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 114
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentFullName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentFullName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 174
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentUsername"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentUsername"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 177
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "StudentPassword"
        Me.DataGridViewTextBoxColumn4.HeaderText = "StudentPassword"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 170
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StudentEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "StudentEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IntakeCode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IntakeCode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 133
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Enabled = False
        Me.StudentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StudentIDTextBox.Location = New System.Drawing.Point(102, 57)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(157, 22)
        Me.StudentIDTextBox.TabIndex = 3
        '
        'StudentFullNameTextBox
        '
        Me.StudentFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "StudentFullName", True))
        Me.StudentFullNameTextBox.Enabled = False
        Me.StudentFullNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StudentFullNameTextBox.Location = New System.Drawing.Point(150, 88)
        Me.StudentFullNameTextBox.Name = "StudentFullNameTextBox"
        Me.StudentFullNameTextBox.Size = New System.Drawing.Size(109, 22)
        Me.StudentFullNameTextBox.TabIndex = 5
        '
        'StudentUsernameTextBox
        '
        Me.StudentUsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "StudentUsername", True))
        Me.StudentUsernameTextBox.Enabled = False
        Me.StudentUsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StudentUsernameTextBox.Location = New System.Drawing.Point(150, 119)
        Me.StudentUsernameTextBox.Name = "StudentUsernameTextBox"
        Me.StudentUsernameTextBox.Size = New System.Drawing.Size(109, 22)
        Me.StudentUsernameTextBox.TabIndex = 7
        '
        'StudentPasswordTextBox
        '
        Me.StudentPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "StudentPassword", True))
        Me.StudentPasswordTextBox.Enabled = False
        Me.StudentPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StudentPasswordTextBox.Location = New System.Drawing.Point(149, 150)
        Me.StudentPasswordTextBox.Name = "StudentPasswordTextBox"
        Me.StudentPasswordTextBox.Size = New System.Drawing.Size(110, 22)
        Me.StudentPasswordTextBox.TabIndex = 9
        '
        'StudentEmailTextBox
        '
        Me.StudentEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "StudentEmail", True))
        Me.StudentEmailTextBox.Enabled = False
        Me.StudentEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StudentEmailTextBox.Location = New System.Drawing.Point(123, 181)
        Me.StudentEmailTextBox.Name = "StudentEmailTextBox"
        Me.StudentEmailTextBox.Size = New System.Drawing.Size(136, 22)
        Me.StudentEmailTextBox.TabIndex = 11
        '
        'IntakeCodeTextBox
        '
        Me.IntakeCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentAccountBindingSource, "IntakeCode", True))
        Me.IntakeCodeTextBox.Enabled = False
        Me.IntakeCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.IntakeCodeTextBox.Location = New System.Drawing.Point(379, 178)
        Me.IntakeCodeTextBox.Name = "IntakeCodeTextBox"
        Me.IntakeCodeTextBox.Size = New System.Drawing.Size(136, 22)
        Me.IntakeCodeTextBox.TabIndex = 15
        '
        'StudentAccountTableAdapter
        '
        Me.StudentAccountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturerAccountTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTimetableTableAdapter = Nothing
        Me.TableAdapterManager.SchedulerAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentAccountTableAdapter = Me.StudentAccountTableAdapter
        Me.TableAdapterManager.StudentTimetableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblSearchHint
        '
        Me.lblSearchHint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchHint.AutoSize = True
        Me.lblSearchHint.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchHint.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchHint.Location = New System.Drawing.Point(549, 36)
        Me.lblSearchHint.Name = "lblSearchHint"
        Me.lblSearchHint.Size = New System.Drawing.Size(166, 17)
        Me.lblSearchHint.TabIndex = 18
        Me.lblSearchHint.Text = "Search by StudentID :"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "UserImage"
        Me.DataGridViewImageColumn1.HeaderText = "UserImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 106
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 40
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.ActiveForecolor = System.Drawing.Color.White
        Me.btnSearch.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleCornerRadius = 40
        Me.btnSearch.IdleFillColor = System.Drawing.Color.Green
        Me.btnSearch.IdleForecolor = System.Drawing.Color.Transparent
        Me.btnSearch.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnSearch.Location = New System.Drawing.Point(985, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 62)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BackgroundImage = CType(resources.GetObject("txtSearch.BackgroundImage"), System.Drawing.Image)
        Me.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Icon = CType(resources.GetObject("txtSearch.Icon"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(726, 32)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(242, 32)
        Me.txtSearch.TabIndex = 16
        Me.txtSearch.text = ""
        '
        'UserImagePictureBox
        '
        Me.UserImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StudentAccountBindingSource, "UserImage", True))
        Me.UserImagePictureBox.Enabled = False
        Me.UserImagePictureBox.Location = New System.Drawing.Point(379, 60)
        Me.UserImagePictureBox.Name = "UserImagePictureBox"
        Me.UserImagePictureBox.Size = New System.Drawing.Size(136, 109)
        Me.UserImagePictureBox.TabIndex = 13
        Me.UserImagePictureBox.TabStop = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(77, 22)
        Me.BindingNavigatorAddNewItem.Text = "New Row"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Red
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'StudentAccountBindingNavigatorSaveItem
        '
        Me.StudentAccountBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.SteelBlue
        Me.StudentAccountBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentAccountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentAccountBindingNavigatorSaveItem.Name = "StudentAccountBindingNavigatorSaveItem"
        Me.StudentAccountBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.StudentAccountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnRefresh
        '
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.btnRefresh.IconColor = System.Drawing.Color.Black
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 30
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(66, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'ManageStudentDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 576)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchHint)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(StudentFullNameLabel)
        Me.Controls.Add(Me.StudentFullNameTextBox)
        Me.Controls.Add(StudentUsernameLabel)
        Me.Controls.Add(Me.StudentUsernameTextBox)
        Me.Controls.Add(StudentPasswordLabel)
        Me.Controls.Add(Me.StudentPasswordTextBox)
        Me.Controls.Add(StudentEmailLabel)
        Me.Controls.Add(Me.StudentEmailTextBox)
        Me.Controls.Add(UserImageLabel)
        Me.Controls.Add(Me.UserImagePictureBox)
        Me.Controls.Add(IntakeCodeLabel)
        Me.Controls.Add(Me.IntakeCodeTextBox)
        Me.Controls.Add(Me.StudentAccountDB)
        Me.Controls.Add(Me.StudentAccountBindingNavigator)
        Me.Name = "ManageStudentDB"
        Me.Text = "ManageStudentDB"
        CType(Me.StudentAccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentAccountBindingNavigator.ResumeLayout(False)
        Me.StudentAccountBindingNavigator.PerformLayout()
        CType(Me.StudentAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentAccountDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents StudentAccountBindingSource As BindingSource
    Friend WithEvents StudentAccountTableAdapter As TimetableappDBDataSetTableAdapters.StudentAccountTableAdapter
    Friend WithEvents TableAdapterManager As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentAccountBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentAccountBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StudentAccountDB As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents StudentFullNameTextBox As TextBox
    Friend WithEvents StudentUsernameTextBox As TextBox
    Friend WithEvents StudentPasswordTextBox As TextBox
    Friend WithEvents StudentEmailTextBox As TextBox
    Friend WithEvents UserImagePictureBox As PictureBox
    Friend WithEvents IntakeCodeTextBox As TextBox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents lblSearchHint As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconToolStripButton
End Class
