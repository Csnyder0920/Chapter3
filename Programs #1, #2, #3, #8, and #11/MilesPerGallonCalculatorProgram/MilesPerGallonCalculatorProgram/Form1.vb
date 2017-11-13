Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        lblMilesPerGallonResult.Text = txtDistancePerTank.Text / txtCapacity.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCapacity.Clear()
        txtDistancePerTank.Clear()
        lblMilesPerGallonResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
