<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalytics
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
        Me.btnPlotByGender = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picBoxChart = New System.Windows.Forms.PictureBox()
        Me.btnPlotByBoth = New System.Windows.Forms.Button()
        Me.btnPlotByClass = New System.Windows.Forms.Button()
        CType(Me.picBoxChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlotByGender
        '
        Me.btnPlotByGender.Location = New System.Drawing.Point(12, 12)
        Me.btnPlotByGender.Name = "btnPlotByGender"
        Me.btnPlotByGender.Size = New System.Drawing.Size(110, 23)
        Me.btnPlotByGender.TabIndex = 0
        Me.btnPlotByGender.Text = "Plot by gender"
        Me.btnPlotByGender.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(362, 13)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(110, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picBoxChart
        '
        Me.picBoxChart.Location = New System.Drawing.Point(13, 42)
        Me.picBoxChart.Name = "picBoxChart"
        Me.picBoxChart.Size = New System.Drawing.Size(459, 335)
        Me.picBoxChart.TabIndex = 2
        Me.picBoxChart.TabStop = False
        '
        'btnPlotByBoth
        '
        Me.btnPlotByBoth.Location = New System.Drawing.Point(244, 13)
        Me.btnPlotByBoth.Name = "btnPlotByBoth"
        Me.btnPlotByBoth.Size = New System.Drawing.Size(110, 23)
        Me.btnPlotByBoth.TabIndex = 3
        Me.btnPlotByBoth.Text = "Plot by both"
        Me.btnPlotByBoth.UseVisualStyleBackColor = True
        '
        'btnPlotByClass
        '
        Me.btnPlotByClass.Location = New System.Drawing.Point(128, 12)
        Me.btnPlotByClass.Name = "btnPlotByClass"
        Me.btnPlotByClass.Size = New System.Drawing.Size(110, 23)
        Me.btnPlotByClass.TabIndex = 4
        Me.btnPlotByClass.Text = "Plot by class"
        Me.btnPlotByClass.UseVisualStyleBackColor = True
        '
        'frmAnalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 389)
        Me.Controls.Add(Me.btnPlotByClass)
        Me.Controls.Add(Me.btnPlotByBoth)
        Me.Controls.Add(Me.picBoxChart)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlotByGender)
        Me.Name = "frmAnalytics"
        Me.Text = "Analytics"
        CType(Me.picBoxChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlotByGender As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents picBoxChart As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlotByBoth As System.Windows.Forms.Button
    Friend WithEvents btnPlotByClass As System.Windows.Forms.Button

End Class
