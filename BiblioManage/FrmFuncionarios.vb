Public Class FrmFuncionarios
    Dim db As New BiblioDbContext

    Private Sub FrmCriarFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.Funcionarios.Load()
        Me.BindingSource1.DataSource = db.Funcionarios.Local.ToBindingList()

        Me.BindingNavigatorSaveItem.Enabled = False
    End Sub
    Private Sub BindingSource1_AddingNew(sender As Object, e As EventArgs) Handles BindingSource1.AddingNew

        Me.BindingNavigatorDeleteItem.Enabled = False

    End Sub

    Private Sub BindingSource1_CurrentItemChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentItemChanged

        Me.BindingNavigatorSaveItem.Enabled = True

    End Sub

    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click

        ' update do hash da senha, separado do binding
        If String.IsNullOrWhiteSpace(Me.SenhaTextBox.Text) = False Then
            Dim usuario As Funcionario = DirectCast(Me.BindingSource1.Current, Funcionario)
            usuario.Senha = Criptografia.CriarHash(Me.SenhaTextBox.Text)
        End If

        Me.BindingSource1.EndEdit()
        db.SaveChanges()

        Me.BindingNavigatorDeleteItem.Enabled = True
        Me.BindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingSource1_AddingNew(sender As Object, e As AddingNewEventArgs) Handles BindingSource1.AddingNew

    End Sub

    Private Sub SenhaTextBox_TextChanged(sender As Object, e As EventArgs) Handles SenhaTextBox.TextChanged

        Me.BindingNavigatorSaveItem.Enabled = True

    End Sub

End Class
