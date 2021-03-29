Public Class RegistrarUsuario

#Region "Variables."

    Dim usuario As String = ""
    Dim existe As Boolean = False
    Dim mostrarPass As Boolean = True
    Dim tipoUsuario As String = ""

    Dim existeUsuario As Boolean = False

    Dim DS As New DataSet

#End Region

#Region "Eventos."

    Private Sub RegistrarUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        conexion()

        ComboBoxTipo.SelectedIndex = 1

    End Sub

    'Valida el TextBoxTelefono para que solamente se puedan ingresar números.
    Private Sub txtBoxTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxTelefono.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

        End If

    End Sub

    Private Sub txtBoxPassRep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBoxPassRep.LostFocus

        If txtBoxPass.Text <> txtBoxPassRep.Text Then

            Labelpasswords.Text = "Las contraseñas no coinciden."

        Else

            Labelpasswords.Text = ""

        End If

    End Sub

    Private Sub ComboBoxTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipo.SelectedIndexChanged

        If ComboBoxTipo.SelectedIndex = 0 Then

            LabelCM.Enabled = True
            LineShapeCM.Enabled = True
            txtBoxClaveMaestra.Enabled = True

        Else

            txtBoxClaveMaestra.Text = ""

            LabelCM.Enabled = False
            LineShapeCM.Enabled = False
            txtBoxClaveMaestra.Enabled = False

        End If

    End Sub

#End Region

#Region "Métodos y funciones."

    'Verifica si el nombre de usuario ya existe en la tabla Usuarios
    Private Function verificarIDUser()

        DS = consultar("SELECT ID_Usuario FROM usuarios")

        For i = 0 To DS.Tables(0).Rows.Count - 1

            usuario = DS.Tables(0).Rows(i)(0)

            If txtBoxUsuario.Text = usuario Then

                existeUsuario = True

                Exit For

            Else

                existeUsuario = False

            End If

        Next

        Return existeUsuario

    End Function

    Public Sub borrarTodo()

        txtBoxUsuario.Text = ""
        txtBoxNombre.Text = ""
        txtBoxPass.Text = ""
        txtBoxPassRep.Text = ""
        txtBoxTelefono.Text = ""
        txtBoxClaveMaestra.Text = ""
        ComboBoxTipo.SelectedIndex = 1

    End Sub

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Login.Show()

        Me.Close()

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        verificarIDUser()

        If txtBoxUsuario.Text = "" Or txtBoxNombre.Text = "" Or txtBoxPass.Text = "" Or txtBoxPassRep.Text = "" Or txtBoxTelefono.Text = "" Then

            MsgBox("Faltan ingresar datos.")

        Else

            If txtBoxPass.Text <> txtBoxPassRep.Text Then

                MsgBox("Las contraseñas no coinciden.")

            Else

                If existe Then

                    MsgBox("El usuario ingresado ya existe.")

                Else


                    If ComboBoxTipo.SelectedIndex = 0 And txtBoxClaveMaestra.Text <> "1234" Then 'Si está elegido el tipo Admin y la clave maestra no es 1234

                        MsgBox("La clave maestra ingresada es incorrecta.")

                    Else

                        If ComboBoxTipo.SelectedIndex = 0 And txtBoxClaveMaestra.Text = "1234" Then

                            tipoUsuario = "Admin"

                        Else

                            tipoUsuario = "Usuario"

                        End If

                        ingresarComando("INSERT INTO Usuarios(ID_Usuario, Nombre, Telefono, Contrasena, Tipo) VALUES ('" + txtBoxUsuario.Text + "', '" + txtBoxNombre.Text + "', '" + txtBoxTelefono.Text + "', sha2('" + txtBoxPass.Text + "', 224), '" + ComboBoxTipo.Text + "')")

                        borrarTodo()

                        MsgBox("Agregado correctamente.")

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

        'Muestra u oculta la contraseña ingresada en los textBox
        If mostrarPass = True Then

            txtBoxPass.PasswordChar = ""
            txtBoxPassRep.PasswordChar = ""
            txtBoxClaveMaestra.PasswordChar = ""

            btnMostrar.Image = My.Resources.IconOjoBlanco

            mostrarPass = False

        Else

            txtBoxPass.PasswordChar = "*"
            txtBoxPassRep.PasswordChar = "*"
            txtBoxClaveMaestra.PasswordChar = "*"

            btnMostrar.Image = My.Resources.IconOjoNegro

            mostrarPass = True

        End If

    End Sub

#End Region

End Class