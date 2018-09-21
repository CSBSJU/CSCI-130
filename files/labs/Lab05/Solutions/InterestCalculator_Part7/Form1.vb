Public Class frmInterestCalculator

    Private Sub btnComputeTotalInterest_Click(sender As Object, e As EventArgs) Handles btnComputeTotalInterest.Click
        Dim startingBalance As Double, currentBalance As Double, nominalInterestRate As Double
        Dim period As Integer, loopCounter As Integer = 0

        startingBalance = txtStartingBalance.Text
        nominalInterestRate = txtNominalInterestRate.Text
        period = InputBox("Please enter a number of years: ", "Period")

        currentBalance = startingBalance

        While loopCounter < period
            currentBalance = currentBalance * (1 + nominalInterestRate)

            loopCounter = loopCounter + 1
        End While

        outResults.Text = "After " & period & " years of compounding, your savings account with an initial balance of " & _
            FormatCurrency(startingBalance) & " and APR of " & FormatPercent(nominalInterestRate) & ", will have earned a total of " & _
            FormatCurrency(currentBalance - startingBalance) & " in interest."
    End Sub

    Private Sub btnComputeNumberOfYears_Click(sender As Object, e As EventArgs) Handles btnComputeNumberOfYears.Click
        Dim startingBalance As Double, currentBalance As Double, targetBalance As Double, nominalInterestRate As Double, interest As Double
        Dim period As Integer = 0
        Dim fmtStr As String = "{0,-4}   {1,8}   {2,10}" & vbNewLine

        startingBalance = txtStartingBalance.Text
        nominalInterestRate = txtNominalInterestRate.Text
        targetBalance = InputBox("Please enter a target balance: ", "Target balance")

        While targetBalance <= startingBalance
            targetBalance = InputBox("The target balance should not be less than the starting balance, please enter a new target balance: ", "New target balance")
        End While

        currentBalance = startingBalance

        outResults.Text = "Starting balance: " & FormatCurrency(startingBalance) & vbNewLine
        outResults.AppendText("APR: " & FormatPercent(nominalInterestRate) & vbNewLine)
        outResults.AppendText("Target balance: " & FormatCurrency(targetBalance) & vbNewLine)
        outResults.AppendText("****************************" & vbNewLine)
        outResults.AppendText(vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "Year", "Interest", "Balance"))
        outResults.AppendText("============================" & vbNewLine)

        While currentBalance <= targetBalance
            interest = currentBalance * nominalInterestRate
            currentBalance = currentBalance + interest

            period = period + 1

            outResults.AppendText(String.Format(fmtStr, period, FormatCurrency(interest), FormatCurrency(currentBalance)))
        End While

        outResults.AppendText("============================" & vbNewLine)
        outResults.AppendText(String.Format(fmtStr, "", FormatCurrency(currentBalance - startingBalance), FormatCurrency(currentBalance)))
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

End Class
