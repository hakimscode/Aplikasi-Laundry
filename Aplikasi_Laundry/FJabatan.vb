Imports System.Data.OleDb

Public Class FJabatan

    Dim selrow = ""

    Public Sub kosong()
        'mengosongkan semua textbox
        txtkode.Text = ""
        txtjabatan.Text = ""
        selrow = ""
    End Sub

    Public Sub tampil()
        'menampilkan database jabatan
        Dim tampil As String = "SELECT * FROM Jabatan"
        Dim da As New OleDbDataAdapter(tampil, koneksi)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            dgjabatan.DataSource = dt
        Next
        dgjabatan.AutoResizeColumns()
        dgjabatan.AutoGenerateColumns = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        'jika masih ada textbox yang kosong
        If txtkode.Text = "" Or txtjabatan.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical)
        Else
            'menyimpan data ke dalam database
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("INSERT INTO Jabatan (Kode_Jabatan, Jabatan) " & _
                                   "VALUES ('" & txtkode.Text & "', '" & txtjabatan.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'jika data belum dipilih
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'mengedit data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("UPDATE Jabatan SET Jabatan = '" & txtjabatan.Text & "' WHERE Kode_Jabatan = '" & selrow & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        'jika data belum di pilih
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'menghapus data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("DELETE * FROM Jabatan WHERE Kode_Jabatan = '" & txtkode.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        kosong()
    End Sub

    Private Sub dgjabatan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgjabatan.CellClick
        'menampilkan data dari datagrid ke dalam textbox sesuai dengan cell yang di klik
        selrow = dgjabatan.SelectedRows.Item(0).Cells("Kode_Jabatan").Value
        txtkode.Text = dgjabatan.SelectedRows.Item(0).Cells("Kode_Jabatan").Value
        txtjabatan.Text = dgjabatan.SelectedRows.Item(0).Cells("Jabatan").Value
    End Sub

    Private Sub FJabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        tampil()
    End Sub
End Class