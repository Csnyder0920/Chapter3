
Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs)

End Sub
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblNightlyCharge = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblRoomService = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblAdditionalChargeResult = New System.Windows.Forms.Label()
        Me.lblTotalChargesResult = New System.Windows.Forms.Label()
        Me.lblTaxResult = New System.Windows.Forms.Label()
        Me.lblSubtotalResult = New System.Windows.Forms.Label()
        Me.lblRoomChargesResult = New System.Windows.Forms.Label()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(91, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(188, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Highlander Hotel"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(93, 44)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Today's Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(133, 71)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.lblNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 127)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(84, 62)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(92, 20)
        Me.txtNightlyCharge.TabIndex = 3
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(84, 31)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(92, 20)
        Me.txtNights.TabIndex = 2
        '
        'lblNightlyCharge
        '
        Me.lblNightlyCharge.AutoSize = True
        Me.lblNightlyCharge.Location = New System.Drawing.Point(6, 65)
        Me.lblNightlyCharge.Name = "lblNightlyCharge"
        Me.lblNightlyCharge.Size = New System.Drawing.Size(79, 13)
        Me.lblNightlyCharge.TabIndex = 1
        Me.lblNightlyCharge.Text = "Nightly Charge:"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(45, 34)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(40, 13)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.lblTelephone)
        Me.GroupBox2.Controls.Add(Me.lblRoomService)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 127)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(84, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(92, 20)
        Me.TextBox5.TabIndex = 5
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(84, 62)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(92, 20)
        Me.txtTelephone.TabIndex = 4
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(84, 34)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(92, 20)
        Me.txtRoomService.TabIndex = 4
        '
        'txtMisc
        '
        Me.txtMisc.AutoSize = True
        Me.txtMisc.Location = New System.Drawing.Point(47, 93)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(32, 13)
        Me.txtMisc.TabIndex = 4
        Me.txtMisc.Text = "Misc:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(18, 65)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 3
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblRoomService
        '
        Me.lblRoomService.AutoSize = True
        Me.lblRoomService.Location = New System.Drawing.Point(2, 34)
        Me.lblRoomService.Name = "lblRoomService"
        Me.lblRoomService.Size = New System.Drawing.Size(77, 13)
        Me.lblRoomService.TabIndex = 2
        Me.lblRoomService.Text = "Room Service:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAdditionalChargeResult)
        Me.GroupBox3.Controls.Add(Me.lblTotalChargesResult)
        Me.GroupBox3.Controls.Add(Me.lblTaxResult)
        Me.GroupBox3.Controls.Add(Me.lblSubtotalResult)
        Me.GroupBox3.Controls.Add(Me.lblRoomChargesResult)
        Me.GroupBox3.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Controls.Add(Me.lblAdditionalCharges)
        Me.GroupBox3.Location = New System.Drawing.Point(60, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 195)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'lblAdditionalChargeResult
        '
        Me.lblAdditionalChargeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditionalChargeResult.Location = New System.Drawing.Point(145, 51)
        Me.lblAdditionalChargeResult.Name = "lblAdditionalChargeResult"
        Me.lblAdditionalChargeResult.Size = New System.Drawing.Size(100, 25)
        Me.lblAdditionalChargeResult.TabIndex = 14
        '
        'lblTotalChargesResult
        '
        Me.lblTotalChargesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalChargesResult.Location = New System.Drawing.Point(145, 167)
        Me.lblTotalChargesResult.Name = "lblTotalChargesResult"
        Me.lblTotalChargesResult.Size = New System.Drawing.Size(100, 25)
        Me.lblTotalChargesResult.TabIndex = 13
        '
        'lblTaxResult
        '
        Me.lblTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxResult.Location = New System.Drawing.Point(145, 124)
        Me.lblTaxResult.Name = "lblTaxResult"
        Me.lblTaxResult.Size = New System.Drawing.Size(100, 25)
        Me.lblTaxResult.TabIndex = 12
        '
        'lblSubtotalResult
        '
        Me.lblSubtotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalResult.Location = New System.Drawing.Point(145, 90)
        Me.lblSubtotalResult.Name = "lblSubtotalResult"
        Me.lblSubtotalResult.Size = New System.Drawing.Size(100, 25)
        Me.lblSubtotalResult.TabIndex = 11
        '
        'lblRoomChargesResult
        '
        Me.lblRoomChargesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomChargesResult.Location = New System.Drawing.Point(145, 16)
        Me.lblRoomChargesResult.Name = "lblRoomChargesResult"
        Me.lblRoomChargesResult.Size = New System.Drawing.Size(100, 25)
        Me.lblRoomChargesResult.TabIndex = 10
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Location = New System.Drawing.Point(52, 167)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(76, 13)
        Me.lblTotalCharges.TabIndex = 9
        Me.lblTotalCharges.Text = "Total Charges:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(100, 124)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(79, 90)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 7
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Location = New System.Drawing.Point(48, 28)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(80, 13)
        Me.lblRoomCharges.TabIndex = 5
        Me.lblRoomCharges.Text = "Room Charges:"
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(30, 63)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(98, 13)
        Me.lblAdditionalCharges.TabIndex = 6
        Me.lblAdditionalCharges.Text = "Additional Charges:"
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(21, 444)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(133, 32)
        Me.btnCalculateCharges.TabIndex = 5
        Me.btnCalculateCharges.Text = "Calculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(163, 444)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 32)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(267, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 479)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNightlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblRoomService As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalChargeResult As System.Windows.Forms.Label
    Friend WithEvents lblTotalChargesResult As System.Windows.Forms.Label
    Friend WithEvents lblTaxResult As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalResult As System.Windows.Forms.Label
    Friend WithEvents lblRoomChargesResult As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalCharges As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button


