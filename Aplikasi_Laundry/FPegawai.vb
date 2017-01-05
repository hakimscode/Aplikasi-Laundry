Imports System.Data.OleDb

Public Class FPegawai
    Dim selrow As String

    Public Sub kosong()
        'mengosongkan semua textbox
        txtnip.Text = ""
        txtnama.Text = ""
        cmbjabatan.Text = ""
        txtalamat.Text = ""
        selrow = ""
    End Sub

    Public Sub tampil()
        'menampilkan database pegawai
        Dim tampil As String = "SELECT * FROM Pegawai"
        Dim da As New OleDbDataAdapter(tampil, koneksi)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            dgpegawai.DataSource = dt
        Next
        dgpegawai.AutoResizeColumns()
        dgpegawai.AutoGenerateColumns = True
    End Sub

    Public Sub jabatan()
        'menampilkan semua jabatan yang ada
        Dim cmd As OleDbCommand
        Dim rd As OleDbDataReader
        cmd = New OleDbCommand("SELECT DISTINCT Jabatan FROM Jabatan", koneksi)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cmbjabatan.Items.Add(rd.Item("Jabatan"))
        Loop
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        tampil()
        jabatan()
    End Sub

    Private Sub cmbjeniskel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjabatan.SelectedIndexChanged
        'kode pegawai otomatis
        Dim dr As DataRow
        Dim cmd As OleDbCommand
        Dim rd As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM Jabatan WHERE Jabatan = '" & cmbjabatan.Text & "'", koneksi)
        rd = cmd.ExecuteReader
        rd.Read()

        'di cek 4 digit terakhir dan terbesar dari kode sebelumnya sesuai dengan jabatan yang di pilih
        dr = OLETable("SELECT MAX (RIGHT (NIP, 4)) AS Nomor FROM Pegawai WHERE Jabatan = '" & cmbjabatan.Text & "'").Rows(0)
        If dr.IsNull("Nomor") Then 'jika data tidak ada
            txtnip.Text = rd.Item("Kode_Jabatan") & "0001" 'maka akan diberikan nilai awal
        Else 'jika data ada
            'maka 4 digit terakhir akan di tambah dengan satu untuk kode selanjutnya
            txtnip.Text = rd.Item("Kode_Jabatan") & Format(dr("Nomor") + 1, "0000")
        End If
        txtnama.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        'jika masih ada textbox yang kosong
        If txtnip.Text = "" Or txtnama.Text = "" Or cmbjabatan.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical)
        Else
            'menyimpan data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("INSERT INTO Pegawai (NIP, Nama_Pegawai, Jabatan, Alamat) " & _
                                   "VALUES ('" & txtnip.Text & "', '" & txtnama.Text & "', '" & cmbjabatan.Text & "', '" & txtalamat.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        'jika masih ada textbox yang kosong
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'menghapus data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("DELETE * FROM Pegawai WHERE NIP = '" & txtnip.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub dganggota_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpegawai.CellClick
        'menampilkan data dari datagrid ke dalam textbox sesuai dengan cell yang di klik
        selrow = dgpegawai.SelectedRows.Item(0).Cells("NIP").Value
        txtnip.Text = dgpegawai.SelectedRows.Item(0).Cells("NIP").Value
        txtnama.Text = dgpegawai.SelectedRows.Item(0).Cells("Nama_Pegawai").Value
        cmbjabatan.Text = dgpegawai.SelectedRows.Item(0).Cells("Jabatan").Value
        txtalamat.Text = dgpegawai.SelectedRows.Item(0).Cells("Alamat").Value
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'jika masih ada textbox yang kosong
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'mengedit data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("UPDATE Pegawai SET Nama_Pegawai = '" & txtnama.Text & "', Jabatan = '" & cmbjabatan.Text & "', Alamat = '" & txtalamat.Text & "' WHERE NIP = '" & selrow & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        kosong()
    End Sub
End Class