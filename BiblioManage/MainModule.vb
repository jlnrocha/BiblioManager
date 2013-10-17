Imports System.IO

Public Module MainModule

    Public Sub Main()

        ' usado para substituir |DataDirectory| na connection string com o banco de dados.
        AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath + "\DataBase")

        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

        Dim loginForm As New FrmLogin
        System.Windows.Forms.Application.Run(loginForm)

        If loginForm.Autenticado Then

            System.Windows.Forms.Application.Run(New FrmBarraDeProgresso())
            System.Windows.Forms.Application.Run(New FrmPrincipal())

        End If

    End Sub

End Module
