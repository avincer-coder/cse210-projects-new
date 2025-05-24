using System;

public class Menu
{
    public void Show()
    {
        Console.WriteLine("\nMain Menu - Choose an option:");
        Console.WriteLine("1. Write a new daily event");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit program");
    }
}
