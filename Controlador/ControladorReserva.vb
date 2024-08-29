Public Class ControladorReserva

    Private reserva As Reserva

    Public Sub New()
        Me.reserva = New Reserva()
    End Sub

    Public Function BuscarReservasDeUnaHabitacionPorIDDeHabitacion(idHabitacion As Integer) As List(Of Reserva)
        Return reserva.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(idHabitacion)
    End Function


    Public Function BuscarReservasDeUnaHabitacionPorIDDeCliente(idCliente As Integer) As List(Of Reserva)
        Return reserva.BuscarReservasDeUnaHabitacionPorIDDeCliente(idCliente)
    End Function


    Public Function NuevaReserva(ComboBoxTitulares As ComboBox, DataGridViewHabitaciones As DataGridView, habitaciones As List(Of Habitacion), controladorClientes As ControladorCliente, controladorHabitaciones As ControladorHabitacion) As Boolean
        Dim nuevasReservas As New List(Of Reserva)
        Dim indiceCliente = ComboBoxTitulares.SelectedIndex.ToString
        Dim errores As String = ""
        If indiceCliente <> -1 Then
            Dim cliente = controladorClientes.BuscarClientePorID(Integer.Parse(indiceCliente) + 1)
            For Each row As DataGridViewRow In DataGridViewHabitaciones.Rows
                Dim supletoria As Boolean = CType(row.Cells(1).Value, Boolean)
                Dim numeroHabitacion As String = row.Cells(2).Value
                Dim fechaInicioNuevaReserva = Convert.ToDateTime(row.Cells(3).Value)
                Dim fechaFinNuevaReserva = Convert.ToDateTime(row.Cells(4).Value)
                Dim habitacion = controladorHabitaciones.BuscarHabitacionPorID(Integer.Parse(numeroHabitacion))
                reserva = New Reserva(fechaInicioNuevaReserva, fechaFinNuevaReserva, cliente, habitacion, supletoria)
                nuevasReservas.Add(reserva)
                If (fechaInicioNuevaReserva < fechaFinNuevaReserva Xor fechaInicioNuevaReserva = fechaFinNuevaReserva) And fechaInicioNuevaReserva.Day >= Date.Now.Day Then
                    Dim reservas = Me.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(numeroHabitacion))
                    For Each r In reservas
                        Dim fechainicio = r.FechaInicio
                        Dim fechafin = r.FechaFin
                        If Not (fechaFinNuevaReserva < fechainicio Or fechaInicioNuevaReserva > fechafin) Then
                            errores &= "la habitación nº " + numeroHabitacion + " no está disponible en la fecha seleccionada" & vbCrLf
                            Exit For
                        End If
                    Next
                Else
                    errores &= "Fechas incorrectas para la habitación nº " + numeroHabitacion & vbCrLf
                End If
            Next
        Else
            errores &= "Escoja un ID de cliente válido " & vbCrLf
        End If
        If errores <> "" Then
            MsgBox(errores)
            Return False
        Else
            reserva.NuevaReserva()
            For Each r In nuevasReservas
                r.AsociarReservaAHabitaciones()
            Next
            MsgBox("Reserva creada")
            Return True
        End If
    End Function


    Public Function CancelarReserva(idReserva As Integer, idHabitacion As Integer) As Boolean
        Return reserva.CancelarReserva(idReserva, idHabitacion)
    End Function


    Public Sub ActualizarTablaReserva(idReserva As Integer)
        reserva.ActualizarTablaReserva(idReserva)
    End Sub


End Class
