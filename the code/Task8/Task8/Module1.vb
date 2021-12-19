Module Module1

    Sub Main()
        Dim str, cen,outstr As String
        Dim i As Integer
        str = ""
        cen = ""


        Console.Write("Enter word to be censored: ")
        str = Console.ReadLine()
        str = LCase(str)
        cen = Left(str, 1)
        outstr = Left(str, 1)
        For i = 2 To Len(str)
            If Mid(str, i, 1) <> cen Then
                outstr = outstr & Mid(str, i, 1)
            ElseIf Mid(str, i, 1) = cen Then
                outstr = outstr & "*"


            End If
        Next
        Console.Write("censored version: " & outstr)
        Console.ReadKey()
    End Sub

End Module
