<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrada
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
        Label3 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 31)
        Label1.TabIndex = 0
        Label1.Text = "Guerrero"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(130, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 29)
        Label3.TabIndex = 8
        Label3.Text = "Ingreso de tienda"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(159, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 31)
        TextBox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Location = New Point(159, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 29)
        Button1.TabIndex = 10
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' entrada
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(465, 157)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "entrada"
        Text = "entrada"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
