Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelpb.Location = New Point(labelpb.Left - picpb.Left, labelpb.Top - picpb.Top)
        labelpb.Parent = picpb
        Labelkb.Location = New Point(Labelkb.Left - picpb.Left, Labelkb.Top - picpb.Top)
        Labelkb.Parent = picpb
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btncart1_Click(sender As Object, e As EventArgs) Handles btncart1.Click
        triggerkeeb = "1"
    End Sub

    Private Sub btncart2_Click(sender As Object, e As EventArgs) Handles btncart2.Click
        triggerkeeb = "2"
    End Sub

    Private Sub btncart3_Click(sender As Object, e As EventArgs) Handles btncart3.Click
        triggerkeeb = "3"
    End Sub
End Class