<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlotGPAs
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
        Me.btnPlotGPAs = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picBoxChart = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlotGPAs
        '
        Me.btnPlotGPAs.Location = New System.Drawing.Point(12, 12)
        Me.btnPlotGPAs.Name = "btnPlotGPAs"
        Me.btnPlotGPAs.Size = New System.Drawing.Size(225, 23)
        Me.btnPlotGPAs.TabIndex = 0
        Me.btnPlotGPAs.Text = "Plot GPAs"
        Me.btnPlotGPAs.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(247, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(225, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picBoxChart
        '
        Me.picBoxChart.Location = New System.Drawing.Point(13, 42)
        Me.picBoxChart.Name = "picBoxChart"
        Me.picBoxChart.Size = New System.Drawing.Size(459, 330)
        Me.picBoxChart.TabIndex = 2
        Me.picBoxChart.TabStop = False
        '
        'frmPlotGPAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 384)
        Me.Controls.Add(Me.picBoxChart)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlotGPAs)
        Me.Name = "frmPlotGPAs"
        Me.Text = "Plot GPAs"
        CType(Me.picBoxChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlotGPAs As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents picBoxChart As System.Windows.Forms.PictureBox

End Class
