Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model
Public Class FrmCliente
	Dim Inclusao As Boolean = True
	Dim CPFExiste As Boolean = False
	Dim CNPJExiste As Boolean = False
	Dim oCliente As New Cliente
	Dim tempID As Integer
	Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
		If ValidaCampos() Then
			If rdoFisica.Checked = True Then
				Dim CPFValidate As String = txtCPF.Text
				oCliente.tipopessoa = "Física"
				CPFExiste = CCliente.ValidaCPF(CPFValidate)
			ElseIf rdoJuridica.Checked = True Then
				oCliente.tipopessoa = "Jurídica"
				Dim CNPJValidade As String = txtCPF.Text
				CPFExiste = CCliente.ValidaCNPJ(CNPJValidade)
			End If
			oCliente.Id_cliente = tempID
			oCliente.bairro = txtBairro.Text.Trim
			oCliente.celular = txtCelular.Text.Trim
			oCliente.cep = txtCEP.Text.Trim
			oCliente.cnpj = txtCNPJ.Text.Trim
			oCliente.telefone = txtTelefone.Text.Trim
			oCliente.cidade = txtCidade.Text.Trim
			oCliente.tipo = cmbTipo.SelectedIndex
			oCliente.cpf = txtCPF.Text.Trim
			oCliente.email = txtEmail.Text.Trim
			oCliente.endereco = txtEndereco.Text.Trim
			oCliente.Estado = cmbEstado.SelectedItem
			oCliente.estadocivil = cmbEstadoCivil.SelectedItem
			oCliente.nacionalidade = cmbNacionalidade.SelectedItem
			oCliente.naturalidade = txtNaturalidade.Text.Trim
			oCliente.Nome = txtNome.Text.Trim
			oCliente.numero = txtNumero.Text.Trim
			oCliente.profissao = txtProfissao.Text.Trim
			oCliente.razaosocial = txtRazaosocial.Text.Trim
			oCliente.datanascimento = dtpNascimento.Value
			oCliente.tipo = cmbTipo.SelectedItem
			If rdoFisica.Checked Then
				If Inclusao Then
					If CPFExiste Then
						MessageBox.Show("O CPF já consta armazenado no sistema", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						CCliente.InserirCliente(oCliente)
						MessageBox.Show("Cliente inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
					End If
				Else
					CCliente.AlterarCliente(oCliente)
					MessageBox.Show("Cliente alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
				End If

			ElseIf rdoJuridica.Checked Then
				If Inclusao Then
					If CNPJExiste Then
						MessageBox.Show("O CNPJ já consta armazenado no sistema", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
					Else
						CCliente.InserirCliente(oCliente)
						MessageBox.Show("Cliente inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
					End If
				Else
					CCliente.AlterarCliente(oCliente)
					MessageBox.Show("Cliente alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
				End If
			End If
			Dim form As New FrmListaCliente
			LimpaCampos()
			form.CarregarGrid()
		End If
	End Sub
	Private Function ValidaCampos() As Boolean
		If rdoFisica.Checked = False And rdoJuridica.Checked = False Then
			MessageBox.Show("Selecione um tipo de Pessoa", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			rdoFisica.Focus()
			Return False
		End If
		If txtBairro.Text.Trim = "" Then
			MessageBox.Show("O campo Bairro é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtBairro.Focus()
			Return False

		End If
		If txtCPF.Enabled = True And txtCPF.Text.Trim = "" Then
			MessageBox.Show("O campo CPF é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCPF.Focus()
			Return False

		End If
		If txtCNPJ.Enabled = True And txtCNPJ.Text.Trim = "" Then
			MessageBox.Show("O campo CNPJ é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCNPJ.Focus()
			Return False

		End If
		If txtCelular.Text.Trim = "" Then
			MessageBox.Show("O campo Celular é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCelular.Focus()
			Return False

		End If
		If txtEndereco.Text.Trim = "" Then
			MessageBox.Show("O campo Endereço é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtCidade.Text.Trim = "" Then
			MessageBox.Show("O campo Cidade é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCidade.Focus()
			Return False
		End If
		If txtNumero.Text.Trim = "" Then
			MessageBox.Show("O campo Número é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtNumero.Focus()
			Return False
		End If
		If txtCEP.Text.Trim = "" Then
			MessageBox.Show("O campo CEP é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtCEP.Focus()
			Return False
		End If
		If cmbNacionalidade.SelectedItem = "" Then
			MessageBox.Show("Selecione uma Nacionalidade", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			cmbNacionalidade.Focus()
			Return False
		End If
		If cmbEstadoCivil.Enabled And cmbEstadoCivil.SelectedItem = "" Then
			MessageBox.Show("Selecione um Estado Civil", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			cmbEstadoCivil.Focus()
			Return False
		End If
		If cmbEstado.SelectedItem = "" Then
			MessageBox.Show("Selecione uma Estado", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			cmbEstado.Focus()
			Return False
		End If
		If txtNaturalidade.Text.Trim = "" Then
			MessageBox.Show("O campo Naturalidade é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtNaturalidade.Focus()
			Return False
		End If
		If txtProfissao.Text.Trim = "" Then
			MessageBox.Show("O campo Profissão é de preenchimento obrigatório", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtProfissao.Focus()
			Return False
		End If
		Return True
	End Function

	Private Sub rdoFisica_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFisica.CheckedChanged
		txtCPF.Enabled = True
		txtCNPJ.Enabled = False
		cmbEstadoCivil.Enabled = True
		dtpNascimento.Enabled = True
		txtRazaosocial.Enabled = False
	End Sub

	Private Sub rdoJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles rdoJuridica.CheckedChanged
		txtCPF.Enabled = False
		txtCNPJ.Enabled = True
		cmbEstadoCivil.Enabled = False
		dtpNascimento.Enabled = False
		txtRazaosocial.Enabled = True
	End Sub

	Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Inclusao = False Then
			lblModo.Text = "Modo de Edição"
		End If
	End Sub

	Public Sub Editing(ByVal oCliente As Cliente)
		Inclusao = False
		txtID.Text = oCliente.Id_cliente
		tempID = oCliente.Id_cliente
		txtBairro.Text = oCliente.bairro
		txtCelular.Text = oCliente.celular
		txtCEP.Text = oCliente.cep
		txtCNPJ.Text = oCliente.cnpj
		txtTelefone.Text = oCliente.telefone
		txtCidade.Text = oCliente.cidade
		cmbTipo.Text = oCliente.tipo
		dtpNascimento.Value = oCliente.datanascimento
		txtCPF.Text = oCliente.cpf
		txtEmail.Text = oCliente.email
		txtEndereco.Text = oCliente.endereco
		cmbEstado.SelectedItem = oCliente.Estado
		cmbEstadoCivil.SelectedItem = oCliente.estadocivil
		cmbNacionalidade.SelectedItem = oCliente.nacionalidade
		txtNaturalidade.Text = oCliente.naturalidade
		txtNome.Text = oCliente.Nome
		txtNumero.Text = oCliente.numero
		txtProfissao.Text = oCliente.profissao
		txtRazaosocial.Text = oCliente.razaosocial
		If oCliente.tipopessoa = "Física" Then
			rdoFisica.Checked = True
			rdoJuridica.Checked = False
		End If
		If oCliente.tipopessoa = "Jurídica" Then
			rdoFisica.Checked = False
			rdoJuridica.Checked = True
		End If
	End Sub

	Private Sub FrmCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Dim form As New FrmListaCliente
		form.CarregarGrid()
	End Sub

	Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
		LimpaCampos()
	End Sub
	Private Sub LimpaCampos()
		txtID.Text = ""
		txtBairro.Text = ""
		txtCelular.Text = ""
		txtCEP.Text = ""
		txtCNPJ.Text = ""
		txtTelefone.Text = ""
		txtCidade.Text = ""
		cmbTipo.Text = ""
		dtpNascimento.Value = Date.Now
		txtCPF.Text = ""
		txtEmail.Text = ""
		txtEndereco.Text = ""
		cmbEstado.SelectedItem = Nothing
		cmbEstadoCivil.SelectedItem = Nothing
		cmbNacionalidade.SelectedItem = Nothing
		txtNaturalidade.Text = ""
		txtNome.Text = ""
		txtNumero.Text = ""
		txtProfissao.Text = ""
		txtRazaosocial.Text = ""
		rdoFisica.Checked = False
		rdoJuridica.Checked = False
	End Sub
End Class