Module Module1
    Public efuncion(8)
    Public ecine(8)
    Public total_a_pagar(8)
    Public subtotal_a_pagar(8)
    Public edescuento1(8)
    Public edescuento2(8)

    Public indice = 0

    'Variables para retornar a calculo
    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0
    Public calculo_desc2 As Double = 0
    Public calculo_total As Double = 0

    Function calcularSubtotal(funcion As String, cine As String) As Double
        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 44
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select
        End Select
        Return calculo_subtotal
    End Function

    Function calculoDescuento1(funcion As String, cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculo_desc1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculo_desc1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculo_desc1 = 0.015
        End If
        Return calculo_desc1
    End Function

    Function calculoDescuento2(subtotal2 As Double)
        If subtotal2 >= 100 And subtotal2 <= 300 Then
            calculo_desc2 = 0.02
        ElseIf subtotal2 > 300 And subtotal2 <= 500 Then
            calculo_desc2 = 0.04
        ElseIf subtotal2 > 500 And subtotal2 <= 1000 Then
            calculo_desc2 = 0.06
        End If
        Return calculo_desc2
    End Function

    Sub LIMPIAR_ENTRADAS()
        Form1.ComboBcine.Text = ""
        Form1.ComboBfuncion.Text = ""
        Form1.txtcantidad.Clear()
        Form1.txtcantidad.Focus()
    End Sub


End Module
