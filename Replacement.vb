Module Module1

    Sub Main()
        'DECLARATION
        Dim str, str2 As String
        Dim char1, char2, char3 As Char
        Dim count As Integer

        'INITIALISATION
        str = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        count = 0

        'PROCEDURE
        Console.Write("Enter Text: ")
        str = Console.ReadLine

        Console.Write("Enter Letter to Replacement: ")
        char1 = Console.ReadLine

        Console.Write("Replacement Letter: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str)
            char3 = Mid(str, count, 1)
            If char3 = char1 Then
                str2 = str2 + char2
            Else
                str2 = str2 + char3

            End If

        Next
        Console.Write("the new string is: " + str2)

        Console.ReadKey()


    End Sub

End Module
