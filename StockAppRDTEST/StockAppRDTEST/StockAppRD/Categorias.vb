Public Class Categorias

    Dim DS As New DataSet

    Dim codigo As String = ""
    Dim codigoElegido As Integer = 0

    Private Sub Categorias_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'Carga todos los datos de la tabla Categorias en el datagridview
        DS = consultar("SELECT * FROM Categorias")
        DataGridViewCategorias.DataSource = DS.Tables(0)

    End Sub

    'Valida el ingreso de solamente números en el textBox
    Private Sub txtBoxUtilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxUtilidad.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click

        If txtBoxNombreCat.Text = "" Or txtBoxUtilidad.Text = "" Then

            MsgBox("Faltan completar datos.")

        Else

            Try

                DS = consultar("SELECT max(IdCategoria) from Categorias")
                codigo = DS.Tables(0).Rows(0)(0).ToString

                'Si no existe ningun ID el código vale 1
                If codigo = "NULL" Then

                    codigo = 1

                Else

                    codigo = codigo + 1

                End If

                'Agrega los datos de la categoría en la tabla Categorías.
                ingresarComando("INSERT INTO categorias(IdCategoria, Categoria, Utilidad) VALUES (" + codigo.ToString + " , '" + txtBoxNombreCat.Text + "' , " + txtBoxUtilidad.Text + ")")

                txtBoxNombreCat.Text = ""
                txtBoxUtilidad.Text = ""

                'Carga todos los datos de la tabla Categorias en el datagridview
                DS = consultar("SELECT * FROM Categorias")
                DataGridViewCategorias.DataSource = DS.Tables(0)

            Catch ex As Exception

                MsgBox("Error: " + ex.Message)

            End Try

        End If

    End Sub

    Private Sub DataGridViewCategorias_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCategorias.CellContentClick

        Try

            'Almacena en la variable codigoElegido el codigo de la categoría seleccionada en el DataGridView
            codigoElegido = DataGridViewCategorias.Item(0, e.RowIndex).FormattedValue

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If codigoElegido = 0 Then

            MsgBox("No ha seleccionado ninguna categoría.")

        Else

            ingresarComando("DELETE FROM categorias WHERE IdCategoria = " + codigoElegido.ToString)

            'Carga todos los datos de la tabla Categorias en el datagridview
            DS = consultar("SELECT * FROM Categorias")
            DataGridViewCategorias.DataSource = DS.Tables(0)

            codigoElegido = 0

        End If

    End Sub
End Class