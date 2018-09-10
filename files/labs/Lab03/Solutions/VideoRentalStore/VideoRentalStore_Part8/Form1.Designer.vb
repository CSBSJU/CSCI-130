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
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.txtSodaSale = New System.Windows.Forms.Button()
        Me.btnPopcornSale = New System.Windows.Forms.Button()
        Me.btnCandyBarSale = New System.Windows.Forms.Button()
        Me.btnRegularVideoSale = New System.Windows.Forms.Button()
        Me.btnPremiumVideoSale = New System.Windows.Forms.Button()
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
        'outResults
        '
        Me.outResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outResults.Location = New System.Drawing.Point(12, 239)
        Me.outResults.Name = "outResults"
        Me.outResults.Size = New System.Drawing.Size(298, 265)
        Me.outResults.TabIndex = 6
        Me.outResults.Text = ""
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.Location = New System.Drawing.Point(12, 510)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(145, 23)
        Me.btnComputeTotal.TabIndex = 7
        Me.btnComputeTotal.Text = "Compute total"
        Me.btnComputeTotal.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(165, 510)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(145, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Location = New System.Drawing.Point(149, 58)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(161, 20)
        Me.txtNumberOfDays.TabIndex = 10
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Location = New System.Drawing.Point(12, 61)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(84, 13)
        Me.lblNumberOfDays.TabIndex = 9
        Me.lblNumberOfDays.Text = "Number of days:"
        '
        'txtSodaSale
        '
        Me.txtSodaSale.Location = New System.Drawing.Point(12, 214)
        Me.txtSodaSale.Name = "txtSodaSale"
        Me.txtSodaSale.Size = New System.Drawing.Size(298, 23)
        Me.txtSodaSale.TabIndex = 17
        Me.txtSodaSale.Text = "Soda sale"
        Me.txtSodaSale.UseVisualStyleBackColor = True
        '
        'btnPopcornSale
        '
        Me.btnPopcornSale.Location = New System.Drawing.Point(12, 187)
        Me.btnPopcornSale.Name = "btnPopcornSale"
        Me.btnPopcornSale.Size = New System.Drawing.Size(298, 23)
        Me.btnPopcornSale.TabIndex = 18
        Me.btnPopcornSale.Text = "Popcorn sale"
        Me.btnPopcornSale.UseVisualStyleBackColor = True
        '
        'btnCandyBarSale
        '
        Me.btnCandyBarSale.Location = New System.Drawing.Point(12, 158)
        Me.btnCandyBarSale.Name = "btnCandyBarSale"
        Me.btnCandyBarSale.Size = New System.Drawing.Size(298, 23)
        Me.btnCandyBarSale.TabIndex = 19
        Me.btnCandyBarSale.Text = "Candy bar sale"
        Me.btnCandyBarSale.UseVisualStyleBackColor = True
        '
        'btnRegularVideoSale
        '
        Me.btnRegularVideoSale.Location = New System.Drawing.Point(12, 84)
        Me.btnRegularVideoSale.Name = "btnRegularVideoSale"
        Me.btnRegularVideoSale.Size = New System.Drawing.Size(298, 23)
        Me.btnRegularVideoSale.TabIndex = 20
        Me.btnRegularVideoSale.Text = "Regular video sale"
        Me.btnRegularVideoSale.UseVisualStyleBackColor = True
        '
        'btnPremiumVideoSale
        '
        Me.btnPremiumVideoSale.Location = New System.Drawing.Point(12, 113)
        Me.btnPremiumVideoSale.Name = "btnPremiumVideoSale"
        Me.btnPremiumVideoSale.Size = New System.Drawing.Size(298, 23)
        Me.btnPremiumVideoSale.TabIndex = 21
        Me.btnPremiumVideoSale.Text = "Premium video sale"
        Me.btnPremiumVideoSale.UseVisualStyleBackColor = True
        '
        'frmVideoRentalStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 545)
        Me.Controls.Add(Me.btnPremiumVideoSale)
        Me.Controls.Add(Me.btnRegularVideoSale)
        Me.Controls.Add(Me.btnCandyBarSale)
        Me.Controls.Add(Me.btnPopcornSale)
        Me.Controls.Add(Me.txtSodaSale)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.outResults)
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
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfDays As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfDays As System.Windows.Forms.Label
    Friend WithEvents txtSodaSale As System.Windows.Forms.Button
    Friend WithEvents btnPopcornSale As System.Windows.Forms.Button
    Friend WithEvents btnCandyBarSale As System.Windows.Forms.Button
    Friend WithEvents btnRegularVideoSale As System.Windows.Forms.Button
    Friend WithEvents btnPremiumVideoSale As System.Windows.Forms.Button

End Class
