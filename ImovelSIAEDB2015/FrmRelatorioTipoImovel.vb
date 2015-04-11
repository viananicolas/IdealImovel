Public Class FrmRelatorioTipoImovel
	Private Sub FrmRelatorioTipoImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GabrielSIAEDB2015DataSet1.Imovel' table. You can move, or remove it, as needed.
		Me.ImovelTableAdapter.Fill(Me.GabrielSIAEDB2015DataSet1.Imovel)

		Me.ReportViewer1.RefreshReport()
	End Sub
End Class