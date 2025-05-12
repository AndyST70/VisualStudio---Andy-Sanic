Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexionDB()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usuario As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If login(usuario, password) Then
            Select Case id_usuario_rol
                Case 0
                    MsgBox("Bienvenido Administrador", MsgBoxStyle.Information, "Login correcto")
                    admin.Show()
                    Me.Hide()
                Case 1
                    MsgBox("Bienvenido Estudiante", MsgBoxStyle.Information, "Login correcto")
                    user.Show()
                    Me.Hide()
                Case Else
                    MsgBox("Rol desconocido", MsgBoxStyle.Exclamation, "Error")
            End Select
        End If

    End Sub
End Class
