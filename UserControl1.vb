Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class UserControl1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkanData()
    End Sub

    Sub tampilkanData()
        bukaKoneksi()


        Dim query As String =
            "SELECT m.nim, m.nama_penerima, f.nama_fakultas, f.prodi, m.tahun_menerima_kipk, j.jenis
             FROM mahasiswa m
             JOIN fakultas f ON m.id_prodi = f.id_prodi
             JOIN jenis_bantuan j ON m.id_jenis = j.id_jenis"

        Dim da As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
End Class
