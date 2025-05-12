<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(79, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 29)
        Button1.TabIndex = 0
        Button1.Text = "Metodo 1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(79, 89)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 39)
        Button2.TabIndex = 1
        Button2.Text = "Funcion"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(79, 163)
        Button3.Name = "Button3"
        Button3.Size = New Size(159, 46)
        Button3.TabIndex = 2
        Button3.Text = "Combobox"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 38)
        Label1.TabIndex = 3
        Label1.Text = "CALCULADORA"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(79, 298)
        Button4.Name = "Button4"
        Button4.Size = New Size(164, 44)
        Button4.TabIndex = 4
        Button4.Text = "Ir"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(85, 381)
        Button5.Name = "Button5"
        Button5.Size = New Size(153, 66)
        Button5.TabIndex = 5
        Button5.Text = "Restaurante"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(305, 580)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
