Public Class Frm_Configuracion
    Dim ex As Int16
    Dim ey As Int16
    Dim Arrastre As Boolean

    Private Sub Frm_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UseWaitCursor = True
        Cursor = Cursors.WaitCursor

        Me.Text = Titulo_Frm.Text
        Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
        Cuadro_Frm.SendToBack()
        Imagen_Frm.Location = New Point(3, 3)
        Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
        Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

        DB_Database.Tag = My.Settings.Database
        DB_Database.Text = Acortar_Ruta(DB_Database.Tag, 50)
        DB_Intercambio.Tag = My.Settings.Arch_Intercambio
        DB_Intercambio.Text = Acortar_Ruta(DB_Intercambio.Tag, 50)
        DB_Uid.Text = My.Settings.Uid
        DB_Password.Text = My.Settings.Password

        Sys_Dias.Value = My.Settings.Dias_Aviso

        Stk_Color0.BackColor = My.Settings.Color0
        Stk_Color1.BackColor = My.Settings.Color1
        Stk_Color2.BackColor = My.Settings.Color2

        Try
            For Each COM As String In My.Computer.Ports.SerialPortNames
                Dim I As Integer = Com_Com.Items.Add(COM)
                If COM = My.Settings.Com Then
                    Com_Com.SelectedIndex = I
                End If
            Next
        Catch ex As Exception

        End Try

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

    Private Sub DB_Database_Click(sender As Object, e As EventArgs) Handles DB_Database.Click
        If DB_Database.Tag <> "" Then
            O_DLG.InitialDirectory = IO.Path.GetDirectoryName(DB_Database.Tag)
        End If

        O_DLG.CheckFileExists = True
        O_DLG.CheckPathExists = True
        O_DLG.Filter = "Archivo de Base de Datos (.mdb)|*.mdb"
        O_DLG.FilterIndex = 1
        O_DLG.RestoreDirectory = True

        If O_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DB_Database.Tag = O_DLG.FileName
            DB_Database.Text = Acortar_Ruta(DB_Database.Tag, 50)
        Else
            DB_Database.Tag = ""
            DB_Database.Text = ""
        End If
    End Sub

    Private Sub DB_Intercambio_Click(sender As Object, e As EventArgs) Handles DB_Intercambio.Click
        If DB_Intercambio.Tag <> "" Then
            O_DLG.InitialDirectory = IO.Path.GetDirectoryName(DB_Intercambio.Tag)
        End If

        O_DLG.CheckFileExists = True
        O_DLG.CheckPathExists = True
        O_DLG.Filter = "Archivo de Base de Datos (.mdb)|*.mdb"
        O_DLG.FilterIndex = 1
        O_DLG.RestoreDirectory = True

        If O_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DB_Intercambio.Tag = O_DLG.FileName
            DB_Intercambio.Text = Acortar_Ruta(DB_Intercambio.Tag, 50)
        Else
            DB_Intercambio.Tag = ""
            DB_Intercambio.Text = ""
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If MsgBox("¿Desea grabar los datos?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            My.Settings.Database = DB_Database.Tag
            My.Settings.Arch_Intercambio = DB_Intercambio.Tag
            My.Settings.Uid = DB_Uid.Text
            My.Settings.Password = DB_Password.Text
            My.Settings.Dias_Aviso = Sys_Dias.Value
            My.Settings.Color2 = Stk_Color2.BackColor
            My.Settings.Color1 = Stk_Color1.BackColor
            My.Settings.Color0 = Stk_Color0.BackColor
            If Com_Com.SelectedIndex = -1 Then
                My.Settings.Com = ""
            Else
                My.Settings.Com = Com_Com.Items(Com_Com.SelectedIndex)
            End If
            My.Settings.Save()

                Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;
										Data Source=" + My.Settings.Database + ";
										Persist Security Info=True;
										Jet OLEDB:Database Password=" + My.Settings.Password + ";
										User Id=" + My.Settings.Uid + ";"
                If Base.Conectado Then Base.Cerrar_Conexion()
                If Not Base.Conectar(CadenaConexion) Then
                    MsgBox("No se pudo conectar con la base de datos!!!", vbCritical)
                End If
                Close()
            End If
    End Sub

    Private Sub Probar_CNX_Click(sender As Object, e As EventArgs) Handles Probar_CNX.Click
        Dim Base1 As New Servidor_SQL

        If DB_Database.Tag <> "" Then
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;
										Data Source=" + DB_Database.Tag + ";
										Persist Security Info=True;
										Jet OLEDB:Database Password=" + DB_Password.Text + ";
										User Id=" + DB_Uid.Text + ";"
            If Base1.Conectar(CadenaConexion) Then
                MsgBox("Conexción exitosa con la Base de Datos!!!")
                Base1.Cerrar_Conexion()
            Else
                MsgBox("No se pudo conectar con la base de datos!!!", vbCritical)
            End If
        Else
            MsgBox("Debe elegir un archivo de Base de Datos")
        End If

        If DB_Intercambio.Tag <> "" Then
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;
										Data Source=" + DB_Intercambio.Tag + ";
										Persist Security Info=True;
										Jet OLEDB:Database Password=" + DB_Password.Text + ";
										User Id=" + DB_Uid.Text + ";"
            If Base1.Conectar(CadenaConexion) Then
                MsgBox("Conexción exitosa con el archivo de intercambio de datos!!!")
                Base1.Cerrar_Conexion()
            Else
                MsgBox("No se pudo conectar con la base de datos!!!", vbCritical)
            End If
        Else
            MsgBox("Debe elegir un archivo de Base de Datos")
        End If
    End Sub

    Private Sub Hacer_Backup_Click(sender As Object, e As EventArgs) Handles Hacer_Backup.Click
        S_DLG.CheckFileExists = False
        S_DLG.CheckPathExists = True
        S_DLG.Filter = "Archivos de BACKUP de Base de Datos (*.bak)|*.bak"
        S_DLG.FileName = "Backup - " + Now().ToString("yyyy_MM_dd hh_mm_ss") + ".bak"
        S_DLG.FilterIndex = 1
        S_DLG.CreatePrompt = True
        S_DLG.OverwritePrompt = True
        S_DLG.Title = "Seleccione la ubicación del archivo de BACKUP"
        'CMD.RestoreDirectory = True

        If S_DLG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            UseWaitCursor = True
            Cursor = Cursors.WaitCursor
            Dim Destino As String = S_DLG.FileName
            If Exportar_BD_CMD(Destino) Then
                MsgBox("Backup realizado con éxito!!!")
            End If

            Cursor = Cursors.Default
            UseWaitCursor = False
        End If
    End Sub

    Private Sub Stk_Color2_Click(sender As Object, e As EventArgs) Handles Stk_Color2.Click
        C_DLG.Color = Stk_Color2.BackColor
        C_DLG.AllowFullOpen = True
        If C_DLG.ShowDialog() = DialogResult.OK Then
            Stk_Color2.BackColor = C_DLG.Color
        End If
    End Sub

    Private Sub Stk_Color1_Click(sender As Object, e As EventArgs) Handles Stk_Color1.Click
        C_DLG.Color = Stk_Color1.BackColor
        C_DLG.AllowFullOpen = True
        If C_DLG.ShowDialog() = DialogResult.OK Then
            Stk_Color1.BackColor = C_DLG.Color
        End If
    End Sub

    Private Sub Stk_Color0_Click(sender As Object, e As EventArgs) Handles Stk_Color0.Click
        C_DLG.Color = Stk_Color0.BackColor
        C_DLG.AllowFullOpen = True
        If C_DLG.ShowDialog() = DialogResult.OK Then
            Stk_Color0.BackColor = C_DLG.Color
        End If
    End Sub
End Class