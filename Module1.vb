Module Module1

    Sub Main()

        Dim timetable, answer

        Console.WriteLine("Which timetable do you want (1-12)?")

        timetable = Console.ReadLine

        For Counter As Integer = 1 To 12

            answer = Counter * timetable

            Console.WriteLine(Counter & "x" & timetable & "=" & answer)

        Next

        Console.Read()

    End Sub

End Module
