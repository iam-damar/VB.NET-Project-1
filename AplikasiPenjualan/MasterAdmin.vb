Imports System.Data.Odbc

Public Class MasterAdmin

    'Custom Method

    Sub ClearAllText()
        txtKodeAdmin.Text = ""
        txtKodeAdmin.Enabled = False
        txtNamaAdmin.Text = ""
        txtNamaAdmin.Enabled = False
        txtAlamat.Text = ""
        txtAlamat.Enabled = False
        CmbLevel.Items.Clear()
        CmbLevel.Enabled = False
        CmbLevel.Text = ""

        'Set button awal
        BtnEdit.Text = "Edit Data"
        BtnHapus.Text = "Hapus Data"
        BtnTutup.Text = "Tutup"

        BtnHapus.Enabled = True
        BtnEdit.Enabled = True

        'Menampilkan Data dari Db_penjualan ke DGV Admin
        Call Koneksi()
        dataAdpt = New OdbcDataAdapter("SELECT kodeadmin, namaadmin, alamat, leveladmin FROM tbl_admin", conn)

        Dset = New DataSet
        dataAdpt.Fill(Dset, "tbl_admin")
        Dgv_MasterAdmin.DataSource = Dset.Tables("tbl_admin")
        Dgv_MasterAdmin.ReadOnly = True
        Dgv_MasterAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Sub FillLevelAdmin()
        txtKodeAdmin.Enabled = True
        txtNamaAdmin.Enabled = False
        CmbLevel.Enabled = False
        CmbLevel.Items.Add("Admin")
        CmbLevel.Items.Add("User")
    End Sub

    'Main Method

    Private Sub MasterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearAllText()


    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If BtnEdit.Text = "Edit Data" Then
            BtnEdit.Text = "Simpan"
            BtnHapus.Enabled = False
            BtnTutup.Text = "Batal"
            Call FillLevelAdmin()
        Else
            If txtKodeAdmin.Text = "" Or txtNamaAdmin.Text = "" Or txtAlamat.Text = "" Or CmbLevel.Text = "" Then
                MsgBox("Mohon isi semua field Data Admin..")
            Else
                'Edit data.

                Dim EditData As String = "UPDATE tbl_admin SET namaadmin='" & txtNamaAdmin.Text & "',alamat='" & txtAlamat.Text & "',leveladmin='" & CmbLevel.Text & "' where kodeadmin='" & txtKodeAdmin.Text & "'"

                Cmd = New OdbcCommand(EditData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit Data Berhasil..")

                Call ClearAllText()
            End If
        End If
    End Sub

    Private Sub txtKodeAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeAdmin.KeyPress

        'Saat Ditekan Enter maka otomatis textbox terisi dengan data dari db.

        If e.KeyChar = Chr(13) Then
            txtNamaAdmin.Enabled = True
            txtAlamat.Enabled = True
            CmbLevel.Enabled = True
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_admin WHERE kodeadmin= '" & txtKodeAdmin.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                MsgBox("Data Admin Tidak ditemukan")
            Else
                txtKodeAdmin.Text = Rd.Item("kodeadmin")
                txtKodeAdmin.Enabled = False
                txtNamaAdmin.Text = Rd.Item("namaadmin")
                txtAlamat.Text = Rd.Item("alamat")
                CmbLevel.Text = Rd.Item("leveladmin")
            End If

        End If

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "Hapus Data" Then
            BtnEdit.Enabled = False
            BtnHapus.Text = "Delete"
            BtnTutup.Text = "Batal"
            Call FillLevelAdmin()
        Else
            If txtKodeAdmin.Text = "" Or txtNamaAdmin.Text = "" Or txtAlamat.Text = "" Or CmbLevel.Text = "" Then
                MsgBox("Mohon isi semua field Data Admin..")
            Else
                'Hapus data.

                Dim HapusData As String = "DELETE FROM tbl_admin WHERE kodeadmin='" & txtKodeAdmin.Text & "'"

                Cmd = New OdbcCommand(HapusData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil..")

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

    Private Sub txtKodeAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtKodeAdmin.TextChanged
        _tooltip.Show("Tekan ENTER setelah memasukan KODE...", txtKodeAdmin)
    End Sub

End Class