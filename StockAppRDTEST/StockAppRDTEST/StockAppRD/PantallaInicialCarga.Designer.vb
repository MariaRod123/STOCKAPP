<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInicialCarga
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
        Me.TimerPantallaInicio = New System.Windows.Forms.Timer(Me.components)
        Me.panelCargaCompleta = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'TimerPantallaInicio
        '
        Me.TimerPantallaInicio.Interval = 45
        '
        'panelCargaCompleta
        '
        Me.panelCargaCompleta.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panelCargaCompleta.Location = New System.Drawing.Point(124, 327)
        Me.panelCargaCompleta.Name = "panelCargaCompleta"
        Me.panelCargaCompleta.Size = New System.Drawing.Size(10, 36)
        Me.panelCargaCompleta.TabIndex = 0
        '
        'PantallaInicialCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StockAppRD.My.Resources.Resources.LoadingScreen
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.panelCargaCompleta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaInicialCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaInicialCarga"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerPantallaInicio As System.Windows.Forms.Timer
    Friend WithEvents panelCargaCompleta As System.Windows.Forms.Panel
End Class
