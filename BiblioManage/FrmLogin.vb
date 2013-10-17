Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If nometxtbox.Text = "diogo" And Senhatxtbox.Text = "1234" Then
            Inicial.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Senhatxtbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Senhatxtbox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub


    Private Sub PasswordLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordLabel.Click

    End Sub
End Class
