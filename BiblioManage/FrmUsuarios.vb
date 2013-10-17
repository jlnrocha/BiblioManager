Public Class FrmUsuarios

    Dim usuarioId As Integer


    Private Sub SALVARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALVARToolStripMenuItem.Click

        Dim db As New BiblioDbContext

        If (usuarioId = 0) Then

            Dim usuario As New Funcionario
            usuario.Id = DateTime.Now.Ticks
            usuario.NomeCompleto = TextBox2.Text
            usuario.NomeUsuario = ""
            usuario.Senha = ""

            db.Funcionarios.Add(usuario)
            db.SaveChanges()

        Else

            Dim usuario As Funcionario

            ' consulta o usuario pelo id
            Dim resultados = From t In db.Funcionarios
                         Where t.Id = usuarioId
                         Select t
            usuario = resultados.FirstOrDefault()

            usuario.NomeCompleto = TextBox2.Text
            usuario.NomeUsuario = ""
            usuario.Senha = ""

            '' grava no banco
            db.SaveChanges()

        End If

        db.Dispose()

    End Sub

    Private Sub NOVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOVOToolStripMenuItem.Click

        usuarioId = 0

    End Sub

End Class
