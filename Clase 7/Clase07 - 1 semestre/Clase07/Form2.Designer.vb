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
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        Label3 = New Label()
        Button5 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        LimpiarToolStripMenuItem = New ToolStripMenuItem()
        LimpiarDatosEntradaToolStripMenuItem = New ToolStripMenuItem()
        LimpiarSalidasToolStripMenuItem = New ToolStripMenuItem()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Linen
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ListBox2)
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Location = New Point(52, 272)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(445, 262)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(232, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 9
        Label4.Text = "Mayores"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(232, 73)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(76, 164)
        ListBox2.TabIndex = 8
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(74, 73)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(76, 164)
        ListBox1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 6
        Label3.Text = "Numeros"
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
        ' Button2
        ' 
        Button2.Location = New Point(49, 118)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 58)
        Button2.TabIndex = 10
        Button2.Text = "Calcular"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Linen
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(52, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(735, 221)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(446, 12)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(250, 185)
        TextBox2.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(222, 118)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(38, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 59)
        Button1.TabIndex = 7
        Button1.Text = "iNGRESA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(222, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 6
        Label2.Text = "Digito a ingresar"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(222, 72)
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
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LimpiarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(810, 28)
        MenuStrip1.TabIndex = 12
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LimpiarToolStripMenuItem
        ' 
        LimpiarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LimpiarDatosEntradaToolStripMenuItem, LimpiarSalidasToolStripMenuItem})
        LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        LimpiarToolStripMenuItem.Size = New Size(73, 24)
        LimpiarToolStripMenuItem.Text = "Limpiar"
        ' 
        ' LimpiarDatosEntradaToolStripMenuItem
        ' 
        LimpiarDatosEntradaToolStripMenuItem.Name = "LimpiarDatosEntradaToolStripMenuItem"
        LimpiarDatosEntradaToolStripMenuItem.Size = New Size(238, 26)
        LimpiarDatosEntradaToolStripMenuItem.Text = "Limpiar datos entrada"
        ' 
        ' LimpiarSalidasToolStripMenuItem
        ' 
        LimpiarSalidasToolStripMenuItem.Name = "LimpiarSalidasToolStripMenuItem"
        LimpiarSalidasToolStripMenuItem.Size = New Size(238, 26)
        LimpiarSalidasToolStripMenuItem.Text = "Limpiar salidas"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(810, 597)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDatosEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarSalidasToolStripMenuItem As ToolStripMenuItem
End Class
