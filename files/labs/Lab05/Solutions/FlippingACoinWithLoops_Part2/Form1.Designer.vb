<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlippingACoin
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
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(12, 180)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(260, 23)
        Me.btnFlip.TabIndex = 0
        Me.btnFlip.Text = "Flip the coin"
        Me.btnFlip.UseVisualStyleBackColor = True
        '
        'outResults
        '
        Me.outResults.Location = New System.Drawing.Point(13, 13)
        Me.outResults.Name = "outResults"
        Me.outResults.Size = New System.Drawing.Size(259, 161)
        Me.outResults.TabIndex = 1
        Me.outResults.Text = ""
        '
        'frmFlippingACoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 213)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.btnFlip)
        Me.Name = "frmFlippingACoin"
        Me.Text = "Flipping a coin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFlip As System.Windows.Forms.Button
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox

End Class
