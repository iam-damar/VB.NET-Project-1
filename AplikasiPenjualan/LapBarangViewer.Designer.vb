<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapBarangViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LapBarangViewer))
        Me.CrystalReportViewerLapBarang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLapBarang
        '
        Me.CrystalReportViewerLapBarang.ActiveViewIndex = -1
        Me.CrystalReportViewerLapBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLapBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLapBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLapBarang.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLapBarang.Name = "CrystalReportViewerLapBarang"
        Me.CrystalReportViewerLapBarang.Size = New System.Drawing.Size(800, 749)
        Me.CrystalReportViewerLapBarang.TabIndex = 0
        Me.CrystalReportViewerLapBarang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LapBarangViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.CrystalReportViewerLapBarang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapBarangViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapBarangViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLapBarang As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
