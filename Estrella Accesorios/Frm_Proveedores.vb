Public Class Frm_Proveedores
	Dim ex As Int16
	Dim ey As Int16
	Dim Arrastre As Boolean

	Private Sub Habilitar()
		Modificar.Enabled = True
		Borrar.Enabled = True
	End Sub

	Private Sub Limpiar()
		D_Descripcion.Text = ""
	End Sub

	Private Sub Frm_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim Tabla As OleDb.OleDbDataReader
		Dim Itm As ListViewItem
		Dim SQL As String

		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		Modificar.Enabled = False
		Borrar.Enabled = False

		Limpiar()

		Listado.Items.Clear()
		SQL = "SELECT * FROM Proveedores ORDER BY pro_nombre ASC"
		If Base.Ejecutar_SQL(SQL, Tabla) Then
			Do While Tabla.Read
				'add items to ListView
				Itm = New ListViewItem With {
					.Text = Tabla.Item("pro_id").ToString'Codigo
					}
				Itm.SubItems.Add(Trim(Tabla.Item("pro_nombre"))) 'Nombre
				Listado.Items.Add(Itm)
			Loop
			Tabla.Close()
		End If

		If Listado.Items.Count >= 1 Then
			Listado.Items(0).Selected = True
			Listado.Items(0).EnsureVisible()
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

	Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
		If Agregar.Text = "Agregar" Then
			'HABILITA PARA AGREGAR UNA NUEVA Proveedor
			Datos.Enabled = True
			Listado.Enabled = False
			Modificar.Enabled = False
			Borrar.Enabled = False
			Limpiar()
			D_Descripcion.Focus()
			Agregar.Text = "GRABAR"
		Else
			'GRABA LOS DATOS INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA EL CODIGO AFIP
				If Trim(D_Descripcion.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion.Focus()
					Exit Sub
				End If

				Dim C_C As Int16 = Proximo_Codigo("pro_id", "Proveedores")

				If C_C <> 0 Then
					Dim Sql As String = "INSERT INTO Proveedores
											(pro_id, pro_nombre)
										VALUES
											( " + C_C.ToString + "
											,'" + Trim(D_Descripcion.Text) + "')"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Proveedor agregado exitosamente!", vbInformation)
						Dim Itm As ListViewItem = New ListViewItem With {
						.Text = C_C.ToString 'Codigo
						}
						Itm.SubItems.Add(Trim(D_Descripcion.Text)) 'Descripción

						Listado.Items.Add(Itm)

						Cancelar.PerformClick()

						Itm.EnsureVisible()
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
					End If
				Else
					MsgBox("Se produjo un error al generar el código de Proveedor")
				End If
			End If
		End If
	End Sub

	Private Sub Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado.SelectedIndexChanged
		If Listado.SelectedItems.Count = 1 Then
			Habilitar()
		Else
			Modificar.Enabled = False
			Borrar.Enabled = False
		End If
	End Sub

	Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

		If Modificar.Text = "Modificar" Then
			'HABILITA PARA MODIFICAR UN CLIENTE
			D_Descripcion.Tag = Listado.SelectedItems(0).SubItems(Col_Codigo.Index).Text
			D_Descripcion.Text = Listado.SelectedItems(0).SubItems(Col_Descripcion.Index).Text
			Datos.Enabled = True
			Listado.Enabled = False
			Agregar.Enabled = False
			Modificar.Text = "GRABAR"
			Borrar.Enabled = False
			D_Descripcion.Focus()
		Else
			'GRABA LOS DATOS INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA LA DESCRIPCION
				If Trim(D_Descripcion.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion.Focus()
					Exit Sub
				End If

				Dim Sql As String = "UPDATE Proveedores
										SET  pro_nombre = '" + Trim(D_Descripcion.Text) + "'
										WHERE pro_id = " + D_Descripcion.Tag

				If Base.Ejecutar_SQL(Sql) Then
					MsgBox("Proveedor modificado exitosamente!", vbInformation)

					Listado.SelectedItems(0).SubItems(Col_Descripcion.Index).Text = Trim(D_Descripcion.Text)

					Cancelar.PerformClick()
					Habilitar()
				Else
					MsgBox("Se produjo un error al grabar los datos!", vbCritical)
				End If
			End If
		End If
	End Sub

	Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
		Dim Sql As String

		If MsgBox("¿Esta seguro que desea brorrar el registro seleccionado?" & vbCrLf & Listado.SelectedItems(0).SubItems(1).Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Sql = "DELETE * FROM Proveedores WHERE pro_id = " + Listado.SelectedItems(0).SubItems(0).Text

			If Base.Ejecutar_SQL(Sql) Then
				MsgBox("Registro eliminado exitosamente!", vbInformation)
				Listado.Items.Remove(Listado.SelectedItems(0))
			Else
				MsgBox("No se pudo borrar el registro!", vbCritical)
			End If
		End If
	End Sub

	Private Sub Listado_DoubleClick(sender As Object, e As EventArgs) Handles Listado.DoubleClick
		If Listado.SelectedItems.Count = 1 Then
			Modificar_Click(sender, e)
		End If
	End Sub

	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
		Limpiar()
		Datos.Enabled = False
		Listado.Enabled = True
		Agregar.Text = "Agregar"
		Agregar.Enabled = True
		Modificar.Text = "Modificar"
		Modificar.Enabled = False
		Borrar.Enabled = False
		Agregar.Focus()

		If Listado.SelectedItems.Count = 1 Then
			Modificar.Enabled = True
			Borrar.Enabled = True
		End If
	End Sub
End Class