<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        MenuStrip1 = New MenuStrip()
        CalcularToolStripMenuItem = New ToolStripMenuItem()
        SumaToolStripMenuItem = New ToolStripMenuItem()
        RestaToolStripMenuItem = New ToolStripMenuItem()
        VolverToolStripMenuItem = New ToolStripMenuItem()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.SeaShell
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(36, 47)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(655, 366)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(467, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 4
        Label3.Text = "Result"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(414, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 31)
        Label2.TabIndex = 3
        Label2.Text = "="
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(192, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 31)
        Label1.TabIndex = 2
        Label1.Text = "+"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(27, 66)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(237, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(157, 27)
        TextBox1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CalcularToolStripMenuItem, VolverToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CalcularToolStripMenuItem
        ' 
        CalcularToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SumaToolStripMenuItem, RestaToolStripMenuItem})
        CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        CalcularToolStripMenuItem.Size = New Size(76, 24)
        CalcularToolStripMenuItem.Text = "Calcular"
        ' 
        ' SumaToolStripMenuItem
        ' 
        SumaToolStripMenuItem.Name = "SumaToolStripMenuItem"
        SumaToolStripMenuItem.Size = New Size(224, 26)
        SumaToolStripMenuItem.Text = "Suma"
        ' 
        ' RestaToolStripMenuItem
        ' 
        RestaToolStripMenuItem.Name = "RestaToolStripMenuItem"
        RestaToolStripMenuItem.Size = New Size(224, 26)
        RestaToolStripMenuItem.Text = "Resta"
        ' 
        ' VolverToolStripMenuItem
        ' 
        VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        VolverToolStripMenuItem.Size = New Size(64, 24)
        VolverToolStripMenuItem.Text = "Volver"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(467, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 9
        Label4.Text = "Result"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(414, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 31)
        Label5.TabIndex = 8
        Label5.Text = "="
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(192, 162)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 31)
        Label6.TabIndex = 7
        Label6.Text = "-"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(27, 162)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(237, 162)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(157, 27)
        TextBox4.TabIndex = 5
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrange
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Form3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
