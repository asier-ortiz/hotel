Public Class NuevoCliente

    Private controladorClientes As New ControladorCliente

    Private Sub NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelDatos.Location = New Point((Me.Width / 2) - (PanelDatos.Width / 2), (Me.Height / 2) - (PanelDatos.Height / 2))
        LabelIdNuevoCliente.Text = (controladorClientes.UltimoID + 1).ToString
    End Sub



    Private Sub NuevoCliente_Activated(sender As Object, e As EventArgs) Handles MyBase.Enter
        PanelDatos.Location = New Point((Me.Width / 2) - (PanelDatos.Width / 2), (Me.Height / 2) - (PanelDatos.Height / 2))
        LabelIdNuevoCliente.Text = (controladorClientes.UltimoID + 1).ToString
    End Sub


    Private Sub ButtonLimpiarCampos_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarCampos.Click
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellidos.Clear()
        Me.TextBoxDni.Clear()
        Me.DateTimePickerFechaNacimiento.Value = Date.Today
        Me.TextBoxTelefono.Clear()
        Me.TextBoxEmail.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxLocalidad.Clear()
        Me.TextBoxCodigoPostal.Clear()
        Me.TextBoxPais.Clear()
    End Sub


    Private Sub ButtonCrearCliente_Click(sender As Object, e As EventArgs) Handles ButtonCrearCliente.Click
        controladorClientes.NuevoCliente(TextBoxNombre.Text, TextBoxApellidos.Text, TextBoxDni.Text, DateTimePickerFechaNacimiento.Value.ToShortDateString, TextBoxTelefono.Text, TextBoxEmail.Text, TextBoxDireccion.Text, TextBoxCodigoPostal.Text, TextBoxLocalidad.Text, TextBoxPais.Text)
    End Sub



End Class