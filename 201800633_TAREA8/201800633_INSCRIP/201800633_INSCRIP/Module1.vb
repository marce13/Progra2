Imports System.Math
Module Module1
    Public nivelestudio(7, 9) As String
    Public nombre
    Public carnet
    Public nivel
    Public carrera
    Public cuotainscripcion
    Public primeracuota
    Public formapago
    Public pagoinicial
    Public pagofinal
    Public carrera_diversificado As String
    Public fila As Byte = 0
    Public Const basico_inscripcion = 350
    Public Const diversificado_inscripcion = 450
    Public Const basico_primera = 250
    Public Const diversificado_primera = 350

    Sub LIMPIAR_ENTRADAS()
        Form1.txtnombre.Clear()
        Form1.txtcarnet.Clear()
        Form1.CBcarrera.Text = ""
        Form1.CBformapago.Text = ""
        Form1.RBbasico.Checked = False
        Form1.RBdiversificado.Checked = False
        Form1.txtnombre.Focus()
    End Sub

    Sub LIMPIAR_TOTALES()
        Form1.txttotalgeneral.Clear()
        Form1.txtformapago.Clear()
        Form1.txttotalnivel.Clear()
        Form1.txttotalinscritos.Clear()
    End Sub

    Sub SALIR()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Sub GUARDAR()
        If (fila <= 6) Then
            nivelestudio(fila, 0) = Form1.txtnombre.Text
            nivelestudio(fila, 1) = Val(Form1.txtcarnet.Text)
            nivelestudio(fila, 3) = Form1.CBcarrera.Text
            nivelestudio(fila, 6) = Form1.CBformapago.Text
            nivelestudio(fila, 7) = pagoinicial
            nivelestudio(fila, 8) = pagofinal
            If Form1.RBbasico.Checked Then
                nivelestudio(fila, 2) = Form1.RBbasico.Text
            ElseIf Form1.RBdiversificado.Checked Then
                nivelestudio(fila, 2) = Form1.RBdiversificado.Text
            End If

            If Form1.RBbasico.Checked Then
                nivelestudio(fila, 4) = basico_inscripcion
            ElseIf Form1.RBdiversificado.Checked Then
                nivelestudio(fila, 4) = diversificado_inscripcion
            End If
            If Form1.RBbasico.Checked Then
                nivelestudio(fila, 5) = basico_primera
            ElseIf Form1.RBdiversificado.Checked Then
                nivelestudio(fila, 2) = diversificado_primera
            End If

            fila = fila + 1
            If (fila = 7) Then
                MsgBox("MATRIZ LLENA")
                Exit Sub
            End If
        End If
    End Sub

    Sub MOSTRAR()
        Dim i As Byte
        For i = 0 To 7
            If nivelestudio(i, 0) <> Nothing Then
                Form1.DGVmuestradatos.Rows.Add(nivelestudio(i, 0), nivelestudio(i, 1), nivelestudio(i, 2), nivelestudio(i, 3), nivelestudio(i, 4), nivelestudio(i, 5), nivelestudio(i, 6), nivelestudio(i, 7), nivelestudio(i, 8))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub LIMPIAR_MATRIZ()
        Dim i As Byte
        Dim j As Byte
        For i = 0 To 6
            For j = 0 To 7
                nivelestudio(i, j) = Nothing
            Next j
        Next i
    End Sub
End Module
