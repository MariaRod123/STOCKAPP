<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBoxIngreso = New System.Windows.Forms.GroupBox()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.ComboBoxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaPedido = New System.Windows.Forms.DateTimePicker()
        Me.txtBoxNumFactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewPedido = New System.Windows.Forms.DataGridView()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBoxIngreso.SuspendLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(680, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(128, 34)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar pestaña"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBoxIngreso
        '
        Me.GroupBoxIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxTotal)
        Me.GroupBoxIngreso.Controls.Add(Me.Label5)
        Me.GroupBoxIngreso.Controls.Add(Me.btnAgregar)
        Me.GroupBoxIngreso.Controls.Add(Me.NumericUpDownCantidad)
        Me.GroupBoxIngreso.Controls.Add(Me.ComboBoxProducto)
        Me.GroupBoxIngreso.Controls.Add(Me.btnNuevoProducto)
        Me.GroupBoxIngreso.Controls.Add(Me.ComboBoxProveedor)
        Me.GroupBoxIngreso.Controls.Add(Me.Label6)
        Me.GroupBoxIngreso.Controls.Add(Me.Label2)
        Me.GroupBoxIngreso.Controls.Add(Me.dtpFechaPedido)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxNumFactura)
        Me.GroupBoxIngreso.Controls.Add(Me.Label1)
        Me.GroupBoxIngreso.Controls.Add(Me.Label4)
        Me.GroupBoxIngreso.Controls.Add(Me.DataGridViewPedido)
        Me.GroupBoxIngreso.Controls.Add(Me.btnBorrarTodo)
        Me.GroupBoxIngreso.Controls.Add(Me.btnIngresar)
        Me.GroupBoxIngreso.Controls.Add(Me.Label3)
        Me.GroupBoxIngreso.Controls.Add(Me.ShapeContainer1)
        Me.GroupBoxIngreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIngreso.Location = New System.Drawing.Point(12, 52)
        Me.GroupBoxIngreso.Name = "GroupBoxIngreso"
        Me.GroupBoxIngreso.Size = New System.Drawing.Size(796, 497)
        Me.GroupBoxIngreso.TabIndex = 27
        Me.GroupBoxIngreso.TabStop = False
        Me.GroupBoxIngreso.Text = "Compras"
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxTotal.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxTotal.Location = New System.Drawing.Point(652, 420)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.ReadOnly = True
        Me.txtBoxTotal.Size = New System.Drawing.Size(128, 20)
        Me.txtBoxTotal.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(602, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Total:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.LightBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(169, 115)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 24)
        Me.btnAgregar.TabIndex = 45
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownCantidad.BackColor = System.Drawing.Color.LightCyan
        Me.NumericUpDownCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(570, 115)
        Me.NumericUpDownCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.ReadOnly = True
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownCantidad.TabIndex = 44
        Me.NumericUpDownCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ComboBoxProducto
        '
        Me.ComboBoxProducto.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxProducto.FormattingEnabled = True
        Me.ComboBoxProducto.Location = New System.Drawing.Point(169, 71)
        Me.ComboBoxProducto.Name = "ComboBoxProducto"
        Me.ComboBoxProducto.Size = New System.Drawing.Size(167, 25)
        Me.ComboBoxProducto.TabIndex = 43
        '
        'btnNuevoProducto
        '
        Me.btnNuevoProducto.BackColor = System.Drawing.Color.LightBlue
        Me.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProducto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProducto.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoProducto.Location = New System.Drawing.Point(342, 72)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Size = New System.Drawing.Size(63, 24)
        Me.btnNuevoProducto.TabIndex = 42
        Me.btnNuevoProducto.Text = "Nuevo"
        Me.btnNuevoProducto.UseVisualStyleBackColor = False
        '
        'ComboBoxProveedor
        '
        Me.ComboBoxProveedor.BackColor = System.Drawing.Color.LightBlue
        Me.ComboBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxProveedor.FormattingEnabled = True
        Me.ComboBoxProveedor.Location = New System.Drawing.Point(169, 22)
        Me.ComboBoxProveedor.Name = "ComboBoxProveedor"
        Me.ComboBoxProveedor.Size = New System.Drawing.Size(236, 25)
        Me.ComboBoxProveedor.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(492, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(90, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Producto:"
        '
        'dtpFechaPedido
        '
        Me.dtpFechaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaPedido.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaPedido.Location = New System.Drawing.Point(569, 69)
        Me.dtpFechaPedido.Name = "dtpFechaPedido"
        Me.dtpFechaPedido.Size = New System.Drawing.Size(218, 23)
        Me.dtpFechaPedido.TabIndex = 34
        '
        'txtBoxNumFactura
        '
        Me.txtBoxNumFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxNumFactura.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNumFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNumFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNumFactura.Location = New System.Drawing.Point(569, 26)
        Me.txtBoxNumFactura.Name = "txtBoxNumFactura"
        Me.txtBoxNumFactura.Size = New System.Drawing.Size(218, 16)
        Me.txtBoxNumFactura.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(428, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Número de pedido:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(440, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha de pedido:"
        '
        'DataGridViewPedido
        '
        Me.DataGridViewPedido.AllowUserToAddRows = False
        Me.DataGridViewPedido.AllowUserToDeleteRows = False
        Me.DataGridViewPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridViewPedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.DataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProducto, Me.Descripcion, Me.PrecioUnit, Me.Cantidad, Me.SubTot})
        Me.DataGridViewPedido.Location = New System.Drawing.Point(18, 186)
        Me.DataGridViewPedido.Name = "DataGridViewPedido"
        Me.DataGridViewPedido.ReadOnly = True
        Me.DataGridViewPedido.Size = New System.Drawing.Size(761, 215)
        Me.DataGridViewPedido.TabIndex = 30
        '
        'CodigoProducto
        '
        Me.CodigoProducto.HeaderText = "Código de Producto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'PrecioUnit
        '
        Me.PrecioUnit.HeaderText = "Precio Unitario"
        Me.PrecioUnit.Name = "PrecioUnit"
        Me.PrecioUnit.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'SubTot
        '
        Me.SubTot.HeaderText = "SubTotal"
        Me.SubTot.Name = "SubTot"
        Me.SubTot.ReadOnly = True
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarTodo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodo.ForeColor = System.Drawing.Color.White
        Me.btnBorrarTodo.Location = New System.Drawing.Point(257, 457)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(128, 34)
        Me.btnBorrarTodo.TabIndex = 27
        Me.btnBorrarTodo.Text = "BORRAR TODO"
        Me.btnBorrarTodo.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(412, 457)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(128, 34)
        Me.btnIngresar.TabIndex = 25
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre proveedor:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(790, 475)
        Me.ShapeContainer1.TabIndex = 48
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 567
        Me.LineShape1.X2 = 782
        Me.LineShape1.Y1 = 26
        Me.LineShape1.Y2 = 26
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 647
        Me.LineShape2.X2 = 775
        Me.LineShape2.Y1 = 426
        Me.LineShape2.Y2 = 426
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.GroupBoxIngreso)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.GroupBoxIngreso.ResumeLayout(False)
        Me.GroupBoxIngreso.PerformLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewPedido As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarTodo As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBoxNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProducto As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevoProducto As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
