//Angel ambiorix liriano soto 2026-0976
try
{
    List<decimal> typedNumbers = new List<decimal>();
    bool running = true;
    Console.WriteLine("---WELCOME TO MY PROJECT---");

    while (running)
    {
        Console.WriteLine("1: THE CALCULATOR");
        Console.WriteLine("2: GRADE VERIFICATION");
        Console.WriteLine("3: EXIT");
        Console.WriteLine("---SELECT AN OPTION---");
        int mainOption;

        while (!int.TryParse(Console.ReadLine()!, out mainOption) || mainOption < 1 || mainOption > 3)
        {
            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
        }

        switch (mainOption)
        {
            case 1:
                {
                    Console.WriteLine("---CALCULATOR MENU---");
                    Console.WriteLine("1: ADDITION");
                    Console.WriteLine("2: SUBTRACTION");
                    Console.WriteLine("3: MULTIPLICATION");
                    Console.WriteLine("4: DIVISION");
                    Console.WriteLine("5: BACK");
                    Console.WriteLine("---SELECT AN OPTION---");
                    int option;

                    while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option > 5)
                    {
                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                    }

                    switch (option)
                    {
                        case 1: // ADDITION
                            {
                                typedNumbers.Clear();
                                Console.WriteLine("--- ADDITION ---");

                                for (int i = 1; i <= 2; i++)
                                {
                                    Console.WriteLine($"ENTER NUMBER {i}:");
                                    decimal num;
                                    while (!decimal.TryParse(Console.ReadLine()!, out num))
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                    }
                                    typedNumbers.Add(num);
                                }

                                bool keepAdding = true;
                                while (keepAdding)
                                {
                                    Console.WriteLine("DO YOU WANT TO ADD ANOTHER NUMBER? (YES OR NO)");
                                    string answer = Console.ReadLine()!.Trim().ToLower();

                                    while (answer != "yes" && answer != "no")
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        answer = Console.ReadLine()!.Trim().ToLower();
                                    }

                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"ENTER NUMBER {typedNumbers.Count + 1}:");
                                        decimal extraNum;
                                        while (!decimal.TryParse(Console.ReadLine()!, out extraNum))
                                        {
                                            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        }
                                        typedNumbers.Add(extraNum);
                                    }
                                    else
                                    {
                                        keepAdding = false;
                                    }
                                }

                                decimal addition = 0;
                                foreach (decimal number in typedNumbers)
                                {
                                    addition += number;
                                }
                                Console.WriteLine($"THE RESULT OF THE ADDITION IS: {addition}");
                            }
                        break;

                        case 2: // SUBTRACTION
                            {
                                typedNumbers.Clear();
                                Console.WriteLine("--- SUBTRACTION ---");

                                for (int i = 1; i <= 2; i++)
                                {
                                    Console.WriteLine($"ENTER NUMBER {i}:");
                                    decimal num;
                                    while (!decimal.TryParse(Console.ReadLine()!, out num))
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                    }
                                    typedNumbers.Add(num);
                                }

                                bool keepAdding = true;
                                while (keepAdding)
                                {
                                    Console.WriteLine("DO YOU WANT TO ADD ANOTHER NUMBER? (YES OR NO)");
                                    string answer = Console.ReadLine()!.Trim().ToLower();

                                    while (answer != "yes" && answer != "no")
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        answer = Console.ReadLine()!.Trim().ToLower();
                                    }

                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"ENTER NUMBER {typedNumbers.Count + 1}:");
                                        decimal extraNum;
                                        while (!decimal.TryParse(Console.ReadLine()!, out extraNum))
                                        {
                                            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        }
                                        typedNumbers.Add(extraNum);
                                    }
                                    else
                                    {
                                        keepAdding = false;
                                    }
                                }

                                decimal subtraction = typedNumbers[0];
                                for (int i = 1; i < typedNumbers.Count; i++)
                                {
                                    subtraction -= typedNumbers[i];
                                }
                                Console.WriteLine($"THE RESULT OF THE SUBTRACTION IS: {subtraction}");
                            }
                        break;

                        case 3: // MULTIPLICATION
                            {
                                typedNumbers.Clear();
                                Console.WriteLine("--- MULTIPLICATION ---");

                                for (int i = 1; i <= 2; i++)
                                {
                                    Console.WriteLine($"ENTER NUMBER {i}:");
                                    decimal num;
                                    while (!decimal.TryParse(Console.ReadLine()!, out num))
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                    }
                                    typedNumbers.Add(num);
                                }

                                bool keepAdding = true;
                                while (keepAdding)
                                {
                                    Console.WriteLine("DO YOU WANT TO ADD ANOTHER NUMBER? (YES OR NO)");
                                    string answer = Console.ReadLine()!.Trim().ToLower();

                                    while (answer != "yes" && answer != "no")
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        answer = Console.ReadLine()!.Trim().ToLower();
                                    }

                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"ENTER NUMBER {typedNumbers.Count + 1}:");
                                        decimal extraNum;
                                        while (!decimal.TryParse(Console.ReadLine()!, out extraNum))
                                        {
                                            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        }
                                        typedNumbers.Add(extraNum);
                                    }
                                    else
                                    {
                                        keepAdding = false;
                                    }
                                }

                                decimal multiplication = 1;
                                foreach (decimal number in typedNumbers)
                                {
                                    multiplication *= number;
                                }
                                Console.WriteLine($"THE RESULT OF THE MULTIPLICATION IS: {multiplication}");
                            }
                        break;

                        case 4: // DIVISION
                            {
                                typedNumbers.Clear();
                                Console.WriteLine("--- DIVISION ---");

                                for (int i = 1; i <= 2; i++)
                                {
                                    Console.WriteLine($"ENTER NUMBER {i}:");
                                    decimal num;

                                    while (!decimal.TryParse(Console.ReadLine()!, out num) || (i == 2 && num == 0))
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                    }
                                    typedNumbers.Add(num);
                                }

                                bool keepAdding = true;
                                while (keepAdding)
                                {
                                    Console.WriteLine("DO YOU WANT TO ADD ANOTHER NUMBER? (YES OR NO)");
                                    string answer = Console.ReadLine()!.Trim().ToLower();

                                    while (answer != "yes" && answer != "no")
                                    {
                                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        answer = Console.ReadLine()!.Trim().ToLower();
                                    }

                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"ENTER NUMBER {typedNumbers.Count + 1}:");
                                        decimal extraNum;

                                        while (!decimal.TryParse(Console.ReadLine()!, out extraNum) || extraNum == 0)
                                        {
                                            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                                        }
                                        typedNumbers.Add(extraNum);
                                    }
                                    else
                                    {
                                        keepAdding = false;
                                    }
                                }

                                decimal division = typedNumbers[0];
                                for (int i = 1; i < typedNumbers.Count; i++)
                                {
                                    division /= typedNumbers[i];
                                }
                                Console.WriteLine($"THE RESULT OF THE DIVISION IS: {division}");
                            }
                        break;

                        case 5:
                            {
                                // BACK
                            }
                        break;
                    }
                }
            break;

            case 2: // GRADE VERIFICATION
                {
                    typedNumbers.Clear();

                    Console.WriteLine("--- GRADE VERIFICATION ---");
                    Console.WriteLine("HOW MANY GRADES DO YOU WANT TO ENTER?");
                    int quantity;

                    while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 1)
                    {
                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                    }

                    for (int i = 1; i <= quantity; i++)
                    {
                        Console.WriteLine($"ENTER GRADE {i}:");

                        decimal actualGrade;

                        while (!decimal.TryParse(Console.ReadLine()!, out actualGrade) || actualGrade < 0 || actualGrade > 100)
                        {
                            Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                        }

                        typedNumbers.Add(actualGrade);
                    }

                    decimal sumGrades = 0;
                    foreach (decimal number in typedNumbers)
                    {
                        sumGrades += number;
                    }

                    decimal gradePointAverage = sumGrades / quantity;

                    Console.WriteLine($"THE GRADE POINT AVERAGE IS: {gradePointAverage:F2}");

                    if (gradePointAverage >= 90)
                    {
                        Console.WriteLine("YOU PASSED. EXCELLENT!");
                    }
                    else if (gradePointAverage >= 80)
                    {
                        Console.WriteLine("YOU PASSED. VERY GOOD!");
                    }
                    else if (gradePointAverage >= 70)
                    {
                        Console.WriteLine("YOU PASSED. GOOD JOB!");
                    }
                    else
                    {
                        Console.WriteLine("YOU FAILED. KEEP TRYING.");
                    }
                }
            break;

            case 3: // EXIT
                {
                    Console.WriteLine("ARE YOU SURE YOU WANT TO EXIT? (YES OR NO)");
                    string answer = Console.ReadLine()!.Trim().ToLower();

                    while (answer != "yes" && answer != "no")
                    {
                        Console.WriteLine("INVALID OPTION. PLEASE ENTER A VALID OPTION");
                        answer = Console.ReadLine()!.Trim().ToLower();
                    }

                    if (answer == "yes")
                    {
                        Console.WriteLine("THANK YOU FOR USING THE PROGRAM!\nTHE PROGRAM HAS ENDED.");
                        running = false;
                    }
                }
            break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine("The program could not be completed.");
}