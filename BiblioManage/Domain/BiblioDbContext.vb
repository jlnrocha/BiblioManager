Imports System.Data.Entity

Public Class BiblioDbContext
    Inherits DbContext

    Private _funcionarios As DbSet(Of Funcionario)
    Public Property Funcionarios() As DbSet(Of Funcionario)
        Get
            Return _funcionarios
        End Get
        Set(ByVal value As DbSet(Of Funcionario))
            _funcionarios = value
        End Set
    End Property

End Class


Public Class BiblioContextInitializer
    Inherits DropCreateDatabaseIfModelChanges(Of BiblioDbContext)

    Protected Overrides Sub Seed(context As BiblioDbContext)

        Dim usuario As New Funcionario
        usuario.Id = 1
        usuario.NomeCompleto = "Administrador"
        usuario.NomeUsuario = "admin"
        usuario.Senha = "123"

        context.Funcionarios.Add(usuario)
        context.SaveChanges()

    End Sub

End Class
