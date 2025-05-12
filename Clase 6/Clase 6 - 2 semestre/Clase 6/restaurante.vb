Public Class restaurante
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Se guarda los valores de los checkbox '
        Dim metodoPago As String = ComboBox1.SelectedItem.ToString()

        Dim pizza_f As Boolean = CheckBox1.Checked
        Dim poll_f As Boolean = CheckBox2.Checked
        Dim hamburg_f As Boolean = CheckBox3.Checked
        Dim refresco_f As Boolean = CheckBox4.Checked

        Dim resultado As Double = 0

        Dim resp1 As Integer = 0
        Dim resp2 As String = ""
        Dim resp3 As Boolean = True
        Dim resp4 As String = ""

        Dim ivacalculado As Double = 0
        Dim pago_Desc_REC As Double = 0


        If pizza_f = True Then
            resp1 = 1 'verdadero se selecciono
        Else
            resp1 = 0 ' no se seleccino / falso
        End If

        If poll_f = True Then
            resp2 = "pollofrito"
        Else
            resp2 = ""
        End If

        If hamburg_f = True Then
            resp3 = True 'verdadero /selecciono
        Else
            resp3 = False 'falso /no lo selecciono
        End If

        If refresco_f = True Then
            resp4 = "refresco"
        Else
            resp4 = ""
        End If


        resultado = Calcular(resp1, resp2, resp3, resp4)

        ' Dim metodoPago As String
        'If RadioButton1.Checked Then
        ' metodoPago = "Efectivo"
        'ElseIf RadioButton3.Checked Then
        ' metodoPago = "Tarjeta"
        'Else
        ' metodoPago = "No especificado"
        'End If '

        calcularPago2(metodoPago, subtotal)


        ivacalculado = calcular_costos(subtotal)

        total = subtotal - descuento + recargo + ivacalculado
        'calcularPago2 (metodoPago, resultados, resultaunico)
        ResultsLabel.Text = "================================" & Environment.NewLine &
                            "Subtotal: " & subtotal.ToString("C") & Environment.NewLine &
                            "Descuento: " & descuento.ToString("C") & Environment.NewLine &
                            "Recargo: " & recargo.ToString("C") & Environment.NewLine &
                            "IVA: " & ivacalculado.ToString("C") & Environment.NewLine &
                            "Total a Pagar: " & total.ToString("C")



        ListBox2.Items.Add(subtotal.ToString())
        ListBox3.Items.Add(descuento.ToString())
        ListBox4.Items.Add(recargo.ToString())
        ListBox5.Items.Add(total.ToString())


    End Sub
End Class