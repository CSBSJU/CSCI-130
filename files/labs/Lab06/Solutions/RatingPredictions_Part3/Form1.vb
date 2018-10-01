﻿Public Class frmRatingPredictions
    Dim totalViewers As Integer
    Dim viewerRatings1(2) As Single, viewerRatings2(2) As Single, viewerRatings3(2) As Single, viewerRatings4(2) As Single, viewerRatings5(2) As Single, distances(2) As Single

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        FileOpen(1, "ML-ratings-small.csv", OpenMode.Input)

        totalViewers = 0
        Do While Not EOF(1)
            Input(1, viewerRatings1(totalViewers))
            Input(1, viewerRatings2(totalViewers))
            Input(1, viewerRatings3(totalViewers))
            Input(1, viewerRatings4(totalViewers))
            Input(1, viewerRatings5(totalViewers))

            totalViewers = totalViewers + 1
        Loop

        FileClose(1)

        outResults.Clear()
        outResults.AppendText(totalViewers & " users' ratings were read from the file.")
    End Sub

    Private Sub btnComputeDistances_Click(sender As Object, e As EventArgs) Handles btnComputeDistances.Click
        Dim userRating1 As Single, userRating2 As Single, userRating3 As Single, userRating4 As Single
        Dim fmtStr As String = "{0,9}   {1,8:0.0}" & vbNewLine

        userRating1 = InputBox("Enter a rating for movie one:")
        userRating2 = InputBox("Enter a rating for movie two:")
        userRating3 = InputBox("Enter a rating for movie three:")
        userRating4 = InputBox("Enter a rating for movie four:")

        For i As Integer = 0 To totalViewers - 1
            distances(i) = Math.Abs(userRating1 - viewerRatings1(i)) + Math.Abs(userRating2 - viewerRatings2(i)) + Math.Abs(userRating3 - viewerRatings3(i)) + Math.Abs(userRating4 - viewerRatings4(i))
        Next

        outResults.Clear()
        For i As Integer = 0 To totalViewers - 1
            outResults.AppendText("The distance between the user and viewer #" & (i + 1) & " is " & FormatNumber(distances(i), 1) & "." & vbNewLine)
        Next
    End Sub

    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class