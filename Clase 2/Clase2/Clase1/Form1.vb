
Public Class Form1

    ' 3 tipos de pizzas
    ' 1 cant x pizza
    ' descuento por apertura del 5%
    ' descuento por ser constante 3%


    ' Leer el enunciado
    ' Identifiquen que variables a utilizar
    ' Relizar el código
    ' Interpretación a sus resultados

    Const precioPizzaHawaina As Integer = 80
    Const precioPizzaPeperoni As Integer = 60
    Const precioPizzaJamon As Integer = 75

    Dim descuento As Double = 0
    Dim descuentoapertura As Double = 0

    Dim total As Double = 0
    Dim subtotal As Double = 0
    Dim sumdescuentos As Double = 0

    Dim totalpzzas As Double = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Seguro quieres salir de la aplicación", "Confirmación", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        txtdescuento.Clear()


        ltotal.Text = "Q00.00"
        CheckBox1.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' INICIALIZANDO
        total = 0
        subtotal = 0
        sumdescuentos = 0
        descuento = 0
        descuentoapertura = 0
        totalpzzas = 0

        Dim cantPHawaina As Integer = 0
        Dim cantPPeporoni As Integer = 0
        Dim cantPPizzaJamon As Integer = 0

        If Val(TextBox1.Text) Then
            cantPHawaina = Val(TextBox1.Text)
        Else
            MessageBox.Show("Por favor ingresa un numero valido, no se acepta palabras")
        End If

        totalpzzas = (cantPHawaina * precioPizzaHawaina) + (cantPPeporoni * 0) + (cantPPizzaJamon * 0)

        descuentoapertura = totalpzzas * 0.05

        If CheckBox1.Checked Then
            descuento = totalpzzas * 0.03
        Else
            descuento = 0
        End If

        'Calculos
        subtotal = totalpzzas
        sumdescuentos = descuentoapertura + descuento
        total = Math.Round((subtotal - sumdescuentos), 2) ' 80.90656565 => 80.91

        txtdescuento.Text = "Q" & (sumdescuentos) ' 560.4585647 = 560.46
        ltotal.Text = "Q" & total


    End Sub


End Class
