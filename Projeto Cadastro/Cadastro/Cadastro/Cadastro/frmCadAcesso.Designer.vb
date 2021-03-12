<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAcesso
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCadUsuario = New System.Windows.Forms.TextBox()
        Me.txtCadSenha = New System.Windows.Forms.TextBox()
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCadUsuario
        '
        Me.txtCadUsuario.Location = New System.Drawing.Point(127, 83)
        Me.txtCadUsuario.Name = "txtCadUsuario"
        Me.txtCadUsuario.Size = New System.Drawing.Size(187, 20)
        Me.txtCadUsuario.TabIndex = 0
        '
        'txtCadSenha
        '
        Me.txtCadSenha.Location = New System.Drawing.Point(127, 129)
        Me.txtCadSenha.Name = "txtCadSenha"
        Me.txtCadSenha.Size = New System.Drawing.Size(187, 20)
        Me.txtCadSenha.TabIndex = 1
        '
        'btnCadastro
        '
        Me.btnCadastro.Location = New System.Drawing.Point(127, 170)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(84, 23)
        Me.btnCadastro.TabIndex = 2
        Me.btnCadastro.Text = "Cadastrar"
        Me.btnCadastro.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(234, 170)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(80, 23)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'frmCadAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(458, 290)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.txtCadSenha)
        Me.Controls.Add(Me.txtCadUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadAcesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadAcesso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCadUsuario As TextBox
    Friend WithEvents txtCadSenha As TextBox
    Friend WithEvents btnCadastro As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
