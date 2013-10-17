Public Class Inicial

    Private Sub CadastroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem1.Click

    End Sub

    Private Sub CONSULTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTAToolStripMenuItem.Click

    End Sub

    Private Sub SERVIÇOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERVIÇOSToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem.Click
        FrmLivros.Show()

    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        FrmUsuarios.Show()
    End Sub

    Private Sub RetiradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiradaToolStripMenuItem.Click
        FrmEmprestimo.Show()

    End Sub

    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCriarUsuario.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FrmCriarLogin.Show()
    End Sub

    Private Sub ALTERARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTERARToolStripMenuItem.Click

    End Sub

    Private Sub SenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhaToolStripMenuItem.Click
        FrmAlterarSenha.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem2.Click
        FrmCriarUsuario.Show()
    End Sub

    Private Sub LivrosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem1.Click
        FrmConsultaLivros.Show()
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem.Click
        FrmCriarFuncionario.Show()
    End Sub
End Class