Public Class Form1
    Private Const PRECIO_HARINA As Double = 2.5
    Private Const PRECIO_AZUCAR As Double = 1.8
    Private Const PRECIO_MANTEQUILLA As Double = 3.0
    Private Const PRECIO_HUEVOS As Double = 0.5
    Private Const PRECIO_LECHE As Double = 1.2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Harina")
        ComboBox1.Items.Add("Azúcar")
        ComboBox1.Items.Add("Mantequilla")
        ComboBox1.Items.Add("Huevos")
        ComboBox1.Items.Add("Leche")
    End Sub

    Sub MostrarDatos()
        DataGridView1.Rows.Add(INGREDIENTE(INDICE), CANTIDAD(INDICE), PRECIO(INDICE), SUBTOTAL(INDICE))
        DataGridView2.Rows.Add(INGREDIENTE(INDICE), CANTIDAD(INDICE), PRECIO(INDICE), SUBTOTAL(INDICE))
    End Sub

    Private Sub LimpiarDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDataToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        INDICE = 0
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (INDICE <= 8) Then
            ' Se guarda la información de cada ingrediente en los vectores
            INGREDIENTE(INDICE) = ComboBox1.Text
            CANTIDAD(INDICE) = Val(TextBox1.Text)
            PRECIO(INDICE) = Val(TextBox2.Text)

            ' Se calcula el subtotal
            SUBTOTAL(INDICE) = CANTIDAD(INDICE) * PRECIO(INDICE)
            ' Harina, 5, 25, 125
            ' Mostramos los datos en el DataGridView
            MostrarDatos()

            ' Incrementamos el índice para el siguiente ingreso
            INDICE += 1
            CalcularTotal()

        End If

        ' Si se llenan los vectores, mostrar mensaje
        If (INDICE = 9) Then
            MsgBox("VECTORES LLENOS")
        End If

        ' Limpiar las entradas para el siguiente ingreso
        LimpiarEntradas()
    End Sub
    Private Sub CalcularTotal()
        Dim total As Double = 0

        ' Sumar todos los subtotales
        For i As Integer = 0 To INDICE - 1
            total += SUBTOTAL(i)
        Next

        ' Mostrar el total en la label3
        LabelTotal.Text = "Total por receta: $" & total.ToString("F2")
    End Sub
End Class
