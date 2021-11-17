Module Module1

    Sub Main()
        Dim count As Integer
        Dim char1 As Char
        Dim Char2 As Char
        Dim str1, str2 As String

        Char2 = ""
        str1 = ""
        count = 0
        char1 = ""
        str2 = ""

        Console.Write("Enter a string you want to manipulate: ")
        str1 = Console.ReadLine

        char1 = Left(str1, 1)
        For count = 2 To Len(str1)
            Char2 = Mid(str1, count, 1)
            If Char2 = char1 Then
                str2 = str2 + "*"
            Else
                str2 = str2 + Char2
            End If
        Next

        Console.Write("The final string is: " + char1 + str2)
        Console.ReadKey()
    End Sub

End Module
