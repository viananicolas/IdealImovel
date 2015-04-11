Imports ImovelSIAEDB2015.Controller

Public Class FrmListaContratoVenda
	Private Sub FrmListaContratoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CarregarGrid()
	End Sub
	Private Sub CarregarGrid()
		dtgContratosVenda.AutoGenerateColumns = False
		dtgContratosVenda.DataSource = CContratoVenda.ListarContratosVenda
		dtgContratosVenda.Refresh()
	End Sub
End Class