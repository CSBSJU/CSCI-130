Public Class frmImageRecovery

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b(511) As Byte, blockNumber As Integer

        FileOpen(1, "card.raw", OpenMode.Binary)

        blockNumber = 0
        Do While Not EOF(1)
            FileGet(1, b)
            outResults.AppendText("Block #" & String.Format("{0:00000}", blockNumber + 1) & " has " & _
                String.Format("{0:000} {1:000} {2:000} {3:000}", b(0), b(1), b(2), b(3)) & vbNewLine)

            blockNumber = blockNumber + 1
        Loop
        outResults.AppendText("-----" & vbNewLine)
        outResults.AppendText("Total blocks in file: " & blockNumber)

        FileClose(1)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
