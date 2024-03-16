public class Entry{
    
    public Entry(){
        _date = DateTime.Now;
    }
    


    //those are just the entries we receive from the PromptGenerator and 
    //the Entry + the date we put here above
    public string _prompt {get; set;}
    public DateTime _date {get; set;}
    public string _entryText {get; set;}
    public void displayPrompt(){
        Console.WriteLine(_prompt);
    }



    //this part displays the entries
    public void displayEntry(){
        
        string dateText = _date.ToString();
        Console.WriteLine($"Date: {dateText} - Prompt: {_prompt}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}