<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restaurante
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
        GroupBox1 = New GroupBox()
        CheckBox4 = New CheckBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        ResultsLabel = New Label()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        ListBox4 = New ListBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ListBox5 = New ListBox()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(48, 122)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(390, 216)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.CheckAlign = ContentAlignment.MiddleRight
        CheckBox4.Location = New Point(63, 137)
        CheckBox4.Margin = New Padding(3, 4, 3, 4)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(88, 24)
        CheckBox4.TabIndex = 9
        CheckBox4.Text = "Refresco"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(248, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 8
        Label3.Text = "Pago"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Efectivo", "Transferencia", "T Debito", "T Credito"})
        ComboBox1.Location = New Point(248, 70)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(122, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.CheckAlign = ContentAlignment.MiddleRight
        CheckBox3.Location = New Point(27, 105)
        CheckBox3.Margin = New Padding(3, 4, 3, 4)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(124, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Hamburguesa"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.CheckAlign = ContentAlignment.MiddleRight
        CheckBox2.Location = New Point(55, 72)
        CheckBox2.Margin = New Padding(3, 4, 3, 4)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(96, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Pollo frito"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.CheckAlign = ContentAlignment.MiddleRight
        CheckBox1.Location = New Point(86, 40)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(65, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Pizza"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 19.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HighlightText
        Label1.Location = New Point(168, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 44)
        Label1.TabIndex = 1
        Label1.Text = "Restaurante la bendicion"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(48, 366)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(229, 79)
        Button1.TabIndex = 2
        Button1.Text = "Pagar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(470, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 32)
        Label2.TabIndex = 3
        Label2.Text = "Factura"
        ' 
        ' ResultsLabel
        ' 
        ResultsLabel.AutoSize = True
        ResultsLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResultsLabel.ForeColor = Color.White
        ResultsLabel.Location = New Point(471, 208)
        ResultsLabel.Name = "ResultsLabel"
        ResultsLabel.Size = New Size(89, 25)
        ResultsLabel.TabIndex = 4
        ResultsLabel.Text = "Loading"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(48, 530)
        ListBox2.Margin = New Padding(3, 4, 3, 4)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(85, 224)
        ListBox2.TabIndex = 7
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.Location = New Point(158, 530)
        ListBox3.Margin = New Padding(3, 4, 3, 4)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(85, 224)
        ListBox3.TabIndex = 8
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.Location = New Point(267, 530)
        ListBox4.Margin = New Padding(3, 4, 3, 4)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(85, 224)
        ListBox4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(43, 480)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 25)
        Label5.TabIndex = 11
        Label5.Text = "Subtotal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(153, 480)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 25)
        Label6.TabIndex = 12
        Label6.Text = "Desc"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(262, 480)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 25)
        Label7.TabIndex = 13
        Label7.Text = "Recarg"
        ' 
        ' ListBox5
        ' 
        ListBox5.FormattingEnabled = True
        ListBox5.Location = New Point(373, 530)
        ListBox5.Margin = New Padding(3, 4, 3, 4)
        ListBox5.Name = "ListBox5"
        ListBox5.Size = New Size(162, 224)
        ListBox5.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(369, 480)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 25)
        Label8.TabIndex = 15
        Label8.Text = "Total"
        ' 
        ' restaurante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(642, 831)
        Controls.Add(Label8)
        Controls.Add(ListBox5)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ListBox4)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ResultsLabel)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.MenuHighlight
        Margin = New Padding(3, 4, 3, 4)
        Name = "restaurante"
        Text = "restaurante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label8 As Label
End Class
