Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelswitch.Location = New Point(labelswitch.Left - picswitch.Left, labelswitch.Top - picswitch.Top)
        labelswitch.Parent = picswitch
    End Sub
End Class