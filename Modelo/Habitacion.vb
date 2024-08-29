Imports System.Data.OleDb

Public Class Habitacion

    Enum Tipo_Habitacion
        Individual
        Doble
    End Enum

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _tipo As Tipo_Habitacion
    Public Property Tipo() As Tipo_Habitacion
        Get
            Return _tipo
        End Get
        Set(ByVal value As Tipo_Habitacion)
            _tipo = value
        End Set
    End Property


    Public Sub New()
    End Sub


    Public Sub New(id As String, tipo As Tipo_Habitacion)
        _id = id
        _tipo = tipo
    End Sub


    Public Function ListaDeHabitaciones() As List(Of Habitacion)
        Dim habitaciones As New List(Of Habitacion)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "SELECT * FROM HABITACION"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    Dim habitacion As New Habitacion()
                    habitacion.ID = Integer.Parse(reader.Item(0))
                    Dim tipo As String = reader.Item(1).ToString
                    If tipo.Equals("INDIVIDUAL") Then
                        habitacion.Tipo = Tipo_Habitacion.Individual
                        habitaciones.Add(habitacion)
                    End If
                    If tipo.Equals("DOBLE") Then
                        habitacion.Tipo = Tipo_Habitacion.Doble
                        habitaciones.Add(habitacion)
                    End If
                End While
            End If
            reader.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return habitaciones
    End Function


    Public Function BuscarHabitacionPorID(idHabitacion As Integer) As Habitacion
        Dim habitacion As New Habitacion()
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("SELECT * FROM HABITACION WHERE ID_HABITACION = {0}", idHabitacion)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                habitacion.ID = Integer.Parse(reader.Item(0))

                Dim tipo As String = reader.Item(1).ToString
                If tipo.Equals("INDIVIDUAL") Then
                    habitacion.Tipo = Tipo_Habitacion.Individual
                End If
                If tipo.Equals("DOBLE") Then
                    habitacion.Tipo = Tipo_Habitacion.Doble
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return habitacion
    End Function



    Public Overrides Function ToString() As String
        Return String.Format("{0}, {1}", ID, Tipo.ToString)
    End Function



End Class
