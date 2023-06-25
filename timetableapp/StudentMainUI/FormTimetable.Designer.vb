<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimetable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTimetable))
        Me.lblTimetableTitle = New System.Windows.Forms.Label()
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
        Me.StudentTimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTimetableTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.StudentTimetableTableAdapter()
        Me.TableAdapterManager = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        Me.StudentTimetableBunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchBar = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentTimetableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentTimetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentTimetableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTimetableTitle
        '
        Me.lblTimetableTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTimetableTitle.AutoSize = True
        Me.lblTimetableTitle.Font = New System.Drawing.Font("Perpetua", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimetableTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimetableTitle.Location = New System.Drawing.Point(569, 39)
        Me.lblTimetableTitle.Name = "lblTimetableTitle"
        Me.lblTimetableTitle.Size = New System.Drawing.Size(303, 73)
        Me.lblTimetableTitle.TabIndex = 1
        Me.lblTimetableTitle.Text = "Timetable"
        '
        'TimetableappDBDataSet
        '
        Me.TimetableappDBDataSet.DataSetName = "TimetableappDBDataSet"
        Me.TimetableappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTimetableBindingSource
        '
        Me.StudentTimetableBindingSource.DataMember = "StudentTimetable"
        Me.StudentTimetableBindingSource.DataSource = Me.TimetableappDBDataSet
        '
        'StudentTimetableTableAdapter
        '
        Me.StudentTimetableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturerAccountTableAdapter = Nothing
        Me.TableAdapterManager.LecturerTimetableTableAdapter = Nothing
        Me.TableAdapterManager.SchedulerAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentAccountTableAdapter = Nothing
        Me.TableAdapterManager.StudentTimetableTableAdapter = Me.StudentTimetableTableAdapter
        Me.TableAdapterManager.UpdateOrder = timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentTimetableBunifuCustomDataGrid
        '
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToAddRows = False
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToDeleteRows = False
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentTimetableBunifuCustomDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentTimetableBunifuCustomDataGrid.AutoGenerateColumns = False
        Me.StudentTimetableBunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentTimetableBunifuCustomDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StudentTimetableBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.StudentTimetableBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersHeight = 45
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentTimetableBunifuCustomDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StudentTimetableBunifuCustomDataGrid.DataSource = Me.StudentTimetableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentTimetableBunifuCustomDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentTimetableBunifuCustomDataGrid.DoubleBuffered = True
        Me.StudentTimetableBunifuCustomDataGrid.EnableHeadersVisualStyles = False
        Me.StudentTimetableBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.Silver
        Me.StudentTimetableBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.Black
        Me.StudentTimetableBunifuCustomDataGrid.Location = New System.Drawing.Point(98, 337)
        Me.StudentTimetableBunifuCustomDataGrid.Name = "StudentTimetableBunifuCustomDataGrid"
        Me.StudentTimetableBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.StudentTimetableBunifuCustomDataGrid.Size = New System.Drawing.Size(1246, 687)
        Me.StudentTimetableBunifuCustomDataGrid.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IntakeCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IntakeCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CourseCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CourseCode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Monday"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monday"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tuesday"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tuesday"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Wednesday"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Wednesday"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Thursday"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Thursday"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Friday"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Friday"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearchBar.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(317, 217)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(808, 29)
        Me.txtSearchBar.TabIndex = 3
        '
        'lblsearch
        '
        Me.lblsearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.ForeColor = System.Drawing.Color.White
        Me.lblsearch.Location = New System.Drawing.Point(94, 220)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(217, 24)
        Me.lblsearch.TabIndex = 4
        Me.lblsearch.Text = "Search by CourseCode :"
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 40
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.ActiveForecolor = System.Drawing.Color.White
        Me.btnSearch.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleCornerRadius = 40
        Me.btnSearch.IdleFillColor = System.Drawing.Color.Red
        Me.btnSearch.IdleForecolor = System.Drawing.Color.Transparent
        Me.btnSearch.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnSearch.Location = New System.Drawing.Point(1179, 193)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(165, 70)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'StudentTimetableBindingNavigatorSaveItem
        '
        Me.StudentTimetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentTimetableBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentTimetableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentTimetableBindingNavigatorSaveItem.Name = "StudentTimetableBindingNavigatorSaveItem"
        Me.StudentTimetableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentTimetableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentTimetableBindingNavigator
        '
        Me.StudentTimetableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentTimetableBindingNavigator.BindingSource = Me.StudentTimetableBindingSource
        Me.StudentTimetableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentTimetableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentTimetableBindingNavigator.Enabled = False
        Me.StudentTimetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentTimetableBindingNavigatorSaveItem})
        Me.StudentTimetableBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StudentTimetableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentTimetableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentTimetableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentTimetableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentTimetableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentTimetableBindingNavigator.Name = "StudentTimetableBindingNavigator"
        Me.StudentTimetableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentTimetableBindingNavigator.Size = New System.Drawing.Size(1441, 25)
        Me.StudentTimetableBindingNavigator.TabIndex = 2
        Me.StudentTimetableBindingNavigator.Text = "BindingNavigator1"
        '
        'FormTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1441, 1024)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.txtSearchBar)
        Me.Controls.Add(Me.StudentTimetableBunifuCustomDataGrid)
        Me.Controls.Add(Me.StudentTimetableBindingNavigator)
        Me.Controls.Add(Me.lblTimetableTitle)
        Me.Name = "FormTimetable"
        Me.Text = "FormTimetable"
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentTimetableBindingNavigator.ResumeLayout(False)
        Me.StudentTimetableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimetableTitle As Label
    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents StudentTimetableBindingSource As BindingSource
    Friend WithEvents StudentTimetableTableAdapter As TimetableappDBDataSetTableAdapters.StudentTimetableTableAdapter
    Friend WithEvents TableAdapterManager As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTimetableBunifuCustomDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtSearchBar As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblsearch As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents StudentTimetableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StudentTimetableBindingNavigator As BindingNavigator
End Class
