Public Class TransparantPanel
    Inherits Panel
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20  ' WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)

    End Sub
End Class
