Option Explicit On

Public Class frmPasswordCrackCalculator

    Public Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd As String
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
        txtSearchTime.Text = FormatNumber(searchTime, 3) & " seconds"
    End Sub

End Class
