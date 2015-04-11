Imports System.Data.SqlClient

Partial Public Class Corretor
	Public Shared Sub InserirCorretor(ByVal oCorretor As Corretor)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "INSERT INTO [dbo].[Corretor]
           ([Nome]
           ,[DataNascimento]
           ,[RG]
           ,[Endereco]
           ,[Bairro]
           ,[Cidade]
           ,[Estado]
           ,[Telefone]
           ,[Email])
			values
			(@Nome
			,@DataNascimento
			,@RG
			,@Endereco
			,@Bairro
			,@Cidade
			,@Estado
			,@Telefone
			,@Email)"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@Nome", oCorretor.nome)
		oComando.Parameters.AddWithValue("@DataNascimento", oCorretor.datanascimento)
		oComando.Parameters.AddWithValue("@RG", oCorretor.rg)
		oComando.Parameters.AddWithValue("@Endereco", oCorretor.endereco)
		oComando.Parameters.AddWithValue("@Bairro", oCorretor.bairro)
		oComando.Parameters.AddWithValue("@Cidade", oCorretor.cidade)
		oComando.Parameters.AddWithValue("@Estado", oCorretor.estado)
		oComando.Parameters.AddWithValue("@Telefone", oCorretor.telefone)
		oComando.Parameters.AddWithValue("@Email", oCorretor.email)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()

	End Sub
	Public Shared Sub AlterarCorretor(ByVal oCorretor As Corretor)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "update Corretor set
		 [Nome] = @Nome
           ,[DataNascimento] = @DataNascimento
           ,[RG] = @RG
           ,[Endereco] = @Endereco
           ,[Bairro] = @Bairro
           ,[Cidade] = @Cidade
           ,[Estado] = @Estado
           ,[Telefone] = @Telefone
           ,[Email] = @Email
where id_corretor = @id_corretor"
		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@id_corretor", oCorretor.id_corretor)
		oComando.Parameters.AddWithValue("@Nome", oCorretor.nome)
		oComando.Parameters.AddWithValue("@DataNascimento", oCorretor.datanascimento)
		oComando.Parameters.AddWithValue("@RG", oCorretor.rg)
		oComando.Parameters.AddWithValue("@Endereco", oCorretor.endereco)
		oComando.Parameters.AddWithValue("@Bairro", oCorretor.bairro)
		oComando.Parameters.AddWithValue("@Cidade", oCorretor.cidade)
		oComando.Parameters.AddWithValue("@Estado", oCorretor.estado)
		oComando.Parameters.AddWithValue("@Telefone", oCorretor.telefone)
		oComando.Parameters.AddWithValue("@Email", oCorretor.email)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Sub ExcluirCorretor(ByVal ID As Integer)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Delete from Corretor where id_corretor=@id_corretor"
		Dim oCommado As New SqlCommand(SQL, ocn)
		oCommado.Parameters.AddWithValue("@id_corretor", ID)
		oCommado.ExecuteNonQuery()
		ocn.Close()
	End Sub

	Public Shared Function SelecionarTodosCorretores() As List(Of Corretor)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from Corretor"
		Dim oCommado As New SqlCommand(SQL, ocn)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		Dim oRetorno As New List(Of Corretor)
		While oDr.Read
			Dim oCorretor As New Corretor
			oCorretor.id_corretor = oDr.GetInt32(oDr.GetOrdinal("id_corretor"))
			oCorretor.nome = oDr.GetString(oDr.GetOrdinal("Nome"))
			oCorretor.datanascimento = oDr.GetDateTime(oDr.GetOrdinal("DataNascimento"))
			oCorretor.rg = oDr.GetString(oDr.GetOrdinal("RG"))
			oCorretor.endereco = oDr.GetString(oDr.GetOrdinal("Endereco"))
			oCorretor.bairro = oDr.GetString(oDr.GetOrdinal("Bairro"))
			oCorretor.cidade = oDr.GetString(oDr.GetOrdinal("Cidade"))
			oCorretor.estado = oDr.GetString(oDr.GetOrdinal("Estado"))
			oCorretor.telefone = oDr.GetString(oDr.GetOrdinal("Telefone"))
			oCorretor.email = oDr.GetString(oDr.GetOrdinal("Email"))
			oRetorno.Add(oCorretor)
		End While
		oDr.Close()
		ocn.Close()
		Return oRetorno
	End Function
End Class
