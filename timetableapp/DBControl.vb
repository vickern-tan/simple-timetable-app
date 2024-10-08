﻿Imports System.Data.OleDb
Public Class DBControl
    ' CREATE DB CONNECTION
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         "Data Source=|DataDirectory|\TimetableappDB.accdb")

    ' PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    ' DATABASE DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMATERS
    Public Params As New List(Of OleDbParameter)

    ' QUERY STATISTICS(ERROR)
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATISTICS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS(ERROR) LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    ' INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class
