Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        combo.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saludar()
    End Sub

    Private Sub saludar()
        Dim mensaje As String = "Hola jovenes, esto es un saludo"
        MessageBox.Show(mensaje)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero As Integer = generarNumeroAleatorio()
        MessageBox.Show(numero)
    End Sub

    Private Function generarNumeroAleatorio()
        Dim numerorandom As New Random()
        Return numerorandom.Next(1, 100)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeroPotencia As Integer = exponente(2, 2)
        MessageBox.Show("2 elevado a 2: " & numeroPotencia)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Calculadora.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        restaurante.Show()
        Me.Hide()
    End Sub
End Class
