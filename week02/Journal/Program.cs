using System;
public class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        AnecdoteManager anecdoteManager = new AnecdoteManager();
        CsvManager csvManager = new CsvManager();

        while (true)
        {
            menu.Show();
            string input = Console.ReadLine();

            if (input == "1")
            {
                anecdoteManager.CreateAnecdote();
            }
            else if (input == "2")
            {
                anecdoteManager.ReadAllAnecdotes();
            }
            else if (input == "3")
            {
                csvManager.SaveToCsv(anecdoteManager.GetAnecdotes());
            }
            else if (input == "4")
            {
                csvManager.LoadFromCsv();
            }
            else if (input == "5")
            {
                Console.WriteLine("Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}