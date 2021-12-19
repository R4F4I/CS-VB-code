Module Module1

    Sub Main()
        Dim str1, str2, tstr1, tstr2, reststr1, reststr2, newstr1, newstr2 As String
        str1 = ""
        str2 = ""

        tstr1 = ""
        tstr2 = ""

        reststr1 = ""
        reststr2 = ""

        newstr1 = ""
        newstr2 = ""

        Console.Write("Please input first word:")
        str1 = Console.ReadLine()

        Console.Write("Please input second word:")
        str2 = Console.ReadLine()

        tstr1 = Left(str1, 2)
        tstr2 = Left(str2, 2)

        reststr1 = Mid(str1, 3, Len(str1))
        reststr2 = Mid(str2, 3, Len(str2))

        newstr1 = tstr1 & reststr2
        newstr2 = tstr2 & reststr1

        Console.Write("New Word: " & newstr1 & " " & newstr2)

        Console.ReadKey()

    End Sub

End Module
