<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmCliente
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNome = New System.Windows.Forms.TextBox()
		Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.rdoFisica = New System.Windows.Forms.RadioButton()
		Me.rdoJuridica = New System.Windows.Forms.RadioButton()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtEndereco = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtCidade = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtBairro = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtNumero = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtCEP = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtNaturalidade = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtProfissao = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnLimpar = New System.Windows.Forms.Button()
		Me.cmbNacionalidade = New System.Windows.Forms.ComboBox()
		Me.cmbEstadoCivil = New System.Windows.Forms.ComboBox()
		Me.cmbEstado = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtRazaosocial = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.lblModo = New System.Windows.Forms.Label()
		Me.dtpNascimento = New System.Windows.Forms.DateTimePicker()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(45, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(45, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nome: *"
		'
		'txtNome
		'
		Me.txtNome.Location = New System.Drawing.Point(96, 18)
		Me.txtNome.Name = "txtNome"
		Me.txtNome.Size = New System.Drawing.Size(352, 20)
		Me.txtNome.TabIndex = 1
		'
		'txtCPF
		'
		Me.txtCPF.Enabled = False
		Me.txtCPF.Location = New System.Drawing.Point(96, 91)
		Me.txtCPF.Mask = "999.999.999-99"
		Me.txtCPF.Name = "txtCPF"
		Me.txtCPF.Size = New System.Drawing.Size(100, 20)
		Me.txtCPF.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(54, 94)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "CPF: *"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(1, 43)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Tipo de pessoa: *"
		'
		'rdoFisica
		'
		Me.rdoFisica.AutoSize = True
		Me.rdoFisica.Location = New System.Drawing.Point(96, 40)
		Me.rdoFisica.Name = "rdoFisica"
		Me.rdoFisica.Size = New System.Drawing.Size(54, 17)
		Me.rdoFisica.TabIndex = 5
		Me.rdoFisica.TabStop = True
		Me.rdoFisica.Text = "Física"
		Me.rdoFisica.UseVisualStyleBackColor = True
		'
		'rdoJuridica
		'
		Me.rdoJuridica.AutoSize = True
		Me.rdoJuridica.Location = New System.Drawing.Point(163, 41)
		Me.rdoJuridica.Name = "rdoJuridica"
		Me.rdoJuridica.Size = New System.Drawing.Size(63, 17)
		Me.rdoJuridica.TabIndex = 6
		Me.rdoJuridica.TabStop = True
		Me.rdoJuridica.Text = "Jurídica"
		Me.rdoJuridica.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(46, 123)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(44, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "CNPJ: *"
		'
		'txtCNPJ
		'
		Me.txtCNPJ.Enabled = False
		Me.txtCNPJ.Location = New System.Drawing.Point(96, 117)
		Me.txtCNPJ.Mask = "99.999.999/9999-99"
		Me.txtCNPJ.Name = "txtCNPJ"
		Me.txtCNPJ.Size = New System.Drawing.Size(112, 20)
		Me.txtCNPJ.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(6, 22)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(59, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Telefone: *"
		'
		'txtTelefone
		'
		Me.txtTelefone.Location = New System.Drawing.Point(61, 19)
		Me.txtTelefone.Mask = "(99)9999-9999"
		Me.txtTelefone.Name = "txtTelefone"
		Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
		Me.txtTelefone.TabIndex = 9
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(11, 44)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(49, 13)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Celular: *"
		'
		'txtCelular
		'
		Me.txtCelular.Location = New System.Drawing.Point(61, 41)
		Me.txtCelular.Mask = "(99)99999-9999"
		Me.txtCelular.Name = "txtCelular"
		Me.txtCelular.Size = New System.Drawing.Size(100, 20)
		Me.txtCelular.TabIndex = 11
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(61, 66)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(100, 20)
		Me.txtEmail.TabIndex = 14
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(18, 69)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(42, 13)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Email: *"
		'
		'txtEndereco
		'
		Me.txtEndereco.Location = New System.Drawing.Point(77, 22)
		Me.txtEndereco.Name = "txtEndereco"
		Me.txtEndereco.Size = New System.Drawing.Size(164, 20)
		Me.txtEndereco.TabIndex = 16
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(6, 29)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(63, 13)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Endereço: *"
		'
		'txtCidade
		'
		Me.txtCidade.Location = New System.Drawing.Point(77, 47)
		Me.txtCidade.Name = "txtCidade"
		Me.txtCidade.Size = New System.Drawing.Size(100, 20)
		Me.txtCidade.TabIndex = 18
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(19, 50)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(50, 13)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Cidade: *"
		'
		'txtBairro
		'
		Me.txtBairro.Location = New System.Drawing.Point(77, 72)
		Me.txtBairro.Name = "txtBairro"
		Me.txtBairro.Size = New System.Drawing.Size(100, 20)
		Me.txtBairro.TabIndex = 20
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(25, 75)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(44, 13)
		Me.Label10.TabIndex = 19
		Me.Label10.Text = "Bairro: *"
		'
		'txtNumero
		'
		Me.txtNumero.Location = New System.Drawing.Point(241, 73)
		Me.txtNumero.Name = "txtNumero"
		Me.txtNumero.Size = New System.Drawing.Size(100, 20)
		Me.txtNumero.TabIndex = 22
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(181, 74)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(54, 13)
		Me.Label11.TabIndex = 21
		Me.Label11.Text = "Número: *"
		'
		'txtCEP
		'
		Me.txtCEP.Location = New System.Drawing.Point(241, 48)
		Me.txtCEP.Name = "txtCEP"
		Me.txtCEP.Size = New System.Drawing.Size(100, 20)
		Me.txtCEP.TabIndex = 24
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(197, 50)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(38, 13)
		Me.Label12.TabIndex = 23
		Me.Label12.Text = "CEP: *"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(232, 68)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(85, 13)
		Me.Label13.TabIndex = 25
		Me.Label13.Text = "Nacionalidade: *"
		'
		'txtNaturalidade
		'
		Me.txtNaturalidade.Location = New System.Drawing.Point(316, 93)
		Me.txtNaturalidade.Name = "txtNaturalidade"
		Me.txtNaturalidade.Size = New System.Drawing.Size(121, 20)
		Me.txtNaturalidade.TabIndex = 28
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(232, 96)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(77, 13)
		Me.Label14.TabIndex = 27
		Me.Label14.Text = "Naturalidade: *"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(243, 142)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(71, 13)
		Me.Label15.TabIndex = 29
		Me.Label15.Text = "Estado civil: *"
		'
		'txtProfissao
		'
		Me.txtProfissao.Location = New System.Drawing.Point(96, 143)
		Me.txtProfissao.Name = "txtProfissao"
		Me.txtProfissao.Size = New System.Drawing.Size(121, 20)
		Me.txtProfissao.TabIndex = 32
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(30, 146)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(60, 13)
		Me.Label16.TabIndex = 31
		Me.Label16.Text = "Profissão: *"
		'
		'btnSalvar
		'
		Me.btnSalvar.Location = New System.Drawing.Point(16, 325)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
		Me.btnSalvar.TabIndex = 33
		Me.btnSalvar.Text = "Salvar"
		Me.btnSalvar.UseVisualStyleBackColor = True
		'
		'btnLimpar
		'
		Me.btnLimpar.Location = New System.Drawing.Point(101, 325)
		Me.btnLimpar.Name = "btnLimpar"
		Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
		Me.btnLimpar.TabIndex = 34
		Me.btnLimpar.Text = "Limpar"
		Me.btnLimpar.UseVisualStyleBackColor = True
		'
		'cmbNacionalidade
		'
		Me.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNacionalidade.FormattingEnabled = True
		Me.cmbNacionalidade.Items.AddRange(New Object() {"Afeganistão", "África do Sul", "Akrotiri", "Albânia", "Alemanha", "Andorra", "Angola", "Anguila", "Antárctida", "Antígua e Barbuda", "Antilhas Neerlandesas", "Arábia Saudita", "Arctic Ocean", "Argélia", "Argentina", "Arménia", "Aruba", "Ashmore and Cartier Islands", "Atlantic Ocean", "Austrália", "Áustria", "Azerbaijão", "Baamas", "Bangladeche", "Barbados", "Barém", "Bélgica", "Belize", "Benim", "Bermudas", "Bielorrússia", "Birmânia", "Bolívia", "Bósnia e Herzegovina", "Botsuana", "Brasil", "Brunei", "Bulgária", "Burquina Faso", "Burúndi", "Butão", "Cabo Verde", "Camarões", "Camboja", "Canadá", "Catar", "Cazaquistão", "Chade", "Chile", "China", "Chipre", "Clipperton Island", "Colômbia", "Comores", "Congo-Brazzaville", "Congo-Kinshasa", "Coral Sea Islands", "Coreia do Norte", "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia", "Cuba", "Dhekelia", "Dinamarca", "Domínica", "Egipto", "Emiratos Árabes Unidos", "Equador", "Eritreia", "Eslováquia", "Eslovénia", "Espanha", "Estados Unidos", "Estónia", "Etiópia", "Faroé", "Fiji", "Filipinas", "Finlândia", "França", "Gabão", "Gâmbia", "Gana", "Gaza Strip", "Geórgia", "Geórgia do Sul e Sandwich do Sul", "Gibraltar", "Granada", "Grécia", "Gronelândia", "Guame", "Guatemala", "Guernsey", "Guiana", "Guiné", "Guiné Equatorial", "Guiné-Bissau", "Haiti", "Honduras", "Hong Kong", "Hungria", "Iémen", "Ilha Bouvet", "Ilha do Natal", "Ilha Norfolk", "Ilhas Caimão", "Ilhas Cook", "Ilhas dos Cocos", "Ilhas Falkland", "Ilhas Heard e McDonald", "Ilhas Marshall", "Ilhas Salomão", "Ilhas Turcas e Caicos", "Ilhas Virgens Americanas", "Ilhas Virgens Britânicas", "Índia", "Indian Ocean", "Indonésia", "Irão", "Iraque", "Irlanda", "Islândia", "Israel", "Itália", "Jamaica", "Jan Mayen", "Japão", "Jersey", "Jibuti", "Jordânia", "Kuwait", "Laos", "Lesoto", "Letónia", "Líbano", "Libéria", "Líbia", "Listenstaine", "Lituânia", "Luxemburgo", "Macau", "Macedónia", "Madagáscar", "Malásia", "Malávi", "Maldivas", "Mali", "Malta", "Man, Isle of", "Marianas do Norte", "Marrocos", "Maurícia", "Mauritânia", "Mayotte", "México", "Micronésia", "Moçambique", "Moldávia", "Mónaco", "Mongólia", "Monserrate", "Montenegro", "Mundo", "Namíbia", "Nauru", "Navassa Island", "Nepal", "Nicarágua", "Níger", "Nigéria", "Niue", "Noruega", "Nova Caledónia", "Nova Zelândia", "Omã", "Pacific Ocean", "Países Baixos", "Palau", "Panamá", "Papua-Nova Guiné", "Paquistão", "Paracel Islands", "Paraguai", "Peru", "Pitcairn", "Polinésia Francesa", "Polónia", "Porto Rico", "Portugal", "Quénia", "Quirguizistão", "Quiribáti", "Reino Unido", "República Centro-Africana", "República Checa", "República Dominicana", "Roménia", "Ruanda", "Rússia", "Salvador", "Samoa", "Samoa Americana", "Santa Helena", "Santa Lúcia", "São Cristóvão e Neves", "São Marinho", "São Pedro e Miquelon", "São Tomé e Príncipe", "São Vicente e Granadinas", "Sara Ocidental", "Seicheles", "Senegal", "Serra Leoa", "Sérvia", "Singapura", "Síria", "Somália", "Southern Ocean", "Spratly Islands", "Sri Lanca", "Suazilândia", "Sudão", "Suécia", "Suíça", "Suriname", "Svalbard e Jan Mayen", "Tailândia", "Taiwan", "Tajiquistão", "Tanzânia", "Território Britânico do Oceano Índico", "Territórios Austrais Franceses", "Timor Leste", "Togo", "Tokelau", "Tonga", "Trindade e Tobago", "Tunísia", "Turquemenistão", "Turquia", "Tuvalu", "Ucrânia", "Uganda", "União Europeia", "Uruguai", "Usbequistão", "Vanuatu", "Vaticano", "Venezuela", "Vietname", "Wake Island", "Wallis e Futuna", "West Bank", "Zâmbia", "Zimbabué"})
		Me.cmbNacionalidade.Location = New System.Drawing.Point(316, 68)
		Me.cmbNacionalidade.Name = "cmbNacionalidade"
		Me.cmbNacionalidade.Size = New System.Drawing.Size(121, 21)
		Me.cmbNacionalidade.TabIndex = 35
		'
		'cmbEstadoCivil
		'
		Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEstadoCivil.FormattingEnabled = True
		Me.cmbEstadoCivil.Items.AddRange(New Object() {"Casado", "Divorciado", "Separado", "Solteiro", "União Estável", "Viúvo"})
		Me.cmbEstadoCivil.Location = New System.Drawing.Point(327, 142)
		Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
		Me.cmbEstadoCivil.Size = New System.Drawing.Size(121, 21)
		Me.cmbEstadoCivil.TabIndex = 36
		'
		'cmbEstado
		'
		Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEstado.FormattingEnabled = True
		Me.cmbEstado.Items.AddRange(New Object() {"AC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AL" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "AM" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "BA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "CE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "DF" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "ES" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "GO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MT" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "MG" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PA" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PB" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "PI" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RJ" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RN" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RS" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RO" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "RR" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SC" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SP" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "SE" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "TO"})
		Me.cmbEstado.Location = New System.Drawing.Point(302, 22)
		Me.cmbEstado.Name = "cmbEstado"
		Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
		Me.cmbEstado.TabIndex = 38
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(250, 25)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(56, 13)
		Me.Label17.TabIndex = 37
		Me.Label17.Text = "Estado: *  "
		'
		'txtRazaosocial
		'
		Me.txtRazaosocial.Enabled = False
		Me.txtRazaosocial.Location = New System.Drawing.Point(96, 65)
		Me.txtRazaosocial.Name = "txtRazaosocial"
		Me.txtRazaosocial.Size = New System.Drawing.Size(100, 20)
		Me.txtRazaosocial.TabIndex = 40
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(11, 68)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(80, 13)
		Me.Label18.TabIndex = 39
		Me.Label18.Text = "Razão Social: *"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(21, 18)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(121, 20)
		Me.txtID.TabIndex = 42
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(3, 21)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(19, 13)
		Me.Label19.TabIndex = 41
		Me.Label19.Text = "Id:"
		'
		'cmbTipo
		'
		Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipo.FormattingEnabled = True
		Me.cmbTipo.Items.AddRange(New Object() {"Fiador", "Inquilino", "Locatário", "Proprietário"})
		Me.cmbTipo.Location = New System.Drawing.Point(276, 40)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(133, 21)
		Me.cmbTipo.TabIndex = 44
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(232, 44)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(38, 13)
		Me.Label20.TabIndex = 43
		Me.Label20.Text = "Tipo: *"
		'
		'lblModo
		'
		Me.lblModo.AutoSize = True
		Me.lblModo.Location = New System.Drawing.Point(15, 352)
		Me.lblModo.Name = "lblModo"
		Me.lblModo.Size = New System.Drawing.Size(92, 13)
		Me.lblModo.TabIndex = 45
		Me.lblModo.Text = "Modo de inserção"
		'
		'dtpNascimento
		'
		Me.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpNascimento.Location = New System.Drawing.Point(333, 114)
		Me.dtpNascimento.Name = "dtpNascimento"
		Me.dtpNascimento.Size = New System.Drawing.Size(121, 20)
		Me.dtpNascimento.TabIndex = 46
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(220, 120)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(114, 13)
		Me.Label21.TabIndex = 47
		Me.Label21.Text = "Data de Nascimento: *"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtNome)
		Me.GroupBox1.Controls.Add(Me.txtCPF)
		Me.GroupBox1.Controls.Add(Me.Label21)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dtpNascimento)
		Me.GroupBox1.Controls.Add(Me.cmbTipo)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.cmbEstadoCivil)
		Me.GroupBox1.Controls.Add(Me.Label20)
		Me.GroupBox1.Controls.Add(Me.rdoFisica)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.rdoJuridica)
		Me.GroupBox1.Controls.Add(Me.txtProfissao)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.txtCNPJ)
		Me.GroupBox1.Controls.Add(Me.txtRazaosocial)
		Me.GroupBox1.Controls.Add(Me.cmbNacionalidade)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label18)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.txtNaturalidade)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(460, 169)
		Me.GroupBox1.TabIndex = 48
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Informações de pessoa"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtTelefone)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.txtCelular)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.txtEmail)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 219)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(178, 100)
		Me.GroupBox2.TabIndex = 49
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Contato"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.txtEndereco)
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Controls.Add(Me.Label9)
		Me.GroupBox3.Controls.Add(Me.txtCidade)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.txtBairro)
		Me.GroupBox3.Controls.Add(Me.cmbEstado)
		Me.GroupBox3.Controls.Add(Me.Label17)
		Me.GroupBox3.Controls.Add(Me.Label11)
		Me.GroupBox3.Controls.Add(Me.txtNumero)
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.txtCEP)
		Me.GroupBox3.Location = New System.Drawing.Point(196, 219)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(436, 100)
		Me.GroupBox3.TabIndex = 50
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Dados de endereço"
		'
		'FrmCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(642, 370)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.lblModo)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.btnLimpar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmCliente"
		Me.Text = "Cadastro de Cliente"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtNome As TextBox
	Friend WithEvents txtCPF As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents rdoFisica As RadioButton
	Friend WithEvents rdoJuridica As RadioButton
	Friend WithEvents Label4 As Label
	Friend WithEvents txtCNPJ As MaskedTextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtTelefone As MaskedTextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtCelular As MaskedTextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtEndereco As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtCidade As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtBairro As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtNumero As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtCEP As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents txtNaturalidade As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents txtProfissao As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents btnSalvar As Button
	Friend WithEvents btnLimpar As Button
	Friend WithEvents cmbNacionalidade As ComboBox
	Friend WithEvents cmbEstadoCivil As ComboBox
	Friend WithEvents cmbEstado As ComboBox
	Friend WithEvents Label17 As Label
	Friend WithEvents txtRazaosocial As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents cmbTipo As ComboBox
	Friend WithEvents Label20 As Label
	Friend WithEvents lblModo As Label
	Friend WithEvents dtpNascimento As DateTimePicker
	Friend WithEvents Label21 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox3 As GroupBox
End Class
