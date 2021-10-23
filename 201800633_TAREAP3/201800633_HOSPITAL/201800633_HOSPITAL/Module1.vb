Module Module1
    Public matriz(6, 9) As String
    Public index = 0

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub

    Sub limpiar_entradas()
        'procedimiento que limpia los objetos de entrada
        Form1.txtnit.Clear()
        Form1.txtnombre.Clear()
        Form1.txtdias.Clear()
        Form1.txthonorarios.Clear()
        Form1.txttotalprivada.Clear()
        Form1.CBhabitacion.Text = ""
        Form1.CBpago.Text = ""
        Form1.txtnit.Focus()
    End Sub

    Sub limpiar_estadisticas()
        'En este proceso se limpian las cajas de texto donde se encuentras las tres estadísticas y totales
        'de las columnas del datagridview
        Form1.txttotalprivada.Clear()
        Form1.txttotalACH.Clear()
        Form1.txttotaldiasnoprivada.Clear()
        Form1.txttotalprivada.Focus()
    End Sub
End Module
