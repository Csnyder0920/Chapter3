Public Class Form1

    Private Sub btnShowFahrenheit_Click(sender As Object, e As EventArgs) Handles btnShowFahrenheit.Click
        Dim dblFahrenheit As Double
        Dim dblCelsius As Double

        dblCelsius = txtCelsius.Text
        dblFahrenheit = 1.8 * dblCelsius + 32
        lblShowFahrenheit.Text = dblFahrenheit
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Clear()
        lblShowFahrenheit.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
