Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmListaContratoVenda
	Dim templist As New List(Of ContratoVenda)
	Private Sub FrmListaContratoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CarregarGrid()
	End Sub
	Private Sub CarregarGrid()
		dtgContratosVenda.AutoGenerateColumns = False
		dtgContratosVenda.DataSource = CContratoVenda.ListarContratosVenda
		dtgContratosVenda.Refresh()
	End Sub

	Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
		'Proprietário
		'Comprador
		'ID Contrato
		Dim a As New ContratoVenda
		If txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Proprietário" Then
			dtgContratosVenda.ClearSelection()
			For index = 0 To dtgContratosVenda.Rows.Count - 1
				a = dtgContratosVenda.Rows(index).DataBoundItem
				If a.proprietario = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
				CarregarGrid()
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Comprador" Then
			dtgContratosVenda.ClearSelection()
			For index = 0 To dtgContratosVenda.Rows.Count - 1
				a = dtgContratosVenda.Rows(index).DataBoundItem
				If a.comprador = txtPesquisar.Text Then
					templist.Add(a)
				End If

			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
				CarregarGrid()
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "ID Contrato" Then
			dtgContratosVenda.ClearSelection()
			For index = 0 To dtgContratosVenda.Rows.Count - 1
				a = dtgContratosVenda.Rows(index).DataBoundItem
				If a.id_contrato_venda = txtPesquisar.Text Then
					templist.Add(a)
				End If

			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
				CarregarGrid()
			End If
		End If
	End Sub

	Private Sub ReCarregarGrid()
		dtgContratosVenda.AutoGenerateColumns = False
		dtgContratosVenda.DataSource = templist
		dtgContratosVenda.Refresh()
	End Sub
End Class