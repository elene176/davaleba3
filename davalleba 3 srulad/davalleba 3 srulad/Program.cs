using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davalleba_3_srulad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string inputText = Console.ReadLine();
            int vowelCount = 0;

            foreach (char letter in inputText.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Total number of vowels: " + vowelCount);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Please enter a number between 1 and 10: ");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());

            if (chosenNumber >= 1 && chosenNumber <= 10)
            {
                Console.WriteLine($"Multiplication table for {chosenNumber}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{chosenNumber} x {i} = {chosenNumber * i}");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number between 1 and 10.");
            }
            Console.WriteLine("-----------------------------------------------------------------");
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int[,] resultMatrix = new int[3, 3];

            Console.WriteLine("Please enter the values for the first matrix (3x3), row by row:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for matrix1[{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Now, enter the values for the second matrix (3x3), row by row:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for matrix2[{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("The resulting matrix after adding the two matrices is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------");
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Please select an option (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Enter the first number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Result of addition: {number1 + number2}");
                            break;
                        case 2:
                            Console.WriteLine($"Result of subtraction: {number1 - number2}");
                            break;
                        case 3:
                            Console.WriteLine($"Result of multiplication: {number1 * number2}");
                            break;
                        case 4:
                            // Prevent division by zero
                            if (number2 != 0)
                            {
                                Console.WriteLine($"Result of division: {number1 / number2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                            }
                            break;
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator...");
                    continueRunning = false;
                }
                else
                {
                    Console.WriteLine("Error: Please select a valid option (1-5).");
                }
            }
            Console.ReadKey();
        }
    }
}
