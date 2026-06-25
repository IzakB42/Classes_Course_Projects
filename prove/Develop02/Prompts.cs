public class Prompts
{
    string _textPrompts = "Text_Prompts.txt";

    List<string> prompt_list = new List<string>();

    public void _MakePrompts()
    {
        string[] lines = System.IO.File.ReadAllLines(_textPrompts);
        foreach (string prompt in lines)
        {
            prompt_list.Add(prompt);
        }
    }
    public string _RandomPrompt()
    {
        // Get random prompt from list
        return "placeholder prompt";
    }
}
