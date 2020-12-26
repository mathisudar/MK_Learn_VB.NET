Module Module1

    Sub Main()

        Dim userInputs As String
        Dim message As String = ""

        Console.WriteLine("Choose your lucky numbers 1 or 2 or 3")
        userInputs = Console.ReadLine()

        If userInputs = 1 Then
            message = "You have choosen 1 and you won a House!"

        ElseIf userInputs = 2 Then
            message = "You have choosen 2 and you won a Car!"

        ElseIf userInputs = 3 Then
            message = "You have choosen 3 and you won a Bike!"

        End If

        Console.WriteLine(message)
        Console.ReadLine()


    End Sub

End Module
