<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanHarianViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanHarianViewer))
        Me.CrystalReportViewerLaporanHarian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLaporanHarian
        '
        Me.CrystalReportViewerLaporanHarian.ActiveViewIndex = -1
        Me.CrystalReportViewerLaporanHarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLaporanHarian.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLaporanHarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLaporanHarian.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLaporanHarian.Name = "CrystalReportViewerLaporanHarian"
        Me.CrystalReportViewerLaporanHarian.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewerLaporanHarian.TabIndex = 0
        Me.CrystalReportViewerLaporanHarian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LaporanHarianViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewerLaporanHarian)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanHarianViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanHarianViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLaporanHarian As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
