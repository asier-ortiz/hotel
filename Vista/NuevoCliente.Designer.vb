<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.GroupBoxDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDni = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.LabelIdNuevoCliente = New System.Windows.Forms.Label()
        Me.ButtonLimpiarCampos = New System.Windows.Forms.Button()
        Me.ButtonCrearCliente = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        Me.GroupBoxDatosPersonales.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.GroupBoxDatosPersonales)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1000, 1000)
        Me.PanelContenedor.TabIndex = 0
        '
        'GroupBoxDatosPersonales
        '
        Me.GroupBoxDatosPersonales.Controls.Add(Me.PanelDatos)
        Me.GroupBoxDatosPersonales.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxDatosPersonales.Name = "GroupBoxDatosPersonales"
        Me.GroupBoxDatosPersonales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBoxDatosPersonales.Size = New System.Drawing.Size(1000, 1000)
        Me.GroupBoxDatosPersonales.TabIndex = 11
        Me.GroupBoxDatosPersonales.TabStop = False
        Me.GroupBoxDatosPersonales.Text = "Datos Personales"
        '
        'PanelDatos
        '
        Me.PanelDatos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelDatos.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelDatos.Controls.Add(Me.LabelIdNuevoCliente)
        Me.PanelDatos.Controls.Add(Me.ButtonLimpiarCampos)
        Me.PanelDatos.Controls.Add(Me.ButtonCrearCliente)
        Me.PanelDatos.Controls.Add(Me.FlowLayoutPanel2)
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Location = New System.Drawing.Point(235, 332)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(528, 311)
        Me.PanelDatos.TabIndex = 26
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxNombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxApellidos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxDni)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePickerFechaNacimiento)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxTelefono)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 29)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(258, 227)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(3, 20)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxNombre.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellidos"
        '
        'TextBoxApellidos
        '
        Me.TextBoxApellidos.Location = New System.Drawing.Point(3, 65)
        Me.TextBoxApellidos.Name = "TextBoxApellidos"
        Me.TextBoxApellidos.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxApellidos.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DNI"
        '
        'TextBoxDni
        '
        Me.TextBoxDni.Location = New System.Drawing.Point(3, 110)
        Me.TextBoxDni.Name = "TextBoxDni"
        Me.TextBoxDni.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxDni.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(3, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha nacimiento"
        '
        'DateTimePickerFechaNacimiento
        '
        Me.DateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaNacimiento.Location = New System.Drawing.Point(3, 155)
        Me.DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento"
        Me.DateTimePickerFechaNacimiento.Size = New System.Drawing.Size(250, 22)
        Me.DateTimePickerFechaNacimiento.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(3, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Teléfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(3, 200)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxTelefono.TabIndex = 4
        '
        'LabelIdNuevoCliente
        '
        Me.LabelIdNuevoCliente.AutoSize = True
        Me.LabelIdNuevoCliente.Location = New System.Drawing.Point(113, 9)
        Me.LabelIdNuevoCliente.Name = "LabelIdNuevoCliente"
        Me.LabelIdNuevoCliente.Size = New System.Drawing.Size(13, 17)
        Me.LabelIdNuevoCliente.TabIndex = 24
        Me.LabelIdNuevoCliente.Text = "-"
        '
        'ButtonLimpiarCampos
        '
        Me.ButtonLimpiarCampos.Location = New System.Drawing.Point(311, 262)
        Me.ButtonLimpiarCampos.Name = "ButtonLimpiarCampos"
        Me.ButtonLimpiarCampos.Size = New System.Drawing.Size(104, 43)
        Me.ButtonLimpiarCampos.TabIndex = 25
        Me.ButtonLimpiarCampos.Text = "Limpiar"
        Me.ButtonLimpiarCampos.UseVisualStyleBackColor = True
        '
        'ButtonCrearCliente
        '
        Me.ButtonCrearCliente.Location = New System.Drawing.Point(421, 262)
        Me.ButtonCrearCliente.Name = "ButtonCrearCliente"
        Me.ButtonCrearCliente.Size = New System.Drawing.Size(104, 43)
        Me.ButtonCrearCliente.TabIndex = 10
        Me.ButtonCrearCliente.Text = "Crear"
        Me.ButtonCrearCliente.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxEmail)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxDireccion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxLocalidad)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxCodigoPostal)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxPais)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(267, 29)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(258, 227)
        Me.FlowLayoutPanel2.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "E-Mail"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(3, 20)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxEmail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(3, 65)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxDireccion.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Localidad"
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(3, 110)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxLocalidad.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(3, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cod. Postal"
        '
        'TextBoxCodigoPostal
        '
        Me.TextBoxCodigoPostal.Location = New System.Drawing.Point(3, 155)
        Me.TextBoxCodigoPostal.Name = "TextBoxCodigoPostal"
        Me.TextBoxCodigoPostal.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxCodigoPostal.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(3, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "País"
        '
        'TextBoxPais
        '
        Me.TextBoxPais.Location = New System.Drawing.Point(3, 200)
        Me.TextBoxPais.Name = "TextBoxPais"
        Me.TextBoxPais.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxPais.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID Nuevo Cliente"
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoCliente"
        Me.Text = "NuevoCliente"
        Me.PanelContenedor.ResumeLayout(False)
        Me.GroupBoxDatosPersonales.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents GroupBoxDatosPersonales As GroupBox
    Friend WithEvents ButtonLimpiarCampos As Button
    Friend WithEvents LabelIdNuevoCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCodigoPostal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDni As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePickerFechaNacimiento As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents ButtonCrearCliente As Button
    Friend WithEvents PanelDatos As Panel
End Class
