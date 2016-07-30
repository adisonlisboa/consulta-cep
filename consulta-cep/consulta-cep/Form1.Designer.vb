<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCep
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipologradouro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(275, 10)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 23)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(169, 12)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INFORME O CEP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UF:"
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(12, 69)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(48, 20)
        Me.txtUF.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CIDADE:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(66, 69)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(316, 20)
        Me.txtCidade.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TIPO LOG:"
        '
        'txtTipologradouro
        '
        Me.txtTipologradouro.Location = New System.Drawing.Point(388, 69)
        Me.txtTipologradouro.Name = "txtTipologradouro"
        Me.txtTipologradouro.Size = New System.Drawing.Size(112, 20)
        Me.txtTipologradouro.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "LOGRADOURO:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(12, 113)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(488, 20)
        Me.txtLogradouro.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "BAIRRO:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(12, 154)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(488, 20)
        Me.txtBairro.TabIndex = 13
        '
        'ConsultaCep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 186)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLogradouro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTipologradouro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.btnConsultar)
        Me.Name = "ConsultaCep"
        Me.Text = "Consulta CEP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtCep As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUF As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTipologradouro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBairro As TextBox
End Class
