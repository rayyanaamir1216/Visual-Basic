Module Module1

    Sub Main()
        'DECLARATION
        Dim str1, Alpha As String
        Dim I As Integer
        Dim char1 As Char
        Dim Pg As Boolean

        'INITIALISATION
        str1 = ""
        Alpha = "abcdefghijklmnopqrstuvwxyz"
        I = 0
        char1 = ""
        Pg = True

        'PROCEDURE
        Console.Write("Input String: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For I = 1 To Len(Alpha)
            char1 = Mid(Alpha, I, 1)
            If InStr(str1, char1) = 0 Then
                Pg = False
                Exit For
            End If
        Next

        If Pg = True Then
            Console.WriteLine("This String is a Pangram! :)")

        Else
            Console.WriteLine("This string is not a Pangram! :(")

        End If
        Console.ReadKey()

    End Sub

End Module
