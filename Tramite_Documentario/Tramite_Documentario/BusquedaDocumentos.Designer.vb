<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaDocumentos))
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtBuscarDocumento = New System.Windows.Forms.TextBox()
        Me.CbbSeleccionarDocumento = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.rbtnTipo = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.rbtnNombre = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
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
        Me.TDOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TRAMITE = New Tramite_Documentario.BD_TRAMITE()
        Me.TDOCUMENTOTableAdapter = New Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaInicio.Location = New System.Drawing.Point(246, 162)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(133, 29)
        Me.dtpFechaInicio.TabIndex = 99
        '
        'txtBuscarDocumento
        '
        Me.txtBuscarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarDocumento.Location = New System.Drawing.Point(246, 127)
        Me.txtBuscarDocumento.Name = "txtBuscarDocumento"
        Me.txtBuscarDocumento.Size = New System.Drawing.Size(405, 29)
        Me.txtBuscarDocumento.TabIndex = 93
        '
        'CbbSeleccionarDocumento
        '
        Me.CbbSeleccionarDocumento.Cursor = System.Windows.Forms.Cursors.Help
        Me.CbbSeleccionarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbSeleccionarDocumento.FormattingEnabled = True
        Me.CbbSeleccionarDocumento.Items.AddRange(New Object() {"SOLICITUD", "MEMORANDUM", "OFICIO", "RESOLUCION"})
        Me.CbbSeleccionarDocumento.Location = New System.Drawing.Point(246, 81)
        Me.CbbSeleccionarDocumento.Name = "CbbSeleccionarDocumento"
        Me.CbbSeleccionarDocumento.Size = New System.Drawing.Size(232, 32)
        Me.CbbSeleccionarDocumento.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 65)
        Me.Panel1.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(219, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BÚCAR DOCUMENTOS"
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.Image = Global.Tramite_Documentario.My.Resources.Resources.imprimir
        Me.BTNIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(684, 155)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(122, 39)
        Me.BTNIMPRIMIR.TabIndex = 102
        Me.BTNIMPRIMIR.Text = "&IMPRIMIR"
        Me.BTNIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(699, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 39)
        Me.Button6.TabIndex = 101
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Tramite_Documentario.My.Resources.Resources.Buscar1
        Me.Button1.Location = New System.Drawing.Point(684, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 58)
        Me.Button1.TabIndex = 94
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Window
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = Global.Tramite_Documentario.My.Resources.Resources._1downarrow
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(246, 264)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 44)
        Me.Button10.TabIndex = 103
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
        Me.Button9.Location = New System.Drawing.Point(172, 264)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 44)
        Me.Button9.TabIndex = 104
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
        Me.Button8.Location = New System.Drawing.Point(85, 264)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 44)
        Me.Button8.TabIndex = 105
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
        Me.Button7.Location = New System.Drawing.Point(12, 264)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 44)
        Me.Button7.TabIndex = 106
        Me.Button7.Text = "&Inicio"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'rbtnTipo
        '
        Me.rbtnTipo.AutoSize = True
        Me.rbtnTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTipo.Location = New System.Drawing.Point(27, 82)
        Me.rbtnTipo.Name = "rbtnTipo"
        Me.rbtnTipo.Size = New System.Drawing.Size(196, 28)
        Me.rbtnTipo.TabIndex = 107
        Me.rbtnTipo.TabStop = True
        Me.rbtnTipo.Text = "Tipo de Documento"
        Me.rbtnTipo.UseVisualStyleBackColor = True
        '
        'rbtnFecha
        '
        Me.rbtnFecha.AutoSize = True
        Me.rbtnFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFecha.Location = New System.Drawing.Point(27, 162)
        Me.rbtnFecha.Name = "rbtnFecha"
        Me.rbtnFecha.Size = New System.Drawing.Size(82, 28)
        Me.rbtnFecha.TabIndex = 108
        Me.rbtnFecha.TabStop = True
        Me.rbtnFecha.Text = "Fecha"
        Me.rbtnFecha.UseVisualStyleBackColor = True
        '
        'rbtnNombre
        '
        Me.rbtnNombre.AutoSize = True
        Me.rbtnNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNombre.Location = New System.Drawing.Point(27, 127)
        Me.rbtnNombre.Name = "rbtnNombre"
        Me.rbtnNombre.Size = New System.Drawing.Size(215, 28)
        Me.rbtnNombre.TabIndex = 109
        Me.rbtnNombre.TabStop = True
        Me.rbtnNombre.Text = "Nombre del solicitante"
        Me.rbtnNombre.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(187, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(388, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Hasta"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaFin.Location = New System.Drawing.Point(443, 165)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(144, 29)
        Me.dtpFechaFin.TabIndex = 112
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(834, 164)
        Me.DataGridView1.TabIndex = 113
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
        'TDOCUMENTOTableAdapter
        '
        Me.TDOCUMENTOTableAdapter.ClearBeforeFill = True
        '
        'BusquedaDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(834, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtnNombre)
        Me.Controls.Add(Me.rbtnFecha)
        Me.Controls.Add(Me.rbtnTipo)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuscarDocumento)
        Me.Controls.Add(Me.CbbSeleccionarDocumento)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaDocumentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBuscarDocumento As System.Windows.Forms.TextBox
    Friend WithEvents CbbSeleccionarDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents rbtnTipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNombre As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BD_TRAMITE As Tramite_Documentario.BD_TRAMITE
    Friend WithEvents TDOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TDOCUMENTOTableAdapter As Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter
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
End Class
