Imports System.Data.SqlClient
Imports System.IO
Imports ImovelSIAEDB2015.Model.DataReaderExtensions
Partial Public Class Imovel
	Public Shared Function SelecionarTodosImoveis() As List(Of Imovel)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from Imovel"
		Dim oCommado As New SqlCommand(SQL, ocn)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		Dim oRetorno As New List(Of Imovel)
		While oDr.Read
			Dim oImovel As New Imovel
			oImovel.id_imovel = oDr.GetInt32(oDr.GetOrdinal("id_imovel"))
			oImovel.transacao = oDr.GetString(oDr.GetOrdinal("Transacao"))
			oImovel.tipo = oDr.GetString(oDr.GetOrdinal("Tipo"))
			oImovel.estado = oDr.GetString(oDr.GetOrdinal("Estado"))
			oImovel.proprietario = oDr.GetString(oDr.GetOrdinal("Proprietario"))
			oImovel.corretor = oDr.GetString(oDr.GetOrdinal("Corretor"))
			oImovel.cidade = oDr.GetString(oDr.GetOrdinal("Cidade"))
			oImovel.bairro = oDr.GetString(oDr.GetOrdinal("Bairro"))
			oImovel.endereco = oDr.GetString(oDr.GetOrdinal("Endereco"))
			oImovel.numero = oDr.GetString(oDr.GetOrdinal("Numero"))
			oImovel.complemento = oDr.GetStringOrNull(oDr.GetOrdinal("Complemento"))
			oImovel.areaterreno = oDr.GetDouble(oDr.GetOrdinal("Area_terreno"))
			oImovel.areaconstruida = oDr.GetDouble(oDr.GetOrdinal("Area_construida"))
			oImovel.id_corretor = oDr.GetInt32(oDr.GetOrdinal("id_corretor"))
			oImovel.quartos = oDr.GetString(oDr.GetOrdinal("Quartos"))
			oImovel.iptu = oDr.GetDouble(oDr.GetOrdinal("IPTU"))
			oImovel.preco = oDr.GetDouble(oDr.GetOrdinal("Preco"))
			oImovel.salas = oDr.GetString(oDr.GetOrdinal("Salas"))
			oImovel.subtipo = oDr.GetString(oDr.GetOrdinal("Subtipo"))
			oImovel.id_cliente = oDr.GetInt32(oDr.GetOrdinal("id_cliente"))
			oImovel.suite = oDr.GetString(oDr.GetOrdinal("Suite"))
			oImovel.garagem = oDr.GetString(oDr.GetOrdinal("Garagem"))
			oImovel.banheiro = oDr.GetString(oDr.GetOrdinal("Banheiro"))
			oImovel.andar = oDr.GetString(oDr.GetOrdinal("Andar"))
			oImovel.condominio = oDr.GetStringOrNull(oDr.GetOrdinal("Condominio"))
			oImovel.salas = oDr.GetString(oDr.GetOrdinal("Salas"))
			oImovel.formapagamento = oDr.GetStringOrNull(oDr.GetOrdinal("FormaPagamento"))
			oImovel.subtipo = oDr.GetString(oDr.GetOrdinal("Subtipo"))
			oImovel.observacao = oDr.GetStringOrNull(oDr.GetOrdinal("Observacao"))
			oImovel.foto = oDr.GetValue(oDr.GetOrdinal("Foto"))
			oImovel.fotoname = Convert.ToString(DateTime.Now.ToFileTime())
			Dim fs As New FileStream(oImovel.fotoname, FileMode.CreateNew, FileAccess.Write)
			fs.Write(oImovel.foto, 0, oImovel.foto.Length)
			fs.Flush()
			fs.Close()
			oRetorno.Add(oImovel)
		End While
		oDr.Close()
		ocn.Close()
		Return oRetorno
	End Function
	Public Shared Sub InserirImovel(ByVal oImovel As Imovel)

		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "		INSERT INTO Imovel
				   ([transacao]
		           ,[Tipo]
		           ,[Estado]
		           ,[Cidade]
		           ,[Bairro]
		           ,[Endereco]
		           ,[Numero]
		           ,[Complemento]
		           ,[Area_terreno]
		           ,[Area_construida]
		           ,[id_corretor]
				   ,[Corretor]
		           ,[Quartos]
		           ,[IPTU]
		           ,[Preco]
		           ,[Salas]
		           ,[Subtipo]
		           ,[id_cliente]
				   ,[Proprietario]
		           ,[Suite]
		           ,[Garagem]
		           ,[Banheiro]
		           ,[Andar]
		           ,[Foto]
		           ,[Observacao]
		           ,[Condominio]
		           ,[FormaPagamento])
		     VALUES
		           (@transacao
		           ,@Tipo
		           ,@Estado
		           ,@Cidade
		           ,@Bairro
		           ,@Endereco
		           ,@Numero
		           ,@Complemento
		           ,@Area_terreno
		           ,@Area_construida
		           ,@id_corretor
				   ,@Corretor
		           ,@Quartos
		           ,@IPTU
		           ,@Preco
		           ,@Salas
		           ,@Subtipo
		           ,@id_cliente
				   ,@Proprietario
		           ,@Suite
		           ,@Garagem
		           ,@Banheiro
		           ,@Andar
		           ,@Foto
		           ,@Observacao
					,@Condominio
		           ,@FormaPagamento)"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@transacao", oImovel.transacao)
		oComando.Parameters.AddWithValue("@Tipo", oImovel.tipo)
		oComando.Parameters.AddWithValue("@Estado", oImovel.estado)
		oComando.Parameters.AddWithValue("@Cidade", oImovel.cidade)
		oComando.Parameters.AddWithValue("@Bairro", oImovel.bairro)
		oComando.Parameters.AddWithValue("@Endereco", oImovel.endereco)
		oComando.Parameters.AddWithValue("@Numero", oImovel.numero)
		oComando.Parameters.AddWithValue("@Complemento", oImovel.complemento)
		oComando.Parameters.AddWithValue("@Area_terreno", oImovel.areaterreno)
		oComando.Parameters.AddWithValue("@Area_construida", oImovel.areaconstruida)
		oComando.Parameters.AddWithValue("@id_corretor", oImovel.id_corretor)
		oComando.Parameters.AddWithValue("@Corretor", oImovel.corretor)
		oComando.Parameters.AddWithValue("@Quartos", oImovel.quartos)
		oComando.Parameters.AddWithValue("@IPTU", oImovel.iptu)
		oComando.Parameters.AddWithValue("@Preco", oImovel.preco)
		oComando.Parameters.AddWithValue("@Salas", oImovel.salas)
		oComando.Parameters.AddWithValue("@Subtipo", oImovel.subtipo)
		oComando.Parameters.AddWithValue("@id_cliente", oImovel.id_cliente)
		oComando.Parameters.AddWithValue("@Proprietario", oImovel.proprietario)
		oComando.Parameters.AddWithValue("@Suite", oImovel.suite)
		oComando.Parameters.AddWithValue("@Condominio", oImovel.condominio)
		oComando.Parameters.AddWithValue("@FormaPagamento", oImovel.formapagamento)
		oComando.Parameters.AddWithValue("@Garagem", oImovel.garagem)
		oComando.Parameters.AddWithValue("@Banheiro", oImovel.banheiro)
		oComando.Parameters.AddWithValue("@Andar", oImovel.andar)
		oComando.Parameters.Add("@Foto", SqlDbType.Image)
		oComando.Parameters("@Foto").Value = oImovel.foto
		oComando.Parameters.AddWithValue("@Observacao", oImovel.observacao)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()

	End Sub
	Public Shared Sub AlterarImovel(ByVal oImovel As Imovel)
		Dim ocn As New SqlConnection
		Dim a As Integer = oImovel.id_imovel
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "
UPDATE Imovel
   SET [Transacao] = @Transacao
      ,[Tipo] = @Tipo
      ,[Estado] = @Estado
      ,[Cidade] = @Cidade
      ,[Bairro] = @Bairro
      ,[Endereco] = @Endereco
      ,[Numero] = @Numero
      ,[Complemento] = @Complemento
      ,[Area_terreno] = @Area_terreno
      ,[Area_construida] = @Area_construida
      ,[id_corretor] = @id_corretor
      ,[Corretor] = @Corretor
      ,[Quartos] = @Quartos
      ,[IPTU] = @IPTU
      ,[Preco] = @Preco
      ,[Salas] = @Salas
      ,[Subtipo] = @Subtipo
      ,[id_cliente] = @id_cliente
      ,[Proprietario] = @Proprietario
      ,[Suite] = @Suite
      ,[Garagem] = @Garagem
      ,[Banheiro] = @Banheiro
      ,[Andar] = @Andar
      ,[Foto] = @Foto
      ,[Observacao] = @Observacao
      ,[Condominio] = @Condominio
      ,[FormaPagamento] = @FormaPagamento
 WHERE id_imovel=@id_imovel"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@transacao", oImovel.transacao)
		oComando.Parameters.AddWithValue("@Tipo", oImovel.tipo)
		oComando.Parameters.AddWithValue("@Estado", oImovel.estado)
		oComando.Parameters.AddWithValue("@Cidade", oImovel.cidade)
		oComando.Parameters.AddWithValue("@Bairro", oImovel.bairro)
		oComando.Parameters.AddWithValue("@Endereco", oImovel.endereco)
		oComando.Parameters.AddWithValue("@Numero", oImovel.numero)
		oComando.Parameters.AddWithValue("@Complemento", oImovel.complemento)
		oComando.Parameters.AddWithValue("@Area_terreno", oImovel.areaterreno)
		oComando.Parameters.AddWithValue("@Area_construida", oImovel.areaconstruida)
		oComando.Parameters.AddWithValue("@id_corretor", oImovel.id_corretor)
		oComando.Parameters.AddWithValue("@Corretor", oImovel.corretor)
		oComando.Parameters.AddWithValue("@Quartos", oImovel.quartos)
		oComando.Parameters.AddWithValue("@IPTU", oImovel.iptu)
		oComando.Parameters.AddWithValue("@Preco", oImovel.preco)
		oComando.Parameters.AddWithValue("@Salas", oImovel.salas)
		oComando.Parameters.AddWithValue("@Subtipo", oImovel.subtipo)
		oComando.Parameters.AddWithValue("@id_cliente", oImovel.id_cliente)
		oComando.Parameters.AddWithValue("@Proprietario", oImovel.proprietario)
		oComando.Parameters.AddWithValue("@Suite", oImovel.suite)
		oComando.Parameters.AddWithValue("@Condominio", oImovel.condominio)
		oComando.Parameters.AddWithValue("@FormaPagamento", oImovel.formapagamento)
		oComando.Parameters.AddWithValue("@Garagem", oImovel.garagem)
		oComando.Parameters.AddWithValue("@Banheiro", oImovel.banheiro)
		oComando.Parameters.AddWithValue("@Andar", oImovel.andar)
		oComando.Parameters.Add("@Foto", SqlDbType.Image)
		oComando.Parameters("@Foto").Value = oImovel.foto
		oComando.Parameters.AddWithValue("@Observacao", oImovel.observacao)
		oComando.Parameters.AddWithValue("@id_imovel", oImovel.id_imovel)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Sub ExcluirImovel(ByVal id As Integer)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Delete from Imovel where id_imovel=@id_imovel"
		Dim oCommado As New SqlCommand(SQL, ocn)
		oCommado.Parameters.AddWithValue("@id_imovel", id)
		oCommado.ExecuteNonQuery()
		ocn.Close()
	End Sub

End Class
