Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Module myfont
    Private _pfc As PrivateFontCollection = Nothing
    Public ReadOnly Property GetInstance(ByVal Size As Single, ByVal Style As FontStyle) As Font
        Get
            If _pfc Is Nothing Then LoadFont()
            Return New Font(_pfc.Families(0), Size, Style)
        End Get
    End Property

    Private Sub LoadFont()
        Try
            _pfc = New PrivateFontCollection
            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.DS_DIGI.Length)
            Marshal.Copy(My.Resources.DS_DIGI, 0, fontMemPointer, My.Resources.DS_DIGI.Length)
            _pfc.AddMemoryFont(fontMemPointer, My.Resources.DS_DIGI.Length)
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
