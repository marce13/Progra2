Imports System.Math
Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBmarca.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBmarca.Items.Add("Honda")
        CBmarca.Items.Add("Mercedes Benz")
        CBmarca.Items.Add("Toyota")
        CBmarca.Items.Add("Mazda")
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        'Verificación de datos
        If CBmarca.SelectedItem = "" Or txtdias.Text = "" Or txtnit.Text = "" Or txtplaca.Text = "" Then
            MsgBox("Error, no sea ha ingresado datos")
        End If
        If txtporcenefectivo.Text = "" Or txtporcentarjeta.Text = "" Then
            MsgBox("Error no se ha ingreso el porcentaje a pagar")
        End If

        If Val(txtporcenefectivo.Text) + Val(txtporcentarjeta.Text) = 100 Then
        Else
            MsgBox("Error, los porcentajes ingresados no suman 100")
        End If
        'Envío de datos
        If indice < 6 Then
            marca(indice) = CBmarca.SelectedItem
            pagoparcial(indice) = Val(txtdias.Text) * calculopagoparcial(marca(indice))
            descuento(indice) = calculodescuentorecargo()
            pagofinal(indice) = pago_final()
            dias(indice) = Val(txtdias.Text)
            placa(indice) = txtplaca.Text

            LBplaca.Items.Add(placa(indice))
            LBmarca.Items.Add(marca(indice))
            LBdias.Items.Add(dias(indice))
            LBpagoparcial.Items.Add(pagoparcial(indice))
            LBdescuento.Items.Add(descuento(indice))
            LBpagofinal.Items.Add(pagofinal(indice))
        ElseIf indice >= 6 Then
            MsgBox("MEMORIA LLENA")
        End If
    End Sub
End Class
