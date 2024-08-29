Imports System.Data.OleDb

Public Class Cliente

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellidos As String
    Public Property Apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property

    Private _dni As String
    Public Property DNI() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _codigoPostal As String
    Public Property CodigoPostal() As String
        Get
            Return _codigoPostal
        End Get
        Set(ByVal value As String)
            _codigoPostal = value
        End Set
    End Property

    Private _localidad As String
    Public Property Localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property

    Private _pais As String
    Public Property Pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property


    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellidos As String, dni As String, fechaNacimiento As Date, telefono As String, email As String, direccion As String, codigoPostal As String, localidad As String, pais As String)
        _id = UltimoId()
        _nombre = nombre
        _apellidos = apellidos
        _dni = dni
        _fechaNacimiento = fechaNacimiento
        _telefono = telefono
        _email = email
        _direccion = direccion
        _codigoPostal = codigoPostal
        _localidad = localidad
        _pais = pais
    End Sub


    Public Function UltimoId() As Integer
        Dim id As Integer = 1
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "SELECT MAX(ID_CLIENTE) FROM CLIENTE"
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


    Public Sub NuevoCliente()
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("INSERT INTO CLIENTE (ID_CLIENTE, NOMBRE, APELLIDOS, DNI, FECHA_NACIMIENTO, TELEFONO, EMAIL, DIRECCION, COD_POSTAL, LOCALIDAD, PAIS) VALUES (""{0}"", ""{1}"", ""{2}"", ""{3}"", ""{4}"", ""{5}"", ""{6}"", ""{7}"", ""{8}"", ""{9}"", ""{10}"")", Me.ID, Me.Nombre, Me.Apellidos, Me.DNI,
             Me.FechaNacimiento, Me.Telefono, Me.Email, Me.Direccion, Me.CodigoPostal, Me.Localidad, Me.Pais)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se puede insertar al cliente")
        End Try
        conn.Close()
    End Sub


    Public Sub EditarCliente(cliente As Cliente)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "UPDATE CLIENTE SET NOMBRE = (?), APELLIDOS = (?), DNI = (?), FECHA_NACIMIENTO = (?), TELEFONO = (?), EMAIL = (?), DIRECCION = (?), COD_POSTAL = (?), LOCALIDAD = (?), PAIS = (?) WHERE ID_CLIENTE = (?)"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.Add("NOMBRE", OleDbType.VarChar).Value = cliente.Nombre
            cmd.Parameters.Add("APELLIDOS", OleDbType.VarChar).Value = cliente.Apellidos
            cmd.Parameters.Add("DNI", OleDbType.VarChar).Value = cliente.DNI
            cmd.Parameters.Add("FECHA_NACIMIENTO", OleDbType.Date).Value = cliente.FechaNacimiento
            cmd.Parameters.Add("TELEFONO", OleDbType.VarChar).Value = cliente.Telefono
            cmd.Parameters.Add("EMAIL", OleDbType.VarChar).Value = cliente.Email
            cmd.Parameters.Add("DIRECCION", OleDbType.VarChar).Value = cliente.Direccion
            cmd.Parameters.Add("COD_POSTAL", OleDbType.VarChar).Value = cliente.CodigoPostal
            cmd.Parameters.Add("LOCALIDAD", OleDbType.VarChar).Value = cliente.Localidad
            cmd.Parameters.Add("PAIS", OleDbType.VarChar).Value = cliente.Pais
            cmd.Parameters.Add("ID", OleDbType.Integer).Value = cliente.ID
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se puede modificar al cliente")
        End Try
        conn.Close()
    End Sub


    Public Function ListaDeClientes() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = "SELECT * FROM CLIENTE"
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
                    Dim cliente As New Cliente()
                    cliente.ID = Integer.Parse(reader.Item(0))
                    cliente.Nombre = reader.Item(1).ToString
                    cliente.Apellidos = reader.Item(2).ToString
                    cliente.DNI = reader.Item(3).ToString
                    cliente.FechaNacimiento = reader.Item(4).ToString
                    cliente.Telefono = reader.Item(5).ToString
                    cliente.Email = reader.Item(6).ToString
                    cliente.Direccion = reader.Item(7).ToString
                    cliente.CodigoPostal = reader.Item(8).ToString
                    cliente.Localidad = reader.Item(9).ToString
                    cliente.Pais = reader.Item(10).ToString
                    clientes.Add(cliente)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return clientes
    End Function


    Public Function BuscarClientePorID(idCliente As Integer) As Cliente
        Dim cliente As New Cliente()
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim sql As String
        sql = String.Format("SELECT * FROM CLIENTE WHERE ID_CLIENTE = {0}", idCliente)
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
                cliente.ID = Integer.Parse(reader.Item(0))
                cliente.Nombre = reader.Item(1).ToString
                cliente.Apellidos = reader.Item(2).ToString
                cliente.DNI = reader.Item(3).ToString
                cliente.FechaNacimiento = reader.Item(4).ToString
                cliente.Telefono = reader.Item(5).ToString
                cliente.Email = reader.Item(6).ToString
                cliente.Direccion = reader.Item(7).ToString
                cliente.CodigoPostal = reader.Item(8).ToString
                cliente.Localidad = reader.Item(9).ToString
                cliente.Pais = reader.Item(10).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return cliente
    End Function


    Public Function BuscarClientesPorCualquierCampo(filtro As String, criterio As String) As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Dim conn = ConexionBD.GetInstance.GetConnection
        Dim cmd As New OleDbCommand
        Dim sql As String = ""
        Select Case filtro
            Case "ID"
                Dim id As Integer
                Dim ok = Integer.TryParse(criterio, id)
                If ok Then
                    sql = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = (?)"
                    cmd.Parameters.Add("ID", OleDbType.Integer).Value = id
                End If
            Case "Nombre"
                sql = String.Format("SELECT * FROM CLIENTE WHERE NOMBRE = '{0}'", criterio)
            Case "Apellidos"
                sql = String.Format("SELECT * FROM CLIENTE WHERE APELLIDOS = '{0}'", criterio)
            Case "DNI"
                sql = String.Format("SELECT * FROM CLIENTE WHERE DNI = '{0}'", criterio)
            Case "Fecha Nacimiento"
                Dim fechaNacimiento As Date
                Dim ok = Date.TryParse(criterio, fechaNacimiento)
                If ok Then
                    fechaNacimiento = fechaNacimiento.ToShortDateString
                    sql = "SELECT * FROM CLIENTE WHERE FECHA_NACIMIENTO = (?)"
                    cmd.Parameters.Add("FECHA_NACIMIENTO", OleDbType.Date).Value = fechaNacimiento
                End If
            Case "Teléfono"
                sql = String.Format("SELECT * FROM CLIENTE WHERE TELEFONO = '{0}'", criterio)
            Case "E-Mail"
                sql = String.Format("SELECT * FROM CLIENTE WHERE EMAIL = '{0}'", criterio)
            Case "Dirección"
                sql = String.Format("SELECT * FROM CLIENTE WHERE DIRECCION = '{0}'", criterio)
            Case "Cod. Postal"
                sql = String.Format("SELECT * FROM CLIENTE WHERE COD_POSTAL = '{0}'", criterio)
            Case "Localidad"
                sql = String.Format("SELECT * FROM CLIENTE WHERE LOCALIDAD = '{0}'", criterio)
            Case "País"
                sql = String.Format("SELECT * FROM CLIENTE WHERE PAIS = '{0}'", criterio)
        End Select
        If sql <> "" Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                cmd.CommandText = sql
                cmd.Connection = conn
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        Dim cliente As New Cliente()
                        cliente.ID = Integer.Parse(reader.Item(0))
                        cliente.Nombre = reader.Item(1).ToString
                        cliente.Apellidos = reader.Item(2).ToString
                        cliente.DNI = reader.Item(3).ToString
                        cliente.FechaNacimiento = reader.Item(4).ToString
                        cliente.Telefono = reader.Item(5).ToString
                        cliente.Email = reader.Item(6).ToString
                        cliente.Direccion = reader.Item(7).ToString
                        cliente.CodigoPostal = reader.Item(8).ToString
                        cliente.Localidad = reader.Item(9).ToString
                        cliente.Pais = reader.Item(10).ToString
                        clientes.Add(cliente)
                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        Return clientes
    End Function





End Class
