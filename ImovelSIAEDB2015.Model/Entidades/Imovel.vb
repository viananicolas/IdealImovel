Partial Public Class Imovel
	Private _id_imovel As Integer
	Public Property id_imovel() As Integer
		Get
			Return _id_imovel
		End Get
		Set(ByVal value As Integer)
			_id_imovel = value
		End Set
	End Property
	Private _id_corretor As Integer
	Public Property id_corretor() As Integer
		Get
			Return _id_corretor
		End Get
		Set(ByVal value As Integer)
			_id_corretor = value
		End Set
	End Property
	Private _transacao As String
	Public Property transacao() As String
		Get
			Return _transacao
		End Get
		Set(ByVal value As String)
			_transacao = value
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
	Private _subtipo As String
	Public Property subtipo() As String
		Get
			Return _subtipo
		End Get
		Set(ByVal value As String)
			_subtipo = value
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
	Private _quartos As String
	Public Property quartos() As String
		Get
			Return _quartos
		End Get
		Set(ByVal value As String)
			_quartos = value
		End Set
	End Property
	Private _salas As String
	Public Property salas() As String
		Get
			Return _salas
		End Get
		Set(ByVal value As String)
			_salas = value
		End Set
	End Property
	Private _estado As String
	Public Property estado() As String
		Get
			Return _estado
		End Get
		Set(ByVal value As String)
			_estado = value
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
	Private _numero As String
	Public Property numero() As String
		Get
			Return _numero
		End Get
		Set(ByVal value As String)
			_numero = value
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
	Private _complemento As String
	Public Property complemento() As String
		Get
			Return _complemento
		End Get
		Set(ByVal value As String)
			_complemento = value
		End Set
	End Property
	Private _preco As Single
	Public Property preco() As Single
		Get
			Return _preco
		End Get
		Set(ByVal value As Single)
			_preco = value
		End Set
	End Property
	Private _id_cliente As Integer
	Public Property id_cliente() As Integer
		Get
			Return _id_cliente
		End Get
		Set(ByVal value As Integer)
			_id_cliente = value
		End Set
	End Property
	Private _suite As String
	Public Property suite() As String
		Get
			Return _suite
		End Get
		Set(ByVal value As String)
			_suite = value
		End Set
	End Property
	Private _garagem As String
	Public Property garagem() As String
		Get
			Return _garagem
		End Get
		Set(ByVal value As String)
			_garagem = value
		End Set
	End Property
	Private _banheiro As String
	Public Property banheiro() As String
		Get
			Return _banheiro
		End Get
		Set(ByVal value As String)
			_banheiro = value
		End Set
	End Property
	Private _andar As String
	Public Property andar() As String
		Get
			Return _andar
		End Get
		Set(ByVal value As String)
			_andar = value
		End Set
	End Property
	Private _iptu As Single
	Public Property iptu() As Single
		Get
			Return _iptu
		End Get
		Set(ByVal value As Single)
			_iptu = value
		End Set
	End Property
	Private _areaconstruida As Single
	Public Property areaconstruida() As Single
		Get
			Return _areaconstruida
		End Get
		Set(ByVal value As Single)
			_areaconstruida = value
		End Set
	End Property
	Private _areaterreno As Single
	Public Property areaterreno() As Single
		Get
			Return _areaterreno
		End Get
		Set(ByVal value As Single)
			_areaterreno = value
		End Set
	End Property
	Private _foto As Byte()
	Public Property foto() As Byte()
		Get
			Return _foto
		End Get
		Set(ByVal value As Byte())
			_foto = value
		End Set
	End Property
	Private _observacao As String
	Public Property observacao() As String
		Get
			Return _observacao
		End Get
		Set(ByVal value As String)
			_observacao = value
		End Set
	End Property
	Private _fotoname As String
	Public Property fotoname() As String
		Get
			Return _fotoname
		End Get
		Set(ByVal value As String)
			_fotoname = value
		End Set
	End Property

	Private _corretor As String
	Public Property corretor() As String
		Get
			Return _corretor
		End Get
		Set(ByVal value As String)
			_corretor = value
		End Set
	End Property
	Private _proprietario As String
	Public Property proprietario() As String
		Get
			Return _proprietario
		End Get
		Set(ByVal value As String)
			_proprietario = value
		End Set
	End Property

	Private _condominio As String
	Public Property condominio() As String
		Get
			Return _condominio
		End Get
		Set(ByVal value As String)
			_condominio = value
		End Set
	End Property

	Private _formapagamento As String
	Public Property formapagamento() As String
		Get
			Return _formapagamento
		End Get
		Set(ByVal value As String)
			_formapagamento = value
		End Set
	End Property
End Class
