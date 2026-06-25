public class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _newEntry;

    public Entry()
    {
        _dateTime = "";

        // can run/create the datetime variable here or in the WriteEntry method.
    }
    
    public void WriteEntry()
    {
        // Start with datetime.now code

        Prompts _prompts = new Prompts();
        _prompts._MakePrompts();
        _prompt = _prompts._RandomPrompt();
        Console.WriteLine(_prompt);
        

        _newEntry = Console.ReadLine();
    }
}