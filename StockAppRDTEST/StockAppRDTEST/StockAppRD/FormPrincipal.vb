Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

#Region "Controles de ventana principal."

    Dim locationX, locationY As Integer
    Dim sizeWidth, sizeHeight As Integer

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Dim respuesta = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir")

        If respuesta = MsgBoxResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click

        locationX = Me.Location.X
        locationY = Me.Location.Y
        sizeWidth = Me.Size.Width
        sizeHeight = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        maximizada = True

    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click

        Me.Size = New Size(sizeWidth, sizeHeight)
        Me.Location = New Point(locationX, locationY)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False

        maximizada = False

    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

#End Region

#Region "Acciones del panel de título."

    Dim drag As Boolean
    Dim maximizada As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PanelTitulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelTitulo.DoubleClick
        'Si la ventana no está maximizada, la maximiza y, si lo está, vuelve a su estado normal.

        If maximizada = False Then

            locationX = Me.Location.X
            locationY = Me.Location.Y
            sizeWidth = Me.Size.Width
            sizeHeight = Me.Size.Height

            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location

            btnMaximizar.Visible = False
            btnRestaurar.Visible = True

            maximizada = True

        Else

            Me.Size = New Size(sizeWidth, sizeHeight)
            Me.Location = New Point(locationX, locationY)

            btnMaximizar.Visible = True
            btnRestaurar.Visible = False

            maximizada = False

        End If

    End Sub

    Private Sub PanelTitulo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTitulo.MouseDown

        drag = True

        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub PanelTitulo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTitulo.MouseMove

        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If

    End Sub

    Private Sub PanelTitulo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTitulo.MouseUp

        drag = False

    End Sub

#End Region

#Region "Acciones de botones del panel lateral."

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click

        AbrirFormEnPanel(Of Productos)()

        btnProductos.BackColor = Color.FromArgb(3, 155, 229)

        panelMarcador.Visible = True
        panelMarcador.Height = btnProductos.Height
        panelMarcador.Top = btnProductos.Top

    End Sub

    Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedores.Click

        AbrirFormEnPanel(Of Proveedores)()

        btnProveedores.BackColor = Color.FromArgb(3, 155, 229)

        panelMarcador.Visible = True
        panelMarcador.Height = btnProveedores.Height
        panelMarcador.Top = btnProveedores.Top

    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click

        AbrirFormEnPanel(Of Compras)()

        btnCompras.BackColor = Color.FromArgb(3, 155, 229)

        panelMarcador.Visible = True
        panelMarcador.Height = btnCompras.Height
        panelMarcador.Top = btnCompras.Top

    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click

        AbrirFormEnPanel(Of Ventas)()

        btnVentas.BackColor = Color.FromArgb(3, 155, 229)

        panelMarcador.Visible = True
        panelMarcador.Height = btnVentas.Height
        panelMarcador.Top = btnVentas.Top

    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click

        AbrirFormEnPanel(Of Usuarios)()

        btnUsuarios.BackColor = Color.FromArgb(3, 155, 229)

        panelMarcador.Visible = True
        panelMarcador.Height = btnUsuarios.Height
        panelMarcador.Top = btnUsuarios.Top

    End Sub

#End Region

#Region "Métodos y funciones."

    'Método para abrir un formulario dentro de un panel.
    Public Sub AbrirFormEnPanel(Of Forms As {Form, New})()

        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Forms)().FirstOrDefault() 'Busca el formulario en la colección.

        'Si el formulario no fue encontrado, no existe.
        If formulario Is Nothing Then

            formulario = New Forms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario

            AddHandler formulario.FormClosed, AddressOf Me.CerrarFormulario

            formulario.Show()
            formulario.BringToFront()

        Else

            If formulario.WindowState = FormWindowState.Minimized Then

                formulario.WindowState = FormWindowState.Normal

            End If

            formulario.BringToFront()

        End If
    End Sub

    'Método ejecutado al cerrar un formulario.
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Colorea el boton correspondiente en la barra de menu si el form esta abierto.

        If Application.OpenForms("Productos") Is Nothing Then 'Si el form esta cerrado, cambia el color al boton.

            btnProductos.BackColor = Color.FromArgb(2, 119, 189)

        End If
        If Application.OpenForms("Proveedores") Is Nothing Then

            btnProveedores.BackColor = Color.FromArgb(2, 119, 189)

        End If
        If Application.OpenForms("Compras") Is Nothing Then

            btnCompras.BackColor = Color.FromArgb(2, 119, 189)

        End If
        If Application.OpenForms("Ventas") Is Nothing Then

            btnVentas.BackColor = Color.FromArgb(2, 119, 189)

        End If
        If Application.OpenForms("Usuarios") Is Nothing Then

            btnUsuarios.BackColor = Color.FromArgb(2, 119, 189)

        End If

    End Sub

#End Region

    Private Sub LinkLabelCerrarSesion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelCerrarSesion.LinkClicked

        Dim respuesta = MsgBox("¿Está seguro que desea cerrar sesión?", MsgBoxStyle.YesNo, "Cerrar sesión")

        If respuesta = MsgBoxResult.Yes Then

            Login.Show()

            Me.Close()

        End If

    End Sub
End Class
