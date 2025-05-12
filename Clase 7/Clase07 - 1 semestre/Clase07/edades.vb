Public Class edades
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CargaVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaVectoresToolStripMenuItem.Click
        Dim edades(8) As Integer '0 , 1, 2, 3, 4, 5, 6, 7
        edades(0) = 15
        edades(1) = 5
        edades(2) = 10
        edades(3) = 30
        edades(4) = 50
        edades(5) = 22
        edades(6) = 21
        edades(7) = 35

        Dim suma As Integer = 0
        Dim promedio As Double = 0

        ComboBox1.Items.Clear()


        For indice As Integer = 0 To 3 Step 1
            ComboBox1.Items.Add(edades(indice))
            suma = suma + edades(indice)
        Next

        promedio = suma / 4

        TextBox1.Text = (promedio).ToString()

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        ComboBox1.Items.Clear()
    End Sub
End Class