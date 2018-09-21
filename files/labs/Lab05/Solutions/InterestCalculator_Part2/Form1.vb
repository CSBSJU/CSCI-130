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

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

End Class
