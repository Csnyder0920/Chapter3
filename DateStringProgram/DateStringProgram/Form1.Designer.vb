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
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblDayOfWeek = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDayOfMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Location = New System.Drawing.Point(209, 53)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.Size = New System.Drawing.Size(84, 20)
        Me.txtDayOfWeek.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(209, 111)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(84, 20)
        Me.txtMonth.TabIndex = 1
        '
        'txtDayOfMonth
        '
        Me.txtDayOfMonth.Location = New System.Drawing.Point(209, 169)
        Me.txtDayOfMonth.Name = "txtDayOfMonth"
        Me.txtDayOfMonth.Size = New System.Drawing.Size(84, 20)
        Me.txtDayOfMonth.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(209, 228)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(84, 20)
        Me.txtYear.TabIndex = 3
        '
        'lblDayOfWeek
        '
        Me.lblDayOfWeek.AutoSize = True
        Me.lblDayOfWeek.Location = New System.Drawing.Point(65, 53)
        Me.lblDayOfWeek.Name = "lblDayOfWeek"
        Me.lblDayOfWeek.Size = New System.Drawing.Size(129, 13)
        Me.lblDayOfWeek.TabIndex = 4
        Me.lblDayOfWeek.Text = "Enter the day of the week"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(65, 111)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(82, 13)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Enter the month"
        '
        'lblDayOfMonth
        '
        Me.lblDayOfMonth.AutoSize = True
        Me.lblDayOfMonth.Location = New System.Drawing.Point(65, 169)
        Me.lblDayOfMonth.Name = "lblDayOfMonth"
        Me.lblDayOfMonth.Size = New System.Drawing.Size(132, 13)
        Me.lblDayOfMonth.TabIndex = 6
        Me.lblDayOfMonth.Text = "Enter the day of the month"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(65, 228)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(73, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Enter the year"
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Location = New System.Drawing.Point(87, 269)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(169, 22)
        Me.lblDateString.TabIndex = 8
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(35, 307)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(75, 23)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(135, 307)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 346)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDayOfMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDayOfWeek)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayOfMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Name = "Form1"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDayOfWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtDayOfMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDayOfWeek As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblDayOfMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class