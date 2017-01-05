Imports System.Data.OleDb

Public Class FKonsumen
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
        'menampilkan data konsumen
        Dim tampil As String = "SELECT * FROM Konsumen"
        Dim da As New OleDbDataAdapter(tampil, koneksi)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            dgkonsumen.DataSource = dt
        Next
        dgkonsumen.AutoResizeColumns()
        dgkonsumen.AutoGenerateColumns = True
    End Sub

    Public Sub kode()
        'kode konsumen otomatis
        Dim dr As DataRow
        'di cek 4 digit terbesar dari kode konsumen yang ada
        dr = OLETable("SELECT MAX (RIGHT (Kode_Konsumen, 4)) AS Nomor FROM Konsumen").Rows(0)
        If dr.IsNull("Nomor") Then 'jika tidak ada data sama sekali
            txtkode.Text = "0001" 'maka akan di beri nilai baru
        Else
            'jika sudah ada, maka 4 digit terakhit ditambah satu untuk kode selanjutnya
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
            'menyimpan data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("INSERT INTO Konsumen (Kode_Konsumen, Nama, Jenis_Kelamin, Alamat, No_HP) " & _
                                   "VALUES ('" & txtkode.Text & "', '" & txtnama.Text & "', '" & cmbjeniskel.Text & "', '" & txtalamat.Text & "', '" & txthp.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
            kode()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        'jika masih ada textbox yang kosong
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'menghapus data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("DELETE * FROM Konsumen WHERE Kode_Konsumen = '" & txtkode.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            tampil()
            kosong()
            kode()
        End If
    End Sub

    Private Sub dganggota_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgkonsumen.CellClick
        'menampilkan data dari datagrid ke textbox sesuai dengan cell yang di klik
        selrow = dgkonsumen.SelectedRows.Item(0).Cells("Kode_Konsumen").Value
        txtkode.Text = dgkonsumen.SelectedRows.Item(0).Cells("Kode_Konsumen").Value
        txtnama.Text = dgkonsumen.SelectedRows.Item(0).Cells("Nama").Value
        cmbjeniskel.Text = dgkonsumen.SelectedRows.Item(0).Cells("Jenis_Kelamin").Value
        txtalamat.Text = dgkonsumen.SelectedRows.Item(0).Cells("Alamat").Value
        txthp.Text = dgkonsumen.SelectedRows.Item(0).Cells("No_HP").Value
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'jika masih ada textbox yang kosong
        If selrow = "" Then
            MsgBox("Anda Belum Memilih Data yang Ingin di Hapus", MsgBoxStyle.Critical)
        Else
            'mengedit data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("UPDATE Konsumen SET Nama = '" & txtnama.Text & "', Jenis_Kelamin = '" & cmbjeniskel.Text & "', Alamat = '" & txtalamat.Text & "', No_HP = '" & txthp.Text & "' WHERE Kode_Konsumen = '" & selrow & "'", koneksi)
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