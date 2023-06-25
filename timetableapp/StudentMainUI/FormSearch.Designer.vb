<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSearchTitle = New System.Windows.Forms.Label()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
        Me.LecturerTimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturerTimetableTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.LecturerTimetableTableAdapter()
        Me.TableAdapterManager = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        Me.LecturerTimetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LecturerTimetableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LecturerTimetableBunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerTimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LecturerTimetableBindingNavigator.SuspendLayout()
        CType(Me.LecturerTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSearchTitle.Font = New System.Drawing.Font("Perpetua", 48.0!)
        Me.lblSearchTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSearchTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(1394, 116)
        Me.lblSearchTitle.TabIndex = 1
        Me.lblSearchTitle.Text = "Search Section"
        Me.lblSearchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSearch.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearch.HintText = "Insert Lecturer ID/FullName"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.DarkViolet
        Me.txtSearch.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.DarkViolet
        Me.txtSearch.LineThickness = 2
        Me.txtSearch.Location = New System.Drawing.Point(10, 166)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(431, 53)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 30
        Me.btnSearch.Location = New System.Drawing.Point(383, 181)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 38)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'TimetableappDBDataSet
        '
        Me.TimetableappDBDataSet.DataSetName = "TimetableappDBDataSet"
        Me.TimetableappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturerTimetableBindingSource
        '
        Me.LecturerTimetableBindingSource.DataMember = "LecturerTimetable"
        Me.LecturerTimetableBindingSource.DataSource = Me.TimetableappDBDataSet
        '
        'LecturerTimetableTableAdapter
        '
        Me.LecturerTimetableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturerAccountTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTimetableTableAdapter = Me.LecturerTimetableTableAdapter
        Me.TableAdapterManager.SchedulerAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentTimetableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LecturerTimetableBindingNavigator
        '
        Me.LecturerTimetableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LecturerTimetableBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LecturerTimetableBindingNavigator.BindingSource = Me.LecturerTimetableBindingSource
        Me.LecturerTimetableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LecturerTimetableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LecturerTimetableBindingNavigator.Enabled = False
        Me.LecturerTimetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LecturerTimetableBindingNavigatorSaveItem})
        Me.LecturerTimetableBindingNavigator.Location = New System.Drawing.Point(0, 116)
        Me.LecturerTimetableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LecturerTimetableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LecturerTimetableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LecturerTimetableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LecturerTimetableBindingNavigator.Name = "LecturerTimetableBindingNavigator"
        Me.LecturerTimetableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LecturerTimetableBindingNavigator.Size = New System.Drawing.Size(1394, 25)
        Me.LecturerTimetableBindingNavigator.TabIndex = 45
        Me.LecturerTimetableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LecturerTimetableBindingNavigatorSaveItem
        '
        Me.LecturerTimetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LecturerTimetableBindingNavigatorSaveItem.Image = CType(resources.GetObject("LecturerTimetableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LecturerTimetableBindingNavigatorSaveItem.Name = "LecturerTimetableBindingNavigatorSaveItem"
        Me.LecturerTimetableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LecturerTimetableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LecturerTimetableBunifuCustomDataGrid
        '
        Me.LecturerTimetableBunifuCustomDataGrid.AllowUserToAddRows = False
        Me.LecturerTimetableBunifuCustomDataGrid.AllowUserToDeleteRows = False
        Me.LecturerTimetableBunifuCustomDataGrid.AllowUserToOrderColumns = True
        Me.LecturerTimetableBunifuCustomDataGrid.AllowUserToResizeColumns = False
        Me.LecturerTimetableBunifuCustomDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.LecturerTimetableBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LecturerTimetableBunifuCustomDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LecturerTimetableBunifuCustomDataGrid.AutoGenerateColumns = False
        Me.LecturerTimetableBunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LecturerTimetableBunifuCustomDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LecturerTimetableBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LecturerTimetableBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LecturerTimetableBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LecturerTimetableBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LecturerTimetableBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturerTimetableBunifuCustomDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.LecturerTimetableBunifuCustomDataGrid.DataSource = Me.LecturerTimetableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumSlateBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LecturerTimetableBunifuCustomDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.LecturerTimetableBunifuCustomDataGrid.DoubleBuffered = True
        Me.LecturerTimetableBunifuCustomDataGrid.EnableHeadersVisualStyles = False
        Me.LecturerTimetableBunifuCustomDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LecturerTimetableBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LecturerTimetableBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.LecturerTimetableBunifuCustomDataGrid.Location = New System.Drawing.Point(13, 245)
        Me.LecturerTimetableBunifuCustomDataGrid.Name = "LecturerTimetableBunifuCustomDataGrid"
        Me.LecturerTimetableBunifuCustomDataGrid.ReadOnly = True
        Me.LecturerTimetableBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LecturerTimetableBunifuCustomDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.LecturerTimetableBunifuCustomDataGrid.Size = New System.Drawing.Size(1369, 405)
        Me.LecturerTimetableBunifuCustomDataGrid.TabIndex = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CourseCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CourseCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CourseName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CourseName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LecturerID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LecturerID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LecturerName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LecturerName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ClassroomCode"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ClassroomCode"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IntakeCode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IntakeCode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'FormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1394, 651)
        Me.Controls.Add(Me.LecturerTimetableBunifuCustomDataGrid)
        Me.Controls.Add(Me.LecturerTimetableBindingNavigator)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchTitle)
        Me.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Name = "FormSearch"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "FormSearch"
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerTimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LecturerTimetableBindingNavigator.ResumeLayout(False)
        Me.LecturerTimetableBindingNavigator.PerformLayout()
        CType(Me.LecturerTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchTitle As Label
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents LecturerTimetableBindingSource As BindingSource
    Friend WithEvents LecturerTimetableTableAdapter As TimetableappDBDataSetTableAdapters.LecturerTimetableTableAdapter
    Friend WithEvents TableAdapterManager As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LecturerTimetableBindingNavigator As BindingNavigator
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
    Friend WithEvents LecturerTimetableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents LecturerTimetableBunifuCustomDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
