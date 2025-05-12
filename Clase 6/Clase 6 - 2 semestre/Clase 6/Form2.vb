Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ComboBox1.SelectedIndex > -1) Then
            ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nueva opcion compañeros")
        ComboBox1.Items.Add("opcion 1")
        ComboBox1.Items.Add("opcion 2")
        ComboBox1.Items.Add("opcion 3")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class