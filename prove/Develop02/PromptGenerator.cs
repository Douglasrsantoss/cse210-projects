using System.ComponentModel.Design;

public class PromptGenerator{
    //this generates a list and then fills it
  List<string> _prompts;
  public PromptGenerator()
  {
    //this is what will complete the list every time I need a new entry:
    _prompts = new List<string>();
    _prompts.Add("Who was the most interesting person I interacted with today?.");
    _prompts.Add("What was the best part of my day?");
    _prompts.Add("How did I see the hand of the Lord in my life today?");
    _prompts.Add("What was the strongest emotion I felt today?");
    _prompts.Add("If I had one thing I could do over today, what would it be?");
    _prompts.Add("What was the best thing that happened when you arrived at home?");
    _prompts.Add("How would you improve this very day if you had the chance?");

  }

    public string GetPrompt(){
        //This will generate a random number
        Random random = new Random();
        //and than, pick a random number from the 0 up to the total number of entries in the list
        int randomPrompt = random.Next(0, _prompts.Count);
        //this will return the prompt the is equal to the random number in the list
        return _prompts[randomPrompt];
    }
}