
using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a scripture instance
        Scripture scripture = new Scripture();
        scripture.Text("Trust in the Lord with all thine heart; and lean not unto thine cown dunderstanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        bool allHidden = false;
        int hiddenWordCount = 1;

        while (!allHidden)
        {
            // Display the scripture
            Console.Clear();
            scripture.Display();

            // Prompt the user
            Console.WriteLine("Press Enter to continue, or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide random words
            scripture.HideRandomWords(hiddenWordCount);
            hiddenWordCount++;

            // Check if all words are hidden
            allHidden = scripture.isCompletelyHidden();
        }
        Console.Clear();
        scripture.Display();
        //Console.WriteLine(hiddenWordCount);
    }
}
