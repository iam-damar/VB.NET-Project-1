<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapDataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LapDataMaster))
        Me.BtnLapAdmin = New System.Windows.Forms.Button()
        Me.BtnLapPelanggan = New System.Windows.Forms.Button()
        Me.BtnLapBarang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLapAdmin
        '
        Me.BtnLapAdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnLapAdmin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLapAdmin.Location = New System.Drawing.Point(26, 51)
        Me.BtnLapAdmin.Name = "BtnLapAdmin"
        Me.BtnLapAdmin.Size = New System.Drawing.Size(155, 55)
        Me.BtnLapAdmin.TabIndex = 1
        Me.BtnLapAdmin.Text = "Laporan Admin"
        Me.BtnLapAdmin.UseVisualStyleBackColor = False
        '
        'BtnLapPelanggan
        '
        Me.BtnLapPelanggan.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnLapPelanggan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapPelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLapPelanggan.Location = New System.Drawing.Point(211, 51)
        Me.BtnLapPelanggan.Name = "BtnLapPelanggan"
        Me.BtnLapPelanggan.Size = New System.Drawing.Size(186, 55)
        Me.BtnLapPelanggan.TabIndex = 2
        Me.BtnLapPelanggan.Text = "Laporan Pelanggan"
        Me.BtnLapPelanggan.UseVisualStyleBackColor = False
        '
        'BtnLapBarang
        '
        Me.BtnLapBarang.BackColor = System.Drawing.Color.Tan
        Me.BtnLapBarang.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLapBarang.Location = New System.Drawing.Point(430, 51)
        Me.BtnLapBarang.Name = "BtnLapBarang"
        Me.BtnLapBarang.Size = New System.Drawing.Size(160, 55)
        Me.BtnLapBarang.TabIndex = 3
        Me.BtnLapBarang.Text = "Laporan Barang"
        Me.BtnLapBarang.UseVisualStyleBackColor = False
        '
        'LapDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(614, 147)
        Me.Controls.Add(Me.BtnLapBarang)
        Me.Controls.Add(Me.BtnLapPelanggan)
        Me.Controls.Add(Me.BtnLapAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapDataMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Master"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLapAdmin As Button
    Friend WithEvents BtnLapPelanggan As Button
    Friend WithEvents BtnLapBarang As Button
End Class
