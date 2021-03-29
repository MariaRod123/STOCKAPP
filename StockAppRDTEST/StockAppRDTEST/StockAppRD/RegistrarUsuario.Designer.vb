<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.txtBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxPassRep = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Labelpasswords = New System.Windows.Forms.Label()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShapeCM = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtBoxClaveMaestra = New System.Windows.Forms.TextBox()
        Me.LabelCM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(175, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tipo:"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxTipo.ForeColor = System.Drawing.Color.White
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Admin", "Usuario"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(223, 311)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(165, 21)
        Me.ComboBoxTipo.TabIndex = 13
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPass.ForeColor = System.Drawing.Color.White
        Me.txtBoxPass.Location = New System.Drawing.Point(223, 179)
        Me.txtBoxPass.MaxLength = 25
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxPass.TabIndex = 12
        '
        'txtBoxUsuario
        '
        Me.txtBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUsuario.ForeColor = System.Drawing.Color.White
        Me.txtBoxUsuario.Location = New System.Drawing.Point(223, 96)
        Me.txtBoxUsuario.MaxLength = 25
        Me.txtBoxUsuario.Name = "txtBoxUsuario"
        Me.txtBoxUsuario.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxUsuario.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(142, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuario:"
        '
        'txtBoxPassRep
        '
        Me.txtBoxPassRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxPassRep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPassRep.ForeColor = System.Drawing.Color.White
        Me.txtBoxPassRep.Location = New System.Drawing.Point(223, 224)
        Me.txtBoxPassRep.MaxLength = 25
        Me.txtBoxPassRep.Name = "txtBoxPassRep"
        Me.txtBoxPassRep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPassRep.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxPassRep.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(98, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Repita la contraseña:"
        '
        'txtBoxTelefono
        '
        Me.txtBoxTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxTelefono.ForeColor = System.Drawing.Color.White
        Me.txtBoxTelefono.Location = New System.Drawing.Point(223, 268)
        Me.txtBoxTelefono.MaxLength = 25
        Me.txtBoxTelefono.Name = "txtBoxTelefono"
        Me.txtBoxTelefono.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxTelefono.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(154, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Teléfono:"
        '
        'Labelpasswords
        '
        Me.Labelpasswords.AutoSize = True
        Me.Labelpasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpasswords.ForeColor = System.Drawing.Color.White
        Me.Labelpasswords.Location = New System.Drawing.Point(3, 482)
        Me.Labelpasswords.Name = "Labelpasswords"
        Me.Labelpasswords.Size = New System.Drawing.Size(0, 13)
        Me.Labelpasswords.TabIndex = 21
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxNombre.ForeColor = System.Drawing.Color.White
        Me.txtBoxNombre.Location = New System.Drawing.Point(223, 138)
        Me.txtBoxNombre.MaxLength = 25
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxNombre.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(160, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nombre:"
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(470, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 29)
        Me.btnCerrar.TabIndex = 24
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(301, 402)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(87, 34)
        Me.btnRegistrar.TabIndex = 29
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 223
        Me.LineShape2.X2 = 387
        Me.LineShape2.Y1 = 116
        Me.LineShape2.Y2 = 116
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShapeCM, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(500, 500)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'LineShapeCM
        '
        Me.LineShapeCM.BorderColor = System.Drawing.Color.White
        Me.LineShapeCM.Enabled = False
        Me.LineShapeCM.Name = "LineShapeCM"
        Me.LineShapeCM.X1 = 223
        Me.LineShapeCM.X2 = 387
        Me.LineShapeCM.Y1 = 375
        Me.LineShapeCM.Y2 = 375
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 223
        Me.LineShape5.X2 = 387
        Me.LineShape5.Y1 = 289
        Me.LineShape5.Y2 = 289
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 223
        Me.LineShape4.X2 = 387
        Me.LineShape4.Y1 = 245
        Me.LineShape4.Y2 = 245
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 223
        Me.LineShape3.X2 = 387
        Me.LineShape3.Y1 = 199
        Me.LineShape3.Y2 = 199
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 223
        Me.LineShape1.X2 = 387
        Me.LineShape1.Y1 = 159
        Me.LineShape1.Y2 = 159
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Image = Global.StockAppRD.My.Resources.Resources.IconOjoNegro
        Me.btnMostrar.Location = New System.Drawing.Point(419, 189)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(50, 23)
        Me.btnMostrar.TabIndex = 32
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'txtBoxClaveMaestra
        '
        Me.txtBoxClaveMaestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxClaveMaestra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxClaveMaestra.Enabled = False
        Me.txtBoxClaveMaestra.ForeColor = System.Drawing.Color.White
        Me.txtBoxClaveMaestra.Location = New System.Drawing.Point(223, 355)
        Me.txtBoxClaveMaestra.MaxLength = 11
        Me.txtBoxClaveMaestra.Name = "txtBoxClaveMaestra"
        Me.txtBoxClaveMaestra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxClaveMaestra.Size = New System.Drawing.Size(165, 13)
        Me.txtBoxClaveMaestra.TabIndex = 34
        '
        'LabelCM
        '
        Me.LabelCM.AutoSize = True
        Me.LabelCM.Enabled = False
        Me.LabelCM.ForeColor = System.Drawing.Color.White
        Me.LabelCM.Location = New System.Drawing.Point(129, 357)
        Me.LabelCM.Name = "LabelCM"
        Me.LabelCM.Size = New System.Drawing.Size(77, 13)
        Me.LabelCM.TabIndex = 33
        Me.LabelCM.Text = "Clave maestra:"
        '
        'RegistrarUsuario
        '
        Me.AcceptButton = Me.btnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.txtBoxClaveMaestra)
        Me.Controls.Add(Me.LabelCM)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtBoxNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Labelpasswords)
        Me.Controls.Add(Me.txtBoxTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBoxPassRep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.txtBoxPass)
        Me.Controls.Add(Me.txtBoxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoxPassRep As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Labelpasswords As System.Windows.Forms.Label
    Friend WithEvents txtBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents LineShapeCM As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtBoxClaveMaestra As System.Windows.Forms.TextBox
    Friend WithEvents LabelCM As System.Windows.Forms.Label
End Class
