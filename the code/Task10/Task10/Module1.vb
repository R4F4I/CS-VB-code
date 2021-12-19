Module Module1

    Sub Main()
        Dim str, chking As String
        chking = ""

        Console.Write("input string: ")
        str = Console.ReadLine()
        chking = Right(str, 3)

        If Len(str) < 3 Then
            Console.Write(str)
        ElseIf chking = "ing" Then
            Console.Write(str & "ly")
        Else : Console.Write(str & "ing")
        End If
        Console.ReadKey()

    End Sub

End Module
