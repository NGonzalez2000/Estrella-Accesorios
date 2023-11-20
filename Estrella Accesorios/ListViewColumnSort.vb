Public Class ListViewColumnSort
	Implements IComparer

	Public Enum TipoCompare
		CADENA
		NUMERO
		FECHA
	End Enum

	Private ReadOnly CompararPor As TipoCompare
	Private ReadOnly ColumnIndex As Integer
	Private ReadOnly Sorting As SortOrder

	Public Sub New()
		ColumnIndex = 0
	End Sub

	' Constructores
	Sub New(ByVal Columna As Integer, ByVal Tipo_Dato As String, ByRef Orden As SortOrder)
		ColumnIndex = Columna

		'
		' El tipo de datos de la columna en la que se ha pulsado
		Select Case UCase(Trim(Tipo_Dato))
			Case "N"  ' NUMERO
				CompararPor = TipoCompare.NUMERO
			Case "F"  ' FECHA
				CompararPor = TipoCompare.FECHA
			Case Else ' CADENA
				CompararPor = TipoCompare.CADENA
		End Select

		'
		' Asignar el orden de clasificación
		If Orden = SortOrder.Ascending Then
			Sorting = SortOrder.Descending
		Else
			Sorting = SortOrder.Ascending
		End If

		Orden = Sorting
	End Sub
	'
	Public Overridable Function Compare(ByVal A As Object,
									ByVal B As Object) As Integer _
									Implements IComparer.Compare
		'
		' Esta función devolverá:
		'   -1 si el primer elemento es menor que el segundo
		'    0 si los dos son iguales
		'    1 si el primero es mayor que el segundo
		'
		Dim Menor As Integer = -1, Mayor As Integer = 1
		Dim S1, S2 As String
		Dim Style As Globalization.NumberStyles
		Dim Provider As Globalization.CultureInfo

		'
		If Sorting = SortOrder.None Then
			Return 0
		End If
		'
		' Convertir el texto en el formato adecuado
		' y tomar el texto de la columna en la que se ha pulsado
		S1 = DirectCast(A, ListViewItem).SubItems(ColumnIndex).Text
		S2 = DirectCast(B, ListViewItem).SubItems(ColumnIndex).Text
		'
		' Asignar cuando es menor o mayor,
		' dependiendo del orden de clasificación
		If Sorting = SortOrder.Descending Then
			Menor = 1
			Mayor = -1
		End If
		'
		Select Case CompararPor
			Case TipoCompare.FECHA
				' Si da error, se comparan como cadenas
				Try
					Dim F1 As Date = DateTime.Parse(S1)
					Dim F2 As Date = DateTime.Parse(S2)
					If F1 < F2 Then
						Return Menor
					ElseIf F1 = F2 Then
						Return 0
					Else
						Return Mayor
					End If
				Catch
					'Return s1.CompareTo(s2) * mayor
					Return System.String.Compare(S1, S2, True) * Mayor
				End Try
			Case TipoCompare.NUMERO
				' Si da error, se comparan como cadenas
				Try
					Style = Globalization.NumberStyles.Number Or Globalization.NumberStyles.Currency
					Provider = New Globalization.CultureInfo("es-ES")

					Dim N1 As Decimal = Decimal.Parse(CDec(S1), Style, Provider)
					Dim N2 As Decimal = Decimal.Parse(CDec(S2), Style, Provider)
					If N1 < N2 Then
						Return Menor
					ElseIf N1 = N2 Then
						Return 0
					Else
						Return Mayor
					End If
				Catch
					Return System.String.Compare(S1, S2, True) * Mayor
				End Try
			Case Else
				'Case TipoCompare.Cadena
				Return System.String.Compare(S1, S2, True) * Mayor
		End Select
	End Function
End Class