<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DimGray
        Button1.Location = New Point(12, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 50)
        Button1.TabIndex = 0
        Button1.Text = "BERANDA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DimGray
        Button2.Location = New Point(12, 195)
        Button2.Name = "Button2"
        Button2.Size = New Size(196, 47)
        Button2.TabIndex = 1
        Button2.Text = "KELOLA DATA"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(222, 492)
        Panel1.TabIndex = 2
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.DimGray
        Button5.Location = New Point(12, 269)
        Button5.Name = "Button5"
        Button5.Size = New Size(196, 50)
        Button5.TabIndex = 4
        Button5.Text = "LAPORAN"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Firebrick
        Button4.Location = New Point(12, 345)
        Button4.Name = "Button4"
        Button4.Size = New Size(196, 50)
        Button4.TabIndex = 3
        Button4.Text = "KEMBALI"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.DimGray
        Button3.Location = New Point(12, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(196, 75)
        Button3.TabIndex = 2
        Button3.Text = "TAMPILAN DATA"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(222, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(938, 492)
        Panel3.TabIndex = 4
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 492)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "menu"
        Text = "Menu Utama"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
End Class
