Public Class FrmRelatorioContratoAluguel
	Private Sub FrmRelatorioContratoAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GabrielSIAEDB2015DataSet.ContratoAluguel' table. You can move, or remove it, as needed.
		Me.ContratoAluguelTableAdapter.Fill(Me.GabrielSIAEDB2015DataSet.ContratoAluguel)

		Me.ReportViewer1.RefreshReport()
	End Sub
End Class