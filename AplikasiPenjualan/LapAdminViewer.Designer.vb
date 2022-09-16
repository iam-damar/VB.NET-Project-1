<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapAdminViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LapAdminViewer))
        Me.CrystalReportViewerLapAdmin = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportLapDataAdmin1 = New AplikasiPenjualan.CrystalReportLapDataAdmin()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLapAdmin
        '
        Me.CrystalReportViewerLapAdmin.ActiveViewIndex = -1
        Me.CrystalReportViewerLapAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLapAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLapAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLapAdmin.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLapAdmin.Name = "CrystalReportViewerLapAdmin"
        Me.CrystalReportViewerLapAdmin.Size = New System.Drawing.Size(800, 749)
        Me.CrystalReportViewerLapAdmin.TabIndex = 0
        Me.CrystalReportViewerLapAdmin.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LapAdminViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.CrystalReportViewerLapAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapAdminViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapAdminViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLapAdmin As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportLapDataAdmin1 As CrystalReportLapDataAdmin
End Class
