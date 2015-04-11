Imports ImovelSIAEDB2015.Model
Public Class CCliente
	Public Shared Function SelecionarTodosClientes() As List(Of Cliente)
		Return Cliente.SelecionarTodosClientes
	End Function
	Public Shared Sub InserirCliente(ByVal oCliente As Cliente)
		Cliente.InserirCliente(oCliente)
	End Sub
	Public Shared Sub AlterarCliente(ByVal oCliente As Cliente)
		Cliente.AlterarCliente(oCliente)
	End Sub
	Public Shared Sub ExcluirCliente(ByVal id As Integer)
		Cliente.ExcluirCliente(id)
	End Sub

	Public Shared Function ValidaCPF(ByVal CPFValidate As String) As Boolean
		Return Cliente.ValidaCPF(CPFValidate)
	End Function

	Public Shared Function ValidaCNPJ(ByVal CNPJValidate As String) As Boolean
		Return Cliente.ValidaCNPJ(CNPJValidate)
	End Function
End Class
