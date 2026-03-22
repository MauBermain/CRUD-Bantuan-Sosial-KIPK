<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class input
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(input))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        TransparantPanel1 = New TransparantPanel()
        Label6 = New Label()
        Button6 = New Button()
        TextBox4 = New TextBox()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TransparantPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 32)
        Label1.TabIndex = 0
        Label1.Text = "NIM Mahasiswa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama Penerima"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 32)
        Label3.TabIndex = 2
        Label3.Text = "Tahun menerima"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 311)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 32)
        Label4.TabIndex = 3
        Label4.Text = "Progam Studi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(259, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(343, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Location = New Point(259, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(343, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Location = New Point(259, 176)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(343, 31)
        TextBox3.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(674, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 35)
        Button1.TabIndex = 8
        Button1.Text = "Tambahkan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(861, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 35)
        Button2.TabIndex = 9
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(674, 102)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 35)
        Button3.TabIndex = 10
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaption
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(861, 104)
        Button4.Name = "Button4"
        Button4.Size = New Size(149, 35)
        Button4.TabIndex = 11
        Button4.Text = "Kosongkan"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(24, 365)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(951, 184)
        DataGridView1.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(259, 246)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(343, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Cursor = Cursors.Hand
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(259, 314)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(343, 33)
        ComboBox2.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 32)
        Label5.TabIndex = 16
        Label5.Text = "Jenis Bantuan"
        ' 
        ' TransparantPanel1
        ' 
        TransparantPanel1.Controls.Add(Label6)
        TransparantPanel1.Controls.Add(Button6)
        TransparantPanel1.Controls.Add(TextBox4)
        TransparantPanel1.Controls.Add(Button5)
        TransparantPanel1.Controls.Add(Label1)
        TransparantPanel1.Controls.Add(DataGridView1)
        TransparantPanel1.Controls.Add(Label5)
        TransparantPanel1.Controls.Add(TextBox1)
        TransparantPanel1.Controls.Add(ComboBox2)
        TransparantPanel1.Controls.Add(Button1)
        TransparantPanel1.Controls.Add(ComboBox1)
        TransparantPanel1.Controls.Add(Label4)
        TransparantPanel1.Controls.Add(TextBox2)
        TransparantPanel1.Controls.Add(Label2)
        TransparantPanel1.Controls.Add(TextBox3)
        TransparantPanel1.Controls.Add(Label3)
        TransparantPanel1.Controls.Add(Button4)
        TransparantPanel1.Controls.Add(Button2)
        TransparantPanel1.Controls.Add(Button3)
        TransparantPanel1.Dock = DockStyle.Bottom
        TransparantPanel1.Location = New Point(0, 193)
        TransparantPanel1.Name = "TransparantPanel1"
        TransparantPanel1.Size = New Size(1061, 561)
        TransparantPanel1.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(749, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 32)
        Label6.TabIndex = 20
        Label6.Text = "Cari"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.White
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Crimson
        Button6.Location = New Point(983, 316)
        Button6.Name = "Button6"
        Button6.Size = New Size(37, 31)
        Button6.TabIndex = 19
        Button6.Text = "X"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Location = New Point(814, 316)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(163, 31)
        TextBox4.TabIndex = 18
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.Red
        Button5.Location = New Point(861, 172)
        Button5.Name = "Button5"
        Button5.Size = New Size(149, 35)
        Button5.TabIndex = 17
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' input
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1061, 754)
        Controls.Add(TransparantPanel1)
        Name = "input"
        Text = "Kelola Data"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TransparantPanel1.ResumeLayout(False)
        TransparantPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TransparantPanel1 As TransparantPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label

End Class
