using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
            
            //This condition is to NOT add number 0:
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Part 1:
        int sum = 0;
        foreach (int element in numbers)
        {
            sum += element;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2:
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Part 3:
        
        int max = numbers[0];

        foreach (int element in numbers)
        {
            // This is to find the max
            if (element > max)
            {
                max = element;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}