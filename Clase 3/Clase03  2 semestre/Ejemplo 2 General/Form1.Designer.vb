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
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLightLight
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(CheckBox6)
        GroupBox1.Controls.Add(CheckBox5)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(27, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(731, 223)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos de entrada"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(480, 178)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 11
        Button3.Text = "Cerrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(342, 178)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(198, 178)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 9
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Mayorista", "Regular", "Premium"})
        ComboBox1.Location = New Point(41, 92)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(238, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CheckBox6.Location = New Point(547, 92)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(82, 32)
        CheckBox6.TabIndex = 7
        CheckBox6.Text = "Cloro"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CheckBox5.Location = New Point(547, 62)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(131, 32)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Suavizante"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CheckBox3.Location = New Point(368, 122)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(154, 32)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Limpiavidrios"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CheckBox2.Location = New Point(368, 92)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(159, 32)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Desinfectante"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(413, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 28)
        Label2.TabIndex = 2
        Label2.Text = "Productos Disponibles"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CheckBox1.Location = New Point(368, 62)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(137, 32)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Detergente"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(41, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 28)
        Label1.TabIndex = 0
        Label1.Text = "Tipo cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 1
        Label3.Text = "Calculos : "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(44, 265)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(701, 158)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(513, 37)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 20)
        Label11.TabIndex = 9
        Label11.Text = ".."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(274, 100)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 20)
        Label10.TabIndex = 8
        Label10.Text = ".."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(274, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(15, 20)
        Label9.TabIndex = 7
        Label9.Text = ".."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(274, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(15, 20)
        Label8.TabIndex = 6
        Label8.Text = ".."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(396, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 5
        Label7.Text = "Total a pagar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(155, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 4
        Label6.Text = "Descuento 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(155, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 3
        Label5.Text = "Descuento 1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(181, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 2
        Label4.Text = "Subtotal"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label

End Class
