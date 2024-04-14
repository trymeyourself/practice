using System;

namespace OperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OperationsApp!");

            double num1, num2;
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input for the first number!");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input for the second number!");
                return;
            }

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Modulus (%)");
            Console.WriteLine("6. Greater than (>)");
            Console.WriteLine("7. Less than (<)");
            Console.WriteLine("8. Equal to (==)");
            Console.WriteLine("9. Not equal to (!=)");
            Console.WriteLine("10. Greater than or equal to (>=)");
            Console.WriteLine("11. Less than or equal to (<=)");

            int operation;
            if (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 11)
            {
                Console.WriteLine("Invalid operation!");
                return;
            }

            string operationName = "";
            double result;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    operationName = "Addition";
                    break;
                case 2:
                    result = num1 - num2;
                    operationName = "Subtraction";
                    break;
                case 3:
                    result = num1 * num2;
                    operationName = "Multiplication";
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                        return;
                    }
                    result = num1 / num2;
                    operationName = "Division";
                    break;
                case 5:
                    result = num1 % num2;
                    operationName = "Modulus";
                    break;
                case 6:
                    result = num1 > num2 ? 1 : 0;
                    operationName = "Greater than";
                    break;
                case 7:
                    result = num1 < num2 ? 1 : 0;
                    operationName = "Less than";
                    break;
                case 8:
                    result = num1 == num2 ? 1 : 0;
                    operationName = "Equal to";
                    break;
                case 9:
                    result = num1 != num2 ? 1 : 0;
                    operationName = "Not equal to";
                    break;
                case 10:
                    result = num1 >= num2 ? 1 : 0;
                    operationName = "Greater than or equal to";
                    break;
                case 11:
                    result = num1 <= num2 ? 1 : 0;
                    operationName = "Less than or equal to";
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    return;
            }

            Console.WriteLine($"Result of {operationName}: {result}");
        }
    }
}
