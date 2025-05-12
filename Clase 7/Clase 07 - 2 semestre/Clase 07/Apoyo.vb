Public Class Apoyo
    Private Const precioHarina As Double = 2.5
    Private Const precioAzucar As Double = 10
    Private Const precioMantequilla As Double = 8
    Private Const precioHuevos As Double = 2
    Private Const precioleche As Double = 12

    Private Sub Apoyo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox1.Items.Add("Harina")
        ' ComboBox1.Items.Add("Azúcar")
        ' ComboBox1.Items.Add("Mantequilla")
        'ComboBox1.Items.Add("Huevos")
        'ComboBox1.Items.Add("Leche")
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (indice <= 7) Then
            INGREDIENTE(indice) = ComboBox1.Text
            CANTIDAD(indice) = Val(TextBox1.Text)
            PRECIO(indice) = Val(TextBox2.Text)

            SUBTOTAL(indice) = CANTIDAD(indice) * PRECIO(indice)
            mostrardatos()

            indice += 1
            Calculartotal()
        Else
            MessageBox.Show("Ya no quedan espacios para guardar en los vectores")
        End If
    End Sub

    Sub mostrardatos()
        DataGridView1.Rows.Add(INGREDIENTE(indice), CANTIDAD(indice), PRECIO(indice), SUBTOTAL(indice))

        ListBox1.Items.Add(INGREDIENTE(indice))
        ListBox2.Items.Add(CANTIDAD(indice))
        ListBox3.Items.Add(PRECIO(indice))
        ListBox4.Items.Add(SUBTOTAL(indice))
    End Sub

    Sub Calculartotal() ' 0 , 1 ,2 
        ' 2
        Dim total_final As Double = 0

        Dim total As Double = 0
        For i As Integer = 0 To indice - 1
            total += SUBTOTAL(i)
        Next

        labeltotal.Text = "total de la receta Q. " & total.ToString("F2")
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Focus()
    End Sub
End Class