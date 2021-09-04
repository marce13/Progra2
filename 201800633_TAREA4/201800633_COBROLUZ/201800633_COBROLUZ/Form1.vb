Imports System.Math
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub SALIDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIDAToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combservicio.Items.Add("RESIDENCIAL")
        Combservicio.Items.Add("INDUSTRIAL")
        Combtarifa.Items.Add("SOCIAL")
        Combtarifa.Items.Add("NO SOCIAL")

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (txtnombre.Text = "") Then
            MsgBox("INGRESE SU NOMBRE", vbQuestion)
            LIMPIAR_ENTRADAS()
            Exit Sub
            txtnombre.Focus()
        End If

        If (txtnit.Text = "") Then
            MsgBox("INGRESE SU NIT", vbQuestion)
            LIMPIAR_ENTRADAS()
            Exit Sub
            txtnombre.Focus()
        End If

        If (txtconsumo.Text = "") Then
            MsgBox("INGRESE EL CONSUMO DE ENERGÍA ELÉCTRICA EN KILOWATTS", vbQuestion)
            LIMPIAR_ENTRADAS()
            Exit Sub
            txtnombre.Focus()
        End If

        If (txtsaldoanterior.Text = "") Then
            MsgBox("INGRESE SALDO ANTERIOR", vbQuestion)
            LIMPIAR_ENTRADAS()
            Exit Sub
            txtnombre.Focus()
        End If

        If (INDICE < 11) Then
            CLIENTE(INDICE) = txtnombre.Text
            TIPO_SERVICIO(INDICE) = Combservicio.Text
            TIPO_TARIFA(INDICE) = Combtarifa.Text
            SALDO_ANTERIOR(INDICE) = txtsaldoanterior.Text
            If Str(Combservicio.Text = "RESIDENCIAL") Then
                Select Case Val(txtconsumo.Text)
                    Case 1 To 100
                        PAGOINICIAL = Val(txtconsumo.Text) * RESIDENCIAL1
                    Case 101 To 300
                        PAGOINICIAL = Val(txtconsumo.Text) * RESIDENCIAL2
                    Case >= 301
                        PAGOINICIAL = Val(txtconsumo.Text) * RESIDENCIAL3
                End Select
                PAGO_INICIAL(INDICE) = Math.Round(PAGOINICIAL, 2)
            End If
            If Str(Combservicio.Text = "INDUSTRIAL") Then
                Select Case Val(txtconsumo.Text)
                    Case 1 To 100
                        PAGOINICIAL = Val(txtconsumo.Text) * INDUSTRIAL1
                    Case 101 To 300
                        PAGOINICIAL = Val(txtconsumo.Text) * INDUSTRIAL2
                    Case >= 301
                        PAGOINICIAL = Val(txtconsumo.Text) * INDUSTRIAL3
                End Select
                PAGO_INICIAL(INDICE) = Math.Round(PAGOINICIAL, 2)
            End If
            If Val(txtsaldoanterior.Text) > 0 Then
                RECARGO = (Val(txtsaldoanterior.Text) * MORA_APLI)
                MORA(INDICE) = (MORA_APLI * 100).ToString + "%"
            ElseIf Val(txtsaldoanterior.Text) <= 0 Then
                MORA(INDICE) = "NO SE APLICA MORA"
            End If
            PAGOCONMORA = Val(txtsaldoanterior.Text) + RECARGO
            PAGO_MORA(INDICE) = Math.Round(PAGOCONMORA, 2)

            Select Case Combtarifa.Text
                Case "SOCIAL"
                    PAGOPARCIAL = (Val(txtsaldoanterior.Text) + PAGOINICIAL + RECARGO)
                    PAGO_PARCIAL(INDICE) = PAGOPARCIAL
                    TARIFATOTAL = PAGOPARCIAL * DESC_SOCIAL
                    DESCUENTO(INDICE) = (DESC_SOCIAL * 100).ToString + "%"
                    PAGOFINAL = PAGOPARCIAL - TARIFATOTAL
                    PAGO_TOTAL(INDICE) = Math.Round(PAGOFINAL, 2)
                Case "NO SOCIAL"
                    TARIFATOTAL = PAGOINICIAL - (PAGOINICIAL * DESC_NOSOCIAL)
                    DESCUENTO(INDICE) = (DESC_NOSOCIAL * 100).ToString + "%"
                    PAGO_INICIAL(INDICE) = Math.Round(TARIFATOTAL, 2)
                    PAGOPARCIAL = TARIFATOTAL + PAGOCONMORA
                    PAGO_PARCIAL(INDICE) = Math.Round(PAGOPARCIAL, 2)
                    PAGOFINAL = PAGOPARCIAL
                    PAGO_TOTAL(INDICE) = Math.Round(PAGOFINAL, 2)
            End Select
            MOSTRAR_VECTORES()
            INDICE = INDICE + 1
        End If
        If (INDICE > 10) Then
            MsgBox("SE HA ALCANZADO EL LÍMITE DEL INGRESO DE 11 CLIENTES")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
