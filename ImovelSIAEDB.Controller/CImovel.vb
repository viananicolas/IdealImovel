Imports ImovelSIAEDB2015.Model
Public Class CImovel
	Public Shared Function SelecionarTodosImoveis() As List(Of Imovel)
		Return Imovel.SelecionarTodosImoveis
	End Function
	Public Shared Sub InserirImovel(ByVal oImovel As Imovel)
		Imovel.InserirImovel(oImovel)
	End Sub
	Public Shared Sub AlterarImovel(ByVal oImovel As Imovel)
		Imovel.AlterarImovel(oImovel)
	End Sub
	Public Shared Sub ExcluirImovel(ByVal id As Integer)
		Imovel.ExcluirImovel(id)
	End Sub
End Class
