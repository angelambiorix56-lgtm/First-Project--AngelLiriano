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
                    }
                }
        }break;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine("The program could not be completed.");
}