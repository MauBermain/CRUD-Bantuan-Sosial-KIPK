Imports MySql.Data.MySqlClient
Public Class login

    Private Sub InitializeMyControl()
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
        TextBox2.MaxLength = 5
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try

            bukaKoneksi()

            Dim sqlQuery As String = "SELECT * FROM user WHERE username=@user AND password=@pass"
            cmd = New MySqlCommand(sqlQuery, conn)


            cmd.Parameters.AddWithValue("@user", TextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

            dr = cmd.ExecuteReader()

            If dr.HasRows = False Then
                MsgBox("Username dan password salah!", MsgBoxStyle.Exclamation, "Error Login")
            Else
                MsgBox("Login berhasil, Selamat datang " & TextBox1.Text & "!", MsgBoxStyle.Information, "Success Login")
                menu.Show()
                Me.Hide()
            End If
            If TextBox2.Text.Length > 5 Then
                MessageBox.Show("Password maksimal 5 karakter!")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan koneksi: " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SignUp.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class