Partial Public Class Cliente
	Private _id_cliente As Integer
	Public Property Id_cliente() As Integer
		Get
			Return _id_cliente
		End Get
		Set(ByVal value As Integer)
			_id_cliente = value
		End Set
	End Property

	Private _nome As String
	Public Property Nome() As String
		Get
			Return _nome
		End Get
		Set(ByVal value As String)
			_nome = value
		End Set
	End Property

	Private _datanascimento As Date
	Public Property datanascimento() As Date
		Get
			Return _datanascimento
		End Get
		Set(ByVal value As Date)
			_datanascimento = value
		End Set
	End Property

	Private _tipo As String
	Public Property tipo() As String
		Get
			Return _tipo
		End Get
		Set(ByVal value As String)
			_tipo = value
		End Set
	End Property

	Private _cpf As String
	Public Property cpf() As String
		Get
			Return _cpf
		End Get
		Set(ByVal value As String)
			_cpf = value
		End Set
	End Property

	Private _tipopessoa As String
	Public Property tipopessoa() As String
		Get
			Return _tipopessoa
		End Get
		Set(ByVal value As String)
			_tipopessoa = value
		End Set
	End Property

	Private _cnpj As String
	Public Property cnpj() As String
		Get
			Return _cnpj
		End Get
		Set(ByVal value As String)
			_cnpj = value
		End Set
	End Property

	Private _razaosocial As String
	Public Property razaosocial() As String
		Get
			Return _razaosocial
		End Get
		Set(ByVal value As String)
			_razaosocial = value
		End Set
	End Property

	Private _telefone As String
	Public Property telefone() As String
		Get
			Return _telefone
		End Get
		Set(ByVal value As String)
			_telefone = value
		End Set
	End Property

	Private _celular As String
	Public Property celular() As String
		Get
			Return _celular
		End Get
		Set(ByVal value As String)
			_celular = value
		End Set
	End Property

	Private _email As String
	Public Property email() As String
		Get
			Return _email
		End Get
		Set(ByVal value As String)
			_email = value
		End Set
	End Property

	Private _endereco As String
	Public Property endereco() As String
		Get
			Return _endereco
		End Get
		Set(ByVal value As String)
			_endereco = value
		End Set
	End Property

	Private _cidade As String
	Public Property cidade() As String
		Get
			Return _cidade
		End Get
		Set(ByVal value As String)
			_cidade = value
		End Set
	End Property

	Private _bairro As String
	Public Property bairro() As String
		Get
			Return _bairro
		End Get
		Set(ByVal value As String)
			_bairro = value
		End Set
	End Property

	Private _estado As String
	Public Property Estado() As String
		Get
			Return _estado
		End Get
		Set(ByVal value As String)
			_estado = value
		End Set
	End Property

	Private _numero As String
	Public Property numero() As String
		Get
			Return _numero
		End Get
		Set(ByVal value As String)
			_numero = value
		End Set
	End Property

	Private _cep As String
	Public Property cep() As String
		Get
			Return _cep
		End Get
		Set(ByVal value As String)
			_cep = value
		End Set
	End Property

	Private _nacionalidade As String
	Public Property nacionalidade() As String
		Get
			Return _nacionalidade
		End Get
		Set(ByVal value As String)
			_nacionalidade = value
		End Set
	End Property

	Private _naturalidade As String
	Public Property naturalidade() As String
		Get
			Return _naturalidade
		End Get
		Set(ByVal value As String)
			_naturalidade = value
		End Set
	End Property

	Private _estadocivil As String
	Public Property estadocivil() As String
		Get
			Return _estadocivil
		End Get
		Set(ByVal value As String)
			_estadocivil = value
		End Set
	End Property

	Private _profissao As String
	Public Property profissao() As String
		Get
			Return _profissao
		End Get
		Set(ByVal value As String)
			_profissao = value
		End Set
	End Property


End Class
