Partial Public Class ContratoAluguel
	Private _id_contrato_aluguel As Integer
	Public Property id_contrato_aluguel() As Integer
		Get
			Return _id_contrato_aluguel
		End Get
		Set(ByVal value As Integer)
			_id_contrato_aluguel = value
		End Set
	End Property
	Private _datacontrato As Date
	Public Property datacontrato() As Date
		Get
			Return _datacontrato
		End Get
		Set(ByVal value As Date)
			_datacontrato = value
		End Set
	End Property
	Private _dataencerramentocontrato As Date
	Public Property dataencerramentocontrato() As Date
		Get
			Return _dataencerramentocontrato
		End Get
		Set(ByVal value As Date)
			_dataencerramentocontrato = value
		End Set
	End Property
	Private _vencimentoparcelas As Integer
	Public Property vencimentoparcelas() As Integer
		Get
			Return _vencimentoparcelas
		End Get
		Set(ByVal value As Integer)
			_vencimentoparcelas = value
		End Set
	End Property
	Private _iniciocobranca As Date
	Public Property iniciocobranca() As Date
		Get
			Return _iniciocobranca
		End Get
		Set(ByVal value As Date)
			_iniciocobranca = value
		End Set
	End Property
	Private _nometestemunha1 As String
	Public Property nometestemunha1() As String
		Get
			Return _nometestemunha1
		End Get
		Set(ByVal value As String)
			_nometestemunha1 = value
		End Set
	End Property
	Private _nometestemunha2 As String
	Public Property nometestemunha2() As String
		Get
			Return _nometestemunha2
		End Get
		Set(ByVal value As String)
			_nometestemunha2 = value
		End Set
	End Property
	Private _cpftestemunha1 As String
	Public Property cpftestemunha1() As String
		Get
			Return _cpftestemunha1
		End Get
		Set(ByVal value As String)
			_cpftestemunha1 = value
		End Set
	End Property
	Private _cpftestemunha2 As String
	Public Property cpftestemunha2() As String
		Get
			Return _cpftestemunha2
		End Get
		Set(ByVal value As String)
			_cpftestemunha2 = value
		End Set
	End Property
	Private _nomefiador1 As String
	Public Property nomefiador1() As String
		Get
			Return _nomefiador1
		End Get
		Set(ByVal value As String)
			_nomefiador1 = value
		End Set
	End Property
	Private _id_fiador1 As Integer
	Public Property id_fiador1() As Integer
		Get
			Return _id_fiador1
		End Get
		Set(ByVal value As Integer)
			_id_fiador1 = value
		End Set
	End Property
	Private _nomefiador2 As String
	Public Property nomefiador2() As String
		Get
			Return _nomefiador2
		End Get
		Set(ByVal value As String)
			_nomefiador2 = value
		End Set
	End Property
	Private _id_fiador2 As Integer
	Public Property id_fiador2() As Integer
		Get
			Return _id_fiador2
		End Get
		Set(ByVal value As Integer)
			_id_fiador2 = value
		End Set
	End Property
	Private _valoraluguel As Single
	Public Property valoraluguel() As Single
		Get
			Return _valoraluguel
		End Get
		Set(ByVal value As Single)
			_valoraluguel = value
		End Set
	End Property
	Private _porcentagem_multa_atraso As Integer
	Public Property porcentagem_multa_atraso() As Integer
		Get
			Return _porcentagem_multa_atraso
		End Get
		Set(ByVal value As Integer)
			_porcentagem_multa_atraso = value
		End Set
	End Property
	Private _dias_multa_atraso As Integer
	Public Property dias_multa_atraso() As Integer
		Get
			Return _dias_multa_atraso
		End Get
		Set(ByVal value As Integer)
			_dias_multa_atraso = value
		End Set
	End Property
	Private _porcentagem_juros_mora As Integer
	Public Property porcentagem_juros_mora() As Integer
		Get
			Return _porcentagem_juros_mora
		End Get
		Set(ByVal value As Integer)
			_porcentagem_juros_mora = value
		End Set
	End Property
	Private _dias_juros_mora As Integer
	Public Property dias_juros_mora() As Integer
		Get
			Return _dias_juros_mora
		End Get
		Set(ByVal value As Integer)
			_dias_juros_mora = value
		End Set
	End Property
	Private _porcentagem_honorario As Integer
	Public Property porcentagem_honorario() As Integer
		Get
			Return _porcentagem_honorario
		End Get
		Set(ByVal value As Integer)
			_porcentagem_honorario = value
		End Set
	End Property
	Private _dias_honorario As Integer
	Public Property dias_honorario() As Integer
		Get
			Return _dias_honorario
		End Get
		Set(ByVal value As Integer)
			_dias_honorario = value
		End Set
	End Property
	Private _porcentagem_desconto As Integer
	Public Property porcentagem_desconto() As Integer
		Get
			Return _porcentagem_desconto
		End Get
		Set(ByVal value As Integer)
			_porcentagem_desconto = value
		End Set
	End Property
	Private _dias_desconto As Integer
	Public Property dias_desconto() As Integer
		Get
			Return _dias_desconto
		End Get
		Set(ByVal value As Integer)
			_dias_desconto = value
		End Set
	End Property
	Private _observacoes As String
	Public Property observacoes() As String
		Get
			Return _observacoes
		End Get
		Set(ByVal value As String)
			_observacoes = value
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
	Private _id_proprietario As Integer
	Public Property id_proprietario() As Integer
		Get
			Return _id_proprietario
		End Get
		Set(ByVal value As Integer)
			_id_proprietario = value
		End Set
	End Property
	Private _id_imovel As Integer
	Public Property id_imovel() As Integer
		Get
			Return _id_imovel
		End Get
		Set(ByVal value As Integer)
			_id_imovel = value
		End Set
	End Property
	Private _tipo_imovel As String
	Public Property tipo_imovel() As String
		Get
			Return _tipo_imovel
		End Get
		Set(ByVal value As String)
			_tipo_imovel = value
		End Set
	End Property
	Private _inquilino1 As String
	Public Property inquilino1() As String
		Get
			Return _inquilino1
		End Get
		Set(ByVal value As String)
			_inquilino1 = value
		End Set
	End Property
	Private _id_inquilino1 As Integer
	Public Property id_inquilino1() As Integer
		Get
			Return _id_inquilino1
		End Get
		Set(ByVal value As Integer)
			_id_inquilino1 = value
		End Set
	End Property
	Private _inquilino2 As String
	Public Property inquilino2() As String
		Get
			Return _inquilino2
		End Get
		Set(ByVal value As String)
			_inquilino2 = value
		End Set
	End Property
	Private _id_inquilino2 As Integer
	Public Property id_inquilino2() As Integer
		Get
			Return _id_inquilino2
		End Get
		Set(ByVal value As Integer)
			_id_inquilino2 = value
		End Set
	End Property
	Private _situacao As String
	Public Property situacao() As String
		Get
			Return _situacao
		End Get
		Set(ByVal value As String)
			_situacao = value
		End Set
	End Property
End Class
