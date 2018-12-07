<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroSolicitante
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
        Dim DNILabel As System.Windows.Forms.Label
        Dim NombreSolicitanteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroSolicitante))
        Me.BD_TRAMITE = New Tramite_Documentario.BD_TRAMITE()
        Me.TSOLICITANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSOLICITANTETableAdapter = New Tramite_Documentario.BD_TRAMITETableAdapters.TSOLICITANTETableAdapter()
        Me.TableAdapterManager = New Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager()
        Me.txtDNI = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreSolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        DNILabel = New System.Windows.Forms.Label()
        NombreSolicitanteLabel = New System.Windows.Forms.Label()
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSOLICITANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDNI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_TRAMITE
        '
        Me.BD_TRAMITE.DataSetName = "BD_TRAMITE"
        Me.BD_TRAMITE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TDERIVADATableAdapter = Nothing
        Me.TableAdapterManager.TDOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.TLOGINTableAdapter = Nothing
        Me.TableAdapterManager.TSOLICITANTETableAdapter = Me.TSOLICITANTETableAdapter
        Me.TableAdapterManager.UpdateOrder = Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(22, 25)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 0
        DNILabel.Text = "DNI:"
        '
        'txtDNI
        '
        Me.txtDNI.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TSOLICITANTEBindingSource, "DNI", True))
        Me.txtDNI.Location = New System.Drawing.Point(126, 22)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 1
        '
        'NombreSolicitanteLabel
        '
        NombreSolicitanteLabel.AutoSize = True
        NombreSolicitanteLabel.Location = New System.Drawing.Point(21, 53)
        NombreSolicitanteLabel.Name = "NombreSolicitanteLabel"
        NombreSolicitanteLabel.Size = New System.Drawing.Size(99, 13)
        NombreSolicitanteLabel.TabIndex = 2
        NombreSolicitanteLabel.Text = "Nombre Solicitante:"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TSOLICITANTEBindingSource, "NombreSolicitante", True))
        Me.txtNombre.Location = New System.Drawing.Point(126, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreSolicitanteDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TSOLICITANTEBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(248, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'NombreSolicitanteDataGridViewTextBoxColumn
        '
        Me.NombreSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "NombreSolicitante"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.HeaderText = "NombreSolicitante"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.Name = "NombreSolicitanteDataGridViewTextBoxColumn"
        Me.NombreSolicitanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 93)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(109, 39)
        Me.btnNuevo.TabIndex = 89
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(128, 93)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 39)
        Me.btnGuardar.TabIndex = 90
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(13, 149)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 39)
        Me.btnEliminar.TabIndex = 91
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(128, 149)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 39)
        Me.btnCancelar.TabIndex = 92
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'RegistroSolicitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 372)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(NombreSolicitanteLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.txtDNI)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistroSolicitante"
        Me.Text = "Registro Solicitante"
        CType(Me.BD_TRAMITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSOLICITANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDNI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_TRAMITE As Tramite_Documentario.BD_TRAMITE
    Friend WithEvents TSOLICITANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TSOLICITANTETableAdapter As Tramite_Documentario.BD_TRAMITETableAdapters.TSOLICITANTETableAdapter
    Friend WithEvents TableAdapterManager As Tramite_Documentario.BD_TRAMITETableAdapters.TableAdapterManager
    Friend WithEvents txtDNI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NombreSolicitanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
