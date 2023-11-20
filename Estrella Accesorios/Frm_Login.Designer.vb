<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Cerrar_Frm = New System.Windows.Forms.Button()
        Me.Titulo_Frm = New System.Windows.Forms.Label()
        Me.Cuadro_Frm = New System.Windows.Forms.GroupBox()
        Me.T_Usuario = New System.Windows.Forms.ToolStrip()
        Me.D_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Ajustes = New System.Windows.Forms.Button()
        Me.D_Usuario = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Imagen_Frm = New System.Windows.Forms.PictureBox()
        Me.T_Usuario.SuspendLayout()
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
        Me.Titulo_Frm.Text = "  Estrella Accesorios - LOGIN"
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
        'T_Usuario
        '
        Me.T_Usuario.AutoSize = False
        Me.T_Usuario.Dock = System.Windows.Forms.DockStyle.None
        Me.T_Usuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.T_Usuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D_Usuario})
        Me.T_Usuario.Location = New System.Drawing.Point(165, 56)
        Me.T_Usuario.Name = "T_Usuario"
        Me.T_Usuario.Size = New System.Drawing.Size(233, 25)
        Me.T_Usuario.TabIndex = 94
        Me.T_Usuario.Tag = ""
        '
        'D_Password
        '
        Me.D_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Password.Location = New System.Drawing.Point(165, 97)
        Me.D_Password.MaxLength = 30
        Me.D_Password.Name = "D_Password"
        Me.D_Password.Size = New System.Drawing.Size(233, 22)
        Me.D_Password.TabIndex = 95
        Me.D_Password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Contraseña:"
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
        Me.Aceptar.Location = New System.Drawing.Point(296, 125)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(102, 64)
        Me.Aceptar.TabIndex = 24
        Me.Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aceptar.UseVisualStyleBackColor = True
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
        Me.Cancelar.Location = New System.Drawing.Point(165, 125)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(102, 64)
        Me.Cancelar.TabIndex = 25
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Ajustes
        '
        Me.Ajustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajustes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Ajustes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ajustes.FlatAppearance.BorderSize = 0
        Me.Ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ajustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ajustes.Image = Global.Estrella_Accesorios.My.Resources.Resources.Ajustes_48
        Me.Ajustes.Location = New System.Drawing.Point(12, 132)
        Me.Ajustes.Name = "Ajustes"
        Me.Ajustes.Size = New System.Drawing.Size(90, 57)
        Me.Ajustes.TabIndex = 98
        Me.Ajustes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ajustes.UseVisualStyleBackColor = True
        '
        'D_Usuario
        '
        Me.D_Usuario.AutoSize = False
        Me.D_Usuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.D_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Usuario.ForeColor = System.Drawing.Color.Black
        Me.D_Usuario.Image = CType(resources.GetObject("D_Usuario.Image"), System.Drawing.Image)
        Me.D_Usuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.D_Usuario.Name = "D_Usuario"
        Me.D_Usuario.Size = New System.Drawing.Size(230, 22)
        Me.D_Usuario.Tag = "0"
        Me.D_Usuario.Text = "*** SELECCIONE USUARIO ***"
        Me.D_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.D_Usuario.ToolTipText = "Seleccione el tipo de comprobante"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estrella_Accesorios.My.Resources.Resources.Candado
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
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
        'Frm_Login
        '
        Me.AcceptButton = Me.Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(410, 196)
        Me.Controls.Add(Me.Ajustes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.D_Password)
        Me.Controls.Add(Me.T_Usuario)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Imagen_Frm)
        Me.Controls.Add(Me.Cerrar_Frm)
        Me.Controls.Add(Me.Titulo_Frm)
        Me.Controls.Add(Me.Cuadro_Frm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.T_Usuario.ResumeLayout(False)
        Me.T_Usuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen_Frm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagen_Frm As PictureBox
	Friend WithEvents Cerrar_Frm As Button
	Friend WithEvents Titulo_Frm As Label
	Friend WithEvents Cuadro_Frm As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents T_Usuario As ToolStrip
    Public WithEvents D_Usuario As ToolStripDropDownButton
    Friend WithEvents D_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ajustes As Button
End Class
