Option Explicit On

#Const D = 0 ' Echo the values from the file to outResults
#Const C1 = 1.1 ' Output distances to outResults
#Const C2 = 1.2 ' Make a prediction using the minimum distance sample
#Const B1 = 2.1 ' Add sampleID array, sort parallel arrays, and make a prediction using the minimum distance sample
#Const B2 = 2.2 ' Output a table with the /k/ minimum distance samples
#Const A = 3 ' Make prediction using the /k/ minimum distance samples
#Const LEVEL = A

Public Class frmPrediction
#If LEVEL = D Then
    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String
        Dim fmtStr As String = "Sample #{0:000} => {1:0.0}, {2:0.0}, {3:0.0}, {4:0.0} : {5,-10}" & vbNewLine

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        outResults.Clear()
        Do While Not EOF(1)
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            outResults.AppendText(String.Format(fmtStr, totalRows, sepalLength(totalRows), sepalWidth(totalRows), petalLength(totalRows), petalWidth(totalRows), label(totalRows)))

            totalRows = totalRows + 1
        Loop

        FileClose(1)
    End Sub
#ElseIf LEVEL = C1 Then
        Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0, distance As Single
        Dim userSepalLength As Single, userSepalWidth As Single, userPetalLength As Single, userPetalWidth As Single
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String
        Dim fmtStr As String = "Sample #{0:000} => {1:0.0}, {2:0.0}, {3:0.0}, {4:0.0} : {5,-10} <= {6,4:0.0}" & vbNewLine

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        userSepalLength = InputBox("Enter a sepal length:")
        userSepalWidth = InputBox("Enter a sepal width:")
        userPetalLength = InputBox("Enter a petal length:")
        userPetalWidth = InputBox("Enter a petal width:")

        outResults.Clear()
        For i As Integer = 0 To totalRows - 1
            distance = Math.Abs(userSepalLength - sepalLength(i))
            distance += Math.Abs(userSepalWidth - sepalWidth(i))
            distance += Math.Abs(userPetalLength - petalLength(i))
            distance += Math.Abs(userPetalWidth - petalWidth(i))

            outResults.AppendText(String.Format(fmtStr, i, sepalLength(i), sepalWidth(i), petalLength(i), petalWidth(i), label(i), distance))
        Next
    End Sub
#ElseIf LEVEL = C2 Then
        Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0, distance(119) As Single
        Dim minDistance As Single = Single.MaxValue, minIndex As Integer
        Dim userSepalLength As Single, userSepalWidth As Single, userPetalLength As Single, userPetalWidth As Single
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        userSepalLength = InputBox("Enter a sepal length:")
        userSepalWidth = InputBox("Enter a sepal width:")
        userPetalLength = InputBox("Enter a petal length:")
        userPetalWidth = InputBox("Enter a petal width:")

        ' Compute distances
        For i As Integer = 0 To totalRows - 1
            distance(i) = Math.Abs(userSepalLength - sepalLength(i))
            distance(i) += Math.Abs(userSepalWidth - sepalWidth(i))
            distance(i) += Math.Abs(userPetalLength - petalLength(i))
            distance(i) += Math.Abs(userPetalWidth - petalWidth(i))
        Next

        ' Find minimum distances
        For i As Integer = 0 To totalRows - 1
            If distance(i) < minDistance Then
                minDistance = distance(i)
                minIndex = i
            End If
        Next

        outResults.Clear()
        outResults.AppendText("The minimum distance was sample #" & minIndex & " and the distance was " & String.Format("{0:0.0}", minDistance) & "." & vbNewLine)
        outResults.AppendText("The predicted class for the user sample is '" & label(minIndex) & "'.")
    End Sub
#ElseIf LEVEL = B1 Then
        Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0, distance(119) As Single
        Dim userSepalLength As Single, userSepalWidth As Single, userPetalLength As Single, userPetalWidth As Single
        Dim sampleID(119) As Integer
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        Do While Not EOF(1)
            sampleID(totalRows) = totalRows
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        userSepalLength = InputBox("Enter a sepal length:")
        userSepalWidth = InputBox("Enter a sepal width:")
        userPetalLength = InputBox("Enter a petal length:")
        userPetalWidth = InputBox("Enter a petal width:")

        ' Compute distances
        For i As Integer = 0 To totalRows - 1
            distance(i) = Math.Abs(userSepalLength - sepalLength(i))
            distance(i) += Math.Abs(userSepalWidth - sepalWidth(i))
            distance(i) += Math.Abs(userPetalLength - petalLength(i))
            distance(i) += Math.Abs(userPetalWidth - petalWidth(i))
        Next

        ' Sort the arrays
        Array.Sort(distance, sampleID)

        outResults.Clear()
        outResults.AppendText("The minimum distance was sample #" & sampleID(0) & " and the distance was " & String.Format("{0:0.0}", distance(0)) & "." & vbNewLine)
        outResults.AppendText("The predicted class for the user sample is '" & label(sampleID(0)) & "'.")
    End Sub
