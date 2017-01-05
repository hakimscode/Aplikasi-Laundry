Imports System.Data.OleDb

Public Class FCucian

    Dim bln As String

    Public Sub tampilcucian()
        'menampilkan data dari database penyerahan cucian
        Dim str As String = "SELECT * FROM Penyerahan_Cucian"
        Dim da As New OleDbDataAdapter(str, koneksi)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        For Each dt In ds.Tables
            dgcucian.DataSource = dt
        Next
        dgcucian.AutoResizeColumns()
        dgcucian.AutoGenerateColumns = True
    End Sub

    Private Sub FCucian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        tampilcucian()
        tglharian()
        tahun()
    End Sub

    Private Sub rdfaktur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdfaktur.CheckedChanged
        txtkons.Enabled = True
        txtfaktur.Enabled = False
        txtkons.Focus()
    End Sub

    Private Sub rdkons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdkons.CheckedChanged
        txtfaktur.Enabled = True
        txtkons.Enabled = False
        txtfaktur.Focus()
    End Sub

    Private Sub txtkons_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkons.TextChanged
        'proses untuk memfilter data sesuai dengan inputan nama konsumen
        Dim cari As String = ""
        If txtkons.Text = "" Then
            cari = "SELECT * FROM Penyerahan_Cucian"
        Else
            cari = "SELECT * FROM Penyerahan_Cucian WHERE Konsumen LIKE '%" & txtkons.Text & "%'"
        End If
        dgcucian.DataSource = OLETable(cari)
    End Sub

    Private Sub txtfaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfaktur.TextChanged
        'proses untuk memfilter data sesuai dengan inputan nomor faktur
        Dim cari As String = ""
        If txtfaktur.Text = "" Then
            cari = "SELECT * FROM Penyerahan_Cucian"
        Else
            cari = "SELECT * FROM Penyerahan_Cucian WHERE Faktur LIKE '%" & txtfaktur.Text & "%'"
        End If
        dgcucian.DataSource = OLETable(cari)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'proses memfilter data berdasarkan tanggal, bulan dan tahun
        bulan()
        If bln = "" Then
            Exit Sub
        Else
            If tglhari.Text = "" Or blnhari.Text = "" Or thnhari.Text = "" Then
                MsgBox("Pilih Tanggal, Bulan dan Tahun", MsgBoxStyle.Critical)
            Else
                Dim filter As String = "SELECT * FROM Penyerahan_Cucian WHERE Tanggal2 = '" & tglhari.Text & "/" & bln & "/" & thnhari.Text & "'"
                dgcucian.DataSource = OLETable(filter)
            End If
        End If
    End Sub

    Public Sub tglharian()
        For i As Integer = 1 To 31
            tglhari.Items.Add(Format(i, "00"))
        Next
    End Sub

    Public Sub tahun()
        For i As Integer = 2012 To 2015
            thnhari.Items.Add(i)
        Next
    End Sub

    Public Sub bulan()
        Select Case blnhari.Text
            Case "Januari"
                bln = "01"
            Case "Februari"
                bln = "02"
            Case "Maret"
                bln = "03"
            Case "April"
                bln = "04"
            Case "Mei"
                bln = "05"
            Case "Juni"
                bln = "06"
            Case "Juli"
                bln = "07"
            Case "Agustus"
                bln = "08"
            Case "September"
                bln = "09"
            Case "Oktober"
                bln = "10"
            Case "November"
                bln = "11"
            Case "Desember"
                bln = "12"
            Case Else
                bln = ""
                MsgBox("Bulan Belum di Pilih", MsgBoxStyle.Critical)
                'blnhari.Text = ""
                blnhari.Focus()
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampilcucian()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'proses untuk memfilter data sesuai dengan keterangan, Lunas atau Belum Lunas
        Dim filter As String = ""
        If cmbket.Text = "Lunas" Then
            filter = "SELECT * FROM Penyerahan_Cucian WHERE Keterangan = '" & cmbket.Text & "'"
        Else
            If cmbket.Text = "Belum Lunas" Then
                filter = "SELECT * FROM Penyerahan_Cucian WHERE Keterangan = '" & cmbket.Text & "'"
            Else
                MsgBox("Inputan Anda Salah", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        dgcucian.DataSource = OLETable(filter)
    End Sub

    Private Sub dgcucian_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgcucian.DoubleClick
        'jika diklik 2 kali, maka akan form pengembalian cucian untuk melakukan transaksi pengembalian cucian
        FPengembalianCucian.txtfaktur.Text = dgcucian.SelectedRows.Item(0).Cells("Faktur").Value
        FPengembalianCucian.cekfaktur()
        FPengembalianCucian.Show()
        Me.Hide()
    End Sub
End Class