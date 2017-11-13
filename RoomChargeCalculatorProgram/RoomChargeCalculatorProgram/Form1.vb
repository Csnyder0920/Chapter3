Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblCurrentDate.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblCurrentTime.Text = Now.ToString("T")
    End Sub
    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        ' Declare variables for the calculations.
        Dim RoomCharges As Double                  ' Room charges total
        Dim AddCharges As Double                   ' Additional charges
        Dim Subtotal As Double                     ' Subtotal
        Dim Tax As Double                          ' Tax
        Dim Total As Double                        ' Total of all charges
        Const TAX_RATE As Double = 0.08D           ' Tax Rate

        Try
            ' Calculate and display the room charges.
            RoomCharges = CDbl(txtNights.Text) * CDbl(txtNightlyCharge.Text)
            lblRoomChargesResult.Text = RoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            AddCharges = CDbl(txtRoomService.Text) + CDbl(txtTelephone.Text) + CDbl(lblMisc.Text)
            lblAdditionalChargesResult.Text = AddCharges.ToString("c")

            ' Calculate and display the Subtatol.
            Subtotal = RoomCharges + AddCharges
            lblSubtotalResult.Text = Subtotal.ToString("c")

            ' Calculate and display the tax.
            Tax = Subtotal * TAX_RATE
            lblTaxResult.Text = Tax.ToString("c")

            ' Calculate and display the total charges.
            Total = Subtotal + Tax
            lblTotalChargesResult.Text = Total.ToString("c")

            ' Change the colors for the total charges.
            lblTotalChargesResult.BackColor = Color.Blue
            lblTotalChargesResult.ForeColor = Color.White
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

        ' Reset the lblTotalChargesResult control's colors.
        lblTotalChargesResult.BackColor = SystemColors.Control
        lblTotalChargesResult.ForeColor = SystemColors.ControlText

        ' Reset the focus to the first field.
        txtNights.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class