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
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox3 = New GroupBox()
        Checkarmadura = New CheckBox()
        Checkpantalones = New CheckBox()
        Checkguantes = New CheckBox()
        GroupBox4 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Button1 = New Button()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(186, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 29)
        Label3.TabIndex = 7
        Label3.Text = "Tienda Lagot"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLightLight
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(29, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(161, 153)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Eleccion arma"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        RadioButton3.Location = New Point(27, 94)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(93, 29)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Espada"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        RadioButton2.Location = New Point(27, 64)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(73, 29)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Arco"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        RadioButton1.Location = New Point(27, 34)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(82, 29)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "Lanza"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 28)
        Label2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlText
        Label1.Font = New Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(401, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 23)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido : "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ControlLightLight
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Location = New Point(211, 83)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(105, 153)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pago"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        RadioButton5.Location = New Point(22, 78)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(77, 32)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Plata"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        RadioButton4.Location = New Point(22, 49)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(67, 32)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Oro"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ControlLightLight
        GroupBox3.Controls.Add(Checkarmadura)
        GroupBox3.Controls.Add(Checkpantalones)
        GroupBox3.Controls.Add(Checkguantes)
        GroupBox3.Location = New Point(349, 83)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(147, 133)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Conjunto"
        ' 
        ' Checkarmadura
        ' 
        Checkarmadura.AutoSize = True
        Checkarmadura.Location = New Point(22, 94)
        Checkarmadura.Name = "Checkarmadura"
        Checkarmadura.Size = New Size(97, 24)
        Checkarmadura.TabIndex = 2
        Checkarmadura.Text = "Armadura"
        Checkarmadura.UseVisualStyleBackColor = True
        ' 
        ' Checkpantalones
        ' 
        Checkpantalones.AutoSize = True
        Checkpantalones.Location = New Point(22, 64)
        Checkpantalones.Name = "Checkpantalones"
        Checkpantalones.Size = New Size(102, 24)
        Checkpantalones.TabIndex = 1
        Checkpantalones.Text = "Pantalones"
        Checkpantalones.UseVisualStyleBackColor = True
        ' 
        ' Checkguantes
        ' 
        Checkguantes.AutoSize = True
        Checkguantes.Location = New Point(22, 34)
        Checkguantes.Name = "Checkguantes"
        Checkguantes.Size = New Size(84, 24)
        Checkguantes.TabIndex = 0
        Checkguantes.Text = "Guantes"
        Checkguantes.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ButtonShadow
        GroupBox4.Controls.Add(ListBox1)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(Button1)
        GroupBox4.Controls.Add(GroupBox3)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(GroupBox2)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Controls.Add(GroupBox1)
        GroupBox4.Location = New Point(31, 18)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(940, 423)
        GroupBox4.TabIndex = 11
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(186, 293)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 17
        Button3.Text = "Cerrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 293)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 16
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(662, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 31)
        Label5.TabIndex = 13
        Label5.Text = "Comprar"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Location = New Point(682, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 64)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(531, 218)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(200, 164)
        ListBox1.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(983, 486)
        Controls.Add(GroupBox4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Checkarmadura As CheckBox
    Friend WithEvents Checkpantalones As CheckBox
    Friend WithEvents Checkguantes As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox

End Class
