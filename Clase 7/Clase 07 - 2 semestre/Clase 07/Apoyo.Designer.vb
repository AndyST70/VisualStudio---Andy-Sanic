<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apoyo
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
        MenuStrip1 = New MenuStrip()
        CalcularToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        LimpiarToolStripMenuItem = New ToolStripMenuItem()
        VolverToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        labeltotal = New Label()
        Label4 = New Label()
        GroupBox4 = New GroupBox()
        ListBox4 = New ListBox()
        ListBox3 = New ListBox()
        ListBox2 = New ListBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        LimpiarEntradasToolStripMenuItem = New ToolStripMenuItem()
        LimpiarDataToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CalcularToolStripMenuItem, CerrarToolStripMenuItem, LimpiarToolStripMenuItem, VolverToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(978, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CalcularToolStripMenuItem
        ' 
        CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        CalcularToolStripMenuItem.Size = New Size(76, 24)
        CalcularToolStripMenuItem.Text = "Calcular"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(63, 24)
        CerrarToolStripMenuItem.Text = "Cerrar"
        ' 
        ' LimpiarToolStripMenuItem
        ' 
        LimpiarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LimpiarEntradasToolStripMenuItem, LimpiarDataToolStripMenuItem})
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
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLightLight
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(65, 59)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(441, 192)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Harina", "Azucar", "Mantequilla", "Huevos", "Leche"})
        ComboBox1.Location = New Point(134, 136)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(252, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(134, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(252, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 3
        Label3.Text = "ingredientes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 2
        Label2.Text = "precio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 1
        Label1.Text = "Cantidad"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(252, 27)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(890, 106)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(8, 8)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Control
        GroupBox3.Controls.Add(labeltotal)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Location = New Point(532, 59)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(378, 192)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' labeltotal
        ' 
        labeltotal.AutoSize = True
        labeltotal.Location = New Point(143, 47)
        labeltotal.Name = "labeltotal"
        labeltotal.Size = New Size(72, 20)
        labeltotal.TabIndex = 1
        labeltotal.Text = "cargando"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 0
        Label4.Text = "CANTIDAD"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ControlLightLight
        GroupBox4.Controls.Add(ListBox4)
        GroupBox4.Controls.Add(ListBox3)
        GroupBox4.Controls.Add(ListBox2)
        GroupBox4.Controls.Add(ListBox1)
        GroupBox4.Controls.Add(DataGridView1)
        GroupBox4.Location = New Point(65, 286)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(823, 337)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.Location = New Point(573, 179)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(145, 104)
        ListBox4.TabIndex = 4
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.Location = New Point(405, 179)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(128, 104)
        ListBox3.TabIndex = 3
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(235, 179)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(151, 104)
        ListBox2.TabIndex = 2
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(57, 179)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 104)
        ListBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(22, 36)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(797, 121)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Ingrediente"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Cantidad"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Precio"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Subtotal"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' LimpiarEntradasToolStripMenuItem
        ' 
        LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        LimpiarEntradasToolStripMenuItem.Size = New Size(224, 26)
        LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        ' 
        ' LimpiarDataToolStripMenuItem
        ' 
        LimpiarDataToolStripMenuItem.Name = "LimpiarDataToolStripMenuItem"
        LimpiarDataToolStripMenuItem.Size = New Size(224, 26)
        LimpiarDataToolStripMenuItem.Text = "Limpiar data"
        ' 
        ' Apoyo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(978, 741)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Apoyo"
        Text = "Apoyo"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents labeltotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDataToolStripMenuItem As ToolStripMenuItem
End Class
