Option Explicit On

Imports System.Numerics

#Const D = 0
#Const C = 1
#Const B = 2
#Const A = 3
#Const LEVEL = A

Public Class frmCracking
#If LEVEL = D Then
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd As String
        Dim passwdLength As Integer

        passwd = txtPassword.Text
        passwdLength = passwd.Length

        MessageBox.Show("The password that you entered has a length of " & passwdLength & ".")
    End Sub
#ElseIf LEVEL = C Then
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd As String
        Dim alphabetSize, passwdLength, gps, searchSpace As Integer
        Dim searchTime As Single

        alphabetSize = 0
        passwd = txtPassword.Text
        gps = txtGuessesPerSec.Text
        passwdLength = passwd.Length

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
        txtSearchTime.Text = searchSpace / gps & " seconds"
    End Sub
#ElseIf LEVEL = B Then
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd, unit As String
        Dim alphabetSize, passwdLength, gps As Integer
        Dim searchSpace As Long
        Dim searchTime As Single

        alphabetSize = 0
        passwd = txtPassword.Text
        gps = txtGuessesPerSec.Text
        passwdLength = passwd.Length

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

        txtSearchTime.Text = Math.Round(searchTime, 3) & " " & unit
    End Sub
#ElseIf LEVEL = A Then
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd, unit As String
        Dim alphabetSize, passwdLength, gps As Integer
        Dim searchSpace As BigInteger
        Dim searchTime As Single

        alphabetSize = 0
        passwd = txtPassword.Text
        gps = txtGuessesPerSec.Text
        passwdLength = passwd.Length

        If passwd Like "*[!a-zA-Z0-9^$/%@#]*" Then
            MessageBox.Show("The password that you entered contains an invalid character")
            Close()
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
        txtSearchSpace.Text = searchSpace.ToString

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

        txtSearchTime.Text = Math.Round(searchTime, 3) & " " & unit
    End Sub
#End If
End Class