Option Explicit On

Public Class frmFlippingACoin

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim randomNumber As Single
        Dim loopCounter As Integer = 0

        While loopCounter < 100
            randomNumber = Rnd()

            outResults.AppendText(randomNumber & " ")

            If randomNumber < 0.5 Then
                outResults.AppendText("Heads")
            Else
                outResults.AppendText("Tails")
            End If

            outResults.AppendText(vbNewLine)

            loopCounter = loopCounter + 1
        End While
    End Sub

End Class
