Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmPlotGPAs
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

    Private Sub btnPlotGPAs_Click(sender As Object, e As EventArgs) Handles btnPlotGPAs.Click
        ' add data
        Dim depts(5) As String
        Dim gpas(5) As Single
        depts(0) = "MATH"
        depts(1) = "BIOL"
        depts(2) = "CSCI"
        depts(3) = "COMM"
        depts(4) = "NURS"
        depts(5) = "MUSC"
        gpas(0) = 2.819
        gpas(1) = 2.996
        gpas(2) = 3.235
        gpas(3) = 3.33
        gpas(4) = 3.789
        gpas(5) = 3.739

        plot(depts, gpas, picBoxChart)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
