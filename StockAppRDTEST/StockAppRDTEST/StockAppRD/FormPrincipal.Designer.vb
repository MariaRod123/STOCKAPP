<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LinkLabelCerrarSesion = New System.Windows.Forms.LinkLabel()
        Me.panelMarcador = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.pictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1000, 600)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.LinkLabelCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.panelMarcador)
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnProveedores)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(180, 560)
        Me.PanelMenu.TabIndex = 1
        '
        'LinkLabelCerrarSesion
        '
        Me.LinkLabelCerrarSesion.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.LinkLabelCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabelCerrarSesion.AutoSize = True
        Me.LinkLabelCerrarSesion.LinkColor = System.Drawing.Color.White
        Me.LinkLabelCerrarSesion.Location = New System.Drawing.Point(56, 538)
        Me.LinkLabelCerrarSesion.Name = "LinkLabelCerrarSesion"
        Me.LinkLabelCerrarSesion.Size = New System.Drawing.Size(68, 13)
        Me.LinkLabelCerrarSesion.TabIndex = 9
        Me.LinkLabelCerrarSesion.TabStop = True
        Me.LinkLabelCerrarSesion.Text = "Cerrar sesión"
        '
        'panelMarcador
        '
        Me.panelMarcador.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelMarcador.Location = New System.Drawing.Point(0, 67)
        Me.panelMarcador.Name = "panelMarcador"
        Me.panelMarcador.Size = New System.Drawing.Size(12, 40)
        Me.panelMarcador.TabIndex = 7
        Me.panelMarcador.Visible = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.Image = Global.StockAppRD.My.Resources.Resources.IconUsuarios
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 379)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(168, 40)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "     Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVentas.Image = Global.StockAppRD.My.Resources.Resources.IconVentas
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(12, 301)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(168, 40)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = "  Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCompras.Image = Global.StockAppRD.My.Resources.Resources.IconCompras
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(12, 223)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(168, 40)
        Me.btnCompras.TabIndex = 3
        Me.btnCompras.Text = "     Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProveedores.Image = Global.StockAppRD.My.Resources.Resources.IconProveedores
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(12, 145)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(168, 40)
        Me.btnProveedores.TabIndex = 1
        Me.btnProveedores.Text = "           Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProductos.Image = Global.StockAppRD.My.Resources.Resources.IconIngreso
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(12, 67)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(168, 40)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "     Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFormularios.BackColor = System.Drawing.Color.LightBlue
        Me.PanelFormularios.Controls.Add(Me.pictureBoxLogo)
        Me.PanelFormularios.Location = New System.Drawing.Point(180, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(820, 560)
        Me.PanelFormularios.TabIndex = 2
        '
        'pictureBoxLogo
        '
        Me.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBoxLogo.Image = Global.StockAppRD.My.Resources.Resources.LogoStockApp
        Me.pictureBoxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pictureBoxLogo.Name = "pictureBoxLogo"
        Me.pictureBoxLogo.Size = New System.Drawing.Size(820, 560)
        Me.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxLogo.TabIndex = 0
        Me.pictureBoxLogo.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.labelTitulo)
        Me.PanelTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1000, 40)
        Me.PanelTitulo.TabIndex = 0
        '
        'labelTitulo
        '
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.ForeColor = System.Drawing.Color.White
        Me.labelTitulo.Location = New System.Drawing.Point(12, 12)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(115, 17)
        Me.labelTitulo.TabIndex = 4
        Me.labelTitulo.Text = "UruByte Software"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = Global.StockAppRD.My.Resources.Resources.restore
        Me.btnRestaurar.Location = New System.Drawing.Point(934, 8)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(24, 24)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.StockAppRD.My.Resources.Resources.minimize
        Me.btnMinimizar.Location = New System.Drawing.Point(904, 8)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.StockAppRD.My.Resources.Resources.maximize
        Me.btnMaximizar.Location = New System.Drawing.Point(934, 8)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(24, 24)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.StockAppRD.My.Resources.Resources.close1
        Me.btnCerrar.Location = New System.Drawing.Point(964, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents PanelFormularios As System.Windows.Forms.Panel
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents pictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents panelMarcador As System.Windows.Forms.Panel
    Friend WithEvents labelTitulo As System.Windows.Forms.Label
    Friend WithEvents LinkLabelCerrarSesion As System.Windows.Forms.LinkLabel

End Class
