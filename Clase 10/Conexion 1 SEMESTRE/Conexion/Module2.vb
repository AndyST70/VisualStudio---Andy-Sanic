' haciendo uso de carpeta
Imports MySql.Data.MySqlClient

Module Module2

    Dim Comando As MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim conec As New MySqlConnection
    Dim datos As DataSet
    Dim respuesta As MySqlDataReader
    Public Function ConexionDB2()
        Try

            Dim conexion As New MySqlConnectionStringBuilder
            conexion.Database = "baseproyecto" 'Aqui va el nombre de nuestra base de datos
            conexion.Server = "localhost" ' Aqui va por default, le dejamos localhost
            conexion.UserID = "root" ' el nombre de usuario que tenemos donde tenemos la base de datos
            conexion.Password = "root" ' contraseña del usuario

            Dim abrir_conexion As New MySqlConnection(conexion.ToString)

            abrir_conexion.Open() ' hace la conexion y abre el metodo
            MsgBox("Conexion exitosa Wilson, listos para el despegue :D")
            'si no se abre correctamente nos mandara al catch por el error al abrirlo


            Return abrir_conexion 'conexion abierta... mas adelante la abrimos je je je

        Catch ex As Exception
            MsgBox("ERROR DE CONEXION :/")
            Return Nothing
        End Try
    End Function
End Module
