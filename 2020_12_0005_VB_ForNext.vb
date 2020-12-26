Module Module1

    Sub Main()

        For index = 10 To 1 Step -1
            If index = 6 Then
                Console.WriteLine("Found 6 and Exiting Here!")
                Exit For

            End If

            Console.WriteLine(index)

        Next

        Console.ReadLine()

    End Sub

End Module
