Public Class Form1






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mensaje() ' SE EJECUTO
    End Sub
    Private Sub mensaje()
        Dim mensajito As String
        mensajito = MessageBox.Show("Hola compañeros esto es un metodo") ' ESPERANDO
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero1 As Integer = 0
        numero1 = GenerarNumeroAleatorio()
        MessageBox.Show(numero1)
    End Sub
    Private Function GenerarNumeroAleatorio()
        Dim numero As New Random()
        Return numero.Next(1, 10)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        restaurante.Show()
        Me.Hide()
    End Sub
End Class
