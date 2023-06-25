Public Class LecturerFormSearch
    Private Sub StudentTimetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentTimetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentTimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TimetableappDBDataSet)

    End Sub

    Private Sub LecturerFormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimetableappDBDataSet.StudentTimetable' table. You can move, or remove it, as needed.
        Me.StudentTimetableTableAdapter.Fill(Me.TimetableappDBDataSet.StudentTimetable)

    End Sub
    Sub SearchFunction()
        Try
            Me.StudentTimetableTableAdapter.FillBy(Me.TimetableappDBDataSet.StudentTimetable, txtSearch.Text, txtSearch.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Error|Search")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchFunction()
    End Sub
End Class