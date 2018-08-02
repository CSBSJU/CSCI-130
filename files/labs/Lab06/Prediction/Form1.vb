Option Explicit On

#Const D1 = 0.1 ' Echo the values from the file to outResults
#Const D2 = 0.2 ' Compute average rating for each of the movies and output to outResults
#Const C1 = 1.1 ' Output distances to outResults
#Const B1 = 2.1 ' Make a prediction using the minimum distance sample
#Const A1 = 3.1 ' Add sampleID array, sort parallel arrays, and make a prediction using the minimum distance sample
#Const A2 = 3.2 ' Output a table with the /k/ minimum distance samples
#Const A3 = 3.3 ' Make prediction using the /k/ minimum distance samples
#Const LEVEL = A3


Public Class frmPrediction
    Dim totalUsers As Integer = 0
    Dim movie1(22418) As Single, movie2(22418) As Single, movie3(22418) As Single, movie4(22418) As Single, movie5(22418) As Single
    Dim distance(22418) As Single

#If LEVEL >= D1 Then
    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        FileOpen(1, "ML-ratings.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, movie1(totalUsers))
            Input(1, movie2(totalUsers))
            Input(1, movie3(totalUsers))
            Input(1, movie4(totalUsers))
            Input(1, movie5(totalUsers))

            totalUsers = totalUsers + 1
        Loop

        FileClose(1)

        outResults.Clear()
        outResults.AppendText(totalUsers & " users' ratings were read from the file.")
    End Sub
#End If

#If LEVEL = D1 Then
    Private Sub btnComputeDistances_Click(sender As Object, e As EventArgs) Handles btnComputeDistances.Click
        Dim fmtStr As String = "{0,7}   {1,7:0.0}   {2,7:0.0}   {3,7:0.0}   {4,7:0.0}   " & _
            "{5,7:0.0}" & vbNewLine

        outResults.Clear()
        outResults.AppendText("User ID   Movie 1   Movie 2   Movie 3   Movie 4   Movie 5" & vbNewLine)
        outResults.AppendText("-------   -------   -------   -------   -------   -------" & vbNewLine)
        For i As Integer = 0 To totalUsers - 1
            outResults.AppendText(String.Format(fmtStr, i, movie1(i), movie2(i), movie3(i), movie4(i), movie5(i)))
        Next
        outResults.AppendText("---------------------------------------------------------" & vbNewLine)
    End Sub
#ElseIf LEVEL = D2 Then
    Private Sub btnComputeDistances_Click(sender As Object, e As EventArgs) Handles btnComputeDistances.Click
        Dim sum1 As Single = 0.0, sum2 As Single = 0.0, sum3 As Single = 0.0, sum4 As Single = 0.0, sum5 As Single = 0.0
        Dim fmtStr As String = "{0,7:0.0}   {1,7:0.0}   {2,7:0.0}   {3,7:0.0}   " & _
            "{4,7:0.0}" & vbNewLine

        For i As Integer = 0 To totalUsers - 1
            sum1 = sum1 + movie1(i)
            sum2 = sum2 + movie2(i)
            sum3 = sum3 + movie3(i)
            sum4 = sum4 + movie4(i)
            sum5 = sum5 + movie5(i)
        Next

        outResults.Clear()
        outResults.AppendText("Movie 1   Movie 2   Movie 3   Movie 4   Movie 5" & vbNewLine)
        outResults.AppendText("-------   -------   -------   -------   -------" & vbNewLine)
        outResults.AppendText(String.Format(fmtStr, sum1 / totalUsers, sum2 / totalUsers, sum3 / totalUsers, sum4 / totalUsers, sum5 / totalUsers))
        outResults.AppendText("-----------------------------------------------" & vbNewLine)
    End Sub
#ElseIf LEVEL >= C1 Then
    Private Sub btnComputeDistances_Click(sender As Object, e As EventArgs) Handles btnComputeDistances.Click
        Dim userMovie1 As Single, userMovie2 As Single, userMovie3 As Single, userMovie4 As Single
        Dim fmtStr1 As String = "Distance results for user ratings ({0:0.0},{1:0.0},{2:0.0},{3:0.0})" & vbNewLine
        Dim fmtStr2 As String = "{0,7}   {1,7:0.0}   {2,7:0.0}   {3,7:0.0}   {4,7:0.0}   " & _
            "{5,8:0.0}" & vbNewLine

        userMovie1 = InputBox("Enter a rating for movie 1:")
        userMovie2 = InputBox("Enter a rating for movie 2:")
        userMovie3 = InputBox("Enter a rating for movie 3:")
        userMovie4 = InputBox("Enter a rating for movie 4:")

        outResults.Clear()
        outResults.AppendText(String.Format(fmtStr1, userMovie1, userMovie2, userMovie3, userMovie4))
        outResults.AppendText("----------------------------------------------------------" & vbNewLine)
        outResults.AppendText("User ID   Movie 1   Movie 2   Movie 3   Movie 4   Distance" & vbNewLine)
        outResults.AppendText("-------   -------   -------   -------   -------   --------" & vbNewLine)
        For i As Integer = 0 To totalUsers - 1
            distance(i) = Math.Abs(userMovie1 - movie1(i))
            distance(i) += Math.Abs(userMovie2 - movie2(i))
            distance(i) += Math.Abs(userMovie3 - movie3(i))
            distance(i) += Math.Abs(userMovie4 - movie4(i))

            outResults.AppendText(String.Format(fmtStr2, i, movie1(i), movie2(i), movie3(i), movie4(i), distance(i)))
        Next
        outResults.AppendText("----------------------------------------------------------" & vbNewLine)
    End Sub
#End If

#If LEVEL = B1 Then
    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click
        Dim minDistance As Single = Single.MaxValue, minIndex As Integer

        For i As Integer = 0 To totalUsers - 1
            If distance(i) < minDistance Then
                minDistance = distance(i)
                minIndex = i
            End If
        Next

        outResults.Clear()
        outResults.AppendText("The most similar user was user #" & minIndex & " and the distance calculated was " & String.Format("{0:0.0}", minDistance) & "." & vbNewLine)
        outResults.AppendText("The predicted rating for movie 5 for the user is '" & movie5(minIndex) & "'.")
    End Sub
#ElseIf LEVEL = A1 Then
    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click
        Dim originalUserID(22418) As Integer

        For i As Integer = 0 To totalUsers - 1
            originalUserID(i) = i
        Next

        ' NOTE: Array.Sort is an unstable sort.
        Array.Sort(distance, originalUserID)

        outResults.Clear()
        outResults.AppendText("The most similar user was user #" & originalUserID(0) & " and the distance calculated was " & String.Format("{0:0.0}", distance(0)) & "." & vbNewLine)
        outResults.AppendText("The predicted rating for movie 5 for the user is '" & movie5(originalUserID(0)) & "'.")
    End Sub
#ElseIf LEVEL = A2 Then
    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click
        Dim numberOfNeighbors As Integer
        Dim originalUserID(22418) As Integer
        Dim fmtStr As String = "{0,7}   {1,7:0.0}   {2,8:0.0}" & vbNewLine

        For i As Integer = 0 To totalUsers - 1
            originalUserID(i) = i
        Next

        ' NOTE: Array.Sort is an unstable sort.
        Array.Sort(distance, originalUserID)

        numberOfNeighbors = InputBox("Enter a number of neighbors:")

        outResults.Clear()
        outResults.AppendText("User ID   Movie 5   Distance" & vbNewLine)
        outResults.AppendText("-------   -------   --------" & vbNewLine)
        For i As Integer = 0 To numberOfNeighbors - 1
            outResults.AppendText(String.Format(fmtStr, originalUserID(i), movie5(originalUserID(i)), distance(i)))
        Next
        outResults.AppendText("----------------------------" & vbNewLine)
    End Sub
#ElseIf LEVEL = A3 Then
    Private Sub btnPredictRatings_Click(sender As Object, e As EventArgs) Handles btnPredictRatings.Click
        Dim numberOfNeighbors As Integer, sum As Single = 0.0
        Dim originalUserID(22418) As Integer
        Dim fmtStr As String = "{0,7}   {1,7:0.0}   {2,8:0.0}" & vbNewLine

        For i As Integer = 0 To totalUsers - 1
            originalUserID(i) = i
        Next

        ' NOTE: Array.Sort is an unstable sort.
        Array.Sort(distance, originalUserID)

        numberOfNeighbors = InputBox("Enter a number of neighbors:")

        outResults.Clear()
        outResults.AppendText("User ID   Movie 5   Distance" & vbNewLine)
        outResults.AppendText("-------   -------   --------" & vbNewLine)
        For i As Integer = 0 To numberOfNeighbors - 1
            outResults.AppendText(String.Format(fmtStr, originalUserID(i), movie5(originalUserID(i)), distance(i)))
        Next
        outResults.AppendText("----------------------------" & vbNewLine)

        For i As Integer = 0 To numberOfNeighbors - 1
            sum = sum + movie5(i)
        Next
        outResults.AppendText("The predicted rating for movie 5 for the user is '" & String.Format("{0:0.0}", sum / numberOfNeighbors) & "'.")
    End Sub
#End If

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
