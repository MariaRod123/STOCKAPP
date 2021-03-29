Public Class Login

#Region "Variables."

    Dim usuario As String = ""
    Dim contraseña As String = ""
    Dim existeUsuario As Boolean = False
    Dim numeroCeldaUsuario As Integer = 0
    Dim passCorrecta As Boolean = False
    Dim mostrarPass As Boolean = True

    Dim DS As New DataSet

    'Public usuarioActual As String = ""

#End Region

#Region "Eventos."

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        conexion()

        contarUsuarios()

    End Sub

#End Region

#Region "Métodos y funciones."

    'Cuenta la cantidad de usuarios que existen en la tabla Usuarios
    Public Sub contarUsuarios()

        DS = consultar("SELECT COUNT(*) FROM usuarios")

        If DS.Tables(0).Rows(0)(0).ToString = 0 Then

            LabelUsuarios.Text = "No hay ningún usuario registrado."

        ElseIf DS.Tables(0).Rows(0)(0).ToString = 1 Then

            LabelUsuarios.Text = "Hay 1 usuario registrado."

        Else

            LabelUsuarios.Text = "Hay " + DS.Tables(0).Rows(0)(0).ToString + " usuarios registrados."

        End If

    End Sub

    'Verifica si el nombre de usuario ya existe en la tabla Usuarios
    Private Function verificarIDUser()

        DS = consultar("SELECT ID_Usuario FROM usuarios")

        For i = 0 To DS.Tables(0).Rows.Count - 1

            usuario = DS.Tables(0).Rows(i)(0)

            If txtBoxUsuario.Text = usuario Then

                existeUsuario = True

                numeroCeldaUsuario = i 'Es el número de celda donde esta almacenado el ID de usuario

                Exit For

            Else

                existeUsuario = False

            End If

        Next

        Return existeUsuario

    End Function

    'Verifica si la contraseña ingresada es la correcta para el usuario elegido
    Private Function verificarPassword()

        DS = consultar("SELECT Contrasena FROM usuarios WHERE Contrasena= sha2('" + txtBoxPass.Text + "', 224) AND ID_Usuario= '" + txtBoxUsuario.Text + "'")

        If DS.Tables(0).Rows.Count = 1 Then

            passCorrecta = True

        Else

            passCorrecta = False

        End If

        Return passCorrecta

    End Function

#End Region

#Region "Botones."

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Application.Exit()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        'Verifica si el usuario ingresado existe y si la contraseña es correcta.
        If txtBoxUsuario.Text = "" Or txtBoxPass.Text = "" Then

            MsgBox("Faltan completar datos.")

        Else

            verificarIDUser()

            If existeUsuario = False Then

                MsgBox("El usuario ingresado no existe.")

            Else

                verificarPassword()

                If passCorrecta = False Then

                    MsgBox("Contraseña incorrecta.")

                Else

                    DS = consultar("SELECT Tipo FROM usuarios WHERE ID_Usuario='" + txtBoxUsuario.Text + "'")

                    If DS.Tables(0).Rows(0)(0).ToString = "Admin" Then 'Activa la pestaña Usuarios solo si el usuario seleccionado es Admin

                        FormPrincipal.btnUsuarios.Enabled = True

                    Else

                        FormPrincipal.btnUsuarios.Enabled = False

                    End If

                    'usuarioActual = txtBoxUsuario.Text

                    txtBoxUsuario.Text = ""
                    txtBoxPass.Text = ""

                    FormPrincipal.Show()

                    Me.Close()

                End If

            End If

        End If

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        RegistrarUsuario.Show()

        Me.Close()

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

        'Muestra u oculta la contraseña ingresada en los textBox
        If mostrarPass = True Then

            txtBoxPass.PasswordChar = ""

            btnMostrar.Image = My.Resources.IconOjoBlanco

            mostrarPass = False

        Else

            txtBoxPass.PasswordChar = "*"

            btnMostrar.Image = My.Resources.IconOjoNegro

            mostrarPass = True

        End If

    End Sub

#End Region

End Class