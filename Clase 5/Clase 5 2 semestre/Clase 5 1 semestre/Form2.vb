Imports System.Formats
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro de que desea salir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre_empleado As String = TextBox1.Text
        Dim horas_Extras As Integer = Val(TextBox2.Text)
        Dim tarifa As Double = Double.Parse(TextBox3.Text)

        Dim pago As String = ComboBox2.SelectedItem.ToString().ToLower()
        Dim turno As String = ComboBox1.SelectedItem.ToString().ToLower()

        Dim op1_igss As Boolean = CheckBox1.Checked
        Dim op2_iva As Boolean = CheckBox2.Checked

        Dim fecha As Date = DateTimePicker1.Value


        pago_parcial = 0
        total = 0
        descuento = 0
        Recargo = 0
        bono = 0

        IGGS = 0
        IVA = 0
        deduccciones = 0

        pago_parcial = horas_Extras * tarifa

        'Mañana
        'Tarde
        'Noche
        If turno = "noche" Then
            bono += pago_parcial * 0.2
        End If

        Select Case pago
            Case "efectivo", "cheque"
                descuento += pago_parcial * 0.15
            Case "t_debito" ' t_debito
                Recargo += pago_parcial * 0.08
        End Select


        If op1_igss Then
            IGGS += pago_parcial * 0.0483
        End If

        If op2_iva Then
            IVA += pago_parcial * 0.12
        End If


        If fecha.DayOfWeek = DayOfWeek.Saturday Then
            bono += pago_parcial * 0.1
        End If

        total = pago_parcial - descuento + Recargo + bono

        deduccciones = IGGS + IVA
        ListBox1.Items.Add(nombre_empleado)

        ListBox2.Items.Add(turno)
        ListBox3.Items.Add(pago)
        ListBox4.Items.Add(fecha)
        ListBox5.Items.Add(pago_parcial)
        ListBox6.Items.Add(descuento)
        ListBox7.Items.Add(bono)
        ListBox8.Items.Add(deduccciones)
        ListBox9.Items.Add(Recargo)
        ListBox10.Items.Add(total)

    End Sub
End Class