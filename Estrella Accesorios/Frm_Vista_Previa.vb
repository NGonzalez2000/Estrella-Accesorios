Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Vista_Previa
    Dim ex As Int16
    Dim ey As Int16
    Dim Arrastre As Boolean

    Private L_Reporte As ReportDocument
    Private L_Filtro As String
    Private L_Parametro1 As Object
    Private L_Parametro2 As Object
    Private L_Parametro3 As Object
    Private L_Parametro4 As Object
    Private L_DatabaseName As String
    Private L_UserID As String
    Private L_Password As String
    Private L_ServerName As String


    ' Constructores
    Public Sub Mostrar(Reporte As ReportDocument, DatabaseName As String, UserID As String, Password As String, ServerName As String, Optional Filtro As String = "", Optional Parametro1 As Object = Nothing, Optional Parametro2 As Object = Nothing, Optional Parametro3 As Object = Nothing, Optional Parametro4 As Object = Nothing)
        UseWaitCursor = True
        Cursor = Cursors.WaitCursor

        L_Reporte = Reporte
        L_Filtro = Filtro
        L_Parametro1 = Parametro1
        L_Parametro2 = Parametro2
        L_Parametro3 = Parametro3
        L_Parametro4 = Parametro4
        L_DatabaseName = DatabaseName
        L_UserID = UserID
        L_Password = Password
        L_ServerName = ServerName

        ConfigureCrystalReports()

        Cursor = Cursors.Default
        UseWaitCursor = False

        Me.ShowDialog()
    End Sub

    Private Sub ConfigureCrystalReports()
        Dim MyConnectionInfo As ConnectionInfo = New ConnectionInfo()

        If L_DatabaseName <> "" Then MyConnectionInfo.DatabaseName = L_DatabaseName
        If L_UserID <> "" Then MyConnectionInfo.UserID = L_UserID
        If L_Password <> "" Then MyConnectionInfo.Password = L_Password
        If L_ServerName <> "" Then MyConnectionInfo.ServerName = L_ServerName

        'Reporte = New Rpt_Etiquetas ' ReportDocument()
        'Dim ReportePath As String = Application.StartupPath + "\" + Archivo_Rpt
        'Dim ReportePath As String = Archivo_Rpt
        'Reporte.Load(ReportePath)

        If L_Filtro.Trim <> "" Then
            L_Reporte.RecordSelectionFormula = L_Filtro.Trim
        End If

        If Not L_Parametro1 Is Nothing Then
            Dim currentParameterValues As ParameterValues = New ParameterValues()
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = L_Parametro1
                }
            currentParameterValues.Add(myParameterDiscreteValue)

            Dim myParameterFieldDefinitions As ParameterFieldDefinitions = L_Reporte.DataDefinition.ParameterFields
            Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(0)
            myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
        End If

        If Not L_Parametro2 Is Nothing Then
            Dim currentParameterValues As ParameterValues = New ParameterValues()
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = L_Parametro2
                }
            currentParameterValues.Add(myParameterDiscreteValue)

            Dim myParameterFieldDefinitions As ParameterFieldDefinitions = L_Reporte.DataDefinition.ParameterFields
            Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(1)
            myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
        End If

        If Not L_Parametro3 Is Nothing Then
            Dim currentParameterValues As ParameterValues = New ParameterValues()
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = L_Parametro3
                }
            currentParameterValues.Add(myParameterDiscreteValue)

            Dim myParameterFieldDefinitions As ParameterFieldDefinitions = L_Reporte.DataDefinition.ParameterFields
            Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(2)
            myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
        End If

        If Not L_Parametro4 Is Nothing Then
            Dim currentParameterValues As ParameterValues = New ParameterValues()
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = L_Parametro4
                }
            currentParameterValues.Add(myParameterDiscreteValue)

            Dim myParameterFieldDefinitions As ParameterFieldDefinitions = L_Reporte.DataDefinition.ParameterFields
            Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(3)
            myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
        End If

        CRV.ReportSource = L_Reporte
        SetDBLogonForReport(MyConnectionInfo, L_Reporte)
        CRV.Zoom(100)
    End Sub

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
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

    Private Sub Frm_Vista_Previa_Load(sender As Object, e As EventArgs) Handles Me.Load
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
End Class