Module Module1

    Sub Main()
        Dim alpha, STR, alphachoose, CHK As String
        Dim l, i, j As Integer
        Dim AllSTR As Boolean

        alpha = "abcdefghijklmnopqrstuvwxyz"
        STR = ""
        l = 0
        i = 0
        j = 0
        alphachoose = ""
        CHK = ""
        AllSTR = True

        Console.Write("Enter string to process: ")
        STR = Console.ReadLine
        STR = LCase(STR)


        For i = 1 To Len(alpha)
            If InStr(STR, (Mid(alpha, i, 1))) = 0 Then AllSTR = False
            If AllSTR = False Then Exit For
        Next i


        If AllSTR = True Then
            Console.WriteLine("All letters are present")
        Else
            Console.WriteLine("All letters are NOT present.")
        End If

        Console.ReadKey()
    End Sub

End Module
