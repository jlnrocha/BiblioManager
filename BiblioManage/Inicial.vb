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

    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuárioToolStripMenuItem.Click
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

    Private Sub SAIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAIRToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultasToolStripMenuItem1.Click

    End Sub

    Private Sub DevoluçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        FrmDevolucao.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        FrmReservas.Show()
    End Sub

    Private Sub Inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDevolucao.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmEmprestimo.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConsultaLivros.Show()

    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Frm_Funcionarios.Show()

    End Sub
End Class