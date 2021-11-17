Module Module1

    Sub Main()
        Dim str1 As String
        Dim alphaC As Integer
        Dim numberC As Integer
        Dim sCharC As Integer
        Dim cChar1 As Char
        Dim count As Integer

        str1 = ""
        alphaC = 0
        numberC = 0
        sCharC = 0
        cChar1 = ""
        count = 0

        Console.Write("Enter a string to know the number of alphabets, numbers, special charater: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)


        For count = 1 To Len(str1)
            cChar1 = Mid(str1, count, 1)
            If Asc(cChar1) > 64 And Asc(cChar1) < 88 Then
                alphaC = alphaC + 1
            ElseIf Asc(cChar1) > 47 And Asc(cChar1) < 58 Then
                numberC = numberC + 1
            Else : sCharC = sCharC + 1

            End If

        Next
        Console.Write("The total number of alphabets, numbers and special characters  in the string are: " & alphaC & "," & numberC & "," & sCharC)
        Console.ReadKey()


    End Sub

End Module
