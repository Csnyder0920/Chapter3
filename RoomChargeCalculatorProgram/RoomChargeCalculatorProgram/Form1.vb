Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblDate.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTime.Text = Now.ToString("T")
    End Sub
    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal                   ' Room chasrges total
        Dim decAddCharges As Decimal                    ' Additional charges
        Dim decSubtotal As Decimal                      ' Subtotal
        Dim decTax As Decimal                           ' Tax
        Dim decTotal As Decimal                         ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D            ' Tax Rate

        Try

        Catch ex As Exception

        End Try
        ' Calculate and display the room charges.
        decRoomCharges = CDec(txtNights.Text) *
            CDec(txtNightlyCharge.Text)
        lblRoomCharges.Text = decRoomCharges.ToString("c")

        ' Calculate and display the additional charges.
        decAddCharges = CDec(txtRoomService.Text) +
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
        lblAdditionalCharges.Text = decAddCharges.ToString("c")

        ' Calculate and display the Subtatol.
        decSubtotal = decRoomCharges + decAddCharges
        lblSubtotal.Text = decSubtotal.ToString("c")

        ' Calculate and display the tax.
        decTax = decSubtotal * decTAX_RATE
        lblTax.Text = decTax.ToString("c")

        ' Calculate and display the total charges.
        decTotal = decSubtotal + decTax
        lblTotalCharges.Text = decTotal.ToString("c")
        Catch 
            ' Error Message 
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub
End Class