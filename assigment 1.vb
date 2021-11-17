Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim count As Integer
        Dim char1 As Char
        Dim pos As Integer
        Dim anagram As Boolean

        pos = 0
        str1 = ""
        str2 = "abcdefghijklmnopqrstuvwxyz"
        count = 0
        char1 = ""
        anagram = True

        Console.Write("Enter a string to find wether it is an anagram or not: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        For count = 1 To Len(str1)
            char1 = Mid(str1, count, 1)
            pos = InStr(char1, str2)
            If pos = 0 Then
                anagram = False
                Exit For
            End If
        NEXT
        If anagram = False Then
            Console.Write("Entered string is not an anagram")
            Console.ReadKey()
        Else
            Console.Write("Entered string is an anagram")
            Console.ReadKey()

        End If
    End Sub

End Module
