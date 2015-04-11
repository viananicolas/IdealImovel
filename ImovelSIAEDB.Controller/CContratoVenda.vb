Imports ImovelSIAEDB2015.Model

Public Class CContratoVenda
	Public Shared Sub InserirContratoVenda(ByVal oContratoVenda As ContratoVenda)
		ContratoVenda.InserirContratoVenda(oContratoVenda)
	End Sub
	Public Shared Sub AlterarContratoVenda(ByVal oContratoVenda As ContratoVenda)
		ContratoVenda.AlterarContratoVenda(oContratoVenda)
	End Sub
	Public Shared Function ListarContratosVenda() As List(Of ContratoVenda)

		Return ContratoVenda.ListarContratosVenda
	End Function
End Class

