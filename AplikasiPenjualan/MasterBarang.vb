Imports System.Data.Odbc

Public Class MasterBarang
    'Custom Method

    Sub ClearAllText()
        txtKodeBarang.Text = ""
        txtKodeBarang.Enabled = False
        txtNamaBarang.Text = ""
        txtNamaBarang.Enabled = False
        txtHargaBarang.Text = ""
        txtHargaBarang.Enabled = False
        txtJumlahBarang.Text = ""
        txtJumlahBarang.Enabled = False
        CmbSatuanBarang.Text = ""
        CmbSatuanBarang.Enabled = False


        'Set button awal
        BtnTambah.Text = "Tambah"
        BtnEdit.Text = "Edit"
        BtnHapus.Text = "Hapus"
        BtnTutup.Text = "Tutup"

        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnEdit.Enabled = True

        'Menampilkan Data dari Db_penjualan ke DGV barang
        Call Koneksi()
        dataAdpt = New OdbcDataAdapter("SELECT * FROM tbl_barang", conn)

        Dset = New DataSet
        dataAdpt.Fill(Dset, "tbl_barang")
        Dgv_Barang.DataSource = Dset.Tables("tbl_barang")
        Dgv_Barang.ReadOnly = True

        Dgv_Barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    'Menset satuan barang muncul di combo box saat di tbl barang->satuanbarang terisi dengan value.

    Sub FillCmbSatuanBarang()
        Call Koneksi()
        Cmd = New OdbcCommand("SELECT DISTINCT satuanbarang FROM tbl_barang", conn)
        Rd = Cmd.ExecuteReader
        CmbSatuanBarang.Items.Clear()
        Do While Rd.Read
            CmbSatuanBarang.Items.Add(Rd.Item("satuanbarang"))
        Loop
    End Sub

    Sub FillValue()
        txtKodeBarang.Enabled = True
        txtNamaBarang.Enabled = False
        txtHargaBarang.Enabled = False
        txtJumlahBarang.Enabled = False
        CmbSatuanBarang.Enabled = False
        FillCmbSatuanBarang()
    End Sub


    Sub AutoFillKodeBarang()

        Dim UrutanKode As String
        Dim Hitung As Long

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_barang WHERE kodebarang in (SELECT max(kodebarang) FROM tbl_barang)", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            UrutanKode = "BRG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1 'Increment jika sudah ada data maka auto generate kode angka + 1.
            UrutanKode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        'Txt Kode Barang
        txtKodeBarang.Text = UrutanKode
    End Sub






    'Main Method

    Private Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearAllText()

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            BtnTambah.Text = "Simpan"
            BtnEdit.Enabled = False
            BtnHapus.Enabled = False
            BtnTutup.Text = "Batal"

            'Isi Kode Barang Otomatis
            txtKodeBarang.Enabled = False
            Call AutoFillKodeBarang()
            _tooltip.Active = False

            'Tanpa menggunakan FillValue()
            txtNamaBarang.Enabled = True
            txtHargaBarang.Enabled = True
            txtJumlahBarang.Enabled = True
            CmbSatuanBarang.Enabled = True
        Else
            If txtKodeBarang.Text = "" And txtNamaBarang.Text = "" And txtHargaBarang.Text = "" And txtJumlahBarang.Text = "" And CmbSatuanBarang.Text = "" Then
                MsgBox("Mohon isi semua field Data Barang..")
            Else
                'Input data ke database.
                Dim TambahData As String = "INSERT INTO tbl_barang VALUES('" & txtKodeBarang.Text & "','" & txtNamaBarang.Text & "','" & txtHargaBarang.Text & "','" & txtJumlahBarang.Text & "','" & CmbSatuanBarang.Text & "')"

                Cmd = New OdbcCommand(TambahData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Barang Berhasil Ditambah..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If BtnEdit.Text = "Edit" Then
            BtnEdit.Text = "Simpan"
            BtnTambah.Enabled = False
            BtnHapus.Enabled = False
            BtnTutup.Text = "Batal"
            Call FillValue()
        Else
            If txtKodeBarang.Text = "" And txtNamaBarang.Text = "" And txtHargaBarang.Text = "" And txtJumlahBarang.Text = "" And CmbSatuanBarang.Text = "" Then
                MsgBox("Mohon isi semua field Data Barang..")

            Else
                'Edit data.

                Dim EditData As String = "UPDATE tbl_barang SET namabarang='" & txtNamaBarang.Text & "',hargabarang='" & txtHargaBarang.Text & "',jumlahbarang='" & txtJumlahBarang.Text & "' where kodebarang='" & txtKodeBarang.Text & "'"

                Cmd = New OdbcCommand(EditData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Barang Berhasil..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then

            txtNamaBarang.Enabled = True
            txtHargaBarang.Enabled = True
            txtJumlahBarang.Enabled = True
            CmbSatuanBarang.Enabled = True

            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_barang WHERE kodebarang= '" & txtKodeBarang.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                MsgBox("Data Barang Tidak ditemukan")
            Else
                txtKodeBarang.Text = Rd.Item("kodebarang")
                txtKodeBarang.Enabled = False
                txtNamaBarang.Text = Rd.Item("namabarang")
                txtHargaBarang.Text = Rd.Item("hargabarang")
                txtJumlahBarang.Text = Rd.Item("jumlahbarang")
                CmbSatuanBarang.Text = Rd.Item("satuanbarang")
            End If

        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "Hapus" Then
            BtnTambah.Enabled = False
            BtnEdit.Enabled = False
            BtnHapus.Text = "Delete"
            BtnTutup.Text = "Batal"
            Call FillValue()
        Else

            If txtKodeBarang.Text = "" And txtNamaBarang.Text = "" And txtHargaBarang.Text = "" And txtJumlahBarang.Text = "" And CmbSatuanBarang.Text = "" Then
                MsgBox("Mohon isi semua field Data Barang..")
            Else
                'Hapus data

                Dim HapusData As String = "DELETE FROM tbl_barang WHERE kodebarang='" & txtKodeBarang.Text & "'"

                Cmd = New OdbcCommand(HapusData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Barang Berhasil dihapus..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "Tutup" Then
            Me.Close()
        Else
            Call ClearAllText()
        End If
    End Sub

    'Input Textbox harga dan jumlah non huruf

    Private Sub txtHargaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtJumlahBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    'Add Tooltip

    Private _tooltip As New ToolTip()

    Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
        _tooltip.Show("Tekan ENTER setelah memasukan KODE...", txtKodeBarang)
    End Sub

End Class