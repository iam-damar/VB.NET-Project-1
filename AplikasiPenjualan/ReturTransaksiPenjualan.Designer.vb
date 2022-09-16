<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturTransaksiPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturTransaksiPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_returBarang = New System.Windows.Forms.DataGridView()
        Me.Dgv_viewTransaksiJualsebelumnnya = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.lblAlamatPelanggan = New System.Windows.Forms.Label()
        Me.txtnojual = New System.Windows.Forms.TextBox()
        Me.lblTanggalJual = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNamaAdmin = New System.Windows.Forms.Label()
        Me.lblJamJual = New System.Windows.Forms.Label()
        Me.BtnInsertReturBarang = New System.Windows.Forms.Button()
        Me.txtJumlahbarangretur = New System.Windows.Forms.TextBox()
        Me.txtkodebarangretur = New System.Windows.Forms.TextBox()
        Me.lblhargabarangretur = New System.Windows.Forms.Label()
        Me.lblNamaBarangRetur = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNoRetur = New System.Windows.Forms.Label()
        Me.lblkodepelanggan = New System.Windows.Forms.Label()
        Me.lblkodeadmin = New System.Windows.Forms.Label()
        CType(Me.Dgv_returBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_viewTransaksiJualsebelumnnya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(24, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Jual/Transaksi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv_returBarang
        '
        Me.Dgv_returBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_returBarang.Location = New System.Drawing.Point(11, 263)
        Me.Dgv_returBarang.Name = "Dgv_returBarang"
        Me.Dgv_returBarang.Size = New System.Drawing.Size(798, 164)
        Me.Dgv_returBarang.TabIndex = 1
        '
        'Dgv_viewTransaksiJualsebelumnnya
        '
        Me.Dgv_viewTransaksiJualsebelumnnya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_viewTransaksiJualsebelumnnya.Location = New System.Drawing.Point(11, 433)
        Me.Dgv_viewTransaksiJualsebelumnnya.Name = "Dgv_viewTransaksiJualsebelumnnya"
        Me.Dgv_viewTransaksiJualsebelumnnya.Size = New System.Drawing.Size(798, 157)
        Me.Dgv_viewTransaksiJualsebelumnnya.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pelanggan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(24, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat Pelanggan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(446, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Record Tanggal Jual/Transaksi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(130, 95)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(289, 23)
        Me.lblNamaPelanggan.TabIndex = 6
        Me.lblNamaPelanggan.Text = "Nama Pelanggan"
        Me.lblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlamatPelanggan
        '
        Me.lblAlamatPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.lblAlamatPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlamatPelanggan.Location = New System.Drawing.Point(130, 140)
        Me.lblAlamatPelanggan.Name = "lblAlamatPelanggan"
        Me.lblAlamatPelanggan.Size = New System.Drawing.Size(289, 23)
        Me.lblAlamatPelanggan.TabIndex = 7
        Me.lblAlamatPelanggan.Text = "Alamat Pelanggan"
        Me.lblAlamatPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnojual
        '
        Me.txtnojual.BackColor = System.Drawing.SystemColors.Control
        Me.txtnojual.Location = New System.Drawing.Point(130, 54)
        Me.txtnojual.Name = "txtnojual"
        Me.txtnojual.Size = New System.Drawing.Size(119, 20)
        Me.txtnojual.TabIndex = 8
        '
        'lblTanggalJual
        '
        Me.lblTanggalJual.BackColor = System.Drawing.SystemColors.Control
        Me.lblTanggalJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTanggalJual.Location = New System.Drawing.Point(613, 52)
        Me.lblTanggalJual.Name = "lblTanggalJual"
        Me.lblTanggalJual.Size = New System.Drawing.Size(123, 23)
        Me.lblTanggalJual.TabIndex = 9
        Me.lblTanggalJual.Text = "Tanggal Jual/Transaksi"
        Me.lblTanggalJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(446, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Record Jam Jual/Transaksi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(446, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nama Admin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaAdmin
        '
        Me.lblNamaAdmin.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaAdmin.Location = New System.Drawing.Point(575, 140)
        Me.lblNamaAdmin.Name = "lblNamaAdmin"
        Me.lblNamaAdmin.Size = New System.Drawing.Size(235, 23)
        Me.lblNamaAdmin.TabIndex = 12
        Me.lblNamaAdmin.Text = "Nama Admin"
        Me.lblNamaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamJual
        '
        Me.lblJamJual.BackColor = System.Drawing.SystemColors.Control
        Me.lblJamJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJamJual.Location = New System.Drawing.Point(613, 96)
        Me.lblJamJual.Name = "lblJamJual"
        Me.lblJamJual.Size = New System.Drawing.Size(123, 23)
        Me.lblJamJual.TabIndex = 13
        Me.lblJamJual.Text = "Jam Jual/Transaksi"
        Me.lblJamJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnInsertReturBarang
        '
        Me.BtnInsertReturBarang.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnInsertReturBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertReturBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInsertReturBarang.Location = New System.Drawing.Point(725, 217)
        Me.BtnInsertReturBarang.Name = "BtnInsertReturBarang"
        Me.BtnInsertReturBarang.Size = New System.Drawing.Size(85, 25)
        Me.BtnInsertReturBarang.TabIndex = 43
        Me.BtnInsertReturBarang.Text = "Insert"
        Me.BtnInsertReturBarang.UseVisualStyleBackColor = False
        '
        'txtJumlahbarangretur
        '
        Me.txtJumlahbarangretur.BackColor = System.Drawing.SystemColors.Control
        Me.txtJumlahbarangretur.Location = New System.Drawing.Point(652, 217)
        Me.txtJumlahbarangretur.Multiline = True
        Me.txtJumlahbarangretur.Name = "txtJumlahbarangretur"
        Me.txtJumlahbarangretur.Size = New System.Drawing.Size(67, 24)
        Me.txtJumlahbarangretur.TabIndex = 42
        '
        'txtkodebarangretur
        '
        Me.txtkodebarangretur.BackColor = System.Drawing.SystemColors.Control
        Me.txtkodebarangretur.Location = New System.Drawing.Point(68, 217)
        Me.txtkodebarangretur.Name = "txtkodebarangretur"
        Me.txtkodebarangretur.Size = New System.Drawing.Size(63, 20)
        Me.txtkodebarangretur.TabIndex = 41
        '
        'lblhargabarangretur
        '
        Me.lblhargabarangretur.BackColor = System.Drawing.SystemColors.Control
        Me.lblhargabarangretur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblhargabarangretur.Location = New System.Drawing.Point(457, 217)
        Me.lblhargabarangretur.Name = "lblhargabarangretur"
        Me.lblhargabarangretur.Size = New System.Drawing.Size(96, 23)
        Me.lblhargabarangretur.TabIndex = 40
        Me.lblhargabarangretur.Text = "Harga"
        Me.lblhargabarangretur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamaBarangRetur
        '
        Me.lblNamaBarangRetur.BackColor = System.Drawing.SystemColors.Control
        Me.lblNamaBarangRetur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaBarangRetur.Location = New System.Drawing.Point(194, 217)
        Me.lblNamaBarangRetur.Name = "lblNamaBarangRetur"
        Me.lblNamaBarangRetur.Size = New System.Drawing.Size(201, 23)
        Me.lblNamaBarangRetur.TabIndex = 39
        Me.lblNamaBarangRetur.Text = "Nama barang retur/dikembalikan"
        Me.lblNamaBarangRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(559, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 23)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Jumlah retur"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(401, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 23)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Harga"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(140, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Nama"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(14, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 23)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Kode"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(14, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(796, 2)
        Me.Label16.TabIndex = 44
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(13, 252)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(796, 2)
        Me.Label17.TabIndex = 45
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(265, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "*) Input Barang      (Tekan ENTER setelah Input Kode)"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(24, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "No Retur"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoRetur
        '
        Me.lblNoRetur.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoRetur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoRetur.Location = New System.Drawing.Point(130, 20)
        Me.lblNoRetur.Name = "lblNoRetur"
        Me.lblNoRetur.Size = New System.Drawing.Size(119, 23)
        Me.lblNoRetur.TabIndex = 48
        Me.lblNoRetur.Text = "No Retur"
        Me.lblNoRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblkodepelanggan
        '
        Me.lblkodepelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblkodepelanggan.Location = New System.Drawing.Point(276, 20)
        Me.lblkodepelanggan.Name = "lblkodepelanggan"
        Me.lblkodepelanggan.Size = New System.Drawing.Size(100, 23)
        Me.lblkodepelanggan.TabIndex = 49
        Me.lblkodepelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblkodepelanggan.Visible = False
        '
        'lblkodeadmin
        '
        Me.lblkodeadmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblkodeadmin.Location = New System.Drawing.Point(276, 54)
        Me.lblkodeadmin.Name = "lblkodeadmin"
        Me.lblkodeadmin.Size = New System.Drawing.Size(100, 23)
        Me.lblkodeadmin.TabIndex = 50
        Me.lblkodeadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblkodeadmin.Visible = False
        '
        'ReturTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(822, 599)
        Me.Controls.Add(Me.lblkodeadmin)
        Me.Controls.Add(Me.lblkodepelanggan)
        Me.Controls.Add(Me.lblNoRetur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnInsertReturBarang)
        Me.Controls.Add(Me.txtJumlahbarangretur)
        Me.Controls.Add(Me.txtkodebarangretur)
        Me.Controls.Add(Me.lblhargabarangretur)
        Me.Controls.Add(Me.lblNamaBarangRetur)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblJamJual)
        Me.Controls.Add(Me.lblNamaAdmin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTanggalJual)
        Me.Controls.Add(Me.txtnojual)
        Me.Controls.Add(Me.lblAlamatPelanggan)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dgv_viewTransaksiJualsebelumnnya)
        Me.Controls.Add(Me.Dgv_returBarang)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReturTransaksiPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv_returBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_viewTransaksiJualsebelumnnya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_returBarang As DataGridView
    Friend WithEvents Dgv_viewTransaksiJualsebelumnnya As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents lblAlamatPelanggan As Label
    Friend WithEvents txtnojual As TextBox
    Friend WithEvents lblTanggalJual As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNamaAdmin As Label
    Friend WithEvents lblJamJual As Label
    Friend WithEvents BtnInsertReturBarang As Button
    Friend WithEvents txtJumlahbarangretur As TextBox
    Friend WithEvents txtkodebarangretur As TextBox
    Friend WithEvents lblhargabarangretur As Label
    Friend WithEvents lblNamaBarangRetur As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNoRetur As Label
    Friend WithEvents lblkodepelanggan As Label
    Friend WithEvents lblkodeadmin As Label
End Class
