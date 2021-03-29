<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.GroupBoxVentas = New System.Windows.Forms.GroupBox()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.txtBoxCambio = New System.Windows.Forms.TextBox()
        Me.txtBoxEfectivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerarBoleta = New System.Windows.Forms.Button()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.btnRegistrarVenta = New System.Windows.Forms.Button()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtBoxNumVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxDatosProducto = New System.Windows.Forms.GroupBox()
        Me.txtBoxProducto = New System.Windows.Forms.TextBox()
        Me.txtboxCodigo = New System.Windows.Forms.TextBox()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBoxVentas.SuspendLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosProducto.SuspendLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBoxVentas
        '
        Me.GroupBoxVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxVentas.Controls.Add(Me.btnCambio)
        Me.GroupBoxVentas.Controls.Add(Me.txtBoxCambio)
        Me.GroupBoxVentas.Controls.Add(Me.txtBoxEfectivo)
        Me.GroupBoxVentas.Controls.Add(Me.Label2)
        Me.GroupBoxVentas.Controls.Add(Me.btnGenerarBoleta)
        Me.GroupBoxVentas.Controls.Add(Me.txtBoxTotal)
        Me.GroupBoxVentas.Controls.Add(Me.Label5)
        Me.GroupBoxVentas.Controls.Add(Me.DataGridViewVentas)
        Me.GroupBoxVentas.Controls.Add(Me.btnBorrarTodo)
        Me.GroupBoxVentas.Controls.Add(Me.btnRegistrarVenta)
        Me.GroupBoxVentas.Controls.Add(Me.ShapeContainer3)
        Me.GroupBoxVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxVentas.Location = New System.Drawing.Point(12, 197)
        Me.GroupBoxVentas.Name = "GroupBoxVentas"
        Me.GroupBoxVentas.Size = New System.Drawing.Size(796, 352)
        Me.GroupBoxVentas.TabIndex = 28
        Me.GroupBoxVentas.TabStop = False
        Me.GroupBoxVentas.Text = "Ventas"
        '
        'btnCambio
        '
        Me.btnCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambio.ForeColor = System.Drawing.Color.White
        Me.btnCambio.Location = New System.Drawing.Point(588, 316)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(74, 27)
        Me.btnCambio.TabIndex = 47
        Me.btnCambio.Text = "CAMBIO"
        Me.btnCambio.UseVisualStyleBackColor = False
        '
        'txtBoxCambio
        '
        Me.txtBoxCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxCambio.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxCambio.Location = New System.Drawing.Point(668, 322)
        Me.txtBoxCambio.Name = "txtBoxCambio"
        Me.txtBoxCambio.ReadOnly = True
        Me.txtBoxCambio.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxCambio.TabIndex = 46
        '
        'txtBoxEfectivo
        '
        Me.txtBoxEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxEfectivo.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxEfectivo.Location = New System.Drawing.Point(668, 277)
        Me.txtBoxEfectivo.MaxLength = 25
        Me.txtBoxEfectivo.Name = "txtBoxEfectivo"
        Me.txtBoxEfectivo.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxEfectivo.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(598, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Efectivo:"
        '
        'btnGenerarBoleta
        '
        Me.btnGenerarBoleta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarBoleta.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnGenerarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarBoleta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarBoleta.ForeColor = System.Drawing.Color.White
        Me.btnGenerarBoleta.Location = New System.Drawing.Point(6, 272)
        Me.btnGenerarBoleta.Name = "btnGenerarBoleta"
        Me.btnGenerarBoleta.Size = New System.Drawing.Size(136, 34)
        Me.btnGenerarBoleta.TabIndex = 42
        Me.btnGenerarBoleta.Text = "GENERAR BOLETA"
        Me.btnGenerarBoleta.UseVisualStyleBackColor = False
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxTotal.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxTotal.Location = New System.Drawing.Point(668, 233)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.ReadOnly = True
        Me.txtBoxTotal.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxTotal.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(619, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total:"
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridViewVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProducto, Me.Producto, Me.PrecioUnitario, Me.Cantidad, Me.PrecioTotal})
        Me.DataGridViewVentas.Location = New System.Drawing.Point(6, 22)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.Size = New System.Drawing.Size(784, 191)
        Me.DataGridViewVentas.TabIndex = 30
        '
        'CodigoProducto
        '
        Me.CodigoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoProducto.HeaderText = "Código de producto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioUnitario.HeaderText = "Precio unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'PrecioTotal
        '
        Me.PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioTotal.HeaderText = "SubTotal"
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.ReadOnly = True
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarTodo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodo.ForeColor = System.Drawing.Color.White
        Me.btnBorrarTodo.Location = New System.Drawing.Point(6, 312)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(136, 34)
        Me.btnBorrarTodo.TabIndex = 27
        Me.btnBorrarTodo.Text = "BORRAR TODO"
        Me.btnBorrarTodo.UseVisualStyleBackColor = False
        '
        'btnRegistrarVenta
        '
        Me.btnRegistrarVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarVenta.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarVenta.Location = New System.Drawing.Point(6, 231)
        Me.btnRegistrarVenta.Name = "btnRegistrarVenta"
        Me.btnRegistrarVenta.Size = New System.Drawing.Size(136, 34)
        Me.btnRegistrarVenta.TabIndex = 25
        Me.btnRegistrarVenta.Text = "REGISTRAR VENTA"
        Me.btnRegistrarVenta.UseVisualStyleBackColor = False
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaVenta.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaVenta.Location = New System.Drawing.Point(303, 49)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(218, 20)
        Me.dtpFechaVenta.TabIndex = 34
        '
        'txtBoxNumVenta
        '
        Me.txtBoxNumVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBoxNumVenta.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNumVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNumVenta.Location = New System.Drawing.Point(29, 51)
        Me.txtBoxNumVenta.MaxLength = 25
        Me.txtBoxNumVenta.Name = "txtBoxNumVenta"
        Me.txtBoxNumVenta.Size = New System.Drawing.Size(218, 13)
        Me.txtBoxNumVenta.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Número de venta:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(300, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha de venta:"
        '
        'GroupBoxDatosProducto
        '
        Me.GroupBoxDatosProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDatosProducto.Controls.Add(Me.txtBoxProducto)
        Me.GroupBoxDatosProducto.Controls.Add(Me.txtboxCodigo)
        Me.GroupBoxDatosProducto.Controls.Add(Me.NumericUpDownCantidad)
        Me.GroupBoxDatosProducto.Controls.Add(Me.Label8)
        Me.GroupBoxDatosProducto.Controls.Add(Me.Label7)
        Me.GroupBoxDatosProducto.Controls.Add(Me.Label6)
        Me.GroupBoxDatosProducto.Controls.Add(Me.ShapeContainer2)
        Me.GroupBoxDatosProducto.Location = New System.Drawing.Point(12, 91)
        Me.GroupBoxDatosProducto.Name = "GroupBoxDatosProducto"
        Me.GroupBoxDatosProducto.Size = New System.Drawing.Size(796, 100)
        Me.GroupBoxDatosProducto.TabIndex = 35
        Me.GroupBoxDatosProducto.TabStop = False
        Me.GroupBoxDatosProducto.Text = "Datos del producto"
        '
        'txtBoxProducto
        '
        Me.txtBoxProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxProducto.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxProducto.Location = New System.Drawing.Point(291, 54)
        Me.txtBoxProducto.MaxLength = 25
        Me.txtBoxProducto.Name = "txtBoxProducto"
        Me.txtBoxProducto.Size = New System.Drawing.Size(218, 13)
        Me.txtBoxProducto.TabIndex = 36
        '
        'txtboxCodigo
        '
        Me.txtboxCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtboxCodigo.BackColor = System.Drawing.Color.LightBlue
        Me.txtboxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtboxCodigo.Location = New System.Drawing.Point(17, 54)
        Me.txtboxCodigo.MaxLength = 25
        Me.txtboxCodigo.Name = "txtboxCodigo"
        Me.txtboxCodigo.Size = New System.Drawing.Size(218, 13)
        Me.txtboxCodigo.TabIndex = 42
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NumericUpDownCantidad.BackColor = System.Drawing.Color.LightCyan
        Me.NumericUpDownCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(557, 50)
        Me.NumericUpDownCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.ReadOnly = True
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(218, 20)
        Me.NumericUpDownCantidad.TabIndex = 41
        Me.NumericUpDownCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(554, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(288, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Producto:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Código:"
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 14
        Me.LineShape2.X2 = 229
        Me.LineShape2.Y1 = 55
        Me.LineShape2.Y2 = 55
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(790, 81)
        Me.ShapeContainer2.TabIndex = 43
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 288
        Me.LineShape3.X2 = 503
        Me.LineShape3.Y1 = 55
        Me.LineShape3.Y2 = 55
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape6, Me.LineShape5})
        Me.ShapeContainer3.Size = New System.Drawing.Size(790, 330)
        Me.ShapeContainer3.TabIndex = 48
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 666
        Me.LineShape5.X2 = 784
        Me.LineShape5.Y1 = 277
        Me.LineShape5.Y2 = 277
        '
        'LineShape6
        '
        Me.LineShape6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape6.BorderColor = System.Drawing.Color.White
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 667
        Me.LineShape6.X2 = 785
        Me.LineShape6.Y1 = 322
        Me.LineShape6.Y2 = 322
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 28
        Me.LineShape1.X2 = 243
        Me.LineShape1.Y1 = 67
        Me.LineShape1.Y2 = 67
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(820, 560)
        Me.ShapeContainer1.TabIndex = 36
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 667
        Me.LineShape4.X2 = 785
        Me.LineShape4.Y1 = 233
        Me.LineShape4.Y2 = 233
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.GroupBoxDatosProducto)
        Me.Controls.Add(Me.dtpFechaVenta)
        Me.Controls.Add(Me.GroupBoxVentas)
        Me.Controls.Add(Me.txtBoxNumVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBoxVentas.ResumeLayout(False)
        Me.GroupBoxVentas.PerformLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosProducto.ResumeLayout(False)
        Me.GroupBoxDatosProducto.PerformLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxVentas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBoxNumVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewVentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarTodo As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarVenta As System.Windows.Forms.Button
    Friend WithEvents txtBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDatosProducto As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtboxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarBoleta As System.Windows.Forms.Button
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCambio As System.Windows.Forms.Button
    Friend WithEvents txtBoxCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
