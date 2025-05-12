Public Class registrar
    Private paisesDic As New Dictionary(Of String, Integer)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = TextBox1.Text
        Dim apellido As String = TextBox2.Text
        Dim fechanacimiento As Date = DateTimePicker1.Value
        Dim contrasenia As String = TextBox3.Text
        Dim rol_id As Integer = 1
        Dim pais_id As Integer = 0
        If ComboBox1.SelectedIndex > 0 Then
            Dim nombrePais As String = ComboBox1.SelectedItem.ToString()
            If paisesDic.TryGetValue(nombrePais, pais_id) Then
                'registrarnuevousuario(nombre, apellido, fechanacimiento, contrasenia, rol_id, pais_id)
            Else
                MsgBox("Error al obtener el ID del país seleccionado.")
            End If
        Else
            MsgBox("Por favor, seleccione un país.")
        End If

    End Sub

    Private Sub registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarpaises(ComboBox1, paisesDic)
    End Sub


End Class