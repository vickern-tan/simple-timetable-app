Public Class ManageStudentTimetable
    Private Sub ManageStudentTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StudentTimetableTableAdapter.Fill(Me.TimetableappDBDataSet.StudentTimetable)
        Me.StudentTimetableBindingNavigator.BindingSource = StudentTimetableBindingSource
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles StudentTimetableBindingSource.CurrentChanged

    End Sub

    Private Sub IconSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub
End Class