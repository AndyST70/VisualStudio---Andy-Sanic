Public Class Form1

    Dim facil As Boolean
    Dim normal As Boolean
    Dim dificil As Boolean

    Dim pantano As Boolean
    Dim pizzeria As Boolean
    Dim comercial As Boolean

    Dim CANT_PERSONAS As Integer ' enteros
    Dim SUBTOTAL As Double ' decimales
    Dim TOTAL_PAGAR As Double

    Dim desc1 As Double
    Dim desc2 As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        facil = False
        normal = False
        dificil = False

        pantano = False
        pizzeria = False
        comercial = False

        'CANT_PERSONAS = 0
        SUBTOTAL = 0
        TOTAL_PAGAR = 0

        desc1 = 0
        desc2 = 0
        CANT_PERSONAS = Val(TextBox1.Text)

        facil = RadioButton1.Checked
        normal = RadioButton2.Checked
        dificil = RadioButton3.Checked

        pantano = CheckBox1.Checked
        pizzeria = CheckBox2.Checked
        comercial = CheckBox3.Checked


        If facil Then
            If pantano Then
                SUBTOTAL += 120 * CANT_PERSONAS '   120 * 2 = 240  | subtotal += 240
            End If
            If pizzeria Then
                SUBTOTAL += 150 * CANT_PERSONAS '   150 * 2 = 300  | subtotal += 240 + 300 
            End If
            If comercial Then
                SUBTOTAL += 250 * CANT_PERSONAS
            End If

        ElseIf normal Then
            If pantano Then
                SUBTOTAL += 150 * CANT_PERSONAS '   120 * 2 = 240  | subtotal += 240
            End If
            If pizzeria Then
                SUBTOTAL += 180 * CANT_PERSONAS '   150 * 2 = 300  | subtotal += 240 + 300 
            End If
            If comercial Then
                SUBTOTAL += 280 * CANT_PERSONAS
            End If

        ElseIf dificil Then
            If pantano Then
                SUBTOTAL += 180 * CANT_PERSONAS '   120 * 2 = 240  | subtotal += 240
            End If
            If pizzeria Then
                SUBTOTAL += 210 * CANT_PERSONAS '   150 * 2 = 300  | subtotal += 240 + 300 
            End If
            If comercial Then
                SUBTOTAL += 310 * CANT_PERSONAS
            End If
        Else
            MessageBox.Show("No seleccionaste ninguna dificultad")
        End If
        SUBTOTAL = SUBTOTAL
        ' DESC1 
        ' si en dado caso es normal o dificil = true
        If (normal Or dificil) And comercial Then
            desc1 += SUBTOTAL * 0.05
        End If

        If facil Then
            desc1 += SUBTOTAL * 0.1
        End If

        'desc 2
        If pantano And pizzeria And dificil Then
            desc2 += SUBTOTAL * 0.02
        End If

        If comercial Then
            desc2 += SUBTOTAL * 0.05
        End If

        TOTAL_PAGAR = SUBTOTAL - desc1 - desc2

        ' MOSTRAMOS RESULTADOS

        lbl_DESC1.Text = "descuento 1: " & desc1.ToString
        lbl_DESC2.Text = "descuento 2: " & desc2.ToString

        lbl_Subtotal.Text = "Subtotal " & SUBTOTAL.ToString()


        lbl_total.Text = "Total a pagar " & TOTAL_PAGAR.ToString()



    End Sub
End Class
