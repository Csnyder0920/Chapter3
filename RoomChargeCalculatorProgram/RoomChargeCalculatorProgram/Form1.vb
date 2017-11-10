Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblCurrentDate.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblCurrentTime.Text = Now.ToString("T")
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
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRoomChargesResult.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(lblMisc.Text)
            lblAdditionalChargesResult.Text = decAddCharges.ToString("c")

            ' Calculate and display the Subtatol.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotalResult.Text = decSubtotal.ToString("c")

            ' Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTaxResult.Text = decTax.ToString("c")

            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotalChargesResult.Text = decTotal.ToString("c")
        Catch
            ' Error Message 
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMIsc.Clear()

        ' Clear the decTotal fields.
        lblRoomChargesResult.Text = String.Empty
        lblAdditionalChargesResult.Text = String.Empty
        lblSubtotalResult.Text = String.Empty
        lblTaxResult.Text = String.Empty
        lblTotalChargesResult.Text = String.Empty

        ' Get today's date from the operating system and display it. 
        lblCurrentDate.Text = Now.ToString("D")

        ' Get the current time from the operating system and display it.
        lblCurrentTime.Text = Now.ToString("T")

        ' Reset the focus to the first field.
        txtNights.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class