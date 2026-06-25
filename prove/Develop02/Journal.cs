public class Journal
{
    public List<Entry> newJournal = new List<Entry>();
    // refer to W01 prep for how to use date-time library.
    // Include a date-time string for each entry


    public void AddEntry(Entry entry)
    {
        newJournal.Add(entry);
    }
}