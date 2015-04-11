Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmListaCliente
	Dim oCliente As Cliente
	Dim templist As New List(Of Cliente)
	Dim teste As Boolean = False
	Dim Janela As String

	Public Sub CarregarGrid()
		dtgCliente.AutoGenerateColumns = False
		dtgCliente.DataSource = CCliente.SelecionarTodosClientes
		dtgCliente.Refresh()
	End Sub
	Private Sub FrmListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If teste Then
			CarregarGrid()
		End If
	End Sub

	Private Sub dtgCliente_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgCliente.CellMouseDoubleClick
		SelecionarCliente(Janela)
	End Sub

	Private Sub dtgCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dtgCliente.SelectionChanged
		If dtgCliente.SelectedRows.Count > 0 Then
			oCliente = dtgCliente.SelectedRows(0).DataBoundItem
		End If
	End Sub

	Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
		Edicao.Editar(oCliente)
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		If (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.OK) Then
			CCliente.ExcluirCliente(oCliente.Id_cliente)
		End If
		CarregarGrid()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
		If txtPesquisar.Text.Trim = "" Then
			MessageBox.Show("Digite um valor no campo Pesquisar", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			txtPesquisar.Focus()
		Else
			Pesquisar(cmbTipoPesquisa.SelectedItem, txtPesquisar.Text, False, "FrmListaCliente")
		End If

	End Sub
	Public Sub Pesquisar(ByVal Criterio As String, ByVal Item As String, ByVal IsToCadastrarImovel As Boolean, ByVal Window As String)
		CarregarGrid()
		Janela = Window
		Dim a As Cliente
		If IsToCadastrarImovel Then
			If Item <> "" And Criterio = "Tipo" Then
				dtgCliente.ClearSelection()
				For index = 0 To dtgCliente.Rows.Count - 1
					a = dtgCliente.Rows(index).DataBoundItem
					If a.tipo = Item Then
						templist.Add(a)
					End If
				Next
				If templist.Count = 0 Then
					MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

				End If

			End If

		Else
			If Item <> "" And Criterio = "Nome" Then
				dtgCliente.ClearSelection()
				For index = 0 To dtgCliente.Rows.Count - 1
					a = dtgCliente.Rows(index).DataBoundItem
					If a.Nome = txtPesquisar.Text Then
						templist.Add(a)
					End If
				Next
				If templist.Count = 0 Then
					MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

				End If

			End If
		End If
		If txtPesquisar.Text <> "" And Criterio = "Tipo" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.tipo = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

			End If

		ElseIf txtPesquisar.Text <> "" And Criterio = "Nome" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.Nome = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

			End If

		ElseIf txtPesquisar.Text <> "" And Criterio = "Razão Social" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.razaosocial = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

			End If
		ElseIf txtPesquisar.Text <> "" And Criterio = "CPF" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.cpf = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

			End If
		ElseIf txtPesquisar.Text <> "" And Criterio = "CNPJ" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.cnpj = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		ElseIf txtPesquisar.Text <> "" And Criterio = "Cidade" Then
			dtgCliente.ClearSelection()
			For index = 0 To dtgCliente.Rows.Count - 1
				a = dtgCliente.Rows(index).DataBoundItem
				If a.cidade = txtPesquisar.Text Then
					templist.Add(a)
				End If
			Next
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		End If
		CarregaGridBusca()
	End Sub
	Public Function Modo() As Boolean
		teste = True
		Return teste
	End Function
	Public Sub SelecionarCliente(ByVal Window As String)
		If teste Then
			If dtgCliente.SelectedRows.Count > 0 Then
				oCliente = dtgCliente.SelectedRows(0).DataBoundItem
			End If
		End If
		Dim ProprietarioSelecionado As New Tuple(Of Integer, String)(oCliente.Id_cliente, oCliente.Nome)
		Edicao.achou = True
		Edicao.Proprietario(ProprietarioSelecionado, Window)
		Me.Close()
	End Sub
	Public Sub CarregaGridBusca()
		dtgCliente.DataSource = templist
		dtgCliente.Refresh()
		dtgCliente.ClearSelection()
	End Sub
End Class