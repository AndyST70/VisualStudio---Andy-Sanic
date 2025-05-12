Public Class Edades
    Private Sub CargarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarVectoresToolStripMenuItem.Click
        Dim edades(10) As Integer
        edades(0) = 51
        edades(1) = 6
        edades(2) = 4
        edades(3) = 12
        edades(4) = 90
        edades(5) = 80
        edades(6) = 70
        edades(7) = 65
        edades(8) = 85
        edades(9) = 30

        Dim suma As Integer = 0
        Dim promedio As Double = 0


        ComboBox1.Items.Clear()
        For indice As Integer = 0 To 3 Step 1 ' 0, 1, 2 , 3
            ComboBox1.Items.Add(edades(indice))
            suma = suma + edades(indice)
        Next
        promedio = suma / 3

        TextBox1.Text = promedio.ToString()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class