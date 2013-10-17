Public Class FrmLogin

    Dim db As New BiblioDbContext

    Property Autenticado As Boolean

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Para ignorar login
        'Me.Hide()
        'Inicial.Show()
        'Return

        Dim resultados As IQueryable(Of Funcionario)

        resultados = From dbFunc In db.Funcionarios
                     Where dbFunc.NomeUsuario = nometxtbox.Text
                     Select dbFunc

        If resultados.Count() = 1 Then

            Dim funcionario = resultados.First()

            If Criptografia.VerificaHash(funcionario.Senha, Senhatxtbox.Text) Then
                Me.Autenticado = True
                Me.Close()
            Else
                MessageBox.Show("Senha incorreta!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Usuario incorreto!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Senhatxtbox.Text = ""
            Me.Senhatxtbox.Focus()
        End If

        resultados = Nothing
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Data.Entity.Database.SetInitializer(New BiblioContextInitializer())

        Me.nometxtbox.Focus()

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub
End Class
