﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Explanation = New System.Windows.Forms.RichTextBox()
		Me.OutputDecimal = New System.Windows.Forms.RichTextBox()
		Me.SuspendLayout()
		'
		'InputOctal
		'
		Me.InputOctal.AllowDrop = True
		Me.InputOctal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.InputOctal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.InputOctal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InputOctal.Location = New System.Drawing.Point(176, 12)
		Me.InputOctal.Name = "InputOctal"
		Me.InputOctal.Size = New System.Drawing.Size(293, 28)
		Me.InputOctal.TabIndex = 0
		Me.InputOctal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'OkButton
		'
		Me.OkButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OkButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.OkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OkButton.Location = New System.Drawing.Point(176, 285)
		Me.OkButton.Name = "OkButton"
		Me.OkButton.Size = New System.Drawing.Size(133, 39)
		Me.OkButton.TabIndex = 1
		Me.OkButton.Text = "Convert"
		Me.OkButton.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(9, 46)
		Me.Label3.Margin = New System.Windows.Forms.Padding(3)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(132, 28)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Decimal"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(9, 12)
		Me.Label2.Margin = New System.Windows.Forms.Padding(3)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(132, 28)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Octal"
		'
		'Explanation
		'
		Me.Explanation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Explanation.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Explanation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Explanation.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Explanation.Location = New System.Drawing.Point(15, 82)
		Me.Explanation.Name = "Explanation"
		Me.Explanation.ReadOnly = True
		Me.Explanation.Size = New System.Drawing.Size(454, 197)
		Me.Explanation.TabIndex = 3
		Me.Explanation.TabStop = False
		Me.Explanation.Text = ""
		Me.Explanation.WordWrap = False
		'
		'OutputDecimal
		'
		Me.OutputDecimal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OutputDecimal.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.OutputDecimal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.OutputDecimal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.OutputDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OutputDecimal.Location = New System.Drawing.Point(176, 46)
		Me.OutputDecimal.MaxLength = 32767
		Me.OutputDecimal.Multiline = False
		Me.OutputDecimal.Name = "OutputDecimal"
		Me.OutputDecimal.ReadOnly = True
		Me.OutputDecimal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.OutputDecimal.Size = New System.Drawing.Size(293, 28)
		Me.OutputDecimal.TabIndex = 4
		Me.OutputDecimal.TabStop = False
		Me.OutputDecimal.Text = ""
		Me.OutputDecimal.WordWrap = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(484, 336)
		Me.Controls.Add(Me.OutputDecimal)
		Me.Controls.Add(Me.Explanation)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.OkButton)
		Me.Controls.Add(Me.InputOctal)
		Me.MinimumSize = New System.Drawing.Size(500, 375)
		Me.Name = "Form1"
		Me.Text = "Octal To Decimal Converter"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents InputOctal As System.Windows.Forms.TextBox
	Friend WithEvents OkButton As System.Windows.Forms.Button

	Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

		' Obtain input from user in textbox.
		Dim s As String = InputOctal.Text

		' Validate input
		If (ValidateInput(s) = False) Then
			' User entered input in wrong format
			OutputDecimal.Text = ""
			Explanation.Rtf = ""
			Return
		End If


		' Valid input entered by user .Now find res
		' Split string into 2 parts .one containing digits before decimal and other containing digits after decimal

		InputOctal.Select()
		Dim Integral, Fractional, Result As String
		Integral = ""
		Fractional = ""
		Result = ConvertDec(InputOctal.Text)
		OutputDecimal.Text = Result
		Explanation.Rtf = GenerateExplanation(InputOctal.Text, Result)

	End Sub

	Private Sub InputOctal_KeyDown(sender As Object, e As KeyEventArgs) Handles InputOctal.KeyDown
		' Handles Enter Keypress on Octal Number Textbox
		If e.KeyCode = Keys.Enter Then
			OkButton.FlatStyle = FlatStyle.Flat
			Call OkButton.PerformClick()
		End If
	End Sub
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Explanation As RichTextBox
	Friend WithEvents OutputDecimal As RichTextBox

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width) \ 2, (Screen.PrimaryScreen.Bounds.Height - Me.Height) \ 2)
		OutputDecimal.SelectionAlignment = HorizontalAlignment.Center
	End Sub
End Class
