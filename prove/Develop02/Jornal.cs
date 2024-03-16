using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _journalList = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public Journal()
    {
        
    }

    public void Save()
    {
        //This will save the file with the chosen name
        Console.Write("Enter filename to save: ");
        string fileName = Console.ReadLine();

        //As shown in the video tutorial, we add "using" so the file closes after usage
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //to save in a json format
            string json = JsonSerializer.Serialize(_journalList);
            //store the filename with "json" in the end
            outputFile.WriteLine(json);
            outputFile.Close();
        }

    }

    public void Load()
    {
        // this asks you what is the namen of the file you'd like to open
        Console.Write("Enter filename to load: ");
        string fileName = Console.ReadLine();

        //read the "json" file
        string json = File.ReadAllText(fileName);

        //turn json into object again
        _journalList = JsonSerializer.Deserialize<List<Entry>>(json);


    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry._prompt = _promptGenerator.GetPrompt();
        entry.displayPrompt();
        Console.Write(">>> ");
        entry._entryText = Console.ReadLine();
        _journalList.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _journalList)
        {
            entry.displayEntry();
        }
    }
}