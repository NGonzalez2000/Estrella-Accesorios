Imports System.ComponentModel

Public Class Frm_QR

    Dim ex As Int16
    Dim ey As Int16
    Dim Arrastre As Boolean

    'Private WithEvents RS232 As New System.IO.Ports.SerialPort

    'Private Sub RS232_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles RS232.DataReceived
    '    Try
    '        Dim Incoming As String = RS232.ReadExisting()
    '        If Incoming IsNot Nothing Then
    '            CheckForIllegalCrossThreadCalls = False

    '            ActiveControl.Text = Incoming

    '            SendKeys.SendWait("{ENTER}")
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub D_Codigo_GotFocus(sender As Object, e As EventArgs) Handles D_Codigo.GotFocus
    '    Try
    '        For Each COM As String In My.Computer.Ports.SerialPortNames
    '            If COM = My.Settings.Com Then
    '                RS232.PortName = COM
    '                If Not RS232.IsOpen Then
    '                    RS232.Open()
    '                End If
    '                Exit For
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub D_Codigo_LostFocus(sender As Object, e As EventArgs) Handles D_Codigo.LostFocus
    '    If RS232 IsNot Nothing Then
    '        If RS232.IsOpen Then RS232.Close()
    '    End If
    'End Sub

    Sub Buscar_Registros()
        Dim SQL = "SELECT Count(Copias.art_id) AS cant, Copias.art_id, Articulos.art_codigo_barras, Articulos.art_descripcion
                   FROM Articulos INNER JOIN Copias ON Articulos.art_id = Copias.art_id
                   GROUP BY Copias.art_id, Articulos.art_codigo_barras, Articulos.art_descripcion
                   ORDER BY Copias.art_id;"
        Dim Tabla As OleDb.OleDbDataReader

        If Base.Ejecutar_SQL(SQL, Tabla) Then
            Dim Itm As ListViewItem
            Listado.Items.Clear()
            Do While Tabla.Read
                Itm = New ListViewItem With {
                    .Text = Tabla.Item("cant"),
                    .Tag = Tabla.Item("art_id")}
                Itm.SubItems.Add(Tabla.Item("art_descripcion"))
                Itm.SubItems.Add(Tabla.Item("art_codigo_barras"))
                Itm.Checked = True
                Listado.Items.Add(Itm)
            Loop

            If Listado.Items.Count >= 1 Then
                Imprimir.Enabled = True
                Imprimir.Enabled = True
            Else
                Imprimir.Enabled = False
                Imprimir.Enabled = False
            End If
        Else
            MsgBox("Se produjo un error al leer los códigos QR")
        End If
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

    Private Sub D_Codigo_TextChanged(sender As Object, e As EventArgs) Handles D_Codigo.TextChanged
        D_Cantidad.Text = Format(0, "##,##0.00")
        D_Cantidad.Tag = 0
        Aceptar_Articulo.Enabled = False
        D_Descripcion.Text = ""
    End Sub

    Private Sub Frm_QR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F8
                Buscar.PerformClick()
                Exit Sub
            Case Keys.F12
                Buscar_Registros()
                Exit Sub
        End Select
    End Sub

    Private Sub Frm_QR_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Cancelar_Articulo.PerformClick()
        Buscar_Registros()
    End Sub

    Private Sub Cancelar_Articulo_Click(sender As Object, e As EventArgs) Handles Cancelar_Articulo.Click
        D_Codigo.Text = ""
        D_Cantidad.Text = Format(0, "##,##0.00")
        D_Cantidad.Tag = 0
        D_Descripcion.Text = ""
        Aceptar_Articulo.Enabled = False
        D_Codigo.Focus()
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

    Private Sub D_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_Codigo.KeyPress
        If e.KeyChar = vbCr Then
            D_Cantidad.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub D_Codigo_Validating(sender As Object, e As CancelEventArgs) Handles D_Codigo.Validating
        D_Codigo.Text = D_Codigo.Text.Trim

        If D_Codigo.Text <> "" Then
            Dim Sql As String
            Dim Tabla As OleDb.OleDbDataReader

            Sql = "SELECT art_id, art_descripcion FROM Articulos WHERE art_codigo = '" + D_Codigo.Text + "' OR art_codigo_barras = '" + D_Codigo.Text + "'"
            If Base.Ejecutar_SQL(Sql, Tabla) Then
                If Tabla.Read() Then
                    If CCdec(D_Cantidad.Text) = 0 Then
                        D_Cantidad.Tag = 1
                        D_Cantidad.Text = Format(D_Cantidad.Tag, "##,##0.00")
                    End If

                    D_Descripcion.Text = Tabla.Item("art_descripcion").ToString.Trim
                    D_Codigo.Tag = Tabla.Item("art_id")

                    If D_Cantidad.Tag = 0 Then
                        Aceptar_Articulo.Enabled = False
                    Else
                        Aceptar_Articulo.Enabled = True
                    End If
                Else
                    MsgBox("No se pudo repuperar los datos del artículo o artículo inexistente!")
                End If
            Else
                MsgBox("No se pudo recuperar los datos del artículo!")
            End If
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        If MsgBox("¿Esta seguro que desea borrar todas las etiqutas seleccionadas?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Dim Sql As String = ""

            If Listado.Items.Count = Listado.CheckedItems.Count Then
                Sql = "DELETE * FROM Copias"
            Else
                For Each Itm As ListViewItem In Listado.CheckedItems
                    If Sql <> "" Then Sql += ", "
                    Sql += Itm.Tag.ToString
                Next

                Sql = "DELETE * FROM Copias WHERE art_id IN (" + Sql + ")"
            End If

            If Not Base.Ejecutar_SQL(Sql) Then
                MsgBox("Se produjo un error al intentar borrar las etiquetas")
            End If
            Buscar_Registros()
        End If
    End Sub

    Private Sub Listado_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Listado.ItemChecked
        If Listado.CheckedItems.Count >= 1 Then
            Borrar.Enabled = True
            Imprimir.Enabled = True
        Else
            Borrar.Enabled = False
            Imprimir.Enabled = False
        End If
    End Sub

    Private Sub Aceptar_Articulo_Click(sender As Object, e As EventArgs) Handles Aceptar_Articulo.Click
        Dim Sql As String = "INSERT INTO Copias (art_id) VALUES (" + D_Codigo.Tag.ToString + ")"

        For I As Integer = 1 To D_Cantidad.Tag
            If Not Base.Ejecutar_SQL(Sql) Then
                MsgBox("Se produjo un error al intentar cargar las copias de las etiquetas")
                Exit For
            End If
        Next
        Cancelar_Articulo.PerformClick()
        Buscar_Registros()
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim Sql As String = ""

        UseWaitCursor = True
        Cursor = Cursors.WaitCursor

        Dim QQR As New QR

        For Each Itm As ListViewItem In Listado.CheckedItems
            If Not Listado.Items.Count = Listado.CheckedItems.Count Then
                If Sql <> "" Then Sql += ", "
                Sql += Itm.Tag.ToString
            End If

            Dim Codigo As String = Itm.SubItems(Col_Codigo.Index).Text
            Dim Arch As String = Application.StartupPath + "\Imagenes\QR\" + Codigo + ".png"
            Dim Img As Image = QQR.Generar_QR(Codigo, 2) ', Color.Black, Color.White, Application.StartupPath + "\Estrella.ico")
            Img.Save(Arch)
            Dim Sql1 = "UPDATE Copias SET cop_ruta = '" + Arch + "' WHERE art_id = " + Itm.Tag.ToString
            If Not Base.Ejecutar_SQL(Sql1) Then
                MsgBox("Se produjo un error al generar el Código QR")
                Exit Sub
            End If
        Next

        If Not Listado.Items.Count = Listado.CheckedItems.Count Then
            Sql = "{Copias.art_id} IN [" + Sql + "]"
        Else
            Sql = ""
        End If

        If D_Etiqueta.Checked Then
            Dim Reporte As New Rpt_Etiquetas
            Dim Frm As New Frm_Vista_Previa
            AddOwnedForm(Frm)

            Frm.Mostrar(Reporte, My.Settings.Database, My.Settings.Uid, My.Settings.Password, "", Sql)

            UseWaitCursor = False
            Cursor = Cursors.Default
        Else
            Dim Reporte As New Rpt_Etiquetas1
            Dim Frm As New Frm_Vista_Previa
            AddOwnedForm(Frm)

            Frm.Mostrar(Reporte, My.Settings.Database, My.Settings.Uid, My.Settings.Password, "", Sql)

            UseWaitCursor = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim Frm_Art As New Frm_Articulos
        AddOwnedForm(Frm_Art)
        Frm_Art.Origen = Origen.F_QR
        Frm_Art.Selecciona = True
        Frm_Art.ShowDialog()
        If D_Codigo.Text.Trim <> "" Then
            D_Cantidad.Focus()
        Else
            D_Codigo.Focus()
        End If
    End Sub

    Private Sub TMnu_Eliminar_Click(sender As Object, e As EventArgs) Handles TMnu_Eliminar.Click
        Try
            If Listado.SelectedItems.Count = 1 Then
                Dim Aux As Integer = CInt(InputBox("Ingrese la cantidad a borrar:", "Borrar Etiqueta", Listado.SelectedItems(0).Text))
                If (Aux > 0) And (Aux <= CInt(Listado.SelectedItems(0).Text)) Then
                    Dim SQL As String = "DELETE * FROM (SELECT TOP " + Aux.ToString + " * FROM Copias WHERE Copias.art_id=" + Listado.SelectedItems(0).Tag.ToString + ") AS deletes;"

                    If Not Base.Ejecutar_SQL(SQL) Then
                        MsgBox("Se produjo un error al intentar borrar las etiquetas")
                    End If

                    Buscar_Registros()
                Else
                    MsgBox("LA cantidad debe es un numero entre 1 y " + Listado.SelectedItems(0).Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listado_MouseClick(sender As Object, e As MouseEventArgs) Handles Listado.MouseClick
        Dim Itm As ListViewItem

        If e.Button = MouseButtons.Right Then
            Itm = Listado.HitTest(e.X, e.Y).Item
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

    Private Sub D_Codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles D_Codigo.KeyDown
        Frm_QR_KeyDown(sender, e)
    End Sub

    Private Sub D_Cantidad_TextChanged(sender As Object, e As EventArgs) Handles D_Cantidad.TextChanged

    End Sub

    Private Sub D_Cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles D_Cantidad.KeyDown
        Frm_QR_KeyDown(sender, e)
    End Sub
End Class