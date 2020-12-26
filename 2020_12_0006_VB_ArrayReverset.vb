Module Module1

    Sub Main()

        Dim numbers(0 To 4) As Integer

        numbers(0) = 12
        numbers(1) = 21
        numbers(2) = 23
        numbers(3) = 32
        numbers(4) = 45

        '' get the 3rd element of the array
        Console.WriteLine("3rd Element:" & numbers(2))
        Console.ReadLine()


        'Iterating all the elements - For each
        Console.WriteLine("Iterating all the elements - For Each")


        For Each index As Integer In numbers
            Console.WriteLine(index)
        Next
        Console.ReadLine()



        'Iterating all the elements - For 
        Console.WriteLine("Iterating all the elements- For")

        For index = 0 To numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next
        Console.ReadLine()



        Array.Reverse(numbers)

        'Iterating all the elements  - Reverse Order- For 
        Console.WriteLine("Iterating all the elements - Reverse Order- For")

        For index = 0 To numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next
        Console.ReadLine()



        'Iterating all the elements - Reverse Order - For each
        Console.WriteLine("Iterating all the elements - Reverse Order- For Each")


        For Each index As Integer In numbers
            Console.WriteLine(index)
        Next
        Console.ReadLine()


    End Sub

End Module
