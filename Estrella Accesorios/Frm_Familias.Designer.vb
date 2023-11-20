<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Familias
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
        Me.Datos_FAM = New System.Windows.Forms.GroupBox()
        Me.D_Descripcion_FAM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Listado_FAM = New System.Windows.Forms.ListView()
        Me.Col_Codigo_Fam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion_Fam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Botones_FAM = New System.Windows.Forms.GroupBox()
        Me.Datos_SFA = New System.Windows.Forms.GroupBox()
        Me.D_Descripcion_SFA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Listado_SFA = New System.Windows.Forms.ListView()
        Me.Col_Codigo_SFA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Descripcion_SFA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Botones_SFA = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Borrar_SFA = New System.Windows.Forms.Button()
        Me.Modificar_SFA = New System.Windows.Forms.Button()
        Me.Cancelar_SFA = New System.Windows.Forms.Button()
        Me.Agregar_SFA = New System.Windows.Forms.Button()
        Me.Borrar_FAM = New System.Windows.Forms.Button()
        Me.Modificar_FAM = New System.Windows.Forms.Button()
        Me.Cancelar_FAM = New System.Windows.Forms.Button()
        Me.Agregar_FAM = New System.Windows.Forms.Button()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.Datos_FAM.SuspendLayout()
        Me.Botones_FAM.SuspendLayout()
        Me.Datos_SFA.SuspendLayout()
        Me.Botones_SFA.SuspendLayout()
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
        Me.Cerrar_Frm.Location = New System.Drawing.Point(549, 5)
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
        Me.Titulo_Frm.Size = New System.Drawing.Size(390, 23)
        Me.Titulo_Frm.TabIndex = 24
        Me.Titulo_Frm.Text = "  Estrella Accesorios - FAMILIAS DE ARTICULOS"
        Me.Titulo_Frm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cuadro_Frm
        '
        Me.Cuadro_Frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cuadro_Frm.ForeColor = System.Drawing.Color.DimGray
        Me.Cuadro_Frm.Location = New System.Drawing.Point(516, 5)
        Me.Cuadro_Frm.Name = "Cuadro_Frm"
        Me.Cuadro_Frm.Size = New System.Drawing.Size(24, 18)
        Me.Cuadro_Frm.TabIndex = 29
        Me.Cuadro_Frm.TabStop = False
        '
        'Datos_FAM
        '
        Me.Datos_FAM.Controls.Add(Me.D_Descripcion_FAM)
        Me.Datos_FAM.Controls.Add(Me.Label5)
        Me.Datos_FAM.Enabled = False
        Me.Datos_FAM.Location = New System.Drawing.Point(2, 413)
        Me.Datos_FAM.Name = "Datos_FAM"
        Me.Datos_FAM.Size = New System.Drawing.Size(404, 41)
        Me.Datos_FAM.TabIndex = 32
        Me.Datos_FAM.TabStop = False
        '
        'D_Descripcion_FAM
        '
        Me.D_Descripcion_FAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.D_Descripcion_FAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.D_Descripcion_FAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Descripcion_FAM.Location = New System.Drawing.Point(97, 13)
        Me.D_Descripcion_FAM.MaxLength = 60
        Me.D_Descripcion_FAM.Name = "D_Descripcion_FAM"
        Me.D_Descripcion_FAM.Size = New System.Drawing.Size(280, 20)
        Me.D_Descripcion_FAM.TabIndex = 5
        Me.D_Descripcion_FAM.Text = "KKKKKKKK"
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
        'Listado_FAM
        '
        Me.Listado_FAM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Codigo_Fam, Me.Col_Descripcion_Fam})
        Me.Listado_FAM.FullRowSelect = True
        Me.Listado_FAM.GridLines = True
        Me.Listado_FAM.HideSelection = False
        Me.Listado_FAM.Location = New System.Drawing.Point(2, 152)
        Me.Listado_FAM.MultiSelect = False
        Me.Listado_FAM.Name = "Listado_FAM"
        Me.Listado_FAM.Size = New System.Drawing.Size(404, 261)
        Me.Listado_FAM.TabIndex = 30
        Me.Listado_FAM.UseCompatibleStateImageBehavior = False
        Me.Listado_FAM.View = System.Windows.Forms.View.Details
        '
        'Col_Codigo_Fam
        '
        Me.Col_Codigo_Fam.Tag = "N"
        Me.Col_Codigo_Fam.Text = "Código"
        Me.Col_Codigo_Fam.Width = 61
        '
        'Col_Descripcion_Fam
        '
        Me.Col_Descripcion_Fam.Text = "Descripción"
        Me.Col_Descripcion_Fam.Width = 314
        '
        'Botones_FAM
        '
        Me.Botones_FAM.Controls.Add(Me.Borrar_FAM)
        Me.Botones_FAM.Controls.Add(Me.Modificar_FAM)
        Me.Botones_FAM.Controls.Add(Me.Cancelar_FAM)
        Me.Botones_FAM.Controls.Add(Me.Agregar_FAM)
        Me.Botones_FAM.Location = New System.Drawing.Point(2, 32)
        Me.Botones_FAM.Name = "Botones_FAM"
        Me.Botones_FAM.Size = New System.Drawing.Size(404, 114)
        Me.Botones_FAM.TabIndex = 31
        Me.Botones_FAM.TabStop = False
        '
        'Datos_SFA
        '
        Me.Datos_SFA.Controls.Add(Me.D_Descripcion_SFA)
        Me.Datos_SFA.Controls.Add(Me.Label1)
        Me.Datos_SFA.Enabled = False
        Me.Datos_SFA.Location = New System.Drawing.Point(412, 413)
        Me.Datos_SFA.Name = "Datos_SFA"
        Me.Datos_SFA.Size = New System.Drawing.Size(404, 41)
        Me.Datos_SFA.TabIndex = 35
        Me.Datos_SFA.TabStop = False
        '
        'D_Descripcion_SFA
        '
        Me.D_Descripcion_SFA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.D_Descripcion_SFA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.D_Descripcion_SFA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.D_Descripcion_SFA.Location = New System.Drawing.Point(97, 13)
        Me.D_Descripcion_SFA.MaxLength = 60
        Me.D_Descripcion_SFA.Name = "D_Descripcion_SFA"
        Me.D_Descripcion_SFA.Size = New System.Drawing.Size(280, 20)
        Me.D_Descripcion_SFA.TabIndex = 5
        Me.D_Descripcion_SFA.Text = "KKKKKKKK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Descripción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Listado_SFA
        '
        Me.Listado_SFA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Codigo_SFA, Me.Col_Descripcion_SFA})
        Me.Listado_SFA.Enabled = False
        Me.Listado_SFA.FullRowSelect = True
        Me.Listado_SFA.GridLines = True
        Me.Listado_SFA.HideSelection = False
        Me.Listado_SFA.Location = New System.Drawing.Point(412, 152)
        Me.Listado_SFA.MultiSelect = False
        Me.Listado_SFA.Name = "Listado_SFA"
        Me.Listado_SFA.Size = New System.Drawing.Size(404, 261)
        Me.Listado_SFA.TabIndex = 33
        Me.Listado_SFA.UseCompatibleStateImageBehavior = False
        Me.Listado_SFA.View = System.Windows.Forms.View.Details
        '
        'Col_Codigo_SFA
        '
        Me.Col_Codigo_SFA.Tag = "N"
        Me.Col_Codigo_SFA.Text = "Código"
        Me.Col_Codigo_SFA.Width = 61
        '
        'Col_Descripcion_SFA
        '
        Me.Col_Descripcion_SFA.Text = "Descripción"
        Me.Col_Descripcion_SFA.Width = 314
        '
        'Botones_SFA
        '
        Me.Botones_SFA.Controls.Add(Me.Borrar_SFA)
        Me.Botones_SFA.Controls.Add(Me.Modificar_SFA)
        Me.Botones_SFA.Controls.Add(Me.Cancelar_SFA)
        Me.Botones_SFA.Controls.Add(Me.Agregar_SFA)
        Me.Botones_SFA.Enabled = False
        Me.Botones_SFA.Location = New System.Drawing.Point(412, 32)
        Me.Botones_SFA.Name = "Botones_SFA"
        Me.Botones_SFA.Size = New System.Drawing.Size(404, 114)
        Me.Botones_SFA.TabIndex = 34
        Me.Botones_SFA.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "  FAMILIAS  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(550, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "  SUB-FAMILIAS  "
        '
        'Borrar_SFA
        '
        Me.Borrar_SFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Borrar_SFA.Enabled = False
        Me.Borrar_SFA.FlatAppearance.BorderSize = 0
        Me.Borrar_SFA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Borrar_SFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Borrar_SFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar_SFA.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_64
        Me.Borrar_SFA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Borrar_SFA.Location = New System.Drawing.Point(203, 13)
        Me.Borrar_SFA.Name = "Borrar_SFA"
        Me.Borrar_SFA.Size = New System.Drawing.Size(97, 95)
        Me.Borrar_SFA.TabIndex = 2
        Me.Borrar_SFA.Text = "Borrar"
        Me.Borrar_SFA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Borrar_SFA.UseVisualStyleBackColor = True
        '
        'Modificar_SFA
        '
        Me.Modificar_SFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar_SFA.Enabled = False
        Me.Modificar_SFA.FlatAppearance.BorderSize = 0
        Me.Modificar_SFA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Modificar_SFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar_SFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar_SFA.Image = Global.Estrella_Accesorios.My.Resources.Resources.Editar_72
        Me.Modificar_SFA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Modificar_SFA.Location = New System.Drawing.Point(104, 13)
        Me.Modificar_SFA.Name = "Modificar_SFA"
        Me.Modificar_SFA.Size = New System.Drawing.Size(97, 95)
        Me.Modificar_SFA.TabIndex = 1
        Me.Modificar_SFA.Text = "Modificar"
        Me.Modificar_SFA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modificar_SFA.UseVisualStyleBackColor = True
        '
        'Cancelar_SFA
        '
        Me.Cancelar_SFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_SFA.FlatAppearance.BorderSize = 0
        Me.Cancelar_SFA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Cancelar_SFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_SFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_SFA.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar_64
        Me.Cancelar_SFA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar_SFA.Location = New System.Drawing.Point(302, 13)
        Me.Cancelar_SFA.Name = "Cancelar_SFA"
        Me.Cancelar_SFA.Size = New System.Drawing.Size(97, 95)
        Me.Cancelar_SFA.TabIndex = 3
        Me.Cancelar_SFA.Text = "Cancelar"
        Me.Cancelar_SFA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_SFA.UseVisualStyleBackColor = True
        '
        'Agregar_SFA
        '
        Me.Agregar_SFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar_SFA.FlatAppearance.BorderSize = 0
        Me.Agregar_SFA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Agregar_SFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_SFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_SFA.Image = Global.Estrella_Accesorios.My.Resources.Resources.Agregar_64
        Me.Agregar_SFA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Agregar_SFA.Location = New System.Drawing.Point(5, 13)
        Me.Agregar_SFA.Name = "Agregar_SFA"
        Me.Agregar_SFA.Size = New System.Drawing.Size(97, 95)
        Me.Agregar_SFA.TabIndex = 0
        Me.Agregar_SFA.Text = "Agregar"
        Me.Agregar_SFA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Agregar_SFA.UseVisualStyleBackColor = True
        '
        'Borrar_FAM
        '
        Me.Borrar_FAM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Borrar_FAM.Enabled = False
        Me.Borrar_FAM.FlatAppearance.BorderSize = 0
        Me.Borrar_FAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Borrar_FAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Borrar_FAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar_FAM.Image = Global.Estrella_Accesorios.My.Resources.Resources.Borrar_1_64
        Me.Borrar_FAM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Borrar_FAM.Location = New System.Drawing.Point(203, 13)
        Me.Borrar_FAM.Name = "Borrar_FAM"
        Me.Borrar_FAM.Size = New System.Drawing.Size(97, 95)
        Me.Borrar_FAM.TabIndex = 2
        Me.Borrar_FAM.Text = "Borrar"
        Me.Borrar_FAM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Borrar_FAM.UseVisualStyleBackColor = True
        '
        'Modificar_FAM
        '
        Me.Modificar_FAM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar_FAM.Enabled = False
        Me.Modificar_FAM.FlatAppearance.BorderSize = 0
        Me.Modificar_FAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Modificar_FAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar_FAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar_FAM.Image = Global.Estrella_Accesorios.My.Resources.Resources.Editar_72
        Me.Modificar_FAM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Modificar_FAM.Location = New System.Drawing.Point(104, 13)
        Me.Modificar_FAM.Name = "Modificar_FAM"
        Me.Modificar_FAM.Size = New System.Drawing.Size(97, 95)
        Me.Modificar_FAM.TabIndex = 1
        Me.Modificar_FAM.Text = "Modificar"
        Me.Modificar_FAM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modificar_FAM.UseVisualStyleBackColor = True
        '
        'Cancelar_FAM
        '
        Me.Cancelar_FAM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_FAM.FlatAppearance.BorderSize = 0
        Me.Cancelar_FAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Cancelar_FAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_FAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_FAM.Image = Global.Estrella_Accesorios.My.Resources.Resources.Cancelar_64
        Me.Cancelar_FAM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancelar_FAM.Location = New System.Drawing.Point(302, 13)
        Me.Cancelar_FAM.Name = "Cancelar_FAM"
        Me.Cancelar_FAM.Size = New System.Drawing.Size(97, 95)
        Me.Cancelar_FAM.TabIndex = 3
        Me.Cancelar_FAM.Text = "Cancelar"
        Me.Cancelar_FAM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar_FAM.UseVisualStyleBackColor = True
        '
        'Agregar_FAM
        '
        Me.Agregar_FAM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar_FAM.FlatAppearance.BorderSize = 0
        Me.Agregar_FAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Agregar_FAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_FAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_FAM.Image = Global.Estrella_Accesorios.My.Resources.Resources.Agregar_64
        Me.Agregar_FAM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Agregar_FAM.Location = New System.Drawing.Point(5, 13)
        Me.Agregar_FAM.Name = "Agregar_FAM"
        Me.Agregar_FAM.Size = New System.Drawing.Size(97, 95)
        Me.Agregar_FAM.TabIndex = 0
        Me.Agregar_FAM.Text = "Agregar"
        Me.Agregar_FAM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Agregar_FAM.UseVisualStyleBackColor = True
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
        'Frm_Familias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 459)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Datos_SFA)
        Me.Controls.Add(Me.Listado_SFA)
        Me.Controls.Add(Me.Botones_SFA)
        Me.Controls.Add(Me.Datos_FAM)
        Me.Controls.Add(Me.Listado_FAM)
        Me.Controls.Add(Me.Botones_FAM)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Familias"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Datos_FAM.ResumeLayout(False)
        Me.Datos_FAM.PerformLayout()
        Me.Botones_FAM.ResumeLayout(False)
        Me.Datos_SFA.ResumeLayout(False)
        Me.Datos_SFA.PerformLayout()
        Me.Botones_SFA.ResumeLayout(False)
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
    Friend WithEvents Cerrar_Frm As Button
    Friend WithEvents Titulo_Frm As Label
    Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents Datos_FAM As GroupBox
    Friend WithEvents D_Descripcion_FAM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Listado_FAM As ListView
    Friend WithEvents Col_Codigo_Fam As ColumnHeader
    Friend WithEvents Col_Descripcion_Fam As ColumnHeader
    Friend WithEvents Botones_FAM As GroupBox
    Friend WithEvents Borrar_FAM As Button
    Friend WithEvents Modificar_FAM As Button
    Friend WithEvents Cancelar_FAM As Button
    Friend WithEvents Agregar_FAM As Button
    Friend WithEvents Datos_SFA As GroupBox
    Friend WithEvents D_Descripcion_SFA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Listado_SFA As ListView
    Friend WithEvents Col_Codigo_SFA As ColumnHeader
    Friend WithEvents Col_Descripcion_SFA As ColumnHeader
    Friend WithEvents Botones_SFA As GroupBox
    Friend WithEvents Borrar_SFA As Button
    Friend WithEvents Modificar_SFA As Button
    Friend WithEvents Cancelar_SFA As Button
    Friend WithEvents Agregar_SFA As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
