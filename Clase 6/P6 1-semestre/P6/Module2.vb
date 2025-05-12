Module Module2
    Public Const Pizza As Integer = 140
    Public Const Pollo As Integer = 60
    Public Const hamburguesa As Integer = 45

    Public total As Double
    Public subtotal As Double
    Public descuento As Double
    Private Const desc1 As Double = 0.05

    Public Suma_pedidos As Double = 0


    Public Function Calcular(ByVal piz1 As Integer, ByVal poll1 As String, ByVal ham1 As Boolean) As Double
        subtotal = 0
        total = 0
        descuento = 0
        Suma_pedidos = 0
        'Suma_pedidos = 0
        If piz1 = 1 Then
            Suma_pedidos += Pizza
        End If
        If poll1.ToLower() = "pollofrito" Then ' pollofrito
            Suma_pedidos += Pollo
        End If
        If ham1 = True Then
            Suma_pedidos += hamburguesa
        End If
        subtotal = Suma_pedidos
        ' Si en dado caso escoge (pizza y hamburguesa) aplica descuento 5%
        If piz1 = 1 And ham1 = True Then
            descuento = Suma_pedidos * desc1
        End If

        total = subtotal - descuento
        Return total

    End Function

    Public Function calcularPago(ByVal metodo As String, ByVal total As Double) As Double
        Select Case metodo.ToLower()
            Case "efectivo"
                Return total * 0.95
            Case "tarjeta"
                Return total
            Case Else
                Return total
        End Select
    End Function


    Public Sub calcularPago2(ByVal metodo As String, ByVal total As Double, ByRef resultadounico As Double)
        Select Case metodo.ToLower()
            Case "efectivo"
                resultadounico = total * 0.95
            Case "tarjeta"
                resultadounico = total
            Case Else
                resultadounico = total
        End Select

    End Sub

End Module
