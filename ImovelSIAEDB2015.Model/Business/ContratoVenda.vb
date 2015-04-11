Imports System.Data.SqlClient
Partial Public Class ContratoVenda
	Public Shared Sub InserirContratoVenda(ByVal oContratoVenda As ContratoVenda)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "
INSERT INTO ContratoVenda
           ([id_imovel]
           ,[nometestemunha1]
           ,[cpftestemunha1]
           ,[nometestemunha2]
           ,[cpftestemunha2]
           ,[parcelamentomeses]
           ,[taxajuros]
           ,[vencimentoparcela]
           ,[pagamentotododia]
           ,[valorimovel]
           ,[valorvenda]
           ,[valorentrada]
           ,[id_proprietario]
           ,[proprietario]
           ,[imovel]
           ,[id_fiador1]
           ,[id_fiador2]
           ,[id_comprador]
           ,[multaatraso]
           ,[jurosmora]
           ,[honorarios]
           ,[indicereajuste]
           ,[reajustedias]
           ,[multaatrasodias]
           ,[jurosmoradias]
           ,[taxaadministrativa]
           ,[id_captador1]
           ,[id_captador2]
           ,[nomecaptador1]
           ,[nomecaptador2]

           ,[OutrasDespesas]
  ,[datacontrato]
           ,[iniciocobranca]
,[comprador])
     VALUES
           (@id_imovel
           ,@nometestemunha1
           ,@cpftestemunha1
           ,@nometestemunha2
           ,@cpftestemunha2
           ,@parcelamentomeses
           ,@taxajuros
           ,@vencimentoparcela
           ,@pagamentotododia
           ,@valorimovel
           ,@valorvenda
           ,@valorentrada
           ,@id_proprietario
           ,@proprietario
           ,@imovel
           ,@id_fiador1
           ,@id_fiador2
           ,@id_comprador
           ,@multaatraso
           ,@jurosmora
           ,@honorarios
           ,@indicereajuste
           ,@reajustedias
           ,@multaatrasodias
           ,@jurosmoradias
           ,@taxaadministrativa
           ,@id_captador1
           ,@id_captador2
           ,@nomecaptador1
           ,@nomecaptador2
           ,@OutrasDespesas
,@datacontrato
,@iniciocobranca
,@comprador)"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@id_imovel", oContratoVenda.id_imovel)
		oComando.Parameters.AddWithValue("@nometestemunha1", oContratoVenda.nometestemunha1)
		oComando.Parameters.AddWithValue("@cpftestemunha1", oContratoVenda.cpftestemunha1)
		oComando.Parameters.AddWithValue("@nometestemunha2", oContratoVenda.nometestemunha2)
		oComando.Parameters.AddWithValue("@cpftestemunha2", oContratoVenda.cpftestemunha2)
		oComando.Parameters.AddWithValue("@parcelamentomeses", oContratoVenda.parcelamentomeses)
		oComando.Parameters.AddWithValue("@taxajuros", oContratoVenda.taxajuros)
		oComando.Parameters.AddWithValue("@vencimentoparcela", oContratoVenda.vencimentoparcela)
		oComando.Parameters.AddWithValue("@pagamentotododia", oContratoVenda.pagamentotododia)
		oComando.Parameters.AddWithValue("@valorimovel", oContratoVenda.valorimovel)
		oComando.Parameters.AddWithValue("@valorvenda", oContratoVenda.valorvenda)
		oComando.Parameters.AddWithValue("@valorentrada", oContratoVenda.valorentrada)
		oComando.Parameters.AddWithValue("@id_proprietario", oContratoVenda.id_proprietario)
		oComando.Parameters.AddWithValue("@proprietario", oContratoVenda.proprietario)
		oComando.Parameters.AddWithValue("@imovel", oContratoVenda.imovel)
		oComando.Parameters.AddWithValue("@id_fiador1", oContratoVenda.id_fiador1)
		oComando.Parameters.AddWithValue("@id_fiador2", oContratoVenda.id_fiador2)
		oComando.Parameters.AddWithValue("@id_comprador", oContratoVenda.id_comprador)
		oComando.Parameters.AddWithValue("@multaatraso", oContratoVenda.multaatraso)
		oComando.Parameters.AddWithValue("@jurosmora", oContratoVenda.jurosmora)
		oComando.Parameters.AddWithValue("@honorarios", oContratoVenda.honorarios)
		oComando.Parameters.AddWithValue("@indicereajuste", oContratoVenda.indicereajuste)
		oComando.Parameters.AddWithValue("@reajustedias", oContratoVenda.reajustedias)
		oComando.Parameters.AddWithValue("@multaatrasodias", oContratoVenda.multaatrasodias)
		oComando.Parameters.AddWithValue("@jurosmoradias", oContratoVenda.jurosmoradias)
		oComando.Parameters.AddWithValue("@taxaadministrativa", oContratoVenda.taxaadministrativa)
		oComando.Parameters.AddWithValue("@id_captador1", oContratoVenda.id_captador1)
		oComando.Parameters.AddWithValue("@id_captador2", oContratoVenda.id_captador2)
		oComando.Parameters.AddWithValue("@nomecaptador1", oContratoVenda.nomecaptador1)
		oComando.Parameters.AddWithValue("@nomecaptador2", oContratoVenda.nomecaptador2)
		oComando.Parameters.AddWithValue("@comprador", oContratoVenda.comprador)
		oComando.Parameters.AddWithValue("@OutrasDespesas", oContratoVenda.outrasdespesas)
		oComando.Parameters.AddWithValue("@datacontrato", oContratoVenda.datacontrato)
		oComando.Parameters.AddWithValue("@iniciocobranca", oContratoVenda.iniciocobranca)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
		'oContrato.datacontrato = dtpDataContrato.Value
		'oContrato.iniciocobranca = dtpInicioCobranca.Value
	End Sub
	Public Shared Sub AlterarContratoVenda(ByVal oContratoVenda As ContratoVenda)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "UPDATE ContratoVenda
   SET [id_imovel] = @id_imovel
      ,[nometestemunha1] = @nometestemunha1
      ,[cpftestemunha1] = @cpftestemunha1
      ,[nometestemunha2] = @nometestemunha2
      ,[cpftestemunha2] = @cpftestemunha2
      ,[parcelamentomeses] = @parcelamentomeses
      ,[taxajuros] = @taxajuros
      ,[vencimentoparcela] = @vencimentoparcela
      ,[pagamentotododia] = @pagamentotododia
      ,[valorimovel] = @valorimovel
      ,[valorvenda] = @valorvenda
      ,[valorentrada] = @valorentrada
      ,[id_proprietario] = @id_proprietario
      ,[proprietario] = @proprietario
      ,[imovel] = @imovel
      ,[id_fiador1] = @id_fiador1
      ,[id_fiador2] = @id_fiador2
      ,[id_comprador] = @id_comprador
      ,[multaatraso] = @multaatraso
      ,[jurosmora] = @jurosmora
      ,[honorarios] = @honorarios
      ,[indicereajuste] = @indicereajuste
      ,[reajustedias] = @reajustedias
      ,[multaatrasodias] = @multaatrasodias
      ,[jurosmoradias] = @jurosmoradias
      ,[taxaadministrativa] = @taxaadministrativa
      ,[id_captador1] = @id_captador1
      ,[id_captador2] = @id_captador2
      ,[nomecaptador1] = @nomecaptador1
      ,[nomecaptador2] = @nomecaptador2
      ,[OutrasDespesas] = @OutrasDespesas
      ,[datacontrato] = @datacontrato
      ,[iniciocobranca] = @iniciocobranca
      ,[comprador] = @comprador
 WHERE id_contrato_venda=@id_contrato_venda"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@id_contrato_venda", oContratoVenda.id_contrato_venda)
		oComando.Parameters.AddWithValue("@id_imovel", oContratoVenda.id_imovel)
		oComando.Parameters.AddWithValue("@nometestemunha1", oContratoVenda.nometestemunha1)
		oComando.Parameters.AddWithValue("@cpftestemunha1", oContratoVenda.cpftestemunha1)
		oComando.Parameters.AddWithValue("@nometestemunha2", oContratoVenda.nometestemunha2)
		oComando.Parameters.AddWithValue("@cpftestemunha2", oContratoVenda.cpftestemunha2)
		oComando.Parameters.AddWithValue("@parcelamentomeses", oContratoVenda.parcelamentomeses)
		oComando.Parameters.AddWithValue("@taxajuros", oContratoVenda.taxajuros)
		oComando.Parameters.AddWithValue("@vencimentoparcela", oContratoVenda.vencimentoparcela)
		oComando.Parameters.AddWithValue("@pagamentotododia", oContratoVenda.pagamentotododia)
		oComando.Parameters.AddWithValue("@valorimovel", oContratoVenda.valorimovel)
		oComando.Parameters.AddWithValue("@valorvenda", oContratoVenda.valorvenda)
		oComando.Parameters.AddWithValue("@valorentrada", oContratoVenda.valorentrada)
		oComando.Parameters.AddWithValue("@id_proprietario", oContratoVenda.id_proprietario)
		oComando.Parameters.AddWithValue("@proprietario", oContratoVenda.proprietario)
		oComando.Parameters.AddWithValue("@imovel", oContratoVenda.imovel)
		oComando.Parameters.AddWithValue("@id_fiador1", oContratoVenda.id_fiador1)
		oComando.Parameters.AddWithValue("@id_fiador2", oContratoVenda.id_fiador2)
		oComando.Parameters.AddWithValue("@id_comprador", oContratoVenda.id_comprador)
		oComando.Parameters.AddWithValue("@multaatraso", oContratoVenda.multaatraso)
		oComando.Parameters.AddWithValue("@jurosmora", oContratoVenda.jurosmora)
		oComando.Parameters.AddWithValue("@honorarios", oContratoVenda.honorarios)
		oComando.Parameters.AddWithValue("@comprador", oContratoVenda.comprador)
		oComando.Parameters.AddWithValue("@indicereajuste", oContratoVenda.indicereajuste)
		oComando.Parameters.AddWithValue("@reajustedias", oContratoVenda.reajustedias)
		oComando.Parameters.AddWithValue("@multaatrasodias", oContratoVenda.multaatrasodias)
		oComando.Parameters.AddWithValue("@jurosmoradias", oContratoVenda.jurosmoradias)
		oComando.Parameters.AddWithValue("@taxaadministrativa", oContratoVenda.taxaadministrativa)
		oComando.Parameters.AddWithValue("@id_captador1", oContratoVenda.id_captador1)
		oComando.Parameters.AddWithValue("@id_captador2", oContratoVenda.id_captador2)
		oComando.Parameters.AddWithValue("@nomecaptador1", oContratoVenda.nomecaptador1)
		oComando.Parameters.AddWithValue("@nomecaptador2", oContratoVenda.nomecaptador2)
		oComando.Parameters.AddWithValue("@OutrasDespesas", oContratoVenda.outrasdespesas)
		oComando.Parameters.AddWithValue("@datacontrato", oContratoVenda.datacontrato)
		oComando.Parameters.AddWithValue("@iniciocobranca", oContratoVenda.iniciocobranca)

		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Function ListarContratosVenda() As List(Of ContratoVenda)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "select * from ContratoVenda"
		Dim oCommado As New SqlCommand(SQL, ocn)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		Dim oRetorno As New List(Of ContratoVenda)
		While oDr.Read
			Dim oContrato As New ContratoVenda
			oContrato.id_contrato_venda = oDr.GetInt32(oDr.GetOrdinal("id_contrato_venda"))
			oContrato.comprador = oDr.GetString(oDr.GetOrdinal("comprador"))
			oContrato.cpftestemunha1 = oDr.GetString(oDr.GetOrdinal("cpftestemunha1"))
			oContrato.cpftestemunha2 = oDr.GetString(oDr.GetOrdinal("cpftestemunha2"))
			oContrato.honorarios = oDr.GetDouble(oDr.GetOrdinal("honorarios"))
			oContrato.id_captador1 = oDr.GetInt32(oDr.GetOrdinal("id_captador1"))
			oContrato.id_captador2 = oDr.GetInt32(oDr.GetOrdinal("id_captador2"))
			oContrato.id_comprador = oDr.GetInt32(oDr.GetOrdinal("id_comprador"))
			oContrato.id_fiador1 = oDr.GetInt32(oDr.GetOrdinal("id_fiador1"))
			oContrato.id_fiador2 = oDr.GetInt32(oDr.GetOrdinal("id_fiador2"))
			oContrato.id_imovel = oDr.GetInt32(oDr.GetOrdinal("id_imovel"))
			oContrato.id_proprietario = oDr.GetInt32(oDr.GetOrdinal("id_proprietario"))
			oContrato.imovel = oDr.GetString(oDr.GetOrdinal("imovel"))
			oContrato.indicereajuste = oDr.GetString(oDr.GetOrdinal("indicereajuste"))
			oContrato.jurosmora = oDr.GetDouble(oDr.GetOrdinal("jurosmora"))
			oContrato.jurosmoradias = oDr.GetInt32(oDr.GetOrdinal("jurosmoradias"))
			oContrato.multaatraso = oDr.GetDouble(oDr.GetOrdinal("multaatraso"))
			oContrato.multaatrasodias = oDr.GetInt32(oDr.GetOrdinal("multaatrasodias"))
			oContrato.nomecaptador1 = oDr.GetString(oDr.GetOrdinal("nomecaptador1"))

			oContrato.nomecaptador2 = oDr.GetString(oDr.GetOrdinal("nomecaptador2"))
			oContrato.nometestemunha1 = oDr.GetString(oDr.GetOrdinal("nometestemunha1"))
			oContrato.nometestemunha2 = oDr.GetString(oDr.GetOrdinal("nometestemunha2"))
			oContrato.outrasdespesas = oDr.GetDouble(oDr.GetOrdinal("outrasdespesas"))
			oContrato.pagamentotododia = oDr.GetString(oDr.GetOrdinal("pagamentotododia"))
			oContrato.parcelamentomeses = oDr.GetInt32(oDr.GetOrdinal("parcelamentomeses"))
			oContrato.proprietario = oDr.GetString(oDr.GetOrdinal("proprietario"))
			oContrato.reajustedias = oDr.GetInt32(oDr.GetOrdinal("reajustedias"))
			oContrato.taxaadministrativa = oDr.GetDouble(oDr.GetOrdinal("taxaadministrativa"))
			oContrato.taxajuros = oDr.GetDouble(oDr.GetOrdinal("taxajuros"))
			oContrato.valorentrada = oDr.GetDouble(oDr.GetOrdinal("valorentrada"))
			oContrato.valorimovel = oDr.GetDouble(oDr.GetOrdinal("valorimovel"))
			oContrato.valorvenda = oDr.GetDouble(oDr.GetOrdinal("valorvenda"))
			oContrato.vencimentoparcela = oDr.GetInt32(oDr.GetOrdinal("vencimentoparcela"))
			oContrato.datacontrato = oDr.GetDateTime(oDr.GetOrdinal("datacontrato"))
			oContrato.iniciocobranca = oDr.GetDateTime(oDr.GetOrdinal("iniciocobranca"))
			oRetorno.Add(oContrato)
		End While
		oDr.Close()
		ocn.Close()
		ocn.Dispose()
		Return oRetorno
	End Function
End Class
