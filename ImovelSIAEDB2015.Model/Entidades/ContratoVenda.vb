Partial Public Class ContratoVenda
	Private _id_contrato_venda As Integer
	Public Property id_contrato_venda() As Integer
		Get
			Return _id_contrato_venda
		End Get
		Set(ByVal value As Integer)
			_id_contrato_venda = value
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
	Private _nometestemunha1 As String
	Public Property nometestemunha1() As String
		Get
			Return _nometestemunha1
		End Get
		Set(ByVal value As String)
			_nometestemunha1 = value
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
	Private _nometestemunha2 As String
	Public Property nometestemunha2() As String
		Get
			Return _nometestemunha2
		End Get
		Set(ByVal value As String)
			_nometestemunha2 = value
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
	Private _parcelamentomeses As Integer
	Public Property parcelamentomeses() As Integer
		Get
			Return _parcelamentomeses
		End Get
		Set(ByVal value As Integer)
			_parcelamentomeses = value
		End Set
	End Property
	Private _taxajuros As Single
	Public Property taxajuros() As Single
		Get
			Return _taxajuros
		End Get
		Set(ByVal value As Single)
			_taxajuros = value
		End Set
	End Property
	Private _vencimentoparcela As Integer
	Public Property vencimentoparcela() As Integer
		Get
			Return _vencimentoparcela
		End Get
		Set(ByVal value As Integer)
			_vencimentoparcela = value
		End Set
	End Property
	Private _pagamentotododia As String
	Public Property pagamentotododia() As String
		Get
			Return _pagamentotododia
		End Get
		Set(ByVal value As String)
			_pagamentotododia = value
		End Set
	End Property
	Private _valorimovel As Single
	Public Property valorimovel() As Single
		Get
			Return _valorimovel
		End Get
		Set(ByVal value As Single)
			_valorimovel = value
		End Set
	End Property
	Private _valorvenda As Single
	Public Property valorvenda() As Single
		Get
			Return _valorvenda
		End Get
		Set(ByVal value As Single)
			_valorvenda = value
		End Set
	End Property
	Private _valorentrada As Single
	Public Property valorentrada() As Single
		Get
			Return _valorentrada
		End Get
		Set(ByVal value As Single)
			_valorentrada = value
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
	Private _proprietario As String
	Public Property proprietario() As String
		Get
			Return _proprietario
		End Get
		Set(ByVal value As String)
			_proprietario = value
		End Set
	End Property
	Private _imovel As String
	Public Property imovel() As String
		Get
			Return _imovel
		End Get
		Set(ByVal value As String)
			_imovel = value
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
	Private _id_fiador2 As Integer
	Public Property id_fiador2() As Integer
		Get
			Return _id_fiador2
		End Get
		Set(ByVal value As Integer)
			_id_fiador2 = value
		End Set
	End Property
	Private _id_comprador As Integer
	Public Property id_comprador() As Integer
		Get
			Return _id_comprador
		End Get
		Set(ByVal value As Integer)
			_id_comprador = value
		End Set
	End Property
	Private _comprador As String
	Public Property comprador() As String
		Get
			Return _comprador
		End Get
		Set(ByVal value As String)
			_comprador = value
		End Set
	End Property
	Private _multaatraso As Single
	Public Property multaatraso() As Single
		Get
			Return _multaatraso
		End Get
		Set(ByVal value As Single)
			_multaatraso = value
		End Set
	End Property
	Private _jurosmora As Single
	Public Property jurosmora() As Single
		Get
			Return _jurosmora
		End Get
		Set(ByVal value As Single)
			_jurosmora = value
		End Set
	End Property
	Private _honorarios As Single
	Public Property honorarios() As Single
		Get
			Return _honorarios
		End Get
		Set(ByVal value As Single)
			_honorarios = value
		End Set
	End Property
	Private _indicereajuste As String
	Public Property indicereajuste() As String
		Get
			Return _indicereajuste
		End Get
		Set(ByVal value As String)
			_indicereajuste = value
		End Set
	End Property
	Private _reajustedias As Integer
	Public Property reajustedias() As Integer
		Get
			Return _reajustedias
		End Get
		Set(ByVal value As Integer)
			_reajustedias = value
		End Set
	End Property
	Private _multaatrasodias As Integer
	Public Property multaatrasodias() As Integer
		Get
			Return _multaatrasodias
		End Get
		Set(ByVal value As Integer)
			_multaatrasodias = value
		End Set
	End Property
	Private _jurosmoradias As Integer
	Public Property jurosmoradias() As Integer
		Get
			Return _jurosmoradias
		End Get
		Set(ByVal value As Integer)
			_jurosmoradias = value
		End Set
	End Property
	Private _taxaadministrativa As Single
	Public Property taxaadministrativa() As Single
		Get
			Return _taxaadministrativa
		End Get
		Set(ByVal value As Single)
			_taxaadministrativa = value
		End Set
	End Property
	Private _id_captador1 As Integer
	Public Property id_captador1() As Integer
		Get
			Return _id_captador1
		End Get
		Set(ByVal value As Integer)
			_id_captador1 = value
		End Set
	End Property
	Private _id_captador2 As Integer
	Public Property id_captador2() As Integer
		Get
			Return _id_captador2
		End Get
		Set(ByVal value As Integer)
			_id_captador2 = value
		End Set
	End Property
	Private _nomecaptador1 As String
	Public Property nomecaptador1() As String
		Get
			Return _nomecaptador1
		End Get
		Set(ByVal value As String)
			_nomecaptador1 = value
		End Set
	End Property
	Private _nomecaptador2 As String
	Public Property nomecaptador2() As String
		Get
			Return _nomecaptador2
		End Get
		Set(ByVal value As String)
			_nomecaptador2 = value
		End Set
	End Property
	Private _outrasdespesas As Single
	Public Property outrasdespesas() As Single
		Get
			Return _outrasdespesas
		End Get
		Set(ByVal value As Single)
			_outrasdespesas = value
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
	Private _iniciocobranca As Date
	Public Property iniciocobranca() As Date
		Get
			Return _iniciocobranca
		End Get
		Set(ByVal value As Date)
			_iniciocobranca = value
		End Set
	End Property
End Class
