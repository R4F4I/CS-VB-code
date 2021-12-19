Module Module1

    Sub Main()
        Dim num As Integer

        Console.Write("Enter Number: ")
        num = Console.ReadLine

        If num > 10 Then
            Console.Write("number of Donuts : Many")
        ElseIf num < 10 Then
            Console.Write("number of Donuts : " & num)
        End If

        Console.ReadKey()
    End Sub

End Module
