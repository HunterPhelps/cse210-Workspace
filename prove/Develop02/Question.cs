using System;

public class Question
{
    public List<string> _questions = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };

    public Question()
    {

    }

    public string getQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
    
}