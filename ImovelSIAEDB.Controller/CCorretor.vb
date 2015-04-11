Imports ImovelSIAEDB2015.Model

Public Class CCorretor
	Public Shared Sub InserirCorretor(ByVal oCorretor As Corretor)
		Corretor.InserirCorretor(oCorretor)
	End Sub
	Public Shared Sub AlterarCorretor(ByVal oCorretor As Corretor)
		Corretor.AlterarCorretor(oCorretor)
	End Sub
	Public Shared Sub ExcluirCorretor(ByVal ID As Integer)
		Corretor.ExcluirCorretor(ID)
	End Sub

	Public Shared Function SelecionarTodosCorretores() As List(Of Corretor)

		Return Corretor.SelecionarTodosCorretores
	End Function
End Class
