Imports System.Data.Odbc

Public Class ReturTransaksiPenjualan
    'Custom Method
    Sub ClearAll()

        txtnojual.Text = ""
        lblNamaPelanggan.Text = ""
        lblTanggalJual.Text = ""
        lblJamJual.Text = ""
        lblNamaAdmin.Text = ""
        lblAlamatPelanggan.Text = ""

        'Mengkosongkan txtbox & label pada pengisian produk barang RETUR
        txtkodebarangretur.Text = ""
        lblNamaBarangRetur.Text = ""
        lblhargabarangretur.Text = ""
        txtJumlahbarangretur.Enabled = False

        Dgv_viewTransaksiJualsebelumnnya.DataSource = Nothing
        Dgv_viewTransaksiJualsebelumnnya.Columns.Clear()
        Dgv_returBarang.Columns.Clear()
        Dgv_returBarang.Rows.Clear()


    End Sub

    'Isi otomatis No Retur
    Sub AutoFillNoRetur()

        Dim UrutanKode As String
        Dim Hitung As Long

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_retur WHERE noretur in (SELECT max(noretur) FROM tbl_retur)", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            UrutanKode = "R" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "R" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        'Textbox No Retur

        lblNoRetur.Text = UrutanKode

    End Sub

    'Menampilkan data transaksi/Jual Pelanggan
    Sub ShowTransaksiData()

        Call Koneksi()

        'memasukan data Pelanggan dan Admin dari table jual dengan command query odbc.
        Cmd = New OdbcCommand("SELECT *FROM tbl_jual WHERE nojual = '" & txtnojual.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            MsgBox("Data Transaksi Penjualan Tidak ditemukan")
        Else

            'menyimpan kode Pelanggan dan Admin didalam label unvisible
            lblkodepelanggan.Text = Rd.Item("kodepelanggan")
            lblkodeadmin.Text = Rd.Item("kodeadmin")


            Dim dateFormat As DateTime = Rd.GetDateTime(1)

            lblTanggalJual.Text = dateFormat.ToString("dd MMMM yyyy")
            lblJamJual.Text = Rd.Item("jamjual").ToString()


            'Memasukan data detail jual ke datagridview dengan odbc dataadapter dan dataset
            dataAdpt = New OdbcDataAdapter("SELECT * FROM tbl_detailjual WHERE nojual= '" & txtnojual.Text & "'", conn)
            Dset = New DataSet
            dataAdpt.Fill(Dset, "tbl_detailjual")

            Dgv_viewTransaksiJualsebelumnnya.ReadOnly = True
            Dgv_viewTransaksiJualsebelumnnya.DataSource = Dset.Tables("tbl_detailjual")

            'Menambahkan custom column saat data DB Masuk
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("nojual", "No Jual")
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("kodebarang", "Kode Barang")
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("namabarang", "Nama Barang")
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("hargajual", "Harga")
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("jumlahjual", "Jumlah")
            Dgv_viewTransaksiJualsebelumnnya.Columns.Add("subtotal", "SubTotal")

            'set width
            Dgv_viewTransaksiJualsebelumnnya.Columns.Item("namabarang").Width = 200
            Dgv_viewTransaksiJualsebelumnnya.Columns.Item("hargajual").Width = 150
            Dgv_viewTransaksiJualsebelumnnya.Columns.Item("jumlahjual").Width = 80
            Dgv_viewTransaksiJualsebelumnnya.Columns.Item("subtotal").Width = 150

        End If


        'Menampilkan nama pelanggan dan alamatnya
        Cmd = New OdbcCommand("SELECT namapelanggan,alamatpelanggan FROM tbl_pelanggan WHERE kodepelanggan= '" & lblkodepelanggan.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            MsgBox("Pelanggan tidak melakukan transaksi dengan No Jual" & txtnojual.Text)
        Else
            lblNamaPelanggan.Text = Rd.Item("namapelanggan")
            lblAlamatPelanggan.Text = Rd.Item("alamatpelanggan")
        End If


        'Menampilkan nama Admin dan alamatnya
        Cmd = New OdbcCommand("SELECT namaadmin FROM tbl_admin WHERE kodeadmin = '" & lblkodeadmin.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            MsgBox("Tidak ada Admin yang sedang melakukan transaksi dengan No Jual " & txtnojual.Text)
        Else
            lblNamaAdmin.Text = Rd.Item("namaadmin")
        End If

    End Sub




    'Main Method
    Private Sub ReturTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearAll()
        Call AutoFillNoRetur()
        txtnojual.Focus()
    End Sub

    Private Sub txtnojual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnojual.KeyPress

        If e.KeyChar = Chr(13) Then
            Call ShowTransaksiData()
        End If
    End Sub
End Class