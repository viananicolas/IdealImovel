<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImóvelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CorretorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NovoContratoDeAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NovoContratoDeVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImóveisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContratosDeAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContratoDeAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TipoDeImóvelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblUserLogado = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblMaquina = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblOS = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.ContratoToolStripMenuItem, Me.ListarToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.SobreToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(897, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'CadastroToolStripMenuItem
		'
		Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ImóvelToolStripMenuItem, Me.CorretorToolStripMenuItem})
		Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
		Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.CadastroToolStripMenuItem.Text = "Cadastro"
		'
		'ClienteToolStripMenuItem
		'
		Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
		Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
		Me.ClienteToolStripMenuItem.Text = "Cliente"
		'
		'ImóvelToolStripMenuItem
		'
		Me.ImóvelToolStripMenuItem.Name = "ImóvelToolStripMenuItem"
		Me.ImóvelToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
		Me.ImóvelToolStripMenuItem.Text = "Imóvel"
		'
		'CorretorToolStripMenuItem
		'
		Me.CorretorToolStripMenuItem.Name = "CorretorToolStripMenuItem"
		Me.CorretorToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
		Me.CorretorToolStripMenuItem.Text = "Corretor"
		'
		'ContratoToolStripMenuItem
		'
		Me.ContratoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoContratoDeAluguelToolStripMenuItem, Me.NovoContratoDeVendaToolStripMenuItem})
		Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
		Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.ContratoToolStripMenuItem.Text = "Contrato"
		'
		'NovoContratoDeAluguelToolStripMenuItem
		'
		Me.NovoContratoDeAluguelToolStripMenuItem.Name = "NovoContratoDeAluguelToolStripMenuItem"
		Me.NovoContratoDeAluguelToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
		Me.NovoContratoDeAluguelToolStripMenuItem.Text = "Novo Contrato de Aluguel"
		'
		'NovoContratoDeVendaToolStripMenuItem
		'
		Me.NovoContratoDeVendaToolStripMenuItem.Name = "NovoContratoDeVendaToolStripMenuItem"
		Me.NovoContratoDeVendaToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
		Me.NovoContratoDeVendaToolStripMenuItem.Text = "Novo Contrato de Venda"
		'
		'ListarToolStripMenuItem
		'
		Me.ListarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ImóveisToolStripMenuItem, Me.ContratosDeAluguelToolStripMenuItem})
		Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
		Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
		Me.ListarToolStripMenuItem.Text = "Listar"
		'
		'ClientesToolStripMenuItem
		'
		Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
		Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ClientesToolStripMenuItem.Text = "Clientes"
		'
		'ImóveisToolStripMenuItem
		'
		Me.ImóveisToolStripMenuItem.Name = "ImóveisToolStripMenuItem"
		Me.ImóveisToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ImóveisToolStripMenuItem.Text = "Imóveis"
		'
		'ContratosDeAluguelToolStripMenuItem
		'
		Me.ContratosDeAluguelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AluguelToolStripMenuItem, Me.VendaToolStripMenuItem})
		Me.ContratosDeAluguelToolStripMenuItem.Name = "ContratosDeAluguelToolStripMenuItem"
		Me.ContratosDeAluguelToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.ContratosDeAluguelToolStripMenuItem.Text = "Contratos"
		'
		'AluguelToolStripMenuItem
		'
		Me.AluguelToolStripMenuItem.Name = "AluguelToolStripMenuItem"
		Me.AluguelToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
		Me.AluguelToolStripMenuItem.Text = "Aluguel"
		'
		'VendaToolStripMenuItem
		'
		Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
		Me.VendaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
		Me.VendaToolStripMenuItem.Text = "Venda"
		'
		'RelatórioToolStripMenuItem
		'
		Me.RelatórioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoDeAluguelToolStripMenuItem, Me.TipoDeImóvelToolStripMenuItem})
		Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
		Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.RelatórioToolStripMenuItem.Text = "Relatório"
		'
		'ContratoDeAluguelToolStripMenuItem
		'
		Me.ContratoDeAluguelToolStripMenuItem.Name = "ContratoDeAluguelToolStripMenuItem"
		Me.ContratoDeAluguelToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
		Me.ContratoDeAluguelToolStripMenuItem.Text = "Contrato de Aluguel"
		'
		'TipoDeImóvelToolStripMenuItem
		'
		Me.TipoDeImóvelToolStripMenuItem.Name = "TipoDeImóvelToolStripMenuItem"
		Me.TipoDeImóvelToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
		Me.TipoDeImóvelToolStripMenuItem.Text = "Tipo de Imóvel"
		'
		'SobreToolStripMenuItem
		'
		Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
		Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
		Me.SobreToolStripMenuItem.Text = "Sobre"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUserLogado, Me.lblMaquina, Me.lblOS})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(897, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblUserLogado
		'
		Me.lblUserLogado.Name = "lblUserLogado"
		Me.lblUserLogado.Size = New System.Drawing.Size(121, 17)
		Me.lblUserLogado.Text = "ToolStripStatusLabel1"
		'
		'lblMaquina
		'
		Me.lblMaquina.Name = "lblMaquina"
		Me.lblMaquina.Size = New System.Drawing.Size(121, 17)
		Me.lblMaquina.Text = "ToolStripStatusLabel1"
		'
		'lblOS
		'
		Me.lblOS.Name = "lblOS"
		Me.lblOS.Size = New System.Drawing.Size(121, 17)
		Me.lblOS.Text = "ToolStripStatusLabel1"
		'
		'ArquivoToolStripMenuItem
		'
		Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
		Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
		Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.ArquivoToolStripMenuItem.Text = "Arquivo"
		'
		'SairToolStripMenuItem
		'
		Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
		Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.SairToolStripMenuItem.Text = "Sair"
		'
		'FrmPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(897, 501)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FrmPrincipal"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Ideal Imóveis"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImóvelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CorretorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContratoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NovoContratoDeVendaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NovoContratoDeAluguelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImóveisToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContratosDeAluguelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RelatórioToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContratoDeAluguelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TipoDeImóvelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblUserLogado As ToolStripStatusLabel
	Friend WithEvents lblMaquina As ToolStripStatusLabel
	Friend WithEvents lblOS As ToolStripStatusLabel
	Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AluguelToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents VendaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
