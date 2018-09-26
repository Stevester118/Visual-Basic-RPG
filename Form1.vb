Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim board As Integer(,) = {{1, 1, 1, 1, 1}, _
                                   {1, 0, 0, 0, 1}, _
                                   {1, 0, 2, 0, 1}, _
                                   {1, 1, 1, 1, 1}}
        Game1.GameBoard = board
    End Sub
End Class
