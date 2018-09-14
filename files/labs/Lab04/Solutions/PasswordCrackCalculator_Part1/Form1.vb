Option Explicit On

Public Class frmPasswordCrackCalculator

    Public Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim passwd As String
        Dim alphabetSize As Integer

        alphabetSize = 0
        passwd = txtPassword.Text

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

        txtAlphabetSize.Text = alphabetSize
    End Sub

End Class
