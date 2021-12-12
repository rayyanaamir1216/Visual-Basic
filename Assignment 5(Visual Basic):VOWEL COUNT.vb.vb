Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As Char
        Dim Vowels, i, Char2, char3, char4, char5, char6 As Integer

        str1 = ""
        char1 = ""
        Char2 = Asc("a")
        char3 = Asc("e")
        char4 = Asc("i")
        char5 = Asc("o")
        char6 = Asc("u")
        Vowels = 0
        i = 0


        Console.Write("Enter String: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If Asc(char1) = Char2 Or
            Asc(char1) = char3 Or
            Asc(char1) = char4 Or
            Asc(char1) = char5 Or
            Asc(char1) = char6 Then
                Vowels = Vowels + 1
            End If
        Next
        If Vowels = 0 Then
            Console.WriteLine("No Vowel Found")
            Console.ReadKey()
        Else
            Console.WriteLine("Vowel Count: " & Vowels)
            Console.ReadKey()
        End If

    End Sub

End Module
