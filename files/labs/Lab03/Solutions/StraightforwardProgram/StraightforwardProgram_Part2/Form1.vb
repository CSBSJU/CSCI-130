Public Class frmStraightforwardProgram
    ' A button to print a message with user input
    Private Sub btnPrintMessage_Click(sender As Object, e As EventArgs) Handles btnPrintMessage.Click
        Dim firstName As String = "", lastName As String = "", monthOfBirth As String = "", dayOfBirth As String = "", yearOfBirth As String = "", college As String = "", major As String = ""

        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        monthOfBirth = txtMonthOfBirth.Text
        dayOfBirth = txtDayOfBirth.Text
        yearOfBirth = txtYearOfBirth.Text
        college = txtCollege.Text
        major = txtMajor.Text

        outResults.Text = firstName & " " & lastName & " was born on " & monthOfBirth & " " & dayOfBirth & ", " & yearOfBirth & ". They are a " & major & " major at " & college & "."
    End Sub

    ' A button to end the program
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
