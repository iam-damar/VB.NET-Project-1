<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterPelanggan))
        Me.Dgv_Pelanggan = New System.Windows.Forms.DataGridView()
        Me.kodepelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namapelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatpelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telppelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.Dgv_Pelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Pelanggan
        '
        Me.Dgv_Pelanggan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Pelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodepelanggan, Me.namapelanggan, Me.alamatpelanggan, Me.telppelanggan})
        Me.Dgv_Pelanggan.Location = New System.Drawing.Point(12, 283)
        Me.Dgv_Pelanggan.Name = "Dgv_Pelanggan"
        Me.Dgv_Pelanggan.Size = New System.Drawing.Size(576, 210)
        Me.Dgv_Pelanggan.TabIndex = 27
        '
        'kodepelanggan
        '
        Me.kodepelanggan.DataPropertyName = "kodepelanggan"
        Me.kodepelanggan.HeaderText = "Kode Pelanggan"
        Me.kodepelanggan.Name = "kodepelanggan"
        Me.kodepelanggan.ReadOnly = True
        Me.kodepelanggan.Width = 110
        '
        'namapelanggan
        '
        Me.namapelanggan.DataPropertyName = "namapelanggan"
        Me.namapelanggan.HeaderText = "Nama"
        Me.namapelanggan.Name = "namapelanggan"
        Me.namapelanggan.ReadOnly = True
        Me.namapelanggan.Width = 150
        '
        'alamatpelanggan
        '
        Me.alamatpelanggan.DataPropertyName = "alamatpelanggan"
        Me.alamatpelanggan.HeaderText = "Alamat"
        Me.alamatpelanggan.Name = "alamatpelanggan"
        Me.alamatpelanggan.ReadOnly = True
        Me.alamatpelanggan.Width = 160
        '
        'telppelanggan
        '
        Me.telppelanggan.DataPropertyName = "telppelanggan"
        Me.telppelanggan.HeaderText = "Telepon"
        Me.telppelanggan.Name = "telppelanggan"
        Me.telppelanggan.ReadOnly = True
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Azure
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Location = New System.Drawing.Point(477, 201)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(111, 53)
        Me.BtnTutup.TabIndex = 8
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Firebrick
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHapus.Location = New System.Drawing.Point(335, 201)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(109, 53)
        Me.BtnHapus.TabIndex = 7
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEdit.Location = New System.Drawing.Point(175, 201)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(111, 53)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTambah.Location = New System.Drawing.Point(25, 201)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(115, 53)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(137, 100)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(367, 26)
        Me.txtAlamat.TabIndex = 3
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(137, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(255, 26)
        Me.txtNama.TabIndex = 2
        '
        'txtKodePelanggan
        '
        Me.txtKodePelanggan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePelanggan.Location = New System.Drawing.Point(137, 28)
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(120, 26)
        Me.txtKodePelanggan.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(26, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Telepon"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(26, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Alamat"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kode Pelanggan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelepon
        '
        Me.txtTelepon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelepon.Location = New System.Drawing.Point(137, 136)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(149, 26)
        Me.txtTelepon.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-1, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 281)
        Me.Panel1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(458, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 24)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Toko Damar"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(-1, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 50)
        Me.Panel2.TabIndex = 30
        '
        'MasterPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 548)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.Dgv_Pelanggan)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKodePelanggan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MasterPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Pelanggan"
        CType(Me.Dgv_Pelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Pelanggan As DataGridView
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKodePelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents kodepelanggan As DataGridViewTextBoxColumn
    Friend WithEvents namapelanggan As DataGridViewTextBoxColumn
    Friend WithEvents alamatpelanggan As DataGridViewTextBoxColumn
    Friend WithEvents telppelanggan As DataGridViewTextBoxColumn
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
End Class
