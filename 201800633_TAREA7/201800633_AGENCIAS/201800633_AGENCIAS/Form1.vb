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
        txtcond25.Clear()
        txtcondfem.Clear()
        txtcondmasc.Clear()
        txtcondextran.Clear()
        txtcondingre.Clear()
        txtmontodaños.Clear()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        txtdeducible.Text = Val(txtmonto.Text) * 0.06
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Dim X As Byte
        DGVresultados.Rows.Clear()
        For X = 0 To 7
            If EDAD(X) <> Nothing Then
                DGVresultados.Rows.Add(Str(EDAD(X)), GENERO(X), CODIGO(X), MONTO(X), TALLER(X), DEDUCIBLE(X))
            Else
                Exit For
            End If
        Next X
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If FILA <= 6 Then
            MONTO(FILA) = Val(txtmonto.Text)
            CODIGO(FILA) = CBcodigo.Text
            EDAD(FILA) = Val(txtedad.Text)
            GENERO(FILA) = CBgenero.Text
            TALLER(FILA) = CBtaller.Text
            DEDUCIBLE(FILA) = txtdeducible.Text
            FILA = FILA + 1
        End If
        inicializar_datos()
        If FILA = 7 Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub Bestadisticas_Click(sender As Object, e As EventArgs) Handles Bestadisticas.Click
        Dim J As Byte
        Dim R1 As Byte = 0
        Dim R2 As Byte = 0
        Dim R3 As Byte = 0
        Dim R4 As Byte = 0
        Dim R5 As Byte = 0
        Dim R6 As Byte = 0

        For K = 0 To DGVresultados.Rows.Count
            If (EDAD(J) < 25 And EDAD(J) > 0) Then
                R1 = R1 + 1
            End If
            If (GENERO(J) = "F") Then
                R2 = R2 + 1
            End If
            If (EDAD(J) > 18 And EDAD(J) < 25 And GENERO(J) = "M") Then
                R3 = R3 + 1
            End If
            If CODIGO(J) = "0" Then
                R4 = R4 + 1
            End If
            If MONTO(J) <> 0 Then
                R6 = R6 + 1
            End If
        Next
        txtcond25.Text = Str(R1)
        txtcondfem.Text = Str(R2)
        txtcondmasc.Text = Str(R3)
        txtcondextran.Text = Str(R4)
        txtcondingre.Text = Str(DGVresultados.Rows.Count - 1)
        txtmontodaños.Text = Str(R6)
    End Sub
End Class
