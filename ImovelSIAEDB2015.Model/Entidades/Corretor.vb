Partial Public Class Corretor
	Private _id_corretor As Integer
	Public Property id_corretor() As Integer
		Get
			Return _id_corretor
		End Get
		Set(ByVal value As Integer)
			_id_corretor = value
		End Set
	End Property
	Private _nome As String
	Public Property nome() As String
		Get
			Return _nome
		End Get
		Set(ByVal value As String)
			_nome = value
		End Set
	End Property
	Private _rg As String
	Public Property rg() As String
		Get
			Return _rg
		End Get
		Set(ByVal value As String)
			_rg = value
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
	Private _bairro As String
	Public Property bairro() As String
		Get
			Return _bairro
		End Get
		Set(ByVal value As String)
			_bairro = value
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
	Private _estado As String
	Public Property estado() As String
		Get
			Return _estado
		End Get
		Set(ByVal value As String)
			_estado = value
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
	Private _email As String
	Public Property email() As String
		Get
			Return _email
		End Get
		Set(ByVal value As String)
			_email = value
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
End Class
