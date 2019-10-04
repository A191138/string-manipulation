Module Module1

    Sub Main()
        Dim pangramstr As String
        Dim pangram As Boolean
        Dim character As Integer
        Dim letter As Char

        pangramstr = ""
        pangram = False

        letter = ""


       
        Console.WriteLine("please enter a pangram")
        pangramstr = Console.ReadLine

        If Len(pangramstr) >= 26 Then
            pangram = True
        End If

        pangramstr = UCase(pangramstr)
        Console.WriteLine(pangramstr)

        For character = 65 To 90
            letter = Chr(character)
            REM Console.WriteLine(letter)

            If pangramstr.Contains(letter) Then
                pangram = True
            Else
                pangram = False
                Exit For

            End If

        Next
        Console.WriteLine("IS STRING PANGRAM = " & pangram)

        Console.ReadKey()
    End Sub

End Module
