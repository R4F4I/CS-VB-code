Module Module1

    Sub Main()
        Dim str, repeated As String
        Dim oneword As Char
        Dim count(128), amt(128), bigamt, wordpos As Integer

        repeated = ""

        Console.Write("input string where it is clear that there is a most repeating value: ")
        str = Console.ReadLine
        str = LCase(str)
        For i = 1 To Len(str)
            oneword = Mid(str, i, 1)
            wordpos = Convert.ToByte(oneword)
            count(wordpos) = count(wordpos) + 1

        Next
        bigamt = 0
        For i = 0 To 128
            If bigamt < count(i) Then
                bigamt = count(i)
                repeated = Convert.ToChar(i)

            End If

        Next
        Console.WriteLine("the most repeated value is '" & repeated & "' which is repeated " & bigamt & " times")
        Console.ReadKey()
    End Sub

End Module
