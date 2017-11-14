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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.lblClassC1 = New System.Windows.Forms.Label()
        Me.lblClassB1 = New System.Windows.Forms.Label()
        Me.lblClassA1 = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalRevenueResult = New System.Windows.Forms.Label()
        Me.lblClassCResult = New System.Windows.Forms.Label()
        Me.lblClassBResult = New System.Windows.Forms.Label()
        Me.lblClassAResult = New System.Windows.Forms.Label()
        Me.lblClassA2 = New System.Windows.Forms.Label()
        Me.lblClassB2 = New System.Windows.Forms.Label()
        Me.lblClassC2 = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.lblClassC1)
        Me.GroupBox1.Controls.Add(Me.lblClassB1)
        Me.GroupBox1.Controls.Add(Me.lblClassA1)
        Me.GroupBox1.Controls.Add(Me.lblHeading)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(96, 167)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(97, 20)
        Me.txtClassC.TabIndex = 6
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(96, 131)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(97, 20)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(96, 93)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(97, 20)
        Me.txtClassA.TabIndex = 4
        '
        'lblClassC1
        '
        Me.lblClassC1.AutoSize = True
        Me.lblClassC1.Location = New System.Drawing.Point(38, 169)
        Me.lblClassC1.Name = "lblClassC1"
        Me.lblClassC1.Size = New System.Drawing.Size(42, 13)
        Me.lblClassC1.TabIndex = 3
        Me.lblClassC1.Text = "Class C"
        '
        'lblClassB1
        '
        Me.lblClassB1.AutoSize = True
        Me.lblClassB1.Location = New System.Drawing.Point(38, 133)
        Me.lblClassB1.Name = "lblClassB1"
        Me.lblClassB1.Size = New System.Drawing.Size(42, 13)
        Me.lblClassB1.TabIndex = 2
        Me.lblClassB1.Text = "Class B"
        '
        'lblClassA1
        '
        Me.lblClassA1.AutoSize = True
        Me.lblClassA1.Location = New System.Drawing.Point(38, 95)
        Me.lblClassA1.Name = "lblClassA1"
        Me.lblClassA1.Size = New System.Drawing.Size(42, 13)
        Me.lblClassA1.TabIndex = 1
        Me.lblClassA1.Text = "Class A"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(36, 43)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(156, 26)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Enter the number of tickets sold" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each class of seats"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenueResult)
        Me.GroupBox2.Controls.Add(Me.lblClassCResult)
        Me.GroupBox2.Controls.Add(Me.lblClassBResult)
        Me.GroupBox2.Controls.Add(Me.lblClassAResult)
        Me.GroupBox2.Controls.Add(Me.lblClassA2)
        Me.GroupBox2.Controls.Add(Me.lblClassB2)
        Me.GroupBox2.Controls.Add(Me.lblClassC2)
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 214)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'lblTotalRevenueResult
        '
        Me.lblTotalRevenueResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenueResult.Location = New System.Drawing.Point(116, 183)
        Me.lblTotalRevenueResult.Name = "lblTotalRevenueResult"
        Me.lblTotalRevenueResult.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalRevenueResult.TabIndex = 10
        '
        'lblClassCResult
        '
        Me.lblClassCResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassCResult.Location = New System.Drawing.Point(116, 124)
        Me.lblClassCResult.Name = "lblClassCResult"
        Me.lblClassCResult.Size = New System.Drawing.Size(100, 23)
        Me.lblClassCResult.TabIndex = 9
        '
        'lblClassBResult
        '
        Me.lblClassBResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassBResult.Location = New System.Drawing.Point(116, 88)
        Me.lblClassBResult.Name = "lblClassBResult"
        Me.lblClassBResult.Size = New System.Drawing.Size(100, 23)
        Me.lblClassBResult.TabIndex = 8
        '
        'lblClassAResult
        '
        Me.lblClassAResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassAResult.Location = New System.Drawing.Point(116, 56)
        Me.lblClassAResult.Name = "lblClassAResult"
        Me.lblClassAResult.Size = New System.Drawing.Size(100, 23)
        Me.lblClassAResult.TabIndex = 2
        '
        'lblClassA2
        '
        Me.lblClassA2.AutoSize = True
        Me.lblClassA2.Location = New System.Drawing.Point(56, 56)
        Me.lblClassA2.Name = "lblClassA2"
        Me.lblClassA2.Size = New System.Drawing.Size(42, 13)
        Me.lblClassA2.TabIndex = 4
        Me.lblClassA2.Text = "Class A"
        '
        'lblClassB2
        '
        Me.lblClassB2.AutoSize = True
        Me.lblClassB2.Location = New System.Drawing.Point(56, 88)
        Me.lblClassB2.Name = "lblClassB2"
        Me.lblClassB2.Size = New System.Drawing.Size(42, 13)
        Me.lblClassB2.TabIndex = 5
        Me.lblClassB2.Text = "Class B"
        '
        'lblClassC2
        '
        Me.lblClassC2.AutoSize = True
        Me.lblClassC2.Location = New System.Drawing.Point(56, 125)
        Me.lblClassC2.Name = "lblClassC2"
        Me.lblClassC2.Size = New System.Drawing.Size(42, 13)
        Me.lblClassC2.TabIndex = 6
        Me.lblClassC2.Text = "Class C"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Location = New System.Drawing.Point(21, 184)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalRevenue.TabIndex = 7
        Me.lblTotalRevenue.Text = "Total Revenue:"
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(61, 245)
        Me.btnCalculateRevenue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(151, 36)
        Me.btnCalculateRevenue.TabIndex = 2
        Me.btnCalculateRevenue.Text = "Calculate Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(225, 245)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 36)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 245)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 330)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents lblClassC1 As System.Windows.Forms.Label
    Friend WithEvents lblClassB1 As System.Windows.Forms.Label
    Friend WithEvents lblClassA1 As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenueResult As System.Windows.Forms.Label
    Friend WithEvents lblClassCResult As System.Windows.Forms.Label
    Friend WithEvents lblClassBResult As System.Windows.Forms.Label
    Friend WithEvents lblClassAResult As System.Windows.Forms.Label
    Friend WithEvents lblClassA2 As System.Windows.Forms.Label
    Friend WithEvents lblClassB2 As System.Windows.Forms.Label
    Friend WithEvents lblClassC2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents btnCalculateRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
