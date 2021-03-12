<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAcessar
        '
        Me.btnAcessar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcessar.Location = New System.Drawing.Point(98, 278)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(87, 26)
        Me.btnAcessar.TabIndex = 2
        Me.btnAcessar.Text = "Entrar"
        Me.btnAcessar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(98, 234)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(179, 20)
        Me.txtSenha.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(98, 192)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(179, 20)
        Me.txtLogin.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.Location = New System.Drawing.Point(191, 280)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(86, 23)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(95, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha"
        '
        'ptbFoto
        '
        Me.ptbFoto.Image = Global.Cadastro.My.Resources.Resources.usuario__2_
        Me.ptbFoto.Location = New System.Drawing.Point(98, 12)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(179, 139)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbFoto.TabIndex = 3
        Me.ptbFoto.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(400, 335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnAcessar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAcessar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
