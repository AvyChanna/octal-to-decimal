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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.InputOctal = New System.Windows.Forms.TextBox()
		Me.OkButton = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Explanation = New System.Windows.Forms.RichTextBox()
		Me.OutputDecimal = New System.Windows.Forms.RichTextBox()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.FileInput = New System.Windows.Forms.Button()
		Me.FileOutput = New System.Windows.Forms.Button()
		Me.FileInputDialog = New System.Windows.Forms.OpenFileDialog()
		Me.FileOutputDialog = New System.Windows.Forms.SaveFileDialog()
		Me.Authors = New System.Windows.Forms.Label()
		Me.AuthorHead = New System.Windows.Forms.Label()
		Me.ShowVisuals = New System.Windows.Forms.CheckBox()
		Me.TempBox = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'InputOctal
		'
		Me.InputOctal.AllowDrop = True
		Me.InputOctal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.InputOctal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.InputOctal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InputOctal.Location = New System.Drawing.Point(178, 12)
		Me.InputOctal.Name = "InputOctal"
		Me.InputOctal.Size = New System.Drawing.Size(368, 28)
		Me.InputOctal.TabIndex = 1
		Me.InputOctal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'OkButton
		'
		Me.OkButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OkButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.OkButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.OkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OkButton.Location = New System.Drawing.Point(178, 380)
		Me.OkButton.Name = "OkButton"
		Me.OkButton.Size = New System.Drawing.Size(309, 40)
		Me.OkButton.TabIndex = 6
		Me.OkButton.Text = "Convert"
		Me.OkButton.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(7, 48)
		Me.Label3.Margin = New System.Windows.Forms.Padding(3)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(150, 28)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Decimal"
		'
		'Label2
		'
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 12)
		Me.Label2.Margin = New System.Windows.Forms.Padding(3)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(150, 28)
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
		Me.Explanation.Location = New System.Drawing.Point(13, 116)
		Me.Explanation.Name = "Explanation"
		Me.Explanation.ReadOnly = True
		Me.Explanation.Size = New System.Drawing.Size(634, 258)
		Me.Explanation.TabIndex = 11
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
		Me.OutputDecimal.Location = New System.Drawing.Point(178, 48)
		Me.OutputDecimal.MaxLength = 32767
		Me.OutputDecimal.Multiline = False
		Me.OutputDecimal.Name = "OutputDecimal"
		Me.OutputDecimal.ReadOnly = True
		Me.OutputDecimal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.OutputDecimal.ShowSelectionMargin = True
		Me.OutputDecimal.Size = New System.Drawing.Size(368, 28)
		Me.OutputDecimal.TabIndex = 10
		Me.OutputDecimal.TabStop = False
		Me.OutputDecimal.Text = ""
		Me.OutputDecimal.WordWrap = False
		'
		'ExitButton
		'
		Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ExitButton.Location = New System.Drawing.Point(497, 380)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(150, 40)
		Me.ExitButton.TabIndex = 7
		Me.ExitButton.Text = "Exit"
		Me.ExitButton.UseVisualStyleBackColor = False
		'
		'ResetButton
		'
		Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ResetButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ResetButton.Location = New System.Drawing.Point(13, 380)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(150, 40)
		Me.ResetButton.TabIndex = 5
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = False
		'
		'FileInput
		'
		Me.FileInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FileInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.FileInput.Cursor = System.Windows.Forms.Cursors.Hand
		Me.FileInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.FileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.FileInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FileInput.Location = New System.Drawing.Point(552, 12)
		Me.FileInput.Name = "FileInput"
		Me.FileInput.Size = New System.Drawing.Size(95, 28)
		Me.FileInput.TabIndex = 2
		Me.FileInput.Text = "File Input"
		Me.FileInput.UseVisualStyleBackColor = False
		'
		'FileOutput
		'
		Me.FileOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FileOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.FileOutput.Cursor = System.Windows.Forms.Cursors.Hand
		Me.FileOutput.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.FileOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.FileOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FileOutput.Location = New System.Drawing.Point(552, 48)
		Me.FileOutput.Name = "FileOutput"
		Me.FileOutput.Size = New System.Drawing.Size(95, 28)
		Me.FileOutput.TabIndex = 3
		Me.FileOutput.Text = "File Output"
		Me.FileOutput.UseVisualStyleBackColor = False
		'
		'FileInputDialog
		'
		Me.FileInputDialog.AddExtension = False
		Me.FileInputDialog.DefaultExt = "txt"
		Me.FileInputDialog.Filter = "Text Files|*.txt|All Files|*.*"
		Me.FileInputDialog.ReadOnlyChecked = True
		Me.FileInputDialog.RestoreDirectory = True
		Me.FileInputDialog.ShowReadOnly = True
		Me.FileInputDialog.SupportMultiDottedExtensions = True
		Me.FileInputDialog.Title = "Open File containing Octal Input"
		'
		'FileOutputDialog
		'
		Me.FileOutputDialog.DefaultExt = "txt"
		Me.FileOutputDialog.Filter = "Text Files|*.txt|All Files|*.*"
		Me.FileOutputDialog.RestoreDirectory = True
		Me.FileOutputDialog.SupportMultiDottedExtensions = True
		Me.FileOutputDialog.Title = "Save Decimal Number Output into File"
		'
		'Authors
		'
		Me.Authors.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Authors.AutoSize = True
		Me.Authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Authors.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Authors.Location = New System.Drawing.Point(175, 425)
		Me.Authors.Name = "Authors"
		Me.Authors.Size = New System.Drawing.Size(458, 24)
		Me.Authors.TabIndex = 12
		Me.Authors.Text = "Avneet Singh (170101015), Piyush Gupta (170101045)"
		Me.Authors.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'AuthorHead
		'
		Me.AuthorHead.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.AuthorHead.AutoSize = True
		Me.AuthorHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AuthorHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AuthorHead.Location = New System.Drawing.Point(30, 425)
		Me.AuthorHead.Name = "AuthorHead"
		Me.AuthorHead.Size = New System.Drawing.Size(143, 25)
		Me.AuthorHead.TabIndex = 13
		Me.AuthorHead.Text = "AUTHORS  -"
		Me.AuthorHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ShowVisuals
		'
		Me.ShowVisuals.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ShowVisuals.AutoSize = True
		Me.ShowVisuals.Checked = True
		Me.ShowVisuals.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ShowVisuals.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ShowVisuals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ShowVisuals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShowVisuals.Location = New System.Drawing.Point(464, 82)
		Me.ShowVisuals.Name = "ShowVisuals"
		Me.ShowVisuals.Size = New System.Drawing.Size(183, 28)
		Me.ShowVisuals.TabIndex = 4
		Me.ShowVisuals.Text = "Show Visualization"
		Me.ShowVisuals.UseVisualStyleBackColor = True
		'
		'TempBox
		'
		Me.TempBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TempBox.Enabled = False
		Me.TempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TempBox.Location = New System.Drawing.Point(13, 92)
		Me.TempBox.Name = "TempBox"
		Me.TempBox.ReadOnly = True
		Me.TempBox.Size = New System.Drawing.Size(1, 3)
		Me.TempBox.TabIndex = 14
		Me.TempBox.TabStop = False
		Me.TempBox.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(659, 461)
		Me.Controls.Add(Me.TempBox)
		Me.Controls.Add(Me.ShowVisuals)
		Me.Controls.Add(Me.AuthorHead)
		Me.Controls.Add(Me.Authors)
		Me.Controls.Add(Me.OutputDecimal)
		Me.Controls.Add(Me.Explanation)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.FileOutput)
		Me.Controls.Add(Me.FileInput)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.OkButton)
		Me.Controls.Add(Me.InputOctal)
		Me.HelpButton = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(650, 499)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Octal To Decimal Converter - Group 8"
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

        Dim Integral, Fractional, Result As String
        Integral = ""
        Fractional = ""
        Result = ConvertDec(InputOctal.Text)
        OutputDecimal.Text = Result
        If ShowVisuals.Checked = True Then
            Explanation.Rtf = GenerateExplanation(InputOctal.Text, Result)
        End If
        InputOctal.Select()

    End Sub

    Private Sub InputOctal_KeyDown(sender As Object, e As KeyEventArgs) Handles InputOctal.KeyDown
        ' Handles Enter Keypress on Octal Number Textbox
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Call OkButton.PerformClick()
        End If
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Explanation As RichTextBox
    Friend WithEvents OutputDecimal As RichTextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OutputDecimal.SelectionAlignment = HorizontalAlignment.Center
        InputOctal.Select()
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        InputOctal.Text = ""
        OutputDecimal.Text = ""
		Explanation.Text = ""
		TempBox.Text = ""
        InputOctal.Select()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
    Friend WithEvents FileInput As System.Windows.Forms.Button
    Friend WithEvents FileOutput As System.Windows.Forms.Button

    Private Sub FileInput_Click(sender As Object, e As EventArgs) Handles FileInput.Click
        FileInputDialog.ShowDialog()
    End Sub

    Private Sub FileOutput_Click(sender As Object, e As EventArgs) Handles FileOutput.Click
        If OutputDecimal.Text = "" Then
            MessageBox.Show("No Number is converted yet!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            InputOctal.Focus()
        Else
            FileOutputDialog.ShowDialog()
        End If
    End Sub
    Friend WithEvents FileInputDialog As System.Windows.Forms.OpenFileDialog

    Private Sub FileInputDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FileInputDialog.FileOk
        Dim strm As System.IO.Stream
        Dim FileContents As String = ""
        Try
            strm = FileInputDialog.OpenFile()
            If Not (strm Is Nothing) Then
                Using Reader As System.IO.StreamReader = New System.IO.StreamReader(strm)
                    FileContents = Reader.ReadToEnd()
                End Using
            End If
            FileContents = FileContents.Trim()
            If ValidateInput(FileContents) = True Then
                InputOctal.Text = FileContents

                ' Valid input entered by user .Now find res
                ' Split string into 2 parts .one containing digits before decimal and other containing digits after decimal
                Dim Integral, Fractional, Result As String
                Integral = ""
                Fractional = ""
                Result = ConvertDec(InputOctal.Text)
                OutputDecimal.Text = Result
                If ShowVisuals.Checked = True Then
                    Explanation.Rtf = GenerateExplanation(InputOctal.Text, Result)
                End If
                InputOctal.Select()
            End If
        Catch err As Exception
            MessageBox.Show("Error reading File :" + err.ToString, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Friend WithEvents FileOutputDialog As System.Windows.Forms.SaveFileDialog

    Private Sub FileOutputDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FileOutputDialog.FileOk
        Try
            My.Computer.FileSystem.WriteAllText(FileOutputDialog.FileName, OutputDecimal.Text, False)
        Catch err As Exception
            MessageBox.Show("Error writing File :" + err.ToString, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Friend WithEvents Authors As Label
    Friend WithEvents AuthorHead As Label
    Friend WithEvents ShowVisuals As CheckBox

    Private Sub ShowVisuals_CheckedChanged(sender As Object, e As EventArgs) Handles ShowVisuals.CheckedChanged
		If OutputDecimal.Text = "" Then
			TempBox.Text = ""
			Return
		End If
		If Explanation.Text = "" Then
			Explanation.Rtf = TempBox.Text
			'Explanation.Rtf = GenerateExplanation(InputOctal.Text, OutputDecimal.Text)
		Else
			TempBox.Text = Explanation.Rtf
			Explanation.Rtf = ""
		End If
	End Sub
	Friend WithEvents TempBox As System.Windows.Forms.TextBox
End Class
