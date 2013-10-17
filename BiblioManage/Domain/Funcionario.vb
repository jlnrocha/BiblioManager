Public Class Funcionario

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nomeCompleto As String
    Public Property NomeCompleto() As String
        Get
            Return _nomeCompleto
        End Get
        Set(ByVal value As String)
            _nomeCompleto = value
        End Set
    End Property

    Private _usuario As String
    Public Property NomeUsuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _senha As String
    Public Property Senha() As String
        Get
            Return _senha
        End Get
        Set(ByVal value As String)
            _senha = value
        End Set
    End Property

End Class
