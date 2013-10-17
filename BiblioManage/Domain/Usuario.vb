Public Class Usuario
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _Cpf As String
    Public Property CPF() As String
        Get
            Return _Cpf
        End Get
        Set(ByVal value As String)
            _Cpf = value
        End Set
    End Property
    Private _rg As String
    Public Property RG() As String
        Get
            Return _rg
        End Get
        Set(ByVal value As String)
            _rg = value
        End Set
    End Property
    Private _nome As String
    Public Property NOME() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
    Private _endereco As String
    Public Property ENDEREÇO() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property
    Private _bairro As String
    Public Property BAIRRO() As String
        Get
            Return _bairro
        End Get
        Set(ByVal value As String)
            _bairro = value
        End Set
    End Property
    Private _cidade As String
    Public Property CIDADE() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property
    Private _uf As String
    Public Property UF() As String
        Get
            Return _uf
        End Get
        Set(ByVal value As String)
            _uf = value
        End Set
    End Property
    Private _cep As String
    Public Property CEP() As String
        Get
            Return _cep
        End Get
        Set(ByVal value As String)
            _cep = value
        End Set
    End Property
    Private _telefone As String
    Public Property TELEFONE() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property
    Private _celular As String
    Public Property CELULAR() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property
    Private _email As String
    Public Property EMAIL() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Private _ativo As String
    Public Property Ativo() As String
        Get
            Return _ativo
        End Get
        Set(ByVal value As String)
            _ativo = value
        End Set
    End Property
    Private _desabilitado As String
    Public Property Desabilitado() As String
        Get
            Return _desabilitado
        End Get
        Set(ByVal value As String)
            _desabilitado = value
        End Set
    End Property

End Class
