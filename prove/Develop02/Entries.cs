public class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _newEntry;
    public string _finalEntry;

    
    public void WriteEntry()
    {
        DateTime currentTime = DateTime.Now;
        string _dateTime = currentTime.ToShortDateString();
        Console.WriteLine(_dateTime);

        Prompts _prompts = new Prompts();
        _prompts._MakePrompts();
        _prompt = _prompts._RandomPrompt();
        Console.WriteLine(_prompt);
        
        _newEntry = Console.ReadLine();

        _finalEntry = $"Date: {_dateTime} - Prompt: {_prompt} \n {_newEntry}";
    }

    public string GetEntry()
    {
        return _finalEntry;
    }
}