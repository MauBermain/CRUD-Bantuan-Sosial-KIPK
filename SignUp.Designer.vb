<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        TransparantPanel1 = New TransparantPanel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TransparantPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Chartreuse
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(662, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(259, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 39)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(259, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(233, 39)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(259, 175)
        TextBox3.MaxLength = 5
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(233, 39)
        TextBox3.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Chartreuse
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(662, 100)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 4
        Button2.Text = "Kosongkan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Chartreuse
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(662, 175)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "Kembali"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TransparantPanel1
        ' 
        TransparantPanel1.Controls.Add(Label4)
        TransparantPanel1.Controls.Add(Label3)
        TransparantPanel1.Controls.Add(Label2)
        TransparantPanel1.Controls.Add(Label1)
        TransparantPanel1.Controls.Add(TextBox2)
        TransparantPanel1.Controls.Add(Button3)
        TransparantPanel1.Controls.Add(TextBox1)
        TransparantPanel1.Controls.Add(Button2)
        TransparantPanel1.Controls.Add(TextBox3)
        TransparantPanel1.Controls.Add(Button1)
        TransparantPanel1.Dock = DockStyle.Bottom
        TransparantPanel1.Location = New Point(0, 132)
        TransparantPanel1.Name = "TransparantPanel1"
        TransparantPanel1.Size = New Size(800, 318)
        TransparantPanel1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 32)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 32)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 32)
        Label1.TabIndex = 6
        Label1.Text = "ID Pengguna"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TransparantPanel1)
        Name = "SignUp"
        Text = "Daftar Akun"
        TransparantPanel1.ResumeLayout(False)
        TransparantPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TransparantPanel1 As TransparantPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label

End Class
