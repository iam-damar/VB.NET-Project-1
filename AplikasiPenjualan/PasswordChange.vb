Imports System.Data.Odbc

Public Class PasswordChange
    'Custom Method
    Sub clearAllText()
        txtPassLama.Text = ""
        txtPassBaru.Text = ""
        txtKonfPassBaru.Text = ""

        txtPassBaru.Enabled = False
        txtKonfPassBaru.Enabled = False
        BtnSimpanPassword.Enabled = False

        txtPassLama.PasswordChar = "*"
        txtPassBaru.PasswordChar = "*"
        txtKonfPassBaru.PasswordChar = "*"

        txtPassLama.Focus()
    End Sub

    'Main Method
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblNamasAdmin.Text = MainForm.STLabel4.Text
        clearAllText()

    End Sub

    Private Sub txtPassLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassLama.KeyPress
        If e.KeyChar = Chr(13) Then

            Cmd = New OdbcCommand("SELECT * FROM tbl_admin WHERE kodeadmin = '" & MainForm.STLabel2.Text & "' and passwordadmin = '" & txtPassLama.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                txtPassBaru.Enabled = True
                txtKonfPassBaru.Enabled = True
                BtnSimpanPassword.Enabled = True
                txtPassBaru.Focus()
            Else
                'Jika Password lama yang diketikan tidak sesuai maka
                MsgBox("Password yang anda masukan Salah !")
                txtPassLama.Text = ""
            End If


        End If
    End Sub

    Private Sub BtnSimpanPassword_Click(sender As Object, e As EventArgs) Handles BtnSimpanPassword.Click
        If txtPassLama.Text = "" Or txtPassBaru.Text = "" Or txtKonfPassBaru.Text = "" Then
            MsgBox("Semua Password harus diisi baik lama dan baru !")
        Else
            If txtPassBaru.Text <> txtKonfPassBaru.Text Then
                MsgBox("Password baru dan konfirmasinya harus sama !")
                txtKonfPassBaru.Text = ""
                txtKonfPassBaru.Focus()
            Else
                Call Koneksi()
                Dim UpdatePassword As String = "UPDATE tbl_admin 
                                                SET passwordadmin='" & txtKonfPassBaru.Text & "' WHERE kodeadmin = '" & MainForm.STLabel2.Text & "'"

                Cmd = New OdbcCommand(UpdatePassword, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Password Sukses diubah !")
                Call clearAllText()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        clearAllText()
        Close()
    End Sub

End Class