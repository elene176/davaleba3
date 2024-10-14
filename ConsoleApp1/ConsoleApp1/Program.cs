using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables
            double num1, num2;

            // Input values for the variables
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perform arithmetic operations
            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num2 != 0 ? num1 / num2 : double.NaN; // Avoid division by zero
            double balance = num1 - num2; // Balance operation can be interpreted as subtraction

            // Print the results to the console
            Console.WriteLine($"Addition: {num1} + {num2} = {addition}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {subtraction}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
            Console.WriteLine(num2 != 0 ? $"Division: {num1} / {num2} = {division}" : "Division: Cannot divide by zero.");
            Console.WriteLine($"Balance (Subtraction): {num1} - {num2} = {balance}");
            Console.WriteLine("//===========================================");
            Console.ReadLine();
            // Create variables with types float, double, and decimal
            float floatValue = (float)(1.0 / 7.0);
            double doubleValue = 1.0 / 7.0;
            decimal decimalValue = 1.0m / 7.0m;

            // Multiply each variable by 7
            float floatResult = floatValue * 7;
            double doubleResult = doubleValue * 7;
            decimal decimalResult = decimalValue * 7;

            // Print the results
            Console.WriteLine($"Float Result: {floatResult}");
            Console.WriteLine($"Double Result: {doubleResult}");
            Console.WriteLine($"Decimal Result: {decimalResult}");

            // Compare precision
            Console.WriteLine("\nComparison of precision:");
            Console.WriteLine($"Expected Value: {1.0}");
            Console.WriteLine($"Float Difference: {Math.Abs(floatResult - 1.0)}");
            Console.WriteLine($"Double Difference: {Math.Abs(doubleResult - 1.0)}");
            Console.WriteLine($"Decimal Difference: {Math.Abs(floatResult - 1.0)}"); ;
            Console.WriteLine("//===========================================");
            Console.ReadLine();
            // Declare and assign values to different types
            int intValue = 42;
            double doubleValue1 = 3.14;
            float floatValue1 = 2.718f;
            decimal decimalValue1 = 1.618m;

            // Implicit conversions (where applicable)
            // int -> double
            double fromIntToDouble = intValue; // Implicit conversion
            Console.WriteLine($"Implicit conversion from int to double: {fromIntToDouble}");

            // float -> double
            double fromFloatToDouble = floatValue1; // Implicit conversion
            Console.WriteLine($"Implicit conversion from float to double: {fromFloatToDouble}");

            // decimal -> double (not implicit; requires explicit conversion)
            double fromDecimalToDouble = (double)decimalValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from decimal to double: {fromDecimalToDouble}");

            // Explicit conversions (when necessary)
            // double -> int
            int fromDoubleToInt = (int)doubleValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from double to int: {fromDoubleToInt}");

            // double -> float
            float fromDoubleToFloat = (float)doubleValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from double to float: {fromDoubleToFloat}");

            // decimal -> float (explicit conversion)
            float fromDecimalToFloat = (float)decimalValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from decimal to float: {fromDecimalToFloat}");

            // decimal -> int (explicit conversion)
            int fromDecimalToInt = (int)decimalValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from decimal to int: {fromDecimalToInt}");

            // float -> int (explicit conversion)
            int fromFloatToInt = (int)floatValue1; // Explicit conversion
            Console.WriteLine($"Explicit conversion from float to int: {fromFloatToInt}");
            Console.WriteLine("//===========================================");
            Console.ReadLine();
        }
    }
}
