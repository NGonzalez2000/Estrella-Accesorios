<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Configuracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hacer_Backup = New System.Windows.Forms.Button()
        Me.Probar_CNX = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DB_Database = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DB_Password = New System.Windows.Forms.TextBox()
        Me.DB_Uid = New System.Windows.Forms.TextBox()
        Me.DB_Intercambio = New System.Windows.Forms.TextBox()
        Me.O_DLG = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sys_Dias = New System.Windows.Forms.NumericUpDown()
        Me.S_DLG = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Stk_Color0 = New System.Windows.Forms.Button()
        Me.Stk_Color1 = New System.Windows.Forms.Button()
        Me.Stk_Color2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C_DLG = New System.Windows.Forms.ColorDialog()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Com_Com = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Sys_Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cerrar_Frm
        '
        Me.Cerrar_Frm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Cerrar_Frm.FlatAppearance.BorderSize = 0
        Me.Cerrar_Frm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Cerrar_Frm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cerrar_Frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar_Frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar_Frm.Location = New System.Drawing.Point(368, 2)
        Me.Cerrar_Frm.Name = "Cerrar_Frm"
        Me.Cerrar_Frm.Size = New System.Drawing.Size(38, 21)
        Me.Cerrar_Frm.TabIndex = 25
        Me.Cerrar_Frm.TabStop = False
        Me.Cerrar_Frm.Text = "X"
        Me.Cerrar_Frm.UseVisualStyleBackColor = True
        '
        'Titulo_Frm
        '
        Me.Titulo_Frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo_Frm.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Titulo_Frm.Location = New System.Drawing.Point(24, 0)
        Me.Titulo_Frm.Name = "Titulo_Frm"
        Me.Titulo_Frm.Size = New System.Drawing.Size(305, 23)
        Me.Titulo_Frm.TabIndex = 24
        Me.Titulo_Frm.Text = "  Estrella Accesorios - Configuraciones"
        Me.Titulo_Frm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cuadro_Frm
        '
        Me.Cuadro_Frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cuadro_Frm.ForeColor = System.Drawing.Color.DimGray
        Me.Cuadro_Frm.Location = New System.Drawing.Point(335, 2)
        Me.Cuadro_Frm.Name = "Cuadro_Frm"
        Me.Cuadro_Frm.Size = New System.Drawing.Size(24, 18)
        Me.Cuadro_Frm.TabIndex = 29
        Me.Cuadro_Frm.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Hacer_Backup)
        Me.GroupBox2.Controls.Add(Me.Probar_CNX)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DB_Database)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DB_Password)
        Me.GroupBox2.Controls.Add(Me.DB_Uid)
        Me.GroupBox2.Controls.Add(Me.DB_Intercambio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(2, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 160)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Opciones de Bases de Datos  "
        '
        'Hacer_Backup
        '
        Me.Hacer_Backup.BackColor = System.Drawing.Color.Salmon
        Me.Hacer_Backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Hacer_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hacer_Backup.ForeColor = System.Drawing.Color.White
        Me.Hacer_Backup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Hacer_Backup.Location = New System.Drawing.Point(19, 127)
        Me.Hacer_Backup.Name = "Hacer_Backup"
        Me.Hacer_Backup.Size = New System.Drawing.Size(205, 23)
        Me.Hacer_Backup.TabIndex = 2
        Me.Hacer_Backup.Text = "Realizar Backup Base de Datos"
        Me.Hacer_Backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Hacer_Backup.UseVisualStyleBackColor = False
        '
        'Probar_CNX
        '
        Me.Probar_CNX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Probar_CNX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Probar_CNX.ForeColor = System.Drawing.Color.White
        Me.Probar_CNX.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Probar_CNX.Location = New System.Drawing.Point(230, 127)
        Me.Probar_CNX.Name = "Probar_CNX"
        Me.Probar_CNX.Size = New System.Drawing.Size(165, 23)
        Me.Probar_CNX.TabIndex = 3
        Me.Probar_CNX.Text = "Probar conexión"
        Me.Probar_CNX.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Probar_CNX.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Base de Datos:"
        '
        'DB_Database
        '
        Me.DB_Database.Location = New System.Drawing.Point(132, 22)
        Me.DB_Database.Name = "DB_Database"
        Me.DB_Database.ReadOnly = True
        Me.DB_Database.Size = New System.Drawing.Size(263, 20)
        Me.DB_Database.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.Estrella_Accesorios.My.Resources.Resources.Database
        Me.PictureBox2.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Base de intercambio:"
        '
        'DB_Password
        '
        Me.DB_Password.Location = New System.Drawing.Point(132, 101)
        Me.DB_Password.Name = "DB_Password"
        Me.DB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DB_Password.Size = New System.Drawing.Size(263, 20)
        Me.DB_Password.TabIndex = 1
        Me.DB_Password.UseSystemPasswordChar = True
        '
        'DB_Uid
        '
        Me.DB_Uid.Location = New System.Drawing.Point(132, 75)
        Me.DB_Uid.Name = "DB_Uid"
        Me.DB_Uid.Size = New System.Drawing.Size(263, 20)
        Me.DB_Uid.TabIndex = 0
        '
        'DB_Intercambio
        '
        Me.DB_Intercambio.Location = New System.Drawing.Point(132, 48)
        Me.DB_Intercambio.Name = "DB_Intercambio"
        Me.DB_Intercambio.ReadOnly = True
        Me.DB_Intercambio.Size = New System.Drawing.Size(263, 20)
        Me.DB_Intercambio.TabIndex = 5
        '
        'O_DLG
        '
        Me.O_DLG.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Sys_Dias)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 54)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Alerta de Ventas "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cantidad de días para aviso en precios:"
        '
        'Sys_Dias
        '
        Me.Sys_Dias.Location = New System.Drawing.Point(246, 19)
        Me.Sys_Dias.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Sys_Dias.Name = "Sys_Dias"
        Me.Sys_Dias.Size = New System.Drawing.Size(80, 20)
        Me.Sys_Dias.TabIndex = 31
        Me.Sys_Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Stk_Color0)
        Me.GroupBox3.Controls.Add(Me.Stk_Color1)
        Me.GroupBox3.Controls.Add(Me.Stk_Color2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(2, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 90)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Colores Stock "
        '
        'Stk_Color0
        '
        Me.Stk_Color0.BackColor = System.Drawing.Color.White
        Me.Stk_Color0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stk_Color0.ForeColor = System.Drawing.Color.Black
        Me.Stk_Color0.Image = Global.Estrella_Accesorios.My.Resources.Resources.Stock_Rojo_16
        Me.Stk_Color0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stk_Color0.Location = New System.Drawing.Point(71, 57)
        Me.Stk_Color0.Name = "Stk_Color0"
        Me.Stk_Color0.Size = New System.Drawing.Size(90, 22)
        Me.Stk_Color0.TabIndex = 47
        Me.Stk_Color0.Text = "Muestra"
        Me.Stk_Color0.UseVisualStyleBackColor = False
        '
        'Stk_Color1
        '
        Me.Stk_Color1.BackColor = System.Drawing.Color.White
        Me.Stk_Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stk_Color1.ForeColor = System.Drawing.Color.Black
        Me.Stk_Color1.Image = Global.Estrella_Accesorios.My.Resources.Resources.Stock_Amarillo_16
        Me.Stk_Color1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stk_Color1.Location = New System.Drawing.Point(71, 36)
        Me.Stk_Color1.Name = "Stk_Color1"
        Me.Stk_Color1.Size = New System.Drawing.Size(90, 22)
        Me.Stk_Color1.TabIndex = 46
        Me.Stk_Color1.Text = "Muestra"
        Me.Stk_Color1.UseVisualStyleBackColor = False
        '
        'Stk_Color2
        '
        Me.Stk_Color2.BackColor = System.Drawing.Color.White
        Me.Stk_Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stk_Color2.ForeColor = System.Drawing.Color.Black
        Me.Stk_Color2.Image = Global.Estrella_Accesorios.My.Resources.Resources.Stock_Verde_16
        Me.Stk_Color2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stk_Color2.Location = New System.Drawing.Point(71, 15)
        Me.Stk_Color2.Name = "Stk_Color2"
        Me.Stk_Color2.Size = New System.Drawing.Size(90, 22)
        Me.Stk_Color2.TabIndex = 45
        Me.Stk_Color2.Text = "Muestra"
        Me.Stk_Color2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Sin Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Poco Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "En Stock:"
        '
        'Cancelar
        '
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar1
        Me.Cancelar.Location = New System.Drawing.Point(173, 303)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(112, 77)
        Me.Cancelar.TabIndex = 33
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Aceptar.FlatAppearance.BorderSize = 0
        Me.Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Aceptar1
        Me.Aceptar.Location = New System.Drawing.Point(290, 303)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(112, 77)
        Me.Aceptar.TabIndex = 32
        Me.Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Imagen_Frm
        '
        Me.Imagen_Frm.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estrella
        Me.Imagen_Frm.Location = New System.Drawing.Point(2, 2)
        Me.Imagen_Frm.Name = "Imagen_Frm"
        Me.Imagen_Frm.Size = New System.Drawing.Size(23, 23)
        Me.Imagen_Frm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen_Frm.TabIndex = 26
        Me.Imagen_Frm.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Com_Com)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(2, 243)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(404, 54)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Puerto de Conexión del Lector "
        '
        'Com_Com
        '
        Me.Com_Com.FormattingEnabled = True
        Me.Com_Com.Location = New System.Drawing.Point(207, 17)
        Me.Com_Com.Name = "Com_Com"
        Me.Com_Com.Size = New System.Drawing.Size(119, 21)
        Me.Com_Com.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Puerto del lector de Barras/QR:"
        '
        'Frm_Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 392)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Configuracion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_FORMA DE PAGO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Sys_Dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Hacer_Backup As Button
    Friend WithEvents Probar_CNX As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DB_Database As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DB_Password As TextBox
    Friend WithEvents DB_Uid As TextBox
    Friend WithEvents DB_Intercambio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents O_DLG As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Sys_Dias As NumericUpDown
    Friend WithEvents Cancelar As Button
    Friend WithEvents Aceptar As Button
    Friend WithEvents S_DLG As SaveFileDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents C_DLG As ColorDialog
    Friend WithEvents Stk_Color2 As Button
    Friend WithEvents Stk_Color0 As Button
    Friend WithEvents Stk_Color1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Com_Com As ComboBox
End Class
