Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Blimpiarvec.Click
        indice = 0
        Cine.Items.Clear()
        Funcion.Items.Clear()
        SubTotal.Items.Clear()
        Descuento1.Items.Clear()
        Descuento2.Items.Clear()
        Total.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Baceptar.Click
        MsgBox(calcularSubtotal("1", "A"))

        'verificación de los datos 
        If ComboBcine.SelectedItem = "" Or ComboBfuncion.SelectedItem = "" Or txtcantidad.Text = "" Then
            MsgBox("Los campos estan vacíos")
            Exit Sub
        End If

        'Envio de la funcion y cine
        If indice < 9 Then
            efuncion(indice) = ComboBfuncion.SelectedItem
            ecine(indice) = ComboBcine.SelectedItem
            subtotal_a_pagar(indice) = Val(txtcantidad.Text) * calcularSubtotal(efuncion(indice), ecine(indice))
            edescuento1(indice) = subtotal_a_pagar(indice) * calculoDescuento1(efuncion(indice), ecine(indice))
            edescuento2(indice) = subtotal_a_pagar(indice) * calculoDescuento2(subtotal_a_pagar(indice))
            total_a_pagar(indice) = subtotal_a_pagar(indice) - (edescuento1(indice) + edescuento2(indice))

            Funcion.Items.Add(efuncion(indice))
            Cine.Items.Add(ecine(indice))
            SubTotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(edescuento1(indice))
            Descuento2.Items.Add(edescuento2(indice))
            Total.Items.Add(total_a_pagar(indice))
        ElseIf indice >= 9 Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Blimpiaren.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Bsalida.Click
        If (MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub
End Class
