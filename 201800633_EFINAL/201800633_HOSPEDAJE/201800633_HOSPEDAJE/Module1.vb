Imports System.Math
Module Module1
    Public Matriz(10, 7) As String
    Public FILA As Byte = 0
    Public I As Byte
    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            'se mandan a llamar los procedimientos que limpian las entradas y que limpian las estadísticas
            limpiar_entradas()
            limpiar_matriz()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox1.Focus()
    End Sub
    Sub limpiar_matriz()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
        I = 0

        While (I <= 9)
            Matriz(I, 0) = Nothing
            Matriz(I, 1) = Nothing
            Matriz(I, 2) = Nothing
            Matriz(I, 3) = Nothing
            Matriz(I, 4) = Nothing
            Matriz(I, 5) = Nothing
            Matriz(I, 6) = Nothing
            I = I + 1
        End While
    End Sub
    Sub mostrar_matriz()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 9
            'EL SIGUIENTE IF ES PARA PODER DETERMINAR QUE SI HAY DATOS EN LA POSICIÓN RESPECTIVA QUE LOS MUESTRE
            'DE LO CONTRARIO QUE NO HAGA NADA, ESTO SE HACE PORQUE A VECES DA ERROR AL QUERER MOSTRAR VALORES NULOS
            If Matriz(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Matriz(i, 0), Matriz(i, 1), Matriz(i, 2), Matriz(i, 3), Matriz(i, 4), Matriz(i, 5), Matriz(i, 6))
            Else
                Exit For
            End If
        Next i
    End Sub

End Module
