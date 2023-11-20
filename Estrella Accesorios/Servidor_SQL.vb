Imports System.Data.OleDb '.SqlClient
Imports System.Data.OleDb.OleDbConnection '  .SqlClient.SqlConnection
Imports System.Data.OleDb.OleDbCommand '.SqlClient.SqlCommand

Public Class Servidor_SQL
    Private ReadOnly Conexion As New OleDbConnection
    Private v_Conectado As Boolean = False
    Private v_CadenaCNX As String

    Public ReadOnly Property Conectado() As Boolean
        Get
            Return v_Conectado
        End Get
    End Property

    Public Function Conectar(CadenaCNX As String) As Boolean
        Try
            v_CadenaCNX = CadenaCNX
            Conexion.ConnectionString = CadenaCNX
            Conexion.Open()
            v_Conectado = True
            Return True
        Catch Exc As Exception
            MsgBox(Exc.Message)
            v_Conectado = False
            Return False
        End Try
    End Function

    Public Function Cerrar_Conexion() As Boolean
        Try
            Conexion.Close()
            v_Conectado = False
            Return True
        Catch Exc As Exception
            MsgBox(Exc.Message)
            v_Conectado = False
            Return False
        End Try
    End Function

    'Función para Agregar, Modificar, Eliminar, Backup (Ejecuta Cualquier consulta SQL sin devolver datos
    Public Overloads Function Ejecutar_SQL(ByVal SQL As String) As Boolean
        Dim Comandos As New OleDbCommand

        If Not v_Conectado Then
            If Trim(v_CadenaCNX) <> "" Then
                If Not Conectar(v_CadenaCNX) Then
                    MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                    Return False
                    Exit Function
                End If
            Else
                MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                Return False
                Exit Function
            End If
        End If

        Try
            Comandos.Connection = Conexion
            Comandos.CommandText = SQL
            Comandos.ExecuteScalar()

            Return True

        Catch Exc As Exception
            MsgBox(Exc.Message)
            Return False
        End Try
    End Function

    'Funcion para Consultas (SELECT)
    Public Overloads Function Ejecutar_SQL(ByVal SQL As String, ByRef Consulta As OleDbDataReader) As Boolean
        Dim Comandos As New OleDbCommand

        If Not v_Conectado Then
            If Trim(v_CadenaCNX) <> "" Then
                If Not Conectar(v_CadenaCNX) Then
                    MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                    Return False
                    Exit Function
                End If
            Else
                MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                Return False
                Exit Function
            End If
        End If

        Try
            If Not IsNothing(Consulta) Then
                If Not Consulta.IsClosed Then Consulta.Close()
            End If

            Comandos.Connection = Conexion
            Comandos.CommandText = SQL
            Comandos.ExecuteNonQuery()
            Consulta = Comandos.ExecuteReader()

            Return True

        Catch Exc As Exception
            MsgBox(Exc.Message)
            Return False
        End Try
    End Function

    'Función para Agregar (Ejecuta Cualquier consulta SQL sin devolver datos, solo el codigo autonumerico especificado
    Public Overloads Function Ejecutar_SQL(ByVal SQL As String, ByRef Codigo_Return As Long, ByVal Campo_ID As String, ByVal Tabla As String) As Boolean
        Dim Comandos As New OleDbCommand
        Dim TT As OleDbDataReader

        If Not v_Conectado Then
            If Trim(v_CadenaCNX) <> "" Then
                If Not Conectar(v_CadenaCNX) Then
                    MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                    Return False
                    Exit Function
                End If
            Else
                MsgBox("No se puede ejecutar la consulta porque no esta conectado a la BASE DE DATOS", vbCritical)
                Return False
                Exit Function
            End If
        End If

        Try
            Comandos.Connection = Conexion
            Comandos.CommandText = SQL
            Comandos.ExecuteScalar()

            If Ejecutar_SQL("SELECT MAX(" + Campo_ID + ") AS id FROM " + Tabla, TT) Then
                If TT.Read Then
                    Codigo_Return = TT.Item(0)
                    TT.Close()
                    Return True
                Else
                    Codigo_Return = 0
                    Return False
                End If
            Else
                Codigo_Return = 0
                Return False
            End If

        Catch Exc As Exception
            MsgBox(Exc.Message)
            Return False
        End Try
    End Function
End Class