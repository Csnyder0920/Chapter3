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
        Me.lblShowFahrenheit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.btnShowFahrenheit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblShowFahrenheit
        '
        Me.lblShowFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowFahrenheit.Location = New System.Drawing.Point(147, 148)
        Me.lblShowFahrenheit.Name = "lblShowFahrenheit"
        Me.lblShowFahrenheit.Size = New System.Drawing.Size(100, 23)
        Me.lblShowFahrenheit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fahrenheit shown here:"
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(147, 65)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(100, 20)
        Me.txtCelsius.TabIndex = 2
        '
        'btnShowFahrenheit
        '
        Me.btnShowFahrenheit.Location = New System.Drawing.Point(46, 252)
        Me.btnShowFahrenheit.Name = "btnShowFahrenheit"
        Me.btnShowFahrenheit.Size = New System.Drawing.Size(76, 38)
        Me.btnShowFahrenheit.TabIndex = 3
        Me.btnShowFahrenheit.Text = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fahrenheit"
        Me.btnShowFahrenheit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 252)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(247, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type Celsius here:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowFahrenheit)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblShowFahrenheit)
        Me.Name = "Form1"
        Me.Text = "Celsius to Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShowFahrenheit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents btnShowFahrenheit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
