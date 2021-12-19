Module Module1

    Sub Main()
        Dim str, oneword, l, r As String
        Dim space As Integer

        Console.Write("input a string: ")
        str = Console.ReadLine
        space = str.IndexOf(" ")

        If Len(str) <= 2 Then
            Console.Write(Left(str, 1))

        ElseIf Len(str) > 2 And space = -1 Then
            l = Left(str, 2)
            r = Right(str, 2)
            Console.Write(l & r)

        ElseIf Len(str) > 2 And space > 0 Then
            oneword = Left(str, space)
            l = Left(oneword, 2)
            r = Right(oneword, 2)
            Console.Write(l & r)
            Console.ReadKey()
        End If
        Console.ReadKey()
    End Sub

End Module
