Imports System.Data.Odbc

Public Class LaporanPenjualan
    'Custom Method
    Sub ShowNoJual()
        Call Koneksi()

        CmbNoJualPerNota.Items.Clear()

        CmbNoJualPerNota.DropDownHeight = CmbNoJualPerNota.ItemHeight * 10 + 2

        Cmd = New OdbcCommand("SELECT * FROM tbl_jual", conn)
        Rd = Cmd.ExecuteReader

        Do While Rd.Read
            CmbNoJualPerNota.Items.Add(Rd.Item(0))
        Loop

    End Sub

    Sub ShowBulan()

        CmbBulan.DataSource = Nothing
        Dim dtb As New DataTable

        CmbBulan.DisplayMember = "Text"
        CmbBulan.ValueMember = "Value"

        dtb.Columns.Add("Text", GetType(String))
        dtb.Columns.Add("Value", GetType(Integer))

        dtb.Rows.Add("Januari", 1)
        dtb.Rows.Add("Februari", 2)
        dtb.Rows.Add("Maret", 3)
        dtb.Rows.Add("April", 4)
        dtb.Rows.Add("Mei", 5)
        dtb.Rows.Add("Juni", 6)
        dtb.Rows.Add("Juli", 7)
        dtb.Rows.Add("Agustus", 8)
        dtb.Rows.Add("September", 9)
        dtb.Rows.Add("Oktober", 10)
        dtb.Rows.Add("November", 11)
        dtb.Rows.Add("Desember", 12)

        CmbBulan.DataSource = dtb

    End Sub


    Private Sub LaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cmb bulan
        Call ShowBulan()

        'Cmb Tahun
        CmbTahun.Items.Clear()

        CmbTahun.Text = Date.Now.Year
        ' Menampilkan tahun dari sekarang ke berkutnya hanya 5 saja.
        For i As Int32 = 0 To 5
            CmbTahun.Items.Add(Date.Now.Year - i)
        Next

        ' Menampilkan Cmb Daftar No Jual.
        Call ShowNoJual()

    End Sub

    Private Sub BtnCetakPerNota_Click(sender As Object, e As EventArgs) Handles BtnCetakPerNota.Click

        Dim reportLapPerNota As New CrystalReportLapPerNota

        reportLapPerNota.Refresh()
        reportLapPerNota.SetParameterValue("Notransaksi", CmbNoJualPerNota.Text)

        LapPerNotaViewer.CrystalReportViewerLapPerNota.ReportSource = reportLapPerNota
        LapPerNotaViewer.ShowDialog()
        LapPerNotaViewer.Dispose()


    End Sub

    Private Sub BtnCetakHarian_Click(sender As Object, e As EventArgs) Handles BtnCetakHarian.Click

        Dim reportLapPenjualanHarian As New CrystalReportLaporanHarian

        Dim dateFrom As String = DtTanggalHarian.Value.ToShortDateString()

        reportLapPenjualanHarian.Refresh()
        reportLapPenjualanHarian.SetParameterValue("fromDate", dateFrom)

        LaporanHarianViewer.CrystalReportViewerLaporanHarian.ReportSource = reportLapPenjualanHarian
        LaporanHarianViewer.ShowDialog()
        LaporanHarianViewer.Dispose()

    End Sub

    Private Sub BtnCetakMingguan_Click(sender As Object, e As EventArgs) Handles BtnCetakMingguan.Click

        Dim reportLapMingguan As New CrystalReportLaporanMingguan

        If DtAwalMingguan.Value > DtAkhirMingguan.Value Then
            MsgBox("Tanggal Awal harus lebih kecil dari tanggal Akhir !.")
        Else
            Dim dateFromMingguan As String = DtAwalMingguan.Value.ToShortDateString()
            Dim dateToMingguan As String = DtAkhirMingguan.Value.ToShortDateString()

            reportLapMingguan.SetParameterValue("fromDate", dateFromMingguan)
            reportLapMingguan.SetParameterValue("toDate", dateToMingguan)

            LaporanMingguanViewer.CrystalReportViewerLapMingguan.ReportSource = reportLapMingguan
            LaporanMingguanViewer.ShowDialog()
            LaporanMingguanViewer.Dispose()
        End If


    End Sub

    Private Sub BtnCetakBulanan_Click(sender As Object, e As EventArgs) Handles BtnCetakBulanan.Click

        Dim reportLapPenjualanBulanan As New CrystalReportLaporanBulanan

        If CmbBulan.Text = "" Or CmbTahun.Text = "" Then
            MsgBox("Bulan dan Tahun tidak boleh kosong !")
        Else
            reportLapPenjualanBulanan.Refresh()
            reportLapPenjualanBulanan.RecordSelectionFormula = "Month({tbl_jual1.tanggaljual}) =" & CmbBulan.SelectedValue & "and Year({tbl_jual1.tanggaljual}) = " & Val(CmbTahun.Text)

            LaporanBulananViewer.CrystalReportViewerLaporanBulanan.ReportSource = reportLapPenjualanBulanan
            LaporanBulananViewer.ShowDialog()
            LaporanBulananViewer.Dispose()
        End If

    End Sub
End Class