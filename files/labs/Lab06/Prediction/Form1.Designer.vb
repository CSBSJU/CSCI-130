<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrediction
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.btnPredict = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(13, 416)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(459, 33)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'outResults
        '
        Me.outResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outResults.Location = New System.Drawing.Point(13, 52)
        Me.outResults.Name = "outResults"
        Me.outResults.ReadOnly = True
        Me.outResults.Size = New System.Drawing.Size(459, 358)
        Me.outResults.TabIndex = 4
        Me.outResults.Text = ""
        '
        'btnPredict
        '
        Me.btnPredict.Location = New System.Drawing.Point(12, 12)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(460, 33)
        Me.btnPredict.TabIndex = 3
        Me.btnPredict.Text = "Predict"
        Me.btnPredict.UseVisualStyleBackColor = True
        '
        'frmPrediction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.btnPredict)
        Me.Name = "frmPrediction"
        Me.Text = "Prediction"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPredict As System.Windows.Forms.Button

End Class
