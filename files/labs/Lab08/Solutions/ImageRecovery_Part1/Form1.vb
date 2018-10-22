Public Class frmImageRecovery

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b As Byte

        FileOpen(1, "card.raw", OpenMode.Binary)
        FileGet(1, b)
        outResults.Text = "Byte #1 is " & String.Format("{0:000}", b)

        FileClose(1)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
