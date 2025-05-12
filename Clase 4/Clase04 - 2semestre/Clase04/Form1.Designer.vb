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
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox3 = New GroupBox()
        lbl_DESC2 = New Label()
        lbl_DESC1 = New Label()
        lbl_total = New Label()
        lbl_Subtotal = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(559, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(135, 213)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(32, 148)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(69, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Dificil"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(32, 95)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(80, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Normal"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(32, 49)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(59, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Facil"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(53, 32)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(412, 203)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 4
        Label1.Text = "Cant. Personas"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(118, 27)
        TextBox1.TabIndex = 3
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(288, 96)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(98, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Comercial"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(288, 66)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(82, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Pizzeria"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(288, 36)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(84, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Pantano"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveCaption
        GroupBox3.Controls.Add(lbl_DESC2)
        GroupBox3.Controls.Add(lbl_DESC1)
        GroupBox3.Controls.Add(lbl_total)
        GroupBox3.Controls.Add(lbl_Subtotal)
        GroupBox3.Location = New Point(53, 265)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(487, 171)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "RESULTADOS"
        ' 
        ' lbl_DESC2
        ' 
        lbl_DESC2.AutoSize = True
        lbl_DESC2.Location = New Point(272, 90)
        lbl_DESC2.Name = "lbl_DESC2"
        lbl_DESC2.Size = New Size(53, 20)
        lbl_DESC2.TabIndex = 3
        lbl_DESC2.Text = "DESC2"
        ' 
        ' lbl_DESC1
        ' 
        lbl_DESC1.AutoSize = True
        lbl_DESC1.Location = New Point(272, 43)
        lbl_DESC1.Name = "lbl_DESC1"
        lbl_DESC1.Size = New Size(53, 20)
        lbl_DESC1.TabIndex = 2
        lbl_DESC1.Text = "DESC1"
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Location = New Point(70, 90)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(70, 20)
        lbl_total.TabIndex = 1
        lbl_total.Text = "Calculo 2"
        ' 
        ' lbl_Subtotal
        ' 
        lbl_Subtotal.AutoSize = True
        lbl_Subtotal.Location = New Point(70, 43)
        lbl_Subtotal.Name = "lbl_Subtotal"
        lbl_Subtotal.Size = New Size(70, 20)
        lbl_Subtotal.TabIndex = 0
        lbl_Subtotal.Text = "Calculo 1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(566, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(566, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 4
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(566, 380)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 5
        Button3.Text = "Cerrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 482)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_Subtotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lbl_DESC2 As Label
    Friend WithEvents lbl_DESC1 As Label

End Class
