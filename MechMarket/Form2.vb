Public Class Form2
    Dim Form1 As Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelpb.Location = New Point(labelpb.Left - picpb.Left, labelpb.Top - picpb.Top)
        labelpb.Parent = picpb

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Form1 = New Form1()
        Form1.Show()
    End Sub
End Class