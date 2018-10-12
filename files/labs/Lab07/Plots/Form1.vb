Public Class frmPlotGPAs

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
