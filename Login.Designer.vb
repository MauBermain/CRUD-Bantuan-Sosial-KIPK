<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TransparantPanel1 = New TransparantPanel()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        TransparantPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(122, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(402, 39)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(122, 236)
        TextBox2.MaxLength = 5
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(402, 39)
        TextBox2.TabIndex = 1
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Chartreuse
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(64, 341)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 49)
        Button1.TabIndex = 2
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Chartreuse
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(246, 341)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 49)
        Button2.TabIndex = 3
        Button2.Text = "Daftar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TransparantPanel1
        ' 
        TransparantPanel1.Controls.Add(Label2)
        TransparantPanel1.Controls.Add(Label1)
        TransparantPanel1.Controls.Add(Button3)
        TransparantPanel1.Controls.Add(TextBox1)
        TransparantPanel1.Controls.Add(Button1)
        TransparantPanel1.Controls.Add(Button2)
        TransparantPanel1.Controls.Add(TextBox2)
        TransparantPanel1.Dock = DockStyle.Right
        TransparantPanel1.Location = New Point(432, 0)
        TransparantPanel1.Name = "TransparantPanel1"
        TransparantPanel1.Size = New Size(575, 477)
        TransparantPanel1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(122, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 32)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 32)
        Label1.TabIndex = 5
        Label1.Text = "Username"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Chartreuse
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(422, 341)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 49)
        Button3.TabIndex = 4
        Button3.Text = "Keluar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1007, 477)
        Controls.Add(TransparantPanel1)
        Name = "Login"
        Text = "masuk"
        TransparantPanel1.ResumeLayout(False)
        TransparantPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TransparantPanel1 As TransparantPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
