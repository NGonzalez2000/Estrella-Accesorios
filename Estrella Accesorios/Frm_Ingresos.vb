Imports System.ComponentModel

Public Class Frm_Ingresos

	Private Modifico_Articulo As Boolean

	Dim ex As Int16
	Dim ey As Int16
	Dim Arrastre As Boolean

	'Private WithEvents RS232 As New System.IO.Ports.SerialPort

	'Private Sub RS232_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles RS232.DataReceived
	'	Try
	'		Dim Incoming As String = RS232.ReadExisting()
	'		If Incoming IsNot Nothing Then

	'			'Code Snippet
	'			CheckForIllegalCrossThreadCalls = False

	'			ActiveControl.Text = Incoming

	'			SendKeys.SendWait("{ENTER}")
	'		End If
	'	Catch ex As Exception

	'	End Try
	'	'Try
	'	'Catch ex As TimeoutException
	'	'End Try
	'End Sub

	'Private Sub D_Codigo_GotFocus(sender As Object, e As EventArgs) Handles D_Codigo.GotFocus
	'	Try
	'		For Each COM As String In My.Computer.Ports.SerialPortNames
	'			If COM = My.Settings.Com Then
	'				RS232.PortName = COM
	'				If Not RS232.IsOpen Then
	'					RS232.Open()
	'				End If
	'				Exit For
	'			End If
	'		Next
	'	Catch ex As Exception

	'	End Try
	'End Sub

	'Private Sub D_Codigo_LostFocus(sender As Object, e As EventArgs) Handles D_Codigo.LostFocus
	'	If RS232 IsNot Nothing Then
	'		If RS232.IsOpen Then RS232.Close()
	'	End If
	'End Sub

	Sub Cargar_Imagen_CMD()
		O_DLG.CheckFileExists = True
		O_DLG.CheckPathExists = True
		O_DLG.Filter = "Archivos de Imagen (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
		O_DLG.FileName = ""
		O_DLG.FilterIndex = 1
		'CMD.RestoreDirectory = True

		If O_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
			Try
				D_Imagen.Image = AbrirImagen(O_DLG.FileName)
				Modifico_Articulo = True
			Catch Ex As Exception
				MsgBox("No se pudo abrir la imagen seleccionada: " & Ex.Message)
			End Try
		End If
	End Sub

	Private Sub Cancelar_Todo()
		Listado.Items.Clear()
		Cancelar_Ingreso.Enabled = False
		Guardar_Ingreso.Enabled = False
		D_Codigo.Text = ""
		Cancelar()
		D_Codigo.Focus()
	End Sub

	Private Sub Cancelar()
		Dim Itm As ToolStripMenuItem

		D_Cantidad.Text = Format(0, "##,##0.00")
		D_Cantidad.Tag = 0
		D_Fecha.Value = Today()
		D_Importe_Compra.Text = Format(0, "$ ##,##0.00")
		D_Importe_Compra.Tag = 0
		D_Importe_Venta.Text = Format(0, "$ ##,##0.00")
		D_Importe_Venta.Tag = 0
		D_Descripcion.Text = ""
		D_Descripcion.Tag = ""

		For Each Itm In D_Familia.DropDownItems
			Itm.Checked = False
		Next
		D_Familia.Text = "*** SELECCIONE UNA FAMILIA ***"
		D_Familia.Tag = 0

		D_Subfamilia.DropDownItems.Clear()
		D_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
		D_Subfamilia.Tag = 0

		For Each Itm In D_Proveedor.DropDownItems
			Itm.Checked = False
		Next
		D_Proveedor.Text = "*** SELECCIONE UN PROVEEDOR ***"
		D_Proveedor.Tag = 0

		D_Imagen.Image = Nothing
		D_Imagen.Tag = ""
		G_Datos1.Enabled = False
		Aceptar_Articulo.Enabled = False
		Modifico_Articulo = False
	End Sub

	Friend Sub Muestra_Familia(Item As ToolStripDropDownItem)
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Itm As ToolStripMenuItem

		If Item.Tag = -1 Then
			Texto = InputBox("Ingrese una descripción:", "Agregar Nueva Familia").ToUpper.Trim
			If Texto <> "" Then
				C_C = Proximo_Codigo("fam_id", "Familias")
				If C_C <> 0 Then
					Sql = "INSERT INTO Familias (fam_id, fam_descripcion)
							VALUES (" + C_C.ToString + ",'" + Texto + "')"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Familia agregada exitosamente!", vbInformation)

						Sql = "SELECT * FROM Familias ORDER BY fam_descripcion"
						If Base.Ejecutar_SQL(Sql, Tabla) Then
							D_Familia.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Familia.DropDownItems.Add(Tabla.Item("fam_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("fam_id")
							Loop

							Itm = D_Familia.DropDownItems.Add("AGREGAR NUEVA FAMILIA...")
							Itm.Tag = -1
						Else
							MsgBox("Se produjo un error al recuperar los datos de las familias")
							Exit Sub
						End If
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
						Exit Sub
					End If
				Else
					MsgBox("Se produjo un error al generar el código de Familia")
					Exit Sub
				End If
			Else
				Exit Sub
			End If
		Else
			C_C = Item.Tag
			Texto = Item.Text
		End If

		D_Familia.Text = Texto
		D_Familia.Tag = C_C
		For Each Itm In D_Familia.DropDownItems
			If Itm.Tag = C_C Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm

		D_Subfamilia.DropDownItems.Clear()
		D_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
		D_Subfamilia.Tag = 0

		Sql = "SELECT * FROM Sub_Familias WHERE fam_id = " + C_C.ToString + " ORDER BY sfa_descripcion"

		If Base.Ejecutar_SQL(Sql, Tabla) Then
			Do While Tabla.Read
				Itm = D_Subfamilia.DropDownItems.Add(Trim(Tabla.Item("sfa_descripcion")))
				Itm.Tag = Tabla.Item("sfa_id")
			Loop

			Itm = D_Subfamilia.DropDownItems.Add("AGREGAR NUEVA SUB-FAMILIA...")
			Itm.Tag = -1
		Else
			MsgBox("Se produjo un error al recuperar los datos de las Sub-Familias")
		End If
	End Sub

	Friend Sub Muestra_SubFamilia(Item As ToolStripDropDownItem)
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Itm As ToolStripMenuItem

		If Item.Tag = -1 Then
			Texto = InputBox("Ingrese una descripción:", "Agregar Nueva Sub-Familia de la Familia " + D_Familia.Text).ToUpper.Trim
			If Texto <> "" Then
				C_C = Proximo_Codigo("sfa_id", "Sub_Familias")
				If C_C <> 0 Then
					Sql = "INSERT INTO Sub_Familias (sfa_id, sfa_descripcion, fam_id)
							VALUES (" + C_C.ToString + ",'" + Texto + "', " + D_Familia.Tag.ToString + ")"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Sub-Familia agregada exitosamente!", vbInformation)

						Sql = "SELECT * FROM Sub_Familias ORDER BY sfa_descripcion"
						If Base.Ejecutar_SQL(Sql, Tabla) Then
							D_Subfamilia.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Subfamilia.DropDownItems.Add(Tabla.Item("sfa_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("sfa_id")
							Loop

							Itm = D_Subfamilia.DropDownItems.Add("AGREGAR NUEVA SUB-FAMILIA...")
							Itm.Tag = -1
						Else
							MsgBox("Se produjo un error al recuperar los datos de las sub-familias")
							Exit Sub
						End If
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
						Exit Sub
					End If
				Else
					MsgBox("Se produjo un error al generar el código de Sub-Familia")
					Exit Sub
				End If
			Else
				Exit Sub
			End If
		Else
			C_C = Item.Tag
			Texto = Item.Text
		End If

		D_Subfamilia.Text = Texto
		D_Subfamilia.Tag = C_C
		For Each Itm In D_Subfamilia.DropDownItems
			If Itm.Tag = C_C Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm
	End Sub

	Friend Sub Muestra_Proveedor(Item As ToolStripDropDownItem)
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Itm As ToolStripMenuItem

		If Item.Tag = -1 Then
			Texto = InputBox("Ingrese una descripción:", "Agregar Nuevo Proveedor").ToUpper.Trim
			If Texto <> "" Then
				C_C = Proximo_Codigo("pro_id", "Proveedores")
				If C_C <> 0 Then
					Sql = "INSERT INTO Proveedores (pro_id, pro_nombre)
							VALUES (" + C_C.ToString + ",'" + Texto + "')"

					If Base.Ejecutar_SQL(Sql) Then
						MsgBox("Proveedor agregado exitosamente!", vbInformation)

						Sql = "SELECT * FROM Proveedores ORDER BY pro_nombre"
						If Base.Ejecutar_SQL(Sql, Tabla) Then
							D_Proveedor.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Proveedor.DropDownItems.Add(Tabla.Item("pro_nombre").ToString.Trim)
								Itm.Tag = Tabla.Item("pro_id")
							Loop

							Itm = D_Proveedor.DropDownItems.Add("AGREGAR NUEVO PROVEEDOR...")
							Itm.Tag = -1
						Else
							MsgBox("Se produjo un error al recuperar los datos de los Proveedores")
							Exit Sub
						End If
					Else
						MsgBox("Se produjo un error al grabar los datos!", vbCritical)
						Exit Sub
					End If
				Else
					MsgBox("Se produjo un error al generar el código del Proveedor")
					Exit Sub
				End If
			Else
				Exit Sub
			End If
		Else
			C_C = Item.Tag
			Texto = Item.Text
		End If

		D_Proveedor.Text = Texto
		D_Proveedor.Tag = C_C
		For Each Itm In D_Proveedor.DropDownItems
			If Itm.Tag = C_C Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm
	End Sub

	Private Sub Frm_Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		LinkLabel1.Parent = D_Imagen
		LinkLabel1.Location = New Point(5, 110)

		Dim Tabla As OleDb.OleDbDataReader
		Dim Sql As String
		Dim Itm As ToolStripMenuItem

		D_Familia.DropDownItems.Clear()
		D_Familia.Text = "*** SELECCIONE UNA FAMILIA ***"
		D_Familia.Tag = 0

		D_Subfamilia.DropDownItems.Clear()
		D_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
		D_Subfamilia.Tag = 0

		D_Proveedor.DropDownItems.Clear()
		D_Proveedor.Text = "*** SELECCIONE UN PROVEEDOR ***"
		D_Proveedor.Tag = 0

		Sql = "SELECT * FROM Familias ORDER BY fam_descripcion"
		If Base.Ejecutar_SQL(Sql, Tabla) Then
			Do While Tabla.Read
				Itm = D_Familia.DropDownItems.Add(Trim(Tabla.Item("fam_descripcion")))
				Itm.Tag = Tabla.Item("fam_id")
			Loop

			Itm = D_Familia.DropDownItems.Add("AGREGAR NUEVA FAMILIA...")
			Itm.Tag = -1
		Else
			MsgBox("Se produjo un error al recuperar los datos de las familias")
		End If

		Sql = "SELECT * FROM Proveedores ORDER BY pro_nombre"

		If Base.Ejecutar_SQL(Sql, Tabla) Then
			Do While Tabla.Read
				Itm = D_Proveedor.DropDownItems.Add(Trim(Tabla.Item("pro_nombre")))
				Itm.Tag = Tabla.Item("pro_id")
			Loop

			Itm = D_Proveedor.DropDownItems.Add("AGREGAR NUEVO PROVEEDOR...")
			Itm.Tag = -1
		Else
			MsgBox("Se produjo un error al recuperar los datos de los proveedores")
		End If

		If Not Administrador Then
			D_Importe_Compra.SoloLectura = True
			D_Importe_Venta.SoloLectura = True
			D_Descripcion.ReadOnly = True
			'LinkLabel1.Enabled = False
			'D_Imagen.Enabled = False
			D_Familia.Enabled = False
			D_Subfamilia.Enabled = False
			D_Proveedor.Enabled = False
		End If

		Cancelar()

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

	Private Sub Cancelar_Articulo_Click(sender As Object, e As EventArgs) Handles Cancelar_Articulo.Click
		D_Codigo.Text = ""
		Cancelar()
		D_Codigo.Focus()
	End Sub

	Private Sub D_Familia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Familia.DropDownItemClicked
		Muestra_Familia(e.ClickedItem)

		If T_B_Familia.Tag <> e.ClickedItem.Tag Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub D_Subfamilia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Subfamilia.DropDownItemClicked
		Muestra_SubFamilia(e.ClickedItem)

		If T_B_Subfamilia.Tag <> e.ClickedItem.Tag Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub D_Proveedor_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Proveedor.DropDownItemClicked
		Muestra_Proveedor(e.ClickedItem)

		If T_B_Proveedor.Tag <> e.ClickedItem.Tag Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
		Dim Frm_Art As New Frm_Articulos
		AddOwnedForm(Frm_Art)
		Frm_Art.Origen = Origen.F_Ingresos
		Frm_Art.Selecciona = True
		Frm_Art.ShowDialog()
		If D_Codigo.Text.Trim <> "" Then
			D_Cantidad.Focus()
		Else
			D_Codigo.Focus()
		End If
	End Sub

	Private Sub D_Codigo_TextChanged(sender As Object, e As EventArgs) Handles D_Codigo.TextChanged
		Cancelar()
	End Sub

	Private Sub D_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_Codigo.KeyPress
		If e.KeyChar = vbCr Then
			If D_Cantidad.Enabled Then
				D_Cantidad.Focus()
			Else
				Dim Aux As New CancelEventArgs
				D_Codigo_Validating(sender, Aux)
				D_Cantidad.Focus()
			End If
			e.Handled = True
		End If
	End Sub

	Private Sub D_Codigo_Validating(sender As Object, e As CancelEventArgs) Handles D_Codigo.Validating
		D_Codigo.Text = D_Codigo.Text.Trim

		If D_Codigo.Text <> "" Then
			Dim Tabla As OleDb.OleDbDataReader
			Dim Sql As String = "SELECT Articulos.*, Familias.fam_id 
									FROM Familias INNER JOIN (Sub_Familias INNER JOIN Articulos ON Sub_Familias.sfa_id = Articulos.sfa_id)
														ON Familias.fam_id = Sub_Familias.fam_id
									WHERE art_codigo = '" + D_Codigo.Text + "' OR art_codigo_barras = '" + D_Codigo.Text + "'"
			If Base.Ejecutar_SQL(Sql, Tabla) Then
				If Tabla.Read() Then
					D_Codigo.Tag = Tabla.Item("art_id")
					If CCdec(D_Cantidad.Text) = 0 Then
						D_Cantidad.Tag = 1
						D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")
					End If
					D_Fecha.Value = Tabla.Item("art_fecha")
					D_Fecha.Tag = Tabla.Item("art_fecha")
					If Administrador Then
						D_Importe_Compra.Text = Format(Tabla.Item("art_importe_compra"), "$ ##,##0.00")
					Else
						D_Importe_Compra.Text = Replace(Format(0, "##,##0.00"), "0", "#")
					End If
					D_Importe_Compra.Tag = Tabla.Item("art_importe_compra")
					D_Importe_Venta.Text = Format(Tabla.Item("art_importe_venta"), "$ ##,##0.00")
					D_Importe_Venta.Tag = Tabla.Item("art_importe_venta")
					D_Descripcion.Text = Tabla.Item("art_descripcion").ToString.Trim
					D_Descripcion.Tag = Tabla.Item("art_descripcion").ToString.Trim
					T_B_Familia.Tag = Tabla.Item("fam_id")
					For Each It As ToolStripDropDownItem In D_Familia.DropDownItems
						If It.Tag = Tabla.Item("fam_id") Then
							Muestra_Familia(It)
							Exit For
						End If
					Next
					T_B_Subfamilia.Tag = Tabla.Item("sfa_id")
					For Each It As ToolStripDropDownItem In D_Subfamilia.DropDownItems
						If It.Tag = Tabla.Item("sfa_id") Then
							Muestra_SubFamilia(It)
							Exit For
						End If
					Next
					T_B_Proveedor.Tag = Tabla.Item("pro_id")
					For Each It As ToolStripDropDownItem In D_Proveedor.DropDownItems
						If It.Tag = Tabla.Item("pro_id") Then
							Muestra_Proveedor(It)
							Exit For
						End If
					Next
					D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Tabla.Item("art_id").ToString + ".png")
					D_Imagen.Tag = Tabla.Item("art_id").ToString + ".png"

					Modifico_Articulo = False

					G_Datos1.Enabled = True
					Aceptar_Articulo.Enabled = True
				Else
					MsgBox("No se pudo repuperar los datos del artículo o artículo inexistente!")
				End If
			Else
				MsgBox("No se pudo recuperar los datos del artículo!")
			End If
		End If
	End Sub

	Private Sub D_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_Cantidad.KeyPress
		If e.KeyChar = vbCr Then
			Aceptar_Articulo.Focus()
			e.Handled = True
		End If
	End Sub

	Private Sub D_Cantidad_Validating(sender As Object, e As CancelEventArgs) Handles D_Cantidad.Validating
		D_Cantidad.Text = D_Cantidad.Text.Trim

		If D_Cantidad.Text = "" Then D_Cantidad.Text = "0"

		D_Cantidad.Tag = CCdec(D_Cantidad.Text)
		D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")

		If D_Cantidad.Tag = 0 Then
			Aceptar_Articulo.Enabled = False
		Else
			Aceptar_Articulo.Enabled = True
		End If
	End Sub

	Private Sub D_Importe_Compra_Validating(sender As Object, e As CancelEventArgs) Handles D_Importe_Compra.Validating
		D_Importe_Compra.Text = D_Importe_Compra.Text.Trim

		If D_Importe_Compra.Text = "" Then D_Importe_Compra.Text = "0"

		D_Cantidad.Text = Format(CCdec(D_Importe_Compra.Text), "$ ##,##0.00")

		If D_Importe_Compra.Tag = CCdec(D_Importe_Compra.Text) Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub D_Importe_Venta_Validating(sender As Object, e As CancelEventArgs) Handles D_Importe_Venta.Validating
		D_Importe_Venta.Text = D_Importe_Venta.Text.Trim

		If D_Importe_Venta.Text = "" Then D_Importe_Venta.Text = "0"

		D_Importe_Venta.Text = Format(CCdec(D_Importe_Venta.Text), "$ ##,##0.00")

		If D_Importe_Venta.Tag = CCdec(D_Importe_Venta.Text) Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub D_Descripcion_Validating(sender As Object, e As CancelEventArgs) Handles D_Descripcion.Validating
		D_Descripcion.Text = D_Descripcion.Text.Trim

		If D_Descripcion.Tag = D_Descripcion.Text Then
			Modifico_Articulo = True
		End If
	End Sub

	Private Sub Aceptar_Articulo_Click(sender As Object, e As EventArgs) Handles Aceptar_Articulo.Click
		If Listado.Enabled Then
			For Each It As ListViewItem In Listado.Items
				If It.Tag = D_Codigo.Tag Then
					If MsgBox("El artículo que desea agregar ya se encuentra en la lista y se va a proceder a unificar la cantidad" & vbCrLf & "¿Desea Continuar?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
						D_Cantidad.Tag += It.SubItems(Col_Cantidad.Index).Tag
						D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")
						It.Remove()
						Exit For
					Else
						Exit For
					End If
				End If
			Next
		End If

		If Modifico_Articulo Then
			If MsgBox("Se modificaron algunos datos del artículo y deben ser grabados antes de continuar" & vbCrLf & "¿Desea grabar y continuar?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
				Exit Sub
			End If

			Dim Sql As String
			If Administrador Then
				Sql = "UPDATE Articulos
						SET  art_descripcion = '" + D_Descripcion.Text.Trim + "'
							,art_importe_compra = " + Replace(CCdec(D_Importe_Compra.Text).ToString, ",", ".") + "
							,art_importe_venta = " + Replace(CCdec(D_Importe_Venta.Text).ToString, ",", ".") + "
							,art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
							,usu_id = " + Usuario.ToString + "
							,sfa_id = " + D_Subfamilia.Tag.ToString + "
							,pro_id = " + D_Proveedor.Tag.ToString + "
						WHERE art_id = " + D_Codigo.Tag.ToString
			Else
				Sql = "UPDATE Articulos
							SET  art_descripcion = '" + D_Descripcion.Text.Trim + "'
								,art_importe_compra = " + Replace(D_Importe_Compra.Tag.ToString, ",", ".") + "
								,art_importe_venta = " + Replace(CCdec(D_Importe_Venta.Text).ToString, ",", ".") + "
								,art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								,usu_id = " + Usuario.ToString + "
								,sfa_id = " + D_Subfamilia.Tag.ToString + "
								,pro_id = " + D_Proveedor.Tag.ToString + "
							WHERE art_id = " + D_Codigo.Tag.ToString
			End If
			If Base.Ejecutar_SQL(Sql) Then
				D_Fecha.Value = Today()
				D_Fecha.Tag = Today()
				If Not D_Imagen.Image Is Nothing Then
					Try
						Dim NImagen As Image
						Dim RAncho As Decimal
						Dim RAlto As Decimal

						RAncho = D_Imagen.Image.Width / 240
						RAlto = D_Imagen.Image.Height / 135

						If RAncho > RAlto Then
							NImagen = New Bitmap(D_Imagen.Image, New Size(D_Imagen.Image.Width / RAncho, D_Imagen.Image.Height / RAncho))
						Else
							NImagen = New Bitmap(D_Imagen.Image, New Size(D_Imagen.Image.Width / RAlto, D_Imagen.Image.Height / RAlto))
						End If

						If Not System.IO.Directory.Exists(Application.StartupPath + "\Imagenes") Then System.IO.Directory.CreateDirectory(Application.StartupPath + "\Imagenes")
						If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png") Then System.IO.File.Delete(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png")
						NImagen.Save(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png")
						D_Imagen.Tag = D_Codigo.Tag.ToString + ".png"
					Catch ex As Exception
						MsgBox("Se produjo un error al grabar la imagen" & vbCrLf & ex.Message)
					End Try
				Else
					If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png") Then System.IO.File.Delete(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png")
				End If
			Else
				MsgBox("Se produjo un error al actualizar los datos del artículo")
				Exit Sub
			End If
		End If

		Dim Img As String = ""
		If Not D_Imagen.Image Is Nothing Then
			' Verifica si la imagen existe en la lisa del Imagelist usando el art_id como identificador
			If Not ImageList1.Images.ContainsKey(D_Imagen.Tag.ToString) Then
				ImageList1.Images.Add(D_Imagen.Tag.ToString, D_Imagen.Image)
			End If
			Img = D_Imagen.Tag
		End If

		If Listado.Enabled Then
			Dim Itm As New ListViewItem With {.Text = D_Codigo.Text,
			.Tag = D_Codigo.Tag,
			.ImageKey = Img
			}
			Itm.SubItems.Add(D_Cantidad.Text)
			Itm.SubItems.Add(D_Descripcion.Text)
			Itm.SubItems.Add(D_Importe_Compra.Text)
			Itm.SubItems.Add(D_Importe_Venta.Text)
			Itm.SubItems.Add(D_Fecha.Value.ToShortDateString)
			Itm.SubItems.Add(D_Subfamilia.Text)
			Itm.SubItems.Add(D_Familia.Text)
			Itm.SubItems.Add(D_Proveedor.Text)

			Itm.SubItems(Col_Cantidad.Index).Tag = D_Cantidad.Tag
			Itm.SubItems(Col_Descripcion.Index).Tag = D_Descripcion.Tag
			Itm.SubItems(Col_Importe_Compra.Index).Tag = D_Importe_Compra.Tag
			Itm.SubItems(Col_Importe_Venta.Index).Tag = D_Importe_Venta.Tag
			Itm.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value
			Itm.SubItems(Col_Subfamilia.Index).Tag = D_Subfamilia.Tag
			Itm.SubItems(Col_Familia.Index).Tag = D_Familia.Tag
			Itm.SubItems(Col_Proveedor.Index).Tag = D_Proveedor.Tag

			Listado.Items.Add(Itm)
			Itm.EnsureVisible()
		Else
			Dim Itm As ListViewItem = Listado.SelectedItems(0)
			Itm.SubItems(Col_Cantidad.Index).Text = D_Cantidad.Text
			Itm.SubItems(Col_Descripcion.Index).Text = D_Descripcion.Text
			Itm.SubItems(Col_Importe_Compra.Index).Text = D_Importe_Compra.Text
			Itm.SubItems(Col_Importe_Venta.Index).Text = D_Importe_Venta.Text
			Itm.SubItems(Col_Fecha.Index).Text = D_Fecha.Value.ToShortDateString
			Itm.SubItems(Col_Subfamilia.Index).Text = D_Subfamilia.Text
			Itm.SubItems(Col_Familia.Index).Text = D_Familia.Text
			Itm.SubItems(Col_Proveedor.Index).Text = D_Proveedor.Text

			Itm.SubItems(Col_Cantidad.Index).Tag = D_Cantidad.Tag
			Itm.SubItems(Col_Descripcion.Index).Tag = D_Descripcion.Tag
			Itm.SubItems(Col_Importe_Compra.Index).Tag = D_Importe_Compra.Tag
			Itm.SubItems(Col_Importe_Venta.Index).Tag = D_Importe_Venta.Tag
			Itm.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value
			Itm.SubItems(Col_Subfamilia.Index).Tag = D_Subfamilia.Tag
			Itm.SubItems(Col_Familia.Index).Tag = D_Familia.Tag
			Itm.SubItems(Col_Proveedor.Index).Tag = D_Proveedor.Tag
		End If

		Cancelar_Articulo.PerformClick()
		Guardar_Ingreso.Enabled = True
		Cancelar_Ingreso.Enabled = True
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Cargar_Imagen_CMD()
	End Sub

	Private Sub D_Imagen_MouseClick(sender As Object, e As MouseEventArgs) Handles D_Imagen.MouseClick
		If e.Button = MouseButtons.Right Then
			TMnu_Eliminar.Text = "Borrar Imagen..."
			mnu_Eliminar.Show(D_Imagen, New Point(e.X, e.Y))
		Else
			Cargar_Imagen_CMD()
		End If
	End Sub

	Private Sub Listado_MouseClick(sender As Object, e As MouseEventArgs) Handles Listado.MouseClick
		If e.Button = MouseButtons.Right Then
			Dim Itm As ListViewItem = Listado.HitTest(e.X, e.Y).Item
			If Not Itm Is Nothing Then
				TMnu_Eliminar.Text = "Borrar Item..."
				mnu_Eliminar.Show(Listado, New Point(e.X, e.Y))
			End If
		End If
	End Sub

	Private Sub Aceptar_Articulo_GotFocus(sender As Object, e As EventArgs) Handles Aceptar_Articulo.GotFocus
		Aceptar_Articulo.BackColor = Color.SpringGreen
	End Sub

	Private Sub Aceptar_Articulo_LostFocus(sender As Object, e As EventArgs) Handles Aceptar_Articulo.LostFocus
		Aceptar_Articulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
	End Sub

	Private Sub TMnu_Eliminar_Click(sender As Object, e As EventArgs) Handles TMnu_Eliminar.Click
		If TMnu_Eliminar.Text = "Borrar Imagen..." Then
			D_Imagen.Image = Nothing
		Else
			If MsgBox("¿Desea Borrar el ITEM Seleccionado?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
				Listado.SelectedItems(0).Remove()

				If Listado.Items.Count = 0 Then
					Guardar_Ingreso.Enabled = False
					Cancelar_Ingreso.Enabled = False
				End If
			End If
		End If
	End Sub

	Private Sub Cancelar_Ingreso_Click(sender As Object, e As EventArgs) Handles Cancelar_Ingreso.Click
		If MsgBox("¿Esta seguro que desea cancelar los ingresos cargados?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Cancelar_Todo()
		End If
	End Sub

	Private Sub Guardar_Ingreso_Click(sender As Object, e As EventArgs) Handles Guardar_Ingreso.Click
		If MsgBox("¿Esta seguro que desea GRABAR los ingresos cargados?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Dim Generar As MsgBoxResult
			Generar = MsgBox("¿Desea generar etiquetas?", vbQuestion + vbYesNo + vbDefaultButton1)
			If Generar = MsgBoxResult.Yes Then
				If MsgBox("¿Desea agregar las etiquetas a las ya existentes?", vbQuestion + vbYesNo + vbDefaultButton1) = vbNo Then
					If Not Base.Ejecutar_SQL("DELETE * FROM COPIAS") Then
						MsgBox("Se produjo un error al borrar las etiquetas ya cargadas")
						Exit Sub
					End If
				End If
			End If

			For Each Itm As ListViewItem In Listado.Items
				Dim Sql As String = "INSERT INTO Ingresos (ing_fecha, ing_cantidad, art_id, usu_id)
										VALUES
										('" + Itm.SubItems(Col_Fecha.Index).Text + "'
										, " + Replace(Itm.SubItems(Col_Cantidad.Index).Tag.ToString, ",", ".") + "
										, " + Itm.Tag.ToString + "
										, " + Usuario.ToString + ")"
				If Base.Ejecutar_SQL(Sql) Then
					If Generar = MsgBoxResult.Yes Then
						Sql = "INSERT INTO Copias (art_id)
										VALUES (" + Itm.Tag.ToString + ")"
						For I As Integer = 1 To Itm.SubItems(Col_Cantidad.Index).Tag
							If Not Base.Ejecutar_SQL(Sql) Then
								MsgBox("Se produjo un error al intentar cargar las copias de las etiquetas")
								Exit For
							End If
						Next
					End If
				Else
					MsgBox("Se produjo un error al cargar el " + Itm.Index + 1.ToString + " item")
				End If
			Next

			MsgBox("INGRESOS GRABADOS EXITOSAMENTE!!!!", vbInformation)
			Cancelar_Todo()

			If Generar = MsgBoxResult.Yes Then
				Dim Frm As New Frm_QR

				'AddOwnedForm(Frm_Vista_Previa)

				Frm.ShowDialog()
			End If
		End If
	End Sub
End Class