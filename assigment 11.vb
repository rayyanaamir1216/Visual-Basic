Module Module1

    Sub Main()
        Dim str1 As String
        Dim firstpart As String
        Dim lastpart As String
        Dim posBad As Integer
        Dim posNot As Integer

        str1 = ""
        firstpart = ""
        lastpart = ""
        posBad = 0
        posNot = 0


        Console.Write("please enter srting: ")
        str1 = Console.ReadLine()
        posBad = InStr(str1, "bad")
        posNot = InStr(str1, "not")

        If posNot < posBad Then
            firstpart = Left(str1, posNot - 1)
            lastpart = Right(str1, Len(str1) - (posBad + 2))
        End If

        Console.WriteLine(firstpart & "good" & lastpart)
        Console.ReadKey()



    End Sub

End Module
