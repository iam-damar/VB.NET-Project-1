<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapPelangganViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LapPelangganViewer))
        Me.CrystalReportViewerLapPelanggan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportLapDataPelanggan1 = New AplikasiPenjualan.CrystalReportLapDataPelanggan()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLapPelanggan
        '
        Me.CrystalReportViewerLapPelanggan.ActiveViewIndex = -1
        Me.CrystalReportViewerLapPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLapPelanggan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLapPelanggan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLapPelanggan.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLapPelanggan.Name = "CrystalReportViewerLapPelanggan"
        Me.CrystalReportViewerLapPelanggan.Size = New System.Drawing.Size(800, 749)
        Me.CrystalReportViewerLapPelanggan.TabIndex = 0
        Me.CrystalReportViewerLapPelanggan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LapPelangganViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.CrystalReportViewerLapPelanggan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapPelangganViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Pelanggan Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLapPelanggan As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportLapDataPelanggan1 As CrystalReportLapDataPelanggan
End Class
