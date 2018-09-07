Public Class frmVideoRentalStore

    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        Dim firstName As String = "", lastName As String = "", fmtStr As String = "{0,-30} {1,7}" & vbNewLine
        Dim numberOfRegularVideos As Integer = 0, numberOfPremiumVideos As Integer = 0, numberOfDays As Integer = 0
        Dim pretaxTotal As Single = 0.0

        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        numberOfRegularVideos = txtNumberOfRegularVideos.Text
        numberOfPremiumVideos = txtNumberOfPremiumVideos.Text
        numberOfDays = txtNumberOfDays.Text
        pretaxTotal = ((numberOfRegularVideos * 2.5 + numberOfPremiumVideos * 5.25) * numberOfDays)

        outResults.Text = "Customer name: " & firstName & " " & lastName & vbNewLine
        outResults.AppendText("Rental period: " & numberOfDays & " days" & vbNewLine)
        outResults.AppendText(vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "Regular videos (" & numberOfRegularVideos & " @ $2.50)", FormatCurrency(numberOfRegularVideos * 2.5 * numberOfDays)))
        outResults.AppendText(String.Format(fmtStr, "Premium videos (" & numberOfPremiumVideos & " @ $5.25)", FormatCurrency(numberOfPremiumVideos * 5.25 * numberOfDays)))
        outResults.AppendText("--------------------------------------" & vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "Subtotal", FormatCurrency(pretaxTotal)))
        outResults.AppendText(String.Format(fmtStr, "Tax", FormatCurrency(pretaxTotal * 0.07)))
        outResults.AppendText(String.Format(fmtStr, "Total", FormatCurrency(pretaxTotal * 1.07)))
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
