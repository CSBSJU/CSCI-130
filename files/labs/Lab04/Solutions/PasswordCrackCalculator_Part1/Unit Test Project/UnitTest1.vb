Imports PasswordCrackCalculator
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestAlphabetSize()
        Dim form As New frmPasswordCrackCalculator()

        ' Populate input
        form.txtPassword.Text = "PASSWORD"

        ' Simulate button click
        form.btnCompute_Click(form.btnCompute, EventArgs.Empty)

        ' Validate result
        Assert.AreEqual(form.txtAlphabetSize.Text, "26")
    End Sub

End Class