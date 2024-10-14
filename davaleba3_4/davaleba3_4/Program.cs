using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba3_4
{
    class Program
    {
       Console.WriteLine("---------------Task 1---------------");
Console.WriteLine();
Console.Write("Enter a string: ");
string text = Console.ReadLine();
int vowels = 0;

foreach (var i in text.ToLower()) // Convert to lowercase to simplify comparison
{
    if ("aeiou".Contains(i)) // Use string.Contains for cleaner code
        vowels++;
}
Console.WriteLine("Number of vowels: " + vowels);
Console.WriteLine();

        }
    }
}
