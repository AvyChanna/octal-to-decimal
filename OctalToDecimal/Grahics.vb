Module Grahics
	Function writeExplanation(ByVal str As String, ByVal Result As String) As String
		Dim Integral, Fractional As String
		Integral = ""
		Fractional = ""

		Dim FoundDot As Boolean = False
		For Each c As Char In str

			If c = "." Then
				FoundDot = True
			ElseIf c = "+" Or c = "-" Then
				Continue For
			ElseIf FoundDot Then
				Fractional += c
			Else
				Integral += c
			End If
		Next
		If Fractional = "" Then
			Fractional = "0"
		End If
		If Integral = "" Then
			Integral = "0"
		End If
		Dim IntegralCounter As Integer = Len(Integral)


		Dim RtfTemp As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Courier New;}}{\colortbl ;\red155\green0\blue211;\red128\green64\blue0;\red155\green187\blue89;\red0\green176\blue80;\red0\green77\blue187;\red255\green0\blue0;\red255\green192\blue0;}\viewkind4\uc1\pard\sl240\slmult1\cf1\f0\fs20\lang9\tab "
		' Line 1(number)
		For Each c As Char In Integral
			RtfTemp = RtfTemp + c + "\tab "
		Next

		If FoundDot = True Then
			RtfTemp = RtfTemp + "\cf0 .\cf2"
			For Each c As Char In Fractional
				RtfTemp = RtfTemp + "\tab " + c
			Next
		End If
		RtfTemp = RtfTemp + "\par\cf3\tab "
		' Line 2(XXX)
		For Each c As Char In Integral
			RtfTemp = RtfTemp + "X\tab "
		Next

		If FoundDot = True Then
			RtfTemp = RtfTemp + "\cf0 .\cf3"
			For Each c As Char In Fractional
				RtfTemp = RtfTemp + "\tab X"
			Next
		End If
		RtfTemp = RtfTemp + "\par\cf2\tab "
		' Line 3(8-power)
		For c As Integer = 0 To IntegralCounter - 1
			Dim d As Integer = IntegralCounter - 1 - c
			RtfTemp = RtfTemp + "8\super " + d.ToString + "\nosupersub\tab "
		Next

		If FoundDot = True Then
			RtfTemp = RtfTemp + "\cf0 .\cf1"
			For c As Integer = 1 To Len(Fractional)
				RtfTemp = RtfTemp + "\tab 8\super -" + c.ToString + "\nosupersub"
			Next
		End If
		RtfTemp = RtfTemp + "\par\par\pard\sa200\sl240\slmult1\cf7  = "
		' Line 4 (brute-force-multiply)
		If Result.StartsWith("-") Then
			RtfTemp = RtfTemp + "\cf5 -1\cf0 ["
		End If
		IntegralCounter = Len(Integral)
		Dim FirstOut As Boolean = False
		For Each c As Char In Integral
			If FirstOut = True Then
				RtfTemp = RtfTemp + "\cf5  + "
			End If
			IntegralCounter = IntegralCounter - 1
			If Asc(c) = Asc("0") Then
				RtfTemp = RtfTemp + "\cf6 (\strike 0 X 8\super\strike0 " + IntegralCounter.ToString + "\nosupersub )"
			Else
				RtfTemp = RtfTemp + "\cf4 (" + c.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
			End If
			FirstOut = True
		Next

		Dim FractionalCounter As Integer = 1
		For Each c As Char In Fractional
			If Asc(c) = Asc("0") Then
				RtfTemp = RtfTemp + "\cf5  + \cf6 (\strike 0 X 8\super\strike0 -" + FractionalCounter.ToString + "\nosupersub )"
			Else
				RtfTemp = RtfTemp + "\cf5  + \cf4 (" + c.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
			End If
			FractionalCounter = FractionalCounter + 1
		Next
		If Result.StartsWith("-") Then
			RtfTemp = RtfTemp + "\cf0 ]"
		End If
		RtfTemp = RtfTemp + "\par"
		' Line 5(smart-add)
		Dim AtleastOneMult As Boolean = False
		Dim AtleastOneMultInIntegral As Boolean = False
		For Each c As Char In Integral
			If Asc(c) <> Asc("0") Then
				AtleastOneMultInIntegral = True
			End If
			If AtleastOneMultInIntegral = True Then
				Exit For
			End If
		Next
		AtleastOneMult = AtleastOneMultInIntegral
		If AtleastOneMultInIntegral = False Then
			For Each c As Char In Fractional
				If Asc(c) <> Asc("0") Then
					AtleastOneMult = True
				End If
				If AtleastOneMult = True Then
					Exit For
				End If
			Next
		End If
		If AtleastOneMult = True Then
			RtfTemp = RtfTemp + "\cf7  = "
			If Result.StartsWith("-") Then
				RtfTemp = RtfTemp + "\cf5 -1\cf0 ["
			End If
		End If
		IntegralCounter = Len(Integral)
		FirstOut = False
		For Each c As Char In Integral
			IntegralCounter = IntegralCounter - 1
			If FirstOut = False Then
				If Asc(c) <> Asc("0") Then
					RtfTemp = RtfTemp + "\cf4 (" + c.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
					FirstOut = True
				End If
			Else
				If Asc(c) <> Asc("0") Then
					RtfTemp = RtfTemp + "\cf5  + " + "\cf4 (" + c.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
				End If
			End If
		Next
		FractionalCounter = 1
		For Each c As Char In Fractional
			If Asc(c) <> Asc("0") Then
				If FirstOut = False AndAlso AtleastOneMultInIntegral = False Then
					RtfTemp = RtfTemp + "\cf4 (" + c.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
					FirstOut = True

				Else
					RtfTemp = RtfTemp + "\cf5  + \cf4 (" + c.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
					FirstOut = True
				End If
			End If
			FractionalCounter = FractionalCounter + 1
		Next
		If Result.StartsWith("-") = True AndAlso AtleastOneMult = True Then
			RtfTemp = RtfTemp + "\cf0 ]"
		End If
		If AtleastOneMult = True Then
			RtfTemp = RtfTemp + "\par"
		End If
		' Line 6(result)
		If Result.StartsWith("-") Then
			RtfTemp = RtfTemp + "\cf7  = \cf5 -1\cf0 [\cf4 " + Result.TrimStart(New Char() {"-"c}) + "\cf0 ]\par"
		End If
		RtfTemp = RtfTemp + "\cf7  = \cf5 " + Result + "\par }"




















		Return RtfTemp
	End Function
End Module
