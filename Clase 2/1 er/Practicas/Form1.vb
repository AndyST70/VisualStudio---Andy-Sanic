Imports System.Reflection.Emit
Public Class Form1
    Const PrecioPizHawaina As Integer = 80
    Const PrecioPizpeperoni As Integer = 60
    Const PrecioPizJamon As Integer = 75

    Dim pagoSubtotal As Double = 0
    Dim Total As Double = 0
    Dim descuento As Double = 0
    Dim descuentofrecuente As Double = 0
    Dim temp As Double = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        'LIMPIAMOS RESULTADOS
        labeltotal.Text = "Q00.00"
        TextBox4.Clear()

        CheckBox1.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'cerramos aplicacion
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres salir", "Confirmación", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pagoSubtotal = 0
        Total = 0
        descuento = 0
        temp = 0
        'Cantidades de pizzas
        Dim CantPizzaHawaina As Integer = 0
        Dim CantPizzaPeperoni As Integer = 0
        Dim CantPizzaJamon As Integer = 0

        If IsNumeric(TextBox1.Text) Then
            CantPizzaHawaina = Val(TextBox1.Text)
        Else
            MessageBox.Show("por favor ingresa un numero valido, no se acepta strings")
        End If

        ' Calcular subtotal
        temp = CantPizzaHawaina * PrecioPizHawaina


        descuento = temp * 0.03


        If CheckBox1.Checked Then
            descuentofrecuente = temp * 0.06
        Else
            descuentofrecuente = 0
        End If

        pagoSubtotal = temp - descuento - descuentofrecuente
        Total = pagoSubtotal

        TextBox4.Text = "Q" & (descuento + descuentofrecuente).ToString("F2")
        labeltotal.Text = "Q" & Total.ToString("F2")

        ' Mostrar descuento total en TextBox4
        TextBox4.Text = "Q" & (descuento + descuentofrecuente).ToString("F2")


    End Sub
End Class
