Imports System.Math
Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sky")
        ComboBox1.Items.Add("Movistar")
        ComboBox1.Items.Add("Pro Cycling")
        ComboBox1.Items.Add("Pro Team")
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticasToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        Dim estadistica1 = 0
        Dim estadistica2 = 0
        Dim estadistica3 = 0

        Select Case RadioButton1.Checked
            Case "guatemalteco"
                If (matriz(fila, 4)) = "guatemalteco" Then
                    matriz(fila, 4) = Val(matriz(fila, 4) + 1)
                    estadistica1 = estadistica1 + 1
                    TextBox4.Text = Val(estadistica1)
                End If
        End Select

        Select Case ComboBox1.Text
            Case "Movistar"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)
            Case "Sky"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)
            Case "Pro Cycling"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)
            Case "Pro Team"
                estadistica2 = Val(TextBox2.Text) + matriz(fila, 2)

                TextBox5.Text = estadistica2
        End Select

        If ComboBox1.Text = "Movistar" Then
            estadistica3 = Val(TextBox3.Text) + Val(matriz(fila, 3))
        End If
        If ComboBox1.Text = "Sky" Then
            estadistica3 = Val(TextBox3.Text) + Val(matriz(fila, 3))
        End If
        If ComboBox1.Text = "Pro Cycling" Then
            estadistica3 = Val(TextBox3.Text) + Val(matriz(fila, 3))
        End If
        If ComboBox1.Text = "Pro Team" Then
            estadistica3 = Val(TextBox3.Text) + Val(matriz(fila, 3))
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Los campos están vacíos")
            Exit Sub
        End If
        If ComboBox1.SelectedIndex < -1 Then
            MsgBox("Seleccone un equipo")
            Exit Sub
        End If

        If fila < 6 Then
            'Columna 0 es etapa
            matriz(fila, 0) = TextBox1.Text
            'Columna 1 es equipo
            matriz(fila, 1) = ComboBox1.Text
            'Columna 2 es km
            matriz(fila, 2) = TextBox2.Text
            'Columna 3 es tiempo
            matriz(fila, 3) = TextBox3.Text
            'Columna 4 es nacionalidad
            If RadioButton1.Checked Then
                matriz(fila, 4) = "guatemalteco"
            End If
            If RadioButton2.Checked Then
                matriz(fila, 4) = "extranjero"
            End If
            'Columna 5 total de penalizacion
            Select Case ComboBox1.Text
                Case "Movistar"
                    If Val(TextBox3.Text) < 85 Then
                        matriz(fila, 5) = Val(TextBox3.Text) - 15
                    End If
                Case "Pro Team"
                    matriz(fila, 5) = Val(TextBox3.Text) - 10
            End Select

            fila = fila + 1
        Else
            MsgBox("Matriz llena")
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        For fila = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If matriz(fila, 0) = TextBox1.Text Then
                    ComboBox1.Text = matriz(fila, 1)
                    TextBox2.Text = matriz(fila, 2)
                    TextBox3.Text = matriz(fila, 3)
                    RadioButton1.Text = matriz(fila, 4)
                    RadioButton2.Text = matriz(fila, 4)
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        matriz(fila, 0) = TextBox1.Text
        matriz(fila, 1) = ComboBox1.Text
        matriz(fila, 2) = TextBox2.Text
        matriz(fila, 3) = TextBox6.Text
        If RadioButton1.Checked Then
            matriz(fila, 4) = "guatemalteco"
        End If
        If RadioButton2.Checked Then
            matriz(fila, 4) = "extranjero"
        End If
        MsgBox("Registro actualizado correctamente en la matriz")
    End Sub
End Class
