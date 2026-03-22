
Imports MySql.Data.MySqlClient

Public Class input
    Private Sub input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkanData()
        loadJenis()
        loadProdi()
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
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("nim").Value.ToString()
            TextBox2.Text = row.Cells("nama_penerima").Value.ToString()
            TextBox3.Text = row.Cells("tahun_menerima_kipk").Value.ToString()
            ComboBox1.Text = row.Cells("jenis").Value.ToString()
            ComboBox2.Text = row.Cells("prodi").Value.ToString()
        End If
    End Sub
    Sub loadJenis()
        bukaKoneksi()

        Dim query As String = "SELECT id_jenis, jenis FROM jenis_bantuan"
        Dim cmd As New MySqlCommand(query, conn)
        Dim rd As MySqlDataReader = cmd.ExecuteReader()

        Dim dt As New DataTable
        dt.Load(rd)

        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "jenis"
        ComboBox1.ValueMember = "id_jenis"
        ComboBox1.SelectedIndex = -1
        conn.Close()
    End Sub
    Sub loadProdi()
        bukaKoneksi()

        Dim query As String = "SELECT id_prodi, prodi FROM fakultas"
        Dim cmd As New MySqlCommand(query, conn)
        Dim rd As MySqlDataReader = cmd.ExecuteReader()

        Dim dt As New DataTable
        dt.Load(rd)

        ComboBox2.DataSource = dt
        ComboBox2.DisplayMember = "prodi"
        ComboBox2.ValueMember = "id_prodi"
        ComboBox2.SelectedIndex = -1
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukaKoneksi()

        Dim query As String =
            "INSERT INTO mahasiswa (nim, nama_penerima, id_prodi, id_jenis, tahun_menerima_kipk)
         VALUES (@nim, @nama, @prodi, @jenis, @tahun)"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nim", TextBox1.Text)
        cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
        cmd.Parameters.AddWithValue("@tahun", TextBox3.Text)
        cmd.Parameters.AddWithValue("@jenis", ComboBox1.SelectedValue)
        cmd.Parameters.AddWithValue("@prodi", ComboBox2.SelectedValue)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data berhasil ditambahkan!")
        tampilkanData()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bukaKoneksi()

        Dim query As String =
            "UPDATE mahasiswa SET 
            nama_penerima=@nama,
            id_prodi=@prodi,
            id_jenis=@jenis,
            tahun_menerima_kipk=@tahun
         WHERE nim=@nim"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nim", TextBox1.Text)
        cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
        cmd.Parameters.AddWithValue("@tahun", TextBox3.Text)
        cmd.Parameters.AddWithValue("@jenis", ComboBox1.SelectedValue)
        cmd.Parameters.AddWithValue("@prodi", ComboBox2.SelectedValue)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data berhasil diupdate!")
        tampilkanData()
    End Sub
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bukaKoneksi()

        Dim query As String = "DELETE FROM mahasiswa WHERE nim=@nim"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nim", TextBox1.Text)

        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Data berhasil dihapus!")
        tampilkanData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Focus()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        bukaKoneksi()

        Dim keyword As String = TextBox4.Text

        Dim query As String =
            "SELECT m.nim, m.nama_penerima, f.nama_fakultas, f.prodi,
                m.tahun_menerima_kipk, j.jenis
         FROM mahasiswa m
         JOIN fakultas f ON m.id_prodi = f.id_prodi
         JOIN jenis_bantuan j ON m.id_jenis = j.id_jenis
         WHERE m.nim LIKE @key 
            OR m.nama_penerima LIKE @key
            OR f.prodi LIKE @key
            OR j.jenis LIKE @key"

        Dim da As New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")

        Dim dt As New DataTable
        da.Fill(dt)

        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox4.Clear()
        tampilkanData()
    End Sub


End Class
