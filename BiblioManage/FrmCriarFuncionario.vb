Imports System.ComponentModel

Public Class FrmCriarFuncionario

    Dim db As New BiblioDbContext
    Dim usuarioId As Integer

    Private Sub NovoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem1.Click
        usuarioId = 0
    End Sub

    Private Sub SALVARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALVARToolStripMenuItem.Click

        'If (usuarioId = 0) Then

        '    Dim usuario As New Funcionario
        '    usuario.Id = DateTime.Now.Ticks
        '    usuario.NomeCompleto = TextBox2.Text
        '    usuario.NomeUsuario = ""
        '    usuario.Senha = ""

        '    db.Funcionarios.Add(usuario)
        '    db.SaveChanges()

        'Else

        '    Dim usuario As Funcionario

        '    ' consulta o usuario pelo id
        '    Dim resultados = From t In db.Funcionarios
        '                 Where t.Id = usuarioId
        '                 Select t
        '    usuario = resultados.FirstOrDefault()

        '    usuario.NomeCompleto = TextBox2.Text
        '    usuario.NomeUsuario = ""
        '    usuario.Senha = ""

        '    '' grava no banco
        '    db.SaveChanges()

        'End If

    End Sub

    Private Sub ALTERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTERARToolStripMenuItem.Click

    End Sub

    Private Sub FrmCriarFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        db.SaveChanges()
    End Sub
End Class
