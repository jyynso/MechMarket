Imports System.Windows.Forms
Public Class Form1
    Public keeb1 As Integer = 6500, keeb2 As Integer = 27000, keeb3 As Integer = 2105
    Public kit1 As Integer = 6238, kit2 As Integer = 2300, kit3 As Integer = 8527


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
        form2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        form2.ControlBox = False
        switchpanel(form2)
    End Sub

    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Visible = True
    End Sub

    Private Sub pickit_Click(sender As Object, e As EventArgs) Handles pickit.Click
        Form3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Form3.ControlBox = False
        switchpanel(Form3)
    End Sub

    Private Sub picswitch_Click(sender As Object, e As EventArgs) Handles picswitch.Click
        Form4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Form4.ControlBox = False
        switchpanel(Form4)
    End Sub

    Private Sub piccap_Click(sender As Object, e As EventArgs) Handles piccap.Click
        Form5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Form5.ControlBox = False
        switchpanel(Form5)
    End Sub
End Class
