Module ValidationFunctionModule
	' Validates that given Input can be correctly processed
	Function ValidateInput(ByVal str As String) As Boolean
		'Check string is not empty
		If str = "" Then
			MessageBox.Show("Empty Input not allowed!", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If

		Dim NotFirst, HasDot, HasSign, DigitAfterDot, HasNumber As Boolean
		NotFirst = False
		HasDot = False
		HasSign = False
		DigitAfterDot = False
		HasNumber = False
		For Each c As Char In str
			If Asc(c) >= Asc("0") AndAlso Asc(c) <= Asc("7") Then
				HasNumber = True
				If HasDot = True Then
					DigitAfterDot = True
				End If
			ElseIf Asc(c) = Asc("-") AndAlso NotFirst = False AndAlso HasSign = False Then
				HasSign = True
			ElseIf Asc(c) = Asc("+") AndAlso NotFirst = False AndAlso HasSign = False Then
				HasSign = True
			ElseIf Asc(c) = Asc(".") AndAlso HasDot = False Then
				HasDot = True
			Else
				MessageBox.Show("Invalid/Disallowed Character!" + " """ + c.ToString + """", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return False
			End If
			NotFirst = True
		Next
		If DigitAfterDot = False AndAlso HasDot = True Then
			MessageBox.Show("Number Incomplete. No digit found after Decimal!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		If HasNumber = False Then
			MessageBox.Show("Number did not seem to have any Digit(0-7)!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		'Input correct as all cases done and accounted for
		'Input still unable to process , in inputs 
		Return True
	End Function
End Module
