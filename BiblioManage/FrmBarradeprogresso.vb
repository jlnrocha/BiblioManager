Public Class FrmBarraDeProgresso
    Private Sub FrmBarraDeProgresso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        BarraDeProgresso.Value = BarraDeProgresso.Value + 1000
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BarraDeProgresso.Increment(1)
        If BarraDeProgresso.Value = BarraDeProgresso.Maximum Then
            Me.Hide()
            Inicial.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub BarraDeProgresso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeProgresso.Click

    End Sub
End Class
