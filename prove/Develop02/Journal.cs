using System.IO;
using System.Reflection.Metadata;

public class Journal
{
    public Constant string _fileName = "journal.txt";
    public List<Entry> newJournal = new List<Entry>();
    // refer to W01 prep for how to use date-time library.
    // Include a date-time string for each entry


    public void AddEntry(Entry entry)
    {
        newJournal.Add(entry);
        
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in newJournal)
        {
            Console.WriteLine(entry.GetEntry());
        }
    }
    public void SaveJournal(StreamWriter outputFile = new StreamWriter(_fileName))
    {
        
        outputFile.WriteLine();
    }
}