<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmListaContratosAluguel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaContratosAluguel))
		Me.dtgContratosAluguel = New System.Windows.Forms.DataGridView()
		Me.id_contrato_aluguel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_proprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Proprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_imovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NomeTestemunha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TipoImovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.cmbTipoPesquisa = New System.Windows.Forms.ComboBox()
		Me.txtPesquisar = New System.Windows.Forms.TextBox()
		CType(Me.dtgContratosAluguel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dtgContratosAluguel
		'
		Me.dtgContratosAluguel.AllowUserToAddRows = False
		Me.dtgContratosAluguel.AllowUserToDeleteRows = False
		Me.dtgContratosAluguel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)	_
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtgContratosAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgContratosAluguel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_contrato_aluguel, Me.id_proprietario, Me.Proprietario, Me.id_imovel, Me.NomeTestemunha1, Me.TipoImovel, Me.Situacao})
		Me.dtgContratosAluguel.Location = New System.Drawing.Point(12, 72)
		Me.dtgContratosAluguel.Name = "dtgContratosAluguel"
		Me.dtgContratosAluguel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgContratosAluguel.Size = New System.Drawing.Size(746, 384)
		Me.dtgContratosAluguel.TabIndex = 0
		'
		'id_contrato_aluguel
		'
		Me.id_contrato_aluguel.DataPropertyName = "id_contrato_aluguel"
		Me.id_contrato_aluguel.HeaderText = "ID Contrato"
		Me.id_contrato_aluguel.Name = "id_contrato_aluguel"
		Me.id_contrato_aluguel.ReadOnly = True
		'
		'id_proprietario
		'
		Me.id_proprietario.DataPropertyName = "id_proprietario"
		Me.id_proprietario.HeaderText = "id_proprietario"
		Me.id_proprietario.Name = "id_proprietario"
		Me.id_proprietario.ReadOnly = True
		'
		'Proprietario
		'
		Me.Proprietario.DataPropertyName = "Proprietario"
		Me.Proprietario.HeaderText = "Proprietario"
		Me.Proprietario.Name = "Proprietario"
		Me.Proprietario.ReadOnly = True
		'
		'id_imovel
		'
		Me.id_imovel.DataPropertyName = "id_imovel"
		Me.id_imovel.HeaderText = "ID do Imóvel"
		Me.id_imovel.Name = "id_imovel"
		Me.id_imovel.ReadOnly = True
		'
		'NomeTestemunha1
		'
		Me.NomeTestemunha1.DataPropertyName = "NomeTestemunha1"
		Me.NomeTestemunha1.HeaderText = "Testemunha 1"
		Me.NomeTestemunha1.Name = "NomeTestemunha1"
		Me.NomeTestemunha1.ReadOnly = True
		'
		'TipoImovel
		'
		Me.TipoImovel.DataPropertyName = "Tipo_Imovel"
		Me.TipoImovel.HeaderText = "Tipo"
		Me.TipoImovel.Name = "TipoImovel"
		Me.TipoImovel.ReadOnly = True
		'
		'Situacao
		'
		Me.Situacao.DataPropertyName = "Situacao"
		Me.Situacao.HeaderText = "Situação"
		Me.Situacao.Name = "Situacao"
		Me.Situacao.ReadOnly = True
		'
		'btnEditar
		'
		Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnEditar.Location = New System.Drawing.Point(683, 42)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(75, 23)
		Me.btnEditar.TabIndex = 14
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = True
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(12, 43)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisar.TabIndex = 13
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'cmbTipoPesquisa
		'
		Me.cmbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipoPesquisa.FormattingEnabled = True
		Me.cmbTipoPesquisa.Items.AddRange(New Object() {"Proprietário", "Tipo", "Situação"})
		Me.cmbTipoPesquisa.Location = New System.Drawing.Point(556, 44)
		Me.cmbTipoPesquisa.Name = "cmbTipoPesquisa"
		Me.cmbTipoPesquisa.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipoPesquisa.TabIndex = 12
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Location = New System.Drawing.Point(93, 45)
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.Size = New System.Drawing.Size(457, 20)
		Me.txtPesquisar.TabIndex = 11
		'
		'FrmListaContratosAluguel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(770, 468)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.cmbTipoPesquisa)
		Me.Controls.Add(Me.txtPesquisar)
		Me.Controls.Add(Me.dtgContratosAluguel)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmListaContratosAluguel"
		Me.Text = "Lista de Contratos de Aluguel"
		CType(Me.dtgContratosAluguel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dtgContratosAluguel As DataGridView
	Friend WithEvents btnEditar As Button
	Friend WithEvents btnPesquisar As Button
	Friend WithEvents cmbTipoPesquisa As ComboBox
	Friend WithEvents txtPesquisar As TextBox
	Friend WithEvents id_contrato_aluguel As DataGridViewTextBoxColumn
	Friend WithEvents id_proprietario As DataGridViewTextBoxColumn
	Friend WithEvents Proprietario As DataGridViewTextBoxColumn
	Friend WithEvents id_imovel As DataGridViewTextBoxColumn
	Friend WithEvents NomeTestemunha1 As DataGridViewTextBoxColumn
	Friend WithEvents TipoImovel As DataGridViewTextBoxColumn
	Friend WithEvents Situacao As DataGridViewTextBoxColumn
End Class
