using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double double1 = GetValue("Enter first number: ");
            double double2 = GetValue("Enter second number: ");
            
            double result;

            while (true)
            {
                Console.Write("\nChoose add, subtract, multiply, or divide (Type A, S, M, or D) -> ");
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper()) {
                    case "A" :
                        result = Add(double1, double2);
                        break;
                    case "S" :
                        result = Subtract(double1, double2);
                        break;
                    case "M" :
                        result = Multiply(double1, double2);
                        break;
                    case "D" :
                        result = Divide(double1, double2);
                        break;
                    default :
                        Console.WriteLine("\n\nYou must choose an operation: (A) (S) (M) (D)");
                        continue;
                }
                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }
        }

        private static double GetValue(string label)
        {
            double value;
            while (true)
            {
                Console.Write(label);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else 
                {
                    Console.WriteLine("\nCannot be parsed. Please enter a number.\n");

                }

            }
        }
        private static double Add(double double1, double double2)
        {
            return double1 + double2;
        }
        private static double Subtract(double double1, double double2)
        {
            return double1 - double2;
        }
        private static double Multiply(double double1, double double2)
        {
            return double1 * double2;
        }
        private static double Divide(double double1, double double2)
        {
            return double1 / double2;
        }
    }
}
