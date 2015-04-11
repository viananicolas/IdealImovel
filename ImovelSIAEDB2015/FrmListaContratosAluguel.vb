Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmListaContratosAluguel
	Dim oContrato As New ContratoAluguel
	Dim templist As New List(Of ContratoAluguel)
	Private Sub FrmListaContratosAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CarregarGrid()
	End Sub
	Private Sub CarregarGrid()
		dtgContratosAluguel.AutoGenerateColumns = False
		dtgContratosAluguel.DataSource = CContratoAluguel.ListarContratosAluguel
		dtgContratosAluguel.Refresh()
	End Sub
	Private Sub ReCarregarGrid()
		dtgContratosAluguel.AutoGenerateColumns = False
		dtgContratosAluguel.DataSource = templist
		dtgContratosAluguel.Refresh()
	End Sub

	Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
		Edicao.EditarContratoAluguel(oContrato)
	End Sub

	Private Sub dtgContratosAluguel_SelectionChanged(sender As Object, e As EventArgs) Handles dtgContratosAluguel.SelectionChanged
		If dtgContratosAluguel.SelectedRows.Count > 0 Then
			oContrato = dtgContratosAluguel.SelectedRows(0).DataBoundItem
		End If
	End Sub

	Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
		'Proprietário
		'Tipo
		'Subtipo
		'Cidade
		'Situação
		Dim a As New ContratoAluguel
		If txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Proprietário" Then
			dtgContratosAluguel.ClearSelection()
			For index = 0 To dtgContratosAluguel.Rows.Count - 1
				a = dtgContratosAluguel.Rows(index).DataBoundItem
				If a.proprietario = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Tipo" Then
			dtgContratosAluguel.ClearSelection()
			For index = 0 To dtgContratosAluguel.Rows.Count - 1
				a = dtgContratosAluguel.Rows(index).DataBoundItem
				If a.tipo_imovel = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Situação" Then
			dtgContratosAluguel.ClearSelection()
			For index = 0 To dtgContratosAluguel.Rows.Count - 1
				a = dtgContratosAluguel.Rows(index).DataBoundItem
				If a.situacao = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		End If
	End Sub
End Class