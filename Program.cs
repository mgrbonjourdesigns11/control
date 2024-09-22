using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            
            Console.Write("Enter the first number (or type 'exit' to quit): ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);
            if (!int.TryParse(input1, out number1) || !int.TryParse(input2, out number2))
            {
                Console.WriteLine("Please enter valid numbers.");
                continue; // Go back to the beginning of the loop
            }

            int sum = number1 + number2;
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
