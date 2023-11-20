Public Class Frm_Principal
    Dim ex As Int16
    Dim ey As Int16
    Dim Arrastre As Boolean

	Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Dim Dir As IO.DirectoryInfo = New IO.DirectoryInfo(IO.Path.Combine(Application.StartupPath, "Imagenes"))
		If Not Dir.Exists Then
			Dir.Create()
		End If

		Dir = New IO.DirectoryInfo(IO.Path.Combine(Application.StartupPath, "Imagenes\QR"))
		If Not Dir.Exists Then
			Dir.Create()
		End If

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		Cursor = Cursors.Default
		UseWaitCursor = False
	End Sub

	Private Sub Cerrar_Frm_Click(sender As Object, e As EventArgs) Handles Cerrar_Frm.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub Titulo_Frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseMove
		If Arrastre Then
			Me.Location = New Point(Me.Location.X + e.X - ex, Me.Location.Y + e.Y - ey)
		End If
	End Sub

	Private Sub Titulo_Frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseDown
		ex = e.X
		ey = e.Y
		Arrastre = True
	End Sub

	Private Sub Titulo_Frm_MouseUp(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseUp
		Arrastre = False
	End Sub

	Private Sub Frm_Principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;
										Data Source=" + My.Settings.Database + ";
										Persist Security Info=True;
										Jet OLEDB:Database Password=" + My.Settings.Password + ";
										User Id=" + My.Settings.Uid + ";"
		If Base.Conectar(CadenaConexion) Then
			Dim Frm As New Frm_Login
			AddOwnedForm(Frm)

			Frm.ShowDialog()
		Else
			MsgBox("No se pudo conectar con la base de datos!!!", vbCritical)

			Dim Frm As New Frm_Configuracion
			AddOwnedForm(Frm)

			Frm.ShowDialog()

			If Base.Conectado Then
				Dim Frm1 As New Frm_Login
				AddOwnedForm(Frm1)

				Frm1.ShowDialog()
			Else
				Application.Exit()
			End If
		End If
    End Sub

	Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
		If MsgBox("¿Esta seguro que desea salir?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Base.Cerrar_Conexion()
			Application.Exit()
		End If
	End Sub

	Private Sub Articulos_Click(sender As Object, e As EventArgs) Handles Articulos.Click
		Dim Frm As New Frm_Articulos
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click
		Dim Frm As New Frm_Ventas
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Forma_Pago_Click(sender As Object, e As EventArgs) Handles B_Forma_Pago.Click
		Dim Frm As New Frm_Forma_Pago
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Usuarios_Click(sender As Object, e As EventArgs) Handles B_Usuarios.Click
		Dim Frm As New Frm_Usuarios
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Proveedores_Click(sender As Object, e As EventArgs) Handles B_Proveedores.Click
		Dim Frm As New Frm_Proveedores
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Familias_Click(sender As Object, e As EventArgs) Handles B_Familias.Click
		Dim Frm As New Frm_Familias
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub Ingresos_Click(sender As Object, e As EventArgs) Handles Ingresos.Click
		Dim Frm As New Frm_Ingresos
		AddOwnedForm(Frm)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Exportar_Click(sender As Object, e As EventArgs) Handles B_Exportar.Click
		If MsgBox("¿Desea EXPORTAR los Datos del Sistema?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			S_DLG.CheckFileExists = False
			S_DLG.CheckPathExists = True
			S_DLG.Filter = "Archivos de Base de Datos (*.mdb)|*.mdb"
			S_DLG.FileName = "Exportar.mdb"
			S_DLG.FilterIndex = 1
			'CMD.RestoreDirectory = True

			If S_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim Destino As String = S_DLG.FileName
				If Exportar_BD_CMD(Destino) Then
					MsgBox("Exportación realizada con éxito!!!")
				End If
			End If
		End If
	End Sub

	Private Sub B_Importar_Click(sender As Object, e As EventArgs) Handles B_Importar.Click
		If MsgBox("Se va a proceder a actualizar la base de datos" & vbCrLf & "Esta acción no podra deshacerse" & vbCrLf & vbCrLf & "¿Está seguro que desea continuar?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			O_DLG.CheckFileExists = True
			O_DLG.CheckPathExists = True
			O_DLG.Filter = "Archivos de Base de Datos (*.mdb)|*.mdb"
			O_DLG.FileName = "Exportar.mdb"
			O_DLG.FilterIndex = 1
			'CMD.RestoreDirectory = True

			If O_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim Origen As String = O_DLG.FileName
				If Importar_BD_CMD(Origen) Then
					UseWaitCursor = True
					Cursor = Cursors.WaitCursor

					'Agrega USUARIOS que faltan
					Dim Sql As String = "INSERT INTO Usuarios
											SELECT Usuarios1.usu_id, Usuarios1.usu_nombre, Usuarios1.usu_password, Usuarios1.usu_habilitado, Usuarios1.usu_administrador
											FROM Usuarios1 LEFT JOIN Usuarios ON Usuarios1.usu_id = Usuarios.usu_id
											WHERE ((Usuarios1.usu_id) Not In (Usuarios.usu_id))"
					If Base.Ejecutar_SQL(Sql) Then
						'Actualiza datos USUARIOS
						Sql = "UPDATE Usuarios
								INNER JOIN Usuarios1 ON Usuarios.usu_id = Usuarios1.usu_id
								SET Usuarios.usu_nombre = Usuarios1.usu_nombre, 
									Usuarios.usu_habilitado = Usuarios1.usu_habilitado, 
									Usuarios.usu_administrador = Usuarios1.usu_administrador"
						If Base.Ejecutar_SQL(Sql) Then
							'Agrega PROVEEDORES que faltan
							Sql = "INSERT INTO Proveedores
									SELECT Proveedores1.pro_id, Proveedores1.pro_nombre
									FROM Proveedores1 LEFT JOIN Proveedores ON Proveedores1.pro_id = Proveedores.pro_id
									WHERE ((Proveedores1.pro_id) Not In (Proveedores.pro_id))"
							If Base.Ejecutar_SQL(Sql) Then
								'Actualiza datos PROVEEDORES
								Sql = "UPDATE Proveedores
										INNER JOIN Proveedores1 ON Proveedores.pro_id = Proveedores1.pro_id
										SET Proveedores.pro_nombre = Proveedores1.pro_nombre"
								If Base.Ejecutar_SQL(Sql) Then
									'Agrega FAMILIAS que faltan
									Sql = "INSERT INTO Familias
											SELECT Familias1.fam_id, Familias1.fam_descripcion
											FROM Familias1 LEFT JOIN Familias ON Familias1.fam_id = Familias.fam_id
											WHERE ((Familias1.fam_id) Not In (Familias.fam_id))"
									If Base.Ejecutar_SQL(Sql) Then
										'Actualiza datos FAMILIAS
										Sql = "UPDATE Familias
												INNER JOIN Familias1 ON Familias.fam_id = Familias1.fam_id
												SET Familias.fam_descripcion = Familias1.fam_descripcion"
										If Base.Ejecutar_SQL(Sql) Then
											'Agrega SUB-FAMILIAS que faltan
											Sql = "INSERT INTO Sub_Familias
													SELECT Sub_Familias1.sfa_id, Sub_Familias1.sfa_descripcion, Sub_Familias1.fam_id
													FROM Sub_Familias1 LEFT JOIN Sub_Familias ON Sub_Familias1.sfa_id = Sub_Familias.sfa_id
													WHERE ((Sub_Familias1.sfa_id) Not In (Sub_Familias.sfa_id))"
											If Base.Ejecutar_SQL(Sql) Then
												'Actualiza datos FAMILIAS
												Sql = "UPDATE Sub_Familias
														INNER JOIN Sub_Familias1 ON Sub_Familias.sfa_id = Sub_Familias1.sfa_id
														SET Sub_Familias.sfa_descripcion = Sub_Familias1.sfa_descripcion,
															Sub_Familias.fam_id = Sub_Familias1.fam_id"
												If Base.Ejecutar_SQL(Sql) Then
													'Agrega ARTICULOS que faltan
													Sql = "INSERT INTO Articulos
															SELECT  Articulos1.art_id, Articulos1.art_codigo, Articulos1.art_descripcion, Articulos1.art_codigo_barras, Articulos1.art_importe_compra, Articulos1.art_importe_venta,
																	0 AS art_stock_inicial, Articulos1.art_stock_minimo, Articulos1.art_fecha, Articulos1.usu_id, Articulos1.sfa_id, Articulos1.pro_id
															FROM Articulos1 LEFT JOIN Articulos ON Articulos1.art_id = Articulos.art_id
															WHERE ((Articulos1.art_id) Not In (Articulos.art_id))"
													If Base.Ejecutar_SQL(Sql) Then
														'Actualiza datos ARTICULOS
														Sql = "UPDATE Articulos
																INNER JOIN Articulos1 ON Articulos.art_id = Articulos1.art_id
																SET Articulos.art_codigo = Articulos1.art_codigo, 
																	Articulos.art_descripcion = Articulos1.art_descripcion, 
																	Articulos.art_codigo_barras = Articulos1.art_codigo_barras, 
																	Articulos.art_importe_compra = Articulos1.art_importe_compra, 
																	Articulos.art_importe_venta = Articulos1.art_importe_venta,
																	Articulos.art_fecha = Articulos1.art_fecha"
														If Base.Ejecutar_SQL(Sql) Then
															MsgBox("La actualización del sistema se realizó correctamente!")
														Else
															MsgBox("Se produjo un error al actualizar los datos de ARTICULOS!!!")
														End If
													Else
														MsgBox("Se produjo un error al agregar los ARTICULOS faltantes!!!")
													End If
												Else
													MsgBox("Se produjo un error al actualizar los datos de SUB-FAMILIAS!!!")
												End If
											Else
												MsgBox("Se produjo un error al agregar las SUB-FAMILIAS faltantes!!!")
											End If
										Else
											MsgBox("Se produjo un error al actualizar los datos de FAMILIAS!!!")
										End If
									Else
										MsgBox("Se produjo un error al agregar las FAMILIAS faltantes!!!")
									End If
								Else
									MsgBox("Se produjo un error al actualizar los datos de PROVEEDORES!!!")
								End If
							Else
								MsgBox("Se produjo un error al agregar los PROVEEDORES faltantes!!!")
							End If
						Else
							MsgBox("Se produjo un error al actualizar los datos de USUARIOS!!!")
						End If
					Else
						MsgBox("Se produjo un error al agregar los USUARIOS faltantes!!!")
					End If

					UseWaitCursor = False
					Cursor = Cursors.Default
				End If
			End If
		End If
	End Sub

	Private Sub B_Etiquetas_QR_Click(sender As Object, e As EventArgs) Handles B_Etiquetas_QR.Click
		Dim Frm As New Frm_QR

		AddOwnedForm(Frm_Vista_Previa)

		Frm.ShowDialog()
	End Sub

	Private Sub B_Configuracion_Click(sender As Object, e As EventArgs) Handles B_Configuracion.Click
		Dim Frm As New Frm_Configuracion
		AddOwnedForm(Frm)

		Frm.ShowDialog()

		If Base.Conectado Then
			Dim Frm1 As New Frm_Login
			AddOwnedForm(Frm1)

			Frm1.ShowDialog()
		Else
			Application.Exit()
		End If
	End Sub

	Private Sub B_Etiquetas_Estantes_Click(sender As Object, e As EventArgs) Handles B_Etiquetas_Estantes.Click
		Dim Frm As New Frm_Etiqueta

		AddOwnedForm(Frm_Vista_Previa)

		Frm.ShowDialog()
	End Sub
End Class