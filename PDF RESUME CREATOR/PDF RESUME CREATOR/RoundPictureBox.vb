Imports System.Drawing.Drawing2D

Public Class RoundPictureBox
    Inherits PictureBox

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim G As GraphicsPath = New GraphicsPath()
        G.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(G)
    End Sub
End Class
