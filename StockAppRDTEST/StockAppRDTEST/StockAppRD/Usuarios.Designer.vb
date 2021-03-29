<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBoxBusqueda = New System.Windows.Forms.GroupBox()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBoxNombreBusq = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBoxBusqueda.SuspendLayout()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(680, 11)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(128, 34)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar pestaña"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBoxBusqueda
        '
        Me.GroupBoxBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxBusqueda.Controls.Add(Me.DataGridViewUsuarios)
        Me.GroupBoxBusqueda.Controls.Add(Me.Label11)
        Me.GroupBoxBusqueda.Controls.Add(Me.txtBoxNombreBusq)
        Me.GroupBoxBusqueda.Controls.Add(Me.ShapeContainer1)
        Me.GroupBoxBusqueda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxBusqueda.Location = New System.Drawing.Point(12, 51)
        Me.GroupBoxBusqueda.Name = "GroupBoxBusqueda"
        Me.GroupBoxBusqueda.Size = New System.Drawing.Size(796, 458)
        Me.GroupBoxBusqueda.TabIndex = 39
        Me.GroupBoxBusqueda.TabStop = False
        Me.GroupBoxBusqueda.Text = "Búsqueda"
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AllowUserToAddRows = False
        Me.DataGridViewUsuarios.AllowUserToDeleteRows = False
        Me.DataGridViewUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(6, 86)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.ReadOnly = True
        Me.DataGridViewUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(784, 366)
        Me.DataGridViewUsuarios.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Nombre:"
        '
        'txtBoxNombreBusq
        '
        Me.txtBoxNombreBusq.BackColor = System.Drawing.Color.LightBlue
        Me.txtBoxNombreBusq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNombreBusq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNombreBusq.Location = New System.Drawing.Point(15, 54)
        Me.txtBoxNombreBusq.Name = "txtBoxNombreBusq"
        Me.txtBoxNombreBusq.Size = New System.Drawing.Size(219, 16)
        Me.txtBoxNombreBusq.TabIndex = 31
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(790, 436)
        Me.ShapeContainer1.TabIndex = 37
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 14
        Me.LineShape5.X2 = 231
        Me.LineShape5.Y1 = 57
        Me.LineShape5.Y2 = 57
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(346, 515)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 34)
        Me.btnEliminar.TabIndex = 40
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBoxBusqueda)
        Me.Controls.Add(Me.btnCerrar)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GroupBoxBusqueda.ResumeLayout(False)
        Me.GroupBoxBusqueda.PerformLayout()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBoxNombreBusq As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
