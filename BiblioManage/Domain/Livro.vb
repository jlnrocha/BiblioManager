Public Class Livro
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _numero As String
    Public Property NumeroTombo() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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
    Private _autor As String
    Public Property AUTO() As String
        Get
            Return _autor
        End Get
        Set(ByVal value As String)
            _autor = value
        End Set
    End Property
    Private _editora As String
    Public Property EDITORA() As String
        Get
            Return _editora
        End Get
        Set(ByVal value As String)
            _editora = value
        End Set
    End Property
    Private _idioma As String
    Public Property IDIOMA() As String
        Get
            Return _idioma
        End Get
        Set(ByVal value As String)
            _idioma = value
        End Set
    End Property
    Private _volume As String
    Public Property VOLUME() As String
        Get
            Return _volume
        End Get
        Set(ByVal value As String)
            _volume = value
        End Set
    End Property
    Private _ano As String
    Public Property ANO() As String
        Get
            Return _ano
        End Get
        Set(ByVal value As String)
            _ano = value
        End Set
    End Property
    Private _qtd As String
    Public Property QTDEXEMPLARES() As String
        Get
            Return _qtd
        End Get
        Set(ByVal value As String)
            _qtd = value
        End Set
    End Property
    Private _qtdPaginas As String
    Public Property QTDPAGINAS() As String
        Get
            Return _qtdPaginas
        End Get
        Set(ByVal value As String)
            _qtdPaginas = value
        End Set
    End Property
    Private _genero As String
    Public Property GENERO() As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            _genero = value
        End Set
    End Property

End Class
