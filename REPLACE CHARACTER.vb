Module Module1
    Sub Main()

        Dim str1, str2 As String
        Dim char1, char2, nextchar As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        nextchar = ""

        Console.WriteLine("please enter a string")
        str1 = Console.ReadLine

        Console.WriteLine("please enter the character to be replaced")
        char1 = Console.ReadLine

        Console.WriteLine("please enter a character to replace with")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar = char1 Then
                str2 = str2 & char2
            Else
                str2 = str2 & nextchar
            End If
        Next
        Console.WriteLine("final string is " & str2)
        Console.ReadKey()

    End Sub
End Module
