Public Class FFilterLaporan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntahunan.Click
        If cmbtahun2.Text = "" Then 'kondisi jika combobox tahun2 kosong
            MsgBox("Tentukan Tahun")
        Else
            'Menampilkan Laporan Sesuai dengan tahun yang dipilih
            FLaporan.Show()
            FLaporan.crv.ReportSource = Nothing
            FLaporan.crv.SelectionFormula = "YEAR ({" & filter & ".Tanggal_Serah}) = " & Val(cmbtahun2.Text)
            FLaporan.crv.ReportSource = laporan
            FLaporan.crv.RefreshReport()
        End If
    End Sub

    Private Sub btntampil_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbulanan.Click
        If cmbbulan.Text = "" Or cmbtahun.Text = "" Then 'kondisi jika cmbbulan dan cmbtahun kosong
            MsgBox("Tentukan Bulan dan Tahun")
            cmbbulan.Focus()
        Else
            'menampilkan laporan sesuai dengan bulan dan tangal yang dipilih
            FLaporan.Show()
            FLaporan.crv.ReportSource = Nothing
            FLaporan.crv.SelectionFormula = "MONTH ({" & filter & ".Tanggal_Serah}) = " & Val(cmbbulan.Text) & " AND YEAR ({" & filter & ".Tanggal_Serah}) = " & Val(cmbtahun.Text)
            FLaporan.crv.ReportSource = laporan
            FLaporan.crv.RefreshReport()
        End If
    End Sub

    Private Sub btnsemua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsemua.Click
        'menampilkan laporan
        FLaporan.Show()
        FLaporan.crv.ReportSource = Nothing
        FLaporan.crv.ReportSource = laporan
        FLaporan.crv.RefreshReport()
    End Sub

    Private Sub FFilterLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If laporan = "Laporan Serah Cucian.rpt" Then
            Me.Text = Me.Text & " Serah Cucian"
        ElseIf laporan = "Laporan Kembali Cucian.rpt" Then
            Me.Text = Me.Text & " Kembali Cucian"
        ElseIf laporan = "Laporan Pemasukan.rpt" Then
            Me.Text = Me.Text & " Pemasukan"
        End If
    End Sub

    Private Sub btnharian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnharian.Click
        'jika tanggal, bulan dan tahun belum terisi
        If cmbtgl.Text = "" Or cmbbln.Text = "" Or cmbthn.Text = "" Then
            MsgBox("Pilih Tanggal, Bulan dan Tahun Penjualan")
        Else
            'menampilkan laporan sesuai dengan tanggal, bulan dan tahun yang ditentukan
            FLaporan.Show()
            FLaporan.crv.ReportSource = Nothing
            FLaporan.crv.SelectionFormula = "TOTEXT({" & filter & ".Tanggal2})= '" & cmbtgl.Text & "/" & cmbbln.Text & "/" & cmbthn.Text & "'"
            FLaporan.crv.ReportSource = laporan
            FLaporan.crv.RefreshReport()
        End If
    End Sub
End Class