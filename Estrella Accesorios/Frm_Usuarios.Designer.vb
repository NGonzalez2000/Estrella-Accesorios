<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Usuarios
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
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.D_Administrador = New System.Windows.Forms.CheckBox()
        Me.D_Habilitado = New System.Windows.Forms.CheckBox()
        Me.D_Repetir = New Controles.CuadroTexto()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.D_Contraseña = New Controles.CuadroTexto()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.D_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Administrador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Habilitado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Botones = New System.Windows.Forms.GroupBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.Datos.SuspendLayout()
        Me.Botones.SuspendLayout()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios - USUARIOS"
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
        'Datos
        '
        Me.Datos.Controls.Add(Me.D_Administrador)
        Me.Datos.Controls.Add(Me.D_Habilitado)
        Me.Datos.Controls.Add(Me.D_Repetir)
        Me.Datos.Controls.Add(Me.Label2)
        Me.Datos.Controls.Add(Me.D_Contraseña)
        Me.Datos.Controls.Add(Me.Label1)
        Me.Datos.Controls.Add(Me.D_Nombre)
        Me.Datos.Controls.Add(Me.Label5)
        Me.Datos.Location = New System.Drawing.Point(2, 403)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(496, 64)
        Me.Datos.TabIndex = 32
        Me.Datos.TabStop = False
        '
        'D_Administrador
        '
        Me.D_Administrador.AutoSize = True
        Me.D_Administrador.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.D_Administrador.Location = New System.Drawing.Point(393, 15)
        Me.D_Administrador.Name = "D_Administrador"
        Me.D_Administrador.Size = New System.Drawing.Size(92, 17)
        Me.D_Administrador.TabIndex = 8
        Me.D_Administrador.Text = "Administrador:"
        Me.D_Administrador.UseVisualStyleBackColor = True
        '
        'D_Habilitado
        '
        Me.D_Habilitado.AutoSize = True
        Me.D_Habilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.D_Habilitado.Location = New System.Drawing.Point(409, 37)
        Me.D_Habilitado.Name = "D_Habilitado"
        Me.D_Habilitado.Size = New System.Drawing.Size(76, 17)
        Me.D_Habilitado.TabIndex = 9
        Me.D_Habilitado.Text = "Habilitado:"
        Me.D_Habilitado.UseVisualStyleBackColor = True
        '
        'D_Repetir
        '
        Me.D_Repetir.BackColor = System.Drawing.Color.White
        Me.D_Repetir.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.D_Repetir.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Libre
        Me.D_Repetir.DatosPositivos = True
        Me.D_Repetir.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Repetir.Location = New System.Drawing.Point(284, 36)
        Me.D_Repetir.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Repetir.MaxLength = 30
        Me.D_Repetir.Multiline = False
        Me.D_Repetir.Name = "D_Repetir"
        Me.D_Repetir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Repetir.Size = New System.Drawing.Size(101, 20)
        Me.D_Repetir.SoloLectura = False
        Me.D_Repetir.TabIndex = 7
        Me.D_Repetir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.D_Repetir.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Repetir contraseña:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'D_Contraseña
        '
        Me.D_Contraseña.BackColor = System.Drawing.Color.White
        Me.D_Contraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.D_Contraseña.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Libre
        Me.D_Contraseña.DatosPositivos = True
        Me.D_Contraseña.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Contraseña.Location = New System.Drawing.Point(74, 36)
        Me.D_Contraseña.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Contraseña.MaxLength = 30
        Me.D_Contraseña.Multiline = False
        Me.D_Contraseña.Name = "D_Contraseña"
        Me.D_Contraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Contraseña.Size = New System.Drawing.Size(101, 20)
        Me.D_Contraseña.SoloLectura = False
        Me.D_Contraseña.TabIndex = 6
        Me.D_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.D_Contraseña.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Contraseña:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'D_Nombre
        '
        Me.D_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.D_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.D_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Nombre.Location = New System.Drawing.Point(74, 13)
        Me.D_Nombre.MaxLength = 100
        Me.D_Nombre.Name = "D_Nombre"
        Me.D_Nombre.Size = New System.Drawing.Size(311, 20)
        Me.D_Nombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Listado
        '
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_ID, Me.Col_Nombre, Me.Col_Administrador, Me.Col_Habilitado})
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(2, 142)
        Me.Listado.MultiSelect = False
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(496, 261)
        Me.Listado.TabIndex = 4
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_ID
        '
        Me.Col_ID.Tag = "N"
        Me.Col_ID.Text = "Código"
        Me.Col_ID.Width = 61
        '
        'Col_Nombre
        '
        Me.Col_Nombre.Text = "Nombre"
        Me.Col_Nombre.Width = 257
        '
        'Col_Administrador
        '
        Me.Col_Administrador.Tag = "N"
        Me.Col_Administrador.Text = "Administrador"
        Me.Col_Administrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Col_Administrador.Width = 75
        '
        'Col_Habilitado
        '
        Me.Col_Habilitado.Tag = "N"
        Me.Col_Habilitado.Text = "Habilitado"
        Me.Col_Habilitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Col_Habilitado.Width = 59
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.Borrar)
        Me.Botones.Controls.Add(Me.Modificar)
        Me.Botones.Controls.Add(Me.Cancelar)
        Me.Botones.Controls.Add(Me.Agregar)
        Me.Botones.Location = New System.Drawing.Point(2, 29)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(496, 107)
        Me.Botones.TabIndex = 31
        Me.Botones.TabStop = False
        '
        'Borrar
        '
        Me.Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Borrar.Enabled = False
        Me.Borrar.FlatAppearance.BorderSize = 0
        Me.Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_64
        Me.Borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Borrar.Location = New System.Drawing.Point(248, 13)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(120, 88)
        Me.Borrar.TabIndex = 2
        Me.Borrar.Text = "Borrar"
        Me.Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Enabled = False
        Me.Modificar.FlatAppearance.BorderSize = 0
        Me.Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Editar_72
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Modificar.Location = New System.Drawing.Point(127, 13)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(120, 88)
        Me.Modificar.TabIndex = 1
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar_64
        Me.Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar.Location = New System.Drawing.Point(369, 13)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(120, 88)
        Me.Cancelar.TabIndex = 3
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar.FlatAppearance.BorderSize = 0
        Me.Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Agregar_64
        Me.Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Agregar.Location = New System.Drawing.Point(6, 13)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(120, 88)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Agregar.UseVisualStyleBackColor = True
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
        'Frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 472)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Usuarios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_FORMA DE PAGO"
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        Me.Botones.ResumeLayout(False)
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Datos As GroupBox
    Friend WithEvents D_Administrador As CheckBox
    Friend WithEvents D_Habilitado As CheckBox
    Friend WithEvents D_Repetir As Controles.CuadroTexto
    Friend WithEvents Label2 As Label
    Friend WithEvents D_Contraseña As Controles.CuadroTexto
    Friend WithEvents Label1 As Label
    Friend WithEvents D_Nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_ID As ColumnHeader
    Friend WithEvents Col_Nombre As ColumnHeader
    Friend WithEvents Col_Administrador As ColumnHeader
    Friend WithEvents Col_Habilitado As ColumnHeader
    Friend WithEvents Botones As GroupBox
    Friend WithEvents Borrar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents Agregar As Button
End Class
