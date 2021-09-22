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
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBmarca = New System.Windows.Forms.ComboBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBpagofinal = New System.Windows.Forms.ListBox()
        Me.LBdescuento = New System.Windows.Forms.ListBox()
        Me.LBpagoparcial = New System.Windows.Forms.ListBox()
        Me.LBdias = New System.Windows.Forms.ListBox()
        Me.LBmarca = New System.Windows.Forms.ListBox()
        Me.LBplaca = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBefectivo = New System.Windows.Forms.CheckBox()
        Me.CheckBtarjeta = New System.Windows.Forms.CheckBox()
        Me.txtporcenefectivo = New System.Windows.Forms.TextBox()
        Me.txtporcentarjeta = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CalcularToolStripMenuItem.Text = "Procesos"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtporcentarjeta)
        Me.GroupBox1.Controls.Add(Me.txtporcenefectivo)
        Me.GroupBox1.Controls.Add(Me.CheckBtarjeta)
        Me.GroupBox1.Controls.Add(Me.CheckBefectivo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CBmarca)
        Me.GroupBox1.Controls.Add(Me.txtdias)
        Me.GroupBox1.Controls.Add(Me.txtplaca)
        Me.GroupBox1.Controls.Add(Me.txtnit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(613, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Forma de pago"
        '
        'CBmarca
        '
        Me.CBmarca.FormattingEnabled = True
        Me.CBmarca.Location = New System.Drawing.Point(260, 43)
        Me.CBmarca.Name = "CBmarca"
        Me.CBmarca.Size = New System.Drawing.Size(121, 21)
        Me.CBmarca.TabIndex = 9
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(431, 43)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(100, 20)
        Me.txtdias.TabIndex = 8
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(137, 43)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(100, 20)
        Me.txtplaca.TabIndex = 7
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(21, 43)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(100, 20)
        Me.txtnit.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Placa del auto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad de días a alquilar "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LBpagofinal)
        Me.GroupBox2.Controls.Add(Me.LBdescuento)
        Me.GroupBox2.Controls.Add(Me.LBpagoparcial)
        Me.GroupBox2.Controls.Add(Me.LBdias)
        Me.GroupBox2.Controls.Add(Me.LBmarca)
        Me.GroupBox2.Controls.Add(Me.LBplaca)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 258)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Pago parcial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(553, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(684, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Pago final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(285, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Días a alquilar "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Marca"
        '
        'LBpagofinal
        '
        Me.LBpagofinal.FormattingEnabled = True
        Me.LBpagofinal.Location = New System.Drawing.Point(655, 46)
        Me.LBpagofinal.Name = "LBpagofinal"
        Me.LBpagofinal.Size = New System.Drawing.Size(115, 199)
        Me.LBpagofinal.TabIndex = 10
        '
        'LBdescuento
        '
        Me.LBdescuento.FormattingEnabled = True
        Me.LBdescuento.Location = New System.Drawing.Point(524, 46)
        Me.LBdescuento.Name = "LBdescuento"
        Me.LBdescuento.Size = New System.Drawing.Size(115, 199)
        Me.LBdescuento.TabIndex = 9
        '
        'LBpagoparcial
        '
        Me.LBpagoparcial.FormattingEnabled = True
        Me.LBpagoparcial.Location = New System.Drawing.Point(396, 46)
        Me.LBpagoparcial.Name = "LBpagoparcial"
        Me.LBpagoparcial.Size = New System.Drawing.Size(115, 199)
        Me.LBpagoparcial.TabIndex = 8
        '
        'LBdias
        '
        Me.LBdias.FormattingEnabled = True
        Me.LBdias.Location = New System.Drawing.Point(266, 46)
        Me.LBdias.Name = "LBdias"
        Me.LBdias.Size = New System.Drawing.Size(115, 199)
        Me.LBdias.TabIndex = 7
        '
        'LBmarca
        '
        Me.LBmarca.FormattingEnabled = True
        Me.LBmarca.Location = New System.Drawing.Point(137, 46)
        Me.LBmarca.Name = "LBmarca"
        Me.LBmarca.Size = New System.Drawing.Size(115, 199)
        Me.LBmarca.TabIndex = 6
        '
        'LBplaca
        '
        Me.LBplaca.FormattingEnabled = True
        Me.LBplaca.Location = New System.Drawing.Point(6, 46)
        Me.LBplaca.Name = "LBplaca"
        Me.LBplaca.Size = New System.Drawing.Size(115, 199)
        Me.LBplaca.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Placa "
        '
        'CheckBefectivo
        '
        Me.CheckBefectivo.AutoSize = True
        Me.CheckBefectivo.Location = New System.Drawing.Point(574, 47)
        Me.CheckBefectivo.Name = "CheckBefectivo"
        Me.CheckBefectivo.Size = New System.Drawing.Size(65, 17)
        Me.CheckBefectivo.TabIndex = 11
        Me.CheckBefectivo.Text = "Efectivo"
        Me.CheckBefectivo.UseVisualStyleBackColor = True
        '
        'CheckBtarjeta
        '
        Me.CheckBtarjeta.AutoSize = True
        Me.CheckBtarjeta.Location = New System.Drawing.Point(574, 70)
        Me.CheckBtarjeta.Name = "CheckBtarjeta"
        Me.CheckBtarjeta.Size = New System.Drawing.Size(59, 17)
        Me.CheckBtarjeta.TabIndex = 12
        Me.CheckBtarjeta.Text = "Tarjeta"
        Me.CheckBtarjeta.UseVisualStyleBackColor = True
        '
        'txtporcenefectivo
        '
        Me.txtporcenefectivo.Location = New System.Drawing.Point(645, 45)
        Me.txtporcenefectivo.Name = "txtporcenefectivo"
        Me.txtporcenefectivo.Size = New System.Drawing.Size(100, 20)
        Me.txtporcenefectivo.TabIndex = 13
        Me.txtporcenefectivo.Text = "0"
        '
        'txtporcentarjeta
        '
        Me.txtporcentarjeta.Location = New System.Drawing.Point(645, 67)
        Me.txtporcentarjeta.Name = "txtporcentarjeta"
        Me.txtporcentarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txtporcentarjeta.TabIndex = 14
        Me.txtporcentarjeta.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rentautos"
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
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBmarca As ComboBox
    Friend WithEvents txtdias As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBpagofinal As ListBox
    Friend WithEvents LBdescuento As ListBox
    Friend WithEvents LBpagoparcial As ListBox
    Friend WithEvents LBdias As ListBox
    Friend WithEvents LBmarca As ListBox
    Friend WithEvents LBplaca As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBtarjeta As CheckBox
    Friend WithEvents CheckBefectivo As CheckBox
    Friend WithEvents txtporcentarjeta As TextBox
    Friend WithEvents txtporcenefectivo As TextBox
End Class
