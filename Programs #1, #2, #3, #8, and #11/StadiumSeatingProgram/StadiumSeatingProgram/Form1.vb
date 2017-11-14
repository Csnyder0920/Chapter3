Public Class Form1
    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        ' Class A seats cost $15 each
        ' Class B seats cost $12 each
        ' Class C seats cost $9 each

        Dim dblClassA As Double
        Dim dblClassB As Double
        Dim dblClassC As Double
        Dim dblTotal As Double

        dblClassA = txtClassA.Text
        lblClassAResult.Text = (dblClassA * 15)
        dblClassA = lblClassAResult.Text

        dblClassB = txtClassB.Text
        lblClassBResult.Text = (dblClassB * 12)
        dblClassB = lblClassBResult.Text

        dblClassC = txtClassC.Text
        lblClassCResult.Text = (dblClassC * 9)
        dblClassC = lblClassCResult.Text

        dblTotal = dblClassA + dblClassB + dblClassC
        lblTotalRevenueResult.Text = dblTotal
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassAResult.Text = ""
        lblClassBResult.Text = ""
        lblClassCResult.Text = ""
        lblTotalRevenueResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
