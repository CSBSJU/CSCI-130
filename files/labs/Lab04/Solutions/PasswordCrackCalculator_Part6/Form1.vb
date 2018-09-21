Option Explicit On

Public Class frmPasswordCrackCalculator

    Public Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd, unit As String
        Dim alphabetSize, passwdLength, gps As Integer
        Dim searchSpace As Long
        Dim searchTime As Double

        alphabetSize = 0
        passwd = txtPassword.Text
        gps = txtGuessesPerSec.Text
        passwdLength = passwd.Length

        If passwd Like "*[!a-zA-Z0-9^$/%@#]*" Then
            MessageBox.Show("The password " & passwd & " contains an invalid character", "Invalid password")
            Return
        End If

        If passwd Like "*[a-z]*" Then
            alphabetSize = alphabetSize + 26
        End If
        If passwd Like "*[A-Z]*" Then
            alphabetSize = alphabetSize + 26
        End If
        If passwd Like "*[0-9]*" Then
            alphabetSize = alphabetSize + 10
        End If
        If passwd Like "*[^$/%@#]*" Then
            alphabetSize = alphabetSize + 6
        End If

        searchSpace = alphabetSize * (alphabetSize ^ passwdLength - 1) / (alphabetSize - 1)
        searchTime = searchSpace / gps

        txtAlphabetSize.Text = alphabetSize
        txtSearchSpace.Text = searchSpace

        If searchTime < 60.0 Then
            unit = "seconds"
        ElseIf searchTime < 60 * 60.0 Then
            searchTime = searchTime / 60.0
            unit = "minutes"
        ElseIf searchTime < 60 * 60 * 24.0 Then
            searchTime = searchTime / (60 * 60)
            unit = "hours"
        ElseIf searchTime < 60 * 60 * 24 * 7.0 Then
            searchTime = searchTime / (60 * 60 * 24.0)
            unit = "days"
        ElseIf searchTime < 60 * 60 * 24 * 7 * 52.0 Then
            searchTime = searchTime / (60 * 60 * 24 * 7.0)
            unit = "weeks"
        ElseIf searchTime < 60 * 60 * 24 * 7 * 52 * 100.0 Then
            searchTime = searchTime / (60 * 60 * 24 * 7 * 52.0)
            unit = "years"
        Else
            searchTime = searchTime / (60 * 60 * 24 * 7 * 52 * 100.0)
            unit = "centuries"
        End If

        txtSearchTime.Text = FormatNumber(searchTime, 3) & " " & unit
    End Sub

End Class
