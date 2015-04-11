Imports ImovelSIAEDB2015.Model

Module Edicao
	Public nome As String
	Public achou As Boolean
	Public Sub Editar(ByVal oCliente As Cliente)
		Dim frfmcliente As New FrmCliente
		frfmcliente.Editing(oCliente)
		frfmcliente.Show()
	End Sub

	Public Sub EditarImovel(ByVal oImovel As Imovel)
		Dim frmimovel As New FrmImovel
		frmimovel.Editing(oImovel)
		frmimovel.Show()
	End Sub
	Public Sub EditarContratoAluguel(ByVal oContrato As ContratoAluguel)
		Dim frmcontrato As New FrmContratoAluguel
		frmcontrato.Editing(oContrato)
		frmcontrato.Show()
	End Sub

	Public Sub SelecionaProprietario(ByVal Procura As String, ByVal Window As String)
		Dim frmlistacliente As New FrmListaCliente
		frmlistacliente.Pesquisar("Tipo", Procura, True, Window)
		frmlistacliente.Show()
	End Sub
	Public Sub SelecionaImovel(ByVal Procura As String, ByVal Window As String)
		Dim frmimovel As New FrmListaImovel
		frmimovel.Pesquisar("Transacao", Procura, True, Window)
		frmimovel.Show()
	End Sub
	Public Sub Proprietario(ByVal ProprietarioSelecionado As Tuple(Of Integer, String), ByVal Window As String)
		If Window = "FrmImovel" Then
			Dim fdfs As FrmImovel = Application.OpenForms("FrmImovel")
			fdfs.txtProprietario.Text = ProprietarioSelecionado.Item2
			fdfs.id_cliente = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoAluguelProprietario" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtProprietario.Text = ProprietarioSelecionado.Item2
			fdfs.id_proprietario = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoAluguelFiador1" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtFiador1.Text = ProprietarioSelecionado.Item2
			fdfs.id_fiador1 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoAluguelFiador2" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtFiador2.Text = ProprietarioSelecionado.Item2
			fdfs.id_fiador2 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoAluguelInquilino1" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtInquilino1.Text = ProprietarioSelecionado.Item2
			fdfs.id_inquilino1 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoAluguelInquilino2" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtInquilino2.Text = ProprietarioSelecionado.Item2
			fdfs.id_inquilino2 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoVendaFiador1" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtFiador1.Text = ProprietarioSelecionado.Item2
			fdfs.id_fiador1 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoVendaFiador2" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtFiador2.Text = ProprietarioSelecionado.Item2
			fdfs.id_fiador2 = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoVendaProprietario" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtProprietario.Text = ProprietarioSelecionado.Item2
			fdfs.id_proprietario = ProprietarioSelecionado.Item1
		ElseIf Window = "FrmContratoVendaComprador" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtComprador.Text = ProprietarioSelecionado.Item2
			fdfs.id_comprador = ProprietarioSelecionado.Item1
		End If
	End Sub
	Public Sub Imovel(ByVal ImovelSelecionado As Tuple(Of Integer, String), ByVal Window As String)
		If Window = "FrmContratoAluguel" Then
			Dim fdfs As FrmContratoAluguel = Application.OpenForms("FrmContratoAluguel")
			fdfs.txtImovel.Text = ImovelSelecionado.Item2
			fdfs.id_imovel = ImovelSelecionado.Item1
		ElseIf Window = "FrmContratoVenda" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtImovel.Text = ImovelSelecionado.Item2
			fdfs.id_imovel = ImovelSelecionado.Item1
		End If
	End Sub
	Public Sub SelecionaCorretor(ByVal Window As String)
		Dim frmcorretor As New FrmCorretor
		frmcorretor.Windowz = Window
		frmcorretor.Show()
	End Sub
	Public Sub Corretor(ByVal CorretorSelecionado As Tuple(Of Integer, String), ByVal Window As String)
		If Window = "FrmImovel" Then
			Dim fdfs As FrmImovel = Application.OpenForms("FrmImovel")
			fdfs.txtCorretor.Text = CorretorSelecionado.Item2
			fdfs.id_corretor = CorretorSelecionado.Item1
		ElseIf Window = "FrmContratoVenda1" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtCaptador1.Text = CorretorSelecionado.Item2
			fdfs.id_captador1 = CorretorSelecionado.Item1
		ElseIf Window = "FrmContratoVenda2" Then
			Dim fdfs As FrmContratoVenda = Application.OpenForms("FrmContratoVenda")
			fdfs.txtCaptador2.Text = CorretorSelecionado.Item2
			fdfs.id_captador2 = CorretorSelecionado.Item1
		End If

	End Sub
End Module
