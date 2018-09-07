Public Class frmStraightforwardProgram
    ' A button to print a message with user input
    Private Sub btnPrintMessage_Click(sender As Object, e As EventArgs) Handles btnPrintMessage.Click
        Dim firstName As String = "", lastName As String = ""

        firstName = txtFirstName.Text
        lastName = txtLastName.Text

        outResults.Text = "Hello " & lastName & ", " & firstName
    End Sub

    ' A button to end the program
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
