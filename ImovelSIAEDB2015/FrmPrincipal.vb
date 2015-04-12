Public Class FrmPrincipal

	Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
		Dim frmcliente As New FrmCliente()
		frmcliente.MdiParent = Me
		frmcliente.WindowState = FormWindowState.Maximized
		frmcliente.Show()
	End Sub

	Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
		Dim frmlistacliente As New FrmListaCliente
		frmlistacliente.MdiParent = Me
		'frmlistacliente.Modo() =  Informa se o formulário será aberto para uma visualização normal da lista de clientes
		'ou se é para escolher um na hora de criar um contrato ou imóvel
		frmlistacliente.Modo()
		frmlistacliente.WindowState = FormWindowState.Maximized
		frmlistacliente.Show()
	End Sub

	Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblUserLogado.Text = "Usuário logado: " + Environment.UserName + " |"
		lblMaquina.Text = "Máquina: " + Environment.MachineName + " |"
		lblOS.Text = "Sistema Operacional: " + Environment.OSVersion.VersionString + " |"
		'ToolStripStatusLabel1.Text = Environment.Version.ToString
	End Sub

	Private Sub ImóvelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImóvelToolStripMenuItem.Click
		Dim frmimovel As New FrmImovel
		frmimovel.MdiParent = Me
		frmimovel.WindowState = FormWindowState.Maximized
		frmimovel.Show()
	End Sub

	Private Sub ImóveisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImóveisToolStripMenuItem.Click
		Dim frmlistaimovel As New FrmListaImovel
		frmlistaimovel.MdiParent = Me
		frmlistaimovel.Modo()
		frmlistaimovel.WindowState = FormWindowState.Maximized
		frmlistaimovel.Show()
	End Sub

	Private Sub CorretorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorretorToolStripMenuItem.Click
		Dim frmcorretor As New FrmCorretor
		frmcorretor.MdiParent = Me
		frmcorretor.Modo()
		frmcorretor.WindowState = FormWindowState.Maximized
		frmcorretor.Show()
	End Sub

	Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
		Dim frmsobre As New Sobre
		frmsobre.Show()
	End Sub

	Private Sub NovoContratoDeAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoContratoDeAluguelToolStripMenuItem.Click
		Dim frmaluguel As New FrmContratoAluguel
		frmaluguel.MdiParent = Me
		frmaluguel.WindowState = FormWindowState.Maximized
		frmaluguel.Show()
	End Sub

	Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

	End Sub

	Private Sub AluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AluguelToolStripMenuItem.Click
		Dim frmlistaaluguel As New FrmListaContratosAluguel
		frmlistaaluguel.MdiParent = Me
		frmlistaaluguel.WindowState = FormWindowState.Maximized
		frmlistaaluguel.Show()
	End Sub

	Private Sub ContratoDeAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratoDeAluguelToolStripMenuItem.Click
		Dim frmrelatorioaluguel As New FrmRelatorioContratoAluguel
		frmrelatorioaluguel.MdiParent = Me
		frmrelatorioaluguel.WindowState = FormWindowState.Maximized
		frmrelatorioaluguel.Show()
	End Sub

	Private Sub TipoDeImóvelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeImóvelToolStripMenuItem.Click
		Dim frmrelatoriotipo As New FrmRelatorioTipoImovel
		frmrelatoriotipo.MdiParent = Me
		frmrelatoriotipo.WindowState = FormWindowState.Maximized
		frmrelatoriotipo.Show()
	End Sub

	Private Sub VendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaToolStripMenuItem.Click
		Dim frmlistavenda As New FrmListaContratoVenda
		frmlistavenda.MdiParent = Me
		frmlistavenda.WindowState = FormWindowState.Maximized
		frmlistavenda.Show()
	End Sub

	Private Sub NovoContratoDeVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoContratoDeVendaToolStripMenuItem.Click
		Dim frmvenda As New FrmContratoVenda
		frmvenda.MdiParent = Me
		frmvenda.WindowState = FormWindowState.Maximized
		frmvenda.Show()
	End Sub
End Class
