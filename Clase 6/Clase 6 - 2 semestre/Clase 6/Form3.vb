Public Class Form3
    Private Sub SumaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaToolStripMenuItem.Click
        Dim num1 As Integer = Val(TextBox1.Text)
        Dim num2 As Integer = Val(TextBox2.Text)
        Dim dat1 As String = "suma"
        calculadora(num1, num2, dat1)

        Label3.Text = total_operaciones.ToString()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub RestaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaToolStripMenuItem.Click
        Dim num1 As Integer = Val(TextBox3.Text)
        Dim num2 As Integer = Val(TextBox4.Text)
        Dim dat1 As String = "resta"
        calculadora(num1, num2, dat1)

        Label4.Text = total.ToString()
    End Sub
End Class