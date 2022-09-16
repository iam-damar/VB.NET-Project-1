<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPenjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbNoJualPerNota = New System.Windows.Forms.ComboBox()
        Me.BtnCetakPerNota = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DtTanggalHarian = New System.Windows.Forms.DateTimePicker()
        Me.BtnCetakHarian = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtAkhirMingguan = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtAwalMingguan = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCetakMingguan = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbTahun = New System.Windows.Forms.ComboBox()
        Me.CmbBulan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCetakBulanan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.CmbNoJualPerNota)
        Me.GroupBox1.Controls.Add(Me.BtnCetakPerNota)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan per Nota"
        '
        'CmbNoJualPerNota
        '
        Me.CmbNoJualPerNota.BackColor = System.Drawing.Color.White
        Me.CmbNoJualPerNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNoJualPerNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbNoJualPerNota.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNoJualPerNota.FormattingEnabled = True
        Me.CmbNoJualPerNota.Location = New System.Drawing.Point(85, 58)
        Me.CmbNoJualPerNota.Name = "CmbNoJualPerNota"
        Me.CmbNoJualPerNota.Size = New System.Drawing.Size(142, 28)
        Me.CmbNoJualPerNota.Sorted = True
        Me.CmbNoJualPerNota.TabIndex = 3
        '
        'BtnCetakPerNota
        '
        Me.BtnCetakPerNota.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnCetakPerNota.Location = New System.Drawing.Point(39, 116)
        Me.BtnCetakPerNota.Name = "BtnCetakPerNota"
        Me.BtnCetakPerNota.Size = New System.Drawing.Size(188, 44)
        Me.BtnCetakPerNota.TabIndex = 2
        Me.BtnCetakPerNota.Text = "Cetak"
        Me.BtnCetakPerNota.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Nota"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.DtTanggalHarian)
        Me.GroupBox2.Controls.Add(Me.BtnCetakHarian)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(315, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Harian"
        '
        'DtTanggalHarian
        '
        Me.DtTanggalHarian.CustomFormat = "dd MMM yyyy"
        Me.DtTanggalHarian.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTanggalHarian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtTanggalHarian.Location = New System.Drawing.Point(107, 58)
        Me.DtTanggalHarian.Name = "DtTanggalHarian"
        Me.DtTanggalHarian.Size = New System.Drawing.Size(119, 25)
        Me.DtTanggalHarian.TabIndex = 1
        '
        'BtnCetakHarian
        '
        Me.BtnCetakHarian.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCetakHarian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCetakHarian.Location = New System.Drawing.Point(50, 116)
        Me.BtnCetakHarian.Name = "BtnCetakHarian"
        Me.BtnCetakHarian.Size = New System.Drawing.Size(188, 44)
        Me.BtnCetakHarian.TabIndex = 2
        Me.BtnCetakHarian.Text = "Cetak"
        Me.BtnCetakHarian.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Controls.Add(Me.DtAkhirMingguan)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DtAwalMingguan)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnCetakMingguan)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 185)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Mingguan"
        '
        'DtAkhirMingguan
        '
        Me.DtAkhirMingguan.CustomFormat = "dd MMM yyyy"
        Me.DtAkhirMingguan.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtAkhirMingguan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAkhirMingguan.Location = New System.Drawing.Point(85, 85)
        Me.DtAkhirMingguan.Name = "DtAkhirMingguan"
        Me.DtAkhirMingguan.Size = New System.Drawing.Size(128, 25)
        Me.DtAkhirMingguan.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Akhir"
        '
        'DtAwalMingguan
        '
        Me.DtAwalMingguan.CustomFormat = "dd MMM yyyy"
        Me.DtAwalMingguan.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtAwalMingguan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAwalMingguan.Location = New System.Drawing.Point(85, 40)
        Me.DtAwalMingguan.Name = "DtAwalMingguan"
        Me.DtAwalMingguan.Size = New System.Drawing.Size(128, 25)
        Me.DtAwalMingguan.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Awal"
        '
        'BtnCetakMingguan
        '
        Me.BtnCetakMingguan.BackColor = System.Drawing.Color.DarkOrchid
        Me.BtnCetakMingguan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCetakMingguan.Location = New System.Drawing.Point(39, 130)
        Me.BtnCetakMingguan.Name = "BtnCetakMingguan"
        Me.BtnCetakMingguan.Size = New System.Drawing.Size(188, 46)
        Me.BtnCetakMingguan.TabIndex = 3
        Me.BtnCetakMingguan.Text = "Cetak"
        Me.BtnCetakMingguan.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox4.Controls.Add(Me.CmbTahun)
        Me.GroupBox4.Controls.Add(Me.CmbBulan)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.BtnCetakBulanan)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(315, 285)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 185)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Bulan"
        '
        'CmbTahun
        '
        Me.CmbTahun.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTahun.FormattingEnabled = True
        Me.CmbTahun.Location = New System.Drawing.Point(94, 76)
        Me.CmbTahun.Name = "CmbTahun"
        Me.CmbTahun.Size = New System.Drawing.Size(132, 28)
        Me.CmbTahun.TabIndex = 2
        '
        'CmbBulan
        '
        Me.CmbBulan.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBulan.FormattingEnabled = True
        Me.CmbBulan.Location = New System.Drawing.Point(94, 40)
        Me.CmbBulan.Name = "CmbBulan"
        Me.CmbBulan.Size = New System.Drawing.Size(132, 28)
        Me.CmbBulan.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tahun"
        '
        'BtnCetakBulanan
        '
        Me.BtnCetakBulanan.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnCetakBulanan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCetakBulanan.Location = New System.Drawing.Point(50, 130)
        Me.BtnCetakBulanan.Name = "BtnCetakBulanan"
        Me.BtnCetakBulanan.Size = New System.Drawing.Size(188, 46)
        Me.BtnCetakBulanan.TabIndex = 3
        Me.BtnCetakBulanan.Text = "Cetak"
        Me.BtnCetakBulanan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bulan"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 63)
        Me.Panel1.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(4, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(470, 2)
        Me.Label8.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(483, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 24)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Toko Damar"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(12, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 207)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Location = New System.Drawing.Point(12, 276)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 203)
        Me.Panel3.TabIndex = 6
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(623, 482)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCetakPerNota As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DtTanggalHarian As DateTimePicker
    Friend WithEvents BtnCetakHarian As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DtAkhirMingguan As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DtAwalMingguan As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCetakMingguan As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCetakBulanan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbTahun As ComboBox
    Friend WithEvents CmbBulan As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CmbNoJualPerNota As ComboBox
End Class
