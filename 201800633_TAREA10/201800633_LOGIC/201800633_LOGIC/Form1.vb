Imports System.Math
Public Class Form1
    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If txtdpi.Text = Nothing And txtnombre.Text = Nothing And txtvalor.Text = Nothing And txtmeses.Text = Nothing Then
            MsgBox("LOS CAMPOS ESTÁN VACÍOS")
            Exit Sub
        End If

        If index < 7 Then
            'Datos de entrada
            dpi(index) = txtdpi.Text
            nombre(index) = txtnombre.Text
            valor(index) = txtvalor.Text
            meses(index) = txtmeses.Text
            'Datos a calcular
            tasa(index) = calcular_tasa(Val(txtmeses.Text), Val(txtvalor.Text))
            monto_final(index) = Round(Val(txtvalor.Text) + Val(tasa(index)) * Val(txtvalor.Text), 2)
            index = index + 1
        Else
            MsgBox("LOS VECTORES ESTÁN LLENOS")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To index - 1

            DataGridView1.Rows.Add(dpi(i), nombre(i), valor(i), meses(i), tasa(i), monto_final(i))

        Next

    End Sub

    Private Sub OperarAscendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarAscendentementeToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6
        For i = 0 To 5
            For j = i + 1 To 6
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (dpi(j) <> Nothing) Then
                    If (dpi(i) > dpi(j)) Then
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DPI
                        temp1 = dpi(i)
                        dpi(i) = dpi(j)
                        dpi(j) = temp1
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DE NOMBRE
                        temp2 = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp2
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR VALOR
                        temp3 = valor(i)
                        valor(i) = valor(j)
                        valor(j) = temp3
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR MESES
                        temp4 = meses(i)
                        meses(i) = meses(j)
                        meses(j) = temp4
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TASA
                        temp5 = tasa(i)
                        tasa(i) = tasa(j)
                        tasa(j) = temp5
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TOTAL
                        temp6 = monto_final(i)
                        monto_final(i) = monto_final(j)
                        monto_final(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub OrdenarDescendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendentementeToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6
        For i = 0 To 5
            For j = i + 1 To 6
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (dpi(j) <> Nothing) Then
                    If (dpi(i) < dpi(j)) Then
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DPI
                        temp1 = dpi(i)
                        dpi(i) = dpi(j)
                        dpi(j) = temp1
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR DE NOMBRE
                        temp2 = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp2
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR VALOR
                        temp3 = valor(i)
                        valor(i) = valor(j)
                        valor(j) = temp3
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR MESES
                        temp4 = meses(i)
                        meses(i) = meses(j)
                        meses(j) = temp4
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TASA
                        temp5 = tasa(i)
                        tasa(i) = tasa(j)
                        tasa(j) = temp5
                        'EN ESTAS TRES INSTRUCCIONES SE HACE EL INTERCAMBIO DE LOS VALORES EN EL VECTOR TOTAL
                        temp6 = monto_final(i)
                        monto_final(i) = monto_final(j)
                        monto_final(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub
End Class
