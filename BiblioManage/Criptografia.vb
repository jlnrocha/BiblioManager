Imports System.Security.Cryptography
Imports System.Text

Public Class Criptografia

    Public Shared Function CriarHash(ByVal valor As String) As String

        Using md5Hash As MD5 = MD5.Create()

            Dim bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(valor))

            Return Convert.ToBase64String(bytes)

        End Using

    End Function

    Public Shared Function VerificaHash(ByVal hash As String, ByVal valor As String) As Boolean

        Dim novoHash = CriarHash(valor)

        Return String.Equals(hash, novoHash, StringComparison.InvariantCulture)

    End Function

End Class
