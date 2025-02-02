using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        FileManager f = new FileManager();
        int _userInput = 0;
        string _userQuitInput = "";
        while (_userInput != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Create New Journal Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string inputStr = Console.ReadLine();
            _userInput = int.Parse(inputStr);
            //Console.WriteLine(input);

            if(_userInput == 1)
                {
                    j.addEntry();
                }

            else if (_userInput == 2)
                {
                    Console.WriteLine();
                    j.displayEntries();

                }

            else if (_userInput == 3)
                {
                    f.loadFile(j);
                    Console.WriteLine();
                    Console.WriteLine("Journal loaded, select 2.Display to see entries");
                    Console.WriteLine();
                }

            else if (_userInput == 4)
                    {
                        f.writeFile(j.getEntry());
                        Console.WriteLine();
                        Console.WriteLine("Journal Saved");
                        Console.WriteLine();
                    }
                    
            else if (_userInput == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to save before quitting? (Yes/No)");

                    _userQuitInput = Console.ReadLine();

                    if (_userQuitInput == "Yes")
                    {
                        f.writeFile(j.getEntry());
                        Console.WriteLine();
                        Console.WriteLine("Journal Saved");
                        Console.WriteLine();
                    }
                    else if(_userQuitInput == "No")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Have a nice day.");
                        Console.WriteLine();
                    }    
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid entry please enter Yes or No (Response is case sensitive)");
                        Console.WriteLine();
                        _userInput = 6;
                    }
                    
                }
            else 
                {
                Console.WriteLine();
                Console.WriteLine("Invalid entry please enter a nummber between 1-5.");
                }
        }
    }
}