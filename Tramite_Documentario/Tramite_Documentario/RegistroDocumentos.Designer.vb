<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDocumentos
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
        Dim IdDocumentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroDocumentos))
        Me.ccbDependencia = New System.Windows.Forms.ComboBox()
        Me.TDOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TRAMITE = New Tramite_Documentario.BD_TRAMITE()
        Me.CbbSeleccionarDocumento = New System.Windows.Forms.ComboBox()
        Me.LblFechaVencimiento = New System.Windows.Forms.Label()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaRegistro = New System.Windows.Forms.Label()
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.CbbOrigenDocumento = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDependenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsuntoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDerivadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroRegistroMesa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbbDocumentoDerivado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TDOCUMENTOTableAdapter = New Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter()
        Me.TableAdapterManager = New Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager()
        Me.cbNombreSolicitante = New System.Windows.Forms.ComboBox()
        Me.TSOLICITANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSOLICITANTETableAdapter = New Tramite_Documentario.BD_TRAMITETableAdapters.TSOLICITANTETableAdapter()
        IdDocumentoLabel = New System.Windows.Forms.Label()
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TSOLICITANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdDocumentoLabel
        '
        IdDocumentoLabel.AutoSize = True
        IdDocumentoLabel.Location = New System.Drawing.Point(28, 32)
        IdDocumentoLabel.Name = "IdDocumentoLabel"
        IdDocumentoLabel.Size = New System.Drawing.Size(105, 18)
        IdDocumentoLabel.TabIndex = 94
        IdDocumentoLabel.Text = "Id Documento:"
        '
        'ccbDependencia
        '
        Me.ccbDependencia.CausesValidation = False
        Me.ccbDependencia.Cursor = System.Windows.Forms.Cursors.Help
        Me.ccbDependencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "NombreDependencia", True))
        Me.ccbDependencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccbDependencia.FormattingEnabled = True
        Me.ccbDependencia.Items.AddRange(New Object() {"COMISIÓN ACADÉMICA", "COMISIÓN DE GRADOS Y TITULOS", "COMISIÓN DE PROYECTOS", "COMISIÓN DE CONVALIDACIONES", "COMISIÓN DE RESPONSABILIDAD SOCIAL"})
        Me.ccbDependencia.Location = New System.Drawing.Point(158, 137)
        Me.ccbDependencia.Name = "ccbDependencia"
        Me.ccbDependencia.Size = New System.Drawing.Size(337, 26)
        Me.ccbDependencia.TabIndex = 92
        '
        'TDOCUMENTOBindingSource
        '
        Me.TDOCUMENTOBindingSource.DataMember = "TDOCUMENTO"
        Me.TDOCUMENTOBindingSource.DataSource = Me.BD_TRAMITE
        '
        'BD_TRAMITE
        '
        Me.BD_TRAMITE.DataSetName = "BD_TRAMITE"
        Me.BD_TRAMITE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbbSeleccionarDocumento
        '
        Me.CbbSeleccionarDocumento.CausesValidation = False
        Me.CbbSeleccionarDocumento.Cursor = System.Windows.Forms.Cursors.Help
        Me.CbbSeleccionarDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "TipoDocumento", True))
        Me.CbbSeleccionarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CbbSeleccionarDocumento.FormattingEnabled = True
        Me.CbbSeleccionarDocumento.Items.AddRange(New Object() {"SOLICITUD", "MEMORANDUM", "OFICIO", "RESOLUCION"})
        Me.CbbSeleccionarDocumento.Location = New System.Drawing.Point(158, 99)
        Me.CbbSeleccionarDocumento.Name = "CbbSeleccionarDocumento"
        Me.CbbSeleccionarDocumento.Size = New System.Drawing.Size(238, 26)
        Me.CbbSeleccionarDocumento.TabIndex = 91
        '
        'LblFechaVencimiento
        '
        Me.LblFechaVencimiento.AutoSize = True
        Me.LblFechaVencimiento.Location = New System.Drawing.Point(513, 30)
        Me.LblFechaVencimiento.Name = "LblFechaVencimiento"
        Me.LblFechaVencimiento.Size = New System.Drawing.Size(156, 18)
        Me.LblFechaVencimiento.TabIndex = 82
        Me.LblFechaVencimiento.Text = "Fecha de vencimiento:"
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.CausesValidation = False
        Me.dtpFechaVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "FechaVencimiento", True))
        Me.dtpFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(673, 24)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(154, 29)
        Me.dtpFechaVencimiento.TabIndex = 90
        '
        'LblFechaRegistro
        '
        Me.LblFechaRegistro.AutoSize = True
        Me.LblFechaRegistro.Location = New System.Drawing.Point(28, 190)
        Me.LblFechaRegistro.Name = "LblFechaRegistro"
        Me.LblFechaRegistro.Size = New System.Drawing.Size(127, 18)
        Me.LblFechaRegistro.TabIndex = 80
        Me.LblFechaRegistro.Text = "Fecha de registro:"
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRegistro.CausesValidation = False
        Me.dtpFechaRegistro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TDOCUMENTOBindingSource, "FechaInicio", True))
        Me.dtpFechaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(159, 185)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(154, 29)
        Me.dtpFechaRegistro.TabIndex = 89
        '
        'CbbOrigenDocumento
        '
        Me.CbbOrigenDocumento.CausesValidation = False
        Me.CbbOrigenDocumento.Cursor = System.Windows.Forms.Cursors.Help
        Me.CbbOrigenDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "OrigenDocumento", True))
        Me.CbbOrigenDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbOrigenDocumento.FormattingEnabled = True
        Me.CbbOrigenDocumento.Items.AddRange(New Object() {"DOCUMENTOS INTERNOS", "DOCUMENTOS EXTERNOS"})
        Me.CbbOrigenDocumento.Location = New System.Drawing.Point(672, 107)
        Me.CbbOrigenDocumento.Name = "CbbOrigenDocumento"
        Me.CbbOrigenDocumento.Size = New System.Drawing.Size(343, 32)
        Me.CbbOrigenDocumento.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDocumentoDataGridViewTextBoxColumn, Me.NroDocumentoDataGridViewTextBoxColumn, Me.TipoDocumentoDataGridViewTextBoxColumn, Me.NombreDependenciaDataGridViewTextBoxColumn, Me.AsuntoDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.DocumentoDerivadoDataGridViewTextBoxColumn, Me.OrigenDocumentoDataGridViewTextBoxColumn, Me.NombreSolicitanteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TDOCUMENTOBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 608)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1196, 129)
        Me.DataGridView1.TabIndex = 87
        '
        'IdDocumentoDataGridViewTextBoxColumn
        '
        Me.IdDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IdDocumento"
        Me.IdDocumentoDataGridViewTextBoxColumn.HeaderText = "IdDocumento"
        Me.IdDocumentoDataGridViewTextBoxColumn.Name = "IdDocumentoDataGridViewTextBoxColumn"
        Me.IdDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NroDocumentoDataGridViewTextBoxColumn
        '
        Me.NroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NroDocumento"
        Me.NroDocumentoDataGridViewTextBoxColumn.HeaderText = "NroDocumento"
        Me.NroDocumentoDataGridViewTextBoxColumn.Name = "NroDocumentoDataGridViewTextBoxColumn"
        Me.NroDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDocumentoDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Name = "TipoDocumentoDataGridViewTextBoxColumn"
        Me.TipoDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDependenciaDataGridViewTextBoxColumn
        '
        Me.NombreDependenciaDataGridViewTextBoxColumn.DataPropertyName = "NombreDependencia"
        Me.NombreDependenciaDataGridViewTextBoxColumn.HeaderText = "NombreDependencia"
        Me.NombreDependenciaDataGridViewTextBoxColumn.Name = "NombreDependenciaDataGridViewTextBoxColumn"
        Me.NombreDependenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsuntoDataGridViewTextBoxColumn
        '
        Me.AsuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.HeaderText = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.Name = "AsuntoDataGridViewTextBoxColumn"
        Me.AsuntoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentoDerivadoDataGridViewTextBoxColumn
        '
        Me.DocumentoDerivadoDataGridViewTextBoxColumn.DataPropertyName = "DocumentoDerivado"
        Me.DocumentoDerivadoDataGridViewTextBoxColumn.HeaderText = "DocumentoDerivado"
        Me.DocumentoDerivadoDataGridViewTextBoxColumn.Name = "DocumentoDerivadoDataGridViewTextBoxColumn"
        Me.DocumentoDerivadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrigenDocumentoDataGridViewTextBoxColumn
        '
        Me.OrigenDocumentoDataGridViewTextBoxColumn.DataPropertyName = "OrigenDocumento"
        Me.OrigenDocumentoDataGridViewTextBoxColumn.HeaderText = "OrigenDocumento"
        Me.OrigenDocumentoDataGridViewTextBoxColumn.Name = "OrigenDocumentoDataGridViewTextBoxColumn"
        Me.OrigenDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreSolicitanteDataGridViewTextBoxColumn
        '
        Me.NombreSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "NombreSolicitante"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.HeaderText = "NombreSolicitante"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.Name = "NombreSolicitanteDataGridViewTextBoxColumn"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tipo de documento:"
        '
        'txtNroRegistroMesa
        '
        Me.txtNroRegistroMesa.CausesValidation = False
        Me.txtNroRegistroMesa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "NroDocumento", True))
        Me.txtNroRegistroMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRegistroMesa.Location = New System.Drawing.Point(158, 64)
        Me.txtNroRegistroMesa.Name = "txtNroRegistroMesa"
        Me.txtNroRegistroMesa.Size = New System.Drawing.Size(139, 29)
        Me.txtNroRegistroMesa.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre/Dependencia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Registro de Mesa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdDocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.IdDocumentoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAsunto)
        Me.GroupBox1.Controls.Add(Me.ccbDependencia)
        Me.GroupBox1.Controls.Add(Me.CbbSeleccionarDocumento)
        Me.GroupBox1.Controls.Add(Me.LblFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.LblFechaRegistro)
        Me.GroupBox1.Controls.Add(Me.dtpFechaRegistro)
        Me.GroupBox1.Controls.Add(Me.CbbOrigenDocumento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbNombreSolicitante)
        Me.GroupBox1.Controls.Add(Me.CbbDocumentoDerivado)
        Me.GroupBox1.Controls.Add(Me.txtNroRegistroMesa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1145, 340)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos "
        '
        'IdDocumentoTextBox
        '
        Me.IdDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "IdDocumento", True))
        Me.IdDocumentoTextBox.Location = New System.Drawing.Point(158, 26)
        Me.IdDocumentoTextBox.Name = "IdDocumentoTextBox"
        Me.IdDocumentoTextBox.ReadOnly = True
        Me.IdDocumentoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.IdDocumentoTextBox.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "NombreSolicitante:"
        '
        'txtAsunto
        '
        Me.txtAsunto.CausesValidation = False
        Me.txtAsunto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "Asunto", True))
        Me.txtAsunto.Location = New System.Drawing.Point(158, 225)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(853, 42)
        Me.txtAsunto.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(513, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Origen de documento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Asunto del trámite:"
        '
        'CbbDocumentoDerivado
        '
        Me.CbbDocumentoDerivado.CausesValidation = False
        Me.CbbDocumentoDerivado.Cursor = System.Windows.Forms.Cursors.Help
        Me.CbbDocumentoDerivado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "DocumentoDerivado", True))
        Me.CbbDocumentoDerivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbDocumentoDerivado.FormattingEnabled = True
        Me.CbbDocumentoDerivado.Items.AddRange(New Object() {"Andahuaylas", "Lima", "Huancayo", "Puerto Maldonado", "Ayacucho", "Cusco"})
        Me.CbbDocumentoDerivado.Location = New System.Drawing.Point(673, 61)
        Me.CbbDocumentoDerivado.Name = "CbbDocumentoDerivado"
        Me.CbbDocumentoDerivado.Size = New System.Drawing.Size(343, 32)
        Me.CbbDocumentoDerivado.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(519, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Documento derivado:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1196, 47)
        Me.Panel1.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(425, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO DE DOCUMENTOS"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Window
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = Global.Tramite_Documentario.My.Resources.Resources._1downarrow
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(237, 485)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 44)
        Me.Button10.TabIndex = 89
        Me.Button10.Text = "&Final"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Window
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.Tramite_Documentario.My.Resources.Resources._1leftarrow
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(163, 485)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 44)
        Me.Button9.TabIndex = 89
        Me.Button9.Text = "&Anterior"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Window
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.Tramite_Documentario.My.Resources.Resources._1rightarrow
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(76, 485)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 44)
        Me.Button8.TabIndex = 89
        Me.Button8.Text = "&Siguiente"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Window
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Tramite_Documentario.My.Resources.Resources._1uparrow
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(3, 485)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 44)
        Me.Button7.TabIndex = 89
        Me.Button7.Text = "&Inicio"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(773, 417)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 39)
        Me.btnSalir.TabIndex = 88
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(431, 417)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 39)
        Me.btnEliminar.TabIndex = 88
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(659, 417)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 39)
        Me.btnCancelar.TabIndex = 88
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(545, 417)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(108, 39)
        Me.btnEditar.TabIndex = 88
        Me.btnEditar.Tag = ""
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(317, 417)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 39)
        Me.btnGuardar.TabIndex = 88
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(202, 417)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(109, 39)
        Me.btnNuevo.TabIndex = 88
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'TDOCUMENTOTableAdapter
        '
        Me.TDOCUMENTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TDERIVADATableAdapter = Nothing
        Me.TableAdapterManager.TDOCUMENTOTableAdapter = Me.TDOCUMENTOTableAdapter
        Me.TableAdapterManager.TLOGINTableAdapter = Nothing
        Me.TableAdapterManager.TSOLICITANTETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cbNombreSolicitante
        '
        Me.cbNombreSolicitante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbNombreSolicitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbNombreSolicitante.CausesValidation = False
        Me.cbNombreSolicitante.Cursor = System.Windows.Forms.Cursors.Help
        Me.cbNombreSolicitante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TDOCUMENTOBindingSource, "NombreSolicitante", True))
        Me.cbNombreSolicitante.DataSource = Me.TSOLICITANTEBindingSource
        Me.cbNombreSolicitante.DisplayMember = "NombreSolicitante"
        Me.cbNombreSolicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNombreSolicitante.FormattingEnabled = True
        Me.cbNombreSolicitante.Location = New System.Drawing.Point(672, 145)
        Me.cbNombreSolicitante.Name = "cbNombreSolicitante"
        Me.cbNombreSolicitante.Size = New System.Drawing.Size(343, 32)
        Me.cbNombreSolicitante.TabIndex = 8
        Me.cbNombreSolicitante.ValueMember = "DNI"
        '
        'TSOLICITANTEBindingSource
        '
        Me.TSOLICITANTEBindingSource.DataMember = "TSOLICITANTE"
        Me.TSOLICITANTEBindingSource.DataSource = Me.BD_TRAMITE
        '
        'TSOLICITANTETableAdapter
        '
        Me.TSOLICITANTETableAdapter.ClearBeforeFill = True
        '
        'RegistroDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1196, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistroDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroDocumentos"
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TSOLICITANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ccbDependencia As System.Windows.Forms.ComboBox
    Friend WithEvents CbbSeleccionarDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents LblFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaRegistro As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbbOrigenDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNroRegistroMesa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbbDocumentoDerivado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BD_TRAMITE As Tramite_Documentario.BD_TRAMITE
    Friend WithEvents TDOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TDOCUMENTOTableAdapter As Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter
    Friend WithEvents TableAdapterManager As Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager
    Friend WithEvents IdDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDependenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsuntoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDerivadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrigenDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreSolicitanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cbNombreSolicitante As System.Windows.Forms.ComboBox
    Friend WithEvents TSOLICITANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TSOLICITANTETableAdapter As Tramite_Documentario.BD_TRAMITETableAdapters.TSOLICITANTETableAdapter
End Class
