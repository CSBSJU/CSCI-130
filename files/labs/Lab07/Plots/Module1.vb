Imports Excel = Microsoft.Office.Interop.Excel

Module Module1
    Public Sub plot(xAxis As Array, yAxis As Array, picBoxChart As System.Windows.Forms.PictureBox)
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
End Module
