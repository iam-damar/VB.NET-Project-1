<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransJualViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransJualViewer))
        Me.CrystalReportViewerTransJual = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerTransJual
        '
        Me.CrystalReportViewerTransJual.ActiveViewIndex = -1
        Me.CrystalReportViewerTransJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerTransJual.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerTransJual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerTransJual.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerTransJual.Name = "CrystalReportViewerTransJual"
        Me.CrystalReportViewerTransJual.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewerTransJual.TabIndex = 0
        Me.CrystalReportViewerTransJual.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TransJualViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewerTransJual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransJualViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransJualViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerTransJual As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
