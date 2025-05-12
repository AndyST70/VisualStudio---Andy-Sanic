Public Class comparar_datos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vector(10) As Integer ' 0, 1, 2 .. 9
        Dim mayor As Integer
        Dim menor As Integer

        For indice As Integer = 0 To 9 ' 0 , 1 , 2
            vector(indice) = CInt(InputBox("Numero a guardar : " & (indice + 1).ToString))
        Next

        mayor = vector(0) ' regresar a la posicion 0
        menor = vector(0)
        ' 90 , 80 , 70 ,50 , 2, 40 , 8, 108
        For indice As Integer = 0 To 9
            If vector(indice) > mayor Then ' 108 > 90
                mayor = vector(indice) ' 108
            End If
        Next

        For indice As Integer = 0 To 9
            If vector(indice) < menor Then '108 < 2
                menor = vector(indice) ' 2
            End If
        Next

        TextBox1.Text = mayor.ToString()
        TextBox2.Text = menor.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class