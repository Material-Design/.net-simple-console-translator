Module Module1

    Sub Main()
        'not the best example of using console with loops but it works
        Console.SetWindowSize(90, 30)
        Console.ForegroundColor = ConsoleColor.Green 'leet hacker green activated
        Console.Title = "Basic console translator- Created by GitHub: Material-Design"
        Dim opts As Integer 'only expecting a numerical value thus set as integer
        Dim word As String
        Dim English() As String = {"hello", "goodbye", "you", "and", "say", "my", "but", "name", "is"} 'english word table
        Dim French() As String = {"bonjour", "au revoir", "vous", "et", "aire", "ma", "acheter", "nom", "est"} 'french word table
        Dim runLoop = True 'boolean variable to control exit from outer while loop, when true continue loop and reprinting menue choices
        While runLoop 'loop!
            Console.WriteLine("----------------------") 'options menu
            Console.WriteLine("1 = Eng -> Fre")
            Console.WriteLine("2 = Fre -> Eng")
            Console.WriteLine("3 = Clear")
            Console.WriteLine("4 = Exit")
            Console.WriteLine("----------------------")
            Try 'try used incase user inputs invalid option
                Console.Write("Select an option: ")
                opts = Console.ReadLine 'user input as opts
                Console.WriteLine("----------------------")
                Select Case opts
                    Case 1 'if "1" is entered
                        Try 'try used to catch invalid english inputs
                            Console.Write("Enter a English word: ")
                            word = Console.ReadLine 'setting input from english word as word
                            Select Case word.ToLower 'ToLower to improve compatibility
                                Case English(0)
                                    Console.WriteLine("Translation = " & French(0) & " - press enter to continue")
                                Case English(1)
                                    Console.WriteLine("Translation = " & French(1) & " - press enter to continue")
                                Case English(2)
                                    Console.WriteLine("Translation = " & French(2) & " - press enter to continue")
                                Case English(3)
                                    Console.WriteLine("Translation = " & French(3) & " - press enter to continue")
                                Case English(4)
                                    Console.WriteLine("Translation = " & French(4) & " - press enter to continue")
                                Case English(5)
                                    Console.WriteLine("Translation = " & French(5) & " - press enter to continue")
                                Case English(6)
                                    Console.WriteLine("Translation = " & French(6) & " - press enter to continue")
                                Case English(7)
                                    Console.WriteLine("Translation = " & French(7) & " - press enter to continuee")
                                Case English(8)
                                    Console.WriteLine("Translation = " & French(8) & " - press enter to continue")
                                Case Else 'if not match to input is found then...
                                    Console.WriteLine("Invalid input - press enter to continue!")
                                    runLoop = True 'return to menu
                            End Select
                        Catch ex As Exception
                            Console.WriteLine(ex.Message) 'display error directly as a printed line
                            runLoop = True 'return to menu
                        End Try
                    Case 2 'if "2" is entered
                        Try 'try used to catch invalid french inputs
                            Console.Write("Enter a French word: ")
                            word = Console.ReadLine 'setting input from french word as word. 
                            Select Case word.ToLower 'ToLower to improve compatibility
                                Case French(0)
                                    Console.WriteLine("Translation = " & English(0) & " - press enter to continue")
                                Case French(1)
                                    Console.WriteLine("Translation = " & English(1) & " - press enter to continue")
                                Case French(2)
                                    Console.WriteLine("Translation = " & English(2) & " - press enter to continue")
                                Case French(3)
                                    Console.WriteLine("Translation = " & English(3) & " - press enter to continue")
                                Case French(4)
                                    Console.WriteLine("Translation = " & English(4) & " - press enter to continue")
                                Case French(5)
                                    Console.WriteLine("Translation = " & English(5) & " - press enter to continue")
                                Case French(6)
                                    Console.WriteLine("Translation = " & English(6) & " - press enter to continue")
                                Case French(7)
                                    Console.WriteLine("Translation = " & English(7) & " - press enter to continue")
                                Case French(8)
                                    Console.WriteLine("Translation = " & English(8) & " - press enter to continue")
                                Case Else 'if not match to input is found then...
                                    Console.WriteLine("Invalid input - press enter to continue!")
                                    runLoop = True 'return to menu
                            End Select
                        Catch ex As Exception
                            Console.WriteLine(ex.Message) 'display error directly as a printed line
                            runLoop = True 'return to menu
                        End Try
                    Case 3 'if "3" is entered
                        Console.Clear() 'clear console
                        runLoop = True 'return to menu
                        Console.WriteLine("Cleared! - Press enter to continue")
                    Case 4 'if "4" is entered
                        Console.WriteLine("----------------------")
                        Console.WriteLine("----------------------")
                        Console.WriteLine("--------Exiting-------")
                        Console.WriteLine("----------------------")
                        Console.WriteLine("----------------------")
                        Console.WriteLine("----------------------")
                        System.Threading.Thread.Sleep(4000) 'since user won't see 'exiting lines' added 4 second timer to add a "cinematic" feel before exit
                        End 'exit program
                    Case Else
                        Console.WriteLine("Invalid input - press enter to continue")
                        runLoop = True
                End Select
            Catch ex As Exception
                Console.WriteLine(ex.Message & " - press enter to continue") 'display error directly as a printed line
            End Try
            Console.ReadLine()
        End While
    End Sub
End Module
