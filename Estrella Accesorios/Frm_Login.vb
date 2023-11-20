Public Class Frm_Login
    Dim ex As Int16
    Dim ey As Int16
	Dim Arrastre As Boolean

	Dim Intentos As Integer

	Sub Cargar_Datos()
		Dim Tabla As OleDb.OleDbDataReader
		Dim Sql As String = "SELECT * FROM Usuarios WHERE usu_habilitado = TRUE ORDER BY usu_nombre"

		If Base.Ejecutar_SQL(Sql, Tabla) Then
			D_Usuario.DropDownItems.Clear()
			Do While Tabla.Read
				Dim Itm As ToolStripMenuItem = D_Usuario.DropDownItems.Add(Trim(Tabla.Item("usu_nombre")))
				Itm.Tag = Tabla.Item("usu_id")
				If Itm.Tag = My.Settings.UltimoLogin Then Itm.PerformClick()
			Loop
		Else
			MsgBox("Se produjo un error al recuperar los datos de los usuarios")
			Application.Exit()
		End If
	End Sub

	Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		Cargar_Datos

		Cursor = Cursors.Default
		UseWaitCursor = False
	End Sub

	Private Sub Cerrar_Frm_Click(sender As Object, e As EventArgs) Handles Cerrar_Frm.Click
		Application.Exit()
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

	Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
		If D_Usuario.Tag = 0 Then
			MsgBox("Debe elegir un usuario")
			T_Usuario.Focus()
			Exit Sub
		End If

		Dim SQL As String = "SELECT * FROM Usuarios WHERE usu_id = " + D_Usuario.Tag.ToString
		Dim Tabla As OleDb.OleDbDataReader

		Intentos += 1

		If Base.Ejecutar_SQL(SQL, Tabla) Then
			If Tabla.Read() Then
				If Trim(Tabla.Item("usu_password")) = D_Password.Text Then
					My.Settings.UltimoLogin = Tabla.Item("usu_id")
					My.Settings.Save()

					Administrador = Tabla.Item("usu_administrador")
					Usuario = Tabla.Item("usu_id")

					Dim Frm As Frm_Principal = DirectCast(Application.OpenForms.Item("Frm_Principal"), Frm_Principal)
					'Dim Frm As Frm_Principal = CType(Form, Frm_Principal)
					Frm.Estadisticas.Enabled = Administrador
					'Frm.T_Opciones.Enabled = Administrador
					Frm.B_Familias.Enabled = Administrador
					Frm.B_Proveedores.Enabled = Administrador
					Frm.B_Forma_Pago.Enabled = Administrador
					Frm.B_Usuarios.Enabled = Administrador
					Close()
				Else
					MsgBox("Contraseña incorrecta" & vbCrLf & "Ud ya realizo " + Intentos.ToString + " intento(s)")
					If Intentos = 3 Then Application.Exit()
				End If
			Else
				MsgBox("Se produjo un error al recuperar los datos del usuario")
			End If
		Else
			MsgBox("Se produjo un error al recuperar los datos del usuario")
		End If
	End Sub

	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
		Application.Exit()
	End Sub

	Private Sub D_Usuario_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Usuario.DropDownItemClicked
		Dim Itm As ToolStripMenuItem

		D_Usuario.Text = e.ClickedItem.Text    ' Nombre del Usuario (* usu_nombre)
		D_Usuario.Tag = e.ClickedItem.Tag      ' Código del Usuario (* usu_id)
		For Each Itm In D_Usuario.DropDownItems
			If Itm.Tag = e.ClickedItem.Tag Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm
	End Sub

	Private Sub Ajustes_Click(sender As Object, e As EventArgs) Handles Ajustes.Click
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
End Class