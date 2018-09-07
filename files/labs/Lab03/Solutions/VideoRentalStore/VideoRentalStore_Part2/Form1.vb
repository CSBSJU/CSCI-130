Public Class Form1

    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        Dim firstName As String = "", lastName As String = ""
        Dim numberOfVideos As Integer = 0, numberOfDays As Integer = 0

        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        numberOfVideos = txtNumberOfVideos.Text
        numberOfDays = txtNumberOfDays.Text

        outResults.Text = "Total cost for " & firstName & " " & lastName & " is $" & (numberOfVideos * numberOfDays * 2.5)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
