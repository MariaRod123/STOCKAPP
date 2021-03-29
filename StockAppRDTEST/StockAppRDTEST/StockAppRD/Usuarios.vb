Public Class Usuarios

#Region "Variables."

    Dim idUsuario As String = ""
    Dim nombreUsuario As String = ""

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Carga todos los datos de la tabla Usuarios en el datagridview
        DS = consultar(" SELECT * From Usuarios")
        DataGridViewUsuarios.DataSource = DS.Tables(0)

    End Sub

    Private Sub DataGridViewUsuarios_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUsuarios.CellContentClick

        Try

            idUsuario = DataGridViewUsuarios.Item(0, e.RowIndex).FormattedValue
            nombreUsuario = DataGridViewUsuarios.Item(1, e.RowIndex).FormattedValue

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBoxNombreBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxNombreBusq.KeyPress

        'Muestra todas las celdas del DataGridView cuando el txtBoxNombreBusq está vacío
        If txtBoxNombreBusq.Text = "" Then

            'Carga todos los datos de la tabla Usuarios en el datagridview
            DS = consultar("SELECT * FROM Usuarios")
            DataGridViewUsuarios.DataSource = DS.Tables(0)

        End If

        'Si la tecla presionada es ENTER.
        If e.KeyChar = ChrW(Keys.Enter) Then

            'Busca el usuario por nombre y lo muestra en el datagridview
            If txtBoxNombreBusq.Text = "" Then

                MsgBox("Ingrese el nombre del usuario.")

            Else

                DS = consultar("SELECT * FROM Usuarios WHERE Nombre = '" + txtBoxNombreBusq.Text + "'")

                If DS.Tables(0).Rows.Count = 0 Then

                    MsgBox("No existe el usuario ingresado.")

                Else

                    DataGridViewUsuarios.DataSource = Nothing
                    DataGridViewUsuarios.CurrentCell = Nothing

                    DataGridViewUsuarios.Rows.Clear()
                    DataGridViewUsuarios.Columns.Clear()

                    DataGridViewUsuarios.DataSource = DS.Tables(0)

                End If

            End If

        End If
    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If idUsuario = "" Then

            MsgBox("No ha seleccionado ningún usuario.")

        Else

            Dim respuesta = MsgBox("¿Está seguro que desea eliminar el usuario " + nombreUsuario, MsgBoxStyle.YesNo, "Eliminar")

            If respuesta = MsgBoxResult.Yes Then

                ingresarComando("DELETE FROM Usuarios WHERE ID_Usuario = '" + idUsuario + "'")

                'Carga todos los datos de la tabla Usuarios en el datagridview
                DS = consultar("SELECT * FROM Usuarios")
                DataGridViewUsuarios.DataSource = DS.Tables(0)

                'If idUsuario = Login.usuarioActual Then

                '    MsgBox("El usuario eliminado está actualmente en uso. Se cerrará la sesión.")

                '    Login.Show()

                '    Me.Close()

                'End If

            End If

            idUsuario = ""

        End If
    End Sub

#End Region

End Class