<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.GroupBoxIngresoProveedor = New System.Windows.Forms.GroupBox()
        Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxRUT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.txtBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBoxDireccion = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.GroupBoxBusquedaProveedor = New System.Windows.Forms.GroupBox()
        Me.txtBoxBusquedaRUT = New System.Windows.Forms.TextBox()
        Me.DataGridViewProveedores = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBoxBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBoxIngresoProveedor.SuspendLayout()
        Me.GroupBoxBusquedaProveedor.SuspendLayout()
        CType(Me.DataGridViewProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar pestaña"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBoxIngresoProveedor
        '
        Me.GroupBoxIngresoProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.comboBoxCategoria)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.Label1)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.txtBoxRUT)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.Label2)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.Label3)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.txtBoxNombre)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.txtBoxTelefono)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.Label4)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.Label8)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.txtBoxDireccion)
        Me.GroupBoxIngresoProveedor.Controls.Add(Me.ShapeContainer2)
        Me.GroupBoxIngresoProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIngresoProveedor.Location = New System.Drawing.Point(12, 52)
        Me.GroupBoxIngresoProveedor.Name = "GroupBoxIngresoProveedor"
        Me.GroupBoxIngresoProveedor.Size = New System.Drawing.Size(331, 456)
        Me.GroupBoxIngresoProveedor.TabIndex = 27
        Me.GroupBoxIngresoProveedor.TabStop = False
        Me.GroupBoxIngresoProveedor.Text = "Ingresar proveedor"
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboBoxCategoria.BackColor = System.Drawing.Color.LightBlue
        Me.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.Location = New System.Drawing.Point(131, 350)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(180, 25)
        Me.comboBoxCategoria.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Categoría:"
        '
        'txtBoxRUT
        '
        Me.txtBoxRUT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxRUT.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxRUT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxRUT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxRUT.Location = New System.Drawing.Point(132, 84)
        Me.txtBoxRUT.MaxLength = 25
        Me.txtBoxRUT.Name = "txtBoxRUT"
        Me.txtBoxRUT.Size = New System.Drawing.Size(180, 16)
        Me.txtBoxRUT.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(80, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "R.U.T.:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(60, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre:"
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxNombre.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNombre.Location = New System.Drawing.Point(132, 156)
        Me.txtBoxNombre.MaxLength = 25
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(180, 16)
        Me.txtBoxNombre.TabIndex = 11
        '
        'txtBoxTelefono
        '
        Me.txtBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxTelefono.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxTelefono.Location = New System.Drawing.Point(131, 285)
        Me.txtBoxTelefono.MaxLength = 25
        Me.txtBoxTelefono.Name = "txtBoxTelefono"
        Me.txtBoxTelefono.Size = New System.Drawing.Size(180, 16)
        Me.txtBoxTelefono.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(52, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(59, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Teléfono:"
        '
        'txtBoxDireccion
        '
        Me.txtBoxDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxDireccion.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxDireccion.Location = New System.Drawing.Point(131, 221)
        Me.txtBoxDireccion.MaxLength = 25
        Me.txtBoxDireccion.Name = "txtBoxDireccion"
        Me.txtBoxDireccion.Size = New System.Drawing.Size(180, 16)
        Me.txtBoxDireccion.TabIndex = 13
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(536, 514)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 34)
        Me.btnEliminar.TabIndex = 27
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(346, 514)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(128, 34)
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(156, 514)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(128, 34)
        Me.btnIngresar.TabIndex = 25
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'GroupBoxBusquedaProveedor
        '
        Me.GroupBoxBusquedaProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.txtBoxBusquedaRUT)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.DataGridViewProveedores)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.Label12)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.Label11)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.txtBoxBusquedaNombre)
        Me.GroupBoxBusquedaProveedor.Controls.Add(Me.ShapeContainer1)
        Me.GroupBoxBusquedaProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBusquedaProveedor.Location = New System.Drawing.Point(349, 52)
        Me.GroupBoxBusquedaProveedor.Name = "GroupBoxBusquedaProveedor"
        Me.GroupBoxBusquedaProveedor.Size = New System.Drawing.Size(459, 456)
        Me.GroupBoxBusquedaProveedor.TabIndex = 28
        Me.GroupBoxBusquedaProveedor.TabStop = False
        Me.GroupBoxBusquedaProveedor.Text = "Búsqueda"
        '
        'txtBoxBusquedaRUT
        '
        Me.txtBoxBusquedaRUT.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxBusquedaRUT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxBusquedaRUT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxBusquedaRUT.Location = New System.Drawing.Point(9, 47)
        Me.txtBoxBusquedaRUT.MaxLength = 25
        Me.txtBoxBusquedaRUT.Name = "txtBoxBusquedaRUT"
        Me.txtBoxBusquedaRUT.Size = New System.Drawing.Size(219, 16)
        Me.txtBoxBusquedaRUT.TabIndex = 42
        '
        'DataGridViewProveedores
        '
        Me.DataGridViewProveedores.AllowUserToAddRows = False
        Me.DataGridViewProveedores.AllowUserToDeleteRows = False
        Me.DataGridViewProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridViewProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.DataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProveedores.Location = New System.Drawing.Point(5, 84)
        Me.DataGridViewProveedores.Name = "DataGridViewProveedores"
        Me.DataGridViewProveedores.ReadOnly = True
        Me.DataGridViewProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewProveedores.Size = New System.Drawing.Size(448, 366)
        Me.DataGridViewProveedores.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "R.U.T.:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(233, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Nombre:"
        '
        'txtBoxBusquedaNombre
        '
        Me.txtBoxBusquedaNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxBusquedaNombre.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxBusquedaNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxBusquedaNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxBusquedaNombre.Location = New System.Drawing.Point(236, 47)
        Me.txtBoxBusquedaNombre.MaxLength = 25
        Me.txtBoxBusquedaNombre.Name = "txtBoxBusquedaNombre"
        Me.txtBoxBusquedaNombre.Size = New System.Drawing.Size(219, 16)
        Me.txtBoxBusquedaNombre.TabIndex = 38
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape4, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(325, 434)
        Me.ShapeContainer2.TabIndex = 30
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 130
        Me.LineShape2.X2 = 308
        Me.LineShape2.Y1 = 155
        Me.LineShape2.Y2 = 155
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 129
        Me.LineShape3.X2 = 307
        Me.LineShape3.Y1 = 221
        Me.LineShape3.Y2 = 221
        '
        'LineShape4
        '
        Me.LineShape4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 131
        Me.LineShape4.X2 = 309
        Me.LineShape4.Y1 = 283
        Me.LineShape4.Y2 = 283
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape6})
        Me.ShapeContainer1.Size = New System.Drawing.Size(453, 434)
        Me.ShapeContainer1.TabIndex = 43
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape6.BorderColor = System.Drawing.Color.White
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 233
        Me.LineShape6.X2 = 449
        Me.LineShape6.Y1 = 47
        Me.LineShape6.Y2 = 47
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 130
        Me.LineShape1.X2 = 308
        Me.LineShape1.Y1 = 85
        Me.LineShape1.Y2 = 85
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 9
        Me.LineShape5.X2 = 225
        Me.LineShape5.Y1 = 47
        Me.LineShape5.Y2 = 47
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.GroupBoxBusquedaProveedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBoxIngresoProveedor)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.GroupBoxIngresoProveedor.ResumeLayout(False)
        Me.GroupBoxIngresoProveedor.PerformLayout()
        Me.GroupBoxBusquedaProveedor.ResumeLayout(False)
        Me.GroupBoxBusquedaProveedor.PerformLayout()
        CType(Me.DataGridViewProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxIngresoProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtBoxRUT As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxBusquedaProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxBusquedaRUT As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBoxBusquedaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboBoxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
