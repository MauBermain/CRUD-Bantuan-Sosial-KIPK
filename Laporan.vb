Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ClosedXML.Excel
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports Xceed.Document.NET
Imports Xceed.Words.NET   'HANYA INI, jangan pakai Xceed.Document.NET!

Public Class Laporan

    Private Sub laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("PDF")
        ComboBox1.Items.Add("DOCX")
        ComboBox1.Items.Add("EXCEL")
        ComboBox1.SelectedIndex = 0

        loadComboFakultas()
        loadComboJenis()
        loadComboTahun()

        tampilkanData()
    End Sub

    '========================================
    '   TAMPILKAN DATA DENGAN FILTER
    '========================================
    Sub tampilkanData(Optional ByVal filterQuery As String = "")
        Try
            bukaKoneksi()

            Dim query As String =
                "SELECT m.nim, m.nama_penerima, f.nama_fakultas, f.prodi,
                        m.tahun_menerima_kipk, j.jenis
                 FROM mahasiswa m
                 JOIN fakultas f ON m.id_prodi = f.id_prodi
                 JOIN jenis_bantuan j ON m.id_jenis = j.id_jenis
                 WHERE 1=1 " & filterQuery

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            DataGridView1.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error tampilkan data: " & ex.Message)
        End Try
    End Sub


    '========================================
    '   EXPORT PDF (ASLI TANPA DELETED)
    '========================================
    Sub ExportPDF()
        Try
            Dim save As New SaveFileDialog()
            save.Filter = "PDF Files (*.pdf)|*.pdf"
            save.FileName = "Data_KIPK.pdf"

            If save.ShowDialog() <> DialogResult.OK Then Exit Sub

            '======== FIX AMBIGUOUS =====================
            Dim pdfDoc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
            Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, New FileStream(save.FileName, FileMode.Create))
            pdfDoc.Open()
            '============================================

            Dim titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18)

            '======== FIX AMBIGUOUS =====================
            Dim title As New iTextSharp.text.Paragraph("DATA KIPK", titleFont)
            '============================================

            title.Alignment = iTextSharp.text.Element.ALIGN_CENTER
            pdfDoc.Add(title)

            pdfDoc.Add(New iTextSharp.text.Paragraph(vbCrLf))

            Dim table As New iTextSharp.text.pdf.PdfPTable(DataGridView1.Columns.Count)
            table.WidthPercentage = 100

            For Each col As DataGridViewColumn In DataGridView1.Columns
                Dim hdrFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10)
                Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(col.HeaderText, hdrFont))
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                cell.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER
                table.AddCell(cell)
            Next

            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                For c As Integer = 0 To DataGridView1.Columns.Count - 1
                    Dim value = DataGridView1.Rows(r).Cells(c).Value
                    table.AddCell(If(value Is Nothing, "", value.ToString()))
                Next
            Next

            pdfDoc.Add(table)
            pdfDoc.Close()

            MessageBox.Show("Export PDF Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error Export PDF: " & ex.Message)
        End Try
    End Sub

    '========================================
    '   EXPORT DOCX (ASLI TANPA PERUBAHAN)
    '========================================
    Sub ExportDOC()
        Try
            Dim save As New SaveFileDialog()
            save.Filter = "Word Document (*.docx)|*.docx"
            save.FileName = "Data_KIPK.docx"

            If save.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim doc As DocX = DocX.Create(save.FileName)

            doc.InsertParagraph("DATA KIPK").FontSize(18).Bold().Alignment = Alignment.center
            doc.InsertParagraph(vbCrLf)

            Dim totalRows As Integer = DataGridView1.Rows.Count
            Dim totalCols As Integer = DataGridView1.Columns.Count

            Dim table = doc.AddTable(totalRows + 1, totalCols)
            table.Design = TableDesign.TableGrid

            For c As Integer = 0 To totalCols - 1
                table.Rows(0).Cells(c).Paragraphs(0).Append(DataGridView1.Columns(c).HeaderText).Bold()
            Next

            For r As Integer = 0 To totalRows - 1
                For c As Integer = 0 To totalCols - 1
                    Dim value = DataGridView1.Rows(r).Cells(c).Value
                    table.Rows(r + 1).Cells(c).Paragraphs(0).Append(
                        If(value Is Nothing, "", value.ToString()))
                Next
            Next

            doc.InsertTable(table)
            doc.Save()

            MessageBox.Show("Export DOCX berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub


    '========================================
    '   EXPORT EXCEL (ASLI)
    '========================================
    Public Sub ExportExcel()
        Try
            Dim wb As New XLWorkbook()
            Dim ws = wb.Worksheets.Add("Data KIPK")

            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                ws.Cell(1, col + 1).Value = DataGridView1.Columns(col).HeaderText
            Next

            For row As Integer = 0 To DataGridView1.Rows.Count - 1
                For col As Integer = 0 To DataGridView1.Columns.Count - 1
                    ws.Cell(row + 2, col + 1).Value =
                        If(DataGridView1.Rows(row).Cells(col).Value Is Nothing,
                           "",
                           DataGridView1.Rows(row).Cells(col).Value.ToString())
                Next
            Next

            Dim save As New SaveFileDialog()
            save.Filter = "Excel File (*.xlsx)|*.xlsx"
            save.FileName = "Data_KIPK.xlsx"

            If save.ShowDialog() = DialogResult.OK Then
                wb.SaveAs(save.FileName)
                MessageBox.Show("Export Excel Berhasil!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    '========================================
    '   TOMBOL PRINT
    '========================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Pilih format export terlebih dahulu!", vbExclamation)
            Exit Sub
        End If

        Select Case ComboBox1.SelectedItem.ToString()
            Case "PDF" : ExportPDF()
            Case "DOCX" : ExportDOC()
            Case "EXCEL" : ExportExcel()
        End Select
    End Sub


    '========================================
    '   SEARCH
    '========================================
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        bukaKoneksi()

        Dim keyword As String = TextBox1.Text

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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        tampilkanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menu.Show()
        Close()
    End Sub


    '=================================================
    '    COMBOBOX FAKULTAS
    '=================================================
    Sub loadComboFakultas()
        Try
            bukaKoneksi()
            Dim cmd As New MySqlCommand("SELECT DISTINCT nama_fakultas FROM fakultas", conn)
            Dim rd = cmd.ExecuteReader()

            cmbFakultas.Items.Clear()
            cmbFakultas.Items.Add("-- Semua Fakultas --")

            While rd.Read()
                cmbFakultas.Items.Add(rd("nama_fakultas").ToString())
            End While

            cmbFakultas.SelectedIndex = 0
            rd.Close()

        Catch ex As Exception
            MessageBox.Show("Error Fakultas: " & ex.Message)
        End Try
    End Sub


    '=================================================
    '    COMBOBOX PRODI (CASCADING)
    '=================================================
    Sub loadComboProdi(ByVal fakultas As String)
        Try
            bukaKoneksi()
            Dim cmd As New MySqlCommand(
                "SELECT prodi FROM fakultas WHERE nama_fakultas = @fak", conn)
            cmd.Parameters.AddWithValue("@fak", fakultas)

            Dim rd = cmd.ExecuteReader()

            cmbProdi.Items.Clear()
            cmbProdi.Items.Add("-- Semua Prodi --")

            While rd.Read()
                cmbProdi.Items.Add(rd("prodi").ToString())
            End While

            cmbProdi.SelectedIndex = 0
            rd.Close()

        Catch ex As Exception
            MessageBox.Show("Error Prodi: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFakultas.SelectedIndexChanged
        If cmbFakultas.SelectedIndex > 0 Then
            loadComboProdi(cmbFakultas.Text)
        Else
            cmbProdi.Items.Clear()
            cmbProdi.Items.Add("-- Semua Prodi --")
            cmbProdi.SelectedIndex = 0
        End If
        applyFilter()
    End Sub


    '=================================================
    '    COMBOBOX JENIS
    '=================================================
    Sub loadComboJenis()
        Try
            bukaKoneksi()
            Dim cmd As New MySqlCommand("SELECT jenis FROM jenis_bantuan", conn)
            Dim rd = cmd.ExecuteReader()

            cmbJenis.Items.Clear()
            cmbJenis.Items.Add("-- Semua Jenis --")

            While rd.Read()
                cmbJenis.Items.Add(rd("jenis").ToString())
            End While

            cmbJenis.SelectedIndex = 0
            rd.Close()

        Catch ex As Exception
            MessageBox.Show("Error Jenis: " & ex.Message)
        End Try
    End Sub


    '=================================================
    '    COMBO TAHUN + RANGE TAHUN
    '=================================================
    Sub loadComboTahun()
        cmbtahun.Items.Clear()
        cmbtahunawal.Items.Clear()
        cmbtahunakhir.Items.Clear()

        cmbtahun.Items.Add("-- Semua Tahun --")

        For i As Integer = 2015 To 2030
            cmbtahun.Items.Add(i.ToString())
            cmbtahunawal.Items.Add(i.ToString())
            cmbtahunakhir.Items.Add(i.ToString())
        Next

        cmbtahun.SelectedIndex = 0
        cmbtahunawal.SelectedIndex = 0
        cmbtahunakhir.SelectedIndex = 0
    End Sub


    '=================================================
    '   EVENT FILTER
    '=================================================
    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        applyFilter()
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged
        applyFilter()
    End Sub

    Private Sub cmbTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtahun.SelectedIndexChanged
        applyFilter()
    End Sub

    Private Sub cmbTahunAwal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtahunawal.SelectedIndexChanged
        applyFilter()
    End Sub

    Private Sub cmbTahunAkhir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtahunakhir.SelectedIndexChanged
        applyFilter()
    End Sub


    '=================================================
    '   APPLY FILTER (UTAMA)
    '=================================================
    Sub applyFilter()
        Dim q As String = ""

        If cmbFakultas.SelectedIndex > 0 Then
            q &= " AND f.nama_fakultas = '" & cmbFakultas.Text & "' "
        End If

        If cmbProdi.SelectedIndex > 0 Then
            q &= " AND f.prodi = '" & cmbProdi.Text & "' "
        End If

        If cmbJenis.SelectedIndex > 0 Then
            q &= " AND j.jenis = '" & cmbJenis.Text & "' "
        End If

        If cmbtahun.SelectedIndex > 0 Then
            q &= " AND m.tahun_menerima_kipk = '" & cmbtahun.Text & "' "
        End If

        If cmbtahunawal.SelectedIndex > 0 And cmbtahunakhir.SelectedIndex > 0 Then
            q &= " AND m.tahun_menerima_kipk BETWEEN '" & cmbtahunawal.Text &
                 "' AND '" & cmbtahunakhir.Text & "' "
        End If

        tampilkanData(q)
    End Sub


    '=================================================
    '   RESET FILTER
    '=================================================
    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        cmbFakultas.SelectedIndex = 0
        cmbProdi.SelectedIndex = 0
        cmbJenis.SelectedIndex = 0
        cmbtahun.SelectedIndex = 0
        cmbtahunawal.SelectedIndex = 0
        cmbtahunakhir.SelectedIndex = 0

        tampilkanData()
    End Sub

End Class

