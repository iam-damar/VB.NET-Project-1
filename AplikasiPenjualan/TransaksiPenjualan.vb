Imports System.Data.Odbc

Public Class TransaksiPenjualan
    ' Set Custom Method

    Sub ClearAll()

        LblNamaPelanggan.Text = ""
        LblAlamatPelanggan.Text = ""
        LblTelpPelanggan.Text = ""
        LblTanggal.Text = MainForm.STLabel10.Text
        LblAdmin.Text = MainForm.STLabel6.Text 'Kode Admin
        LblKembali.Text = "0"
        LblBarangTersedia.Text = "0"
        LblTotalItemJual.Text = "0"

        ' Set Label Total Harga 0 saat load Form
        LblTotalHarga.Text = "0"

        'Mengkosongkan txtbox & label pada pengisian produk barang
        txtKodeInsert.Text = ""
        LblNamaBrgInsert.Text = ""
        LblHargaBrgInsert.Text = "0"
        txtJumlahBrgInsert.Enabled = False
        Dgv_TransaksiPenjualan.Rows.Clear()

        'Auto Column size pada datagridview saat Maximize
        Dgv_TransaksiPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Sub ShowPelanggan()

        Call Koneksi()
        'Bersihkan kode saat dialog box transaksi terbuka kembali
        CmbKodePelanggan.Items.Clear()

        Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan", conn)
        Rd = Cmd.ExecuteReader

        Do While Rd.Read
            CmbKodePelanggan.Items.Add(Rd.Item(0))
        Loop

    End Sub

    Private Sub TimerTransPenjualan_Tick(sender As Object, e As EventArgs) Handles TimerTransPenjualan.Tick
        LblJam.Text = TimeOfDay
    End Sub


    'Membuat Auto Fill Angka pada Nomor Jual.

    Sub AutoFillNoJual()

        Dim UrutanKode As String
        Dim Hitung As Long

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_jual WHERE nojual in (SELECT max(nojual) FROM tbl_jual)", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        'Label NoJual

        LblNoJual.Text = UrutanKode

    End Sub

    'Membuat Kalkulasi perhitungan subtotal transaksi
    Sub CalculateSubTotal()
        Dim Hitung As Int32 = 0
        If Dgv_TransaksiPenjualan Is Nothing Then
            LblTotalHarga.Text = "0"
        Else
            For i As Int32 = 0 To Dgv_TransaksiPenjualan.Rows.Count - 1
                Hitung = Hitung + Dgv_TransaksiPenjualan.Rows(i).Cells(4).Value
                LblTotalHarga.Text = Hitung
            Next
        End If
    End Sub

    'Membuat kalkukasi hitung total item yang dipesan
    Sub CalculateTotalItem()
        Dim Hitung As Int32 = 0

        For i As Int32 = 0 To Dgv_TransaksiPenjualan.Rows.Count - 1
            Hitung = Hitung + Dgv_TransaksiPenjualan.Rows(i).Cells(3).Value
            LblTotalItemJual.Text = Hitung
        Next
    End Sub






    ' Main Method

    Private Sub TransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearAll()
        Call ShowPelanggan()
        Call AutoFillNoJual()

    End Sub

    Private Sub CmbKodePelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKodePelanggan.SelectedIndexChanged

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan where kodepelanggan='" & CmbKodePelanggan.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        'Add item tbl ke textbox
        If Rd.HasRows Then
            LblNamaPelanggan.Text = Rd!NamaPelanggan
            LblAlamatPelanggan.Text = Rd!AlamatPelanggan
            LblTelpPelanggan.Text = Rd!TelpPelanggan
        End If

    End Sub

    ' Agar jumlah yang dimasukan hanya angka saja.
    Private Sub txtJumlahBrgInsert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBrgInsert.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub txtKodeInsert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeInsert.KeyPress
        If e.KeyChar = Chr(13) Then

            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_barang WHERE kodebarang= '" & txtKodeInsert.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            'Disable sementara untuk textbox kode insert.
            txtKodeInsert.Enabled = False

            If Not Rd.HasRows Then
                MsgBox("Data Barang Tidak ditemukan")
                txtKodeInsert.Enabled = True
            Else
                txtJumlahBrgInsert.Enabled = True
                txtKodeInsert.Text = Rd.Item("kodebarang")
                LblNamaBrgInsert.Text = Rd.Item("namabarang")
                LblHargaBrgInsert.Text = Rd.Item("hargabarang")
                LblBarangTersedia.Text = Rd.Item("jumlahbarang")
            End If

        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click

        'Mengaktifkan kembali text box kode Insert.
        txtKodeInsert.Enabled = True

        If txtJumlahBrgInsert.Text = "" And LblNamaBrgInsert.Text = "" Then
            MsgBox("Masukan Kode Barang dahulu & tekan ENTER")

        Else
            If Val(LblBarangTersedia.Text) < Val(txtJumlahBrgInsert.Text) Then
                MsgBox("Stok barang kurang !")
            Else
                Dgv_TransaksiPenjualan.Rows.Add(New String() {txtKodeInsert.Text, LblNamaBrgInsert.Text, LblHargaBrgInsert.Text, txtJumlahBrgInsert.Text, Val(LblHargaBrgInsert.Text) * Val(txtJumlahBrgInsert.Text)})

                'Kalkulasi SubTotal
                Call CalculateSubTotal()

                'Menampilkan total produk barang yang dipesan
                Call CalculateTotalItem()


                'Bersihkan Data sebelumnya Setelah insert
                txtKodeInsert.Text = ""
                LblNamaBrgInsert.Text = ""
                LblHargaBrgInsert.Text = ""
                txtJumlahBrgInsert.Text = ""
                txtJumlahBrgInsert.Enabled = False
            End If

        End If

    End Sub

    'Saat melakukan Pembayaran

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then

            If Val(txtBayar.Text) < Val(LblTotalHarga.Text) Then
                MsgBox("Uang tidak mencukupi untuk melakukan pembayaran!")
            ElseIf Val(txtBayar.Text) = Val(LblTotalHarga.Text) Then
                LblKembali.Text = 0
            ElseIf Val(txtBayar.Text) > Val(LblTotalHarga.Text) Then
                LblKembali.Text = Val(txtBayar.Text) - Val(LblTotalHarga.Text)
                BtnSimpan.Select()
            End If

        End If
    End Sub



    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        If LblKembali.Text = "" Or LblNamaPelanggan.Text = "" Or LblTotalHarga.Text = "" Then
            MsgBox("Transaksi gagal, Mohon lakukan transaksi kembali!")
        Else
            Dim FormatTanggal As String

            'Set format tanggal jadi yyyy-MM-dd
            FormatTanggal = Format(Today, "yyyy-MM-dd")

            'Insert ke tbl_jual

            Dim SimpanTransaksi As String = "INSERT INTO tbl_jual VALUES('" & LblNoJual.Text & "', '" & FormatTanggal & "', 
                                                                         '" & LblJam.Text & "', '" & LblTotalItemJual.Text & "', 
                                                                         '" & LblTotalHarga.Text & "','" & txtBayar.Text & "',
                                                                         '" & LblKembali.Text & "','" & CmbKodePelanggan.Text & "',
                                                                         '" & MainForm.STLabel2.Text & "')"

            Cmd = New OdbcCommand(SimpanTransaksi, conn)
            Cmd.ExecuteNonQuery()

            'Insert ke tbl_detailjual

            For dgvRows As Int32 = 0 To Dgv_TransaksiPenjualan.Rows.Count - 2
                Dim simpanDetailTransaksi As String = "INSERT INTO tbl_detailjual VALUES('" & LblNoJual.Text & "', '" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(0).Value & "',
                                                                                         '" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(1).Value & "','" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(2).Value & "',
                                                                                         '" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(3).Value & "', '" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(4).Value & "')"
                Cmd = New OdbcCommand(simpanDetailTransaksi, conn)
                Cmd.ExecuteNonQuery()

                ' Mengubah stok setelah transaksi
                Cmd = New OdbcCommand("SELECT * FROM tbl_barang WHERE kodebarang = '" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(0).Value & "'", conn)
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                Dim UbahStok As String = "UPDATE tbl_barang SET jumlahbarang='" & Rd!JumlahBarang - Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(3).Value & "' WHERE kodebarang ='" & Dgv_TransaksiPenjualan.Rows(dgvRows).Cells(0).Value & "'"

                Cmd = New OdbcCommand(UbahStok, conn)
                Cmd.ExecuteNonQuery()

            Next

            If MessageBox.Show("Apakah ingin cetak nota...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Mulai Cetak

                Dim reportTransJual As New CrystalReportsTransJuals
                Dim KodeAdmins As String = MainForm.STLabel2.Text
                '--------------------------------------------------------------------------------
                'Add Item Datagridview transaksi penjualan ke Dataset As Adapter .
                Dim dt As New DataTable
                With dt
                    .Columns.Add("Kode Barang")
                    .Columns.Add("Nama Barang")
                    .Columns.Add("Harga Barang")
                    .Columns.Add("Jumlah")
                    .Columns.Add("Subtotal")
                End With

                ' Ambil Item

                For Each dgv As DataGridViewRow In Me.Dgv_TransaksiPenjualan.Rows  'Harga                                       'Jumlah                                     'Subtotal
                    If Not dgv.IsNewRow Then
                        dt.Rows.Add(dgv.Cells(0).Value, dgv.Cells(1).Value, "Rp. " + dgv.Cells(2).Value, dgv.Cells(3).Value, "Rp. " + dgv.Cells(4).Value)
                    End If

                Next

                'Add Item to Parameter field di crystal report
                reportTransJual.SetDataSource(dt)
                reportTransJual.SetParameterValue("NamaPelanggan", LblNamaPelanggan.Text)

                reportTransJual.SetParameterValue("AlamatPelanggan", LblAlamatPelanggan.Text)
                reportTransJual.SetParameterValue("NoTelp", LblTelpPelanggan.Text)
                reportTransJual.SetParameterValue("KodeAdmin", KodeAdmins)
                reportTransJual.SetParameterValue("NamaAdmin", LblAdmin.Text)

                reportTransJual.SetParameterValue("NoJuals", LblNoJual.Text)

                'Total Harga untuk cetak
                Try
                    Dim max As Int32 = Dgv_TransaksiPenjualan.Rows.Count - 1
                    Dim tot As Int32 = 0
                    For Each rows As DataGridViewRow In Dgv_TransaksiPenjualan.Rows
                        tot += rows.Cells(4).Value
                    Next

                    tot += Dgv_TransaksiPenjualan.Rows(max).Cells(4).Value
                    reportTransJual.SetParameterValue("TotalHarga", tot)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                reportTransJual.SetParameterValue("Bayar", txtBayar.Text)
                reportTransJual.SetParameterValue("Kembali", LblKembali.Text)


                ' Masukan item ke crystal report

                TransJualViewer.CrystalReportViewerTransJual.ReportSource = reportTransJual
                TransJualViewer.ShowDialog()
                TransJualViewer.Dispose()

                '----------------------------------------------------------------------------------

                Call ClearAll()
                Dgv_TransaksiPenjualan.Rows.Clear()
                CmbKodePelanggan.Items.Clear()
                Call ShowPelanggan()
                txtBayar.Text = ""
                LblKembali.Text = ""

                Call AutoFillNoJual()
                MsgBox("Transaksi Sukses, dan berhasil disimpan !")

            Else

                'Refresh
                Call ClearAll()
                Dgv_TransaksiPenjualan.Rows.Clear()
                CmbKodePelanggan.Items.Clear()
                Call ShowPelanggan()
                txtBayar.Text = ""
                LblKembali.Text = ""
                Call AutoFillNoJual()
                MsgBox("Transaksi Sukses, dan berhasil disimpan !")


            End If
        End If
    End Sub


    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Call ClearAll()
        Dgv_TransaksiPenjualan.Rows.Clear()
        CmbKodePelanggan.Items.Clear()
        Call ShowPelanggan()
        txtBayar.Text = ""
        LblKembali.Text = "0"
        LblBarangTersedia.Text = "0"
        Call AutoFillNoJual()

        Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call ClearAll()
        Dgv_TransaksiPenjualan.Rows.Clear()
        CmbKodePelanggan.Items.Clear()
        Call ShowPelanggan()
        txtBayar.Text = ""
        LblKembali.Text = "0"
        LblBarangTersedia.Text = "0"
        Call AutoFillNoJual()
    End Sub

    Private Sub Dgv_TransaksiPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv_TransaksiPenjualan.KeyDown
        If e.KeyCode = Keys.Delete Then
            For Each row As DataGridViewRow In Dgv_TransaksiPenjualan.SelectedRows
                Dgv_TransaksiPenjualan.Rows(row.Index).Cells(3).Value = 0
                Dgv_TransaksiPenjualan.Rows(row.Index).Cells(4).Value = 0
            Next
            Call CalculateSubTotal()
            Call CalculateTotalItem()
            Dgv_TransaksiPenjualan.Refresh()
        End If
    End Sub


End Class