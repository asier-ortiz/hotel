Imports System.Data.OleDb

Public Class Reserva

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _fechaInicio As Date
    Public Property FechaInicio() As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property


    Private _fechaFin As Date
    Public Property FechaFin() As Date
        Get
            Return _fechaFin
        End Get
        Set(ByVal value As Date)
            _fechaFin = value
        End Set
    End Property


    Private _cliente As Cliente
    Public Property Cliente() As Cliente
        Get
            Return _cliente
        End Get
        Set(ByVal value As Cliente)
            _cliente = value
        End Set
    End Property


    Private _empleado As Empleado
    Public Property Empleado() As Empleado
        Get
            Return _empleado
        End Get
        Set(ByVal value As Empleado)
            _empleado = value
        End Set
    End Property


    Private _habitacion As Habitacion
    Public Property Habitacion() As Habitacion
        Get
            Return _habitacion
        End Get
        Set(ByVal value As Habitacion)
            _habitacion = value
        End Set
    End Property



    Private _supletoria As Boolean
    Public Property Sulpetoria() As Boolean
        Get
            Return _supletoria
        End Get
        Set(ByVal value As Boolean)
            _supletoria = value
        End Set
    End Property


    Public Sub New(fechaInicio As Date, fechaFin As Date, cliente As Cliente, habitacion As Habitacion, supletoria As Boolean)
        _id = UltimoId()
        _fechaInicio = fechaInicio
        _fechaFin = fechaFin
        _cliente = cliente
        _habitacion = habitacion
        _supletoria = supletoria
    End Sub


    Public Sub New()
        FechaInicio = New Date
        FechaFin = New Date
        Cliente = New Cliente()
        Habitacion = New Habitacion()
    End Sub


    Public Function UltimoId() As Integer
        Dim id As Integer = 1
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "SELECT MAX(ID_RESERVA) FROM RESERVA"
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
                If reader.Item(0) IsNot DBNull.Value Then
                    id = Integer.Parse(reader.Item(0))
                    id = id + 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return id
    End Function


    Public Sub NuevaReserva()
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("INSERT INTO RESERVA (ID_RESERVA, ID_CLIENTE, ID_EMPLEADO) VALUES (""{0}"", ""{1}"", ""{2}"")", Me.ID, Me.Cliente.ID, 1)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se inserta la reserva")
        End Try
        conn.Close()
    End Sub


    Public Sub AsociarReservaAHabitaciones()
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        Dim supletoria As Integer = IIf(Me.Sulpetoria = False, 0, -1)
        sql = String.Format("INSERT INTO RESERVA_HABITACION (ID_RESERVA, ID_HABITACION, FECHA_INICIO, FECHA_FIN, SUPLETORIA) VALUES (""{0}"", ""{1}"", ""{2}"", ""{3}"", ""{4}"")", Me.ID, Me.Habitacion.ID, Me.FechaInicio, Me.FechaFin, supletoria)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se inserta la reserva")
        End Try
        conn.Close()
    End Sub



    Public Function BuscarReservasDeUnaHabitacionPorIDDeHabitacion(idHabitacion As Integer) As List(Of Reserva)
        Dim reservas As New List(Of Reserva)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("SELECT A.FECHA_INICIO, A.FECHA_FIN, B.ID_CLIENTE FROM RESERVA_HABITACION A, RESERVA B WHERE A.ID_RESERVA = B.ID_RESERVA AND A.ID_HABITACION = {0}", idHabitacion)
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
                    Dim reserva As New Reserva()
                    reserva.FechaInicio = Date.Parse(reader.Item(0))
                    reserva.FechaFin = Date.Parse(reader.Item(1))
                    reservas.Add(reserva)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return reservas
    End Function



    Public Function BuscarReservasDeUnaHabitacionPorIDDeCliente(idCliente As Integer) As List(Of Reserva)
        Dim reservas As New List(Of Reserva)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("SELECT A.ID_CLIENTE, A.ID_RESERVA, B.ID_HABITACION, A.ID_EMPLEADO, B.FECHA_INICIO, B.FECHA_FIN, B.SUPLETORIA FROM RESERVA A, RESERVA_HABITACION B WHERE A.ID_RESERVA = B.ID_RESERVA AND A.ID_CLIENTE = {0}", idCliente)
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
                    Dim reserva As New Reserva()
                    Dim cliente = New Cliente()
                    cliente.ID = Integer.Parse(reader.Item(0))
                    reserva.Cliente = cliente
                    reserva.ID = Integer.Parse(reader.Item(1))
                    Dim habitacion = New Habitacion()
                    habitacion.ID = Integer.Parse(reader.Item(2))
                    reserva.Habitacion = habitacion
                    Dim empleado = New Empleado()
                    empleado.ID = Integer.Parse(reader.Item(3))
                    reserva.Empleado = empleado
                    reserva.FechaInicio = Date.Parse(reader.Item(4))
                    reserva.FechaFin = Date.Parse(reader.Item(5))
                    reserva.Sulpetoria = reader.Item(6)
                    reservas.Add(reserva)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return reservas
    End Function


    Public Function CancelarReserva(idReserva As Integer, idHabitacion As Integer) As Boolean
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "DELETE FROM RESERVA_HABITACION WHERE ID_RESERVA = (?) AND ID_HABITACION = (?)"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.Add("ID_RESERVA", OleDbType.Integer).Value = idReserva
            cmd.Parameters.Add("ID_HABITACION", OleDbType.Integer).Value = idHabitacion
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se puede eliminar la reserva")
            Return False
        End Try
        conn.Close()
        Return True
    End Function



    Public Sub ActualizarTablaReserva(idReserva As Integer)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "SELECT COUNT(*) FROM RESERVA_HABITACION WHERE ID_RESERVA = (?)"
        Dim noQuedanHabitacionesReservadas = False
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.Add("ID_RESERVA", OleDbType.Integer).Value = idReserva
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                If reader(0) = 0 Then
                    noQuedanHabitacionesReservadas = True
                End If
            End If
            If noQuedanHabitacionesReservadas Then
                sql = "DELETE FROM RESERVA WHERE ID_RESERVA = (?)"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.Add("ID_RESERVA", OleDbType.Integer).Value = idReserva
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " No se puede actualizar la tabla reservas")
        End Try
        conn.Close()
    End Sub





End Class
