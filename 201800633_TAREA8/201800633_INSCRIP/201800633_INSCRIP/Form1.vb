Imports System.Math
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LimpiarTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTotalesToolStripMenuItem.Click
        LIMPIAR_TOTALES()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        SALIR()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GUARDAR()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        MOSTRAR()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        LIMPIAR_MATRIZ()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If RBbasico.Checked = True Then
            pagoinicial = basico_inscripcion + basico_primera
            If CBformapago.SelectedItem = "Tarjeta de crédito" Then
                pagofinal = pagoinicial + pagoinicial * 0.1
            End If
        Else
            Exit Sub
        End If

        If RBdiversificado.Checked = True Then
            pagoinicial = diversificado_inscripcion + diversificado_primera
            If CBformapago.SelectedItem = "Tarjeta de crédito" Then
                pagofinal = pagoinicial + pagoinicial * 0.1
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub TotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesToolStripMenuItem.Click

        Dim totalnivel As Double
        Dim totalinscritos As Double

        If RBbasico.Checked Then
            totalnivel = totalnivel + Val(nivelestudio(fila, 4))
            txttotalnivel.Text = Str(totalnivel)
        ElseIf RBdiversificado.Checked Then
            totalnivel = totalnivel + Val(nivelestudio(fila, 4))
            txttotalnivel.Text = Str(totalnivel)
        End If
        If CBcarrera.Text = "Perito contador" Then
            totalinscritos = totalinscritos + Val(nivelestudio(fila, 3))
            txttotalinscritos.Text = Str(totalinscritos)
        ElseIf CBcarrera.Text = "Bachillerato" Then
            totalinscritos = totalinscritos + Val(nivelestudio(fila, 3))
            txttotalinscritos.Text = Str(totalinscritos)
        ElseIf CBcarrera.Text = "Electrónica" Then
            totalinscritos = totalinscritos + Val(nivelestudio(fila, 3))
            txttotalinscritos.Text = Str(totalinscritos)
        ElseIf CBcarrera.Text = "Diseño gráfico" Then
            totalinscritos = totalinscritos + Val(nivelestudio(fila, 3))
            txttotalinscritos.Text = Str(totalinscritos)
        End If
    End Sub
End Class
