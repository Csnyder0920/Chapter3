Public Class Form1
    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        Dim dblScore1, dblScore2, dblScore3, dblAverage As Double

        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            lblResult.Text = dblAverage.ToString("n2")

            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"""
            Else
                lblMessage.Text = "Keep Trying!"
            End If

        Catch ex As Exception
            lblMessage.Text = "Scores Must be Numeric"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
