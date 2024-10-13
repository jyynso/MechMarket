Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelswitch.Location = New Point(labelswitch.Left - picswitch.Left, labelswitch.Top - picswitch.Top)
        labelswitch.Parent = picswitch
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btncart1_Click(sender As Object, e As EventArgs) Handles btncart1.Click
        triggerswitch = "1"
    End Sub

    Private Sub btncart2_Click(sender As Object, e As EventArgs) Handles btncart2.Click
        triggerswitch = "2"
    End Sub
    Private Sub btncart3_Click(sender As Object, e As EventArgs) Handles btncart3.Click
        triggerswitch = "3"
    End Sub
End Class