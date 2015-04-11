<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmListaImovel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaImovel))
		Me.dtgImovel = New System.Windows.Forms.DataGridView()
		Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
		Me.id_imovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Transacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Subtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Complemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Area_terreno = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Area_construida = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Corretor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Quartos = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IPTU = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Salas = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Suite = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Garagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Banheiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Andar = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.cmbTipoPesquisa = New System.Windows.Forms.ComboBox()
		Me.txtPesquisar = New System.Windows.Forms.TextBox()
		CType(Me.dtgImovel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dtgImovel
		'
		Me.dtgImovel.AllowUserToAddRows = False
		Me.dtgImovel.AllowUserToDeleteRows = False
		Me.dtgImovel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtgImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgImovel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foto, Me.id_imovel, Me.Transacao, Me.Tipo, Me.Subtipo, Me.Estado, Me.Cidade, Me.Bairro, Me.Endereco, Me.Numero, Me.Complemento, Me.Area_terreno, Me.Area_construida, Me.Corretor, Me.Quartos, Me.IPTU, Me.Preco, Me.Salas, Me.id_cliente, Me.Suite, Me.Garagem, Me.Banheiro, Me.Andar})
		Me.dtgImovel.Location = New System.Drawing.Point(12, 65)
		Me.dtgImovel.Name = "dtgImovel"
		Me.dtgImovel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgImovel.Size = New System.Drawing.Size(845, 442)
		Me.dtgImovel.TabIndex = 0
		'
		'Foto
		'
		Me.Foto.DataPropertyName = "foto"
		Me.Foto.HeaderText = "Foto"
		Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
		Me.Foto.Name = "Foto"
		Me.Foto.ReadOnly = True
		'
		'id_imovel
		'
		Me.id_imovel.DataPropertyName = "id_imovel"
		Me.id_imovel.HeaderText = "ID"
		Me.id_imovel.Name = "id_imovel"
		Me.id_imovel.ReadOnly = True
		'
		'Transacao
		'
		Me.Transacao.DataPropertyName = "Transacao"
		Me.Transacao.HeaderText = "Transação"
		Me.Transacao.Name = "Transacao"
		Me.Transacao.ReadOnly = True
		'
		'Tipo
		'
		Me.Tipo.DataPropertyName = "Tipo"
		Me.Tipo.HeaderText = "Tipo"
		Me.Tipo.Name = "Tipo"
		Me.Tipo.ReadOnly = True
		'
		'Subtipo
		'
		Me.Subtipo.DataPropertyName = "Subtipo"
		Me.Subtipo.HeaderText = "Subtipo"
		Me.Subtipo.Name = "Subtipo"
		Me.Subtipo.ReadOnly = True
		'
		'Estado
		'
		Me.Estado.DataPropertyName = "Estado"
		Me.Estado.HeaderText = "Estado"
		Me.Estado.Name = "Estado"
		Me.Estado.ReadOnly = True
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
		'Endereco
		'
		Me.Endereco.DataPropertyName = "Endereco"
		Me.Endereco.HeaderText = "Endereço"
		Me.Endereco.Name = "Endereco"
		Me.Endereco.ReadOnly = True
		'
		'Numero
		'
		Me.Numero.DataPropertyName = "Numero"
		Me.Numero.HeaderText = "Número"
		Me.Numero.Name = "Numero"
		Me.Numero.ReadOnly = True
		'
		'Complemento
		'
		Me.Complemento.DataPropertyName = "Complemento"
		Me.Complemento.HeaderText = "Complemento"
		Me.Complemento.Name = "Complemento"
		Me.Complemento.ReadOnly = True
		'
		'Area_terreno
		'
		Me.Area_terreno.DataPropertyName = "Areaterreno"
		Me.Area_terreno.HeaderText = "Area Terreno"
		Me.Area_terreno.Name = "Area_terreno"
		Me.Area_terreno.ReadOnly = True
		'
		'Area_construida
		'
		Me.Area_construida.DataPropertyName = "Areaconstruida"
		Me.Area_construida.HeaderText = "Area Construída"
		Me.Area_construida.Name = "Area_construida"
		Me.Area_construida.ReadOnly = True
		'
		'Corretor
		'
		Me.Corretor.DataPropertyName = "Corretor"
		Me.Corretor.HeaderText = "Corretor"
		Me.Corretor.Name = "Corretor"
		Me.Corretor.ReadOnly = True
		'
		'Quartos
		'
		Me.Quartos.DataPropertyName = "Quartos"
		Me.Quartos.HeaderText = "Quartos"
		Me.Quartos.Name = "Quartos"
		Me.Quartos.ReadOnly = True
		'
		'IPTU
		'
		Me.IPTU.DataPropertyName = "IPTU"
		Me.IPTU.HeaderText = "IPTU"
		Me.IPTU.Name = "IPTU"
		Me.IPTU.ReadOnly = True
		'
		'Preco
		'
		Me.Preco.DataPropertyName = "Preco"
		Me.Preco.HeaderText = "Preço"
		Me.Preco.Name = "Preco"
		Me.Preco.ReadOnly = True
		'
		'Salas
		'
		Me.Salas.DataPropertyName = "Salas"
		Me.Salas.HeaderText = "Salas"
		Me.Salas.Name = "Salas"
		Me.Salas.ReadOnly = True
		'
		'id_cliente
		'
		Me.id_cliente.DataPropertyName = "id_cliente"
		Me.id_cliente.HeaderText = "Proprietário"
		Me.id_cliente.Name = "id_cliente"
		Me.id_cliente.ReadOnly = True
		'
		'Suite
		'
		Me.Suite.DataPropertyName = "Suite"
		Me.Suite.HeaderText = "Suíte"
		Me.Suite.Name = "Suite"
		Me.Suite.ReadOnly = True
		'
		'Garagem
		'
		Me.Garagem.DataPropertyName = "Garagem"
		Me.Garagem.HeaderText = "Garagem"
		Me.Garagem.Name = "Garagem"
		Me.Garagem.ReadOnly = True
		'
		'Banheiro
		'
		Me.Banheiro.DataPropertyName = "Banheiro"
		Me.Banheiro.HeaderText = "Banheiro"
		Me.Banheiro.Name = "Banheiro"
		Me.Banheiro.ReadOnly = True
		'
		'Andar
		'
		Me.Andar.DataPropertyName = "Andar"
		Me.Andar.HeaderText = "Andar"
		Me.Andar.Name = "Andar"
		Me.Andar.ReadOnly = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(781, 39)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
		Me.btnExcluir.TabIndex = 10
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseVisualStyleBackColor = True
		'
		'btnEditar
		'
		Me.btnEditar.Location = New System.Drawing.Point(700, 39)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(75, 23)
		Me.btnEditar.TabIndex = 9
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = True
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(12, 37)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisar.TabIndex = 8
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'cmbTipoPesquisa
		'
		Me.cmbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipoPesquisa.FormattingEnabled = True
		Me.cmbTipoPesquisa.Items.AddRange(New Object() {"Proprietário", "Tipo", "Subtipo", "Cidade"})
		Me.cmbTipoPesquisa.Location = New System.Drawing.Point(573, 41)
		Me.cmbTipoPesquisa.Name = "cmbTipoPesquisa"
		Me.cmbTipoPesquisa.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipoPesquisa.TabIndex = 7
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Location = New System.Drawing.Point(93, 39)
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.Size = New System.Drawing.Size(474, 20)
		Me.txtPesquisar.TabIndex = 6
		'
		'FrmListaImovel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(869, 519)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.cmbTipoPesquisa)
		Me.Controls.Add(Me.txtPesquisar)
		Me.Controls.Add(Me.dtgImovel)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmListaImovel"
		Me.Text = "Lista de imóveis"
		CType(Me.dtgImovel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dtgImovel As DataGridView
	Friend WithEvents btnExcluir As Button
	Friend WithEvents btnEditar As Button
	Friend WithEvents btnPesquisar As Button
	Friend WithEvents cmbTipoPesquisa As ComboBox
	Friend WithEvents txtPesquisar As TextBox
	Friend WithEvents Foto As DataGridViewImageColumn
	Friend WithEvents id_imovel As DataGridViewTextBoxColumn
	Friend WithEvents Transacao As DataGridViewTextBoxColumn
	Friend WithEvents Tipo As DataGridViewTextBoxColumn
	Friend WithEvents Subtipo As DataGridViewTextBoxColumn
	Friend WithEvents Estado As DataGridViewTextBoxColumn
	Friend WithEvents Cidade As DataGridViewTextBoxColumn
	Friend WithEvents Bairro As DataGridViewTextBoxColumn
	Friend WithEvents Endereco As DataGridViewTextBoxColumn
	Friend WithEvents Numero As DataGridViewTextBoxColumn
	Friend WithEvents Complemento As DataGridViewTextBoxColumn
	Friend WithEvents Area_terreno As DataGridViewTextBoxColumn
	Friend WithEvents Area_construida As DataGridViewTextBoxColumn
	Friend WithEvents Corretor As DataGridViewTextBoxColumn
	Friend WithEvents Quartos As DataGridViewTextBoxColumn
	Friend WithEvents IPTU As DataGridViewTextBoxColumn
	Friend WithEvents Preco As DataGridViewTextBoxColumn
	Friend WithEvents Salas As DataGridViewTextBoxColumn
	Friend WithEvents id_cliente As DataGridViewTextBoxColumn
	Friend WithEvents Suite As DataGridViewTextBoxColumn
	Friend WithEvents Garagem As DataGridViewTextBoxColumn
	Friend WithEvents Banheiro As DataGridViewTextBoxColumn
	Friend WithEvents Andar As DataGridViewTextBoxColumn
End Class
