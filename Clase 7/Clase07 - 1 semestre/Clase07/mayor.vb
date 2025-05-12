Imports System.Reflection.Emit

Public Class mayor

    Private numeros(9) As Integer
    Private indice As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero As Integer

        ' Validamos que se ingrese un número válido en el TextBox
        If Integer.TryParse(TextBox1.Text, numero) Then
            If indice < numeros.Length Then
                ' Agregamos el número al vector y al ComboBox
                numeros(indice) = numero
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub LimpiarlistboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarlistboxToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub LimpiarDatosEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosEntradaToolStripMenuItem.Click
        ComboBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class