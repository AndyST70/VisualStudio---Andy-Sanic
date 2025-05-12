Public Class pares_impares
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector_numeros(8) As Integer
        Dim sumpares As Integer = 0
        Dim sumimpares As Integer = 0


        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        For indice As Integer = 0 To 7
            vector_numeros(indice) = CInt(InputBox("Ingresar numero : ") & (indice + 1).ToString())
        Next

        For indice As Integer = 0 To 7
            If vector_numeros(indice) Mod 2 = 0 Then
                ListBox1.Items.Add(vector_numeros(indice))
                sumpares += vector_numeros(indice)
            Else
                ListBox2.Items.Add(vector_numeros(indice))
                sumimpares += vector_numeros(indice)
            End If

        Next

        TextBox1.Text = sumpares.ToString()
        TextBox2.Text = sumimpares.ToString()


    End Sub
End Class