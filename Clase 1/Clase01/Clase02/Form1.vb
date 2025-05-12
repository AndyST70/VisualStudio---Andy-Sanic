Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1

    Private variableprivada As Integer = 10
    Private variablepublica As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer = variablepublica
        Label1.Text = "Hola la variable publica a cambiado a: " & (variablepublica.ToString)
        MessageBox.Show("Valor de la variable : " & valor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor As Integer = 4 ' declaracion
        variablepublica = 14 ' asignacion
        Dim suma = valor + variablepublica ' declaracion
        Label1.Text = "Hola la variable publica a cambiado a: " & (variablepublica.ToString)
        MessageBox.Show("Valor de la variable : " & suma)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Hola la variable publica a cambiado a: " & (variablepublica.ToString) ' COMENTARIO


        Dim integerVar As Integer = 100
        Dim stringVar As String = "Hola Mundo - 100"
        Dim booleana As Boolean = True
        Dim doubleVar As Double = 123.45 '1548756.0 ' 1000 a 100000
        Dim dateVar As Date = Now

        MessageBox.Show("Integer: " & integerVar)
        MessageBox.Show("String: " & stringVar)
        MessageBox.Show("Boolean: " & booleana)
        MessageBox.Show("Double: " & doubleVar)
        MessageBox.Show("Date: " & dateVar) '

    End Sub


    Dim dat1 As Integer = 0

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim suma As Integer = 0 ' inicializar es que seteamos el valor a 0 o ''
        'Msgx 1
        MessageBox.Show("Mensaje 1 :" & suma)
        'Msgx 2
        MessageBox.Show("Mensaje 2 :" & suma + variablepublica)
        'Msgx 3
        MessageBox.Show("Mensaje 3 :" & suma)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As String = ""
        Dim num2 As Integer = 0 ' 1 , "1" error

        num1 = TextBox1.Text
        num2 = Val(TextBox2.Text) ' "1" => 1 

        ' "3" + 4 = sixtax error => error value
        Dim suma As Integer = Val(num1) + num2
        MessageBox.Show("total: " & suma)
        Label1.Text = "operacion: " & (suma.ToString)
    End Sub
End Class
