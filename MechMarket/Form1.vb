Imports System.Windows.Forms
Public Class Form1
    Public keeb1 As Integer = 6500, keeb2 As Integer = 27000, keeb3 As Integer = 2105
    Public kit1 As Integer = 6238, kit2 As Integer = 2300, kit3 As Integer = 8527
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
        'form2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        ' Form2.ControlBox = False
        'switchpanel(form2)
        'Sub switchpanel(ByVal panel As Form)
        '   Panel1.Controls.Clear()
        '  panel.TopLevel = False
        ' Panel1.Controls.Add(panel)
        'panel.Visible = True
        'End Sub


        Dim form2 As New Form2(Me) ' Pass the instance of Form1 to Form2
        form2.Show()
        Me.Hide() ' Hide Form1 while Form2 is open
    End Sub

    Private Sub pickit_Click(sender As Object, e As EventArgs) Handles pickit.Click
        Dim form3 As New Form3(Me)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub picswitch_Click(sender As Object, e As EventArgs) Handles picswitch.Click

    End Sub

    Private Sub piccap_Click(sender As Object, e As EventArgs) Handles piccap.Click

    End Sub

End Class
