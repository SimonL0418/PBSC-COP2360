using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers to perform division:");

        try
        {
            Console.Write("Enter the first number: ");
            string dig1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string dig2 = Console.ReadLine();

            int num1 = Convert.ToInt32(dig1);
            int num2 = Convert.ToInt32(dig2);

            int result = Divide(num1, num2);

            Console.WriteLine($"Answer: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter valid integers.");
            Console.WriteLine($"Please enter Arabic numerals in the base 10 system.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed. The second number cannot be zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number is too large or too small for an integer.");
            Console.WriteLine($"Keep integers between the values -2147483648 and 2147483647.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: How did we get here?");
        }
    }

    static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}
