<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>	_
Partial Class FrmRelatorioContratoAluguel
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
		Me.ContratoAluguelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.GabrielSIAEDB2015DataSet = New ImovelSIAEDB2015.View.GabrielSIAEDB2015DataSet()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.ContratoAluguelTableAdapter = New ImovelSIAEDB2015.View.GabrielSIAEDB2015DataSetTableAdapters.ContratoAluguelTableAdapter()
		CType(Me.ContratoAluguelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GabrielSIAEDB2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ContratoAluguelBindingSource
		'
		Me.ContratoAluguelBindingSource.DataMember = "ContratoAluguel"
		Me.ContratoAluguelBindingSource.DataSource = Me.GabrielSIAEDB2015DataSet
		'
		'GabrielSIAEDB2015DataSet
		'
		Me.GabrielSIAEDB2015DataSet.DataSetName = "GabrielSIAEDB2015DataSet"
		Me.GabrielSIAEDB2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		ReportDataSource1.Name = "DataSet1"
		ReportDataSource1.Value = Me.ContratoAluguelBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ImovelSIAEDB2015.RptContratoAluguel.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(-1, 2)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.Size = New System.Drawing.Size(839, 420)
		Me.ReportViewer1.TabIndex = 0
		'
		'ContratoAluguelTableAdapter
		'
		Me.ContratoAluguelTableAdapter.ClearBeforeFill = True
		'
		'FrmRelatorioContratoAluguel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(839, 422)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Name = "FrmRelatorioContratoAluguel"
		Me.Text = "Relatório de Contratos de Aluguel"
		CType(Me.ContratoAluguelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GabrielSIAEDB2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents ContratoAluguelBindingSource As BindingSource
	Friend WithEvents GabrielSIAEDB2015DataSet As GabrielSIAEDB2015DataSet
	Friend WithEvents ContratoAluguelTableAdapter As GabrielSIAEDB2015DataSetTableAdapters.ContratoAluguelTableAdapter
End Class
