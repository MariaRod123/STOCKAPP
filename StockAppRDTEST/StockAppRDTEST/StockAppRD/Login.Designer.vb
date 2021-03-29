<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxUsuario = New System.Windows.Forms.TextBox()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'txtBoxUsuario
        '
        Me.txtBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUsuario.ForeColor = System.Drawing.Color.White
        Me.txtBoxUsuario.Location = New System.Drawing.Point(156, 137)
        Me.txtBoxUsuario.MaxLength = 25
        Me.txtBoxUsuario.Name = "txtBoxUsuario"
        Me.txtBoxUsuario.Size = New System.Drawing.Size(180, 13)
        Me.txtBoxUsuario.TabIndex = 3
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPass.ForeColor = System.Drawing.Color.White
        Me.txtBoxPass.Location = New System.Drawing.Point(156, 183)
        Me.txtBoxPass.MaxLength = 25
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.Size = New System.Drawing.Size(180, 13)
        Me.txtBoxPass.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(370, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 29)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(249, 230)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(87, 34)
        Me.btnIngresar.TabIndex = 27
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(156, 230)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(87, 34)
        Me.btnRegistrar.TabIndex = 28
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 400)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 156
        Me.LineShape2.X2 = 335
        Me.LineShape2.Y1 = 202
        Me.LineShape2.Y2 = 202
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 157
        Me.LineShape1.X2 = 336
        Me.LineShape1.Y1 = 154
        Me.LineShape1.Y2 = 154
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.Location = New System.Drawing.Point(342, 167)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(50, 23)
        Me.btnMostrar.TabIndex = 33
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.White
        Me.LabelUsuarios.Location = New System.Drawing.Point(3, 378)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(165, 13)
        Me.LabelUsuarios.TabIndex = 34
        Me.LabelUsuarios.Text = "No hay ningún usuario registrado."
        Me.LabelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtBoxPass)
        Me.Controls.Add(Me.txtBoxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents LabelUsuarios As System.Windows.Forms.Label
End Class
