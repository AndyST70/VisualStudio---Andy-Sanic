Public Class Calculadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = Val(TextBox1.Text)
        Dim n2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = suma(n1, n2)
        TextBox3.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1 As Integer = Val(TextBox1.Text)
        Dim n2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = multiplicar(n1, n2)
        TextBox3.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1 As Integer = Val(TextBox6.Text)
        Dim n2 As Integer = Val(TextBox5.Text)
        Dim result As Boolean = mayor(n1, n2)

        Dim funcion As String = ""

        If result = True Then
            funcion = "Verdadero"
        Else
            funcion = "Falso"
        End If

        TextBox4.Text = funcion
    End Sub
End Class