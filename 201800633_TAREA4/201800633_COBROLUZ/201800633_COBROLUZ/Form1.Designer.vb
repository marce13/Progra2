<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtconsumo = New System.Windows.Forms.TextBox()
        Me.txtsaldoanterior = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Combtarifa = New System.Windows.Forms.ComboBox()
        Me.Combservicio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBpagoparcial = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListBpagoconmora = New System.Windows.Forms.ListBox()
        Me.ListBmora = New System.Windows.Forms.ListBox()
        Me.ListBpagoinicial = New System.Windows.Forms.ListBox()
        Me.ListBsaldoan = New System.Windows.Forms.ListBox()
        Me.ListBtarifa = New System.Windows.Forms.ListBox()
        Me.ListBservicio = New System.Windows.Forms.ListBox()
        Me.ListBcliente = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ListBdesc = New System.Windows.Forms.ListBox()
        Me.ListBpagototal = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.SALIDAToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1267, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'SALIDAToolStripMenuItem
        '
        Me.SALIDAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SALIDAToolStripMenuItem.Name = "SALIDAToolStripMenuItem"
        Me.SALIDAToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SALIDAToolStripMenuItem.Text = "SALIDA"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtconsumo)
        Me.GroupBox1.Controls.Add(Me.txtsaldoanterior)
        Me.GroupBox1.Controls.Add(Me.txtnit)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Combtarifa)
        Me.GroupBox1.Controls.Add(Me.Combservicio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 155)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DATOS"
        '
        'txtconsumo
        '
        Me.txtconsumo.Location = New System.Drawing.Point(215, 122)
        Me.txtconsumo.Name = "txtconsumo"
        Me.txtconsumo.Size = New System.Drawing.Size(118, 20)
        Me.txtconsumo.TabIndex = 11
        '
        'txtsaldoanterior
        '
        Me.txtsaldoanterior.Location = New System.Drawing.Point(122, 85)
        Me.txtsaldoanterior.Name = "txtsaldoanterior"
        Me.txtsaldoanterior.Size = New System.Drawing.Size(154, 20)
        Me.txtsaldoanterior.TabIndex = 10
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(74, 55)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(126, 20)
        Me.txtnit.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(74, 25)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(272, 20)
        Me.txtnombre.TabIndex = 8
        '
        'Combtarifa
        '
        Me.Combtarifa.FormattingEnabled = True
        Me.Combtarifa.Location = New System.Drawing.Point(581, 100)
        Me.Combtarifa.Name = "Combtarifa"
        Me.Combtarifa.Size = New System.Drawing.Size(121, 21)
        Me.Combtarifa.TabIndex = 7
        '
        'Combservicio
        '
        Me.Combservicio.FormattingEnabled = True
        Me.Combservicio.Location = New System.Drawing.Point(581, 28)
        Me.Combservicio.Name = "Combservicio"
        Me.Combservicio.Size = New System.Drawing.Size(121, 21)
        Me.Combservicio.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TIPO DE TARIFA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(472, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO DE SERVICIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONSUMO ENERGÍA ELÉCTRICA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALDO ANTERIOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ListBpagototal)
        Me.GroupBox2.Controls.Add(Me.ListBdesc)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.ListBpagoparcial)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.ListBpagoconmora)
        Me.GroupBox2.Controls.Add(Me.ListBmora)
        Me.GroupBox2.Controls.Add(Me.ListBpagoinicial)
        Me.GroupBox2.Controls.Add(Me.ListBsaldoan)
        Me.GroupBox2.Controls.Add(Me.ListBtarifa)
        Me.GroupBox2.Controls.Add(Me.ListBservicio)
        Me.GroupBox2.Controls.Add(Me.ListBcliente)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1243, 268)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'ListBpagoparcial
        '
        Me.ListBpagoparcial.FormattingEnabled = True
        Me.ListBpagoparcial.Location = New System.Drawing.Point(874, 32)
        Me.ListBpagoparcial.Name = "ListBpagoparcial"
        Me.ListBpagoparcial.Size = New System.Drawing.Size(88, 212)
        Me.ListBpagoparcial.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(867, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "PAGO PARCIAL"
        '
        'ListBpagoconmora
        '
        Me.ListBpagoconmora.FormattingEnabled = True
        Me.ListBpagoconmora.Location = New System.Drawing.Point(737, 32)
        Me.ListBpagoconmora.Name = "ListBpagoconmora"
        Me.ListBpagoconmora.Size = New System.Drawing.Size(101, 212)
        Me.ListBpagoconmora.TabIndex = 13
        '
        'ListBmora
        '
        Me.ListBmora.FormattingEnabled = True
        Me.ListBmora.Location = New System.Drawing.Point(622, 32)
        Me.ListBmora.Name = "ListBmora"
        Me.ListBmora.Size = New System.Drawing.Size(100, 212)
        Me.ListBmora.TabIndex = 12
        '
        'ListBpagoinicial
        '
        Me.ListBpagoinicial.FormattingEnabled = True
        Me.ListBpagoinicial.Location = New System.Drawing.Point(512, 32)
        Me.ListBpagoinicial.Name = "ListBpagoinicial"
        Me.ListBpagoinicial.Size = New System.Drawing.Size(93, 212)
        Me.ListBpagoinicial.TabIndex = 11
        '
        'ListBsaldoan
        '
        Me.ListBsaldoan.FormattingEnabled = True
        Me.ListBsaldoan.Location = New System.Drawing.Point(406, 32)
        Me.ListBsaldoan.Name = "ListBsaldoan"
        Me.ListBsaldoan.Size = New System.Drawing.Size(88, 212)
        Me.ListBsaldoan.TabIndex = 10
        '
        'ListBtarifa
        '
        Me.ListBtarifa.FormattingEnabled = True
        Me.ListBtarifa.Location = New System.Drawing.Point(274, 32)
        Me.ListBtarifa.Name = "ListBtarifa"
        Me.ListBtarifa.Size = New System.Drawing.Size(115, 212)
        Me.ListBtarifa.TabIndex = 9
        '
        'ListBservicio
        '
        Me.ListBservicio.FormattingEnabled = True
        Me.ListBservicio.Location = New System.Drawing.Point(154, 32)
        Me.ListBservicio.Name = "ListBservicio"
        Me.ListBservicio.Size = New System.Drawing.Size(114, 212)
        Me.ListBservicio.TabIndex = 8
        '
        'ListBcliente
        '
        Me.ListBcliente.FormattingEnabled = True
        Me.ListBcliente.Location = New System.Drawing.Point(6, 32)
        Me.ListBcliente.Name = "ListBcliente"
        Me.ListBcliente.Size = New System.Drawing.Size(132, 212)
        Me.ListBcliente.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(734, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "PAGO CON MORA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(638, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "MORA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(518, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "PAGO INICIAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(392, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "SALDO ANTERIOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "TIPO TARIFA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "TIPO SERVICO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CLIENTE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(993, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "DESCUENTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1123, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "PAGO TOTAL"
        '
        'ListBdesc
        '
        Me.ListBdesc.FormattingEnabled = True
        Me.ListBdesc.Location = New System.Drawing.Point(1000, 32)
        Me.ListBdesc.Name = "ListBdesc"
        Me.ListBdesc.Size = New System.Drawing.Size(92, 212)
        Me.ListBdesc.TabIndex = 18
        '
        'ListBpagototal
        '
        Me.ListBpagototal.FormattingEnabled = True
        Me.ListBpagototal.Location = New System.Drawing.Point(1130, 32)
        Me.ListBpagototal.Name = "ListBpagototal"
        Me.ListBpagototal.Size = New System.Drawing.Size(78, 212)
        Me.ListBpagototal.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "RECIBO PAGO DE LUZ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtconsumo As TextBox
    Friend WithEvents txtsaldoanterior As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Combtarifa As ComboBox
    Friend WithEvents Combservicio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBpagoparcial As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ListBpagoconmora As ListBox
    Friend WithEvents ListBmora As ListBox
    Friend WithEvents ListBpagoinicial As ListBox
    Friend WithEvents ListBsaldoan As ListBox
    Friend WithEvents ListBtarifa As ListBox
    Friend WithEvents ListBservicio As ListBox
    Friend WithEvents ListBcliente As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBpagototal As ListBox
    Friend WithEvents ListBdesc As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
