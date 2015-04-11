Imports System.Data.SqlClient

Public Class Conexao
	Public Shared Function ConexaoSQL() As SqlConnection
		Dim ocn As New SqlConnection("Data Source=Notenick;Initial Catalog=GabrielSIAEDB2015;Integrated Security=True")
		ocn.Open()
		Return ocn
	End Function
End Class
