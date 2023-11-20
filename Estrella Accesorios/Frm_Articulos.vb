Imports System.ComponentModel

Public Class Frm_Articulos

	Friend Selecciona As Boolean
	Friend Origen As Origen

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

	'Private Sub Abrir_RS232(sender As Object, e As EventArgs) Handles B_Codigo.GotFocus, D_Codigo_Barras.GotFocus
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

	'Private Sub Cerrar_RS232(sender As Object, e As EventArgs) Handles B_Codigo.LostFocus, D_Codigo_Barras.LostFocus
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
			Catch Ex As Exception
				MsgBox("No se pudo abrir la imagen seleccionada: " & Ex.Message)
			End Try
		End If
	End Sub

	Sub Limpiar()
		D_Codigo.Text = ""
		D_Codigo_Barras.Text = ""
		D_Descripcion.Text = ""
		D_Importe_Compra.Text = Format(0, "$ ##,##0.00")
		D_Importe_Compra.Tag = 0
		D_Importe_Venta.Text = Format(0, "$ ##,##0.00")
		D_Importe_Venta.Tag = 0
		D_Stock_Inicial.Text = Format(0, "##,##0.00")
		D_Stock_Inicial.Tag = 0
		D_Stock_Minimo.Text = Format(0, "##,##0.00")
		D_Stock_Minimo.Tag = 0
		D_Fecha.Value = Today()
		D_Imagen.Image = Nothing

		For Each It As ToolStripMenuItem In D_Familia.DropDownItems
			It.Checked = False
		Next
		D_Familia.Text = "*** SELECCIONE UNA FAMILIA ***"
		D_Familia.Tag = 0

		D_Subfamilia.DropDownItems.Clear()
		D_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
		D_Subfamilia.Tag = 0

		For Each It As ToolStripMenuItem In D_Proveedor.DropDownItems
			It.Checked = False
		Next
		D_Proveedor.Text = "*** SELECCIONE UN PROVEEDOR ***"
		D_Proveedor.Tag = 0
	End Sub

	Private Sub Frm_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
		'VP.Parent = Listado

		Dim Tabla As OleDb.OleDbDataReader
		Dim Sql As String


		Dim ItmAux As ToolStripMenuItem

		B_Familia.DropDownItems.Clear()
		ItmAux = B_Familia.DropDownItems.Add("*** TODAS LAS FAMILIAS ***")
		ItmAux.Tag = 0
		ItmAux.Checked = True
		B_Familia.Text = ItmAux.Text
		B_Familia.Tag = ItmAux.Tag

		B_Subfamilia.DropDownItems.Clear()
		ItmAux = B_Subfamilia.DropDownItems.Add("*** TODAS LAS SUB-FAMILIAS ***")
		ItmAux.Tag = 0
		ItmAux.Checked = True
		B_Subfamilia.Text = ItmAux.Text
		B_Subfamilia.Tag = ItmAux.Tag

		B_Proveedor.DropDownItems.Clear()
		ItmAux = B_Proveedor.DropDownItems.Add("*** TODOS LOS PROVEEDORES ***")
		ItmAux.Tag = 0
		ItmAux.Checked = True
		B_Proveedor.Text = ItmAux.Text
		B_Proveedor.Tag = ItmAux.Tag

		Sql = "SELECT * FROM Familias ORDER BY fam_descripcion"
		If Base.Ejecutar_SQL(Sql, Tabla) Then
			Do While Tabla.Read
				Dim Itm As ToolStripMenuItem = D_Familia.DropDownItems.Add(Trim(Tabla.Item("fam_descripcion")))
				Itm.Tag = Tabla.Item("fam_id")

				Dim Itm1 As ToolStripMenuItem = B_Familia.DropDownItems.Add(Trim(Tabla.Item("fam_descripcion")))
				Itm1.Tag = Tabla.Item("fam_id")
			Loop
		Else
			MsgBox("Se produjo un error al recuperar los datos de las familias")
		End If

		ItmAux = D_Familia.DropDownItems.Add("AGREGAR NUEVA FAMILIA...")
		ItmAux.Tag = -1

		Sql = "SELECT * FROM Proveedores ORDER BY pro_nombre"

		If Base.Ejecutar_SQL(Sql, Tabla) Then
			Do While Tabla.Read
				Dim Itm As ToolStripMenuItem = D_Proveedor.DropDownItems.Add(Trim(Tabla.Item("pro_nombre")))
				Itm.Tag = Tabla.Item("pro_id")

				Dim Itm1 As ToolStripMenuItem = B_Proveedor.DropDownItems.Add(Trim(Tabla.Item("pro_nombre")))
				Itm1.Tag = Tabla.Item("pro_id")
			Loop
		Else
			MsgBox("Se produjo un error al recuperar los datos de los proveedores")
		End If

		ItmAux = D_Proveedor.DropDownItems.Add("AGREGAR NUEVO PROVEEDOR...")
		ItmAux.Tag = -1

		If Not Administrador Then
			G_Controles.Enabled = False
			G_Botones.Enabled = False
		End If
		Limpiar()
		VP.Tag = ""
		B_Codigo.Focus()

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

	Private Sub Generar_CB_Click(sender As Object, e As EventArgs) Handles Generar_CB.Click
		If Trim(D_Codigo_Barras.Text) <> "" Then
			If MsgBox("¿Desea reemplazar el Código de Barras por uno generado automáticamente?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
				Exit Sub
			End If
		End If

		Dim Sql As String

		Sql = "SELECT 'EA'+Format(Max(Mid([Articulos].[art_codigo_barras],3,13))+1,'0000000000000') AS codigo_barras
				FROM Articulos
				WHERE (((Articulos.art_codigo_barras) Like 'EA%'));"
		Dim Tabla As OleDb.OleDbDataReader
		If Base.Ejecutar_SQL(Sql, Tabla) Then
			If Tabla.Read Then
				If Tabla.Item(0) = "EA" Then
					D_Codigo_Barras.Text = "EA0000000000001"
				Else
					D_Codigo_Barras.Text = Tabla.Item(0)
				End If
			Else
				D_Codigo_Barras.Text = "EA0000000000001"
			End If
		Else
			MsgBox("Se produjo un error al generar el código de barras")
		End If
		D_Codigo_Barras.Focus()
	End Sub

	Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
		Dim WH As String = ""
		Dim SQL As String = "SELECT Articulos.art_id, IIF(ISNULL(Articulos.art_codigo), '', Articulos.art_codigo) AS art_codigo, Articulos.art_descripcion, IIF(ISNULL(Articulos.art_codigo_barras), '', Articulos.art_codigo_barras) AS art_codigo_barras, Articulos.art_stock_minimo, 
									Articulos.art_importe_compra, Articulos.art_importe_venta, Articulos.art_stock_inicial, Articulos.art_fecha, IIf(IsNull(Sum(Ingresos.ing_cantidad)),0,Sum(Ingresos.ing_cantidad)) AS ingresos, IIF(ISNULL(Sum(Detalle_Ventas.art_cantidad)), 0,Sum(Detalle_Ventas.art_cantidad)) AS ventas,
									Sub_Familias.sfa_id, Sub_Familias.sfa_descripcion, Familias.fam_id, Familias.fam_descripcion, Proveedores.pro_id, Proveedores.pro_nombre
								FROM (Familias INNER JOIN Sub_Familias ON Familias.fam_id = Sub_Familias.fam_id) INNER JOIN (Proveedores INNER JOIN ((Articulos LEFT JOIN Detalle_Ventas ON Articulos.art_id = Detalle_Ventas.art_id) LEFT JOIN Ingresos ON Articulos.art_id = Ingresos.art_id) ON Proveedores.pro_id = Articulos.pro_id) ON Sub_Familias.sfa_id = Articulos.sfa_id"
		Dim Tabla As OleDb.OleDbDataReader

		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		B_Codigo.Text = Replace(B_Codigo.Text, vbCr, "")

		If Trim(B_Codigo.Text) <> "" Then
			WH = " WHERE (Articulos.art_codigo LIKE '%" + Trim(B_Codigo.Text) + "%' OR Articulos.art_codigo_barras = '" + Trim(B_Codigo.Text) + "') "
		End If

		If Trim(B_Descripcion.Text) <> "" Then
			If WH = "" Then
				WH = " WHERE "
			Else
				WH += " AND "
			End If

			WH += " (Articulos.art_descripcion) LIKE '%" + Trim(B_Descripcion.Text) + "%' "
		End If

		If B_Subfamilia.Tag <> 0 Then
			If WH = "" Then
				WH = " WHERE "
			Else
				WH += " AND "
			End If

			WH += " (Sub_Familias.sfa_id = " + B_Subfamilia.Tag.ToString + ") "
		Else
			If B_Familia.Tag <> 0 Then
				If WH = "" Then
					WH = " WHERE "
				Else
					WH += " AND "
				End If

				WH += " (Familias.fam_id = " + B_Familia.Tag.ToString + ") "
			End If
		End If

		If B_Proveedor.Tag <> 0 Then
			If WH = "" Then
				WH = " WHERE "
			Else
				WH += " AND "
			End If

			WH += " (Proveedores.pro_id = " + B_Proveedor.Tag.ToString + ") "
		End If

		SQL += WH + " GROUP BY Articulos.art_id, IIf(IsNull(Articulos.art_codigo),'',Articulos.art_codigo), Articulos.art_descripcion, Articulos.art_stock_minimo, IIf(IsNull(Articulos.art_codigo_barras),'',Articulos.art_codigo_barras), Articulos.art_importe_compra, Articulos.art_importe_venta, Articulos.art_stock_inicial, Articulos.art_fecha, Sub_Familias.sfa_id, Sub_Familias.sfa_descripcion, Familias.fam_id, Familias.fam_descripcion, Proveedores.pro_id, Proveedores.pro_nombre
				 ORDER BY art_descripcion"

		If Base.Ejecutar_SQL(SQL, Tabla) Then
			Dim Itm As ListViewItem
			Dim Stock As Decimal
			Listado.Items.Clear()
			'Listado.BeginUpdate()
			Do While Tabla.Read
				Stock = Tabla.Item("art_stock_inicial") + Tabla.Item("ingresos") - Tabla.Item("ventas")
				If Stock <= 0 Then
					Itm = New ListViewItem With {
					.Text = Tabla.Item("art_codigo"), 'Codigo del Articulo (0)
					.Tag = Tabla.Item("art_id"), 'ID del Articulo (0)
					.ImageKey = "S0",
					.ForeColor = Color.Black,
					.BackColor = My.Settings.Color0
					}
				ElseIf Stock < Tabla.Item("art_stock_minimo") Then
					Itm = New ListViewItem With {
					.Text = Tabla.Item("art_codigo"), 'Codigo del Articulo (0)
					.Tag = Tabla.Item("art_id"), 'ID del Articulo (0)
					.ImageKey = "S1",
					.ForeColor = Color.Black,
					.BackColor = My.Settings.Color1
					}
				Else
					Itm = New ListViewItem With {
					.Text = Tabla.Item("art_codigo"), 'Codigo del Articulo (0)
					.Tag = Tabla.Item("art_id"), 'ID del Articulo (0)
					.ImageKey = "S2",
					.ForeColor = Color.Black,
					.BackColor = My.Settings.Color2
					}
				End If

				Itm.Checked = True
				Itm.SubItems.Add(Trim(Tabla.Item("art_descripcion"))) 'Descripicon del Articulo (1)

				Itm.SubItems.Add(Trim(Tabla.Item("art_codigo_barras"))) 'Código de Barras (2)

				Itm.SubItems.Add(Format(Tabla.Item("art_importe_venta"), "$ ##,##0.00")) 'Importe Venta (3)
				Itm.SubItems(Col_Importe_Venta.Index).Tag = Tabla.Item("art_importe_venta")

				Itm.SubItems.Add(Format(Tabla.Item("art_fecha"), "dd/MM/yyyy")) 'Fecha de modificación (4)
				Itm.SubItems(Col_Fecha.Index).Tag = Tabla.Item("art_fecha")

				Itm.SubItems.Add(Format(Stock, "##,##0.00")) 'Stock (5)
				Itm.SubItems(Col_Stock.Index).Tag = Stock

				Itm.SubItems.Add(Trim(Tabla.Item("sfa_descripcion"))) 'Sub-Familia (6)
				Itm.SubItems(Col_Subfamilia.Index).Tag = Tabla.Item("sfa_id")

				Itm.SubItems.Add(Trim(Tabla.Item("fam_descripcion"))) 'Familia (7)
				Itm.SubItems(Col_Familia.Index).Tag = Tabla.Item("fam_id")

				Itm.SubItems.Add(Trim(Tabla.Item("pro_nombre"))) 'Proveedor (8)
				Itm.SubItems(Col_Proveedor.Index).Tag = Tabla.Item("pro_id")

				If Administrador Then
					Itm.SubItems.Add(Format(Tabla.Item("art_importe_compra"), "$ ##,##0.00")) 'Importe Compra (9)
				Else
					Itm.SubItems.Add(Replace(Format(0, "$ ##,##0.00"), "0", "#")) 'Importe Compra OCULTO (9)
				End If
				Itm.SubItems(Col_Importe_Compra.Index).Tag = Tabla.Item("art_importe_compra")

				If Administrador Then
					Itm.SubItems.Add(Format(Tabla.Item("ventas"), "##,##0.00")) 'Cant. Vendida (10)
				Else
					Itm.SubItems.Add(Replace(Format(0, "##,##0.00"), "0", "#")) 'Cant. Vendid OCULTO (10)
				End If
				Itm.SubItems(Col_Venidos.Index).Tag = Tabla.Item("ventas")

				If Administrador Then
					Itm.SubItems.Add(Format(Tabla.Item("ingresos"), "##,##0.00")) 'Cant. Comprada (11)
				Else
					Itm.SubItems.Add(Replace(Format(0, "##,##0.00"), "0", "#")) 'Cant. Comprada OCULTO (11)
				End If
				Itm.SubItems(Col_Compra.Index).Tag = Tabla.Item("ingresos")

				If Administrador Then
					Itm.SubItems.Add(Format(Tabla.Item("art_stock_inicial"), "##,##0.00")) 'Stock Inicial (12)
				Else
					Itm.SubItems.Add(Replace(Format(0, "##,##0.00"), "0", "#")) 'Stock Inicial OCULTO (12)
				End If
				Itm.SubItems(Col_Stock_Inicial.Index).Tag = Tabla.Item("art_stock_inicial")

				If Administrador Then
					Itm.SubItems.Add(Format(Tabla.Item("art_stock_minimo"), "##,##0.00")) 'Stock mínimo (12)
				Else
					Itm.SubItems.Add(Replace(Format(0, "##,##0.00"), "0", "#")) 'Stock mínimo OCULTO (12)
				End If
				Itm.SubItems(Col_Stock_Minimo.Index).Tag = Tabla.Item("art_stock_minimo")

				Listado.Items.Add(Itm)

				If Listado.Items.Count = 200 Then
					If MsgBox("La busqueda devolvió muchos registros, ya se listaron los primeros 200" & vbCrLf & "¿Desea continuar?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						Exit Do
					End If
				End If
			Loop

			If Administrador Then
				If Listado.CheckedItems.Count >= 1 Then
					B_Lotes.Enabled = True
				Else
					B_Lotes.Enabled = False
				End If
			Else
				B_Lotes.Enabled = False
			End If

			'Listado.EndUpdate()
		Else
			MsgBox("Se produjo un error en la busqueda de artículos")
		End If

		UseWaitCursor = False
		Cursor = Cursors.Default
	End Sub

	Private Sub D_Imagen_Click(sender As Object, e As EventArgs) Handles D_Imagen.Click
		Cargar_Imagen_CMD()
	End Sub

	Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
		If Agregar.Text = "Agregar" Then
			'HABILITA PARA AGREGAR UN Articulo NUEVO
			G_Datos.Enabled = True
			G_Busqueda.Enabled = False
			G_Botones.Enabled = False
			Listado.Enabled = False
			Modificar.Enabled = False
			Borrar.Enabled = False
			Limpiar()
			D_Codigo.Focus()
			Agregar.Text = "GRABAR"
		Else
			'GRABA LOS DATOS INGRESADOS
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA EL CODIGO
				If Trim(D_Codigo.Text) = "" Then
					If MsgBox("¿Desea cargar el artículo sin codigo original?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Codigo.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL CODIGO DE BARRAS
				If Trim(D_Codigo_Barras.Text) = "" Then
					If MsgBox("¿Desea generar el código de barras automáticamente?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Codigo_Barras.Focus()
						Exit Sub
					Else
						Generar_CB.PerformClick()
					End If
				End If

				'VERIFICA LA DESCRIPCION
				If Trim(D_Descripcion.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion.Focus()
					Exit Sub
				End If

				'VERIFICA EL IMPORTE COMPRA
				If CCdec(D_Importe_Compra.Text) = 0 Then
					If MsgBox("¿Desea agregar el artículo sin importe de compra?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Compra.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL IMPORTE VENTA
				If CCdec(D_Importe_Venta.Text) = 0 Then
					If MsgBox("¿Desea agregar el artículo sin importe de venta?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Venta.Focus()
						Exit Sub
					End If
				End If

				If CCdec(D_Importe_Compra.Text) >= CCdec(D_Importe_Venta.Text) Then
					If MsgBox("El importe de venta debería ser mayo al de compra" & vbCrLf & "¿Estan los datos Correctos?" & vbCrLf & "Compra: " & D_Importe_Compra.Text & vbCrLf & "Venta: " & vbCrLf & D_Importe_Venta.Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Venta.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL STOCK INICIAL
				If CCdec(D_Stock_Inicial.Text) = 0 Then
					If MsgBox("El stock INICIAL es 0 ¿es esto correcto?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Stock_Inicial.Focus()
						Exit Sub
					End If
				End If

				If CCdec(D_Stock_Minimo.Text) = 0 Then
					If MsgBox("El stock MÍNIMO es 0 ¿es esto correcto?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Stock_Inicial.Focus()
						Exit Sub
					End If
				End If

				If D_Familia.Tag = 0 Then
					MsgBox("Debe elegir una Familia y Sub-Familia")
					T_Familia.Focus()
					Exit Sub
				End If

				If D_Subfamilia.Tag = 0 Then
					MsgBox("Debe elegir una Sub-Familia")
					T_Subfamilia.Focus()
					Exit Sub
				End If

				If D_Proveedor.Tag = 0 Then
					MsgBox("Debe elegir una Proveedor")
					Modificar.Focus()
					Exit Sub
				End If

				Dim C_C As Long = Proximo_Codigo("art_id", "Articulos")

				If C_C <> 0 Then
					Dim Sql As String = "INSERT INTO Articulos
											(art_id, art_codigo, art_descripcion, art_codigo_barras, art_importe_compra, art_importe_venta
											,art_stock_inicial, art_stock_minimo, art_fecha, usu_id, sfa_id, pro_id)
										VALUES
											( " + C_C.ToString + "
											,'" + Trim(D_Codigo.Text) + "'
											,'" + Trim(D_Descripcion.Text) + "'
											,'" + Trim(D_Codigo_Barras.Text) + "'
											, " + Replace(CCdec(D_Importe_Compra.Text).ToString, ",", ".") + "
											, " + Replace(CCdec(D_Importe_Venta.Text).ToString, ",", ".") + "
											, " + Replace(CCdec(D_Stock_Inicial.Text).ToString, ",", ".") + "
											, " + Replace(CCdec(D_Stock_Minimo.Text).ToString, ",", ".") + "
											,'" + Format(D_Fecha.Value, "dd/MM/yyyy") + "'
											, " + Usuario.ToString + "
											, " + D_Subfamilia.Tag.ToString + "
											, " + D_Proveedor.Tag.ToString + ")"

					If Base.Ejecutar_SQL(Sql) Then
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
								If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + C_C.ToString + ".png") Then System.IO.File.Delete(Application.StartupPath + "\Imagenes\" + C_C.ToString + ".png")
								NImagen.Save(Application.StartupPath + "\Imagenes\" + C_C.ToString + ".png")
							Catch ex As Exception
								MsgBox("Se produjo un error al grabar la imagen" & vbCrLf & ex.Message)
							End Try
						End If

						MsgBox("ARTICULO agregado exitosamente!", vbInformation)

						Dim Stock As Decimal = CCdec(D_Stock_Inicial.Text)
						Dim Itm As ListViewItem

						If Stock <= 0 Then
							Itm = New ListViewItem With {
						.Text = Trim(D_Codigo.Text), ' Codigo del Articulo (0)
						.Tag = C_C, ' ID del Artículo
						.ImageKey = "S0",
						.ForeColor = Color.Black,
						.BackColor = My.Settings.Color0,
						.Checked = True
						}
						ElseIf Stock < CCdec(D_Stock_Minimo.Text) Then
							Itm = New ListViewItem With {
						.Text = Trim(D_Codigo.Text), ' Codigo del Articulo (0)
						.Tag = C_C, ' ID del Artículo
						.ImageKey = "S1",
						.ForeColor = Color.Black,
						.BackColor = My.Settings.Color1,
						.Checked = True
						}
						Else
							Itm = New ListViewItem With {
						.Text = Trim(D_Codigo.Text), ' Codigo del Articulo (0)
						.Tag = C_C, ' ID del Artículo
						.ImageKey = "S2",
						.ForeColor = Color.Black,
						.BackColor = My.Settings.Color2,
						.Checked = True
						}
						End If

						With Itm


							.SubItems.Add(Trim(D_Descripcion.Text)) ' Descripicon del Articulo (1)

							.SubItems.Add(Trim(D_Codigo_Barras.Text)) ' Código de Barras (2)

							.SubItems.Add(D_Importe_Venta.Text) ' Importe Venta (3)
							.SubItems(Col_Importe_Venta.Index).Tag = D_Importe_Venta.Tag

							.SubItems.Add(Format(D_Fecha.Value, "dd/MM/yyyy")) ' Fecha de modificación (4)
							.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value

							.SubItems.Add(D_Stock_Inicial.Text) ' Stock (5)
							.SubItems(Col_Stock.Index).Tag = D_Stock_Inicial.Tag

							.SubItems.Add(D_Subfamilia.Text) 'Sub-Familia (6)
							.SubItems(Col_Subfamilia.Index).Tag = D_Subfamilia.Tag

							.SubItems.Add(D_Familia.Text) 'Familia (7)
							.SubItems(Col_Familia.Index).Tag = D_Familia.Tag

							.SubItems.Add(D_Proveedor.Text) 'Proveedor (8)
							.SubItems(Col_Proveedor.Index).Tag = D_Proveedor.Tag

							.SubItems.Add(D_Importe_Compra.Text) ' Importe Compra (9)
							.SubItems(Col_Importe_Compra.Index).Tag = D_Importe_Compra.Tag

							.SubItems.Add(Format(0, "##,##0.00")) ' Cant. Vendida (10)
							.SubItems(Col_Venidos.Index).Tag = 0

							.SubItems.Add(Format(0, "##,##0.00")) ' Cant. Comprada (11)
							.SubItems(Col_Compra.Index).Tag = 0

							.SubItems.Add(D_Stock_Inicial.Text) 'Stock Inicial (12)
							.SubItems(Col_Stock_Inicial.Index).Tag = D_Stock_Inicial.Tag

							.SubItems.Add(D_Stock_Minimo.Text) 'Stock Mínimo (13)
							.SubItems(Col_Stock_Minimo.Index).Tag = D_Stock_Minimo.Tag
						End With

						Listado.Items.Add(Itm)

						Cancelar.PerformClick()
						Itm.EnsureVisible()
					Else
						MsgBox("Se produjo un Error al grabar los datos del ARTICULO!", vbCritical)
					End If
				Else
					MsgBox("Se produjo un error al generar el código del artículo")
				End If
			End If
		End If
	End Sub

	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
		Limpiar()
		G_Datos.Enabled = False
		G_Busqueda.Enabled = True
		If Administrador Then
			G_Botones.Enabled = True
		Else
			G_Botones.Enabled = False
		End If
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

	Private Sub Listado_MouseLeave(sender As Object, e As EventArgs) Handles Listado.MouseLeave
		VP.Visible = False
		VP.Image = Nothing
		VP.Tag = ""
	End Sub

	Private Sub Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado.SelectedIndexChanged
		If Listado.SelectedItems.Count = 1 Then
			Modificar.Enabled = True
			Borrar.Enabled = True
		Else
			Modificar.Enabled = False
			Borrar.Enabled = False
		End If
	End Sub

	Private Sub Listado_MouseMove(sender As Object, e As MouseEventArgs) Handles Listado.MouseMove
		Dim Itm As ListViewItem

		Itm = Listado.HitTest(e.X, e.Y).Item
		If Not Itm Is Nothing Then
			If VP.Tag <> Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png" Then
				If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png") Then
					VP.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png")
					VP.Tag = Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png"
					VP.Visible = True
				Else
					VP.Tag = ""
					VP.Visible = False
				End If
			End If

			If VP.Visible Then VP.Location = New Point(e.X + 170, e.Y + 180)
		Else
			VP.Visible = False
			VP.Tag = ""
		End If
	End Sub

	Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
		If Modificar.Text = "Modificar" Then
			'HABILITA PARA MODIFICAR UN Articulo
			With Listado.SelectedItems(0)
				D_Codigo.Text = .Text
				D_Codigo.Tag = .Tag

				D_Descripcion.Text = .SubItems(Col_Descripcion.Index).Text

				D_Codigo_Barras.Text = .SubItems(Col_Cod_Barras.Index).Text

				D_Importe_Venta.Text = .SubItems(Col_Importe_Venta.Index).Text
				D_Importe_Venta.Tag = .SubItems(Col_Importe_Venta.Index).Tag

				D_Importe_Compra.Text = .SubItems(Col_Importe_Compra.Index).Text
				D_Importe_Compra.Tag = .SubItems(Col_Importe_Compra.Index).Tag

				D_Fecha.Value = Today()

				D_Stock_Inicial.Text = .SubItems(Col_Stock_Inicial.Index).Text
				D_Stock_Inicial.Tag = .SubItems(Col_Stock_Inicial.Index).Tag

				D_Stock_Minimo.Text = .SubItems(Col_Stock_Minimo.Index).Text
				D_Stock_Minimo.Tag = .SubItems(Col_Stock_Minimo.Index).Tag

				If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + .Tag.ToString + ".png") Then
					D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + .Tag.ToString + ".png")
				Else
					D_Imagen.Image = Nothing
				End If

				Dim Itm As ToolStripMenuItem

				For Each Itm In D_Familia.DropDownItems
					If Itm.Tag = .SubItems(Col_Familia.Index).Tag Then
						Itm.PerformClick()
						Exit For
					End If
				Next

				For Each Itm In D_Subfamilia.DropDownItems
					If Itm.Tag = .SubItems(Col_Subfamilia.Index).Tag Then
						Itm.PerformClick()
						Exit For
					End If
				Next

				For Each Itm In D_Proveedor.DropDownItems
					If Itm.Tag = .SubItems(Col_Proveedor.Index).Tag Then
						Itm.PerformClick()
						Exit For
					End If
				Next
			End With

			G_Datos.Enabled = True
			G_Busqueda.Enabled = False
			G_Botones.Enabled = False
			Listado.Enabled = False
			Agregar.Enabled = False
			Modificar.Text = "GRABAR"
			Borrar.Enabled = False
			D_Codigo.Focus()
		Else
			If MsgBox("¿Esta seguro que desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmación") = MsgBoxResult.Yes Then
				'VERIFICA EL CODIGO
				If Trim(D_Codigo.Text) = "" Then
					If MsgBox("¿Desea cargar el artículo sin codigo original?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Codigo.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL CODIGO DE BARRAS
				If Trim(D_Codigo_Barras.Text) = "" Then
					If MsgBox("¿Desea generar el código de barras automáticamente?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Codigo_Barras.Focus()
						Exit Sub
					Else
						Generar_CB.PerformClick()
					End If
				End If

				'VERIFICA LA DESCRIPCION
				If Trim(D_Descripcion.Text) = "" Then
					MsgBox("Debe ingresar una descripción", vbInformation)
					D_Descripcion.Focus()
					Exit Sub
				End If

				'VERIFICA EL IMPORTE COMPRA
				If CCdec(D_Importe_Compra.Text) = 0 Then
					If MsgBox("¿Desea agregar el artículo sin importe de compra?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Compra.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL IMPORTE VENTA
				If CCdec(D_Importe_Venta.Text) = 0 Then
					If MsgBox("¿Desea agregar el artículo sin importe de venta?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Venta.Focus()
						Exit Sub
					End If
				End If

				If CCdec(D_Importe_Compra.Text) >= CCdec(D_Importe_Venta.Text) Then
					If MsgBox("El importe de venta debería ser mayo al de compra" & vbCrLf & "¿Estan los datos Correctos?" & vbCrLf & "Compra: " & D_Importe_Compra.Text & vbCrLf & "Venta: " & vbCrLf & D_Importe_Venta.Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Importe_Venta.Focus()
						Exit Sub
					End If
				End If

				'VERIFICA EL STOCK INICIAL
				If CCdec(D_Stock_Inicial.Text) = 0 Then
					If MsgBox("El stock INICIAL es 0 ¿es esto correcto?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Stock_Inicial.Focus()
						Exit Sub
					End If
				End If

				If CCdec(D_Stock_Minimo.Text) = 0 Then
					If MsgBox("El stock MÍNIMO es 0 ¿es esto correcto?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
						D_Stock_Minimo.Focus()
						Exit Sub
					End If
				End If

				If D_Familia.Tag = 0 Then
					MsgBox("Debe elegir una Familia y Sub-Familia")
					T_Familia.Focus()
					Exit Sub
				End If

				If D_Subfamilia.Tag = 0 Then
					MsgBox("Debe elegir una Sub-Familia")
					T_Subfamilia.Focus()
					Exit Sub
				End If

				If D_Proveedor.Tag = 0 Then
					MsgBox("Debe elegir una Proveedor")
					Modificar.Focus()
					Exit Sub
				End If

				Dim Sql As String = "UPDATE Articulos
										SET  art_codigo = '" + Trim(D_Codigo.Text) + "'
											,art_descripcion = '" + Trim(D_Descripcion.Text) + "'
											,art_codigo_barras = '" + Trim(D_Codigo_Barras.Text) + "'
											,art_importe_compra = " + Replace(CCdec(D_Importe_Compra.Text).ToString, ",", ".") + "
											,art_importe_venta = " + Replace(CCdec(D_Importe_Venta.Text).ToString, ",", ".") + "
											,art_stock_inicial = " + Replace(CCdec(D_Stock_Inicial.Text).ToString, ",", ".") + "
											,art_stock_minimo = " + Replace(CCdec(D_Stock_Minimo.Text).ToString, ",", ".") + "
											,art_fecha = '" + Format(D_Fecha.Value, "dd/MM/yyyy") + "'
											,usu_id = " + Usuario.ToString + "
											,sfa_id = " + D_Subfamilia.Tag.ToString + "
											,pro_id = " + D_Proveedor.Tag.ToString + "
										WHERE art_id = " + D_Codigo.Tag.ToString

				If Base.Ejecutar_SQL(Sql) Then
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
						Catch ex As Exception
							MsgBox("Se produjo un error al grabar la imagen" & vbCrLf & ex.Message)
						End Try
					Else
						If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png") Then System.IO.File.Delete(Application.StartupPath + "\Imagenes\" + D_Codigo.Tag.ToString + ".png")
					End If

					MsgBox("ARTICULO modificado exitosamente!", vbInformation)

					Dim Itm As ListViewItem = Listado.SelectedItems(0)
					With Itm
						Dim Stock As Decimal = D_Stock_Inicial.Tag - Itm.SubItems(Col_Venidos.Index).Tag + Itm.SubItems(Col_Compra.Index).Tag

						If Stock <= 0 Then
							.Text = Trim(D_Codigo.Text) ' Codigo del Articulo (0)
							.Tag = D_Codigo.Tag  ' ID del Artículo
							.ImageKey = "S0"
							.ForeColor = Color.Black
							.BackColor = My.Settings.Color0
						ElseIf Stock < CCdec(D_Stock_Minimo.Text) Then
							.Text = Trim(D_Codigo.Text) ' Codigo del Articulo (0)
							.Tag = D_Codigo.Tag  ' ID del Artículo
							.ImageKey = "S1"
							.ForeColor = Color.Black
							.BackColor = My.Settings.Color1
						Else
							.Text = Trim(D_Codigo.Text) ' Codigo del Articulo (0)
							.Tag = D_Codigo.Tag  ' ID del Artículo
							.ImageKey = "S2"
							.ForeColor = Color.Black
							.BackColor = My.Settings.Color2
						End If

						.SubItems(Col_Descripcion.Index).Text = D_Descripcion.Text.Trim ' Descripicon del Articulo (1)

						.SubItems(Col_Cod_Barras.Index).Text = D_Codigo_Barras.Text.Trim  ' Código de Barras (2)

						.SubItems(Col_Importe_Venta.Index).Text = D_Importe_Venta.Text ' Importe Venta (3)
						.SubItems(Col_Importe_Venta.Index).Tag = D_Importe_Venta.Tag

						.SubItems(Col_Importe_Compra.Index).Text = D_Importe_Compra.Text ' Importe Compra (9)
						.SubItems(Col_Importe_Compra.Index).Tag = D_Importe_Compra.Tag

						.SubItems(Col_Fecha.Index).Text = Format(D_Fecha.Value, "dd/MM/yyyy") ' Fecha de modificación (4)
						.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value

						.SubItems(Col_Stock_Inicial.Index).Text = D_Stock_Inicial.Text 'Stock Inicial (12)
						.SubItems(Col_Stock_Inicial.Index).Tag = D_Stock_Inicial.Tag

						.SubItems(Col_Stock_Minimo.Index).Text = D_Stock_Inicial.Text 'Stock Mínimo (13)
						.SubItems(Col_Stock_Minimo.Index).Tag = D_Stock_Minimo.Tag

						.SubItems(Col_Stock.Index).Tag = Itm.SubItems(12).Tag + Itm.SubItems(11).Tag - Itm.SubItems(10).Tag
						.SubItems(Col_Stock.Index).Text = Format(Itm.SubItems(5).Tag, "##,##0.00") ' Stock (5)

						.SubItems(Col_Familia.Index).Text = D_Familia.Text 'Familia (7)
						.SubItems(Col_Familia.Index).Tag = D_Familia.Tag

						.SubItems(Col_Subfamilia.Index).Text = D_Subfamilia.Text 'Sub-Familia (6)
						.SubItems(Col_Subfamilia.Index).Tag = D_Subfamilia.Tag

						.SubItems(Col_Proveedor.Index).Text = D_Proveedor.Text 'Proveedor (8)
						.SubItems(Col_Proveedor.Index).Tag = D_Proveedor.Tag
					End With
					Cancelar.PerformClick()
				Else
					MsgBox("Se produjo un Error al grabar los datos del ARTICULO!", vbCritical)
				End If
			End If
		End If
	End Sub

	Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
		Dim Sql As String

		If MsgBox("¿Esta seguro que desea brorrar el registro seleccionado?" & vbCrLf & Listado.SelectedItems(0).SubItems(1).Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Sql = "DELETE * FROM Articulos WHERE art_id = " + Listado.SelectedItems(0).Tag.ToString

			If Base.Ejecutar_SQL(Sql) Then
				MsgBox("ARTICULO eliminado exitosamente!", vbInformation)
				If System.IO.File.Exists(Application.StartupPath + "\Imagenes\" + Listado.SelectedItems(0).Tag.ToString + ".png") Then System.IO.File.Delete(Application.StartupPath + "\Imagenes\" + Listado.SelectedItems(0).Tag.ToString + ".png")
				Listado.Items.Remove(Listado.SelectedItems(0))
			Else
				MsgBox("Se produjo un error al borrar el ARTICULO!", vbCritical)
			End If
		End If
	End Sub

	Private Sub D_Codigo_Validating(sender As Object, e As CancelEventArgs) Handles D_Codigo.Validating
		D_Codigo.Text = D_Codigo.Text.Trim
	End Sub

	Private Sub D_Codigo_Barras_Validating(sender As Object, e As CancelEventArgs) Handles D_Codigo_Barras.Validating
		D_Codigo_Barras.Text = D_Codigo_Barras.Text.Trim
	End Sub

	Private Sub D_Descripcion_Validating(sender As Object, e As CancelEventArgs) Handles D_Descripcion.Validating
		D_Descripcion.Text = D_Descripcion.Text.Trim
	End Sub

	Private Sub D_Importe_Compra_Validating(sender As Object, e As CancelEventArgs) Handles D_Importe_Compra.Validating
		D_Importe_Compra.Text = D_Importe_Compra.Text.Trim
		If D_Importe_Compra.Text = "" Then D_Importe_Compra.Text = "0"
		D_Importe_Compra.Tag = CCdec(D_Importe_Compra.Text)
		D_Importe_Compra.Text = Format(D_Importe_Compra.Tag, "$ ##,##0.00")
	End Sub

	Private Sub D_Importe_Venta_Validating(sender As Object, e As CancelEventArgs) Handles D_Importe_Venta.Validating
		D_Importe_Venta.Text = D_Importe_Venta.Text.Trim
		If D_Importe_Venta.Text = "" Then D_Importe_Venta.Text = "0"
		D_Importe_Venta.Tag = CCdec(D_Importe_Venta.Text)
		D_Importe_Venta.Text = Format(D_Importe_Venta.Tag, "$ ##,##0.00")
	End Sub

	Private Sub D_Stock_Inicial_Validating(sender As Object, e As CancelEventArgs) Handles D_Stock_Inicial.Validating
		D_Stock_Inicial.Text = D_Stock_Inicial.Text.Trim
		If D_Stock_Inicial.Text = "" Then D_Stock_Inicial.Text = "0"
		D_Stock_Inicial.Tag = CCdec(D_Stock_Inicial.Text)
		D_Stock_Inicial.Text = Format(D_Stock_Inicial.Tag, "##,##0.00")
	End Sub

	Private Sub D_Stock_Minimo_Validating(sender As Object, e As CancelEventArgs) Handles D_Stock_Minimo.Validating
		D_Stock_Minimo.Text = D_Stock_Minimo.Text.Trim
		If D_Stock_Minimo.Text = "" Then D_Stock_Minimo.Text = "0"
		D_Stock_Minimo.Tag = CCdec(D_Stock_Minimo.Text)
		D_Stock_Minimo.Text = Format(D_Stock_Minimo.Tag, "##,##0.00")
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Cargar_Imagen_CMD()
	End Sub

	Private Sub D_Familia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Familia.DropDownItemClicked
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Aux As Integer = B_Familia.Tag
		Dim Itm As ToolStripMenuItem

		If e.ClickedItem.Tag = -1 Then
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
							B_Familia.DropDownItems.Clear()
							Itm = B_Familia.DropDownItems.Add("*** TODAS LAS FAMILIAS ***")
							Itm.Tag = 0
							If Aux = 0 Then
								Itm.Checked = True
								B_Familia.Text = Itm.Text
								B_Familia.Tag = Itm.Tag
							End If

							D_Familia.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Familia.DropDownItems.Add(Tabla.Item("fam_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("fam_id")

								Itm = B_Familia.DropDownItems.Add(Tabla.Item("fam_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("fam_id")
								If Itm.Tag = Aux Then
									B_Familia.Text = Itm.Text
									B_Familia.Tag = Itm.Tag
									Itm.Checked = True
								End If
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
			C_C = e.ClickedItem.Tag
			Texto = e.ClickedItem.Text
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

	Private Sub D_Subfamilia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Subfamilia.DropDownItemClicked
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Aux As Integer = B_Subfamilia.Tag
		Dim Itm As ToolStripMenuItem

		If e.ClickedItem.Tag = -1 Then
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
							B_Subfamilia.DropDownItems.Clear()
							Itm = B_Subfamilia.DropDownItems.Add("*** TODAS LAS SUB-FAMILIAS ***")
							Itm.Tag = 0
							If Aux = 0 Then
								Itm.Checked = True
								B_Subfamilia.Text = Itm.Text
								B_Subfamilia.Tag = Itm.Tag
							End If

							D_Subfamilia.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Subfamilia.DropDownItems.Add(Tabla.Item("sfa_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("sfa_id")

								Itm = B_Subfamilia.DropDownItems.Add(Tabla.Item("sfa_descripcion").ToString.Trim)
								Itm.Tag = Tabla.Item("sfa_id")
								If Itm.Tag = Aux Then
									B_Subfamilia.Text = Itm.Text
									B_Subfamilia.Tag = Itm.Tag
									Itm.Checked = True
								End If
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
			C_C = e.ClickedItem.Tag
			Texto = e.ClickedItem.Text
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

	Private Sub D_Proveedor_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Proveedor.DropDownItemClicked
		Dim C_C As Integer
		Dim Texto As String
		Dim Sql As String
		Dim Tabla As OleDb.OleDbDataReader
		Dim Aux As Integer = B_Proveedor.Tag
		Dim Itm As ToolStripMenuItem

		If e.ClickedItem.Tag = -1 Then
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
							B_Proveedor.DropDownItems.Clear()
							Itm = B_Proveedor.DropDownItems.Add("*** TODOS LOS PROVEEDORES ***")
							Itm.Tag = 0
							If Aux = 0 Then
								Itm.Checked = True
								B_Proveedor.Text = Itm.Text
								B_Proveedor.Tag = Itm.Tag
							End If

							D_Proveedor.DropDownItems.Clear()

							Do While Tabla.Read
								Itm = D_Proveedor.DropDownItems.Add(Tabla.Item("pro_nombre").ToString.Trim)
								Itm.Tag = Tabla.Item("pro_id")

								Itm = B_Proveedor.DropDownItems.Add(Tabla.Item("pro_nombre").ToString.Trim)
								Itm.Tag = Tabla.Item("pro_id")
								If Itm.Tag = Aux Then
									B_Proveedor.Text = Itm.Text
									B_Proveedor.Tag = Itm.Tag
									Itm.Checked = True
								End If
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
			C_C = e.ClickedItem.Tag
			Texto = e.ClickedItem.Text
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

	Private Sub B_Familia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles B_Familia.DropDownItemClicked
		B_Familia.Text = e.ClickedItem.Text
		B_Familia.Tag = e.ClickedItem.Tag
		For Each Itm As ToolStripMenuItem In B_Familia.DropDownItems
			If Itm.Tag = e.ClickedItem.Tag Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm

		Dim ItmAux As ToolStripMenuItem
		B_Subfamilia.DropDownItems.Clear()
		ItmAux = B_Subfamilia.DropDownItems.Add("*** TODAS LAS SUB-FAMILIAS ***")
		ItmAux.Tag = 0
		ItmAux.Checked = True
		B_Subfamilia.Text = ItmAux.Text
		B_Subfamilia.Tag = ItmAux.Tag

		If e.ClickedItem.Tag <> 0 Then
			Dim SQL As String = "SELECT * FROM Sub_Familias WHERE fam_id = " + e.ClickedItem.Tag.ToString + " ORDER BY sfa_descripcion"
			Dim Tabla As OleDb.OleDbDataReader

			If Base.Ejecutar_SQL(SQL, Tabla) Then
				Do While Tabla.Read
					Dim Itm As ToolStripMenuItem = B_Subfamilia.DropDownItems.Add(Trim(Tabla.Item("sfa_descripcion")))
					Itm.Tag = Tabla.Item("sfa_id")
				Loop
			Else
				MsgBox("Se produjo un error al recuperar los datos de las Sub-Familias")
			End If
		End If
	End Sub

	Private Sub B_Subfamilia_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles B_Subfamilia.DropDownItemClicked
		B_Subfamilia.Text = e.ClickedItem.Text
		B_Subfamilia.Tag = e.ClickedItem.Tag
		For Each Itm As ToolStripMenuItem In B_Subfamilia.DropDownItems
			If Itm.Tag = e.ClickedItem.Tag Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm
	End Sub

	Private Sub B_Proveedor_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles B_Proveedor.DropDownItemClicked
		B_Proveedor.Text = e.ClickedItem.Text
		B_Proveedor.Tag = e.ClickedItem.Tag
		For Each Itm As ToolStripMenuItem In B_Proveedor.DropDownItems
			If Itm.Tag = e.ClickedItem.Tag Then
				Itm.Checked = True
			Else
				Itm.Checked = False
			End If
		Next Itm
	End Sub

	Private Sub Listado_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Listado.ColumnClick
		Listado.ListViewItemSorter = New ListViewColumnSort(e.Column, Listado.Columns(e.Column).Tag, Listado.Sorting)
	End Sub

	Private Sub Limpiar_Filtros_Click(sender As Object, e As EventArgs) Handles Limpiar_Filtros.Click
		B_Codigo.Text = ""
		B_Descripcion.Text = ""
		B_Familia.DropDownItems(0).PerformClick()
		B_Proveedor.DropDownItems(0).PerformClick()
		Listado.Items.Clear()
		B_Lotes.Enabled = False
		B_Codigo.Focus()
	End Sub

	Private Sub Suma_CheckedChanged(sender As Object, e As EventArgs) Handles Suma.CheckedChanged
		If Suma.Checked Then
			Resta.Checked = False
		Else
			Resta.Checked = True
		End If
	End Sub

	Private Sub Resta_CheckedChanged(sender As Object, e As EventArgs) Handles Resta.CheckedChanged
		If Resta.Checked Then
			Suma.Checked = False
		Else
			Suma.Checked = True
		End If
	End Sub

	Private Sub P_Compra_CheckedChanged(sender As Object, e As EventArgs) Handles P_Compra.CheckedChanged
		If P_Compra.Checked Then
			P_Compra.Text = "Precio Compra ✔"
		Else
			P_Compra.Text = "Precio Compra"
		End If
	End Sub

	Private Sub P_Venta_CheckedChanged(sender As Object, e As EventArgs) Handles P_Venta.CheckedChanged
		If P_Venta.Checked Then
			P_Venta.Text = "Precio Venta ✔"
		Else
			P_Venta.Text = "Precio Venta"
		End If
	End Sub

	Private Sub O_Porcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles O_Porcentaje.CheckedChanged
		If O_Porcentaje.Checked Then
			O_Porcentaje.Text = "Porcentaje ✔"
			O_Suma.Checked = False
			O_Multiplicacion.Checked = False
			O_Division.Checked = False
			O_Valor.Checked = False
		Else
			O_Porcentaje.Text = "Porcentaje"
		End If
	End Sub

	Private Sub O_Suma_CheckedChanged(sender As Object, e As EventArgs) Handles O_Suma.CheckedChanged
		If O_Suma.Checked Then
			O_Suma.Text = "Suma/Resta ✔"
			O_Porcentaje.Checked = False
			O_Multiplicacion.Checked = False
			O_Division.Checked = False
			O_Valor.Checked = False
		Else
			O_Suma.Text = "Suma/Resta"
		End If
	End Sub

	Private Sub O_Multiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles O_Multiplicacion.CheckedChanged
		If O_Multiplicacion.Checked Then
			O_Multiplicacion.Text = "Multiplicación ✔"
			O_Porcentaje.Checked = False
			O_Suma.Checked = False
			O_Division.Checked = False
			O_Valor.Checked = False
		Else
			O_Multiplicacion.Text = "Multiplicación"
		End If
	End Sub

	Private Sub O_Division_CheckedChanged(sender As Object, e As EventArgs) Handles O_Division.CheckedChanged
		If O_Division.Checked Then
			O_Division.Text = "División ✔"
			O_Porcentaje.Checked = False
			O_Suma.Checked = False
			O_Multiplicacion.Checked = False
			O_Valor.Checked = False
		Else
			O_Division.Text = "División"
		End If
	End Sub

	Private Sub O_Valor_CheckedChanged(sender As Object, e As EventArgs) Handles O_Valor.CheckedChanged
		If O_Valor.Checked Then
			O_Valor.Text = "Valor ✔"
			O_Porcentaje.Checked = False
			O_Suma.Checked = False
			O_Multiplicacion.Checked = False
			O_Division.Checked = False
		Else
			O_Valor.Text = "Valor"
		End If
	End Sub

	Private Sub Cancelar_Lotes_Click(sender As Object, e As EventArgs) Handles Cancelar_Lotes.Click
		G_Lotes.Visible = False
		G_Busqueda.Enabled = True
		G_Botones.Enabled = True
		G_Controles.Enabled = True
		Listado.Enabled = True
	End Sub

	Private Sub B_Lotes_Click(sender As Object, e As EventArgs) Handles B_Lotes.Click
		Suma.Checked = True
		O_Porcentaje.Checked = True
		P_Compra.Checked = True
		P_Venta.Checked = True
		G_Lotes.Visible = True
		G_Busqueda.Enabled = False
		G_Botones.Enabled = False
		G_Controles.Enabled = False
		Listado.Enabled = False
		D_Valor.Text = Format(0, "##,##0.00")
	End Sub

	Private Sub D_Valor_Validating(sender As Object, e As CancelEventArgs) Handles D_Valor.Validating
		If D_Valor.Text.Trim = "" Then D_Valor.Text = "0"
		D_Valor.Text = Format(CCdec(D_Valor.Text), "##,##0.00")
	End Sub

	Private Sub Listado_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Listado.ItemChecked
		Try
			If Listado.CheckedItems.Count >= 1 Then
				B_Lotes.Enabled = True
			Else
				B_Lotes.Enabled = False
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Aceptar_Lotes_Click(sender As Object, e As EventArgs) Handles Aceptar_Lotes.Click
		Dim Aux As Decimal 'Valor de actualización
		Dim Sql1 As String = "" 'SQL para actualizar precios de compra
		Dim Sql2 As String = ""  'SQL para actualizar precios de venta
		Dim Codigos As String = "" 'Codigos a actualizar
		Dim Itm As ListViewItem


		Aux = CCdec(D_Valor.Text)

		If Aux = 0 And O_Division.Checked Then
			MsgBox("El valor debe ser distinto a '0' para una división")
			D_Valor.Focus()
			Exit Sub
		End If

		If Resta.Checked Then
			Aux *= -1
		End If

		If Not P_Compra.Checked And Not P_Venta.Checked Then
			MsgBox("Debe elegir al menos un precio a modificar (Compra o Venta)")
			Exit Sub
		End If

		If P_Compra.Checked And P_Venta.Checked And O_Valor.Checked Then
			If MsgBox("¿Esta seguro que desea fijar el mismo precio tanto para compra como para venta?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
				Exit Sub
			End If
		End If

		If MsgBox("Confirme actualización de precios", vbYesNo) = vbYes Then
			UseWaitCursor = True
			Cursor = Cursors.WaitCursor
			Me.Refresh()

			For Each Itm In Listado.CheckedItems
				If Codigos <> "" Then Codigos += ", "
				Codigos += Itm.Tag.ToString
			Next
			Codigos = "(" + Codigos + ")"

			If O_Porcentaje.Checked Then 'Porcentaje **********************************************************************************************
				Aux = Aux / 100 + 1
			End If

			If O_Suma.Checked Then 'Suma o Resta **************************************************************************************************
				If P_Compra.Checked Then
					Sql1 = "UPDATE Articulos SET
								art_importe_compra =  art_importe_compra + " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If

				If P_Venta.Checked Then
					Sql2 = "UPDATE Articulos SET
								art_importe_venta =  art_importe_venta + " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If
			ElseIf O_Porcentaje.Checked Or O_Multiplicacion.Checked Then 'Porcentaje o Multiplicacion *********************************************
				If P_Compra.Checked Then
					Sql1 = "UPDATE Articulos SET
								art_importe_compra =  art_importe_compra * " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If

				If P_Venta.Checked Then
					Sql2 = "UPDATE Articulos SET
								art_importe_venta =  art_importe_venta * " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If
			ElseIf O_Division.Checked Then 'División **********************************************************************************************
				If P_Compra.Checked Then
					Sql1 = "UPDATE Articulos SET
							art_importe_compra =  art_importe_compra / " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If

				If P_Venta.Checked Then
					Sql2 = "UPDATE Articulos SET
								art_importe_venta =  art_importe_venta * " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If
			Else 'Valor ***************************************************************************************************************************
				If P_Compra.Checked Then
					Sql1 = "UPDATE Articulos SET 
								art_importe_compra =  " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If

				If P_Venta.Checked Then
					Sql2 = "UPDATE Articulos SET
								art_importe_venta =  " + Replace(Aux.ToString, ",", ".") + ",
								art_fecha = '" + Format(Today(), "dd/MM/yyyy") + "'
								WHERE art_id IN " + Codigos
				End If
			End If

			' *************************************************************************************************************************************

			If P_Compra.Checked Then
				If Base.Ejecutar_SQL(Sql1) Then
					MsgBox("Precios de COMPRA actualizados!!!")
				Else
					MsgBox("Se produjo un error al actualizar los precios de compra")
				End If
			End If

			If P_Venta.Checked Then
				If Base.Ejecutar_SQL(Sql2) Then
					MsgBox("Precios de VENTA actualizados!!!")
				Else
					MsgBox("Se produjo un error al actualizar los precios de venta")
				End If
			End If

			Cancelar_Lotes.PerformClick()

			Buscar.PerformClick()

			UseWaitCursor = False
			Cursor = Cursors.Default
		End If
	End Sub

	Private Sub Listado_DoubleClick(sender As Object, e As EventArgs) Handles Listado.DoubleClick
		If Selecciona Then
			If Listado.SelectedItems.Count = 1 Then
				If Origen = Origen.F_Ventas Then
					'ORIGEN VENTAS ************************************************************************************************************
					Dim Frm As Frm_Ventas = CType(Owner, Frm_Ventas)
					Dim Itm As ListViewItem = Listado.SelectedItems.Item(0)

					With Frm

						If Itm.SubItems(Col_Cod_Barras.Index).Text <> "" Then
							.D_Codigo.Text = Itm.SubItems(Col_Cod_Barras.Index).Text
						Else
							If Itm.SubItems(Col_Codigo.Index).Text <> "" Then
								.D_Codigo.Text = Itm.SubItems(Col_Codigo.Index).Text
							End If
						End If

						.D_Importe.Text = Itm.SubItems(Col_Importe_Venta.Index).Text
						.D_Importe.Tag = Itm.SubItems(Col_Importe_Venta.Index).Tag
						.D_Fecha.Tag = Itm.SubItems(Col_Importe_Compra.Index).Tag
						.D_Fecha.Value = Itm.SubItems(Col_Fecha.Index).Text
						If CCdec(.D_Cantidad.Text) = 0 Then
							.D_Cantidad.Tag = 1
							.D_Cantidad.Text = Format(.D_Cantidad.Tag, "##,##0.00")
						End If

						.D_Total.Tag = .D_Importe.Tag * .D_Cantidad.Tag
						.D_Total.Text = Format(.D_Total.Tag, "$ ##,##0.00")

						If .D_Total.Tag = 0 Then
							.Aceptar_Articulo.Enabled = False
						Else
							.Aceptar_Articulo.Enabled = True
						End If

						.D_Descripcion.Text = Itm.SubItems(Col_Descripcion.Index).Text
						.D_Codigo.Tag = Itm.Tag
						.D_Descripcion.Tag = Itm.SubItems(Col_Stock.Index).Tag


						.D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png")
						.D_Imagen.Tag = Itm.Tag.ToString + ".png"

						If Itm.SubItems(Col_Stock.Index).Tag <= 0 Then
							.Stock.Image = My.Resources.Stock_Rojo_128
						ElseIf Itm.SubItems(Col_Stock.Index).Tag <= Itm.SubItems(Col_Stock_Minimo.Index).Tag Then
							.Stock.Image = My.Resources.Stock_Amarillo_128
						Else
							.Stock.Image = My.Resources.Stock_Verde_128
						End If
					End With

				ElseIf Origen = Origen.F_Ingresos Then
					'ORIGEN INGRESOS **********************************************************************************************************
					Dim Frm As Frm_Ingresos = CType(Owner, Frm_Ingresos)
					Dim Itm As ListViewItem = Listado.SelectedItems.Item(0)

					With Frm

						If Itm.SubItems(Col_Cod_Barras.Index).Text <> "" Then
							.D_Codigo.Text = Itm.SubItems(Col_Cod_Barras.Index).Text
						Else
							If Itm.SubItems(Col_Codigo.Index).Text <> "" Then
								.D_Codigo.Text = Itm.SubItems(Col_Codigo.Index).Text
							End If
						End If
						.D_Codigo.Tag = Itm.Tag
						If CCdec(.D_Cantidad.Text) = 0 Then
							.D_Cantidad.Tag = 1
							.D_Cantidad.Text = Format(.D_Cantidad.Tag, "##,##0.00")
						End If
						.D_Fecha.Tag = Itm.SubItems(Col_Fecha.Index).Tag
						.D_Fecha.Value = Itm.SubItems(Col_Fecha.Index).Text
						If Administrador Then
							.D_Importe_Compra.Text = Itm.SubItems(Col_Importe_Compra.Index).Text
						Else
							D_Importe_Compra.Text = Replace(Format(0, "##,##0.00"), "0", "#")
						End If
						.D_Importe_Compra.Tag = Itm.SubItems(Col_Importe_Compra.Index).Tag
						.D_Importe_Venta.Text = Itm.SubItems(Col_Importe_Venta.Index).Text
						.D_Importe_Venta.Tag = Itm.SubItems(Col_Importe_Venta.Index).Tag
						.D_Descripcion.Text = Itm.SubItems(Col_Descripcion.Index).Text
						.D_Descripcion.Tag = Itm.SubItems(Col_Descripcion.Index).Text
						For Each It As ToolStripDropDownItem In .D_Familia.DropDownItems
							If It.Tag = Itm.SubItems(Col_Familia.Index).Tag Then
								.T_B_Familia.Tag = It.Tag
								.Muestra_Familia(It)
								Exit For
							End If
						Next
						For Each It As ToolStripDropDownItem In .D_Subfamilia.DropDownItems
							If It.Tag = Itm.SubItems(Col_Subfamilia.Index).Tag Then
								.T_B_Subfamilia.Tag = It.Tag
								.Muestra_SubFamilia(It)
								Exit For
							End If
						Next
						For Each It As ToolStripDropDownItem In .D_Proveedor.DropDownItems
							If It.Tag = Itm.SubItems(Col_Proveedor.Index).Tag Then
								.T_B_Proveedor.Tag = It.Tag
								.Muestra_Proveedor(It)
								Exit For
							End If
						Next
						.D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png")
						.D_Imagen.Tag = Itm.Tag.ToString + ".png"

						.Aceptar_Articulo.Enabled = True

						.G_Datos1.Enabled = True
					End With

				ElseIf Origen = Origen.F_QR Then
					'ORIGEN QR ****************************************************************************************************************
					Dim Frm As Frm_QR = CType(Owner, Frm_QR)
					Dim Itm As ListViewItem = Listado.SelectedItems.Item(0)

					With Frm

						If Itm.SubItems(Col_Cod_Barras.Index).Text <> "" Then
							.D_Codigo.Text = Itm.SubItems(Col_Cod_Barras.Index).Text
						Else
							If Itm.SubItems(Col_Codigo.Index).Text <> "" Then
								.D_Codigo.Text = Itm.SubItems(Col_Codigo.Index).Text
							End If
						End If

						.D_Descripcion.Text = Itm.SubItems(Col_Descripcion.Index).Text
						.D_Codigo.Tag = Itm.Tag

						If CCdec(.D_Cantidad.Text) = 0 Then
							.D_Cantidad.Tag = 1
							.D_Cantidad.Text = Format(.D_Cantidad.Tag, "##,##0.00")
						End If

						If .D_Cantidad.Tag = 0 Then
							.Aceptar_Articulo.Enabled = False
						Else
							.Aceptar_Articulo.Enabled = True
						End If
					End With

				ElseIf Origen = Origen.F_Etiqueta Then
					'ORIGEN QR ****************************************************************************************************************
					Dim Frm As Frm_Etiqueta = CType(Owner, Frm_Etiqueta)
					Dim Itm As ListViewItem = Listado.SelectedItems.Item(0)

					With Frm

						If Itm.SubItems(Col_Cod_Barras.Index).Text <> "" Then
							.D_Codigo.Text = Itm.SubItems(Col_Cod_Barras.Index).Text
						Else
							If Itm.SubItems(Col_Codigo.Index).Text <> "" Then
								.D_Codigo.Text = Itm.SubItems(Col_Codigo.Index).Text
							End If
						End If

						.D_Precio.Text = Itm.SubItems(Col_Importe_Venta.Index).Text
						.D_Descripcion.Text = Itm.SubItems(Col_Descripcion.Index).Text
						.D_Codigo.Tag = Itm.Tag

						If CCdec(.D_Cantidad.Text) = 0 Then
							.D_Cantidad.Tag = 1
							.D_Cantidad.Text = Format(.D_Cantidad.Tag, "##,##0.00")
						End If

						If .D_Cantidad.Tag = 0 Then
							.Aceptar_Articulo.Enabled = False
						Else
							.Aceptar_Articulo.Enabled = True
						End If
					End With

				End If

				Close()

			End If
		End If
	End Sub

	Private Sub B_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles B_Codigo.KeyPress
		If e.KeyChar = vbCr Then
			Buscar.PerformClick()
		End If
	End Sub

	Private Sub Codigo_Barras_Click(sender As Object, e As EventArgs) Handles Codigo_Barras.Click
		Dim Frm As New Frm_QR

		'AddOwnedForm(Frm_Vista_Previa)

		Frm.ShowDialog()

	End Sub

	Private Sub TMnu_Eliminar_Click(sender As Object, e As EventArgs) Handles TMnu_Eliminar.Click
		D_Imagen.Image = Nothing
	End Sub

	Private Sub B_Codigo_TextChanged(sender As Object, e As EventArgs) Handles B_Codigo.TextChanged

	End Sub

	Private Sub D_Codigo_Barras_LostFocus(sender As Object, e As EventArgs) Handles D_Codigo_Barras.LostFocus

	End Sub
End Class