using System.IO;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Entry CreateNewEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string randomPrompt = prompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.Write("> ");
        string text = Console.ReadLine();

        string date = DateTime.Now.ToString();

        Entry newEntry = new Entry(date, randomPrompt, text);
        return newEntry;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                foreach (var entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }

    }

    public void SaveAsJson()
    {
    Console.Write("What is the filename: ");
    string filename = Console.ReadLine();
    string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filename, json);
    Console.WriteLine($"Journal saved as JSON.");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                string date = parts[0];
                string prompt = parts[1];
                string text = parts[2];

                Entry newEntry = new Entry(date, prompt, text);
                _entries.Add(newEntry);
            }
            Console.WriteLine();
            DisplayAll();
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void LoadFromJson()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            
            Console.WriteLine($"Journal loaded from JSON.");
            DisplayAll();
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}