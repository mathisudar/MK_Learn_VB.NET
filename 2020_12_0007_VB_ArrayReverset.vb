Module Module1

    Sub Main()

        Dim myTexts As String = "abcdefghij" & _
                                    "klmnopqrstuvwxyz"
        Dim myCharArray() As Char = myTexts.ToCharArray


        Console.WriteLine("Output:Regular Order")
        Console.WriteLine("-------------------------------")
        For Each mychar As Char In myCharArray
            Console.Write(mychar)
        Next
        Console.WriteLine()
        Console.WriteLine()



        Console.WriteLine("Output:Reverse Order")
        Console.WriteLine("-------------------------------")

        Array.Reverse(myCharArray)


        For Each myReverseChar As Char In myCharArray
            Console.Write(myReverseChar)
        Next

        Console.ReadLine()

    End Sub

End Module
