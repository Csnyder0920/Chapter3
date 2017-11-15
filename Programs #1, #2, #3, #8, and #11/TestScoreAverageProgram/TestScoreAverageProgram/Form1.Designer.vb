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
        Me.lblTestScore1 = New System.Windows.Forms.Label()
        Me.lblTestScore2 = New System.Windows.Forms.Label()
        Me.lblTestScore3 = New System.Windows.Forms.Label()
        Me.lblTestScore4 = New System.Windows.Forms.Label()
        Me.lblTestScore5 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAverageResult = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore4 = New System.Windows.Forms.TextBox()
        Me.txtScore5 = New System.Windows.Forms.TextBox()
        Me.btnCalculateAvereage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTestScore1
        '
        Me.lblTestScore1.AutoSize = True
        Me.lblTestScore1.Location = New System.Drawing.Point(51, 55)
        Me.lblTestScore1.Name = "lblTestScore1"
        Me.lblTestScore1.Size = New System.Drawing.Size(103, 20)
        Me.lblTestScore1.TabIndex = 0
        Me.lblTestScore1.Text = "Test Score 1:"
        '
        'lblTestScore2
        '
        Me.lblTestScore2.AutoSize = True
        Me.lblTestScore2.Location = New System.Drawing.Point(51, 95)
        Me.lblTestScore2.Name = "lblTestScore2"
        Me.lblTestScore2.Size = New System.Drawing.Size(103, 20)
        Me.lblTestScore2.TabIndex = 1
        Me.lblTestScore2.Text = "Test Score 2:"
        '
        'lblTestScore3
        '
        Me.lblTestScore3.AutoSize = True
        Me.lblTestScore3.Location = New System.Drawing.Point(51, 139)
        Me.lblTestScore3.Name = "lblTestScore3"
        Me.lblTestScore3.Size = New System.Drawing.Size(103, 20)
        Me.lblTestScore3.TabIndex = 2
        Me.lblTestScore3.Text = "Test Score 3:"
        '
        'lblTestScore4
        '
        Me.lblTestScore4.AutoSize = True
        Me.lblTestScore4.Location = New System.Drawing.Point(51, 180)
        Me.lblTestScore4.Name = "lblTestScore4"
        Me.lblTestScore4.Size = New System.Drawing.Size(103, 20)
        Me.lblTestScore4.TabIndex = 3
        Me.lblTestScore4.Text = "Test Score 4:"
        '
        'lblTestScore5
        '
        Me.lblTestScore5.AutoSize = True
        Me.lblTestScore5.Location = New System.Drawing.Point(51, 227)
        Me.lblTestScore5.Name = "lblTestScore5"
        Me.lblTestScore5.Size = New System.Drawing.Size(103, 20)
        Me.lblTestScore5.TabIndex = 4
        Me.lblTestScore5.Text = "Test Score 5:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(82, 286)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(72, 20)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "Average:"
        '
        'lblAverageResult
        '
        Me.lblAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageResult.Location = New System.Drawing.Point(220, 286)
        Me.lblAverageResult.Name = "lblAverageResult"
        Me.lblAverageResult.Size = New System.Drawing.Size(162, 34)
        Me.lblAverageResult.TabIndex = 6
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(220, 49)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(162, 26)
        Me.txtScore1.TabIndex = 7
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(220, 95)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(162, 26)
        Me.txtScore2.TabIndex = 8
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(220, 139)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(162, 26)
        Me.txtScore3.TabIndex = 9
        '
        'txtScore4
        '
        Me.txtScore4.Location = New System.Drawing.Point(220, 180)
        Me.txtScore4.Name = "txtScore4"
        Me.txtScore4.Size = New System.Drawing.Size(162, 26)
        Me.txtScore4.TabIndex = 10
        '
        'txtScore5
        '
        Me.txtScore5.Location = New System.Drawing.Point(220, 227)
        Me.txtScore5.Name = "txtScore5"
        Me.txtScore5.Size = New System.Drawing.Size(162, 26)
        Me.txtScore5.TabIndex = 11
        '
        'btnCalculateAvereage
        '
        Me.btnCalculateAvereage.Location = New System.Drawing.Point(39, 343)
        Me.btnCalculateAvereage.Name = "btnCalculateAvereage"
        Me.btnCalculateAvereage.Size = New System.Drawing.Size(115, 62)
        Me.btnCalculateAvereage.TabIndex = 12
        Me.btnCalculateAvereage.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average"
        Me.btnCalculateAvereage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(185, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 62)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(322, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 62)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 417)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateAvereage)
        Me.Controls.Add(Me.txtScore5)
        Me.Controls.Add(Me.txtScore4)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.lblAverageResult)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTestScore5)
        Me.Controls.Add(Me.lblTestScore4)
        Me.Controls.Add(Me.lblTestScore3)
        Me.Controls.Add(Me.lblTestScore2)
        Me.Controls.Add(Me.lblTestScore1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTestScore1 As Label
    Friend WithEvents lblTestScore2 As Label
    Friend WithEvents lblTestScore3 As Label
    Friend WithEvents lblTestScore4 As Label
    Friend WithEvents lblTestScore5 As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblAverageResult As Label
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents txtScore4 As TextBox
    Friend WithEvents txtScore5 As TextBox
    Friend WithEvents btnCalculateAvereage As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
