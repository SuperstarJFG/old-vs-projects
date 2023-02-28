Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = assign.Value
        Dim a(num) As String
        For index = 1 To num
            a(index) = InputBox("Enter Value", "Enter Value", "Please Enter Value")
            If a(index).StartsWith("a") Then
                a(index).Remove(0, 1)
                a(index) *= 0.6
            Else
                a(index).Remove(0, 1)
                a(index) *= 0.2
            End If
            ListBox1.Items.Add(a(index))
        Next
    End Sub
End Class