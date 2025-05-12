Imports MySql.Data.MySqlClient

Module Module1
    Dim conexion As New MySqlConnection
    Public comandos As New MySqlCommand

    Public UsuarioActual As String
    Public id_usuario_date As Integer
    Public id_usuario_rol As Integer

    Public apellido As String
    Public fecha As Date
    Public nombre As String

    Public id_usuario_mod As Integer
    Public Function conexionDB()
        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = "server=localhost;username=root;password=root;database=Biblioteca"
            conexion.Open()
            MessageBox.Show("Se conecto correctamente al servidor, bienvenido Iron-Man :D")
            Return conexion
        Catch ex As Exception
            MsgBox("Error al conectar Base de Datos")
            Return Nothing ' Retornamos en caso de error
        End Try
    End Function

    Public Function conexionDB1()
        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = "server=localhost;username=root;password=root;database=Biblioteca"
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("Error al conectar Base de Datos")
            Return Nothing ' Retornamos en caso de error
        End Try
    End Function
    Public Function login(usuario As String, password As String) As Boolean
        Try
            Dim conex As MySqlConnection = conexionDB1()
            Dim query As String = ""

            query = "SELECT idusuario, idrol FROM usuario WHERE carnet = '" &
            usuario.Replace("'", "''") &
            "' AND password = '" &
            password.Replace("'", "''") & "'"

            Dim cmd As New MySqlCommand(query, conex)
            Dim lector As MySqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                id_usuario_date = Convert.ToInt32(lector("idusuario"))
                id_usuario_rol = Convert.ToInt32(lector("idrol"))
                UsuarioActual = usuario
                lector.Close()
                conex.Close()
                Return True
            Else
                lector.Close()
                conex.Close()
                MsgBox("Carnet o contraseña incorrectos", MsgBoxStyle.Exclamation, "Error")
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al validar login: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Sub registrar_usuario_admin(nombres As String, apellido As String, fechanacimiento As Date, password As String, carnet As String, cui As String, correo As String, rol_id As Integer)
        Try
            Dim con = conexionDB1()
            Dim query = ""
            query = "INSERT INTO usuario (nombre, apellido, carnet, correo, fecha_nacimiento, cui, password, idrol) " &
                              "VALUES ('" & nombres.Replace("'", "''") & "', '" &
                              apellido.Replace("'", "''") & "', '" &
                              carnet.Replace("'", "''") & "', '" &
                              correo.Replace("'", "''") & "', '" &
                              fechanacimiento.ToString("yyyy-MM-dd") & "', '" &
                              cui.Replace("'", "''") & "', '" &
                              password.Replace("'", "''") & "', " &
                              rol_id & ")"
            Dim comandos As New MySqlCommand(query, conexion)
            comandos.ExecuteNonQuery()
            con.close()
            MsgBox("Usuario registrado con éxito", MsgBoxStyle.Information, "Éxito")

        Catch ex As Exception
            MsgBox("Error al insertar nuevo usuario", ex.Message)
        End Try
    End Sub
    Sub actualizarusuario_admin(nuevoNombre As String, nuevoApellido As String, nuevaFechaNacimiento As Date, nuevaContrasenia As String, carnet As String, cui As String, correo As String, rol_id As Integer)
        Try
            Dim con = conexionDB1()
            Dim query As String = $"UPDATE usuario SET nombre = '{nuevoNombre.Replace("'", "''")}', " &
                              $"apellido = '{nuevoApellido.Replace("'", "''")}', " &
                              $"carnet = '{carnet.Replace("'", "''")}', " &
                              $"correo = '{correo.Replace("'", "''")}', " &
                              $"fecha_nacimiento = '{nuevaFechaNacimiento.ToString("yyyy-MM-dd")}', " &
                              $"cui = '{cui.Replace("'", "''")}', " &
                              $"password = '{nuevaContrasenia.Replace("'", "''")}', " &
                              $"idrol = {rol_id} " &
                              $"WHERE idusuario = {id_usuario_mod}"
            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()
            con.Close()
            MsgBox("Usuario actualizado con éxito", MsgBoxStyle.Information, "Éxito")
        Catch ex As Exception
            MsgBox("Error al actualizar el usuario: " & ex.Message)
        End Try
    End Sub

    Sub eliminarusuario_admin(id_usuario As Integer)
        Try
            Dim con = conexionDB1()
            Dim query As String = $"DELETE FROM usuario WHERE idusuario = {id_usuario}"
            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al eliminar el usuario: " & ex.Message)
        End Try
    End Sub

    Sub cargarusuarios(grid As DataGridView)
        Try
            Dim con = conexionDB1()
            Dim query As String = "SELECT idusuario, nombre, apellido, carnet, cui, correo, fecha_nacimiento, password, idrol FROM usuario"
            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()
            grid.Rows.Clear()
            While reader.Read()
                Dim id As Integer = reader("idusuario")
                Dim nombre As String = reader("nombre").ToString()
                Dim apellido As String = reader("apellido").ToString()
                Dim carnet As String = reader("carnet").ToString()
                Dim cui As String = reader("cui").ToString()
                Dim correo As String = reader("correo").ToString()
                Dim fecha As Date = Convert.ToDateTime(reader("fecha_nacimiento"))
                Dim pass As String = reader("password").ToString()
                Dim rol As Integer = reader("idrol")
                Dim rolText As String = If(rol = 1, "Administrador", "Estudiante")
                grid.Rows.Add(id, nombre, apellido, carnet, cui, correo, fecha.ToString("yyyy-MM-dd"), pass, rolText)
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar usuarios: " & ex.Message)
        End Try
    End Sub
    Sub buscarusuario_por_carnet(carnet As String, grid As DataGridView)
        Try
            Dim con = conexionDB1()
            Dim query As String = "SELECT idusuario, nombre, apellido, carnet, cui, correo, fecha_nacimiento, password, idrol FROM usuario WHERE carnet = '" & carnet.Replace("'", "''") & "'"
            MsgBox("Ejecutando: " & query)

            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()
            grid.Rows.Clear()
            If reader.HasRows Then
                While reader.Read()
                    Dim id As Integer = reader("idusuario")
                    Dim nombre As String = reader("nombre").ToString()
                    Dim apellido As String = reader("apellido").ToString()
                    Dim cui As String = reader("cui").ToString()
                    Dim correo As String = reader("correo").ToString()
                    Dim fecha As Date = Convert.ToDateTime(reader("fecha_nacimiento"))
                    Dim password As String = reader("password").ToString()
                    Dim rol As Integer = reader("idrol")
                    Dim rolText As String = If(rol = 1, "Administrador", "Estudiante")

                    grid.Rows.Add(id, nombre, apellido, carnet, cui, correo, fecha.ToString("yyyy-MM-dd"), password, rolText)
                End While
            Else
                MsgBox("No se encontró ningún usuario con ese carnet.", MsgBoxStyle.Information, "Buscar")
            End If
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al buscar por carnet: " & ex.Message)
        End Try
    End Sub



End Module
