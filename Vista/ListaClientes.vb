Public Class ListaClientes

    Private controladorClientes As New ControladorCliente()
    Private controladorReservas As New ControladorReserva()
    Private cliente As Cliente

    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CLIENTETableAdapter.Fill(Me.HotelDataSet.CLIENTE)
        If ComboBoxFiltrosBuscarCliente.Items.Count > 0 Then
            ComboBoxFiltrosBuscarCliente.SelectedIndex = 0
        End If
    End Sub


    Private Sub CLIENTEDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles CLIENTEDataGridView.RowStateChanged
        If CLIENTEDataGridView.Rows.Count > 0 Then
            cliente = New Cliente
            Dim row = e.Row
            Dim idCliente = row.Cells(0).Value
            cliente = controladorClientes.BuscarClientePorID(Integer.Parse(idCliente))
            Me.GroupBoxEditarCliente.Text = "Editar Cliente ID: " + cliente.ID.ToString
            Me.TextBoxNombre.Text = cliente.Nombre
            Me.TextBoxApellidos.Text = cliente.Apellidos
            Me.TextBoxDni.Text = cliente.DNI
            Me.DateTimePickerFechaNacimiento.Value = cliente.FechaNacimiento
            Me.TextBoxTelefono.Text = cliente.Telefono
            Me.TextBoxEmail.Text = cliente.Email
            Me.TextBoxDireccion.Text = cliente.Direccion
            Me.TextBoxLocalidad.Text = cliente.Localidad
            Me.TextBoxCodigoPostal.Text = cliente.CodigoPostal
            Me.TextBoxPais.Text = cliente.Pais
            Dim reservas = controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeCliente(idCliente)
            RESERVAS_HABITACIONESDataGridView.Rows.Clear()
            For Each r In reservas
                RESERVAS_HABITACIONESDataGridView.Rows.Add(r.Cliente.ID, r.ID, r.Habitacion.ID, r.Empleado.ID, r.FechaInicio.ToShortDateString, r.FechaFin.ToShortDateString, r.Sulpetoria)
            Next
        End If
    End Sub


    Private Sub DataGridViewBusquedas_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridViewBusquedas.RowStateChanged
        If DataGridViewBusquedas.Rows.Count > 0 Then
            cliente = New Cliente
            Dim row = e.Row
            Dim idCliente = row.Cells(0).Value
            cliente = controladorClientes.BuscarClientePorID(Integer.Parse(idCliente))
            Me.GroupBoxEditarCliente.Text = "Editar Cliente ID: " + cliente.ID.ToString
            Me.TextBoxNombre.Text = cliente.Nombre
            Me.TextBoxApellidos.Text = cliente.Apellidos
            Me.TextBoxDni.Text = cliente.DNI
            Me.DateTimePickerFechaNacimiento.Value = cliente.FechaNacimiento
            Me.TextBoxTelefono.Text = cliente.Telefono
            Me.TextBoxEmail.Text = cliente.Email
            Me.TextBoxDireccion.Text = cliente.Direccion
            Me.TextBoxLocalidad.Text = cliente.Localidad
            Me.TextBoxCodigoPostal.Text = cliente.CodigoPostal
            Me.TextBoxPais.Text = cliente.Pais
            Dim reservas = controladorReservas.BuscarReservasDeUnaHabitacionPorIDDeCliente(idCliente)
            RESERVAS_HABITACIONESDataGridView.Rows.Clear()
            For Each r In reservas
                RESERVAS_HABITACIONESDataGridView.Rows.Add(r.Cliente.ID, r.ID, r.Habitacion.ID, r.Empleado.ID, r.FechaInicio.ToShortDateString, r.FechaFin.ToShortDateString, r.Sulpetoria)
            Next

        End If
    End Sub


    Private Sub ButtonEditarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEditarCliente.Click
        cliente.Nombre = Me.TextBoxNombre.Text
        cliente.Apellidos = Me.TextBoxApellidos.Text
        cliente.DNI = Me.TextBoxDni.Text
        cliente.FechaNacimiento = Me.DateTimePickerFechaNacimiento.Value
        cliente.Telefono = Me.TextBoxTelefono.Text
        cliente.Email = Me.TextBoxEmail.Text
        cliente.Direccion = Me.TextBoxDireccion.Text
        cliente.Localidad = Me.TextBoxLocalidad.Text
        cliente.CodigoPostal = Me.TextBoxCodigoPostal.Text
        cliente.Pais = Me.TextBoxPais.Text
        If controladorClientes.EditarCliente(cliente) Then
            ComboBoxFiltrosBuscarCliente.SelectedIndex = 0
            TextBoxCriterioFiltro.Text = ""
            DataGridViewBusquedas.Visible = False

            Me.CLIENTETableAdapter.Fill(Me.HotelDataSet.CLIENTE)
        End If
    End Sub


    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click
        Dim clientesFiltrados = controladorClientes.BuscarClientesPorCualquierFiltro(ComboBoxFiltrosBuscarCliente.SelectedItem.ToString, TextBoxCriterioFiltro.Text.Trim)
        If clientesFiltrados IsNot Nothing Then
            DataGridViewBusquedas.Rows.Clear()
            DataGridViewBusquedas.Visible = True
            For Each c In clientesFiltrados
                DataGridViewBusquedas.Rows.Add(c.ID, c.Nombre, c.Apellidos, c.FechaNacimiento, c.Telefono, c.Email, c.Direccion, c.CodigoPostal, c.Localidad, c.Pais)
            Next
        End If
    End Sub


    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        ComboBoxFiltrosBuscarCliente.SelectedIndex = 0
        TextBoxCriterioFiltro.Text = ""
        DataGridViewBusquedas.Visible = False
        RESERVAS_HABITACIONESDataGridView.Rows.Clear()
    End Sub


    Private Sub RESERVAS_HABITACIONESDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RESERVAS_HABITACIONESDataGridView.CellContentClick
        Dim sendergrid = DirectCast(sender, DataGridView)
        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim idReserva = RESERVAS_HABITACIONESDataGridView.CurrentRow.Cells(1).Value
            Dim idHabitacion = RESERVAS_HABITACIONESDataGridView.CurrentRow.Cells(2).Value
            If controladorReservas.CancelarReserva(idReserva, idHabitacion) Then
                controladorReservas.ActualizarTablaReserva(idReserva)
                RESERVAS_HABITACIONESDataGridView.Rows.RemoveAt(RESERVAS_HABITACIONESDataGridView.CurrentRow.Index)
                MsgBox("Reserva cancelada")
            End If
        End If
    End Sub



End Class