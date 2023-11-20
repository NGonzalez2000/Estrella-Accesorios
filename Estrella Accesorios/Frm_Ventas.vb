Imports System.ComponentModel

Public Class Frm_Ventas

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

	Private Sub Limpiar()
		D_Cantidad.Text = Format(0, "##,##0.00")
		D_Cantidad.Tag = 0
		Adv.Visible = False
		Adv1.Visible = False
		Timer1.Enabled = False
		D_Importe.Text = Format(0, "$ ##,##0.00")
		D_Importe.Tag = 0
		D_Total.Text = Format(0, "$ ##,##0.00")
		D_Total.Tag = 0
		Aceptar_Articulo.Enabled = False
		D_Descripcion.Text = ""
		D_Fecha.Value = Today()
		D_Imagen.Image = Nothing
		D_Imagen.Tag = ""
		D_Devolucion.Checked = False
		D_Devolucion.Tag = 1
		Stock.Image = Nothing
		D_Devolucion.Checked = False
		D_Devolucion.Tag = 1
	End Sub

	Private Sub Frm_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		'Adv.Parent = D_Importe

		Dim SQL As String = "SELECT * FROM Forma_Pago WHERE fpa_habilitado = true ORDER BY fpa_descripcion"
		Dim Itm As ToolStripMenuItem
		Dim Tabla As OleDb.OleDbDataReader

		Itm = D_Forma_Pago.DropDownItems.Add("*** SELECCIONE FORMA PAGO ***")
		Itm.Tag = 0
		Itm.Checked = True

		If Base.Ejecutar_SQL(SQL, Tabla) Then
			Do While Tabla.Read
				Itm = D_Forma_Pago.DropDownItems.Add(Tabla.Item("fpa_descripcion"))
				Itm.Tag = Tabla.Item("fpa_id")
			Loop
		Else
			MsgBox("Se produjo un error al intentar recuperar las formas de pago")
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

	Private Sub Cancelar_Articulo_Click(sender As Object, e As EventArgs) Handles Cancelar_Articulo.Click
		Limpiar()
		D_Codigo.Text = ""
		D_Codigo.Focus()
		Listado.Enabled = True
	End Sub

	Private Sub Frm_Ventas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		Cancelar_Articulo.PerformClick()
		D_Forma_Pago.DropDownItems(0).PerformClick()
		Abonado.Tag = 0
		Calcula_Importes()
	End Sub

	Private Sub D_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_Codigo.KeyPress
		If e.KeyChar = vbCr Then
			D_Cantidad.Focus()
			e.Handled = True
		End If
	End Sub

	Private Sub D_Codigo_Validating(sender As Object, e As CancelEventArgs) Handles D_Codigo.Validating
		D_Codigo.Text = D_Codigo.Text.Trim

		If D_Codigo.Text <> "" Then
			Dim Tabla As OleDb.OleDbDataReader
			Dim Sql As String = "SELECT Articulos.art_id, IIF(ISNULL(Articulos.art_codigo), '', Articulos.art_codigo) AS art_codigo, Articulos.art_descripcion, IIF(ISNULL(Articulos.art_codigo_barras), '', Articulos.art_codigo_barras) AS art_codigo_barras, Articulos.art_importe_venta, Articulos.art_fecha,
									  MIN(Articulos.art_stock_inicial) + IIf(IsNull(Sum(Ingresos.ing_cantidad)),0,Sum(Ingresos.ing_cantidad)) - IIF(ISNULL(Sum(Detalle_Ventas.art_cantidad)), 0,Sum(Detalle_Ventas.art_cantidad)) AS stock, Articulos.art_stock_minimo, Articulos.art_importe_compra
								FROM (Articulos LEFT JOIN Ingresos ON Articulos.art_id = Ingresos.art_id) LEFT JOIN Detalle_Ventas ON Articulos.art_id = Detalle_Ventas.art_id
								WHERE art_codigo = '" + D_Codigo.Text + "' OR art_codigo_barras = '" + D_Codigo.Text + "'
								GROUP BY Articulos.art_id, IIF(ISNULL(Articulos.art_codigo), '', Articulos.art_codigo), Articulos.art_descripcion, IIF(ISNULL(Articulos.art_codigo_barras), '', Articulos.art_codigo_barras), Articulos.art_importe_venta, Articulos.art_fecha, Articulos.art_stock_minimo, Articulos.art_importe_compra"
			If Base.Ejecutar_SQL(Sql, Tabla) Then
				If Tabla.Read() Then
					If (Today().ToOADate - CDate(Tabla.Item("art_fecha")).ToOADate) >= My.Settings.Dias_Aviso Then
						Adv.Visible = True
						Timer1.Enabled = True
					Else
						Adv.Visible = False
						Adv1.Visible = False
						Timer1.Enabled = False
					End If
					D_Importe.Text = Format(Tabla.Item("art_importe_venta"), "$ ##,##0.00")
					D_Importe.Tag = Tabla.Item("art_importe_venta")
					D_Fecha.Tag = Tabla.Item("art_importe_compra")
					If CCdec(D_Cantidad.Text) = 0 Then
						D_Cantidad.Tag = 1
						D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")
					End If

					D_Total.Tag = D_Importe.Tag * D_Cantidad.Tag
					D_Total.Text = Format(D_Total.Tag, "$ ##,##0.00")

					If D_Total.Tag = 0 Then
						Aceptar_Articulo.Enabled = False
					Else
						Aceptar_Articulo.Enabled = True
					End If

					D_Descripcion.Text = Tabla.Item("art_descripcion").ToString.Trim
					D_Codigo.Tag = Tabla.Item("art_id")
					D_Descripcion.Tag = Tabla.Item("stock")
					D_Fecha.Value = Tabla.Item("art_fecha")

					D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Tabla.Item("art_id").ToString + ".png")
					D_Imagen.Tag = Tabla.Item("art_id").ToString + ".png"

					If Tabla.Item("Stock") <= 0 Then
						Stock.Image = My.Resources.Stock_Rojo_128
					ElseIf Tabla.Item("stock") < Tabla.Item("art_stock_minimo") Then
						Stock.Image = My.Resources.Stock_Amarillo_128
					Else
						Stock.Image = My.Resources.Stock_Verde_128
					End If
				Else
					MsgBox("No se pudo repuperar los datos del artículo o artículo inexistente!")
				End If
			Else
				MsgBox("No se pudo recuperar los datos del artículo!")
			End If
		End If
	End Sub

	Private Sub Aceptar_Articulo_Click(sender As Object, e As EventArgs) Handles Aceptar_Articulo.Click
		Dim Itm As ListViewItem
		Dim Cant_Total As Decimal

		If D_Cantidad.Tag <= 0 Then
			MsgBox("La cantidad debe ser mayor a 0")
			D_Cantidad.Focus()
			Exit Sub
		End If

		For Each Itm In Listado.Items
			If Itm.Tag = D_Codigo.Tag And Not Itm.Selected Then
				Cant_Total += Itm.SubItems(Col_Cantidad.Index).Tag
			End If
		Next

		Cant_Total += D_Cantidad.Tag * D_Devolucion.Tag

		If D_Descripcion.Tag < Cant_Total Then
			If MsgBox("La cantidad de venta es mayor al stock informado en el sistema" & vbCrLf & "¿Esta correcta la cantidad de ventas?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
				D_Cantidad.Focus()
				Exit Sub
			End If
		End If

		If Not D_Imagen.Image Is Nothing Then
			' Verifica si la imagen existe en la lisa del Imagelist usando el art_id como identificador
			If Not (ImageList1.Images.ContainsKey(D_Imagen.Tag.ToString)) Then
				ImageList1.Images.Add(D_Imagen.Tag.ToString, D_Imagen.Image)
			End If
		End If

		If Listado.Enabled Then
			If Not D_Imagen.Image Is Nothing Then
				Itm = New ListViewItem("", D_Imagen.Tag.ToString) With {
				.Tag = D_Codigo.Tag
				}
			Else
				Itm = New ListViewItem("") With {
				.Tag = D_Codigo.Tag
				}
			End If

			If D_Devolucion.Checked Then
				Itm.BackColor = My.Settings.Color0
			End If
			Itm.SubItems.Add(D_Cantidad.Text)
			Itm.SubItems(Col_Cantidad.Index).Tag = D_Cantidad.Tag * D_Devolucion.Tag
			Itm.SubItems.Add(D_Descripcion.Text)
			Itm.SubItems(Col_Descripcion.Index).Tag = D_Codigo.Text
			Itm.SubItems.Add(D_Importe.Text)
			Itm.SubItems(Col_Importe.Index).Tag = D_Importe.Tag
			Itm.SubItems.Add(D_Total.Text)
			Itm.SubItems(Col_Total.Index).Tag = D_Total.Tag * D_Devolucion.Tag
			Itm.SubItems.Add("")
			Itm.SubItems(Col_Importe_Compra.Index).Tag = D_Fecha.Tag
			Itm.SubItems.Add("")
			Itm.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value


			Listado.Items.Add(Itm)
		Else
			Itm = Listado.SelectedItems(0)
			If Not D_Imagen.Image Is Nothing Then
				Itm.ImageKey = D_Imagen.Tag.ToString
			Else
				Itm.ImageKey = ""
			End If

			If D_Devolucion.Checked Then
				Itm.BackColor = My.Settings.Color0
			Else
				Itm.BackColor = Color.White
			End If
			Itm.Tag = D_Codigo.Tag
			Itm.SubItems(Col_Cantidad.Index).Text = D_Cantidad.Text
			Itm.SubItems(Col_Cantidad.Index).Tag = D_Cantidad.Tag * D_Devolucion.Tag
			Itm.SubItems(Col_Descripcion.Index).Text = D_Descripcion.Text
			Itm.SubItems(Col_Descripcion.Index).Tag = D_Codigo.Text
			Itm.SubItems(Col_Importe.Index).Text = D_Importe.Text
			Itm.SubItems(Col_Importe.Index).Tag = D_Importe.Tag
			Itm.SubItems(Col_Total.Index).Text = D_Total.Text
			Itm.SubItems(Col_Total.Index).Tag = D_Total.Tag * D_Devolucion.Tag
			Itm.SubItems(Col_Importe_Compra.Index).Tag = D_Fecha.Tag
			Itm.SubItems(Col_Fecha.Index).Tag = D_Fecha.Value
			Listado.Enabled = True
		End If

		Itm.EnsureVisible()

		Cancelar_Venta.Enabled = True

		Cancelar_Articulo.PerformClick()

		G_Pago.Enabled = True

		Calcula_Importes()
	End Sub

	Private Sub D_Cantidad_Validating(sender As Object, e As CancelEventArgs) Handles D_Cantidad.Validating
		D_Cantidad.Text = D_Cantidad.Text.Trim

		If D_Cantidad.Text = "" Then D_Cantidad.Text = "0"

		D_Cantidad.Tag = CCdec(D_Cantidad.Text)
		D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")


		D_Total.Tag = D_Cantidad.Tag * D_Importe.Tag
		D_Total.Text = Format(D_Total.Tag, "$ ##,##0.00")
	End Sub

	Private Sub D_Importe_Validating(sender As Object, e As CancelEventArgs) Handles D_Importe.Validating
		D_Importe.Text = D_Importe.Text.Trim

		If D_Importe.Text = "" Then D_Importe.Text = "0"

		D_Importe.Tag = CCdec(D_Importe.Text)
		D_Importe.Text = Format(D_Importe.Tag, "$ ##,##0.00")

		'ver con MARI el criterio
		'If D_Fecha.Tag <> D_Importe.Tag Then
		'	If MsgBox("El precio unitario es distinto al precio de lista, ¿es esto correcto?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
		'		e.Cancel = True
		'	End If
		'End If

		D_Total.Tag = D_Cantidad.Tag * D_Importe.Tag
		D_Total.Text = Format(D_Total.Tag, "$ ##,##0.00")
	End Sub

	Private Sub Frm_Ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.F8 Then
			Buscar.PerformClick()
		End If
	End Sub

	Private Sub Listado_DoubleClick(sender As Object, e As EventArgs) Handles Listado.DoubleClick
		If Listado.SelectedItems.Count = 1 Then
			Dim Itm As ListViewItem = Listado.SelectedItems(0)

			D_Codigo.Text = Itm.SubItems(Col_Descripcion.Index).Tag
			D_Codigo.Tag = Itm.Tag
			D_Cantidad.Text = Itm.SubItems(Col_Cantidad.Index).Text
			D_Cantidad.Tag = Math.Abs(Itm.SubItems(Col_Cantidad.Index).Tag)
			D_Descripcion.Text = Itm.SubItems(Col_Descripcion.Index).Text
			If (Today().ToOADate - Itm.SubItems(Col_Fecha.Index).Tag.ToOADate) >= My.Settings.Dias_Aviso Then
				Adv.Visible = True
				Timer1.Enabled = True
			Else
				Adv.Visible = False
				Adv1.Visible = False
				Timer1.Enabled = False
			End If
			D_Importe.Text = Itm.SubItems(Col_Importe.Index).Text
			D_Importe.Tag = Math.Abs(Itm.SubItems(Col_Importe.Index).Tag)
			D_Total.Text = Itm.SubItems(Col_Total.Index).Text
			D_Total.Tag = Math.Abs(Itm.SubItems(Col_Total.Index).Tag)
			D_Fecha.Value = Itm.SubItems(Col_Fecha.Index).Tag
			D_Fecha.Tag = Itm.SubItems(Col_Importe_Compra.Index).Tag

			D_Imagen.Image = AbrirImagen(Application.StartupPath + "\Imagenes\" + Itm.Tag.ToString + ".png")
			D_Imagen.Tag = Itm.Tag.ToString + ".png"

			Listado.Enabled = False

			If Itm.BackColor = My.Settings.Color0 Then
				D_Devolucion.Checked = True
				D_Devolucion.Tag = -1
			Else
				D_Devolucion.Checked = False
				D_Devolucion.Tag = 1
			End If

			D_Cantidad.Focus()

		End If
	End Sub

	Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
		Dim Frm_Art As New Frm_Articulos
		AddOwnedForm(Frm_Art)
		Frm_Art.Origen = Origen.F_Ventas
		Frm_Art.Selecciona = True
		Frm_Art.ShowDialog()
		If D_Codigo.Text.Trim <> "" Then
			D_Cantidad.Focus()
		Else
			D_Codigo.Focus()
		End If
	End Sub

	Private Sub D_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_Cantidad.KeyPress
		If e.KeyChar = vbCr Then
			Aceptar_Articulo.Focus()
			e.Handled = True
		End If
	End Sub

	Private Sub Cancelar_Venta_Click(sender As Object, e As EventArgs) Handles Cancelar_Venta.Click
		If MsgBox("¿Desea cancelar venta?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
			Cancelar_Todo()
		End If
	End Sub

	Sub Cancelar_Todo()
		Cancelar_Articulo.PerformClick()

		D_Forma_Pago.DropDownItems(0).PerformClick()

		Subtotal.Tag = 0
		Total.Tag = 0
		Abonado.Tag = 0
		Vuelto.Tag = 0

		Guardar_Venta.Enabled = False
		Cancelar_Venta.Enabled = False

		G_Pago.Enabled = False

		Listado.Items.Clear()

		Calcula_Importes()

		D_Codigo.Focus()
	End Sub

	Private Sub D_Forma_Pago_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles D_Forma_Pago.DropDownItemClicked
		For Each itm As ToolStripMenuItem In D_Forma_Pago.DropDownItems
			If itm.Tag = e.ClickedItem.Tag Then
				itm.Checked = True
				D_Forma_Pago.Text = itm.Text
				D_Forma_Pago.Tag = itm.Tag
			Else
				itm.Checked = False
			End If
		Next

		If e.ClickedItem.Tag = 0 Then
			V_Descuento.Tag = 0
			V_Recargo.Tag = 0

			Guardar_Venta.Enabled = False
		Else
			Dim SQL As String = "SELECT * FROM Forma_Pago WHERE fpa_id = " + e.ClickedItem.Tag.ToString
			Dim Tabla As OleDb.OleDbDataReader

			If Base.Ejecutar_SQL(SQL, Tabla) Then
				If Tabla.Read Then

					V_Descuento.Tag = Tabla.Item("fpa_descuento")
					V_Recargo.Tag = Tabla.Item("fpa_recargo")

					If Subtotal.Tag <> 0 Then
						Guardar_Venta.Enabled = True
					Else
						Guardar_Venta.Enabled = False
					End If
				Else
					MsgBox("Se produjo un error al intentar recuperar los datos de la forma de pago sellecionada")
					V_Descuento.Tag = 0
					V_Recargo.Tag = 0
					Guardar_Venta.Enabled = False
				End If
			Else
				MsgBox("Se produjo un error al intentar recuperar los datos de la forma de pago sellecionada")
				V_Descuento.Tag = 0
				V_Recargo.Tag = 0
				Guardar_Venta.Enabled = False
			End If
		End If

		Calcula_Importes()
	End Sub

	Sub Calcula_Importes()
		Dim Itm As ListViewItem
		Dim Aux As Decimal

		For Each Itm In Listado.Items
			Aux += Itm.SubItems(Col_Total.Index).Tag
		Next

		Subtotal.Tag = Aux
		Descuento.Tag = Subtotal.Tag * V_Descuento.Tag / 100
		Recargo.Tag = Subtotal.Tag * V_Recargo.Tag / 100
		Total.Tag = Subtotal.Tag + Recargo.Tag - Descuento.Tag
		Vuelto.Tag = Abonado.Tag - Total.Tag

		Subtotal.Text = Format(Subtotal.Tag, "$ ##,##0.00")
		V_Descuento.Text = Format(V_Descuento.Tag, "##,##0.00") + "%"
		V_Recargo.Text = Format(V_Recargo.Tag, "##,##0.00") + "%"
		Descuento.Text = Format(Descuento.Tag, "$ ##,##0.00")
		Recargo.Text = Format(Recargo.Tag, "$ ##,##0.00")
		Total.Text = Format(Total.Tag, "$ ##,##0.00")
		Abonado.Text = Format(Abonado.Tag, "$ ##,##0.00")
		Vuelto.Text = Format(Vuelto.Tag, "$ ##,##0.00")
	End Sub

	Private Sub Abonado_Validating(sender As Object, e As CancelEventArgs) Handles Abonado.Validating
		Abonado.Text = Abonado.Text.Trim

		If Abonado.Text = "" Then Abonado.Text = "0"

		Abonado.Tag = CCdec(Abonado.Text)
		Abonado.Text = Format(Abonado.Tag, "$ ##,##0.00")

		Calcula_Importes()
	End Sub

	Private Sub Listado_MouseClick(sender As Object, e As MouseEventArgs) Handles Listado.MouseClick
		If e.Button = MouseButtons.Right Then
			Dim Itm As ListViewItem = Listado.HitTest(e.X, e.Y).Item
			If Not Itm Is Nothing Then
				mnu_Eliminar.Show(Listado, New Point(e.X, e.Y))
			End If
		End If
	End Sub

	Private Sub Listado_KeyDown(sender As Object, e As KeyEventArgs) Handles Listado.KeyDown
		If e.KeyCode = Keys.Delete Then
			TMnu_Eliminar.PerformClick()
		End If
	End Sub

	Private Sub TMnu_Eliminar_Click(sender As Object, e As EventArgs) Handles TMnu_Eliminar.Click
		If Listado.SelectedItems.Count = 1 Then
			Listado.SelectedItems(0).Remove()
			Calcula_Importes()
			If Listado.Items.Count = 0 Then
				Cancelar_Venta.Enabled = False
				Guardar_Venta.Enabled = False
			End If
			D_Codigo.Focus()
		End If
	End Sub

	Private Sub Guardar_Venta_Click(sender As Object, e As EventArgs) Handles Guardar_Venta.Click
		If MsgBox("¿Confirma venta?" &
				  vbCrLf & "Cantidad de articulos: " & Listado.Items.Count &
				  vbCrLf & "Importe Total: " & Total.Text &
				  vbCrLf & "Forma de Pago: " & D_Forma_Pago.Text, vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then

			UseWaitCursor = True
			Cursor = Cursors.WaitCursor

			Dim C_C As Integer
			Dim Sql As String = "INSERT INTO Ventas
									(ven_fecha, ven_total, usu_id, fpa_id, ven_descuento, ven_recargo)
								VALUES
									('" + Format(Today(), "dd/MM/yyyy") + "'
									, " + Replace(Total.Tag.ToString, ",", ".") + "
									, " + Usuario.ToString + "
									, " + D_Forma_Pago.Tag.ToString + "
									, " + Replace(V_Descuento.Tag.ToString, ",", ".") + "
									, " + Replace(V_Recargo.Tag.ToString, ",", ".") + ")"

			If Base.Ejecutar_SQL(Sql, C_C, "ven_id", "Ventas") Then
				For Each itm As ListViewItem In Listado.Items
					'Dim Aux As Decimal = itm.SubItems(Col_Importe.Index).Tag + (itm.SubItems(Col_Importe.Index).Tag * V_Recargo.Tag / 100) - (itm.SubItems(Col_Importe.Index).Tag * V_Descuento.Tag / 100)
					'Sql = "INSERT INTO Detalle_Ventas
					'			(ven_id, art_id, art_cantidad, art_importe, art_importe_compra)
					'		VALUES
					'			( " + C_C.ToString + "
					'			, " + itm.Tag.ToString + "
					'			, " + Replace(itm.SubItems(Col_Cantidad.Index).Tag.ToString, ",", ".") + "
					'			, " + Replace(Aux.ToString, ",", ".") + "
					'			, " + Replace(itm.SubItems(Col_Importe_Compra.Index).Tag.ToString, ",", ".") + ")"

					Sql = "INSERT INTO Detalle_Ventas
								(ven_id, art_id, art_cantidad, art_importe, art_importe_compra)
							VALUES
								( " + C_C.ToString + "
								, " + itm.Tag.ToString + "
								, " + Replace(itm.SubItems(Col_Cantidad.Index).Tag.ToString, ",", ".") + "
								, " + Replace(itm.SubItems(Col_Importe.Index).Tag.ToString, ",", ".") + "
								, " + Replace(itm.SubItems(Col_Importe_Compra.Index).Tag.ToString, ",", ".") + ")"

					If Not Base.Ejecutar_SQL(Sql) Then
						MsgBox("Se produjo un error al cargar el " + itm.Index + 1.ToString + " item")
					End If
				Next
				If MsgBox("Venta grabada exitosamente!!!" & vbCrLf & vbCrLf & "¿Desea imprimir el detalle?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then

					Dim Reporte As New Rpt_Ventas
					Dim Frm As New Frm_Vista_Previa
					AddOwnedForm(Frm)

					Sql = "{Ventas.ven_id} = " + C_C.ToString

					Frm.Mostrar(Reporte, My.Settings.Database, My.Settings.Uid, My.Settings.Password, "", Sql)
				End If
				Cancelar_Todo()
			Else
				MsgBox("Se produjo un error al cargar la venta")
			End If

			UseWaitCursor = False
			Cursor = Cursors.Default
		End If
	End Sub

	Private Sub D_Codigo_TextChanged(sender As Object, e As EventArgs) Handles D_Codigo.TextChanged
		Limpiar()
	End Sub

	Private Sub Aceptar_Articulo_GotFocus(sender As Object, e As EventArgs) Handles Aceptar_Articulo.GotFocus
		Aceptar_Articulo.BackColor = Color.SpringGreen
	End Sub

	Private Sub Aceptar_Articulo_LostFocus(sender As Object, e As EventArgs) Handles Aceptar_Articulo.LostFocus
		Aceptar_Articulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
	End Sub

	Private Sub Adv_Click(sender As Object, e As EventArgs) Handles Adv.Click, Adv1.Click
		Dim Dias As Integer = (Today().ToOADate - D_Fecha.Value.ToOADate)
		MsgBox("Verifique el precio ya que la ultima actualización fue hace " + Dias.ToString + " dias", vbExclamation)
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Adv.Visible = Not Adv.Visible
		Adv1.Visible = Not Adv.Visible
	End Sub

	Private Sub Listado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listado.SelectedIndexChanged

	End Sub

	Private Sub D_Forma_Pago_Click(sender As Object, e As EventArgs) Handles D_Forma_Pago.Click

	End Sub

	Private Sub D_Devolucion_CheckedChanged(sender As Object, e As EventArgs) Handles D_Devolucion.CheckedChanged
		If D_Devolucion.Checked Then
			D_Devolucion.Tag = -1
		Else
			D_Devolucion.Tag = 1
		End If
	End Sub
End Class