﻿Module Grahics
	' Generates RTF formatted text
	Function GenerateExplanation(ByVal Str As String, ByVal Result As String) As String
		' Returns RTF text to be added to rtfbox, all formatted nicely


		' *RTF CHEATSHEET*
		' \tab = tabspace
		' \cf0 = normal black colour
		' \cf1 = purple
		' \cf2 = brown
		' \cf3 = lightgreen
		' \cf4 = green
		' \cf5 = blue
		' \cf6 = red
		' \par = para ending
		' \super = superscript
		' \nosupersub = normal text
        Dim NegativeNumber As Boolean = False
        If Result.StartsWith("-") Then
            NegativeNumber = True
        End If

        Dim Integral, Fractional As String
        Integral = ""
        Fractional = ""
        ' Find integral and fractional part of """"given input"""" (absolutely no trimming/slicing)
        Dim FoundDot As Boolean = False
        For Each C As Char In Str

            If C = "." Then
                FoundDot = True
            ElseIf C = "+" Or C = "-" Then
                Continue For
            ElseIf FoundDot Then
                Fractional += C
            Else
                Integral += C
            End If
        Next
        If Integral = "" Then
            Integral = "0"
        End If

        ' Start RTF string. Subsequently, strings will append to it one-by-one 
        Dim RtfTemp As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Courier New;}}{\colortbl ;\red155\green0\blue211;\red128\green64\blue0;\red255\green0\blue128;\red0\green64\blue0;\red0\green77\blue187;\red255\green0\blue0;}\viewkind4\uc1\pard\sl240\slmult1\cf1\f0\fs20\lang9\line\tab"
        Dim IntegralCounter As Integer = Len(Integral)
        Dim s1, s2 As String
        s1 = ""
        s2 = ""

        ' Line 1(number) ,Line 2(cross)
        Dim Counter As Integer = 1
        For Each C As Char In Integral
            s1 += " " + C + "\tab"
            s2 += " X" + "\tab"
        Next

        If FoundDot = True Then
            s1 += "\cf0 .\cf2"
            s2 += "\cf0 .\cf3"
            For Each C As Char In Fractional
                s1 += "\tab " + C
                s2 += "\tab X"
            Next
        End If

        RtfTemp = RtfTemp + s1 + "\par\cf3\tab" + s2 + "\par\cf2\tab"

        ' Line 3(8-power)
        For C As Integer = IntegralCounter - 1 To 0 Step -1
            RtfTemp = RtfTemp + " 8\super " + C.ToString + "\nosupersub\tab"
        Next

        If FoundDot = True Then
            RtfTemp = RtfTemp + "\cf0 .\cf1"
            For C As Integer = 1 To Len(Fractional)
                RtfTemp = RtfTemp + "\tab 8\super -" + C.ToString + "\nosupersub"
            Next
        End If

        RtfTemp = RtfTemp + "\par\par\pard\sa200\sl240\slmult1\cf1  = "

        ' Line 4 (brute-force-multiply)
        If NegativeNumber = True Then
            RtfTemp = RtfTemp + "\cf5 -1\cf0 ["
        End If

        Dim AtleastOneMult As Boolean = False
        Dim AtleastOneMultInIntegral As Boolean = False
        Dim AtleastOneZero As Boolean = False

        ' Add blue + between two multiplications
        Dim FirstOut As Boolean = False
        For Each C As Char In Integral
            If FirstOut = True Then
                RtfTemp = RtfTemp + "\cf5  + "
            End If
            IntegralCounter = IntegralCounter - 1
            If Asc(C) = Asc("0") Then
                RtfTemp = RtfTemp + "\cf6 (\strike 0 X 8\super\strike0 " + IntegralCounter.ToString + "\nosupersub )"
                AtleastOneZero = True
            Else
                AtleastOneMult = True
                AtleastOneMultInIntegral = True
                RtfTemp = RtfTemp + "\cf4 (" + C.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
            End If
            FirstOut = True
        Next

        Dim FractionalCounter As Integer = 1
        For Each C As Char In Fractional
            If Asc(C) = Asc("0") Then
                RtfTemp = RtfTemp + "\cf5  + \cf6 (\strike 0 X 8\super\strike0 -" + FractionalCounter.ToString + "\nosupersub )"
                AtleastOneZero = True
            Else
                AtleastOneMult = True
                RtfTemp = RtfTemp + "\cf5  + \cf4 (" + C.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
            End If
            FractionalCounter = FractionalCounter + 1
        Next

        If NegativeNumber = True Then
            RtfTemp = RtfTemp + "\cf0 ]"
        End If

        RtfTemp += "\par"

        ' Line 5(smart-add)
        ' This line gets printed only if there is atleast one multiplication and atleast one strikeout
        ' Below 2 FOR loops determine if this line must be printed
        ' AtleastOneMult sees that there is atleast one non-zero character to print, otherwise result is directly zero
        ' AtlaestOneZero sees that there is atleast one zero, otherwise we do not need any simplification

        ' NegativeNumber adds support for negative numbers
        If AtleastOneMult = True AndAlso AtleastOneZero = True Then
            RtfTemp = RtfTemp + "\cf1  = "
            If NegativeNumber = True Then
                RtfTemp = RtfTemp + "\cf5 -1\cf0 ["
            End If
            IntegralCounter = Len(Integral)
            FirstOut = False
            ' Print Integral Part
            For Each C As Char In Integral
                IntegralCounter = IntegralCounter - 1
                If FirstOut = False Then
                    If Asc(C) <> Asc("0") Then
                        RtfTemp = RtfTemp + "\cf4 (" + C.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
                        FirstOut = True
                    End If
                Else
                    If Asc(C) <> Asc("0") Then
                        RtfTemp = RtfTemp + "\cf5  + " + "\cf4 (" + C.ToString + " X 8\super " + IntegralCounter.ToString + "\nosupersub )"
                    End If
                End If
            Next

            FractionalCounter = 1
            ' Print fractional part
            For Each C As Char In Fractional
                If Asc(C) <> Asc("0") Then
                    If FirstOut = False AndAlso AtleastOneMultInIntegral = False Then
                        RtfTemp = RtfTemp + "\cf4 (" + C.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
                        FirstOut = True

                    Else
                        RtfTemp = RtfTemp + "\cf5  + \cf4 (" + C.ToString + " X 8\super -" + FractionalCounter.ToString + "\nosupersub )"
                        FirstOut = True
                    End If
                End If
                FractionalCounter = FractionalCounter + 1
            Next
            If NegativeNumber = True = True Then
                RtfTemp = RtfTemp + "\cf0 ]"
            End If
            RtfTemp = RtfTemp + "\par"
        End If

        ' Line 6 and/or 7(result)
        If NegativeNumber = True Then
            RtfTemp = RtfTemp + "\cf1  = \cf5 -1\cf0 [\cf4 " + Result.TrimStart(New Char() {"-"c}) + "\cf0 ]\par"
        End If
        RtfTemp = RtfTemp + "\cf1  = \cf5 " + Result + "\par }"

        Return RtfTemp
    End Function
End Module
