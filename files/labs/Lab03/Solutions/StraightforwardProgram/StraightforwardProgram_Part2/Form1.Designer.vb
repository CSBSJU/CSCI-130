<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStraightforwardProgram
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.outResults = New System.Windows.Forms.RichTextBox()
        Me.btnPrintMessage = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtMonthOfBirth = New System.Windows.Forms.TextBox()
        Me.lblMonthOfBirth = New System.Windows.Forms.Label()
        Me.txtDayOfBirth = New System.Windows.Forms.TextBox()
        Me.lblDayOfBirth = New System.Windows.Forms.Label()
        Me.txtYearOfBirth = New System.Windows.Forms.TextBox()
        Me.lblYearOfBirth = New System.Windows.Forms.Label()
        Me.txtCollege = New System.Windows.Forms.TextBox()
        Me.lblCollege = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(92, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(160, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(13, 13)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(16, 46)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(92, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(160, 20)
        Me.txtLastName.TabIndex = 3
        '
        'outResults
        '
        Me.outResults.Location = New System.Drawing.Point(19, 257)
        Me.outResults.Name = "outResults"
        Me.outResults.Size = New System.Drawing.Size(233, 96)
        Me.outResults.TabIndex = 4
        Me.outResults.Text = ""
        '
        'btnPrintMessage
        '
        Me.btnPrintMessage.Location = New System.Drawing.Point(19, 360)
        Me.btnPrintMessage.Name = "btnPrintMessage"
        Me.btnPrintMessage.Size = New System.Drawing.Size(115, 23)
        Me.btnPrintMessage.TabIndex = 5
        Me.btnPrintMessage.Text = "Print message"
        Me.btnPrintMessage.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(137, 360)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(115, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtMonthOfBirth
        '
        Me.txtMonthOfBirth.Location = New System.Drawing.Point(92, 81)
        Me.txtMonthOfBirth.Name = "txtMonthOfBirth"
        Me.txtMonthOfBirth.Size = New System.Drawing.Size(160, 20)
        Me.txtMonthOfBirth.TabIndex = 8
        '
        'lblMonthOfBirth
        '
        Me.lblMonthOfBirth.AutoSize = True
        Me.lblMonthOfBirth.Location = New System.Drawing.Point(16, 81)
        Me.lblMonthOfBirth.Name = "lblMonthOfBirth"
        Me.lblMonthOfBirth.Size = New System.Drawing.Size(75, 13)
        Me.lblMonthOfBirth.TabIndex = 7
        Me.lblMonthOfBirth.Text = "Month of birth:"
        '
        'txtDayOfBirth
        '
        Me.txtDayOfBirth.Location = New System.Drawing.Point(92, 116)
        Me.txtDayOfBirth.Name = "txtDayOfBirth"
        Me.txtDayOfBirth.Size = New System.Drawing.Size(160, 20)
        Me.txtDayOfBirth.TabIndex = 10
        '
        'lblDayOfBirth
        '
        Me.lblDayOfBirth.AutoSize = True
        Me.lblDayOfBirth.Location = New System.Drawing.Point(16, 116)
        Me.lblDayOfBirth.Name = "lblDayOfBirth"
        Me.lblDayOfBirth.Size = New System.Drawing.Size(64, 13)
        Me.lblDayOfBirth.TabIndex = 9
        Me.lblDayOfBirth.Text = "Day of birth:"
        '
        'txtYearOfBirth
        '
        Me.txtYearOfBirth.Location = New System.Drawing.Point(92, 151)
        Me.txtYearOfBirth.Name = "txtYearOfBirth"
        Me.txtYearOfBirth.Size = New System.Drawing.Size(160, 20)
        Me.txtYearOfBirth.TabIndex = 12
        '
        'lblYearOfBirth
        '
        Me.lblYearOfBirth.AutoSize = True
        Me.lblYearOfBirth.Location = New System.Drawing.Point(16, 151)
        Me.lblYearOfBirth.Name = "lblYearOfBirth"
        Me.lblYearOfBirth.Size = New System.Drawing.Size(67, 13)
        Me.lblYearOfBirth.TabIndex = 11
        Me.lblYearOfBirth.Text = "Year of birth:"
        '
        'txtCollege
        '
        Me.txtCollege.Location = New System.Drawing.Point(92, 186)
        Me.txtCollege.Name = "txtCollege"
        Me.txtCollege.Size = New System.Drawing.Size(160, 20)
        Me.txtCollege.TabIndex = 14
        '
        'lblCollege
        '
        Me.lblCollege.AutoSize = True
        Me.lblCollege.Location = New System.Drawing.Point(16, 186)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(45, 13)
        Me.lblCollege.TabIndex = 13
        Me.lblCollege.Text = "College:"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(92, 221)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(160, 20)
        Me.txtMajor.TabIndex = 16
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(16, 221)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(36, 13)
        Me.lblMajor.TabIndex = 15
        Me.lblMajor.Text = "Major:"
        '
        'frmStraightforwardProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 395)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.txtCollege)
        Me.Controls.Add(Me.lblCollege)
        Me.Controls.Add(Me.txtYearOfBirth)
        Me.Controls.Add(Me.lblYearOfBirth)
        Me.Controls.Add(Me.txtDayOfBirth)
        Me.Controls.Add(Me.lblDayOfBirth)
        Me.Controls.Add(Me.txtMonthOfBirth)
        Me.Controls.Add(Me.lblMonthOfBirth)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPrintMessage)
        Me.Controls.Add(Me.outResults)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "frmStraightforwardProgram"
        Me.Text = "Straightforward Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents outResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPrintMessage As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtMonthOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents lblMonthOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtDayOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents lblDayOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtYearOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents lblYearOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtCollege As System.Windows.Forms.TextBox
    Friend WithEvents lblCollege As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label

End Class
