
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
'VERSION CON LIBRERIA
Module Module1
    Public connection As New MySqlConnection
    Public comandos As New MySqlCommand

    ' Datos para usuario
    Public UsuarioActual As String
    Public TipoUsuarioActual As String
    Public Id_usuario_date As Integer

    Public Function conexionBD()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=localhost;username=root;password=root;database=baseproyecto"
            connection.Open() 'Abrimos la conexion y metodos

            MsgBox("Conexión EXITOSA a Base de Datos!")

            Return connection
        Catch ex As Exception
            MsgBox("Error al conectar Base de Datos")
            Return Nothing ' Retornamos en caso de error
        End Try
    End Function


    Sub registrarnuevousuario(nombres As String, apellido As String, fechanacimiento As Date, contrasenia As String, rol_id As Integer, pais_id As Integer)
        Try

            Dim con = conexionBD()
            Dim query As String = ""

            query = "INSERT INTO Usuarios (nombre, apellido, fechanacimiento, contrasenia, rol_id, pais_id) " &
             "VALUES ('" & nombres & "', '" &
             apellido & "', '" &
             fechanacimiento.ToString("yyyy-MM-dd") & "', '" &
             contrasenia & "', " &
             rol_id & ", " &
             pais_id & ")"

            Dim comandos As New MySqlCommand(query, con)

            comandos = New MySqlCommand(query, con)

            comandos.ExecuteNonQuery()

            con.close()
            MsgBox("Cliente registrado con exito", MsgBoxStyle.Information, "Exito")

        Catch ex As Exception
            MsgBox("Error en la insercion del cliente..." & ex.Message)
        End Try
    End Sub

    Sub cargarpaises(combobox As ComboBox, ByRef paisesDic As Dictionary(Of String, Integer))
        Try
            Dim con = conexionBD()
            Dim query As String = "SELECT idpais, nombre FROM pais"
            Dim comandos As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = comandos.ExecuteReader()

            combobox.Items.Clear()
            combobox.Items.Add("Seleccione un país")
            paisesDic.Clear()

            While reader.Read()
                Dim idpais As Integer = Convert.ToInt32(reader("idpais"))
                Dim nombrePais As String = reader("nombre").ToString()
                combobox.Items.Add(nombrePais)
                paisesDic.Add(nombrePais, idpais) ' Agregar al diccionario
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los países: " & ex.Message)
        End Try
    End Sub

End Module


