using CenturyCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyCalculator.UI
{
    static class Program
    { 
        private static void Main(string[] args)
        {
            var calculator = new CalculatorLogic();

            Display.ShowWelcomeText();

            var yearInput = Display.GetYearInput();
            
            var result = calculator.CalculatingCentury(yearInput);

            Display.ShowResult(result);

            Console.ReadKey();
        }
    }
}
