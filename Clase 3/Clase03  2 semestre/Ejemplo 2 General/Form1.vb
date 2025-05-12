Public Class Form1

    Dim opcCliente As String = ""

    Dim subTotal As Double = 0
    Dim total As Double = 0
    Dim Desc1 As Double = 0
    Dim Desc2 As Double = 0

    Dim Det As Boolean
    Dim Des As Boolean
    Dim LimVid As Boolean
    Dim Suavz As Boolean
    Dim Clr As Boolean

    Dim contador As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opcCliente = ComboBox1.Text.ToLower() ' Tolower Mayorista => mayorista

        Det = CheckBox1.Checked
        Des = CheckBox2.Checked
        LimVid = CheckBox3.Checked
        Suavz = CheckBox5.Checked
        Clr = CheckBox6.Checked

        If Not (Det Or Des Or LimVid Or Suavz Or Clr) Then
            MessageBox.Show("Debe seleccionar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        subTotal = 0
        Desc1 = 0
        Desc2 = 0
        contador = 0

        Select Case opcCliente
            Case "regular"
                If Det Then
                    subTotal += 5
                    contador += 1
                End If
                If Des Then
                    subTotal += 7
                    contador += 1
                End If
                If LimVid Then
                    subTotal += 6
                    contador += 1
                End If
                If Suavz Then
                    subTotal += 8
                    contador += 1
                End If
                If Clr Then
                    subTotal += 3.5
                    contador += 1
                End If

            Case "mayorista"
                If Det Then
                    subTotal += 4.5
                    contador += 1
                End If
                If Des Then
                    subTotal += 6.5
                    contador += 1
                End If
                If LimVid Then
                    subTotal += 5.5
                    contador += 1
                End If
                If Suavz Then
                    subTotal += 7.5
                    contador += 1
                End If
                If Clr Then
                    subTotal += 3.0
                    contador += 1
                End If

            Case "premium"
                If Det Then
                    subTotal += 4.0
                    contador += 1
                End If
                If Des Then
                    subTotal += 6.0
                    contador += 1
                End If
                If LimVid Then
                    subTotal += 5.0
                    contador += 1
                End If
                If Suavz Then
                    subTotal += 7.0
                    contador += 1
                End If
                If Clr Then
                    subTotal += 2.5
                    contador += 1
                End If
            Case Else
                MessageBox.Show("Debe seleccionar un tipo de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        'APLICANDO DESCUENTOS
        ' Descuentos 1
        If contador > 3 Then
            Desc1 += subTotal * 0.05
        End If
        If opcCliente = "mayorista" And Det And Clr Then
            Desc1 += subTotal * 0.04
        End If
        'Descuentos 2
        If subTotal > 15 Then
            Desc2 = subTotal * 0.1
        End If

        'CALCULOS FINALES
        total = subTotal - Desc1 - Desc2


        Label8.Text = Math.Round(subTotal, 2).ToString("C2")
        Label9.Text = Math.Round(Desc1, 2).ToString("C2")
        Label10.Text = Math.Round(Desc2, 2).ToString("C2")
        Label11.Text = Math.Round(total, 2).ToString("C2")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.SelectedIndex = -1

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False

        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""

        subTotal = 0
        total = 0
        Desc1 = 0
        Desc2 = 0
        contador = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            End

        End If
    End Sub
End Class
