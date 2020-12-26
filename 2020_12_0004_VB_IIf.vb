Module Module1

    Sub Main()

        Dim userInputs As String
        Console.WriteLine("Choose  the lucky number, either 1 or 2")
        userInputs = Console.ReadLine()
        Console.WriteLine(IIf(userInputs = 1, "You  got first prize in the Game", "You got second prize in the Game"))

        ' IIf(Expression As Boolean,TruePart As Object,FalsePart As Object)

        Dim message As String = IIf(userInputs = 1, "House", "CAR")
        Console.WriteLine("You won {0}!", message) ' for getting the 0 th element
        Console.ReadLine()

    End Sub

End Module
