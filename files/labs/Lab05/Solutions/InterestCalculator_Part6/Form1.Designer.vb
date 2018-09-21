<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterestCalculator
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
        Me.btnComputeTotalInterest = New System.Windows.Forms.Button()
        Me.btnComputeNumberOfYears = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.lblStartingBalance = New System.Windows.Forms.Label()
        Me.lblNominalInterestRate = New System.Windows.Forms.Label()
        Me.txtStartingBalance = New System.Windows.Forms.TextBox()
        Me.txtNominalInterestRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnComputeTotalInterest
        '
        Me.btnComputeTotalInterest.Location = New System.Drawing.Point(12, 282)
        Me.btnComputeTotalInterest.Name = "btnComputeTotalInterest"
        Me.btnComputeTotalInterest.Size = New System.Drawing.Size(255, 23)
        Me.btnComputeTotalInterest.TabIndex = 0
        Me.btnComputeTotalInterest.Text = "Compute total interest"
        Me.btnComputeTotalInterest.UseVisualStyleBackColor = True
        '
        'btnComputeNumberOfYears
        '
        Me.btnComputeNumberOfYears.Location = New System.Drawing.Point(12, 311)
        Me.btnComputeNumberOfYears.Name = "btnComputeNumberOfYears"
        Me.btnComputeNumberOfYears.Size = New System.Drawing.Size(255, 23)
        Me.btnComputeNumberOfYears.TabIndex = 1
        Me.btnComputeNumberOfYears.Text = "Compute number of years"
        Me.btnComputeNumberOfYears.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 340)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(255, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'outResults
        '
        Me.outResults.Location = New System.Drawing.Point(12, 58)
        Me.outResults.Name = "outResults"
        Me.outResults.Size = New System.Drawing.Size(255, 218)
        Me.outResults.TabIndex = 3
        Me.outResults.Text = ""
        '
        'lblStartingBalance
        '
        Me.lblStartingBalance.AutoSize = True
        Me.lblStartingBalance.Location = New System.Drawing.Point(9, 9)
        Me.lblStartingBalance.Name = "lblStartingBalance"
        Me.lblStartingBalance.Size = New System.Drawing.Size(87, 13)
        Me.lblStartingBalance.TabIndex = 4
        Me.lblStartingBalance.Text = "Starting balance:"
        '
        'lblNominalInterestRate
        '
        Me.lblNominalInterestRate.AutoSize = True
        Me.lblNominalInterestRate.Location = New System.Drawing.Point(9, 35)
        Me.lblNominalInterestRate.Name = "lblNominalInterestRate"
        Me.lblNominalInterestRate.Size = New System.Drawing.Size(106, 13)
        Me.lblNominalInterestRate.TabIndex = 5
        Me.lblNominalInterestRate.Text = "Nominal interest rate:"
        '
        'txtStartingBalance
        '
        Me.txtStartingBalance.Location = New System.Drawing.Point(121, 6)
        Me.txtStartingBalance.Name = "txtStartingBalance"
        Me.txtStartingBalance.Size = New System.Drawing.Size(146, 20)
        Me.txtStartingBalance.TabIndex = 7
        '
        'txtNominalInterestRate
        '
        Me.txtNominalInterestRate.Location = New System.Drawing.Point(121, 32)
        Me.txtNominalInterestRate.Name = "txtNominalInterestRate"
        Me.txtNominalInterestRate.Size = New System.Drawing.Size(146, 20)
        Me.txtNominalInterestRate.TabIndex = 8
        '
        'frmInterestCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 372)
        Me.Controls.Add(Me.txtNominalInterestRate)
        Me.Controls.Add(Me.txtStartingBalance)
        Me.Controls.Add(Me.lblNominalInterestRate)
        Me.Controls.Add(Me.lblStartingBalance)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnComputeNumberOfYears)
        Me.Controls.Add(Me.btnComputeTotalInterest)
        Me.Name = "frmInterestCalculator"
        Me.Text = "Interest calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComputeTotalInterest As System.Windows.Forms.Button
    Friend WithEvents btnComputeNumberOfYears As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents lblStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblNominalInterestRate As System.Windows.Forms.Label
    Friend WithEvents txtStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtNominalInterestRate As System.Windows.Forms.TextBox

End Class
