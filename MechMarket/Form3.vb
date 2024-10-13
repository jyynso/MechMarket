
Imports System.Windows

Public Class Form3
    Private _form1 As Form1

    Public Sub New(form1 As Form1)
        InitializeComponent()
        _form1 = form1

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelkit.Location = New Point(labelkit.Left - pickit.Left, labelkit.Top - pickit.Top)
        labelkit.Parent = pickit

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _form1.Show()
        Me.Close()
    End Sub
End Class