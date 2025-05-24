using System;
using System.Collections.Generic;

public class AnecdoteManager
{
    private List<string> _userAnecdotes = new List<string>();

    public void CreateAnecdote()
    {
        string[] questions = {
            "Who did you talk to today?", 
            "What did you do today?", 
            "At what time during the day?", 
            "Where did this take place?", 
            "Did you help someone today?"
        };

        Random random = new Random();
        int randomNumber = random.Next(0, questions.Length);
        Console.WriteLine(questions[randomNumber]);

        string questionResponse = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        string fullAnecdote = $"{date} - {questions[randomNumber]} - {questionResponse}";
        _userAnecdotes.Add(fullAnecdote);

        Console.WriteLine("Anecdote saved!");
        ReadAllAnecdotes();
    }

    public void ReadAllAnecdotes()
    {
        Console.WriteLine("\nRegistered Anecdotes:");
        foreach (var anecdote in _userAnecdotes)
        {
            Console.WriteLine(anecdote);
        }
    }

    public List<string> GetAnecdotes()
    {
        return _userAnecdotes;
    }
}
