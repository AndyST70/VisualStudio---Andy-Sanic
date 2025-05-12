Module Module2
    ' Variables constantes'
    Private Const pizza As Integer = 140
    Private Const pollo As Integer = 140
    Private Const hamburguesa As Integer = 140
    Private Const refresco As Integer = 140


    Public total As Double
    Public subtotal As Double
    Public descuento As Double
    Public recargo As Double
    Public metodopago_total As Double

    Public Function Calcular(ByVal piz1 As Integer, ByVal poll1 As String, ByVal ham1 As Boolean, ByVal refres As String) As Double
        subtotal = 0
        total = 0
        descuento = 0

        If piz1 = 1 Then
            subtotal += pizza
        End If
        If poll1.ToLower() = "pollofrito" Then ' pollofrito
            subtotal += pollo
        End If
        If ham1 = True Then
            subtotal += hamburguesa
        End If

        If refres = "refresco" Then
            subtotal += refresco
        End If


        ' Si en dado caso escoge (pizza y hamburguesa) aplica descuento 5%
        If piz1 = 1 And ham1 = True Then
            descuento += subtotal * 0.05
        End If

        Return subtotal - descuento

    End Function

    Public Function calcularPago(ByVal metodo As String, ByVal total As Double) As Double
        Select Case metodo.ToLower()
            Case "efectivo", "transferencia"
                Return -(total * 0.1)
            Case "t debito"
                Return total * 0.05
            Case "t credito"
                Return total * 0.8
            Case Else
                Return total
        End Select
    End Function


    Public Sub calcularPago2(ByVal metodo As String, ByVal total As Double)
        Select Case metodo.ToLower()
            Case "efectivo", "transferencia"
                descuento += total * 0.1
            Case "t debito"
                recargo += total * 0.05
            Case "t credito"
                recargo += total * 0.08
            Case Else
                metodopago_total += total
        End Select

    End Sub

    Public Function calcular_costos(ByVal datos As Double) As Double
        Return datos * 0.12
    End Function


End Module
