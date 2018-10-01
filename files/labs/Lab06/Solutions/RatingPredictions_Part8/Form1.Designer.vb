<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRatingPredictions
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
        Me.btnComputeDistances = New System.Windows.Forms.Button()
        Me.btnLoadData = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.btnPredictRatings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComputeDistances
        '
        Me.btnComputeDistances.Location = New System.Drawing.Point(160, 12)
        Me.btnComputeDistances.Name = "btnComputeDistances"
        Me.btnComputeDistances.Size = New System.Drawing.Size(136, 33)
        Me.btnComputeDistances.TabIndex = 12
        Me.btnComputeDistances.Text = "Compute distances"
        Me.btnComputeDistances.UseVisualStyleBackColor = True
        '
        'btnLoadData
        '
        Me.btnLoadData.Location = New System.Drawing.Point(12, 12)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(136, 33)
        Me.btnLoadData.TabIndex = 11
        Me.btnLoadData.Text = "Load data"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(456, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(136, 33)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'outResults
        '
        Me.outResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outResults.Location = New System.Drawing.Point(13, 52)
        Me.outResults.Name = "outResults"
        Me.outResults.ReadOnly = True
        Me.outResults.Size = New System.Drawing.Size(579, 397)
        Me.outResults.TabIndex = 9
        Me.outResults.Text = ""
        '
        'btnPredictRatings
        '
        Me.btnPredictRatings.Location = New System.Drawing.Point(308, 12)
        Me.btnPredictRatings.Name = "btnPredictRatings"
        Me.btnPredictRatings.Size = New System.Drawing.Size(136, 33)
        Me.btnPredictRatings.TabIndex = 8
        Me.btnPredictRatings.Text = "Predict rating"
        Me.btnPredictRatings.UseVisualStyleBackColor = True
        '
        'frmRatingPredictions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 461)
        Me.Controls.Add(Me.btnComputeDistances)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.btnPredictRatings)
        Me.Name = "frmRatingPredictions"
        Me.Text = "Rating predictions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnComputeDistances As System.Windows.Forms.Button
    Friend WithEvents btnLoadData As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPredictRatings As System.Windows.Forms.Button

End Class
