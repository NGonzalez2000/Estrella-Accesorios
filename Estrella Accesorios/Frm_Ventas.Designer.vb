<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ventas))
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.G_Datos = New System.Windows.Forms.GroupBox()
        Me.Adv1 = New System.Windows.Forms.PictureBox()
        Me.Adv = New System.Windows.Forms.PictureBox()
        Me.Stock = New System.Windows.Forms.PictureBox()
        Me.D_Codigo = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Cancelar_Articulo = New System.Windows.Forms.Button()
        Me.Aceptar_Articulo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.D_Total = New Controles.CuadroTexto()
        Me.D_Descripcion = New System.Windows.Forms.TextBox()
        Me.D_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.D_Cantidad = New Controles.CuadroTexto()
        Me.D_Imagen = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.D_Importe = New Controles.CuadroTexto()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_Imagen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe_Compra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.G_Pago = New System.Windows.Forms.GroupBox()
        Me.Cancelar_Venta = New System.Windows.Forms.Button()
        Me.Guardar_Venta = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Vuelto = New Controles.CuadroTexto()
        Me.V_Recargo = New Controles.CuadroTexto()
        Me.V_Descuento = New Controles.CuadroTexto()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Abonado = New Controles.CuadroTexto()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Total = New Controles.CuadroTexto()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Recargo = New Controles.CuadroTexto()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Descuento = New Controles.CuadroTexto()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.T_Forma_Pago = New System.Windows.Forms.ToolStrip()
        Me.D_Forma_Pago = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Subtotal = New Controles.CuadroTexto()
        Me.mnu_Eliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TMnu_Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.D_Devolucion = New System.Windows.Forms.CheckBox()
        Me.G_Datos.SuspendLayout()
        CType(Me.Adv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G_Pago.SuspendLayout()
        Me.T_Forma_Pago.SuspendLayout()
        Me.mnu_Eliminar.SuspendLayout()
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
        Me.Cerrar_Frm.ForeColor = System.Drawing.Color.White
        Me.Cerrar_Frm.Location = New System.Drawing.Point(368, 2)
        Me.Cerrar_Frm.Name = "Cerrar_Frm"
        Me.Cerrar_Frm.Size = New System.Drawing.Size(38, 21)
        Me.Cerrar_Frm.TabIndex = 18
        Me.Cerrar_Frm.TabStop = False
        Me.Cerrar_Frm.Text = "X"
        Me.Cerrar_Frm.UseVisualStyleBackColor = True
        '
        'Titulo_Frm
        '
        Me.Titulo_Frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo_Frm.ForeColor = System.Drawing.Color.White
        Me.Titulo_Frm.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Titulo_Frm.Location = New System.Drawing.Point(24, 0)
        Me.Titulo_Frm.Name = "Titulo_Frm"
        Me.Titulo_Frm.Size = New System.Drawing.Size(260, 23)
        Me.Titulo_Frm.TabIndex = 17
        Me.Titulo_Frm.Text = "  Estrella Accesorios - VENTAS"
        Me.Titulo_Frm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cuadro_Frm
        '
        Me.Cuadro_Frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cuadro_Frm.ForeColor = System.Drawing.Color.White
        Me.Cuadro_Frm.Location = New System.Drawing.Point(335, 2)
        Me.Cuadro_Frm.Name = "Cuadro_Frm"
        Me.Cuadro_Frm.Size = New System.Drawing.Size(24, 18)
        Me.Cuadro_Frm.TabIndex = 22
        Me.Cuadro_Frm.TabStop = False
        '
        'G_Datos
        '
        Me.G_Datos.Controls.Add(Me.D_Devolucion)
        Me.G_Datos.Controls.Add(Me.Adv1)
        Me.G_Datos.Controls.Add(Me.Adv)
        Me.G_Datos.Controls.Add(Me.Stock)
        Me.G_Datos.Controls.Add(Me.D_Codigo)
        Me.G_Datos.Controls.Add(Me.Buscar)
        Me.G_Datos.Controls.Add(Me.Cancelar_Articulo)
        Me.G_Datos.Controls.Add(Me.Aceptar_Articulo)
        Me.G_Datos.Controls.Add(Me.Label1)
        Me.G_Datos.Controls.Add(Me.D_Total)
        Me.G_Datos.Controls.Add(Me.D_Descripcion)
        Me.G_Datos.Controls.Add(Me.D_Fecha)
        Me.G_Datos.Controls.Add(Me.Label8)
        Me.G_Datos.Controls.Add(Me.Label9)
        Me.G_Datos.Controls.Add(Me.D_Cantidad)
        Me.G_Datos.Controls.Add(Me.D_Imagen)
        Me.G_Datos.Controls.Add(Me.Label7)
        Me.G_Datos.Controls.Add(Me.Label4)
        Me.G_Datos.Controls.Add(Me.Label3)
        Me.G_Datos.Controls.Add(Me.D_Importe)
        Me.G_Datos.Location = New System.Drawing.Point(2, 26)
        Me.G_Datos.Name = "G_Datos"
        Me.G_Datos.Size = New System.Drawing.Size(772, 206)
        Me.G_Datos.TabIndex = 30
        Me.G_Datos.TabStop = False
        '
        'Adv1
        '
        Me.Adv1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Adv1.Image = Global.Estrella_Accesorios.My.Resources.Resources.Advertencia_1_128
        Me.Adv1.Location = New System.Drawing.Point(67, 91)
        Me.Adv1.Name = "Adv1"
        Me.Adv1.Size = New System.Drawing.Size(24, 24)
        Me.Adv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Adv1.TabIndex = 35
        Me.Adv1.TabStop = False
        Me.Adv1.Visible = False
        '
        'Adv
        '
        Me.Adv.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Adv.Image = Global.Estrella_Accesorios.My.Resources.Resources.Advertencia_128
        Me.Adv.Location = New System.Drawing.Point(67, 91)
        Me.Adv.Name = "Adv"
        Me.Adv.Size = New System.Drawing.Size(24, 24)
        Me.Adv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Adv.TabIndex = 34
        Me.Adv.TabStop = False
        Me.Adv.Visible = False
        '
        'Stock
        '
        Me.Stock.Image = Global.Estrella_Accesorios.My.Resources.Resources.Stock_Verde_128
        Me.Stock.Location = New System.Drawing.Point(287, 85)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(71, 71)
        Me.Stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Stock.TabIndex = 29
        Me.Stock.TabStop = False
        '
        'D_Codigo
        '
        Me.D_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Codigo.Location = New System.Drawing.Point(66, 11)
        Me.D_Codigo.MaxLength = 15
        Me.D_Codigo.Name = "D_Codigo"
        Me.D_Codigo.Size = New System.Drawing.Size(212, 31)
        Me.D_Codigo.TabIndex = 0
        '
        'Buscar
        '
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Buscar_48
        Me.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Buscar.Location = New System.Drawing.Point(288, 13)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(72, 66)
        Me.Buscar.TabIndex = 28
        Me.Buscar.Text = "Buscar (F8)"
        Me.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buscar.UseVisualStyleBackColor = True
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
        Me.Cancelar_Articulo.Location = New System.Drawing.Point(375, 89)
        Me.Cancelar_Articulo.Name = "Cancelar_Articulo"
        Me.Cancelar_Articulo.Size = New System.Drawing.Size(115, 68)
        Me.Cancelar_Articulo.TabIndex = 3
        Me.Cancelar_Articulo.Text = "CANCELAR"
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
        Me.Aceptar_Articulo.Location = New System.Drawing.Point(375, 14)
        Me.Aceptar_Articulo.Name = "Aceptar_Articulo"
        Me.Aceptar_Articulo.Size = New System.Drawing.Size(115, 68)
        Me.Aceptar_Articulo.TabIndex = 2
        Me.Aceptar_Articulo.Text = "ACEPTAR"
        Me.Aceptar_Articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar_Articulo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Total:"
        '
        'D_Total
        '
        Me.D_Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Total.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Total.DatosPositivos = True
        Me.D_Total.Enabled = False
        Me.D_Total.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Total.Location = New System.Drawing.Point(66, 125)
        Me.D_Total.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Total.MaxLength = 20
        Me.D_Total.Multiline = False
        Me.D_Total.Name = "D_Total"
        Me.D_Total.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Total.Size = New System.Drawing.Size(212, 31)
        Me.D_Total.SoloLectura = True
        Me.D_Total.TabIndex = 18
        Me.D_Total.TabStop = False
        Me.D_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Total.UseSystemPasswordChar = False
        '
        'D_Descripcion
        '
        Me.D_Descripcion.Enabled = False
        Me.D_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Descripcion.Location = New System.Drawing.Point(66, 163)
        Me.D_Descripcion.Name = "D_Descripcion"
        Me.D_Descripcion.ReadOnly = True
        Me.D_Descripcion.Size = New System.Drawing.Size(553, 31)
        Me.D_Descripcion.TabIndex = 16
        Me.D_Descripcion.TabStop = False
        '
        'D_Fecha
        '
        Me.D_Fecha.Enabled = False
        Me.D_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D_Fecha.Location = New System.Drawing.Point(191, 57)
        Me.D_Fecha.Name = "D_Fecha"
        Me.D_Fecha.Size = New System.Drawing.Size(87, 20)
        Me.D_Fecha.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "F. Actualización:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad:"
        '
        'D_Cantidad
        '
        Me.D_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Cantidad.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Cantidad.DatosPositivos = True
        Me.D_Cantidad.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Cantidad.Location = New System.Drawing.Point(66, 49)
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
        'D_Imagen
        '
        Me.D_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Imagen.Location = New System.Drawing.Point(506, 19)
        Me.D_Imagen.Name = "D_Imagen"
        Me.D_Imagen.Size = New System.Drawing.Size(240, 135)
        Me.D_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.D_Imagen.TabIndex = 11
        Me.D_Imagen.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Importe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 172)
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
        'D_Importe
        '
        Me.D_Importe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Importe.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Importe.DatosPositivos = True
        Me.D_Importe.Enabled = False
        Me.D_Importe.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Importe.Location = New System.Drawing.Point(66, 87)
        Me.D_Importe.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Importe.MaxLength = 20
        Me.D_Importe.Multiline = False
        Me.D_Importe.Name = "D_Importe"
        Me.D_Importe.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Importe.Size = New System.Drawing.Size(212, 31)
        Me.D_Importe.SoloLectura = False
        Me.D_Importe.TabIndex = 4
        Me.D_Importe.TabStop = False
        Me.D_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Importe.UseSystemPasswordChar = False
        '
        'Listado
        '
        Me.Listado.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Imagen, Me.Col_Cantidad, Me.Col_Descripcion, Me.Col_Importe, Me.Col_Total, Me.Col_Importe_Compra, Me.Col_Fecha})
        Me.Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(2, 238)
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(772, 298)
        Me.Listado.SmallImageList = Me.ImageList1
        Me.Listado.TabIndex = 5
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_Imagen
        '
        Me.Col_Imagen.Text = ""
        Me.Col_Imagen.Width = 40
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
        Me.Col_Descripcion.Width = 322
        '
        'Col_Importe
        '
        Me.Col_Importe.Text = "Importe"
        Me.Col_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Importe.Width = 131
        '
        'Col_Total
        '
        Me.Col_Total.Text = "Total"
        Me.Col_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Total.Width = 150
        '
        'Col_Importe_Compra
        '
        Me.Col_Importe_Compra.Text = ""
        Me.Col_Importe_Compra.Width = 0
        '
        'Col_Fecha
        '
        Me.Col_Fecha.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Adv")
        '
        'G_Pago
        '
        Me.G_Pago.Controls.Add(Me.Cancelar_Venta)
        Me.G_Pago.Controls.Add(Me.Guardar_Venta)
        Me.G_Pago.Controls.Add(Me.Label12)
        Me.G_Pago.Controls.Add(Me.Vuelto)
        Me.G_Pago.Controls.Add(Me.V_Recargo)
        Me.G_Pago.Controls.Add(Me.V_Descuento)
        Me.G_Pago.Controls.Add(Me.Label11)
        Me.G_Pago.Controls.Add(Me.Abonado)
        Me.G_Pago.Controls.Add(Me.Label10)
        Me.G_Pago.Controls.Add(Me.Total)
        Me.G_Pago.Controls.Add(Me.Label6)
        Me.G_Pago.Controls.Add(Me.Recargo)
        Me.G_Pago.Controls.Add(Me.Label5)
        Me.G_Pago.Controls.Add(Me.Descuento)
        Me.G_Pago.Controls.Add(Me.Label13)
        Me.G_Pago.Controls.Add(Me.T_Forma_Pago)
        Me.G_Pago.Controls.Add(Me.Label2)
        Me.G_Pago.Controls.Add(Me.Subtotal)
        Me.G_Pago.Enabled = False
        Me.G_Pago.Location = New System.Drawing.Point(780, 26)
        Me.G_Pago.Name = "G_Pago"
        Me.G_Pago.Size = New System.Drawing.Size(461, 510)
        Me.G_Pago.TabIndex = 32
        Me.G_Pago.TabStop = False
        '
        'Cancelar_Venta
        '
        Me.Cancelar_Venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Venta.Enabled = False
        Me.Cancelar_Venta.FlatAppearance.BorderSize = 0
        Me.Cancelar_Venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Cancelar_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_Venta.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar1
        Me.Cancelar_Venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar_Venta.Location = New System.Drawing.Point(29, 381)
        Me.Cancelar_Venta.Name = "Cancelar_Venta"
        Me.Cancelar_Venta.Size = New System.Drawing.Size(202, 121)
        Me.Cancelar_Venta.TabIndex = 116
        Me.Cancelar_Venta.Text = "CANCELAR VENTA"
        Me.Cancelar_Venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_Venta.UseVisualStyleBackColor = True
        '
        'Guardar_Venta
        '
        Me.Guardar_Venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Venta.Enabled = False
        Me.Guardar_Venta.FlatAppearance.BorderSize = 0
        Me.Guardar_Venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Guardar_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Venta.Image = Global.Estrella_Accesorios.My.Resources.Resources.Aceptar
        Me.Guardar_Venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Guardar_Venta.Location = New System.Drawing.Point(237, 381)
        Me.Guardar_Venta.Name = "Guardar_Venta"
        Me.Guardar_Venta.Size = New System.Drawing.Size(202, 121)
        Me.Guardar_Venta.TabIndex = 115
        Me.Guardar_Venta.Text = "GUARDAR VENTA"
        Me.Guardar_Venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Guardar_Venta.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(99, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Su Vuelto:"
        '
        'Vuelto
        '
        Me.Vuelto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vuelto.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Vuelto.DatosPositivos = True
        Me.Vuelto.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vuelto.Location = New System.Drawing.Point(157, 337)
        Me.Vuelto.Margin = New System.Windows.Forms.Padding(0)
        Me.Vuelto.MaxLength = 20
        Me.Vuelto.Multiline = False
        Me.Vuelto.Name = "Vuelto"
        Me.Vuelto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Vuelto.Size = New System.Drawing.Size(294, 31)
        Me.Vuelto.SoloLectura = True
        Me.Vuelto.TabIndex = 114
        Me.Vuelto.TabStop = False
        Me.Vuelto.Tag = "Vuelto"
        Me.Vuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vuelto.UseSystemPasswordChar = False
        '
        'V_Recargo
        '
        Me.V_Recargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.V_Recargo.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.V_Recargo.DatosPositivos = True
        Me.V_Recargo.Enabled = False
        Me.V_Recargo.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.V_Recargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Recargo.Location = New System.Drawing.Point(69, 198)
        Me.V_Recargo.Margin = New System.Windows.Forms.Padding(0)
        Me.V_Recargo.MaxLength = 20
        Me.V_Recargo.Multiline = False
        Me.V_Recargo.Name = "V_Recargo"
        Me.V_Recargo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.V_Recargo.Size = New System.Drawing.Size(86, 31)
        Me.V_Recargo.SoloLectura = True
        Me.V_Recargo.TabIndex = 112
        Me.V_Recargo.TabStop = False
        Me.V_Recargo.Tag = "0"
        Me.V_Recargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.V_Recargo.UseSystemPasswordChar = False
        '
        'V_Descuento
        '
        Me.V_Descuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.V_Descuento.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.V_Descuento.DatosPositivos = True
        Me.V_Descuento.Enabled = False
        Me.V_Descuento.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.V_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Descuento.Location = New System.Drawing.Point(69, 154)
        Me.V_Descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.V_Descuento.MaxLength = 20
        Me.V_Descuento.Multiline = False
        Me.V_Descuento.Name = "V_Descuento"
        Me.V_Descuento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.V_Descuento.Size = New System.Drawing.Size(86, 31)
        Me.V_Descuento.SoloLectura = True
        Me.V_Descuento.TabIndex = 111
        Me.V_Descuento.TabStop = False
        Me.V_Descuento.Tag = "0"
        Me.V_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.V_Descuento.UseSystemPasswordChar = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Importe Abonado:"
        '
        'Abonado
        '
        Me.Abonado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Abonado.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Abonado.DatosPositivos = True
        Me.Abonado.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Abonado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abonado.Location = New System.Drawing.Point(157, 292)
        Me.Abonado.Margin = New System.Windows.Forms.Padding(0)
        Me.Abonado.MaxLength = 20
        Me.Abonado.Multiline = False
        Me.Abonado.Name = "Abonado"
        Me.Abonado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Abonado.Size = New System.Drawing.Size(294, 31)
        Me.Abonado.SoloLectura = False
        Me.Abonado.TabIndex = 110
        Me.Abonado.Tag = "0"
        Me.Abonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Abonado.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(121, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Total:"
        '
        'Total
        '
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Total.DatosPositivos = True
        Me.Total.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(157, 245)
        Me.Total.Margin = New System.Windows.Forms.Padding(0)
        Me.Total.MaxLength = 20
        Me.Total.Multiline = False
        Me.Total.Name = "Total"
        Me.Total.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Total.Size = New System.Drawing.Size(294, 31)
        Me.Total.SoloLectura = True
        Me.Total.TabIndex = 108
        Me.Total.TabStop = False
        Me.Total.Tag = "0"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Recargo:"
        '
        'Recargo
        '
        Me.Recargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Recargo.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Recargo.DatosPositivos = True
        Me.Recargo.Enabled = False
        Me.Recargo.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Recargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recargo.Location = New System.Drawing.Point(157, 198)
        Me.Recargo.Margin = New System.Windows.Forms.Padding(0)
        Me.Recargo.MaxLength = 20
        Me.Recargo.Multiline = False
        Me.Recargo.Name = "Recargo"
        Me.Recargo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Recargo.Size = New System.Drawing.Size(294, 31)
        Me.Recargo.SoloLectura = True
        Me.Recargo.TabIndex = 106
        Me.Recargo.TabStop = False
        Me.Recargo.Tag = "0"
        Me.Recargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Recargo.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Descuento:"
        '
        'Descuento
        '
        Me.Descuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descuento.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Descuento.DatosPositivos = True
        Me.Descuento.Enabled = False
        Me.Descuento.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(157, 154)
        Me.Descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.Descuento.MaxLength = 20
        Me.Descuento.Multiline = False
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Descuento.Size = New System.Drawing.Size(294, 31)
        Me.Descuento.SoloLectura = True
        Me.Descuento.TabIndex = 104
        Me.Descuento.TabStop = False
        Me.Descuento.Tag = "0"
        Me.Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Descuento.UseSystemPasswordChar = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Forma de Pago:"
        '
        'T_Forma_Pago
        '
        Me.T_Forma_Pago.AutoSize = False
        Me.T_Forma_Pago.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Forma_Pago.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Forma_Pago.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Forma_Pago})
        Me.T_Forma_Pago.Location = New System.Drawing.Point(89, 85)
        Me.T_Forma_Pago.Name = "T_Forma_Pago"
        Me.T_Forma_Pago.Size = New System.Drawing.Size(362, 41)
        Me.T_Forma_Pago.TabIndex = 101
        Me.T_Forma_Pago.Tag = ""
        '
        'D_Forma_Pago
        '
        Me.D_Forma_Pago.AutoSize = False
        Me.D_Forma_Pago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.D_Forma_Pago.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Forma_Pago.ForeColor = System.Drawing.Color.Black
        Me.D_Forma_Pago.Image = CType(resources.GetObject("D_Forma_Pago.Image"), System.Drawing.Image)
        Me.D_Forma_Pago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.D_Forma_Pago.Name = "D_Forma_Pago"
        Me.D_Forma_Pago.Size = New System.Drawing.Size(360, 34)
        Me.D_Forma_Pago.Tag = "0"
        Me.D_Forma_Pago.Text = "*** SELECCIONE FORMA PAGO ***"
        Me.D_Forma_Pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.D_Forma_Pago.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sub-Total:"
        '
        'Subtotal
        '
        Me.Subtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Subtotal.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.Subtotal.DatosPositivos = True
        Me.Subtotal.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.Location = New System.Drawing.Point(157, 33)
        Me.Subtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.Subtotal.MaxLength = 20
        Me.Subtotal.Multiline = False
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Subtotal.Size = New System.Drawing.Size(294, 31)
        Me.Subtotal.SoloLectura = True
        Me.Subtotal.TabIndex = 20
        Me.Subtotal.TabStop = False
        Me.Subtotal.Tag = "0"
        Me.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Subtotal.UseSystemPasswordChar = False
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
        'Imagen_Frm
        '
        Me.Imagen_Frm.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estrella
        Me.Imagen_Frm.Location = New System.Drawing.Point(2, 2)
        Me.Imagen_Frm.Name = "Imagen_Frm"
        Me.Imagen_Frm.Size = New System.Drawing.Size(23, 23)
        Me.Imagen_Frm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen_Frm.TabIndex = 19
        Me.Imagen_Frm.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'D_Devolucion
        '
        Me.D_Devolucion.Appearance = System.Windows.Forms.Appearance.Button
        Me.D_Devolucion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.D_Devolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.D_Devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.D_Devolucion.Location = New System.Drawing.Point(625, 163)
        Me.D_Devolucion.Name = "D_Devolucion"
        Me.D_Devolucion.Size = New System.Drawing.Size(121, 31)
        Me.D_Devolucion.TabIndex = 36
        Me.D_Devolucion.Tag = "1"
        Me.D_Devolucion.Text = "Devolución"
        Me.D_Devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.D_Devolucion.UseVisualStyleBackColor = True
        '
        'Frm_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 540)
        Me.Controls.Add(Me.G_Pago)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.G_Datos)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Frm_Ventas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.G_Datos.ResumeLayout(False)
        Me.G_Datos.PerformLayout()
        CType(Me.Adv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G_Pago.ResumeLayout(False)
        Me.G_Pago.PerformLayout()
        Me.T_Forma_Pago.ResumeLayout(False)
        Me.T_Forma_Pago.PerformLayout()
        Me.mnu_Eliminar.ResumeLayout(False)
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents G_Datos As GroupBox
    Friend WithEvents D_Fecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents D_Cantidad As Controles.CuadroTexto
    Friend WithEvents D_Imagen As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents D_Importe As Controles.CuadroTexto
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents D_Total As Controles.CuadroTexto
    Friend WithEvents D_Descripcion As TextBox
    Friend WithEvents Cancelar_Articulo As Button
    Friend WithEvents Aceptar_Articulo As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_Cantidad As ColumnHeader
    Friend WithEvents Col_Descripcion As ColumnHeader
    Friend WithEvents Col_Importe As ColumnHeader
    Friend WithEvents Col_Total As ColumnHeader
    Friend WithEvents G_Pago As GroupBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Col_Imagen As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Subtotal As Controles.CuadroTexto
    Friend WithEvents Label13 As Label
    Friend WithEvents T_Forma_Pago As ToolStrip
    Public WithEvents D_Forma_Pago As ToolStripDropDownButton
    Friend WithEvents Cancelar_Venta As Button
    Friend WithEvents Guardar_Venta As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Vuelto As Controles.CuadroTexto
    Friend WithEvents V_Recargo As Controles.CuadroTexto
    Friend WithEvents V_Descuento As Controles.CuadroTexto
    Friend WithEvents Label11 As Label
    Friend WithEvents Abonado As Controles.CuadroTexto
    Friend WithEvents Label10 As Label
    Friend WithEvents Total As Controles.CuadroTexto
    Friend WithEvents Label6 As Label
    Friend WithEvents Recargo As Controles.CuadroTexto
    Friend WithEvents Label5 As Label
    Friend WithEvents Descuento As Controles.CuadroTexto
    Friend WithEvents mnu_Eliminar As ContextMenuStrip
    Friend WithEvents TMnu_Eliminar As ToolStripMenuItem
    Friend WithEvents D_Codigo As TextBox
    Friend WithEvents Stock As PictureBox
    Friend WithEvents Col_Importe_Compra As ColumnHeader
    Friend WithEvents Adv As PictureBox
    Friend WithEvents Adv1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Col_Fecha As ColumnHeader
    Friend WithEvents D_Devolucion As CheckBox
End Class
