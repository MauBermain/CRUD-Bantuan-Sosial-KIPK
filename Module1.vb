Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub bukaKoneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=kipk")
        conn.Open()
    End Sub
End Module