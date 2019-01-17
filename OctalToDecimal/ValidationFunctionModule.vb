Module ValidationFunctionModule
    Function validateInput(ByVal str As String) As Boolean
        Dim notFirst, hasDot, hasSign As Boolean
        notFirst = False
        hasDot = False
        hasSign = False
        System.Console.WriteLine(str)
        For Each c As Char In str
            System.Console.WriteLine(c)
            If Asc(c) >= Asc("0") AndAlso Asc(c) <= Asc("7") Then
            ElseIf Asc(c) = Asc("-") AndAlso notFirst = False AndAlso hasSign = False Then
                hasSign = True
            ElseIf Asc(c) = Asc("+") AndAlso notFirst = False AndAlso hasSign = False Then
                hasSign = True
            ElseIf Asc(c) = Asc(".") AndAlso hasDot = False Then
                hasDot = True
            Else
                'input incorrect return false.
                Return False
            End If
            notFirst = True
        Next

        'input correct as all cases done and accounted for
        'input still unable to process , in inputs 
        Return True
    End Function
End Module
