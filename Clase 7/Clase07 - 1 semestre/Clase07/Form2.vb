Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private numeros(9) As Integer
    Private indice As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer

        ' Validamos que se ingrese un número válido en el TextBox
        If Integer.TryParse(TextBox1.Text, numero) Then
            If indice < numeros.Length Then ' 10 -> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10-> NO EXISTE LA POSICIOUN
                ' Agregamos el número al vector y al ComboBox 
                numeros(indice) = numero '0=10, 1
                ComboBox1.Items.Add(numero)
                ListBox1.Items.Add(numero)
                ' Incrementamos el índice
                indice += 1

                ' Limpiamos el TextBox para el siguiente número
                TextBox1.Clear()
            Else
                MessageBox.Show("El vector está lleno. Ingresa el valor a comparars.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor As Integer
        Dim contador As Integer = 0

        ' Limpiamos el ListBox de resultados
        ListBox2.Items.Clear()

        ' Validamos que se ingrese un valor válido en el TextBox
        If Integer.TryParse(TextBox1.Text, valor) Then
            ' Contamos cuántos números en el vector son mayores que el valor dado
            For i As Integer = 0 To indice - 1
                If numeros(i) > valor Then
                    contador += 1

                    ' Agregamos los números mayores al ListBox2
                    ListBox2.Items.Add(numeros(i))
                End If
            Next

            ' Mostramos el resultado en un Label
            TextBox2.Text = "Tenemos: " & contador.ToString() & " números mayores que " & valor.ToString()
        Else
            MessageBox.Show("Por favor, ingresa un valor válido.")
        End If
    End Sub

    Private Sub LimpiarDatosEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosEntradaToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub LimpiarSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarSalidasToolStripMenuItem.Click
        TextBox2.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ComboBox1.Items.Clear()
    End Sub
End Class