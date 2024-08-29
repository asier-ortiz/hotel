Public Class ControladorCliente

    Private cliente As Cliente

    Public Sub New()
        Me.cliente = New Cliente()
    End Sub

    Public Function NuevoCliente(nombre As String, apellidos As String, dni As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, cod_postal As String, localidad As String, pais As String) As Boolean
        Dim errores As String = ""
        If nombre.Length = 0 Then errores &= "Tienes que insertar un nombre" & vbCrLf
        If apellidos.Length = 0 Then errores &= "Tienes que insertar unos apellidos" & vbCrLf
        If DateDiff(DateInterval.Day, fecha_nacimiento, Date.Now) < 18 Then errores &= "El cliente ha de ser mayor de edad" & vbCrLf
        If direccion.Length = 0 Then errores &= "Tienes que insertar una dirección" & vbCrLf
        If cod_postal.Length = 0 Xor cod_postal.Length > 5 Then errores &= "Código postal incorrecto" & vbCrLf
        If localidad.Length = 0 Then errores &= "Tienes que insertar una localidad" & vbCrLf
        If pais.Length = 0 Then errores &= "Tienes que insertar un país" & vbCrLf
        If errores = "" Then
            MsgBox("Nuevo cliente creado")
            cliente = New Cliente(nombre, apellidos, dni, fecha_nacimiento, telefono, email, direccion, cod_postal, localidad, pais)
            cliente.NuevoCliente()
            NuevoCliente = True
        Else
            MsgBox(errores)
            NuevoCliente = False
        End If
    End Function


    Public Function EditarCliente(c As Cliente) As Boolean
        Dim errores As String = ""
        If c.Nombre.Length = 0 Then errores &= "Tienes que insertar un nombre" & vbCrLf
        If c.Apellidos.Length = 0 Then errores &= "Tienes que insertar unos apellidos" & vbCrLf
        If DateDiff(DateInterval.Day, c.FechaNacimiento, Date.Now) < 18 Then errores &= "El cliente ha de ser mayor de edad" & vbCrLf
        If c.Direccion.Length = 0 Then errores &= "Tienes que insertar una dirección" & vbCrLf
        If c.CodigoPostal.Length = 0 Xor c.CodigoPostal.Length > 5 Then errores &= "Código postal incorrecto" & vbCrLf
        If c.Localidad.Length = 0 Then errores &= "Tienes que insertar una localidad" & vbCrLf
        If c.Pais.Length = 0 Then errores &= "Tienes que insertar un país" & vbCrLf
        If errores = "" Then
            MsgBox("Cliente editado")
            c.EditarCliente(c)
            Return True
        Else
            MsgBox(errores)
            Return False
        End If
    End Function



    Public Function BuscarClientesPorCualquierFiltro(filtro As String, criterio As String) As List(Of Cliente)
        Dim errores As String = ""
        If filtro.Length = 0 Xor criterio.Length = 0 Then errores &= "Tienes que introducir datos de búsqueda" & vbCrLf
        If errores = "" Then
            Dim clientesFiltrados = cliente.BuscarClientesPorCualquierCampo(filtro, criterio)
            If clientesFiltrados.Count = 0 Then
                errores &= "No se encontró ninguna coincidencia" & vbCrLf
                MsgBox(errores)
                Return Nothing
            Else
                Return cliente.BuscarClientesPorCualquierCampo(filtro, criterio)
            End If
        Else
            MsgBox(errores)
            Return Nothing
        End If
    End Function



    Public Function ListaDeClientes() As List(Of Cliente)
        Return cliente.ListaDeClientes()
    End Function


    Public Function BuscarClientePorID(idCliente As Integer) As Cliente
        Return cliente.BuscarClientePorID(idCliente)
    End Function


    Public Function UltimoID() As Integer
        Return cliente.UltimoId()
    End Function

End Class
