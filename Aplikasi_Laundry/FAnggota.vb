Imports System.Data.OleDb

Public Class FAnggota

    Dim selrow As String

    Public Sub kosong()
        'mengosongkan semua textbox
        txtkode.Text = ""
        txtnama.Text = ""
        cmbjeniskel.Text = ""
        txtalamat.Text = ""
        txthp.Text = ""
        selrow = ""
    End Sub

    Public Sub tampil()
        'menampilkan data ke dalam datagrid
        Dim tampil As String = "SELECT * FROM Anggota"
        Dim da As New OleDbDataAdapter(tampil, koneksi)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            dganggota.DataSource = dt
        Next
        dganggota.AutoResizeColumns()
        dganggota.AutoGenerateColumns = True
    End Sub

    Public Sub kode()
        'membuat kode otomatis untuk anggota
        Dim dr As DataRow
        'cek 4 digit terbesar kode terakhir dari table anggota
        dr = OLETable("SELECT MAX (RIGHT (Kode_Anggota, 4)) AS Nomor FROM ANGGOTA").Rows(0)
        If dr.IsNull("Nomor") Then 'jika tidak ada
            txtkode.Text = "0001" 'maka diberi nilai awal
        Else
            'jika ada maka nilai terbesar akan di tambahkan satu untuk kode berikutnya
            txtkode.Text = Format(dr("Nomor") + 1, "0000")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        tampil()
        kode()
    End Sub

    Private Sub cmbjeniskel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjeniskel.SelectedIndexChanged
        txtalamat.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        'jika masih ada textbox yang kosong
        If txtkode.Text = "" Or txtnama.Text = "" Or cmbjeniskel.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical)
        Else
            'simpan data kedalam database
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("INSERT INTO Anggota (Kode_Anggota, Nama_Anggota, Jenis_Kelamin, Alamat, No_HP) " & _
                                   "VALUES ('" & txtkode.Text & "', '" & txtnama.Text & "', '" & cmbjeniskel.Text & "', '" & txtalamat.Text & "', '" & txthp.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
            kode()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        'jika data belum di pilih
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'hapus data dari database
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("DELETE * FROM Anggota WHERE Kode_Anggota = '" & txtkode.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
            kode()
        End If
    End Sub

    Private Sub dganggota_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dganggota.CellClick
        'menampilkan dari datagrid ke dalam textbox sesuai dengan cell yang diklik
        selrow = dganggota.SelectedRows.Item(0).Cells("Kode_Anggota").Value
        txtkode.Text = dganggota.SelectedRows.Item(0).Cells("Kode_Anggota").Value
        txtnama.Text = dganggota.SelectedRows.Item(0).Cells("Nama_Anggota").Value
        cmbjeniskel.Text = dganggota.SelectedRows.Item(0).Cells("Jenis_Kelamin").Value
        txtalamat.Text = dganggota.SelectedRows.Item(0).Cells("Alamat").Value
        txthp.Text = dganggota.SelectedRows.Item(0).Cells("No_HP").Value
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'jika data belum di pilih
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'mengedit data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("UPDATE Anggota SET Nama_Anggota = '" & txtnama.Text & "', Jenis_Kelamin = '" & cmbjeniskel.Text & "', Alamat = '" & txtalamat.Text & "', No_HP = '" & txthp.Text & "' WHERE Kode_Anggota = '" & selrow & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        kosong()
        kode()
    End Sub
End Class
