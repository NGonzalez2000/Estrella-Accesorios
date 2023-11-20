Public Class Frm_Base
	Dim ex As Int16
	Dim ey As Int16
	Dim Arrastre As Boolean

	Private Sub Frm_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UseWaitCursor = True
		Cursor = Cursors.WaitCursor

		Me.Text = Titulo_Frm.Text
		Cuadro_Frm.SetBounds(0, -6, Me.Width, Me.Height + 7)
		Cuadro_Frm.SendToBack()
		Imagen_Frm.Location = New Point(3, 3)
		Titulo_Frm.SetBounds(28, 3, Me.Width - 75, Titulo_Frm.Height)
		Cerrar_Frm.Location = New Point(Me.Width - 43, 3)

		Cursor = Cursors.Default
		UseWaitCursor = False
	End Sub

	Private Sub Cerrar_Frm_Click(sender As Object, e As EventArgs) Handles Cerrar_Frm.Click
		Close()
	End Sub

	Private Sub Titulo_Frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseMove
		If Arrastre Then
			Me.Location = New Point(Me.Location.X + e.X - ex, Me.Location.Y + e.Y - ey)
		End If
	End Sub

	Private Sub Titulo_Frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseDown
		ex = e.X
		ey = e.Y
		Arrastre = True
	End Sub

	Private Sub Titulo_Frm_MouseUp(sender As Object, e As MouseEventArgs) Handles Titulo_Frm.MouseUp
		Arrastre = False
	End Sub
End Class