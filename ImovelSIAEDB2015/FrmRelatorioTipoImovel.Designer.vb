<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmRelatorioTipoImovel
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Me.ImovelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.GabrielSIAEDB2015DataSet1 = New ImovelSIAEDB2015.View.GabrielSIAEDB2015DataSet1()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.ImovelTableAdapter = New ImovelSIAEDB2015.View.GabrielSIAEDB2015DataSet1TableAdapters.ImovelTableAdapter()
		CType(Me.ImovelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GabrielSIAEDB2015DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ImovelBindingSource
		'
		Me.ImovelBindingSource.DataMember = "Imovel"
		Me.ImovelBindingSource.DataSource = Me.GabrielSIAEDB2015DataSet1
		'
		'GabrielSIAEDB2015DataSet1
		'
		Me.GabrielSIAEDB2015DataSet1.DataSetName = "GabrielSIAEDB2015DataSet1"
		Me.GabrielSIAEDB2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		ReportDataSource1.Name = "dtsTipoImovel"
		ReportDataSource1.Value = Me.ImovelBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ImovelSIAEDB2015.View.RptTipoImovel.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(5, 7)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.Size = New System.Drawing.Size(600, 309)
		Me.ReportViewer1.TabIndex = 0
		'
		'ImovelTableAdapter
		'
		Me.ImovelTableAdapter.ClearBeforeFill = True
		'
		'FrmRelatorioTipoImovel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(617, 328)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Name = "FrmRelatorioTipoImovel"
		Me.Text = "Relatório por Tipo de Imóvel"
		CType(Me.ImovelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GabrielSIAEDB2015DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents ImovelBindingSource As BindingSource
	Friend WithEvents GabrielSIAEDB2015DataSet1 As GabrielSIAEDB2015DataSet1
	Friend WithEvents ImovelTableAdapter As GabrielSIAEDB2015DataSet1TableAdapters.ImovelTableAdapter
End Class
