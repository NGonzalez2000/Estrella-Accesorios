<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Proveedores
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
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.D_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Listado = New System.Windows.Forms.ListView()
        Me.Col_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Botones = New System.Windows.Forms.GroupBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos.SuspendLayout()
        Me.Botones.SuspendLayout()
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios - PROVEEDORES"
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
        'Datos
        '
        Me.Datos.Controls.Add(Me.D_Descripcion)
        Me.Datos.Controls.Add(Me.Label5)
        Me.Datos.Location = New System.Drawing.Point(4, 394)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(550, 42)
        Me.Datos.TabIndex = 32
        Me.Datos.TabStop = False
        '
        'D_Descripcion
        '
        Me.D_Descripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.D_Descripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.D_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Descripcion.Location = New System.Drawing.Point(97, 13)
        Me.D_Descripcion.MaxLength = 60
        Me.D_Descripcion.Name = "D_Descripcion"
        Me.D_Descripcion.Size = New System.Drawing.Size(363, 20)
        Me.D_Descripcion.TabIndex = 5
        Me.D_Descripcion.Text = "KKKKKKKK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Descripción:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Listado
        '
        Me.Listado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Codigo, Me.Col_Descripcion})
        Me.Listado.FullRowSelect = True
        Me.Listado.GridLines = True
        Me.Listado.HideSelection = False
        Me.Listado.Location = New System.Drawing.Point(4, 133)
        Me.Listado.MultiSelect = False
        Me.Listado.Name = "Listado"
        Me.Listado.Size = New System.Drawing.Size(550, 261)
        Me.Listado.TabIndex = 30
        Me.Listado.UseCompatibleStateImageBehavior = False
        Me.Listado.View = System.Windows.Forms.View.Details
        '
        'Col_Codigo
        '
        Me.Col_Codigo.Tag = "N"
        Me.Col_Codigo.Text = "Código"
        Me.Col_Codigo.Width = 75
        '
        'Col_Descripcion
        '
        Me.Col_Descripcion.Text = "Descripción"
        Me.Col_Descripcion.Width = 446
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.Borrar)
        Me.Botones.Controls.Add(Me.Modificar)
        Me.Botones.Controls.Add(Me.Cancelar)
        Me.Botones.Controls.Add(Me.Agregar)
        Me.Botones.Location = New System.Drawing.Point(4, 20)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(550, 107)
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
        Me.Borrar.Location = New System.Drawing.Point(278, 13)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(130, 88)
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
        Me.Modificar.Location = New System.Drawing.Point(143, 13)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(130, 88)
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
        Me.Cancelar.Location = New System.Drawing.Point(413, 13)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(130, 88)
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
        Me.Agregar.Location = New System.Drawing.Point(8, 13)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(130, 88)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 439)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Listado)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Proveedores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_FORMA DE PAGO"
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        Me.Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Datos As GroupBox
    Friend WithEvents D_Descripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Listado As ListView
    Friend WithEvents Col_Codigo As ColumnHeader
    Friend WithEvents Col_Descripcion As ColumnHeader
    Friend WithEvents Botones As GroupBox
    Friend WithEvents Borrar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents Agregar As Button
End Class
