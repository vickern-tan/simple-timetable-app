Public Class ManageStudentDB
    Private Sub StudentAccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentAccountBindingNavigatorSaveItem.Click
        Try
            Dim result As DialogResult
            result = MsgBox("Do you want to Save the selected record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save Data")

            If (result = DialogResult.Yes) Then
                Me.Validate()
                StudentAccountBindingSource.EndEdit()
                StudentAccountTableAdapter.Update(Me.TimetableappDBDataSet.StudentAccount)

                ' REFRESH DATABASE
                Me.StudentAccountTableAdapter.Fill(Me.TimetableappDBDataSet.StudentAccount)
                MsgBox("Record has been saved successfully.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Data")
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Update|Error")
        End Try

    End Sub

    Private Sub ManageStudentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimetableappDBDataSet.StudentAccount' table. You can move, or remove it, as needed.
        Me.StudentAccountTableAdapter.Fill(Me.TimetableappDBDataSet.StudentAccount)
        Me.StudentAccountBindingNavigator.BindingSource = StudentAccountBindingSource
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.StudentAccountTableAdapter.FillBy(Me.TimetableappDBDataSet.StudentAccount, txtSearch.text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Error|Search")
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ManageStudentDB_Load(sender, e)
    End Sub

    Private Sub StudentAccountBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles StudentAccountBindingSource.CurrentChanged

    End Sub
End Class