<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pares_impares
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
        Button2 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ListBox2)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(37, 17)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(717, 467)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(525, 397)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 47)
        Button2.TabIndex = 7
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(444, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 6
        Label2.Text = "Impares"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 5
        Label1.Text = "Pares"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(444, 150)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(174, 224)
        ListBox2.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(85, 150)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(174, 224)
        ListBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(285, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 42)
        Button1.TabIndex = 2
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(417, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(85, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(215, 27)
        TextBox1.TabIndex = 0
        ' 
        ' pares_impares
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(766, 496)
        Controls.Add(GroupBox1)
        Name = "pares_impares"
        Text = "pares_impares"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
