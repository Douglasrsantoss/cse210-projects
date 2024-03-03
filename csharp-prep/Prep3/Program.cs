using System;

class Program
{
    static void Main(string[] args)
    {
        // For specified the number:

        // Console.Write("What is the magic number? ");
        // int magicalNumber = int.Parse(Console.ReadLine());
        
        //-------------------------

        // For a random number:

        Random randomGenerator = new Random();
        int magicalNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicalNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicalNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicalNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }            
    }
}