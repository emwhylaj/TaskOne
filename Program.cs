using System;
using System.Collections.Generic;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {

            var listOfPmNewsPapers = new PmNewsPaper();
            var listOfGuardianNewsPaper = new GuardianNewsPaper();
            var listOfThePunchPapers = new ThePunchNewsPaper();
            var listOfSunPapers = new TheSunNewsPaper();
            Console.WriteLine("------------------Welcome to Newspaper Zone-----------------");
            Console.WriteLine($"The total sales for PMNews for all the weeks is : " + listOfPmNewsPapers.getSumTotalForAllWeeksPmNews());
            Console.WriteLine($"The average total sales for PMNews for all the weeks is : " + listOfPmNewsPapers.getAverageForPmNews());
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine($"The total sales for Guardian News paper for all the weeks is : " + listOfGuardianNewsPaper.getSumTotalForAllWeeksGuardian());
            Console.WriteLine($"The average total sales for Guardian paper for all the weeks is : " + listOfGuardianNewsPaper.getAverageForGuardian());
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine($"The total sales for Punch News paper for all the weeks is : " + listOfThePunchPapers.getSumTotalForAllWeeksPunch());
            Console.WriteLine($"The average total sales for Punch news paper for all the weeks is : " + listOfThePunchPapers.getAverageForPunchNews());
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine($"The total sales for Sun News paper for all the weeks is : " + listOfSunPapers.getSumTotalForAllWeeksSun());
            Console.WriteLine($"The average total sales for Sun news paper for all the weeks is : " + listOfSunPapers.getAverageForSunNews());
            Console.ReadLine();
        }
    }
}

