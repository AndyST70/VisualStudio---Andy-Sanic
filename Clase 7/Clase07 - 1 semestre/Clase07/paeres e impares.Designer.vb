<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paeres_e_impares
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
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        Button5 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Linen
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(54, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(445, 221)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(153, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 59)
        Button1.TabIndex = 7
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(270, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 6
        Label2.Text = "Suma impares"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 5
        Label1.Text = "Suma pares"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(270, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(35, 62)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(132, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(-121, -249)
        Button3.Name = "Button3"
        Button3.Size = New Size(214, 48)
        Button3.TabIndex = 2
        Button3.Text = "Pares e impares"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(529, 47)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 58)
        Button2.TabIndex = 3
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Linen
        GroupBox2.Controls.Add(ListBox2)
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Location = New Point(54, 269)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(445, 262)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(243, 46)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(76, 164)
        ListBox2.TabIndex = 8
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(91, 46)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(76, 164)
        ListBox1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 6
        Label3.Text = " impares"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(91, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 5
        Label4.Text = " pares"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(-121, -249)
        Button5.Name = "Button5"
        Button5.Size = New Size(214, 48)
        Button5.TabIndex = 2
        Button5.Text = "Pares e impares"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' paeres_e_impares
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(669, 533)
        Controls.Add(GroupBox2)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Name = "paeres_e_impares"
        Text = "paeres_e_impares"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
End Class
