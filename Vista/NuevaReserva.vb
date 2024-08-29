Public Class NuevaReserva

    Private controladorHabitaciones As New ControladorHabitacion
    Private controladorReservas As New ControladorReserva
    Private controladorClientes As New ControladorCliente



    Private Sub NuevaReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CLIENTETableAdapter.Fill(Me.HotelDataSet1.CLIENTE)
        Me.CargarBotonesHabitaciones(TableLayoutPanel1.Controls)
        Me.CargarBotonesHabitaciones(TableLayoutPanel2.Controls)
        Me.CargarBotonesHabitaciones(TableLayoutPanel3.Controls)
    End Sub


    Private Sub NuevaReserva_Activated(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.CLIENTETableAdapter.Fill(Me.HotelDataSet1.CLIENTE)
        Me.CargarBotonesHabitaciones(TableLayoutPanel1.Controls)
        Me.CargarBotonesHabitaciones(TableLayoutPanel2.Controls)
        Me.CargarBotonesHabitaciones(TableLayoutPanel3.Controls)
    End Sub



    Private Sub ButtonEliminarHabitacion_Click(sender As Object, e As EventArgs) Handles ButtonEliminarHabitacion.Click
        If DataGridViewHabitaciones.Rows.Count > 0 Then
            Dim allControls = TableLayoutPanel1.Controls.Cast(Of Control).Concat(TableLayoutPanel2.Controls.Cast(Of Control).Concat(TableLayoutPanel3.Controls.Cast(Of Control)))
            For Each c In allControls
                If TypeOf (c) Is Button Then
                    If CType(c, Button).Text.Equals(DataGridViewHabitaciones.CurrentRow.Cells(2).Value) Then
                        CType(c, Button).Enabled = True
                    End If
                End If
            Next
            DataGridViewHabitaciones.Rows.Remove(DataGridViewHabitaciones.CurrentRow)
        Else
            DataGridViewHabitaciones.Rows.Clear()
        End If
    End Sub


    Private Sub CargarBotonesHabitaciones(ByRef controls As TableLayoutControlCollection)
        Dim habitaciones = controladorHabitaciones.CargarListaHabitaciones
        Dim counter As Integer = 0
        For Each c In controls
            If TypeOf (c) Is Button Then
                If habitaciones(counter).Tipo = Habitacion.Tipo_Habitacion.Individual Then
                    CType(c, Button).BackgroundImageLayout = ImageLayout.Stretch
                    CType(c, Button).BackgroundImage = My.Resources.cama_doble
                End If
                If habitaciones(counter).Tipo = Habitacion.Tipo_Habitacion.Doble Then
                    CType(c, Button).BackgroundImageLayout = ImageLayout.Stretch
                    CType(c, Button).BackgroundImage = My.Resources.cama_single
                End If
                counter += 1
            End If
        Next

    End Sub



    Private Sub Datagridviewhabitaciones_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridViewHabitaciones.RowStateChanged
        If DataGridViewHabitaciones.Rows.Count > 0 Then
            Dim row = e.Row
            Dim numerohabitacion = row.Cells(2).Value
            Dim fechainicio = row.Cells(3).Value
            Dim fechafin = row.Cells(4).Value
            DataGridViewDetalleHabitacion.Rows.Clear()
            If numerohabitacion IsNot Nothing Then
                For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(numerohabitacion))
                    DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                Next
            End If
        End If
    End Sub


    Private Sub Datagridviewhabitaciones_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewHabitaciones.RowsAdded
        DataGridViewHabitaciones.Rows(e.RowIndex).Selected = True
        DataGridViewHabitaciones.Rows(e.RowIndex).Cells(0).Selected = True
    End Sub



    Private Sub Datagridviewhabitaciones_RowsRoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewHabitaciones.RowsRemoved
        If DataGridViewHabitaciones.Rows.Count = 0 Then
            DataGridViewDetalleHabitacion.Rows.Clear()
        End If
    End Sub


    Private Sub DataGridViewHabitaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHabitaciones.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            DataGridViewHabitaciones.CurrentRow.Cells(3).Value = DateTimePickerLlegada.Value.ToShortDateString
            DataGridViewHabitaciones.CurrentRow.Cells(4).Value = DateTimePickerSalida.Value.ToShortDateString
        End If
    End Sub


    Private Sub Button_Click(sender As Button, e As EventArgs) Handles ButtonHabitacion101.Click, ButtonHabitacion102.Click, ButtonHabitacion103.Click, ButtonHabitacion104.Click,
        ButtonHabitacion105.Click, ButtonHabitacion106.Click, ButtonHabitacion107.Click, ButtonHabitacion108.Click,
        ButtonHabitacion109.Click, ButtonHabitacion110.Click, ButtonHabitacion111.Click, ButtonHabitacion112.Click,
        ButtonHabitacion113.Click, ButtonHabitacion114.Click, ButtonHabitacion115.Click, ButtonHabitacion116.Click,
        ButtonHabitacion201.Click, ButtonHabitacion202.Click, ButtonHabitacion203.Click, ButtonHabitacion204.Click,
        ButtonHabitacion205.Click, ButtonHabitacion206.Click, ButtonHabitacion207.Click, ButtonHabitacion208.Click,
        ButtonHabitacion209.Click, ButtonHabitacion210.Click, ButtonHabitacion211.Click, ButtonHabitacion212.Click,
        ButtonHabitacion213.Click, ButtonHabitacion214.Click, ButtonHabitacion215.Click, ButtonHabitacion216.Click,
        ButtonHabitacion301.Click, ButtonHabitacion302.Click, ButtonHabitacion303.Click, ButtonHabitacion304.Click,
        ButtonHabitacion305.Click, ButtonHabitacion306.Click, ButtonHabitacion307.Click, ButtonHabitacion308.Click,
        ButtonHabitacion309.Click, ButtonHabitacion310.Click, ButtonHabitacion311.Click, ButtonHabitacion312.Click,
        ButtonHabitacion313.Click, ButtonHabitacion314.Click, ButtonHabitacion315.Click, ButtonHabitacion316.Click

        Dim habitaciones = controladorHabitaciones.CargarListaHabitaciones
        Dim indice As Integer
        Select Case TabControl1.SelectedTab.TabIndex
            Case 0
                For i As Integer = 0 To TableLayoutPanel1.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel1.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i
                        DataGridViewHabitaciones.Rows.Add()
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(2).Value = sender.Text
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(0).Value = habitaciones(15 - indice).Tipo
                        CType(sender, Button).Enabled = False
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(15 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
            Case 1
                For i As Integer = 0 To TableLayoutPanel2.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel2.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i + 16
                        DataGridViewHabitaciones.Rows.Add()
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(2).Value = sender.Text
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(0).Value = habitaciones(31 - indice).Tipo
                        CType(sender, Button).Enabled = False
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(31 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
            Case 2
                For i As Integer = 0 To TableLayoutPanel3.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel3.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i + 32
                        DataGridViewHabitaciones.Rows.Add()
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(2).Value = sender.Text
                        DataGridViewHabitaciones.Rows(DataGridViewHabitaciones.Rows.Count - 1).Cells(0).Value = habitaciones(47 - indice).Tipo
                        CType(sender, Button).Enabled = False
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(47 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
        End Select
    End Sub


    Private Sub Button_DobleClick(sender As Button, e As EventArgs) Handles ButtonHabitacion101.MouseHover, ButtonHabitacion102.MouseHover, ButtonHabitacion103.MouseHover, ButtonHabitacion104.MouseHover,
        ButtonHabitacion105.MouseHover, ButtonHabitacion106.MouseHover, ButtonHabitacion107.MouseHover, ButtonHabitacion108.MouseHover,
        ButtonHabitacion109.MouseHover, ButtonHabitacion110.MouseHover, ButtonHabitacion111.MouseHover, ButtonHabitacion112.MouseHover,
        ButtonHabitacion113.MouseHover, ButtonHabitacion114.MouseHover, ButtonHabitacion115.MouseHover, ButtonHabitacion116.MouseHover,
        ButtonHabitacion201.MouseHover, ButtonHabitacion202.MouseHover, ButtonHabitacion203.MouseHover, ButtonHabitacion204.MouseHover,
        ButtonHabitacion205.MouseHover, ButtonHabitacion206.MouseHover, ButtonHabitacion207.MouseHover, ButtonHabitacion208.MouseHover,
        ButtonHabitacion209.MouseHover, ButtonHabitacion210.MouseHover, ButtonHabitacion211.MouseHover, ButtonHabitacion212.MouseHover,
        ButtonHabitacion213.MouseHover, ButtonHabitacion214.MouseHover, ButtonHabitacion215.MouseHover, ButtonHabitacion216.MouseHover,
        ButtonHabitacion301.MouseHover, ButtonHabitacion302.MouseHover, ButtonHabitacion303.MouseHover, ButtonHabitacion304.MouseHover,
        ButtonHabitacion305.MouseHover, ButtonHabitacion306.MouseHover, ButtonHabitacion307.MouseHover, ButtonHabitacion308.MouseHover,
        ButtonHabitacion309.MouseHover, ButtonHabitacion310.MouseHover, ButtonHabitacion311.MouseHover, ButtonHabitacion312.MouseHover,
        ButtonHabitacion313.MouseHover, ButtonHabitacion314.MouseHover, ButtonHabitacion315.MouseHover, ButtonHabitacion316.MouseHover

        Dim habitaciones = controladorHabitaciones.CargarListaHabitaciones
        Dim indice As Integer
        Select Case TabControl1.SelectedTab.TabIndex
            Case 0
                For i As Integer = 0 To TableLayoutPanel1.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel1.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(15 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
            Case 1
                For i As Integer = 0 To TableLayoutPanel2.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel2.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i + 16
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(31 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
            Case 2
                For i As Integer = 0 To TableLayoutPanel3.Controls.Count - 1
                    Dim boton = CType(TableLayoutPanel3.Controls(i), Button)
                    If sender.Equals(boton) Then
                        indice = i + 32
                        DataGridViewDetalleHabitacion.Rows.Clear()
                        For Each r In controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeHabitacion(Integer.Parse(habitaciones(47 - indice).ID))
                            DataGridViewDetalleHabitacion.Rows.Add(r.FechaInicio.ToString("dd-MM-yyyy"), r.FechaFin.ToString("dd-MM-yyyy"))
                        Next
                    End If
                Next
        End Select
    End Sub


    Private Sub ButtonGenerarReservas_Click(sender As Object, e As EventArgs) Handles ButtonGenerarReservas.Click
        Dim habitaciones = controladorHabitaciones.CargarListaHabitaciones
        If controladorReservas.NuevaReserva(ComboBoxTitulares, DataGridViewHabitaciones, habitaciones, controladorClientes, controladorHabitaciones) Then
            Dim allControls = TableLayoutPanel1.Controls.Cast(Of Control).Concat(TableLayoutPanel2.Controls.Cast(Of Control).Concat(TableLayoutPanel3.Controls.Cast(Of Control)))
            For Each c In allControls
                If TypeOf (c) Is Button Then
                    c.Enabled = True
                End If
            Next
            DataGridViewHabitaciones.Rows.Clear()
        End If

    End Sub




End Class