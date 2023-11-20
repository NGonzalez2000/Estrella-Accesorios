Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Crystal_Report
    Public Enum Tipos_Salidas
        Impresora
        Archivo
    End Enum

    Private Reporte As ReportDocument

    Public Overridable Function Reportes_Crystal(ByVal Archivo_CRP As String, ByVal Filtro_Sql As String, ByVal Destino As Tipos_Salidas, ByVal Optional Archivo_PDF As String = "", ByVal Optional Parametro1 As Object = Nothing, ByVal Optional Parametro2 As Object = Nothing, ByVal Optional Parametro3 As Object = Nothing, ByVal Optional Parametro4 As Object = Nothing) As Boolean
        Reporte = New ReportDocument()

        Reporte.Load(Archivo_CRP)

        Try
            If Filtro_Sql <> "" Then
                Reporte.RecordSelectionFormula = Filtro_Sql
            End If

            If Not Parametro1 Is Nothing Then
                Dim currentParameterValues As ParameterValues = New ParameterValues()
                Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = Parametro1
                }
                currentParameterValues.Add(myParameterDiscreteValue)

                Dim myParameterFieldDefinitions As ParameterFieldDefinitions = Reporte.DataDefinition.ParameterFields
                Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(0)
                myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
            End If

            If Not Parametro2 Is Nothing Then
                Dim currentParameterValues As ParameterValues = New ParameterValues()
                Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = Parametro2
                }
                currentParameterValues.Add(myParameterDiscreteValue)

                Dim myParameterFieldDefinitions As ParameterFieldDefinitions = Reporte.DataDefinition.ParameterFields
                Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(1)
                myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
            End If

            If Not Parametro3 Is Nothing Then
                Dim currentParameterValues As ParameterValues = New ParameterValues()
                Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = Parametro3
                }
                currentParameterValues.Add(myParameterDiscreteValue)

                Dim myParameterFieldDefinitions As ParameterFieldDefinitions = Reporte.DataDefinition.ParameterFields
                Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(2)
                myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
            End If

            If Not Parametro4 Is Nothing Then
                Dim currentParameterValues As ParameterValues = New ParameterValues()
                Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue With {
                    .Value = Parametro4
                }
                currentParameterValues.Add(myParameterDiscreteValue)

                Dim myParameterFieldDefinitions As ParameterFieldDefinitions = Reporte.DataDefinition.ParameterFields
                Dim myParameterFieldDefinition As ParameterFieldDefinition = myParameterFieldDefinitions(3)
                myParameterFieldDefinition.ApplyCurrentValues(currentParameterValues)
            End If

            If Destino = Tipos_Salidas.Impresora Then
                Reporte.PrintToPrinter(1, False, 0, 0)
            Else
                Reporte.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo_PDF)
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class