<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edades
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        CargaVectoresToolStripMenuItem = New ToolStripMenuItem()
        LimpiarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MistyRose
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Location = New Point(26, 63)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(552, 208)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 2
        Label1.Text = "Promedio"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(161, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(161, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(235, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(598, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 45)
        Button1.TabIndex = 2
        Button1.Text = "Volver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CargaVectoresToolStripMenuItem, LimpiarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(696, 28)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CargaVectoresToolStripMenuItem
        ' 
        CargaVectoresToolStripMenuItem.Name = "CargaVectoresToolStripMenuItem"
        CargaVectoresToolStripMenuItem.Size = New Size(121, 24)
        CargaVectoresToolStripMenuItem.Text = "Carga vectores"
        ' 
        ' LimpiarToolStripMenuItem
        ' 
        LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        LimpiarToolStripMenuItem.Size = New Size(73, 24)
        LimpiarToolStripMenuItem.Text = "Limpiar"
        ' 
        ' edades
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(696, 313)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "edades"
        Text = "edades"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CargaVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
