

Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1
    'decalaramos nuestras variables constantes
    Private Const cost_espada As Integer = 100
    Private Const cost_arco As Integer = 80
    Private Const cost_lanza As Integer = 90
    Private Const cost_guantes As Integer = 10
    Private Const cost_pantalones As Integer = 20
    Private Const cost_armadura As Integer = 50
    Private Const descuento_or As Double = 0.05
    Dim descuentos As Double

    Public usuario As String


    Dim total As Double = 0
    Dim subtotal As Double = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Bienvenido : " & usuario
        inicializar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calculos()
    End Sub
    Private Sub inicializar()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False

        Checkguantes.Checked = False
        Checkpantalones.Checked = False
        Checkarmadura.Checked = False

        ListBox1.Items.Clear()
    End Sub
    Private Sub calculos()

        total = 0
        subtotal = 0

        If Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
            MessageBox.Show("Por favor, seleccione un tipo de arma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not (RadioButton4.Checked Or RadioButton5.Checked) Then
            MessageBox.Show("Por favor, seleccione un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If RadioButton1.Checked Then
            total += cost_lanza
        ElseIf RadioButton2.Checked Then
            total += cost_arco
        ElseIf RadioButton3.Checked Then
            total += cost_espada
        End If

        If RadioButton4.Checked Then
            descuentos = total * descuento_or
        ElseIf RadioButton5.Checked Then
            descuentos = 0
        End If


        If Checkguantes.Checked Then
            total += cost_guantes
        End If
        If Checkpantalones.Checked Then
            total += cost_pantalones
        End If
        If Checkarmadura.Checked Then
            total += cost_armadura
        End If

        subtotal = total
        total = subtotal - descuentos

        ListBox1.Items.Add("-----------------------------------------")
        ListBox1.Items.Add("Subtotal: $" & subtotal.ToString("0.00"))
        ListBox1.Items.Add("Descuento: -$" & descuentos.ToString("0.00"))
        ListBox1.Items.Add("Total a pagar: $" & total.ToString("0.00"))
        ListBox1.Items.Add("**************************************")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inicializar()
    End Sub
End Class
