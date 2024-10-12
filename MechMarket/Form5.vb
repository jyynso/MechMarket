Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelswitch.Location = New Point(labelswitch.Left - picswitch.Left, labelswitch.Top - picswitch.Top)
        labelswitch.Parent = picswitch
    End Sub
End Class