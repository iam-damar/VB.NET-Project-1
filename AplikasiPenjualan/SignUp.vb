Imports System.Data.Odbc

Public Class SignUp
    'Custom Method
    Sub ClearAllText()
        txtkodeAdmin.Text = ""
        txtNamaAdmin.Text = ""
        CmbGender.Text = ""
        CmbGender.Items.Clear()
        CmbLevel().Text = ""
        CmbLevel.Items.Clear()
        txtAlamat.Text = ""
        txtPass.Text = ""
        txtKonfPass.Text = ""
    End Sub

    Sub AutoFillNoKodeAdmin()

        Dim UrutanKode As String
        Dim Hitung As Long

        Call Koneksi()

        Cmd = New OdbcCommand("SELECT * FROM tbl_admin WHERE kodeadmin in (SELECT max(kodeadmin) FROM tbl_admin)", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            UrutanKode = "ADM" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1 'Increment jika sudah ada data maka auto generate kode angka + 1.
            UrutanKode = "ADM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        'Txt Kode Admin
        txtkodeAdmin.Text = UrutanKode
    End Sub

    Sub FillCmbGender()
        CmbGender.Items.Add("Laki-Laki")
        CmbGender.Items.Add("Perempuan")
    End Sub

    Sub FillCmbLevel()
        CmbLevel.Items.Add("Admin")
        CmbLevel.Items.Add("User")
    End Sub



    'Main Method
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearAllText()
        Call AutoFillNoKodeAdmin()
        Call FillCmbGender()
        Call FillCmbLevel()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtNamaAdmin.Text = "" Or CmbGender.Text = "" Or txtAlamat.Text = "" Or txtPass.Text = "" Or txtKonfPass.Text = "" Or CmbLevel.Text = "" Then
            MsgBox("Data Admin Tidak Lengkap !")
        Else
            If txtPass.Text <> txtKonfPass.Text Then
                MsgBox("Password Harus Sama !")
            Else
                Dim TambahDataAdmin As String = "INSERT INTO tbl_admin VALUES ('" & txtkodeAdmin.Text & "','" & txtNamaAdmin.Text & "','" & CmbGender.Text & "','" & txtAlamat.Text & "','" & txtKonfPass.Text & "','" & CmbLevel.Text & "')"

                Cmd = New OdbcCommand(TambahDataAdmin, conn)
                Cmd.ExecuteNonQuery()

                MsgBox("Pendaftaran Sukses !")

                Call ClearAllText()
                Call AutoFillNoKodeAdmin()

            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class