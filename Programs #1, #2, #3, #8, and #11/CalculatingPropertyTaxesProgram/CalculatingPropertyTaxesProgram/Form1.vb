Public Class Form1

    Private Sub btnShowTax_Click(sender As Object, e As EventArgs) Handles btnShowTax.Click
        Dim PropertyValue, sixtyPercentValue, taxValue As Double
        Const TAX_RATE As Double = 0.64

        Try
            PropertyValue = txtActualPropertyValue.Text
            sixtyPercentValue = PropertyValue * 0.6

            taxValue = (sixtyPercentValue / 100) * TAX_RATE

            lblAssesmentAndTax.Text = taxValue.ToString("c")
        Catch
            MessageBox.Show("ERROR: please enter values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtActualPropertyValue.Clear()
        lblAssesmentAndTax.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class