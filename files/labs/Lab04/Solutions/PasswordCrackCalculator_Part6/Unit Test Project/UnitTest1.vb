Imports PasswordCrackCalculator
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim form As frmPasswordCrackCalculator

    <TestInitialize()> Public Sub TestSetup()
        form = New frmPasswordCrackCalculator()
    End Sub

    ' Test of Part 1. Make sure that the alphabet size is being computed correctly.
    <TestMethod()> Public Sub Test1()
        Dim inputs As String() = {"aaaa", "AAAA", "1111", "$$$$", "aA1$"}
        Dim outputs As String() = {"26", "26", "10", "6", "68"}

        For i As Integer = 0 To inputs.Length - 1
            ' Populate input
            form.txtPassword.Text = inputs(i)

            ' Simulate button click
            form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

            ' Validate result
            Assert.AreEqual(outputs(i), form.txtAlphabetSize.Text, "Password: " + inputs(i))
        Next
    End Sub

    ' Test of Part 2. Make sure that the search space is being computed correctly for the test cases provided in the writeup.
    <TestMethod()> Public Sub Test2()
        Dim inputs As String() = {"aaaa", "AAAA", "1111", "$$$$", "aA1$"}
        Dim outputs As String() = {"475254", "475254", "11110", "1554", "21700500"}

        For i As Integer = 0 To inputs.Length - 1
            ' Populate input
            form.txtPassword.Text = inputs(i)

            ' Simulate button click
            form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

            ' Validate result
            Assert.AreEqual(outputs(i), form.txtSearchSpace.Text, "Password: " + inputs(i))
        Next
    End Sub

    ' Extra test for Part 2. This should exercise the limitations of the Integer data type.
    <TestMethod()> Public Sub Test3()
        ' Populate input
        form.txtPassword.Text = "aA0$$$"

        ' Simulate button click
        form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

        ' Validate result
        Assert.AreEqual("100343116692", form.txtSearchSpace.Text, "Password: " + "aA0$$$")
    End Sub

    ' Test of Part 4. Make sure that the search time is being computed correctly for the test cases provided in the writeup.
    <TestMethod()> Public Sub Test4()
        Dim inputs As String() = {"aaaa", "AAAA", "1111", "$$$$", "aA1$"}
        Dim outputs As String() = {"475.254", "475.254", "11.110", "1.554", "21,700.500"}

        For i As Integer = 0 To inputs.Length - 1
            ' Populate input
            form.txtPassword.Text = inputs(i)
            form.txtGuessesPerSec.Text = "1000"

            ' Simulate button click
            form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

            ' Validate result
            Assert.AreEqual(outputs(i) & " seconds", form.txtSearchTime.Text, "Password: " + inputs(i))
        Next
    End Sub

    ' Test of Part 5. Make sure that the unit is being computed correctly for the test cases provided in the writeup.
    <TestMethod()> Public Sub Test5()
        Dim inputs As String() = {"1111", "aaaa", "aA1$", "a1$$$", "aA1$$", "aA0$$$", "aA0$$$$"}
        Dim outputs As String() = {"11.110 seconds", "7.921 minutes", "6.028 hours", "1.550 days", "2.440 weeks", "3.191 years", "2.170 centuries"}

        For i As Integer = 0 To inputs.Length - 1
            ' Populate input
            form.txtPassword.Text = inputs(i)
            form.txtGuessesPerSec.Text = "1000"

            ' Simulate button click
            form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

            ' Validate result
            Assert.AreEqual(outputs(i), form.txtSearchTime.Text, "Password: " + inputs(i))
        Next
    End Sub

    ' Extra test for Part 5. This should exercise the limitations of the Long data type.
    <TestMethod()> Public Sub Test6()
        ' Populate input
        form.txtPassword.Text = "aA0$$$$$$$$"

        ' Simulate button click
        form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

        ' Validate result
        Assert.AreEqual("145892225677715551124", form.txtSearchSpace.Text, "Password: " + "aA0$$$$$$$$")
    End Sub
End Class