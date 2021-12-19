Module Module1

    Sub Main()
        Dim str, befnot, aftbad As String
        Dim notpos, i, j, badpos As Integer
        Console.Write("Please input sentence where the word ''not'' is present before the word ''bad'': ")
        str = Console.ReadLine()
        For i = 1 To Len(str) - 3
            If Mid(str, i, 3) = "not" Then
                notpos = i - 1
                If notpos > 0 Then
                    Exit For
                End If
            End If
        Next



        For j = notpos To Len(str) - 3
            If Mid(str, j, 3) = "bad" Then
                badpos = j + 2
                If badpos > 0 Then
                    Exit For
                End If

            End If

        Next
        befnot = Left(str, notpos)
        aftbad = Right(str, (Len(str) - badpos) - 1)

        Console.Write(befnot & "good " & aftbad)



        Console.ReadKey()
    End Sub

End Module
