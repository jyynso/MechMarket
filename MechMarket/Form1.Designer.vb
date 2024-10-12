<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        labelcart = New Label()
        labelcap = New Label()
        labelswitch = New Label()
        labelkit = New Label()
        labelpb = New Label()
        piccap = New PictureBox()
        picswitch = New PictureBox()
        pickit = New PictureBox()
        picpb = New PictureBox()
        Label1 = New Label()
        label01 = New Label()
        labeltitle = New Label()
        picboxtitle = New PictureBox()
        Panel1.SuspendLayout()
        CType(piccap, ComponentModel.ISupportInitialize).BeginInit()
        CType(picswitch, ComponentModel.ISupportInitialize).BeginInit()
        CType(pickit, ComponentModel.ISupportInitialize).BeginInit()
        CType(picpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxtitle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(labelcart)
        Panel1.Controls.Add(labelcap)
        Panel1.Controls.Add(labelswitch)
        Panel1.Controls.Add(labelkit)
        Panel1.Controls.Add(labelpb)
        Panel1.Controls.Add(piccap)
        Panel1.Controls.Add(picswitch)
        Panel1.Controls.Add(pickit)
        Panel1.Controls.Add(picpb)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(label01)
        Panel1.Controls.Add(labeltitle)
        Panel1.Controls.Add(picboxtitle)
        Panel1.Dock = DockStyle.Fill
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(680, 837)
        Panel1.TabIndex = 0
        ' 
        ' labelcart
        ' 
        labelcart.AutoSize = True
        labelcart.BackColor = Color.Transparent
        labelcart.Font = New Font("Montserrat Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcart.Location = New Point(559, 251)
        labelcart.Name = "labelcart"
        labelcart.Size = New Size(86, 41)
        labelcart.TabIndex = 13
        labelcart.Text = "Cart"
        ' 
        ' labelcap
        ' 
        labelcap.AutoSize = True
        labelcap.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        labelcap.Font = New Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcap.Location = New Point(491, 630)
        labelcap.Name = "labelcap"
        labelcap.Size = New Size(142, 39)
        labelcap.TabIndex = 12
        labelcap.Text = "Keycaps"
        ' 
        ' labelswitch
        ' 
        labelswitch.AutoSize = True
        labelswitch.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        labelswitch.Font = New Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelswitch.Location = New Point(147, 630)
        labelswitch.Name = "labelswitch"
        labelswitch.Size = New Size(152, 39)
        labelswitch.TabIndex = 11
        labelswitch.Text = "Switches"
        ' 
        ' labelkit
        ' 
        labelkit.AutoSize = True
        labelkit.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        labelkit.Font = New Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelkit.Location = New Point(569, 395)
        labelkit.Name = "labelkit"
        labelkit.Size = New Size(60, 39)
        labelkit.TabIndex = 10
        labelkit.Text = "Kit"
        ' 
        ' labelpb
        ' 
        labelpb.AutoSize = True
        labelpb.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(23))
        labelpb.Font = New Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelpb.Location = New Point(161, 395)
        labelpb.Name = "labelpb"
        labelpb.Size = New Size(138, 39)
        labelpb.TabIndex = 9
        labelpb.Text = "Prebuilt"
        ' 
        ' piccap
        ' 
        piccap.BackgroundImage = CType(resources.GetObject("piccap.BackgroundImage"), Image)
        piccap.Image = CType(resources.GetObject("piccap.Image"), Image)
        piccap.Location = New Point(372, 617)
        piccap.Name = "piccap"
        piccap.Size = New Size(273, 189)
        piccap.SizeMode = PictureBoxSizeMode.CenterImage
        piccap.TabIndex = 8
        piccap.TabStop = False
        ' 
        ' picswitch
        ' 
        picswitch.BackgroundImage = CType(resources.GetObject("picswitch.BackgroundImage"), Image)
        picswitch.Image = CType(resources.GetObject("picswitch.Image"), Image)
        picswitch.Location = New Point(38, 617)
        picswitch.Name = "picswitch"
        picswitch.Size = New Size(273, 189)
        picswitch.SizeMode = PictureBoxSizeMode.CenterImage
        picswitch.TabIndex = 7
        picswitch.TabStop = False
        ' 
        ' pickit
        ' 
        pickit.BackgroundImage = CType(resources.GetObject("pickit.BackgroundImage"), Image)
        pickit.Image = CType(resources.GetObject("pickit.Image"), Image)
        pickit.Location = New Point(372, 383)
        pickit.Name = "pickit"
        pickit.Size = New Size(273, 189)
        pickit.SizeMode = PictureBoxSizeMode.StretchImage
        pickit.TabIndex = 6
        pickit.TabStop = False
        ' 
        ' picpb
        ' 
        picpb.BackgroundImage = CType(resources.GetObject("picpb.BackgroundImage"), Image)
        picpb.Location = New Point(38, 383)
        picpb.Name = "picpb"
        picpb.Size = New Size(273, 189)
        picpb.SizeMode = PictureBoxSizeMode.CenterImage
        picpb.TabIndex = 5
        picpb.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(38, 326)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 41)
        Label1.TabIndex = 4
        Label1.Text = "Explore"
        ' 
        ' label01
        ' 
        label01.AutoSize = True
        label01.BackColor = Color.Transparent
        label01.Font = New Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label01.ForeColor = Color.White
        label01.Location = New Point(24, 142)
        label01.Name = "label01"
        label01.Size = New Size(580, 32)
        label01.TabIndex = 3
        label01.Text = "The number 1 place for mechanical keyboard kits"
        ' 
        ' labeltitle
        ' 
        labeltitle.AutoSize = True
        labeltitle.BackColor = Color.Transparent
        labeltitle.FlatStyle = FlatStyle.Flat
        labeltitle.Font = New Font("Montserrat", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labeltitle.ForeColor = Color.White
        labeltitle.Location = New Point(3, 31)
        labeltitle.Name = "labeltitle"
        labeltitle.Size = New Size(570, 111)
        labeltitle.TabIndex = 2
        labeltitle.Text = "MechMarket"
        ' 
        ' picboxtitle
        ' 
        picboxtitle.Image = CType(resources.GetObject("picboxtitle.Image"), Image)
        picboxtitle.Location = New Point(0, 0)
        picboxtitle.Name = "picboxtitle"
        picboxtitle.Size = New Size(679, 311)
        picboxtitle.SizeMode = PictureBoxSizeMode.CenterImage
        picboxtitle.TabIndex = 0
        picboxtitle.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(680, 837)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "The MechMarket"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(piccap, ComponentModel.ISupportInitialize).EndInit()
        CType(picswitch, ComponentModel.ISupportInitialize).EndInit()
        CType(pickit, ComponentModel.ISupportInitialize).EndInit()
        CType(picpb, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxtitle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labeltitle As Label
    Friend WithEvents picboxtitle As PictureBox
    Friend WithEvents label01 As Label
    Friend WithEvents picpb As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents piccap As PictureBox
    Friend WithEvents picswitch As PictureBox
    Friend WithEvents pickit As PictureBox
    Friend WithEvents labelpb As Label
    Friend WithEvents labelcap As Label
    Friend WithEvents labelswitch As Label
    Friend WithEvents labelkit As Label
    Friend WithEvents labelcart As Label

End Class
