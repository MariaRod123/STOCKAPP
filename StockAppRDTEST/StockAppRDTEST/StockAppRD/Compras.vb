Public Class Compras

#Region "Variables."

    Dim codProd As Int64 = 0 'Almacena mayor cantidad de dígitos que Integer.
    Dim precioUnitario As Double = 0
    Dim subTotal As Double = 0
    Dim subTotal2 As Double = 0
    Dim fechaPedido As String = ""
    Dim total As Double = 0
    Dim cantidadProducto As Integer = 0

    Dim productoAgregado As Boolean = False

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub Compras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Llena los combobox
        DS = consultar("SELECT Nombre From Proveedores")

        ComboBoxProveedor.DataSource = DS.Tables(0)
        ComboBoxProveedor.DisplayMember = "Nombre"

        DS = consultar("SELECT Nombre From Productos")

        ComboBoxProducto.DataSource = DS.Tables(0)
        ComboBoxProducto.DisplayMember = "Nombre"

    End Sub

    'Valida el ingreso de solo números en el TextBox.
    Private Sub txtBoxNumFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxNumFactura.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

#End Region

#Region "Métodos y funciones."

    Public Sub borrarTodo()

        'Limpia todos los textBox, el datagridview y establece los valores por defectos de los otros objetos.
        txtBoxNumFactura.Text = ""
        txtBoxTotal.Text = ""

        NumericUpDownCantidad.Value = 1

        ComboBoxProveedor.SelectedIndex = 0
        ComboBoxProducto.SelectedIndex = 0

        DataGridViewPedido.Rows.Clear()

        'Devuelve a sus valores por defecto a todas las variables.
        precioUnitario = 0
        subTotal = 0
        subTotal2 = 0
        total = 0
        codProd = 0
        productoAgregado = False

    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnNuevoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProducto.Click

        'Abre la pestaña Productos realizando clic en el boton Productos del FormPrincipal.
        FormPrincipal.btnProductos.PerformClick()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        DS = consultar("SELECT Precio_de_Venta FROM Productos WHERE Nombre='" + ComboBoxProducto.Text + "'")
        precioUnitario = DS.Tables(0).Rows(0)(0).ToString

        DS = consultar("SELECT Codigo_de_producto FROM Productos WHERE Nombre='" + ComboBoxProducto.Text + "'")
        codProd = DS.Tables(0).Rows(0)(0).ToString

        'Controla si se ha agregado algún producto.
        If DataGridViewPedido.Rows.Count = 0 Then

        Else

            'Controla si el producto ya se ha agregado anteriormente al DGV.
            For i = 0 To DataGridViewPedido.Rows.Count - 1 'Recorre el DGV

                If codProd = DataGridViewPedido.Item(0, i).FormattedValue.ToString Then 'Si el código del producto ya fue agregado al DGV.

                    productoAgregado = True

                    DataGridViewPedido.Item(3, i).Value = DataGridViewPedido.Item(3, i).Value + NumericUpDownCantidad.Value 'Le suma el valor del numericupdown a la cantidad del producto en el DGV.

                    subTotal = precioUnitario * DataGridViewPedido.Item(3, i).Value 'Precio unitario * cantidad.

                    DataGridViewPedido.Item(4, i).Value = subTotal 'Actualiza el subtotal en el DGV.

                    Exit For 'Sale del For

                Else

                    productoAgregado = False

                End If

            Next

        End If

        If productoAgregado = False Then 'Si el producto no fue agregado al DGV, lo agrega.

            subTotal = precioUnitario * NumericUpDownCantidad.Value

            DataGridViewPedido.Rows.Add(codProd, ComboBoxProducto.Text, precioUnitario, NumericUpDownCantidad.Value.ToString, subTotal)

        End If


        For i = 0 To DataGridViewPedido.Rows.Count - 1 'Suma todos los valores de la columna subtotal del DGV y lo guarda en la variable Total.

            total = total + DataGridViewPedido.Item(4, i).Value

        Next

        txtBoxTotal.Text = total

        NumericUpDownCantidad.Value = 1

        total = 0


    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtBoxNumFactura.Text = "" Or DataGridViewPedido.Rows.Count = 0 Then

            MsgBox("Faltan completar datos.")

        Else

            'Buscar por numero de pedido
            DS = consultar("SELECT Numero_de_pedido FROM Pedidos WHERE Numero_de_pedido= " + txtBoxNumFactura.Text + "")

            'Si no existe el número de pedido.
            If DS.Tables(0).Rows.Count = 0 Then

                For i = 0 To DataGridViewPedido.RowCount - 1

                    'Ingresa los productos comprados en la tabla Contienen de la base de datos.
                    ingresarComando("INSERT INTO contienen (Codigo_de_Producto, Numero_de_pedido, Descripcion, Precio_Unitario, Cantidad, SubTotal) VALUES ( " + DataGridViewPedido.Item(0, i).FormattedValue + " , " + txtBoxNumFactura.Text + " , '" + DataGridViewPedido.Item(1, i).FormattedValue + "' , " + DataGridViewPedido.Item(2, i).FormattedValue + " , " + DataGridViewPedido.Item(3, i).FormattedValue + " , " + DataGridViewPedido.Item(4, i).FormattedValue + ")")

                    'Cantidad actual de dicho producto en la tabla Productos.
                    DS = consultar("SELECT Cantidad FROM Productos WHERE Codigo_de_producto= " + DataGridViewPedido.Item(0, i).FormattedValue.ToString + "")
                    cantidadProducto = DS.Tables(0).Rows(0)(0)

                    'Cantidad actualizada del producto. Se suma la cantidad existente con la cantidad de productos comprados.
                    cantidadProducto = cantidadProducto + DataGridViewPedido.Item(3, i).FormattedValue.ToString

                    'Se actualiza la cantidad de productos en la tabla Productos de la base de datos.
                    ingresarComando("UPDATE productos SET Cantidad= " + cantidadProducto.ToString + " WHERE Codigo_de_producto= " + DataGridViewPedido.Item(0, i).FormattedValue.ToString)

                Next

                fechaPedido = Format(dtpFechaPedido.Value, "dd-MM-yyyy")

                ingresarComando("INSERT INTO pedidos (Numero_de_pedido, Fecha_del_pedido, Monto_total, Proveedor) VALUES (" + txtBoxNumFactura.Text.ToString + ", '" + fechaPedido.ToString + "' , " + txtBoxTotal.Text.ToString + ", '" + ComboBoxProveedor.Text.ToString + "')")

                borrarTodo()

                MsgBox("Compra realizada con éxito.")

            Else

                MsgBox("Este número de pedido ya ha sido ingresado.")

            End If

        End If

    End Sub

    Private Sub btnBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarTodo.Click

        borrarTodo()

    End Sub

#End Region

End Class