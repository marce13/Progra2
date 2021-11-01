Imports System.Math
Module Module1
    Public matriz(6, 5) As String
    Public etapa(12) As String
    Public equipo(12) As String
    Public kilometros_recorridos(12) As Integer
    Public tiempo(12) As Integer
    Public nacionalidad(12) As String
    Public penalizacion(12) As Integer
    'variable que sirve para el control en el proceso de eliminar un registro de los vectores
    Public elimina As Byte
    'Variable que se utilizará para controlar los ingresos en cada fila de los vectores
    Public fila As Byte = 0
    'Variable que se utilizará para algunos de los ciclos For de ciertos procesos
    Public I As Byte
    Sub Mostrar_vectores()
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        While (I <= 5)

            If (matriz(I, 5) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(matriz(fila, 0)), matriz(fila, 1), (matriz(fila, 2)), (matriz(fila, 3)), (matriz(fila, 4)), (matriz(fila, 5)))
                fila = fila + 1
            Else
                Exit While
            End If
        End While
    End Sub


    Sub limpiar_entradas()
        'procedimiento donde se limpian los objetos donde se hacen los ingresos
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.TextBox1.Focus()
    End Sub

    Sub limpiar_estadisticas()
        'En este proceso se limpian las cajas de texto donde se encuentras las tres estadísticas y totales
        'de las columnas del datagridview
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox4.Focus()
    End Sub

    Sub limpiar_vectores()
        Dim J As Byte
        'Se limpia primero el datagrid donde se encuentran los datos
        Form1.DataGridView1.Rows.Clear()
        'Se inicializa a cero la variable que controla las filas de ingreso de datos a los vectores
        'para dejarla lista para  5 nuevos ingresos
        fila = 0
        J = 0
        While (J <= 11)
            etapa(I) = Nothing
            equipo(I) = Nothing
            kilometros_recorridos(I) = Nothing
            tiempo(I) = Nothing
            nacionalidad(I) = Nothing
            penalizacion(I) = Nothing
            J = J + 1    'si no se coloca esta instrucción, el ciclo se vuelve infinito
            'la instrucción anterior controla que en algún momento la condición del ciclo while se vuelva falsa y se salga del ciclo
        End While

    End Sub
    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            'se mandan a llamar los procedimientos que limpian las entradas y que limpian las estadísticas
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub
End Module
