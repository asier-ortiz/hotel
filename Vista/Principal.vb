Public Class Principal

    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BotonMaximizar_Click(sender As Object, e As EventArgs) Handles BotonMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        BotonMaximizar.Visible = False
        BotonRestaurar.Visible = True
    End Sub


    Private Sub BotonRestaurar_Click(sender As Object, e As EventArgs) Handles BotonRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        BotonRestaurar.Visible = False
        BotonMaximizar.Visible = True
    End Sub

    Private Sub BotonMinimizar_Click(sender As Object, e As EventArgs) Handles BotonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BarraTitulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            BotonMaximizar.Visible = False
            BotonRestaurar.Visible = True
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            BotonRestaurar.Visible = False
            BotonMaximizar.Visible = True
        End If
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer,
            ByVal wParam As Integer, ByVal lParam As Integer
            )
    End Sub

    Private Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub

    Private Sub Principal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                    Handles MyBase.MouseMove, BarraTitulo.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.DoubleClick

    End Sub



    Private Sub ButtonNuevaReserva_Click(sender As Object, e As EventArgs) Handles ButtonNuevaReserva.Click
        With NuevaReserva
            .TopLevel = False
            PanelContenedor.Controls.Clear()
            PanelContenedor.Controls.Add(NuevaReserva)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ButtonNuevoCliente_Click(sender As Object, e As EventArgs) Handles ButtonNuevoCliente.Click
        With NuevoCliente
            .TopLevel = False
            PanelContenedor.Controls.Clear()
            PanelContenedor.Controls.Add(NuevoCliente)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ButtonListaClientes_Click(sender As Object, e As EventArgs) Handles ButtonListaClientes.Click
        With ListaClientes
            .TopLevel = False
            PanelContenedor.Controls.Clear()
            PanelContenedor.Controls.Add(ListaClientes)
            .BringToFront()
            .Show()
        End With
    End Sub




End Class
