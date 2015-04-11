Imports System.Data.SqlClient
Imports ImovelSIAEDB2015.Model.DataReaderExtensions
Partial Public Class Cliente
	Public Shared Sub InserirCliente(ByVal oCliente As Cliente)

		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "INSERT INTO Cliente
           ([Nome]
           ,[CPF]
           ,[Tipo_Pessoa]
			,[Tipo]
           ,[Razao_social]
           ,[Telefone]
           ,[Celular]
           ,[CNPJ]
           ,[Email]
           ,[Endereco]
           ,[Cidade]
           ,[Bairro]
           ,[Numero]
           ,[CEP]
           ,[Nacionalidade]
           ,[Naturalidade]
           ,[Estado_Civil]
           ,[Profissao]
           ,[Estado]
			,[DataNascimento])
     VALUES
           (@Nome
           ,@CPF
           ,@Tipo_Pessoa
			,@Tipo
           ,@Razao_social
           ,@Telefone
           ,@Celular
           ,@CNPJ
           ,@Email
           ,@Endereco
           ,@Cidade
           ,@Bairro
           ,@Numero
           ,@CEP
           ,@Nacionalidade
           ,@Naturalidade
           ,@Estado_Civil
           ,@Profissao
           ,@Estado
			,@DataNascimento)"

		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@Nome", oCliente.Nome)

		'Verifica se o atributo é nulo, pois não é de preenchimento obrigatório. 
		'Se for, insere um valor nulo do formato do Banco de dados
		If oCliente.cpf = Nothing Then
			oComando.Parameters.AddWithValue("@CPF", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@CPF", oCliente.cpf)

		End If
		oComando.Parameters.AddWithValue("@Tipo_Pessoa", oCliente.tipopessoa)
		oComando.Parameters.AddWithValue("@Tipo", oCliente.tipo)
		oComando.Parameters.AddWithValue("@Razao_social", oCliente.razaosocial)

		If oCliente.telefone = Nothing Then
			oComando.Parameters.AddWithValue("@Telefone", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@Telefone", oCliente.telefone)
		End If

		oComando.Parameters.AddWithValue("@Celular", oCliente.celular)
		If oCliente.cnpj = Nothing Then
			oComando.Parameters.AddWithValue("@CNPJ", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@CNPJ", oCliente.cnpj)
		End If
		oComando.Parameters.AddWithValue("@Email", oCliente.email)
		oComando.Parameters.AddWithValue("@Endereco", oCliente.endereco)
		oComando.Parameters.AddWithValue("@Cidade", oCliente.cidade)
		oComando.Parameters.AddWithValue("@Bairro", oCliente.bairro)
		oComando.Parameters.AddWithValue("@Numero", oCliente.numero)
		oComando.Parameters.AddWithValue("@CEP", oCliente.cep)
		oComando.Parameters.AddWithValue("@Nacionalidade", oCliente.nacionalidade)
		oComando.Parameters.AddWithValue("@Naturalidade", oCliente.naturalidade)
		If oCliente.estadocivil = Nothing Then
			oComando.Parameters.AddWithValue("@Estado_Civil", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@Estado_Civil", oCliente.estadocivil)
		End If

		oComando.Parameters.AddWithValue("@Profissao", oCliente.profissao)
		oComando.Parameters.AddWithValue("@Estado", oCliente.Estado)
		oComando.Parameters.AddWithValue("@DataNascimento", oCliente.datanascimento)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()

	End Sub
	Public Shared Sub AlterarCliente(ByVal oCliente As Cliente)
		Dim ocn As New SqlConnection
		Dim a As Integer = oCliente.Id_cliente
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "update Cliente
     set
           [Nome]= @Nome
           ,[CPF]= @CPF
           ,[Tipo_Pessoa]= @Tipo_Pessoa
           ,[Razao_social]= @Razao_social
           ,[Telefone]= @Telefone
           , [Celular]= @Celular
           ,[CNPJ] = @CNPJ
           ,[Email]= @Email
           ,[Endereco]= @Endereco
           ,[Cidade]= @Cidade
           ,[Bairro] = @Bairro
           ,[Numero]= @Numero
           ,[CEP]= @CEP
           ,[Nacionalidade]= @Nacionalidade
           ,[Naturalidade]= @Naturalidade
           ,[Estado_Civil]= @Estado_Civil
           ,[Profissao] = @Profissao
           ,[Estado] = @Estado

		where id_cliente= @id_cliente"

		Dim oComando As New SqlCommand(SQL, ocn)
		oComando.Parameters.AddWithValue("@Nome", oCliente.Nome)
		If oCliente.cpf = Nothing Then
			oComando.Parameters.AddWithValue("@CPF", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@CPF", oCliente.cpf)

		End If
		oComando.Parameters.AddWithValue("@Tipo_Pessoa", oCliente.tipopessoa)
		oComando.Parameters.AddWithValue("@Razao_social", oCliente.razaosocial)

		If oCliente.telefone = Nothing Then
			oComando.Parameters.AddWithValue("@Telefone", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@Telefone", oCliente.telefone)
		End If

		oComando.Parameters.AddWithValue("@Celular", oCliente.celular)
		If oCliente.cnpj = Nothing Then
			oComando.Parameters.AddWithValue("@CNPJ", DBNull.Value)
		Else
			oComando.Parameters.AddWithValue("@CNPJ", oCliente.cnpj)
		End If
		oComando.Parameters.AddWithValue("@Email", oCliente.email)
		oComando.Parameters.AddWithValue("@Endereco", oCliente.endereco)
		oComando.Parameters.AddWithValue("@Cidade", oCliente.cidade)
		oComando.Parameters.AddWithValue("@Bairro", oCliente.bairro)
		oComando.Parameters.AddWithValue("@Numero", oCliente.numero)
		oComando.Parameters.AddWithValue("@CEP", oCliente.cep)
		oComando.Parameters.AddWithValue("@Nacionalidade", oCliente.nacionalidade)
		oComando.Parameters.AddWithValue("@Naturalidade", oCliente.naturalidade)
		oComando.Parameters.AddWithValue("@Estado_Civil", oCliente.estadocivil)
		oComando.Parameters.AddWithValue("@Profissao", oCliente.profissao)
		oComando.Parameters.AddWithValue("@Estado", oCliente.Estado)
		oComando.Parameters.AddWithValue("@id_cliente", oCliente.Id_cliente)
		oComando.ExecuteNonQuery()
		ocn.Close()
		ocn.Dispose()
	End Sub
	Public Shared Sub ExcluirCliente(ByVal id As Integer)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Delete from Cliente where id_cliente=@id_cliente"
		Dim oCommado As New SqlCommand(SQL, ocn)
		oCommado.Parameters.AddWithValue("@id_cliente", id)
		oCommado.ExecuteNonQuery()
		ocn.Close()
	End Sub
	Public Shared Function SelecionarTodosClientes() As List(Of Cliente)
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from Cliente"
		Dim oCommado As New SqlCommand(SQL, ocn)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		Dim oRetorno As New List(Of Cliente)
		While oDr.Read
			Dim oCliente As New Cliente
			oCliente.Id_cliente = oDr.GetInt32(oDr.GetOrdinal("id_cliente"))
			oCliente.Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
			oCliente.cpf = oDr.GetStringOrNull(oDr.GetOrdinal("CPF"))
			oCliente.tipopessoa = oDr.GetString(oDr.GetOrdinal("Tipo_Pessoa"))
			oCliente.tipo = oDr.GetStringOrNull(oDr.GetOrdinal("Tipo"))
			oCliente.razaosocial = oDr.GetStringOrNull(oDr.GetOrdinal("Razao_social"))
			oCliente.telefone = oDr.GetStringOrNull(oDr.GetOrdinal("Telefone"))
			oCliente.celular = oDr.GetString(oDr.GetOrdinal("Celular"))
			oCliente.cnpj = oDr.GetStringOrNull(oDr.GetOrdinal("CNPJ"))
			oCliente.email = oDr.GetStringOrNull(oDr.GetOrdinal("Email"))
			oCliente.endereco = oDr.GetString(oDr.GetOrdinal("Endereco"))
			oCliente.tipo = oDr.GetStringOrNull(oDr.GetOrdinal("Tipo"))
			oCliente.cidade = oDr.GetString(oDr.GetOrdinal("Cidade"))
			oCliente.bairro = oDr.GetString(oDr.GetOrdinal("Bairro"))
			oCliente.numero = oDr.GetString(oDr.GetOrdinal("Numero"))
			oCliente.cep = oDr.GetString(oDr.GetOrdinal("CEP"))
			oCliente.nacionalidade = oDr.GetString(oDr.GetOrdinal("Nacionalidade"))
			oCliente.naturalidade = oDr.GetString(oDr.GetOrdinal("Naturalidade"))
			oCliente.estadocivil = oDr.GetStringOrNull(oDr.GetOrdinal("Estado_Civil"))
			oCliente.profissao = oDr.GetString(oDr.GetOrdinal("Profissao"))
			oCliente.Estado = oDr.GetString(oDr.GetOrdinal("Estado"))
			oCliente.datanascimento = oDr.GeDateTimeOrNull(oDr.GetOrdinal("DataNascimento"))
			oRetorno.Add(oCliente)
		End While
		oDr.Close()
		ocn.Close()
		Return oRetorno
	End Function
	Public Shared Function ValidaCPF(ByVal CPFValidate As String) As Boolean
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from Cliente where CPF= @CPF"
		Dim oCommado As New SqlCommand(SQL, ocn)
		oCommado.Parameters.AddWithValue("@CPF", CPFValidate)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		If oDr.Read Then
			oDr.Close()
			ocn.Close()
			Return True
		End If
		oDr.Close()
		ocn.Close()
		Return False
	End Function
	Public Shared Function ValidaCNPJ(ByVal CNPJValidate As String) As Boolean
		Dim ocn As New SqlConnection
		ocn = Conexao.ConexaoSQL
		Dim SQL As String
		SQL = "Select * from Cliente where CNPJ= @CNPJ"
		Dim oCommado As New SqlCommand(SQL, ocn)
		oCommado.Parameters.AddWithValue("@CNPJ", CNPJValidate)
		Dim oDr As SqlDataReader
		oDr = oCommado.ExecuteReader()
		If oDr.Read Then
			oDr.Close()
			ocn.Close()
			Return True
		End If
		oDr.Close()
		ocn.Close()
		Return False
	End Function
End Class

