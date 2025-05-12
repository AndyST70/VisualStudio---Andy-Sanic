<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mayor
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
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        TextBox2 = New TextBox()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        CalcularToolStripMenuItem = New ToolStripMenuItem()
        LimpiarToolStripMenuItem = New ToolStripMenuItem()
        LimpiarlistboxToolStripMenuItem = New ToolStripMenuItem()
        LimpiarDatosEntradaToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MistyRose
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(45, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(406, 139)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 78)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 44)
        Button1.TabIndex = 3
        Button1.Text = "Comparar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(215, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(215, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(48, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 44)
        Button2.TabIndex = 0
        Button2.Text = "Agregar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MistyRose
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(ListBox2)
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Location = New Point(45, 199)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(705, 239)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(360, 63)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(295, 131)
        TextBox2.TabIndex = 3
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(195, 49)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(136, 184)
        ListBox2.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(37, 49)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(136, 184)
        ListBox1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(514, 59)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 79)
        Button3.TabIndex = 5
        Button3.Text = "Volver"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CalcularToolStripMenuItem, LimpiarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CalcularToolStripMenuItem
        ' 
        CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        CalcularToolStripMenuItem.Size = New Size(76, 24)
        CalcularToolStripMenuItem.Text = "Calcular"
        ' 
        ' LimpiarToolStripMenuItem
        ' 
        LimpiarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LimpiarlistboxToolStripMenuItem, LimpiarDatosEntradaToolStripMenuItem})
        LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        LimpiarToolStripMenuItem.Size = New Size(73, 24)
        LimpiarToolStripMenuItem.Text = "Limpiar"
        ' 
        ' LimpiarlistboxToolStripMenuItem
        ' 
        LimpiarlistboxToolStripMenuItem.Name = "LimpiarlistboxToolStripMenuItem"
        LimpiarlistboxToolStripMenuItem.Size = New Size(238, 26)
        LimpiarlistboxToolStripMenuItem.Text = "Limpiarlistbox"
        ' 
        ' LimpiarDatosEntradaToolStripMenuItem
        ' 
        LimpiarDatosEntradaToolStripMenuItem.Name = "LimpiarDatosEntradaToolStripMenuItem"
        LimpiarDatosEntradaToolStripMenuItem.Size = New Size(238, 26)
        LimpiarDatosEntradaToolStripMenuItem.Text = "Limpiar datos entrada"
        ' 
        ' mayor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "mayor"
        Text = "mayor"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarlistboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDatosEntradaToolStripMenuItem As ToolStripMenuItem
End Class
