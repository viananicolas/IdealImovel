Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmContratoVenda
	Dim oContrato As New ContratoVenda
	Public Shared id_proprietario As Integer
	Public Shared id_comprador As Integer
	Public Shared id_fiador1 As Integer
	Public Shared id_fiador2 As Integer
	Public Shared id_captador1 As Integer
	Public Shared id_captador2 As Integer
	Public Shared id_imovel As Integer
	Dim inclusão As Boolean = True

	Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
		If ValidaCampos() Then
			oContrato.comprador = txtComprador.Text.Trim
			oContrato.cpftestemunha1 = txtCPF1.Text.Trim
			oContrato.cpftestemunha2 = txtCPF2.Text.Trim
			oContrato.honorarios = txtHonorario.Text.Trim
			oContrato.id_captador1 = id_captador1
			oContrato.id_captador2 = id_captador2
			oContrato.id_comprador = id_comprador
			oContrato.id_fiador1 = id_fiador1
			oContrato.id_fiador2 = id_fiador2
			oContrato.id_imovel = id_imovel
			oContrato.id_proprietario = id_proprietario
			oContrato.imovel = txtImovel.Text.Trim
			oContrato.indicereajuste = cmbReajuste.SelectedItem
			oContrato.jurosmora = Convert.ToSingle(txtJurosMora.Text.Trim)
			oContrato.jurosmoradias = Convert.ToInt32(txtDiasJurosMora.Text.Trim)
			oContrato.multaatraso = Convert.ToSingle(txtMultaAtraso.Text.Trim)
			oContrato.multaatrasodias = Convert.ToInt32(txtMultaAtrasoDias.Text.Trim)
			oContrato.nomecaptador1 = txtCaptador1.Text.Trim
			oContrato.nomecaptador2 = txtCaptador2.Text.Trim
			oContrato.nometestemunha1 = txtTestemunha1.Text.Trim
			oContrato.nometestemunha2 = txtTestemunha2.Text.Trim
			oContrato.outrasdespesas = Convert.ToSingle(txtOutrasDespesas.Text.Trim)
			oContrato.pagamentotododia = txtpagamentotododia.Text.Trim
			oContrato.parcelamentomeses = Convert.ToInt32(txtParcelamentoMeses.Text.Trim)
			oContrato.proprietario = txtProprietario.Text.Trim
			oContrato.reajustedias = Convert.ToInt32(txtReajusteDias.Text.Trim)
			oContrato.taxaadministrativa = Convert.ToSingle(txtTaxaAdministrativa.Text.Trim)
			oContrato.taxajuros = Convert.ToSingle(txtTaxaJuros.Text.Trim)
			oContrato.valorentrada = Convert.ToSingle(txtValorEntrada.Text.Trim)
			oContrato.valorimovel = Convert.ToSingle(txtValorImovel.Text.Trim)
			oContrato.valorvenda = Convert.ToSingle(txtValorVenda.Text.Trim)
			oContrato.vencimentoparcela = Convert.ToInt32(txtVencimentoParcela.Text.Trim)
			oContrato.datacontrato = dtpDataContrato.Value
			oContrato.iniciocobranca = dtpInicioCobranca.Value
			If inclusão Then
				CContratoVenda.InserirContratoVenda(oContrato)
				MessageBox.Show("Contrato inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			Else
				CContratoVenda.AlterarContratoVenda(oContrato)
				MessageBox.Show("Contrato alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

			End If
		End If
	End Sub
	Public Function ValidaCampos() As Boolean
		If txtCPF1.Text.Trim = "" Then
			MessageBox.Show("O campo CPF de Testemunha é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCPF1.Focus()
			Return False
		End If
		If txtCPF2.Text.Trim = "" Then
			MessageBox.Show("O campo CPF de testemunha é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCPF2.Focus()
			Return False
		End If
		If txtCaptador1.Text.Trim = "" Then
			MessageBox.Show("O campo Captador 1 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCaptador1.Focus()
			Return False
		End If
		If txtCaptador2.Text.Trim = "" Then
			MessageBox.Show("O campo Captador 2 é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCaptador2.Focus()
			Return False
		End If
		If txtComprador.Text.Trim = "" Then
			MessageBox.Show("O campo Comprador é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtComprador.Focus()
			Return False
		End If
		If txtTaxaAdministrativa.Text.Trim = "" Then
			MessageBox.Show("O campo Taxa Administrativa é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtTaxaAdministrativa.Focus()
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
		If txtJurosMora.Text.Trim = "" Then
			MessageBox.Show("O campo Juros Mora é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtJurosMora.Focus()
			Return False
		End If
		If txtValorVenda.Text.Trim = "" Then
			MessageBox.Show("O campo Porcentagem Desconto é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtValorVenda.Focus()
			Return False
		End If
		If txtValorEntrada.Text.Trim = "" Then
			MessageBox.Show("O campo Porcentagem Honorario é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtValorEntrada.Focus()
			Return False
		End If
		If txtProprietario.Text.Trim = "" Then
			MessageBox.Show("O campo Proprietario é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtProprietario.Focus()
			Return False
		End If
		If txtValorImovel.Text.Trim = "" Then
			MessageBox.Show("O campo Valor Aluguel é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtValorImovel.Focus()
			Return False
		End If
		If txtVencimentoParcela.Text.Trim = "" Then
			MessageBox.Show("O campo Vencimento Parcela é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtVencimentoParcela.Focus()
			Return False
		End If
		If cmbReajuste.SelectedItem = "" Then
			MessageBox.Show("O campo Reajuste é de seleção obrigatória", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtVencimentoParcela.Focus()
			Return False
		End If
		Return True
	End Function

	Private Sub btnPesquisar1_Click(sender As Object, e As EventArgs) Handles btnPesquisar1.Click
		Edicao.SelecionaProprietario("Fiador", "FrmContratoVendaFiador1")
	End Sub

	Private Sub btnPesquisar2_Click(sender As Object, e As EventArgs) Handles btnPesquisar2.Click
		Edicao.SelecionaProprietario("Fiador", "FrmContratoVendaFiador2")
	End Sub

	Private Sub btnPesquisarProprietario_Click(sender As Object, e As EventArgs) Handles btnPesquisarProprietario.Click
		Edicao.SelecionaProprietario("Proprietário", "FrmContratoVendaProprietario")

	End Sub

	Private Sub btnComprador_Click(sender As Object, e As EventArgs) Handles btnComprador.Click
		Edicao.SelecionaProprietario("Proprietário", "FrmContratoVendaComprador")
	End Sub

	Private Sub btnImovel_Click(sender As Object, e As EventArgs) Handles btnImovel.Click
		Edicao.SelecionaImovel("Venda", "FrmContratoVenda")
	End Sub

	Private Sub btnCaptador1_Click(sender As Object, e As EventArgs) Handles btnCaptador1.Click
		Edicao.SelecionaCorretor("FrmContratoVenda1")
	End Sub

	Private Sub btnCaptador2_Click(sender As Object, e As EventArgs) Handles btnCaptador2.Click
		Edicao.SelecionaCorretor("FrmContratoVenda2")
	End Sub

	Private Sub FrmContratoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class