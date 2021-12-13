Module Module1

    Sub Main()

        'DECLARATION

        Dim str As String
        Dim char1 As Char
        Dim space, LoopCount, Letter, Cap, Special, spec As Integer

        'INITIALISATION

        str = ""
        char1 = ""
        Letter = 0
        LoopCount = 0
        Cap = 0
        Special = 0
        space = 0
        spec = 0

        'PROCEDURE

        Console.Write("INPUT STRING: ")
        str = Console.ReadLine
        For LoopCount = 1 To Len(str)
            char1 = Mid(str, LoopCount, 1)
            If Asc(char1) > 64 And Asc(char1) < 90 Then
                Letter = Letter + 1
            End If
            If Asc(char1) > 96 And Asc(char1) < 123 Then
                Cap = Cap + 1
            End If

            If Asc(char1) > 47 And Asc(char1) < 58 Then
                Special = Special + 1
            End If

            If Asc(char1) = 32 Then
                space = space + 1
            End If

            If Asc(char1) > 32 And Asc(char1) <= 47 Or
               Asc(char1) > 58 And Asc(char1) <= 64 Or
               Asc(char1) > 91 And Asc(char1) <= 96 Then
                spec = spec + 1
            End If

            'OUTPUT

        Next
        Console.WriteLine("CHARACTER COUNT")
        Console.WriteLine("Small Letter: " & Cap)
        Console.WriteLine("Capital Letter: " & Letter)
        Console.WriteLine("Digits: " & Special)
        Console.WriteLine("Space Count: " & space)
        Console.WriteLine("Other: " & spec)
        Console.WriteLine("Loop Count: " & LoopCount)
        Console.ReadKey()
    End Sub

End Module
