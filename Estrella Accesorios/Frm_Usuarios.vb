Public Class Frm_Usuarios
    Dim ex As Int16
    Dim ey As Int16
    Dim Arrastre As Boolean

    Private Sub Habilitar()
        Modificar.Enabled = True
        Borrar.Enabled = True
    End Sub

    Private Sub Limpiar()
        D_Nombre.Text = ""
        D_Nombre.Tag = 0
        D_Contraseña.Text = ""
        D_Repetir.Text = ""
        D_Administrador.Checked = False
        D_Habilitado.Checked = False
    End Sub

    Private Sub Frm_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Tabla As OleDb.OleDbDataReader
        Dim Itm As ListViewItem
		Dim SQL As String = "SELECT usu_Id, usu_nombre, IIF(ISNULL(usu_password),'',usu_password) AS usu_password, usu_habilitado, usu_administrador FROM Usuarios ORDER BY usu_nombre"

		UseWaitCursor = True
        Cursor = Cursors.WaitCursor

        Me.Text = Titulo_Frm.Text
        Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
        Cuadro_Frm.SendToBack()
        Imagen_Frm.Location = New Point(3, 3)
        Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
        Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

        If Base.Ejecutar_SQL(SQL, Tabla) Then
            Do While Tabla.Read
                Itm = New ListViewItem With {
                    .Text = Tabla.Item("usu_id").ToString,
                    .Tag = Tabla.Item("usu_id")}
                Itm.SubItems.Add(Tabla.Item("usu_nombre"))
                Itm.SubItems(1).Tag = Tabla.Item("usu_password")
                Itm.SubItems.Add(IIf(Tabla.Item("usu_administrador"), "SI", "NO"))
                Itm.SubItems(2).Tag = Tabla.Item("usu_administrador")
                Itm.SubItems.Add(IIf(Tabla.Item("usu_habilitado"), "SI", "NO"))
				Itm.SubItems(3).Tag = Tabla.Item("usu_habilitado")

				Listado.Items.Add(Itm)
            Loop
        Else
            MsgBox("Se produjo un error al intentar recuperar los datos de USUARIOS!")
            Close()
        End If

        If Listado.Items.Count >= 1 Then
            Listado.Items(0).Selected = True
            Listado.Items(0).EnsureVisible()
        End If

        Limpiar()

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

    Private Sub D_Administrador_CheckedChanged(sender As Object, e As EventArgs) Handles D_Administrador.CheckedChanged
        If D_Nombre.Tag = 1 Then
            D_Administrador.Checked = True
            D_Habilitado.Checked = True

            Exit Sub
        End If
    End Sub

    Private Sub D_Habilitado_CheckedChanged(sender As Object, e As EventArgs) Handles D_Habilitado.CheckedChanged
        If D_Nombre.Tag = 1 Then
            D_Administrador.Checked = True
            D_Habilitado.Checked = True

            Exit Sub
        End If
    End Sub

	Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
		If Agregar.Text = "Agregar" Then
			'HABILITA PARA AGREGAR UNA NUEVA FORMA DE PAGO
			Datos.Enabled = True
			Listado.Enabled = False
			Modificar.Enabled = False
			Borrar.Enabled = False
			Limpiar()
			D_Nombre.Focus()
			Agregar.Text = "GRABAR"
		Else
			'GRABA LOS DATOS INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA EL NOMBRE
				If D_Nombre.Text.Trim = "" Then
					MsgBox("Debe ingresar una Nombre de usuario", vbInformation)
					D_Nombre.Focus()
					Exit Sub
				End If

				'VERIFICA LA CONTRASEÑA SEAN IGUALES
				If D_Contraseña.Text <> D_Repetir.Text Then
					MsgBox("No coinciden las contraseñas")
					D_Contraseña.Focus()
					Exit Sub
				End If

				Dim C_C As Int16 = Proximo_Codigo("usu_id", "Usuarios")

				If C_C <> 0 Then
					Dim Sql As String = "INSERT INTO Usuarios
											(usu_id, usu_nombre, usu_password, usu_habilitado, usu_administrador)
										VALUES
										   ( " + C_C.ToString + "
										   ,'" + D_Nombre.Text.Trim + "' 
										   ,'" + D_Contraseña.Text + "'
										   , " + D_Habilitado.Checked.ToString + "
										   , " + D_Administrador.Checked.ToString + ")"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Usuario agregado exitosamente!", vbInformation)
						Dim Itm As ListViewItem = New ListViewItem With {
						.Text = C_C.ToString, 'Codigo
						.Tag = C_C 'Codigo
						}
						Itm.SubItems.Add(D_Nombre.Text.Trim) 'Descripción
						Itm.SubItems(1).Tag = D_Contraseña.Text 'Contraseña
						Itm.SubItems.Add(IIf(D_Administrador.Checked, "SI", "NO")) 'Administrador
						Itm.SubItems(2).Tag = D_Administrador.Checked
						Itm.SubItems.Add(IIf(D_Habilitado.Checked, "SI", "NO")) ' Habilitado
						Itm.SubItems(3).Tag = D_Habilitado.Checked

						Listado.Items.Add(Itm)

						Cancelar.PerformClick()
						Itm.EnsureVisible()
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
					End If
				Else
					MsgBox("No se pudo generar el codigo para el usuario")
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

		Dim Sql As String

		If Modificar.Text = "Modificar" Then
			'HABILITA PARA MODIFICAR UN CLIENTE
			D_Nombre.Tag = Listado.SelectedItems(0).Tag
			D_Nombre.Text = Listado.SelectedItems(0).SubItems(Col_Nombre.Index).Text
			D_Contraseña.Text = Listado.SelectedItems(0).SubItems(Col_Nombre.Index).Tag
			D_Repetir.Text = Listado.SelectedItems(0).SubItems(Col_Nombre.Index).Tag
			D_Administrador.Checked = Listado.SelectedItems(0).SubItems(Col_Administrador.Index).Tag
			D_Habilitado.Checked = Listado.SelectedItems(0).SubItems(Col_Habilitado.Index).Tag
			Datos.Enabled = True
			Listado.Enabled = False
			Agregar.Enabled = False
			Modificar.Text = "GRABAR"
			Borrar.Enabled = False
			D_Nombre.Focus()
		Else
			'GRABA LOS DATOS INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA EL NOMBRE
				If D_Nombre.Text.Trim = "" Then
					MsgBox("Debe ingresar una Nombre de usuario", vbInformation)
					D_Nombre.Focus()
					Exit Sub
				End If

				'VERIFICA LA CONTRASEÑA SEAN IGUALES
				If D_Contraseña.Text <> D_Repetir.Text Then
					MsgBox("No coinciden las contraseñas")
					D_Contraseña.Focus()
					Exit Sub
				End If

				Sql = "UPDATE Usuarios
                        SET  usu_nombre = '" + D_Nombre.Text.Trim + "' 
                            ,usu_habilitado = " + D_Habilitado.Checked.ToString + "
                            ,usu_administrador = " + D_Administrador.Checked.ToString + "
							,usu_password = '" + D_Contraseña.Text + "'
                        WHERE usu_id = " + D_Nombre.Tag.ToString

				If Base.Ejecutar_SQL(Sql) Then
					MsgBox("Usuario modificado exitosamente!", vbInformation)

					If Usuario = D_Nombre.Tag Then

						Administrador = D_Administrador.Checked
						Dim Frm As Frm_Principal = CType(Owner, Frm_Principal)
						Frm.Estadisticas.Enabled = Administrador
						Frm.T_Opciones.Enabled = Administrador

						If Not D_Habilitado.Checked Then
							MsgBox("Se ha deshabilitado el usuario actual y se cerrara el programa")
							Application.Exit()
						End If
					End If

					With Listado.SelectedItems(0)
						.SubItems(Col_Nombre.Index).Text = D_Nombre.Text.Trim
						.SubItems(Col_Nombre.Index).Tag = D_Contraseña.Text
						.SubItems(Col_Administrador.Index).Text = IIf(D_Administrador.Checked, "SI", "NO")
						.SubItems(Col_Administrador.Index).Tag = D_Administrador.Checked
						.SubItems(Col_Habilitado.Index).Text = IIf(D_Habilitado.Checked, "SI", "NO")
						.SubItems(Col_Habilitado.Index).Tag = D_Habilitado.Checked
					End With

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
			If Listado.SelectedItems(0).Tag <> 1 Then
				Sql = "DELETE * FROM Usuarios WHERE usu_id = " + Listado.SelectedItems(0).Tag.ToString

				If Base.Ejecutar_SQL(Sql) Then
					MsgBox("Registro eliminado exitosamente!", vbInformation)
					Listado.Items.Remove(Listado.SelectedItems(0))
				Else
					MsgBox("No se pudo borrar el registro!", vbCritical)
				End If
			Else
				MsgBox("No se puede borrar el usuario principal")
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