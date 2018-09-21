<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordCracking
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
        Me.lblAlphabetSize = New System.Windows.Forms.Label()
        Me.txtAlphabetSize = New System.Windows.Forms.TextBox()
        Me.lblGuessesPerSec = New System.Windows.Forms.Label()
        Me.txtGuessesPerSec = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblSearchTime = New System.Windows.Forms.Label()
        Me.txtSearchTime = New System.Windows.Forms.TextBox()
        Me.lblSearchSpace = New System.Windows.Forms.Label()
        Me.txtSearchSpace = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAlphabetSize
        '
        Me.lblAlphabetSize.AutoSize = True
        Me.lblAlphabetSize.Location = New System.Drawing.Point(14, 88)
        Me.lblAlphabetSize.Name = "lblAlphabetSize"
        Me.lblAlphabetSize.Size = New System.Drawing.Size(73, 13)
        Me.lblAlphabetSize.TabIndex = 36
        Me.lblAlphabetSize.Text = "Alphabet size:"
        Me.lblAlphabetSize.UseWaitCursor = True
        '
        'txtAlphabetSize
        '
        Me.txtAlphabetSize.Enabled = False
        Me.txtAlphabetSize.Location = New System.Drawing.Point(102, 85)
        Me.txtAlphabetSize.Name = "txtAlphabetSize"
        Me.txtAlphabetSize.ReadOnly = True
        Me.txtAlphabetSize.Size = New System.Drawing.Size(232, 20)
        Me.txtAlphabetSize.TabIndex = 35
        Me.txtAlphabetSize.UseWaitCursor = True
        '
        'lblGuessesPerSec
        '
        Me.lblGuessesPerSec.AutoSize = True
        Me.lblGuessesPerSec.Location = New System.Drawing.Point(12, 40)
        Me.lblGuessesPerSec.Name = "lblGuessesPerSec"
        Me.lblGuessesPerSec.Size = New System.Drawing.Size(115, 13)
        Me.lblGuessesPerSec.TabIndex = 34
        Me.lblGuessesPerSec.Text = "Enter # guesses / sec:"
        Me.lblGuessesPerSec.UseWaitCursor = True
        '
        'txtGuessesPerSec
        '
        Me.txtGuessesPerSec.Location = New System.Drawing.Point(133, 37)
        Me.txtGuessesPerSec.Name = "txtGuessesPerSec"
        Me.txtGuessesPerSec.Size = New System.Drawing.Size(200, 20)
        Me.txtGuessesPerSec.TabIndex = 33
        Me.txtGuessesPerSec.UseWaitCursor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 14)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 13)
        Me.lblPassword.TabIndex = 32
        Me.lblPassword.Text = "Enter password:"
        Me.lblPassword.UseWaitCursor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(133, 11)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 31
        Me.txtPassword.UseWaitCursor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(13, 166)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(320, 38)
        Me.btnCompute.TabIndex = 30
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        Me.btnCompute.UseWaitCursor = True
        '
        'lblSearchTime
        '
        Me.lblSearchTime.AutoSize = True
        Me.lblSearchTime.Location = New System.Drawing.Point(13, 143)
        Me.lblSearchTime.Name = "lblSearchTime"
        Me.lblSearchTime.Size = New System.Drawing.Size(66, 13)
        Me.lblSearchTime.TabIndex = 29
        Me.lblSearchTime.Text = "Search time:"
        Me.lblSearchTime.UseWaitCursor = True
        '
        'txtSearchTime
        '
        Me.txtSearchTime.Enabled = False
        Me.txtSearchTime.Location = New System.Drawing.Point(101, 140)
        Me.txtSearchTime.Name = "txtSearchTime"
        Me.txtSearchTime.ReadOnly = True
        Me.txtSearchTime.Size = New System.Drawing.Size(232, 20)
        Me.txtSearchTime.TabIndex = 28
        Me.txtSearchTime.UseWaitCursor = True
        '
        'lblSearchSpace
        '
        Me.lblSearchSpace.AutoSize = True
        Me.lblSearchSpace.Location = New System.Drawing.Point(13, 117)
        Me.lblSearchSpace.Name = "lblSearchSpace"
        Me.lblSearchSpace.Size = New System.Drawing.Size(76, 13)
        Me.lblSearchSpace.TabIndex = 27
        Me.lblSearchSpace.Text = "Search space:"
        Me.lblSearchSpace.UseWaitCursor = True
        '
        'txtSearchSpace
        '
        Me.txtSearchSpace.Enabled = False
        Me.txtSearchSpace.Location = New System.Drawing.Point(101, 114)
        Me.txtSearchSpace.Name = "txtSearchSpace"
        Me.txtSearchSpace.ReadOnly = True
        Me.txtSearchSpace.Size = New System.Drawing.Size(232, 20)
        Me.txtSearchSpace.TabIndex = 26
        Me.txtSearchSpace.UseWaitCursor = True
        '
        'frmPasswordCracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 219)
        Me.Controls.Add(Me.lblAlphabetSize)
        Me.Controls.Add(Me.txtAlphabetSize)
        Me.Controls.Add(Me.lblGuessesPerSec)
        Me.Controls.Add(Me.txtGuessesPerSec)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblSearchTime)
        Me.Controls.Add(Me.txtSearchTime)
        Me.Controls.Add(Me.lblSearchSpace)
        Me.Controls.Add(Me.txtSearchSpace)
        Me.Name = "frmPasswordCracking"
        Me.Text = "Password Cracking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAlphabetSize As System.Windows.Forms.Label
    Public WithEvents txtAlphabetSize As System.Windows.Forms.TextBox
    Friend WithEvents lblGuessesPerSec As System.Windows.Forms.Label
    Public WithEvents txtGuessesPerSec As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblSearchTime As System.Windows.Forms.Label
    Public WithEvents txtSearchTime As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchSpace As System.Windows.Forms.Label
    Public WithEvents txtSearchSpace As System.Windows.Forms.TextBox

End Class
