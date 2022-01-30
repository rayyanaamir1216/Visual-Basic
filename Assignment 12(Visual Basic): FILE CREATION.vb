Module Module1

    Sub Main()
        Dim rollno As Integer
        Dim sname, scontact As String
        Dim sfee As Decimal
        Dim isfeepaid As Boolean

        Console.Write("enter roll number: ")
        rollno = Console.ReadLine
        Console.Write("enter Student name: ")
        sname = Console.ReadLine
        Console.Write("enter student contact: ")
        scontact = Console.ReadLine
        Console.Write("enter fee amount: ")
        sfee = Console.ReadLine
        Console.Write("is fee paid: ")
        isfeepaid = Console.ReadLine()


        FileOpen(1, "F:\srec.txt", OpenMode.Append)

        WriteLine(1, rollno)
        WriteLine(1, sname)
        WriteLine(1, scontact)
        WriteLine(1, sfee)
        WriteLine(1, isfeepaid)

        FileClose(1)












    End Sub

End Module
