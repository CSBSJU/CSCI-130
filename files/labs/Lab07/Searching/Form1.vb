Option Explicit On

#Const D = 0
#Const C = 1
#Const B = 2
#Const A = 3
#Const LEVEL = B

Public Class frmDataAnalytics
#If LEVEL = D Then
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim totalRows As Integer = 0
        Dim ticketClass(886) As Integer, gender(886) As String, name(886) As String, age(886) As Integer, farePaid(886) As String, survivalStatus(886) As Boolean
        Dim fmtStr = "{0} {1,-6} {2,-60} {3,3} {4,7} {5}" & vbNewLine

        FileOpen(1, "Titanic.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, ticketClass(totalRows))
            Input(1, gender(totalRows))
            Input(1, name(totalRows))
            Input(1, age(totalRows))
            Input(1, farePaid(totalRows))
            Input(1, survivalStatus(totalRows))

            outResults.AppendText(String.Format(fmtStr, ticketClass(totalRows), gender(totalRows), name(totalRows), age(totalRows), "£" & farePaid(totalRows), survivalStatus(totalRows)))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        outResults.AppendText("Total rows in the file: " & totalRows)
    End Sub
#ElseIf LEVEL = C Then
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim totalRows As Integer = 0, row As Integer = 0, found As Boolean = False, survivalString As String = "", searchName As String = ""
        Dim ticketClass(886) As Integer, gender(886) As String, name(886) As String, age(886) As Integer, farePaid(886) As String, survivalStatus(886) As Boolean
        Dim fmtStr = "{0} {1,3} {2,7} {3}" & vbNewLine

        FileOpen(1, "Titanic.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, ticketClass(totalRows))
            Input(1, gender(totalRows))
            Input(1, name(totalRows))
            Input(1, age(totalRows))
            Input(1, farePaid(totalRows))
            Input(1, survivalStatus(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        searchName = InputBox("Enter a full name to search for: ")

        Do While row < totalRows And Not found
            If name(row) = searchName Then
                found = True
            Else
                row = row + 1
            End If
        Loop

        If found Then
            If survivalStatus(row) = True Then
                survivalString = "SURVIVED"
            Else
                survivalString = "DIED"
            End If
            outResults.Text = String.Format(fmtStr, ticketClass(row), age(row), farePaid(row), survivalString)
        Else
            outResults.Text = searchName & " PRODUCED NO MATCHES"
        End If
    End Sub
#ElseIf LEVEL = B Then
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim totalRows As Integer = 0, numberOfTicketClass As Integer = 0, numberOfTicketClassSurvivors As Integer = 0
        Dim percentOfTicketClassSurvivors As Single, sumOfAgesOfTicketClass As Integer = 0, averageAgeTicketClass As Single
        Dim searchTicketClass As Integer
        Dim ticketClass(886) As Integer, gender(886) As String, name(886) As String, age(886) As Integer, farePaid(886) As String, survivalStatus(886) As Boolean

        FileOpen(1, "Titanic.csv", OpenMode.Input)

        Do While Not EOF(1)
            Input(1, ticketClass(totalRows))
            Input(1, gender(totalRows))
            Input(1, name(totalRows))
            Input(1, age(totalRows))
            Input(1, farePaid(totalRows))
            Input(1, survivalStatus(totalRows))

            totalRows = totalRows + 1
        Loop

        FileClose(1)

        searchTicketClass = InputBox("Enter a class value: ")

        For row As Integer = 0 To totalRows - 1
            If ticketClass(row) = searchTicketClass Then
                numberOfTicketClass = numberOfTicketClass + 1
                If survivalStatus(row) = True Then
                    sumOfAgesOfTicketClass = sumOfAgesOfTicketClass + age(row)
                    numberOfTicketClassSurvivors = numberOfTicketClassSurvivors + 1
                End If
            End If
        Next

        If numberOfTicketClass > 0 Then
            percentOfTicketClassSurvivors = numberOfTicketClassSurvivors / numberOfTicketClass * 100
            averageAgeTicketClass = sumOfAgesOfTicketClass / numberOfTicketClassSurvivors
            outResults.Text = FormatNumber(percentOfTicketClassSurvivors) & "% of class " & searchTicketClass & " passengers survived with an average age of " & FormatNumber(averageAgeTicketClass) & "."
        Else
            outResults.Text = "There were no passengers from class " & searchTicketClass & "."
        End If
    End Sub
#End If

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
