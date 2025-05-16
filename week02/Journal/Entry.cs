using System.Text.Json.Serialization;

public class Entry
{
    [JsonInclude]
    public string _date;
    [JsonInclude]
    public string _promptText;
    [JsonInclude]
    public string _entryText;

    public Entry() { }

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} prompt: {_promptText}");
        Console.WriteLine($"> {_entryText}");
    }


}