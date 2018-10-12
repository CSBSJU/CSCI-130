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

        i = 0
        found = False
        Do While i < numberOfPassengers And Not found
            If fullName(i) = searchName Then
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

    End Sub

    Private Sub btnPlotByClass_Click(sender As Object, e As EventArgs) Handles btnPlotByClass.Click

    End Sub

    Private Sub btnPlotByBoth_Click(sender As Object, e As EventArgs) Handles btnPlotByBoth.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
