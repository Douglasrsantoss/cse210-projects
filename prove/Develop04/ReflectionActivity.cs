using System.Diagnostics.CodeAnalysis;

public class ReflectionActivity : Activity
{
    List<String> _prompts = new List<String>();
    List<string> _questions = new List<string>();


    public ReflectionActivity() : base()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resuilience. this will help you recognize the power you have and how you can use it in other aspects of your life.";
            
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you felt the Holy Spirit.");
            _prompts.Add("Think of a time when you preached the Gospel.");
            _prompts.Add("Think of a time when you was the aswer of someone's prayer.");
            _prompts.Add("Think of a time when you prayed and got aswered.");


            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What is you favorite thing about this experience?");
            _questions.Add("How can you help others with this experience?");
            _questions.Add("What can you learn about it?");
            _questions.Add("How you can keep this experiece in mind?");
            _questions.Add("What you did after this experience?");
    }

   public string getRandomPrompt(){
    Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index];
   }

   public string getRandomQuestion(){
    Random random = new Random();
       int index = random.Next(_questions.Count);
       return _questions[index];
   }
   public void Run(){
    int remainingDuration = base._duration;
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {getRandomPrompt()} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue...");
    Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    CountDown(5);
    Console.Clear();

    while (remainingDuration > 0)
    {
        Console.Write(getRandomQuestion());
        Spinner(10);
        Console.WriteLine();
        remainingDuration -= 10; 

        if (remainingDuration <= 0)
            break; 
    }

    DisplayEndMessage();

   }

}