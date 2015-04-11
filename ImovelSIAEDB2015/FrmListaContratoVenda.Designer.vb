<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmListaContratoVenda
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaContratoVenda))
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.cmbTipoPesquisa = New System.Windows.Forms.ComboBox()
		Me.txtPesquisar = New System.Windows.Forms.TextBox()
		Me.dtgContratosVenda = New System.Windows.Forms.DataGridView()
		Me.id_contrato_aluguel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_proprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Proprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id_imovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NomeTestemunha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Comprador = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Captador1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dtgContratosVenda, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnEditar
		'
		Me.btnEditar.Location = New System.Drawing.Point(599, 11)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(75, 23)
		Me.btnEditar.TabIndex = 20
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = True
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(12, 12)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisar.TabIndex = 19
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'cmbTipoPesquisa
		'
		Me.cmbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipoPesquisa.FormattingEnabled = True
		Me.cmbTipoPesquisa.Items.AddRange(New Object() {"Proprietário", "Comprador", "ID Contrato"})
		Me.cmbTipoPesquisa.Location = New System.Drawing.Point(472, 13)
		Me.cmbTipoPesquisa.Name = "cmbTipoPesquisa"
		Me.cmbTipoPesquisa.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipoPesquisa.TabIndex = 18
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Location = New System.Drawing.Point(93, 14)
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.Size = New System.Drawing.Size(373, 20)
		Me.txtPesquisar.TabIndex = 17
		'
		'dtgContratosVenda
		'
		Me.dtgContratosVenda.AllowUserToAddRows = False
		Me.dtgContratosVenda.AllowUserToDeleteRows = False
		Me.dtgContratosVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtgContratosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgContratosVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_contrato_aluguel, Me.id_proprietario, Me.Proprietario, Me.id_imovel, Me.NomeTestemunha1, Me.Comprador, Me.Captador1})
		Me.dtgContratosVenda.Location = New System.Drawing.Point(12, 41)
		Me.dtgContratosVenda.Name = "dtgContratosVenda"
		Me.dtgContratosVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgContratosVenda.Size = New System.Drawing.Size(750, 412)
		Me.dtgContratosVenda.TabIndex = 16
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
		'Comprador
		'
		Me.Comprador.DataPropertyName = "Comprador"
		Me.Comprador.HeaderText = "Comprador"
		Me.Comprador.Name = "Comprador"
		Me.Comprador.ReadOnly = True
		'
		'Captador1
		'
		Me.Captador1.DataPropertyName = "Captador1"
		Me.Captador1.HeaderText = "Captador 1"
		Me.Captador1.Name = "Captador1"
		Me.Captador1.ReadOnly = True
		'
		'FrmListaContratoVenda
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(774, 465)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.btnPesquisar)
		Me.Controls.Add(Me.cmbTipoPesquisa)
		Me.Controls.Add(Me.txtPesquisar)
		Me.Controls.Add(Me.dtgContratosVenda)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmListaContratoVenda"
		Me.Text = "Lista de Contratos de Venda"
		CType(Me.dtgContratosVenda, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnEditar As Button
	Friend WithEvents btnPesquisar As Button
	Friend WithEvents cmbTipoPesquisa As ComboBox
	Friend WithEvents txtPesquisar As TextBox
	Friend WithEvents dtgContratosVenda As DataGridView
	Friend WithEvents id_contrato_aluguel As DataGridViewTextBoxColumn
	Friend WithEvents id_proprietario As DataGridViewTextBoxColumn
	Friend WithEvents Proprietario As DataGridViewTextBoxColumn
	Friend WithEvents id_imovel As DataGridViewTextBoxColumn
	Friend WithEvents NomeTestemunha1 As DataGridViewTextBoxColumn
	Friend WithEvents Comprador As DataGridViewTextBoxColumn
	Friend WithEvents Captador1 As DataGridViewTextBoxColumn
End Class
