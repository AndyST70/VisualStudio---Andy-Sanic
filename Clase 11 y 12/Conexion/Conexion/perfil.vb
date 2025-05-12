Public Class perfil
    Private Sub perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If obtenerusuario(UsuarioActual) Then
            TextBox1.Text = nombre
            TextBox2.Text = apellido
            TextBox3.Text = ""
            DateTimePicker1.Value = fecha

            MsgBox("usuario" & UsuarioActual)
        Else
            MsgBox("Nose pudo obtener eeste usuario")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizarUsuario(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value, TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EliminarUsuario()
        Form1.Show()
        Me.Hide()

    End Sub
End Class