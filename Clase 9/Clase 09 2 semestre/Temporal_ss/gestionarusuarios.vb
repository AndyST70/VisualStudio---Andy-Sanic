Public Class gestionarusuarios
    Private Sub gestionarusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarusuarios(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre = txtNombre.Text
        Dim apellido = txtApellido.Text
        Dim carnet = txtCarnet.Text
        Dim correo = txtCorreo.Text
        Dim cui = txtCUI.Text
        Dim fecha = DateTimePicker1.Value
        Dim password = txtPassword.Text
        Dim rolTxt = ComboBox1.Text

        Dim rol_id As Integer = If(rolTxt = "Administrador", 1, 0)

        registrar_usuario_admin(nombre, apellido, fecha, password, carnet, cui, correo, rol_id)
        cargarusuarios(DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id_usuario_mod <= 0 Then
            MsgBox("Selecciona un usuario para eliminar")
            Return
        End If

        If MsgBox("¿Eliminar este usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            eliminarusuario_admin(id_usuario_mod)
            cargarusuarios(DataGridView1)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If id_usuario_mod <= 0 Then
            MsgBox("Selecciona un usuario para actualizar")
            Return
        End If

        Dim nombre = txtNombre.Text
        Dim apellido = txtApellido.Text
        Dim carnet = txtCarnet.Text
        Dim correo = txtCorreo.Text
        Dim cui = txtcui.Text
        Dim fecha = DateTimePicker1.Value
        Dim password = txtpassword.Text
        Dim rolTxt = ComboBox1.Text

        Dim rol_id As Integer = If(rolTxt = "Administrador", 1, 0)

        actualizarusuario_admin(nombre, apellido, fecha, password, carnet, cui, correo, rol_id)

        cargarusuarios(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            id_usuario_mod = Convert.ToInt32(row.Cells(0).Value)
            txtNombre.Text = row.Cells(1).Value.ToString()
            txtApellido.Text = row.Cells(2).Value.ToString()
            txtCarnet.Text = row.Cells(3).Value.ToString()
            txtcui.Text = row.Cells(4).Value.ToString()
            txtCorreo.Text = row.Cells(5).Value.ToString()


            DateTimePicker1.Value = Convert.ToDateTime(row.Cells(6).Value)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim carnet_x_buscar As String = (TextBox9.Text).ToString()
        If carnet_x_buscar = "" Then
            MsgBox("ingresa un carnet para buscar")
            Return
        End If
        buscarusuario_por_carnet(carnet_x_buscar, DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
        Me.Hide()
    End Sub


End Class