<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmImovel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImovel))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbTransacao = New System.Windows.Forms.ComboBox()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.cmbSubtipo = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCidade = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtBairro = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtEndereco = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtNumero = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtComplemento = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtPreco = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtProprietario = New System.Windows.Forms.TextBox()
		Me.btnPesquisarProprietario = New System.Windows.Forms.Button()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtGaragem = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtSuites = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtQuartos = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtSalas = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.txtBanheiro = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtAndar = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.txtAreaTerreno = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.txtAreaConstruida = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.txtObs = New System.Windows.Forms.TextBox()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.txtCondominio = New System.Windows.Forms.TextBox()
		Me.btnFoto = New System.Windows.Forms.Button()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.pbCasa = New System.Windows.Forms.PictureBox()
		Me.btnPesquisarCorretor = New System.Windows.Forms.Button()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.txtCorretor = New System.Windows.Forms.TextBox()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnLimpar = New System.Windows.Forms.Button()
		Me.cmbEstado = New System.Windows.Forms.ComboBox()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.txtIPTU = New System.Windows.Forms.TextBox()
		Me.txtFormaPagamento = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		CType(Me.pbCasa, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(1, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Transação: *"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(195, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(38, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Tipo: *"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(362, 9)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Subtipo: *"
		'
		'cmbTransacao
		'
		Me.cmbTransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTransacao.FormattingEnabled = True
		Me.cmbTransacao.Items.AddRange(New Object() {"Aluguel", "Venda"})
		Me.cmbTransacao.Location = New System.Drawing.Point(72, 6)
		Me.cmbTransacao.Name = "cmbTransacao"
		Me.cmbTransacao.Size = New System.Drawing.Size(121, 21)
		Me.cmbTransacao.TabIndex = 3
		'
		'cmbTipo
		'
		Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipo.FormattingEnabled = True
		Me.cmbTipo.Items.AddRange(New Object() {"Residencial", "Comercial", "Industrial"})
		Me.cmbTipo.Location = New System.Drawing.Point(235, 6)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipo.TabIndex = 4
		'
		'cmbSubtipo
		'
		Me.cmbSubtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSubtipo.FormattingEnabled = True
		Me.cmbSubtipo.Items.AddRange(New Object() {"Apartamento", "Casa", "Cobertura", "Kitnet", "Lote", "Terreno"})
		Me.cmbSubtipo.Location = New System.Drawing.Point(421, 6)
		Me.cmbSubtipo.Name = "cmbSubtipo"
		Me.cmbSubtipo.Size = New System.Drawing.Size(121, 21)
		Me.cmbSubtipo.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(35, 16)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Estado: *"
		'
		'txtCidade
		'
		Me.txtCidade.Location = New System.Drawing.Point(252, 13)
		Me.txtCidade.Name = "txtCidade"
		Me.txtCidade.Size = New System.Drawing.Size(100, 20)
		Me.txtCidade.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(197, 17)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(50, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Cidade: *"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(358, 17)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(44, 13)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Bairro: *"
		'
		'txtBairro
		'
		Me.txtBairro.Location = New System.Drawing.Point(408, 13)
		Me.txtBairro.Name = "txtBairro"
		Me.txtBairro.Size = New System.Drawing.Size(100, 20)
		Me.txtBairro.TabIndex = 10
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(18, 43)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(63, 13)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Endereço: *"
		'
		'txtEndereco
		'
		Me.txtEndereco.Location = New System.Drawing.Point(91, 41)
		Me.txtEndereco.Name = "txtEndereco"
		Me.txtEndereco.Size = New System.Drawing.Size(357, 20)
		Me.txtEndereco.TabIndex = 12
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(456, 42)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(54, 13)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Número: *"
		'
		'txtNumero
		'
		Me.txtNumero.Location = New System.Drawing.Point(516, 41)
		Me.txtNumero.Name = "txtNumero"
		Me.txtNumero.Size = New System.Drawing.Size(100, 20)
		Me.txtNumero.TabIndex = 14
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(-402, 74)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(71, 13)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Complemento"
		'
		'txtComplemento
		'
		Me.txtComplemento.Location = New System.Drawing.Point(91, 66)
		Me.txtComplemento.Name = "txtComplemento"
		Me.txtComplemento.Size = New System.Drawing.Size(100, 20)
		Me.txtComplemento.TabIndex = 16
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(-225, 74)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(35, 13)
		Me.Label10.TabIndex = 19
		Me.Label10.Text = "Preço"
		'
		'txtPreco
		'
		Me.txtPreco.Location = New System.Drawing.Point(89, 145)
		Me.txtPreco.Name = "txtPreco"
		Me.txtPreco.Size = New System.Drawing.Size(100, 20)
		Me.txtPreco.TabIndex = 18
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(29, 210)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(70, 13)
		Me.Label11.TabIndex = 21
		Me.Label11.Text = "Proprietário: *"
		'
		'txtProprietario
		'
		Me.txtProprietario.Location = New System.Drawing.Point(109, 208)
		Me.txtProprietario.Name = "txtProprietario"
		Me.txtProprietario.ReadOnly = True
		Me.txtProprietario.Size = New System.Drawing.Size(100, 20)
		Me.txtProprietario.TabIndex = 20
		'
		'btnPesquisarProprietario
		'
		Me.btnPesquisarProprietario.Location = New System.Drawing.Point(215, 205)
		Me.btnPesquisarProprietario.Name = "btnPesquisarProprietario"
		Me.btnPesquisarProprietario.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisarProprietario.TabIndex = 22
		Me.btnPesquisarProprietario.Text = "Pesquisar"
		Me.btnPesquisarProprietario.UseVisualStyleBackColor = True
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(249, 29)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(60, 13)
		Me.Label12.TabIndex = 28
		Me.Label12.Text = "Garagem: *"
		'
		'txtGaragem
		'
		Me.txtGaragem.Location = New System.Drawing.Point(317, 26)
		Me.txtGaragem.Name = "txtGaragem"
		Me.txtGaragem.Size = New System.Drawing.Size(31, 20)
		Me.txtGaragem.TabIndex = 27
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(132, 29)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(48, 13)
		Me.Label13.TabIndex = 26
		Me.Label13.Text = "Suítes: *"
		'
		'txtSuites
		'
		Me.txtSuites.Location = New System.Drawing.Point(186, 26)
		Me.txtSuites.Name = "txtSuites"
		Me.txtSuites.Size = New System.Drawing.Size(30, 20)
		Me.txtSuites.TabIndex = 25
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(23, 30)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(54, 13)
		Me.Label14.TabIndex = 24
		Me.Label14.Text = "Quartos: *"
		'
		'txtQuartos
		'
		Me.txtQuartos.Location = New System.Drawing.Point(77, 26)
		Me.txtQuartos.Name = "txtQuartos"
		Me.txtQuartos.Size = New System.Drawing.Size(31, 20)
		Me.txtQuartos.TabIndex = 23
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(428, 30)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(43, 13)
		Me.Label15.TabIndex = 30
		Me.Label15.Text = "Salas: *"
		'
		'txtSalas
		'
		Me.txtSalas.Location = New System.Drawing.Point(477, 26)
		Me.txtSalas.Name = "txtSalas"
		Me.txtSalas.Size = New System.Drawing.Size(31, 20)
		Me.txtSalas.TabIndex = 29
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(18, 55)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(59, 13)
		Me.Label16.TabIndex = 32
		Me.Label16.Text = "Banheiro: *"
		'
		'txtBanheiro
		'
		Me.txtBanheiro.Location = New System.Drawing.Point(77, 52)
		Me.txtBanheiro.Name = "txtBanheiro"
		Me.txtBanheiro.Size = New System.Drawing.Size(31, 20)
		Me.txtBanheiro.TabIndex = 31
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(118, 55)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(62, 13)
		Me.Label17.TabIndex = 34
		Me.Label17.Text = "Andar(es): *"
		'
		'txtAndar
		'
		Me.txtAndar.Location = New System.Drawing.Point(186, 55)
		Me.txtAndar.Name = "txtAndar"
		Me.txtAndar.Size = New System.Drawing.Size(31, 20)
		Me.txtAndar.TabIndex = 33
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(227, 55)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(90, 13)
		Me.Label18.TabIndex = 36
		Me.Label18.Text = "Área do terreno: *"
		'
		'txtAreaTerreno
		'
		Me.txtAreaTerreno.Location = New System.Drawing.Point(317, 53)
		Me.txtAreaTerreno.Name = "txtAreaTerreno"
		Me.txtAreaTerreno.Size = New System.Drawing.Size(47, 20)
		Me.txtAreaTerreno.TabIndex = 35
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(382, 55)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(93, 13)
		Me.Label19.TabIndex = 38
		Me.Label19.Text = "Area construída: *"
		'
		'txtAreaConstruida
		'
		Me.txtAreaConstruida.Location = New System.Drawing.Point(477, 52)
		Me.txtAreaConstruida.Name = "txtAreaConstruida"
		Me.txtAreaConstruida.Size = New System.Drawing.Size(33, 20)
		Me.txtAreaConstruida.TabIndex = 37
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(5, 21)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(80, 13)
		Me.Label20.TabIndex = 46
		Me.Label20.Text = "Observações: *"
		'
		'txtObs
		'
		Me.txtObs.Location = New System.Drawing.Point(89, 19)
		Me.txtObs.Multiline = True
		Me.txtObs.Name = "txtObs"
		Me.txtObs.Size = New System.Drawing.Size(379, 120)
		Me.txtObs.TabIndex = 45
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(501, 12)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(117, 13)
		Me.Label21.TabIndex = 44
		Me.Label21.Text = "Forma de pagamento: *"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(516, 28)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(74, 13)
		Me.Label23.TabIndex = 40
		Me.Label23.Text = "Condomínio: *"
		'
		'txtCondominio
		'
		Me.txtCondominio.Location = New System.Drawing.Point(596, 25)
		Me.txtCondominio.Name = "txtCondominio"
		Me.txtCondominio.Size = New System.Drawing.Size(31, 20)
		Me.txtCondominio.TabIndex = 39
		'
		'btnFoto
		'
		Me.btnFoto.Location = New System.Drawing.Point(6, 231)
		Me.btnFoto.Name = "btnFoto"
		Me.btnFoto.Size = New System.Drawing.Size(117, 23)
		Me.btnFoto.TabIndex = 47
		Me.btnFoto.Text = "Selecionar Foto..."
		Me.btnFoto.UseVisualStyleBackColor = True
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(548, 9)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(28, 13)
		Me.Label22.TabIndex = 49
		Me.Label22.Text = "ID: *"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(582, 6)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(100, 20)
		Me.txtID.TabIndex = 48
		'
		'pbCasa
		'
		Me.pbCasa.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.pbCasa.Location = New System.Drawing.Point(6, 19)
		Me.pbCasa.Name = "pbCasa"
		Me.pbCasa.Size = New System.Drawing.Size(355, 206)
		Me.pbCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbCasa.TabIndex = 50
		Me.pbCasa.TabStop = False
		'
		'btnPesquisarCorretor
		'
		Me.btnPesquisarCorretor.Location = New System.Drawing.Point(215, 233)
		Me.btnPesquisarCorretor.Name = "btnPesquisarCorretor"
		Me.btnPesquisarCorretor.Size = New System.Drawing.Size(75, 23)
		Me.btnPesquisarCorretor.TabIndex = 53
		Me.btnPesquisarCorretor.Text = "Pesquisar"
		Me.btnPesquisarCorretor.UseVisualStyleBackColor = True
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(48, 237)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(54, 13)
		Me.Label24.TabIndex = 52
		Me.Label24.Text = "Corretor: *"
		'
		'txtCorretor
		'
		Me.txtCorretor.Location = New System.Drawing.Point(109, 235)
		Me.txtCorretor.Name = "txtCorretor"
		Me.txtCorretor.ReadOnly = True
		Me.txtCorretor.Size = New System.Drawing.Size(100, 20)
		Me.txtCorretor.TabIndex = 51
		'
		'btnSalvar
		'
		Me.btnSalvar.Location = New System.Drawing.Point(207, 231)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
		Me.btnSalvar.TabIndex = 54
		Me.btnSalvar.Text = "Salvar"
		Me.btnSalvar.UseVisualStyleBackColor = True
		'
		'btnLimpar
		'
		Me.btnLimpar.Location = New System.Drawing.Point(288, 231)
		Me.btnLimpar.Name = "btnLimpar"
		Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
		Me.btnLimpar.TabIndex = 55
		Me.btnLimpar.Text = "Limpar"
		Me.btnLimpar.UseVisualStyleBackColor = True
		'
		'cmbEstado
		'
		Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEstado.FormattingEnabled = True
		Me.cmbEstado.Items.AddRange(New Object() {"AC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AL" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AM" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "BA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "CE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "DF" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "ES" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "GO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MT" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MG" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PB" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PI" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RJ" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RN" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "TO"})
		Me.cmbEstado.Location = New System.Drawing.Point(91, 13)
		Me.cmbEstado.Name = "cmbEstado"
		Me.cmbEstado.Size = New System.Drawing.Size(100, 21)
		Me.cmbEstado.TabIndex = 56
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Location = New System.Drawing.Point(47, 174)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(42, 13)
		Me.Label25.TabIndex = 58
		Me.Label25.Text = "IPTU: *"
		'
		'txtIPTU
		'
		Me.txtIPTU.Location = New System.Drawing.Point(89, 167)
		Me.txtIPTU.Name = "txtIPTU"
		Me.txtIPTU.Size = New System.Drawing.Size(31, 20)
		Me.txtIPTU.TabIndex = 57
		'
		'txtFormaPagamento
		'
		Me.txtFormaPagamento.Location = New System.Drawing.Point(498, 28)
		Me.txtFormaPagamento.Multiline = True
		Me.txtFormaPagamento.Name = "txtFormaPagamento"
		Me.txtFormaPagamento.Size = New System.Drawing.Size(171, 111)
		Me.txtFormaPagamento.TabIndex = 43
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.txtQuartos)
		Me.GroupBox1.Controls.Add(Me.txtSuites)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.txtGaragem)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.txtSalas)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.txtBanheiro)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.txtAndar)
		Me.GroupBox1.Controls.Add(Me.Label17)
		Me.GroupBox1.Controls.Add(Me.Label23)
		Me.GroupBox1.Controls.Add(Me.txtCondominio)
		Me.GroupBox1.Controls.Add(Me.txtAreaTerreno)
		Me.GroupBox1.Controls.Add(Me.Label18)
		Me.GroupBox1.Controls.Add(Me.txtAreaConstruida)
		Me.GroupBox1.Controls.Add(Me.Label19)
		Me.GroupBox1.Location = New System.Drawing.Point(4, 136)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(633, 89)
		Me.GroupBox1.TabIndex = 59
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Medidas e cômodos"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label26)
		Me.GroupBox2.Controls.Add(Me.txtBairro)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.cmbEstado)
		Me.GroupBox2.Controls.Add(Me.txtCidade)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.txtEndereco)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.txtNumero)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.txtComplemento)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Location = New System.Drawing.Point(4, 33)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(633, 97)
		Me.GroupBox2.TabIndex = 60
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Localização"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(5, 69)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(77, 13)
		Me.Label26.TabIndex = 61
		Me.Label26.Text = "Complemento: "
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(44, 148)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(45, 13)
		Me.Label27.TabIndex = 61
		Me.Label27.Text = "Preço: *"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.GroupBox4)
		Me.GroupBox3.Controls.Add(Me.txtObs)
		Me.GroupBox3.Controls.Add(Me.Label25)
		Me.GroupBox3.Controls.Add(Me.txtIPTU)
		Me.GroupBox3.Controls.Add(Me.Label27)
		Me.GroupBox3.Controls.Add(Me.Label20)
		Me.GroupBox3.Controls.Add(Me.Label21)
		Me.GroupBox3.Controls.Add(Me.txtFormaPagamento)
		Me.GroupBox3.Controls.Add(Me.btnPesquisarProprietario)
		Me.GroupBox3.Controls.Add(Me.txtPreco)
		Me.GroupBox3.Controls.Add(Me.txtProprietario)
		Me.GroupBox3.Controls.Add(Me.Label11)
		Me.GroupBox3.Controls.Add(Me.btnPesquisarCorretor)
		Me.GroupBox3.Controls.Add(Me.txtCorretor)
		Me.GroupBox3.Controls.Add(Me.Label24)
		Me.GroupBox3.Location = New System.Drawing.Point(4, 231)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(705, 411)
		Me.GroupBox3.TabIndex = 62
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Outros"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.btnFoto)
		Me.GroupBox4.Controls.Add(Me.pbCasa)
		Me.GroupBox4.Controls.Add(Me.btnSalvar)
		Me.GroupBox4.Controls.Add(Me.btnLimpar)
		Me.GroupBox4.Location = New System.Drawing.Point(308, 145)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(391, 260)
		Me.GroupBox4.TabIndex = 62
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Foto do Imóvel"
		'
		'FrmImovel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(731, 650)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label22)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.cmbSubtipo)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.cmbTransacao)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmImovel"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de imóvel"
		CType(Me.pbCasa, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents cmbTransacao As ComboBox
	Friend WithEvents cmbTipo As ComboBox
	Friend WithEvents cmbSubtipo As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtCidade As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtBairro As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtEndereco As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtNumero As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtComplemento As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtPreco As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtProprietario As TextBox
	Friend WithEvents btnPesquisarProprietario As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents txtGaragem As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents txtSuites As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents txtQuartos As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents txtSalas As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents txtBanheiro As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents txtAndar As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents txtAreaTerreno As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents txtAreaConstruida As TextBox
	Friend WithEvents Label20 As Label
	Friend WithEvents txtObs As TextBox
	Friend WithEvents Label21 As Label
	Friend WithEvents Label23 As Label
	Friend WithEvents txtCondominio As TextBox
	Friend WithEvents btnFoto As Button
	Friend WithEvents Label22 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents pbCasa As PictureBox
	Friend WithEvents btnPesquisarCorretor As Button
	Friend WithEvents Label24 As Label
	Friend WithEvents txtCorretor As TextBox
	Friend WithEvents btnSalvar As Button
	Friend WithEvents btnLimpar As Button
	Friend WithEvents cmbEstado As ComboBox
	Friend WithEvents Label25 As Label
	Friend WithEvents txtIPTU As TextBox
	Friend WithEvents txtFormaPagamento As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label26 As Label
	Friend WithEvents Label27 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents GroupBox4 As GroupBox
End Class
