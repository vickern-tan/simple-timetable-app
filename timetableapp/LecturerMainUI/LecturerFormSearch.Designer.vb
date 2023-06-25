<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecturerFormSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecturerFormSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StudentTimetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentTimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
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
        Me.StudentTimetableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentTimetableBunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSearchtitle = New System.Windows.Forms.Label()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.StudentTimetableTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.StudentTimetableTableAdapter()
        Me.TableAdapterManager = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentTimetableBindingNavigator.SuspendLayout()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentTimetableBindingNavigator
        '
        Me.StudentTimetableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentTimetableBindingNavigator.BindingSource = Me.StudentTimetableBindingSource
        Me.StudentTimetableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentTimetableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentTimetableBindingNavigator.Enabled = False
        Me.StudentTimetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentTimetableBindingNavigatorSaveItem})
        Me.StudentTimetableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentTimetableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentTimetableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentTimetableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentTimetableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentTimetableBindingNavigator.Name = "StudentTimetableBindingNavigator"
        Me.StudentTimetableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentTimetableBindingNavigator.Size = New System.Drawing.Size(1002, 25)
        Me.StudentTimetableBindingNavigator.TabIndex = 0
        Me.StudentTimetableBindingNavigator.Text = "BindingNavigator1"
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
        'StudentTimetableBindingSource
        '
        Me.StudentTimetableBindingSource.DataMember = "StudentTimetable"
        Me.StudentTimetableBindingSource.DataSource = Me.TimetableappDBDataSet
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
        'StudentTimetableBindingNavigatorSaveItem
        '
        Me.StudentTimetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentTimetableBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentTimetableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentTimetableBindingNavigatorSaveItem.Name = "StudentTimetableBindingNavigatorSaveItem"
        Me.StudentTimetableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentTimetableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentTimetableBunifuCustomDataGrid
        '
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToAddRows = False
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToDeleteRows = False
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToResizeColumns = False
        Me.StudentTimetableBunifuCustomDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StudentTimetableBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentTimetableBunifuCustomDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentTimetableBunifuCustomDataGrid.AutoGenerateColumns = False
        Me.StudentTimetableBunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentTimetableBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.StudentTimetableBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersHeight = 30
        Me.StudentTimetableBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentTimetableBunifuCustomDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.StudentTimetableBunifuCustomDataGrid.DataSource = Me.StudentTimetableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentTimetableBunifuCustomDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentTimetableBunifuCustomDataGrid.DoubleBuffered = True
        Me.StudentTimetableBunifuCustomDataGrid.EnableHeadersVisualStyles = False
        Me.StudentTimetableBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.StudentTimetableBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.Black
        Me.StudentTimetableBunifuCustomDataGrid.Location = New System.Drawing.Point(0, 237)
        Me.StudentTimetableBunifuCustomDataGrid.Name = "StudentTimetableBunifuCustomDataGrid"
        Me.StudentTimetableBunifuCustomDataGrid.ReadOnly = True
        Me.StudentTimetableBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentTimetableBunifuCustomDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentTimetableBunifuCustomDataGrid.Size = New System.Drawing.Size(1002, 429)
        Me.StudentTimetableBunifuCustomDataGrid.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IntakeCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IntakeCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Monday"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monday"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tuesday"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tuesday"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Wednesday"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Wednesday"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Thursday"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Thursday"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Friday"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Friday"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'lblSearchtitle
        '
        Me.lblSearchtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSearchtitle.Font = New System.Drawing.Font("Lucida Fax", 36.0!)
        Me.lblSearchtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSearchtitle.Location = New System.Drawing.Point(0, 25)
        Me.lblSearchtitle.Name = "lblSearchtitle"
        Me.lblSearchtitle.Size = New System.Drawing.Size(1002, 124)
        Me.lblSearchtitle.TabIndex = 16
        Me.lblSearchtitle.Text = "SEARCH"
        Me.lblSearchtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 30
        Me.btnSearch.Location = New System.Drawing.Point(750, 164)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 38)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearch.HintText = "Insert Student Intake Code OR Course Code"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.DarkViolet
        Me.txtSearch.LineIdleColor = System.Drawing.Color.LightGray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.DarkViolet
        Me.txtSearch.LineThickness = 2
        Me.txtSearch.Location = New System.Drawing.Point(194, 153)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(614, 53)
        Me.txtSearch.TabIndex = 45
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'LecturerFormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 666)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchtitle)
        Me.Controls.Add(Me.StudentTimetableBunifuCustomDataGrid)
        Me.Controls.Add(Me.StudentTimetableBindingNavigator)
        Me.Name = "LecturerFormSearch"
        Me.Text = "LecturerFormSearch"
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentTimetableBindingNavigator.ResumeLayout(False)
        Me.StudentTimetableBindingNavigator.PerformLayout()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents StudentTimetableBindingSource As BindingSource
    Friend WithEvents StudentTimetableTableAdapter As TimetableappDBDataSetTableAdapters.StudentTimetableTableAdapter
    Friend WithEvents TableAdapterManager As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTimetableBindingNavigator As BindingNavigator
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
    Friend WithEvents StudentTimetableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StudentTimetableBunifuCustomDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents lblSearchtitle As Label
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
