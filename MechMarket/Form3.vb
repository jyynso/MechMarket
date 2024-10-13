Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelkit.Location = New Point(labelkit.Left - pickit.Left, labelkit.Top - pickit.Top)
        labelkit.Parent = pickit
        labelkit2.Location = New Point(labelkit2.Left - pickit.Left, labelkit2.Top - pickit.Top)
        labelkit2.Parent = pickit

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btncart1_Click(sender As Object, e As EventArgs) Handles btncart1.Click
        triggerkit = "1"
    End Sub

    Private Sub btncart2_Click(sender As Object, e As EventArgs) Handles btncart2.Click
        triggerkit = "2"
    End Sub
    Private Sub btncart3_Click(sender As Object, e As EventArgs) Handles btncart3.Click
        triggerkit = "3"
    End Sub
End Class