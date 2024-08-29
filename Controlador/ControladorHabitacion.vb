Public Class ControladorHabitacion

    Private habitacion As Habitacion

    Public Sub New()
        Me.habitacion = New Habitacion()
    End Sub

    Public Function CargarListaHabitaciones() As List(Of Habitacion)
        Return habitacion.ListaDeHabitaciones()
    End Function

    Public Function BuscarHabitacionPorID(idHabitacion As Integer) As Habitacion
        Return habitacion.BuscarHabitacionPorID(idHabitacion)
    End Function



End Class
