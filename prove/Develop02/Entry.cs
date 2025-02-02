
public class Entry
{
    public string _entry = "";
    public string _question = "";
    public string _date = "";

    public Entry()
    {

    }

    private string getDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    
    public void create()
    {
        _date = getDate();
        _question = new Question().getQuestion();
        Console.WriteLine(_question);
        _entry = Console.ReadLine();
    }

    public void createFromFile(string date, string question, string entry)
    {
        _date = date;
        _question = question;
        _entry = entry;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date}: {_question}");
        Console.WriteLine(_entry);
    }
    
    public void createFromList(string[] entryDetails)
    {
        _date  = entryDetails[0];
        _question  = entryDetails[1];
        _entry  = entryDetails[2];
    }
}

