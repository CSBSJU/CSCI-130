Option Explicit On

#Const D1 = 0.1 ' read a byte and print it using format string
#Const D2 = 0.2 ' read a block of 512 bytes and print its four byte header
#Const D3 = 0.3 ' read all blocks and print the block number and the four byte header for each
#Const D4 = 0.4 ' read all blocks and print the jpeg number and the four byte header for only those blocks that demark JPEGs
#Const C1 = 1.1 ' create empty files, named correctly, for each of the JPEGs
#Const C2 = 1.2 ' use Seek to skip bytes before the JPEGs start, then output each JPEG to file
#Const B1 = 2.1 ' remove Seek and create logic to skip bytes before the JPEGs start
#Const A1 = 3.1 ' add OpenFileDialogue so that the disk image can be selected by user
#Const A2 = 3.2 ' improve logic to remove unspecified FileClose() and use exactly two (2) file channels, i.e., close previous JPEG file before
'                 opening the next one so the file channel can be reused
#Const LEVEL = A2

Public Class frmRecover
#If LEVEL = D1 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b As Byte
            Dim fmtStr As String = "{0:000}"

            FileOpen(1, "card.raw", OpenMode.Binary)
            FileGet(1, b)
            outResults.Text = "The byte read is " & String.Format(fmtStr, b)

            FileClose(1)
        End Sub
#ElseIf LEVEL = D2 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim fmtStr As String = "{0:000} {1:000} {2:000} {3:000}"

            FileOpen(1, "card.raw", OpenMode.Binary)

            FileGet(1, b)
            outResults.Text = "block #0 = " & String.Format(fmtStr, b(0), b(1), b(2), b(3))

            FileClose(1)
        End Sub
#ElseIf LEVEL = D3 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim blockNumber As Integer = 0
            Dim fmtStr As String = "block #{0,5} = {1:000} {2:000} {3:000} {4:000}" & vbNewLine

            FileOpen(1, "card.raw", OpenMode.Binary)

            Do While Not EOF(1)
                FileGet(1, b)
                outResults.AppendText(String.Format(fmtStr, blockNumber, b(0), b(1), b(2), b(3)))
                blockNumber = blockNumber + 1
            Loop

            FileClose(1)
        End Sub
#ElseIf LEVEL = D4 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim jpegNumber As Integer = 0
            Dim fmtStr As String = "jpeg #{0,5} = {1:000} {2:000} {3:000} {4:000}" & vbNewLine

            FileOpen(1, "card.raw", OpenMode.Binary)

            Do While Not EOF(1)
                FileGet(1, b)
                ' There is a problem with this condition (precedence of And over Or)
                '   If b(0) = 255 And b(1) = 216 And b(2) = 255 And b(3) = 224 Or b(3) = 225 Then
                If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                    outResults.AppendText(String.Format(fmtStr, jpegNumber, b(0), b(1), b(2), b(3)))
                    jpegNumber = jpegNumber + 1
                End If
            Loop

            FileClose(1)
        End Sub
#ElseIf LEVEL = C1 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim jpegNumber As Integer = 2
            Dim fmtStr As String = "{0:000}.jpeg", fileName As String

            FileOpen(1, "card.raw", OpenMode.Binary)

            Do While Not EOF(1)
                FileGet(1, b)

                If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                    fileName = String.Format(fmtStr, jpegNumber - 2)
                    outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)
                    FileOpen(jpegNumber, fileName, OpenMode.Binary)
                    jpegNumber = jpegNumber + 1
                End If
            Loop

            FileClose()
        End Sub
#ElseIf LEVEL = C2 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim jpegNumber As Integer = 1
            Dim fmtStr As String = "{0:000}.jpeg", fileName As String

            FileOpen(1, "card.raw", OpenMode.Binary)
            Seek(1, 2631681)

            Do While Not EOF(1)
                FileGet(1, b)

                If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                    fileName = String.Format(fmtStr, jpegNumber - 1)
                    outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)
                    jpegNumber = jpegNumber + 1
                    FileOpen(jpegNumber, fileName, OpenMode.Binary)
                End If

                FilePut(jpegNumber, b)
            Loop

            FileClose()
        End Sub
#ElseIf LEVEL = B1 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim jpegNumber As Integer = 1
            Dim fmtStr As String = "{0:000}.jpeg", fileName As String

            FileOpen(1, "card.raw", OpenMode.Binary)

            Do While Not EOF(1)
                FileGet(1, b)

                If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                    fileName = String.Format(fmtStr, jpegNumber - 1)
                    outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)
                    jpegNumber = jpegNumber + 1
                    FileOpen(jpegNumber, fileName, OpenMode.Binary)
                End If

                If jpegNumber > 1 Then
                    FilePut(jpegNumber, b)
                End If
            Loop

            FileClose()
        End Sub
#ElseIf LEVEL = A1 Then
        Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
            Dim b(511) As Byte
            Dim jpegNumber As Integer = 1
            Dim fmtStr As String = "{0:000}.jpeg", fileName As String
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog

            openFileDialog.ShowDialog()

            FileOpen(1, openFileDialog.FileName, OpenMode.Binary)

            Do While Not EOF(1)
                FileGet(1, b)

                If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                    fileName = String.Format(fmtStr, jpegNumber - 1)
                    outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)
                    jpegNumber = jpegNumber + 1
                    FileOpen(jpegNumber, fileName, OpenMode.Binary)
                End If

                If jpegNumber > 1 Then
                    FilePut(jpegNumber, b)
                End If
            Loop

            FileClose()
        End Sub
#ElseIf LEVEL = A2 Then
    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim b(511) As Byte
        Dim jpegNumber As Integer = 1
        Dim fmtStr As String = "{0:000}.jpeg", fileName As String
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog

        openFileDialog.ShowDialog()

        FileOpen(1, openFileDialog.FileName, OpenMode.Binary)

        Do While Not EOF(1)
            FileGet(1, b)

            If b(0) = 255 And b(1) = 216 And b(2) = 255 And (b(3) = 224 Or b(3) = 225) Then
                fileName = String.Format(fmtStr, jpegNumber - 1)
                outResults.AppendText("Recovering " & fileName & "..." & vbNewLine)
                jpegNumber = jpegNumber + 1

                FileClose(2)
                FileOpen(2, fileName, OpenMode.Binary)
            End If

            If jpegNumber > 1 Then
                FilePut(2, b)
            End If
        Loop

        FileClose(2)
        FileClose(1)
    End Sub
#End If

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
