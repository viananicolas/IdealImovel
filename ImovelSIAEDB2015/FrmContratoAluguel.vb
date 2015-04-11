Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmContratoAluguel
	Dim inclusao As Boolean = True
	Dim oContratoAluguel As New ContratoAluguel
	Public Shared id_proprietario As Integer
	Public Shared id_fiador1 As Integer
	Public Shared id_fiador2 As Integer
	Public Shared id_inquilino1 As Integer
	Public Shared id_inquilino2 As Integer
	Public Shared id_imovel As Integer
	Private Sub FrmContratoAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Public Function ValidaCampos() As Boolean
		If txtCPFTestemunha1.Text.Trim = "" Then
			MessageBox.Show("O campo CPF de Testemunha é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCPFTestemunha1.Focus()
			Return False
		End If
		If txtCPFTestemunha2.Text.Trim = "" Then
			MessageBox.Show("O campo CPF de testemunha é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCPFTestemunha2.Focus()
			Return False
		End If
		If txtDiasDesconto.Text.Trim = "" Then
			MessageBox.Show("O campo Dias Desconto é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtDiasDesconto.Focus()
			Return False
		End If
		If txtDiasHonorario.Text.Trim = "" Then
			MessageBox.Show("O campo Dias Honorario é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtDiasHonorario.Focus()
			Return False
		End If
		If txtDiasJurosMora.Text.Trim = "" Then
			MessageBox.Show("O campo Dias Juros Mora é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtDiasJurosMora.Focus()
			Return False
		End If
		If txtDiasMulta.Text.Trim = "" Then
			MessageBox.Show("O campo Dias Multa é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtDiasMulta.Focus()
			Return False
		End If
		If txtFiador1.Text.Trim = "" Then
			MessageBox.Show("O campo Fiador 1 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtFiador1.Focus()
			Return False
		End If
		If txtFiador2.Text.Trim = "" Then
			MessageBox.Show("O campo Fiador 2 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtFiador2.Focus()
			Return False
		End If
		If txtImovel.Text.Trim = "" Then
			MessageBox.Show("O campo Imovel é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtImovel.Focus()
			Return False
		End If
		If txtInquilino1.Text.Trim = "" Then
			MessageBox.Show("O campo Inquilino 1 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtInquilino1.Focus()
			Return False
		End If
		If txtInquilino2.Text.Trim = "" Then
			MessageBox.Show("O campo Inquilino 2 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtInquilino2.Focus()
			Return False
		End If
		If txtJurosMora.Text.Trim = "" Then
			MessageBox.Show("O campo Juros Mora é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtJurosMora.Focus()
			Return False
		End If
		If txtNomeTestemunha1.Text.Trim = "" Then
			MessageBox.Show("O campo Nome Testemunha 1 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtNomeTestemunha1.Focus()
			Return False
		End If
		If txtNomeTestemunha2.Text.Trim = "" Then
			MessageBox.Show("O campo Nome Testemunha 2 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtNomeTestemunha2.Focus()
			Return False
		End If
		If txtPorcentagemDesconto.Text.Trim = "" Then
			MessageBox.Show("O campo Porcentagem Desconto é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtPorcentagemDesconto.Focus()
			Return False
		End If
		If txtPorcentagemHonorario.Text.Trim = "" Then
			MessageBox.Show("O campo Porcentagem Honorario é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtPorcentagemHonorario.Focus()
			Return False
		End If
		If txtProprietario.Text.Trim = "" Then
			MessageBox.Show("O campo Proprietario é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtProprietario.Focus()
			Return False
		End If
		If txtValorAluguel.Text.Trim = "" Then
			MessageBox.Show("O campo Valor Aluguel é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtValorAluguel.Focus()
			Return False
		End If
		If txtVencimentoParcela.Text.Trim = "" Then
			MessageBox.Show("O campo Vencimento Parcela é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtVencimentoParcela.Focus()
			Return False
		End If
		Return True
	End Function

	Private Sub btnPesquisar1_Click(sender As Object, e As EventArgs) Handles btnPesquisar1.Click
		Edicao.SelecionaProprietario("Fiador", "FrmContratoAluguelFiador1")
	End Sub

	Private Sub btnPesquisar2_Click(sender As Object, e As EventArgs) Handles btnPesquisar2.Click
		Edicao.SelecionaProprietario("Fiador", "FrmContratoAluguelFiador2")
	End Sub

	Private Sub btnPesquisarProprietario_Click(sender As Object, e As EventArgs) Handles btnPesquisarProprietario.Click
		Edicao.SelecionaProprietario("Proprietário", "FrmContratoAluguelProprietario")
	End Sub

	Private Sub btnPesquisarInquilino1_Click(sender As Object, e As EventArgs) Handles btnPesquisarInquilino1.Click
		Edicao.SelecionaProprietario("Inquilino", "FrmContratoAluguelInquilino1")
	End Sub

	Private Sub btnPesquisarInquilino2_Click(sender As Object, e As EventArgs) Handles btnPesquisarInquilino2.Click
		Edicao.SelecionaProprietario("Inquilino", "FrmContratoAluguelInquilino2")
	End Sub

	Private Sub btnPesquisarImovel_Click(sender As Object, e As EventArgs) Handles btnPesquisarImovel.Click
		Edicao.SelecionaImovel("Aluguel", "FrmContratoAluguel")
	End Sub

	Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
		If ValidaCampos() Then
			oContratoAluguel.cpftestemunha1 = txtCPFTestemunha1.Text.Trim
			oContratoAluguel.cpftestemunha2 = txtCPFTestemunha2.Text.Trim
			oContratoAluguel.datacontrato = dtpDataContrato.Value
			oContratoAluguel.dataencerramentocontrato = dtpDataEncerramento.Value
			oContratoAluguel.dias_desconto = Convert.ToInt32(txtDiasDesconto.Text.Trim)
			oContratoAluguel.dias_honorario = Convert.ToInt32(txtDiasHonorario.Text.Trim)
			oContratoAluguel.dias_juros_mora = Convert.ToInt32(txtDiasJurosMora.Text.Trim)
			oContratoAluguel.dias_multa_atraso = Convert.ToInt32(txtDiasMulta.Text.Trim)
			oContratoAluguel.id_fiador1 = id_fiador1
			oContratoAluguel.id_fiador2 = id_fiador2
			oContratoAluguel.id_imovel = id_imovel
			oContratoAluguel.id_inquilino1 = id_inquilino1
			oContratoAluguel.id_inquilino2 = id_inquilino2
			oContratoAluguel.id_proprietario = id_proprietario
			oContratoAluguel.iniciocobranca = dtpInicioCobranca.Value
			oContratoAluguel.inquilino1 = txtInquilino1.Text.Trim
			oContratoAluguel.inquilino2 = txtInquilino2.Text.Trim
			oContratoAluguel.nomefiador1 = txtFiador1.Text.Trim
			oContratoAluguel.nomefiador2 = txtFiador2.Text.Trim
			oContratoAluguel.nometestemunha1 = txtNomeTestemunha1.Text.Trim
			oContratoAluguel.nometestemunha2 = txtNomeTestemunha2.Text.Trim
			oContratoAluguel.observacoes = txtObs.Text
			oContratoAluguel.porcentagem_desconto = Convert.ToInt32(txtPorcentagemDesconto.Text.Trim)
			oContratoAluguel.porcentagem_honorario = Convert.ToInt32(txtPorcentagemHonorario.Text.Trim)
			oContratoAluguel.porcentagem_juros_mora = Convert.ToInt32(txtJurosMora.Text.Trim)
			oContratoAluguel.porcentagem_multa_atraso = Convert.ToInt32(txtPorcentagemMulta.Text.Trim)
			oContratoAluguel.proprietario = txtProprietario.Text.Trim
			oContratoAluguel.situacao = cmbSituacao.SelectedItem
			oContratoAluguel.tipo_imovel = txtImovel.Text.Trim
			oContratoAluguel.valoraluguel = Convert.ToDouble(txtValorAluguel.Text.Trim)
			oContratoAluguel.vencimentoparcelas = txtVencimentoParcela.Text
			If inclusao Then
				CContratoAluguel.InserirContratoAluguel(oContratoAluguel)
				MessageBox.Show("Contrato inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			Else
				CContratoAluguel.AlterarContratoAluguel(oContratoAluguel)
				MessageBox.Show("Contrato alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
		End If
	End Sub
	Public Sub Editing(ByVal oContratoAluguel As ContratoAluguel)
		'CONTINUAR DAQUI
		txtCPFTestemunha1.Text = oContratoAluguel.cpftestemunha1
		oContratoAluguel.cpftestemunha2 = txtCPFTestemunha2.Text.Trim
		oContratoAluguel.datacontrato = dtpDataContrato.Value
		oContratoAluguel.dataencerramentocontrato = dtpDataEncerramento.Value
		txtDiasDesconto.Text = oContratoAluguel.dias_desconto
		txtDiasHonorario.Text = oContratoAluguel.dias_honorario
		txtDiasJurosMora.Text = oContratoAluguel.dias_juros_mora
		txtDiasMulta.Text = oContratoAluguel.dias_multa_atraso
		id_fiador1 = oContratoAluguel.id_fiador1
		id_fiador2 = oContratoAluguel.id_fiador2
		id_imovel = oContratoAluguel.id_imovel =
		id_inquilino1 = oContratoAluguel.id_inquilino1
		id_inquilino2 = oContratoAluguel.id_inquilino2
		id_proprietario = oContratoAluguel.id_proprietario
		dtpInicioCobranca.Value = oContratoAluguel.iniciocobranca
		txtInquilino1.Text = oContratoAluguel.inquilino1
		txtInquilino2.Text = oContratoAluguel.inquilino2
		txtFiador1.Text = oContratoAluguel.nomefiador1
		txtFiador2.Text = oContratoAluguel.nomefiador2
		txtNomeTestemunha1.Text = oContratoAluguel.nometestemunha1
		txtNomeTestemunha2.Text = oContratoAluguel.nometestemunha2
		txtObs.Text = oContratoAluguel.observacoes
		txtPorcentagemDesconto.Text = oContratoAluguel.porcentagem_desconto
		txtPorcentagemHonorario.Text = oContratoAluguel.porcentagem_honorario
		txtJurosMora.Text = oContratoAluguel.porcentagem_juros_mora
		txtPorcentagemMulta.Text = oContratoAluguel.porcentagem_multa_atraso
		txtProprietario.Text = oContratoAluguel.proprietario
		cmbSituacao.SelectedItem = oContratoAluguel.situacao
		txtImovel.Text = oContratoAluguel.tipo_imovel
		txtValorAluguel.Text = oContratoAluguel.valoraluguel
		txtVencimentoParcela.Text = oContratoAluguel.vencimentoparcelas
	End Sub
End Class