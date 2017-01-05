Imports System.Data.OleDb

Public Class FLogin

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        'keluar program
        If koneksi.State = ConnectionState.Open Then
            koneksi.Close() 'menutup koneksi database
        End If
        Application.Exit()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        bukakoneksi()
        Dim cmd As OleDbCommand
        Dim rd As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM Users WHERE Username = '" & txtusername.Text & "'", koneksi)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then 'jika username inputan terdapat dalam database
            If txtpassword.Text = rd.Item("Password") Then 'jika password cocok dengan username
                If rd.Item("Jenis_User") = "Admin" Then 'jika jenis user admin maka di beri nilai var user = admin
                    user = "admin"
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    MsgBox("Selamat Datang " & rd.Item("Nama"), MsgBoxStyle.MsgBoxSetForeground)
                    FMenu.Show()
                    Me.Hide()
                ElseIf rd.Item("Jenis_User") = "Kasir" Then 'jika jenis user kasir maka di beri nilai var user = kasir
                    user = "kasir"
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    MsgBox("Selamat Datang " & rd.Item("Nama"), MsgBoxStyle.MsgBoxSetForeground)
                    FMenu.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Username dan Password Tidak Cocok", MsgBoxStyle.Critical) 'jika password tidak cocok dengan username
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
            End If
        Else
            MsgBox("Username Tidak Ada", MsgBoxStyle.Critical) 'jika username inputan tidak ada dalam database
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub
End Class