#ElseIf LEVEL = B2 Then
        Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0, distance(119) As Single, numberOfNeighbors As Integer
        Dim userSepalLength As Single, userSepalWidth As Single, userPetalLength As Single, userPetalWidth As Single
        Dim sampleID(119) As Integer
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String
        Dim fmtStr As String = "{0,8}   {1,10}   {2,8:0.0}" & vbNewLine

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        Do While Not EOF(1)
            sampleID(totalRows) = totalRows
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        userSepalLength = InputBox("Enter a sepal length:")
        userSepalWidth = InputBox("Enter a sepal width:")
        userPetalLength = InputBox("Enter a petal length:")
        userPetalWidth = InputBox("Enter a petal width:")

        ' Compute distances
        For i As Integer = 0 To totalRows - 1
            distance(i) = Math.Abs(userSepalLength - sepalLength(i))
            distance(i) += Math.Abs(userSepalWidth - sepalWidth(i))
            distance(i) += Math.Abs(userPetalLength - petalLength(i))
            distance(i) += Math.Abs(userPetalWidth - petalWidth(i))
        Next

        ' Sort the arrays
        Array.Sort(distance, sampleID)

        numberOfNeighbors = InputBox("Enter a number of neighbors:")

        outResults.Clear()
        outResults.AppendText("Sample #        Class   Distance" & vbNewLine)
        outResults.AppendText("--------   ----------   --------" & vbNewLine)
        For i As Integer = 0 To numberOfNeighbors - 1
            outResults.AppendText(String.Format(fmtStr, sampleID(i), label(sampleID(i)), distance(i)))
        Next
    End Sub
#ElseIf LEVEL = A Then
        Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim totalRows As Integer = 0, distance(119) As Single, numberOfNeighbors As Integer
        Dim classes(2) As String, numberInClass As Integer, maxNumberInClass As Integer = 0, maxClass As String
        Dim userSepalLength As Single, userSepalWidth As Single, userPetalLength As Single, userPetalWidth As Single
        Dim sampleID(119) As Integer
        Dim sepalLength(119) As Single, sepalWidth(119) As Single, petalLength(119) As Single, petalWidth(119) As Single, label(119) As String
        Dim fmtStr As String = "{0,8}   {1,10}   {2,8:0.0}" & vbNewLine

        FileOpen(1, "FisherIrisDataset.csv", OpenMode.Input)

        Do While Not EOF(1)
            sampleID(totalRows) = totalRows
            Input(1, sepalLength(totalRows))
            Input(1, sepalWidth(totalRows))
            Input(1, petalLength(totalRows))
            Input(1, petalWidth(totalRows))
            Input(1, label(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        userSepalLength = InputBox("Enter a sepal length:")
        userSepalWidth = InputBox("Enter a sepal width:")
        userPetalLength = InputBox("Enter a petal length:")
        userPetalWidth = InputBox("Enter a petal width:")

        ' Compute distances
        For i As Integer = 0 To totalRows - 1
            distance(i) = Math.Abs(userSepalLength - sepalLength(i))
            distance(i) += Math.Abs(userSepalWidth - sepalWidth(i))
            distance(i) += Math.Abs(userPetalLength - petalLength(i))
            distance(i) += Math.Abs(userPetalWidth - petalWidth(i))
        Next

        ' Sort the arrays
        Array.Sort(distance, sampleID)

        numberOfNeighbors = InputBox("Enter a number of neighbors:")

        outResults.Clear()
        outResults.AppendText("Sample #        Class   Distance" & vbNewLine)
        outResults.AppendText("--------   ----------   --------" & vbNewLine)
        For i As Integer = 0 To numberOfNeighbors - 1
            outResults.AppendText(String.Format(fmtStr, sampleID(i), label(sampleID(i)), distance(i)))
        Next
        outResults.AppendText("--------------------------------" & vbNewLine)

        classes(0) = "setosa"
        classes(1) = "versicolor"
        classes(2) = "virginica"

        ' Find the class that has the greatest number of samples in the top /k/
        For i As Integer = 0 To classes.Length - 1
            numberInClass = 0

            For j As Integer = 0 To numberOfNeighbors - 1
                If label(sampleID(j)) = classes(i) Then
                    numberInClass = numberInClass + 1
                End If
            Next

            If numberInClass > maxNumberInClass Then
                maxNumberInClass = numberInClass
                maxClass = classes(i)
            End If
        Next

        outResults.AppendText("The predicted class for the user sample is '" & maxClass & "' with " & maxNumberInClass & " samples in the top " & numberOfNeighbors & ".")
    End Sub
#End If

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
