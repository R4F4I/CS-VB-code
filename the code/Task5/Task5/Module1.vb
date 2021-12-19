Module Module1

    Sub Main()
        Dim vowel, chk, str As String
        Dim i, j, c As Integer

        vowel = "aeiou"
        i = 0
        j = 0
        c = 0
        str = ""
        chk = ""


        Console.Write("input string: ")
        str = Console.ReadLine
        For i = 1 To Len(str)
            chk = Mid(str, i, 1)
            For j = 1 To Len(vowel)
                If Mid(vowel, j, 1) = chk Then
                    c = c + 1
                End If

            Next
        Next
        Console.Write("no. of vowels is: " & c)
        Console.ReadKey()
    End Sub

End Module
