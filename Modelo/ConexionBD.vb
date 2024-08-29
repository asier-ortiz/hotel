Imports System.Data.OleDb

Public Class ConexionBD

    Private path As String = "Hotel.mdb"
    Private connString As String = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & path
    Private Shared objConexion As OleDbConnection
    Private Shared objConexionBD As ConexionBD


    Private Sub New()
        objConexion = New OleDbConnection(connString)
    End Sub


    Public Shared Function GetInstance() As ConexionBD
        If objConexionBD Is Nothing Then
            objConexionBD = New ConexionBD()
        End If
        Return objConexionBD
    End Function


    Public ReadOnly Property GetConnection() As OleDbConnection
        Get
            Return objConexion
        End Get
    End Property


End Class
