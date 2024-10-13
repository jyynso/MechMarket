Imports System.Windows.Forms
Public Class Form1
    ' name ng product para icall
    Public keebname1 As String = "WOB Rainy75", keebname2 = "Kibou Suisei65", keebname3 = "RK R65"
    ' Prices sa Keeb
    'Public Property keebpr1 As Integer = 6500, keebpr2 = 27000, keebpr3 = 2105
    'Public Property kitpr As Integer = 6238, kitpr2 = 2300, kitpr3 = 8527
    'Public Property switchpr1 As Integer = 3500, switchpr2 = 4000, switchpr3 = 1030
    'Public Property cappr1 As Integer = 500, cappr2 = 4500, cappr3 = 6200
    ' hola

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting parent para transparent sa picboxtitle
        labeltitle.Location = New Point(labeltitle.Left - picboxtitle.Left, labeltitle.Top - picboxtitle.Top)
        labeltitle.Parent = picboxtitle
        labelcart.Location = New Point(labelcart.Left - picboxtitle.Left, labelcart.Top - picboxtitle.Top)
        labelcart.Parent = picboxtitle
        label01.Location = New Point(label01.Left - picboxtitle.Left, label01.Top - picboxtitle.Top)
        label01.Parent = picboxtitle
    End Sub

    Public Sub picpb_Click(sender As Object, e As EventArgs) Handles picpb.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub pickit_Click(sender As Object, e As EventArgs) Handles pickit.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub picswitch_Click(sender As Object, e As EventArgs) Handles picswitch.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub piccap_Click(sender As Object, e As EventArgs) Handles piccap.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub labelcart_Click(sender As Object, e As EventArgs) Handles labelcart.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class
