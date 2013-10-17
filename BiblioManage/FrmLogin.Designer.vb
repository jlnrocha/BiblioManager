<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents nometxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Senhatxtbox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.nometxtbox = New System.Windows.Forms.TextBox()
        Me.Senhatxtbox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(96, 43)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(51, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Login"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(96, 69)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(62, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nometxtbox
        '
        Me.nometxtbox.Location = New System.Drawing.Point(153, 45)
        Me.nometxtbox.Name = "nometxtbox"
        Me.nometxtbox.Size = New System.Drawing.Size(116, 20)
        Me.nometxtbox.TabIndex = 1
        '
        'Senhatxtbox
        '
        Me.Senhatxtbox.Location = New System.Drawing.Point(153, 71)
        Me.Senhatxtbox.Name = "Senhatxtbox"
        Me.Senhatxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Senhatxtbox.Size = New System.Drawing.Size(116, 20)
        Me.Senhatxtbox.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.White
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Image = CType(resources.GetObject("OK.Image"), System.Drawing.Image)
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OK.Location = New System.Drawing.Point(99, 128)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 68)
        Me.OK.TabIndex = 4
        Me.OK.Text = "Entrar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(181, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 89)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Trocar Senha"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.ErrorImage = CType(resources.GetObject("LogoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(1, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(89, 105)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(281, 208)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Senhatxtbox)
        Me.Controls.Add(Me.nometxtbox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

End Class
