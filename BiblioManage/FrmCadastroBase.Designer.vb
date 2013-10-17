<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroBase
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
        Me.TituloPanel = New System.Windows.Forms.Panel()
        Me.TituloLabel = New System.Windows.Forms.Label()
        Me.MainGroupBox = New System.Windows.Forms.GroupBox()
        Me.TituloPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloPanel
        '
        Me.TituloPanel.BackColor = System.Drawing.Color.White
        Me.TituloPanel.Controls.Add(Me.TituloLabel)
        Me.TituloPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloPanel.Location = New System.Drawing.Point(0, 0)
        Me.TituloPanel.Name = "TituloPanel"
        Me.TituloPanel.Size = New System.Drawing.Size(781, 60)
        Me.TituloPanel.TabIndex = 0
        '
        'TituloLabel
        '
        Me.TituloLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TituloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLabel.ForeColor = System.Drawing.Color.Blue
        Me.TituloLabel.Location = New System.Drawing.Point(0, 0)
        Me.TituloLabel.Name = "TituloLabel"
        Me.TituloLabel.Size = New System.Drawing.Size(781, 60)
        Me.TituloLabel.TabIndex = 1
        Me.TituloLabel.Text = "Label1"
        Me.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainGroupBox
        '
        Me.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MainGroupBox.Location = New System.Drawing.Point(0, 60)
        Me.MainGroupBox.Name = "MainGroupBox"
        Me.MainGroupBox.Size = New System.Drawing.Size(781, 468)
        Me.MainGroupBox.TabIndex = 1
        Me.MainGroupBox.TabStop = False
        '
        'FrmCadastroBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 528)
        Me.Controls.Add(Me.MainGroupBox)
        Me.Controls.Add(Me.TituloPanel)
        Me.Name = "FrmCadastroBase"
        Me.Text = "FrmCadastroBase"
        Me.TituloPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents MainGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TituloPanel As System.Windows.Forms.Panel
    Protected Friend WithEvents TituloLabel As System.Windows.Forms.Label
End Class
