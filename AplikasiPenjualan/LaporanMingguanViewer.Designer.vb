<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMingguanViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanMingguanViewer))
        Me.CrystalReportViewerLapMingguan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLapMingguan
        '
        Me.CrystalReportViewerLapMingguan.ActiveViewIndex = -1
        Me.CrystalReportViewerLapMingguan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLapMingguan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLapMingguan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLapMingguan.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLapMingguan.Name = "CrystalReportViewerLapMingguan"
        Me.CrystalReportViewerLapMingguan.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewerLapMingguan.TabIndex = 0
        Me.CrystalReportViewerLapMingguan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LaporanMingguanViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewerLapMingguan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanMingguanViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanMingguanViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLapMingguan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
