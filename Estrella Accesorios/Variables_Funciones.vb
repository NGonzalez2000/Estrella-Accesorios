Imports System.IO

Module Funciones
	Public Enum Origen
		F_Articulos
		F_Ingresos
		F_Ventas
		F_QR
		F_Etiqueta
	End Enum

	Public Base As New Servidor_SQL

	Public Administrador As Boolean
	Public Usuario As Integer

	Public Function CCdec(ByVal Valor As String) As Decimal
		Try
			Dim Aux As String

			Aux = Replace(Replace(Replace(Valor, "$", ""), "%", ""), "#", "").Trim
			If Aux = "" Then Aux = "0"
			Return CDec(Aux)
		Catch ex As Exception
			Return 0
		End Try

	End Function

	Public Function Acortar_Ruta(Ruta As String, Largo_Maximo As Integer) As String
		Dim Archivo As String

		Archivo = Mid(Ruta, InStrRev(Ruta, "\") + 1)

		If Ruta.Length <= Largo_Maximo Then
			Acortar_Ruta = Ruta
		Else
			If Archivo.Length <= Largo_Maximo - 5 Then
				Acortar_Ruta = Mid(Ruta, 1, Largo_Maximo - 5 - Archivo.Length) + "...\" + Archivo
			Else
				Acortar_Ruta = Archivo
			End If
		End If
	End Function

	Public Function Importar_BD_CMD(Origen As String) As Boolean
		Try
			Dim Destino As String = My.Settings.Arch_Intercambio
			Dim ROrigen As IO.FileInfo = New System.IO.FileInfo(Origen)
			Dim RDestino As IO.FileInfo = New System.IO.FileInfo(Destino)
			Dim RutaOrigen As String = IO.Path.Combine(ROrigen.Directory.FullName, "Imagenes")
			Dim RutaDestino As String = IO.Path.Combine(RDestino.Directory.FullName, "Imagenes")

			If (Origen = Destino) Or (RutaOrigen = RutaDestino) Then
				MsgBox("El archivo o ruta de origen no puede ser el mismo que el arhchivo de intercambio")
				Return False
			Else
				If CopiarArchivo(Origen, Destino, True) Then
					If CopiarDirectorio(RutaOrigen, RutaDestino, True, True) Then
						Return True
					Else
						Return False
					End If
				Else
					Return False
				End If
			End If
		Catch Ex As Exception
			MsgBox("No se pudo importar la base de datos seleccionada: " & vbCrLf & Ex.Message)
			Return False
		End Try
	End Function

	Public Function Exportar_BD_CMD(Destino As String) As Boolean
		Try
			Dim Origen As String = My.Settings.Database
			Dim ROrigen As System.IO.FileInfo = New System.IO.FileInfo(Origen)
			Dim RDestino As System.IO.FileInfo = New System.IO.FileInfo(Destino)
			Dim RutaOrigen As String = IO.Path.Combine(ROrigen.Directory.FullName, "Imagenes")
			Dim RutaDestino As String = IO.Path.Combine(RDestino.Directory.FullName, "Imagenes")

			If (Origen = Destino) Or (ROrigen.Directory.FullName = RDestino.Directory.FullName) Then
				MsgBox("El archivo y la ubicación de exportación no puede ser el mismo que la Base de Datos")
				Return False
			Else
				If CopiarArchivo(Origen, Destino, True) Then
					If CopiarDirectorio(RutaOrigen, RutaDestino, True, True) Then
						Return True
					Else
						Return False
					End If
				Else
					Return False
				End If
			End If
		Catch Ex As Exception
			MsgBox("No se pudo exportar la base de datos y/o las imagenes" & vbCrLf & Ex.Message)
			Return False
		End Try
	End Function

	Public Function CopiarDirectorio(ByVal Origen As String, ByVal Destino As String, Optional ByVal SobreEscribir As Boolean = True, Optional ByVal CopiarSubDirectorios As Boolean = True) As Boolean

		Try
			'Obtiene los datos del directorio a copiar
			Dim Directorio As DirectoryInfo = New DirectoryInfo(Origen)

			'Verifica si existe el directorio sino genera excepción
			If Not Directorio.Exists Then

				'Genera una excepción si no encuentra el directorio
				Throw New DirectoryNotFoundException("No se a encontrado el directorio de Origen: " + Origen)

			Else

				'Verifica si existe el directorio de destino sino lo crea
				If Not Directory.Exists(Destino) Then

					Directory.CreateDirectory(Destino)

				End If

				'Obtiene los Archivos del directorio origen
				Dim Archivos() As FileInfo = Directorio.GetFiles()

				For Each Archivo As FileInfo In Archivos

					'Arma la ruta de destino del archivo
					Dim ArchivoDestino As String = Path.Combine(Destino, Archivo.Name)

					'Copia cada archivo dentro del directorio origen al destino
					If Not CopiarArchivo(Archivo.FullName, ArchivoDestino, SobreEscribir) Then

						Return False
						Exit Function

					End If

				Next

				If CopiarSubDirectorios Then

					'Obtiene los Subdirectorios del directorio origen
					Dim Directorios() As DirectoryInfo = Directorio.GetDirectories()

					For Each SubDirectorio As DirectoryInfo In Directorios

						'Arma la ruta de destino del Sub-Directorio
						Dim TempPath As String = Path.Combine(Destino, SubDirectorio.Name)

						'Copia cada Sub-Directorio
						If Not CopiarDirectorio(SubDirectorio.FullName, TempPath, SobreEscribir, CopiarSubDirectorios) Then
							Return False
							Exit Function
						End If

					Next

				End If

				'Copia del directorio exitosamente
				Return True

			End If

		Catch ex As Exception

			'Intercepta y muestra el error
			MsgBox(ex.Message)
			Return False

		End Try
	End Function

	Public Function CopiarArchivo(ByVal Origen As String, ByVal Destino As String, Optional ByVal Sobreescribir As Boolean = True) As Boolean

		Try

			'Obtiene los datos del Archivo origen
			Dim Archivo As FileInfo = New FileInfo(Origen)

			'Verifica que el archivo de origen exista
			If Not Archivo.Exists Then

				'Genera una excepción si no encuentra el archivo
				Throw New FileNotFoundException("No se a encontrado el archivo de Origen: ", Origen)

			Else

				If Sobreescribir Then

					'Copia el archivo utilizando la sobreescritura
					Archivo.CopyTo(Destino, True)

				Else

					'Obtiene información del archivo de destino
					Dim TempPath As FileInfo = New FileInfo(Destino)

					If Not TempPath.Exists Then

						'Copia el archivo de rigen si no existe el archivo de destino
						Archivo.CopyTo(Destino)

					End If

				End If

				'Copia realizada exitosa o ignorada
				Return True

			End If

		Catch ex As Exception

			'Intercepta y muestra el error
			MsgBox(ex.Message)
			Return False

		End Try
	End Function

	Public Function Proximo_Codigo(ByVal Campo As String, ByVal Tabla As String) As Integer
		Try
			If Campo.Trim <> "" And Tabla.Trim <> "" Then
				Dim Sql As String = "SELECT MAX(IIF(ISNULL(" + Campo + "), 0, " + Campo + "))+1 AS codigo FROM " + Tabla
				Dim Datos As OleDb.OleDbDataReader

				If Base.Ejecutar_SQL(Sql, Datos) Then
					If Datos.Read Then
						If IsNumeric(Datos.Item("codigo")) Then
							Return Datos.Item("codigo")
						Else
							Return 1
						End If
					Else
						Return 0
					End If
				Else
					Return 0
				End If
			Else
				Return 0
			End If
		Catch ex As Exception
			Return 0
		End Try
	End Function

	Public Function AbrirImagen(ByVal Archivo_Imagen As String) As Image
		Try
			Using Fs As New FileStream(Archivo_Imagen, FileMode.Open, FileAccess.Read)
				Dim Img = Image.FromStream(Fs)
				Return Img
			End Using
		Catch ex As Exception
			Return Nothing
		End Try
	End Function
End Module
