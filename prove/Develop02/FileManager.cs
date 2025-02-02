using System.IO;

public class FileManager
{
    public string _file = "journalfile.txt";

    public void writeFile(List<Entry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(_file))
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._question}|{entry._entry}");
            }
        }
    }
    
    public void loadFile(Journal j)
    {
        string[] lines = System.IO.File.ReadAllLines(_file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string question = parts[1];
            string entry = parts[2];

            Entry e = new Entry();
            e.createFromFile(date,question,entry);
            j._entries.Add(e);
        }
    }
}