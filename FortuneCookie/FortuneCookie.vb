﻿'Justin Bell
'RCET0265
'Fall 2024
'Fortune Cookie
'https://github.com/ju8t1n203/FortuneCookie/tree/master

Option Compare Text
Option Explicit On
Option Strict On

Module FortuneCookie

    Sub Main()
        Dim userinput As String

        Do
            Dim rand As New Random(DateTime.Now.Millisecond)                    'creates random number
            Dim randomNumber As Integer = rand.Next(1, 6)
            Console.Clear()

            Select Case randomNumber                                            'a wisdom is selected based off the random number
                Case 1
                    Console.WriteLine("""The best way To predict the future Is To create it."" - Peter Drucker")
                Case 2
                    Console.WriteLine("""The journey of a thousand miles begins with one step."" - Lao Tzu")
                Case 3
                    Console.WriteLine("""Happiness Is Not something ready-made. It comes from your own actions"" - Dalai Lama")
                Case 4
                    Console.WriteLine("""The only True wisdom Is In knowing you know Nothing."" - Socrates")
                Case 5
                    Console.WriteLine("""In the middle of difficulty lies opportunity."" - Albert Einstein")
                Case Else
                    Console.WriteLine("ye broke it")
            End Select

            Console.WriteLine()                                                 'user can quit the program or get another wisdom
            Console.WriteLine("Press enter for new fortune or press ""Q"" to quit.")
            userinput = Console.ReadLine()

            If userinput = "q" Then
                Exit Do
            End If

        Loop

    End Sub

End Module
