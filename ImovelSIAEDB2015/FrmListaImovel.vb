Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmListaImovel
	Dim oImovel As Imovel
	Dim janela As String
	Dim teste As Boolean = False
	Private Sub FrmListaImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If teste Then
			CarregarGrid()
		End If
	End Sub

	Private Sub CarregarGrid()
		dtgImovel.AutoGenerateColumns = False
		dtgImovel.DataSource = CImovel.SelecionarTodosImoveis
		dtgImovel.Refresh()
	End Sub

	Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
		Pesquisar(cmbTipoPesquisa.SelectedItem, txtPesquisar.Text, False, Me.Text)
	End Sub

	Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
		Dim frmimovel As New FrmImovel
		Edicao.EditarImovel(oImovel)
	End Sub

	Private Sub dtgImovel_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgImovel.CellMouseDoubleClick
		SelecionarImovel(janela)
	End Sub

	Private Sub dtgImovel_SelectionChanged(sender As Object, e As EventArgs) Handles dtgImovel.SelectionChanged
		If dtgImovel.SelectedRows.Count > 0 Then
			oImovel = dtgImovel.SelectedRows(0).DataBoundItem
		End If
	End Sub
	Public Sub Pesquisar(ByVal Criterio As String, ByVal Item As String, ByVal IsToContratoAluguel As Boolean, ByVal Window As String)
		CarregarGrid()
		Janela = Window
		Dim a As Imovel
		Dim templist As New List(Of Imovel)
		If IsToContratoAluguel Then
			If Item <> "" And Criterio = "Transacao" Then
				dtgImovel.ClearSelection()
				For index = 0 To dtgImovel.Rows.Count - 1
					a = dtgImovel.Rows(index).DataBoundItem
					If a.transacao = Item Then
						templist.Add(a)
					End If
				Next
				If templist.Count = 0 Then
					MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

				End If
				dtgImovel.DataSource = templist
				dtgImovel.Refresh()
				dtgImovel.ClearSelection()
			End If
		Else

		End If
	End Sub
	Public Function Modo() As Boolean
		teste = True
		Return teste
	End Function
	Public Sub SelecionarImovel(ByVal Window As String)
		If teste Then
			If dtgImovel.SelectedRows.Count > 0 Then
				oImovel = dtgImovel.SelectedRows(0).DataBoundItem
			End If
		End If
		Dim ImovelSelecionado As New Tuple(Of Integer, String)(oImovel.id_imovel, oImovel.tipo)
		Edicao.achou = True
		Edicao.Imovel(ImovelSelecionado, Window)
		Me.Close()
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		If (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.OK) Then
			CImovel.ExcluirImovel(oImovel.id_imovel)
		End If
	End Sub
End Class