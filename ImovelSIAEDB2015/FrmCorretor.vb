Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmCorretor
	Dim teste As Boolean = False
	Dim oCorretor As New Corretor
	Dim inserir As Boolean = True
	Dim templist As New List(Of Corretor)
	Public Shared Windowz As String
	Private Sub FrmCorretor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CarregaGrid()
	End Sub
	Public Sub CarregaGrid()
		dtgCorretor.AutoGenerateColumns = False
		dtgCorretor.DataSource = CCorretor.SelecionarTodosCorretores
		dtgCorretor.Refresh()
	End Sub
	Public Function Modo() As Boolean
		teste = True
		Return teste
	End Function

	Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
		If ValidaCampos() Then
			oCorretor.bairro = txtBairro.Text
			oCorretor.cidade = txtCidade.Text
			oCorretor.datanascimento = dtpNascimento.Value
			oCorretor.email = txtEmail.Text
			oCorretor.endereco = txtEndereco.Text
			oCorretor.nome = txtNome.Text
			oCorretor.estado = cmbEstado.SelectedItem
			oCorretor.rg = txtRG.Text
			oCorretor.telefone = txtTelefone.Text
			If inserir Then
				CCorretor.InserirCorretor(oCorretor)
				MessageBox.Show("Cliente inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			Else
				CCorretor.AlterarCorretor(oCorretor)
				MessageBox.Show("Cliente alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		End If
		CarregaGrid()
		LimpaCampos()

	End Sub

	Private Sub LimpaCampos()
		txtBairro.Text = ""
		txtCidade.Text = ""
		dtpNascimento.Value = Date.Now
		txtEmail.Text = ""
		txtEndereco.Text = ""
		txtNome.Text = ""
		cmbEstado.SelectedItem = Nothing
		txtRG.Text = ""
		txtTelefone.Text = ""
	End Sub

	Public Function ValidaCampos() As Boolean
		If txtBairro.Text = "" Then
			MessageBox.Show("O Campo Bairro é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtCidade.Text = "" Then
			MessageBox.Show("O Campo Cidade é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtEmail.Text = "" Then
			MessageBox.Show("O Campo Email é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtEndereco.Text = "" Then
			MessageBox.Show("O Campo Endereço é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtNome.Text = "" Then
			MessageBox.Show("O Campo Nome é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtRG.Text = "" Then
			MessageBox.Show("O Campo RG é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtTelefone.Text = "" Then
			MessageBox.Show("O Campo Telefone é de preenchimento obrigatório", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		Return True
	End Function

	Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
		LimpaCampos()
	End Sub

	Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
		If dtgCorretor.SelectedRows.Count > 0 Then
			inserir = False
			oCorretor = dtgCorretor.SelectedRows(0).DataBoundItem
			txtBairro.Text = oCorretor.bairro
			txtCidade.Text = oCorretor.cidade
			dtpNascimento.Value = oCorretor.datanascimento
			txtEmail.Text = oCorretor.email
			txtEndereco.Text = oCorretor.endereco
			txtNome.Text = oCorretor.nome
			cmbEstado.SelectedItem = oCorretor.estado
			txtRG.Text = oCorretor.rg
			txtTelefone.Text = oCorretor.telefone
		End If
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		If dtgCorretor.SelectedRows.Count > 0 Then
			If (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.OK) Then
				oCorretor = dtgCorretor.SelectedRows(0).DataBoundItem
				CCorretor.ExcluirCorretor(oCorretor.id_corretor)
			End If
			CarregaGrid()
		End If
	End Sub

	Private Sub dtgCorretor_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCorretor.CellContentDoubleClick

	End Sub

	Private Sub SelecionaCorretor()
		If dtgCorretor.SelectedRows.Count > 0 Then
			oCorretor = dtgCorretor.SelectedRows(0).DataBoundItem
		End If
		Dim CorretorSelecionado As New Tuple(Of Integer, String)(oCorretor.id_corretor, oCorretor.nome)
		Edicao.achou = True
		Edicao.Corretor(CorretorSelecionado, Windowz)
		Me.Close()
	End Sub

	Private Sub dtgCorretor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgCorretor.CellMouseDoubleClick
		SelecionaCorretor()
	End Sub

	Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
		'ID
		'Nome
		'Cidade
		Dim a As New Corretor
		If txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "ID" Then
			dtgCorretor.ClearSelection()
			For index = 0 To dtgCorretor.Rows.Count - 1
				a = dtgCorretor.Rows(index).DataBoundItem
				If a.id_corretor = txtPesquisar.Text Then
					templist.Add(a)
				End If

			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Nome" Then
			dtgCorretor.ClearSelection()
			For index = 0 To dtgCorretor.Rows.Count - 1
				a = dtgCorretor.Rows(index).DataBoundItem
				If a.nome = txtPesquisar.Text Then
					templist.Add(a)
				End If

			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		ElseIf txtPesquisar.Text <> "" And cmbTipoPesquisa.SelectedItem = "Cidade" Then
			dtgCorretor.ClearSelection()
			For index = 0 To dtgCorretor.Rows.Count - 1
				a = dtgCorretor.Rows(index).DataBoundItem
				If a.cidade = txtPesquisar.Text Then
					templist.Add(a)
				End If

			Next
			ReCarregarGrid()
			If templist.Count = 0 Then
				MessageBox.Show("Nenhum item encontrado", "Aviso de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		End If
	End Sub

	Private Sub ReCarregarGrid()
		dtgCorretor.AutoGenerateColumns = False
		dtgCorretor.DataSource = templist
		dtgCorretor.Refresh()
	End Sub
End Class