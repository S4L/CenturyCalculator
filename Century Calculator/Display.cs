using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyCalculator.UI
{
    internal static class Display
    {
        public static void ShowWelcomeText()
        {
            Console.WriteLine("-------------Welcome to Century Calculator-------------");
            Console.WriteLine("This simple calculator will tell you the century");
        }

        public static int GetYearInput()
        {
            Console.WriteLine("Please type in year: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void ShowResult(int result)
        {
            Console.WriteLine($"This year belongs in: {result} century");
        }
    }
}
