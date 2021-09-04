Imports System.Math
Module Module1
    Public INDICE As Byte = 0
    Public Const RESIDENCIAL1 As Double = 0.99
    Public Const RESIDENCIAL2 As Double = 1.2
    Public Const RESIDENCIAL3 As Double = 3.0
    Public Const INDUSTRIAL1 As Double = 1.99
    Public Const INDUSTRIAL2 As Double = 2.2
    Public Const INDUSTRIAL3 As Double = 4.0

    Public PAGOINICIAL As Double
    Public PAGOPARCIAL As Double
    Public PAGOPARCIAL1 As Double
    Public PAGOFINAL As Double
    Public PAGOFINAL1 As Double
    Public PAGOCONMORA As Double
    Public RECARGO As Double
    Public TARIFATOTAL As Double
    Public MORA_APLI As Double = 0.02
    Public DESC_SOCIAL = 0.2
    Public DESC_NOSOCIAL = 0.1


    'SE DEFINEN LOS VECTORES DONDE SE ALMACENARÁ CADA DATO RESPECTIVO Y SU TAMAÑO,
    'ESTE TAMAÑO SE REFIERE A QUE SON SOLO ONCE DATOS
    'QUE SE ALMACENARÁN EN CADA UNO, ES DECIR QUE EN LA PRIMERA POSICIÓN DE CADA VECTOR
    'SE ALMACENARÁ CADA INGRESO Y CÁLCULO REALIZADO Y ASÍ SUCESIVAMENTE
    Public CLIENTE(11) As String
    Public TIPO_SERVICIO(11) As String
    Public TIPO_TARIFA(11) As String
    Public SALDO_ANTERIOR(11) As Double
    Public PAGO_INICIAL(11) As Double
    Public MORA(11) As String
    Public PAGO_MORA(11) As String
    Public PAGO_PARCIAL(11) As Double
    Public DESCUENTO(11) As String
    Public PAGO_TOTAL(11) As Double


    Sub LIMPIAR_ENTRADAS()
        Form1.txtnombre.Clear()
        Form1.txtnit.Clear()
        Form1.txtsaldoanterior.Clear()
        Form1.txtconsumo.Clear()
        Form1.Combservicio.Text = ""
        Form1.Combtarifa.Text = ""
        Form1.txtnombre.Focus()
    End Sub

    Sub MOSTRAR_VECTORES()
        'SE MUESTRA EL CONTENIDO DEL VECTOR EN LISTBOX
        Form1.ListBcliente.Items.Add(CLIENTE(INDICE))
        Form1.ListBservicio.Items.Add(TIPO_SERVICIO(INDICE))
        Form1.ListBtarifa.Items.Add(TIPO_TARIFA(INDICE))
        Form1.ListBsaldoan.Items.Add(SALDO_ANTERIOR(INDICE))
        Form1.ListBpagoinicial.Items.Add(PAGO_INICIAL(INDICE))
        Form1.ListBmora.Items.Add(MORA(INDICE))
        Form1.ListBpagoconmora.Items.Add(PAGO_MORA(INDICE))
        Form1.ListBpagoparcial.Items.Add(PAGO_PARCIAL(INDICE))
        Form1.ListBdesc.Items.Add(DESCUENTO(INDICE))
        Form1.ListBpagototal.Items.Add(PAGO_TOTAL(INDICE))
    End Sub

    Sub LIMPIAR_VECTORES()
        INDICE = 0
        'SE PROCEDE A LIMPIAR LOS LISTBOX
        Form1.ListBcliente.Items.Clear()
        Form1.ListBservicio.Items.Clear()
        Form1.ListBtarifa.Items.Clear()
        Form1.ListBsaldoan.Items.Clear()
        Form1.ListBpagoinicial.Items.Clear()
        Form1.ListBmora.Items.Clear()
        Form1.ListBpagoconmora.Items.Clear()
        Form1.ListBpagoparcial.Items.Clear()
        Form1.ListBdesc.Items.Clear()
        Form1.ListBpagototal.Items.Clear()
    End Sub


End Module
