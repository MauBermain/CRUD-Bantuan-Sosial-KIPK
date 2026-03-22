Imports MySql.Data.MySqlClient
Public Class SignUp

    Private Sub SignUp_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        bukaKoneksi()
        Kode_Otomatis()
    End Sub

    Sub FormHidup()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Sub Kode_Otomatis()
        Dim Urutan As Integer

        cmd = New MySqlCommand("SELECT MAX(id_username) AS maxID FROM user", conn)
        dr = cmd.ExecuteReader()

        If dr.Read() AndAlso Not IsDBNull(dr("maxID")) Then
            Urutan = CInt(dr("maxID")) + 1
        Else
            Urutan = 1000
        End If

        dr.Close()
        TextBox1.Text = Urutan.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        bukaKoneksi()


        If TextBox1.Text = "" Then
            MessageBox.Show("Nomor ID Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Masukan Username", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Focus()
            Exit Sub
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Masukan Password", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox3.Focus()
            Exit Sub
        End If

        Dim peringatan = MessageBox.Show("Apakah Data Sudah Benar?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If peringatan = vbYes Then

            Dim sql As String = "INSERT INTO user (id_username, username, password) VALUES (@id, @user, @pass)"
            cmd = New MySqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@user", TextBox2.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox3.Text)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Pendaftaran Dengan Username " & TextBox2.Text & " Berhasil", "Simpan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Login.Show()
            Hide()
        Else
            TextBox2.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim peringatan = MessageBox.Show("Apakah anda ingin membatalkan?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If peringatan = vbYes Then
            Login.Show()
            Close()
        End If
    End Sub

End Class