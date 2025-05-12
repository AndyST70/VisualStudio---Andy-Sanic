<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        ListBox4 = New ListBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        GroupBox1 = New GroupBox()
        Label11 = New Label()
        Label10 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        ListBox5 = New ListBox()
        Label9 = New Label()
        Button2 = New Button()
        Label12 = New Label()
        ListBox6 = New ListBox()
        Label13 = New Label()
        Label14 = New Label()
        ListBox7 = New ListBox()
        ListBox8 = New ListBox()
        ListBox9 = New ListBox()
        Label15 = New Label()
        Button3 = New Button()
        ListBox10 = New ListBox()
        Label16 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        ComboBox1.Location = New Point(138, 30)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 1
        Label1.Text = "Turno"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Efectivo", "Cheque", "T_Debito", "T_Credito"})
        ComboBox2.Location = New Point(138, 101)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 3
        Label2.Text = "Pago"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(138, 178)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 5
        Label3.Text = "Nombre"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(58, 322)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(73, 204)
        ListBox1.TabIndex = 7
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(146, 322)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(73, 204)
        ListBox2.TabIndex = 8
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.Location = New Point(236, 322)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(73, 204)
        ListBox3.TabIndex = 9
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.Location = New Point(332, 322)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(76, 204)
        ListBox4.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(146, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 20)
        Label4.TabIndex = 11
        Label4.Text = "Turno"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(236, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 12
        Label5.Text = "Pago"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(58, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 13
        Label6.Text = "Nombre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(898, 288)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 14
        Label7.Text = "Total Pago"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(52, 227)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(61, 24)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "IGSS"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(165, 227)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(53, 24)
        CheckBox2.TabIndex = 16
        CheckBox2.Text = "IVA"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(42, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(587, 257)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(347, 96)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 20)
        Label11.TabIndex = 24
        Label11.Text = "Tarifa"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(304, 30)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 23
        Label10.Text = "horas extras"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(406, 89)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(167, 27)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(406, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(167, 27)
        TextBox2.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(319, 149)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 20)
        Label8.TabIndex = 20
        Label8.Text = "Fecha"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(319, 181)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(649, 92)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 44)
        Button1.TabIndex = 18
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox5
        ' 
        ListBox5.FormattingEnabled = True
        ListBox5.Location = New Point(426, 322)
        ListBox5.Name = "ListBox5"
        ListBox5.Size = New Size(79, 204)
        ListBox5.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(332, 288)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 20)
        Label9.TabIndex = 19
        Label9.Text = "Fecha"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(649, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 48)
        Button2.TabIndex = 21
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(426, 288)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 20)
        Label12.TabIndex = 22
        Label12.Text = "pago parcial"
        ' 
        ' ListBox6
        ' 
        ListBox6.FormattingEnabled = True
        ListBox6.Location = New Point(523, 322)
        ListBox6.Name = "ListBox6"
        ListBox6.Size = New Size(79, 204)
        ListBox6.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(525, 288)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 20)
        Label13.TabIndex = 24
        Label13.Text = "descuento"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(618, 288)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 20)
        Label14.TabIndex = 25
        Label14.Text = "bonus"
        ' 
        ' ListBox7
        ' 
        ListBox7.FormattingEnabled = True
        ListBox7.Location = New Point(618, 322)
        ListBox7.Name = "ListBox7"
        ListBox7.Size = New Size(79, 204)
        ListBox7.TabIndex = 26
        ' 
        ' ListBox8
        ' 
        ListBox8.FormattingEnabled = True
        ListBox8.Location = New Point(706, 322)
        ListBox8.Name = "ListBox8"
        ListBox8.Size = New Size(79, 204)
        ListBox8.TabIndex = 27
        ' 
        ' ListBox9
        ' 
        ListBox9.FormattingEnabled = True
        ListBox9.Location = New Point(800, 322)
        ListBox9.Name = "ListBox9"
        ListBox9.Size = New Size(69, 204)
        ListBox9.TabIndex = 28
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(705, 288)
        Label15.Name = "Label15"
        Label15.Size = New Size(80, 20)
        Label15.TabIndex = 29
        Label15.Text = "Deduccion"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(660, 213)
        Button3.Name = "Button3"
        Button3.Size = New Size(145, 37)
        Button3.TabIndex = 30
        Button3.Text = "Salir" & vbCrLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ListBox10
        ' 
        ListBox10.FormattingEnabled = True
        ListBox10.Location = New Point(901, 322)
        ListBox10.Name = "ListBox10"
        ListBox10.Size = New Size(76, 204)
        ListBox10.TabIndex = 31
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(809, 288)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 20)
        Label16.TabIndex = 32
        Label16.Text = "recargo"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 553)
        Controls.Add(Label16)
        Controls.Add(ListBox10)
        Controls.Add(Button3)
        Controls.Add(Label15)
        Controls.Add(ListBox9)
        Controls.Add(ListBox8)
        Controls.Add(ListBox7)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(ListBox6)
        Controls.Add(Label12)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(ListBox5)
        Controls.Add(GroupBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ListBox4)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox10 As ListBox
    Friend WithEvents Label16 As Label
End Class
