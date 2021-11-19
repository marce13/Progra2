Imports System.Math
Public Class Form1
    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()
        'SE LIMPIAN LOS CONTROLES DE ENTRADA POR SI SE HA QUEDADO ALGÚN DATO AÚN
        limpiar_entradas()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Simple")
        ComboBox1.Items.Add("Familiar")
        ComboBox1.Items.Add("Suite")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If (FILA <= 9) Then
            Matriz(FILA, 0) = TextBox1.Text
            Matriz(FILA, 1) = ComboBox1.Text
            Matriz(FILA, 2) = TextBox2.Text
            Matriz(FILA, 3) = TextBox3.Text
            Select Case ComboBox1.SelectedIndex
                Case 0 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 0)) * 150.0)
                Case 1 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 0)) * 400.0)
                Case 2 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 0)) * 750.0)
            End Select
            If (ComboBox1.Text = "Simple") And (Val(TextBox1.Text) >= 7) Then
                Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.1, 2)
                Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
            Else
                Matriz(FILA, 6) = Val(Matriz(FILA, 4))
            End If
            If (ComboBox1.Text = "Simple") And (Val(TextBox2.Text) > 3) Then
                Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.05, 2)
                Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) + Matriz(FILA, 5)), 2)
            Else
                Matriz(FILA, 6) = Val(Matriz(FILA, 4))
            End If
            If (ComboBox1.Text = "Familiar") And (Val(TextBox1.Text) >= 4) Then
                Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.07, 2)
                Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
            Else
                Matriz(FILA, 6) = Val(Matriz(FILA, 4))
            End If
            If (ComboBox1.Text = "Suite") And (Val(TextBox2.Text) = 2) And (Val(TextBox1.Text) > 15) Then
                Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.2, 2)
                Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
            Else
                Matriz(FILA, 6) = Val(Matriz(FILA, 4))
            End If
            FILA = FILA + 1
        End If
        If (FILA = 10) Then
            MsgBox("MATRIZ LLENA")
        End If
        limpiar_entradas()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        'SE DECLARAN LAS VARIABLES Y SE INICIALIZAN DE UNA VEZ
        I = 0
        Dim EXISTE As Boolean = True
        While (I <= 9) And (EXISTE)
            If (Val(Matriz(I, 0)) = Val(TextBox3.Text)) Then
                EXISTE = False
            Else
                I = I + 1
            End If
        End While
        If (EXISTE) Then
            MsgBox("Número de identificación no encontrado")
        Else
            TextBox1.Text = Matriz(I, 0)
            ComboBox1.Text = Matriz(I, 1)
            TextBox2.Text = Matriz(I, 2)
            'SE LIMPIA EL DATAGRIDVIEW PARA LUEGO MOSTRAR SOLAMENTE EL REGISTRO ENCONTRADO
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Matriz(I, 0), Matriz(I, 1), Matriz(I, 2), Matriz(I, 3), Matriz(I, 4), Matriz(I, 5), Matriz(I, 6))
            'SE LE ASIGNA A LA VARIABLE FILA EL VALOR DE I, QUE ES EL INDICE DEL VECTOR DEL DATO ENCONTRADO
            'ESTO SE HACE PARA CUANDO SE HAGA DESPUÉS EL PROCESO DE ACTUALIZAR O ELIMINAR
            FILA = I
            'SE LIMPIA EL TEXTBOX DONDE SE INGRESÓ EL DATO A BUSCAR
            TextBox3.Clear()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Matriz(FILA, 0) = TextBox1.Text
        Matriz(FILA, 1) = ComboBox1.Text
        Matriz(FILA, 2) = TextBox2.Text
        Matriz(FILA, 3) = TextBox3.Text
        Select Case ComboBox1.SelectedIndex
            Case 0 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 2)) * 150)
            Case 1 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 2)) * 400)
            Case 2 : Matriz(FILA, 4) = Str(Val(Matriz(FILA, 2)) * 750)
        End Select
        If (ComboBox1.Text = "Simple") And (Val(TextBox1.Text) >= 7) Then
            Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.1, 2)
            Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
        Else
            Matriz(FILA, 6) = Val(Matriz(FILA, 4))
        End If
        If (ComboBox1.Text = "Simple") And (Val(TextBox2.Text) > 3) Then
            Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.05, 2)
            Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) + Matriz(FILA, 5)), 2)
        Else
            Matriz(FILA, 6) = Val(Matriz(FILA, 4))
        End If
        If (ComboBox1.Text = "Familiar") And (Val(TextBox1.Text) >= 4) Then
            Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.07, 2)
            Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
        Else
            Matriz(FILA, 6) = Val(Matriz(FILA, 4))
        End If
        If (ComboBox1.Text = "Suite") And (Val(TextBox2.Text) = 2) And (Val(TextBox1.Text) > 15) Then
            Matriz(FILA, 5) = Round(Val(Matriz(FILA, 4)) * 0.15, 2)
            Matriz(FILA, 6) = Round(Val(Matriz(FILA, 4) - Matriz(FILA, 5)), 2)
        Else
            Matriz(FILA, 6) = Val(Matriz(FILA, 4))
        End If
        FILA = 0
        While (Matriz(FILA, 0) <> Nothing)
            FILA = FILA + 1
        End While
        limpiar_entradas()
    End Sub

    Private Sub OrdenarDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1
        Dim temp2
        Dim temp3
        Dim temp4
        Dim temp5
        Dim temp6
        Dim temp7
        For i = 0 To 9
            For j = i + 1 To 10
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (Matriz(j, 3) <> Nothing) Then
                    If (Val(Matriz(i, 3)) < Val(Matriz(j, 3))) Then
                        temp1 = Matriz(i, 0)
                        Matriz(i, 0) = Matriz(j, 0)
                        Matriz(j, 0) = temp1
                        temp2 = Matriz(i, 1)
                        Matriz(i, 1) = Matriz(j, 1)
                        Matriz(j, 1) = temp2
                        temp3 = Matriz(i, 2)
                        Matriz(i, 2) = Matriz(j, 2)
                        Matriz(j, 2) = temp3
                        temp4 = Matriz(i, 3)
                        Matriz(i, 3) = Matriz(j, 3)
                        Matriz(j, 3) = temp4
                        temp5 = Matriz(i, 4)
                        Matriz(i, 4) = Matriz(j, 4)
                        Matriz(j, 4) = temp5
                        temp6 = Matriz(i, 5)
                        Matriz(i, 5) = Matriz(j, 5)
                        Matriz(j, 5) = temp6
                        temp7 = Matriz(i, 6)
                        Matriz(i, 6) = Matriz(j, 6)
                        Matriz(j, 6) = temp7
                    End If
                Else
                    Exit For
                End If
            Next j
        Next i

    End Sub
End Class
