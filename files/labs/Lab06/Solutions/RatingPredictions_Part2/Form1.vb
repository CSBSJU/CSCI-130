Public Class frmRatingPredictions

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click

    End Sub

    Private Sub btnComputeDistances_Click(sender As Object, e As EventArgs) Handles btnComputeDistances.Click
        Dim userRating1 As Single, userRating2 As Single, userRating3 As Single, userRating4 As Single
        Dim viewerRatings1(2) As Single, viewerRatings2(2) As Single, viewerRatings3(2) As Single, viewerRatings4(2) As Single, viewerRatings5(2) As Single, distances(2) As Single

        viewerRatings1(0) = 4.0
        viewerRatings2(0) = 4.5
        viewerRatings3(0) = 4.0
        viewerRatings4(0) = 4.0
        viewerRatings5(0) = 3.0

        viewerRatings1(1) = 3.0
        viewerRatings2(1) = 4.0
        viewerRatings3(1) = 5.0
        viewerRatings4(1) = 4.0
        viewerRatings5(1) = 5.0

        viewerRatings1(2) = 5.0
        viewerRatings2(2) = 5.0
        viewerRatings3(2) = 5.0
        viewerRatings4(2) = 5.0
        viewerRatings5(2) = 5.0

        userRating1 = InputBox("Enter a rating for movie one:")
        userRating2 = InputBox("Enter a rating for movie two:")
        userRating3 = InputBox("Enter a rating for movie three:")
        userRating4 = InputBox("Enter a rating for movie four:")

        For i As Integer = 0 To viewerRatings1.Length - 1
            distances(i) = Math.Abs(userRating1 - viewerRatings1(i)) + Math.Abs(userRating2 - viewerRatings2(i)) + Math.Abs(userRating3 - viewerRatings3(i)) + Math.Abs(userRating4 - viewerRatings4(i))
        Next

        outResults.Clear()
        For i As Integer = 0 To viewerRatings1.Length - 1
            outResults.AppendText("The distance between the user and viewer #" & (i + 1) & " is " & FormatNumber(distances(i), 1) & "." & vbNewLine)
        Next
    End Sub

    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
