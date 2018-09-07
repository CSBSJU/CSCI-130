Public Class frmVideoRentalStore

    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        Dim firstName As String = "", lastName As String = ""
        Dim numberOfRegularVideos As Integer = 0, numberOfPremiumVideos As Integer = 0, numberOfDays As Integer = 0
        Dim pretaxTotal As Single = 0.0

        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        numberOfRegularVideos = txtNumberOfRegularVideos.Text
        numberOfPremiumVideos = txtNumberOfPremiumVideos.Text
        numberOfDays = txtNumberOfDays.Text
        pretaxTotal = ((numberOfRegularVideos * 2.5 + numberOfPremiumVideos * 5.25) * numberOfDays)

        outResults.Text = "Hello " & firstName & " " & lastName & ", your pretax total for " & numberOfRegularVideos & " regular videos and " & numberOfPremiumVideos & " premium videos for " & numberOfDays & " days is $" & pretaxTotal & ", or $" & (pretaxTotal * 1.07) & " after tax."
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
