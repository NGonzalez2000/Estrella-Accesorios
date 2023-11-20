<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Ingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ingresos))
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.G_Datos = New System.Windows.Forms.GroupBox()
        Me.Cancelar_Articulo = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Aceptar_Articulo = New System.Windows.Forms.Button()
        Me.D_Codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.G_Datos1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.T_B_Proveedor = New System.Windows.Forms.ToolStrip()
        Me.D_Proveedor = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.T_B_Subfamilia = New System.Windows.Forms.ToolStrip()
        Me.D_Subfamilia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.T_B_Familia = New System.Windows.Forms.ToolStrip()
        Me.D_Familia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.D_Importe_Venta = New Controles.CuadroTexto()
        Me.D_Descripcion = New System.Windows.Forms.TextBox()
        Me.D_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.D_Cantidad = New Controles.CuadroTexto()
        Me.D_Imagen = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.D_Importe_Compra = New Controles.CuadroTexto()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe_Compra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe_Venta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Subfamilia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Familia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.O_DLG = New System.Windows.Forms.OpenFileDialog()
        Me.mnu_Eliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TMnu_Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cancelar_Ingreso = New System.Windows.Forms.Button()
        Me.Guardar_Ingreso = New System.Windows.Forms.Button()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G_Datos.SuspendLayout()
        Me.G_Datos1.SuspendLayout()
        Me.T_B_Proveedor.SuspendLayout()
        Me.T_B_Subfamilia.SuspendLayout()
        Me.T_B_Familia.SuspendLayout()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios - Ingresos de Mercadería"
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
        'G_Datos
        '
        Me.G_Datos.Controls.Add(Me.Cancelar_Articulo)
        Me.G_Datos.Controls.Add(Me.Buscar)
        Me.G_Datos.Controls.Add(Me.Aceptar_Articulo)
        Me.G_Datos.Controls.Add(Me.D_Codigo)
        Me.G_Datos.Controls.Add(Me.Label3)
        Me.G_Datos.Controls.Add(Me.G_Datos1)
        Me.G_Datos.Location = New System.Drawing.Point(2, 23)
        Me.G_Datos.Name = "G_Datos"
        Me.G_Datos.Size = New System.Drawing.Size(917, 229)
        Me.G_Datos.TabIndex = 0
        Me.G_Datos.TabStop = False
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
        Me.Cancelar_Articulo.Location = New System.Drawing.Point(477, 17)
        Me.Cancelar_Articulo.Name = "Cancelar_Articulo"
        Me.Cancelar_Articulo.Size = New System.Drawing.Size(167, 68)
        Me.Cancelar_Articulo.TabIndex = 3
        Me.Cancelar_Articulo.Text = "CANCELAR"
        Me.Cancelar_Articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_Articulo.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Buscar_48
        Me.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Buscar.Location = New System.Drawing.Point(205, 47)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(95, 64)
        Me.Buscar.TabIndex = 4
        Me.Buscar.Text = "Buscar (F8)"
        Me.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buscar.UseVisualStyleBackColor = True
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
        Me.Aceptar_Articulo.Location = New System.Drawing.Point(307, 17)
        Me.Aceptar_Articulo.Name = "Aceptar_Articulo"
        Me.Aceptar_Articulo.Size = New System.Drawing.Size(167, 68)
        Me.Aceptar_Articulo.TabIndex = 2
        Me.Aceptar_Articulo.Text = "ACEPTAR"
        Me.Aceptar_Articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar_Articulo.UseVisualStyleBackColor = True
        '
        'D_Codigo
        '
        Me.D_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Codigo.Location = New System.Drawing.Point(91, 14)
        Me.D_Codigo.MaxLength = 15
        Me.D_Codigo.Name = "D_Codigo"
        Me.D_Codigo.Size = New System.Drawing.Size(212, 31)
        Me.D_Codigo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código:"
        '
        'G_Datos1
        '
        Me.G_Datos1.Controls.Add(Me.Label15)
        Me.G_Datos1.Controls.Add(Me.T_B_Proveedor)
        Me.G_Datos1.Controls.Add(Me.Label14)
        Me.G_Datos1.Controls.Add(Me.T_B_Subfamilia)
        Me.G_Datos1.Controls.Add(Me.Label13)
        Me.G_Datos1.Controls.Add(Me.T_B_Familia)
        Me.G_Datos1.Controls.Add(Me.Label1)
        Me.G_Datos1.Controls.Add(Me.D_Importe_Venta)
        Me.G_Datos1.Controls.Add(Me.D_Descripcion)
        Me.G_Datos1.Controls.Add(Me.D_Fecha)
        Me.G_Datos1.Controls.Add(Me.Label8)
        Me.G_Datos1.Controls.Add(Me.Label9)
        Me.G_Datos1.Controls.Add(Me.D_Cantidad)
        Me.G_Datos1.Controls.Add(Me.D_Imagen)
        Me.G_Datos1.Controls.Add(Me.Label7)
        Me.G_Datos1.Controls.Add(Me.D_Importe_Compra)
        Me.G_Datos1.Controls.Add(Me.Label4)
        Me.G_Datos1.Enabled = False
        Me.G_Datos1.Location = New System.Drawing.Point(0, 1)
        Me.G_Datos1.Name = "G_Datos1"
        Me.G_Datos1.Size = New System.Drawing.Size(917, 228)
        Me.G_Datos1.TabIndex = 1
        Me.G_Datos1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(312, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Proveedor:"
        '
        'T_B_Proveedor
        '
        Me.T_B_Proveedor.AutoSize = False
        Me.T_B_Proveedor.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Proveedor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Proveedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Proveedor})
        Me.T_B_Proveedor.Location = New System.Drawing.Point(373, 152)
        Me.T_B_Proveedor.Name = "T_B_Proveedor"
        Me.T_B_Proveedor.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Proveedor.TabIndex = 6
        Me.T_B_Proveedor.Tag = ""
        '
        'D_Proveedor
        '
        Me.D_Proveedor.AutoSize = False
        Me.D_Proveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.D_Proveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Proveedor.ForeColor = System.Drawing.Color.Black
        Me.D_Proveedor.Image = CType(resources.GetObject("D_Proveedor.Image"), System.Drawing.Image)
        Me.D_Proveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.D_Proveedor.Name = "D_Proveedor"
        Me.D_Proveedor.Size = New System.Drawing.Size(270, 22)
        Me.D_Proveedor.Tag = "0"
        Me.D_Proveedor.Text = "*** SELECCIONE UN PROVEEDOR ***"
        Me.D_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.D_Proveedor.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(307, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Sub-Familia:"
        '
        'T_B_Subfamilia
        '
        Me.T_B_Subfamilia.AutoSize = False
        Me.T_B_Subfamilia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Subfamilia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Subfamilia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Subfamilia})
        Me.T_B_Subfamilia.Location = New System.Drawing.Point(374, 121)
        Me.T_B_Subfamilia.Name = "T_B_Subfamilia"
        Me.T_B_Subfamilia.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Subfamilia.TabIndex = 5
        Me.T_B_Subfamilia.Tag = ""
        '
        'D_Subfamilia
        '
        Me.D_Subfamilia.AutoSize = False
        Me.D_Subfamilia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.D_Subfamilia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Subfamilia.ForeColor = System.Drawing.Color.Black
        Me.D_Subfamilia.Image = CType(resources.GetObject("D_Subfamilia.Image"), System.Drawing.Image)
        Me.D_Subfamilia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.D_Subfamilia.Name = "D_Subfamilia"
        Me.D_Subfamilia.Size = New System.Drawing.Size(270, 22)
        Me.D_Subfamilia.Tag = "0"
        Me.D_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
        Me.D_Subfamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.D_Subfamilia.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(329, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Familia:"
        '
        'T_B_Familia
        '
        Me.T_B_Familia.AutoSize = False
        Me.T_B_Familia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Familia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Familia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Familia})
        Me.T_B_Familia.Location = New System.Drawing.Point(374, 90)
        Me.T_B_Familia.Name = "T_B_Familia"
        Me.T_B_Familia.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Familia.TabIndex = 4
        Me.T_B_Familia.Tag = ""
        '
        'D_Familia
        '
        Me.D_Familia.AutoSize = False
        Me.D_Familia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.D_Familia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Familia.ForeColor = System.Drawing.Color.Black
        Me.D_Familia.Image = CType(resources.GetObject("D_Familia.Image"), System.Drawing.Image)
        Me.D_Familia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.D_Familia.Name = "D_Familia"
        Me.D_Familia.Size = New System.Drawing.Size(270, 22)
        Me.D_Familia.Tag = "0"
        Me.D_Familia.Text = "*** SELECCIONE UNA FAMILIA ***"
        Me.D_Familia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.D_Familia.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Importe Venta:"
        '
        'D_Importe_Venta
        '
        Me.D_Importe_Venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Importe_Venta.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Importe_Venta.DatosPositivos = True
        Me.D_Importe_Venta.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Importe_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Importe_Venta.Location = New System.Drawing.Point(91, 147)
        Me.D_Importe_Venta.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Importe_Venta.MaxLength = 20
        Me.D_Importe_Venta.Multiline = False
        Me.D_Importe_Venta.Name = "D_Importe_Venta"
        Me.D_Importe_Venta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Importe_Venta.Size = New System.Drawing.Size(212, 31)
        Me.D_Importe_Venta.SoloLectura = False
        Me.D_Importe_Venta.TabIndex = 2
        Me.D_Importe_Venta.TabStop = False
        Me.D_Importe_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Importe_Venta.UseSystemPasswordChar = False
        '
        'D_Descripcion
        '
        Me.D_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Descripcion.Location = New System.Drawing.Point(91, 184)
        Me.D_Descripcion.Name = "D_Descripcion"
        Me.D_Descripcion.Size = New System.Drawing.Size(813, 31)
        Me.D_Descripcion.TabIndex = 3
        Me.D_Descripcion.TabStop = False
        '
        'D_Fecha
        '
        Me.D_Fecha.Enabled = False
        Me.D_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D_Fecha.Location = New System.Drawing.Point(91, 85)
        Me.D_Fecha.Name = "D_Fecha"
        Me.D_Fecha.Size = New System.Drawing.Size(113, 20)
        Me.D_Fecha.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "F. Actualización:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Cantidad:"
        '
        'D_Cantidad
        '
        Me.D_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Cantidad.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Cantidad.DatosPositivos = True
        Me.D_Cantidad.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Cantidad.Location = New System.Drawing.Point(91, 49)
        Me.D_Cantidad.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Cantidad.MaxLength = 15
        Me.D_Cantidad.Multiline = False
        Me.D_Cantidad.Name = "D_Cantidad"
        Me.D_Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Cantidad.Size = New System.Drawing.Size(113, 31)
        Me.D_Cantidad.SoloLectura = False
        Me.D_Cantidad.TabIndex = 0
        Me.D_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Cantidad.UseSystemPasswordChar = False
        '
        'D_Imagen
        '
        Me.D_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Imagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.D_Imagen.Location = New System.Drawing.Point(664, 31)
        Me.D_Imagen.Name = "D_Imagen"
        Me.D_Imagen.Size = New System.Drawing.Size(240, 135)
        Me.D_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.D_Imagen.TabIndex = 115
        Me.D_Imagen.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Importe Compra:"
        '
        'D_Importe_Compra
        '
        Me.D_Importe_Compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Importe_Compra.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Importe_Compra.DatosPositivos = True
        Me.D_Importe_Compra.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Importe_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Importe_Compra.Location = New System.Drawing.Point(91, 110)
        Me.D_Importe_Compra.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Importe_Compra.MaxLength = 20
        Me.D_Importe_Compra.Multiline = False
        Me.D_Importe_Compra.Name = "D_Importe_Compra"
        Me.D_Importe_Compra.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Importe_Compra.Size = New System.Drawing.Size(212, 31)
        Me.D_Importe_Compra.SoloLectura = False
        Me.D_Importe_Compra.TabIndex = 1
        Me.D_Importe_Compra.TabStop = False
        Me.D_Importe_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Importe_Compra.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Descrición:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(464, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(230, 13)
        Me.LinkLabel1.TabIndex = 32
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click sobre el recuadro para cargar una imagen"
        '
        'Listado
        '
        Me.Listado.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Codigo, Me.Col_Cantidad, Me.Col_Descripcion, Me.Col_Importe_Compra, Me.Col_Importe_Venta, Me.Col_Fecha, Me.Col_Subfamilia, Me.Col_Familia, Me.Col_Proveedor})
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(3, 258)
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(1093, 278)
        Me.Listado.SmallImageList = Me.ImageList1
        Me.Listado.TabIndex = 1
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_Codigo
        '
        Me.Col_Codigo.Text = "Código"
        Me.Col_Codigo.Width = 130
        '
        'Col_Cantidad
        '
        Me.Col_Cantidad.Text = "Cantidad"
        Me.Col_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Col_Descripcion
        '
        Me.Col_Descripcion.Tag = "N"
        Me.Col_Descripcion.Text = "Descripción"
        Me.Col_Descripcion.Width = 257
        '
        'Col_Importe_Compra
        '
        Me.Col_Importe_Compra.Tag = "N"
        Me.Col_Importe_Compra.Text = "Importe Compra"
        Me.Col_Importe_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Importe_Compra.Width = 100
        '
        'Col_Importe_Venta
        '
        Me.Col_Importe_Venta.Tag = "N"
        Me.Col_Importe_Venta.Text = "Importe Venta"
        Me.Col_Importe_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Importe_Venta.Width = 100
        '
        'Col_Fecha
        '
        Me.Col_Fecha.Tag = "F"
        Me.Col_Fecha.Text = "Fecha Act."
        Me.Col_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Col_Fecha.Width = 70
        '
        'Col_Subfamilia
        '
        Me.Col_Subfamilia.Text = "Sub Familia"
        Me.Col_Subfamilia.Width = 160
        '
        'Col_Familia
        '
        Me.Col_Familia.Text = "Familia"
        Me.Col_Familia.Width = 160
        '
        'Col_Proveedor
        '
        Me.Col_Proveedor.Text = "Proveedor"
        Me.Col_Proveedor.Width = 160
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'O_DLG
        '
        Me.O_DLG.FileName = "OpenFileDialog1"
        '
        'mnu_Eliminar
        '
        Me.mnu_Eliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TMnu_Eliminar})
        Me.mnu_Eliminar.Name = "mnu_Eliminar"
        Me.mnu_Eliminar.Size = New System.Drawing.Size(166, 42)
        Me.mnu_Eliminar.Text = "Eliminar"
        '
        'TMnu_Eliminar
        '
        Me.TMnu_Eliminar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_32
        Me.TMnu_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TMnu_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TMnu_Eliminar.Name = "TMnu_Eliminar"
        Me.TMnu_Eliminar.Size = New System.Drawing.Size(165, 38)
        Me.TMnu_Eliminar.Text = "Borrar Imagen"
        '
        'Cancelar_Ingreso
        '
        Me.Cancelar_Ingreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Ingreso.Enabled = False
        Me.Cancelar_Ingreso.FlatAppearance.BorderSize = 0
        Me.Cancelar_Ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Cancelar_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_Ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_Ingreso.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar1
        Me.Cancelar_Ingreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar_Ingreso.Location = New System.Drawing.Point(925, 142)
        Me.Cancelar_Ingreso.Name = "Cancelar_Ingreso"
        Me.Cancelar_Ingreso.Size = New System.Drawing.Size(168, 106)
        Me.Cancelar_Ingreso.TabIndex = 118
        Me.Cancelar_Ingreso.Text = "CANCELAR INGRESO"
        Me.Cancelar_Ingreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_Ingreso.UseVisualStyleBackColor = True
        '
        'Guardar_Ingreso
        '
        Me.Guardar_Ingreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Ingreso.Enabled = False
        Me.Guardar_Ingreso.FlatAppearance.BorderSize = 0
        Me.Guardar_Ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Guardar_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar_Ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Ingreso.Image = Global.Estrella_Accesorios.My.Resources.Resources.Aceptar
        Me.Guardar_Ingreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Guardar_Ingreso.Location = New System.Drawing.Point(925, 32)
        Me.Guardar_Ingreso.Name = "Guardar_Ingreso"
        Me.Guardar_Ingreso.Size = New System.Drawing.Size(168, 106)
        Me.Guardar_Ingreso.TabIndex = 117
        Me.Guardar_Ingreso.Text = "GUARDAR INGRESO"
        Me.Guardar_Ingreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Guardar_Ingreso.UseVisualStyleBackColor = True
        '
        'Frm_Ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 540)
        Me.Controls.Add(Me.Cancelar_Ingreso)
        Me.Controls.Add(Me.Guardar_Ingreso)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.G_Datos)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Ingresos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_FORMA DE PAGO"
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G_Datos.ResumeLayout(False)
        Me.G_Datos.PerformLayout()
        Me.G_Datos1.ResumeLayout(False)
        Me.G_Datos1.PerformLayout()
        Me.T_B_Proveedor.ResumeLayout(False)
        Me.T_B_Proveedor.PerformLayout()
        Me.T_B_Subfamilia.ResumeLayout(False)
        Me.T_B_Subfamilia.PerformLayout()
        Me.T_B_Familia.ResumeLayout(False)
        Me.T_B_Familia.PerformLayout()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Eliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents G_Datos As GroupBox
    Friend WithEvents D_Codigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents G_Datos1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents T_B_Proveedor As ToolStrip
    Public WithEvents D_Proveedor As ToolStripDropDownButton
    Friend WithEvents Label14 As Label
    Friend WithEvents T_B_Subfamilia As ToolStrip
    Public WithEvents D_Subfamilia As ToolStripDropDownButton
    Friend WithEvents Label13 As Label
    Friend WithEvents T_B_Familia As ToolStrip
    Public WithEvents D_Familia As ToolStripDropDownButton
    Friend WithEvents Label1 As Label
    Friend WithEvents D_Importe_Venta As Controles.CuadroTexto
    Friend WithEvents D_Descripcion As TextBox
    Friend WithEvents D_Fecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents D_Cantidad As Controles.CuadroTexto
    Friend WithEvents D_Imagen As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents D_Importe_Compra As Controles.CuadroTexto
    Friend WithEvents Label4 As Label
    Friend WithEvents Cancelar_Articulo As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents Aceptar_Articulo As Button
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_Codigo As ColumnHeader
    Friend WithEvents Col_Descripcion As ColumnHeader
    Friend WithEvents Col_Importe_Venta As ColumnHeader
    Friend WithEvents Col_Fecha As ColumnHeader
    Friend WithEvents Col_Subfamilia As ColumnHeader
    Friend WithEvents Col_Familia As ColumnHeader
    Friend WithEvents Col_Proveedor As ColumnHeader
    Friend WithEvents Col_Importe_Compra As ColumnHeader
    Friend WithEvents Col_Cantidad As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents O_DLG As OpenFileDialog
    Friend WithEvents mnu_Eliminar As ContextMenuStrip
    Friend WithEvents TMnu_Eliminar As ToolStripMenuItem
    Friend WithEvents Cancelar_Ingreso As Button
    Friend WithEvents Guardar_Ingreso As Button
End Class
