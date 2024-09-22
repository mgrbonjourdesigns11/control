using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        // Convert inputs to integers
        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        // Calculate the sum
        int sum = number1 + number2;

        // Output the result
        Console.WriteLine("The sum is: " + sum);
    }
}
