Public Class LapDataMaster
    Private Sub BtnLapAdmin_Click(sender As Object, e As EventArgs) Handles BtnLapAdmin.Click

        'Cetak tbl admin data ke Crystal Report
        Dim reportLapAdmin As New CrystalReportLapDataAdmin

        ' Set Viewer
        reportLapAdmin.Refresh()
        LapAdminViewer.CrystalReportViewerLapAdmin.ReportSource = reportLapAdmin
        LapAdminViewer.ShowDialog()
        LapAdminViewer.Dispose()

    End Sub

    Private Sub BtnLapPelanggan_Click(sender As Object, e As EventArgs) Handles BtnLapPelanggan.Click

        Dim reportLapPelanggan As New CrystalReportLapDataPelanggan

        reportLapPelanggan.Refresh()
        LapPelangganViewer.CrystalReportViewerLapPelanggan.ReportSource = reportLapPelanggan
        LapPelangganViewer.ShowDialog()
        LapPelangganViewer.Dispose()

    End Sub

    Private Sub BtnLapBarang_Click(sender As Object, e As EventArgs) Handles BtnLapBarang.Click

        Dim reportLapBarang As New CrystalReportLapBarang

        reportLapBarang.Refresh()
        LapBarangViewer.CrystalReportViewerLapBarang.ReportSource = reportLapBarang
        LapBarangViewer.ShowDialog()
        LapBarangViewer.Dispose()

    End Sub
End Class