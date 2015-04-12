<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmListaCliente
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaCliente))
		Me.dtgCliente = New System.Windows.Forms.DataGridView()
		Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Tipo_Pessoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Razao_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Nacionalidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Naturalidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Estado_Civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Profissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtPesquisar = New System.Windows.Forms.TextBox()
		Me.cmbTipoPesquisa = New System.Windows.Forms.ComboBox()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnExcluir = New System.Windows.Forms.Button()
		CType(Me.dtgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dtgCliente
		'
		Me.dtgCliente.AllowUserToAddRows = False
		Me.dtgCliente.AllowUserToDeleteRows = False
		Me.dtgCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cliente, Me.Tipo, Me.DataNascimento, Me.Nome, Me.CPF, Me.Tipo_Pessoa, Me.Razao_social, Me.Telefone, Me.Celular, Me.CNPJ, Me.Email, Me.Endereco, Me.Cidade, Me.Bairro, Me.Estado, Me.Numero, Me.CEP, Me.Nacionalidade, Me.Naturalidade, Me.Estado_Civil, Me.Profissao})
		Me.dtgCliente.Location = New System.Drawing.Point(12, 71)
		Me.dtgCliente.Name = "dtgCliente"
		Me.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgCliente.Size = New System.Drawing.Size(1044, 409)
		Me.dtgCliente.TabIndex = 0
		'
		'id_cliente
		'
		Me.id_cliente.DataPropertyName = "id_cliente"
		Me.id_cliente.HeaderText = "ID"
		Me.id_cliente.Name = "id_cliente"
		Me.id_cliente.ReadOnly = True
		'
		'Tipo
		'
		Me.Tipo.DataPropertyName = "Tipo"
		Me.Tipo.HeaderText = "Tipo"
		Me.Tipo.Name = "Tipo"
		Me.Tipo.ReadOnly = True
		'
		'DataNascimento
		'
		Me.DataNascimento.DataPropertyName = "DataNascimento"
		Me.DataNascimento.HeaderText = "Data de Nascimento"
		Me.DataNascimento.Name = "DataNascimento"
		Me.DataNascimento.ReadOnly = True
		'
		'Nome
		'
		Me.Nome.DataPropertyName = "Nome"
		Me.Nome.HeaderText = "Nome"
		Me.Nome.Name = "Nome"
		Me.Nome.ReadOnly = True
		'
		'CPF
		'
		Me.CPF.DataPropertyName = "CPF"
		Me.CPF.HeaderText = "CPF"
		Me.CPF.Name = "CPF"
		Me.CPF.ReadOnly = True
		'
		'Tipo_Pessoa
		'
		Me.Tipo_Pessoa.DataPropertyName = "tipopessoa"
		Me.Tipo_Pessoa.HeaderText = "Pessoa"
		Me.Tipo_Pessoa.Name = "Tipo_Pessoa"
		Me.Tipo_Pessoa.ReadOnly = True
		'
		'Razao_social
		'
		Me.Razao_social.DataPropertyName = "razaosocial"
		Me.Razao_social.HeaderText = "Razão Social"
		Me.Razao_social.Name = "Razao_social"
		Me.Razao_social.ReadOnly = True
		'
		'Telefone
		'
		Me.Telefone.DataPropertyName = "Telefone"
		Me.Telefone.HeaderText = "Telefone"
		Me.Telefone.Name = "Telefone"
		Me.Telefone.ReadOnly = True
		'
		'Celular
		'
		Me.Celular.DataPropertyName = "Celular"
		Me.Celular.HeaderText = "Celular"
		Me.Celular.Name = "Celular"
		Me.Celular.ReadOnly = True
		'
		'CNPJ
		'
		Me.CNPJ.DataPropertyName = "CNPJ"
		Me.CNPJ.HeaderText = "CNPJ"
		Me.CNPJ.Name = "CNPJ"
		Me.CNPJ.ReadOnly = True
		'
		'Email
		'
		Me.Email.DataPropertyName = "Email"
		Me.Email.HeaderText = "Email"
		Me.Email.Name = "Email"
		Me.Email.ReadOnly = True
		'
		'Endereco
		'
		Me.Endereco.DataPropertyName = "Endereco"
		Me.Endereco.HeaderText = "Endereço"
		Me.Endereco.Name = "Endereco"
		Me.Endereco.ReadOnly = True
		'
		'Cidade
		'
		Me.Cidade.DataPropertyName = "Cidade"
		Me.Cidade.HeaderText = "Cidade"
		Me.Cidade.Name = "Cidade"
		Me.Cidade.ReadOnly = True
		'
		'Bairro
		'
		Me.Bairro.DataPropertyName = "Bairro"
		Me.Bairro.HeaderText = "Bairro"
		Me.Bairro.Name = "Bairro"
		Me.Bairro.ReadOnly = True
		'
		'Estado
		'
		Me.Estado.DataPropertyName = "Estado"
		Me.Estado.HeaderText = "Estado"
		Me.Estado.Name = "Estado"
		Me.Estado.ReadOnly = True
		'
		'Numero
		'
		Me.Numero.DataPropertyName = "Numero"
		Me.Numero.HeaderText = "Número"
		Me.Numero.Name = "Numero"
		Me.Numero.ReadOnly = True
		'
		'CEP
		'
		Me.CEP.DataPropertyName = "CEP"
		Me.CEP.HeaderText = "CEP"
		Me.CEP.Name = "CEP"
		Me.CEP.ReadOnly = True
		'
		'Nacionalidade
		'
		Me.Nacionalidade.DataPropertyName = "Nacionalidade"
		Me.Nacionalidade.HeaderText = "Nacionalidade"
		Me.Nacionalidade.Name = "Nacionalidade"
		Me.Nacionalidade.ReadOnly = True
		'
		'Naturalidade
		'
		Me.Naturalidade.DataPropertyName = "Naturalidade"
		Me.Naturalidade.HeaderText = "Naturalidade"
		Me.Naturalidade.Name = "Naturalidade"
		Me.Naturalidade.ReadOnly = True
		'
		'Estado_Civil
		'
		Me.Estado_Civil.DataPropertyName = "estadocivil"
		Me.Estado_Civil.HeaderText = "Estado Civil"
		Me.Estado_Civil.Name = "Estado_Civil"
		Me.Estado_Civil.ReadOnly = True
		'
		'Profissao
		'
		Me.Profissao.DataPropertyName = "Profissao"
		Me.Profissao.HeaderText = "Profissão"
		Me.Profissao.Name = "Profissao"
		Me.Profissao.ReadOnly = True
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Location = New System.Drawing.Point(94, 37)
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.Size = New System.Drawing.Size(314, 20)
		Me.txtPesquisar.TabIndex = 1
		'
		'cmbTipoPesquisa
		'
		Me.cmbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipoPesquisa.FormattingEnabled = True
		Me.cmbTipoPesquisa.Items.AddRange(New Object() {"Nome", "Tipo", "CPF", "CNPJ", "Cidade", "Razão Social"})
		Me.cmbTipoPesquisa.Location = New System.Drawing.Point(771, 35)
		Me.cmbTipoPesquisa.Name = "cmbTipoPesquisa"
		Me.cmbTipoPesquisa.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipoPesquisa.TabIndex = 2
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(13, 35)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisar.TabIndex = 3
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'btnEditar
		'
		Me.btnEditar.Location = New System.Drawing.Point(898, 33)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(75, 23)
		Me.btnEditar.TabIndex = 4
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(979, 33)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
		Me.btnExcluir.TabIndex = 5
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseVisualStyleBackColor = True
		'
		'FrmListaCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1068, 492)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.cmbTipoPesquisa)
		Me.Controls.Add(Me.txtPesquisar)
		Me.Controls.Add(Me.dtgCliente)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmListaCliente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Lista de Clientes"
		CType(Me.dtgCliente, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dtgCliente As DataGridView
	Friend WithEvents txtPesquisar As TextBox
	Friend WithEvents cmbTipoPesquisa As ComboBox
	Friend WithEvents btnPesquisar As Button
	Friend WithEvents btnEditar As Button
	Friend WithEvents btnExcluir As Button
	Friend WithEvents id_cliente As DataGridViewTextBoxColumn
	Friend WithEvents Tipo As DataGridViewTextBoxColumn
	Friend WithEvents DataNascimento As DataGridViewTextBoxColumn
	Friend WithEvents Nome As DataGridViewTextBoxColumn
	Friend WithEvents CPF As DataGridViewTextBoxColumn
	Friend WithEvents Tipo_Pessoa As DataGridViewTextBoxColumn
	Friend WithEvents Razao_social As DataGridViewTextBoxColumn
	Friend WithEvents Telefone As DataGridViewTextBoxColumn
	Friend WithEvents Celular As DataGridViewTextBoxColumn
	Friend WithEvents CNPJ As DataGridViewTextBoxColumn
	Friend WithEvents Email As DataGridViewTextBoxColumn
	Friend WithEvents Endereco As DataGridViewTextBoxColumn
	Friend WithEvents Cidade As DataGridViewTextBoxColumn
	Friend WithEvents Bairro As DataGridViewTextBoxColumn
	Friend WithEvents Estado As DataGridViewTextBoxColumn
	Friend WithEvents Numero As DataGridViewTextBoxColumn
	Friend WithEvents CEP As DataGridViewTextBoxColumn
	Friend WithEvents Nacionalidade As DataGridViewTextBoxColumn
	Friend WithEvents Naturalidade As DataGridViewTextBoxColumn
	Friend WithEvents Estado_Civil As DataGridViewTextBoxColumn
	Friend WithEvents Profissao As DataGridViewTextBoxColumn
End Class
