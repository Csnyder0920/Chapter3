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
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblDistancePerTank = New System.Windows.Forms.Label()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtDistancePerTank = New System.Windows.Forms.TextBox()
        Me.lblMilesPerGallonResult = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(45, 38)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(92, 26)
        Me.lblCapacity.TabIndex = 0
        Me.lblCapacity.Text = "Gallons of gas the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "car can hold:"
        '
        'lblDistancePerTank
        '
        Me.lblDistancePerTank.AutoSize = True
        Me.lblDistancePerTank.Location = New System.Drawing.Point(45, 95)
        Me.lblDistancePerTank.Name = "lblDistancePerTank"
        Me.lblDistancePerTank.Size = New System.Drawing.Size(96, 39)
        Me.lblDistancePerTank.TabIndex = 1
        Me.lblDistancePerTank.Text = "Number of miles it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be driven on a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "full tank:"
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.AutoSize = True
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(45, 155)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(83, 13)
        Me.lblMilesPerGallon.TabIndex = 2
        Me.lblMilesPerGallon.Text = "Miles per gallon:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(158, 44)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacity.TabIndex = 3
        '
        'txtDistancePerTank
        '
        Me.txtDistancePerTank.Location = New System.Drawing.Point(158, 95)
        Me.txtDistancePerTank.Name = "txtDistancePerTank"
        Me.txtDistancePerTank.Size = New System.Drawing.Size(100, 20)
        Me.txtDistancePerTank.TabIndex = 4
        '
        'lblMilesPerGallonResult
        '
        Me.lblMilesPerGallonResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallonResult.Location = New System.Drawing.Point(158, 145)
        Me.lblMilesPerGallonResult.Name = "lblMilesPerGallonResult"
        Me.lblMilesPerGallonResult.Size = New System.Drawing.Size(100, 23)
        Me.lblMilesPerGallonResult.TabIndex = 5
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(39, 206)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(63, 44)
        Me.btnCalculateMPG.TabIndex = 6
        Me.btnCalculateMPG.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(108, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 44)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 44)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.lblMilesPerGallonResult)
        Me.Controls.Add(Me.txtDistancePerTank)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.lblDistancePerTank)
        Me.Controls.Add(Me.lblCapacity)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents lblDistancePerTank As System.Windows.Forms.Label
    Friend WithEvents lblMilesPerGallon As System.Windows.Forms.Label
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents txtDistancePerTank As System.Windows.Forms.TextBox
    Friend WithEvents lblMilesPerGallonResult As System.Windows.Forms.Label
    Friend WithEvents btnCalculateMPG As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
