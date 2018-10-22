Public Class frmImageRecovery

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b(511) As Byte

        FileOpen(1, "card.raw", OpenMode.Binary)
        FileGet(1, b)
        outResults.Text = "Block #1 has " & String.Format("{0:000} {1:000} {2:000} {3:000}", b(0), b(1), b(2), b(3))

        FileClose(1)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
