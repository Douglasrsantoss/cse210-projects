
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Activity{

    protected string _name;
    protected string _description;
    protected int _duration;
    

// Creating the Spinner:

    public void Spinner(int seconds)
    {
        //Testing the Spinner
        //int seconds = 10;
        
        List<string> animationList = new List<string>();
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationList[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationList.Count)
            {
                i = 0;
            }
        }
    }

// Creating the countdow:

    public void CountDown(int seconds)
    {
        int i = seconds;
        while (i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i--;
        }
        
    }

       public void CountDownWithTwo(int seconds)
    {
        int i = seconds;
        while (i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  ");

            i--;
        }
        
    }



    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
            //Converting from:
            // https://learn.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-8.0#system-convert-todouble(system-string)
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready...");
        Spinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.Write("Weldone!!");
        Console.WriteLine();
        Console.Write($"You have completed another {this._duration} seconds of the {this._name}.");
        Spinner(3);
    }
}
