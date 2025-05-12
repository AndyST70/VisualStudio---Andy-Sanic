Imports System.Numerics

Public Class DatosComparando
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(19) As Integer
        Dim mayor As Integer
        Dim menor As Integer

        For indice As Integer = 0 To 9
            vector(indice) = CInt(InputBox("Numero" & (indice + 1).ToString()))
        Next
        'vector {0,}
        mayor = vector(0)
        menor = vector(0)
        'vector {0, 1}
        ' 10, 2
        ' posicion inicial 0
        For indice As Integer = 0 To 9
            If vector(indice) > mayor Then
                mayor = vector(indice)
            End If
        Next

        For indice As Integer = 0 To 9
            If vector(indice) < menor Then
                menor = vector(indice)
            End If
        Next
        TextBox1.Text = mayor.ToString()
        TextBox2.Text = menor.ToString()

    End Sub
End Class