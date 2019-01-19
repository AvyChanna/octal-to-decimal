Module convertor

    Function convertDec(ByVal str As String) As String

		'split into 2 halves before decimal and after decimal
		Dim befDec, aftDec, aftDec2, befDec2 As String
		befDec = ""
        befDec2 = ""
        aftDec = ""
        aftDec2 = ""

        Dim foundDot As Boolean = False
		For Each c As Char In str
			If c = "." Then
				foundDot = True
			ElseIf c = "+" Or c = "-" Then
				Continue For
			ElseIf foundDot Then
				aftDec += c
			Else
				befDec += c
			End If
		Next
		If aftDec = "" Then
			aftDec = "0"
		End If
		If befDec = "" Then
			befDec = "0"
		End If
		aftDec2 = aftDec
        befDec2 = befDec
        '*********************************initialisations*********************************************

        Dim resBefDec, multiplicant, remainder As System.Numerics.BigInteger
        Dim resAftDec As String = "0"
        Dim carry As Integer = 0
        Dim count As Integer = 0

        multiplicant = 1
        resBefDec = 0
        resAftDec = "0"
        remainder = 0

        '*****************************conversion before decimal*****************************************

        For Each c As Char In befDec.Reverse
            resBefDec += multiplicant * (Asc(c) - Asc("0"))
            multiplicant *= 8
        Next

        '******************************conversion after decimal*****************************************

        For Each c As Char In (aftDec.Remove(0, 1)).Reverse
            resAftDec = supportFunc(resAftDec, count, c)
        Next

        If aftDec(0) = "0" Then
            resAftDec = supportFunc(resAftDec, count, "8").Remove(0, 1)
        Else
            resAftDec = supportFunc(resAftDec, count, aftDec(0))
        End If

		'***********************************pretty return string*****************************************
		Dim result As String = ""
		If str.StartsWith("-") Then
			result = "-"
		End If
		result = result + resBefDec.ToString
		If System.Numerics.BigInteger.Parse(resAftDec) > 0 Then
			result = result + "." + resAftDec.TrimEnd(New Char() {"0"c})
		End If
		'writeExplanation(aftDec2,befDec2,result)
		Return result
    End Function

    Function supportFunc(ByVal resAftDec As String, ByRef count As Integer, ByVal c As Char) As String
        Dim temp As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(c)
        Dim curr As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(resAftDec)

        For i As Integer = 0 To count - 1
            temp *= 1000
        Next

        curr += temp
        count += 1
        Return (curr * 125).ToString
    End Function
	'Function writeExplanation(ByVal integral As String, ByVal fractional As String, ByVal result As String) As String
	'	Dim IntegralSize As Integer = Len(integral)
	'	Dim FractionalSize As Integer = Len(fractional)
	'	Dim RtfTemp As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Courier New;}}{\colortbl ;\red155\green0\blue211;\red128\green64\blue0;\red155\green187\blue89;\red0\green176\blue80;\red0\green77\blue187;\red255\green0\blue0;}\viewkind4\uc1\pard\sl240\slmult1\cf1\f0\fs20\lang9 "
	'	' Line 1
	'	For Each c As Char In integral
	'		RtfTemp = RtfTemp + c + "\tab "
	'	Next

	'	If System.Numerics.BigInteger.Parse(fractional) > 0 Then
	'		RtfTemp = RtfTemp + "\cf0 .\cf2"
	'		For Each c As Char In fractional
	'			RtfTemp = RtfTemp + "\tab " + c
	'		Next
	'	End If
	'	RtfTemp = RtfTemp + "\par\cf3"
	'	' Line 2
	'	For Each c As Char In integral
	'		RtfTemp = RtfTemp + "X\tab "
	'	Next

	'	If System.Numerics.BigInteger.Parse(fractional) > 0 Then
	'		RtfTemp = RtfTemp + "\cf0 .\cf2"
	'		For Each c As Char In fractional
	'			RtfTemp = RtfTemp + "\tab X"
	'		Next
	'	End If
	'	RtfTemp = RtfTemp + "\par\cf2 "
	'	' Line 3
	'	For c As Integer = IntegralSize - 1 To 0
	'		RtfTemp = RtfTemp + "8\super " + c.ToString + "\nosupersub\tab "
	'	Next

	'	If System.Numerics.BigInteger.Parse(fractional) > 0 Then
	'		RtfTemp = RtfTemp + "\cf0 .\cf2"
	'		For c As Integer = 1 To Len(fractional)
	'			RtfTemp = RtfTemp + "\tab 8\super -" + c.ToString + "\nosupersub"
	'		Next
	'	End If
	'	RtfTemp = RtfTemp + "\par\par\}"
	'	Return "0"
	'End Function
End Module
