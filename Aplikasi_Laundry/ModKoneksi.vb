Imports System.Data.OleDb


Module ModKoneksi
    Public koneksi As New OleDbConnection
    Public str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Aplikasi_Laundry.mdb"
    Public user As String
    Public laporan As String
    Public filter As String

    Public Sub bukakoneksi()
        If koneksi.State = ConnectionState.Open Then
            koneksi.Close()
        End If
        koneksi.ConnectionString = str
        koneksi.Open()
    End Sub

    Public Function OLETable(ByVal Source As String) As DataTable
        Try
            Dim da As New OleDb.OleDbDataAdapter(Source, koneksi)
            Dim dt As New DataTable

            da.Fill(dt)
            OLETable = dt
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message)
            OLETable = Nothing
        End Try
    End Function
End Module
