Module Convertor
	' Converts a given octal number to decimal
	Function ConvertDec(ByVal Str As String) As String

		'split into 2 halves before decimal and after decimal
		Dim BefDec, AftDec As String
		BefDec = ""
		AftDec = ""

		Dim FoundDot As Boolean = False
		For Each C As Char In Str
			If C = "." Then
				FoundDot = True
			ElseIf C = "+" Or C = "-" Then
				Continue For
			ElseIf FoundDot Then
				AftDec += C
			Else
				BefDec += C
			End If
		Next
		If AftDec = "" Then
			AftDec = "0"
		End If
		If BefDec = "" Then
			BefDec = "0"
		End If
		'*********************************initialisations*********************************************

		Dim ResBefDec, Multiplicant As System.Numerics.BigInteger
		Dim ResAftDec As String = "0"
		Dim Count As Integer = 0

		Multiplicant = 1
		ResBefDec = 0
		ResAftDec = "0"

		'*****************************conversion before decimal*****************************************

		For Each C As Char In BefDec.Reverse
			ResBefDec += Multiplicant * (Asc(C) - Asc("0"))
			Multiplicant *= 8
		Next

		'******************************conversion after decimal*****************************************

		For Each C As Char In (AftDec.Remove(0, 1)).Reverse
			ResAftDec = SupportFunc(ResAftDec, Count, C)
		Next

		If AftDec(0) = "0" Then
			ResAftDec = SupportFunc(ResAftDec, Count, "8").Remove(0, 1)
		Else
			ResAftDec = SupportFunc(ResAftDec, Count, AftDec(0))
		End If

		'***********************************pretty return string*****************************************
		Dim Result As String = ""
		If Str.StartsWith("-") Then
			Result = "-"
		End If
		Result = Result + ResBefDec.ToString
		If System.Numerics.BigInteger.Parse(ResAftDec) > 0 Then
			Result = Result + "." + ResAftDec.TrimEnd(New Char() {"0"c})
		End If
		Return Result
	End Function

	Function SupportFunc(ByVal ResAftDec As String, ByRef Count As Integer, ByVal C As Char) As String
		Dim Temp As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(C)
		Dim Curr As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(ResAftDec)

		For I As Integer = 0 To Count - 1
			Temp *= 1000
		Next

		Curr += Temp
		Count += 1
		Return (Curr * 125).ToString
	End Function

End Module
