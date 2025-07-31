using System;

class Program
{
    static void Main()
    {
        while (true)
        {
        Console.WriteLine("Enter number 1:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2:");
        double b = Convert.ToDouble(Console.ReadLine());

        
            Console.WriteLine("Enter operator (+, -, *, /) or 'q' to quit:");
            string op = Console.ReadLine();

            if (op == "q" || op == "Q")
            {
                Console.WriteLine("You exited the calculator.");
                break; 
            }

            double result;

            if (op == "+")
            {
                result = a + b;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "-")
            {
                result = a - b;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "*")
            {
                result = a * b;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Division by 0 is prohibited.");
                }
                else
                {
                    result = a / b;
                    Console.WriteLine("Result: " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }
        }
    }
}