
public class ListingActivity : Activity
{
    List<String> _prompts = new List<String>();


    public ListingActivity() : base()
    {
            _name = "Listing Activity";
            _description = "This activity will help you  reflect on the good things in your life by having you list as many things as you can in a certain area.";
           
            _prompts.Add("When have you felt the Holy Ghost in this month?");
            _prompts.Add("When have you helped someone this week?");
            _prompts.Add("What have you done to help others this week?");
            _prompts.Add("What are the things you are grateful for?");
            _prompts.Add("What were your challenges last week?");
            _prompts.Add("Who helped you with something today?");

    }

   public string getRandomPrompt(){
    Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index];
   }


   public void Run(){
    int remainingDuration = base._duration;
    Console.WriteLine("List as many responses as you can to the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"-- {getRandomPrompt()} --");
    Console.WriteLine();
    Console.Write("Beginning in...");
    CountDown(5);
    Console.WriteLine();
    Console.WriteLine();
    
    DateTime currentTime = DateTime.Now;
    DateTime targetTime = currentTime.AddSeconds(_duration);
    int count = 0;
    while (targetTime  > currentTime)
    {
        Console.Write(">");
        Console.ReadLine();
        currentTime = DateTime.Now;
        count++;
    }
    Console.Write($"You listed {count} items!");
    Spinner(5);

    DisplayEndMessage();

   }
    
}
