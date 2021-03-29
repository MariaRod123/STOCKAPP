Public Class Ventas

#Region "Variables."

    Dim codProd As Int64 = 0
    Dim Subtotal As Double = 0
    Dim precioVenta As Double = 0
    Dim Total As Double = 0
    Dim cantidadProducto As Integer = 0
    Dim cantidadActualizada As Integer = 0
    Dim efectivo As Double = 0
    Dim cambio As Double = 0
    Dim productoAgregado As Boolean = False

    Public datosDGV As New DataTable

    Dim fechaVenta As String = ""

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Valida el ingreso de solamente números en el TextBox. 
    Private Sub txtBoxNumVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxNumVenta.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    Private Sub txtBoxCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxCodigo.KeyPress

        'Valida el ingreso de solamente números en el TextBox.
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

        'Si la tecla presionada es ENTER.
        If e.KeyChar = ChrW(Keys.Enter) Then

            'Verifica si el textBox está vacío.
            If txtboxCodigo.Text = "" Then

                MsgBox("Ingrese un código de producto.")

            Else

                DS = consultar("SELECT * FROM Productos WHERE Codigo_de_producto= '" + txtboxCodigo.Text + "'")

                'Verifica si el producto existe.
                If DS.Tables(0).Rows.Count > 0 Then

                    precioVenta = DS.Tables(0).Rows(0)(2).ToString
                    codProd = DS.Tables(0).Rows(0)(0).ToString

                    'Controla si se ha agregado algún producto.
                    If DataGridViewVentas.Rows.Count = 0 Then

                    Else

                        'Controla si el producto ya se ha agregado anteriormente al DGV.
                        For i = 0 To DataGridViewVentas.Rows.Count - 1 'Recorre el DGV

                            If codProd = DataGridViewVentas.Item(0, i).FormattedValue.ToString Then 'Si el código del producto ya fue agregado al DGV.

                                productoAgregado = True

                                DataGridViewVentas.Item(3, i).Value = DataGridViewVentas.Item(3, i).Value + NumericUpDownCantidad.Value 'Le suma el valor del numericupdown a la cantidad del producto en el DGV.

                                Subtotal = precioVenta * DataGridViewVentas.Item(3, i).Value 'Precio unitario * cantidad.

                                DataGridViewVentas.Item(4, i).Value = Subtotal 'Actualiza el subtotal en el DGV.

                                Exit For 'Sale del For

                            Else

                                productoAgregado = False

                            End If

                        Next

                    End If

                    If productoAgregado = False Then 'Si el producto no fue agregado al DGV, lo agrega.

                        Subtotal = precioVenta * NumericUpDownCantidad.Value

                        DataGridViewVentas.Rows.Add(codProd, DS.Tables(0).Rows(0)(1).ToString, precioVenta, NumericUpDownCantidad.Value.ToString, Subtotal)


                    End If


                    For i = 0 To DataGridViewVentas.Rows.Count - 1 'Suma todos los valores de la columna subtotal del DGV y lo guarda en la variable Total.

                        Total = Total + DataGridViewVentas.Item(4, i).Value

                    Next

                    txtBoxTotal.Text = Total

                    NumericUpDownCantidad.Value = 1

                    Total = 0

                Else

                    MsgBox("El producto seleccionado no existe.")

                End If

            End If

        End If

    End Sub

    Private Sub txtBoxProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxProducto.KeyPress

        'Si la tecla presionada es ENTER.
        If e.KeyChar = ChrW(Keys.Enter) Then

            'Verifica si el textBox está vacío.
            If txtBoxProducto.Text = "" Then

                MsgBox("Ingrese un nombre de producto.")

            Else

                DS = consultar("SELECT * FROM Productos WHERE Nombre= '" + txtBoxProducto.Text + "'")

                'Verifica si el producto existe.
                If DS.Tables(0).Rows.Count > 0 Then

                    precioVenta = DS.Tables(0).Rows(0)(2).ToString
                    codProd = DS.Tables(0).Rows(0)(0).ToString

                    'Controla si se ha agregado algún producto.
                    If DataGridViewVentas.Rows.Count = 0 Then

                    Else

                        'Controla si el producto ya se ha agregado anteriormente al DGV.
                        For i = 0 To DataGridViewVentas.Rows.Count - 1 'Recorre el DGV

                            If codProd = DataGridViewVentas.Item(0, i).FormattedValue.ToString Then 'Si el código del producto ya fue agregado al DGV.

                                productoAgregado = True

                                DataGridViewVentas.Item(3, i).Value = DataGridViewVentas.Item(3, i).Value + NumericUpDownCantidad.Value 'Le suma el valor del numericupdown a la cantidad del producto en el DGV.

                                Subtotal = precioVenta * DataGridViewVentas.Item(3, i).Value 'Precio unitario * cantidad.

                                DataGridViewVentas.Item(4, i).Value = Subtotal 'Actualiza el subtotal en el DGV.

                                Exit For 'Sale del For

                            Else

                                productoAgregado = False

                            End If

                        Next

                    End If

                    If productoAgregado = False Then 'Si el producto no fue agregado al DGV, lo agrega.

                        Subtotal = precioVenta * NumericUpDownCantidad.Value

                        DataGridViewVentas.Rows.Add(codProd, txtBoxProducto.Text, precioVenta, NumericUpDownCantidad.Value.ToString, Subtotal)

                    End If


                    For i = 0 To DataGridViewVentas.Rows.Count - 1 'Suma todos los valores de la columna subtotal del DGV y lo guarda en la variable Total.

                        Total = Total + DataGridViewVentas.Item(4, i).Value

                    Next

                    txtBoxTotal.Text = Total

                    NumericUpDownCantidad.Value = 1

                    Total = 0

                Else

                    MsgBox("El producto seleccionado no existe.")

                End If

            End If

        End If

    End Sub

