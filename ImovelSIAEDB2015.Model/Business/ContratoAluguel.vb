Imports System.Data.SqlClient

Partial Public Class ContratoAluguel
	Public Shared Sub InserirContratoAluguel(ByVal oContratoAluguel As ContratoAluguel)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "INSERT INTO ContratoAluguel
           (
           [id_proprietario]
           ,[id_imovel]
           ,[id_inquilino1]
           ,[id_inquilino2]
           ,[id_fiador1]
           ,[id_fiador2]
           ,[datacontrato]
           ,[dataencerramentocontrato]
           ,[vencimentoparcelas]
           ,[iniciocobranca]
           ,[nometestemunha1]
           ,[cpftestemunha1]
           ,[nometestemunha2]
           ,[cpftestemunha2]
           ,[nomefiador1]
           ,[nomefiador2]
           ,[valoraluguel]
           ,[porcentagemmultaatraso]
           ,[diasmultaatraso]
           ,[porcentagemjurosmora]
           ,[diasjurosmora]
           ,[porcentagemhonorario]
           ,[diashonorario]
           ,[porcentagemdesconto]
           ,[diasdesconto]
           ,[observacoes]
           ,[proprietario]
           ,[tipoimovel]
           ,[situacao])
     VALUES
           (
           @id_proprietario
           ,@id_imovel
           ,@id_inquilino1
           ,@id_inquilino2
           ,@id_fiador1
           ,@id_fiador2
           ,@datacontrato
           ,@dataencerramentocontrato
           ,@vencimentoparcelas
           ,@iniciocobranca
           ,@nometestemunha1
           ,@cpftestemunha1
           ,@nometestemunha2
           ,@cpftestemunha2
           ,@nomefiador1
           ,@nomefiador2
           ,@valoraluguel
           ,@porcentagemmultaatraso
           ,@diasmultaatraso
           ,@porcentagemjurosmora
           ,@diasjurosmora
           ,@porcentagemhonorario
           ,@diashonorario
           ,@porcentagemdesconto
           ,@diasdesconto
           ,@observacoes
           ,@proprietario
           ,@tipoimovel
           ,@situacao)"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@id_proprietario", oContratoAluguel.id_proprietario)
		If oContratoAluguel.observacoes = Nothing Then
			oComando.Parameters.AddWithValue("@observacoes", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@observacoes", oContratoAluguel.observacoes)
		End If
		oComando.Parameters.AddWithValue("@id_imovel", oContratoAluguel.id_imovel)
		oComando.Parameters.AddWithValue("@id_inquilino1", oContratoAluguel.id_inquilino1)
		oComando.Parameters.AddWithValue("@id_inquilino2", oContratoAluguel.id_inquilino2)
		oComando.Parameters.AddWithValue("@id_fiador1", oContratoAluguel.id_fiador1)
		oComando.Parameters.AddWithValue("@id_fiador2", oContratoAluguel.id_fiador2)
		oComando.Parameters.AddWithValue("@datacontrato", oContratoAluguel.datacontrato)
		oComando.Parameters.AddWithValue("@dataencerramentocontrato", oContratoAluguel.dataencerramentocontrato)
		oComando.Parameters.AddWithValue("@vencimentoparcelas", oContratoAluguel.vencimentoparcelas)
		oComando.Parameters.AddWithValue("@iniciocobranca", oContratoAluguel.iniciocobranca)
		oComando.Parameters.AddWithValue("@nometestemunha1", oContratoAluguel.nometestemunha1)
		oComando.Parameters.AddWithValue("@cpftestemunha1", oContratoAluguel.cpftestemunha1)
		oComando.Parameters.AddWithValue("@nometestemunha2", oContratoAluguel.nometestemunha2)
		oComando.Parameters.AddWithValue("@cpftestemunha2", oContratoAluguel.cpftestemunha2)
		oComando.Parameters.AddWithValue("@nomefiador1", oContratoAluguel.nomefiador1)
		oComando.Parameters.AddWithValue("@nomefiador2", oContratoAluguel.nomefiador2)
		oComando.Parameters.AddWithValue("@valoraluguel", oContratoAluguel.valoraluguel)
		oComando.Parameters.AddWithValue("@porcentagemmultaatraso", oContratoAluguel.porcentagem_multa_atraso)
		oComando.Parameters.AddWithValue("@diasmultaatraso", oContratoAluguel.dias_multa_atraso)
		oComando.Parameters.AddWithValue("@porcentagemjurosmora", oContratoAluguel.porcentagem_juros_mora)
		oComando.Parameters.AddWithValue("@diasjurosmora", oContratoAluguel.dias_juros_mora)
		oComando.Parameters.AddWithValue("@porcentagemhonorario", oContratoAluguel.porcentagem_honorario)
		oComando.Parameters.AddWithValue("@diashonorario", oContratoAluguel.dias_honorario)
		oComando.Parameters.AddWithValue("@porcentagemdesconto", oContratoAluguel.porcentagem_desconto)
		oComando.Parameters.AddWithValue("@diasdesconto", oContratoAluguel.dias_desconto)
		oComando.Parameters.AddWithValue("@proprietario", oContratoAluguel.proprietario)
		oComando.Parameters.AddWithValue("@tipoimovel", oContratoAluguel.tipo_imovel)
		oComando.Parameters.AddWithValue("@situacao", oContratoAluguel.situacao)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Sub AlterarContratoAluguel(ByVal oContratoAluguel As ContratoAluguel)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "UPDATE ContratoAluguel
		   SET [id_proprietario] = @id_proprietario
		      ,[id_imovel] = @id_imovel
		      ,[id_inquilino1] = @id_inquilino1
		      ,[id_inquilino2] = @id_inquilino2
		      ,[id_fiador1] = @id_fiador1
		      ,[id_fiador2] = @id_fiador2
		      ,[datacontrato] = @datacontrato
		      ,[dataencerramentocontrato] = @dataencerramentocontrato
		      ,[vencimentoparcelas] = @vencimentoparcelas
		      ,[iniciocobranca] = @iniciocobranca
		      ,[nometestemunha1] = @nometestemunha1
		      ,[cpftestemunha1] = @cpftestemunha1
		      ,[nometestemunha2] = @nometestemunha2
		      ,[cpftestemunha2] = @cpftestemunha2
		      ,[nomefiador1] = @nomefiador1
		      ,[nomefiador2] = @nomefiador2
		      ,[valoraluguel] = @valoraluguel
		      ,[porcentagemmultaatraso] = @porcentagemmultaatraso
		      ,[diasmultaatraso] = @diasmultaatraso
		      ,[porcentagemjurosmora] = @porcentagemjurosmora
		      ,[diasjurosmora] = @diasjurosmora
		      ,[porcentagemhonorario] = @porcentagemhonorario
		      ,[diashonorario] = @diashonorario
		      ,[porcentagemdesconto] = @porcentagemdesconto
		      ,[diasdesconto] = @diasdesconto
		      ,[observacoes] = @observacoes
		      ,[proprietario] = @proprietario
		      ,[tipoimovel] = @tipoimovel
		      ,[situacao] = @situacao
		 WHERE id_contrato =@id_contrato"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@id_contrato", oContratoAluguel.id_contrato_aluguel)

		oComando.Parameters.AddWithValue("@id_proprietario", oContratoAluguel.id_proprietario)
		If oContratoAluguel.observacoes = Nothing Then
			oComando.Parameters.AddWithValue("@observacoes", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@observacoes", oContratoAluguel.observacoes)
		End If
		oComando.Parameters.AddWithValue("@id_imovel", oContratoAluguel.id_imovel)
		oComando.Parameters.AddWithValue("@id_inquilino1", oContratoAluguel.id_inquilino1)
		oComando.Parameters.AddWithValue("@id_inquilino2", oContratoAluguel.id_inquilino2)
		oComando.Parameters.AddWithValue("@id_fiador1", oContratoAluguel.id_fiador1)
		oComando.Parameters.AddWithValue("@id_fiador2", oContratoAluguel.id_fiador2)
		oComando.Parameters.AddWithValue("@datacontrato", oContratoAluguel.datacontrato)
		oComando.Parameters.AddWithValue("@dataencerramentocontrato", oContratoAluguel.dataencerramentocontrato)
		oComando.Parameters.AddWithValue("@vencimentoparcelas", oContratoAluguel.vencimentoparcelas)
		oComando.Parameters.AddWithValue("@iniciocobranca", oContratoAluguel.iniciocobranca)
		oComando.Parameters.AddWithValue("@nometestemunha1", oContratoAluguel.nometestemunha1)
		oComando.Parameters.AddWithValue("@cpftestemunha1", oContratoAluguel.cpftestemunha1)
		oComando.Parameters.AddWithValue("@nometestemunha2", oContratoAluguel.nometestemunha2)
		oComando.Parameters.AddWithValue("@cpftestemunha2", oContratoAluguel.cpftestemunha2)
		oComando.Parameters.AddWithValue("@nomefiador1", oContratoAluguel.nomefiador1)
		oComando.Parameters.AddWithValue("@nomefiador2", oContratoAluguel.nomefiador2)
		oComando.Parameters.AddWithValue("@valoraluguel", oContratoAluguel.valoraluguel)
		oComando.Parameters.AddWithValue("@porcentagemmultaatraso", oContratoAluguel.porcentagem_multa_atraso)
		oComando.Parameters.AddWithValue("@diasmultaatraso", oContratoAluguel.dias_multa_atraso)
		oComando.Parameters.AddWithValue("@porcentagemjurosmora", oContratoAluguel.porcentagem_juros_mora)
		oComando.Parameters.AddWithValue("@diasjurosmora", oContratoAluguel.dias_juros_mora)
		oComando.Parameters.AddWithValue("@porcentagemhonorario", oContratoAluguel.porcentagem_honorario)
		oComando.Parameters.AddWithValue("@diashonorario", oContratoAluguel.dias_honorario)
		oComando.Parameters.AddWithValue("@porcentagemdesconto", oContratoAluguel.porcentagem_desconto)
		oComando.Parameters.AddWithValue("@diasdesconto", oContratoAluguel.dias_desconto)
		oComando.Parameters.AddWithValue("@proprietario", oContratoAluguel.proprietario)
		oComando.Parameters.AddWithValue("@tipoimovel", oContratoAluguel.tipo_imovel)
		oComando.Parameters.AddWithValue("@situacao", oContratoAluguel.situacao)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Function ListarContratosAluguel() As List(Of ContratoAluguel)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from ContratoAluguel"
		Dim oCommado As New SqlCommand(SQL, ocn)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		Dim oRetorno As New List(Of ContratoAluguel)
		While oDr.Read
			Dim oContrato As New ContratoAluguel
			oContrato.id_contrato_aluguel = oDr.GetInt32(oDr.GetOrdinal("id_contrato"))
			oContrato.id_proprietario = oDr.GetInt32(oDr.GetOrdinal("id_proprietario"))
			oContrato.id_imovel = oDr.GetInt32(oDr.GetOrdinal("id_imovel"))
			oContrato.id_inquilino1 = oDr.GetInt32(oDr.GetOrdinal("id_inquilino1"))
			oContrato.id_inquilino2 = oDr.GetInt32(oDr.GetOrdinal("id_inquilino2"))
			oContrato.id_fiador1 = oDr.GetInt32(oDr.GetOrdinal("id_fiador1"))
			oContrato.id_fiador2 = oDr.GetInt32(oDr.GetOrdinal("id_fiador2"))
			oContrato.datacontrato = oDr.GetDateTime(oDr.GetOrdinal("datacontrato"))
			oContrato.dataencerramentocontrato = oDr.GetDateTime(oDr.GetOrdinal("dataencerramentocontrato"))
			oContrato.vencimentoparcelas = oDr.GetInt32(oDr.GetOrdinal("vencimentoparcelas"))
			oContrato.iniciocobranca = oDr.GetDateTime(oDr.GetOrdinal("iniciocobranca"))
			oContrato.nometestemunha1 = oDr.GetString(oDr.GetOrdinal("nometestemunha1"))
			oContrato.cpftestemunha1 = oDr.GetString(oDr.GetOrdinal("cpftestemunha1"))
			oContrato.nometestemunha2 = oDr.GetString(oDr.GetOrdinal("nometestemunha2"))
			oContrato.cpftestemunha2 = oDr.GetString(oDr.GetOrdinal("cpftestemunha2"))
			oContrato.nomefiador1 = oDr.GetString(oDr.GetOrdinal("nomefiador1"))
			oContrato.nomefiador2 = oDr.GetString(oDr.GetOrdinal("nomefiador2"))
			oContrato.valoraluguel = oDr.GetDouble(oDr.GetOrdinal("valoraluguel"))
			oContrato.porcentagem_multa_atraso = oDr.GetInt32(oDr.GetOrdinal("porcentagemmultaatraso"))
			oContrato.dias_multa_atraso = oDr.GetInt32(oDr.GetOrdinal("diasmultaatraso"))
			oContrato.porcentagem_juros_mora = oDr.GetInt32(oDr.GetOrdinal("porcentagemjurosmora"))
			oContrato.dias_juros_mora = oDr.GetInt32(oDr.GetOrdinal("diasjurosmora"))
			oContrato.porcentagem_honorario = oDr.GetInt32(oDr.GetOrdinal("porcentagemhonorario"))
			oContrato.dias_honorario = oDr.GetInt32(oDr.GetOrdinal("diashonorario"))
			oContrato.porcentagem_desconto = oDr.GetInt32(oDr.GetOrdinal("porcentagemdesconto"))
			oContrato.dias_desconto = oDr.GetInt32(oDr.GetOrdinal("diasdesconto"))
			oContrato.observacoes = oDr.GetString(oDr.GetOrdinal("observacoes"))
			oContrato.proprietario = oDr.GetString(oDr.GetOrdinal("proprietario"))
			oContrato.tipo_imovel = oDr.GetString(oDr.GetOrdinal("tipoimovel"))
			oContrato.situacao = oDr.GetString(oDr.GetOrdinal("situacao"))
			oRetorno.Add(oContrato)
		End While
		oDr.Close()
		ocn.Close()
		Return oRetorno
	End Function
End Class
