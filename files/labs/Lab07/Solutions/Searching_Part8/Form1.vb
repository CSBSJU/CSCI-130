Public Class frmAnalytics
    Dim ticketClass(886) As Integer, gender(886) As String, fullName(886) As String, age(886) As Integer, farePaid(886) As String, survivalStatus(886) As Boolean
    Dim numberOfPassengers As Integer

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        FileOpen(1, "Titanic.csv", OpenMode.Input)

        numberOfPassengers = 0
        Do While Not EOF(1)
            Input(1, ticketClass(numberOfPassengers))
            Input(1, gender(numberOfPassengers))
            Input(1, fullName(numberOfPassengers))
            Input(1, age(numberOfPassengers))
            Input(1, farePaid(numberOfPassengers))
            Input(1, survivalStatus(numberOfPassengers))

            outResults.AppendText(ticketClass(numberOfPassengers) & " " & gender(numberOfPassengers) & " " & fullName(numberOfPassengers) & " " & _
                                  age(numberOfPassengers) & " " & farePaid(numberOfPassengers) & " " & survivalStatus(numberOfPassengers) & vbNewLine)

            numberOfPassengers = numberOfPassengers + 1
        Loop

        FileClose(1)

        outResults.AppendText("-----" & vbNewLine)
        outResults.AppendText("Total passengers in file: " & numberOfPassengers)
    End Sub

    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click
        Dim i As Integer, searchName As String, survivedString As String, found As Boolean, foundIndex As Integer

        searchName = InputBox("Enter the name of a passenger to search for:")
        searchName = searchName.ToLower().Trim()

        i = 0
        found = False
        Do While i < numberOfPassengers And Not found
            If fullName(i).ToLower().Contains(searchName) Then
                found = True
                foundIndex = i
            End If
            i = i + 1
        Loop

        If found Then
            If survivalStatus(foundIndex) Then
                survivedString = "SURVIVED"
            Else
                survivedString = "DIED"
            End If

            outResults.Text = fullName(foundIndex) & " " & ticketClass(foundIndex) & " " & age(foundIndex) & " " & farePaid(foundIndex) & " " & survivedString
        Else
            outResults.Text = searchName & " PRODUCED NO MATCHES"
        End If
    End Sub

    Private Sub btnPlotByGender_Click(sender As Object, e As EventArgs) Handles btnPlotByGender.Click
        Dim i As Integer, femaleSurvivedTotal As Integer, femaleTotal As Integer, maleSurvivedTotal As Integer, maleTotal As Integer

        femaleSurvivedTotal = 0
        femaleTotal = 0
        maleSurvivedTotal = 0
        maleTotal = 0
        For i = 0 To numberOfPassengers - 1
            If gender(i) = "female" Then
                If survivalStatus(i) Then
                    femaleSurvivedTotal = femaleSurvivedTotal + 1
                End If
                femaleTotal = femaleTotal + 1
            Else
                If survivalStatus(i) Then
                    maleSurvivedTotal = maleSurvivedTotal + 1
                End If
                maleTotal = maleTotal + 1
            End If
        Next

        ' add data
        Dim xAxis(1) As String
        Dim yAxis(1) As Single
        xAxis(0) = "female"
        xAxis(1) = "male"
        yAxis(0) = femaleSurvivedTotal / femaleTotal * 100
        yAxis(1) = maleSurvivedTotal / maleTotal * 100

        plot(xAxis, yAxis, picBoxChart)

        outResults.Text = "Percentage of female survivors was " & FormatPercent(femaleSurvivedTotal / femaleTotal) & vbNewLine & _
            "Percentage of male survivors was " & FormatPercent(maleSurvivedTotal / maleTotal)
    End Sub

    Private Sub btnPlotByClass_Click(sender As Object, e As EventArgs) Handles btnPlotByClass.Click
        Dim i As Integer, class1SurvivedTotal As Integer, class1Total As Integer, class2SurvivedTotal As Integer, class2Total As Integer, class3SurvivedTotal As Integer, class3Total As Integer

        class1SurvivedTotal = 0
        class1Total = 0
        class2SurvivedTotal = 0
        class2Total = 0
        class3SurvivedTotal = 0
        class3Total = 0
        For i = 0 To numberOfPassengers - 1
            If ticketClass(i) = 1 Then
                If survivalStatus(i) Then
                    class1SurvivedTotal = class1SurvivedTotal + 1
                End If
                class1Total = class1Total + 1
            ElseIf ticketClass(i) = 2 Then
                If survivalStatus(i) Then
                    class2SurvivedTotal = class2SurvivedTotal + 1
                End If
                class2Total = class2Total + 1
            Else
                If survivalStatus(i) Then
                    class3SurvivedTotal = class3SurvivedTotal + 1
                End If
                class3Total = class3Total + 1
            End If
        Next

        ' clear outResults box
        outResults.Clear()

        ' add data
        Dim xAxis(2) As String
        Dim yAxis(2) As Single
        xAxis(0) = "Class 1"
        xAxis(1) = "Class 2"
        xAxis(2) = "Class 3"
        yAxis(0) = class1SurvivedTotal / class1Total * 100
        yAxis(1) = class2SurvivedTotal / class2Total * 100
        yAxis(2) = class3SurvivedTotal / class3Total * 100

        plot(xAxis, yAxis, picBoxChart)
    End Sub

    Private Sub btnPlotByBoth_Click(sender As Object, e As EventArgs) Handles btnPlotByBoth.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
