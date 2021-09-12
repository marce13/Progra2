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
        Me.Baceptar = New System.Windows.Forms.Button()
        Me.Blimpiaren = New System.Windows.Forms.Button()
        Me.Blimpiarvec = New System.Windows.Forms.Button()
        Me.Bsalida = New System.Windows.Forms.Button()
        Me.ComboBcine = New System.Windows.Forms.ComboBox()
        Me.ComboBfuncion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Descuento2 = New System.Windows.Forms.ListBox()
        Me.Descuento1 = New System.Windows.Forms.ListBox()
        Me.SubTotal = New System.Windows.Forms.ListBox()
        Me.Funcion = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Baceptar
        '
        Me.Baceptar.Location = New System.Drawing.Point(592, 12)
        Me.Baceptar.Name = "Baceptar"
        Me.Baceptar.Size = New System.Drawing.Size(75, 23)
        Me.Baceptar.TabIndex = 0
        Me.Baceptar.Text = "ACEPTAR"
        Me.Baceptar.UseVisualStyleBackColor = True
        '
        'Blimpiaren
        '
        Me.Blimpiaren.Location = New System.Drawing.Point(592, 41)
        Me.Blimpiaren.Name = "Blimpiaren"
        Me.Blimpiaren.Size = New System.Drawing.Size(75, 35)
        Me.Blimpiaren.TabIndex = 1
        Me.Blimpiaren.Text = "LIMPIAR ENTRADAS"
        Me.Blimpiaren.UseVisualStyleBackColor = True
        '
        'Blimpiarvec
        '
        Me.Blimpiarvec.Location = New System.Drawing.Point(592, 82)
        Me.Blimpiarvec.Name = "Blimpiarvec"
        Me.Blimpiarvec.Size = New System.Drawing.Size(75, 40)
        Me.Blimpiarvec.TabIndex = 2
        Me.Blimpiarvec.Text = "LIMPIAR VECTORES"
        Me.Blimpiarvec.UseVisualStyleBackColor = True
        '
        'Bsalida
        '
        Me.Bsalida.Location = New System.Drawing.Point(592, 128)
        Me.Bsalida.Name = "Bsalida"
        Me.Bsalida.Size = New System.Drawing.Size(75, 23)
        Me.Bsalida.TabIndex = 3
        Me.Bsalida.Text = "SALIR"
        Me.Bsalida.UseVisualStyleBackColor = True
        '
        'ComboBcine
        '
        Me.ComboBcine.FormattingEnabled = True
        Me.ComboBcine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBcine.Location = New System.Drawing.Point(73, 25)
        Me.ComboBcine.Name = "ComboBcine"
        Me.ComboBcine.Size = New System.Drawing.Size(121, 21)
        Me.ComboBcine.TabIndex = 4
        '
        'ComboBfuncion
        '
        Me.ComboBfuncion.FormattingEnabled = True
        Me.ComboBfuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBfuncion.Location = New System.Drawing.Point(73, 66)
        Me.ComboBfuncion.Name = "ComboBfuncion"
        Me.ComboBfuncion.Size = New System.Drawing.Size(121, 21)
        Me.ComboBfuncion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cine"
        '
        'Cine
        '
        Me.Cine.FormattingEnabled = True
        Me.Cine.Location = New System.Drawing.Point(15, 19)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(111, 173)
        Me.Cine.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBfuncion)
        Me.GroupBox1.Controls.Add(Me.ComboBcine)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 115)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elejir función y cine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Función"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento2)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.SubTotal)
        Me.GroupBox2.Controls.Add(Me.Funcion)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 223)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Total
        '
        Me.Total.FormattingEnabled = True
        Me.Total.Location = New System.Drawing.Point(626, 19)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(111, 173)
        Me.Total.TabIndex = 12
        '
        'Descuento2
        '
        Me.Descuento2.FormattingEnabled = True
        Me.Descuento2.Location = New System.Drawing.Point(509, 19)
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Size = New System.Drawing.Size(111, 173)
        Me.Descuento2.TabIndex = 11
        '
        'Descuento1
        '
        Me.Descuento1.FormattingEnabled = True
        Me.Descuento1.Location = New System.Drawing.Point(392, 19)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(111, 173)
        Me.Descuento1.TabIndex = 10
        '
        'SubTotal
        '
        Me.SubTotal.FormattingEnabled = True
        Me.SubTotal.Location = New System.Drawing.Point(259, 19)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(111, 173)
        Me.SubTotal.TabIndex = 9
        '
        'Funcion
        '
        Me.Funcion.FormattingEnabled = True
        Me.Funcion.Location = New System.Drawing.Point(132, 19)
        Me.Funcion.Name = "Funcion"
        Me.Funcion.Size = New System.Drawing.Size(111, 173)
        Me.Funcion.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cantidad de entradas"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(346, 57)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bsalida)
        Me.Controls.Add(Me.Blimpiarvec)
        Me.Controls.Add(Me.Blimpiaren)
        Me.Controls.Add(Me.Baceptar)
        Me.Name = "Form1"
        Me.Text = "Compra de entradas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Baceptar As Button
    Friend WithEvents Blimpiaren As Button
    Friend WithEvents Blimpiarvec As Button
    Friend WithEvents Bsalida As Button
    Friend WithEvents ComboBcine As ComboBox
    Friend WithEvents ComboBfuncion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cine As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento2 As ListBox
    Friend WithEvents Descuento1 As ListBox
    Friend WithEvents SubTotal As ListBox
    Friend WithEvents Funcion As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidad As TextBox
End Class
