<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageLecturerDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LecturerIDLabel As System.Windows.Forms.Label
        Dim LecturerFullNameLabel As System.Windows.Forms.Label
        Dim LecturerUsernameLabel As System.Windows.Forms.Label
        Dim LecturerPasswordLabel As System.Windows.Forms.Label
        Dim LecturerEmailLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageLecturerDB))
        Me.LecturerIDTextBox = New System.Windows.Forms.TextBox()
        Me.LecturerAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
        Me.LecturerFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.LecturerUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LecturerPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LecturerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.lblSearchHint = New System.Windows.Forms.Label()
        Me.LecturerAccountDB = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        Me.LecturerAccountTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.LecturerAccountTableAdapter()
        Me.LecturerAccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentAccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconToolStripButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuTextbox()
        LecturerIDLabel = New System.Windows.Forms.Label()
        LecturerFullNameLabel = New System.Windows.Forms.Label()
        LecturerUsernameLabel = New System.Windows.Forms.Label()
        LecturerPasswordLabel = New System.Windows.Forms.Label()
        LecturerEmailLabel = New System.Windows.Forms.Label()
        CType(Me.LecturerAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerAccountDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerAccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LecturerAccountBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LecturerIDLabel
        '
        LecturerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        LecturerIDLabel.AutoSize = True
        LecturerIDLabel.Enabled = False
        LecturerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LecturerIDLabel.Location = New System.Drawing.Point(94, 103)
        LecturerIDLabel.Name = "LecturerIDLabel"
        LecturerIDLabel.Size = New System.Drawing.Size(75, 16)
        LecturerIDLabel.TabIndex = 2
        LecturerIDLabel.Text = "Lecturer ID:"
        '
        'LecturerFullNameLabel
        '
        LecturerFullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        LecturerFullNameLabel.AutoSize = True
        LecturerFullNameLabel.Enabled = False
        LecturerFullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LecturerFullNameLabel.Location = New System.Drawing.Point(335, 144)
        LecturerFullNameLabel.Name = "LecturerFullNameLabel"
        LecturerFullNameLabel.Size = New System.Drawing.Size(123, 16)
        LecturerFullNameLabel.TabIndex = 4
        LecturerFullNameLabel.Text = "Lecturer Full Name:"
        '
        'LecturerUsernameLabel
        '
        LecturerUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        LecturerUsernameLabel.AutoSize = True
        LecturerUsernameLabel.Enabled = False
        LecturerUsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LecturerUsernameLabel.Location = New System.Drawing.Point(44, 144)
        LecturerUsernameLabel.Name = "LecturerUsernameLabel"
        LecturerUsernameLabel.Size = New System.Drawing.Size(125, 16)
        LecturerUsernameLabel.TabIndex = 6
        LecturerUsernameLabel.Text = "Lecturer Username:"
        '
        'LecturerPasswordLabel
        '
        LecturerPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        LecturerPasswordLabel.AutoSize = True
        LecturerPasswordLabel.Enabled = False
        LecturerPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LecturerPasswordLabel.Location = New System.Drawing.Point(336, 190)
        LecturerPasswordLabel.Name = "LecturerPasswordLabel"
        LecturerPasswordLabel.Size = New System.Drawing.Size(122, 16)
        LecturerPasswordLabel.TabIndex = 8
        LecturerPasswordLabel.Text = "Lecturer Password:"
        '
        'LecturerEmailLabel
        '
        LecturerEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        LecturerEmailLabel.AutoSize = True
        LecturerEmailLabel.Enabled = False
        LecturerEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LecturerEmailLabel.Location = New System.Drawing.Point(73, 190)
        LecturerEmailLabel.Name = "LecturerEmailLabel"
        LecturerEmailLabel.Size = New System.Drawing.Size(96, 16)
        LecturerEmailLabel.TabIndex = 10
        LecturerEmailLabel.Text = "Lecturer Email:"
        '
        'LecturerIDTextBox
        '
        Me.LecturerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerAccountBindingSource, "LecturerID", True))
        Me.LecturerIDTextBox.Enabled = False
        Me.LecturerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerIDTextBox.Location = New System.Drawing.Point(175, 97)
        Me.LecturerIDTextBox.Name = "LecturerIDTextBox"
        Me.LecturerIDTextBox.Size = New System.Drawing.Size(86, 22)
        Me.LecturerIDTextBox.TabIndex = 3
        '
        'LecturerAccountBindingSource
        '
        Me.LecturerAccountBindingSource.DataMember = "LecturerAccount"
        Me.LecturerAccountBindingSource.DataSource = Me.TimetableappDBDataSet
        '
        'TimetableappDBDataSet
        '
        Me.TimetableappDBDataSet.DataSetName = "TimetableappDBDataSet"
        Me.TimetableappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturerFullNameTextBox
        '
        Me.LecturerFullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerAccountBindingSource, "LecturerFullName", True))
        Me.LecturerFullNameTextBox.Enabled = False
        Me.LecturerFullNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerFullNameTextBox.Location = New System.Drawing.Point(474, 138)
        Me.LecturerFullNameTextBox.Name = "LecturerFullNameTextBox"
        Me.LecturerFullNameTextBox.Size = New System.Drawing.Size(136, 22)
        Me.LecturerFullNameTextBox.TabIndex = 5
        '
        'LecturerUsernameTextBox
        '
        Me.LecturerUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerUsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerAccountBindingSource, "LecturerUsername", True))
        Me.LecturerUsernameTextBox.Enabled = False
        Me.LecturerUsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerUsernameTextBox.Location = New System.Drawing.Point(175, 138)
        Me.LecturerUsernameTextBox.Name = "LecturerUsernameTextBox"
        Me.LecturerUsernameTextBox.Size = New System.Drawing.Size(136, 22)
        Me.LecturerUsernameTextBox.TabIndex = 7
        '
        'LecturerPasswordTextBox
        '
        Me.LecturerPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerAccountBindingSource, "LecturerPassword", True))
        Me.LecturerPasswordTextBox.Enabled = False
        Me.LecturerPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerPasswordTextBox.Location = New System.Drawing.Point(474, 184)
        Me.LecturerPasswordTextBox.Name = "LecturerPasswordTextBox"
        Me.LecturerPasswordTextBox.Size = New System.Drawing.Size(136, 22)
        Me.LecturerPasswordTextBox.TabIndex = 9
        '
        'LecturerEmailTextBox
        '
        Me.LecturerEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LecturerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturerAccountBindingSource, "LecturerEmail", True))
        Me.LecturerEmailTextBox.Enabled = False
        Me.LecturerEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LecturerEmailTextBox.Location = New System.Drawing.Point(175, 184)
        Me.LecturerEmailTextBox.Name = "LecturerEmailTextBox"
        Me.LecturerEmailTextBox.Size = New System.Drawing.Size(136, 22)
        Me.LecturerEmailTextBox.TabIndex = 11
        '
        'lblSearchHint
        '
        Me.lblSearchHint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchHint.AutoSize = True
        Me.lblSearchHint.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchHint.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchHint.Location = New System.Drawing.Point(297, 52)
        Me.lblSearchHint.Name = "lblSearchHint"
        Me.lblSearchHint.Size = New System.Drawing.Size(170, 17)
        Me.lblSearchHint.TabIndex = 15
        Me.lblSearchHint.Text = "Search by LecturerID :"
        '
        'LecturerAccountDB
        '
        Me.LecturerAccountDB.AllowUserToResizeColumns = False
        Me.LecturerAccountDB.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LecturerAccountDB.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LecturerAccountDB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LecturerAccountDB.AutoGenerateColumns = False
        Me.LecturerAccountDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LecturerAccountDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LecturerAccountDB.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.LecturerAccountDB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LecturerAccountDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LecturerAccountDB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LecturerAccountDB.ColumnHeadersHeight = 28
        Me.LecturerAccountDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LecturerAccountDB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.LecturerAccountDB.DataSource = Me.LecturerAccountBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LecturerAccountDB.DefaultCellStyle = DataGridViewCellStyle3
        Me.LecturerAccountDB.DoubleBuffered = True
        Me.LecturerAccountDB.EnableHeadersVisualStyles = False
        Me.LecturerAccountDB.HeaderBgColor = System.Drawing.Color.DarkViolet
        Me.LecturerAccountDB.HeaderForeColor = System.Drawing.Color.Black
        Me.LecturerAccountDB.Location = New System.Drawing.Point(42, 215)
        Me.LecturerAccountDB.Name = "LecturerAccountDB"
        Me.LecturerAccountDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.LecturerAccountDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.LecturerAccountDB.Size = New System.Drawing.Size(785, 357)
        Me.LecturerAccountDB.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LecturerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LecturerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 108
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LecturerFullName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LecturerFullName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 168
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LecturerUsername"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LecturerUsername"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 171
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LecturerPassword"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LecturerPassword"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 164
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LecturerEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LecturerEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 136
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturerAccountTableAdapter = Me.LecturerAccountTableAdapter
        Me.TableAdapterManager.LecturerTimetableTableAdapter = Nothing
        Me.TableAdapterManager.SchedulerAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentTimetableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LecturerAccountTableAdapter
        '
        Me.LecturerAccountTableAdapter.ClearBeforeFill = True
        '
        'LecturerAccountBindingNavigator
        '
        Me.LecturerAccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LecturerAccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LecturerAccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LecturerAccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentAccountBindingNavigatorSaveItem, Me.btnRefresh})
        Me.LecturerAccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LecturerAccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LecturerAccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LecturerAccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LecturerAccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LecturerAccountBindingNavigator.Name = "LecturerAccountBindingNavigator"
        Me.LecturerAccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LecturerAccountBindingNavigator.Size = New System.Drawing.Size(864, 25)
        Me.LecturerAccountBindingNavigator.TabIndex = 16
        Me.LecturerAccountBindingNavigator.Text = "BindingNavigator1"
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
        Me.btnSearch.Location = New System.Drawing.Point(733, 30)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 62)
        Me.btnSearch.TabIndex = 14
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
        Me.txtSearch.Location = New System.Drawing.Point(474, 48)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(242, 32)
        Me.txtSearch.TabIndex = 13
        Me.txtSearch.text = ""
        '
        'ManageLecturerDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 575)
        Me.Controls.Add(Me.LecturerAccountBindingNavigator)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchHint)
        Me.Controls.Add(Me.LecturerAccountDB)
        Me.Controls.Add(LecturerIDLabel)
        Me.Controls.Add(Me.LecturerIDTextBox)
        Me.Controls.Add(LecturerFullNameLabel)
        Me.Controls.Add(Me.LecturerFullNameTextBox)
        Me.Controls.Add(LecturerUsernameLabel)
        Me.Controls.Add(Me.LecturerUsernameTextBox)
        Me.Controls.Add(LecturerPasswordLabel)
        Me.Controls.Add(Me.LecturerPasswordTextBox)
        Me.Controls.Add(LecturerEmailLabel)
        Me.Controls.Add(Me.LecturerEmailTextBox)
        Me.Name = "ManageLecturerDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageLecturerDB"
        CType(Me.LecturerAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerAccountDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerAccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LecturerAccountBindingNavigator.ResumeLayout(False)
        Me.LecturerAccountBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LecturerIDTextBox As TextBox
    Friend WithEvents LecturerFullNameTextBox As TextBox
    Friend WithEvents LecturerUsernameTextBox As TextBox
    Friend WithEvents LecturerPasswordTextBox As TextBox
    Friend WithEvents LecturerEmailTextBox As TextBox
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblSearchHint As Label
    Friend WithEvents LecturerAccountDB As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents LecturerAccountBindingSource As BindingSource
    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents TableAdapterManager As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LecturerAccountTableAdapter As TimetableappDBDataSetTableAdapters.LecturerAccountTableAdapter
    Friend WithEvents LecturerAccountBindingNavigator As BindingNavigator
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
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconToolStripButton
End Class
