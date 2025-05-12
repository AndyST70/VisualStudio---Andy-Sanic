Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class restaurante
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pizza_f As Boolean = CheckBox1.Checked
        Dim poll_f As Boolean = CheckBox2.Checked
        Dim hamburg_f As Boolean = CheckBox3.Checked

        Dim resultado As Integer = 0
        Dim resp1 As Integer = 0
        Dim resp2 As String = ""
        Dim resp3 As Boolean = True
        Dim pago As Double = 0



        If pizza_f = True Then
            resp1 = 1
        Else
            resp1 = 0
        End If

        If poll_f = True Then
            resp2 = "pollofrito"
        Else
            resp2 = ""
        End If

        If hamburg_f = True Then
            resp3 = True
        Else
            resp3 = False
        End If
        resultado = Calcular(resp1, resp2, resp3)

        Dim metodoPago As String
        If RadioButton1.Checked Then
            metodoPago = "Efectivo"
        ElseIf RadioButton2.Checked Then
            metodoPago = "Tarjeta"
        Else
            metodoPago = "No especificado"
        End If
        pago = calcularPago(metodoPago, resultado)
        'calcularPago2 (metodoPago, resultados, resultaunico)
        ResultsLabel.Text = "================================" & Environment.NewLine &
                      "Subtotal: " & subtotal.ToString("C") & Environment.NewLine &
                      "Descuento: " & descuento.ToString("C") & Environment.NewLine &
                      "Total a Pagar: " & pago.ToString("C")

    End Sub
End Class