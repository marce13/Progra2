Public Class Form1
    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LIMPIAR_VECTORES()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_VECTORES()
        End If
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim deducible = 0.06
        Label14.Text = txtmonto.Text * deducible
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        DGVresultados.Rows.Add()
        DGVresultados(0, 0).Value = txtedad.Text
        DGVresultados(1, 0).Value = CBgenero.Text
        DGVresultados(2, 0).Value = CBcodigo.Text
        DGVresultados(3, 0).Value = txtmonto.Text
        DGVresultados(4, 0).Value = CBtaller.Text
        DGVresultados(5, 0).Value = Label14.Text
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If FILA <= 6 Then
            MONTO(FILA) = Val(txtmonto.Text)
            CODIGO(FILA) = CBcodigo.Text
            EDAD(FILA) = Val(txtedad.Text)
            GENERO(FILA) = CBgenero.Text
            TALLER(FILA) = CBtaller.Text
            FILA = FILA + 1
        End If
        inicializar_datos()
        If FILA = 7 Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub
End Class
