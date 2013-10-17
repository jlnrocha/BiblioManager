Public Class FrmBarraDeProgresso

    Private Sub FrmBarraDeProgresso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Owner.Close()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BarraDeProgresso.Increment(50)
        If BarraDeProgresso.Value = BarraDeProgresso.Maximum Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub BarraDeProgresso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeProgresso.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
