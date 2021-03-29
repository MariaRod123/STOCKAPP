Public Class Productos

#Region "Variables."

    Dim precioCosto As Double = 0
    Dim Subtotal As Double = 0
    Dim precioVenta As Double = 0
    Dim Total As Double = 0
    Dim utilidad As Double = 0
    Dim cantidad As Double = 0
    Dim Suma As Double = 0
    Dim buscando As Boolean = True

    Dim codigoElegido As String = ""

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Carga todos los datos de la tabla productos en el datagridview
        DS = consultar("SELECT * FROM Productos")
        DataGridViewProductos.DataSource = DS.Tables(0)

        'Desactiva la fecha de vencimiento al inicializar.
        radioBtnNo.Checked = True

        'Llena los combobox
        DS = consultar("SELECT Categoria From Categorias")

        comboBoxCategoria.DataSource = DS.Tables(0)
        comboBoxCategoria.DisplayMember = "Categoria"

        comboBoxCategoriaBusq.DataSource = DS.Tables(0)
        comboBoxCategoriaBusq.DisplayMember = "Categoria"

    End Sub

    Private Sub DataGridViewProductos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewProductos.CellContentClick

        Try

            'Almacena en la variable codigoElegido el codigo del producto seleccionado en el DataGridView
            codigoElegido = DataGridViewProductos.Item(0, e.RowIndex).FormattedValue

            txtBoxCodigo.Text = codigoElegido
            txtBoxNombre.Text = DataGridViewProductos.Item(1, e.RowIndex).FormattedValue
            txtBoxNombreBusq.Text = DataGridViewProductos.Item(1, e.RowIndex).FormattedValue
            txtBoxCosto.Text = DataGridViewProductos.Item(4, e.RowIndex).FormattedValue
            txtBoxCantidad.Text = DataGridViewProductos.Item(3, e.RowIndex).FormattedValue
            dtpFechaVencimiento.Text = DataGridViewProductos.Item(5, e.RowIndex).FormattedValue

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBoxNombreBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxNombreBusq.KeyPress

        'Muestra todas las celdas del DataGridView cuando el txtBoxNombreBusq está vacío
        If txtBoxNombreBusq.Text = "" Then

            'Carga todos los datos de la tabla productos en el datagridview
            DS = consultar("SELECT * FROM Productos")
            DataGridViewProductos.DataSource = DS.Tables(0)

        End If

    End Sub

    'Validación para ingresar solamente números en el TextBox.
    Private Sub txtBoxCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxCodigo.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    'Validación para ingresar solamente números en el TextBox.
    Private Sub txtBoxCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxCosto.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    'Validación para ingresar solamente números en el TextBox.
    Private Sub txtBoxCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxCantidad.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        DS = consultar("SELECT Codigo_de_producto FROM Productos WHERE Codigo_de_producto= '" + txtBoxCodigo.Text + "'")

        'Si el código de producto ya ha sido ingresado anteriormente.
        If DS.Tables(0).Rows.Count > 0 Then

            MsgBox("Ya existe un producto con este mismo código.")

        Else

            Dim fechaVenc As String = ""

            'Verifica que no hayan campos sin completar. 
            If txtBoxCodigo.Text = "" Or txtBoxNombre.Text = "" Or txtBoxCantidad.Text = "" Or comboBoxCategoria.Text = "" Or txtBoxCosto.Text = "" Then

                MsgBox("Faltan completar datos.")

            Else

                If dtpFechaVencimiento.Enabled = False Then 'Verifica si el vencimiento esta activado.

                    fechaVenc = "NO"

                Else

                    'Formatea la fecha ingresada en el DateTimePicker y la guarda en fechaVenc.
                    fechaVenc = Format(dtpFechaVencimiento.Value, "dd-MM-yyyy")

                End If

                precioCosto = txtBoxCosto.Text
                cantidad = txtBoxCantidad.Text

                DS = consultar("SELECT Utilidad FROM Categorias WHERE Categoria = '" + comboBoxCategoria.Text + "'")

                utilidad = DS.Tables(0).Rows(0)(0).ToString

                utilidad = utilidad / 100

                precioVenta = precioCosto + (precioCosto * utilidad)
                Subtotal = precioVenta * cantidad
                Total = Subtotal

                'Agrega los datos del producto en la tabla Productos de la BD.
                ingresarComando("INSERT INTO productos(Codigo_de_producto, Nombre, Precio_de_venta, Cantidad, Costo,  Fecha_de_vencimiento, Categoria) VALUES ('" + txtBoxCodigo.Text.ToString + "' , '" + txtBoxNombre.Text + "' , '" + precioVenta.ToString + "' , " + txtBoxCantidad.Text.ToString + " , '" + txtBoxCosto.Text.ToString + "', '" + fechaVenc.ToString + "' , '" + comboBoxCategoria.Text + "')")

                'Carga todos los datos de la tabla productos en el datagridview
                DS = consultar("SELECT * FROM Productos")
                DataGridViewProductos.DataSource = DS.Tables(0)

                txtBoxCodigo.Text = ""
                txtBoxNombre.Text = ""
                txtBoxCantidad.Text = ""
                txtBoxCosto.Text = ""

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        precioCosto = txtBoxCosto.Text

        DS = consultar("SELECT Utilidad FROM Categorias WHERE Categoria = '" + comboBoxCategoria.Text + "'")

        utilidad = DS.Tables(0).Rows(0)(0).ToString
        utilidad = utilidad / 100

        precioVenta = precioCosto + (precioCosto * utilidad)

        ingresarComando("UPDATE Productos SET Nombre= '" + txtBoxNombre.Text + "', Precio_de_venta= '" + precioVenta.ToString + "', Cantidad= " + txtBoxCantidad.Text + ", Costo= '" + txtBoxCosto.Text + "' WHERE Codigo_de_producto = '" + txtBoxCodigo.Text + "'")

        'Carga todos los datos de la tabla productos en el datagridview
        DS = consultar("SELECT * FROM Productos")
        DataGridViewProductos.DataSource = DS.Tables(0)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If codigoElegido = "" Then

            MsgBox("No ha seleccionado ningún producto.")

        Else

            ingresarComando("DELETE FROM productos WHERE Codigo_de_producto = '" + codigoElegido.ToString + "'")

            'Carga todos los datos de la tabla productos en el datagridview
            DS = consultar("SELECT * FROM Productos")
            DataGridViewProductos.DataSource = DS.Tables(0)

            codigoElegido = ""

        End If

    End Sub

    Private Sub radioBtnSí_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBtnSi.CheckedChanged

        'Verifica si la fecha de vencimiento está activada o no.
        If radioBtnSi.Checked = True Then

            dtpFechaVencimiento.Enabled = True

        ElseIf radioBtnNo.Checked = True Then

            dtpFechaVencimiento.Enabled = False

        End If

    End Sub

    Private Sub btnNuevaCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCategoria.Click

        Categorias.Show()

    End Sub

    Private Sub btnBuscarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProd.Click

        If buscando = False Then

            'Carga todos los datos de la tabla productos en el datagridview
            DS = consultar("SELECT * FROM Productos")
            DataGridViewProductos.DataSource = DS.Tables(0)

            buscando = True

        Else

            'Busca el producto por nombre y lo muestra en el datagridview.
            'Si el txtBoxNombreBusq está vacío, buscará el producto por la categoría seleccionada.
            If txtBoxNombreBusq.Text = "" Then

                DS = consultar("SELECT * FROM Productos WHERE Categoria = '" + comboBoxCategoriaBusq.Text + "'")

                If DS.Tables(0).Rows.Count = 0 Then

                    MsgBox("No existe ningún producto en la categoría seleccionada.")

                Else

                    DataGridViewProductos.DataSource = Nothing
                    DataGridViewProductos.CurrentCell = Nothing

                    DataGridViewProductos.Rows.Clear()
                    DataGridViewProductos.Columns.Clear()

                    DataGridViewProductos.DataSource = DS.Tables(0)

                End If

            Else

                DS = consultar("SELECT * FROM Productos WHERE Nombre = '" + txtBoxNombreBusq.Text + "'")

                If DS.Tables(0).Rows.Count = 0 Then

                    MsgBox("No existe el producto ingresado.")

                Else

                    DataGridViewProductos.DataSource = Nothing
                    DataGridViewProductos.CurrentCell = Nothing

                    DataGridViewProductos.Rows.Clear()
                    DataGridViewProductos.Columns.Clear()

                    DataGridViewProductos.DataSource = DS.Tables(0)

                End If

            End If

            buscando = False

        End If

    End Sub

#End Region

End Class