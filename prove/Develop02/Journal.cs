using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Journal
{
    public List<Entry> newJournal = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        newJournal.Add(entry);
        
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in newJournal)
        {
            Console.WriteLine(entry.ToScreen());
        }
    }
    public void ReadFiles(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry displayE = new Entry(date, prompt, response);
            Console.WriteLine(displayE.ToScreen());
        }
    }
    public void SaveJournal(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in newJournal)
            {
                outputFile.WriteLine(entry.ToFile());
            }
        }
    }
}