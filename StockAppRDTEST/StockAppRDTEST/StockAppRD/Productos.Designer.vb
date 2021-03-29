<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxCodigo = New System.Windows.Forms.TextBox()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxCosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.radioBtnSi = New System.Windows.Forms.RadioButton()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.GroupBoxIngreso = New System.Windows.Forms.GroupBox()
        Me.btnNuevaCategoria = New System.Windows.Forms.Button()
        Me.radioBtnNo = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comboBoxCategoriaBusq = New System.Windows.Forms.ComboBox()
        Me.txtBoxNombreBusq = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBoxIngreso.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar pestaña"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Código:"
        '
        'txtBoxCodigo
        '
        Me.txtBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxCodigo.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxCodigo.Location = New System.Drawing.Point(124, 370)
        Me.txtBoxCodigo.MaxLength = 25
        Me.txtBoxCodigo.Name = "txtBoxCodigo"
        Me.txtBoxCodigo.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxCodigo.TabIndex = 9
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxNombre.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNombre.Location = New System.Drawing.Point(124, 55)
        Me.txtBoxNombre.MaxLength = 25
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxNombre.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre:"
        '
        'txtBoxCosto
        '
        Me.txtBoxCosto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxCosto.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxCosto.Location = New System.Drawing.Point(124, 105)
        Me.txtBoxCosto.MaxLength = 25
        Me.txtBoxCosto.Name = "txtBoxCosto"
        Me.txtBoxCosto.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxCosto.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(67, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Costo:"
        '
        'txtBoxCantidad
        '
        Me.txtBoxCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxCantidad.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxCantidad.Location = New System.Drawing.Point(124, 162)
        Me.txtBoxCantidad.MaxLength = 5
        Me.txtBoxCantidad.Name = "txtBoxCantidad"
        Me.txtBoxCantidad.Size = New System.Drawing.Size(119, 16)
        Me.txtBoxCantidad.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(49, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Vencimiento:"
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFechaVencimiento.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(124, 298)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(119, 23)
        Me.dtpFechaVencimiento.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Categoría:"
        '
        'comboBoxCategoria
        '
        Me.comboBoxCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboBoxCategoria.BackColor = System.Drawing.Color.LightBlue
        Me.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBoxCategoria.FormattingEnabled = True
        Me.comboBoxCategoria.Location = New System.Drawing.Point(124, 213)
        Me.comboBoxCategoria.Name = "comboBoxCategoria"
        Me.comboBoxCategoria.Size = New System.Drawing.Size(119, 25)
        Me.comboBoxCategoria.TabIndex = 19
        '
        'radioBtnSi
        '
        Me.radioBtnSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radioBtnSi.AutoSize = True
        Me.radioBtnSi.ForeColor = System.Drawing.Color.Black
        Me.radioBtnSi.Location = New System.Drawing.Point(124, 327)
        Me.radioBtnSi.Name = "radioBtnSi"
        Me.radioBtnSi.Size = New System.Drawing.Size(35, 21)
        Me.radioBtnSi.TabIndex = 20
        Me.radioBtnSi.TabStop = True
        Me.radioBtnSi.Text = "Sí"
        Me.radioBtnSi.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(117, 514)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(128, 34)
        Me.btnIngresar.TabIndex = 25
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'GroupBoxIngreso
        '
        Me.GroupBoxIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxIngreso.Controls.Add(Me.btnNuevaCategoria)
        Me.GroupBoxIngreso.Controls.Add(Me.radioBtnNo)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxCodigo)
        Me.GroupBoxIngreso.Controls.Add(Me.Label2)
        Me.GroupBoxIngreso.Controls.Add(Me.Label3)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxNombre)
        Me.GroupBoxIngreso.Controls.Add(Me.Label4)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxCosto)
        Me.GroupBoxIngreso.Controls.Add(Me.radioBtnSi)
        Me.GroupBoxIngreso.Controls.Add(Me.Label5)
        Me.GroupBoxIngreso.Controls.Add(Me.comboBoxCategoria)
        Me.GroupBoxIngreso.Controls.Add(Me.txtBoxCantidad)
        Me.GroupBoxIngreso.Controls.Add(Me.Label7)
        Me.GroupBoxIngreso.Controls.Add(Me.Label6)
        Me.GroupBoxIngreso.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBoxIngreso.Controls.Add(Me.ShapeContainer2)
        Me.GroupBoxIngreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIngreso.Location = New System.Drawing.Point(12, 50)
        Me.GroupBoxIngreso.Name = "GroupBoxIngreso"
        Me.GroupBoxIngreso.Size = New System.Drawing.Size(249, 458)
        Me.GroupBoxIngreso.TabIndex = 26
        Me.GroupBoxIngreso.TabStop = False
        Me.GroupBoxIngreso.Text = "Ingresar producto"
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNuevaCategoria.BackColor = System.Drawing.Color.LightBlue
        Me.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCategoria.ForeColor = System.Drawing.Color.Black
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(124, 244)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(119, 25)
        Me.btnNuevaCategoria.TabIndex = 38
        Me.btnNuevaCategoria.Text = "Nueva"
        Me.btnNuevaCategoria.UseVisualStyleBackColor = False
        '
        'radioBtnNo
        '
        Me.radioBtnNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radioBtnNo.AutoSize = True
        Me.radioBtnNo.ForeColor = System.Drawing.Color.Black
        Me.radioBtnNo.Location = New System.Drawing.Point(198, 327)
        Me.radioBtnNo.Name = "radioBtnNo"
        Me.radioBtnNo.Size = New System.Drawing.Size(45, 21)
        Me.radioBtnNo.TabIndex = 30
        Me.radioBtnNo.TabStop = True
        Me.radioBtnNo.Text = "No"
        Me.radioBtnNo.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(243, 436)
        Me.ShapeContainer2.TabIndex = 39
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 121
        Me.LineShape4.X2 = 239
        Me.LineShape4.Y1 = 369
        Me.LineShape4.Y2 = 369
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 122
        Me.LineShape3.X2 = 240
        Me.LineShape3.Y1 = 161
        Me.LineShape3.Y2 = 161
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 121
        Me.LineShape2.X2 = 239
        Me.LineShape2.Y1 = 104
        Me.LineShape2.Y2 = 104
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 121
        Me.LineShape1.X2 = 239
        Me.LineShape1.Y1 = 52
        Me.LineShape1.Y2 = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Categoría:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(239, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Nombre:"
        '
        'comboBoxCategoriaBusq
        '
        Me.comboBoxCategoriaBusq.BackColor = System.Drawing.Color.LightBlue
        Me.comboBoxCategoriaBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCategoriaBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBoxCategoriaBusq.FormattingEnabled = True
        Me.comboBoxCategoriaBusq.Location = New System.Drawing.Point(9, 47)
        Me.comboBoxCategoriaBusq.Name = "comboBoxCategoriaBusq"
        Me.comboBoxCategoriaBusq.Size = New System.Drawing.Size(218, 25)
        Me.comboBoxCategoriaBusq.TabIndex = 34
        '
        'txtBoxNombreBusq
        '
        Me.txtBoxNombreBusq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxNombreBusq.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNombreBusq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNombreBusq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNombreBusq.Location = New System.Drawing.Point(242, 49)
        Me.txtBoxNombreBusq.MaxLength = 25
        Me.txtBoxNombreBusq.Name = "txtBoxNombreBusq"
        Me.txtBoxNombreBusq.Size = New System.Drawing.Size(219, 16)
        Me.txtBoxNombreBusq.TabIndex = 31
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(575, 514)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProd)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProductos)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.comboBoxCategoriaBusq)
        Me.GroupBox1.Controls.Add(Me.txtBoxNombreBusq)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(267, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 458)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnBuscarProd
        '
        Me.btnBuscarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarProd.FlatAppearance.BorderSize = 0
        Me.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProd.Image = Global.StockAppRD.My.Resources.Resources.IconBuscar1
        Me.btnBuscarProd.Location = New System.Drawing.Point(467, 35)
        Me.btnBuscarProd.Name = "btnBuscarProd"
        Me.btnBuscarProd.Size = New System.Drawing.Size(56, 46)
        Me.btnBuscarProd.TabIndex = 38
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        Me.DataGridViewProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(6, 86)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewProductos.Size = New System.Drawing.Size(530, 366)
        Me.DataGridViewProductos.TabIndex = 30
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(536, 436)
        Me.ShapeContainer1.TabIndex = 37
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 239
        Me.LineShape5.X2 = 455
        Me.LineShape5.Y1 = 53
        Me.LineShape5.Y2 = 53
        '
        'Productos
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxIngreso)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Ingreso"
        Me.GroupBoxIngreso.ResumeLayout(False)
        Me.GroupBoxIngreso.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents comboBoxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents radioBtnSi As System.Windows.Forms.RadioButton
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtBoxNombreBusq As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents comboBoxCategoriaBusq As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioBtnNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnNuevaCategoria As System.Windows.Forms.Button
    Friend WithEvents DataGridViewProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnBuscarProd As System.Windows.Forms.Button
End Class
