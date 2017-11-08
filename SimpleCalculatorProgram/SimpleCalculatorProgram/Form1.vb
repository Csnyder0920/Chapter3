Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' This event handler performs addition.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "+" as the operation.
        lblOperation.Text = " + "

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ' This event handler performs subtraction.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "-" as the operation.
        lblOperation.Text = " - "

        ' Subtract the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' This event handler performs multiplication.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "*" as the operation.
        lblOperation.Text = " * "

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnIntegerDivide_Click(sender As Object, e As EventArgs) Handles btnIntegerDivide.Click
        ' This event handler performs integer division.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "/" as the operation.
        lblOperation.Text = " / "

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        ' This event handler performs Exponential.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "^" as the operation.
        lblOperation.Text = " ^ "

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        ' This event handler performs modulus.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "Mod" as the operation.
        lblOperation.Text = " Mod "

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) Mod CDbl(txtNumber2.Text)

        'Display the result.
        lblResult1.Text = CStr(dblResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblResult1.Text = ""
        lblOperation.Text = "Operation:"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
