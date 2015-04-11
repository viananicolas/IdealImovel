Imports ImovelSIAEDB2015.Model

Public Class CContratoAluguel
	Public Shared Sub InserirContratoAluguel(ByVal oContratoAluguel As ContratoAluguel)
		ContratoAluguel.InserirContratoAluguel(oContratoAluguel)
	End Sub
	Public Shared Sub AlterarContratoAluguel(ByVal oContratoAluguel As ContratoAluguel)
		ContratoAluguel.AlterarContratoAluguel(oContratoAluguel)
	End Sub
	Public Shared Function ListarContratosAluguel() As List(Of ContratoAluguel)

		Return ContratoAluguel.ListarContratosAluguel
	End Function
End Class
