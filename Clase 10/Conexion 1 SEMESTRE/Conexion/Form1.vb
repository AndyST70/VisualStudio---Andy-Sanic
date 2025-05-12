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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim usuario As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If login(usuario, password) Then
            Select Case TipoUsuarioActual.ToLower()
                Case "admin"
                    MsgBox("Bienvenido administrador", vbInformation, "Login exitoso")
                    admin.Show()
                    Me.Hide()

                Case "usuario"
                    MsgBox("Bienvenido usuario", vbInformation, "Login exitoso")
                    user.Show()
                    Me.Hide()
            End Select
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        registrar.Show()
        Me.Hide
    End Sub
End Class
