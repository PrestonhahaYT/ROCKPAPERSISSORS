

Module Module1
    'preston
    '12/12/23
    Dim rand As New Random
    Dim usermoves(4), computermoves(4) As Integer
    Dim outcomes(4) As String
    Dim num As Integer
    Dim word As String

    Sub Main()
        Dim Input As Integer

        Console.WriteLine(".-. .-. .-. . .     .-. .-. .-. .-. .-.     .-. .-. .-. .-. .-. .-. .-. .-.
|(  | | |   |<      |-' |-| |-' |-  |(      `-. |    |  `-. `-. | | |(  `-.
' ' `-' `-' ' ` ,   '   ` ' '   `-' ' ' ,   `-' `-' `-' `-' `-' `-' ' ' `-'
    _______           _______               _______
---'   ____)      ---'   ____)____     ---'    ____)____
      (_____)               ______)               ______)
      (_____)               _______)           __________)
      (____)               _______)           (____)
---.__(___)       ---.__________)      ---.__(___)")

        For i As Integer = 0 To 4
            usermoves(i) = getvalidinput()
            computermoves(i) = COMPUTERMOVE()
            Console.WriteLine($"You Played {numtoword(usermoves(i))} the computer played {numtoword(computermoves(i))}")
            outcomes(i) = determineoutcome(usermoves(i), computermoves(i))
            Console.WriteLine($"You {outcomes(i)}")
        Next

        PRINTBOARD()


    End Sub
    Function getvalidinput()
        Dim num As Integer
        Dim input As String
        Dim Valid As Boolean = False


        Do
            Console.WriteLine("Enter a ""1"" for Rocka, Enter a ""2"" for Paper, Enter a ""3"" for Scissors")
            input = Console.ReadLine
            Integer.TryParse(input, num)
            If num <> 1 AndAlso num <> 2 AndAlso num <> 3 Then
                Valid = False
                Console.WriteLine("WRONG INPUT BUSTER!!!!!!!")
            Else
                Valid = True
            End If
        Loop While Not Valid

        Return num
    End Function
    Function COMPUTERMOVE()
        Dim guess As Integer = rand.Next(1, 4)
        Return guess
    End Function
    Function numtoword(num As Integer) As String
        If num = 1 Then
            word = "ROCKA"
        ElseIf num = 2 Then
            word = "PAPER"
        ElseIf num = 3 Then
            word = "Scissors"
        End If
        Return word
    End Function
    Function determineoutcome(userplay As Integer, compplay As Integer) As String


        Dim outcome As String = "Lost"
        If (userplay = 1 AndAlso compplay = 3) OrElse
       (userplay = 2 AndAlso compplay = 1) OrElse
        (userplay = 3 AndAlso compplay = 2) Then
            outcome = "won"
        ElseIf userplay = compplay Then

            outcome = "Tie"

        End If
        Return outcome
    End Function
    ''' <summary>
    ''' Prints Table With Reports
    ''' </summary>
    Sub PRINTBOARD()
        Console.WriteLine()
        Console.WriteLine("".PadRight(77, "#"))
        Console.WriteLine("{0}{1}{2}", "".PadLeft(23, "#"), " Rocka, Paper, Scissors Report ", "".PadRight(23, "#"))
        Console.WriteLine("".PadRight(77, "#"))
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "Round".PadRight(20), "|".PadRight(5), "User Played".PadRight(20), "|".PadRight(5), "Computer Played".PadRight(20), "|".PadRight(5), "Outcome".PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "1".PadRight(20), "|".PadRight(5), numtoword(usermoves(0)).ToString.PadRight(20), "|".PadRight(5), numtoword(computermoves(0)).ToString.PadRight(20), "|".PadRight(5), outcomes(0).PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "2".PadRight(20), "|".PadRight(5), numtoword(usermoves(0)).ToString.PadRight(20), "|".PadRight(5), numtoword(computermoves(1)).ToString.PadRight(20), "|".PadRight(5), outcomes(1).PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "3".PadRight(20), "|".PadRight(5), numtoword(usermoves(0)).ToString.PadRight(20), "|".PadRight(5), numtoword(computermoves(2)).ToString.PadRight(20), "|".PadRight(5), outcomes(2).PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "4".PadRight(20), "|".PadRight(5), numtoword(usermoves(0)).ToString.PadRight(20), "|".PadRight(5), numtoword(computermoves(3)).ToString.PadRight(20), "|".PadRight(5), outcomes(3).PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", "|".PadRight(5), "5".PadRight(20), "|".PadRight(5), numtoword(usermoves(0)).ToString.PadRight(20), "|".PadRight(5), numtoword(computermoves(4)).ToString.PadRight(20), "|".PadRight(5), outcomes(4).PadRight(20), "|")
        Console.WriteLine("".PadRight(90, "_"))
    End Sub

End Module
