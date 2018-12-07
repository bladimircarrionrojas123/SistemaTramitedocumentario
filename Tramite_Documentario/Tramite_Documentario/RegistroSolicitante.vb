Public Class RegistroSolicitante

    'Private Sub TSOLICITANTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TSOLICITANTEBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.TSOLICITANTEBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.BD_TRAMITE)
    'End Sub
    Protected Sub BorrarCampos()
        txtDNI.Text = ""
        txtNombre.Text = ""
    End Sub
    Protected Sub CamposActivos()
        txtDNI.Enabled = True
        txtNombre.Enabled = True
    End Sub
    Protected Sub CamposBloqueados()
        txtDNI.Enabled = False
        txtNombre.Enabled = False
    End Sub
    Private Sub RegistroSolicitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TSOLICITANTE' Puede moverla o quitarla según sea necesario.
        Me.TSOLICITANTETableAdapter.Fill(Me.BD_TRAMITE.TSOLICITANTE)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CamposActivos()
        BorrarCampos()
        btnGuardar.Tag = "GuardarInicio"
        txtDNI.Focus()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Tag = "GuardarInicio" Then
            Me.TSOLICITANTETableAdapter.Insert(txtNroRegistroMesa.Text, CbbSeleccionarDocumento.Text, ccbDependencia.Text, txtAsunto.Text, dtpFechaRegistro.Text, dtpFechaVencimiento.Text, CbbDocumentoDerivado.Text, CbbOrigenDocumento.Text, cbNombreSolicitante.SelectedValue)
            RegistroSolicitante_Load(sender, e)
        ElseIf btnGuardar.Tag = "GuardarFin" Then
            Me.TSOLICITANTETableAdapter.Actualizar(txtNroRegistroMesa.Text, CbbSeleccionarDocumento.Text, ccbDependencia.Text, txtAsunto.Text, dtpFechaRegistro.Text, dtpFechaVencimiento.Text, CbbDocumentoDerivado.Text, CbbOrigenDocumento.Text, cbNombreSolicitante.SelectedValue, IdDocumentoTextBox.Text)
            btnGuardar.Tag = "GuardarInicio"
            RegistroSolicitante_Load(sender, e)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.TSOLICITANTETableAdapter.Eliminar(IdDocumentoTextBox.Text)
        RegistroSolicitante_Load(sender, e)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RegistroSolicitante_Load(sender, e)
    End Sub
End Class