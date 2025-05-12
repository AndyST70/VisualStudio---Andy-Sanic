Public Class gestionvideojuegos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub gestionvideojuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargavideojuegos(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OrdenarVideojuegosPorPrecio(DataGridView1)
    End Sub
End Class