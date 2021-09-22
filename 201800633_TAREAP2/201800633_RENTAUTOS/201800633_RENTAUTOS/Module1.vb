Imports System.Math
Module Module1
    Public indice As Byte = 0
    Public placa(6) As String
    Public marca(6) As String
    Public dias(6) As Double
    Public formapago(6) As String
    Public descuento(6) As Double
    Public pagoparcial(6) As Double
    Public pagofinal(6) As Double
    Public Const efectivo = 0.05
    Public Const tarjeta = 0.025
    Public calculo_pagoparcial As Double = 0

    Sub LIMPIAR_ENTRADAS()
        Form1.CBmarca.SelectedIndex = -1
        Form1.txtdias.Clear()
        Form1.txtnit.Clear()
        Form1.txtplaca.Clear()
        Form1.txtporcenefectivo.Clear()
        Form1.txtporcentarjeta.Clear()
        Form1.txtnit.Focus()
        indice = 0
    End Sub

    Sub LIMPIAR_VECTORES()
        'LIMPIAR LA VARIABLE QUE CONTROLA LOS INGRESOS DE LOS VECTORES
        indice = 0
        'SE PROCEDE A LIMPIAR LOS LISTBOX
        Form1.LBplaca.Items.Clear()
        Form1.LBmarca.Items.Clear()
        Form1.LBdias.Items.Clear()
        Form1.LBpagoparcial.Items.Clear()
        Form1.LBdescuento.Items.Clear()
        Form1.LBpagofinal.Items.Clear()
    End Sub
    Function calculopagoparcial(marca As String) As Double
        Select Case marca
            Case "Honda"
                calculo_pagoparcial = 250
            Case "Mercedes Benz"
                calculo_pagoparcial = 450
            Case "Toyota"
                calculo_pagoparcial = 350
            Case "Mazda"
                calculo_pagoparcial = 300
        End Select
        Return calculo_pagoparcial
    End Function

    Function calculodescuentorecargo() As Double
        Dim descuento As Double
        Dim recargo As Double

        If (Form1.CheckBefectivo.Checked) Then
            If Form1.txtporcenefectivo.Text = "100" Then
                formapago(indice) = Form1.CheckBefectivo.Text
                descuento = pagoparcial(indice) * efectivo
                Return descuento * -1
            End If
        ElseIf (Form1.CheckBtarjeta.Checked) Then
            If Form1.txtporcentarjeta.Text = "100" Then
                formapago(indice) = Form1.CheckBtarjeta.Text
                recargo = pagoparcial(indice) * tarjeta
                Return recargo
            End If
        End If
        Return 0
    End Function

    Function pago_final() As Double
        pago_final = pagoparcial(indice) + descuento(indice)
        Return pago_final
    End Function
End Module
