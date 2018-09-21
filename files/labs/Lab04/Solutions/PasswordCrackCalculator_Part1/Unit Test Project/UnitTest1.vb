Imports PasswordCrackCalculator
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim form As frmPasswordCrackCalculator

    <TestInitialize()> Public Sub TestSetup()
        form = New frmPasswordCrackCalculator()
    End Sub

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
End Class