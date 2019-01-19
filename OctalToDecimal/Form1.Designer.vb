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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.OutputDecimal = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Explanation = New System.Windows.Forms.RichTextBox()
		Me.SuspendLayout()
		'
		'InputOctal
		'
		Me.InputOctal.AllowDrop = True
		Me.InputOctal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InputOctal.Location = New System.Drawing.Point(358, 9)
		Me.InputOctal.Name = "InputOctal"
		Me.InputOctal.Size = New System.Drawing.Size(437, 31)
		Me.InputOctal.TabIndex = 0
		'
		'OkButton
		'
		Me.OkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OkButton.Location = New System.Drawing.Point(428, 337)
		Me.OkButton.Name = "OkButton"
		Me.OkButton.Size = New System.Drawing.Size(79, 38)
		Me.OkButton.TabIndex = 1
		Me.OkButton.Text = "Convert"
		Me.OkButton.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(191, 40)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(119, 31)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Decimal"
		'
		'OutputDecimal
		'
		Me.OutputDecimal.CausesValidation = False
		Me.OutputDecimal.Enabled = False
		Me.OutputDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OutputDecimal.Location = New System.Drawing.Point(358, 40)
		Me.OutputDecimal.Name = "OutputDecimal"
		Me.OutputDecimal.Size = New System.Drawing.Size(437, 31)
		Me.OutputDecimal.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(191, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(83, 31)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Octal"
		'
		'Explanation
		'
		Me.Explanation.Location = New System.Drawing.Point(84, 77)
		Me.Explanation.Name = "Explanation"
		Me.Explanation.ReadOnly = True
		Me.Explanation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
		Me.Explanation.Size = New System.Drawing.Size(804, 254)
		Me.Explanation.TabIndex = 3
		Me.Explanation.Text = ""
		Me.Explanation.WordWrap = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(943, 408)
		Me.Controls.Add(Me.Explanation)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
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

		InputOctal.Select()
		Dim Integral, Fractional, Result As String
		Integral = ""
		Fractional = ""
		Result = convertDec(InputOctal.Text)
		OutputDecimal.Text = Result
		Explanation.Rtf = writeExplanation(InputOctal.Text, Result)

		'If resAftDec > 0 Then
		'	OutputDecimal.Text = OutputDecimal.Text + "." + resAftDec.ToString
		'End If

		'Dim Endl As String = "\line "
		'Dim Tab As String = "\tab "
		'' Writes Special Chars
		'Dim StrikeEnd As String = "\strike0 "
		'Dim StrikeStart As String = "\strike "
		'' Writes StrikedThrough Text
		'' Usage: Explanation.Rtf = RtfStart + RedStart + "Red Text" + ColourEnd + RtfEnd
		'Dim RtfStart As String = "{\rtf1\ansi\deff0{\fonttbl{\f0 @Arial Unicode MS;}}{\colortbl ;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;\f0\fs22}" ' \f0\fs22
		'Dim RtfEnd As String = "}"
		'' Colours text
		'Dim RedStart As String = "\cf1 "
		'Dim GreenStart As String = "\cf2 "
		'Dim BlueStart As String = "\cf3 "
		'Dim RedEnd As String = "\cf0 "
		'Dim GreenEnd As String = "\cf0 "
		'Dim BlueEnd As String = "\cf0 "
		'Dim ColourEnd As String = "\cf0 "
		'' Writes 8 power n
		'Dim SuperStart As String = "\super "
		'Dim SuperEnd As String = "\nosuperSub "


		'Dim proc As String = RtfStart + RedStart + "Red" + Tab + "Text" + SuperStart + GreenStart + StrikeStart + "Striked Green Superscript" + StrikeEnd + GreenEnd + SuperEnd + ColourEnd + Endl + "Next Line"
		'Explanation.Rtf = proc
		'Console.Write(Explanation.Rtf)
		'Console.Write(proc)

		'Do visualisation as you find answer
		'visualisation method unknows till now

	End Sub

	Private Sub InputOctal_KeyDown(sender As Object, e As KeyEventArgs) Handles InputOctal.KeyDown
		If e.KeyCode = Keys.Enter Then
			OkButton.FlatStyle = FlatStyle.Flat
			Call OkButton.PerformClick()
		End If
	End Sub
	Friend WithEvents Label3 As Label
	Friend WithEvents OutputDecimal As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Explanation As RichTextBox

End Class
