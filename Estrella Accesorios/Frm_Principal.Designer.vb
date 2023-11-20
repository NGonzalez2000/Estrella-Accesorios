<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.T_Opciones = New System.Windows.Forms.ToolStrip()
        Me.B_Opciones = New System.Windows.Forms.ToolStripDropDownButton()
        Me.B_Varios = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Exportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Importar = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Etiquetas_QR = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Etiquetas_Estantes = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Configuracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Forma_Pago = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Proveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Familias = New System.Windows.Forms.ToolStripMenuItem()
        Me.S_DLG = New System.Windows.Forms.SaveFileDialog()
        Me.O_DLG = New System.Windows.Forms.OpenFileDialog()
        Me.Ingresos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Estadisticas = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.Articulos = New System.Windows.Forms.Button()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.T_Opciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cerrar_Frm.Text = "_"
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios"
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
        'T_Opciones
        '
        Me.T_Opciones.AutoSize = False
        Me.T_Opciones.BackColor = System.Drawing.Color.Transparent
        Me.T_Opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.T_Opciones.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Opciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Opciones})
        Me.T_Opciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.T_Opciones.Location = New System.Drawing.Point(414, 251)
        Me.T_Opciones.Name = "T_Opciones"
        Me.T_Opciones.Padding = New System.Windows.Forms.Padding(0)
        Me.T_Opciones.Size = New System.Drawing.Size(401, 201)
        Me.T_Opciones.TabIndex = 95
        Me.T_Opciones.Tag = ""
        '
        'B_Opciones
        '
        Me.B_Opciones.AutoSize = False
        Me.B_Opciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_Opciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Varios, Me.B_Usuarios, Me.B_Forma_Pago, Me.B_Proveedores, Me.B_Familias})
        Me.B_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Opciones.Image = Global.Estrella_Accesorios.My.Resources.Resources.Engranajes
        Me.B_Opciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Opciones.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Opciones.Name = "B_Opciones"
        Me.B_Opciones.Size = New System.Drawing.Size(166, 166)
        Me.B_Opciones.Text = "Opciones"
        Me.B_Opciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'B_Varios
        '
        Me.B_Varios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Varios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Exportar, Me.B_Importar, Me.B_Etiquetas_QR, Me.B_Etiquetas_Estantes, Me.B_Configuracion})
        Me.B_Varios.ForeColor = System.Drawing.Color.White
        Me.B_Varios.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estrella
        Me.B_Varios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Varios.Name = "B_Varios"
        Me.B_Varios.Size = New System.Drawing.Size(249, 54)
        Me.B_Varios.Text = "Funciones Varias"
        '
        'B_Exportar
        '
        Me.B_Exportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Exportar.ForeColor = System.Drawing.Color.White
        Me.B_Exportar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Exportar_1_64
        Me.B_Exportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Exportar.Name = "B_Exportar"
        Me.B_Exportar.Size = New System.Drawing.Size(355, 70)
        Me.B_Exportar.Text = "Exportar Datos"
        '
        'B_Importar
        '
        Me.B_Importar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Importar.ForeColor = System.Drawing.Color.White
        Me.B_Importar.Image = Global.Estrella_Accesorios.My.Resources.Resources.Importar_1_64
        Me.B_Importar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Importar.Name = "B_Importar"
        Me.B_Importar.Size = New System.Drawing.Size(355, 70)
        Me.B_Importar.Text = "Importar Datos"
        '
        'B_Etiquetas_QR
        '
        Me.B_Etiquetas_QR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Etiquetas_QR.ForeColor = System.Drawing.Color.White
        Me.B_Etiquetas_QR.Image = Global.Estrella_Accesorios.My.Resources.Resources.Etiqueta_QR_64
        Me.B_Etiquetas_QR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Etiquetas_QR.Name = "B_Etiquetas_QR"
        Me.B_Etiquetas_QR.Size = New System.Drawing.Size(355, 70)
        Me.B_Etiquetas_QR.Text = "Etiquetas QR"
        '
        'B_Etiquetas_Estantes
        '
        Me.B_Etiquetas_Estantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Etiquetas_Estantes.ForeColor = System.Drawing.Color.White
        Me.B_Etiquetas_Estantes.Image = Global.Estrella_Accesorios.My.Resources.Resources.Etiqueta_Precio_64
        Me.B_Etiquetas_Estantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Etiquetas_Estantes.Name = "B_Etiquetas_Estantes"
        Me.B_Etiquetas_Estantes.Size = New System.Drawing.Size(355, 70)
        Me.B_Etiquetas_Estantes.Text = "Etiquetas P/Estanteria"
        '
        'B_Configuracion
        '
        Me.B_Configuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Configuracion.ForeColor = System.Drawing.Color.White
        Me.B_Configuracion.Image = Global.Estrella_Accesorios.My.Resources.Resources.Ajustes_64
        Me.B_Configuracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Configuracion.Name = "B_Configuracion"
        Me.B_Configuracion.Size = New System.Drawing.Size(355, 70)
        Me.B_Configuracion.Text = "Configuraciones del Sistema"
        '
        'B_Usuarios
        '
        Me.B_Usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Usuarios.ForeColor = System.Drawing.Color.White
        Me.B_Usuarios.Image = Global.Estrella_Accesorios.My.Resources.Resources.Usuario_48
        Me.B_Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Usuarios.Name = "B_Usuarios"
        Me.B_Usuarios.Size = New System.Drawing.Size(249, 54)
        Me.B_Usuarios.Text = "Usuarios"
        Me.B_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'B_Forma_Pago
        '
        Me.B_Forma_Pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Forma_Pago.ForeColor = System.Drawing.Color.White
        Me.B_Forma_Pago.Image = Global.Estrella_Accesorios.My.Resources.Resources.Forma_Pago
        Me.B_Forma_Pago.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Forma_Pago.Name = "B_Forma_Pago"
        Me.B_Forma_Pago.Size = New System.Drawing.Size(249, 54)
        Me.B_Forma_Pago.Text = "Formas de Pago"
        '
        'B_Proveedores
        '
        Me.B_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Proveedores.ForeColor = System.Drawing.Color.White
        Me.B_Proveedores.Image = Global.Estrella_Accesorios.My.Resources.Resources.Proveedor_48
        Me.B_Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Proveedores.Name = "B_Proveedores"
        Me.B_Proveedores.Size = New System.Drawing.Size(249, 54)
        Me.B_Proveedores.Text = "Proveedores"
        '
        'B_Familias
        '
        Me.B_Familias.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B_Familias.ForeColor = System.Drawing.Color.White
        Me.B_Familias.Image = Global.Estrella_Accesorios.My.Resources.Resources.Familias
        Me.B_Familias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.B_Familias.Name = "B_Familias"
        Me.B_Familias.Size = New System.Drawing.Size(249, 54)
        Me.B_Familias.Text = "Familias"
        '
        'O_DLG
        '
        Me.O_DLG.FileName = "OpenFileDialog1"
        '
        'Ingresos
        '
        Me.Ingresos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ingresos.FlatAppearance.BorderSize = 0
        Me.Ingresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Ingresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ingresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingresos.Image = Global.Estrella_Accesorios.My.Resources.Resources.Ingresos
        Me.Ingresos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ingresos.Location = New System.Drawing.Point(414, 59)
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Ingresos.Size = New System.Drawing.Size(166, 166)
        Me.Ingresos.TabIndex = 28
        Me.Ingresos.TabStop = False
        Me.Ingresos.Text = "Ingresos"
        Me.Ingresos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ingresos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estrella1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 266)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Salir
        '
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.FlatAppearance.BorderSize = 0
        Me.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Image = Global.Estrella_Accesorios.My.Resources.Resources.Apagar
        Me.Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Salir.Location = New System.Drawing.Point(608, 251)
        Me.Salir.Name = "Salir"
        Me.Salir.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Salir.Size = New System.Drawing.Size(166, 166)
        Me.Salir.TabIndex = 26
        Me.Salir.TabStop = False
        Me.Salir.Text = "Salir del Sistema..."
        Me.Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Estadisticas
        '
        Me.Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Estadisticas.FlatAppearance.BorderSize = 0
        Me.Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Estadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estadisticas.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estadisticas_128
        Me.Estadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Estadisticas.Location = New System.Drawing.Point(608, 59)
        Me.Estadisticas.Name = "Estadisticas"
        Me.Estadisticas.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Estadisticas.Size = New System.Drawing.Size(166, 166)
        Me.Estadisticas.TabIndex = 25
        Me.Estadisticas.TabStop = False
        Me.Estadisticas.Text = "Estadisticas"
        Me.Estadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Estadisticas.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ventas.FlatAppearance.BorderSize = 0
        Me.Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.Image = Global.Estrella_Accesorios.My.Resources.Resources.Carrito
        Me.Ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ventas.Location = New System.Drawing.Point(221, 59)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Ventas.Size = New System.Drawing.Size(166, 166)
        Me.Ventas.TabIndex = 24
        Me.Ventas.TabStop = False
        Me.Ventas.Text = "Ventas"
        Me.Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Articulos
        '
        Me.Articulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Articulos.FlatAppearance.BorderSize = 0
        Me.Articulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulos.Image = Global.Estrella_Accesorios.My.Resources.Resources.Estralla_Diamante
        Me.Articulos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Articulos.Location = New System.Drawing.Point(29, 59)
        Me.Articulos.Name = "Articulos"
        Me.Articulos.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Articulos.Size = New System.Drawing.Size(166, 166)
        Me.Articulos.TabIndex = 23
        Me.Articulos.TabStop = False
        Me.Articulos.Text = "Artículos"
        Me.Articulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Articulos.UseVisualStyleBackColor = True
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
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(815, 452)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.Controls.Add(Me.Ingresos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Estadisticas)
        Me.Controls.Add(Me.Ventas)
        Me.Controls.Add(Me.Articulos)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.T_Opciones)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.T_Opciones.ResumeLayout(False)
        Me.T_Opciones.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Articulos As Button
    Friend WithEvents Ventas As Button
    Friend WithEvents Estadisticas As Button
    Friend WithEvents Salir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Ingresos As Button
    Friend WithEvents T_Opciones As ToolStrip
    Friend WithEvents B_Opciones As ToolStripDropDownButton
    Friend WithEvents B_Usuarios As ToolStripMenuItem
    Friend WithEvents B_Forma_Pago As ToolStripMenuItem
    Friend WithEvents B_Proveedores As ToolStripMenuItem
    Friend WithEvents B_Familias As ToolStripMenuItem
    Friend WithEvents B_Varios As ToolStripMenuItem
    Friend WithEvents S_DLG As SaveFileDialog
    Friend WithEvents O_DLG As OpenFileDialog
    Friend WithEvents B_Exportar As ToolStripMenuItem
    Friend WithEvents B_Importar As ToolStripMenuItem
    Friend WithEvents B_Etiquetas_QR As ToolStripMenuItem
    Friend WithEvents B_Etiquetas_Estantes As ToolStripMenuItem
    Friend WithEvents B_Configuracion As ToolStripMenuItem
End Class
