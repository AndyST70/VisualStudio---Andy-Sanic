Module Module1
    Public INDICE As Byte = 0 ' indexador, i = 9
    Public INGREDIENTE(8) As String ' agregarme 9 datos
    Public CANTIDAD(8) As Double
    Public PRECIO(8) As Double
    Public SUBTOTAL(8) As Double

    ' Procedimiento para limpiar las entradas del formulario
    Sub LimpiarEntradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TextBox1.Focus()
    End Sub
End Module
