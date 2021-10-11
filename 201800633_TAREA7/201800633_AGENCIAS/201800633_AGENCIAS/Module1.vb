Module Module1
    Public FILA As Byte = 0
    Public MONTO(7) As Integer
    Public EDAD(7) As String
    Public CODIGO(7) As String
    Public TALLER(7) As String
    Public GENERO(7) As String
    Public DEDUCIBLE(7) As String

    Sub inicializar_datos()
        Form1.txtedad.Clear()
        Form1.CBcodigo.Text = ""
        Form1.CBgenero.Text = ""
        Form1.CBtaller.Text = ""
        Form1.txtmonto.Clear()
        Form1.txtnombre.Clear()
        Form1.txtdeducible.Clear()
        Form1.txtnombre.Focus()
    End Sub

    Sub LIMPIAR_VECTORES()
        FILA = 0
        Form1.DGVresultados.Rows.Clear()
        Form1.txtedad.Text = ""
        Form1.txtmonto.Text = ""
        Form1.txtnombre.Text = ""
        Form1.CBcodigo.Text = ""
        Form1.CBgenero.Text = ""
        Form1.CBtaller.Text = ""

    End Sub
End Module
