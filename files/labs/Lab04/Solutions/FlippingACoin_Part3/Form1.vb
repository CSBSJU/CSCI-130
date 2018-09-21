Option Explicit On

Public Class frmFlippingACoin

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim randomNumber As Single

        randomNumber = Rnd()

        If randomNumber < 0.75 Then
            outResults.Text = "Heads"
        Else
            outResults.Text = "Tails"
        End If
    End Sub

End Class
