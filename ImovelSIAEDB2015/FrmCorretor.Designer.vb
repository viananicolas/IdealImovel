<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmCorretor
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorretor))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNome = New System.Windows.Forms.TextBox()
		Me.txtRG = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtEndereco = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtBairro = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCidade = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtTelefone = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.dtgCorretor = New System.Windows.Forms.DataGridView()
		Me.id_corretor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RG = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dtpNascimento = New System.Windows.Forms.DateTimePicker()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnLimpar = New System.Windows.Forms.Button()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.txtPesquisar = New System.Windows.Forms.TextBox()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.cmbEstado = New System.Windows.Forms.ComboBox()
		Me.btnEditar = New System.Windows.Forms.Button()
		CType(Me.dtgCorretor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(38, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nome:"
		'
		'txtNome
		'
		Me.txtNome.Location = New System.Drawing.Point(59, 13)
		Me.txtNome.Name = "txtNome"
		Me.txtNome.Size = New System.Drawing.Size(100, 20)
		Me.txtNome.TabIndex = 1
		'
		'txtRG
		'
		Me.txtRG.Location = New System.Drawing.Point(59, 39)
		Me.txtRG.Name = "txtRG"
		Me.txtRG.Size = New System.Drawing.Size(100, 20)
		Me.txtRG.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 39)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(29, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "RG: "
		'
		'txtEndereco
		'
		Me.txtEndereco.Location = New System.Drawing.Point(59, 65)
		Me.txtEndereco.Name = "txtEndereco"
		Me.txtEndereco.Size = New System.Drawing.Size(100, 20)
		Me.txtEndereco.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(0, 68)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Endereço"
		'
		'txtBairro
		'
		Me.txtBairro.Location = New System.Drawing.Point(218, 13)
		Me.txtBairro.Name = "txtBairro"
		Me.txtBairro.Size = New System.Drawing.Size(100, 20)
		Me.txtBairro.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(172, 13)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(34, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Bairro"
		'
		'txtCidade
		'
		Me.txtCidade.Location = New System.Drawing.Point(218, 39)
		Me.txtCidade.Name = "txtCidade"
		Me.txtCidade.Size = New System.Drawing.Size(100, 20)
		Me.txtCidade.TabIndex = 9
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(172, 39)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 13)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Cidade"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(172, 65)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(40, 13)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Estado"
		'
		'txtTelefone
		'
		Me.txtTelefone.Location = New System.Drawing.Point(382, 10)
		Me.txtTelefone.Name = "txtTelefone"
		Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
		Me.txtTelefone.TabIndex = 13
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(327, 13)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(49, 13)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "Telefone"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(382, 39)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(100, 20)
		Me.txtEmail.TabIndex = 15
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(327, 42)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(32, 13)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "Email"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(327, 71)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(104, 13)
		Me.Label9.TabIndex = 16
		Me.Label9.Text = "Data de Nascimento"
		'
		'dtgCorretor
		'
		Me.dtgCorretor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)	_
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtgCorretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgCorretor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_corretor, Me.Nome, Me.RG, Me.Bairro, Me.Cidade, Me.Estado, Me.Telefone, Me.Email, Me.DataNascimento})
		Me.dtgCorretor.Location = New System.Drawing.Point(12, 131)
		Me.dtgCorretor.Name = "dtgCorretor"
		Me.dtgCorretor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgCorretor.Size = New System.Drawing.Size(721, 239)
		Me.dtgCorretor.TabIndex = 17
		'
		'id_corretor
		'
		Me.id_corretor.DataPropertyName = "id_corretor"
		Me.id_corretor.HeaderText = "ID"
		Me.id_corretor.Name = "id_corretor"
		Me.id_corretor.ReadOnly = True
		'
		'Nome
		'
		Me.Nome.DataPropertyName = "Nome"
		Me.Nome.HeaderText = "Nome"
		Me.Nome.Name = "Nome"
		Me.Nome.ReadOnly = True
		'
		'RG
		'
		Me.RG.DataPropertyName = "RG"
		Me.RG.HeaderText = "RG"
		Me.RG.Name = "RG"
		Me.RG.ReadOnly = True
		'
		'Bairro
		'
		Me.Bairro.DataPropertyName = "Bairro"
		Me.Bairro.HeaderText = "Bairro"
		Me.Bairro.Name = "Bairro"
		Me.Bairro.ReadOnly = True
		'
		'Cidade
		'
		Me.Cidade.DataPropertyName = "Cidade"
		Me.Cidade.HeaderText = "Cidade"
		Me.Cidade.Name = "Cidade"
		Me.Cidade.ReadOnly = True
		'
		'Estado
		'
		Me.Estado.DataPropertyName = "Estado"
		Me.Estado.HeaderText = "Estado"
		Me.Estado.Name = "Estado"
		Me.Estado.ReadOnly = True
		'
		'Telefone
		'
		Me.Telefone.DataPropertyName = "Telefone"
		Me.Telefone.HeaderText = "Telefone"
		Me.Telefone.Name = "Telefone"
		Me.Telefone.ReadOnly = True
		'
		'Email
		'
		Me.Email.DataPropertyName = "Email"
		Me.Email.HeaderText = "Email"
		Me.Email.Name = "Email"
		Me.Email.ReadOnly = True
		'
		'DataNascimento
		'
		Me.DataNascimento.DataPropertyName = "DataNascimento"
		Me.DataNascimento.HeaderText = "DataNascimento"
		Me.DataNascimento.Name = "DataNascimento"
		Me.DataNascimento.ReadOnly = True
		'
		'dtpNascimento
		'
		Me.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpNascimento.Location = New System.Drawing.Point(437, 68)
		Me.dtpNascimento.Name = "dtpNascimento"
		Me.dtpNascimento.Size = New System.Drawing.Size(78, 20)
		Me.dtpNascimento.TabIndex = 18
		'
		'btnSalvar
		'
		Me.btnSalvar.Location = New System.Drawing.Point(16, 102)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
		Me.btnSalvar.TabIndex = 19
		Me.btnSalvar.Text = "Salvar"
		Me.btnSalvar.UseVisualStyleBackColor = True
		'
		'btnLimpar
		'
		Me.btnLimpar.Location = New System.Drawing.Point(97, 102)
		Me.btnLimpar.Name = "btnLimpar"
		Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
		Me.btnLimpar.TabIndex = 20
		Me.btnLimpar.Text = "Limpar"
		Me.btnLimpar.UseVisualStyleBackColor = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(178, 102)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
		Me.btnExcluir.TabIndex = 21
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseVisualStyleBackColor = True
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Location = New System.Drawing.Point(552, 107)
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.Size = New System.Drawing.Size(100, 20)
		Me.txtPesquisar.TabIndex = 22
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(658, 105)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisar.TabIndex = 23
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'cmbEstado
		'
		Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEstado.FormattingEnabled = True
		Me.cmbEstado.Items.AddRange(New Object() {"AC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AL" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AM" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "BA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "CE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "DF" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "ES" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "GO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MT" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MG" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PB" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PI" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RJ" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RN" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "TO"})
		Me.cmbEstado.Location = New System.Drawing.Point(218, 65)
		Me.cmbEstado.Name = "cmbEstado"
		Me.cmbEstado.Size = New System.Drawing.Size(100, 21)
		Me.cmbEstado.TabIndex = 39
		'
		'btnEditar
		'
		Me.btnEditar.Location = New System.Drawing.Point(259, 102)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(75, 23)
		Me.btnEditar.TabIndex = 40
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = True
		'
		'FrmCorretor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(745, 382)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.cmbEstado)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.txtPesquisar)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.btnLimpar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.dtpNascimento)
		Me.Controls.Add(Me.dtgCorretor)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtTelefone)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtCidade)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtBairro)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtEndereco)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtRG)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtNome)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmCorretor"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de Corretor"
		CType(Me.dtgCorretor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtNome As TextBox
	Friend WithEvents txtRG As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtEndereco As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtBairro As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtCidade As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtTelefone As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents dtgCorretor As DataGridView
	Friend WithEvents id_corretor As DataGridViewTextBoxColumn
	Friend WithEvents Nome As DataGridViewTextBoxColumn
	Friend WithEvents RG As DataGridViewTextBoxColumn
	Friend WithEvents Bairro As DataGridViewTextBoxColumn
	Friend WithEvents Cidade As DataGridViewTextBoxColumn
	Friend WithEvents Estado As DataGridViewTextBoxColumn
	Friend WithEvents Telefone As DataGridViewTextBoxColumn
	Friend WithEvents Email As DataGridViewTextBoxColumn
	Friend WithEvents DataNascimento As DataGridViewTextBoxColumn
	Friend WithEvents dtpNascimento As DateTimePicker
	Friend WithEvents btnSalvar As Button
	Friend WithEvents btnLimpar As Button
	Friend WithEvents btnExcluir As Button
	Friend WithEvents txtPesquisar As TextBox
	Friend WithEvents btnPesquisar As Button
	Friend WithEvents cmbEstado As ComboBox
	Friend WithEvents btnEditar As Button
End Class
