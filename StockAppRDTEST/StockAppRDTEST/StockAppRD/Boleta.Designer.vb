<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boleta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boleta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBoxFechaBoleta = New System.Windows.Forms.TextBox()
        Me.txtBoxSerie = New System.Windows.Forms.TextBox()
        Me.txtBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtBoxDireccionCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridViewBoleta = New System.Windows.Forms.DataGridView()
        Me.txtBoxTotalBoleta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ELIDA SILVEIRA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GUARANI 1467"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "47330405"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MONOTRIBUTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(616, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RUT 162365890011"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(646, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "BOLETA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(630, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CONTADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(79, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "NOMBRE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DIRECCIÓN:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(532, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Serie A N°"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(554, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Fecha:"
        '
        'txtBoxFechaBoleta
        '
        Me.txtBoxFechaBoleta.Location = New System.Drawing.Point(608, 152)
        Me.txtBoxFechaBoleta.Name = "txtBoxFechaBoleta"
        Me.txtBoxFechaBoleta.ReadOnly = True
        Me.txtBoxFechaBoleta.Size = New System.Drawing.Size(128, 20)
        Me.txtBoxFechaBoleta.TabIndex = 14
        '
        'txtBoxSerie
        '
        Me.txtBoxSerie.Location = New System.Drawing.Point(608, 119)
        Me.txtBoxSerie.Name = "txtBoxSerie"
        Me.txtBoxSerie.ReadOnly = True
        Me.txtBoxSerie.Size = New System.Drawing.Size(128, 20)
        Me.txtBoxSerie.TabIndex = 15
        '
        'txtBoxNombreCliente
        '
        Me.txtBoxNombreCliente.Location = New System.Drawing.Point(154, 196)
        Me.txtBoxNombreCliente.Name = "txtBoxNombreCliente"
        Me.txtBoxNombreCliente.Size = New System.Drawing.Size(380, 20)
        Me.txtBoxNombreCliente.TabIndex = 16
        '
        'txtBoxDireccionCliente
        '
        Me.txtBoxDireccionCliente.Location = New System.Drawing.Point(154, 231)
        Me.txtBoxDireccionCliente.Name = "txtBoxDireccionCliente"
        Me.txtBoxDireccionCliente.Size = New System.Drawing.Size(380, 20)
        Me.txtBoxDireccionCliente.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(66, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "SALTO - URUGUAY"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(591, 510)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Total:"
        '
        'DataGridViewBoleta
        '
        Me.DataGridViewBoleta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewBoleta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBoleta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.PrecioUnitario, Me.Column5, Me.Column4})
        Me.DataGridViewBoleta.Location = New System.Drawing.Point(69, 275)
        Me.DataGridViewBoleta.Name = "DataGridViewBoleta"
        Me.DataGridViewBoleta.Size = New System.Drawing.Size(666, 219)
        Me.DataGridViewBoleta.TabIndex = 21
        '
        'txtBoxTotalBoleta
        '
        Me.txtBoxTotalBoleta.Location = New System.Drawing.Point(636, 509)
        Me.txtBoxTotalBoleta.Name = "txtBoxTotalBoleta"
        Me.txtBoxTotalBoleta.ReadOnly = True
        Me.txtBoxTotalBoleta.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotalBoleta.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 565)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(66, 546)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Contado A 00001 - A 00400  X2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 591)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(360, 546)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 32)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "FECHA VTO." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "18/09/2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(653, 548)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = " Original  Cliente"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(660, 565)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = " Copia Archivo"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(405, 605)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(74, 27)
        Me.btnImprimir.TabIndex = 48
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(325, 605)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 27)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Concepto"
        Me.Column2.Name = "Column2"
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Importe"
        Me.Column4.Name = "Column4"
        '
        'Boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(804, 638)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBoxTotalBoleta)
        Me.Controls.Add(Me.DataGridViewBoleta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBoxDireccionCliente)
        Me.Controls.Add(Me.txtBoxNombreCliente)
        Me.Controls.Add(Me.txtBoxSerie)
        Me.Controls.Add(Me.txtBoxFechaBoleta)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Boleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boleta"
        CType(Me.DataGridViewBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBoxFechaBoleta As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxDireccionCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewBoleta As System.Windows.Forms.DataGridView
    Friend WithEvents txtBoxTotalBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
