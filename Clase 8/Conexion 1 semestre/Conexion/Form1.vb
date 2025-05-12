Public Class Form1
    ' VARIABLES TEMPORALES USUARIOS QUEMADOS LOGIN
    ' ADMINISTRADORES
    Dim useradmin As String = "admin"
    Dim contra As String = "123"
    ' USUARIOS
    Dim usuernormal As String = "Andy"
    Dim contra2 As String = "ast123"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexionBD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConexionDB2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a1 As String = TextBox1.Text
        Dim a2 As String = TextBox2.Text


        If a1 = useradmin And a2 = contra Then
            MsgBox("Bienvenido Administrador", vbInformation, "Login exitoso")

        ElseIf a1 = usuernormal And a2 = contra2 Then
            MsgBox("Bienvenido Usuario", vbInformation, "Login exitoso")
        Else
            MsgBox("Error al iniciar sesion, usuario erroneo", vbInformation, "Error")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        registrar.Show()
        Me.Hide
    End Sub
End Class
