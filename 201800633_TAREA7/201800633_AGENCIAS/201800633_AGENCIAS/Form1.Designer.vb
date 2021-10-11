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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBtaller = New System.Windows.Forms.ComboBox()
        Me.CBcodigo = New System.Windows.Forms.ComboBox()
        Me.CBgenero = New System.Windows.Forms.ComboBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVresultados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bestadisticas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcond25 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcondfem = New System.Windows.Forms.TextBox()
        Me.txtcondmasc = New System.Windows.Forms.TextBox()
        Me.txtcondextran = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcondingre = New System.Windows.Forms.TextBox()
        Me.txtmontodaños = New System.Windows.Forms.TextBox()
        Me.txtdeducible = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVresultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtdeducible)
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CBtaller)
        Me.GroupBox1.Controls.Add(Me.CBcodigo)
        Me.GroupBox1.Controls.Add(Me.CBgenero)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 134)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada"
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(356, 46)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(141, 20)
        Me.txtmonto.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(293, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Deducible Q."
        '
        'CBtaller
        '
        Me.CBtaller.FormattingEnabled = True
        Me.CBtaller.Items.AddRange(New Object() {"Taller de confianza", "Taller por la aseguradora"})
        Me.CBtaller.Location = New System.Drawing.Point(356, 71)
        Me.CBtaller.Name = "CBtaller"
        Me.CBtaller.Size = New System.Drawing.Size(121, 21)
        Me.CBtaller.TabIndex = 10
        '
        'CBcodigo
        '
        Me.CBcodigo.FormattingEnabled = True
        Me.CBcodigo.Items.AddRange(New Object() {"0", "1"})
        Me.CBcodigo.Location = New System.Drawing.Point(129, 99)
        Me.CBcodigo.Name = "CBcodigo"
        Me.CBcodigo.Size = New System.Drawing.Size(121, 21)
        Me.CBcodigo.TabIndex = 9
        '
        'CBgenero
        '
        Me.CBgenero.FormattingEnabled = True
        Me.CBgenero.Items.AddRange(New Object() {"F", "M"})
        Me.CBgenero.Location = New System.Drawing.Point(73, 71)
        Me.CBgenero.Name = "CBgenero"
        Me.CBgenero.Size = New System.Drawing.Size(121, 21)
        Me.CBgenero.TabIndex = 8
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(73, 39)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(50, 20)
        Me.txtedad.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(88, 13)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(341, 20)
        Me.txtnombre.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Taller"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monto daños "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Código de Registro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Género"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.DGVresultados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 169)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'DGVresultados
        '
        Me.DGVresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVresultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DGVresultados.Location = New System.Drawing.Point(3, 16)
        Me.DGVresultados.Name = "DGVresultados"
        Me.DGVresultados.Size = New System.Drawing.Size(644, 137)
        Me.DGVresultados.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "EDAD"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "GENERO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODIGO R"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "MONTO DAÑOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TALLER"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DEDUCIBLE"
        Me.Column6.Name = "Column6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarEstadísticasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'LimpiarEstadísticasToolStripMenuItem
        '
        Me.LimpiarEstadísticasToolStripMenuItem.Name = "LimpiarEstadísticasToolStripMenuItem"
        Me.LimpiarEstadísticasToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.LimpiarEstadísticasToolStripMenuItem.Text = "Limpiar estadísticas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'Bestadisticas
        '
        Me.Bestadisticas.Location = New System.Drawing.Point(866, 112)
        Me.Bestadisticas.Name = "Bestadisticas"
        Me.Bestadisticas.Size = New System.Drawing.Size(75, 23)
        Me.Bestadisticas.TabIndex = 9
        Me.Bestadisticas.Text = "Estadisticas"
        Me.Bestadisticas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(684, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "% de conductores < 25 años"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(684, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "% de conductores de género femenino"
        '
        'txtcond25
        '
        Me.txtcond25.Location = New System.Drawing.Point(1013, 171)
        Me.txtcond25.Name = "txtcond25"
        Me.txtcond25.Size = New System.Drawing.Size(100, 20)
        Me.txtcond25.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(684, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "% de conductores de género masculino entre los 18 y 25 años"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(684, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "% de conductores con registro extranjero"
        '
        'txtcondfem
        '
        Me.txtcondfem.Location = New System.Drawing.Point(1013, 204)
        Me.txtcondfem.Name = "txtcondfem"
        Me.txtcondfem.Size = New System.Drawing.Size(100, 20)
        Me.txtcondfem.TabIndex = 16
        '
        'txtcondmasc
        '
        Me.txtcondmasc.Location = New System.Drawing.Point(1013, 230)
        Me.txtcondmasc.Name = "txtcondmasc"
        Me.txtcondmasc.Size = New System.Drawing.Size(100, 20)
        Me.txtcondmasc.TabIndex = 17
        '
        'txtcondextran
        '
        Me.txtcondextran.Location = New System.Drawing.Point(1013, 261)
        Me.txtcondextran.Name = "txtcondextran"
        Me.txtcondextran.Size = New System.Drawing.Size(100, 20)
        Me.txtcondextran.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(684, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Total de conductores ingresados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(684, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(242, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Total (Q) de los montos de los daños ocasionados"
        '
        'txtcondingre
        '
        Me.txtcondingre.Location = New System.Drawing.Point(1013, 296)
        Me.txtcondingre.Name = "txtcondingre"
        Me.txtcondingre.Size = New System.Drawing.Size(100, 20)
        Me.txtcondingre.TabIndex = 21
        '
        'txtmontodaños
        '
        Me.txtmontodaños.Location = New System.Drawing.Point(1013, 327)
        Me.txtmontodaños.Name = "txtmontodaños"
        Me.txtmontodaños.Size = New System.Drawing.Size(100, 20)
        Me.txtmontodaños.TabIndex = 22
        '
        'txtdeducible
        '
        Me.txtdeducible.Location = New System.Drawing.Point(368, 99)
        Me.txtdeducible.Name = "txtdeducible"
        Me.txtdeducible.Size = New System.Drawing.Size(141, 20)
        Me.txtdeducible.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1122, 373)
        Me.Controls.Add(Me.txtmontodaños)
        Me.Controls.Add(Me.txtcondingre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcondextran)
        Me.Controls.Add(Me.txtcondmasc)
        Me.Controls.Add(Me.txtcondfem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcond25)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bestadisticas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVresultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents CBtaller As ComboBox
    Friend WithEvents CBcodigo As ComboBox
    Friend WithEvents CBgenero As ComboBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGVresultados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Bestadisticas As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcond25 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcondfem As TextBox
    Friend WithEvents txtcondmasc As TextBox
    Friend WithEvents txtcondextran As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcondingre As TextBox
    Friend WithEvents txtmontodaños As TextBox
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents txtdeducible As TextBox
End Class
