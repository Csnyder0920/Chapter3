<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.lblNumberOrDate = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnExponetialFormat = New System.Windows.Forms.Button()
        Me.btnFixedPoint = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(152, 26)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(191, 20)
        Me.txtUserEntry.TabIndex = 0
        '
        'lblNumberOrDate
        '
        Me.lblNumberOrDate.AutoSize = True
        Me.lblNumberOrDate.Location = New System.Drawing.Point(28, 29)
        Me.lblNumberOrDate.Name = "lblNumberOrDate"
        Me.lblNumberOrDate.Size = New System.Drawing.Size(118, 13)
        Me.lblNumberOrDate.TabIndex = 1
        Me.lblNumberOrDate.Text = "Enter a number or date:"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(86, 74)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(57, 13)
        Me.lblFormatted.TabIndex = 2
        Me.lblFormatted.Text = "Formatted:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(149, 66)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(191, 21)
        Me.lblResult.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponetialFormat)
        Me.GroupBox1.Controls.Add(Me.btnFixedPoint)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 184)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(176, 141)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(138, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full date/time ( F )"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(176, 110)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(138, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long Time ( T )"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(176, 83)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(138, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short time ( t )"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(176, 54)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(138, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long date ( D )"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(176, 25)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(138, 23)
        Me.btnShortDate.TabIndex = 5
        Me.btnShortDate.Text = "Short date ( d )"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(8, 141)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(164, 23)
        Me.btnPercentFormat.TabIndex = 4
        Me.btnPercentFormat.Text = "Percent format ( p )"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(6, 112)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(164, 23)
        Me.btnCurrencyFormat.TabIndex = 3
        Me.btnCurrencyFormat.Text = "Currency format ( c )"
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnExponetialFormat
        '
        Me.btnExponetialFormat.Location = New System.Drawing.Point(6, 83)
        Me.btnExponetialFormat.Name = "btnExponetialFormat"
        Me.btnExponetialFormat.Size = New System.Drawing.Size(164, 23)
        Me.btnExponetialFormat.TabIndex = 2
        Me.btnExponetialFormat.Text = "Exponential format ( e )"
        Me.btnExponetialFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPoint
        '
        Me.btnFixedPoint.Location = New System.Drawing.Point(6, 54)
        Me.btnFixedPoint.Name = "btnFixedPoint"
        Me.btnFixedPoint.Size = New System.Drawing.Size(164, 23)
        Me.btnFixedPoint.TabIndex = 1
        Me.btnFixedPoint.Text = "Fixed-point format ( f )"
        Me.btnFixedPoint.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(6, 25)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(164, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number format ( n )"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(68, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(189, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 36)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 348)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblNumberOrDate)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOrDate As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponetialFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPoint As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
