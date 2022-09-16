Public Class MainForm
    Sub Lock()
        SignInToolStripMenuItem.Enabled = True
        SignUpToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        UtilityToolStripMenuItem.Enabled = False

        'Label Dalam posisi kosong
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Lock()
        STLabel10.Text = Today

        If STLabel2.Text = "" Or STLabel4.Text = "" Then
            LoginForm.ShowDialog()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay


    End Sub

    Private Sub SignInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignInToolStripMenuItem.Click
        LoginForm.ShowDialog()
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        SignUp.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Lock()

        LoginForm.ShowDialog()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Call Lock()

        End

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        MasterAdmin.ShowDialog()


    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        MasterPelanggan.ShowDialog()

    End Sub

    Private Sub BarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        MasterBarang.ShowDialog()

    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        TransaksiPenjualan.ShowDialog()

    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        LaporanPenjualan.ShowDialog()
    End Sub

    Private Sub LaporanDataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataMasterToolStripMenuItem.Click
        LapDataMaster.ShowDialog()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        PasswordChange.ShowDialog()
    End Sub

    Private Sub ReturPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ReturTransaksiPenjualan.ShowDialog()
    End Sub
End Class
