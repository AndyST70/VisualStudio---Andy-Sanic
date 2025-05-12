Module Module1

    Public total_operaciones As Double = 0

    Sub calculadora(ByVal num1 As Integer, ByVal num2 As Integer, ByVal calculo As String)
        If calculo = "suma" Then
            total = num1 + num2
        ElseIf calculo = "resta" Then
            total = num1 - num2
        End If
    End Sub


End Module
