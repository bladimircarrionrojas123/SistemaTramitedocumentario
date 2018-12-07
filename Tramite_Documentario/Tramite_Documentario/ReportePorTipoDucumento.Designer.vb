<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePorTipoDucumento
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TDOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TRAMITE = New Tramite_Documentario.BD_TRAMITE()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TDOCUMENTOTableAdapter = New Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtnNombre = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.rbtnTipo = New System.Windows.Forms.RadioButton()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtBuscarDocumento = New System.Windows.Forms.TextBox()
        Me.CbbSeleccionarDocumento = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource2.Name = "DocumentosPorTipo"
        ReportDataSource2.Value = Me.TDOCUMENTOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tramite_Documentario.DocumentoPorTipo.rdlc"
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 151)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(846, 404)
        Me.ReportViewer1.TabIndex = 0
        '
        'TDOCUMENTOTableAdapter
        '
        Me.TDOCUMENTOTableAdapter.ClearBeforeFill = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaFin.Location = New System.Drawing.Point(454, 95)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(144, 29)
        Me.dtpFechaFin.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(198, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(399, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Hasta"
        '
        'rbtnNombre
        '
        Me.rbtnNombre.AutoSize = True
        Me.rbtnNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNombre.Location = New System.Drawing.Point(38, 57)
        Me.rbtnNombre.Name = "rbtnNombre"
        Me.rbtnNombre.Size = New System.Drawing.Size(215, 28)
        Me.rbtnNombre.TabIndex = 118
        Me.rbtnNombre.TabStop = True
        Me.rbtnNombre.Text = "Nombre del solicitante"
        Me.rbtnNombre.UseVisualStyleBackColor = True
        '
        'rbtnFecha
        '
        Me.rbtnFecha.AutoSize = True
        Me.rbtnFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFecha.Location = New System.Drawing.Point(38, 92)
        Me.rbtnFecha.Name = "rbtnFecha"
        Me.rbtnFecha.Size = New System.Drawing.Size(82, 28)
        Me.rbtnFecha.TabIndex = 117
        Me.rbtnFecha.TabStop = True
        Me.rbtnFecha.Text = "Fecha"
        Me.rbtnFecha.UseVisualStyleBackColor = True
        '
        'rbtnTipo
        '
        Me.rbtnTipo.AutoSize = True
        Me.rbtnTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTipo.Location = New System.Drawing.Point(38, 12)
        Me.rbtnTipo.Name = "rbtnTipo"
        Me.rbtnTipo.Size = New System.Drawing.Size(196, 28)
        Me.rbtnTipo.TabIndex = 116
        Me.rbtnTipo.TabStop = True
        Me.rbtnTipo.Text = "Tipo de Documento"
        Me.rbtnTipo.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaInicio.Location = New System.Drawing.Point(257, 92)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(133, 29)
        Me.dtpFechaInicio.TabIndex = 115
        '
        'txtBuscarDocumento
        '
        Me.txtBuscarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarDocumento.Location = New System.Drawing.Point(257, 57)
        Me.txtBuscarDocumento.Name = "txtBuscarDocumento"
        Me.txtBuscarDocumento.Size = New System.Drawing.Size(405, 29)
        Me.txtBuscarDocumento.TabIndex = 114
        '
        'CbbSeleccionarDocumento
        '
        Me.CbbSeleccionarDocumento.Cursor = System.Windows.Forms.Cursors.Help
        Me.CbbSeleccionarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbSeleccionarDocumento.FormattingEnabled = True
        Me.CbbSeleccionarDocumento.Items.AddRange(New Object() {"SOLICITUD", "MEMORANDUM", "OFICIO", "RESOLUCION"})
        Me.CbbSeleccionarDocumento.Location = New System.Drawing.Point(257, 11)
        Me.CbbSeleccionarDocumento.Name = "CbbSeleccionarDocumento"
        Me.CbbSeleccionarDocumento.Size = New System.Drawing.Size(232, 32)
        Me.CbbSeleccionarDocumento.TabIndex = 113
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Tramite_Documentario.My.Resources.Resources.Buscar1
        Me.btnBuscar.Location = New System.Drawing.Point(712, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 58)
        Me.btnBuscar.TabIndex = 122
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ReportePorTipoDucumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 555)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtnNombre)
        Me.Controls.Add(Me.rbtnFecha)
        Me.Controls.Add(Me.rbtnTipo)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.txtBuscarDocumento)
        Me.Controls.Add(Me.CbbSeleccionarDocumento)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePorTipoDucumento"
        Me.Text = "ReportePorTipoDucumento"
        CType(Me.TDOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TDOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BD_TRAMITE As Tramite_Documentario.BD_TRAMITE
    Friend WithEvents TDOCUMENTOTableAdapter As Tramite_Documentario.BD_TRAMITETableAdapters.TDOCUMENTOTableAdapter
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbtnNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTipo As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBuscarDocumento As System.Windows.Forms.TextBox
    Friend WithEvents CbbSeleccionarDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