#End Region

#Region "Métodos y funciones."

    Public Sub borrarTodo()

        'Limpia todos los textBox, el datagridview y establece los valores por defectos de los otros objetos.
        txtBoxNumVenta.Text = ""
        txtboxCodigo.Text = ""
        txtBoxProducto.Text = ""
        txtBoxTotal.Text = ""
        txtBoxEfectivo.Text = ""
        txtBoxCambio.Text = ""

        NumericUpDownCantidad.Value = 1

        DataGridViewVentas.Rows.Clear()

        codProd = 0
        precioVenta = 0
        Subtotal = 0
        Total = 0
        productoAgregado = False

    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarTodo.Click

        borrarTodo()

    End Sub

    Private Sub btnRegistrarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarVenta.Click

        If txtBoxNumVenta.Text = "" Or DataGridViewVentas.Rows.Count = 0 Then

            MsgBox("Faltan completar datos.")

        Else

            'Buscar por ID de Venta
            DS = consultar("SELECT ID_Venta FROM Ventas WHERE ID_Venta= '" + txtBoxNumVenta.Text + "'")

            ''Si no existe el ID de venta.
            If DS.Tables(0).Rows.Count = 0 Then

                For i = 0 To DataGridViewVentas.RowCount - 1

                    'Cantidad actual de dicho producto en la tabla Productos.
                    DS = consultar("SELECT Cantidad FROM Productos WHERE Codigo_de_producto= '" + DataGridViewVentas.Item(0, i).FormattedValue.ToString + "'")
                    cantidadProducto = DS.Tables(0).Rows(0)(0)

                    'Cantidad actualizada del producto. Se resta la cantidad existente con la cantidad de productos comprados.
                    cantidadActualizada = cantidadProducto - DataGridViewVentas.Item(3, i).FormattedValue.ToString

                    'Verifica si la cantidad del producto es suficiente.
                    If cantidadActualizada = 0 Then

                        'Ingresa el producto vendido en la tabla Tienen de la base de datos.
                        ingresarComando("INSERT INTO Tienen (Codigo_de_Producto, ID_Venta, Descripcion, Cantidad, Precio_Unitario, SubTotal) VALUES ( '" + DataGridViewVentas.Item(0, i).FormattedValue.ToString + "' , '" + txtBoxNumVenta.Text + "' , '" + DataGridViewVentas.Item(1, i).FormattedValue + "' , " + DataGridViewVentas.Item(3, i).FormattedValue + " , '" + DataGridViewVentas.Item(2, i).FormattedValue.ToString + "' , '" + DataGridViewVentas.Item(4, i).FormattedValue.ToString + "')")

                        'Borra el producto de la tabla Productos
                        ingresarComando("DELETE FROM Productos WHERE Codigo_de_producto= '" + DataGridViewVentas.Item(0, i).FormattedValue.ToString + "'")

                        'Avisa de la falta del producto.
                        MsgBox("Ya no queda más " + DataGridViewVentas.Item(1, i).FormattedValue.ToString + " disponible. Recuerda comprar más.")

                    ElseIf cantidadActualizada < 0 Then

                        DataGridViewVentas.Item(4, i).Value = 0

                        MsgBox("El stock de " + DataGridViewVentas.Item(1, i).FormattedValue.ToString + " es insuficiente. No fue agregado a la compra.")

                    Else

                        'Ingresa el producto vendido en la tabla Tienen de la base de datos.
                        ingresarComando("INSERT INTO Tienen (Codigo_de_Producto, ID_Venta, Descripcion, Cantidad, Precio_Unitario, SubTotal) VALUES ( '" + DataGridViewVentas.Item(0, i).FormattedValue + "' , '" + txtBoxNumVenta.Text + "' , '" + DataGridViewVentas.Item(1, i).FormattedValue + "' , " + DataGridViewVentas.Item(3, i).FormattedValue + " , '" + DataGridViewVentas.Item(2, i).FormattedValue.ToString + "' , '" + DataGridViewVentas.Item(4, i).FormattedValue.ToString + "')")

                        'Se actualiza la cantidad de productos en la tabla Productos de la base de datos.
                        ingresarComando("UPDATE productos SET Cantidad= " + cantidadActualizada.ToString + " WHERE Codigo_de_producto= " + DataGridViewVentas.Item(0, i).FormattedValue.ToString)

                    End If

                Next

                'Suma todos los valores de la columna subtotal del DGV y lo guarda en la variable Total.
                For i = 0 To DataGridViewVentas.Rows.Count - 1

                    Total = Total + DataGridViewVentas.Item(4, i).Value

                Next

                txtBoxTotal.Text = Total

                fechaVenta = Format(dtpFechaVenta.Value, "dd-MM-yyyy")

                ingresarComando("INSERT INTO Ventas (ID_Venta, Precio_total, Fecha_de_venta) VALUES ('" + txtBoxNumVenta.Text.ToString + "', '" + txtBoxTotal.Text.ToString + "', '" + fechaVenta + "')")

                borrarTodo()

                MsgBox("Venta realizada con éxito.")

            Else

                MsgBox("Este número de venta ya ha sido ingresado.")

            End If

        End If

    End Sub

    Private Sub btnGenerarBoleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarBoleta.Click


        If txtBoxNumVenta.Text = "" Or DataGridViewVentas.Rows.Count = 0 Then

            MsgBox("Faltan completar datos.")

        Else

            fechaVenta = Format(dtpFechaVenta.Value, "dd-MM-yyyy")

            Boleta.txtBoxSerie.Text = txtBoxNumVenta.Text
            Boleta.txtBoxFechaBoleta.Text = fechaVenta.ToString
            Boleta.txtBoxTotalBoleta.Text = txtBoxTotal.Text

            For i = 0 To DataGridViewVentas.Rows.Count() - 1

                Boleta.DataGridViewBoleta.Rows.Add(DataGridViewVentas.Item(0, i).FormattedValue.ToString, DataGridViewVentas.Item(1, i).FormattedValue.ToString, DataGridViewVentas.Item(2, i).FormattedValue.ToString, DataGridViewVentas.Item(3, i).FormattedValue.ToString, DataGridViewVentas.Item(4, i).FormattedValue.ToString)

            Next

            Boleta.Show()

        End If


    End Sub

#End Region

    Private Sub btnCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambio.Click

        efectivo = txtBoxEfectivo.Text
        Total = txtBoxTotal.Text


        If efectivo > Total Then

            cambio = efectivo - Total
            txtBoxCambio.Text = cambio

        ElseIf efectivo = Total Then

            txtBoxCambio.Text = cambio

        End If


    End Sub
End Class





