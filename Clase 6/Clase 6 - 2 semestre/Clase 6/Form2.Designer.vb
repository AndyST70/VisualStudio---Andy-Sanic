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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 20)
        Label1.TabIndex = 0
        Label1.Text = "Datos"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"opcion 1", "opcion 2", "opcion 3"})
        ComboBox1.Location = New Point(130, 29)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(216, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(399, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(247, 40)
        Button1.TabIndex = 2
        Button1.Text = "limpieza"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(399, 92)
        Button2.Name = "Button2"
        Button2.Size = New Size(247, 40)
        Button2.TabIndex = 3
        Button2.Text = "Agregar opciones"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(84, 122)
        Button3.Name = "Button3"
        Button3.Size = New Size(247, 40)
        Button3.TabIndex = 4
        Button3.Text = "Volver"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(399, 173)
        Button4.Name = "Button4"
        Button4.Size = New Size(247, 41)
        Button4.TabIndex = 5
        Button4.Text = "Eliminar opcion"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(707, 257)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
