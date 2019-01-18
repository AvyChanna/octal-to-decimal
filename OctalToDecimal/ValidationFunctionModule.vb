Module ValidationFunctionModule
	Function ValidateInput(ByVal str As String) As Boolean
		'Check string is not empty
		If str = "" Then
			MessageBox.Show("Please insert a number before clicking OK !", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		Dim NotFirst, HasDot, HasSign As Boolean
		NotFirst = False
		HasDot = False
		HasSign = False
		For Each c As Char In str
			If Asc(c) >= Asc("0") AndAlso Asc(c) <= Asc("7") Then
			ElseIf Asc(c) = Asc("-") AndAlso NotFirst = False AndAlso HasSign = False Then
				HasSign = True
			ElseIf Asc(c) = Asc("+") AndAlso NotFirst = False AndAlso HasSign = False Then
				HasSign = True
			ElseIf Asc(c) = Asc(".") AndAlso HasDot = False Then
				HasDot = True
			Else
				MessageBox.Show("Please check your number !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return False
			End If
			NotFirst = True
		Next

		'Input correct as all cases done and accounted for
		'Input still unable to process , in inputs 
		Return True
	End Function
End Module
