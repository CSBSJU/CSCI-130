Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmAnalytics
    Private Sub plot(xAxis As Array, yAxis As Array, picBoxChart As System.Windows.Forms.PictureBox)
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.Sheets("sheet1")
        Dim chartPage As Excel.Chart = xlWorkSheet.ChartObjects.Add(10, 80, 342, 250).Chart
        Dim column As Char = Chr(Asc("A") + xAxis.Length - 1)
        Dim tmpFile As String = System.IO.Path.GetTempPath & "plot.bmp"

        ' add data
        xlWorkSheet.Range("A1:" & column & "1").Value = xAxis
        xlWorkSheet.Range("A2:" & column & "2").Value = yAxis

        ' create chart
        chartPage.SetSourceData(Source:=xlWorkSheet.Range("A1", "" & column & "2"))
        chartPage.ChartType = Excel.XlChartType.xlColumnClustered
        chartPage.Legend.Clear()

        ' exporting chart as picture file
        If Not picBoxChart.Image Is Nothing Then
            picBoxChart.Image.Dispose()
        End If
        chartPage.Export(Filename:=tmpFile, FilterName:="BMP")

        ' load the pipcture into the picture box
        picBoxChart.Image = New System.Drawing.Bitmap(tmpFile)

        ' cleanup
        xlWorkBook.Close(False)
        xlApp.Quit()
    End Sub

    Private Sub btnPlotByGender_Click(sender As Object, e As EventArgs) Handles btnPlotByGender.Click
        Dim totalRows As Integer = 0
        Dim numberOfMales As Integer = 0, numberOfMaleSurvivors As Integer = 0
        Dim numberOfFemales As Integer = 0, numberOfFemaleSurvivors As Integer = 0
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

        For row As Integer = 0 To totalRows - 1
            If gender(row) = "male" Then
                numberOfMales = numberOfMales + 1
                If survivalStatus(row) = True Then
                    numberOfMaleSurvivors = numberOfMaleSurvivors + 1
                End If
            ElseIf gender(row) = "female" Then
                numberOfFemales = numberOfFemales + 1
                If survivalStatus(row) = True Then
                    numberOfFemaleSurvivors = numberOfFemaleSurvivors + 1
                End If
            End If
        Next

        ' add data
        Dim xAxis(1) As String
        Dim yAxis(1) As Single
        xAxis(0) = "male"
        xAxis(1) = "female"
        yAxis(0) = numberOfMaleSurvivors / numberOfMales * 100
        yAxis(1) = numberOfFemaleSurvivors / numberOfFemales * 100

        plot(xAxis, yAxis, picBoxChart)
    End Sub

    Private Sub btnPlotByClass_Click(sender As Object, e As EventArgs) Handles btnPlotByClass.Click
        Dim totalRows As Integer = 0
        Dim numberOfTicketClass1 As Integer = 0, numberOfTicketClass1Survivors As Integer = 0
        Dim numberOfTicketClass2 As Integer = 0, numberOfTicketClass2Survivors As Integer = 0
        Dim numberOfTicketClass3 As Integer = 0, numberOfTicketClass3Survivors As Integer = 0
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

        For row As Integer = 0 To totalRows - 1
            If ticketClass(row) = 1 Then
                numberOfTicketClass1 = numberOfTicketClass1 + 1
                If survivalStatus(row) = True Then
                    numberOfTicketClass1Survivors = numberOfTicketClass1Survivors + 1
                End If
            ElseIf ticketClass(row) = 2 Then
                numberOfTicketClass2 = numberOfTicketClass2 + 1
                If survivalStatus(row) = True Then
                    numberOfTicketClass2Survivors = numberOfTicketClass2Survivors + 1
                End If
            ElseIf ticketClass(row) = 3 Then
                numberOfTicketClass3 = numberOfTicketClass3 + 1
                If survivalStatus(row) = True Then
                    numberOfTicketClass3Survivors = numberOfTicketClass3Survivors + 1
                End If
            End If
        Next

        ' add data
        Dim xAxis(2) As String
        Dim yAxis(2) As Single
        xAxis(0) = "Class 1"
        xAxis(1) = "Class 2"
        xAxis(2) = "Class 3"
        yAxis(0) = numberOfTicketClass1Survivors / numberOfTicketClass1 * 100
        yAxis(1) = numberOfTicketClass2Survivors / numberOfTicketClass2 * 100
        yAxis(2) = numberOfTicketClass3Survivors / numberOfTicketClass3 * 100

        plot(xAxis, yAxis, picBoxChart)
    End Sub

    Private Sub btnPlotByBoth_Click(sender As Object, e As EventArgs) Handles btnPlotByBoth.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
