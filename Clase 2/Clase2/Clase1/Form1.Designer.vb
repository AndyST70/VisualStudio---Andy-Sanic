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
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox2 = New GroupBox()
        txtdescuento = New TextBox()
        ltotal = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Linen
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(21, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(377, 243)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pizzas"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(107, 196)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(190, 32)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Cliente frecuente"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(221, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 28)
        Label4.TabIndex = 6
        Label4.Text = "Cantidad"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(221, 147)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(92, 34)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(221, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(92, 34)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(221, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(92, 34)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 28)
        Label3.TabIndex = 2
        Label3.Text = "Pizza de Jamon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 28)
        Label2.TabIndex = 1
        Label2.Text = "Pizza de Peperoni"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 28)
        Label1.TabIndex = 0
        Label1.Text = "Pizza Hawaina"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Chartreuse
        Button1.Font = New Font("Segoe Print", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(448, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 43)
        Button1.TabIndex = 1
        Button1.Text = "Limpiar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe Print", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(448, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 38)
        Button2.TabIndex = 2
        Button2.Text = "Cerrar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LemonChiffon
        Button3.Font = New Font("Segoe Print", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(448, 150)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 34)
        Button3.TabIndex = 3
        Button3.Text = "Calcular"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Linen
        GroupBox2.Controls.Add(txtdescuento)
        GroupBox2.Controls.Add(ltotal)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(422, 261)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(255, 144)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' txtdescuento
        ' 
        txtdescuento.Enabled = False
        txtdescuento.Location = New Point(118, 87)
        txtdescuento.Name = "txtdescuento"
        txtdescuento.Size = New Size(116, 27)
        txtdescuento.TabIndex = 4
        ' 
        ' ltotal
        ' 
        ltotal.AutoSize = True
        ltotal.Location = New Point(120, 60)
        ltotal.Name = "ltotal"
        ltotal.Size = New Size(24, 20)
        ltotal.TabIndex = 3
        ltotal.Text = "L8"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(26, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 2
        Label7.Text = "Descuento"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 1
        Label6.Text = "Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 0
        Label5.Text = "RESULTADOS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrange
        ClientSize = New Size(731, 427)
        Controls.Add(GroupBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents ltotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox

End Class
