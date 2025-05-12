
Imports MySql.Data.MySqlClient

'VERSION CON LIBRERIA
Module Module1
    Public connection As New MySqlConnection
    Public comandos As New MySqlCommand

    ' Datos para usuario
    Public UsuarioActual As String
    Public TipoUsuarioActual As String
    Public Id_usuario_date As Integer

    'GUARDATR DATOS LOGUEADO
    Public apellido As String
    Public fecha As Date
    Public nombre As String

    ' Id del usuario a modificar desde gestion usuarios adminsitrador
    Public id_usuario_mod As Integer

    Public Function conexionBD()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=localhost;username=root;password=root;database=baseinicial"
            connection.Open() 'Abrimos la conexion y metodo
            Return connection
        Catch ex As Exception
            MsgBox("Error al conectar Base de Datos")
            Return Nothing ' Retornamos en caso de error
        End Try
    End Function

    Public Function login(usuario As String, pasword As String) As Boolean
        Try
            Dim con As MySqlConnection = conexionBD()
            Dim query As String
            query = "SELECT u.idusuario, r.tipo " &
                    "FROM usuarios u " &
                    "JOIN roles r ON u.rol_id = r.idrol " &
                    "WHERE u.Usuario = '" & usuario.Replace("'", "''") & "' AND u.contrasenia = '" & pasword.Replace("'", "''") & "' "
            Dim cmd As New MySqlCommand(query, con)
            Dim lector As MySqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                TipoUsuarioActual = lector("tipo").ToString()
                Id_usuario_date = Convert.ToInt32(lector("idusuario"))
                UsuarioActual = usuario
                lector.Close()
                con.Close()
                Return True
            Else
                MsgBox("Usuario o contraseña incorrectas", MsgBoxStyle.Exclamation, "Error al loguearse")
                lector.Close()
                con.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al validar el login" & ex.Message, MsgBoxStyle.Critical, "Error ")
            Return False
        End Try
    End Function

    Function obtenerusuario(user_Actual As String) As Boolean
        Try
            Dim con As MySqlConnection = conexionBD()
            Dim query As String
            query = $"SELECT u.idusuario, u.nombre, u.apellido, u.fechanacimiento " &
                    $"FROM usuarios u " &
                    $"WHERE u.Usuario = '{user_Actual.Replace("'", "''")}'"
            Dim cmd As New MySqlCommand(query, con)
            Dim lector As MySqlDataReader = cmd.ExecuteReader()
            If lector.Read() Then
                Id_usuario_date = Convert.ToInt32(lector("idusuario"))
                nombre = lector("nombre").ToString()
                apellido = lector("apellido").ToString()
                fecha = Convert.ToDateTime(lector("fechanacimiento"))
                lector.Close()
                con.Close()
                Return True
            Else
                lector.Close()
                con.Close()
                Return False

            End If

        Catch ex As Exception
            MsgBox("Error al OBTENER EL USUARIO" & ex.Message, MsgBoxStyle.Critical, "Error ")
            Return False
        End Try

    End Function

    Sub actualizarUsuario(nuevoNombre As String, nuevoApellido As String, nuevaFechaNacimiento As Date, nuevaContrasenia As String)
        Try
            Dim con = conexionBD()

            Dim query As String = $"UPDATE usuarios SET nombre = '{nuevoNombre}', apellido = '{nuevoApellido}', " &
                              $"fechanacimiento = '{nuevaFechaNacimiento.ToString("yyyy-MM-dd")}', " &
                              $"contrasenia = '{nuevaContrasenia.Replace("'", "''")}' " &
                              $" WHERE idusuario = {Id_usuario_date}"

            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()
            con.Close()
            MsgBox("Perfil actualizado con éxito", MsgBoxStyle.Information, "Éxito")

        Catch ex As Exception
            MsgBox("Error al actualizar el perfil: " & ex.Message)
        End Try
    End Sub
    Sub EliminarUsuario()
        Try
            Dim con = conexionBD()
            Dim query As String = $"DELETE FROM usuarios WHERE idusuario = {Id_usuario_date}"

            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()

            con.Close()
            MsgBox("Usuario eliminado con éxito", MsgBoxStyle.Information, "Éxito")

        Catch ex As Exception
            MsgBox("Error al eliminar el usuario: " & ex.Message)
        End Try
    End Sub


    Sub cargarpaises(combobox As ComboBox)
        Try
            Dim con = conexionBD()
            Dim query As String = "SELECT idpais, nombre FROM pais"
            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()

            combobox.Items.Clear()
            combobox.Items.Add("Seleccione un país")

            Dim paises As New Dictionary(Of Integer, String)
            ' {(1, guatemala), (2, mexico) }

            While reader.Read()
                Dim idPais As Integer = Convert.ToInt32(reader("idpais"))
                Dim nombrePais As String = reader("nombre").ToString()
                paises.Add(idPais, nombrePais)
                combobox.Items.Add(nombrePais)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los países: " & ex.Message)
        End Try
    End Sub

    Sub cargarroles(combobox As ComboBox)
        Try
            Dim con = conexionBD()
            Dim query As String = "SELECT idrol, tipo FROM roles"
            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()

            combobox.Items.Clear()
            combobox.Items.Add("Selecciona un rol")
            While reader.Read()
                Dim rol As String = reader("tipo").ToString()
                combobox.Items.Add(rol)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los roles: " & ex.Message)
        End Try
    End Sub

    Sub cargarusuarios(datos As DataGridView)
        Try
            Dim con = conexionBD()
            Dim query As String = "SELECT u.idusuario, u.nombre, u.apellido, u.fechanacimiento, u.cui, u.contrasenia, u.usuario, r.tipo AS rol " &
                              "FROM usuarios u " &
                              "JOIN roles r ON u.rol_id = r.idrol;"

            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()

            datos.Rows.Clear()
            If reader.HasRows Then
                While reader.Read()

                    Dim idUsuario As Integer = Convert.ToInt32(reader("idusuario"))
                    Dim nombre As String = reader("nombre").ToString()
                    Dim apellido As String = reader("apellido").ToString()
                    Dim fechaNacimiento As Date = Convert.ToDateTime(reader("fechanacimiento"))
                    Dim cui As String = reader("cui").ToString()
                    Dim contrasenia As String = reader("contrasenia").ToString()
                    Dim usuario As String = reader("usuario").ToString()
                    Dim rol As String = reader("rol").ToString()

                    datos.Rows.Add(idUsuario, nombre, apellido, fechaNacimiento.ToString("yyyy-MM-dd"), cui, contrasenia, usuario, rol)
                End While
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los usuarios: " & ex.Message)
        End Try
    End Sub

    Sub cargavideojuegos(datos As DataGridView)
        Try
            Dim con = conexionBD()
            Dim query As String = " SELECT v.idvideojuego, v.nombre, v.descripcion, v.precio, v.puntuacion, " &
                                   "c.categoria AS categoria, d.empresa as desarrolladora " &
                                   "FROM videojuegos v " &
                                   "JOIN categorias c ON  v.vidcat_id = c.idcategoria " &
                                   "JOIN desarrolladora d ON v.desarrolladora_id = d.idcreador ;"

            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()

            datos.Rows.Clear()
            If reader.HasRows Then
                While reader.Read()

                    Dim idVIDEOJE As Integer = Convert.ToInt32(reader("idvideojuego"))
                    Dim nombre As String = reader("nombre").ToString()
                    Dim descripcion As String = reader("descripcion").ToString()
                    Dim precio As Integer = reader("precio").ToString()
                    Dim puntuacion As Integer = Convert.ToInt32(reader("puntuacion"))
                    Dim categoria As String = reader("categoria").ToString()
                    Dim desarrolladora As String = reader("desarrolladora").ToString()
                    datos.Rows.Add(idVIDEOJE, nombre, descripcion, precio, puntuacion, categoria, desarrolladora)
                End While
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los usuarios: " & ex.Message)
        End Try
    End Sub




    Sub registrarnuevousuario(nombres As String, apellido As String, fechanacimiento As Date, contrasenia As String, usuarionew As String, cui As String, rol_id As Integer, pais_id As Integer)
        Try
            Dim con = conexionBD()
            Dim query As String = "INSERT INTO usuarios (nombre, apellido, fechanacimiento, cui,contrasenia, Usuario, rol_id, pais_id) " &
                                  "VALUES ('" & nombres.Replace("'", "''") & "', '" &
                                  apellido.Replace("'", "''") & "', '" &
                                  fechanacimiento.ToString("yyyy-MM-dd") & "', '" &
                                  cui.Replace("'", "''") & "', '" &
                                  contrasenia.Replace("'", "''") & "', '" &
                                  usuarionew.Replace("'", "''") & "', " &
                                  rol_id & ", " &
                                  pais_id & ")"

            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()
            con.Close()
            MsgBox("Cliente registrado con éxito", MsgBoxStyle.Information, "Éxito")

        Catch ex As Exception
            MsgBox("Error en la inserción del cliente: " & ex.Message)
        End Try
    End Sub

    Sub actualizarusuario_admin(nuevoNombre As String, nuevoApellido As String, nuevaFechaNacimiento As Date, nuevaContrasenia As String, nuevouser As String, cui As String, rol_id As Integer, pais_id As Integer)
        Try
            Dim con = conexionBD()

            Dim query As String = $"UPDATE usuarios SET nombre = '{nuevoNombre.Replace("'", "''")}', " &
                              $"apellido = '{nuevoApellido.Replace("'", "''")}', " &
                              $"fechanacimiento = '{nuevaFechaNacimiento.ToString("yyyy-MM-dd")}', " &
                              $"contrasenia = '{nuevaContrasenia.Replace("'", "''")}', " &
                              $"usuario = '{nuevouser.Replace("'", "''")}', " &
                              $"cui = '{cui.Replace("'", "''")}', " &
                              $"rol_id = {rol_id}, pais_id = {pais_id} " &
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
            Dim con = conexionBD()

            Dim query As String = $"DELETE FROM usuarios WHERE idusuario = {id_usuario}"

            Dim comandos As New MySqlCommand(query, con)
            comandos.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Error al eliminar el usuario: " & ex.Message)
        End Try
    End Sub




    ' Método para realizar la partición
    Private Function Partition(arr As List(Of (precio As Integer, id As Integer, nombre As String, descripcion As String, puntuacion As Integer, categoria As String, desarrolladora As String)), low As Integer, high As Integer) As Integer
        Dim pivot As Integer = arr(high).precio
        Dim i As Integer = low - 1

        For j As Integer = low To high - 1
            If arr(j).precio < pivot Then
                i += 1
                Dim temp As (Integer, Integer, String, String, Integer, String, String) = arr(i)
                arr(i) = arr(j)
                arr(j) = temp
            End If
        Next


        Dim temp1 As (Integer, Integer, String, String, Integer, String, String) = arr(i + 1)
        arr(i + 1) = arr(high)
        arr(high) = temp1

        Return i + 1
    End Function


    ' Método de Quicksort
    Public Sub QuickSort(arr As List(Of (precio As Integer, id As Integer, nombre As String, descripcion As String, puntuacion As Integer, categoria As String, desarrolladora As String)), low As Integer, high As Integer)
        If low < high Then
            ' pi es el índice de partición
            Dim pi As Integer = Partition(arr, low, high)

            ' Recursión
            QuickSort(arr, low, pi - 1) ' Antes del pivote
            QuickSort(arr, pi + 1, high) ' Después del pivote
        End If
    End Sub

    Public Sub OrdenarVideojuegosPorPrecio(datos As DataGridView)
        Dim videojuegos As New List(Of (precio As Integer, id As Integer, nombre As String, descripcion As String, puntuacion As Integer, categoria As String, desarrolladora As String))
        For Each row As DataGridViewRow In datos.Rows
            If Not row.IsNewRow Then
                Dim id As Integer = Convert.ToInt32(row.Cells("Column1").Value)
                Dim nombre As String = row.Cells("Column2").Value.ToString()
                Dim descripcion As String = row.Cells("Column3").Value.ToString()
                Dim precio As Integer = Convert.ToInt32(row.Cells("Column4").Value)
                Dim puntuacion As Integer = Convert.ToInt32(row.Cells("Column5").Value)
                Dim categoria As String = row.Cells("Column6").Value.ToString()
                Dim desarrolladora As String = row.Cells("Column6").Value.ToString()

                videojuegos.Add((precio, id, nombre, descripcion, puntuacion, categoria, desarrolladora))
            End If
        Next

        QuickSort(videojuegos, 0, videojuegos.Count - 1)
        datos.Rows.Clear()
        For Each videojuego In videojuegos
            datos.Rows.Add(videojuego.id, videojuego.nombre, videojuego.descripcion, videojuego.precio, videojuego.puntuacion, videojuego.categoria, videojuego.desarrolladora)
        Next
    End Sub



End Module


