using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }



    //This is the welcome message module:
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }



    //This is the User name message module:
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }


    //This is the User number message module:
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }



//This is the calculator module:
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }



//This it the display module
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}