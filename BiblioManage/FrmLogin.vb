Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Me.Hide()

        Inicial.Show()

        Return

        Dim db As New BiblioDbContext

        Dim resultados = From t In db.Funcionarios
                         Where t.NomeUsuario = nometxtbox.Text And t.Senha = Senhatxtbox.Text
                         Select t

        If resultados.Count() = 1 Then
            FrmBarraDeProgresso.Show()
        End If

        db.Dispose()

        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Data.Entity.Database.SetInitializer(New BiblioContextInitializer())




    End Sub

End Class
