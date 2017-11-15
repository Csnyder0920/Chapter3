Public Class Form1
    Private Sub btnCalculateAvereage_Click(sender As Object, e As EventArgs) Handles btnCalculateAvereage.Click
        lblAverageResult.Text = txtScore1.Text + txtScore2.Text + txtScore3.Text + txtScore4.Text + txtScore5.Text / "5"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        txtScore4.Clear()
        txtScore5.Clear()
        lblAverageResult.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class