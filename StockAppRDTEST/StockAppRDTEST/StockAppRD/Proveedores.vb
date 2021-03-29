Public Class Proveedores

#Region "Variables."

    Dim contador As Integer
    Dim codigoElegido As String = 0

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub Proveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DS = consultar("SELECT * FROM Proveedores")
        DataGridViewProveedores.DataSource = DS.Tables(0)

        DS = consultar("SELECT Categoria FROM Categorias")
        comboBoxCategoria.DataSource = DS.Tables(0)
        comboBoxCategoria.DisplayMember = "Categoria"

    End Sub

    'Validación para ingresar solamente números en el TextBox.
    Private Sub txtBoxRUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxRUT.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    'Validación para ingresar solamente números en el TextBox.
    Private Sub txtBoxTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxTelefono.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    Private Sub txtBoxBusquedaRUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxBusquedaRUT.KeyPress
        'Muestra todas las celdas del DataGridView cuando el txtBoxBusquedaRUT está vacío
        If txtBoxBusquedaRUT.Text = "" Then

            'Carga todos los datos de la tabla proveedores en el datagridview
            DS = consultar("SELECT * FROM Proveedores")
            DataGridViewProveedores.DataSource = DS.Tables(0)

        End If

        'Valida el ingreso de solamente números en el textBox
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

        'Establece las acciones a realizar cuando se presione la tecla ENTER.
        If e.KeyChar = ChrW(Keys.Enter) Then

            If txtBoxBusquedaRUT.Text = "" Then

                MsgBox("Ingrese el RUT del proveedor a buscar.")

            Else

                DS = consultar("SELECT * FROM Proveedores WHERE RUT = '" + txtBoxBusquedaRUT.Text + "'")

                If DS.Tables(0).Rows.Count = 0 Then

                    MsgBox("No existe el proveedor ingresado.")

                Else

                    DataGridViewProveedores.DataSource = Nothing
                    DataGridViewProveedores.CurrentCell = Nothing

                    DataGridViewProveedores.Rows.Clear()
                    DataGridViewProveedores.Columns.Clear()

                    DataGridViewProveedores.DataSource = DS.Tables(0)

                End If

            End If

        End If

    End Sub

    Private Sub txtBoxBusquedaNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxBusquedaNombre.KeyPress

        'Muestra todas las celdas del DataGridView cuando el txtBoxBusquedaRUT está vacío
        If txtBoxBusquedaNombre.Text = "" Then

            'Carga todos los datos de la tabla proveedores en el datagridview
            DS = consultar("SELECT * FROM Proveedores")
            DataGridViewProveedores.DataSource = DS.Tables(0)

        End If

        'Establece las acciones a realizar cuando se presione la tecla ENTER.
        If e.KeyChar = ChrW(Keys.Enter) Then

            If txtBoxBusquedaNombre.Text = "" Then

                MsgBox("Ingrese el nombre del proveedor a buscar.")

            Else

                DS = consultar("SELECT * FROM Proveedores WHERE Nombre = '" + txtBoxBusquedaNombre.Text + "'")

                If DS.Tables(0).Rows.Count = 0 Then

                    MsgBox("No existe el proveedor ingresado.")

                Else

                    DataGridViewProveedores.DataSource = Nothing
                    DataGridViewProveedores.CurrentCell = Nothing

                    DataGridViewProveedores.Rows.Clear()
                    DataGridViewProveedores.Columns.Clear()

                    DataGridViewProveedores.DataSource = DS.Tables(0)

                End If

            End If

        End If

    End Sub

    Private Sub DataGridViewProveedores_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewProveedores.CellContentClick

        Try

            'Almacena en la variable codigoElegido el codigo del proveedor seleccionado en el DataGridView
            codigoElegido = DataGridViewProveedores.Item(0, e.RowIndex).FormattedValue

            txtBoxRUT.Text = codigoElegido
            txtBoxNombre.Text = DataGridViewProveedores.Item(1, e.RowIndex).FormattedValue
            txtBoxDireccion.Text = DataGridViewProveedores.Item(2, e.RowIndex).FormattedValue
            txtBoxTelefono.Text = DataGridViewProveedores.Item(3, e.RowIndex).FormattedValue


        Catch ex As Exception

            MsgBox(ex.Message.ToString)

        End Try
    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtBoxRUT.Text = "" Or txtBoxNombre.Text = "" Or txtBoxDireccion.Text = "" Or txtBoxTelefono.Text = "" Then

            MsgBox("Faltan completar datos.")

        Else

            DS = consultar("SELECT * FROM Proveedores WHERE RUT = '" + txtBoxRUT.Text + "'")

            If DS.Tables(0).Rows.Count = 0 Then

                ingresarComando("INSERT INTO proveedores (RUT, Nombre, Direccion, Telefono, Categoria) VALUES ('" + txtBoxRUT.Text.ToString + "', '" + txtBoxNombre.Text + "', '" + txtBoxDireccion.Text + "', '" + txtBoxTelefono.Text.ToString + "', '" + comboBoxCategoria.Text + "')")

                DS = consultar("SELECT * FROM Proveedores")
                DataGridViewProveedores.DataSource = DS.Tables(0)

                txtBoxRUT.Text = ""
                txtBoxNombre.Text = ""
                txtBoxDireccion.Text = ""
                txtBoxTelefono.Text = ""

            Else

                MsgBox("Ya existe un proveedor con este número de RUT.")

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        ingresarComando("UPDATE Proveedores SET Nombre= '" + txtBoxNombre.Text + "', Direccion= '" + txtBoxDireccion.Text + "' WHERE RUT = '" + txtBoxRUT.Text + "'")

        DS = consultar("SELECT * FROM Proveedores")
        DataGridViewProveedores.DataSource = DS.Tables(0)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If codigoElegido = 0 Then

            MsgBox("No ha seleccionado ningun proveeedor.")

        Else

            ingresarComando("DELETE FROM Proveedores WHERE RUT = '" + codigoElegido + "'")

            DS = consultar("SELECT * FROM Proveedores")
            DataGridViewProveedores.DataSource = DS.Tables(0)

            codigoElegido = 0

        End If

    End Sub

#End Region
    
End Class