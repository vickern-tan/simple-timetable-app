
Public Class ManageLecturerDB
    Private Sub ManageLecturerDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimetableappDBDataSet.LecturerAccount' table. You can move, or remove it, as needed.
        Me.LecturerAccountTableAdapter.Fill(Me.TimetableappDBDataSet.LecturerAccount)
        Me.LecturerAccountBindingNavigator.BindingSource = LecturerAccountBindingSource
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.LecturerAccountTableAdapter.FillBy(Me.TimetableappDBDataSet.LecturerAccount, txtSearch.text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Error|Search")
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Try
            If MsgBox("Do you want to Delete the selected record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save Data") = DialogResult.Yes Then
                LecturerAccountBindingSource.RemoveCurrent()
                LecturerAccountBindingSource.EndEdit()
                LecturerAccountTableAdapter.Update(Me.TimetableappDBDataSet.LecturerAccount)

                ' REFRESH DATABASE
                Me.LecturerAccountTableAdapter.Fill(Me.TimetableappDBDataSet.LecturerAccount)
                MsgBox("Record has been Deleted.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Delete|Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Delete|Error")
        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        Try
            If LecturerIDTextBox.Text <> "" Then
                LecturerAccountBindingSource.AddNew()
            Else
                MsgBox("Please Fill In LecturerID before adding a New Row!", MsgBoxStyle.Information, "ManageUser|Info")
                LecturerIDTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub StudentAccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentAccountBindingNavigatorSaveItem.Click
        ' SAVE NEW RECORD
        Try
            Dim result As DialogResult
            result = MsgBox("Do you want to Save the selected record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save Data")

            If (result = DialogResult.Yes) Then
                LecturerAccountBindingSource.EndEdit()
                LecturerAccountTableAdapter.Update(Me.TimetableappDBDataSet.LecturerAccount)

                ' REFRESH DATABASE
                Me.LecturerAccountTableAdapter.Fill(Me.TimetableappDBDataSet.LecturerAccount)
                MsgBox("Record has been saved successfully.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Data")
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Update|Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ManageLecturerDB_Load(sender, e)
    End Sub

    Private Sub txtSearch_OnTextChange(sender As Object, e As EventArgs) Handles txtSearch.OnTextChange

    End Sub

    Private Sub LecturerAccountBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles LecturerAccountBindingNavigator.RefreshItems

    End Sub

    Private Sub LecturerAccountBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles LecturerAccountBindingSource.CurrentChanged

    End Sub

    Private Sub LecturerAccountDB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LecturerAccountDB.CellContentClick

    End Sub
End Class