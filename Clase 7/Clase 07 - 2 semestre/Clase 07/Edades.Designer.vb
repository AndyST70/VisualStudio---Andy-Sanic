<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edades
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
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        CargarVectoresToolStripMenuItem = New ToolStripMenuItem()
        LimpiarToolStripMenuItem = New ToolStripMenuItem()
        VolverToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.HighlightText
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(47, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(681, 170)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(232, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 27)
        TextBox1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(232, 29)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(256, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 2
        Label1.Text = "Promedio"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CargarVectoresToolStripMenuItem, LimpiarToolStripMenuItem, VolverToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(782, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CargarVectoresToolStripMenuItem
        ' 
        CargarVectoresToolStripMenuItem.Name = "CargarVectoresToolStripMenuItem"
        CargarVectoresToolStripMenuItem.Size = New Size(126, 24)
        CargarVectoresToolStripMenuItem.Text = "Cargar vectores"
        ' 
        ' LimpiarToolStripMenuItem
        ' 
        LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        LimpiarToolStripMenuItem.Size = New Size(73, 24)
        LimpiarToolStripMenuItem.Text = "Limpiar"
        ' 
        ' VolverToolStripMenuItem
        ' 
        VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        VolverToolStripMenuItem.Size = New Size(64, 24)
        VolverToolStripMenuItem.Text = "Volver"
        ' 
        ' Edades
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(782, 244)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Edades"
        Text = "Edades"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CargarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
End Class
