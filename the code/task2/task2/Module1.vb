Module Module1

    Sub Main()
        Dim str1, str2, n1, n2 As String

        str1 = ""
        str2 = ""
        n1 = ""
        n2 = ""

        Console.Write("Please input first name:")
        str1 = Console.ReadLine()
        Console.Write("Please input second name:")
        str2 = Console.ReadLine()

        n1 = Left(str1, str1.IndexOf(" "))
        n2 = Right(str2, Len(str2) - str2.IndexOf(" "))

        Console.Write("Full new name: " & n1 & " " & n2)
        Console.ReadKey()
    End Sub

End Module
