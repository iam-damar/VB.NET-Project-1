﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapPerNotaViewer
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
        Me.CrystalReportViewerLapPerNota = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerLapPerNota
        '
        Me.CrystalReportViewerLapPerNota.ActiveViewIndex = -1
        Me.CrystalReportViewerLapPerNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerLapPerNota.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerLapPerNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerLapPerNota.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerLapPerNota.Name = "CrystalReportViewerLapPerNota"
        Me.CrystalReportViewerLapPerNota.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewerLapPerNota.TabIndex = 0
        Me.CrystalReportViewerLapPerNota.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LapPerNotaViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewerLapPerNota)
        Me.Name = "LapPerNotaViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapPerNotaViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerLapPerNota As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
