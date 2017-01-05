Imports System.Data.OleDb

Public Class FPenyerahanCucian

    Public Sub awal()
        txtkons.Text = ""
        txtberat.Text = ""
        txtpakaian.Text = ""
        txtharga.Text = ""
        txtdiskon.Text = "0"
        txtpanjar.Text = ""
        cmbket.Text = ""
        rdobukan.Checked = True
        cmbkode.Text = ""
        cmbanggota.Text = ""
        txtbayar.Text = ""
        txtsisa.Text = ""
    End Sub

    Public Sub tampilkonsumen()
        'menampilkan database konsumen
        Dim str As String = "SELECT * FROM Konsumen"
        Dim da As New OleDbDataAdapter(str, koneksi)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(ds)
        For Each dt In ds.Tables
            dgkonsumen.DataSource = dt
        Next
        dgkonsumen.AutoResizeColumns()
        dgkonsumen.AutoGenerateColumns = True
    End Sub

    Public Sub faktur()
        'faktur otomatis
        Dim dr As DataRow
        'dicek 4 digit terakhir dan terbesar dari faktur sebelumnya
        dr = OLETable("SELECT MAX (RIGHT (Faktur, 4)) AS Nomor FROM Penyerahan_Cucian WHERE Tanggal2 = '" & lbltanggal.Text & "'").Rows(0)
        If dr.IsNull("Nomor") Then 'jika data tidak ada
            'maka akan diberikan nilai awal
            txtfaktur.Text = Format(Now.Day, "00") & Format(Now.Month, "00") & Strings.Right(Now.Year, 2) & "0001"
        Else
            'jika ada maka 4 digit terakhit di tambah 1 yaitu 6 digit pertama tanggal, bulan dan tahun dan sisanya adalah jumlah penjualaan 
            txtfaktur.Text = Format(Now.Day, "00") & Format(Now.Month, "00") & Strings.Right(Now.Year, 2) & Format(dr("Nomor") + 1, "0000")

        End If
    End Sub

    Public Sub anggota()
        'menampilkan semua kode anggota yang ada
        Dim cmd As OleDbCommand
        Dim rd As OleDbDataReader
        cmd = New OleDbCommand("SELECT DISTINCT Kode_Anggota FROM Anggota", koneksi)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cmbkode.Items.Add(rd.Item("Kode_Anggota"))
        Loop
    End Sub

    Public Sub bayar()
        txtbayar.Text = Val(txtharga.Text) - (Val(txtdiskon.Text) / 100 * Val(txtharga.Text))
    End Sub

    Private Sub FPenyerahanCucian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        lbltanggal.Text = Now.Date
        tampilkonsumen()
        faktur()
        anggota()
        rdobukan.Checked = 1
    End Sub

    Private Sub gensoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gensoft.Click
        'menuju ke indoklasi.com
        Process.Start("http://www.indoklasik.com")
    End Sub

    Private Sub dgkonsumen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgkonsumen.DoubleClick
        txtkons.Text = dgkonsumen.SelectedRows.Item(0).Cells("Nama").Value
        rdobukan.Checked = True
        cmbkode.Text = ""
        cmbanggota.Text = ""
        txtberat.Focus()
    End Sub

    Private Sub rdobukan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdobukan.CheckedChanged
        cmbkode.Enabled = False
        cmbkode.Text = ""
        cmbanggota.Text = ""
        txtdiskon.Text = "0"
        bayar()
        txtberat.Focus()
    End Sub

    Private Sub rdoanggota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoanggota.CheckedChanged
        cmbkode.Enabled = True
        txtdiskon.Text = "15"
        bayar()
    End Sub

    Private Sub cmbkode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkode.SelectedIndexChanged
        Dim cmd As OleDbCommand
        Dim rd As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM Anggota WHERE Kode_Anggota = '" & cmbkode.Text & "'", koneksi)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then 'jika kode anggota pilihan ada dalam database
            'maka cmbanggota akan berisi text sesuai dengan nama anggota dengan kode tersebut
            cmbanggota.Text = rd.Item("Nama_Anggota")
        End If
        txtkons.Text = ""
        txtberat.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FAnggota.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FKonsumen.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam.Text = Format(Now.Hour, "00") & ":" & Format(Now.Minute, "00") & ":" & Format(Now.Second, "00")
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        awal()
    End Sub

    Private Sub txtberat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtberat.Leave
        txtharga.Text = Val(txtberat.Text) * 6000
        bayar()
    End Sub

    Private Sub txtberat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtberat.KeyPress
        'jika inputan bukan angka
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpakaian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpakaian.KeyPress
        'jika inputan bukan angka
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpanjar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpanjar.KeyPress
        'jika inputan bukan angka
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        'memfilter data sesuai dengan nama konsumen yang diinput, istilah ini dikenal dengan istilah "search"
        Dim cari As String
        If txtcari.Text = "" Then
            cari = "SELECT * FROM Konsumen"
            dgkonsumen.DataSource = OLETable(cari)
        Else
            cari = "SELECT * FROM Konsumen WHERE Nama LIKE '%" & txtcari.Text & "%'"
            dgkonsumen.DataSource = OLETable(cari)
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim kons As String = ""
        If rdoanggota.Checked = True Then
            kons = cmbanggota.Text
        ElseIf rdobukan.Checked = True Then
            kons = txtkons.Text
        End If

        'menyimpan data
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand("INSERT INTO Penyerahan_Cucian (Faktur, Tanggal_Serah, Tanggal2, Konsumen, Berat_Cucian, Jumlah_Pakaian, Harga, Diskon, Total_Bayar, Panjar, Sisa, Keterangan) " & _
                                "VALUES ('" & txtfaktur.Text & "', '" & lbltanggal.Text & "', '" & lbltanggal.Text & "', '" & kons & "', '" & txtberat.Text & " Kg" & "', '" & txtpakaian.Text & " Potong" & "', '" & txtharga.Text & "', '" & txtdiskon.Text & "', '" & txtbayar.Text & "', '" & txtpanjar.Text & "', '" & txtsisa.Text & "', '" & cmbket.Text & "')", koneksi)
        cmd.ExecuteNonQuery()
        awal()
        faktur()
    End Sub

    Private Sub txtpanjar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpanjar.Leave
        txtsisa.Text = Val(txtbayar.Text) - Val(txtpanjar.Text)
        If Val(txtsisa.Text) <= 0 Then
            cmbket.Text = "Lunas"
            txtsisa.Text = "0"
        End If
        If txtsisa.Text = "0" Then
            cmbket.Text = "Lunas"
        Else
            cmbket.Text = "Belum Lunas"
        End If
        btnsimpan.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bukakoneksi()
        lbltanggal.Text = Now.Date
        tampilkonsumen()
        faktur()
        anggota()
        rdobukan.Checked = 1
    End Sub

End Class