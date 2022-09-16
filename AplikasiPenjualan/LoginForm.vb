Imports System.Data.Odbc

Public Class LoginForm

    Sub Unlock()
        MainForm.SignInToolStripMenuItem.Enabled = False
        MainForm.SignUpToolStripMenuItem.Enabled = True
        MainForm.LogoutToolStripMenuItem.Enabled = True
        MainForm.MasterToolStripMenuItem.Enabled = True
        MainForm.TransaksiToolStripMenuItem.Enabled = True
        MainForm.LaporanToolStripMenuItem.Enabled = True
        MainForm.UtilityToolStripMenuItem.Enabled = True
    End Sub

    Sub ClearText()
        TxtKodeAdmin.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearText()
        TxtKodeAdmin.Select()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtKodeAdmin.Text = "" And TxtPassword.Text = "" Then
            TxtKodeAdmin.Select()
            MsgBox("Masukan Kode Admin dan Password..")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_admin where kodeadmin = '" & TxtKodeAdmin.Text & "' and passwordadmin = '" & TxtPassword.Text & "'", conn)

            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MsgBox("Hallo, Selamat Datang Kembali..")
                Me.Close()
                Call Unlock()

                MainForm.STLabel2.Text = Rd!KodeAdmin
                MainForm.STLabel4.Text = Rd!NamaAdmin
                MainForm.STLabel6.Text = Rd!LevelAdmin

                ' Jika Selain Admin yang membuka aplikasi, maka toolstrip Admin terkunci.

                If MainForm.STLabel6.Text = "User" Then
                    MainForm.AdminToolStripMenuItem.Enabled = False
                    MainForm.LaporanPenjualanToolStripMenuItem.Enabled = False
                    MainForm.SignUpToolStripMenuItem.Enabled = False
                End If

            Else
                MsgBox("Kode atau password Salah")
                ClearText()

            End If

        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click

        ' Menampilkan SignUp Form untuk pendaftaran akun admin kasir.

        Me.Dispose()

        Dim SignUps As New SignUp
        SignUps.ShowDialog()
    End Sub
End Class