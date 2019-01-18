<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.InputOctal = New System.Windows.Forms.TextBox()
		Me.OkButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.OutputDecimal = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'InputOctal
		'
		Me.InputOctal.AllowDrop = True
		Me.InputOctal.Location = New System.Drawing.Point(226, 37)
		Me.InputOctal.Name = "InputOctal"
		Me.InputOctal.Size = New System.Drawing.Size(242, 20)
		Me.InputOctal.TabIndex = 0
		'
		'OkButton
		'
		Me.OkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OkButton.Location = New System.Drawing.Point(226, 189)
		Me.OkButton.Name = "OkButton"
		Me.OkButton.Size = New System.Drawing.Size(79, 38)
		Me.OkButton.TabIndex = 1
		Me.OkButton.Text = "Convert"
		Me.OkButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(104, 34)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 16)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Octal"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(104, 66)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(66, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Decimal"
		'
		'OutputDecimal
		'
		Me.OutputDecimal.CausesValidation = False
		Me.OutputDecimal.Enabled = False
		Me.OutputDecimal.Location = New System.Drawing.Point(226, 66)
		Me.OutputDecimal.Name = "OutputDecimal"
		Me.OutputDecimal.Size = New System.Drawing.Size(242, 20)
		Me.OutputDecimal.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(104, 37)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 20)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Octal"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(543, 259)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.OkButton)
		Me.Controls.Add(Me.OutputDecimal)
		Me.Controls.Add(Me.InputOctal)
		Me.Name = "Form1"
		Me.Text = "Octal To Decimal Converter"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents InputOctal As System.Windows.Forms.TextBox
	Friend WithEvents OkButton As System.Windows.Forms.Button

	Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

		'Obtain input from user in textbox.
		Dim s As String = InputOctal.Text

		'Validate input 
		If (ValidateInput(s) = False) Then
			'user entered input in wrong format
			Return
		End If

		'Valid input entered by user .Now find res
		'Split string into 2 parts .one containing digits before decimal and other containing digits after decimal

		Dim befDec, aftDec As String
		befDec = ""
		aftDec = ""

		Dim foundDot As Boolean = False
		For Each c As Char In s
			If c = "." Then
				foundDot = True
			ElseIf foundDot Then
				aftDec += c
			Else
				befDec += c
			End If
		Next


		InputOctal.Select()
		OutputDecimal.Text = "Fuck Off"
		
		System.Console.WriteLine(aftDec)
		System.Console.WriteLine(befDec)

		'Do visualisation as you find answer
		'visualisation method unknows till now

	End Sub

	Private Sub InputOctal_KeyDown(sender As Object, e As KeyEventArgs) Handles InputOctal.KeyDown
		If e.KeyCode = Keys.Enter Then
			OkButton.FlatStyle = FlatStyle.Flat
			Call OkButton.PerformClick()
		End If
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents OutputDecimal As TextBox
	Friend WithEvents Label2 As Label
End Class
