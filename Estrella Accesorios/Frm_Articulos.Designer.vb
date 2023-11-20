<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Articulos))
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Cod_Barras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe_Venta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Stock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Subfamilia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Familia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Importe_Compra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Venidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Compra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Stock_Inicial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Stock_Minimo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.G_Controles = New System.Windows.Forms.GroupBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.G_Busqueda = New System.Windows.Forms.GroupBox()
        Me.Limpiar_Filtros = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.T_B_Proveedor = New System.Windows.Forms.ToolStrip()
        Me.B_Proveedor = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.T_B_Subfamilia = New System.Windows.Forms.ToolStrip()
        Me.B_Subfamilia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.T_B_Familia = New System.Windows.Forms.ToolStrip()
        Me.B_Familia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Descripcion = New System.Windows.Forms.TextBox()
        Me.B_Codigo = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.G_Datos = New System.Windows.Forms.GroupBox()
        Me.D_Codigo_Barras = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.D_Stock_Minimo = New Controles.CuadroTexto()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.T_Proveedor = New System.Windows.Forms.ToolStrip()
        Me.D_Proveedor = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.T_Subfamilia = New System.Windows.Forms.ToolStrip()
        Me.D_Subfamilia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.T_Familia = New System.Windows.Forms.ToolStrip()
        Me.D_Familia = New System.Windows.Forms.ToolStripDropDownButton()
        Me.D_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.D_Stock_Inicial = New Controles.CuadroTexto()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.D_Importe_Venta = New Controles.CuadroTexto()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.D_Importe_Compra = New Controles.CuadroTexto()
        Me.Generar_CB = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.D_Descripcion = New Controles.CuadroTexto()
        Me.D_Codigo = New Controles.CuadroTexto()
        Me.D_Imagen = New System.Windows.Forms.PictureBox()
        Me.mnu_Eliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TMnu_Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.O_DLG = New System.Windows.Forms.OpenFileDialog()
        Me.G_Botones = New System.Windows.Forms.GroupBox()
        Me.B_Lotes = New System.Windows.Forms.Button()
        Me.Codigo_Barras = New System.Windows.Forms.Button()
        Me.G_Lotes = New System.Windows.Forms.GroupBox()
        Me.O_Valor = New System.Windows.Forms.CheckBox()
        Me.O_Division = New System.Windows.Forms.CheckBox()
        Me.O_Multiplicacion = New System.Windows.Forms.CheckBox()
        Me.O_Suma = New System.Windows.Forms.CheckBox()
        Me.O_Porcentaje = New System.Windows.Forms.CheckBox()
        Me.P_Venta = New System.Windows.Forms.CheckBox()
        Me.P_Compra = New System.Windows.Forms.CheckBox()
        Me.Cancelar_Lotes = New System.Windows.Forms.Button()
        Me.Aceptar_Lotes = New System.Windows.Forms.Button()
        Me.D_Valor = New Controles.CuadroTexto()
        Me.Resta = New System.Windows.Forms.CheckBox()
        Me.Suma = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.VP = New System.Windows.Forms.PictureBox()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.G_Controles.SuspendLayout()
        Me.G_Busqueda.SuspendLayout()
        Me.T_B_Proveedor.SuspendLayout()
        Me.T_B_Subfamilia.SuspendLayout()
        Me.T_B_Familia.SuspendLayout()
        Me.G_Datos.SuspendLayout()
        Me.T_Proveedor.SuspendLayout()
        Me.T_Subfamilia.SuspendLayout()
        Me.T_Familia.SuspendLayout()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_Eliminar.SuspendLayout()
        Me.G_Botones.SuspendLayout()
        Me.G_Lotes.SuspendLayout()
        CType(Me.VP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Titulo_Frm.TabIndex = 1
        Me.Titulo_Frm.Text = "  Estrella Accesorios - ARTICULOS"
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
        'Listado
        '
        Me.Listado.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Listado.CheckBoxes = True
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Codigo, Me.Col_Descripcion, Me.Col_Cod_Barras, Me.Col_Importe_Venta, Me.Col_Fecha, Me.Col_Stock, Me.Col_Subfamilia, Me.Col_Familia, Me.Col_Proveedor, Me.Col_Importe_Compra, Me.Col_Venidos, Me.Col_Compra, Me.Col_Stock_Inicial, Me.Col_Stock_Minimo})
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(157, 162)
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(903, 280)
        Me.Listado.SmallImageList = Me.ImageList1
        Me.Listado.TabIndex = 4
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_Codigo
        '
        Me.Col_Codigo.Text = "Código"
        Me.Col_Codigo.Width = 113
        '
        'Col_Descripcion
        '
        Me.Col_Descripcion.Text = "Descripción"
        Me.Col_Descripcion.Width = 280
        '
        'Col_Cod_Barras
        '
        Me.Col_Cod_Barras.Text = "Código Barras"
        Me.Col_Cod_Barras.Width = 105
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
        'Col_Stock
        '
        Me.Col_Stock.Tag = "N"
        Me.Col_Stock.Text = "Stock"
        Me.Col_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Stock.Width = 100
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
        'Col_Importe_Compra
        '
        Me.Col_Importe_Compra.Tag = "N"
        Me.Col_Importe_Compra.Text = "Importe Compra"
        Me.Col_Importe_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Importe_Compra.Width = 100
        '
        'Col_Venidos
        '
        Me.Col_Venidos.Tag = "N"
        Me.Col_Venidos.Text = "Cant. Vendidos"
        Me.Col_Venidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Venidos.Width = 100
        '
        'Col_Compra
        '
        Me.Col_Compra.Tag = "N"
        Me.Col_Compra.Text = "Cant. Compras"
        Me.Col_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Compra.Width = 100
        '
        'Col_Stock_Inicial
        '
        Me.Col_Stock_Inicial.Tag = "N"
        Me.Col_Stock_Inicial.Text = "Stock Inicial"
        Me.Col_Stock_Inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Stock_Inicial.Width = 100
        '
        'Col_Stock_Minimo
        '
        Me.Col_Stock_Minimo.Text = "Stock Min."
        Me.Col_Stock_Minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col_Stock_Minimo.Width = 100
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "S1")
        Me.ImageList1.Images.SetKeyName(1, "S0")
        Me.ImageList1.Images.SetKeyName(2, "S2")
        '
        'G_Controles
        '
        Me.G_Controles.Controls.Add(Me.Borrar)
        Me.G_Controles.Controls.Add(Me.Modificar)
        Me.G_Controles.Controls.Add(Me.Cancelar)
        Me.G_Controles.Controls.Add(Me.Agregar)
        Me.G_Controles.Location = New System.Drawing.Point(630, 25)
        Me.G_Controles.Name = "G_Controles"
        Me.G_Controles.Size = New System.Drawing.Size(430, 131)
        Me.G_Controles.TabIndex = 1
        Me.G_Controles.TabStop = False
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
        Me.Borrar.Location = New System.Drawing.Point(219, 15)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Borrar.Size = New System.Drawing.Size(97, 108)
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
        Me.Modificar.Location = New System.Drawing.Point(116, 15)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Modificar.Size = New System.Drawing.Size(97, 108)
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
        Me.Cancelar.Location = New System.Drawing.Point(322, 15)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Cancelar.Size = New System.Drawing.Size(97, 108)
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
        Me.Agregar.Location = New System.Drawing.Point(13, 15)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Agregar.Size = New System.Drawing.Size(97, 108)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'G_Busqueda
        '
        Me.G_Busqueda.Controls.Add(Me.Limpiar_Filtros)
        Me.G_Busqueda.Controls.Add(Me.Label15)
        Me.G_Busqueda.Controls.Add(Me.T_B_Proveedor)
        Me.G_Busqueda.Controls.Add(Me.Label14)
        Me.G_Busqueda.Controls.Add(Me.T_B_Subfamilia)
        Me.G_Busqueda.Controls.Add(Me.Label13)
        Me.G_Busqueda.Controls.Add(Me.T_B_Familia)
        Me.G_Busqueda.Controls.Add(Me.Label2)
        Me.G_Busqueda.Controls.Add(Me.Label1)
        Me.G_Busqueda.Controls.Add(Me.B_Descripcion)
        Me.G_Busqueda.Controls.Add(Me.B_Codigo)
        Me.G_Busqueda.Controls.Add(Me.Buscar)
        Me.G_Busqueda.Location = New System.Drawing.Point(5, 25)
        Me.G_Busqueda.Name = "G_Busqueda"
        Me.G_Busqueda.Size = New System.Drawing.Size(619, 131)
        Me.G_Busqueda.TabIndex = 0
        Me.G_Busqueda.TabStop = False
        '
        'Limpiar_Filtros
        '
        Me.Limpiar_Filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar_Filtros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Limpiar_Filtros.FlatAppearance.BorderSize = 0
        Me.Limpiar_Filtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Limpiar_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Limpiar_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar_Filtros.Image = Global.Estrella_Accesorios.My.Resources.Resources.Limpiar
        Me.Limpiar_Filtros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Limpiar_Filtros.Location = New System.Drawing.Point(353, 36)
        Me.Limpiar_Filtros.Name = "Limpiar_Filtros"
        Me.Limpiar_Filtros.Size = New System.Drawing.Size(138, 89)
        Me.Limpiar_Filtros.TabIndex = 7
        Me.Limpiar_Filtros.Text = "Limpiar Filtros"
        Me.Limpiar_Filtros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Limpiar_Filtros.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Proveedor:"
        '
        'T_B_Proveedor
        '
        Me.T_B_Proveedor.AutoSize = False
        Me.T_B_Proveedor.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Proveedor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Proveedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Proveedor})
        Me.T_B_Proveedor.Location = New System.Drawing.Point(72, 98)
        Me.T_B_Proveedor.Name = "T_B_Proveedor"
        Me.T_B_Proveedor.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Proveedor.TabIndex = 5
        Me.T_B_Proveedor.Tag = ""
        '
        'B_Proveedor
        '
        Me.B_Proveedor.AutoSize = False
        Me.B_Proveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.B_Proveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Proveedor.ForeColor = System.Drawing.Color.Black
        Me.B_Proveedor.Image = CType(resources.GetObject("B_Proveedor.Image"), System.Drawing.Image)
        Me.B_Proveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Proveedor.Name = "B_Proveedor"
        Me.B_Proveedor.Size = New System.Drawing.Size(270, 22)
        Me.B_Proveedor.Tag = "0"
        Me.B_Proveedor.Text = "*** SELECCIONE UN PROVEEDOR ***"
        Me.B_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Proveedor.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Sub-Familia:"
        '
        'T_B_Subfamilia
        '
        Me.T_B_Subfamilia.AutoSize = False
        Me.T_B_Subfamilia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Subfamilia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Subfamilia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Subfamilia})
        Me.T_B_Subfamilia.Location = New System.Drawing.Point(72, 67)
        Me.T_B_Subfamilia.Name = "T_B_Subfamilia"
        Me.T_B_Subfamilia.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Subfamilia.TabIndex = 4
        Me.T_B_Subfamilia.Tag = ""
        '
        'B_Subfamilia
        '
        Me.B_Subfamilia.AutoSize = False
        Me.B_Subfamilia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.B_Subfamilia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Subfamilia.ForeColor = System.Drawing.Color.Black
        Me.B_Subfamilia.Image = CType(resources.GetObject("B_Subfamilia.Image"), System.Drawing.Image)
        Me.B_Subfamilia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Subfamilia.Name = "B_Subfamilia"
        Me.B_Subfamilia.Size = New System.Drawing.Size(270, 22)
        Me.B_Subfamilia.Tag = "0"
        Me.B_Subfamilia.Text = "*** SELECCIONE UNA SUB-FAMILIA ***"
        Me.B_Subfamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Subfamilia.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Familia:"
        '
        'T_B_Familia
        '
        Me.T_B_Familia.AutoSize = False
        Me.T_B_Familia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_B_Familia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_B_Familia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Familia})
        Me.T_B_Familia.Location = New System.Drawing.Point(72, 36)
        Me.T_B_Familia.Name = "T_B_Familia"
        Me.T_B_Familia.Size = New System.Drawing.Size(272, 25)
        Me.T_B_Familia.TabIndex = 3
        Me.T_B_Familia.Tag = ""
        '
        'B_Familia
        '
        Me.B_Familia.AutoSize = False
        Me.B_Familia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.B_Familia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Familia.ForeColor = System.Drawing.Color.Black
        Me.B_Familia.Image = CType(resources.GetObject("B_Familia.Image"), System.Drawing.Image)
        Me.B_Familia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Familia.Name = "B_Familia"
        Me.B_Familia.Size = New System.Drawing.Size(270, 22)
        Me.B_Familia.Tag = "0"
        Me.B_Familia.Text = "*** SELECCIONE UNA FAMILIA ***"
        Me.B_Familia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Familia.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Código:"
        '
        'B_Descripcion
        '
        Me.B_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.B_Descripcion.Location = New System.Drawing.Point(242, 12)
        Me.B_Descripcion.MaxLength = 100
        Me.B_Descripcion.Name = "B_Descripcion"
        Me.B_Descripcion.Size = New System.Drawing.Size(249, 20)
        Me.B_Descripcion.TabIndex = 1
        '
        'B_Codigo
        '
        Me.B_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.B_Codigo.Location = New System.Drawing.Point(70, 12)
        Me.B_Codigo.MaxLength = 15
        Me.B_Codigo.Name = "B_Codigo"
        Me.B_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.B_Codigo.TabIndex = 0
        '
        'Buscar
        '
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Buscar_64
        Me.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Buscar.Location = New System.Drawing.Point(500, 15)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Buscar.Size = New System.Drawing.Size(109, 106)
        Me.Buscar.TabIndex = 6
        Me.Buscar.Text = "Buscar"
        Me.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(486, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(230, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click sobre el recuadro para cargar una imagen"
        '
        'G_Datos
        '
        Me.G_Datos.Controls.Add(Me.D_Codigo_Barras)
        Me.G_Datos.Controls.Add(Me.Label17)
        Me.G_Datos.Controls.Add(Me.D_Stock_Minimo)
        Me.G_Datos.Controls.Add(Me.Label12)
        Me.G_Datos.Controls.Add(Me.T_Proveedor)
        Me.G_Datos.Controls.Add(Me.Label11)
        Me.G_Datos.Controls.Add(Me.T_Subfamilia)
        Me.G_Datos.Controls.Add(Me.Label10)
        Me.G_Datos.Controls.Add(Me.T_Familia)
        Me.G_Datos.Controls.Add(Me.D_Fecha)
        Me.G_Datos.Controls.Add(Me.Label8)
        Me.G_Datos.Controls.Add(Me.Label9)
        Me.G_Datos.Controls.Add(Me.D_Stock_Inicial)
        Me.G_Datos.Controls.Add(Me.Label6)
        Me.G_Datos.Controls.Add(Me.D_Importe_Venta)
        Me.G_Datos.Controls.Add(Me.Label7)
        Me.G_Datos.Controls.Add(Me.D_Importe_Compra)
        Me.G_Datos.Controls.Add(Me.Generar_CB)
        Me.G_Datos.Controls.Add(Me.Label5)
        Me.G_Datos.Controls.Add(Me.Label4)
        Me.G_Datos.Controls.Add(Me.Label3)
        Me.G_Datos.Controls.Add(Me.D_Descripcion)
        Me.G_Datos.Controls.Add(Me.D_Codigo)
        Me.G_Datos.Controls.Add(Me.D_Imagen)
        Me.G_Datos.Enabled = False
        Me.G_Datos.Location = New System.Drawing.Point(5, 440)
        Me.G_Datos.Name = "G_Datos"
        Me.G_Datos.Size = New System.Drawing.Size(1055, 155)
        Me.G_Datos.TabIndex = 5
        Me.G_Datos.TabStop = False
        '
        'D_Codigo_Barras
        '
        Me.D_Codigo_Barras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Codigo_Barras.Location = New System.Drawing.Point(107, 41)
        Me.D_Codigo_Barras.MaxLength = 15
        Me.D_Codigo_Barras.Name = "D_Codigo_Barras"
        Me.D_Codigo_Barras.Size = New System.Drawing.Size(113, 20)
        Me.D_Codigo_Barras.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(246, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Stock Mínimo:"
        '
        'D_Stock_Minimo
        '
        Me.D_Stock_Minimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Stock_Minimo.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Stock_Minimo.DatosPositivos = True
        Me.D_Stock_Minimo.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Stock_Minimo.Location = New System.Drawing.Point(323, 126)
        Me.D_Stock_Minimo.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Stock_Minimo.MaxLength = 15
        Me.D_Stock_Minimo.Multiline = False
        Me.D_Stock_Minimo.Name = "D_Stock_Minimo"
        Me.D_Stock_Minimo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Stock_Minimo.Size = New System.Drawing.Size(113, 20)
        Me.D_Stock_Minimo.SoloLectura = False
        Me.D_Stock_Minimo.TabIndex = 6
        Me.D_Stock_Minimo.Text = "0000"
        Me.D_Stock_Minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Stock_Minimo.UseSystemPasswordChar = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(529, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Proveedor:"
        '
        'T_Proveedor
        '
        Me.T_Proveedor.AutoSize = False
        Me.T_Proveedor.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Proveedor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Proveedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Proveedor})
        Me.T_Proveedor.Location = New System.Drawing.Point(525, 120)
        Me.T_Proveedor.Name = "T_Proveedor"
        Me.T_Proveedor.Size = New System.Drawing.Size(272, 25)
        Me.T_Proveedor.TabIndex = 10
        Me.T_Proveedor.Tag = ""
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(529, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Sub-Familia:"
        '
        'T_Subfamilia
        '
        Me.T_Subfamilia.AutoSize = False
        Me.T_Subfamilia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Subfamilia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Subfamilia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Subfamilia})
        Me.T_Subfamilia.Location = New System.Drawing.Point(525, 73)
        Me.T_Subfamilia.Name = "T_Subfamilia"
        Me.T_Subfamilia.Size = New System.Drawing.Size(272, 25)
        Me.T_Subfamilia.TabIndex = 9
        Me.T_Subfamilia.Tag = ""
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(529, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Familia:"
        '
        'T_Familia
        '
        Me.T_Familia.AutoSize = False
        Me.T_Familia.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Familia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Familia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Familia})
        Me.T_Familia.Location = New System.Drawing.Point(525, 28)
        Me.T_Familia.Name = "T_Familia"
        Me.T_Familia.Size = New System.Drawing.Size(272, 25)
        Me.T_Familia.TabIndex = 8
        Me.T_Familia.Tag = ""
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
        'D_Fecha
        '
        Me.D_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D_Fecha.Location = New System.Drawing.Point(412, 33)
        Me.D_Fecha.Name = "D_Fecha"
        Me.D_Fecha.Size = New System.Drawing.Size(105, 20)
        Me.D_Fecha.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Actualización:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Stock Inicial:"
        '
        'D_Stock_Inicial
        '
        Me.D_Stock_Inicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Stock_Inicial.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Stock_Inicial.DatosPositivos = True
        Me.D_Stock_Inicial.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Stock_Inicial.Location = New System.Drawing.Point(323, 98)
        Me.D_Stock_Inicial.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Stock_Inicial.MaxLength = 15
        Me.D_Stock_Inicial.Multiline = False
        Me.D_Stock_Inicial.Name = "D_Stock_Inicial"
        Me.D_Stock_Inicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Stock_Inicial.Size = New System.Drawing.Size(113, 20)
        Me.D_Stock_Inicial.SoloLectura = False
        Me.D_Stock_Inicial.TabIndex = 5
        Me.D_Stock_Inicial.Text = "0000"
        Me.D_Stock_Inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Stock_Inicial.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Importe Venta:"
        '
        'D_Importe_Venta
        '
        Me.D_Importe_Venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Importe_Venta.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Importe_Venta.DatosPositivos = True
        Me.D_Importe_Venta.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Importe_Venta.Location = New System.Drawing.Point(107, 126)
        Me.D_Importe_Venta.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Importe_Venta.MaxLength = 20
        Me.D_Importe_Venta.Multiline = False
        Me.D_Importe_Venta.Name = "D_Importe_Venta"
        Me.D_Importe_Venta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Importe_Venta.Size = New System.Drawing.Size(113, 20)
        Me.D_Importe_Venta.SoloLectura = False
        Me.D_Importe_Venta.TabIndex = 4
        Me.D_Importe_Venta.Text = "0000"
        Me.D_Importe_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Importe_Venta.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Importe Compra:"
        '
        'D_Importe_Compra
        '
        Me.D_Importe_Compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Importe_Compra.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Importe_Compra.DatosPositivos = True
        Me.D_Importe_Compra.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Importe_Compra.Location = New System.Drawing.Point(107, 98)
        Me.D_Importe_Compra.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Importe_Compra.MaxLength = 20
        Me.D_Importe_Compra.Multiline = False
        Me.D_Importe_Compra.Name = "D_Importe_Compra"
        Me.D_Importe_Compra.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Importe_Compra.Size = New System.Drawing.Size(113, 20)
        Me.D_Importe_Compra.SoloLectura = False
        Me.D_Importe_Compra.TabIndex = 3
        Me.D_Importe_Compra.Text = "0000"
        Me.D_Importe_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Importe_Compra.UseSystemPasswordChar = False
        '
        'Generar_CB
        '
        Me.Generar_CB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Generar_CB.FlatAppearance.BorderSize = 0
        Me.Generar_CB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Generar_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Generar_CB.Image = Global.Estrella_Accesorios.My.Resources.Resources.CB
        Me.Generar_CB.Location = New System.Drawing.Point(233, 12)
        Me.Generar_CB.Name = "Generar_CB"
        Me.Generar_CB.Size = New System.Drawing.Size(178, 48)
        Me.Generar_CB.TabIndex = 11
        Me.Generar_CB.Text = "Generar Cod. Barras / QR"
        Me.Generar_CB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Generar_CB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Generar_CB.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cód. Barras / QR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descrición:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código:"
        '
        'D_Descripcion
        '
        Me.D_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Descripcion.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Libre
        Me.D_Descripcion.DatosPositivos = True
        Me.D_Descripcion.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Descripcion.Location = New System.Drawing.Point(107, 69)
        Me.D_Descripcion.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Descripcion.MaxLength = 100
        Me.D_Descripcion.Multiline = False
        Me.D_Descripcion.Name = "D_Descripcion"
        Me.D_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Descripcion.Size = New System.Drawing.Size(410, 20)
        Me.D_Descripcion.SoloLectura = False
        Me.D_Descripcion.TabIndex = 2
        Me.D_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.D_Descripcion.UseSystemPasswordChar = False
        '
        'D_Codigo
        '
        Me.D_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Codigo.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Libre
        Me.D_Codigo.DatosPositivos = True
        Me.D_Codigo.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Codigo.Location = New System.Drawing.Point(107, 12)
        Me.D_Codigo.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Codigo.MaxLength = 15
        Me.D_Codigo.Multiline = False
        Me.D_Codigo.Name = "D_Codigo"
        Me.D_Codigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Codigo.Size = New System.Drawing.Size(113, 20)
        Me.D_Codigo.SoloLectura = False
        Me.D_Codigo.TabIndex = 0
        Me.D_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.D_Codigo.UseSystemPasswordChar = False
        '
        'D_Imagen
        '
        Me.D_Imagen.BackColor = System.Drawing.Color.Transparent
        Me.D_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Imagen.ContextMenuStrip = Me.mnu_Eliminar
        Me.D_Imagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.D_Imagen.Location = New System.Drawing.Point(806, 12)
        Me.D_Imagen.Name = "D_Imagen"
        Me.D_Imagen.Size = New System.Drawing.Size(240, 135)
        Me.D_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.D_Imagen.TabIndex = 11
        Me.D_Imagen.TabStop = False
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
        'O_DLG
        '
        Me.O_DLG.FileName = "OpenFileDialog1"
        '
        'G_Botones
        '
        Me.G_Botones.Controls.Add(Me.B_Lotes)
        Me.G_Botones.Controls.Add(Me.Codigo_Barras)
        Me.G_Botones.Location = New System.Drawing.Point(5, 155)
        Me.G_Botones.Name = "G_Botones"
        Me.G_Botones.Size = New System.Drawing.Size(146, 287)
        Me.G_Botones.TabIndex = 2
        Me.G_Botones.TabStop = False
        '
        'B_Lotes
        '
        Me.B_Lotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B_Lotes.Enabled = False
        Me.B_Lotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Lotes.FlatAppearance.BorderSize = 0
        Me.B_Lotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.B_Lotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Lotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Lotes.Image = Global.Estrella_Accesorios.My.Resources.Resources.Calculadora
        Me.B_Lotes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_Lotes.Location = New System.Drawing.Point(4, 7)
        Me.B_Lotes.Name = "B_Lotes"
        Me.B_Lotes.Size = New System.Drawing.Size(138, 90)
        Me.B_Lotes.TabIndex = 0
        Me.B_Lotes.Text = "Modif. x Lotes"
        Me.B_Lotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_Lotes.UseVisualStyleBackColor = True
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Codigo_Barras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Codigo_Barras.FlatAppearance.BorderSize = 0
        Me.Codigo_Barras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Codigo_Barras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Codigo_Barras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Barras.Image = Global.Estrella_Accesorios.My.Resources.Resources.Etiqueta_QR_64
        Me.Codigo_Barras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Codigo_Barras.Location = New System.Drawing.Point(4, 100)
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Size = New System.Drawing.Size(138, 90)
        Me.Codigo_Barras.TabIndex = 3
        Me.Codigo_Barras.Text = "Etiquetas QR"
        Me.Codigo_Barras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Codigo_Barras.UseVisualStyleBackColor = True
        '
        'G_Lotes
        '
        Me.G_Lotes.Controls.Add(Me.O_Valor)
        Me.G_Lotes.Controls.Add(Me.O_Division)
        Me.G_Lotes.Controls.Add(Me.O_Multiplicacion)
        Me.G_Lotes.Controls.Add(Me.O_Suma)
        Me.G_Lotes.Controls.Add(Me.O_Porcentaje)
        Me.G_Lotes.Controls.Add(Me.P_Venta)
        Me.G_Lotes.Controls.Add(Me.P_Compra)
        Me.G_Lotes.Controls.Add(Me.Cancelar_Lotes)
        Me.G_Lotes.Controls.Add(Me.Aceptar_Lotes)
        Me.G_Lotes.Controls.Add(Me.D_Valor)
        Me.G_Lotes.Controls.Add(Me.Resta)
        Me.G_Lotes.Controls.Add(Me.Suma)
        Me.G_Lotes.Controls.Add(Me.Label16)
        Me.G_Lotes.Location = New System.Drawing.Point(353, 206)
        Me.G_Lotes.Name = "G_Lotes"
        Me.G_Lotes.Size = New System.Drawing.Size(511, 190)
        Me.G_Lotes.TabIndex = 6
        Me.G_Lotes.TabStop = False
        Me.G_Lotes.Visible = False
        '
        'O_Valor
        '
        Me.O_Valor.Appearance = System.Windows.Forms.Appearance.Button
        Me.O_Valor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.O_Valor.FlatAppearance.BorderSize = 0
        Me.O_Valor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia
        Me.O_Valor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.O_Valor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Valor.Image = Global.Estrella_Accesorios.My.Resources.Resources.Valor_24
        Me.O_Valor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.O_Valor.Location = New System.Drawing.Point(6, 148)
        Me.O_Valor.Name = "O_Valor"
        Me.O_Valor.Padding = New System.Windows.Forms.Padding(5, 0, 45, 0)
        Me.O_Valor.Size = New System.Drawing.Size(148, 32)
        Me.O_Valor.TabIndex = 5
        Me.O_Valor.Text = "Valor"
        Me.O_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.O_Valor.UseVisualStyleBackColor = True
        '
        'O_Division
        '
        Me.O_Division.Appearance = System.Windows.Forms.Appearance.Button
        Me.O_Division.Cursor = System.Windows.Forms.Cursors.Hand
        Me.O_Division.FlatAppearance.BorderSize = 0
        Me.O_Division.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia
        Me.O_Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.O_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Division.Image = Global.Estrella_Accesorios.My.Resources.Resources.Dividir_24
        Me.O_Division.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.O_Division.Location = New System.Drawing.Point(6, 114)
        Me.O_Division.Name = "O_Division"
        Me.O_Division.Padding = New System.Windows.Forms.Padding(5, 0, 37, 0)
        Me.O_Division.Size = New System.Drawing.Size(148, 32)
        Me.O_Division.TabIndex = 4
        Me.O_Division.Text = "División"
        Me.O_Division.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.O_Division.UseVisualStyleBackColor = True
        '
        'O_Multiplicacion
        '
        Me.O_Multiplicacion.Appearance = System.Windows.Forms.Appearance.Button
        Me.O_Multiplicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.O_Multiplicacion.FlatAppearance.BorderSize = 0
        Me.O_Multiplicacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia
        Me.O_Multiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.O_Multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Multiplicacion.Image = Global.Estrella_Accesorios.My.Resources.Resources.Multiplicar_24
        Me.O_Multiplicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.O_Multiplicacion.Location = New System.Drawing.Point(6, 80)
        Me.O_Multiplicacion.Name = "O_Multiplicacion"
        Me.O_Multiplicacion.Padding = New System.Windows.Forms.Padding(5, 0, 22, 0)
        Me.O_Multiplicacion.Size = New System.Drawing.Size(148, 32)
        Me.O_Multiplicacion.TabIndex = 3
        Me.O_Multiplicacion.Text = "Multiplicación"
        Me.O_Multiplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.O_Multiplicacion.UseVisualStyleBackColor = True
        '
        'O_Suma
        '
        Me.O_Suma.Appearance = System.Windows.Forms.Appearance.Button
        Me.O_Suma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.O_Suma.FlatAppearance.BorderSize = 0
        Me.O_Suma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia
        Me.O_Suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.O_Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Suma.Image = Global.Estrella_Accesorios.My.Resources.Resources.Suma_Resta_24
        Me.O_Suma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.O_Suma.Location = New System.Drawing.Point(6, 46)
        Me.O_Suma.Name = "O_Suma"
        Me.O_Suma.Padding = New System.Windows.Forms.Padding(5, 0, 25, 0)
        Me.O_Suma.Size = New System.Drawing.Size(148, 32)
        Me.O_Suma.TabIndex = 2
        Me.O_Suma.Text = "Suma/Resta"
        Me.O_Suma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.O_Suma.UseVisualStyleBackColor = True
        '
        'O_Porcentaje
        '
        Me.O_Porcentaje.Appearance = System.Windows.Forms.Appearance.Button
        Me.O_Porcentaje.Checked = True
        Me.O_Porcentaje.CheckState = System.Windows.Forms.CheckState.Checked
        Me.O_Porcentaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.O_Porcentaje.FlatAppearance.BorderSize = 0
        Me.O_Porcentaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia
        Me.O_Porcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.O_Porcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Porcentaje.Image = Global.Estrella_Accesorios.My.Resources.Resources.Porcentaje_24
        Me.O_Porcentaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.O_Porcentaje.Location = New System.Drawing.Point(6, 12)
        Me.O_Porcentaje.Name = "O_Porcentaje"
        Me.O_Porcentaje.Padding = New System.Windows.Forms.Padding(5, 0, 15, 0)
        Me.O_Porcentaje.Size = New System.Drawing.Size(148, 32)
        Me.O_Porcentaje.TabIndex = 1
        Me.O_Porcentaje.Text = "Porcentaje ✔"
        Me.O_Porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.O_Porcentaje.UseVisualStyleBackColor = True
        '
        'P_Venta
        '
        Me.P_Venta.Appearance = System.Windows.Forms.Appearance.Button
        Me.P_Venta.FlatAppearance.BorderSize = 0
        Me.P_Venta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.P_Venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.P_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.P_Venta.Location = New System.Drawing.Point(349, 98)
        Me.P_Venta.Name = "P_Venta"
        Me.P_Venta.Size = New System.Drawing.Size(154, 24)
        Me.P_Venta.TabIndex = 9
        Me.P_Venta.Text = "Precio Venta"
        Me.P_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.P_Venta.UseVisualStyleBackColor = True
        '
        'P_Compra
        '
        Me.P_Compra.Appearance = System.Windows.Forms.Appearance.Button
        Me.P_Compra.FlatAppearance.BorderSize = 0
        Me.P_Compra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.P_Compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.P_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.P_Compra.Location = New System.Drawing.Point(190, 98)
        Me.P_Compra.Name = "P_Compra"
        Me.P_Compra.Size = New System.Drawing.Size(154, 24)
        Me.P_Compra.TabIndex = 8
        Me.P_Compra.Text = "Precio Compra"
        Me.P_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.P_Compra.UseVisualStyleBackColor = True
        '
        'Cancelar_Lotes
        '
        Me.Cancelar_Lotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Lotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cancelar_Lotes.FlatAppearance.BorderSize = 0
        Me.Cancelar_Lotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Cancelar_Lotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_Lotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_Lotes.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar_32
        Me.Cancelar_Lotes.Location = New System.Drawing.Point(190, 128)
        Me.Cancelar_Lotes.Name = "Cancelar_Lotes"
        Me.Cancelar_Lotes.Size = New System.Drawing.Size(154, 51)
        Me.Cancelar_Lotes.TabIndex = 11
        Me.Cancelar_Lotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_Lotes.UseVisualStyleBackColor = True
        '
        'Aceptar_Lotes
        '
        Me.Aceptar_Lotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar_Lotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Aceptar_Lotes.FlatAppearance.BorderSize = 0
        Me.Aceptar_Lotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Aceptar_Lotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar_Lotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar_Lotes.Image = Global.Estrella_Accesorios.My.Resources.Resources.Aceptar_32
        Me.Aceptar_Lotes.Location = New System.Drawing.Point(349, 128)
        Me.Aceptar_Lotes.Name = "Aceptar_Lotes"
        Me.Aceptar_Lotes.Size = New System.Drawing.Size(154, 50)
        Me.Aceptar_Lotes.TabIndex = 10
        Me.Aceptar_Lotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar_Lotes.UseVisualStyleBackColor = True
        '
        'D_Valor
        '
        Me.D_Valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.D_Valor.DatosAdmitidos = Controles.CuadroTexto.TipoDatos.Numero_Doble
        Me.D_Valor.DatosPositivos = True
        Me.D_Valor.EstiloBorde = System.Windows.Forms.BorderStyle.FixedSingle
        Me.D_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Valor.Location = New System.Drawing.Point(190, 23)
        Me.D_Valor.Margin = New System.Windows.Forms.Padding(0)
        Me.D_Valor.MaxLength = 12
        Me.D_Valor.Multiline = False
        Me.D_Valor.Name = "D_Valor"
        Me.D_Valor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.D_Valor.Size = New System.Drawing.Size(313, 67)
        Me.D_Valor.SoloLectura = False
        Me.D_Valor.TabIndex = 0
        Me.D_Valor.Text = "1.000.000,00"
        Me.D_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.D_Valor.UseSystemPasswordChar = False
        '
        'Resta
        '
        Me.Resta.Appearance = System.Windows.Forms.Appearance.Button
        Me.Resta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resta.FlatAppearance.BorderSize = 0
        Me.Resta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Resta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Resta.Image = Global.Estrella_Accesorios.My.Resources.Resources.Resta_24
        Me.Resta.Location = New System.Drawing.Point(158, 56)
        Me.Resta.Margin = New System.Windows.Forms.Padding(0)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(32, 32)
        Me.Resta.TabIndex = 7
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Suma
        '
        Me.Suma.Appearance = System.Windows.Forms.Appearance.Button
        Me.Suma.Checked = True
        Me.Suma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Suma.FlatAppearance.BorderSize = 0
        Me.Suma.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed
        Me.Suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Suma.Image = Global.Estrella_Accesorios.My.Resources.Resources.Suma_24
        Me.Suma.Location = New System.Drawing.Point(158, 24)
        Me.Suma.Margin = New System.Windows.Forms.Padding(0)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(32, 32)
        Me.Suma.TabIndex = 6
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(193, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(191, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "   Modificación por Lotes   "
        '
        'VP
        '
        Me.VP.BackColor = System.Drawing.Color.Transparent
        Me.VP.Location = New System.Drawing.Point(809, 307)
        Me.VP.Name = "VP"
        Me.VP.Size = New System.Drawing.Size(240, 135)
        Me.VP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VP.TabIndex = 30
        Me.VP.TabStop = False
        Me.VP.Visible = False
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
        'Frm_Articulos
        '
        Me.AcceptButton = Me.Buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 599)
        Me.Controls.Add(Me.G_Lotes)
        Me.Controls.Add(Me.G_Botones)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.VP)
        Me.Controls.Add(Me.G_Datos)
        Me.Controls.Add(Me.G_Controles)
        Me.Controls.Add(Me.G_Busqueda)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.Controls.Add(Me.Listado)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Articulos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.G_Controles.ResumeLayout(False)
        Me.G_Busqueda.ResumeLayout(False)
        Me.G_Busqueda.PerformLayout()
        Me.T_B_Proveedor.ResumeLayout(False)
        Me.T_B_Proveedor.PerformLayout()
        Me.T_B_Subfamilia.ResumeLayout(False)
        Me.T_B_Subfamilia.PerformLayout()
        Me.T_B_Familia.ResumeLayout(False)
        Me.T_B_Familia.PerformLayout()
        Me.G_Datos.ResumeLayout(False)
        Me.G_Datos.PerformLayout()
        Me.T_Proveedor.ResumeLayout(False)
        Me.T_Proveedor.PerformLayout()
        Me.T_Subfamilia.ResumeLayout(False)
        Me.T_Subfamilia.PerformLayout()
        Me.T_Familia.ResumeLayout(False)
        Me.T_Familia.PerformLayout()
        CType(Me.D_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_Eliminar.ResumeLayout(False)
        Me.G_Botones.ResumeLayout(False)
        Me.G_Lotes.ResumeLayout(False)
        Me.G_Lotes.PerformLayout()
        CType(Me.VP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_Codigo As ColumnHeader
    Friend WithEvents Col_Descripcion As ColumnHeader
    Friend WithEvents Col_Cod_Barras As ColumnHeader
    Friend WithEvents Col_Importe_Venta As ColumnHeader
    Friend WithEvents Col_Importe_Compra As ColumnHeader
    Friend WithEvents Col_Stock As ColumnHeader
    Friend WithEvents Col_Venidos As ColumnHeader
    Friend WithEvents Col_Compra As ColumnHeader
    Friend WithEvents Col_Stock_Inicial As ColumnHeader
    Friend WithEvents G_Controles As GroupBox
    Friend WithEvents Borrar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents G_Busqueda As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents B_Descripcion As TextBox
    Friend WithEvents B_Codigo As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Col_Fecha As ColumnHeader
    Friend WithEvents G_Datos As GroupBox
    Friend WithEvents Generar_CB As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents D_Descripcion As Controles.CuadroTexto
    Friend WithEvents D_Codigo As Controles.CuadroTexto
    Friend WithEvents Label6 As Label
    Friend WithEvents D_Importe_Venta As Controles.CuadroTexto
    Friend WithEvents Label7 As Label
    Friend WithEvents D_Importe_Compra As Controles.CuadroTexto
    Friend WithEvents D_Imagen As PictureBox
    Friend WithEvents O_DLG As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents D_Stock_Inicial As Controles.CuadroTexto
    Friend WithEvents D_Fecha As DateTimePicker
    Friend WithEvents VP As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents T_Familia As ToolStrip
    Public WithEvents D_Familia As ToolStripDropDownButton
    Friend WithEvents Label12 As Label
    Friend WithEvents T_Proveedor As ToolStrip
    Public WithEvents D_Proveedor As ToolStripDropDownButton
    Friend WithEvents Label11 As Label
    Friend WithEvents T_Subfamilia As ToolStrip
    Public WithEvents D_Subfamilia As ToolStripDropDownButton
    Friend WithEvents Limpiar_Filtros As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents T_B_Proveedor As ToolStrip
    Public WithEvents B_Proveedor As ToolStripDropDownButton
    Friend WithEvents Label14 As Label
    Friend WithEvents T_B_Subfamilia As ToolStrip
    Public WithEvents B_Subfamilia As ToolStripDropDownButton
    Friend WithEvents Label13 As Label
    Friend WithEvents T_B_Familia As ToolStrip
    Public WithEvents B_Familia As ToolStripDropDownButton
    Friend WithEvents Col_Familia As ColumnHeader
    Friend WithEvents Col_Subfamilia As ColumnHeader
    Friend WithEvents Col_Proveedor As ColumnHeader
    Friend WithEvents G_Botones As GroupBox
    Friend WithEvents B_Lotes As Button
    Friend WithEvents G_Lotes As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Resta As CheckBox
    Friend WithEvents Suma As CheckBox
    Friend WithEvents D_Valor As Controles.CuadroTexto
    Friend WithEvents Cancelar_Lotes As Button
    Friend WithEvents Aceptar_Lotes As Button
    Friend WithEvents P_Venta As CheckBox
    Friend WithEvents P_Compra As CheckBox
    Friend WithEvents O_Valor As CheckBox
    Friend WithEvents O_Division As CheckBox
    Friend WithEvents O_Multiplicacion As CheckBox
    Friend WithEvents O_Suma As CheckBox
    Friend WithEvents O_Porcentaje As CheckBox
    Friend WithEvents Codigo_Barras As Button
    Friend WithEvents Col_Stock_Minimo As ColumnHeader
    Friend WithEvents Label17 As Label
    Friend WithEvents D_Stock_Minimo As Controles.CuadroTexto
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents mnu_Eliminar As ContextMenuStrip
    Friend WithEvents TMnu_Eliminar As ToolStripMenuItem
    Friend WithEvents D_Codigo_Barras As TextBox
End Class
