Public Class Splashscreen
    Dim strTemp As String
    Dim LenTemp, n As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'menjalankan progres bar untuk membuatnya kelihatan seperti animasi
        If ProgressBar1.Value = 250 Then
            Timer1.Enabled = False
            FLogin.Show()
            Me.Hide()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub Splashscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl.Text = "Aplikasi Laundry" & vbCr & "Made By Heri Hakim Setiawan" & vbCr & "Mail : hhakimsetiawan@gmail.com" & vbCr & "http://indoklasik.com"
        strTemp = lbl.Text
        n = 1
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lbl.Visible = True
        LenTemp = Len(strTemp)
        lbl.Text = Strings.Left(strTemp, n) + "_"
        n = n + 1
        If n > LenTemp Then
            lbl.Text = Strings.Left(strTemp, n) + "_"
        End If
    End Sub
End Class