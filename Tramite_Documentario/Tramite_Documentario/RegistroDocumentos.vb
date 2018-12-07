Public Class RegistroDocumentos

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    'Private Sub TDOCUMENTOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.TDOCUMENTOBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.BD_TRAMITE)

    'End Sub

    Protected Sub BorrarCampos()
        txtNroRegistroMesa.Text = ""
        CbbSeleccionarDocumento.Text = ""
        ccbDependencia.Text = ""
        txtAsunto.Text = ""
        dtpFechaRegistro.Text = ""
        dtpFechaVencimiento.Text = ""
        CbbDocumentoDerivado.Text = ""
        CbbOrigenDocumento.Text = ""
        cbNombreSolicitante.Text = ""
    End Sub
    Protected Sub CamposActivos()
        txtNroRegistroMesa.Enabled = True
        CbbSeleccionarDocumento.Enabled = True
        ccbDependencia.Enabled = True
        txtAsunto.Enabled = True
        dtpFechaRegistro.Enabled = True
        dtpFechaVencimiento.Enabled = True
        CbbDocumentoDerivado.Enabled = True
        CbbOrigenDocumento.Enabled = True
        cbNombreSolicitante.Enabled = True
    End Sub
    Protected Sub CamposBloqueados()
        txtNroRegistroMesa.Enabled = False
        CbbSeleccionarDocumento.Enabled = False
        ccbDependencia.Enabled = False
        txtAsunto.Enabled = False
        dtpFechaRegistro.Enabled = False
        dtpFechaVencimiento.Enabled = False
        CbbDocumentoDerivado.Enabled = False
        CbbOrigenDocumento.Enabled = False
        cbNombreSolicitante.Enabled = False
    End Sub

    Private Sub RegistroDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TSOLICITANTE' Puede moverla o quitarla según sea necesario.
        Me.TSOLICITANTETableAdapter.Fill(Me.BD_TRAMITE.TSOLICITANTE)
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TDOCUMENTO' Puede moverla o quitarla según sea necesario.
        Me.TDOCUMENTOTableAdapter.Fill(Me.BD_TRAMITE.TDOCUMENTO)
        CamposBloqueados()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CamposActivos()
        BorrarCampos()
        btnGuardar.Tag = "GuardarInicio"
        txtNroRegistroMesa.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Tag = "GuardarInicio" Then
            Me.TDOCUMENTOTableAdapter.Insert(txtNroRegistroMesa.Text, CbbSeleccionarDocumento.Text, ccbDependencia.Text, txtAsunto.Text, dtpFechaRegistro.Text, dtpFechaVencimiento.Text, CbbDocumentoDerivado.Text, CbbOrigenDocumento.Text, cbNombreSolicitante.SelectedValue)
            RegistroDocumentos_Load(sender, e)
        ElseIf btnGuardar.Tag = "GuardarFin" Then
            Me.TDOCUMENTOTableAdapter.Actualizar(txtNroRegistroMesa.Text, CbbSeleccionarDocumento.Text, ccbDependencia.Text, txtAsunto.Text, dtpFechaRegistro.Text, dtpFechaVencimiento.Text, CbbDocumentoDerivado.Text, CbbOrigenDocumento.Text, cbNombreSolicitante.SelectedValue, IdDocumentoTextBox.Text)
            btnGuardar.Tag = "GuardarInicio"
            RegistroDocumentos_Load(sender, e)
        End If
       
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.TDOCUMENTOTableAdapter.Eliminar(IdDocumentoTextBox.Text)
        RegistroDocumentos_Load(sender, e)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        CamposActivos()
        btnGuardar.Tag = "GuardarFin"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RegistroDocumentos_Load(sender, e)
    End Sub
End Class