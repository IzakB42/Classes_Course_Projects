using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _response;

    public Entry()
    {
        _dateTime = "";
        _prompt = "";
        _response = "";
    }
    public Entry(string date, string prompt, string response)
    {
        _dateTime = date;
        _prompt = prompt;
        _response = response;
    }

    public void WriteEntry()
    {
        SetDateTime();
        
        Prompts _prompts = new Prompts();
        _prompts._MakePrompts();
        _prompt = _prompts._RandomPrompt();
        Console.WriteLine(_prompt);

        _response = Console.ReadLine();
    }
    public void SetDateTime()
    {
        DateTime currentTime = DateTime.Now;
        _dateTime = currentTime.ToShortDateString();
    }

    public string ToFile()
    {
        SetDateTime();
        return $"{_dateTime}#{_prompt}#{_response}";
    }

    public string ToScreen()
    {
        SetDateTime();
        return $"Date: {_dateTime}\tPrompt: {_prompt}\nResponse: {_response}";
    }
}