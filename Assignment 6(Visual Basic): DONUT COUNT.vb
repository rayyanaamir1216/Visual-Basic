Module Module1

    Sub Main()
        'DECLERATION
        Dim Int As Integer
        Dim Donuts As Boolean

        'INITIALISATION
        Int = 0
        Donuts = True

        'PROCEDURE

        Console.Write("Input Number: ")
        Int = Console.ReadLine

        If Int > 1 And Int < 10 Then
            Donuts = True
        End If

        If Int > 9 Then
            Donuts = False
        End If

        'OUTPUT

        If Donuts = True Then
            Console.WriteLine("Number of Donuts: " & Int)
            Console.ReadKey()
        Else
            Console.WriteLine("Number of Donuts: Many")
            Console.ReadKey()
        End If
    End Sub

End Module
