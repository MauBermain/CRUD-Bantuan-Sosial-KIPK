<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        TransparantPanel1 = New TransparantPanel()
        cmbProdi = New ComboBox()
        cmbJenis = New ComboBox()
        cmbtahunawal = New ComboBox()
        cmbtahunakhir = New ComboBox()
        cmbFakultas = New ComboBox()
        cmbtahun = New ComboBox()
        btnResetFilter = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TransparantPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-3, 245)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1025, 303)
        DataGridView1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(708, 94)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(896, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(73, 33)
        Button1.TabIndex = 9
        Button1.Text = "Cetak"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Crimson
        Button2.Location = New Point(416, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 31)
        Button2.TabIndex = 20
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(216, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 30)
        Label1.TabIndex = 22
        Label1.Text = "Kolom Pencarian"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(516, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 30)
        Label2.TabIndex = 23
        Label2.Text = "Jenis Laporan"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(708, 174)
        Button3.Name = "Button3"
        Button3.Size = New Size(182, 35)
        Button3.TabIndex = 24
        Button3.Text = "Kembali"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TransparantPanel1
        ' 
        TransparantPanel1.Controls.Add(Label8)
        TransparantPanel1.Controls.Add(Label7)
        TransparantPanel1.Controls.Add(Label6)
        TransparantPanel1.Controls.Add(Label5)
        TransparantPanel1.Controls.Add(Label4)
        TransparantPanel1.Controls.Add(Label3)
        TransparantPanel1.Controls.Add(btnResetFilter)
        TransparantPanel1.Controls.Add(cmbtahun)
        TransparantPanel1.Controls.Add(cmbProdi)
        TransparantPanel1.Controls.Add(cmbJenis)
        TransparantPanel1.Controls.Add(cmbtahunawal)
        TransparantPanel1.Controls.Add(cmbtahunakhir)
        TransparantPanel1.Controls.Add(cmbFakultas)
        TransparantPanel1.Controls.Add(Button3)
        TransparantPanel1.Controls.Add(DataGridView1)
        TransparantPanel1.Controls.Add(Label2)
        TransparantPanel1.Controls.Add(Button2)
        TransparantPanel1.Controls.Add(Label1)
        TransparantPanel1.Controls.Add(Button1)
        TransparantPanel1.Controls.Add(ComboBox1)
        TransparantPanel1.Controls.Add(TextBox1)
        TransparantPanel1.Dock = DockStyle.Bottom
        TransparantPanel1.Location = New Point(0, 159)
        TransparantPanel1.Name = "TransparantPanel1"
        TransparantPanel1.Size = New Size(1024, 466)
        TransparantPanel1.TabIndex = 25
        ' 
        ' cmbProdi
        ' 
        cmbProdi.FormattingEnabled = True
        cmbProdi.Location = New Point(216, 94)
        cmbProdi.Name = "cmbProdi"
        cmbProdi.Size = New Size(182, 33)
        cmbProdi.TabIndex = 29
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Location = New Point(216, 133)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(182, 33)
        cmbJenis.TabIndex = 28
        ' 
        ' cmbtahunawal
        ' 
        cmbtahunawal.FormattingEnabled = True
        cmbtahunawal.Location = New Point(708, 17)
        cmbtahunawal.Name = "cmbtahunawal"
        cmbtahunawal.Size = New Size(182, 33)
        cmbtahunawal.TabIndex = 27
        ' 
        ' cmbtahunakhir
        ' 
        cmbtahunakhir.FormattingEnabled = True
        cmbtahunakhir.Location = New Point(708, 55)
        cmbtahunakhir.Name = "cmbtahunakhir"
        cmbtahunakhir.Size = New Size(182, 33)
        cmbtahunakhir.TabIndex = 26
        ' 
        ' cmbFakultas
        ' 
        cmbFakultas.FormattingEnabled = True
        cmbFakultas.Location = New Point(216, 55)
        cmbFakultas.Name = "cmbFakultas"
        cmbFakultas.Size = New Size(182, 33)
        cmbFakultas.TabIndex = 25
        ' 
        ' cmbtahun
        ' 
        cmbtahun.FormattingEnabled = True
        cmbtahun.Location = New Point(216, 172)
        cmbtahun.Name = "cmbtahun"
        cmbtahun.Size = New Size(182, 33)
        cmbtahun.TabIndex = 30
        ' 
        ' btnResetFilter
        ' 
        btnResetFilter.BackColor = Color.White
        btnResetFilter.Cursor = Cursors.Hand
        btnResetFilter.FlatStyle = FlatStyle.Flat
        btnResetFilter.ForeColor = Color.Red
        btnResetFilter.Location = New Point(708, 133)
        btnResetFilter.Name = "btnResetFilter"
        btnResetFilter.Size = New Size(182, 35)
        btnResetFilter.TabIndex = 31
        btnResetFilter.Text = "Reset"
        btnResetFilter.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 30)
        Label3.TabIndex = 32
        Label3.Text = "Fakultas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 30)
        Label4.TabIndex = 33
        Label4.Text = "Program Studi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 30)
        Label5.TabIndex = 34
        Label5.Text = "Jenis Bantuan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 30)
        Label6.TabIndex = 35
        Label6.Text = "Tahun"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(516, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 30)
        Label7.TabIndex = 36
        Label7.Text = "Tahun Awal"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(516, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 30)
        Label8.TabIndex = 37
        Label8.Text = "Tahun Akhir"
        ' 
        ' Laporan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1024, 625)
        Controls.Add(TransparantPanel1)
        Name = "Laporan"
        Text = "Laporan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TransparantPanel1.ResumeLayout(False)
        TransparantPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TransparantPanel1 As TransparantPanel
    Friend WithEvents cmbProdi As ComboBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents cmbtahunawal As ComboBox
    Friend WithEvents cmbtahunakhir As ComboBox
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents cmbtahun As ComboBox
    Friend WithEvents btnResetFilter As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
