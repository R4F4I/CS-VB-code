﻿Module Module1

    Sub Main()
        Dim str, str1 As String
        Dim chk As Char
        Dim Num, l, n, c, i, j, nchk As Integer


        nchk = 0
        str = ""
        chk = ""
        l = 0
        n = 0
        c = 0
        i = 0
        j = 1

        Console.Write("Input String:")
        str = Console.ReadLine()

        Console.Write("Input character you want count of:")
        str1 = Console.ReadLine()

        For i = 1 To Len(str)
            If Mid(str, i, 1) = str1 Then
                Num = Num + 1
            End If
        Next

        For i = 1 To Len(str)
            chk = Mid(str, i, 1)
            nchk = Convert.ToByte(chk)
            If nchk >= 32 And nchk <= 47 Then
                c = c + 1
            ElseIf nchk >= 91 And nchk <= 96 Then
                c = c + 1
            ElseIf nchk >= 123 And nchk <= 126 Then
                c = c + 1
            ElseIf nchk >= 58 And nchk <= 64 Then
                c = c + 1
            ElseIf nchk >= 48 And nchk <= 57 Then
                n = n + 1
            ElseIf nchk >= 65 And nchk <= 90 Then
                l = l + 1
            ElseIf nchk >= 97 And nchk <= 122 Then
                l = l + 1


            End If


        Next

        If Num > 0 Then
            Console.WriteLine("no. of selected character is: " & Num)
        ElseIf Num = 0 Then
            Console.WriteLine("selected character not found!")
        End If

        If c > 0 Then
            Console.WriteLine("no. of characters: " & c)
        End If

        If l > 0 Then
            Console.WriteLine("no. of letters: " & l)
        End If

        If n > 0 Then
            Console.WriteLine("no. of numbers: " & n)
        End If

        Console.ReadKey()
    End Sub

End Module
