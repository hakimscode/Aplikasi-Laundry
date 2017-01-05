Imports System.Data.OleDb

Public Class FUsers

    Public Sub awal()
        txtnama.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        cmbjenis.Text = ""
        txtnama.Focus()
    End Sub

    Public Sub tampiluser()
        'menampilkan data dari field users
        Dim tampil As String = "SELECT * FROM Users"
        Dim da As New OleDbDataAdapter(tampil, koneksi)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        For Each dt In ds.Tables
            dgusers.DataSource = dt
        Next
        dgusers.AutoResizeColumns()
        'kolom password tidak akan ditampilkan
        dgusers.Columns("Password").Visible = False
    End Sub

    Private Sub FUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        tampiluser()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        'jika masih ada textbox yang kosong
        If txtnama.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or cmbjenis.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical)
        Else
            'menyimpan data
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("INSERT INTO Users ([Nama], [Username], [Password], [Jenis_User]) " & _
                                   "VALUES ('" & txtnama.Text & "', '" & txtuser.Text & "', '" & txtpass.Text & "', '" & cmbjenis.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            awal()
            tampiluser()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        'menghapus data
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand("DELETE * FROM Users WHERE Nama = '" & txtnama.Text & "'", koneksi)
        cmd.ExecuteNonQuery()
        tampiluser()
        awal()
    End Sub

    Private Sub dgusers_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgusers.CellClick
        'menampilkan data dari datagrid ke dalam textbox sesuai dengan cell yang di klik
        txtnama.Text = dgusers.SelectedRows.Item(0).Cells("Nama").Value
        txtuser.Text = dgusers.SelectedRows.Item(0).Cells("Username").Value
        txtpass.Text = dgusers.SelectedRows.Item(0).Cells("Password").Value
        cmbjenis.Text = dgusers.SelectedRows.Item(0).Cells("Jenis_User").Value
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        awal()
    End Sub
End Class