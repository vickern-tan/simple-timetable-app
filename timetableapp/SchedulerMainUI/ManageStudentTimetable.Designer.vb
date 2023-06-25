<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageStudentTimetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudentTimetable))
        Me.StudentTimetableTableAdapter = New timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager()
        Me.TimetableappDBDataSet = New timetableapp.TimetableappDBDataSet()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentTimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTimetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentAccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconToolStripButton()
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentTimetableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentTimetableTableAdapter
        '
        Me.StudentTimetableTableAdapter.BackupDataSetBeforeUpdate = False
        Me.StudentTimetableTableAdapter.Connection = Nothing
        Me.StudentTimetableTableAdapter.LecturerAccountTableAdapter = Nothing
        Me.StudentTimetableTableAdapter.LecturerTimetableTableAdapter = Nothing
        Me.StudentTimetableTableAdapter.SchedulerAccountTableAdapter = Nothing
        Me.StudentTimetableTableAdapter.StudentAccountTableAdapter = Nothing
        Me.StudentTimetableTableAdapter.StudentTimetableTableAdapter = Nothing
        Me.StudentTimetableTableAdapter.UpdateOrder = timetableapp.TimetableappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TimetableappDBDataSet
        '
        Me.TimetableappDBDataSet.DataSetName = "TimetableappDBDataSet"
        Me.TimetableappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(583, 202)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(8, 8)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.StudentTimetableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(93, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(653, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'StudentTimetableBindingSource
        '
        Me.StudentTimetableBindingSource.DataSource = Me.TimetableappDBDataSet
        Me.StudentTimetableBindingSource.Position = 0
        '
        'StudentTimetableBindingNavigator
        '
        Me.StudentTimetableBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.StudentTimetableBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.StudentTimetableBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.StudentTimetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.StudentAccountBindingNavigatorSaveItem, Me.btnRefresh})
        Me.StudentTimetableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentTimetableBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.StudentTimetableBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.StudentTimetableBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.StudentTimetableBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.StudentTimetableBindingNavigator.Name = "StudentTimetableBindingNavigator"
        Me.StudentTimetableBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.StudentTimetableBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.StudentTimetableBindingNavigator.TabIndex = 17
        Me.StudentTimetableBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton1.Text = "New Row"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'ManageStudentTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentTimetableBindingNavigator)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "ManageStudentTimetable"
        Me.Text = "ManageStudentTimetable"
        CType(Me.TimetableappDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTimetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentTimetableBindingNavigator.ResumeLayout(False)
        Me.StudentTimetableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentTimetableTableAdapter As TimetableappDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimetableappDBDataSet As TimetableappDBDataSet
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentTimetableBindingSource As BindingSource
    Friend WithEvents StudentTimetableBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StudentAccountBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconToolStripButton
End Class
