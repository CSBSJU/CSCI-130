Public Class frmRatingPredictions
    Dim totalViewers As Integer
    Dim viewerRatings1(99) As Single, viewerRatings2(99) As Single, viewerRatings3(99) As Single, viewerRatings4(99) As Single, viewerRatings5(99) As Single, distances(99) As Single

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        FileOpen(1, "ML-ratings-medium.csv", OpenMode.Input)

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

        outResults.Text = "Viewer ID   Distance" & vbNewLine
        outResults.AppendText("--------------------" & vbNewLine)
        For i As Integer = 0 To totalViewers - 1
            outResults.AppendText(String.Format(fmtStr, (i + 1), distances(i)))
        Next
        outResults.AppendText("--------------------")
    End Sub

    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click
        Dim numberOfNeighbors As Integer
        Dim originalUserID(22418) As Integer
        Dim sum As Single = 0.0
        Dim fmtStr As String = "{0,9}   {1,10:0.0}   {2,8:0.0}" & vbNewLine

        For i As Integer = 0 To totalViewers - 1
            originalUserID(i) = i
        Next

        ' NOTE: Array.Sort is an unstable sort.
        Array.Sort(distances, originalUserID)

        numberOfNeighbors = InputBox("Enter a number of neighbors:")

        outResults.Text = "Viewer ID   Movie five   Distance" & vbNewLine
        outResults.AppendText("---------------------------------" & vbNewLine)
        For i As Integer = 0 To numberOfNeighbors - 1
            outResults.AppendText(String.Format(fmtStr, originalUserID(i) + 1, viewerRatings5(originalUserID(i)), distances(i)))
        Next
        outResults.AppendText("---------------------------------" & vbNewLine)

        For i As Integer = 0 To numberOfNeighbors - 1
            sum = sum + viewerRatings5(originalUserID(i))
        Next
        outResults.AppendText("The predicted rating for movie five is " & FormatNumber(sum / numberOfNeighbors, 1) & ".")
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
