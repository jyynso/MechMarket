Imports System.Reflection.Emit

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelkit.Location = New Point(labelkit.Left - pickit.Left, labelkit.Top - pickit.Top)
        labelkit.Parent = pickit

    End Sub
End Class