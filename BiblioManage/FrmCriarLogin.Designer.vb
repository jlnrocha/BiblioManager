<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCriarLogin
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCriarLogin))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SALVARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CANCELARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALVARToolStripMenuItem, Me.CANCELARToolStripMenuItem, Me.NovoToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(350, 24)
        Me.MenuStrip2.TabIndex = 39
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SALVARToolStripMenuItem
        '
        Me.SALVARToolStripMenuItem.Image = CType(resources.GetObject("SALVARToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SALVARToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.SALVARToolStripMenuItem.Name = "SALVARToolStripMenuItem"
        Me.SALVARToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SALVARToolStripMenuItem.Text = "Salvar"
        '
        'CANCELARToolStripMenuItem
        '
        Me.CANCELARToolStripMenuItem.Image = CType(resources.GetObject("CANCELARToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CANCELARToolStripMenuItem.Name = "CANCELARToolStripMenuItem"
        Me.CANCELARToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CANCELARToolStripMenuItem.Text = "Bloquear"
        '
        'NovoToolStripMenuItem1
        '
        Me.NovoToolStripMenuItem1.Image = CType(resources.GetObject("NovoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NovoToolStripMenuItem1.Name = "NovoToolStripMenuItem1"
        Me.NovoToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.NovoToolStripMenuItem1.Text = "Novo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "CÓD FUNCIONÁRIO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "USUÁRIO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "SENHA"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(130, 129)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "CONFIRMAR SENHA"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(130, 155)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 20)
        Me.TextBox4.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 19)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "CRIAÇÃO DE LOGIN"
        '
        'FrmCriarLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 253)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCriarLogin"
        Me.Text = "FrmCriarLogin"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents SALVARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CANCELARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
