﻿Public Class frmImageRecovery

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b(511) As Byte, jpegNumber As Integer, fileName As String

        FileOpen(1, "card.raw", OpenMode.Binary, OpenAccess.Read)
        Seek(1, 319489)

        jpegNumber = 0
        Do While Not EOF(1)
            FileGet(1, b)

            If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                fileName = String.Format("{0:00}.jpeg", jpegNumber + 1)
                outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)

                FileOpen(jpegNumber + 2, fileName, OpenMode.Binary, OpenAccess.Write)

                jpegNumber = jpegNumber + 1
            End If

            FilePut(jpegNumber + 1, b)
        Loop
        outResults.AppendText("-----" & vbNewLine)
        outResults.AppendText(jpegNumber & " JPEGs were recovered.")

        FileClose()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
