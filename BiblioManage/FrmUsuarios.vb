Public Class FrmUsuarios
    Dim db As New BiblioDbContext

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.Usuarios.Load()
        Me.BindingSource1.DataSource = db.Usuarios.Local.ToBindingList()

        Me.BindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click

        Me.BindingSource1.EndEdit()
        db.SaveChanges()

        Me.BindingNavigatorDeleteItem.Enabled = True
        Me.BindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub BindingSource1_AddingNew(sender As Object, e As EventArgs) Handles BindingSource1.AddingNew

        Me.BindingNavigatorDeleteItem.Enabled = False

    End Sub
    Private Sub BindingSource1_CurrentItemChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentItemChanged

        Me.BindingNavigatorSaveItem.Enabled = True

    End Sub


End Class