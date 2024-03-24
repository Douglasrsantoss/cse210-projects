class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        base._name = "Breathing Activity";
        base._description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        int duration = base._duration;
        
        Console.Clear();
        while (duration > 0)
        {
            Console.Write("Breath IN...");
            CountDown(3);
            duration -= 3;
            Console.WriteLine();

            Console.Write("Breath OUT...");
            CountDown(6);
            duration -= 6;
            Console.WriteLine();

            Console.WriteLine();

            if (duration <= 0)
                break;
        }

        DisplayEndMessage();
    }
}