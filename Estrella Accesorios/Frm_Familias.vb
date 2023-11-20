Public Class Frm_Familias
	Dim ex As Int16
	Dim ey As Int16
	Dim Arrastre As Boolean

	Private Sub Habilitar_FAM()
		Modificar_FAM.Enabled = True
		Borrar_FAM.Enabled = True
	End Sub

	Private Sub Limpiar_FAM()
		D_Descripcion_FAM.Text = ""
	End Sub

	Private Sub Habilitar_SFA()
		Modificar_SFA.Enabled = True
		Borrar_SFA.Enabled = True
	End Sub

	Private Sub Limpiar_SFA()
		D_Descripcion_SFA.Text = ""
	End Sub

	Private Sub Frm_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim Tabla As OleDb.OleDbDataReader
		Dim Itm As ListViewItem
		Dim SQL As String = "SELECT * FROM Familias ORDER BY fam_descripcion ASC"

		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		Modificar_FAM.Enabled = False
		Borrar_FAM.Enabled = False

		Limpiar_FAM()
		Limpiar_SFA()

		Listado_FAM.Items.Clear()

		If Base.Ejecutar_SQL(SQL, Tabla) Then
			Do While Tabla.Read
				'add items to ListView
				Itm = New ListViewItem With {
					.Text = Tabla.Item("fam_id").ToString'Codigo
					}
				Itm.SubItems.Add(Trim(Tabla.Item("fam_descripcion"))) 'Descripción
				Listado_FAM.Items.Add(Itm)
			Loop
			Tabla.Close()
		End If

		If Listado_FAM.Items.Count >= 1 Then
			Listado_FAM.Items(0).Selected = True
			Listado_FAM.Items(0).EnsureVisible()
		End If

		Cursor = Cursors.Default
		UseWaitCursor = False
	End Sub

	Private Sub Cerrar_Frm_Click(sender As Object, e As EventArgs) Handles Cerrar_Frm.Click
		Close()
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

	Private Sub Agregar_FAM_Click(sender As Object, e As EventArgs) Handles Agregar_FAM.Click
		If Agregar_FAM.Text = "Agregar" Then
			'HABILITA PARA Agregar_FAM UNA NUEVA Familia
			Datos_FAM.Enabled = True
			Listado_FAM.Enabled = False
			Modificar_FAM.Enabled = False
			Borrar_FAM.Enabled = False
			Limpiar_FAM()
			D_Descripcion_FAM.Focus()
			Agregar_FAM.Text = "GRABAR"

			Botones_SFA.Enabled = False
			Listado_SFA.Enabled = False
		Else
			'GRABA LOS Datos_FAM INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then

				If Trim(D_Descripcion_FAM.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion_FAM.Focus()
					Exit Sub
				End If

				Dim C_C As Int16 = Proximo_Codigo("fam_id", "Familias")

				If C_C <> 0 Then
					Dim Sql As String = "INSERT INTO Familias	(fam_id, fam_descripcion)
										VALUES (" + C_C.ToString + ",'" + Trim(D_Descripcion_FAM.Text) + "')"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Familia agregada exitosamente!", vbInformation)
						Dim Itm As ListViewItem = New ListViewItem With {
						.Text = C_C.ToString 'Codigo
						}
						Itm.SubItems.Add(Trim(D_Descripcion_FAM.Text)) 'Descripción

						Listado_FAM.Items.Add(Itm)

						Cancelar_FAM_Click()
						Itm.EnsureVisible()
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
					End If
				Else
					MsgBox("Se produjo un error al generar el código de Familia")
				End If
			End If
		End If
	End Sub

	Private Sub Listado_FAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado_FAM.SelectedIndexChanged
		Listado_SFA.Items.Clear()

		If Listado_FAM.SelectedItems.Count = 1 Then
			Habilitar_FAM()

			Dim SQL As String = "SELECT * FROM Sub_Familias WHERE fam_id = " + Listado_FAM.SelectedItems(0).Text + " ORDER BY sfa_descripcion"
			Dim Tabla As OleDb.OleDbDataReader
			Dim Itm As ListViewItem

			If Base.Ejecutar_SQL(SQL, Tabla) Then
				Do While Tabla.Read
					Itm = New ListViewItem With {.Text = Tabla.Item("sfa_id").ToString}
					Itm.SubItems.Add(Tabla.Item("sfa_descripcion"))

					Listado_SFA.Items.Add(Itm)
				Loop

				Botones_SFA.Enabled = True
				Listado_SFA.Enabled = True
			Else
					MsgBox("Se produjo un error al recuperar los datos de la sub-familia")
			End If
		Else
			Modificar_FAM.Enabled = False
			Borrar_FAM.Enabled = False

			Botones_SFA.Enabled = False
			Listado_SFA.Enabled = False
		End If
	End Sub

	Private Sub Modificar_FAM_Click(sender As Object, e As EventArgs) Handles Modificar_FAM.Click
		If Modificar_FAM.Text = "Modificar" Then
			D_Descripcion_FAM.Tag = Listado_FAM.SelectedItems(0).SubItems(Col_Codigo_Fam.Index).Text
			D_Descripcion_FAM.Text = Listado_FAM.SelectedItems(0).SubItems(Col_Descripcion_Fam.Index).Text
			Datos_FAM.Enabled = True
			Listado_FAM.Enabled = False
			Agregar_FAM.Enabled = False
			Modificar_FAM.Text = "GRABAR"
			Borrar_FAM.Enabled = False
			D_Descripcion_FAM.Focus()

			Botones_SFA.Enabled = False
			Listado_SFA.Enabled = False
		Else
			'GRABA LOS Datos_FAM INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA LA DESCRIPCION
				If Trim(D_Descripcion_FAM.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion_FAM.Focus()
					Exit Sub
				End If

				Dim Sql As String = "UPDATE Familias
										SET  fam_descripcion = '" + Trim(D_Descripcion_FAM.Text) + "'
										WHERE fam_id = " + D_Descripcion_FAM.Tag

				If Base.Ejecutar_SQL(Sql) Then
					MsgBox("Familia modificada exitosamente!", vbInformation)

					Listado_FAM.SelectedItems(0).SubItems(Col_Descripcion_Fam.Index).Text = Trim(D_Descripcion_FAM.Text)

					Cancelar_FAM_Click()
					Habilitar_FAM()

				Else
					MsgBox("Se produjo un error al grabar los datos!", vbCritical)
				End If
			End If
		End If
	End Sub

	Private Sub Cancelar_FAM_Click() Handles Cancelar_FAM.Click
		Limpiar_FAM()
		Datos_FAM.Enabled = False
		Listado_FAM.Enabled = True
		Agregar_FAM.Text = "Agregar"
		Agregar_FAM.Enabled = True
		Modificar_FAM.Text = "Modificar"
		Modificar_FAM.Enabled = False
		Borrar_FAM.Enabled = False
		Agregar_FAM.Focus()

		If Listado_FAM.SelectedItems.Count = 1 Then
			Modificar_FAM.Enabled = True
			Borrar_FAM.Enabled = True

			Botones_SFA.Enabled = True
			Listado_SFA.Enabled = True
		End If
	End Sub

	Private Sub Borrar_FAM_Click(sender As Object, e As EventArgs) Handles Borrar_FAM.Click
		Dim Sql As String

		If MsgBox("¿Esta seguro que desea brorrar el registro seleccionado?" & vbCrLf & Listado_FAM.SelectedItems(0).SubItems(1).Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Sql = "DELETE * FROM Familias WHERE fam_id = " + Listado_FAM.SelectedItems(0).SubItems(0).Text

			If Base.Ejecutar_SQL(Sql) Then
				MsgBox("Registro eliminado exitosamente!", vbInformation)
				Listado_FAM.Items.Remove(Listado_FAM.SelectedItems(0))
			Else
				MsgBox("No se pudo borrar el registro!", vbCritical)
			End If
		End If
	End Sub

	Private Sub Listado_FAM_DoubleClick(sender As Object, e As EventArgs) Handles Listado_FAM.DoubleClick
		If Listado_FAM.SelectedItems.Count = 1 Then
			Modificar_FAM_Click(sender, e)
		End If
	End Sub

	'******************************************************************************************************************************************
	'******************************************************************************************************************************************
	'******************************************************************************************************************************************
	'******************************************************************************************************************************************

	Private Sub Agregar_SFA_Click(sender As Object, e As EventArgs) Handles Agregar_SFA.Click
		If Agregar_SFA.Text = "Agregar" Then
			'HABILITA PARA Agregar_SFA UNA NUEVA Familia
			Datos_SFA.Enabled = True
			Listado_SFA.Enabled = False
			Modificar_SFA.Enabled = False
			Borrar_SFA.Enabled = False
			Limpiar_SFA()
			D_Descripcion_SFA.Focus()
			Agregar_SFA.Text = "GRABAR"

			Botones_FAM.Enabled = False
			Listado_FAM.Enabled = False
		Else
			'GRABA LOS Datos_SFA INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then

				If Trim(D_Descripcion_SFA.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion_SFA.Focus()
					Exit Sub
				End If

				Dim C_C As Int16 = Proximo_Codigo("sfa_id", "Sub_Familias")

				If C_C <> 0 Then
					Dim Sql As String = "INSERT INTO Sub_Familias	(sfa_id, sfa_descripcion, fam_id)
                         VALUES ( " + C_C.ToString + "
								,'" + Trim(D_Descripcion_SFA.Text) + "'
								, " + Listado_FAM.SelectedItems(0).Text + ")"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Sub-Familia agregada exitosamente!", vbInformation)
						Dim Itm As ListViewItem = New ListViewItem With {
						.Text = C_C.ToString 'Codigo
						}
						Itm.SubItems.Add(Trim(D_Descripcion_SFA.Text)) 'Descripción

						Listado_SFA.Items.Add(Itm)

						Cancelar_SFA_Click()
						Itm.EnsureVisible()
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
					End If
				Else
					MsgBox("Se produjo un error al generar el código de la Sub-Familia")
				End If
			End If
		End If
	End Sub

	Private Sub Listado_SFA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado_SFA.SelectedIndexChanged
		If Listado_SFA.SelectedItems.Count = 1 Then
			Habilitar_SFA()
		Else
			Modificar_SFA.Enabled = False
			Borrar_SFA.Enabled = False
		End If
	End Sub

	Private Sub Modificar_SFA_Click(sender As Object, e As EventArgs) Handles Modificar_SFA.Click
		If Modificar_SFA.Text = "Modificar" Then
			D_Descripcion_SFA.Tag = Listado_SFA.SelectedItems(0).SubItems(Col_Codigo_SFA.Index).Text
			D_Descripcion_SFA.Text = Listado_SFA.SelectedItems(0).SubItems(Col_Descripcion_SFA.Index).Text
			Datos_SFA.Enabled = True
			Listado_SFA.Enabled = False
			Agregar_SFA.Enabled = False
			Modificar_SFA.Text = "GRABAR"
			Borrar_SFA.Enabled = False
			D_Descripcion_SFA.Focus()

			Botones_FAM.Enabled = False
			Listado_FAM.Enabled = False
		Else
			'GRABA LOS Datos_SFA INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA LA DESCRIPCION
				If Trim(D_Descripcion_SFA.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion_SFA.Focus()
					Exit Sub
				End If

				Dim Sql As String = "UPDATE Sub_Familias
										SET  sfa_descripcion = '" + Trim(D_Descripcion_SFA.Text) + "'
										WHERE sfa_id = " + D_Descripcion_SFA.Tag

				If Base.Ejecutar_SQL(Sql) Then
					MsgBox("Sub-Familia modificada exitosamente!", vbInformation)

					Listado_SFA.SelectedItems(0).SubItems(Col_Descripcion_SFA.Index).Text = Trim(D_Descripcion_SFA.Text)

					Cancelar_SFA_Click()
					Habilitar_SFA()

				Else
					MsgBox("Se produjo un error al grabar los datos!", vbCritical)
				End If
			End If
		End If
	End Sub

	Private Sub Cancelar_SFA_Click() Handles Cancelar_SFA.Click
		Limpiar_SFA()
		Datos_SFA.Enabled = False
		Listado_SFA.Enabled = True
		Agregar_SFA.Text = "Agregar"
		Agregar_SFA.Enabled = True
		Modificar_SFA.Text = "Modificar"
		Modificar_SFA.Enabled = False
		Borrar_SFA.Enabled = False
		Agregar_SFA.Focus()

		Botones_FAM.Enabled = True
		Listado_FAM.Enabled = True

		If Listado_SFA.SelectedItems.Count = 1 Then
			Modificar_SFA.Enabled = True
			Borrar_SFA.Enabled = True
		End If
	End Sub

	Private Sub Borrar_SFA_Click(sender As Object, e As EventArgs) Handles Borrar_SFA.Click
		Dim Sql As String

		If MsgBox("¿Esta seguro que desea brorrar el registro seleccionado?" & vbCrLf & Listado_SFA.SelectedItems(0).SubItems(1).Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Sql = "DELETE * FROM Sub_Familias WHERE sfa_id = " + Listado_SFA.SelectedItems(0).SubItems(0).Text

			If Base.Ejecutar_SQL(Sql) Then
				MsgBox("Registro eliminado exitosamente!", vbInformation)
				Listado_SFA.Items.Remove(Listado_SFA.SelectedItems(0))
			Else
				MsgBox("No se pudo borrar el registro!", vbCritical)
			End If
		End If
	End Sub

	Private Sub Listado_SFA_DoubleClick(sender As Object, e As EventArgs) Handles Listado_SFA.DoubleClick
		If Listado_SFA.SelectedItems.Count = 1 Then
			Modificar_SFA_Click(sender, e)
		End If
	End Sub

	Private Sub Cancelar_SFA_Click(sender As Object, e As EventArgs) Handles Cancelar_SFA.Click

	End Sub

	Private Sub Cancelar_FAM_Click(sender As Object, e As EventArgs) Handles Cancelar_FAM.Click

	End Sub
End Class