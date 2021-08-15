Module Module1
    Public saldo_nuevo
    Public interes
    Public interesesAcumulados
    Public tipoSeleccionado As Boolean = False

    Sub LIMPIAR()
        'Limpiar todo
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False

        Form1.montoCP.Clear()
        Form1.montoCOB.Clear()
        Form1.montoEF.Clear()

        Form1.RadioButton1.Focus()

    End Sub

End Module
