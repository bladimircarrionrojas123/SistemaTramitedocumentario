Public Class ReportePorTipoDucumento

    Private Sub ReportePorTipoDucumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TDOCUMENTO' Puede moverla o quitarla según sea necesario.
        Me.TDOCUMENTOTableAdapter.Fill(Me.BD_TRAMITE.TDOCUMENTO)
        Me.ReportViewer1.RefreshReport()
    End Sub
  
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If rbtnTipo.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorTipoDucumento(Me.BD_TRAMITE.TDOCUMENTO, CbbSeleccionarDocumento.Text)
            Me.ReportViewer1.RefreshReport()
        ElseIf rbtnNombre.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorNombre(Me.BD_TRAMITE.TDOCUMENTO, txtBuscarDocumento.Text)
            Me.ReportViewer1.RefreshReport()
        ElseIf rbtnFecha.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorFecha(Me.BD_TRAMITE.TDOCUMENTO, dtpFechaInicio.Text, dtpFechaFin.Text)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class