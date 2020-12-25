Module Module1

    Sub Main()

        Dim x As Integer = 7
        Dim y As Integer = 3

        Dim myString1 As String = 12
        Dim myString2 As String = 8

        Dim myStringAdd As String = myString1 + myString2
        Dim myStringAdd2 As Integer = CInt(myString1) + CInt(myString2)


        Console.WriteLine(CStr(x) & CStr(y)) ' ans: 73
        Console.WriteLine(myStringAdd) 'ans: 128
        Console.WriteLine(myStringAdd2) 'ans: 20

        Console.ReadLine()

    End Sub

End Module
