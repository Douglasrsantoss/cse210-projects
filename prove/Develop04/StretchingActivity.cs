using System.Security.Cryptography.X509Certificates;

class StretchingActivity : Activity
{
    public StretchingActivity() : base()
    {
        _name = "Stretching Activity";
        _description = "This activity may help you to relax a little while stretching the main parts of your body";
        
    }

    public void Run()
    {
        Console.WriteLine();
        string message = "Stand up and get ready...";
        Console.Write(message);
        CountDown(5);

        Console.Clear();
        Console.Write("Put your right hand in your head and pull it down to the right gently for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Put your left hand in your head and pull it down to the left gently for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Put both of your hands in your head and pull it down forward gently for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Rotate you sholders clockwise for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Rotate you sholders counter-clockwise for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Grab you left foot with your right hand and pull it up to your back for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        Console.Write("Grab you right foot with your left hand and pull it up to your back for: ");
        Spinner(5);
        CountDownWithTwo(_duration);
        Console.WriteLine();

        DisplayEndMessage();

    }
}