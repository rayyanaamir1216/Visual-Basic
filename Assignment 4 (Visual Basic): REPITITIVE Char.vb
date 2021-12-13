Module Module1

    Sub Main()


        'DECLARATION

        Dim str1, str2, C As String
        Dim Counter, Count As Integer


        'INIITALISATION

        str1 = ""
        str2 = ""
        C = ""
        Counter = 0
        Count = 0

        'PROCEDURE
        Console.Write("Enter string to search in: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to look and count for: ")
        C = Console.ReadLine

        For Counter = 1 To Len(str1)
            str2 = Mid(str1, Counter, 1)
            If UCase(str2) = UCase(C) Then
                Count = Count + 1
            End If
        Next

        'OUTPUT
        Console.WriteLine(Count)
        Console.ReadKey()
    End Sub

End Module
