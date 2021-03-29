Public Class PantallaInicialCarga

    Private Sub PantallaInicialCarga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TimerPantallaInicio.Start()

    End Sub

    Private Sub TimerPantallaInicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPantallaInicio.Tick

        panelCargaCompleta.Width += 8

        If panelCargaCompleta.Width >= 358 Then

            TimerPantallaInicio.Stop()

            Me.Hide()

            Login.Show()

        End If

    End Sub


End Class