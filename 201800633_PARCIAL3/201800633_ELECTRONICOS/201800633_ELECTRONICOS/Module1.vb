Imports System.Math
Module Module1
    Public index = 0
    Public MATRIZ(6, 9) As String

    Sub limpiar_entradas()
        'procedimiento que limpia los objetos de entrada
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox1.Focus()
    End Sub

    Sub limpiar_matriz()
        Form1.DataGridView1.Rows.Clear()
        For fila As Integer = 0 To 5
            For columna As Integer = 0 To 8
                MATRIZ(fila, columna) = Nothing
            Next
        Next
    End Sub

    Sub limpiar_tabla()
        Form1.DataGridView1.Rows.Clear()
    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub

    Sub limpiar_estadisticas()
        'En este proceso se limpian las cajas de texto donde se encuentras las tres estadísticas y totales
        'de las columnas del datagridview
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox4.Focus()
    End Sub
    Sub Mostrar_Matriz()
        For fila As Integer = 0 To 5
            If (MATRIZ(fila, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(MATRIZ(fila, 0), MATRIZ(fila, 1), MATRIZ(fila, 2), MATRIZ(fila, 3), MATRIZ(fila, 4), MATRIZ(fila, 5), MATRIZ(fila, 6), MATRIZ(fila, 7), MATRIZ(fila, 8))
            End If
            fila = fila + 1
        Next
    End Sub
End Module
