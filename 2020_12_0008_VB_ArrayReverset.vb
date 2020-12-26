Module Module1

    Sub Main()

        Dim myNamesArray() As String = {"Mathan", "Anitha", "Tamil", "Hariharan", "Iniyan"}


        Console.WriteLine("##### Names in Order ########")
        For Each myName As String In myNamesArray
            Console.WriteLine(myName)
        Next


        Console.WriteLine("##### Names in Regular Order - Using For ########")

        For myNameIndex As Integer = 0 To myNamesArray.Length - 1
            Console.WriteLine(myNamesArray(myNameIndex))
        Next




        Console.WriteLine("##### Names in Reverse Order ########")
        Array.Reverse(myNamesArray)

        For Each myNameReverse As String In myNamesArray
            Console.WriteLine(myNameReverse)
        Next



        Console.WriteLine("##### Names in Reverse Order - Using For ########")

        For myNameIndex As Integer = 0 To myNamesArray.Length - 1
            Console.WriteLine(myNamesArray(myNameIndex))
        Next

        Console.ReadLine()


    End Sub

End Module
