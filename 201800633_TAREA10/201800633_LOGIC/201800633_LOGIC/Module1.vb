Imports System.Math
Module Module1
    Public dpi(6) As String
    Public nombre(6) As String
    Public valor(6) As String
    Public meses(6) As String
    Public tasa(6) As String
    Public monto_final(6) As String
    Public index As Integer = 0

    Public Function calcular_tasa(mesesF As Integer, valorF As Decimal) As Decimal
        If mesesF = 12 And valorF > 8000 Then
            Return 0.02
        ElseIf mesesF > 12 And mesesF <= 24 Then
            Return 0.045
        ElseIf mesesF > 24 And mesesF <= 36 Then
            Return 0.055
        ElseIf mesesF >= 36 Then
            Return 0.062
        ElseIf mesesF <= 12 Then
            Return 0.03
        End If

        Return 0
    End Function

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            'se mandan a llamar los procedimientos que limpian las entradas y que limpian las estadísticas
            limpiar_entradas()
            limpiar_vectores()
        End If
    End Sub

    Sub limpiar_entradas()
        'procedimiento donde se limpian los objetos donde se hacen los ingresos
        Form1.txtdpi.Clear()
        Form1.txtnombre.Clear()
        Form1.txtvalor.Clear()
        Form1.txtmeses.Clear()
        Form1.txtdpi.Focus()
    End Sub
    Sub limpiar_vectores()
        Dim J As Byte
        Dim i As Integer
        'Se limpia primero el datagrid donde se encuentran los datos
        Form1.DataGridView1.Rows.Clear()
        index = 0
        J = 0
        While (J <= 6)
            dpi(i) = Nothing
            nombre(i) = Nothing
            valor(i) = Nothing
            meses(i) = Nothing
            tasa(i) = Nothing
            monto_final(i) = Nothing
            J = J + 1
        End While
    End Sub

End Module
