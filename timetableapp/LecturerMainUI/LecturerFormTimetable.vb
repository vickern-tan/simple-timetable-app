Public Class LecturerFormTimetable
    Private Sub LecturerTimetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LecturerTimetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LecturerTimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TimetableappDBDataSet)

    End Sub

    Private Sub LecturerFormTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimetableappDBDataSet.LecturerTimetable' table. You can move, or remove it, as needed.
        Me.LecturerTimetableTableAdapter.Fill(Me.TimetableappDBDataSet.LecturerTimetable)

    End Sub
    Sub SearchFunction()
        Try
            Me.LecturerTimetableTableAdapter.FillBy(Me.TimetableappDBDataSet.LecturerTimetable, txtSearch.Text, txtSearch.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Error|Search")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchFunction()
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged

    End Sub
End Class