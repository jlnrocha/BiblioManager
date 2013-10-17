Public Module MainModule

    Public Sub Main()

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
