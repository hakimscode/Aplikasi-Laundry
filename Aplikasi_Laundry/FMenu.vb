Public Class FMenu

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FPegawai.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FJabatan.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FAnggota.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FPenyerahanCucian.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FPengembalianCucian.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FCucian.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If koneksi.State = ConnectionState.Open Then
            koneksi.Close()
        End If
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'membuat label1 bergerak ke kanan seperi animasi
        If Label1.Left = -600 Then
            Label1.Left = 1380
        Else
            Label1.Left = Label1.Left - 10
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'menuju link indoklasik.com
        Process.Start("http://www.indoklasik.com")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'jika user = kasir maka pada saat menekan tombol users muncul pesan critical
        If user = "kasir" Then
            MsgBox("Anda Tidak Memiliki Izin Untuk Membuka Menu Ini", MsgBoxStyle.Critical)
            Exit Sub
        Else
            FUsers.Show()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FKonsumen.Show()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        'jika user = kasir, pada saat menuku tab pegawai dan laporan akan muncul pesan critical
        If user = "kasir" Then
            If TabControl1.SelectedIndex = 3 Or TabControl1.SelectedIndex = 4 Then
                MsgBox("Anda Tidak Memiliki Izin Untuk Membuka Menu Ini", MsgBoxStyle.Critical)
                TabControl1.SelectedIndex = 0
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        FLogin.Show()
        Me.Hide()
        FLogin.txtusername.Focus()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'menampilkan laporan anggota
        FLaporan.Show()
        FLaporan.crv.ReportSource = ""
        FLaporan.crv.ReportSource = "Laporan Anggota.rpt"
        FLaporan.crv.RefreshReport()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'menampilkan laporan pegawai
        FLaporan.Show()
        FLaporan.crv.ReportSource = ""
        FLaporan.crv.ReportSource = "Laporan Pegawai.rpt"
        FLaporan.crv.RefreshReport()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'menampilkan laporan konsumen
        FLaporan.Show()
        FLaporan.crv.ReportSource = ""
        FLaporan.crv.ReportSource = "Laporan Konsumen.rpt"
        FLaporan.crv.RefreshReport()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        laporan = "Laporan Serah Cucian.rpt"
        filter = "Penyerahan_Cucian"
        FFilterLaporan.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        laporan = "Laporan Kembali Cucian.rpt"
        filter = "Pengembalian_Cucian"
        FFilterLaporan.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        laporan = "Laporan Pemasukan.rpt"
        filter = "Pemasukan"
        FFilterLaporan.Show()
    End Sub
End Class