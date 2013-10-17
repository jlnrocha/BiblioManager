Public Class FrmPrincipal

    Private Sub CadastroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem1.Click

    End Sub

    Private Sub CONSULTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTAToolStripMenuItem.Click

    End Sub

    Private Sub SERVIÇOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERVIÇOSToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem.Click
        Dim frm As New FrmLivros

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        Dim frm As New FrmUsuarios
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub

    Private Sub RetiradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiradaToolStripMenuItem.Click
        Dim frm As New FrmEmprestimo

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub

    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New FrmCriarUsuario

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Dim frm As New FrmCriarLogin

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub

    Private Sub ALTERARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTERARToolStripMenuItem.Click

    End Sub

    Private Sub SenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhaToolStripMenuItem.Click
        Dim frm As New FrmAlterarSenha

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill
    End Sub

    Private Sub CadastroToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem2.Click
        Dim frm As New FrmCriarUsuario

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill
    End Sub

    Private Sub LivrosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem1.Click
        Dim frm As New FrmLivros

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem.Click
        Dim frm As New FrmFuncionarios
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

        Me.ActiveMdiChild.Dock = DockStyle.Fill

    End Sub
End Class