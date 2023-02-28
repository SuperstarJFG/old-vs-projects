Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Move()
            Case Keys.Down
            Case Keys.Left
            Case Keys.Right
        End Select
    End Sub
    Sub move()

    End Sub
End Class
