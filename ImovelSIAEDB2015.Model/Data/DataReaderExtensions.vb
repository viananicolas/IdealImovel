Imports System.Runtime.CompilerServices

Module DataReaderExtensions
	<Extension()>
	Public Function GetStringOrNull(ByVal reader As IDataReader, ByVal ordinal As Integer) As String
		If reader.IsDBNull(ordinal) Then
			Return Nothing
		Else
			Return reader.GetString(ordinal)
		End If
	End Function
	<Extension()>
	Public Function GetStringOrNull(ByVal reader As IDataReader, ByVal columnname As String) As String

		Return reader.GetStringOrNull(reader.GetOrdinal(columnname))
	End Function

	<Extension()>
	Public Function GeDateTimeOrNull(ByVal reader As IDataReader, ByVal ordinal As Integer) As Date
		If reader.IsDBNull(ordinal) Then
			Return Nothing
		Else
			Return reader.GetDateTime(ordinal)
		End If
	End Function
	<Extension()>
	Public Function GeDateTimeOrNull(ByVal reader As IDataReader, ByVal columnname As String) As Date

		Return reader.GeDateTimeOrNull(reader.GetOrdinal(columnname))
	End Function


	<Extension()>
	Public Function GetByteOrNull(ByVal reader As IDataReader, ByVal ordinal As Integer) As Byte
		If reader.IsDBNull(ordinal) Then
			Return Nothing
		Else
			Return reader.GetByte(ordinal)
		End If
	End Function
	<Extension()>
	Public Function GetByteOrNull(ByVal reader As IDataReader, ByVal columnname As String) As Byte

		Return reader.GetByteOrNull(reader.GetOrdinal(columnname))
	End Function


End Module
