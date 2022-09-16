<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransaksiPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiPenjualan))
        Me.TimerTransPenjualan = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Dgv_TransaksiPenjualan = New System.Windows.Forms.DataGridView()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblKembali = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblTotalItemJual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNoJual = New System.Windows.Forms.Label()
        Me.CmbKodePelanggan = New System.Windows.Forms.ComboBox()
        Me.LblNamaPelanggan = New System.Windows.Forms.Label()
        Me.LblAlamatPelanggan = New System.Windows.Forms.Label()
        Me.LblTelpPelanggan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblAdmin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblTotalHarga = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblNamaBrgInsert = New System.Windows.Forms.Label()
        Me.LblHargaBrgInsert = New System.Windows.Forms.Label()
        Me.txtKodeInsert = New System.Windows.Forms.TextBox()
        Me.txtJumlahBrgInsert = New System.Windows.Forms.TextBox()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblBarangTersedia = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.Dgv_TransaksiPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerTransPenjualan
        '
        Me.TimerTransPenjualan.Enabled = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSimpan.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSimpan.Location = New System.Drawing.Point(20, 21)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(162, 40)
        Me.BtnSimpan.TabIndex = 23
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnBatal.BackColor = System.Drawing.Color.Chocolate
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBatal.Location = New System.Drawing.Point(242, 21)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(109, 41)
        Me.BtnBatal.TabIndex = 24
        Me.BtnBatal.Text = "BATAL"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTutup
        '
        Me.BtnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTutup.BackColor = System.Drawing.Color.LightBlue
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTutup.Location = New System.Drawing.Point(391, 19)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(98, 43)
        Me.BtnTutup.TabIndex = 25
        Me.BtnTutup.Text = "TUTUP"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Dgv_TransaksiPenjualan
        '
        Me.Dgv_TransaksiPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_TransaksiPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_TransaksiPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodebarang, Me.namabarang, Me.hargabarang, Me.Jumlah, Me.Subtotal})
        Me.Dgv_TransaksiPenjualan.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dgv_TransaksiPenjualan.Location = New System.Drawing.Point(12, 295)
        Me.Dgv_TransaksiPenjualan.Name = "Dgv_TransaksiPenjualan"
        Me.Dgv_TransaksiPenjualan.Size = New System.Drawing.Size(1058, 247)
        Me.Dgv_TransaksiPenjualan.TabIndex = 18
        '
        'kodebarang
        '
        Me.kodebarang.HeaderText = "Kode Barang"
        Me.kodebarang.Name = "kodebarang"
        '
        'namabarang
        '
        Me.namabarang.HeaderText = "Nama Barang"
        Me.namabarang.Name = "namabarang"
        '
        'hargabarang
        '
        Me.hargabarang.HeaderText = "Harga Barang"
        Me.hargabarang.Name = "hargabarang"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(769, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "BAYAR"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBayar
        '
        Me.txtBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBayar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(871, 19)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(204, 26)
        Me.txtBayar.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(769, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "KEMBALI"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKembali
        '
        Me.LblKembali.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblKembali.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKembali.Location = New System.Drawing.Point(871, 53)
        Me.LblKembali.Name = "LblKembali"
        Me.LblKembali.Size = New System.Drawing.Size(204, 27)
        Me.LblKembali.TabIndex = 22
        Me.LblKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(585, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "TOTAL ITEM"
        '
        'LblTotalItemJual
        '
        Me.LblTotalItemJual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalItemJual.BackColor = System.Drawing.SystemColors.Control
        Me.LblTotalItemJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalItemJual.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalItemJual.Location = New System.Drawing.Point(667, 21)
        Me.LblTotalItemJual.Name = "LblTotalItemJual"
        Me.LblTotalItemJual.Size = New System.Drawing.Size(63, 23)
        Me.LblTotalItemJual.TabIndex = 37
        Me.LblTotalItemJual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Jual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(23, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNoJual
        '
        Me.LblNoJual.BackColor = System.Drawing.SystemColors.Control
        Me.LblNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNoJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoJual.Location = New System.Drawing.Point(125, 20)
        Me.LblNoJual.Name = "LblNoJual"
        Me.LblNoJual.Size = New System.Drawing.Size(126, 25)
        Me.LblNoJual.TabIndex = 5
        Me.LblNoJual.Text = "LblNoJual"
        Me.LblNoJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbKodePelanggan
        '
        Me.CmbKodePelanggan.BackColor = System.Drawing.SystemColors.Window
        Me.CmbKodePelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbKodePelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbKodePelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbKodePelanggan.FormattingEnabled = True
        Me.CmbKodePelanggan.Location = New System.Drawing.Point(125, 51)
        Me.CmbKodePelanggan.Name = "CmbKodePelanggan"
        Me.CmbKodePelanggan.Size = New System.Drawing.Size(126, 26)
        Me.CmbKodePelanggan.TabIndex = 6
        '
        'LblNamaPelanggan
        '
        Me.LblNamaPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.LblNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPelanggan.Location = New System.Drawing.Point(125, 85)
        Me.LblNamaPelanggan.Name = "LblNamaPelanggan"
        Me.LblNamaPelanggan.Size = New System.Drawing.Size(376, 25)
        Me.LblNamaPelanggan.TabIndex = 7
        Me.LblNamaPelanggan.Text = "LblNama"
        Me.LblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAlamatPelanggan
        '
        Me.LblAlamatPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.LblAlamatPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAlamatPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamatPelanggan.Location = New System.Drawing.Point(125, 120)
        Me.LblAlamatPelanggan.Name = "LblAlamatPelanggan"
        Me.LblAlamatPelanggan.Size = New System.Drawing.Size(376, 25)
        Me.LblAlamatPelanggan.TabIndex = 8
        Me.LblAlamatPelanggan.Text = "LblAlamat"
        Me.LblAlamatPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTelpPelanggan
        '
        Me.LblTelpPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.LblTelpPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTelpPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelpPelanggan.Location = New System.Drawing.Point(125, 155)
        Me.LblTelpPelanggan.Name = "LblTelpPelanggan"
        Me.LblTelpPelanggan.Size = New System.Drawing.Size(226, 25)
        Me.LblTelpPelanggan.TabIndex = 9
        Me.LblTelpPelanggan.Text = "LblTelepon"
        Me.LblTelpPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(565, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tanggal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(565, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Jam"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(565, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Admin"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTanggal
        '
        Me.LblTanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTanggal.BackColor = System.Drawing.SystemColors.Control
        Me.LblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(667, 86)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(107, 25)
        Me.LblTanggal.TabIndex = 13
        Me.LblTanggal.Text = "LblTanggal"
        Me.LblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblJam
        '
        Me.LblJam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblJam.BackColor = System.Drawing.SystemColors.Control
        Me.LblJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(667, 122)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(107, 25)
        Me.LblJam.TabIndex = 14
        Me.LblJam.Text = "LblJam"
        Me.LblJam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAdmin
        '
        Me.LblAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAdmin.BackColor = System.Drawing.SystemColors.Control
        Me.LblAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmin.Location = New System.Drawing.Point(667, 155)
        Me.LblAdmin.Name = "LblAdmin"
        Me.LblAdmin.Size = New System.Drawing.Size(179, 25)
        Me.LblAdmin.TabIndex = 15
        Me.LblAdmin.Text = "LblAdmin"
        Me.LblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(565, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 55)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TOTAL : Rp."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotalHarga
        '
        Me.LblTotalHarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalHarga.BackColor = System.Drawing.SystemColors.Control
        Me.LblTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalHarga.Location = New System.Drawing.Point(698, 9)
        Me.LblTotalHarga.Name = "LblTotalHarga"
        Me.LblTotalHarga.Size = New System.Drawing.Size(362, 55)
        Me.LblTotalHarga.TabIndex = 17
        Me.LblTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(17, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Kode"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(163, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 28)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Nama"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(472, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 28)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Harga"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(731, 255)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 23)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Jumlah Beli"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNamaBrgInsert
        '
        Me.LblNamaBrgInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblNamaBrgInsert.BackColor = System.Drawing.SystemColors.Control
        Me.LblNamaBrgInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaBrgInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBrgInsert.Location = New System.Drawing.Point(247, 250)
        Me.LblNamaBrgInsert.Name = "LblNamaBrgInsert"
        Me.LblNamaBrgInsert.Size = New System.Drawing.Size(219, 28)
        Me.LblNamaBrgInsert.TabIndex = 30
        Me.LblNamaBrgInsert.Text = "Nama"
        Me.LblNamaBrgInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblHargaBrgInsert
        '
        Me.LblHargaBrgInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblHargaBrgInsert.BackColor = System.Drawing.SystemColors.Control
        Me.LblHargaBrgInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHargaBrgInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHargaBrgInsert.Location = New System.Drawing.Point(539, 249)
        Me.LblHargaBrgInsert.Name = "LblHargaBrgInsert"
        Me.LblHargaBrgInsert.Size = New System.Drawing.Size(180, 28)
        Me.LblHargaBrgInsert.TabIndex = 31
        Me.LblHargaBrgInsert.Text = "Harga"
        Me.LblHargaBrgInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKodeInsert
        '
        Me.txtKodeInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtKodeInsert.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtKodeInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeInsert.Location = New System.Drawing.Point(71, 251)
        Me.txtKodeInsert.Name = "txtKodeInsert"
        Me.txtKodeInsert.Size = New System.Drawing.Size(86, 26)
        Me.txtKodeInsert.TabIndex = 32
        '
        'txtJumlahBrgInsert
        '
        Me.txtJumlahBrgInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtJumlahBrgInsert.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtJumlahBrgInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahBrgInsert.Location = New System.Drawing.Point(848, 255)
        Me.txtJumlahBrgInsert.Multiline = True
        Me.txtJumlahBrgInsert.Name = "txtJumlahBrgInsert"
        Me.txtJumlahBrgInsert.Size = New System.Drawing.Size(83, 24)
        Me.txtJumlahBrgInsert.TabIndex = 33
        '
        'BtnInsert
        '
        Me.BtnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnInsert.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnInsert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInsert.Location = New System.Drawing.Point(937, 228)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(138, 52)
        Me.BtnInsert.TabIndex = 34
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(17, 225)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(323, 16)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "*) Input Barang      (Tekan ENTER setelah Input Kode)"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(731, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 24)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Stok tersedia"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBarangTersedia
        '
        Me.LblBarangTersedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LblBarangTersedia.BackColor = System.Drawing.SystemColors.Control
        Me.LblBarangTersedia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBarangTersedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarangTersedia.Location = New System.Drawing.Point(848, 226)
        Me.LblBarangTersedia.Name = "LblBarangTersedia"
        Me.LblBarangTersedia.Size = New System.Drawing.Size(83, 23)
        Me.LblBarangTersedia.TabIndex = 39
        Me.LblBarangTersedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.LblBarangTersedia)
        Me.Panel1.Controls.Add(Me.LblNamaBrgInsert)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtJumlahBrgInsert)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnInsert)
        Me.Panel1.Controls.Add(Me.txtKodeInsert)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblHargaBrgInsert)
        Me.Panel1.Controls.Add(Me.LblTanggal)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.LblJam)
        Me.Panel1.Controls.Add(Me.LblAdmin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblNoJual)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CmbKodePelanggan)
        Me.Panel1.Controls.Add(Me.LblNamaPelanggan)
        Me.Panel1.Controls.Add(Me.LblAlamatPelanggan)
        Me.Panel1.Controls.Add(Me.LblTelpPelanggan)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 289)
        Me.Panel1.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.LblTotalItemJual)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.LblKembali)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtBayar)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.BtnSimpan)
        Me.Panel3.Controls.Add(Me.BtnTutup)
        Me.Panel3.Controls.Add(Me.BtnBatal)
        Me.Panel3.Location = New System.Drawing.Point(-5, 548)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1092, 167)
        Me.Panel3.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(18, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 25)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "TOKO DAMAR"
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(3, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(1086, 2)
        Me.Label19.TabIndex = 38
        '
        'TransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1082, 714)
        Me.Controls.Add(Me.Dgv_TransaksiPenjualan)
        Me.Controls.Add(Me.LblTotalHarga)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransaksiPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dgv_TransaksiPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerTransPenjualan As Timer
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents Dgv_TransaksiPenjualan As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LblKembali As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LblTotalItemJual As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblNoJual As Label
    Friend WithEvents CmbKodePelanggan As ComboBox
    Friend WithEvents LblNamaPelanggan As Label
    Friend WithEvents LblAlamatPelanggan As Label
    Friend WithEvents LblTelpPelanggan As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LblJam As Label
    Friend WithEvents LblAdmin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblTotalHarga As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblNamaBrgInsert As Label
    Friend WithEvents LblHargaBrgInsert As Label
    Friend WithEvents txtKodeInsert As TextBox
    Friend WithEvents txtJumlahBrgInsert As TextBox
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LblBarangTersedia As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents kodebarang As DataGridViewTextBoxColumn
    Friend WithEvents namabarang As DataGridViewTextBoxColumn
    Friend WithEvents hargabarang As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
