Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub LimpiarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTablaToolStripMenuItem.Click
        limpiar_tabla()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("L01")
        ComboBox1.Items.Add("L02")
        ComboBox1.Items.Add("L03")
        ComboBox1.Items.Add("L04")
        ComboBox1.Items.Add("L05")
        ComboBox1.Items.Add("L06")
        ComboBox2.Items.Add("Memoria RAM")
        ComboBox2.Items.Add("Disco Duro")
        ComboBox2.Items.Add("Procesador")
        ComboBox2.Items.Add("Motherboard")
        ComboBox2.Items.Add("Tarjeta Gráfica")
        ComboBox2.Items.Add("SSD")
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Los campos estan vacios")
            Exit Sub
        End If

        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("Seleccione un código de producto")
            Exit Sub
        End If
        If (ComboBox2.SelectedIndex = -1) Then
            MsgBox("Seleccione un Nombre de producto")
            Exit Sub
        End If

        For fila As Integer = 0 To 5
            If (MATRIZ(fila, 0) <> Nothing) Then
                If (MATRIZ(fila, 0) = ComboBox1.Text) Then
                    MsgBox("Ya existe ese código de producto registrado")
                    Exit Sub
                End If
            End If
        Next

        If Index < 6 Then
            'código del producto en columna 0
            MATRIZ(index, 0) = ComboBox1.Text
            'Nombre del producto en columna 1
            MATRIZ(index, 1) = ComboBox2.Text
            'Precio por unidad en columna 2
            MATRIZ(index, 2) = TextBox1.Text
            'Cantidad de unidades defectuosas en la columna 3
            MATRIZ(index, 3) = TextBox2.Text
            'Cantidad de unidades aprobadas en la colunna 4
            MATRIZ(index, 4) = TextBox3.Text

            'Cantidad de unidades aprobadas * el precio por unidad en la columna 5
            Select Case ComboBox1.Text
                Case "L01"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
                Case "L02"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
                Case "L03"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
                Case "L04"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
                Case "L05"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
                Case "L06"
                    MATRIZ(index, 5) = Val(TextBox1.Text) * Val(TextBox3.Text)
            End Select
            'Calculo de Pérdida con el descuento en la columna 6
            If TextBox2.Text > 0 Then
                MATRIZ(index, 6) = Str(Round(Val(TextBox2.Text) * Val(TextBox1.Text) * 0.75, 2))
            End If

            'Calculo de total en la columna 7
            MATRIZ(index, 7) = Str(Round(Val(MATRIZ(index, 5)) - Val(MATRIZ(index, 6)), 2))

            'Sello de calidad en la columna 8
            If TextBox2.Text = 0 Then
                MATRIZ(index, 8) = "Sí"
            Else
                MATRIZ(index, 8) = "NO"
            End If
            MsgBox("Se almacenarán los siguientes valores " + MATRIZ(index, 0) + MATRIZ(index, 1) + MATRIZ(index, 2) + MATRIZ(index, 3) + MATRIZ(index, 4) + MATRIZ(index, 5) + MATRIZ(index, 6) + MATRIZ(index, 7) + MATRIZ(index, 8))
            index = index + 1
        End If
        If index = 6 Then
            MsgBox("La matriz llegó al límite de productos, limpiarla para más registros")
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("No seleccionó Código de producto")
            Exit Sub
        End If

        Dim encontro = False

        For fila As Integer = 0 To 5
            If (MATRIZ(fila, 0) <> Nothing) Then
                If (MATRIZ(fila, 0) = ComboBox1.Text) Then
                    ComboBox2.Text = MATRIZ(fila, 1)
                    TextBox1.Text = MATRIZ(fila, 2)
                    TextBox2.Text = MATRIZ(fila, 3)
                    TextBox3.Text = MATRIZ(fila, 4)
                    encontro = True
                End If
            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el código de producto")
        ElseIf encontro = True Then
            MsgBox("Se encontró el código de producto")
        End If
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Dim fila As Integer = 0
        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        While fila < 6
            If (MATRIZ(fila, 0) <> Nothing) Then

                If MATRIZ(fila, 8) = "Sí" Then
                    estadistica1 = estadistica1 + 1
                End If

                If Val(MATRIZ(fila, 3)) > Val(MATRIZ(fila, 4)) Then
                    estadistica2 = estadistica2 + 1
                End If

                If Val(MATRIZ(fila, 3)) >= 1 Then
                    estadistica3 = estadistica3 + 1
                End If
            End If
            fila = fila + 1
        End While
        TextBox4.Text = estadistica1
        TextBox5.Text = estadistica2
        TextBox6.Text = estadistica3
    End Sub
End Class
