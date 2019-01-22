using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyCalculator.Logic
{
    public class CalculatorLogic
    {
        private int minYear = 1;
        private int maxYear = 100;
     
        public int CalculatingCentury(int year)
        {
            int centuryCounter = 1;
            bool isInRange = false;
            if (1 <= year)
            {
                do
                {
                    if (minYear <= year && year <= maxYear)
                    {
                        isInRange = true;
                    }
                    else
                    {
                        minYear += 100;
                        maxYear += 100;
                        centuryCounter++;
                    }
                } while (!isInRange);
            }
            return centuryCounter;
        }
    }
}
