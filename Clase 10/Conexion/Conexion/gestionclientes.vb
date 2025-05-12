Public Class gestionclientes
    Private Sub gestionclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarpaises(ComboBox2)
        cargarroles(ComboBox1)
        cargarusuarios(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre As String = text_nombre.Text
        Dim apellido As String = text_apellido.Text
        Dim fecha As Date = DateTimePicker1.Value
        Dim usuarionew As String = text_user.Text
        Dim contrasenia As String = text_contra.Text
        Dim rol_id As String = ComboBox1.Text
        Dim pais_id As Integer = ComboBox2.SelectedIndex
        Dim cui As String = text_cui.Text

        If rol_id = "" Then
            MsgBox("Por favor, seleccione un rol.")
            Return
        End If
        If pais_id = 0 Then
            MsgBox("Por favor, seleccione un país válido.")
            Return
        End If


        Dim a1 As Integer

        If rol_id = "admin" Then
            a1 = 1
        ElseIf rol_id = "usuario" Then
            a1 = 2
        Else
            MsgBox("No existe ese rol")
            Return
        End If

        registrarnuevousuario(nombre, apellido, fecha, contrasenia, usuarionew, cui, a1, pais_id - 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id_usuario_mod <= 0 Then
            MsgBox("Seleccione un usuario para actualizar.")
            Return
        End If

        Dim nuevoNombre As String = text_nombre.Text
        Dim nuevoApellido As String = text_apellido.Text
        Dim nuevaFechaNacimiento As Date = DateTimePicker1.Value
        Dim nuevaContrasenia As String = text_contra.Text
        Dim nuevouser As String = text_user.Text
        Dim cui As String = text_cui.Text

        Dim rol_id As String = ComboBox1.Text
        Dim pais_id_index As Integer = ComboBox2.SelectedIndex

        If rol_id = "" Then
            MsgBox("Por favor, seleccione un rol.")
            Return
        End If
        If pais_id_index = 0 Then
            MsgBox("Por favor, seleccione un país válido.")
            Return
        End If


        Dim a1 As Integer
        If rol_id = "admin" Then
            a1 = 1
        ElseIf rol_id = "usuario" Then
            a1 = 2
        Else
            MsgBox("No existe ese rol")
            Return
        End If
        actualizarusuario_admin(nuevoNombre, nuevoApellido, nuevaFechaNacimiento, nuevaContrasenia, nuevouser, cui, a1, pais_id_index)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If id_usuario_mod <= 0 Then
            MsgBox("Por favor, seleccione un usuario para eliminar.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            eliminarusuario_admin(id_usuario_mod)

            cargarusuarios(DataGridView1)
            text_nombre.Clear()
            text_apellido.Clear()
            text_cui.Clear()
            text_user.Clear()
            text_contra.Clear()
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            DateTimePicker1.Value = DateTime.Now

            id_usuario_mod = -1

            MsgBox("Usuario eliminado con éxito.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            text_nombre.Text = row.Cells("Column2").Value.ToString()
            text_apellido.Text = row.Cells("Column3").Value.ToString()
            text_cui.Text = row.Cells("Column5").Value.ToString()
            text_user.Text = row.Cells("Column7").Value.ToString()
            text_contra.Text = row.Cells("Column6").Value.ToString()
            DateTimePicker1.Value = Convert.ToDateTime(row.Cells("Column4").Value)

            Dim rol As String = row.Cells("Column8").Value.ToString()
            ComboBox1.SelectedItem = rol

            id_usuario_mod = Convert.ToInt32(row.Cells("Column1").Value)
        End If
    End Sub
End Class