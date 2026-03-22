Public Class menu
    Private Sub TampilkanUC(uc As UserControl)
        Panel3.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel3.Controls.Add(uc)
        uc.BringToFront()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilkanUC(New UserControl2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        input.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TampilkanUC(New UserControl1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Laporan.Show()
        Me.Hide()
    End Sub
End Class