Public Class paeres_e_impares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(7) As Integer
        Dim sumapares As Integer = 0
        Dim sumaimpares As Integer = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()


        For indice As Integer = 0 To 7
            vector(indice) = CInt(InputBox("Ingresar numero: " & (indice + 1).ToString()))
        Next

        For indice As Integer = 0 To 7
            If vector(indice) Mod 2 = 0 Then
                ListBox1.Items.Add(vector(indice))
                sumapares += vector(indice)
            Else
                ListBox2.Items.Add(vector(indice))
                sumaimpares += vector(indice)
            End If
        Next

        TextBox1.Text = sumapares.ToString
        TextBox2.Text = sumaimpares.ToString





    End Sub
End Class