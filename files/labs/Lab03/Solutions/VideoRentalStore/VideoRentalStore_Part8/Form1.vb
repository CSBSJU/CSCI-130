Public Class frmVideoRentalStore
    Dim numberOfRegularVideos As Integer = 0, numberOfPremiumVideos As Integer = 0, numberOfCandyBars As Integer = 0, numberOfPopcorn As Integer = 0, numberOfSoda As Integer = 0

    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        Dim firstName As String = "", lastName As String = "", fmtStr As String = "{0,-30} {1,7}" & vbNewLine
        Dim numberOfDays As Integer = 0
        Dim pretaxTotal As Single = 0.0

        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        numberOfDays = txtNumberOfDays.Text
        pretaxTotal = ((numberOfRegularVideos * 2.5 + numberOfPremiumVideos * 5.25) * numberOfDays) + numberOfCandyBars * 1.5 + numberOfPopcorn * 5 + numberOfSoda * 2.25

        outResults.AppendText("======================================" & vbNewLine)
        outResults.AppendText(vbNewLine)
        outResults.AppendText("Customer name: " & firstName & " " & lastName & vbNewLine)
        outResults.AppendText("Rental period: " & numberOfDays & " days" & vbNewLine)
        outResults.AppendText(vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "Regular videos (" & numberOfRegularVideos & " @ $2.50)", FormatCurrency(numberOfRegularVideos * 2.5 * numberOfDays)))
        outResults.AppendText(String.Format(fmtStr, "Premium videos (" & numberOfPremiumVideos & " @ $5.25)", FormatCurrency(numberOfPremiumVideos * 5.25 * numberOfDays)))
        outResults.AppendText(String.Format(fmtStr, "Candy bars (" & numberOfCandyBars & " @ $1.50)", FormatCurrency(numberOfCandyBars * 1.5)))
        outResults.AppendText(String.Format(fmtStr, "Popcorn (" & numberOfPopcorn & " @ $5.00)", FormatCurrency(numberOfPopcorn * 5)))
        outResults.AppendText(String.Format(fmtStr, "Soda (" & numberOfSoda & " @ $2.25)", FormatCurrency(numberOfSoda * 2.25)))
        outResults.AppendText("--------------------------------------" & vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "Subtotal", FormatCurrency(pretaxTotal)))
        outResults.AppendText(String.Format(fmtStr, "Tax", FormatCurrency(pretaxTotal * 0.07)))
        outResults.AppendText(String.Format(fmtStr, "Total", FormatCurrency(pretaxTotal * 1.07)))
    End Sub

    Private Sub btnRegularVideoSale_Click(sender As Object, e As EventArgs) Handles btnRegularVideoSale.Click
        numberOfRegularVideos = numberOfRegularVideos + 1
        outResults.AppendText(numberOfRegularVideos & " x Regular videos @ $2.50 / day" & vbNewLine)
    End Sub

    Private Sub btnPremiumVideoSale_Click(sender As Object, e As EventArgs) Handles btnPremiumVideoSale.Click
        numberOfPremiumVideos = numberOfPremiumVideos + 1
        outResults.AppendText(numberOfPremiumVideos & " x Premium videos @ $5.25 / day" & vbNewLine)
    End Sub

    Private Sub btnCandyBarSale_Click(sender As Object, e As EventArgs) Handles btnCandyBarSale.Click
        numberOfCandyBars = numberOfCandyBars + 1
        outResults.AppendText(numberOfCandyBars & " x Candy bars @ $1.50" & vbNewLine)
    End Sub

    Private Sub btnPopcornSale_Click(sender As Object, e As EventArgs) Handles btnPopcornSale.Click
        numberOfPopcorn = numberOfPopcorn + 1
        outResults.AppendText(numberOfPopcorn & " x Popcorn @ $5.00" & vbNewLine)
    End Sub

    Private Sub txtSodaSale_Click(sender As Object, e As EventArgs) Handles txtSodaSale.Click
        numberOfSoda = numberOfSoda + 1
        outResults.AppendText(numberOfSoda & " x Soda @ $2.25" & vbNewLine)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
