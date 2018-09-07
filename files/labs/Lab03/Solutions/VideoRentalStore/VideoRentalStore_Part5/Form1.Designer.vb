<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoRentalStore
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfRegularVideos = New System.Windows.Forms.TextBox()
        Me.lblNumberOfRegularVideos = New System.Windows.Forms.Label()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.txtNumberOfPremiumVideos = New System.Windows.Forms.TextBox()
        Me.lblNumberOfPreimumVideos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 9)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 35)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(149, 6)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(161, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(149, 32)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(161, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtNumberOfRegularVideos
        '
        Me.txtNumberOfRegularVideos.Location = New System.Drawing.Point(149, 58)
        Me.txtNumberOfRegularVideos.Name = "txtNumberOfRegularVideos"
        Me.txtNumberOfRegularVideos.Size = New System.Drawing.Size(161, 20)
        Me.txtNumberOfRegularVideos.TabIndex = 5
        '
        'lblNumberOfRegularVideos
        '
        Me.lblNumberOfRegularVideos.AutoSize = True
        Me.lblNumberOfRegularVideos.Location = New System.Drawing.Point(12, 61)
        Me.lblNumberOfRegularVideos.Name = "lblNumberOfRegularVideos"
        Me.lblNumberOfRegularVideos.Size = New System.Drawing.Size(128, 13)
        Me.lblNumberOfRegularVideos.TabIndex = 4
        Me.lblNumberOfRegularVideos.Text = "Number of regular videos:"
        '
        'outResults
        '
        Me.outResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outResults.Location = New System.Drawing.Point(12, 136)
        Me.outResults.Name = "outResults"
        Me.outResults.Size = New System.Drawing.Size(298, 265)
        Me.outResults.TabIndex = 6
        Me.outResults.Text = ""
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.Location = New System.Drawing.Point(12, 407)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(145, 23)
        Me.btnComputeTotal.TabIndex = 7
        Me.btnComputeTotal.Text = "Compute total"
        Me.btnComputeTotal.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(165, 407)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(145, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Location = New System.Drawing.Point(149, 110)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(161, 20)
        Me.txtNumberOfDays.TabIndex = 10
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Location = New System.Drawing.Point(12, 113)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(84, 13)
        Me.lblNumberOfDays.TabIndex = 9
        Me.lblNumberOfDays.Text = "Number of days:"
        '
        'txtNumberOfPremiumVideos
        '
        Me.txtNumberOfPremiumVideos.Location = New System.Drawing.Point(149, 84)
        Me.txtNumberOfPremiumVideos.Name = "txtNumberOfPremiumVideos"
        Me.txtNumberOfPremiumVideos.Size = New System.Drawing.Size(161, 20)
        Me.txtNumberOfPremiumVideos.TabIndex = 12
        '
        'lblNumberOfPreimumVideos
        '
        Me.lblNumberOfPreimumVideos.AutoSize = True
        Me.lblNumberOfPreimumVideos.Location = New System.Drawing.Point(12, 87)
        Me.lblNumberOfPreimumVideos.Name = "lblNumberOfPreimumVideos"
        Me.lblNumberOfPreimumVideos.Size = New System.Drawing.Size(135, 13)
        Me.lblNumberOfPreimumVideos.TabIndex = 11
        Me.lblNumberOfPreimumVideos.Text = "Number of premium videos:"
        '
        'frmVideoRentalStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 442)
        Me.Controls.Add(Me.txtNumberOfPremiumVideos)
        Me.Controls.Add(Me.lblNumberOfPreimumVideos)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.txtNumberOfRegularVideos)
        Me.Controls.Add(Me.lblNumberOfRegularVideos)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmVideoRentalStore"
        Me.Text = "Video rental store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfRegularVideos As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfRegularVideos As System.Windows.Forms.Label
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfDays As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfDays As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfPremiumVideos As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfPreimumVideos As System.Windows.Forms.Label

End Class
