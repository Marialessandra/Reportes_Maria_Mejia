Public Class frmVistaPrevia
    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            frmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            frmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            frmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            frmVistaPrevia.ReportViewer1.Refresh()
            frmVistaPrevia.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub
End Class