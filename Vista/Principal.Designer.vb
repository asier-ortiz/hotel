<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.BotonRestaurar = New System.Windows.Forms.PictureBox()
        Me.BotonMaximizar = New System.Windows.Forms.PictureBox()
        Me.BotonMinimizar = New System.Windows.Forms.PictureBox()
        Me.BotonCerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.ButtonSalir = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtonListaClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonNuevoCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonNuevaReserva = New System.Windows.Forms.Button()
        Me.PicktureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.BotonRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        CType(Me.ButtonSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicktureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.BotonRestaurar)
        Me.BarraTitulo.Controls.Add(Me.BotonMaximizar)
        Me.BarraTitulo.Controls.Add(Me.BotonMinimizar)
        Me.BarraTitulo.Controls.Add(Me.BotonCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1220, 38)
        Me.BarraTitulo.TabIndex = 0
        '
        'BotonRestaurar
        '
        Me.BotonRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonRestaurar.Image = Global.Hotel.My.Resources.Resources.res
        Me.BotonRestaurar.Location = New System.Drawing.Point(1139, 7)
        Me.BotonRestaurar.Name = "BotonRestaurar"
        Me.BotonRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.BotonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonRestaurar.TabIndex = 3
        Me.BotonRestaurar.TabStop = False
        Me.BotonRestaurar.Visible = False
        '
        'BotonMaximizar
        '
        Me.BotonMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonMaximizar.Image = Global.Hotel.My.Resources.Resources.maxi
        Me.BotonMaximizar.Location = New System.Drawing.Point(1139, 7)
        Me.BotonMaximizar.Name = "BotonMaximizar"
        Me.BotonMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.BotonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonMaximizar.TabIndex = 2
        Me.BotonMaximizar.TabStop = False
        '
        'BotonMinimizar
        '
        Me.BotonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonMinimizar.Image = Global.Hotel.My.Resources.Resources.minimazar
        Me.BotonMinimizar.Location = New System.Drawing.Point(1094, 7)
        Me.BotonMinimizar.Name = "BotonMinimizar"
        Me.BotonMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonMinimizar.TabIndex = 1
        Me.BotonMinimizar.TabStop = False
        '
        'BotonCerrar
        '
        Me.BotonCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCerrar.Image = Global.Hotel.My.Resources.Resources.cerrar
        Me.BotonCerrar.Location = New System.Drawing.Point(1183, 7)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonCerrar.TabIndex = 0
        Me.BotonCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.ButtonSalir)
        Me.MenuVertical.Controls.Add(Me.Panel4)
        Me.MenuVertical.Controls.Add(Me.ButtonListaClientes)
        Me.MenuVertical.Controls.Add(Me.Panel2)
        Me.MenuVertical.Controls.Add(Me.ButtonNuevoCliente)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Controls.Add(Me.ButtonNuevaReserva)
        Me.MenuVertical.Controls.Add(Me.PicktureBoxLogo)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 38)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 1000)
        Me.MenuVertical.TabIndex = 1
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.Image = Global.Hotel.My.Resources.Resources.salir
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 938)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(50, 50)
        Me.ButtonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonSalir.TabIndex = 9
        Me.ButtonSalir.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 232)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 32)
        Me.Panel4.TabIndex = 8
        '
        'ButtonListaClientes
        '
        Me.ButtonListaClientes.FlatAppearance.BorderSize = 0
        Me.ButtonListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ButtonListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonListaClientes.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListaClientes.ForeColor = System.Drawing.Color.White
        Me.ButtonListaClientes.Image = Global.Hotel.My.Resources.Resources.clientes
        Me.ButtonListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonListaClientes.Location = New System.Drawing.Point(3, 232)
        Me.ButtonListaClientes.Name = "ButtonListaClientes"
        Me.ButtonListaClientes.Size = New System.Drawing.Size(217, 32)
        Me.ButtonListaClientes.TabIndex = 7
        Me.ButtonListaClientes.Text = "Lista Clientes"
        Me.ButtonListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonListaClientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 32)
        Me.Panel2.TabIndex = 4
        '
        'ButtonNuevoCliente
        '
        Me.ButtonNuevoCliente.FlatAppearance.BorderSize = 0
        Me.ButtonNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ButtonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevoCliente.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevoCliente.ForeColor = System.Drawing.Color.White
        Me.ButtonNuevoCliente.Image = Global.Hotel.My.Resources.Resources.nuevoCliente
        Me.ButtonNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNuevoCliente.Location = New System.Drawing.Point(4, 194)
        Me.ButtonNuevoCliente.Name = "ButtonNuevoCliente"
        Me.ButtonNuevoCliente.Size = New System.Drawing.Size(217, 32)
        Me.ButtonNuevoCliente.TabIndex = 3
        Me.ButtonNuevoCliente.Text = "Nueva Cliente"
        Me.ButtonNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNuevoCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 32)
        Me.Panel1.TabIndex = 2
        '
        'ButtonNuevaReserva
        '
        Me.ButtonNuevaReserva.FlatAppearance.BorderSize = 0
        Me.ButtonNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ButtonNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevaReserva.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevaReserva.ForeColor = System.Drawing.Color.White
        Me.ButtonNuevaReserva.Image = Global.Hotel.My.Resources.Resources.reserva
        Me.ButtonNuevaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNuevaReserva.Location = New System.Drawing.Point(3, 155)
        Me.ButtonNuevaReserva.Name = "ButtonNuevaReserva"
        Me.ButtonNuevaReserva.Size = New System.Drawing.Size(217, 32)
        Me.ButtonNuevaReserva.TabIndex = 1
        Me.ButtonNuevaReserva.Text = "Nueva Reserva"
        Me.ButtonNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNuevaReserva.UseVisualStyleBackColor = True
        '
        'PicktureBoxLogo
        '
        Me.PicktureBoxLogo.Image = Global.Hotel.My.Resources.Resources.logo
        Me.PicktureBoxLogo.Location = New System.Drawing.Point(0, 6)
        Me.PicktureBoxLogo.Name = "PicktureBoxLogo"
        Me.PicktureBoxLogo.Size = New System.Drawing.Size(220, 114)
        Me.PicktureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicktureBoxLogo.TabIndex = 0
        Me.PicktureBoxLogo.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1000, 1000)
        Me.PanelContenedor.TabIndex = 2
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 1038)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.BotonRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.ButtonSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicktureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents BotonCerrar As PictureBox
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BotonMaximizar As PictureBox
    Friend WithEvents BotonMinimizar As PictureBox
    Friend WithEvents BotonRestaurar As PictureBox
    Friend WithEvents PicktureBoxLogo As PictureBox
    Friend WithEvents ButtonNuevaReserva As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ButtonListaClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonNuevoCliente As Button
    Friend WithEvents ButtonSalir As PictureBox
End Class
