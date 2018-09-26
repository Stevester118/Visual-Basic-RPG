Public Class Game
    Private gb As Integer(,) = {}
    Public Property GameBoard As Integer(,)
        Get
            Return gb
        End Get
        Set(value As Integer(,))
            gb = value
            Refresh()
        End Set
    End Property


    Private Sub Game_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Game_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'the paint event is when the control is drawn
        'you use the graphics class here to draw things on here
        e.Graphics.FillRectangle(Brushes.White, New Rectangle(0, 0, Me.Width, Me.Height))
        If GameBoard.GetUpperBound(0) >= 0 And GameBoard.GetUpperBound(1) >= 0 Then
            For x = 0 To GameBoard.GetUpperBound(0)
                For y = 0 To GameBoard.GetUpperBound(1)
                    If GameBoard(x, y) = 1 Then
                        e.Graphics.DrawImage(My.Resources.Tree1)
                    End If
                Next
            Next
        End If
    End Sub
End Class
