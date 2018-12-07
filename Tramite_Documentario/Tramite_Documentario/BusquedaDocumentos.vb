Imports Microsoft.Reporting.WinForms

Public Class BusquedaDocumentos

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub BusquedaDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TDOCUMENTO' Puede moverla o quitarla según sea necesario.
        Me.TDOCUMENTOTableAdapter.Fill(Me.BD_TRAMITE.TDOCUMENTO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbtnTipo.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorTipoDucumento(Me.BD_TRAMITE.TDOCUMENTO, CbbSeleccionarDocumento.Text)
        ElseIf rbtnNombre.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorNombre(Me.BD_TRAMITE.TDOCUMENTO, txtBuscarDocumento.Text)
        ElseIf rbtnFecha.Checked = True Then
            Me.TDOCUMENTOTableAdapter.BusquedaPorFecha(Me.BD_TRAMITE.TDOCUMENTO, dtpFechaInicio.Text, dtpFechaFin.Text)
        End If
    End Sub

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNIMPRIMIR.Click
        ReportePorTipoDucumento.Show()
    End Sub
End Class