Public Class Form1

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        ' Declare a string variable to hold the full name.
        Dim strFullName As String

        ' Combine the first and last names and assign the 
        ' result to strFullName. 
        strFullName = txtFirstName.Text & " " & txtLastName.Text
        ' Dsiplay the full name in the lblFullName Label.
        lblFullName1.Text = strFullName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the TextBox controls and the label.
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName1.Text = String.Empty

        ' Set focus to txtFirstName.
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class