<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PasswordChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordChange))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassLama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassBaru = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKonfPassBaru = New System.Windows.Forms.TextBox()
        Me.BtnSimpanPassword = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.LblNamasAdmin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(601, 2)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Caslon Pro", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubah password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 49)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gunakan password yang kuat. Masukan setidaknya 6-10 karakter, jangan masukan kata" &
    " yang umum. Kombinasikan dengan huruf besar, simbol, angka."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password lama"
        '
        'txtPassLama
        '
        Me.txtPassLama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassLama.Location = New System.Drawing.Point(15, 198)
        Me.txtPassLama.Name = "txtPassLama"
        Me.txtPassLama.Size = New System.Drawing.Size(247, 20)
        Me.txtPassLama.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password baru"
        '
        'txtPassBaru
        '
        Me.txtPassBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassBaru.Location = New System.Drawing.Point(15, 267)
        Me.txtPassBaru.Name = "txtPassBaru"
        Me.txtPassBaru.Size = New System.Drawing.Size(247, 20)
        Me.txtPassBaru.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Konfirm password baru"
        '
        'txtKonfPassBaru
        '
        Me.txtKonfPassBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKonfPassBaru.Location = New System.Drawing.Point(15, 326)
        Me.txtKonfPassBaru.Name = "txtKonfPassBaru"
        Me.txtKonfPassBaru.Size = New System.Drawing.Size(247, 20)
        Me.txtKonfPassBaru.TabIndex = 8
        '
        'BtnSimpanPassword
        '
        Me.BtnSimpanPassword.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnSimpanPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpanPassword.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSimpanPassword.Location = New System.Drawing.Point(15, 366)
        Me.BtnSimpanPassword.Name = "BtnSimpanPassword"
        Me.BtnSimpanPassword.Size = New System.Drawing.Size(135, 37)
        Me.BtnSimpanPassword.TabIndex = 9
        Me.BtnSimpanPassword.Text = "Simpan"
        Me.BtnSimpanPassword.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBatal.Location = New System.Drawing.Point(156, 366)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(91, 37)
        Me.BtnBatal.TabIndex = 10
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'LblNamasAdmin
        '
        Me.LblNamasAdmin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamasAdmin.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LblNamasAdmin.Location = New System.Drawing.Point(401, 9)
        Me.LblNamasAdmin.Name = "LblNamasAdmin"
        Me.LblNamasAdmin.Size = New System.Drawing.Size(212, 21)
        Me.LblNamasAdmin.TabIndex = 11
        Me.LblNamasAdmin.Text = "_NamaAdmin"
        Me.LblNamasAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(625, 434)
        Me.Controls.Add(Me.LblNamasAdmin)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpanPassword)
        Me.Controls.Add(Me.txtKonfPassBaru)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassBaru)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassLama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PasswordChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassLama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassBaru As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKonfPassBaru As TextBox
    Friend WithEvents BtnSimpanPassword As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents LblNamasAdmin As Label
End Class
