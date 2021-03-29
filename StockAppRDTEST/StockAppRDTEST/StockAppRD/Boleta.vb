Public Class Boleta

#Region "Botones."

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Dispose()

    End Sub

#End Region

End Class