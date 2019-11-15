Module Module1

    Sub Main()
        Dim str, input As String
        Dim nextchar As Char
        Dim maxcount, count, n As Integer
        Dim maxchar As Char
        Dim charlist As New ArrayList
        Console.WriteLine("please enter a word")
        input = Console.ReadLine
        str = input.ToUpper()

        With charlist
            For Each c In "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray
                .Add(c)
            Next
        End With

        For n = 0 To 25
            nextchar = (charlist.Item(n).ToString)
            count = str.Split(nextchar).Length - 1
            Console.WriteLine(nextchar & "=" & count)
            If count > maxcount Then
                maxcount = count
                maxchar = nextchar
            End If
        Next

        Console.WriteLine("most repeated character is " & maxchar & " and occurring " & maxcount & " times")
        Console.ReadKey()

    End Sub

End Module
