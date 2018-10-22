Public Class frmImageRecovery

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b(511) As Byte, blockNumber As Integer, jpegNumber As Integer

        FileOpen(1, "card.raw", OpenMode.Binary, OpenAccess.Read)

        blockNumber = 0
        jpegNumber = 0
        Do While Not EOF(1)
            FileGet(1, b)

            If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                outResults.AppendText("JPEG #" & String.Format("{0:000}", jpegNumber + 1) & " starts @ Block # " & _
                    String.Format("{0:00000}", blockNumber + 1) & vbNewLine)

                jpegNumber = jpegNumber + 1
            End If

            blockNumber = blockNumber + 1
        Loop
        outResults.AppendText("-----" & vbNewLine)
        outResults.AppendText("Total JPEGs in file: " & jpegNumber)

        FileClose(1)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
