using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }
    
    public void addEntry()
    {
        Entry e = new Entry();
        e.create();
        _entries.Add(e);
    }

    public void displayEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public List<Entry> getEntry()
    {
        return _entries;
    }

    public void choice()
    {

    }

}