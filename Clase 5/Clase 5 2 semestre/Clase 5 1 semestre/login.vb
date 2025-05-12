Public Class login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valida_nombre As String = TextBox1.Text
        Dim valida_password As String = TextBox2.Text

        If valida_nombre = name_admin And valida_password = password Then
            Me.Hide() ' OCULTANDO FORMULARIO ACTUAL
            Form2.Show() ' MOSTRANDO EL FORMULO 2
            MessageBox.Show("Bievenido Arturo")
        Else
            MessageBox.Show("Acceso negado, Usted no es el PATRON :/", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class