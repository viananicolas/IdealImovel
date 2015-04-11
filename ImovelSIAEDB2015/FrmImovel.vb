Imports System.IO
Imports ImovelSIAEDB2015.Controller
Imports ImovelSIAEDB2015.Model

Public Class FrmImovel
	Dim Inclusao As Boolean = True

	Public Shared id_cliente As Integer
	Public Shared id_corretor As Integer
	Dim imgbytesize() As Byte
	Dim oImovel As New Imovel
	Dim tempid As Integer

	Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

	End Sub

	Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

	End Sub

	Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
		Dim findpic As New OpenFileDialog()
		Dim imglocation As String
		findpic.Filter = "JPEG (*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;*.jfi)|*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;*.jfi|" _
		& "PNG (*.png)|*.png"
		If (findpic.ShowDialog() = DialogResult.OK) Then
			imglocation = findpic.FileName
			Dim imginfo As New FileInfo(imglocation)
			Dim imgsize = imginfo.Length
			ReDim imgbytesize(Convert.ToInt32(imgsize))
			Dim fs As New FileStream(imglocation, FileMode.Open, FileAccess.Read, FileShare.Read)
			Dim iByteRead = fs.Read(imgbytesize, 0, Convert.ToInt32(imgsize))
			fs.Close()
			pbCasa.ImageLocation = imglocation
		End If
	End Sub

	Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
		If ValidaCampos() Then

			oImovel.estado = cmbEstado.SelectedItem
			oImovel.andar = txtAndar.Text
			oImovel.areaconstruida = Convert.ToDouble(txtAreaConstruida.Text)
			oImovel.areaterreno = Convert.ToDouble(txtAreaTerreno.Text)
			oImovel.foto = imgbytesize
			oImovel.bairro = txtBairro.Text
			oImovel.banheiro = txtBanheiro.Text
			oImovel.cidade = txtCidade.Text
			oImovel.complemento = txtComplemento.Text
			oImovel.endereco = txtEndereco.Text
			oImovel.garagem = txtGaragem.Text
			oImovel.id_corretor = id_corretor
			oImovel.id_cliente = id_cliente
			oImovel.proprietario = txtProprietario.Text
			oImovel.corretor = txtCorretor.Text
			oImovel.iptu = Convert.ToDouble(txtIPTU.Text)
			oImovel.numero = txtNumero.Text
			oImovel.formapagamento = txtFormaPagamento.Text
			oImovel.condominio = txtCondominio.Text
			oImovel.observacao = txtObs.Text
			oImovel.preco = Convert.ToDouble(txtPreco.Text)
			oImovel.quartos = txtQuartos.Text
			oImovel.salas = txtSalas.Text
			oImovel.subtipo = cmbSubtipo.SelectedItem
			oImovel.suite = txtSuites.Text
			oImovel.tipo = cmbTipo.SelectedItem
			oImovel.transacao = cmbTransacao.SelectedItem
			If Inclusao Then
				CImovel.InserirImovel(oImovel)
				MessageBox.Show("Imóvel inserido com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			Else
				oImovel.id_imovel = tempid
				CImovel.AlterarImovel(oImovel)
				MessageBox.Show("Imóvel alterado com sucesso", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End If
			LimpaCampos()
		End If
	End Sub
	Private Function ValidaCampos() As Boolean
		If cmbTipo.SelectedItem = "" Then
			MessageBox.Show("Selecione o Tipo de Imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If cmbSubtipo.SelectedItem = "" Then
			MessageBox.Show("Selecione o Subipo de Imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If cmbTransacao.SelectedItem = "" Then
			MessageBox.Show("Selecione o Tipo de Transação do Imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If cmbEstado.SelectedItem = "" Then
			MessageBox.Show("Selecione o Estado onde está localizado o Imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtAndar.Text = "" Then
			MessageBox.Show("Digite a quantidade de andares do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtAreaConstruida.Text = "" Then
			MessageBox.Show("Digite a área construída do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtAreaTerreno.Text = "" Then
			MessageBox.Show("Digite a área do terreno do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtBairro.Text = "" Then
			MessageBox.Show("Digite o Bairro onde está localizado o imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtBanheiro.Text = "" Then
			MessageBox.Show("Digite a quantidade de Banheiros do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtCidade.Text = "" Then
			MessageBox.Show("Digite a Cidade onde está localizado o imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtEndereco.Text = "" Then
			MessageBox.Show("Digite o Endereço onde está localizado o imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtFormaPagamento.Text = "" Then
			MessageBox.Show("Digite a Forma de pagamento do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtGaragem.Text = "" Then
			MessageBox.Show("Digite a quantidade de garagens do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtNumero.Text = "" Then
			MessageBox.Show("Digite o número do o imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtPreco.Text = "" Then
			MessageBox.Show("Digite o Preço do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtSalas.Text = "" Then
			MessageBox.Show("Digite a quantidade de salas do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		If txtSuites.Text = "" Then
			MessageBox.Show("Digite a quantidade de suítes do imóvel", "Aviso de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Return False
		End If
		Return True
	End Function

	Private Sub btnPesquisarProprietario_Click(sender As Object, e As EventArgs) Handles btnPesquisarProprietario.Click
		Edicao.SelecionaProprietario("Proprietário", "FrmImovel")
	End Sub

	Private Sub btnPesquisarCorretor_Click(sender As Object, e As EventArgs) Handles btnPesquisarCorretor.Click
		Edicao.SelecionaCorretor("FrmImovel")
	End Sub

	Private Sub FrmImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Public Sub Editing(ByVal oImovel As Imovel)
		Inclusao = False
		txtID.Text = oImovel.id_imovel.ToString
		txtCorretor.Text = oImovel.corretor
		txtProprietario.Text = oImovel.proprietario
		tempid = oImovel.id_imovel
		cmbEstado.SelectedItem = oImovel.estado
		imgbytesize = oImovel.foto
		txtAndar.Text = oImovel.andar
		txtAreaConstruida.Text = oImovel.areaconstruida.ToString
		txtAreaTerreno.Text = oImovel.areaterreno.ToString
		pbCasa.ImageLocation = oImovel.fotoname
		txtBairro.Text = oImovel.bairro
		txtBanheiro.Text = oImovel.banheiro
		txtCidade.Text = oImovel.cidade
		txtComplemento.Text = oImovel.complemento
		txtEndereco.Text = oImovel.endereco
		txtGaragem.Text = oImovel.garagem
		id_corretor = oImovel.id_corretor
		id_cliente = oImovel.id_cliente
		txtIPTU.Text = oImovel.iptu.ToString
		txtFormaPagamento.Text = oImovel.formapagamento
		txtCondominio.Text = oImovel.condominio
		txtNumero.Text = oImovel.numero
		txtObs.Text = oImovel.observacao
		txtPreco.Text = oImovel.preco
		txtQuartos.Text = oImovel.quartos
		txtSalas.Text = oImovel.salas
		cmbSubtipo.SelectedItem = oImovel.subtipo
		txtSuites.Text = oImovel.suite
		cmbTipo.SelectedItem = oImovel.tipo
		cmbTransacao.SelectedItem = oImovel.transacao
	End Sub
	Private Sub LimpaCampos()
		txtID.Text = ""
		txtCorretor.Text = ""
		txtProprietario.Text = ""
		cmbEstado.SelectedItem = Nothing
		txtAndar.Text = ""
		txtAreaConstruida.Text = ""
		txtAreaTerreno.Text = ""
		pbCasa.ImageLocation = Nothing
		txtBairro.Text = ""
		txtBanheiro.Text = ""
		txtCidade.Text = ""
		txtComplemento.Text = ""
		txtEndereco.Text = ""
		txtGaragem.Text = ""
		txtIPTU.Text = ""
		txtFormaPagamento.Text = ""
		txtCondominio.Text = ""
		txtNumero.Text = ""
		txtObs.Text = ""
		txtPreco.Text = ""
		txtQuartos.Text = ""
		txtSalas.Text = ""
		cmbSubtipo.SelectedItem = Nothing
		txtSuites.Text = ""
		cmbTipo.SelectedItem = Nothing
		cmbTransacao.SelectedItem = Nothing
	End Sub

	Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
		LimpaCampos()
	End Sub
End Class