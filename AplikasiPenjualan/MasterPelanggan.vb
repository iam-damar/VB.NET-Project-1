Imports System.Data.Odbc

Public Class MasterPelanggan

    'Custom Method

    Sub ClearAllText()
        txtKodePelanggan.Text = ""
        txtKodePelanggan.Enabled = False
        txtNama.Text = ""
        txtNama.Enabled = False
        txtAlamat.Text = ""
        txtAlamat.Enabled = False
        txtTelepon.Text = ""
        txtTelepon.Enabled = False

        'Set button awal
        BtnTambah.Text = "Tambah"
        BtnEdit.Text = "Edit"
        BtnHapus.Text = "Hapus"
        BtnTutup.Text = "Tutup"

        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnEdit.Enabled = True

        'Menampilkan Data dari Db_penjualan ke DGV pelanggan
        Call Koneksi()
        dataAdpt = New OdbcDataAdapter("SELECT * FROM tbl_pelanggan", conn)

        Dset = New DataSet
        dataAdpt.Fill(Dset, "tbl_pelanggan")
        Dgv_Pelanggan.DataSource = Dset.Tables("tbl_pelanggan")
        Dgv_Pelanggan.ReadOnly = True

        Dgv_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub


    Sub FillValue()
        txtKodePelanggan.Enabled = True
        txtNama.Enabled = False
        txtAlamat.Enabled = False
        txtTelepon.Enabled = False
    End Sub


    Sub AutoFillKodePelanggan()

        Dim UrutanKode As String
        Dim Hitung As Long

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan WHERE kodepelanggan in (SELECT max(kodepelanggan) FROM tbl_pelanggan)", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            UrutanKode = "PLG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1 'Increment jika sudah ada data maka auto generate kode angka + 1.
            UrutanKode = "PLG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        'Txt Kode Pelanggan
        txtKodePelanggan.Text = UrutanKode
    End Sub





    'Main Method

    Private Sub MasterPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearAllText()

    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            BtnTambah.Text = "Simpan"
            BtnEdit.Enabled = False
            BtnHapus.Enabled = False
            BtnTutup.Text = "Batal"


            'Isi Kode Pelanggan Otomatis
            txtKodePelanggan.Enabled = False
            Call AutoFillKodePelanggan()
            _tooltip.Active = False

            'Tanpa menggunakan FillValue()
            txtNama.Enabled = True
            txtAlamat.Enabled = True
            txtTelepon.Enabled = True
        Else
            If txtKodePelanggan.Text = "" And txtNama.Text = "" And txtAlamat.Text = "" And txtTelepon.Text = "" Then
                MsgBox("Mohon isi semua field Data Pelanggan..")
            Else
                'Input data ke database.
                Dim TambahData As String = "INSERT INTO tbl_pelanggan VALUES('" & txtKodePelanggan.Text & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & txtTelepon.Text & "')"

                Cmd = New OdbcCommand(TambahData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah..")

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
            If txtKodePelanggan.Text = "" And txtNama.Text = "" And txtAlamat.Text = "" And txtTelepon.Text = "" Then
                MsgBox("Mohon isi semua field Data Pelanggan..")

            Else
                'Edit data.

                Dim EditData As String = "UPDATE tbl_pelanggan SET namapelanggan='" & txtNama.Text & "',alamatpelanggan='" & txtAlamat.Text & "',telppelanggan='" & txtTelepon.Text & "' where kodepelanggan='" & txtKodePelanggan.Text & "'"

                Cmd = New OdbcCommand(EditData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Berhasil..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub txtKodePelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePelanggan.KeyPress
        If e.KeyChar = Chr(13) Then

            txtNama.Enabled = True
            txtAlamat.Enabled = True
            txtTelepon.Enabled = True

            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan WHERE kodepelanggan= '" & txtKodePelanggan.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                MsgBox("Data Pelanggan Tidak ditemukan")
            Else
                txtKodePelanggan.Text = Rd.Item("kodepelanggan")
                txtKodePelanggan.Enabled = False
                txtNama.Text = Rd.Item("namapelanggan")
                txtAlamat.Text = Rd.Item("alamatpelanggan")
                txtTelepon.Text = Rd.Item("telppelanggan")
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

            If txtKodePelanggan.Text = "" And txtNama.Text = "" And txtAlamat.Text = "" And txtTelepon.Text = "" Then
                MsgBox("Mohon isi semua field Data Pelanggan..")
            Else
                'Hapus data

                Dim HapusData As String = "DELETE FROM tbl_pelanggan WHERE kodepelanggan='" & txtKodePelanggan.Text & "'"

                Cmd = New OdbcCommand(HapusData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Pelanggan Berhasil dihapus..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "Tutup" Then
            Me.Close()
        Else
            ClearAllText()
        End If
    End Sub

    'Add Tool Tip
    Private _tooltip As New ToolTip()

    Private Sub txtKodePelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtKodePelanggan.TextChanged
        _tooltip.Show("Tekan ENTER setelah memasukan KODE...", txtKodePelanggan)
    End Sub

End Class