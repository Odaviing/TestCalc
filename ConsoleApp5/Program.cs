using System;

namespace ConsoleApp5
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string str_first = Console.ReadLine();
            double first, second;
            if(!Double.TryParse(str_first, out first))
            {
                throw new ArgumentException("You must enter a number");
            }
            //first = Convert.ToDouble(str_first);

            Console.WriteLine("Input second number");
            string str_second = Console.ReadLine();
            if (!Double.TryParse(str_second, out second))
            {
                throw new ArgumentException("You must enter a number");
            }
            //second = Convert.ToDouble(str_second);

            Console.WriteLine("Choose the operation:\n 1. Sum\n 2. Subtract\n 3. Multiply\n 4. Divide\n 5. Square");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Calculator.Sum(first, second);
                    break;
                case "2":
                    Calculator.Subtract(first, second);
                    break;
                case "3":
                    Calculator.Mult(first, second);
                    break;
                case "4":
                    Calculator.Divide(first, second);
                    break;
                case "5":
                    Calculator.Square(first);
                    break;
                default:
                    throw new Exception("Incorrect option was chosen");
                    

            }

        }
    }
}
