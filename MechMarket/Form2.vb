Public Class Form2
    Public _form1 As Form1

    Public Sub New(form1 As Form1)
        InitializeComponent()
        _form1 = form1

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelpb.Location = New Point(labelpb.Left - picpb.Left, labelpb.Top - picpb.Top)
        labelpb.Parent = picpb
        Labelkb.Location = New Point(Labelkb.Left - picpb.Left, Labelkb.Top - picpb.Top)
        Labelkb.Parent = picpb

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _form1.Show()
        Me.Close()

    End Sub
End Class