Module Module1


    Public Function exponente(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer = 1
        Dim i As Integer
        For i = 1 To num2
            resultado *= num1
        Next
        Return resultado
    End Function

    Public Function suma(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = num1 + num2
        Return resultado
    End Function

    Public Function multiplicar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = num1 * num2
        Return resultado
    End Function

    Public Function mayor(ByVal num1 As Integer, ByVal num2 As Integer) As Boolean
        Dim n1 As Integer = num1
        Dim n2 As Integer = num2
        If n1 > n2 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
