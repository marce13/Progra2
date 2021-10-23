Imports System.Math
Public Class Form1
    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub CalculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoToolStripMenuItem.Click
        If (txtnit.Text = "") Or (txtnombre.Text = "") Or (txtdias.Text = "") Or (txthonorarios.Text = "") Then
            MsgBox("Los campos estan vacios")
            Exit Sub
        End If

        If (CBhabitacion.SelectedIndex = -1) Or (CBpago.SelectedIndex = -1) Then
            MsgBox("Seleccione un elemento")
            Exit Sub
        End If

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = txtnit.Text) Then
                    MsgBox("Ya existe ese NIT registrado")
                    Exit Sub
                End If
            End If
        Next

        If index < 6 Then
            'NIT en columna 0
            matriz(index, 0) = txtnit.Text
            'Nombre en columna 1
            matriz(index, 1) = txtnombre.Text
            'Dias hospitalizados en columna 2
            matriz(index, 2) = txtdias.Text
            'Honorarios en la columna 3
            matriz(index, 3) = txthonorarios.Text
            'Tipo hab en la colunna 4
            matriz(index, 4) = CBhabitacion.Text
            'Tipo hab en la colunna 5
            matriz(index, 5) = CBpago.Text

            'Total de dias * habitacion en la columna 6
            Select Case CBhabitacion.Text
                Case "Privada"
                    matriz(index, 6) = Val(txtdias.Text) * 350
                Case "Semiprivada"
                    matriz(index, 6) = Val(txtdias.Text) * 250
                Case "No privada"
                    matriz(index, 6) = Val(txtdias.Text) * 150
            End Select


            'Calculo de descuento/recargo en la columna 7
            Select Case CBpago.Text
                Case "Efectivo"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1
                Case "Depósito"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1
                Case "Transferencia"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.08 * -1
                Case "Tarjeta"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.015
            End Select

            'Calculo de total en la columna 8
            matriz(index, 8) = Val(matriz(index, 6)) + Val(matriz(index, 7))


            MsgBox("Se almacenarán los siguientes valores " + matriz(index, 0) + matriz(index, 1) + matriz(index, 2) + matriz(index, 3) + matriz(index, 4) + matriz(index, 5) + matriz(index, 6) + matriz(index, 7) + matriz(index, 8))
            index = index + 1

        Else
            MsgBox("La matriz llegó al límite de pacientes, limpiarla para más registros")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Dim fila As Integer = 0
        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then
                DGVdatos.Rows.Add(matriz(fila, 0), matriz(fila, 1), matriz(fila, 2), matriz(fila, 3), matriz(fila, 4), matriz(fila, 5), matriz(fila, 6), matriz(fila, 7), matriz(fila, 8))
            End If
            fila = fila + 1
        End While
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If txtnit.Text = "" Then
            MsgBox("No seleccionó NIT")
            Exit Sub
        End If

        Dim encontro = False

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = txtnit.Text) Then
                    txtnombre.Text = matriz(fila, 1)
                    txtdias.Text = matriz(fila, 2)
                    txthonorarios.Text = matriz(fila, 3)
                    CBhabitacion.Text = matriz(fila, 4)
                    CBpago.Text = matriz(fila, 5)
                    encontro = True
                End If
            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el paciente")
        ElseIf encontro = True Then
            MsgBox("Se encontró el paciente")
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        For fila As Integer = 0 To 5
            For columna As Integer = 0 To 8
                matriz(fila, columna) = Nothing
            Next
        Next
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Dim fila As Integer = 0
        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        While fila < 6
            If (matriz(fila, 0) <> Nothing) Then

                If matriz(fila, 4) = "Privada" Then
                    estadistica1 = estadistica1 + 1
                End If

                If matriz(fila, 5) = "Transferencia" Then
                    estadistica2 = estadistica2 + Val(matriz(fila, 8))
                End If

                If matriz(fila, 4) = "No privada" Then
                    estadistica3 = estadistica3 + Val(matriz(fila, 2))
                End If
            End If
            fila = fila + 1
        End While
        txttotalprivada.Text = estadistica1
        txttotalACH.Text = estadistica2
        txttotaldiasnoprivada.Text = estadistica3
    End Sub

    Private Sub LimpiarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTablaToolStripMenuItem.Click
        DGVdatos.Rows.Clear()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
End Class
