Public Class entrada
    Public usuario As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        If String.IsNullOrEmpty(usuario) Then
            MessageBox.Show("Por favor ingresa su nombre")
        End If

        'Dim varnombre As New Form1()
        Dim frm As New Form1()
        frm.usuario = usuario
        frm.Show()
        Me.Hide()
    End Sub
End Class