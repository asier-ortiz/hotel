<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaClientes
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewBusquedas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHANACIMIENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPOSTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDataSet = New Hotel.HotelDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RESERVAS_HABITACIONESDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxEditarCliente = New System.Windows.Forms.GroupBox()
        Me.GroupBoxBuscarCliente = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxFiltrosBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxCriterioFiltro = New System.Windows.Forms.TextBox()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxPais = New System.Windows.Forms.TextBox()
        Me.ButtonEditarCliente = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.CLIENTETableAdapter = New Hotel.HotelDataSetTableAdapters.CLIENTETableAdapter()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewBusquedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RESERVAS_HABITACIONESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEditarCliente.SuspendLayout()
        Me.GroupBoxBuscarCliente.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DataGridViewBusquedas)
        Me.GroupBox1.Controls.Add(Me.CLIENTEDataGridView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 300)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'DataGridViewBusquedas
        '
        Me.DataGridViewBusquedas.AllowUserToAddRows = False
        Me.DataGridViewBusquedas.AllowUserToDeleteRows = False
        Me.DataGridViewBusquedas.AllowUserToResizeRows = False
        Me.DataGridViewBusquedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBusquedas.ColumnHeadersHeight = 29
        Me.DataGridViewBusquedas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridViewBusquedas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewBusquedas.Location = New System.Drawing.Point(3, 18)
        Me.DataGridViewBusquedas.MultiSelect = False
        Me.DataGridViewBusquedas.Name = "DataGridViewBusquedas"
        Me.DataGridViewBusquedas.ReadOnly = True
        Me.DataGridViewBusquedas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewBusquedas.RowTemplate.Height = 24
        Me.DataGridViewBusquedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusquedas.Size = New System.Drawing.Size(994, 279)
        Me.DataGridViewBusquedas.TabIndex = 1
        Me.DataGridViewBusquedas.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_CLIENTE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "APELLIDOS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "FECHA_NACIMIENTO"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TELEFONO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "EMAIL"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "DIRECCION"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "COD_POSTAL"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "LOCALIDAD"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "PAIS"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'CLIENTEDataGridView
        '
        Me.CLIENTEDataGridView.AllowUserToAddRows = False
        Me.CLIENTEDataGridView.AllowUserToDeleteRows = False
        Me.CLIENTEDataGridView.AllowUserToResizeRows = False
        Me.CLIENTEDataGridView.AutoGenerateColumns = False
        Me.CLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOSDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FECHANACIMIENTODataGridViewTextBoxColumn, Me.TELEFONODataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.DIRECCIONDataGridViewTextBoxColumn, Me.CODPOSTALDataGridViewTextBoxColumn, Me.LOCALIDADDataGridViewTextBoxColumn, Me.PAISDataGridViewTextBoxColumn})
        Me.CLIENTEDataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.CLIENTEDataGridView.DataSource = Me.CLIENTEBindingSource
        Me.CLIENTEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLIENTEDataGridView.Location = New System.Drawing.Point(3, 18)
        Me.CLIENTEDataGridView.MultiSelect = False
        Me.CLIENTEDataGridView.Name = "CLIENTEDataGridView"
        Me.CLIENTEDataGridView.ReadOnly = True
        Me.CLIENTEDataGridView.RowHeadersWidth = 51
        Me.CLIENTEDataGridView.RowTemplate.Height = 24
        Me.CLIENTEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CLIENTEDataGridView.Size = New System.Drawing.Size(994, 279)
        Me.CLIENTEDataGridView.TabIndex = 0
        '
        'IDCLIENTEDataGridViewTextBoxColumn
        '
        Me.IDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE"
        Me.IDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE"
        Me.IDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCLIENTEDataGridViewTextBoxColumn.Name = "IDCLIENTEDataGridViewTextBoxColumn"
        Me.IDCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCLIENTEDataGridViewTextBoxColumn.Width = 86
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 85
        '
        'APELLIDOSDataGridViewTextBoxColumn
        '
        Me.APELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.APELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APELLIDOSDataGridViewTextBoxColumn.Name = "APELLIDOSDataGridViewTextBoxColumn"
        Me.APELLIDOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.APELLIDOSDataGridViewTextBoxColumn.Width = 86
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DNIDataGridViewTextBoxColumn.Width = 85
        '
        'FECHANACIMIENTODataGridViewTextBoxColumn
        '
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_NACIMIENTO"
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_NACIMIENTO"
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.Name = "FECHANACIMIENTODataGridViewTextBoxColumn"
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.Width = 86
        '
        'TELEFONODataGridViewTextBoxColumn
        '
        Me.TELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TELEFONODataGridViewTextBoxColumn.Name = "TELEFONODataGridViewTextBoxColumn"
        Me.TELEFONODataGridViewTextBoxColumn.ReadOnly = True
        Me.TELEFONODataGridViewTextBoxColumn.Width = 85
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMAILDataGridViewTextBoxColumn.Width = 86
        '
        'DIRECCIONDataGridViewTextBoxColumn
        '
        Me.DIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DIRECCIONDataGridViewTextBoxColumn.Name = "DIRECCIONDataGridViewTextBoxColumn"
        Me.DIRECCIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DIRECCIONDataGridViewTextBoxColumn.Width = 85
        '
        'CODPOSTALDataGridViewTextBoxColumn
        '
        Me.CODPOSTALDataGridViewTextBoxColumn.DataPropertyName = "COD_POSTAL"
        Me.CODPOSTALDataGridViewTextBoxColumn.HeaderText = "COD_POSTAL"
        Me.CODPOSTALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODPOSTALDataGridViewTextBoxColumn.Name = "CODPOSTALDataGridViewTextBoxColumn"
        Me.CODPOSTALDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODPOSTALDataGridViewTextBoxColumn.Width = 86
        '
        'LOCALIDADDataGridViewTextBoxColumn
        '
        Me.LOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "LOCALIDAD"
        Me.LOCALIDADDataGridViewTextBoxColumn.HeaderText = "LOCALIDAD"
        Me.LOCALIDADDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOCALIDADDataGridViewTextBoxColumn.Name = "LOCALIDADDataGridViewTextBoxColumn"
        Me.LOCALIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOCALIDADDataGridViewTextBoxColumn.Width = 85
        '
        'PAISDataGridViewTextBoxColumn
        '
        Me.PAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS"
        Me.PAISDataGridViewTextBoxColumn.HeaderText = "PAIS"
        Me.PAISDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PAISDataGridViewTextBoxColumn.Name = "PAISDataGridViewTextBoxColumn"
        Me.PAISDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAISDataGridViewTextBoxColumn.Width = 86
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.HotelDataSet
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "HotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RESERVAS_HABITACIONESDataGridView)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 700)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 300)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reservas"
        '
        'RESERVAS_HABITACIONESDataGridView
        '
        Me.RESERVAS_HABITACIONESDataGridView.AllowUserToAddRows = False
        Me.RESERVAS_HABITACIONESDataGridView.AllowUserToDeleteRows = False
        Me.RESERVAS_HABITACIONESDataGridView.AllowUserToResizeRows = False
        Me.RESERVAS_HABITACIONESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RESERVAS_HABITACIONESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RESERVAS_HABITACIONESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column18, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17})
        Me.RESERVAS_HABITACIONESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RESERVAS_HABITACIONESDataGridView.Location = New System.Drawing.Point(3, 18)
        Me.RESERVAS_HABITACIONESDataGridView.MultiSelect = False
        Me.RESERVAS_HABITACIONESDataGridView.Name = "RESERVAS_HABITACIONESDataGridView"
        Me.RESERVAS_HABITACIONESDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RESERVAS_HABITACIONESDataGridView.RowTemplate.Height = 24
        Me.RESERVAS_HABITACIONESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RESERVAS_HABITACIONESDataGridView.Size = New System.Drawing.Size(994, 279)
        Me.RESERVAS_HABITACIONESDataGridView.TabIndex = 0
        '
        'GroupBoxEditarCliente
        '
        Me.GroupBoxEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GroupBoxEditarCliente.Controls.Add(Me.GroupBoxBuscarCliente)
        Me.GroupBoxEditarCliente.Controls.Add(Me.GroupBox4)
        Me.GroupBoxEditarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxEditarCliente.Location = New System.Drawing.Point(0, 300)
        Me.GroupBoxEditarCliente.Name = "GroupBoxEditarCliente"
        Me.GroupBoxEditarCliente.Size = New System.Drawing.Size(1000, 400)
        Me.GroupBoxEditarCliente.TabIndex = 30
        Me.GroupBoxEditarCliente.TabStop = False
        Me.GroupBoxEditarCliente.Text = "Editar Cliente"
        '
        'GroupBoxBuscarCliente
        '
        Me.GroupBoxBuscarCliente.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBoxBuscarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxBuscarCliente.Location = New System.Drawing.Point(522, 18)
        Me.GroupBoxBuscarCliente.Name = "GroupBoxBuscarCliente"
        Me.GroupBoxBuscarCliente.Size = New System.Drawing.Size(475, 379)
        Me.GroupBoxBuscarCliente.TabIndex = 31
        Me.GroupBoxBuscarCliente.TabStop = False
        Me.GroupBoxBuscarCliente.Text = "Buscar Cliente"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel2.Controls.Add(Me.ComboBoxFiltrosBuscarCliente)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxCriterioFiltro)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonBuscarCliente)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonLimpiar)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(221, 358)
        Me.FlowLayoutPanel2.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Filtro"
        '
        'ComboBoxFiltrosBuscarCliente
        '
        Me.ComboBoxFiltrosBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFiltrosBuscarCliente.FormattingEnabled = True
        Me.ComboBoxFiltrosBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBoxFiltrosBuscarCliente.Items.AddRange(New Object() {"ID", "Nombre", "Apellidos", "DNI", "Fecha Nacimiento", "Teléfono", "E-Mail", "Dirección", "Cod. Postal", "Localidad", "País"})
        Me.ComboBoxFiltrosBuscarCliente.Location = New System.Drawing.Point(3, 20)
        Me.ComboBoxFiltrosBuscarCliente.Name = "ComboBoxFiltrosBuscarCliente"
        Me.ComboBoxFiltrosBuscarCliente.Size = New System.Drawing.Size(214, 24)
        Me.ComboBoxFiltrosBuscarCliente.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(3, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Criterio"
        '
        'TextBoxCriterioFiltro
        '
        Me.TextBoxCriterioFiltro.Location = New System.Drawing.Point(3, 67)
        Me.TextBoxCriterioFiltro.Name = "TextBoxCriterioFiltro"
        Me.TextBoxCriterioFiltro.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxCriterioFiltro.TabIndex = 16
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(3, 95)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(104, 43)
        Me.ButtonBuscarCliente.TabIndex = 34
        Me.ButtonBuscarCliente.Text = "Buscar"
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(113, 95)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(104, 43)
        Me.ButtonLimpiar.TabIndex = 36
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(519, 379)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxEmail)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxDireccion)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxLocalidad)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxCodigoPostal)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxPais)
        Me.FlowLayoutPanel3.Controls.Add(Me.ButtonEditarCliente)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(261, 18)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(255, 358)
        Me.FlowLayoutPanel3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "E-Mail"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(3, 20)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxEmail.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dirección"
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(3, 65)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxDireccion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(3, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Localidad"
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(3, 110)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxLocalidad.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cod. Postal"
        '
        'TextBoxCodigoPostal
        '
        Me.TextBoxCodigoPostal.Location = New System.Drawing.Point(3, 155)
        Me.TextBoxCodigoPostal.Name = "TextBoxCodigoPostal"
        Me.TextBoxCodigoPostal.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxCodigoPostal.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(3, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "País"
        '
        'TextBoxPais
        '
        Me.TextBoxPais.Location = New System.Drawing.Point(3, 200)
        Me.TextBoxPais.Name = "TextBoxPais"
        Me.TextBoxPais.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxPais.TabIndex = 5
        '
        'ButtonEditarCliente
        '
        Me.ButtonEditarCliente.Location = New System.Drawing.Point(3, 228)
        Me.ButtonEditarCliente.Name = "ButtonEditarCliente"
        Me.ButtonEditarCliente.Size = New System.Drawing.Size(104, 43)
        Me.ButtonEditarCliente.TabIndex = 33
        Me.ButtonEditarCliente.Text = "Guardar"
        Me.ButtonEditarCliente.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxNombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxApellidos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxDni)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePickerFechaNacimiento)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxTelefono)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(258, 358)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(3, 20)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Apellidos"
        '
        'TextBoxApellidos
        '
        Me.TextBoxApellidos.Location = New System.Drawing.Point(3, 65)
        Me.TextBoxApellidos.Name = "TextBoxApellidos"
        Me.TextBoxApellidos.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxApellidos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DNI"
        '
        'TextBoxDni
        '
        Me.TextBoxDni.Location = New System.Drawing.Point(3, 110)
        Me.TextBoxDni.Name = "TextBoxDni"
        Me.TextBoxDni.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxDni.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(3, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "F.Nacimiento"
        '
        'DateTimePickerFechaNacimiento
        '
        Me.DateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaNacimiento.Location = New System.Drawing.Point(3, 155)
        Me.DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento"
        Me.DateTimePickerFechaNacimiento.Size = New System.Drawing.Size(250, 22)
        Me.DateTimePickerFechaNacimiento.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(3, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Teléfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(3, 200)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxTelefono.TabIndex = 5
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "ID_CLIENTE"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "ID_RESERVA"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.HeaderText = "ID_HABITACION"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "ID_EMPLEADO"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "FECHA_INICIO"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "FECHA_FIN"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "SUPLETORIA"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "CANCELAR"
        Me.Column17.MinimumWidth = 6
        Me.Column17.Name = "Column17"
        Me.Column17.Text = "X"
        Me.Column17.UseColumnTextForButtonValue = True
        '
        'ListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.GroupBoxEditarCliente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaClientes"
        Me.Text = "ListaClientes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewBusquedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.RESERVAS_HABITACIONESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEditarCliente.ResumeLayout(False)
        Me.GroupBoxBuscarCliente.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CLIENTEDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RESERVAS_HABITACIONESDataGridView As DataGridView
    Friend WithEvents GroupBoxEditarCliente As GroupBox
    Friend WithEvents GroupBoxBuscarCliente As GroupBox
    Friend WithEvents ComboBoxFiltrosBuscarCliente As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCodigoPostal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDni As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerFechaNacimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents HotelDataSet As HotelDataSet
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As HotelDataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents IDCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHANACIMIENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODPOSTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonEditarCliente As Button
    Friend WithEvents TextBoxCriterioFiltro As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents DataGridViewBusquedas As DataGridView
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewButtonColumn
End Class
