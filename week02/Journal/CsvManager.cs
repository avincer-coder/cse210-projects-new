using System;
using System.Collections.Generic;
using System.IO;

public class CsvManager
{
    // public void SaveToCsv(List<string> anecdotes)
    // {
    //     using (StreamWriter writer = new StreamWriter("Anecdotes.csv", true))
    //     {
    //         foreach (string anecdote in anecdotes)
    //         {
    //             writer.WriteLine(anecdote);
    //         }
    //     }
    //     Console.WriteLine("Anecdotes saved to file.");
    // }
    public void SaveToCsv(List<string> anecdotes)
    {
        Console.Write("Enter the name of the file to save (without extension or with .csv): ");
        string fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name. Using default name: Anecdotes.csv");
            fileName = "Anecdotes.csv";
        }
        else if (!fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
        {
            fileName += ".csv";
        }

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            foreach (string anecdote in anecdotes)
            {
                writer.WriteLine(anecdote);
            }
        }

        Console.WriteLine($"Anecdotes saved to file: {fileName}");
    }


    // public void LoadFromCsv()
    // {
    //     if (File.Exists("Anecdotes.csv"))
    //     {
    //         Console.WriteLine("\nAnecdotes in file:");
    //         using (StreamReader reader = new StreamReader("Anecdotes.csv"))
    //         {
    //             string line;
    //             while ((line = reader.ReadLine()) != null)
    //             {
    //                 Console.WriteLine(line);
    //             }
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No CSV file found.");
    //     }
    // }
    public void LoadFromCsv()
{
    Console.Write("Enter the name of the file to load (without extension or with .csv): ");
    string fileName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(fileName))
    {
        Console.WriteLine("Invalid file name.");
        return;
    }

    if (!fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
    {
        fileName += ".csv";
    }

    if (File.Exists(fileName))
    {
        Console.WriteLine($"\nAnecdotes in file: {fileName}");
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    else
    {
        Console.WriteLine($"File '{fileName}' not found.");
    }
}

}
