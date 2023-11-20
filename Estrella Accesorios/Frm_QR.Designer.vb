<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QR
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
        Me.components = New System.ComponentModel.Container()
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.G_Datos = New System.Windows.Forms.GroupBox()
        Me.D_Listado = New System.Windows.Forms.RadioButton()
        Me.D_Etiqueta = New System.Windows.Forms.RadioButton()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.D_Codigo = New System.Windows.Forms.TextBox()
        Me.Cancelar_Articulo = New System.Windows.Forms.Button()
        Me.Aceptar_Articulo = New System.Windows.Forms.Button()
        Me.D_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.D_Cantidad = New Controles.CuadroTexto()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.mnu_Eliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TMnu_Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.G_Datos.SuspendLayout()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_Eliminar.SuspendLayout()
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios - Impresion de Equitetas QR"
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
        'Listado
        '
        Me.Listado.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Listado.CheckBoxes = True
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Cantidad, Me.Col_Descripcion, Me.Col_Codigo})
        Me.Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(3, 151)
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(917, 381)
        Me.Listado.TabIndex = 31
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_Cantidad
        '
        Me.Col_Cantidad.Text = "Cantidad"
        Me.Col_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Cantidad.Width = 92
        '
        'Col_Descripcion
        '
        Me.Col_Descripcion.Text = "Descripción"
        Me.Col_Descripcion.Width = 550
        '
        'Col_Codigo
        '
        Me.Col_Codigo.Text = "Codigo QR"
        Me.Col_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Codigo.Width = 230
        '
        'G_Datos
        '
        Me.G_Datos.Controls.Add(Me.D_Listado)
        Me.G_Datos.Controls.Add(Me.D_Etiqueta)
        Me.G_Datos.Controls.Add(Me.Borrar)
        Me.G_Datos.Controls.Add(Me.Buscar)
        Me.G_Datos.Controls.Add(Me.Imprimir)
        Me.G_Datos.Controls.Add(Me.D_Codigo)
        Me.G_Datos.Controls.Add(Me.Cancelar_Articulo)
        Me.G_Datos.Controls.Add(Me.Aceptar_Articulo)
        Me.G_Datos.Controls.Add(Me.D_Descripcion)
        Me.G_Datos.Controls.Add(Me.Label9)
        Me.G_Datos.Controls.Add(Me.D_Cantidad)
        Me.G_Datos.Controls.Add(Me.Label4)
        Me.G_Datos.Controls.Add(Me.Label3)
        Me.G_Datos.Location = New System.Drawing.Point(3, 22)
        Me.G_Datos.Name = "G_Datos"
        Me.G_Datos.Size = New System.Drawing.Size(917, 123)
        Me.G_Datos.TabIndex = 32
        Me.G_Datos.TabStop = False
        '
        'D_Listado
        '
        Me.D_Listado.AutoSize = True
        Me.D_Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Listado.Location = New System.Drawing.Point(634, 75)
        Me.D_Listado.Name = "D_Listado"
        Me.D_Listado.Size = New System.Drawing.Size(94, 24)
        Me.D_Listado.TabIndex = 32
        Me.D_Listado.Text = "QR Solo"
        Me.D_Listado.UseVisualStyleBackColor = True
        '
        'D_Etiqueta
        '
        Me.D_Etiqueta.AutoSize = True
        Me.D_Etiqueta.Checked = True
        Me.D_Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Etiqueta.Location = New System.Drawing.Point(634, 36)
        Me.D_Etiqueta.Name = "D_Etiqueta"
        Me.D_Etiqueta.Size = New System.Drawing.Size(158, 24)
        Me.D_Etiqueta.TabIndex = 31
        Me.D_Etiqueta.TabStop = True
        Me.D_Etiqueta.Text = "Con Descripción"
        Me.D_Etiqueta.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Borrar.Enabled = False
        Me.Borrar.FlatAppearance.BorderSize = 0
        Me.Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Borrar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_48
        Me.Borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Borrar.Location = New System.Drawing.Point(559, 11)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(72, 68)
        Me.Borrar.TabIndex = 30
        Me.Borrar.Text = "Borrar (F12)"
        Me.Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Buscar_48
        Me.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Buscar.Location = New System.Drawing.Point(484, 11)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(72, 68)
        Me.Buscar.TabIndex = 29
        Me.Buscar.Text = "Buscar (F8)"
        Me.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Imprimir.FlatAppearance.BorderSize = 0
        Me.Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.Image = Global.Estrella_Accesorios.My.Resources.Resources.Impresora_1_72
        Me.Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimir.Location = New System.Drawing.Point(798, 11)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(114, 106)
        Me.Imprimir.TabIndex = 17
        Me.Imprimir.Text = "IMPRIMIR"
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imprimir.UseVisualStyleBackColor = True
        '
        'D_Codigo
        '
        Me.D_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Codigo.Location = New System.Drawing.Point(66, 11)
        Me.D_Codigo.MaxLength = 15
        Me.D_Codigo.Name = "D_Codigo"
        Me.D_Codigo.Size = New System.Drawing.Size(235, 31)
        Me.D_Codigo.TabIndex = 0
        '
        'Cancelar_Articulo
        '
        Me.Cancelar_Articulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Articulo.FlatAppearance.BorderSize = 0
        Me.Cancelar_Articulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Cancelar_Articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_Articulo.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar_32
        Me.Cancelar_Articulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar_Articulo.Location = New System.Drawing.Point(392, 11)
        Me.Cancelar_Articulo.Name = "Cancelar_Articulo"
        Me.Cancelar_Articulo.Size = New System.Drawing.Size(89, 68)
        Me.Cancelar_Articulo.TabIndex = 3
        Me.Cancelar_Articulo.Text = "Cancelar"
        Me.Cancelar_Articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_Articulo.UseVisualStyleBackColor = True
        '
        'Aceptar_Articulo
        '
        Me.Aceptar_Articulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar_Articulo.Enabled = False
        Me.Aceptar_Articulo.FlatAppearance.BorderSize = 0
        Me.Aceptar_Articulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Aceptar_Articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar_Articulo.Image = Global.Estrella_Accesorios.My.Resources.Resources.Aceptar_32
        Me.Aceptar_Articulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Aceptar_Articulo.Location = New System.Drawing.Point(307, 11)
        Me.Aceptar_Articulo.Name = "Aceptar_Articulo"
        Me.Aceptar_Articulo.Size = New System.Drawing.Size(82, 68)
        Me.Aceptar_Articulo.TabIndex = 2
        Me.Aceptar_Articulo.Text = "Aceptar"
        Me.Aceptar_Articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar_Articulo.UseVisualStyleBackColor = True
        '
        'D_Descripcion
        '
        Me.D_Descripcion.Enabled = False
        Me.D_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Descripcion.Location = New System.Drawing.Point(66, 85)
        Me.D_Descripcion.Name = "D_Descripcion"
        Me.D_Descripcion.ReadOnly = True
        Me.D_Descripcion.Size = New System.Drawing.Size(563, 31)
        Me.D_Descripcion.TabIndex = 16
        Me.D_Descripcion.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad:"
        '
        'D_Cantidad
        '
        Me.D_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Cantidad.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Entero
        Me.D_Cantidad.DatosPositivos = True
        Me.D_Cantidad.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Cantidad.Location = New System.Drawing.Point(66, 48)
        Me.D_Cantidad.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Cantidad.MaxLength = 15
        Me.D_Cantidad.Multiline = False
        Me.D_Cantidad.Name = "D_Cantidad"
        Me.D_Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Cantidad.Size = New System.Drawing.Size(113, 31)
        Me.D_Cantidad.SoloLectura = False
        Me.D_Cantidad.TabIndex = 1
        Me.D_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Cantidad.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descrición:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código:"
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
        'mnu_Eliminar
        '
        Me.mnu_Eliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TMnu_Eliminar})
        Me.mnu_Eliminar.Name = "mnu_Eliminar"
        Me.mnu_Eliminar.Size = New System.Drawing.Size(166, 74)
        Me.mnu_Eliminar.Text = "Eliminar"
        '
        'TMnu_Eliminar
        '
        Me.TMnu_Eliminar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_64
        Me.TMnu_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TMnu_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TMnu_Eliminar.Name = "TMnu_Eliminar"
        Me.TMnu_Eliminar.Size = New System.Drawing.Size(165, 70)
        Me.TMnu_Eliminar.Text = "Eliminar"
        '
        'Frm_QR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 536)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.G_Datos)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Frm_QR"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_FORMA DE PAGO"
        Me.G_Datos.ResumeLayout(False)
        Me.G_Datos.PerformLayout()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Eliminar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_Cantidad As ColumnHeader
    Friend WithEvents Col_Descripcion As ColumnHeader
    Friend WithEvents Col_Codigo As ColumnHeader
    Friend WithEvents G_Datos As GroupBox
    Friend WithEvents Imprimir As Button
    Friend WithEvents D_Codigo As TextBox
    Friend WithEvents Cancelar_Articulo As Button
    Friend WithEvents Aceptar_Articulo As Button
    Friend WithEvents D_Descripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents D_Cantidad As Controles.CuadroTexto
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents mnu_Eliminar As ContextMenuStrip
    Friend WithEvents TMnu_Eliminar As ToolStripMenuItem
    Friend WithEvents D_Listado As RadioButton
    Friend WithEvents D_Etiqueta As RadioButton
End Class
