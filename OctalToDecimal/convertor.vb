Module convertor

    Function convertDec(ByVal str As String) As String

        'split into 2 halves before decimal and after decimal
        Dim befDec, aftDec As String
        befDec = ""
        aftDec = ""

        Dim foundDot As Boolean = False
        For Each c As Char In str
            If c = "." Then
                foundDot = True
            ElseIf foundDot Then
                aftDec += c
            Else
                befDec += c
            End If
        Next

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

        If System.Numerics.BigInteger.Parse(resAftDec) > 0 Then
            Return resBefDec.ToString + "." + resAftDec
        Else
            Return resBefDec.ToString
        End If

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

End Module
