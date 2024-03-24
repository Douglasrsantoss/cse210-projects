using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        while(true){
            string menu = "Menu Options:";
            Console.Clear();
            Console.WriteLine(menu);
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start stretching activity");
            Console.WriteLine("5. Exit");
            Console.Write("Select a choice from the Menu: ");
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndMessage();
                    break;
                case "2":
                    ReflectionActivity reflextion = new ReflectionActivity();
                    reflextion.DisplayStartingMessage();
                    reflextion.Run();
                    reflextion.DisplayEndMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndMessage();
                    break;
                case "4":
                    StretchingActivity stretch = new StretchingActivity();
                    stretch.DisplayStartingMessage();
                    stretch.Run();
                    stretch.DisplayEndMessage();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    break;
            }
        }
    }
}
